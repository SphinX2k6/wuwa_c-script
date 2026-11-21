using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AD8 RID: 23256
	public class IMechPullHookInteractT
	{
		// Token: 0x1700A9A0 RID: 43424
		// (get) Token: 0x060262DA RID: 156378 RVA: 0x0053B71A File Offset: 0x0053991A
		// (set) Token: 0x060262DB RID: 156379 RVA: 0x0053B722 File Offset: 0x00539922
		public EMechHookInteractType Type { get; set; }

		// Token: 0x1700A9A1 RID: 43425
		// (get) Token: 0x060262DC RID: 156380 RVA: 0x0053B72B File Offset: 0x0053992B
		// (set) Token: 0x060262DD RID: 156381 RVA: 0x0053B733 File Offset: 0x00539933
		public List<IActionInfoT> HookActions { get; set; }

		// Token: 0x1700A9A2 RID: 43426
		// (get) Token: 0x060262DE RID: 156382 RVA: 0x0053B73C File Offset: 0x0053993C
		// (set) Token: 0x060262DF RID: 156383 RVA: 0x0053B744 File Offset: 0x00539944
		public List<IActionInfoT> ExitHookActions { get; set; }

		// Token: 0x1700A9A3 RID: 43427
		// (get) Token: 0x060262E0 RID: 156384 RVA: 0x0053B74D File Offset: 0x0053994D
		// (set) Token: 0x060262E1 RID: 156385 RVA: 0x0053B755 File Offset: 0x00539955
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x1700A9A4 RID: 43428
		// (get) Token: 0x060262E2 RID: 156386 RVA: 0x0053B75E File Offset: 0x0053995E
		// (set) Token: 0x060262E3 RID: 156387 RVA: 0x0053B766 File Offset: 0x00539966
		public IClientHookActionConfigT ClientHookActionConfig { get; set; }

		// Token: 0x1700A9A5 RID: 43429
		// (get) Token: 0x060262E4 RID: 156388 RVA: 0x0053B76F File Offset: 0x0053996F
		// (set) Token: 0x060262E5 RID: 156389 RVA: 0x0053B777 File Offset: 0x00539977
		public bool IsPlayPullProgress { get; set; }

		// Token: 0x1700A9A6 RID: 43430
		// (get) Token: 0x060262E6 RID: 156390 RVA: 0x0053B780 File Offset: 0x00539980
		// (set) Token: 0x060262E7 RID: 156391 RVA: 0x0053B788 File Offset: 0x00539988
		public float PullMoveSpeed { get; set; }

		// Token: 0x1700A9A7 RID: 43431
		// (get) Token: 0x060262E8 RID: 156392 RVA: 0x0053B791 File Offset: 0x00539991
		// (set) Token: 0x060262E9 RID: 156393 RVA: 0x0053B799 File Offset: 0x00539999
		public bool IsFixedWhenNotMech { get; set; }

		// Token: 0x1700A9A8 RID: 43432
		// (get) Token: 0x060262EA RID: 156394 RVA: 0x0053B7A2 File Offset: 0x005399A2
		// (set) Token: 0x060262EB RID: 156395 RVA: 0x0053B7AA File Offset: 0x005399AA
		public bool DisableAreaEffect { get; set; }

		// Token: 0x1700A9A9 RID: 43433
		// (get) Token: 0x060262EC RID: 156396 RVA: 0x0053B7B3 File Offset: 0x005399B3
		// (set) Token: 0x060262ED RID: 156397 RVA: 0x0053B7BB File Offset: 0x005399BB
		public bool DisableCollectEffect { get; set; }

		// Token: 0x1700A9AA RID: 43434
		// (get) Token: 0x060262EE RID: 156398 RVA: 0x0053B7C4 File Offset: 0x005399C4
		// (set) Token: 0x060262EF RID: 156399 RVA: 0x0053B7CC File Offset: 0x005399CC
		public byte NullMask { get; set; }

		// Token: 0x060262F0 RID: 156400 RVA: 0x0053B7D8 File Offset: 0x005399D8
		public IMechPullHookInteractT()
		{
			this.Type = EMechHookInteractType.FixedPointHook;
			this.HookActions = null;
			this.ExitHookActions = null;
			this.FinishActions = null;
			this.ClientHookActionConfig = null;
			this.IsPlayPullProgress = false;
			this.PullMoveSpeed = 0f;
			this.IsFixedWhenNotMech = false;
			this.DisableAreaEffect = false;
			this.DisableCollectEffect = false;
			this.NullMask = 0;
		}
	}
}
