using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Diagnostics
{
	// Token: 0x0200088B RID: 2187
	[NullableContext(2)]
	[Nullable(0)]
	public class DebugProvider
	{
		// Token: 0x0600895F RID: 35167 RVA: 0x0014DD08 File Offset: 0x0014BF08
		[DoesNotReturn]
		public virtual void Fail(string message, string detailMessage)
		{
			string stackTrace;
			try
			{
				stackTrace = new StackTrace(0, true).ToString(StackTrace.TraceFormat.Normal);
			}
			catch
			{
				stackTrace = "";
			}
			this.WriteAssert(stackTrace, message, detailMessage);
			DebugProvider.FailCore(stackTrace, message, detailMessage, "Assertion failed.");
		}

		// Token: 0x06008960 RID: 35168 RVA: 0x0014DD54 File Offset: 0x0014BF54
		internal void WriteAssert(string stackTrace, string message, string detailMessage)
		{
			this.WriteLine(string.Concat(new string[]
			{
				SR.DebugAssertBanner,
				"\r\n",
				SR.DebugAssertShortMessage,
				"\r\n",
				message,
				"\r\n",
				SR.DebugAssertLongMessage,
				"\r\n",
				detailMessage,
				"\r\n",
				stackTrace
			}));
		}

		// Token: 0x06008961 RID: 35169 RVA: 0x0014DDC4 File Offset: 0x0014BFC4
		public virtual void Write(string message)
		{
			object obj = DebugProvider.s_lock;
			lock (obj)
			{
				if (message == null)
				{
					DebugProvider.WriteCore(string.Empty);
				}
				else
				{
					if (this._needIndent)
					{
						message = this.GetIndentString() + message;
						this._needIndent = false;
					}
					DebugProvider.WriteCore(message);
					if (message.EndsWith("\r\n", StringComparison.Ordinal))
					{
						this._needIndent = true;
					}
				}
			}
		}

		// Token: 0x06008962 RID: 35170 RVA: 0x0014DE44 File Offset: 0x0014C044
		public virtual void WriteLine(string message)
		{
			this.Write(message + "\r\n");
		}

		// Token: 0x06008963 RID: 35171 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		public virtual void OnIndentLevelChanged(int indentLevel)
		{
		}

		// Token: 0x06008964 RID: 35172 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		public virtual void OnIndentSizeChanged(int indentSize)
		{
		}

		// Token: 0x06008965 RID: 35173 RVA: 0x0014DE58 File Offset: 0x0014C058
		private string GetIndentString()
		{
			int num = Debug.IndentSize * Debug.IndentLevel;
			string indentString = this._indentString;
			if (indentString != null && indentString.Length == num)
			{
				return this._indentString;
			}
			return this._indentString = new string(' ', num);
		}

		// Token: 0x06008966 RID: 35174 RVA: 0x0014DEA0 File Offset: 0x0014C0A0
		[NullableContext(1)]
		public static void FailCore(string stackTrace, [Nullable(2)] string message, [Nullable(2)] string detailMessage, string errorSource)
		{
			if (DebugProvider.s_FailCore != null)
			{
				DebugProvider.s_FailCore(stackTrace, message, detailMessage, errorSource);
				return;
			}
			if (Debugger.IsAttached)
			{
				Debugger.Break();
				return;
			}
			DebugProvider.DebugAssertException ex = new DebugProvider.DebugAssertException(message, detailMessage, stackTrace);
			Environment.FailFast(ex.Message, ex, errorSource);
		}

		// Token: 0x06008967 RID: 35175 RVA: 0x0014DEE8 File Offset: 0x0014C0E8
		[NullableContext(1)]
		public static void WriteCore(string message)
		{
			if (DebugProvider.s_WriteCore != null)
			{
				DebugProvider.s_WriteCore(message);
				return;
			}
			object obj = DebugProvider.s_ForLock;
			lock (obj)
			{
				if (message.Length <= 4091)
				{
					DebugProvider.WriteToDebugger(message);
				}
				else
				{
					int i;
					for (i = 0; i < message.Length - 4091; i += 4091)
					{
						DebugProvider.WriteToDebugger(message.Substring(i, 4091));
					}
					DebugProvider.WriteToDebugger(message.Substring(i));
				}
			}
		}

		// Token: 0x06008968 RID: 35176 RVA: 0x0014DF84 File Offset: 0x0014C184
		private static void WriteToDebugger(string message)
		{
			if (Debugger.IsLogging())
			{
				Debugger.Log(0, null, message);
				return;
			}
			Interop.Kernel32.OutputDebugString(message ?? string.Empty);
		}

		// Token: 0x04001E3F RID: 7743
		private static readonly object s_lock = new object();

		// Token: 0x04001E40 RID: 7744
		private bool _needIndent = true;

		// Token: 0x04001E41 RID: 7745
		private string _indentString;

		// Token: 0x04001E42 RID: 7746
		internal static Action<string, string, string, string> s_FailCore;

		// Token: 0x04001E43 RID: 7747
		internal static Action<string> s_WriteCore;

		// Token: 0x04001E44 RID: 7748
		private static readonly object s_ForLock = new object();

		// Token: 0x0200088C RID: 2188
		private sealed class DebugAssertException : Exception
		{
			// Token: 0x0600896B RID: 35179 RVA: 0x0014DFCA File Offset: 0x0014C1CA
			internal DebugAssertException(string message, string detailMessage, string stackTrace) : base(DebugProvider.DebugAssertException.Terminate(message) + DebugProvider.DebugAssertException.Terminate(detailMessage) + stackTrace)
			{
			}

			// Token: 0x0600896C RID: 35180 RVA: 0x0014DFE4 File Offset: 0x0014C1E4
			private static string Terminate(string s)
			{
				if (s == null)
				{
					return s;
				}
				s = s.Trim();
				if (s.Length > 0)
				{
					s += "\r\n";
				}
				return s;
			}
		}
	}
}
