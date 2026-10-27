using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E4F RID: 15951
	public class IFinishTetrisT
	{
		// Token: 0x17006E8F RID: 28303
		// (get) Token: 0x06016701 RID: 91905 RVA: 0x0033E721 File Offset: 0x0033C921
		// (set) Token: 0x06016702 RID: 91906 RVA: 0x0033E729 File Offset: 0x0033C929
		public EChildQuest Type { get; set; }

		// Token: 0x17006E90 RID: 28304
		// (get) Token: 0x06016703 RID: 91907 RVA: 0x0033E732 File Offset: 0x0033C932
		// (set) Token: 0x06016704 RID: 91908 RVA: 0x0033E73A File Offset: 0x0033C93A
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17006E91 RID: 28305
		// (get) Token: 0x06016705 RID: 91909 RVA: 0x0033E743 File Offset: 0x0033C943
		// (set) Token: 0x06016706 RID: 91910 RVA: 0x0033E74B File Offset: 0x0033C94B
		public int OriginPosEntityId { get; set; }

		// Token: 0x17006E92 RID: 28306
		// (get) Token: 0x06016707 RID: 91911 RVA: 0x0033E754 File Offset: 0x0033C954
		// (set) Token: 0x06016708 RID: 91912 RVA: 0x0033E75C File Offset: 0x0033C95C
		public TTetrisPlayModeUnion PlayMode { get; set; }

		// Token: 0x17006E93 RID: 28307
		// (get) Token: 0x06016709 RID: 91913 RVA: 0x0033E765 File Offset: 0x0033C965
		// (set) Token: 0x0601670A RID: 91914 RVA: 0x0033E76D File Offset: 0x0033C96D
		public ETetrisDirection Direction { get; set; }

		// Token: 0x17006E94 RID: 28308
		// (get) Token: 0x0601670B RID: 91915 RVA: 0x0033E776 File Offset: 0x0033C976
		// (set) Token: 0x0601670C RID: 91916 RVA: 0x0033E77E File Offset: 0x0033C97E
		public float PrepareTime { get; set; }

		// Token: 0x17006E95 RID: 28309
		// (get) Token: 0x0601670D RID: 91917 RVA: 0x0033E787 File Offset: 0x0033C987
		// (set) Token: 0x0601670E RID: 91918 RVA: 0x0033E78F File Offset: 0x0033C98F
		public float FallSpeed { get; set; }

		// Token: 0x17006E96 RID: 28310
		// (get) Token: 0x0601670F RID: 91919 RVA: 0x0033E798 File Offset: 0x0033C998
		// (set) Token: 0x06016710 RID: 91920 RVA: 0x0033E7A0 File Offset: 0x0033C9A0
		public ITetrisIndexedBoardT PresetBlocks { get; set; }

		// Token: 0x17006E97 RID: 28311
		// (get) Token: 0x06016711 RID: 91921 RVA: 0x0033E7A9 File Offset: 0x0033C9A9
		// (set) Token: 0x06016712 RID: 91922 RVA: 0x0033E7B1 File Offset: 0x0033C9B1
		public List<string> AvailableCombineBlocks { get; set; }

		// Token: 0x17006E98 RID: 28312
		// (get) Token: 0x06016713 RID: 91923 RVA: 0x0033E7BA File Offset: 0x0033C9BA
		// (set) Token: 0x06016714 RID: 91924 RVA: 0x0033E7C2 File Offset: 0x0033C9C2
		public TVarRefUnion IsSuccessVar { get; set; }

		// Token: 0x17006E99 RID: 28313
		// (get) Token: 0x06016715 RID: 91925 RVA: 0x0033E7CB File Offset: 0x0033C9CB
		// (set) Token: 0x06016716 RID: 91926 RVA: 0x0033E7D3 File Offset: 0x0033C9D3
		public TVarRefUnion IsInitializedVar { get; set; }

		// Token: 0x17006E9A RID: 28314
		// (get) Token: 0x06016717 RID: 91927 RVA: 0x0033E7DC File Offset: 0x0033C9DC
		// (set) Token: 0x06016718 RID: 91928 RVA: 0x0033E7E4 File Offset: 0x0033C9E4
		public byte NullMask { get; set; }

		// Token: 0x06016719 RID: 91929 RVA: 0x0033E7F0 File Offset: 0x0033C9F0
		public IFinishTetrisT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.OriginPosEntityId = 0;
			this.PlayMode = null;
			this.Direction = ETetrisDirection.UpDown;
			this.PrepareTime = 0f;
			this.FallSpeed = 0f;
			this.PresetBlocks = null;
			this.AvailableCombineBlocks = null;
			this.IsSuccessVar = null;
			this.IsInitializedVar = null;
			this.NullMask = 0;
		}
	}
}
