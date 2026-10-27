using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A8B RID: 6795
	[NullableContext(1)]
	[Nullable(0)]
	public class IFlowDefineNpcMotorcycleSharingPerform : IFlowDefineNpcGroupPerformType
	{
		// Token: 0x06009184 RID: 37252 RVA: 0x00152A98 File Offset: 0x00150C98
		private IFlowDefineNpcMotorcycleSharingPerform_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFlowDefineNpcMotorcycleSharingPerform 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFlowDefineNpcMotorcycleSharingPerform_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFlowDefineNpcMotorcycleSharingPerform_SetValue());
			}
			return result;
		}

		// Token: 0x06009185 RID: 37253 RVA: 0x00152AD0 File Offset: 0x00150CD0
		public static IFlowDefineNpcMotorcycleSharingPerform Create([Nullable(2)] IFlowDefineNpcMotorcycleSharingPerform instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowDefineNpcMotorcycleSharingPerform
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009186 RID: 37254 RVA: 0x00152AE3 File Offset: 0x00150CE3
		public static IFlowDefineNpcMotorcycleSharingPerform CreateFromSetValue([Nullable(2)] IFlowDefineNpcMotorcycleSharingPerform_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFlowDefineNpcMotorcycleSharingPerform
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009187 RID: 37255 RVA: 0x00152AF6 File Offset: 0x00150CF6
		public new IFlowDefineNpcMotorcycleSharingPerform_SetValue ToSetValue()
		{
			return new IFlowDefineNpcMotorcycleSharingPerform_SetValue
			{
				Type = this.Type,
				Key = this.Key
			};
		}

		// Token: 0x17002E47 RID: 11847
		// (get) Token: 0x06009188 RID: 37256 RVA: 0x00152B15 File Offset: 0x00150D15
		// (set) Token: 0x06009189 RID: 37257 RVA: 0x00152B40 File Offset: 0x00150D40
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

		// Token: 0x17002E48 RID: 11848
		// (get) Token: 0x0600918A RID: 37258 RVA: 0x00152B4E File Offset: 0x00150D4E
		// (set) Token: 0x0600918B RID: 37259 RVA: 0x00152B79 File Offset: 0x00150D79
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

		// Token: 0x040059B8 RID: 22968
		[Nullable(2)]
		protected new IFlowDefineNpcMotorcycleSharingPerform FbInstance;

		// Token: 0x040059B9 RID: 22969
		[Nullable(2)]
		protected new IFlowDefineNpcMotorcycleSharingPerform_SetValue PocoInterface;
	}
}
