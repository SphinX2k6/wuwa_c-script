using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006994 RID: 27028
	public class IInteractOptionT
	{
		// Token: 0x1700C878 RID: 51320
		// (get) Token: 0x0602F36A RID: 193386 RVA: 0x0066E81B File Offset: 0x0066CA1B
		// (set) Token: 0x0602F36B RID: 193387 RVA: 0x0066E823 File Offset: 0x0066CA23
		public string Guid { get; set; }

		// Token: 0x1700C879 RID: 51321
		// (get) Token: 0x0602F36C RID: 193388 RVA: 0x0066E82C File Offset: 0x0066CA2C
		// (set) Token: 0x0602F36D RID: 193389 RVA: 0x0066E834 File Offset: 0x0066CA34
		public TInteractOptionUnion Type { get; set; }

		// Token: 0x1700C87A RID: 51322
		// (get) Token: 0x0602F36E RID: 193390 RVA: 0x0066E83D File Offset: 0x0066CA3D
		// (set) Token: 0x0602F36F RID: 193391 RVA: 0x0066E845 File Offset: 0x0066CA45
		public EInteractIcon Icon { get; set; }

		// Token: 0x1700C87B RID: 51323
		// (get) Token: 0x0602F370 RID: 193392 RVA: 0x0066E84E File Offset: 0x0066CA4E
		// (set) Token: 0x0602F371 RID: 193393 RVA: 0x0066E856 File Offset: 0x0066CA56
		public string TidContent { get; set; }

		// Token: 0x1700C87C RID: 51324
		// (get) Token: 0x0602F372 RID: 193394 RVA: 0x0066E85F File Offset: 0x0066CA5F
		// (set) Token: 0x0602F373 RID: 193395 RVA: 0x0066E867 File Offset: 0x0066CA67
		public IVectorInfoT InteractPointOffset { get; set; }

		// Token: 0x1700C87D RID: 51325
		// (get) Token: 0x0602F374 RID: 193396 RVA: 0x0066E870 File Offset: 0x0066CA70
		// (set) Token: 0x0602F375 RID: 193397 RVA: 0x0066E878 File Offset: 0x0066CA78
		public IConditionGroupT Condition { get; set; }

		// Token: 0x1700C87E RID: 51326
		// (get) Token: 0x0602F376 RID: 193398 RVA: 0x0066E881 File Offset: 0x0066CA81
		// (set) Token: 0x0602F377 RID: 193399 RVA: 0x0066E889 File Offset: 0x0066CA89
		public IInteractOptionConfirmBoxT ConfirmBox { get; set; }

		// Token: 0x1700C87F RID: 51327
		// (get) Token: 0x0602F378 RID: 193400 RVA: 0x0066E892 File Offset: 0x0066CA92
		// (set) Token: 0x0602F379 RID: 193401 RVA: 0x0066E89A File Offset: 0x0066CA9A
		public EInteractUniqueness UniquenessTest { get; set; }

		// Token: 0x1700C880 RID: 51328
		// (get) Token: 0x0602F37A RID: 193402 RVA: 0x0066E8A3 File Offset: 0x0066CAA3
		// (set) Token: 0x0602F37B RID: 193403 RVA: 0x0066E8AB File Offset: 0x0066CAAB
		public EDoInteract DoIntactType { get; set; }

		// Token: 0x1700C881 RID: 51329
		// (get) Token: 0x0602F37C RID: 193404 RVA: 0x0066E8B4 File Offset: 0x0066CAB4
		// (set) Token: 0x0602F37D RID: 193405 RVA: 0x0066E8BC File Offset: 0x0066CABC
		public float Range { get; set; }

		// Token: 0x1700C882 RID: 51330
		// (get) Token: 0x0602F37E RID: 193406 RVA: 0x0066E8C5 File Offset: 0x0066CAC5
		// (set) Token: 0x0602F37F RID: 193407 RVA: 0x0066E8CD File Offset: 0x0066CACD
		public IDurationInteractT Duration { get; set; }

		// Token: 0x1700C883 RID: 51331
		// (get) Token: 0x0602F380 RID: 193408 RVA: 0x0066E8D6 File Offset: 0x0066CAD6
		// (set) Token: 0x0602F381 RID: 193409 RVA: 0x0066E8DE File Offset: 0x0066CADE
		public IOptionLockTipT OptionLockTip { get; set; }

		// Token: 0x1700C884 RID: 51332
		// (get) Token: 0x0602F382 RID: 193410 RVA: 0x0066E8E7 File Offset: 0x0066CAE7
		// (set) Token: 0x0602F383 RID: 193411 RVA: 0x0066E8EF File Offset: 0x0066CAEF
		public List<EOptionLockType> OptionLockTypeList { get; set; }

		// Token: 0x1700C885 RID: 51333
		// (get) Token: 0x0602F384 RID: 193412 RVA: 0x0066E8F8 File Offset: 0x0066CAF8
		// (set) Token: 0x0602F385 RID: 193413 RVA: 0x0066E900 File Offset: 0x0066CB00
		public ILongPressInteractConfigT LongPressInteractConfig { get; set; }

		// Token: 0x1700C886 RID: 51334
		// (get) Token: 0x0602F386 RID: 193414 RVA: 0x0066E909 File Offset: 0x0066CB09
		// (set) Token: 0x0602F387 RID: 193415 RVA: 0x0066E911 File Offset: 0x0066CB11
		public bool KeepInRecall { get; set; }

		// Token: 0x1700C887 RID: 51335
		// (get) Token: 0x0602F388 RID: 193416 RVA: 0x0066E91A File Offset: 0x0066CB1A
		// (set) Token: 0x0602F389 RID: 193417 RVA: 0x0066E922 File Offset: 0x0066CB22
		public byte NullMask { get; set; }

		// Token: 0x0602F38A RID: 193418 RVA: 0x0066E92C File Offset: 0x0066CB2C
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
			this.LongPressInteractConfig = null;
			this.KeepInRecall = false;
			this.NullMask = 0;
		}
	}
}
