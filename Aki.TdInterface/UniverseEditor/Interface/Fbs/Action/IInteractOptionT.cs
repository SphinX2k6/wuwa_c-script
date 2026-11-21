using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007047 RID: 28743
	public class IInteractOptionT
	{
		// Token: 0x1700D27C RID: 53884
		// (get) Token: 0x06031D44 RID: 204100 RVA: 0x006BEEF4 File Offset: 0x006BD0F4
		// (set) Token: 0x06031D45 RID: 204101 RVA: 0x006BEEFC File Offset: 0x006BD0FC
		public string Guid { get; set; }

		// Token: 0x1700D27D RID: 53885
		// (get) Token: 0x06031D46 RID: 204102 RVA: 0x006BEF05 File Offset: 0x006BD105
		// (set) Token: 0x06031D47 RID: 204103 RVA: 0x006BEF0D File Offset: 0x006BD10D
		public TInteractOptionUnion Type { get; set; }

		// Token: 0x1700D27E RID: 53886
		// (get) Token: 0x06031D48 RID: 204104 RVA: 0x006BEF16 File Offset: 0x006BD116
		// (set) Token: 0x06031D49 RID: 204105 RVA: 0x006BEF1E File Offset: 0x006BD11E
		public EInteractIcon Icon { get; set; }

		// Token: 0x1700D27F RID: 53887
		// (get) Token: 0x06031D4A RID: 204106 RVA: 0x006BEF27 File Offset: 0x006BD127
		// (set) Token: 0x06031D4B RID: 204107 RVA: 0x006BEF2F File Offset: 0x006BD12F
		public string TidContent { get; set; }

		// Token: 0x1700D280 RID: 53888
		// (get) Token: 0x06031D4C RID: 204108 RVA: 0x006BEF38 File Offset: 0x006BD138
		// (set) Token: 0x06031D4D RID: 204109 RVA: 0x006BEF40 File Offset: 0x006BD140
		public IVectorInfoT InteractPointOffset { get; set; }

		// Token: 0x1700D281 RID: 53889
		// (get) Token: 0x06031D4E RID: 204110 RVA: 0x006BEF49 File Offset: 0x006BD149
		// (set) Token: 0x06031D4F RID: 204111 RVA: 0x006BEF51 File Offset: 0x006BD151
		public IConditionGroupT Condition { get; set; }

		// Token: 0x1700D282 RID: 53890
		// (get) Token: 0x06031D50 RID: 204112 RVA: 0x006BEF5A File Offset: 0x006BD15A
		// (set) Token: 0x06031D51 RID: 204113 RVA: 0x006BEF62 File Offset: 0x006BD162
		public IInteractOptionConfirmBoxT ConfirmBox { get; set; }

		// Token: 0x1700D283 RID: 53891
		// (get) Token: 0x06031D52 RID: 204114 RVA: 0x006BEF6B File Offset: 0x006BD16B
		// (set) Token: 0x06031D53 RID: 204115 RVA: 0x006BEF73 File Offset: 0x006BD173
		public EInteractUniqueness UniquenessTest { get; set; }

		// Token: 0x1700D284 RID: 53892
		// (get) Token: 0x06031D54 RID: 204116 RVA: 0x006BEF7C File Offset: 0x006BD17C
		// (set) Token: 0x06031D55 RID: 204117 RVA: 0x006BEF84 File Offset: 0x006BD184
		public EDoInteract DoIntactType { get; set; }

		// Token: 0x1700D285 RID: 53893
		// (get) Token: 0x06031D56 RID: 204118 RVA: 0x006BEF8D File Offset: 0x006BD18D
		// (set) Token: 0x06031D57 RID: 204119 RVA: 0x006BEF95 File Offset: 0x006BD195
		public float Range { get; set; }

		// Token: 0x1700D286 RID: 53894
		// (get) Token: 0x06031D58 RID: 204120 RVA: 0x006BEF9E File Offset: 0x006BD19E
		// (set) Token: 0x06031D59 RID: 204121 RVA: 0x006BEFA6 File Offset: 0x006BD1A6
		public IDurationInteractT Duration { get; set; }

		// Token: 0x1700D287 RID: 53895
		// (get) Token: 0x06031D5A RID: 204122 RVA: 0x006BEFAF File Offset: 0x006BD1AF
		// (set) Token: 0x06031D5B RID: 204123 RVA: 0x006BEFB7 File Offset: 0x006BD1B7
		public IOptionLockTipT OptionLockTip { get; set; }

		// Token: 0x1700D288 RID: 53896
		// (get) Token: 0x06031D5C RID: 204124 RVA: 0x006BEFC0 File Offset: 0x006BD1C0
		// (set) Token: 0x06031D5D RID: 204125 RVA: 0x006BEFC8 File Offset: 0x006BD1C8
		public List<EOptionLockType> OptionLockTypeList { get; set; }

		// Token: 0x1700D289 RID: 53897
		// (get) Token: 0x06031D5E RID: 204126 RVA: 0x006BEFD1 File Offset: 0x006BD1D1
		// (set) Token: 0x06031D5F RID: 204127 RVA: 0x006BEFD9 File Offset: 0x006BD1D9
		public List<EOptionUnlockType> OptionUnlockTypeList { get; set; }

		// Token: 0x1700D28A RID: 53898
		// (get) Token: 0x06031D60 RID: 204128 RVA: 0x006BEFE2 File Offset: 0x006BD1E2
		// (set) Token: 0x06031D61 RID: 204129 RVA: 0x006BEFEA File Offset: 0x006BD1EA
		public ILongPressInteractConfigT LongPressInteractConfig { get; set; }

		// Token: 0x1700D28B RID: 53899
		// (get) Token: 0x06031D62 RID: 204130 RVA: 0x006BEFF3 File Offset: 0x006BD1F3
		// (set) Token: 0x06031D63 RID: 204131 RVA: 0x006BEFFB File Offset: 0x006BD1FB
		public bool KeepInRecall { get; set; }

		// Token: 0x1700D28C RID: 53900
		// (get) Token: 0x06031D64 RID: 204132 RVA: 0x006BF004 File Offset: 0x006BD204
		// (set) Token: 0x06031D65 RID: 204133 RVA: 0x006BF00C File Offset: 0x006BD20C
		public byte NullMask { get; set; }

		// Token: 0x06031D66 RID: 204134 RVA: 0x006BF018 File Offset: 0x006BD218
		public IInteractOptionT()
		{
			this.Guid = null;
			this.Type = null;
			this.Icon = EInteractIcon.Dialog;
			this.TidContent = null;
			this.InteractPointOffset = null;
			this.Condition = null;
			this.ConfirmBox = null;
			this.UniquenessTest = EInteractUniqueness.Closest;
			this.DoIntactType = EDoInteract.Direct;
			this.Range = 0f;
			this.Duration = null;
			this.OptionLockTip = null;
			this.OptionLockTypeList = null;
			this.OptionUnlockTypeList = null;
			this.LongPressInteractConfig = null;
			this.KeepInRecall = false;
			this.NullMask = 0;
		}
	}
}
