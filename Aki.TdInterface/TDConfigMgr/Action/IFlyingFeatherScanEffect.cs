using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AA5 RID: 6821
	[NullableContext(1)]
	[Nullable(0)]
	public class IFlyingFeatherScanEffect : ISpecificScanEffect
	{
		// Token: 0x0600924E RID: 37454 RVA: 0x001542F0 File Offset: 0x001524F0
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

		// Token: 0x0600924F RID: 37455 RVA: 0x00154328 File Offset: 0x00152528
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

		// Token: 0x06009250 RID: 37456 RVA: 0x0015433B File Offset: 0x0015253B
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

		// Token: 0x06009251 RID: 37457 RVA: 0x0015434E File Offset: 0x0015254E
		public new IFlyingFeatherScanEffect_SetValue ToSetValue()
		{
			return new IFlyingFeatherScanEffect_SetValue
			{
				Type = this.Type,
				TriggerPosEntityId = this.TriggerPosEntityId
			};
		}

		// Token: 0x17002E85 RID: 11909
		// (get) Token: 0x06009252 RID: 37458 RVA: 0x0015436D File Offset: 0x0015256D
		// (set) Token: 0x06009253 RID: 37459 RVA: 0x00154398 File Offset: 0x00152598
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

		// Token: 0x17002E86 RID: 11910
		// (get) Token: 0x06009254 RID: 37460 RVA: 0x001543A6 File Offset: 0x001525A6
		// (set) Token: 0x06009255 RID: 37461 RVA: 0x001543D1 File Offset: 0x001525D1
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

		// Token: 0x04005A18 RID: 23064
		[Nullable(2)]
		protected new IFlyingFeatherScanEffect FbInstance;

		// Token: 0x04005A19 RID: 23065
		[Nullable(2)]
		protected new IFlyingFeatherScanEffect_SetValue PocoInterface;
	}
}
