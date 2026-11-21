using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D50 RID: 11600
	public class INpcGroupSequenceBindingBase
	{
		// Token: 0x0600FD46 RID: 64838 RVA: 0x002493FD File Offset: 0x002475FD
		public static INpcGroupSequenceBindingBase Create(INpcGroupSequenceBindingBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcGroupSequenceBindingBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F54 RID: 20308
		// (get) Token: 0x0600FD47 RID: 64839 RVA: 0x0024941C File Offset: 0x0024761C
		public virtual ENpcGroupSequenceBindingType Type
		{
			get
			{
				return (ENpcGroupSequenceBindingType)this.Instance.Type;
			}
		}

		// Token: 0x04008A3E RID: 35390
		private INpcGroupSequenceBindingBase Instance;
	}
}
