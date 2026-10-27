using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Encircle
{
	// Token: 0x02006664 RID: 26212
	[NullableContext(2)]
	[Nullable(0)]
	public class LimitWall
	{
		// Token: 0x06041AFF RID: 269055 RVA: 0x00FEDFB7 File Offset: 0x00FEC1B7
		[NullableContext(1)]
		public LimitWall(IHexPos pos, int limitRound)
		{
			this.PosInternal = pos;
			this.LimitRoundInternal = limitRound;
		}

		// Token: 0x17009637 RID: 38455
		// (get) Token: 0x06041B00 RID: 269056 RVA: 0x00FEDFCD File Offset: 0x00FEC1CD
		// (set) Token: 0x06041B01 RID: 269057 RVA: 0x00FEDFD5 File Offset: 0x00FEC1D5
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

		// Token: 0x17009638 RID: 38456
		// (get) Token: 0x06041B02 RID: 269058 RVA: 0x00FEDFDE File Offset: 0x00FEC1DE
		// (set) Token: 0x06041B03 RID: 269059 RVA: 0x00FEDFE6 File Offset: 0x00FEC1E6
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

		// Token: 0x040222C4 RID: 139972
		private IHexPos PosInternal;

		// Token: 0x040222C5 RID: 139973
		private int LimitRoundInternal;
	}
}
