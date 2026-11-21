using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BC5 RID: 23493
	public class INpcModelT
	{
		// Token: 0x1700ABBF RID: 43967
		// (get) Token: 0x06026BF4 RID: 158708 RVA: 0x0054DC8A File Offset: 0x0054BE8A
		// (set) Token: 0x06026BF5 RID: 158709 RVA: 0x0054DC92 File Offset: 0x0054BE92
		public EModelType Type { get; set; }

		// Token: 0x1700ABC0 RID: 43968
		// (get) Token: 0x06026BF6 RID: 158710 RVA: 0x0054DC9B File Offset: 0x0054BE9B
		// (set) Token: 0x06026BF7 RID: 158711 RVA: 0x0054DCA3 File Offset: 0x0054BEA3
		public string BlueprintPath { get; set; }

		// Token: 0x1700ABC1 RID: 43969
		// (get) Token: 0x06026BF8 RID: 158712 RVA: 0x0054DCAC File Offset: 0x0054BEAC
		// (set) Token: 0x06026BF9 RID: 158713 RVA: 0x0054DCB4 File Offset: 0x0054BEB4
		public TNpcModelTypeUnion NpcModel { get; set; }

		// Token: 0x1700ABC2 RID: 43970
		// (get) Token: 0x06026BFA RID: 158714 RVA: 0x0054DCBD File Offset: 0x0054BEBD
		// (set) Token: 0x06026BFB RID: 158715 RVA: 0x0054DCC5 File Offset: 0x0054BEC5
		public string Abp { get; set; }

		// Token: 0x1700ABC3 RID: 43971
		// (get) Token: 0x06026BFC RID: 158716 RVA: 0x0054DCCE File Offset: 0x0054BECE
		// (set) Token: 0x06026BFD RID: 158717 RVA: 0x0054DCD6 File Offset: 0x0054BED6
		public List<string> BattleSockets { get; set; }

		// Token: 0x1700ABC4 RID: 43972
		// (get) Token: 0x06026BFE RID: 158718 RVA: 0x0054DCDF File Offset: 0x0054BEDF
		// (set) Token: 0x06026BFF RID: 158719 RVA: 0x0054DCE7 File Offset: 0x0054BEE7
		public List<string> NormalSockets { get; set; }

		// Token: 0x1700ABC5 RID: 43973
		// (get) Token: 0x06026C00 RID: 158720 RVA: 0x0054DCF0 File Offset: 0x0054BEF0
		// (set) Token: 0x06026C01 RID: 158721 RVA: 0x0054DCF8 File Offset: 0x0054BEF8
		public float LookingUpAngle { get; set; }

		// Token: 0x1700ABC6 RID: 43974
		// (get) Token: 0x06026C02 RID: 158722 RVA: 0x0054DD01 File Offset: 0x0054BF01
		// (set) Token: 0x06026C03 RID: 158723 RVA: 0x0054DD09 File Offset: 0x0054BF09
		public EBodyType BodyType { get; set; }

		// Token: 0x1700ABC7 RID: 43975
		// (get) Token: 0x06026C04 RID: 158724 RVA: 0x0054DD12 File Offset: 0x0054BF12
		// (set) Token: 0x06026C05 RID: 158725 RVA: 0x0054DD1A File Offset: 0x0054BF1A
		public float NameZaxisOffset { get; set; }

		// Token: 0x1700ABC8 RID: 43976
		// (get) Token: 0x06026C06 RID: 158726 RVA: 0x0054DD23 File Offset: 0x0054BF23
		// (set) Token: 0x06026C07 RID: 158727 RVA: 0x0054DD2B File Offset: 0x0054BF2B
		public byte NullMask { get; set; }

		// Token: 0x06026C08 RID: 158728 RVA: 0x0054DD34 File Offset: 0x0054BF34
		public INpcModelT()
		{
			this.Type = EModelType.LevelPrefab;
			this.BlueprintPath = null;
			this.NpcModel = null;
			this.Abp = null;
			this.BattleSockets = null;
			this.NormalSockets = null;
			this.LookingUpAngle = 0f;
			this.BodyType = EBodyType.None;
			this.NameZaxisOffset = 0f;
			this.NullMask = 0;
		}
	}
}
