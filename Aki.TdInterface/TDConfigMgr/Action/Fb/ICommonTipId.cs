using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A15 RID: 10773
	public class ICommonTipId : ICommonTipType
	{
		// Token: 0x0600EE1C RID: 60956 RVA: 0x0022F6AB File Offset: 0x0022D8AB
		public static ICommonTipId Create(ICommonTipId? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonTipId
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170046A0 RID: 18080
		// (get) Token: 0x0600EE1D RID: 60957 RVA: 0x0022F6CA File Offset: 0x0022D8CA
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x170046A1 RID: 18081
		// (get) Token: 0x0600EE1E RID: 60958 RVA: 0x0022F6D7 File Offset: 0x0022D8D7
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x040082F5 RID: 33525
		private ICommonTipId Instance;
	}
}
