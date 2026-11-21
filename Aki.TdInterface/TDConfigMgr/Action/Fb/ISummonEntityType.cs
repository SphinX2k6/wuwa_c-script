using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D1C RID: 11548
	public class ISummonEntityType
	{
		// Token: 0x0600FC85 RID: 64645 RVA: 0x002484C1 File Offset: 0x002466C1
		public static ISummonEntityType Create(ISummonEntityType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISummonEntityType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004EFB RID: 20219
		// (get) Token: 0x0600FC86 RID: 64646 RVA: 0x002484E0 File Offset: 0x002466E0
		public virtual ESummonEntityType Type
		{
			get
			{
				return (ESummonEntityType)this.Instance.Type;
			}
		}

		// Token: 0x040089E6 RID: 35302
		private ISummonEntityType Instance;
	}
}
