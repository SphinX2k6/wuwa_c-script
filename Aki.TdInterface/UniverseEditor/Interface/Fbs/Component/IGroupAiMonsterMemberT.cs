using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058C8 RID: 22728
	public class IGroupAiMonsterMemberT
	{
		// Token: 0x1700A4C8 RID: 42184
		// (get) Token: 0x06024E68 RID: 151144 RVA: 0x005112A5 File Offset: 0x0050F4A5
		// (set) Token: 0x06024E69 RID: 151145 RVA: 0x005112AD File Offset: 0x0050F4AD
		public int EntityId { get; set; }

		// Token: 0x1700A4C9 RID: 42185
		// (get) Token: 0x06024E6A RID: 151146 RVA: 0x005112B6 File Offset: 0x0050F4B6
		// (set) Token: 0x06024E6B RID: 151147 RVA: 0x005112BE File Offset: 0x0050F4BE
		public IPosAndRotT RelativeTransform { get; set; }

		// Token: 0x1700A4CA RID: 42186
		// (get) Token: 0x06024E6C RID: 151148 RVA: 0x005112C7 File Offset: 0x0050F4C7
		// (set) Token: 0x06024E6D RID: 151149 RVA: 0x005112CF File Offset: 0x0050F4CF
		public IGroupAiMonsterMemberActionTagAttachT ActionTagAttach { get; set; }

		// Token: 0x06024E6E RID: 151150 RVA: 0x005112D8 File Offset: 0x0050F4D8
		public IGroupAiMonsterMemberT()
		{
			this.EntityId = 0;
			this.RelativeTransform = null;
			this.ActionTagAttach = null;
		}
	}
}
