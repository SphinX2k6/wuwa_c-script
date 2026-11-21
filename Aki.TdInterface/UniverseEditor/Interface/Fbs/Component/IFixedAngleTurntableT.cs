using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057D0 RID: 22480
	public class IFixedAngleTurntableT
	{
		// Token: 0x1700A27F RID: 41599
		// (get) Token: 0x060244BD RID: 148669 RVA: 0x004FCBD5 File Offset: 0x004FADD5
		// (set) Token: 0x060244BE RID: 148670 RVA: 0x004FCBDD File Offset: 0x004FADDD
		public EControllerType Type { get; set; }

		// Token: 0x1700A280 RID: 41600
		// (get) Token: 0x060244BF RID: 148671 RVA: 0x004FCBE6 File Offset: 0x004FADE6
		// (set) Token: 0x060244C0 RID: 148672 RVA: 0x004FCBEE File Offset: 0x004FADEE
		public int RotationSpeed { get; set; }

		// Token: 0x1700A281 RID: 41601
		// (get) Token: 0x060244C1 RID: 148673 RVA: 0x004FCBF7 File Offset: 0x004FADF7
		// (set) Token: 0x060244C2 RID: 148674 RVA: 0x004FCBFF File Offset: 0x004FADFF
		public List<IFixedAngleItemT> ItemConfig { get; set; }

		// Token: 0x060244C3 RID: 148675 RVA: 0x004FCC08 File Offset: 0x004FAE08
		public IFixedAngleTurntableT()
		{
			this.Type = EControllerType.FreeAngle;
			this.RotationSpeed = 0;
			this.ItemConfig = null;
		}
	}
}
