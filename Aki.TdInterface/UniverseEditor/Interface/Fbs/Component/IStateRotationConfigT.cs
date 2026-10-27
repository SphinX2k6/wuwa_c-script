using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059C0 RID: 22976
	public class IStateRotationConfigT
	{
		// Token: 0x1700AC6F RID: 44143
		// (get) Token: 0x06026F07 RID: 159495 RVA: 0x0055B83D File Offset: 0x00559A3D
		// (set) Token: 0x06026F08 RID: 159496 RVA: 0x0055B845 File Offset: 0x00559A45
		public string State { get; set; }

		// Token: 0x1700AC70 RID: 44144
		// (get) Token: 0x06026F09 RID: 159497 RVA: 0x0055B84E File Offset: 0x00559A4E
		// (set) Token: 0x06026F0A RID: 159498 RVA: 0x0055B856 File Offset: 0x00559A56
		public bool IsLoop { get; set; }

		// Token: 0x1700AC71 RID: 44145
		// (get) Token: 0x06026F0B RID: 159499 RVA: 0x0055B85F File Offset: 0x00559A5F
		// (set) Token: 0x06026F0C RID: 159500 RVA: 0x0055B867 File Offset: 0x00559A67
		public IStartRotationConfigT StartRotationConfig { get; set; }

		// Token: 0x1700AC72 RID: 44146
		// (get) Token: 0x06026F0D RID: 159501 RVA: 0x0055B870 File Offset: 0x00559A70
		// (set) Token: 0x06026F0E RID: 159502 RVA: 0x0055B878 File Offset: 0x00559A78
		public string RotatePoint { get; set; }

		// Token: 0x1700AC73 RID: 44147
		// (get) Token: 0x06026F0F RID: 159503 RVA: 0x0055B881 File Offset: 0x00559A81
		// (set) Token: 0x06026F10 RID: 159504 RVA: 0x0055B889 File Offset: 0x00559A89
		public List<IRotationConfigT> RotationConfig { get; set; }

		// Token: 0x1700AC74 RID: 44148
		// (get) Token: 0x06026F11 RID: 159505 RVA: 0x0055B892 File Offset: 0x00559A92
		// (set) Token: 0x06026F12 RID: 159506 RVA: 0x0055B89A File Offset: 0x00559A9A
		public List<IKeyRotatorConfigT> KeyRotatorConfig { get; set; }

		// Token: 0x1700AC75 RID: 44149
		// (get) Token: 0x06026F13 RID: 159507 RVA: 0x0055B8A3 File Offset: 0x00559AA3
		// (set) Token: 0x06026F14 RID: 159508 RVA: 0x0055B8AB File Offset: 0x00559AAB
		public bool KeepLastRotation { get; set; }

		// Token: 0x1700AC76 RID: 44150
		// (get) Token: 0x06026F15 RID: 159509 RVA: 0x0055B8B4 File Offset: 0x00559AB4
		// (set) Token: 0x06026F16 RID: 159510 RVA: 0x0055B8BC File Offset: 0x00559ABC
		public byte NullMask { get; set; }

		// Token: 0x06026F17 RID: 159511 RVA: 0x0055B8C5 File Offset: 0x00559AC5
		public IStateRotationConfigT()
		{
			this.State = null;
			this.IsLoop = false;
			this.StartRotationConfig = null;
			this.RotatePoint = null;
			this.RotationConfig = null;
			this.KeyRotatorConfig = null;
			this.KeepLastRotation = false;
			this.NullMask = 0;
		}
	}
}
