using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006342 RID: 25410
	public class IAirCurrentDataT
	{
		// Token: 0x1700BBDA RID: 48090
		// (get) Token: 0x0602B165 RID: 176485 RVA: 0x005DF7A5 File Offset: 0x005DD9A5
		// (set) Token: 0x0602B166 RID: 176486 RVA: 0x005DF7AD File Offset: 0x005DD9AD
		public EAreaFunctionType Type { get; set; }

		// Token: 0x1700BBDB RID: 48091
		// (get) Token: 0x0602B167 RID: 176487 RVA: 0x005DF7B6 File Offset: 0x005DD9B6
		// (set) Token: 0x0602B168 RID: 176488 RVA: 0x005DF7BE File Offset: 0x005DD9BE
		public float ExitEffectHeight { get; set; }

		// Token: 0x1700BBDC RID: 48092
		// (get) Token: 0x0602B169 RID: 176489 RVA: 0x005DF7C7 File Offset: 0x005DD9C7
		// (set) Token: 0x0602B16A RID: 176490 RVA: 0x005DF7CF File Offset: 0x005DD9CF
		public float EffectiveHeight { get; set; }

		// Token: 0x1700BBDD RID: 48093
		// (get) Token: 0x0602B16B RID: 176491 RVA: 0x005DF7D8 File Offset: 0x005DD9D8
		// (set) Token: 0x0602B16C RID: 176492 RVA: 0x005DF7E0 File Offset: 0x005DD9E0
		public float FallTeleportHeight { get; set; }

		// Token: 0x1700BBDE RID: 48094
		// (get) Token: 0x0602B16D RID: 176493 RVA: 0x005DF7E9 File Offset: 0x005DD9E9
		// (set) Token: 0x0602B16E RID: 176494 RVA: 0x005DF7F1 File Offset: 0x005DD9F1
		public int FallTeleportTransitionConfigId { get; set; }

		// Token: 0x1700BBDF RID: 48095
		// (get) Token: 0x0602B16F RID: 176495 RVA: 0x005DF7FA File Offset: 0x005DD9FA
		// (set) Token: 0x0602B170 RID: 176496 RVA: 0x005DF802 File Offset: 0x005DDA02
		public float TopTeleportHeight { get; set; }

		// Token: 0x1700BBE0 RID: 48096
		// (get) Token: 0x0602B171 RID: 176497 RVA: 0x005DF80B File Offset: 0x005DDA0B
		// (set) Token: 0x0602B172 RID: 176498 RVA: 0x005DF813 File Offset: 0x005DDA13
		public IMotorAirCurrentConfigT Motor { get; set; }

		// Token: 0x1700BBE1 RID: 48097
		// (get) Token: 0x0602B173 RID: 176499 RVA: 0x005DF81C File Offset: 0x005DDA1C
		// (set) Token: 0x0602B174 RID: 176500 RVA: 0x005DF824 File Offset: 0x005DDA24
		public ICharacterAirCurrentConfigT Character { get; set; }

		// Token: 0x1700BBE2 RID: 48098
		// (get) Token: 0x0602B175 RID: 176501 RVA: 0x005DF82D File Offset: 0x005DDA2D
		// (set) Token: 0x0602B176 RID: 176502 RVA: 0x005DF835 File Offset: 0x005DDA35
		public byte NullMask { get; set; }

		// Token: 0x0602B177 RID: 176503 RVA: 0x005DF840 File Offset: 0x005DDA40
		public IAirCurrentDataT()
		{
			this.Type = EAreaFunctionType.AirCurrent;
			this.ExitEffectHeight = 0f;
			this.EffectiveHeight = 0f;
			this.FallTeleportHeight = 0f;
			this.FallTeleportTransitionConfigId = 0;
			this.TopTeleportHeight = 0f;
			this.Motor = null;
			this.Character = null;
			this.NullMask = 0;
		}
	}
}
