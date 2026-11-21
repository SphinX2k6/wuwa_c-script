using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035B6 RID: 13750
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class InputDistributeSetup
	{
		// Token: 0x060230D9 RID: 143577
		public abstract bool OnRefresh();

		// Token: 0x060230DA RID: 143578 RVA: 0x009F7B5B File Offset: 0x009F5D5B
		protected void SetInputDistributeTag(string tagName)
		{
			InputDistributeModel.Instance.SetInputDistributeTag(tagName);
		}

		// Token: 0x060230DB RID: 143579 RVA: 0x009F7B68 File Offset: 0x009F5D68
		protected void SetInputDistributeTags(IList<string> tagNames)
		{
			InputDistributeModel.Instance.SetInputDistributeTags(tagNames);
		}

		// Token: 0x060230DC RID: 143580 RVA: 0x009F7B75 File Offset: 0x009F5D75
		protected void AddInputDistributeTag(string tagName)
		{
			InputDistributeModel.Instance.AddInputDistributeTag(tagName);
		}

		// Token: 0x060230DD RID: 143581 RVA: 0x009F7B82 File Offset: 0x009F5D82
		protected void RemoveInputDistributeTag(string tagName, bool bRemoveChild = false)
		{
			InputDistributeModel.Instance.RemoveInputDistributeTag(tagName, bRemoveChild);
		}
	}
}
