using System;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x02000741 RID: 1857
	[NullableContext(2)]
	[Nullable(0)]
	public class ExceptionHandlingClause
	{
		// Token: 0x06007902 RID: 30978 RVA: 0x00005ACC File Offset: 0x00003CCC
		protected ExceptionHandlingClause()
		{
		}

		// Token: 0x17000F6A RID: 3946
		// (get) Token: 0x06007903 RID: 30979 RVA: 0x00007B65 File Offset: 0x00005D65
		public virtual ExceptionHandlingClauseOptions Flags
		{
			get
			{
				return ExceptionHandlingClauseOptions.Clause;
			}
		}

		// Token: 0x17000F6B RID: 3947
		// (get) Token: 0x06007904 RID: 30980 RVA: 0x00007B65 File Offset: 0x00005D65
		public virtual int TryOffset
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000F6C RID: 3948
		// (get) Token: 0x06007905 RID: 30981 RVA: 0x00007B65 File Offset: 0x00005D65
		public virtual int TryLength
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000F6D RID: 3949
		// (get) Token: 0x06007906 RID: 30982 RVA: 0x00007B65 File Offset: 0x00005D65
		public virtual int HandlerOffset
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000F6E RID: 3950
		// (get) Token: 0x06007907 RID: 30983 RVA: 0x00007B65 File Offset: 0x00005D65
		public virtual int HandlerLength
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000F6F RID: 3951
		// (get) Token: 0x06007908 RID: 30984 RVA: 0x0011F470 File Offset: 0x0011D670
		public virtual int FilterOffset
		{
			get
			{
				throw new InvalidOperationException(SR.Arg_EHClauseNotFilter);
			}
		}

		// Token: 0x17000F70 RID: 3952
		// (get) Token: 0x06007909 RID: 30985 RVA: 0x0001A4BA File Offset: 0x000186BA
		public virtual Type CatchType
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0600790A RID: 30986 RVA: 0x0011F47C File Offset: 0x0011D67C
		[NullableContext(1)]
		public override string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(74, 6);
			defaultInterpolatedStringHandler.AppendLiteral("Flags=");
			defaultInterpolatedStringHandler.AppendFormatted<ExceptionHandlingClauseOptions>(this.Flags);
			defaultInterpolatedStringHandler.AppendLiteral(", TryOffset=");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.TryOffset);
			defaultInterpolatedStringHandler.AppendLiteral(", TryLength=");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.TryLength);
			defaultInterpolatedStringHandler.AppendLiteral(", HandlerOffset=");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.HandlerOffset);
			defaultInterpolatedStringHandler.AppendLiteral(", HandlerLength=");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.HandlerLength);
			defaultInterpolatedStringHandler.AppendLiteral(", CatchType=");
			defaultInterpolatedStringHandler.AppendFormatted<Type>(this.CatchType);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
	}
}
