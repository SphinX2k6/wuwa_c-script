using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BFF RID: 11263
	public class ICreatePrefabConfig
	{
		// Token: 0x0600F811 RID: 63505 RVA: 0x002415B7 File Offset: 0x0023F7B7
		public static ICreatePrefabConfig Create(ICreatePrefabConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICreatePrefabConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CC1 RID: 19649
		// (get) Token: 0x0600F812 RID: 63506 RVA: 0x002415D6 File Offset: 0x0023F7D6
		public virtual ECreatePrefabType Type
		{
			get
			{
				return (ECreatePrefabType)this.Instance.Type;
			}
		}

		// Token: 0x040087C3 RID: 34755
		private ICreatePrefabConfig Instance;
	}
}
