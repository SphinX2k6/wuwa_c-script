using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029C0 RID: 10688
	public class IMonsterNpcInteractConfigBase
	{
		// Token: 0x0600ECAD RID: 60589 RVA: 0x0022D3B2 File Offset: 0x0022B5B2
		public static IMonsterNpcInteractConfigBase Create(IMonsterNpcInteractConfigBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterNpcInteractConfigBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045DB RID: 17883
		// (get) Token: 0x0600ECAE RID: 60590 RVA: 0x0022D3D1 File Offset: 0x0022B5D1
		public virtual EMonsterNpcInteractType Type
		{
			get
			{
				return (EMonsterNpcInteractType)this.Instance.Type;
			}
		}

		// Token: 0x0400824A RID: 33354
		private IMonsterNpcInteractConfigBase Instance;
	}
}
