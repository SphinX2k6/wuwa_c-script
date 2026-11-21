using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004B99 RID: 19353
	public class ICameraTemplateT
	{
		// Token: 0x170088F2 RID: 35058
		// (get) Token: 0x0601D824 RID: 120868 RVA: 0x00424B44 File Offset: 0x00422D44
		// (set) Token: 0x0601D825 RID: 120869 RVA: 0x00424B4C File Offset: 0x00422D4C
		public int Id { get; set; }

		// Token: 0x170088F3 RID: 35059
		// (get) Token: 0x0601D826 RID: 120870 RVA: 0x00424B55 File Offset: 0x00422D55
		// (set) Token: 0x0601D827 RID: 120871 RVA: 0x00424B5D File Offset: 0x00422D5D
		public string Name { get; set; }

		// Token: 0x170088F4 RID: 35060
		// (get) Token: 0x0601D828 RID: 120872 RVA: 0x00424B66 File Offset: 0x00422D66
		// (set) Token: 0x0601D829 RID: 120873 RVA: 0x00424B6E File Offset: 0x00422D6E
		public int Amount { get; set; }

		// Token: 0x170088F5 RID: 35061
		// (get) Token: 0x0601D82A RID: 120874 RVA: 0x00424B77 File Offset: 0x00422D77
		// (set) Token: 0x0601D82B RID: 120875 RVA: 0x00424B7F File Offset: 0x00422D7F
		public bool Enable { get; set; }

		// Token: 0x170088F6 RID: 35062
		// (get) Token: 0x0601D82C RID: 120876 RVA: 0x00424B88 File Offset: 0x00422D88
		// (set) Token: 0x0601D82D RID: 120877 RVA: 0x00424B90 File Offset: 0x00422D90
		public string Template { get; set; }

		// Token: 0x170088F7 RID: 35063
		// (get) Token: 0x0601D82E RID: 120878 RVA: 0x00424B99 File Offset: 0x00422D99
		// (set) Token: 0x0601D82F RID: 120879 RVA: 0x00424BA1 File Offset: 0x00422DA1
		public string CameraType { get; set; }

		// Token: 0x170088F8 RID: 35064
		// (get) Token: 0x0601D830 RID: 120880 RVA: 0x00424BAA File Offset: 0x00422DAA
		// (set) Token: 0x0601D831 RID: 120881 RVA: 0x00424BB2 File Offset: 0x00422DB2
		public List<IPosAT> ActorDataArray { get; set; }

		// Token: 0x170088F9 RID: 35065
		// (get) Token: 0x0601D832 RID: 120882 RVA: 0x00424BBB File Offset: 0x00422DBB
		// (set) Token: 0x0601D833 RID: 120883 RVA: 0x00424BC3 File Offset: 0x00422DC3
		public ICameraDataT CameraData { get; set; }

		// Token: 0x0601D834 RID: 120884 RVA: 0x00424BCC File Offset: 0x00422DCC
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
