using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace System.Diagnostics
{
	// Token: 0x02000877 RID: 2167
	[NullableContext(2)]
	[Nullable(0)]
	public class StackFrame
	{
		// Token: 0x060088C1 RID: 35009 RVA: 0x0014C9CC File Offset: 0x0014ABCC
		internal StackFrame(MonoStackFrame monoStackFrame, bool needFileInfo)
		{
			this._method = monoStackFrame.methodBase;
			this._nativeOffset = monoStackFrame.nativeOffset;
			this._ilOffset = monoStackFrame.ilOffset;
			if (needFileInfo)
			{
				this._fileName = monoStackFrame.fileName;
				this._lineNumber = monoStackFrame.lineNumber;
				this._columnNumber = monoStackFrame.columnNumber;
			}
			this._isLastFrameFromForeignExceptionStackTrace = monoStackFrame.isLastFrameFromForeignException;
		}

		// Token: 0x060088C2 RID: 35010 RVA: 0x0014CA38 File Offset: 0x0014AC38
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void BuildStackFrame(int skipFrames, bool needFileInfo)
		{
			if (skipFrames + 3 < 0)
			{
				return;
			}
			MethodBase method = null;
			string fileName = null;
			int ilOffset;
			int nativeOffset;
			int lineNumber;
			int columnNumber;
			if (!StackFrame.GetFrameInfo(skipFrames + 3, needFileInfo, ObjectHandleOnStack.Create<MethodBase>(ref method), ObjectHandleOnStack.Create<string>(ref fileName), out ilOffset, out nativeOffset, out lineNumber, out columnNumber))
			{
				return;
			}
			this._method = method;
			this._ilOffset = ilOffset;
			this._nativeOffset = nativeOffset;
			if (needFileInfo)
			{
				this._fileName = fileName;
				this._lineNumber = lineNumber;
				this._columnNumber = columnNumber;
			}
		}

		// Token: 0x060088C3 RID: 35011
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool GetFrameInfo(int skipFrames, bool needFileInfo, ObjectHandleOnStack out_method, ObjectHandleOnStack out_file, out int ilOffset, out int nativeOffset, out int line, out int column);

		// Token: 0x060088C4 RID: 35012 RVA: 0x0014CAA1 File Offset: 0x0014ACA1
		private void InitMembers()
		{
			this._nativeOffset = -1;
			this._ilOffset = -1;
		}

		// Token: 0x060088C5 RID: 35013 RVA: 0x0014CAB1 File Offset: 0x0014ACB1
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StackFrame()
		{
			this.InitMembers();
			this.BuildStackFrame(0, false);
		}

		// Token: 0x060088C6 RID: 35014 RVA: 0x0014CAC7 File Offset: 0x0014ACC7
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StackFrame(bool needFileInfo)
		{
			this.InitMembers();
			this.BuildStackFrame(0, needFileInfo);
		}

		// Token: 0x060088C7 RID: 35015 RVA: 0x0014CADD File Offset: 0x0014ACDD
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StackFrame(int skipFrames)
		{
			this.InitMembers();
			this.BuildStackFrame(skipFrames, false);
		}

		// Token: 0x060088C8 RID: 35016 RVA: 0x0014CAF3 File Offset: 0x0014ACF3
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StackFrame(int skipFrames, bool needFileInfo)
		{
			this.InitMembers();
			this.BuildStackFrame(skipFrames, needFileInfo);
		}

		// Token: 0x060088C9 RID: 35017 RVA: 0x0014CB09 File Offset: 0x0014AD09
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StackFrame(string fileName, int lineNumber)
		{
			this.InitMembers();
			this.BuildStackFrame(0, false);
			this._fileName = fileName;
			this._lineNumber = lineNumber;
		}

		// Token: 0x060088CA RID: 35018 RVA: 0x0014CB2D File Offset: 0x0014AD2D
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StackFrame(string fileName, int lineNumber, int colNumber)
		{
			this.InitMembers();
			this.BuildStackFrame(0, false);
			this._fileName = fileName;
			this._lineNumber = lineNumber;
			this._columnNumber = colNumber;
		}

		// Token: 0x1700120B RID: 4619
		// (get) Token: 0x060088CB RID: 35019 RVA: 0x0014CB58 File Offset: 0x0014AD58
		internal bool IsLastFrameFromForeignExceptionStackTrace
		{
			get
			{
				return this._isLastFrameFromForeignExceptionStackTrace;
			}
		}

		// Token: 0x060088CC RID: 35020 RVA: 0x0014CB60 File Offset: 0x0014AD60
		[RequiresUnreferencedCode("Metadata for the method might be incomplete or removed. Consider using DiagnosticMethodInfo.Create instead")]
		public virtual MethodBase GetMethod()
		{
			return this._method;
		}

		// Token: 0x060088CD RID: 35021 RVA: 0x0014CB68 File Offset: 0x0014AD68
		public virtual int GetNativeOffset()
		{
			return this._nativeOffset;
		}

		// Token: 0x060088CE RID: 35022 RVA: 0x0014CB70 File Offset: 0x0014AD70
		public virtual int GetILOffset()
		{
			return this._ilOffset;
		}

		// Token: 0x060088CF RID: 35023 RVA: 0x0014CB78 File Offset: 0x0014AD78
		public virtual string GetFileName()
		{
			return this._fileName;
		}

		// Token: 0x060088D0 RID: 35024 RVA: 0x0014CB80 File Offset: 0x0014AD80
		public virtual int GetFileLineNumber()
		{
			return this._lineNumber;
		}

		// Token: 0x060088D1 RID: 35025 RVA: 0x0014CB88 File Offset: 0x0014AD88
		public virtual int GetFileColumnNumber()
		{
			return this._columnNumber;
		}

		// Token: 0x060088D2 RID: 35026 RVA: 0x0014CB90 File Offset: 0x0014AD90
		[NullableContext(1)]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder(255);
			bool flag2;
			if (this._method != null)
			{
				stringBuilder.Append(this._method.Name);
				MethodInfo methodInfo = this._method as MethodInfo;
				if (methodInfo != null && methodInfo.IsGenericMethod)
				{
					Type[] genericArguments = methodInfo.GetGenericArguments();
					stringBuilder.Append('<');
					int i = 0;
					bool flag = true;
					while (i < genericArguments.Length)
					{
						if (!flag)
						{
							stringBuilder.Append(',');
						}
						else
						{
							flag = false;
						}
						stringBuilder.Append(genericArguments[i].Name);
						i++;
					}
					stringBuilder.Append('>');
				}
				flag2 = true;
			}
			else
			{
				flag2 = false;
			}
			if (flag2)
			{
				stringBuilder.Append(" at offset ");
				if (this._nativeOffset == -1)
				{
					stringBuilder.Append("<offset unknown>");
				}
				else
				{
					stringBuilder.Append(this._nativeOffset);
				}
				stringBuilder.Append(" in file:line:column ");
				stringBuilder.Append(this._fileName ?? "<filename unknown>");
				stringBuilder.Append(':');
				stringBuilder.Append(this._lineNumber);
				stringBuilder.Append(':');
				stringBuilder.Append(this._columnNumber);
			}
			else
			{
				stringBuilder.Append("<null>");
			}
			stringBuilder.AppendLine();
			return stringBuilder.ToString();
		}

		// Token: 0x04001E06 RID: 7686
		private MethodBase _method;

		// Token: 0x04001E07 RID: 7687
		private int _nativeOffset;

		// Token: 0x04001E08 RID: 7688
		private int _ilOffset;

		// Token: 0x04001E09 RID: 7689
		private string _fileName;

		// Token: 0x04001E0A RID: 7690
		private int _lineNumber;

		// Token: 0x04001E0B RID: 7691
		private int _columnNumber;

		// Token: 0x04001E0C RID: 7692
		private bool _isLastFrameFromForeignExceptionStackTrace;

		// Token: 0x04001E0D RID: 7693
		public const int OFFSET_UNKNOWN = -1;
	}
}
