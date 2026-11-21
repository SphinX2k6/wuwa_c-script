using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D1D RID: 11549
	public class ISummonVehicle : ISummonEntityType
	{
		// Token: 0x0600FC88 RID: 64648 RVA: 0x002484F5 File Offset: 0x002466F5
		public static ISummonVehicle Create(ISummonVehicle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISummonVehicle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004EFC RID: 20220
		// (get) Token: 0x0600FC89 RID: 64649 RVA: 0x00248514 File Offset: 0x00246714
		public override ESummonEntityType Type
		{
			get
			{
				return (ESummonEntityType)this.Instance.Type;
			}
		}

		// Token: 0x17004EFD RID: 20221
		// (get) Token: 0x0600FC8A RID: 64650 RVA: 0x00248521 File Offset: 0x00246721
		public virtual string TemplateId
		{
			get
			{
				return this.Instance.TemplateId;
			}
		}

		// Token: 0x17004EFE RID: 20222
		// (get) Token: 0x0600FC8B RID: 64651 RVA: 0x0024852E File Offset: 0x0024672E
		public virtual int PositionEntityId
		{
			get
			{
				return this.Instance.PositionEntityId;
			}
		}

		// Token: 0x040089E7 RID: 35303
		private ISummonVehicle Instance;
	}
}
