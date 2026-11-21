using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B11 RID: 23313
	public class IMonsterComponentT
	{
		// Token: 0x1700AA25 RID: 43557
		// (get) Token: 0x06026528 RID: 156968 RVA: 0x0054021B File Offset: 0x0053E41B
		// (set) Token: 0x06026529 RID: 156969 RVA: 0x00540223 File Offset: 0x0053E423
		public bool Disabled { get; set; }

		// Token: 0x1700AA26 RID: 43558
		// (get) Token: 0x0602652A RID: 156970 RVA: 0x0054022C File Offset: 0x0053E42C
		// (set) Token: 0x0602652B RID: 156971 RVA: 0x00540234 File Offset: 0x0053E434
		public int FightConfigId { get; set; }

		// Token: 0x1700AA27 RID: 43559
		// (get) Token: 0x0602652C RID: 156972 RVA: 0x0054023D File Offset: 0x0053E43D
		// (set) Token: 0x0602652D RID: 156973 RVA: 0x00540245 File Offset: 0x0053E445
		public IBossStateViewConfigT BossViewConfig { get; set; }

		// Token: 0x1700AA28 RID: 43560
		// (get) Token: 0x0602652E RID: 156974 RVA: 0x0054024E File Offset: 0x0053E44E
		// (set) Token: 0x0602652F RID: 156975 RVA: 0x00540256 File Offset: 0x0053E456
		public List<string> InitGasTag { get; set; }

		// Token: 0x1700AA29 RID: 43561
		// (get) Token: 0x06026530 RID: 156976 RVA: 0x0054025F File Offset: 0x0053E45F
		// (set) Token: 0x06026531 RID: 156977 RVA: 0x00540267 File Offset: 0x0053E467
		public int SpecialHateAndSenseConfig { get; set; }

		// Token: 0x1700AA2A RID: 43562
		// (get) Token: 0x06026532 RID: 156978 RVA: 0x00540270 File Offset: 0x0053E470
		// (set) Token: 0x06026533 RID: 156979 RVA: 0x00540278 File Offset: 0x0053E478
		public IMonsterPerformConfigT PerformConfig { get; set; }

		// Token: 0x1700AA2B RID: 43563
		// (get) Token: 0x06026534 RID: 156980 RVA: 0x00540281 File Offset: 0x0053E481
		// (set) Token: 0x06026535 RID: 156981 RVA: 0x00540289 File Offset: 0x0053E489
		public List<int> ShareLifeSubMonsterIds { get; set; }

		// Token: 0x1700AA2C RID: 43564
		// (get) Token: 0x06026536 RID: 156982 RVA: 0x00540292 File Offset: 0x0053E492
		// (set) Token: 0x06026537 RID: 156983 RVA: 0x0054029A File Offset: 0x0053E49A
		public int LifeMaxCustomizationId { get; set; }

		// Token: 0x1700AA2D RID: 43565
		// (get) Token: 0x06026538 RID: 156984 RVA: 0x005402A3 File Offset: 0x0053E4A3
		// (set) Token: 0x06026539 RID: 156985 RVA: 0x005402AB File Offset: 0x0053E4AB
		public IMonsterNpcInteractionEnableConfigT EnableMonsterNpcInteraction { get; set; }

		// Token: 0x1700AA2E RID: 43566
		// (get) Token: 0x0602653A RID: 156986 RVA: 0x005402B4 File Offset: 0x0053E4B4
		// (set) Token: 0x0602653B RID: 156987 RVA: 0x005402BC File Offset: 0x0053E4BC
		public List<TMonsterCombatInteractionConfigUnion> EnableMonsterCombatInteraction { get; set; }

		// Token: 0x1700AA2F RID: 43567
		// (get) Token: 0x0602653C RID: 156988 RVA: 0x005402C5 File Offset: 0x0053E4C5
		// (set) Token: 0x0602653D RID: 156989 RVA: 0x005402CD File Offset: 0x0053E4CD
		public IMonsterCommunicationGroupConfigT MonsterCommunicationGroup { get; set; }

		// Token: 0x1700AA30 RID: 43568
		// (get) Token: 0x0602653E RID: 156990 RVA: 0x005402D6 File Offset: 0x0053E4D6
		// (set) Token: 0x0602653F RID: 156991 RVA: 0x005402DE File Offset: 0x0053E4DE
		public List<EExtraMovementAbility> ExtraMovementAbilities { get; set; }

		// Token: 0x1700AA31 RID: 43569
		// (get) Token: 0x06026540 RID: 156992 RVA: 0x005402E7 File Offset: 0x0053E4E7
		// (set) Token: 0x06026541 RID: 156993 RVA: 0x005402EF File Offset: 0x0053E4EF
		public byte NullMask { get; set; }

		// Token: 0x06026542 RID: 156994 RVA: 0x005402F8 File Offset: 0x0053E4F8
		public IMonsterComponentT()
		{
			this.Disabled = false;
			this.FightConfigId = 0;
			this.BossViewConfig = null;
			this.InitGasTag = null;
			this.SpecialHateAndSenseConfig = 0;
			this.PerformConfig = null;
			this.ShareLifeSubMonsterIds = null;
			this.LifeMaxCustomizationId = 0;
			this.EnableMonsterNpcInteraction = null;
			this.EnableMonsterCombatInteraction = null;
			this.MonsterCommunicationGroup = null;
			this.ExtraMovementAbilities = null;
			this.NullMask = 0;
		}
	}
}
