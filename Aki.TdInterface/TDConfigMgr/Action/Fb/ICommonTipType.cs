using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002740 RID: 10048
	public class ICommonTipType
	{
		// Token: 0x0600DFEB RID: 57323 RVA: 0x002128E5 File Offset: 0x00210AE5
		[NullableContext(1)]
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

		// Token: 0x1700432D RID: 17197
		// (get) Token: 0x0600DFEC RID: 57324 RVA: 0x00212904 File Offset: 0x00210B04
		public virtual ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x04007C3E RID: 31806
		private ICommonTipType Instance;
	}
}
