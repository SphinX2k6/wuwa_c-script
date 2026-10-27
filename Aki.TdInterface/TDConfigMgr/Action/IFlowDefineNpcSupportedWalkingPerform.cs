using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A8D RID: 6797
	[NullableContext(1)]
	[Nullable(0)]
	public class IFlowDefineNpcSupportedWalkingPerform : IFlowDefineNpcGroupPerformType
	{
		// Token: 0x0600918E RID: 37262 RVA: 0x00152B98 File Offset: 0x00150D98
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

		// Token: 0x0600918F RID: 37263 RVA: 0x00152BD0 File Offset: 0x00150DD0
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

		// Token: 0x06009190 RID: 37264 RVA: 0x00152BE3 File Offset: 0x00150DE3
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

		// Token: 0x06009191 RID: 37265 RVA: 0x00152BF6 File Offset: 0x00150DF6
		public new IFlowDefineNpcSupportedWalkingPerform_SetValue ToSetValue()
		{
			return new IFlowDefineNpcSupportedWalkingPerform_SetValue
			{
				Type = this.Type,
				Key = this.Key
			};
		}

		// Token: 0x17002E49 RID: 11849
		// (get) Token: 0x06009192 RID: 37266 RVA: 0x00152C15 File Offset: 0x00150E15
		// (set) Token: 0x06009193 RID: 37267 RVA: 0x00152C40 File Offset: 0x00150E40
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

		// Token: 0x17002E4A RID: 11850
		// (get) Token: 0x06009194 RID: 37268 RVA: 0x00152C4E File Offset: 0x00150E4E
		// (set) Token: 0x06009195 RID: 37269 RVA: 0x00152C79 File Offset: 0x00150E79
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

		// Token: 0x040059BC RID: 22972
		[Nullable(2)]
		protected new IFlowDefineNpcSupportedWalkingPerform FbInstance;

		// Token: 0x040059BD RID: 22973
		[Nullable(2)]
		protected new IFlowDefineNpcSupportedWalkingPerform_SetValue PocoInterface;
	}
}
