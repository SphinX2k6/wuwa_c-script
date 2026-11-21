using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000773 RID: 1907
	public class ISkyboxDistanceTrigger : ISkyboxTrigger
	{
		// Token: 0x060028B4 RID: 10420 RVA: 0x0006C26C File Offset: 0x0006A46C
		private ISkyboxDistanceTrigger_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISkyboxDistanceTrigger 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISkyboxDistanceTrigger_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISkyboxDistanceTrigger_SetValue());
			}
			return result;
		}

		// Token: 0x060028B5 RID: 10421 RVA: 0x0006C2A4 File Offset: 0x0006A4A4
		public static ISkyboxDistanceTrigger Create([Nullable(2)] ISkyboxDistanceTrigger instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISkyboxDistanceTrigger
			{
				FbInstance = instance
			};
		}

		// Token: 0x060028B6 RID: 10422 RVA: 0x0006C2B7 File Offset: 0x0006A4B7
		public static ISkyboxDistanceTrigger CreateFromSetValue([Nullable(2)] ISkyboxDistanceTrigger_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISkyboxDistanceTrigger
			{
				PocoInterface = value
			};
		}

		// Token: 0x060028B7 RID: 10423 RVA: 0x0006C2CA File Offset: 0x0006A4CA
		public new ISkyboxDistanceTrigger_SetValue ToSetValue()
		{
			return new ISkyboxDistanceTrigger_SetValue
			{
				Type = this.Type,
				Distance = this.Distance
			};
		}

		// Token: 0x17000AAC RID: 2732
		// (get) Token: 0x060028B8 RID: 10424 RVA: 0x0006C2E9 File Offset: 0x0006A4E9
		// (set) Token: 0x060028B9 RID: 10425 RVA: 0x0006C314 File Offset: 0x0006A514
		public override ETriggerMode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETriggerMode.Distance;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000AAD RID: 2733
		// (get) Token: 0x060028BA RID: 10426 RVA: 0x0006C322 File Offset: 0x0006A522
		// (set) Token: 0x060028BB RID: 10427 RVA: 0x0006C351 File Offset: 0x0006A551
		public virtual float Distance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Distance;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Distance;
			}
			set
			{
				this.GetOrCreatePoco().Distance = value;
			}
		}

		// Token: 0x04001BA1 RID: 7073
		[Nullable(2)]
		protected new ISkyboxDistanceTrigger FbInstance;

		// Token: 0x04001BA2 RID: 7074
		[Nullable(2)]
		protected new ISkyboxDistanceTrigger_SetValue PocoInterface;
	}
}
