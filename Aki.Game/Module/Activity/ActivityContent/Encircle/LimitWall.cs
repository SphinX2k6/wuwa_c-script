using System;
using System.Runtime.CompilerServices;

namespace Aki.Game.Module.Activity.ActivityContent.Encircle
{
	// Token: 0x02003012 RID: 12306
	[NullableContext(2)]
	[Nullable(0)]
	public class LimitWall
	{
		// Token: 0x0601D31E RID: 119582 RVA: 0x008E9A83 File Offset: 0x008E7C83
		[NullableContext(1)]
		public LimitWall(IHexPos pos, int limitRound)
		{
			this.PosInternal = pos;
			this.LimitRoundInternal = limitRound;
		}

		// Token: 0x17002E67 RID: 11879
		// (get) Token: 0x0601D31F RID: 119583 RVA: 0x008E9A99 File Offset: 0x008E7C99
		// (set) Token: 0x0601D320 RID: 119584 RVA: 0x008E9AA1 File Offset: 0x008E7CA1
		public IHexPos Pos
		{
			get
			{
				return this.PosInternal;
			}
			set
			{
				this.PosInternal = value;
			}
		}

		// Token: 0x17002E68 RID: 11880
		// (get) Token: 0x0601D321 RID: 119585 RVA: 0x008E9AAA File Offset: 0x008E7CAA
		// (set) Token: 0x0601D322 RID: 119586 RVA: 0x008E9AB2 File Offset: 0x008E7CB2
		public int LimitRound
		{
			get
			{
				return this.LimitRoundInternal;
			}
			set
			{
				this.LimitRoundInternal = value;
			}
		}

		// Token: 0x0400F5CE RID: 62926
		private IHexPos PosInternal;

		// Token: 0x0400F5CF RID: 62927
		private int LimitRoundInternal;
	}
}
