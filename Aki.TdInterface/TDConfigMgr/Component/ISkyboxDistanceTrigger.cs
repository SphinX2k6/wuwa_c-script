using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006D2 RID: 1746
	[NullableContext(1)]
	[Nullable(0)]
	public class ISkyboxDistanceTrigger : ISkyboxTrigger
	{
		// Token: 0x06002594 RID: 9620 RVA: 0x000651FC File Offset: 0x000633FC
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

		// Token: 0x06002595 RID: 9621 RVA: 0x00065234 File Offset: 0x00063434
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

		// Token: 0x06002596 RID: 9622 RVA: 0x00065247 File Offset: 0x00063447
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

		// Token: 0x06002597 RID: 9623 RVA: 0x0006525A File Offset: 0x0006345A
		public new ISkyboxDistanceTrigger_SetValue ToSetValue()
		{
			return new ISkyboxDistanceTrigger_SetValue
			{
				Type = this.Type,
				Distance = this.Distance
			};
		}

		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x06002598 RID: 9624 RVA: 0x00065279 File Offset: 0x00063479
		// (set) Token: 0x06002599 RID: 9625 RVA: 0x000652A4 File Offset: 0x000634A4
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

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x0600259A RID: 9626 RVA: 0x000652B2 File Offset: 0x000634B2
		// (set) Token: 0x0600259B RID: 9627 RVA: 0x000652E1 File Offset: 0x000634E1
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

		// Token: 0x040019A2 RID: 6562
		[Nullable(2)]
		protected new ISkyboxDistanceTrigger FbInstance;

		// Token: 0x040019A3 RID: 6563
		[Nullable(2)]
		protected new ISkyboxDistanceTrigger_SetValue PocoInterface;
	}
}
