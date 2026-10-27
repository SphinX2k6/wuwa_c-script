using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052F8 RID: 21240
	public class IGodKingFrequencyControllerComponentT
	{
		// Token: 0x17009BEF RID: 39919
		// (get) Token: 0x06022B00 RID: 142080 RVA: 0x004CEBD7 File Offset: 0x004CCDD7
		// (set) Token: 0x06022B01 RID: 142081 RVA: 0x004CEBDF File Offset: 0x004CCDDF
		public bool Disabled { get; set; }

		// Token: 0x17009BF0 RID: 39920
		// (get) Token: 0x06022B02 RID: 142082 RVA: 0x004CEBE8 File Offset: 0x004CCDE8
		// (set) Token: 0x06022B03 RID: 142083 RVA: 0x004CEBF0 File Offset: 0x004CCDF0
		public List<int> StatueEntityIdList { get; set; }

		// Token: 0x17009BF1 RID: 39921
		// (get) Token: 0x06022B04 RID: 142084 RVA: 0x004CEBF9 File Offset: 0x004CCDF9
		// (set) Token: 0x06022B05 RID: 142085 RVA: 0x004CEC01 File Offset: 0x004CCE01
		public int InitialAttachStatue { get; set; }

		// Token: 0x17009BF2 RID: 39922
		// (get) Token: 0x06022B06 RID: 142086 RVA: 0x004CEC0A File Offset: 0x004CCE0A
		// (set) Token: 0x06022B07 RID: 142087 RVA: 0x004CEC12 File Offset: 0x004CCE12
		public int GodKingFrequencyEntity { get; set; }

		// Token: 0x17009BF3 RID: 39923
		// (get) Token: 0x06022B08 RID: 142088 RVA: 0x004CEC1B File Offset: 0x004CCE1B
		// (set) Token: 0x06022B09 RID: 142089 RVA: 0x004CEC23 File Offset: 0x004CCE23
		public string AttachSocket { get; set; }

		// Token: 0x17009BF4 RID: 39924
		// (get) Token: 0x06022B0A RID: 142090 RVA: 0x004CEC2C File Offset: 0x004CCE2C
		// (set) Token: 0x06022B0B RID: 142091 RVA: 0x004CEC34 File Offset: 0x004CCE34
		public float FlySpeed { get; set; }

		// Token: 0x17009BF5 RID: 39925
		// (get) Token: 0x06022B0C RID: 142092 RVA: 0x004CEC3D File Offset: 0x004CCE3D
		// (set) Token: 0x06022B0D RID: 142093 RVA: 0x004CEC45 File Offset: 0x004CCE45
		public float MaxFlyTime { get; set; }

		// Token: 0x17009BF6 RID: 39926
		// (get) Token: 0x06022B0E RID: 142094 RVA: 0x004CEC4E File Offset: 0x004CCE4E
		// (set) Token: 0x06022B0F RID: 142095 RVA: 0x004CEC56 File Offset: 0x004CCE56
		public byte NullMask { get; set; }

		// Token: 0x06022B10 RID: 142096 RVA: 0x004CEC60 File Offset: 0x004CCE60
		public IGodKingFrequencyControllerComponentT()
		{
			this.Disabled = false;
			this.StatueEntityIdList = null;
			this.InitialAttachStatue = 0;
			this.GodKingFrequencyEntity = 0;
			this.AttachSocket = null;
			this.FlySpeed = 0f;
			this.MaxFlyTime = 0f;
			this.NullMask = 0;
		}
	}
}
