using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005752 RID: 22354
	public class IExploreSkillInteractGroupComponentT
	{
		// Token: 0x1700A19A RID: 41370
		// (get) Token: 0x06024072 RID: 147570 RVA: 0x004F4C79 File Offset: 0x004F2E79
		// (set) Token: 0x06024073 RID: 147571 RVA: 0x004F4C81 File Offset: 0x004F2E81
		public bool Disabled { get; set; }

		// Token: 0x1700A19B RID: 41371
		// (get) Token: 0x06024074 RID: 147572 RVA: 0x004F4C8A File Offset: 0x004F2E8A
		// (set) Token: 0x06024075 RID: 147573 RVA: 0x004F4C92 File Offset: 0x004F2E92
		public List<IExploreSkillInteractT> ExploreSkillInteractList { get; set; }

		// Token: 0x1700A19C RID: 41372
		// (get) Token: 0x06024076 RID: 147574 RVA: 0x004F4C9B File Offset: 0x004F2E9B
		// (set) Token: 0x06024077 RID: 147575 RVA: 0x004F4CA3 File Offset: 0x004F2EA3
		public byte NullMask { get; set; }

		// Token: 0x06024078 RID: 147576 RVA: 0x004F4CAC File Offset: 0x004F2EAC
		public IExploreSkillInteractGroupComponentT()
		{
			this.Disabled = false;
			this.ExploreSkillInteractList = null;
			this.NullMask = 0;
		}
	}
}
