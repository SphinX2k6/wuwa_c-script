using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A0C RID: 10764
	public class ICommonTipType
	{
		// Token: 0x0600EDEB RID: 60907 RVA: 0x0022F41D File Offset: 0x0022D61D
		public static ICommonTipType Create(ICommonTipType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonTipType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004681 RID: 18049
		// (get) Token: 0x0600EDEC RID: 60908 RVA: 0x0022F43C File Offset: 0x0022D63C
		public virtual ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x040082EC RID: 33516
		private ICommonTipType Instance;
	}
}
