using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.CodeDom.Compiler
{
	// Token: 0x0200032E RID: 814
	[NullableContext(1)]
	[Nullable(0)]
	public class IndentedTextWriter : TextWriter
	{
		// Token: 0x06003A32 RID: 14898 RVA: 0x000C16B8 File Offset: 0x000BF8B8
		public IndentedTextWriter(TextWriter writer) : this(writer, "    ")
		{
		}

		// Token: 0x06003A33 RID: 14899 RVA: 0x000C16C6 File Offset: 0x000BF8C6
		public IndentedTextWriter(TextWriter writer, string tabString) : base(CultureInfo.InvariantCulture)
		{
			ArgumentNullException.ThrowIfNull(writer, "writer");
			this._writer = writer;
			this._tabString = tabString;
			this._tabsPending = true;
		}

		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x06003A34 RID: 14900 RVA: 0x000C16F3 File Offset: 0x000BF8F3
		public override Encoding Encoding
		{
			get
			{
				return this._writer.Encoding;
			}
		}

		// Token: 0x17000B0C RID: 2828
		// (get) Token: 0x06003A35 RID: 14901 RVA: 0x000C1700 File Offset: 0x000BF900
		// (set) Token: 0x06003A36 RID: 14902 RVA: 0x000C170D File Offset: 0x000BF90D
		public override string NewLine
		{
			get
			{
				return this._writer.NewLine;
			}
			[param: AllowNull]
			set
			{
				this._writer.NewLine = value;
			}
		}

		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x06003A37 RID: 14903 RVA: 0x000C171B File Offset: 0x000BF91B
		// (set) Token: 0x06003A38 RID: 14904 RVA: 0x000C1723 File Offset: 0x000BF923
		public int Indent
		{
			get
			{
				return this._indentLevel;
			}
			set
			{
				this._indentLevel = Math.Max(value, 0);
			}
		}

		// Token: 0x17000B0E RID: 2830
		// (get) Token: 0x06003A39 RID: 14905 RVA: 0x000C1732 File Offset: 0x000BF932
		public TextWriter InnerWriter
		{
			get
			{
				return this._writer;
			}
		}

		// Token: 0x06003A3A RID: 14906 RVA: 0x000C173A File Offset: 0x000BF93A
		public override void Close()
		{
			this._writer.Close();
		}

		// Token: 0x06003A3B RID: 14907 RVA: 0x000C1747 File Offset: 0x000BF947
		public override ValueTask DisposeAsync()
		{
			return this._writer.DisposeAsync();
		}

		// Token: 0x06003A3C RID: 14908 RVA: 0x000C1754 File Offset: 0x000BF954
		public override void Flush()
		{
			this._writer.Flush();
		}

		// Token: 0x06003A3D RID: 14909 RVA: 0x000C1761 File Offset: 0x000BF961
		public override Task FlushAsync()
		{
			return this._writer.FlushAsync();
		}

		// Token: 0x06003A3E RID: 14910 RVA: 0x000C176E File Offset: 0x000BF96E
		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled(cancellationToken);
			}
			if (!(base.GetType() != typeof(IndentedTextWriter)))
			{
				return this._writer.FlushAsync(cancellationToken);
			}
			return this.FlushAsync();
		}

		// Token: 0x06003A3F RID: 14911 RVA: 0x000C17AC File Offset: 0x000BF9AC
		protected virtual void OutputTabs()
		{
			if (this._tabsPending)
			{
				for (int i = 0; i < this._indentLevel; i++)
				{
					this._writer.Write(this._tabString);
				}
				this._tabsPending = false;
			}
		}

		// Token: 0x06003A40 RID: 14912 RVA: 0x000C17EC File Offset: 0x000BF9EC
		protected virtual Task OutputTabsAsync()
		{
			IndentedTextWriter.<OutputTabsAsync>d__23 <OutputTabsAsync>d__;
			<OutputTabsAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<OutputTabsAsync>d__.<>4__this = this;
			<OutputTabsAsync>d__.<>1__state = -1;
			<OutputTabsAsync>d__.<>t__builder.Start<IndentedTextWriter.<OutputTabsAsync>d__23>(ref <OutputTabsAsync>d__);
			return <OutputTabsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06003A41 RID: 14913 RVA: 0x000C182F File Offset: 0x000BFA2F
		[NullableContext(2)]
		public override void Write(string s)
		{
			this.OutputTabs();
			this._writer.Write(s);
		}

		// Token: 0x06003A42 RID: 14914 RVA: 0x000C1843 File Offset: 0x000BFA43
		public override void Write(bool value)
		{
			this.OutputTabs();
			this._writer.Write(value);
		}

		// Token: 0x06003A43 RID: 14915 RVA: 0x000C1857 File Offset: 0x000BFA57
		public override void Write(char value)
		{
			this.OutputTabs();
			this._writer.Write(value);
		}

		// Token: 0x06003A44 RID: 14916 RVA: 0x000C186B File Offset: 0x000BFA6B
		[NullableContext(2)]
		public override void Write(char[] buffer)
		{
			this.OutputTabs();
			this._writer.Write(buffer);
		}

		// Token: 0x06003A45 RID: 14917 RVA: 0x000C187F File Offset: 0x000BFA7F
		public override void Write(char[] buffer, int index, int count)
		{
			this.OutputTabs();
			this._writer.Write(buffer, index, count);
		}

		// Token: 0x06003A46 RID: 14918 RVA: 0x000C1895 File Offset: 0x000BFA95
		public override void Write(double value)
		{
			this.OutputTabs();
			this._writer.Write(value);
		}

		// Token: 0x06003A47 RID: 14919 RVA: 0x000C18A9 File Offset: 0x000BFAA9
		public override void Write(float value)
		{
			this.OutputTabs();
			this._writer.Write(value);
		}

		// Token: 0x06003A48 RID: 14920 RVA: 0x000C18BD File Offset: 0x000BFABD
		public override void Write(int value)
		{
			this.OutputTabs();
			this._writer.Write(value);
		}

		// Token: 0x06003A49 RID: 14921 RVA: 0x000C18D1 File Offset: 0x000BFAD1
		public override void Write(long value)
		{
			this.OutputTabs();
			this._writer.Write(value);
		}

		// Token: 0x06003A4A RID: 14922 RVA: 0x000C18E5 File Offset: 0x000BFAE5
		[NullableContext(2)]
		public override void Write(object value)
		{
			this.OutputTabs();
			this._writer.Write(value);
		}

		// Token: 0x06003A4B RID: 14923 RVA: 0x000C18F9 File Offset: 0x000BFAF9
		public override void Write([StringSyntax("CompositeFormat")] string format, [Nullable(2)] object arg0)
		{
			this.OutputTabs();
			this._writer.Write(format, arg0);
		}

		// Token: 0x06003A4C RID: 14924 RVA: 0x000C190E File Offset: 0x000BFB0E
		[NullableContext(2)]
		public override void Write([Nullable(1)] [StringSyntax("CompositeFormat")] string format, object arg0, object arg1)
		{
			this.OutputTabs();
			this._writer.Write(format, arg0, arg1);
		}

		// Token: 0x06003A4D RID: 14925 RVA: 0x000C1924 File Offset: 0x000BFB24
		public override void Write([StringSyntax("CompositeFormat")] string format, [Nullable(new byte[]
		{
			1,
			2
		})] params object[] arg)
		{
			this.OutputTabs();
			this._writer.Write(format, arg);
		}

		// Token: 0x06003A4E RID: 14926 RVA: 0x000C1939 File Offset: 0x000BFB39
		public override void Write([StringSyntax("CompositeFormat")] string format, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			2
		})] ReadOnlySpan<object> arg)
		{
			this.OutputTabs();
			this._writer.Write(format, arg);
		}

		// Token: 0x06003A4F RID: 14927 RVA: 0x000C1950 File Offset: 0x000BFB50
		public override Task WriteAsync(char value)
		{
			IndentedTextWriter.<WriteAsync>d__38 <WriteAsync>d__;
			<WriteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteAsync>d__.<>4__this = this;
			<WriteAsync>d__.value = value;
			<WriteAsync>d__.<>1__state = -1;
			<WriteAsync>d__.<>t__builder.Start<IndentedTextWriter.<WriteAsync>d__38>(ref <WriteAsync>d__);
			return <WriteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06003A50 RID: 14928 RVA: 0x000C199C File Offset: 0x000BFB9C
		public override Task WriteAsync(char[] buffer, int index, int count)
		{
			IndentedTextWriter.<WriteAsync>d__39 <WriteAsync>d__;
			<WriteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteAsync>d__.<>4__this = this;
			<WriteAsync>d__.buffer = buffer;
			<WriteAsync>d__.index = index;
			<WriteAsync>d__.count = count;
			<WriteAsync>d__.<>1__state = -1;
			<WriteAsync>d__.<>t__builder.Start<IndentedTextWriter.<WriteAsync>d__39>(ref <WriteAsync>d__);
			return <WriteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06003A51 RID: 14929 RVA: 0x000C19F8 File Offset: 0x000BFBF8
		public override Task WriteAsync([Nullable(2)] string value)
		{
			IndentedTextWriter.<WriteAsync>d__40 <WriteAsync>d__;
			<WriteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteAsync>d__.<>4__this = this;
			<WriteAsync>d__.value = value;
			<WriteAsync>d__.<>1__state = -1;
			<WriteAsync>d__.<>t__builder.Start<IndentedTextWriter.<WriteAsync>d__40>(ref <WriteAsync>d__);
			return <WriteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06003A52 RID: 14930 RVA: 0x000C1A44 File Offset: 0x000BFC44
		[NullableContext(0)]
		[return: Nullable(1)]
		public override Task WriteAsync(ReadOnlyMemory<char> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			IndentedTextWriter.<WriteAsync>d__41 <WriteAsync>d__;
			<WriteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteAsync>d__.<>4__this = this;
			<WriteAsync>d__.buffer = buffer;
			<WriteAsync>d__.cancellationToken = cancellationToken;
			<WriteAsync>d__.<>1__state = -1;
			<WriteAsync>d__.<>t__builder.Start<IndentedTextWriter.<WriteAsync>d__41>(ref <WriteAsync>d__);
			return <WriteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06003A53 RID: 14931 RVA: 0x000C1A98 File Offset: 0x000BFC98
		public override Task WriteAsync([Nullable(2)] StringBuilder value, CancellationToken cancellationToken = default(CancellationToken))
		{
			IndentedTextWriter.<WriteAsync>d__42 <WriteAsync>d__;
			<WriteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteAsync>d__.<>4__this = this;
			<WriteAsync>d__.value = value;
			<WriteAsync>d__.cancellationToken = cancellationToken;
			<WriteAsync>d__.<>1__state = -1;
			<WriteAsync>d__.<>t__builder.Start<IndentedTextWriter.<WriteAsync>d__42>(ref <WriteAsync>d__);
			return <WriteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06003A54 RID: 14932 RVA: 0x000C1AEB File Offset: 0x000BFCEB
		[NullableContext(2)]
		public void WriteLineNoTabs(string s)
		{
			this._writer.WriteLine(s);
		}

		// Token: 0x06003A55 RID: 14933 RVA: 0x000C1AF9 File Offset: 0x000BFCF9
		public Task WriteLineNoTabsAsync([Nullable(2)] string s)
		{
			return this._writer.WriteLineAsync(s);
		}

		// Token: 0x06003A56 RID: 14934 RVA: 0x000C1B07 File Offset: 0x000BFD07
		[NullableContext(2)]
		public override void WriteLine(string s)
		{
			this.OutputTabs();
			this._writer.WriteLine(s);
			this._tabsPending = true;
		}

		// Token: 0x06003A57 RID: 14935 RVA: 0x000C1B22 File Offset: 0x000BFD22
		public override void WriteLine()
		{
			this.OutputTabs();
			this._writer.WriteLine();
			this._tabsPending = true;
		}

		// Token: 0x06003A58 RID: 14936 RVA: 0x000C1B3C File Offset: 0x000BFD3C
		public override void WriteLine(bool value)
		{
			this.OutputTabs();
			this._writer.WriteLine(value);
			this._tabsPending = true;
		}

		// Token: 0x06003A59 RID: 14937 RVA: 0x000C1B57 File Offset: 0x000BFD57
		public override void WriteLine(char value)
		{
			this.OutputTabs();
			this._writer.WriteLine(value);
			this._tabsPending = true;
		}

		// Token: 0x06003A5A RID: 14938 RVA: 0x000C1B72 File Offset: 0x000BFD72
		[NullableContext(2)]
		public override void WriteLine(char[] buffer)
		{
			this.OutputTabs();
			this._writer.WriteLine(buffer);
			this._tabsPending = true;
		}

		// Token: 0x06003A5B RID: 14939 RVA: 0x000C1B8D File Offset: 0x000BFD8D
		public override void WriteLine(char[] buffer, int index, int count)
		{
			this.OutputTabs();
			this._writer.WriteLine(buffer, index, count);
			this._tabsPending = true;
		}

		// Token: 0x06003A5C RID: 14940 RVA: 0x000C1BAA File Offset: 0x000BFDAA
		public override void WriteLine(double value)
		{
			this.OutputTabs();
			this._writer.WriteLine(value);
			this._tabsPending = true;
		}

		// Token: 0x06003A5D RID: 14941 RVA: 0x000C1BC5 File Offset: 0x000BFDC5
		public override void WriteLine(float value)
		{
			this.OutputTabs();
			this._writer.WriteLine(value);
			this._tabsPending = true;
		}

		// Token: 0x06003A5E RID: 14942 RVA: 0x000C1BE0 File Offset: 0x000BFDE0
		public override void WriteLine(int value)
		{
			this.OutputTabs();
			this._writer.WriteLine(value);
			this._tabsPending = true;
		}

		// Token: 0x06003A5F RID: 14943 RVA: 0x000C1BFB File Offset: 0x000BFDFB
		public override void WriteLine(long value)
		{
			this.OutputTabs();
			this._writer.WriteLine(value);
			this._tabsPending = true;
		}

		// Token: 0x06003A60 RID: 14944 RVA: 0x000C1C16 File Offset: 0x000BFE16
		[NullableContext(2)]
		public override void WriteLine(object value)
		{
			this.OutputTabs();
			this._writer.WriteLine(value);
			this._tabsPending = true;
		}

		// Token: 0x06003A61 RID: 14945 RVA: 0x000C1C31 File Offset: 0x000BFE31
		public override void WriteLine([StringSyntax("CompositeFormat")] string format, [Nullable(2)] object arg0)
		{
			this.OutputTabs();
			this._writer.WriteLine(format, arg0);
			this._tabsPending = true;
		}

		// Token: 0x06003A62 RID: 14946 RVA: 0x000C1C4D File Offset: 0x000BFE4D
		[NullableContext(2)]
		public override void WriteLine([Nullable(1)] [StringSyntax("CompositeFormat")] string format, object arg0, object arg1)
		{
			this.OutputTabs();
			this._writer.WriteLine(format, arg0, arg1);
			this._tabsPending = true;
		}

		// Token: 0x06003A63 RID: 14947 RVA: 0x000C1C6A File Offset: 0x000BFE6A
		public override void WriteLine([StringSyntax("CompositeFormat")] string format, [Nullable(new byte[]
		{
			1,
			2
		})] params object[] arg)
		{
			this.OutputTabs();
			this._writer.WriteLine(format, arg);
			this._tabsPending = true;
		}

		// Token: 0x06003A64 RID: 14948 RVA: 0x000C1C86 File Offset: 0x000BFE86
		public override void WriteLine([StringSyntax("CompositeFormat")] string format, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			2
		})] ReadOnlySpan<object> arg)
		{
			this.OutputTabs();
			this._writer.WriteLine(format, arg);
			this._tabsPending = true;
		}

		// Token: 0x06003A65 RID: 14949 RVA: 0x000C1CA2 File Offset: 0x000BFEA2
		[CLSCompliant(false)]
		public override void WriteLine(uint value)
		{
			this.OutputTabs();
			this._writer.WriteLine(value);
			this._tabsPending = true;
		}

		// Token: 0x06003A66 RID: 14950 RVA: 0x000C1CC0 File Offset: 0x000BFEC0
		public override Task WriteLineAsync()
		{
			IndentedTextWriter.<WriteLineAsync>d__61 <WriteLineAsync>d__;
			<WriteLineAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteLineAsync>d__.<>4__this = this;
			<WriteLineAsync>d__.<>1__state = -1;
			<WriteLineAsync>d__.<>t__builder.Start<IndentedTextWriter.<WriteLineAsync>d__61>(ref <WriteLineAsync>d__);
			return <WriteLineAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06003A67 RID: 14951 RVA: 0x000C1D04 File Offset: 0x000BFF04
		public override Task WriteLineAsync(char value)
		{
			IndentedTextWriter.<WriteLineAsync>d__62 <WriteLineAsync>d__;
			<WriteLineAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteLineAsync>d__.<>4__this = this;
			<WriteLineAsync>d__.value = value;
			<WriteLineAsync>d__.<>1__state = -1;
			<WriteLineAsync>d__.<>t__builder.Start<IndentedTextWriter.<WriteLineAsync>d__62>(ref <WriteLineAsync>d__);
			return <WriteLineAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06003A68 RID: 14952 RVA: 0x000C1D50 File Offset: 0x000BFF50
		public override Task WriteLineAsync(char[] buffer, int index, int count)
		{
			IndentedTextWriter.<WriteLineAsync>d__63 <WriteLineAsync>d__;
			<WriteLineAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteLineAsync>d__.<>4__this = this;
			<WriteLineAsync>d__.buffer = buffer;
			<WriteLineAsync>d__.index = index;
			<WriteLineAsync>d__.count = count;
			<WriteLineAsync>d__.<>1__state = -1;
			<WriteLineAsync>d__.<>t__builder.Start<IndentedTextWriter.<WriteLineAsync>d__63>(ref <WriteLineAsync>d__);
			return <WriteLineAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06003A69 RID: 14953 RVA: 0x000C1DAC File Offset: 0x000BFFAC
		public override Task WriteLineAsync([Nullable(2)] string value)
		{
			IndentedTextWriter.<WriteLineAsync>d__64 <WriteLineAsync>d__;
			<WriteLineAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteLineAsync>d__.<>4__this = this;
			<WriteLineAsync>d__.value = value;
			<WriteLineAsync>d__.<>1__state = -1;
			<WriteLineAsync>d__.<>t__builder.Start<IndentedTextWriter.<WriteLineAsync>d__64>(ref <WriteLineAsync>d__);
			return <WriteLineAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06003A6A RID: 14954 RVA: 0x000C1DF8 File Offset: 0x000BFFF8
		[NullableContext(0)]
		[return: Nullable(1)]
		public override Task WriteLineAsync(ReadOnlyMemory<char> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			IndentedTextWriter.<WriteLineAsync>d__65 <WriteLineAsync>d__;
			<WriteLineAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteLineAsync>d__.<>4__this = this;
			<WriteLineAsync>d__.buffer = buffer;
			<WriteLineAsync>d__.cancellationToken = cancellationToken;
			<WriteLineAsync>d__.<>1__state = -1;
			<WriteLineAsync>d__.<>t__builder.Start<IndentedTextWriter.<WriteLineAsync>d__65>(ref <WriteLineAsync>d__);
			return <WriteLineAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06003A6B RID: 14955 RVA: 0x000C1E4C File Offset: 0x000C004C
		public override Task WriteLineAsync([Nullable(2)] StringBuilder value, CancellationToken cancellationToken = default(CancellationToken))
		{
			IndentedTextWriter.<WriteLineAsync>d__66 <WriteLineAsync>d__;
			<WriteLineAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteLineAsync>d__.<>4__this = this;
			<WriteLineAsync>d__.value = value;
			<WriteLineAsync>d__.cancellationToken = cancellationToken;
			<WriteLineAsync>d__.<>1__state = -1;
			<WriteLineAsync>d__.<>t__builder.Start<IndentedTextWriter.<WriteLineAsync>d__66>(ref <WriteLineAsync>d__);
			return <WriteLineAsync>d__.<>t__builder.Task;
		}

		// Token: 0x04000BE8 RID: 3048
		private readonly TextWriter _writer;

		// Token: 0x04000BE9 RID: 3049
		private readonly string _tabString;

		// Token: 0x04000BEA RID: 3050
		private int _indentLevel;

		// Token: 0x04000BEB RID: 3051
		private bool _tabsPending;

		// Token: 0x04000BEC RID: 3052
		public const string DefaultTabString = "    ";
	}
}
