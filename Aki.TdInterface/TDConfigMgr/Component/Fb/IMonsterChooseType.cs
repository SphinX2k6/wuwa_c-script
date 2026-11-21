using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EA9 RID: 3753
	public class IMonsterChooseType
	{
		// Token: 0x060054AE RID: 21678 RVA: 0x000D07A2 File Offset: 0x000CE9A2
		public static IMonsterChooseType Create(IMonsterChooseType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterChooseType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B57 RID: 6999
		// (get) Token: 0x060054AF RID: 21679 RVA: 0x000D07C1 File Offset: 0x000CE9C1
		public virtual EMonsterChooseType Type
		{
			get
			{
				return (EMonsterChooseType)this.Instance.Type;
			}
		}

		// Token: 0x04003068 RID: 12392
		private IMonsterChooseType Instance;
	}
}
