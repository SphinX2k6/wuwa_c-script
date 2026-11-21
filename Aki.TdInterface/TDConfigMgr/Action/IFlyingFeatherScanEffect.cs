using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C3E RID: 7230
	public class IFlyingFeatherScanEffect : ISpecificScanEffect
	{
		// Token: 0x060099CE RID: 39374 RVA: 0x001644DC File Offset: 0x001626DC
		private IFlyingFeatherScanEffect_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFlyingFeatherScanEffect 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFlyingFeatherScanEffect_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFlyingFeatherScanEffect_SetValue());
			}
			return result;
		}

		// Token: 0x060099CF RID: 39375 RVA: 0x00164514 File Offset: 0x00162714
		public static IFlyingFeatherScanEffect Create([Nullable(2)] IFlyingFeatherScanEffect instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlyingFeatherScanEffect
			{
				FbInstance = instance
			};
		}

		// Token: 0x060099D0 RID: 39376 RVA: 0x00164527 File Offset: 0x00162727
		public static IFlyingFeatherScanEffect CreateFromSetValue([Nullable(2)] IFlyingFeatherScanEffect_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFlyingFeatherScanEffect
			{
				PocoInterface = value
			};
		}

		// Token: 0x060099D1 RID: 39377 RVA: 0x0016453A File Offset: 0x0016273A
		public new IFlyingFeatherScanEffect_SetValue ToSetValue()
		{
			return new IFlyingFeatherScanEffect_SetValue
			{
				Type = this.Type,
				TriggerPosEntityId = this.TriggerPosEntityId
			};
		}

		// Token: 0x17003097 RID: 12439
		// (get) Token: 0x060099D2 RID: 39378 RVA: 0x00164559 File Offset: 0x00162759
		// (set) Token: 0x060099D3 RID: 39379 RVA: 0x00164584 File Offset: 0x00162784
		public override ESpecificScanType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return (ESpecificScanType)0;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003098 RID: 12440
		// (get) Token: 0x060099D4 RID: 39380 RVA: 0x00164592 File Offset: 0x00162792
		// (set) Token: 0x060099D5 RID: 39381 RVA: 0x001645BD File Offset: 0x001627BD
		public virtual int TriggerPosEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TriggerPosEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TriggerPosEntityId;
			}
			set
			{
				this.GetOrCreatePoco().TriggerPosEntityId = value;
			}
		}

		// Token: 0x04005E88 RID: 24200
		[Nullable(2)]
		protected new IFlyingFeatherScanEffect FbInstance;

		// Token: 0x04005E89 RID: 24201
		[Nullable(2)]
		protected new IFlyingFeatherScanEffect_SetValue PocoInterface;
	}
}
