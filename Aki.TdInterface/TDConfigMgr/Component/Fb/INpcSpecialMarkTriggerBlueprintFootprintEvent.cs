using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CA1 RID: 3233
	public class INpcSpecialMarkTriggerBlueprintFootprintEvent : INpcSpecialMarkBase
	{
		// Token: 0x060049E0 RID: 18912 RVA: 0x000BA0E1 File Offset: 0x000B82E1
		public static INpcSpecialMarkTriggerBlueprintFootprintEvent Create(INpcSpecialMarkTriggerBlueprintFootprintEvent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcSpecialMarkTriggerBlueprintFootprintEvent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001499 RID: 5273
		// (get) Token: 0x060049E1 RID: 18913 RVA: 0x000BA100 File Offset: 0x000B8300
		public override ESpecialNpcMarkType Type
		{
			get
			{
				return (ESpecialNpcMarkType)this.Instance.Type;
			}
		}

		// Token: 0x1700149A RID: 5274
		// (get) Token: 0x060049E2 RID: 18914 RVA: 0x000BA10D File Offset: 0x000B830D
		public virtual string ConfigDa
		{
			get
			{
				return this.Instance.ConfigDa;
			}
		}

		// Token: 0x040029D4 RID: 10708
		private INpcSpecialMarkTriggerBlueprintFootprintEvent Instance;
	}
}
