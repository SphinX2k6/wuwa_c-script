using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace System.Diagnostics
{
	// Token: 0x02000879 RID: 2169
	[NullableContext(1)]
	[Nullable(0)]
	public class StackTrace
	{
		// Token: 0x060088D3 RID: 35027
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void GetTrace(ObjectHandleOnStack ex, ObjectHandleOnStack res, int skipFrames, bool needFileInfo);

		// Token: 0x060088D4 RID: 35028 RVA: 0x0014CCD8 File Offset: 0x0014AED8
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:RequiresUnreferencedCode", Justification = "StackFrame.GetMethod is getting compared to null but nothing else on it is touched.")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitializeForCurrentThread(int skipFrames, bool needFileInfo)
		{
			skipFrames += 2;
			List<StackFrame> list = new List<StackFrame>();
			while (skipFrames >= 0)
			{
				StackFrame stackFrame = new StackFrame(skipFrames, needFileInfo);
				if (stackFrame.GetMethod() == null)
				{
					break;
				}
				list.Add(stackFrame);
				skipFrames++;
			}
			this._stackFrames = list.ToArray();
			this._numOfFrames = this._stackFrames.Length;
		}

		// Token: 0x060088D5 RID: 35029 RVA: 0x0014CD34 File Offset: 0x0014AF34
		private void InitializeForException(Exception e, int skipFrames, bool needFileInfo)
		{
			MonoStackFrame[] array = null;
			StackTrace.GetTrace(ObjectHandleOnStack.Create<Exception>(ref e), ObjectHandleOnStack.Create<MonoStackFrame[]>(ref array), skipFrames, needFileInfo);
			this._numOfFrames = array.Length;
			MonoStackFrame[] foreignExceptionsFrames = e.foreignExceptionsFrames;
			int num;
			if (foreignExceptionsFrames != null)
			{
				num = foreignExceptionsFrames.Length;
				this._numOfFrames += num;
				this._stackFrames = new StackFrame[this._numOfFrames];
				for (int i = 0; i < foreignExceptionsFrames.Length; i++)
				{
					this._stackFrames[i] = new StackFrame(foreignExceptionsFrames[i], needFileInfo);
				}
			}
			else
			{
				this._stackFrames = new StackFrame[this._numOfFrames];
				num = 0;
			}
			for (int j = 0; j < array.Length; j++)
			{
				this._stackFrames[num + j] = new StackFrame(array[j], needFileInfo);
			}
		}

		// Token: 0x1700120C RID: 4620
		// (get) Token: 0x060088D6 RID: 35030 RVA: 0x0014CDE9 File Offset: 0x0014AFE9
		internal static bool IsSupported { get; } = StackTrace.InitializeIsSupported();

		// Token: 0x060088D7 RID: 35031 RVA: 0x0014CDF0 File Offset: 0x0014AFF0
		private static bool InitializeIsSupported()
		{
			bool flag;
			return !AppContext.TryGetSwitch("System.Diagnostics.StackTrace.IsSupported", out flag) || flag;
		}

		// Token: 0x060088D8 RID: 35032 RVA: 0x0014CE0E File Offset: 0x0014B00E
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StackTrace()
		{
			this.InitializeForCurrentThread(0, false);
		}

		// Token: 0x060088D9 RID: 35033 RVA: 0x0014CE1E File Offset: 0x0014B01E
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StackTrace(bool fNeedFileInfo)
		{
			this.InitializeForCurrentThread(0, fNeedFileInfo);
		}

		// Token: 0x060088DA RID: 35034 RVA: 0x0014CE2E File Offset: 0x0014B02E
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StackTrace(int skipFrames)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(skipFrames, "skipFrames");
			this.InitializeForCurrentThread(skipFrames, false);
		}

		// Token: 0x060088DB RID: 35035 RVA: 0x0014CE49 File Offset: 0x0014B049
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StackTrace(int skipFrames, bool fNeedFileInfo)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(skipFrames, "skipFrames");
			this.InitializeForCurrentThread(skipFrames, fNeedFileInfo);
		}

		// Token: 0x060088DC RID: 35036 RVA: 0x0014CE64 File Offset: 0x0014B064
		public StackTrace(Exception e)
		{
			ArgumentNullException.ThrowIfNull(e, "e");
			this.InitializeForException(e, 0, false);
		}

		// Token: 0x060088DD RID: 35037 RVA: 0x0014CE80 File Offset: 0x0014B080
		public StackTrace(Exception e, bool fNeedFileInfo)
		{
			ArgumentNullException.ThrowIfNull(e, "e");
			this.InitializeForException(e, 0, fNeedFileInfo);
		}

		// Token: 0x060088DE RID: 35038 RVA: 0x0014CE9C File Offset: 0x0014B09C
		public StackTrace(Exception e, int skipFrames)
		{
			ArgumentNullException.ThrowIfNull(e, "e");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(skipFrames, "skipFrames");
			this.InitializeForException(e, skipFrames, false);
		}

		// Token: 0x060088DF RID: 35039 RVA: 0x0014CEC3 File Offset: 0x0014B0C3
		public StackTrace(Exception e, int skipFrames, bool fNeedFileInfo)
		{
			ArgumentNullException.ThrowIfNull(e, "e");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(skipFrames, "skipFrames");
			this.InitializeForException(e, skipFrames, fNeedFileInfo);
		}

		// Token: 0x060088E0 RID: 35040 RVA: 0x0014CEEA File Offset: 0x0014B0EA
		public StackTrace(StackFrame frame)
		{
			this._stackFrames = new StackFrame[]
			{
				frame
			};
			this._numOfFrames = 1;
		}

		// Token: 0x060088E1 RID: 35041 RVA: 0x0014CF0C File Offset: 0x0014B10C
		public StackTrace(IEnumerable<StackFrame> frames)
		{
			ArgumentNullException.ThrowIfNull(frames, "frames");
			List<StackFrame> list = new List<StackFrame>(frames);
			this._stackFrames = list.ToArray();
			this._numOfFrames = list.Count;
		}

		// Token: 0x1700120D RID: 4621
		// (get) Token: 0x060088E2 RID: 35042 RVA: 0x0014CF49 File Offset: 0x0014B149
		public virtual int FrameCount
		{
			get
			{
				return this._numOfFrames;
			}
		}

		// Token: 0x060088E3 RID: 35043 RVA: 0x0014CF51 File Offset: 0x0014B151
		[NullableContext(2)]
		public virtual StackFrame GetFrame(int index)
		{
			if (this._stackFrames != null && index < this._numOfFrames && index >= 0)
			{
				return this._stackFrames[index + this._methodsToSkip];
			}
			return null;
		}

		// Token: 0x060088E4 RID: 35044 RVA: 0x0014CF7C File Offset: 0x0014B17C
		public virtual StackFrame[] GetFrames()
		{
			if (this._stackFrames == null || this._numOfFrames <= 0)
			{
				return Array.Empty<StackFrame>();
			}
			StackFrame[] array = new StackFrame[this._numOfFrames];
			Array.Copy(this._stackFrames, this._methodsToSkip, array, 0, this._numOfFrames);
			return array;
		}

		// Token: 0x060088E5 RID: 35045 RVA: 0x0014CFC6 File Offset: 0x0014B1C6
		public override string ToString()
		{
			return this.ToString(StackTrace.TraceFormat.TrailingNewLine);
		}

		// Token: 0x060088E6 RID: 35046 RVA: 0x0014CFD0 File Offset: 0x0014B1D0
		internal string ToString(StackTrace.TraceFormat traceFormat)
		{
			StringBuilder stringBuilder = new StringBuilder(256);
			this.ToString(traceFormat, stringBuilder);
			return stringBuilder.ToString();
		}

		// Token: 0x060088E7 RID: 35047 RVA: 0x0014CFF8 File Offset: 0x0014B1F8
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:RequiresUnreferencedCode", Justification = "ToString is best effort when it comes to available information.")]
		internal unsafe void ToString(StackTrace.TraceFormat traceFormat, StringBuilder sb)
		{
			string value = SR.UsingResourceKeys() ? "at" : SR.Word_At;
			string format = SR.UsingResourceKeys() ? "in {0}:{1}" : SR.StackTrace_InFileLineNumber;
			string format2 = SR.UsingResourceKeys() ? "in {0}:token 0x{1:x}+0x{2:x}" : SR.StackTrace_InFileILOffset;
			bool flag = true;
			for (int i = 0; i < this._numOfFrames; i++)
			{
				StackFrame frame = this.GetFrame(i);
				MethodBase methodBase = (frame != null) ? frame.GetMethod() : null;
				if (methodBase != null && (StackTrace.ShowInStackTrace(methodBase) || i == this._numOfFrames - 1))
				{
					if (flag)
					{
						flag = false;
					}
					else
					{
						sb.AppendLine();
					}
					sb.Append("   ").Append(value).Append(' ');
					bool flag2 = false;
					Type declaringType = methodBase.DeclaringType;
					string name = methodBase.Name;
					bool flag3 = false;
					if (declaringType != null && StackTrace.IsDefinedSafe(declaringType, typeof(CompilerGeneratedAttribute), false))
					{
						flag2 = declaringType.IsAssignableTo(typeof(IAsyncStateMachine));
						if (flag2 || declaringType.IsAssignableTo(typeof(IEnumerator)))
						{
							flag3 = StackTrace.TryResolveStateMachineMethod(ref methodBase, out declaringType);
						}
					}
					if (declaringType != null)
					{
						string value2 = declaringType.ToString();
						sb.Append(value2);
						sb.Append('.');
					}
					sb.Append(methodBase.Name);
					MethodInfo methodInfo = methodBase as MethodInfo;
					if (methodInfo != null && methodInfo.IsGenericMethod)
					{
						Type[] genericArguments = methodInfo.GetGenericArguments();
						sb.Append('[');
						int j = 0;
						bool flag4 = true;
						while (j < genericArguments.Length)
						{
							if (!flag4)
							{
								sb.Append(',');
							}
							else
							{
								flag4 = false;
							}
							sb.Append(genericArguments[j].Name);
							j++;
						}
						sb.Append(']');
					}
					ReadOnlySpan<ParameterInfo> readOnlySpan = default(ReadOnlySpan<ParameterInfo>);
					bool flag5 = true;
					try
					{
						readOnlySpan = methodBase.GetParametersAsSpan();
					}
					catch
					{
						flag5 = false;
					}
					if (flag5)
					{
						sb.Append('(');
						bool flag6 = true;
						for (int k = 0; k < readOnlySpan.Length; k++)
						{
							if (!flag6)
							{
								sb.Append(", ");
							}
							else
							{
								flag6 = false;
							}
							string value3 = "<UnknownType>";
							if (readOnlySpan[k]->ParameterType != null)
							{
								value3 = readOnlySpan[k]->ParameterType.Name;
							}
							sb.Append(value3);
							string name2 = readOnlySpan[k]->Name;
							if (name2 != null)
							{
								sb.Append(' ');
								sb.Append(name2);
							}
						}
						sb.Append(')');
					}
					if (flag3)
					{
						sb.Append('+');
						sb.Append(name);
						sb.Append('(').Append(')');
					}
					if (frame.GetILOffset() != -1)
					{
						string fileName = frame.GetFileName();
						if (fileName != null)
						{
							sb.Append(' ');
							sb.AppendFormat(CultureInfo.InvariantCulture, format, fileName, frame.GetFileLineNumber());
							StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(4, 1, sb);
							appendInterpolatedStringHandler.AppendLiteral(" il:");
							appendInterpolatedStringHandler.AppendFormatted<int>(frame.GetILOffset(), "x");
							sb.Append(ref appendInterpolatedStringHandler);
						}
						else if (LocalAppContextSwitches.ShowILOffsets && methodBase.ReflectedType != null)
						{
							string scopeName = methodBase.ReflectedType.Module.ScopeName;
							try
							{
								int metadataToken = methodBase.MetadataToken;
								sb.Append(' ');
								sb.AppendFormat(CultureInfo.InvariantCulture, format2, scopeName, metadataToken, frame.GetILOffset());
							}
							catch (InvalidOperationException)
							{
							}
						}
					}
					if (frame.IsLastFrameFromForeignExceptionStackTrace && !flag2)
					{
						sb.AppendLine();
						sb.Append(SR.UsingResourceKeys() ? "--- End of stack trace from previous location ---" : SR.Exception_EndStackTraceFromPreviousThrow);
					}
				}
			}
			if (traceFormat == StackTrace.TraceFormat.TrailingNewLine)
			{
				sb.AppendLine();
			}
		}

		// Token: 0x060088E8 RID: 35048 RVA: 0x0014D3EC File Offset: 0x0014B5EC
		private static bool ShowInStackTrace(MethodBase mb)
		{
			if ((mb.MethodImplementationFlags & MethodImplAttributes.AggressiveInlining) != MethodImplAttributes.IL)
			{
				return false;
			}
			if (StackTrace.IsDefinedSafe(mb, typeof(StackTraceHiddenAttribute), false))
			{
				return false;
			}
			Type declaringType = mb.DeclaringType;
			return !(declaringType != null) || !StackTrace.IsDefinedSafe(declaringType, typeof(StackTraceHiddenAttribute), false);
		}

		// Token: 0x060088E9 RID: 35049 RVA: 0x0014D444 File Offset: 0x0014B644
		private static bool IsDefinedSafe(MemberInfo memberInfo, Type attributeType, bool inherit)
		{
			bool result;
			try
			{
				result = memberInfo.IsDefined(attributeType, inherit);
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060088EA RID: 35050 RVA: 0x0014D474 File Offset: 0x0014B674
		private static Attribute[] GetCustomAttributesSafe(MemberInfo memberInfo, Type attributeType, bool inherit)
		{
			Attribute[] result;
			try
			{
				result = Attribute.GetCustomAttributes(memberInfo, attributeType, inherit);
			}
			catch
			{
				result = Array.Empty<Attribute>();
			}
			return result;
		}

		// Token: 0x060088EB RID: 35051 RVA: 0x0014D4A8 File Offset: 0x0014B6A8
		private static bool TryResolveStateMachineMethod(ref MethodBase method, out Type declaringType)
		{
			declaringType = method.DeclaringType;
			Type declaringType2 = declaringType.DeclaringType;
			if (declaringType2 == null)
			{
				return false;
			}
			MethodInfo[] array = StackTrace.<TryResolveStateMachineMethod>g__GetDeclaredMethods|32_0(declaringType2);
			if (array == null)
			{
				return false;
			}
			foreach (MethodInfo methodInfo in array)
			{
				StateMachineAttribute[] array3 = (StateMachineAttribute[])StackTrace.GetCustomAttributesSafe(methodInfo, typeof(StateMachineAttribute), false);
				if (array3 != null)
				{
					bool flag = false;
					bool flag2 = false;
					foreach (StateMachineAttribute stateMachineAttribute in array3)
					{
						if (stateMachineAttribute.StateMachineType == declaringType)
						{
							flag = true;
							flag2 |= (stateMachineAttribute is IteratorStateMachineAttribute || stateMachineAttribute is AsyncIteratorStateMachineAttribute);
						}
					}
					if (flag)
					{
						method = methodInfo;
						declaringType = methodInfo.DeclaringType;
						return flag2;
					}
				}
			}
			return false;
		}

		// Token: 0x060088ED RID: 35053 RVA: 0x001225C5 File Offset: 0x001207C5
		[CompilerGenerated]
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2070:UnrecognizedReflectionPattern", Justification = "Using Reflection to find the state machine's corresponding method is safe because the corresponding method is the only caller of the state machine. If the state machine is present, the corresponding method will be, too.")]
		internal static MethodInfo[] <TryResolveStateMachineMethod>g__GetDeclaredMethods|32_0(Type type)
		{
			return type.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		}

		// Token: 0x04001E19 RID: 7705
		public const int METHODS_TO_SKIP = 0;

		// Token: 0x04001E1A RID: 7706
		private int _numOfFrames;

		// Token: 0x04001E1B RID: 7707
		private int _methodsToSkip;

		// Token: 0x04001E1C RID: 7708
		private StackFrame[] _stackFrames;

		// Token: 0x0200087A RID: 2170
		internal enum TraceFormat
		{
			// Token: 0x04001E1E RID: 7710
			Normal,
			// Token: 0x04001E1F RID: 7711
			TrailingNewLine
		}
	}
}
