using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A85 RID: 6789
	[NullableContext(1)]
	[Nullable(0)]
	public class IFlowDefineNpcCancelSupportedWalkingPerform : IFlowDefineNpcGroupPerformType
	{
		// Token: 0x06009168 RID: 37224 RVA: 0x001527DC File Offset: 0x001509DC
		private IFlowDefineNpcCancelSupportedWalkingPerform_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFlowDefineNpcCancelSupportedWalkingPerform 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFlowDefineNpcCancelSupportedWalkingPerform_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFlowDefineNpcCancelSupportedWalkingPerform_SetValue());
			}
			return result;
		}

		// Token: 0x06009169 RID: 37225 RVA: 0x00152814 File Offset: 0x00150A14
		public static IFlowDefineNpcCancelSupportedWalkingPerform Create([Nullable(2)] IFlowDefineNpcCancelSupportedWalkingPerform instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowDefineNpcCancelSupportedWalkingPerform
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600916A RID: 37226 RVA: 0x00152827 File Offset: 0x00150A27
		public static IFlowDefineNpcCancelSupportedWalkingPerform CreateFromSetValue([Nullable(2)] IFlowDefineNpcCancelSupportedWalkingPerform_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFlowDefineNpcCancelSupportedWalkingPerform
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600916B RID: 37227 RVA: 0x0015283A File Offset: 0x00150A3A
		public new IFlowDefineNpcCancelSupportedWalkingPerform_SetValue ToSetValue()
		{
			return new IFlowDefineNpcCancelSupportedWalkingPerform_SetValue
			{
				Type = this.Type,
				Key = this.Key
			};
		}

		// Token: 0x17002E42 RID: 11842
		// (get) Token: 0x0600916C RID: 37228 RVA: 0x00152859 File Offset: 0x00150A59
		// (set) Token: 0x0600916D RID: 37229 RVA: 0x00152884 File Offset: 0x00150A84
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

		// Token: 0x17002E43 RID: 11843
		// (get) Token: 0x0600916E RID: 37230 RVA: 0x00152892 File Offset: 0x00150A92
		// (set) Token: 0x0600916F RID: 37231 RVA: 0x001528BD File Offset: 0x00150ABD
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

		// Token: 0x040059AD RID: 22957
		[Nullable(2)]
		protected new IFlowDefineNpcCancelSupportedWalkingPerform FbInstance;

		// Token: 0x040059AE RID: 22958
		[Nullable(2)]
		protected new IFlowDefineNpcCancelSupportedWalkingPerform_SetValue PocoInterface;
	}
}
