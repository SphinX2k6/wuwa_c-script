using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DFF RID: 11775
	public class IChangeElementalBoxStateTarget
	{
		// Token: 0x0600FFFB RID: 65531 RVA: 0x0024DA9A File Offset: 0x0024BC9A
		public static IChangeElementalBoxStateTarget Create(IChangeElementalBoxStateTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChangeElementalBoxStateTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170050AB RID: 20651
		// (get) Token: 0x0600FFFC RID: 65532 RVA: 0x0024DAB9 File Offset: 0x0024BCB9
		public virtual EChangeElementalBoxStateTargetType Type
		{
			get
			{
				return (EChangeElementalBoxStateTargetType)this.Instance.Type;
			}
		}

		// Token: 0x04008BB5 RID: 35765
		private IChangeElementalBoxStateTarget Instance;
	}
}
