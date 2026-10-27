using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A83 RID: 6787
	[NullableContext(1)]
	[Nullable(0)]
	public class IFlowDefineNpcCancelMotorcycleSharingPerform : IFlowDefineNpcGroupPerformType
	{
		// Token: 0x0600915E RID: 37214 RVA: 0x001526DC File Offset: 0x001508DC
		private IFlowDefineNpcCancelMotorcycleSharingPerform_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFlowDefineNpcCancelMotorcycleSharingPerform 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFlowDefineNpcCancelMotorcycleSharingPerform_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFlowDefineNpcCancelMotorcycleSharingPerform_SetValue());
			}
			return result;
		}

		// Token: 0x0600915F RID: 37215 RVA: 0x00152714 File Offset: 0x00150914
		public static IFlowDefineNpcCancelMotorcycleSharingPerform Create([Nullable(2)] IFlowDefineNpcCancelMotorcycleSharingPerform instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowDefineNpcCancelMotorcycleSharingPerform
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009160 RID: 37216 RVA: 0x00152727 File Offset: 0x00150927
		public static IFlowDefineNpcCancelMotorcycleSharingPerform CreateFromSetValue([Nullable(2)] IFlowDefineNpcCancelMotorcycleSharingPerform_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFlowDefineNpcCancelMotorcycleSharingPerform
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009161 RID: 37217 RVA: 0x0015273A File Offset: 0x0015093A
		public new IFlowDefineNpcCancelMotorcycleSharingPerform_SetValue ToSetValue()
		{
			return new IFlowDefineNpcCancelMotorcycleSharingPerform_SetValue
			{
				Type = this.Type,
				Key = this.Key
			};
		}

		// Token: 0x17002E40 RID: 11840
		// (get) Token: 0x06009162 RID: 37218 RVA: 0x00152759 File Offset: 0x00150959
		// (set) Token: 0x06009163 RID: 37219 RVA: 0x00152784 File Offset: 0x00150984
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

		// Token: 0x17002E41 RID: 11841
		// (get) Token: 0x06009164 RID: 37220 RVA: 0x00152792 File Offset: 0x00150992
		// (set) Token: 0x06009165 RID: 37221 RVA: 0x001527BD File Offset: 0x001509BD
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

		// Token: 0x040059A9 RID: 22953
		[Nullable(2)]
		protected new IFlowDefineNpcCancelMotorcycleSharingPerform FbInstance;

		// Token: 0x040059AA RID: 22954
		[Nullable(2)]
		protected new IFlowDefineNpcCancelMotorcycleSharingPerform_SetValue PocoInterface;
	}
}
