using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005740 RID: 22336
	public class IPilotThrowT
	{
		// Token: 0x1700A691 RID: 42641
		// (get) Token: 0x060256A5 RID: 153253 RVA: 0x00529F21 File Offset: 0x00528121
		// (set) Token: 0x060256A6 RID: 153254 RVA: 0x00529F29 File Offset: 0x00528129
		public EHookInteractType Type { get; set; }

		// Token: 0x1700A692 RID: 42642
		// (get) Token: 0x060256A7 RID: 153255 RVA: 0x00529F32 File Offset: 0x00528132
		// (set) Token: 0x060256A8 RID: 153256 RVA: 0x00529F3A File Offset: 0x0052813A
		public List<IActionInfoT> HookActions { get; set; }

		// Token: 0x1700A693 RID: 42643
		// (get) Token: 0x060256A9 RID: 153257 RVA: 0x00529F43 File Offset: 0x00528143
		// (set) Token: 0x060256AA RID: 153258 RVA: 0x00529F4B File Offset: 0x0052814B
		public List<IActionInfoT> ExitHookActions { get; set; }

		// Token: 0x1700A694 RID: 42644
		// (get) Token: 0x060256AB RID: 153259 RVA: 0x00529F54 File Offset: 0x00528154
		// (set) Token: 0x060256AC RID: 153260 RVA: 0x00529F5C File Offset: 0x0052815C
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x1700A695 RID: 42645
		// (get) Token: 0x060256AD RID: 153261 RVA: 0x00529F65 File Offset: 0x00528165
		// (set) Token: 0x060256AE RID: 153262 RVA: 0x00529F6D File Offset: 0x0052816D
		public IClientHookActionConfigT ClientHookActionConfig { get; set; }

		// Token: 0x1700A696 RID: 42646
		// (get) Token: 0x060256AF RID: 153263 RVA: 0x00529F76 File Offset: 0x00528176
		// (set) Token: 0x060256B0 RID: 153264 RVA: 0x00529F7E File Offset: 0x0052817E
		public int TitanEntityId { get; set; }

		// Token: 0x1700A697 RID: 42647
		// (get) Token: 0x060256B1 RID: 153265 RVA: 0x00529F87 File Offset: 0x00528187
		// (set) Token: 0x060256B2 RID: 153266 RVA: 0x00529F8F File Offset: 0x0052818F
		public float MinPitchAngle { get; set; }

		// Token: 0x1700A698 RID: 42648
		// (get) Token: 0x060256B3 RID: 153267 RVA: 0x00529F98 File Offset: 0x00528198
		// (set) Token: 0x060256B4 RID: 153268 RVA: 0x00529FA0 File Offset: 0x005281A0
		public float DefaultPitchAngle { get; set; }

		// Token: 0x1700A699 RID: 42649
		// (get) Token: 0x060256B5 RID: 153269 RVA: 0x00529FA9 File Offset: 0x005281A9
		// (set) Token: 0x060256B6 RID: 153270 RVA: 0x00529FB1 File Offset: 0x005281B1
		public float MaxPitchAngle { get; set; }

		// Token: 0x1700A69A RID: 42650
		// (get) Token: 0x060256B7 RID: 153271 RVA: 0x00529FBA File Offset: 0x005281BA
		// (set) Token: 0x060256B8 RID: 153272 RVA: 0x00529FC2 File Offset: 0x005281C2
		public float MaxYawAngleDelta { get; set; }

		// Token: 0x1700A69B RID: 42651
		// (get) Token: 0x060256B9 RID: 153273 RVA: 0x00529FCB File Offset: 0x005281CB
		// (set) Token: 0x060256BA RID: 153274 RVA: 0x00529FD3 File Offset: 0x005281D3
		public float FlySpeed { get; set; }

		// Token: 0x1700A69C RID: 42652
		// (get) Token: 0x060256BB RID: 153275 RVA: 0x00529FDC File Offset: 0x005281DC
		// (set) Token: 0x060256BC RID: 153276 RVA: 0x00529FE4 File Offset: 0x005281E4
		public float Gravity { get; set; }

		// Token: 0x1700A69D RID: 42653
		// (get) Token: 0x060256BD RID: 153277 RVA: 0x00529FED File Offset: 0x005281ED
		// (set) Token: 0x060256BE RID: 153278 RVA: 0x00529FF5 File Offset: 0x005281F5
		public List<IPilotThrowTargetT> TargetList { get; set; }

		// Token: 0x1700A69E RID: 42654
		// (get) Token: 0x060256BF RID: 153279 RVA: 0x00529FFE File Offset: 0x005281FE
		// (set) Token: 0x060256C0 RID: 153280 RVA: 0x0052A006 File Offset: 0x00528206
		public EPilotThrowAutoThrowType AutoThrowType { get; set; }

		// Token: 0x1700A69F RID: 42655
		// (get) Token: 0x060256C1 RID: 153281 RVA: 0x0052A00F File Offset: 0x0052820F
		// (set) Token: 0x060256C2 RID: 153282 RVA: 0x0052A017 File Offset: 0x00528217
		public bool IsAutoRide { get; set; }

		// Token: 0x1700A6A0 RID: 42656
		// (get) Token: 0x060256C3 RID: 153283 RVA: 0x0052A020 File Offset: 0x00528220
		// (set) Token: 0x060256C4 RID: 153284 RVA: 0x0052A028 File Offset: 0x00528228
		public bool DisableInterrupt { get; set; }

		// Token: 0x1700A6A1 RID: 42657
		// (get) Token: 0x060256C5 RID: 153285 RVA: 0x0052A031 File Offset: 0x00528231
		// (set) Token: 0x060256C6 RID: 153286 RVA: 0x0052A039 File Offset: 0x00528239
		public byte NullMask { get; set; }

		// Token: 0x060256C7 RID: 153287 RVA: 0x0052A044 File Offset: 0x00528244
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
