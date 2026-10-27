using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065DD RID: 26077
	public class IDisableCharacterSectionalSkillOptionT
	{
		// Token: 0x1700C192 RID: 49554
		// (get) Token: 0x0602D3BE RID: 185278 RVA: 0x00633302 File Offset: 0x00631502
		// (set) Token: 0x0602D3BF RID: 185279 RVA: 0x0063330A File Offset: 0x0063150A
		public bool DisableJump { get; set; }

		// Token: 0x1700C193 RID: 49555
		// (get) Token: 0x0602D3C0 RID: 185280 RVA: 0x00633313 File Offset: 0x00631513
		// (set) Token: 0x0602D3C1 RID: 185281 RVA: 0x0063331B File Offset: 0x0063151B
		public bool DisableShowClimb { get; set; }

		// Token: 0x1700C194 RID: 49556
		// (get) Token: 0x0602D3C2 RID: 185282 RVA: 0x00633324 File Offset: 0x00631524
		// (set) Token: 0x0602D3C3 RID: 185283 RVA: 0x0063332C File Offset: 0x0063152C
		public bool DisableAttack { get; set; }

		// Token: 0x1700C195 RID: 49557
		// (get) Token: 0x0602D3C4 RID: 185284 RVA: 0x00633335 File Offset: 0x00631535
		// (set) Token: 0x0602D3C5 RID: 185285 RVA: 0x0063333D File Offset: 0x0063153D
		public bool DisableDodge { get; set; }

		// Token: 0x1700C196 RID: 49558
		// (get) Token: 0x0602D3C6 RID: 185286 RVA: 0x00633346 File Offset: 0x00631546
		// (set) Token: 0x0602D3C7 RID: 185287 RVA: 0x0063334E File Offset: 0x0063154E
		public bool DisableSkill1 { get; set; }

		// Token: 0x1700C197 RID: 49559
		// (get) Token: 0x0602D3C8 RID: 185288 RVA: 0x00633357 File Offset: 0x00631557
		// (set) Token: 0x0602D3C9 RID: 185289 RVA: 0x0063335F File Offset: 0x0063155F
		public bool DisableUltimateSkill { get; set; }

		// Token: 0x1700C198 RID: 49560
		// (get) Token: 0x0602D3CA RID: 185290 RVA: 0x00633368 File Offset: 0x00631568
		// (set) Token: 0x0602D3CB RID: 185291 RVA: 0x00633370 File Offset: 0x00631570
		public bool DisableExploreInput { get; set; }

		// Token: 0x1700C199 RID: 49561
		// (get) Token: 0x0602D3CC RID: 185292 RVA: 0x00633379 File Offset: 0x00631579
		// (set) Token: 0x0602D3CD RID: 185293 RVA: 0x00633381 File Offset: 0x00631581
		public bool DisableSwitchRole1 { get; set; }

		// Token: 0x1700C19A RID: 49562
		// (get) Token: 0x0602D3CE RID: 185294 RVA: 0x0063338A File Offset: 0x0063158A
		// (set) Token: 0x0602D3CF RID: 185295 RVA: 0x00633392 File Offset: 0x00631592
		public bool DisableSwitchRole2 { get; set; }

		// Token: 0x1700C19B RID: 49563
		// (get) Token: 0x0602D3D0 RID: 185296 RVA: 0x0063339B File Offset: 0x0063159B
		// (set) Token: 0x0602D3D1 RID: 185297 RVA: 0x006333A3 File Offset: 0x006315A3
		public bool DisableSwitchRole3 { get; set; }

		// Token: 0x1700C19C RID: 49564
		// (get) Token: 0x0602D3D2 RID: 185298 RVA: 0x006333AC File Offset: 0x006315AC
		// (set) Token: 0x0602D3D3 RID: 185299 RVA: 0x006333B4 File Offset: 0x006315B4
		public bool DisableLock { get; set; }

		// Token: 0x1700C19D RID: 49565
		// (get) Token: 0x0602D3D4 RID: 185300 RVA: 0x006333BD File Offset: 0x006315BD
		// (set) Token: 0x0602D3D5 RID: 185301 RVA: 0x006333C5 File Offset: 0x006315C5
		public bool DisableAim { get; set; }

		// Token: 0x1700C19E RID: 49566
		// (get) Token: 0x0602D3D6 RID: 185302 RVA: 0x006333CE File Offset: 0x006315CE
		// (set) Token: 0x0602D3D7 RID: 185303 RVA: 0x006333D6 File Offset: 0x006315D6
		public ushort NullMask { get; set; }

		// Token: 0x0602D3D8 RID: 185304 RVA: 0x006333E0 File Offset: 0x006315E0
		public IDisableCharacterSectionalSkillOptionT()
		{
			this.DisableJump = false;
			this.DisableShowClimb = false;
			this.DisableAttack = false;
			this.DisableDodge = false;
			this.DisableSkill1 = false;
			this.DisableUltimateSkill = false;
			this.DisableExploreInput = false;
			this.DisableSwitchRole1 = false;
			this.DisableSwitchRole2 = false;
			this.DisableSwitchRole3 = false;
			this.DisableLock = false;
			this.DisableAim = false;
			this.NullMask = 0;
		}
	}
}
