using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E6A RID: 28266
	public class IFloorSettingsT
	{
		// Token: 0x1700CF26 RID: 53030
		// (get) Token: 0x06030D4F RID: 200015 RVA: 0x006A0272 File Offset: 0x0069E472
		// (set) Token: 0x06030D50 RID: 200016 RVA: 0x006A027A File Offset: 0x0069E47A
		public string MeshPath { get; set; }

		// Token: 0x1700CF27 RID: 53031
		// (get) Token: 0x06030D51 RID: 200017 RVA: 0x006A0283 File Offset: 0x0069E483
		// (set) Token: 0x06030D52 RID: 200018 RVA: 0x006A028B File Offset: 0x0069E48B
		public string MaterialPath { get; set; }

		// Token: 0x1700CF28 RID: 53032
		// (get) Token: 0x06030D53 RID: 200019 RVA: 0x006A0294 File Offset: 0x0069E494
		// (set) Token: 0x06030D54 RID: 200020 RVA: 0x006A029C File Offset: 0x0069E49C
		public IVector2T Scale { get; set; }

		// Token: 0x1700CF29 RID: 53033
		// (get) Token: 0x06030D55 RID: 200021 RVA: 0x006A02A5 File Offset: 0x0069E4A5
		// (set) Token: 0x06030D56 RID: 200022 RVA: 0x006A02AD File Offset: 0x0069E4AD
		public float ShowTime { get; set; }

		// Token: 0x1700CF2A RID: 53034
		// (get) Token: 0x06030D57 RID: 200023 RVA: 0x006A02B6 File Offset: 0x0069E4B6
		// (set) Token: 0x06030D58 RID: 200024 RVA: 0x006A02BE File Offset: 0x0069E4BE
		public float DisappearTime { get; set; }

		// Token: 0x06030D59 RID: 200025 RVA: 0x006A02C7 File Offset: 0x0069E4C7
		public IFloorSettingsT()
		{
			this.MeshPath = null;
			this.MaterialPath = null;
			this.Scale = null;
			this.ShowTime = 0f;
			this.DisappearTime = 0f;
		}
	}
}
