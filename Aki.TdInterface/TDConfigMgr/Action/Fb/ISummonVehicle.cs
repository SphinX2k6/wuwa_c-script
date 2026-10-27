using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A30 RID: 10800
	[NullableContext(1)]
	[Nullable(0)]
	public class ISummonVehicle : ISummonEntityType
	{
		// Token: 0x0600EDF0 RID: 60912 RVA: 0x0022AB41 File Offset: 0x00228D41
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

		// Token: 0x17004B52 RID: 19282
		// (get) Token: 0x0600EDF1 RID: 60913 RVA: 0x0022AB60 File Offset: 0x00228D60
		public override ESummonEntityType Type
		{
			get
			{
				return (ESummonEntityType)this.Instance.Type;
			}
		}

		// Token: 0x17004B53 RID: 19283
		// (get) Token: 0x0600EDF2 RID: 60914 RVA: 0x0022AB6D File Offset: 0x00228D6D
		public virtual string TemplateId
		{
			get
			{
				return this.Instance.TemplateId;
			}
		}

		// Token: 0x17004B54 RID: 19284
		// (get) Token: 0x0600EDF3 RID: 60915 RVA: 0x0022AB7A File Offset: 0x00228D7A
		public virtual int PositionEntityId
		{
			get
			{
				return this.Instance.PositionEntityId;
			}
		}

		// Token: 0x040082F4 RID: 33524
		private ISummonVehicle Instance;
	}
}
