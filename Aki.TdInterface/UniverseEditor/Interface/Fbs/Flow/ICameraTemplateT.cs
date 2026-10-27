using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004731 RID: 18225
	public class ICameraTemplateT
	{
		// Token: 0x170082B1 RID: 33457
		// (get) Token: 0x0601C04F RID: 114767 RVA: 0x003F88A8 File Offset: 0x003F6AA8
		// (set) Token: 0x0601C050 RID: 114768 RVA: 0x003F88B0 File Offset: 0x003F6AB0
		public int Id { get; set; }

		// Token: 0x170082B2 RID: 33458
		// (get) Token: 0x0601C051 RID: 114769 RVA: 0x003F88B9 File Offset: 0x003F6AB9
		// (set) Token: 0x0601C052 RID: 114770 RVA: 0x003F88C1 File Offset: 0x003F6AC1
		public string Name { get; set; }

		// Token: 0x170082B3 RID: 33459
		// (get) Token: 0x0601C053 RID: 114771 RVA: 0x003F88CA File Offset: 0x003F6ACA
		// (set) Token: 0x0601C054 RID: 114772 RVA: 0x003F88D2 File Offset: 0x003F6AD2
		public int Amount { get; set; }

		// Token: 0x170082B4 RID: 33460
		// (get) Token: 0x0601C055 RID: 114773 RVA: 0x003F88DB File Offset: 0x003F6ADB
		// (set) Token: 0x0601C056 RID: 114774 RVA: 0x003F88E3 File Offset: 0x003F6AE3
		public bool Enable { get; set; }

		// Token: 0x170082B5 RID: 33461
		// (get) Token: 0x0601C057 RID: 114775 RVA: 0x003F88EC File Offset: 0x003F6AEC
		// (set) Token: 0x0601C058 RID: 114776 RVA: 0x003F88F4 File Offset: 0x003F6AF4
		public string Template { get; set; }

		// Token: 0x170082B6 RID: 33462
		// (get) Token: 0x0601C059 RID: 114777 RVA: 0x003F88FD File Offset: 0x003F6AFD
		// (set) Token: 0x0601C05A RID: 114778 RVA: 0x003F8905 File Offset: 0x003F6B05
		public string CameraType { get; set; }

		// Token: 0x170082B7 RID: 33463
		// (get) Token: 0x0601C05B RID: 114779 RVA: 0x003F890E File Offset: 0x003F6B0E
		// (set) Token: 0x0601C05C RID: 114780 RVA: 0x003F8916 File Offset: 0x003F6B16
		public List<IPosAT> ActorDataArray { get; set; }

		// Token: 0x170082B8 RID: 33464
		// (get) Token: 0x0601C05D RID: 114781 RVA: 0x003F891F File Offset: 0x003F6B1F
		// (set) Token: 0x0601C05E RID: 114782 RVA: 0x003F8927 File Offset: 0x003F6B27
		public ICameraDataT CameraData { get; set; }

		// Token: 0x0601C05F RID: 114783 RVA: 0x003F8930 File Offset: 0x003F6B30
		public ICameraTemplateT()
		{
			this.Id = 0;
			this.Name = null;
			this.Amount = 0;
			this.Enable = false;
			this.Template = null;
			this.CameraType = null;
			this.ActorDataArray = null;
			this.CameraData = null;
		}
	}
}
