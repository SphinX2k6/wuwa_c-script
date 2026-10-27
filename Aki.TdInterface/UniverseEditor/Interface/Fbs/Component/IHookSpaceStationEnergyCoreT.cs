using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053DB RID: 21467
	public class IHookSpaceStationEnergyCoreT
	{
		// Token: 0x17009DF1 RID: 40433
		// (get) Token: 0x060233CD RID: 144333 RVA: 0x004E1496 File Offset: 0x004DF696
		// (set) Token: 0x060233CE RID: 144334 RVA: 0x004E149E File Offset: 0x004DF69E
		public EHookInteractType Type { get; set; }

		// Token: 0x17009DF2 RID: 40434
		// (get) Token: 0x060233CF RID: 144335 RVA: 0x004E14A7 File Offset: 0x004DF6A7
		// (set) Token: 0x060233D0 RID: 144336 RVA: 0x004E14AF File Offset: 0x004DF6AF
		public List<IActionInfoT> HookActions { get; set; }

		// Token: 0x17009DF3 RID: 40435
		// (get) Token: 0x060233D1 RID: 144337 RVA: 0x004E14B8 File Offset: 0x004DF6B8
		// (set) Token: 0x060233D2 RID: 144338 RVA: 0x004E14C0 File Offset: 0x004DF6C0
		public List<IActionInfoT> ExitHookActions { get; set; }

		// Token: 0x17009DF4 RID: 40436
		// (get) Token: 0x060233D3 RID: 144339 RVA: 0x004E14C9 File Offset: 0x004DF6C9
		// (set) Token: 0x060233D4 RID: 144340 RVA: 0x004E14D1 File Offset: 0x004DF6D1
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x17009DF5 RID: 40437
		// (get) Token: 0x060233D5 RID: 144341 RVA: 0x004E14DA File Offset: 0x004DF6DA
		// (set) Token: 0x060233D6 RID: 144342 RVA: 0x004E14E2 File Offset: 0x004DF6E2
		public IClientHookActionConfigT ClientHookActionConfig { get; set; }

		// Token: 0x17009DF6 RID: 40438
		// (get) Token: 0x060233D7 RID: 144343 RVA: 0x004E14EB File Offset: 0x004DF6EB
		// (set) Token: 0x060233D8 RID: 144344 RVA: 0x004E14F3 File Offset: 0x004DF6F3
		public int HookSpeed { get; set; }

		// Token: 0x17009DF7 RID: 40439
		// (get) Token: 0x060233D9 RID: 144345 RVA: 0x004E14FC File Offset: 0x004DF6FC
		// (set) Token: 0x060233DA RID: 144346 RVA: 0x004E1504 File Offset: 0x004DF704
		public byte NullMask { get; set; }

		// Token: 0x060233DB RID: 144347 RVA: 0x004E150D File Offset: 0x004DF70D
		public IHookSpaceStationEnergyCoreT()
		{
			this.Type = EHookInteractType.FixedPointHook;
			this.HookActions = null;
			this.ExitHookActions = null;
			this.FinishActions = null;
			this.ClientHookActionConfig = null;
			this.HookSpeed = 0;
			this.NullMask = 0;
		}
	}
}
