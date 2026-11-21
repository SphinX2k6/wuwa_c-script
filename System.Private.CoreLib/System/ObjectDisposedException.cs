using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x02000186 RID: 390
	[NullableContext(1)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class ObjectDisposedException : InvalidOperationException
	{
		// Token: 0x060019C0 RID: 6592 RVA: 0x00054A00 File Offset: 0x00052C00
		[NullableContext(2)]
		public ObjectDisposedException(string objectName) : this(objectName, SR.ObjectDisposed_Generic)
		{
		}

		// Token: 0x060019C1 RID: 6593 RVA: 0x00054A0E File Offset: 0x00052C0E
		[NullableContext(2)]
		public ObjectDisposedException(string objectName, string message) : base(message ?? SR.ObjectDisposed_Generic)
		{
			base.HResult = -2146232798;
			this._objectName = objectName;
		}

		// Token: 0x060019C2 RID: 6594 RVA: 0x00054A32 File Offset: 0x00052C32
		[NullableContext(2)]
		public ObjectDisposedException(string message, Exception innerException) : base(message ?? SR.ObjectDisposed_Generic, innerException)
		{
			base.HResult = -2146232798;
		}

		// Token: 0x060019C3 RID: 6595 RVA: 0x00054A50 File Offset: 0x00052C50
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected ObjectDisposedException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this._objectName = info.GetString("ObjectName");
		}

		// Token: 0x060019C4 RID: 6596 RVA: 0x00054A6B File Offset: 0x00052C6B
		[StackTraceHidden]
		public static void ThrowIf([DoesNotReturnIf(true)] bool condition, object instance)
		{
			if (condition)
			{
				ThrowHelper.ThrowObjectDisposedException(instance);
			}
		}

		// Token: 0x060019C5 RID: 6597 RVA: 0x00054A76 File Offset: 0x00052C76
		[StackTraceHidden]
		public static void ThrowIf([DoesNotReturnIf(true)] bool condition, Type type)
		{
			if (condition)
			{
				ThrowHelper.ThrowObjectDisposedException(type);
			}
		}

		// Token: 0x060019C6 RID: 6598 RVA: 0x00054A81 File Offset: 0x00052C81
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("ObjectName", this.ObjectName, typeof(string));
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x060019C7 RID: 6599 RVA: 0x00054AA8 File Offset: 0x00052CA8
		public override string Message
		{
			get
			{
				string objectName = this.ObjectName;
				if (string.IsNullOrEmpty(objectName))
				{
					return base.Message;
				}
				string str = SR.Format(SR.ObjectDisposed_ObjectName_Name, objectName);
				return base.Message + "\r\n" + str;
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x060019C8 RID: 6600 RVA: 0x00054AE8 File Offset: 0x00052CE8
		public string ObjectName
		{
			get
			{
				return this._objectName ?? string.Empty;
			}
		}

		// Token: 0x04000531 RID: 1329
		private readonly string _objectName;
	}
}
