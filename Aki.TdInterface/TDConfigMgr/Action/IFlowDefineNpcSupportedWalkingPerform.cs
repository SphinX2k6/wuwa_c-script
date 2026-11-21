using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C22 RID: 7202
	public class IFlowDefineNpcSupportedWalkingPerform : IFlowDefineNpcGroupPerformType
	{
		// Token: 0x060098F8 RID: 39160 RVA: 0x00162AC4 File Offset: 0x00160CC4
		private IFlowDefineNpcSupportedWalkingPerform_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFlowDefineNpcSupportedWalkingPerform 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFlowDefineNpcSupportedWalkingPerform_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFlowDefineNpcSupportedWalkingPerform_SetValue());
			}
			return result;
		}

		// Token: 0x060098F9 RID: 39161 RVA: 0x00162AFC File Offset: 0x00160CFC
		public static IFlowDefineNpcSupportedWalkingPerform Create([Nullable(2)] IFlowDefineNpcSupportedWalkingPerform instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowDefineNpcSupportedWalkingPerform
			{
				FbInstance = instance
			};
		}

		// Token: 0x060098FA RID: 39162 RVA: 0x00162B0F File Offset: 0x00160D0F
		public static IFlowDefineNpcSupportedWalkingPerform CreateFromSetValue([Nullable(2)] IFlowDefineNpcSupportedWalkingPerform_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFlowDefineNpcSupportedWalkingPerform
			{
				PocoInterface = value
			};
		}

		// Token: 0x060098FB RID: 39163 RVA: 0x00162B22 File Offset: 0x00160D22
		public new IFlowDefineNpcSupportedWalkingPerform_SetValue ToSetValue()
		{
			return new IFlowDefineNpcSupportedWalkingPerform_SetValue
			{
				Type = this.Type,
				Key = this.Key
			};
		}

		// Token: 0x17003056 RID: 12374
		// (get) Token: 0x060098FC RID: 39164 RVA: 0x00162B41 File Offset: 0x00160D41
		// (set) Token: 0x060098FD RID: 39165 RVA: 0x00162B6C File Offset: 0x00160D6C
		public override ENpcGroupPerformType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENpcGroupPerformType.HandInHand;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003057 RID: 12375
		// (get) Token: 0x060098FE RID: 39166 RVA: 0x00162B7A File Offset: 0x00160D7A
		// (set) Token: 0x060098FF RID: 39167 RVA: 0x00162BA5 File Offset: 0x00160DA5
		public virtual string Key
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Key;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Key;
			}
			set
			{
				this.GetOrCreatePoco().Key = value;
			}
		}

		// Token: 0x04005E21 RID: 24097
		[Nullable(2)]
		protected new IFlowDefineNpcSupportedWalkingPerform FbInstance;

		// Token: 0x04005E22 RID: 24098
		[Nullable(2)]
		protected new IFlowDefineNpcSupportedWalkingPerform_SetValue PocoInterface;
	}
}
