using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BD1 RID: 23505
	public class INpcPerformComponentT
	{
		// Token: 0x1700ABEC RID: 44012
		// (get) Token: 0x06026CBC RID: 158908 RVA: 0x00550373 File Offset: 0x0054E573
		// (set) Token: 0x06026CBD RID: 158909 RVA: 0x0055037B File Offset: 0x0054E57B
		public bool Disabled { get; set; }

		// Token: 0x1700ABED RID: 44013
		// (get) Token: 0x06026CBE RID: 158910 RVA: 0x00550384 File Offset: 0x0054E584
		// (set) Token: 0x06026CBF RID: 158911 RVA: 0x0055038C File Offset: 0x0054E58C
		public IBaseRoleNpcPerformT SpecialNpcPerformConfig { get; set; }

		// Token: 0x1700ABEE RID: 44014
		// (get) Token: 0x06026CC0 RID: 158912 RVA: 0x00550395 File Offset: 0x0054E595
		// (set) Token: 0x06026CC1 RID: 158913 RVA: 0x0055039D File Offset: 0x0054E59D
		public bool IsStare { get; set; }

		// Token: 0x1700ABEF RID: 44015
		// (get) Token: 0x06026CC2 RID: 158914 RVA: 0x005503A6 File Offset: 0x0054E5A6
		// (set) Token: 0x06026CC3 RID: 158915 RVA: 0x005503AE File Offset: 0x0054E5AE
		public INpcHitShowT NpcHitShow { get; set; }

		// Token: 0x1700ABF0 RID: 44016
		// (get) Token: 0x06026CC4 RID: 158916 RVA: 0x005503B7 File Offset: 0x0054E5B7
		// (set) Token: 0x06026CC5 RID: 158917 RVA: 0x005503BF File Offset: 0x0054E5BF
		public bool IsShowStrike { get; set; }

		// Token: 0x1700ABF1 RID: 44017
		// (get) Token: 0x06026CC6 RID: 158918 RVA: 0x005503C8 File Offset: 0x0054E5C8
		// (set) Token: 0x06026CC7 RID: 158919 RVA: 0x005503D0 File Offset: 0x0054E5D0
		public INpcBumpShowT NpcBumpShow { get; set; }

		// Token: 0x1700ABF2 RID: 44018
		// (get) Token: 0x06026CC8 RID: 158920 RVA: 0x005503D9 File Offset: 0x0054E5D9
		// (set) Token: 0x06026CC9 RID: 158921 RVA: 0x005503E1 File Offset: 0x0054E5E1
		public INpcAwakeShowT ShowOnAwake { get; set; }

		// Token: 0x1700ABF3 RID: 44019
		// (get) Token: 0x06026CCA RID: 158922 RVA: 0x005503EA File Offset: 0x0054E5EA
		// (set) Token: 0x06026CCB RID: 158923 RVA: 0x005503F2 File Offset: 0x0054E5F2
		public TNpcStandbyShowOptionUnion ShowOnStandby { get; set; }

		// Token: 0x1700ABF4 RID: 44020
		// (get) Token: 0x06026CCC RID: 158924 RVA: 0x005503FB File Offset: 0x0054E5FB
		// (set) Token: 0x06026CCD RID: 158925 RVA: 0x00550403 File Offset: 0x0054E603
		public INpcPerformOnInteractT ShowOnInteract { get; set; }

		// Token: 0x1700ABF5 RID: 44021
		// (get) Token: 0x06026CCE RID: 158926 RVA: 0x0055040C File Offset: 0x0054E60C
		// (set) Token: 0x06026CCF RID: 158927 RVA: 0x00550414 File Offset: 0x0054E614
		public List<IConditionalNpcPerformOnInteractT> ConditionalShowOnInteracts { get; set; }

		// Token: 0x1700ABF6 RID: 44022
		// (get) Token: 0x06026CD0 RID: 158928 RVA: 0x0055041D File Offset: 0x0054E61D
		// (set) Token: 0x06026CD1 RID: 158929 RVA: 0x00550425 File Offset: 0x0054E625
		public TNpcUiInteractOptionUnion ShowOnUiInteract { get; set; }

		// Token: 0x1700ABF7 RID: 44023
		// (get) Token: 0x06026CD2 RID: 158930 RVA: 0x0055042E File Offset: 0x0054E62E
		// (set) Token: 0x06026CD3 RID: 158931 RVA: 0x00550436 File Offset: 0x0054E636
		public List<TNpcRideInVehiclePerformTypeUnion> ShowOnRideInVehicle { get; set; }

		// Token: 0x1700ABF8 RID: 44024
		// (get) Token: 0x06026CD4 RID: 158932 RVA: 0x0055043F File Offset: 0x0054E63F
		// (set) Token: 0x06026CD5 RID: 158933 RVA: 0x00550447 File Offset: 0x0054E647
		public INpcPerformOnMonsterClosebyT NpcMonsterClosePerform { get; set; }

		// Token: 0x1700ABF9 RID: 44025
		// (get) Token: 0x06026CD6 RID: 158934 RVA: 0x00550450 File Offset: 0x0054E650
		// (set) Token: 0x06026CD7 RID: 158935 RVA: 0x00550458 File Offset: 0x0054E658
		public INpcPerformStateT NpcPerformState { get; set; }

		// Token: 0x1700ABFA RID: 44026
		// (get) Token: 0x06026CD8 RID: 158936 RVA: 0x00550461 File Offset: 0x0054E661
		// (set) Token: 0x06026CD9 RID: 158937 RVA: 0x00550469 File Offset: 0x0054E669
		public INpcDeathInteractT DeathInteract { get; set; }

		// Token: 0x1700ABFB RID: 44027
		// (get) Token: 0x06026CDA RID: 158938 RVA: 0x00550472 File Offset: 0x0054E672
		// (set) Token: 0x06026CDB RID: 158939 RVA: 0x0055047A File Offset: 0x0054E67A
		public bool FixedPosition { get; set; }

		// Token: 0x1700ABFC RID: 44028
		// (get) Token: 0x06026CDC RID: 158940 RVA: 0x00550483 File Offset: 0x0054E683
		// (set) Token: 0x06026CDD RID: 158941 RVA: 0x0055048B File Offset: 0x0054E68B
		public string DefaultAbpState { get; set; }

		// Token: 0x1700ABFD RID: 44029
		// (get) Token: 0x06026CDE RID: 158942 RVA: 0x00550494 File Offset: 0x0054E694
		// (set) Token: 0x06026CDF RID: 158943 RVA: 0x0055049C File Offset: 0x0054E69C
		public int DefaultFaceExpressionId { get; set; }

		// Token: 0x1700ABFE RID: 44030
		// (get) Token: 0x06026CE0 RID: 158944 RVA: 0x005504A5 File Offset: 0x0054E6A5
		// (set) Token: 0x06026CE1 RID: 158945 RVA: 0x005504AD File Offset: 0x0054E6AD
		public INpcDefaultPerformT DefaultPerform { get; set; }

		// Token: 0x1700ABFF RID: 44031
		// (get) Token: 0x06026CE2 RID: 158946 RVA: 0x005504B6 File Offset: 0x0054E6B6
		// (set) Token: 0x06026CE3 RID: 158947 RVA: 0x005504BE File Offset: 0x0054E6BE
		public List<TNpcSpecialMarkUnion> NpcSpecialMarks { get; set; }

		// Token: 0x1700AC00 RID: 44032
		// (get) Token: 0x06026CE4 RID: 158948 RVA: 0x005504C7 File Offset: 0x0054E6C7
		// (set) Token: 0x06026CE5 RID: 158949 RVA: 0x005504CF File Offset: 0x0054E6CF
		public List<EExtraMovementAbility> ExtraMovementAbilities { get; set; }

		// Token: 0x1700AC01 RID: 44033
		// (get) Token: 0x06026CE6 RID: 158950 RVA: 0x005504D8 File Offset: 0x0054E6D8
		// (set) Token: 0x06026CE7 RID: 158951 RVA: 0x005504E0 File Offset: 0x0054E6E0
		public byte NullMask { get; set; }

		// Token: 0x06026CE8 RID: 158952 RVA: 0x005504EC File Offset: 0x0054E6EC
		public INpcPerformComponentT()
		{
			this.Disabled = false;
			this.SpecialNpcPerformConfig = null;
			this.IsStare = false;
			this.NpcHitShow = null;
			this.IsShowStrike = false;
			this.NpcBumpShow = null;
			this.ShowOnAwake = null;
			this.ShowOnStandby = null;
			this.ShowOnInteract = null;
			this.ConditionalShowOnInteracts = null;
			this.ShowOnUiInteract = null;
			this.ShowOnRideInVehicle = null;
			this.NpcMonsterClosePerform = null;
			this.NpcPerformState = null;
			this.DeathInteract = null;
			this.FixedPosition = false;
			this.DefaultAbpState = null;
			this.DefaultFaceExpressionId = 0;
			this.DefaultPerform = null;
			this.NpcSpecialMarks = null;
			this.ExtraMovementAbilities = null;
			this.NullMask = 0;
		}
	}
}
