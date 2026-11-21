using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D57 RID: 11607
	public class RemoveNpcGroupPerform : ActionParams
	{
		// Token: 0x0600FD64 RID: 64868 RVA: 0x002497A2 File Offset: 0x002479A2
		public static RemoveNpcGroupPerform Create(IRemoveNpcGroupPerform? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RemoveNpcGroupPerform
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F64 RID: 20324
		// (get) Token: 0x0600FD65 RID: 64869 RVA: 0x002497C1 File Offset: 0x002479C1
		public virtual string Key
		{
			get
			{
				return this.Instance.Key;
			}
		}

		// Token: 0x04008A51 RID: 35409
		private IRemoveNpcGroupPerform Instance;
	}
}
