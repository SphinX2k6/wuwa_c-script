using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006926 RID: 26918
	public class ICatapultT
	{
		// Token: 0x1700C62B RID: 50731
		// (get) Token: 0x0602E216 RID: 188950 RVA: 0x0064DB25 File Offset: 0x0064BD25
		// (set) Token: 0x0602E217 RID: 188951 RVA: 0x0064DB2D File Offset: 0x0064BD2D
		public ELeisureInteract Type { get; set; }

		// Token: 0x1700C62C RID: 50732
		// (get) Token: 0x0602E218 RID: 188952 RVA: 0x0064DB36 File Offset: 0x0064BD36
		// (set) Token: 0x0602E219 RID: 188953 RVA: 0x0064DB3E File Offset: 0x0064BD3E
		public ICatapultParamT Param { get; set; }

		// Token: 0x1700C62D RID: 50733
		// (get) Token: 0x0602E21A RID: 188954 RVA: 0x0064DB47 File Offset: 0x0064BD47
		// (set) Token: 0x0602E21B RID: 188955 RVA: 0x0064DB4F File Offset: 0x0064BD4F
		public TCommonTargetUnion Target { get; set; }

		// Token: 0x0602E21C RID: 188956 RVA: 0x0064DB58 File Offset: 0x0064BD58
		public ICatapultT()
		{
			this.Type = ELeisureInteract.CustomSkill;
			this.Param = null;
			this.Target = null;
		}
	}
}
