using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;

namespace System
{
	// Token: 0x02000083 RID: 131
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class Exception : ISerializable
	{
		// Token: 0x0600040D RID: 1037 RVA: 0x0000F588 File Offset: 0x0000D788
		internal static uint GetExceptionCount()
		{
			return (uint)EventPipeInternal.GetRuntimeCounterValue(EventPipeInternal.RuntimeCounters.EXCEPTION_COUNT);
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600040E RID: 1038 RVA: 0x0000F591 File Offset: 0x0000D791
		private bool HasBeenThrown
		{
			get
			{
				return this._traceIPs != null;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600040F RID: 1039 RVA: 0x0000F59C File Offset: 0x0000D79C
		public MethodBase TargetSite
		{
			[RequiresUnreferencedCode("Metadata for the method might be incomplete or removed")]
			get
			{
				StackTrace stackTrace = new StackTrace(this, true);
				if (stackTrace.FrameCount <= 0)
				{
					return null;
				}
				StackFrame frame = stackTrace.GetFrame(0);
				if (frame == null)
				{
					return null;
				}
				return frame.GetMethod();
			}
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x0000F5D0 File Offset: 0x0000D7D0
		internal Exception.DispatchState CaptureDispatchState()
		{
			MonoStackFrame[] array2;
			if (this._traceIPs != null)
			{
				Exception ex = this;
				MonoStackFrame[] array = null;
				System.Diagnostics.StackTrace.GetTrace(ObjectHandleOnStack.Create<Exception>(ref ex), ObjectHandleOnStack.Create<MonoStackFrame[]>(ref array), 0, true);
				array2 = array;
				if (array2.Length != 0)
				{
					array2[array2.Length - 1].isLastFrameFromForeignException = true;
				}
				MonoStackFrame[] array3 = this.foreignExceptionsFrames;
				if (array3 != null)
				{
					MonoStackFrame[] array4 = new MonoStackFrame[array2.Length + array3.Length];
					Array.Copy(array3, 0, array4, 0, array3.Length);
					Array.Copy(array2, 0, array4, array3.Length, array2.Length);
					array2 = array4;
				}
			}
			else
			{
				array2 = this.foreignExceptionsFrames;
			}
			return new Exception.DispatchState(array2);
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x0000F657 File Offset: 0x0000D857
		internal void RestoreDispatchState(in Exception.DispatchState state)
		{
			this.foreignExceptionsFrames = state.StackFrames;
			this._stackTraceString = null;
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x0000F66C File Offset: 0x0000D86C
		private bool CanSetRemoteStackTrace()
		{
			if (this._traceIPs != null || this._stackTraceString != null || this._remoteStackTraceString != null)
			{
				ThrowHelper.ThrowInvalidOperationException();
			}
			return true;
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x0000F68C File Offset: 0x0000D88C
		private static ListDictionaryInternal CreateDataContainer()
		{
			return new ListDictionaryInternal();
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x0000F693 File Offset: 0x0000D893
		public Exception()
		{
			this._HResult = -2146233088;
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x0000F6A6 File Offset: 0x0000D8A6
		public Exception(string message) : this()
		{
			this._message = message;
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x0000F6B5 File Offset: 0x0000D8B5
		public Exception(string message, Exception innerException) : this()
		{
			this._message = message;
			this._innerException = innerException;
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x0000F6CC File Offset: 0x0000D8CC
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected Exception(SerializationInfo info, StreamingContext context)
		{
			ArgumentNullException.ThrowIfNull(info, "info");
			this._message = info.GetString("Message");
			this._data = (IDictionary)info.GetValueNoThrow("Data", typeof(IDictionary));
			this._innerException = (Exception)info.GetValue("InnerException", typeof(Exception));
			this._helpURL = info.GetString("HelpURL");
			this._stackTraceString = info.GetString("StackTraceString");
			this._remoteStackTraceString = info.GetString("RemoteStackTraceString");
			this._HResult = info.GetInt32("HResult");
			this._source = info.GetString("Source");
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000418 RID: 1048 RVA: 0x0000F790 File Offset: 0x0000D990
		[Nullable(1)]
		public virtual string Message
		{
			[NullableContext(1)]
			get
			{
				return this._message ?? SR.Format(SR.Exception_WasThrown, this.GetClassName());
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000419 RID: 1049 RVA: 0x0000F7AC File Offset: 0x0000D9AC
		[Nullable(1)]
		public virtual IDictionary Data
		{
			[NullableContext(1)]
			get
			{
				IDictionary result;
				if ((result = this._data) == null)
				{
					result = (this._data = Exception.CreateDataContainer());
				}
				return result;
			}
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x0000F7D1 File Offset: 0x0000D9D1
		private string GetClassName()
		{
			return this.GetType().ToString();
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x0000F7E0 File Offset: 0x0000D9E0
		[NullableContext(1)]
		public virtual Exception GetBaseException()
		{
			Exception innerException = this.InnerException;
			Exception result = this;
			while (innerException != null)
			{
				result = innerException;
				innerException = innerException.InnerException;
			}
			return result;
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600041C RID: 1052 RVA: 0x0000F805 File Offset: 0x0000DA05
		public Exception InnerException
		{
			get
			{
				return this._innerException;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600041D RID: 1053 RVA: 0x0000F80D File Offset: 0x0000DA0D
		// (set) Token: 0x0600041E RID: 1054 RVA: 0x0000F815 File Offset: 0x0000DA15
		public virtual string HelpLink
		{
			get
			{
				return this._helpURL;
			}
			set
			{
				this._helpURL = value;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600041F RID: 1055 RVA: 0x0000F820 File Offset: 0x0000DA20
		// (set) Token: 0x06000420 RID: 1056 RVA: 0x0000F875 File Offset: 0x0000DA75
		public virtual string Source
		{
			[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:RequiresUnreferencedCode", Justification = "The API will return <unknown> if the metadata for current method cannot be established.")]
			get
			{
				string result;
				if ((result = this._source) == null)
				{
					string source;
					if (!this.HasBeenThrown)
					{
						source = null;
					}
					else
					{
						MethodBase targetSite = this.TargetSite;
						source = (((targetSite != null) ? targetSite.Module.Assembly.GetName().Name : null) ?? "<unknown>");
					}
					result = (this._source = source);
				}
				return result;
			}
			set
			{
				this._source = value;
			}
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x0000F880 File Offset: 0x0000DA80
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			ArgumentNullException.ThrowIfNull(info, "info");
			if (this._source == null)
			{
				this._source = this.Source;
			}
			info.AddValue("ClassName", this.GetClassName(), typeof(string));
			info.AddValue("Message", this._message, typeof(string));
			info.AddValue("Data", this._data, typeof(IDictionary));
			info.AddValue("InnerException", this._innerException, typeof(Exception));
			info.AddValue("HelpURL", this._helpURL, typeof(string));
			info.AddValue("StackTraceString", this.SerializationStackTraceString, typeof(string));
			info.AddValue("RemoteStackTraceString", this._remoteStackTraceString, typeof(string));
			info.AddValue("RemoteStackIndex", 0, typeof(int));
			info.AddValue("ExceptionMethod", null, typeof(string));
			info.AddValue("HResult", this._HResult);
			info.AddValue("Source", this._source, typeof(string));
			info.AddValue("WatsonBuckets", null, typeof(byte[]));
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x0000F9DC File Offset: 0x0000DBDC
		[NullableContext(1)]
		public override string ToString()
		{
			string className = this.GetClassName();
			string message = this.Message;
			Exception innerException = this._innerException;
			string text = ((innerException != null) ? innerException.ToString() : null) ?? "";
			string exception_EndOfInnerExceptionStack = SR.Exception_EndOfInnerExceptionStack;
			string stackTrace = this.StackTrace;
			int num = className.Length;
			checked
			{
				if (!string.IsNullOrEmpty(message))
				{
					num += 2 + message.Length;
				}
				if (this._innerException != null)
				{
					num += "\r\n".Length + " ---> ".Length + text.Length + "\r\n".Length + 3 + exception_EndOfInnerExceptionStack.Length;
				}
				if (stackTrace != null)
				{
					num += "\r\n".Length + stackTrace.Length;
				}
				string text2 = string.FastAllocateString(num);
				Span<char> span = new Span<char>(text2.GetRawStringData(), text2.Length);
				Exception.<ToString>g__Write|48_0(className, ref span);
				if (!string.IsNullOrEmpty(message))
				{
					Exception.<ToString>g__Write|48_0(": ", ref span);
					Exception.<ToString>g__Write|48_0(message, ref span);
				}
				if (this._innerException != null)
				{
					Exception.<ToString>g__Write|48_0("\r\n", ref span);
					Exception.<ToString>g__Write|48_0(" ---> ", ref span);
					Exception.<ToString>g__Write|48_0(text, ref span);
					Exception.<ToString>g__Write|48_0("\r\n", ref span);
					Exception.<ToString>g__Write|48_0("   ", ref span);
					Exception.<ToString>g__Write|48_0(exception_EndOfInnerExceptionStack, ref span);
				}
				if (stackTrace != null)
				{
					Exception.<ToString>g__Write|48_0("\r\n", ref span);
					Exception.<ToString>g__Write|48_0(stackTrace, ref span);
				}
				return text2;
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000423 RID: 1059 RVA: 0x0000FB34 File Offset: 0x0000DD34
		// (remove) Token: 0x06000424 RID: 1060 RVA: 0x0000FB34 File Offset: 0x0000DD34
		[Nullable(new byte[]
		{
			2,
			1
		})]
		[Obsolete("BinaryFormatter serialization is obsolete and should not be used. See https://aka.ms/binaryformatter for more information.", DiagnosticId = "SYSLIB0011", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		protected event EventHandler<SafeSerializationEventArgs> SerializeObjectState
		{
			add
			{
				throw new PlatformNotSupportedException(SR.PlatformNotSupported_SecureBinarySerialization);
			}
			remove
			{
				throw new PlatformNotSupportedException(SR.PlatformNotSupported_SecureBinarySerialization);
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000425 RID: 1061 RVA: 0x0000FB40 File Offset: 0x0000DD40
		// (set) Token: 0x06000426 RID: 1062 RVA: 0x0000FB48 File Offset: 0x0000DD48
		public int HResult
		{
			get
			{
				return this._HResult;
			}
			set
			{
				this._HResult = value;
			}
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00009E60 File Offset: 0x00008060
		[NullableContext(1)]
		public new Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x0000FB54 File Offset: 0x0000DD54
		public virtual string StackTrace
		{
			get
			{
				string stackTraceString = this._stackTraceString;
				string remoteStackTraceString = this._remoteStackTraceString;
				if (stackTraceString != null)
				{
					return remoteStackTraceString + stackTraceString;
				}
				if (!this.HasBeenThrown)
				{
					return remoteStackTraceString;
				}
				return remoteStackTraceString + this.GetStackTrace();
			}
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x0000FB90 File Offset: 0x0000DD90
		private string GetStackTrace()
		{
			return new StackTrace(this, true).ToString(System.Diagnostics.StackTrace.TraceFormat.Normal);
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x0000FBA0 File Offset: 0x0000DDA0
		[StackTraceHidden]
		internal void SetCurrentStackTrace()
		{
			if (!this.CanSetRemoteStackTrace())
			{
				return;
			}
			StringBuilder stringBuilder = new StringBuilder(256);
			new StackTrace(true).ToString(System.Diagnostics.StackTrace.TraceFormat.TrailingNewLine, stringBuilder);
			stringBuilder.AppendLine(SR.Exception_EndStackTraceFromPreviousThrow);
			this._remoteStackTraceString = stringBuilder.ToString();
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x0000FBE6 File Offset: 0x0000DDE6
		internal void SetRemoteStackTrace(string stackTrace)
		{
			if (!this.CanSetRemoteStackTrace())
			{
				return;
			}
			this._remoteStackTraceString = stackTrace + "\r\n" + SR.Exception_EndStackTraceFromPreviousThrow + "\r\n";
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600042C RID: 1068 RVA: 0x0000FC0C File Offset: 0x0000DE0C
		private string SerializationStackTraceString
		{
			get
			{
				string text = this._stackTraceString;
				if (text == null && this.HasBeenThrown)
				{
					text = this.GetStackTrace();
				}
				return text;
			}
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x0000FC33 File Offset: 0x0000DE33
		[CompilerGenerated]
		internal static void <ToString>g__Write|48_0(string source, ref Span<char> dest)
		{
			source.CopyTo(dest);
			dest = dest.Slice(source.Length);
		}

		// Token: 0x04000247 RID: 583
		private string _unused1;

		// Token: 0x04000248 RID: 584
		internal string _message;

		// Token: 0x04000249 RID: 585
		private IDictionary _data;

		// Token: 0x0400024A RID: 586
		private Exception _innerException;

		// Token: 0x0400024B RID: 587
		private string _helpURL;

		// Token: 0x0400024C RID: 588
		private object _traceIPs;

		// Token: 0x0400024D RID: 589
		private string _stackTraceString;

		// Token: 0x0400024E RID: 590
		private string _remoteStackTraceString;

		// Token: 0x0400024F RID: 591
		private int _unused4;

		// Token: 0x04000250 RID: 592
		private object[] _dynamicMethods;

		// Token: 0x04000251 RID: 593
		private int _HResult;

		// Token: 0x04000252 RID: 594
		private string _source;

		// Token: 0x04000253 RID: 595
		private object _unused6;

		// Token: 0x04000254 RID: 596
		internal MonoStackFrame[] foreignExceptionsFrames;

		// Token: 0x04000255 RID: 597
		private IntPtr[] native_trace_ips;

		// Token: 0x04000256 RID: 598
		private int caught_in_unmanaged;

		// Token: 0x04000257 RID: 599
		private protected const string InnerExceptionPrefix = " ---> ";

		// Token: 0x02000084 RID: 132
		internal readonly struct DispatchState
		{
			// Token: 0x0600042E RID: 1070 RVA: 0x0000FC53 File Offset: 0x0000DE53
			public DispatchState(MonoStackFrame[] stackFrames)
			{
				this.StackFrames = stackFrames;
			}

			// Token: 0x04000258 RID: 600
			public readonly MonoStackFrame[] StackFrames;
		}
	}
}
