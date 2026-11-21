using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067DC RID: 26588
	public class IAdjustZoneFollowCameraT
	{
		// Token: 0x1700C35F RID: 50015
		// (get) Token: 0x0602D667 RID: 185959 RVA: 0x00637D66 File Offset: 0x00635F66
		// (set) Token: 0x0602D668 RID: 185960 RVA: 0x00637D6E File Offset: 0x00635F6E
		public EAdjustPlayerCamera Type { get; set; }

		// Token: 0x1700C360 RID: 50016
		// (get) Token: 0x0602D669 RID: 185961 RVA: 0x00637D77 File Offset: 0x00635F77
		// (set) Token: 0x0602D66A RID: 185962 RVA: 0x00637D7F File Offset: 0x00635F7F
		public int Priority { get; set; }

		// Token: 0x1700C361 RID: 50017
		// (get) Token: 0x0602D66B RID: 185963 RVA: 0x00637D88 File Offset: 0x00635F88
		// (set) Token: 0x0602D66C RID: 185964 RVA: 0x00637D90 File Offset: 0x00635F90
		public float FadeInTime { get; set; }

		// Token: 0x1700C362 RID: 50018
		// (get) Token: 0x0602D66D RID: 185965 RVA: 0x00637D99 File Offset: 0x00635F99
		// (set) Token: 0x0602D66E RID: 185966 RVA: 0x00637DA1 File Offset: 0x00635FA1
		public IBaseCurveT FadeInCurve { get; set; }

		// Token: 0x1700C363 RID: 50019
		// (get) Token: 0x0602D66F RID: 185967 RVA: 0x00637DAA File Offset: 0x00635FAA
		// (set) Token: 0x0602D670 RID: 185968 RVA: 0x00637DB2 File Offset: 0x00635FB2
		public float FadeOutTime { get; set; }

		// Token: 0x1700C364 RID: 50020
		// (get) Token: 0x0602D671 RID: 185969 RVA: 0x00637DBB File Offset: 0x00635FBB
		// (set) Token: 0x0602D672 RID: 185970 RVA: 0x00637DC3 File Offset: 0x00635FC3
		public IBaseCurveT FadeOutCurve { get; set; }

		// Token: 0x1700C365 RID: 50021
		// (get) Token: 0x0602D673 RID: 185971 RVA: 0x00637DCC File Offset: 0x00635FCC
		// (set) Token: 0x0602D674 RID: 185972 RVA: 0x00637DD4 File Offset: 0x00635FD4
		public float ArmLength { get; set; }

		// Token: 0x1700C366 RID: 50022
		// (get) Token: 0x0602D675 RID: 185973 RVA: 0x00637DDD File Offset: 0x00635FDD
		// (set) Token: 0x0602D676 RID: 185974 RVA: 0x00637DE5 File Offset: 0x00635FE5
		public float MinumArmLength { get; set; }

		// Token: 0x1700C367 RID: 50023
		// (get) Token: 0x0602D677 RID: 185975 RVA: 0x00637DEE File Offset: 0x00635FEE
		// (set) Token: 0x0602D678 RID: 185976 RVA: 0x00637DF6 File Offset: 0x00635FF6
		public float MaxiumArmLength { get; set; }

		// Token: 0x1700C368 RID: 50024
		// (get) Token: 0x0602D679 RID: 185977 RVA: 0x00637DFF File Offset: 0x00635FFF
		// (set) Token: 0x0602D67A RID: 185978 RVA: 0x00637E07 File Offset: 0x00636007
		public IVectorInfoT Offset { get; set; }

		// Token: 0x1700C369 RID: 50025
		// (get) Token: 0x0602D67B RID: 185979 RVA: 0x00637E10 File Offset: 0x00636010
		// (set) Token: 0x0602D67C RID: 185980 RVA: 0x00637E18 File Offset: 0x00636018
		public IVectorInfoT ArmOffset { get; set; }

		// Token: 0x1700C36A RID: 50026
		// (get) Token: 0x0602D67D RID: 185981 RVA: 0x00637E21 File Offset: 0x00636021
		// (set) Token: 0x0602D67E RID: 185982 RVA: 0x00637E29 File Offset: 0x00636029
		public float YawLimitMin { get; set; }

		// Token: 0x1700C36B RID: 50027
		// (get) Token: 0x0602D67F RID: 185983 RVA: 0x00637E32 File Offset: 0x00636032
		// (set) Token: 0x0602D680 RID: 185984 RVA: 0x00637E3A File Offset: 0x0063603A
		public float YawLimitMax { get; set; }

		// Token: 0x1700C36C RID: 50028
		// (get) Token: 0x0602D681 RID: 185985 RVA: 0x00637E43 File Offset: 0x00636043
		// (set) Token: 0x0602D682 RID: 185986 RVA: 0x00637E4B File Offset: 0x0063604B
		public float PitchLimitMin { get; set; }

		// Token: 0x1700C36D RID: 50029
		// (get) Token: 0x0602D683 RID: 185987 RVA: 0x00637E54 File Offset: 0x00636054
		// (set) Token: 0x0602D684 RID: 185988 RVA: 0x00637E5C File Offset: 0x0063605C
		public float PitchLimitMax { get; set; }

		// Token: 0x1700C36E RID: 50030
		// (get) Token: 0x0602D685 RID: 185989 RVA: 0x00637E65 File Offset: 0x00636065
		// (set) Token: 0x0602D686 RID: 185990 RVA: 0x00637E6D File Offset: 0x0063606D
		public float Fov { get; set; }

		// Token: 0x1700C36F RID: 50031
		// (get) Token: 0x0602D687 RID: 185991 RVA: 0x00637E76 File Offset: 0x00636076
		// (set) Token: 0x0602D688 RID: 185992 RVA: 0x00637E7E File Offset: 0x0063607E
		public bool IsDisableResetFocus { get; set; }

		// Token: 0x1700C370 RID: 50032
		// (get) Token: 0x0602D689 RID: 185993 RVA: 0x00637E87 File Offset: 0x00636087
		// (set) Token: 0x0602D68A RID: 185994 RVA: 0x00637E8F File Offset: 0x0063608F
		public TGravityDirectionUnion GravityDirection { get; set; }

		// Token: 0x1700C371 RID: 50033
		// (get) Token: 0x0602D68B RID: 185995 RVA: 0x00637E98 File Offset: 0x00636098
		// (set) Token: 0x0602D68C RID: 185996 RVA: 0x00637EA0 File Offset: 0x006360A0
		public bool IsDisableCollision { get; set; }

		// Token: 0x1700C372 RID: 50034
		// (get) Token: 0x0602D68D RID: 185997 RVA: 0x00637EA9 File Offset: 0x006360A9
		// (set) Token: 0x0602D68E RID: 185998 RVA: 0x00637EB1 File Offset: 0x006360B1
		public bool IsDisableDither { get; set; }

		// Token: 0x1700C373 RID: 50035
		// (get) Token: 0x0602D68F RID: 185999 RVA: 0x00637EBA File Offset: 0x006360BA
		// (set) Token: 0x0602D690 RID: 186000 RVA: 0x00637EC2 File Offset: 0x006360C2
		public string SubScreenBindKey { get; set; }

		// Token: 0x1700C374 RID: 50036
		// (get) Token: 0x0602D691 RID: 186001 RVA: 0x00637ECB File Offset: 0x006360CB
		// (set) Token: 0x0602D692 RID: 186002 RVA: 0x00637ED3 File Offset: 0x006360D3
		public bool IsFollowPlayer { get; set; }

		// Token: 0x1700C375 RID: 50037
		// (get) Token: 0x0602D693 RID: 186003 RVA: 0x00637EDC File Offset: 0x006360DC
		// (set) Token: 0x0602D694 RID: 186004 RVA: 0x00637EE4 File Offset: 0x006360E4
		public int SceneActorRefEntityId { get; set; }

		// Token: 0x1700C376 RID: 50038
		// (get) Token: 0x0602D695 RID: 186005 RVA: 0x00637EED File Offset: 0x006360ED
		// (set) Token: 0x0602D696 RID: 186006 RVA: 0x00637EF5 File Offset: 0x006360F5
		public byte NullMask { get; set; }

		// Token: 0x0602D697 RID: 186007 RVA: 0x00637F00 File Offset: 0x00636100
		public IAdjustZoneFollowCameraT()
		{
			this.Type = EAdjustPlayerCamera.Basic;
			this.Priority = 0;
			this.FadeInTime = 0f;
			this.FadeInCurve = null;
			this.FadeOutTime = 0f;
			this.FadeOutCurve = null;
			this.ArmLength = 0f;
			this.MinumArmLength = 0f;
			this.MaxiumArmLength = 0f;
			this.Offset = null;
			this.ArmOffset = null;
			this.YawLimitMin = 0f;
			this.YawLimitMax = 0f;
			this.PitchLimitMin = 0f;
			this.PitchLimitMax = 0f;
			this.Fov = 0f;
			this.IsDisableResetFocus = false;
			this.GravityDirection = null;
			this.IsDisableCollision = false;
			this.IsDisableDither = false;
			this.SubScreenBindKey = null;
			this.IsFollowPlayer = false;
			this.SceneActorRefEntityId = 0;
			this.NullMask = 0;
		}
	}
}
