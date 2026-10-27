using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F8C RID: 20364
	public class IChargeSlashHookT
	{
		// Token: 0x17009341 RID: 37697
		// (get) Token: 0x060205A7 RID: 132519 RVA: 0x00480761 File Offset: 0x0047E961
		// (set) Token: 0x060205A8 RID: 132520 RVA: 0x00480769 File Offset: 0x0047E969
		public EHookInteractType Type { get; set; }

		// Token: 0x17009342 RID: 37698
		// (get) Token: 0x060205A9 RID: 132521 RVA: 0x00480772 File Offset: 0x0047E972
		// (set) Token: 0x060205AA RID: 132522 RVA: 0x0048077A File Offset: 0x0047E97A
		public List<IActionInfoT> HookActions { get; set; }

		// Token: 0x17009343 RID: 37699
		// (get) Token: 0x060205AB RID: 132523 RVA: 0x00480783 File Offset: 0x0047E983
		// (set) Token: 0x060205AC RID: 132524 RVA: 0x0048078B File Offset: 0x0047E98B
		public List<IActionInfoT> ExitHookActions { get; set; }

		// Token: 0x17009344 RID: 37700
		// (get) Token: 0x060205AD RID: 132525 RVA: 0x00480794 File Offset: 0x0047E994
		// (set) Token: 0x060205AE RID: 132526 RVA: 0x0048079C File Offset: 0x0047E99C
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x17009345 RID: 37701
		// (get) Token: 0x060205AF RID: 132527 RVA: 0x004807A5 File Offset: 0x0047E9A5
		// (set) Token: 0x060205B0 RID: 132528 RVA: 0x004807AD File Offset: 0x0047E9AD
		public IClientHookActionConfigT ClientHookActionConfig { get; set; }

		// Token: 0x17009346 RID: 37702
		// (get) Token: 0x060205B1 RID: 132529 RVA: 0x004807B6 File Offset: 0x0047E9B6
		// (set) Token: 0x060205B2 RID: 132530 RVA: 0x004807BE File Offset: 0x0047E9BE
		public List<int> TargetEntityIds { get; set; }

		// Token: 0x17009347 RID: 37703
		// (get) Token: 0x060205B3 RID: 132531 RVA: 0x004807C7 File Offset: 0x0047E9C7
		// (set) Token: 0x060205B4 RID: 132532 RVA: 0x004807CF File Offset: 0x0047E9CF
		public float MaxRandomDelayTime { get; set; }

		// Token: 0x17009348 RID: 37704
		// (get) Token: 0x060205B5 RID: 132533 RVA: 0x004807D8 File Offset: 0x0047E9D8
		// (set) Token: 0x060205B6 RID: 132534 RVA: 0x004807E0 File Offset: 0x0047E9E0
		public IVectorInfoT CharacterLookAt { get; set; }

		// Token: 0x17009349 RID: 37705
		// (get) Token: 0x060205B7 RID: 132535 RVA: 0x004807E9 File Offset: 0x0047E9E9
		// (set) Token: 0x060205B8 RID: 132536 RVA: 0x004807F1 File Offset: 0x0047E9F1
		public int CharacterLookAtPointId { get; set; }

		// Token: 0x1700934A RID: 37706
		// (get) Token: 0x060205B9 RID: 132537 RVA: 0x004807FA File Offset: 0x0047E9FA
		// (set) Token: 0x060205BA RID: 132538 RVA: 0x00480802 File Offset: 0x0047EA02
		public int SlashBackSafePointId { get; set; }

		// Token: 0x1700934B RID: 37707
		// (get) Token: 0x060205BB RID: 132539 RVA: 0x0048080B File Offset: 0x0047EA0B
		// (set) Token: 0x060205BC RID: 132540 RVA: 0x00480813 File Offset: 0x0047EA13
		public bool IsAdjustCameraConfig { get; set; }

		// Token: 0x1700934C RID: 37708
		// (get) Token: 0x060205BD RID: 132541 RVA: 0x0048081C File Offset: 0x0047EA1C
		// (set) Token: 0x060205BE RID: 132542 RVA: 0x00480824 File Offset: 0x0047EA24
		public byte NullMask { get; set; }

		// Token: 0x060205BF RID: 132543 RVA: 0x00480830 File Offset: 0x0047EA30
		public IChargeSlashHookT()
		{
			this.Type = EHookInteractType.FixedPointHook;
			this.HookActions = null;
			this.ExitHookActions = null;
			this.FinishActions = null;
			this.ClientHookActionConfig = null;
			this.TargetEntityIds = null;
			this.MaxRandomDelayTime = 0f;
			this.CharacterLookAt = null;
			this.CharacterLookAtPointId = 0;
			this.SlashBackSafePointId = 0;
			this.IsAdjustCameraConfig = false;
			this.NullMask = 0;
		}
	}
}
