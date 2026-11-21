using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace System.Diagnostics
{
	// Token: 0x0200087C RID: 2172
	[NullableContext(2)]
	[Nullable(0)]
	public static class Debug
	{
		// Token: 0x060088F0 RID: 35056 RVA: 0x0014D59F File Offset: 0x0014B79F
		[NullableContext(1)]
		public static DebugProvider SetProvider(DebugProvider provider)
		{
			ArgumentNullException.ThrowIfNull(provider, "provider");
			return Interlocked.Exchange<DebugProvider>(ref Debug.s_provider, provider);
		}

		// Token: 0x1700120F RID: 4623
		// (get) Token: 0x060088F1 RID: 35057 RVA: 0x000070DD File Offset: 0x000052DD
		// (set) Token: 0x060088F2 RID: 35058 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		public static bool AutoFlush
		{
			get
			{
				return true;
			}
			set
			{
			}
		}

		// Token: 0x17001210 RID: 4624
		// (get) Token: 0x060088F3 RID: 35059 RVA: 0x0014D5B7 File Offset: 0x0014B7B7
		// (set) Token: 0x060088F4 RID: 35060 RVA: 0x0014D5BE File Offset: 0x0014B7BE
		public static int IndentLevel
		{
			get
			{
				return Debug.t_indentLevel;
			}
			set
			{
				Debug.t_indentLevel = ((value < 0) ? 0 : value);
				Debug.s_provider.OnIndentLevelChanged(Debug.t_indentLevel);
			}
		}

		// Token: 0x17001211 RID: 4625
		// (get) Token: 0x060088F5 RID: 35061 RVA: 0x0014D5DE File Offset: 0x0014B7DE
		// (set) Token: 0x060088F6 RID: 35062 RVA: 0x0014D5E7 File Offset: 0x0014B7E7
		public static int IndentSize
		{
			get
			{
				return Debug.s_indentSize;
			}
			set
			{
				Debug.s_indentSize = ((value < 0) ? 0 : value);
				Debug.s_provider.OnIndentSizeChanged(Debug.s_indentSize);
			}
		}

		// Token: 0x060088F7 RID: 35063 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		[Conditional("DEBUG")]
		public static void Close()
		{
		}

		// Token: 0x060088F8 RID: 35064 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		[Conditional("DEBUG")]
		public static void Flush()
		{
		}

		// Token: 0x060088F9 RID: 35065 RVA: 0x0014D60B File Offset: 0x0014B80B
		[Conditional("DEBUG")]
		public static void Indent()
		{
			Debug.IndentLevel++;
		}

		// Token: 0x060088FA RID: 35066 RVA: 0x0014D619 File Offset: 0x0014B819
		[Conditional("DEBUG")]
		public static void Unindent()
		{
			Debug.IndentLevel--;
		}

		// Token: 0x060088FB RID: 35067 RVA: 0x0014D627 File Offset: 0x0014B827
		[Conditional("DEBUG")]
		public static void Print(string message)
		{
			Debug.WriteLine(message);
		}

		// Token: 0x060088FC RID: 35068 RVA: 0x0014D62F File Offset: 0x0014B82F
		[NullableContext(1)]
		[Conditional("DEBUG")]
		public static void Print([StringSyntax("CompositeFormat")] string format, [Nullable(new byte[]
		{
			1,
			2
		})] params object[] args)
		{
			Debug.WriteLine(string.Format(null, format, args));
		}

		// Token: 0x060088FD RID: 35069 RVA: 0x0014D63E File Offset: 0x0014B83E
		[Conditional("DEBUG")]
		[OverloadResolutionPriority(-1)]
		public static void Assert([DoesNotReturnIf(false)] bool condition)
		{
			Debug.Assert(condition, string.Empty, string.Empty);
		}

		// Token: 0x060088FE RID: 35070 RVA: 0x0014D650 File Offset: 0x0014B850
		[Conditional("DEBUG")]
		public static void Assert([DoesNotReturnIf(false)] bool condition, [CallerArgumentExpression("condition")] string message = null)
		{
			Debug.Assert(condition, message, string.Empty);
		}

		// Token: 0x060088FF RID: 35071 RVA: 0x0014D65E File Offset: 0x0014B85E
		[Conditional("DEBUG")]
		public static void Assert([DoesNotReturnIf(false)] bool condition, [InterpolatedStringHandlerArgument("condition")] ref Debug.AssertInterpolatedStringHandler message)
		{
			Debug.Assert(condition, message.ToStringAndClear());
		}

		// Token: 0x06008900 RID: 35072 RVA: 0x0014D66C File Offset: 0x0014B86C
		[Conditional("DEBUG")]
		public static void Assert([DoesNotReturnIf(false)] bool condition, string message, string detailMessage)
		{
			if (!condition)
			{
				Debug.Fail(message, detailMessage);
			}
		}

		// Token: 0x06008901 RID: 35073 RVA: 0x0014D678 File Offset: 0x0014B878
		[Conditional("DEBUG")]
		public static void Assert([DoesNotReturnIf(false)] bool condition, [InterpolatedStringHandlerArgument("condition")] ref Debug.AssertInterpolatedStringHandler message, [InterpolatedStringHandlerArgument("condition")] ref Debug.AssertInterpolatedStringHandler detailMessage)
		{
			Debug.Assert(condition, message.ToStringAndClear(), detailMessage.ToStringAndClear());
		}

		// Token: 0x06008902 RID: 35074 RVA: 0x0014D68C File Offset: 0x0014B88C
		[NullableContext(1)]
		[Conditional("DEBUG")]
		public static void Assert([DoesNotReturnIf(false)] bool condition, [Nullable(2)] string message, [StringSyntax("CompositeFormat")] string detailMessageFormat, [Nullable(new byte[]
		{
			1,
			2
		})] params object[] args)
		{
			Debug.Assert(condition, message, string.Format(detailMessageFormat, args));
		}

		// Token: 0x06008903 RID: 35075 RVA: 0x0014D69C File Offset: 0x0014B89C
		internal static void ContractFailure(string message, string detailMessage, string failureKindMessage)
		{
			string stackTrace;
			try
			{
				stackTrace = new StackTrace(2, true).ToString(StackTrace.TraceFormat.Normal);
			}
			catch
			{
				stackTrace = "";
			}
			Debug.s_provider.WriteAssert(stackTrace, message, detailMessage);
			DebugProvider.FailCore(stackTrace, message, detailMessage, failureKindMessage);
		}

		// Token: 0x06008904 RID: 35076 RVA: 0x0014D6EC File Offset: 0x0014B8EC
		[Conditional("DEBUG")]
		[DoesNotReturn]
		public static void Fail(string message)
		{
			Debug.Fail(message, string.Empty);
		}

		// Token: 0x06008905 RID: 35077 RVA: 0x0014D6F9 File Offset: 0x0014B8F9
		[Conditional("DEBUG")]
		[DoesNotReturn]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Fail(string message, string detailMessage)
		{
			Debug.s_provider.Fail(message, detailMessage);
		}

		// Token: 0x06008906 RID: 35078 RVA: 0x0014D709 File Offset: 0x0014B909
		[Conditional("DEBUG")]
		public static void WriteLine(string message)
		{
			Debug.s_provider.WriteLine(message);
		}

		// Token: 0x06008907 RID: 35079 RVA: 0x0014D718 File Offset: 0x0014B918
		[Conditional("DEBUG")]
		public static void Write(string message)
		{
			Debug.s_provider.Write(message);
		}

		// Token: 0x06008908 RID: 35080 RVA: 0x0014D727 File Offset: 0x0014B927
		[Conditional("DEBUG")]
		public static void WriteLine(object value)
		{
			Debug.WriteLine((value != null) ? value.ToString() : null);
		}

		// Token: 0x06008909 RID: 35081 RVA: 0x0014D73A File Offset: 0x0014B93A
		[Conditional("DEBUG")]
		public static void WriteLine(object value, string category)
		{
			Debug.WriteLine((value != null) ? value.ToString() : null, category);
		}

		// Token: 0x0600890A RID: 35082 RVA: 0x0014D62F File Offset: 0x0014B82F
		[NullableContext(1)]
		[Conditional("DEBUG")]
		public static void WriteLine([StringSyntax("CompositeFormat")] string format, [Nullable(new byte[]
		{
			1,
			2
		})] params object[] args)
		{
			Debug.WriteLine(string.Format(null, format, args));
		}

		// Token: 0x0600890B RID: 35083 RVA: 0x0014D74E File Offset: 0x0014B94E
		[Conditional("DEBUG")]
		public static void WriteLine(string message, string category)
		{
			if (category == null)
			{
				Debug.WriteLine(message);
				return;
			}
			Debug.WriteLine(category + ": " + message);
		}

		// Token: 0x0600890C RID: 35084 RVA: 0x0014D76B File Offset: 0x0014B96B
		[Conditional("DEBUG")]
		public static void Write(object value)
		{
			Debug.Write((value != null) ? value.ToString() : null);
		}

		// Token: 0x0600890D RID: 35085 RVA: 0x0014D77E File Offset: 0x0014B97E
		[Conditional("DEBUG")]
		public static void Write(string message, string category)
		{
			if (category == null)
			{
				Debug.Write(message);
				return;
			}
			Debug.Write(category + ": " + message);
		}

		// Token: 0x0600890E RID: 35086 RVA: 0x0014D79B File Offset: 0x0014B99B
		[Conditional("DEBUG")]
		public static void Write(object value, string category)
		{
			Debug.Write((value != null) ? value.ToString() : null, category);
		}

		// Token: 0x0600890F RID: 35087 RVA: 0x0014D7AF File Offset: 0x0014B9AF
		[Conditional("DEBUG")]
		public static void WriteIf(bool condition, string message)
		{
			if (condition)
			{
				Debug.Write(message);
			}
		}

		// Token: 0x06008910 RID: 35088 RVA: 0x0014D7BA File Offset: 0x0014B9BA
		[Conditional("DEBUG")]
		public static void WriteIf(bool condition, [InterpolatedStringHandlerArgument("condition")] ref Debug.WriteIfInterpolatedStringHandler message)
		{
			Debug.WriteIf(condition, message.ToStringAndClear());
		}

		// Token: 0x06008911 RID: 35089 RVA: 0x0014D7C8 File Offset: 0x0014B9C8
		[Conditional("DEBUG")]
		public static void WriteIf(bool condition, object value)
		{
			if (condition)
			{
				Debug.Write(value);
			}
		}

		// Token: 0x06008912 RID: 35090 RVA: 0x0014D7D3 File Offset: 0x0014B9D3
		[Conditional("DEBUG")]
		public static void WriteIf(bool condition, string message, string category)
		{
			if (condition)
			{
				Debug.Write(message, category);
			}
		}

		// Token: 0x06008913 RID: 35091 RVA: 0x0014D7DF File Offset: 0x0014B9DF
		[Conditional("DEBUG")]
		public static void WriteIf(bool condition, [InterpolatedStringHandlerArgument("condition")] ref Debug.WriteIfInterpolatedStringHandler message, string category)
		{
			Debug.WriteIf(condition, message.ToStringAndClear(), category);
		}

		// Token: 0x06008914 RID: 35092 RVA: 0x0014D7EE File Offset: 0x0014B9EE
		[Conditional("DEBUG")]
		public static void WriteIf(bool condition, object value, string category)
		{
			if (condition)
			{
				Debug.Write(value, category);
			}
		}

		// Token: 0x06008915 RID: 35093 RVA: 0x0014D7FA File Offset: 0x0014B9FA
		[Conditional("DEBUG")]
		public static void WriteLineIf(bool condition, object value)
		{
			if (condition)
			{
				Debug.WriteLine(value);
			}
		}

		// Token: 0x06008916 RID: 35094 RVA: 0x0014D805 File Offset: 0x0014BA05
		[Conditional("DEBUG")]
		public static void WriteLineIf(bool condition, object value, string category)
		{
			if (condition)
			{
				Debug.WriteLine(value, category);
			}
		}

		// Token: 0x06008917 RID: 35095 RVA: 0x0014D811 File Offset: 0x0014BA11
		[Conditional("DEBUG")]
		public static void WriteLineIf(bool condition, string message)
		{
			if (condition)
			{
				Debug.WriteLine(message);
			}
		}

		// Token: 0x06008918 RID: 35096 RVA: 0x0014D81C File Offset: 0x0014BA1C
		[Conditional("DEBUG")]
		public static void WriteLineIf(bool condition, [InterpolatedStringHandlerArgument("condition")] ref Debug.WriteIfInterpolatedStringHandler message)
		{
			Debug.WriteLineIf(condition, message.ToStringAndClear());
		}

		// Token: 0x06008919 RID: 35097 RVA: 0x0014D82A File Offset: 0x0014BA2A
		[Conditional("DEBUG")]
		public static void WriteLineIf(bool condition, string message, string category)
		{
			if (condition)
			{
				Debug.WriteLine(message, category);
			}
		}

		// Token: 0x0600891A RID: 35098 RVA: 0x0014D836 File Offset: 0x0014BA36
		[Conditional("DEBUG")]
		public static void WriteLineIf(bool condition, [InterpolatedStringHandlerArgument("condition")] ref Debug.WriteIfInterpolatedStringHandler message, string category)
		{
			Debug.WriteLineIf(condition, message.ToStringAndClear(), category);
		}

		// Token: 0x04001E21 RID: 7713
		private static volatile DebugProvider s_provider = new DebugProvider();

		// Token: 0x04001E22 RID: 7714
		[ThreadStatic]
		private static int t_indentLevel;

		// Token: 0x04001E23 RID: 7715
		private static volatile int s_indentSize = 4;

		// Token: 0x0200087D RID: 2173
		[Nullable(0)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[InterpolatedStringHandler]
		public struct AssertInterpolatedStringHandler
		{
			// Token: 0x0600891C RID: 35100 RVA: 0x0014D85B File Offset: 0x0014BA5B
			public AssertInterpolatedStringHandler(int literalLength, int formattedCount, bool condition, out bool shouldAppend)
			{
				if (condition)
				{
					this._stringBuilderHandler = default(StringBuilder.AppendInterpolatedStringHandler);
					shouldAppend = false;
					return;
				}
				this._stringBuilderHandler = new StringBuilder.AppendInterpolatedStringHandler(literalLength, formattedCount, new StringBuilder());
				shouldAppend = true;
			}

			// Token: 0x0600891D RID: 35101 RVA: 0x0014D888 File Offset: 0x0014BA88
			internal string ToStringAndClear()
			{
				StringBuilder stringBuilder = this._stringBuilderHandler._stringBuilder;
				string result = (stringBuilder != null) ? stringBuilder.ToString() : string.Empty;
				this._stringBuilderHandler = default(StringBuilder.AppendInterpolatedStringHandler);
				return result;
			}

			// Token: 0x0600891E RID: 35102 RVA: 0x0014D8BD File Offset: 0x0014BABD
			[NullableContext(1)]
			public void AppendLiteral(string value)
			{
				this._stringBuilderHandler.AppendLiteral(value);
			}

			// Token: 0x0600891F RID: 35103 RVA: 0x0014D8CB File Offset: 0x0014BACB
			[NullableContext(1)]
			public void AppendFormatted<[Nullable(2)] T>(T value)
			{
				this._stringBuilderHandler.AppendFormatted<T>(value);
			}

			// Token: 0x06008920 RID: 35104 RVA: 0x0014D8D9 File Offset: 0x0014BAD9
			public void AppendFormatted<T>([Nullable(1)] T value, string format)
			{
				this._stringBuilderHandler.AppendFormatted<T>(value, format);
			}

			// Token: 0x06008921 RID: 35105 RVA: 0x0014D8E8 File Offset: 0x0014BAE8
			[NullableContext(1)]
			public void AppendFormatted<[Nullable(2)] T>(T value, int alignment)
			{
				this._stringBuilderHandler.AppendFormatted<T>(value, alignment);
			}

			// Token: 0x06008922 RID: 35106 RVA: 0x0014D8F7 File Offset: 0x0014BAF7
			public void AppendFormatted<T>([Nullable(1)] T value, int alignment, string format)
			{
				this._stringBuilderHandler.AppendFormatted<T>(value, alignment, format);
			}

			// Token: 0x06008923 RID: 35107 RVA: 0x0014D907 File Offset: 0x0014BB07
			[NullableContext(0)]
			public void AppendFormatted(ReadOnlySpan<char> value)
			{
				this._stringBuilderHandler.AppendFormatted(value);
			}

			// Token: 0x06008924 RID: 35108 RVA: 0x0014D915 File Offset: 0x0014BB15
			[NullableContext(0)]
			public void AppendFormatted(ReadOnlySpan<char> value, int alignment = 0, [Nullable(2)] string format = null)
			{
				this._stringBuilderHandler.AppendFormatted(value, alignment, format);
			}

			// Token: 0x06008925 RID: 35109 RVA: 0x0014D925 File Offset: 0x0014BB25
			public void AppendFormatted(string value)
			{
				this._stringBuilderHandler.AppendFormatted(value);
			}

			// Token: 0x06008926 RID: 35110 RVA: 0x0014D933 File Offset: 0x0014BB33
			public void AppendFormatted(string value, int alignment = 0, string format = null)
			{
				this._stringBuilderHandler.AppendFormatted(value, alignment, format);
			}

			// Token: 0x06008927 RID: 35111 RVA: 0x0014D943 File Offset: 0x0014BB43
			public void AppendFormatted(object value, int alignment = 0, string format = null)
			{
				this._stringBuilderHandler.AppendFormatted(value, alignment, format);
			}

			// Token: 0x04001E24 RID: 7716
			private StringBuilder.AppendInterpolatedStringHandler _stringBuilderHandler;
		}

		// Token: 0x0200087E RID: 2174
		[Nullable(0)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[InterpolatedStringHandler]
		public struct WriteIfInterpolatedStringHandler
		{
			// Token: 0x06008928 RID: 35112 RVA: 0x0014D953 File Offset: 0x0014BB53
			public WriteIfInterpolatedStringHandler(int literalLength, int formattedCount, bool condition, out bool shouldAppend)
			{
				if (condition)
				{
					this._stringBuilderHandler = new StringBuilder.AppendInterpolatedStringHandler(literalLength, formattedCount, StringBuilderCache.Acquire(DefaultInterpolatedStringHandler.GetDefaultLength(literalLength, formattedCount)));
					shouldAppend = true;
					return;
				}
				this._stringBuilderHandler = default(StringBuilder.AppendInterpolatedStringHandler);
				shouldAppend = false;
			}

			// Token: 0x06008929 RID: 35113 RVA: 0x0014D988 File Offset: 0x0014BB88
			internal string ToStringAndClear()
			{
				StringBuilder stringBuilder = this._stringBuilderHandler._stringBuilder;
				string result = (stringBuilder != null) ? StringBuilderCache.GetStringAndRelease(stringBuilder) : string.Empty;
				this._stringBuilderHandler = default(StringBuilder.AppendInterpolatedStringHandler);
				return result;
			}

			// Token: 0x0600892A RID: 35114 RVA: 0x0014D9BD File Offset: 0x0014BBBD
			[NullableContext(1)]
			public void AppendLiteral(string value)
			{
				this._stringBuilderHandler.AppendLiteral(value);
			}

			// Token: 0x0600892B RID: 35115 RVA: 0x0014D9CB File Offset: 0x0014BBCB
			[NullableContext(1)]
			public void AppendFormatted<[Nullable(2)] T>(T value)
			{
				this._stringBuilderHandler.AppendFormatted<T>(value);
			}

			// Token: 0x0600892C RID: 35116 RVA: 0x0014D9D9 File Offset: 0x0014BBD9
			public void AppendFormatted<T>([Nullable(1)] T value, string format)
			{
				this._stringBuilderHandler.AppendFormatted<T>(value, format);
			}

			// Token: 0x0600892D RID: 35117 RVA: 0x0014D9E8 File Offset: 0x0014BBE8
			[NullableContext(1)]
			public void AppendFormatted<[Nullable(2)] T>(T value, int alignment)
			{
				this._stringBuilderHandler.AppendFormatted<T>(value, alignment);
			}

			// Token: 0x0600892E RID: 35118 RVA: 0x0014D9F7 File Offset: 0x0014BBF7
			public void AppendFormatted<T>([Nullable(1)] T value, int alignment, string format)
			{
				this._stringBuilderHandler.AppendFormatted<T>(value, alignment, format);
			}

			// Token: 0x0600892F RID: 35119 RVA: 0x0014DA07 File Offset: 0x0014BC07
			[NullableContext(0)]
			public void AppendFormatted(ReadOnlySpan<char> value)
			{
				this._stringBuilderHandler.AppendFormatted(value);
			}

			// Token: 0x06008930 RID: 35120 RVA: 0x0014DA15 File Offset: 0x0014BC15
			[NullableContext(0)]
			public void AppendFormatted(ReadOnlySpan<char> value, int alignment = 0, [Nullable(2)] string format = null)
			{
				this._stringBuilderHandler.AppendFormatted(value, alignment, format);
			}

			// Token: 0x06008931 RID: 35121 RVA: 0x0014DA25 File Offset: 0x0014BC25
			public void AppendFormatted(string value)
			{
				this._stringBuilderHandler.AppendFormatted(value);
			}

			// Token: 0x06008932 RID: 35122 RVA: 0x0014DA33 File Offset: 0x0014BC33
			public void AppendFormatted(string value, int alignment = 0, string format = null)
			{
				this._stringBuilderHandler.AppendFormatted(value, alignment, format);
			}

			// Token: 0x06008933 RID: 35123 RVA: 0x0014DA43 File Offset: 0x0014BC43
			public void AppendFormatted(object value, int alignment = 0, string format = null)
			{
				this._stringBuilderHandler.AppendFormatted(value, alignment, format);
			}

			// Token: 0x04001E25 RID: 7717
			private StringBuilder.AppendInterpolatedStringHandler _stringBuilderHandler;
		}
	}
}
