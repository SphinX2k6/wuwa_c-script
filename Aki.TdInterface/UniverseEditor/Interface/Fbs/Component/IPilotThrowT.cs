using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D47 RID: 23879
	public class IPilotThrowT
	{
		// Token: 0x1700AFB5 RID: 44981
		// (get) Token: 0x06027BC5 RID: 162757 RVA: 0x005700AD File Offset: 0x0056E2AD
		// (set) Token: 0x06027BC6 RID: 162758 RVA: 0x005700B5 File Offset: 0x0056E2B5
		public EHookInteractType Type { get; set; }

		// Token: 0x1700AFB6 RID: 44982
		// (get) Token: 0x06027BC7 RID: 162759 RVA: 0x005700BE File Offset: 0x0056E2BE
		// (set) Token: 0x06027BC8 RID: 162760 RVA: 0x005700C6 File Offset: 0x0056E2C6
		public List<IActionInfoT> HookActions { get; set; }

		// Token: 0x1700AFB7 RID: 44983
		// (get) Token: 0x06027BC9 RID: 162761 RVA: 0x005700CF File Offset: 0x0056E2CF
		// (set) Token: 0x06027BCA RID: 162762 RVA: 0x005700D7 File Offset: 0x0056E2D7
		public List<IActionInfoT> ExitHookActions { get; set; }

		// Token: 0x1700AFB8 RID: 44984
		// (get) Token: 0x06027BCB RID: 162763 RVA: 0x005700E0 File Offset: 0x0056E2E0
		// (set) Token: 0x06027BCC RID: 162764 RVA: 0x005700E8 File Offset: 0x0056E2E8
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x1700AFB9 RID: 44985
		// (get) Token: 0x06027BCD RID: 162765 RVA: 0x005700F1 File Offset: 0x0056E2F1
		// (set) Token: 0x06027BCE RID: 162766 RVA: 0x005700F9 File Offset: 0x0056E2F9
		public IClientHookActionConfigT ClientHookActionConfig { get; set; }

		// Token: 0x1700AFBA RID: 44986
		// (get) Token: 0x06027BCF RID: 162767 RVA: 0x00570102 File Offset: 0x0056E302
		// (set) Token: 0x06027BD0 RID: 162768 RVA: 0x0057010A File Offset: 0x0056E30A
		public int TitanEntityId { get; set; }

		// Token: 0x1700AFBB RID: 44987
		// (get) Token: 0x06027BD1 RID: 162769 RVA: 0x00570113 File Offset: 0x0056E313
		// (set) Token: 0x06027BD2 RID: 162770 RVA: 0x0057011B File Offset: 0x0056E31B
		public float MinPitchAngle { get; set; }

		// Token: 0x1700AFBC RID: 44988
		// (get) Token: 0x06027BD3 RID: 162771 RVA: 0x00570124 File Offset: 0x0056E324
		// (set) Token: 0x06027BD4 RID: 162772 RVA: 0x0057012C File Offset: 0x0056E32C
		public float DefaultPitchAngle { get; set; }

		// Token: 0x1700AFBD RID: 44989
		// (get) Token: 0x06027BD5 RID: 162773 RVA: 0x00570135 File Offset: 0x0056E335
		// (set) Token: 0x06027BD6 RID: 162774 RVA: 0x0057013D File Offset: 0x0056E33D
		public float MaxPitchAngle { get; set; }

		// Token: 0x1700AFBE RID: 44990
		// (get) Token: 0x06027BD7 RID: 162775 RVA: 0x00570146 File Offset: 0x0056E346
		// (set) Token: 0x06027BD8 RID: 162776 RVA: 0x0057014E File Offset: 0x0056E34E
		public float MaxYawAngleDelta { get; set; }

		// Token: 0x1700AFBF RID: 44991
		// (get) Token: 0x06027BD9 RID: 162777 RVA: 0x00570157 File Offset: 0x0056E357
		// (set) Token: 0x06027BDA RID: 162778 RVA: 0x0057015F File Offset: 0x0056E35F
		public float FlySpeed { get; set; }

		// Token: 0x1700AFC0 RID: 44992
		// (get) Token: 0x06027BDB RID: 162779 RVA: 0x00570168 File Offset: 0x0056E368
		// (set) Token: 0x06027BDC RID: 162780 RVA: 0x00570170 File Offset: 0x0056E370
		public float Gravity { get; set; }

		// Token: 0x1700AFC1 RID: 44993
		// (get) Token: 0x06027BDD RID: 162781 RVA: 0x00570179 File Offset: 0x0056E379
		// (set) Token: 0x06027BDE RID: 162782 RVA: 0x00570181 File Offset: 0x0056E381
		public List<IPilotThrowTargetT> TargetList { get; set; }

		// Token: 0x1700AFC2 RID: 44994
		// (get) Token: 0x06027BDF RID: 162783 RVA: 0x0057018A File Offset: 0x0056E38A
		// (set) Token: 0x06027BE0 RID: 162784 RVA: 0x00570192 File Offset: 0x0056E392
		public EPilotThrowAutoThrowType AutoThrowType { get; set; }

		// Token: 0x1700AFC3 RID: 44995
		// (get) Token: 0x06027BE1 RID: 162785 RVA: 0x0057019B File Offset: 0x0056E39B
		// (set) Token: 0x06027BE2 RID: 162786 RVA: 0x005701A3 File Offset: 0x0056E3A3
		public bool IsAutoRide { get; set; }

		// Token: 0x1700AFC4 RID: 44996
		// (get) Token: 0x06027BE3 RID: 162787 RVA: 0x005701AC File Offset: 0x0056E3AC
		// (set) Token: 0x06027BE4 RID: 162788 RVA: 0x005701B4 File Offset: 0x0056E3B4
		public bool DisableInterrupt { get; set; }

		// Token: 0x1700AFC5 RID: 44997
		// (get) Token: 0x06027BE5 RID: 162789 RVA: 0x005701BD File Offset: 0x0056E3BD
		// (set) Token: 0x06027BE6 RID: 162790 RVA: 0x005701C5 File Offset: 0x0056E3C5
		public byte NullMask { get; set; }

		// Token: 0x06027BE7 RID: 162791 RVA: 0x005701D0 File Offset: 0x0056E3D0
		public IPilotThrowT()
		{
			this.Type = EHookInteractType.FixedPointHook;
			this.HookActions = null;
			this.ExitHookActions = null;
			this.FinishActions = null;
			this.ClientHookActionConfig = null;
			this.TitanEntityId = 0;
			this.MinPitchAngle = 0f;
			this.DefaultPitchAngle = 0f;
			this.MaxPitchAngle = 0f;
			this.MaxYawAngleDelta = 0f;
			this.FlySpeed = 0f;
			this.Gravity = 0f;
			this.TargetList = null;
			this.AutoThrowType = EPilotThrowAutoThrowType.LowAngle;
			this.IsAutoRide = false;
			this.DisableInterrupt = false;
			this.NullMask = 0;
		}
	}
}
