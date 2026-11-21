using System;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x02000753 RID: 1875
	[NullableContext(1)]
	[Nullable(0)]
	public class LocalVariableInfo
	{
		// Token: 0x17000F72 RID: 3954
		// (get) Token: 0x06007933 RID: 31027 RVA: 0x0001A4BA File Offset: 0x000186BA
		public virtual Type LocalType
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F73 RID: 3955
		// (get) Token: 0x06007934 RID: 31028 RVA: 0x00007B65 File Offset: 0x00005D65
		public virtual int LocalIndex
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000F74 RID: 3956
		// (get) Token: 0x06007935 RID: 31029 RVA: 0x00007B65 File Offset: 0x00005D65
		public virtual bool IsPinned
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06007936 RID: 31030 RVA: 0x00005ACC File Offset: 0x00003CCC
		protected LocalVariableInfo()
		{
		}

		// Token: 0x06007937 RID: 31031 RVA: 0x0011FEA8 File Offset: 0x0011E0A8
		public override string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
			if (!this.IsPinned)
			{
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 2);
				defaultInterpolatedStringHandler.AppendFormatted<Type>(this.LocalType);
				defaultInterpolatedStringHandler.AppendLiteral(" (");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.LocalIndex);
				defaultInterpolatedStringHandler.AppendLiteral(")");
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 2);
			defaultInterpolatedStringHandler.AppendFormatted<Type>(this.LocalType);
			defaultInterpolatedStringHandler.AppendLiteral(" (");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.LocalIndex);
			defaultInterpolatedStringHandler.AppendLiteral(") (pinned)");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
	}
}
