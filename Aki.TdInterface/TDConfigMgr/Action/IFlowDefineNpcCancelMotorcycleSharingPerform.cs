using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C18 RID: 7192
	public class IFlowDefineNpcCancelMotorcycleSharingPerform : IFlowDefineNpcGroupPerformType
	{
		// Token: 0x060098C8 RID: 39112 RVA: 0x00162608 File Offset: 0x00160808
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

		// Token: 0x060098C9 RID: 39113 RVA: 0x00162640 File Offset: 0x00160840
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

		// Token: 0x060098CA RID: 39114 RVA: 0x00162653 File Offset: 0x00160853
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

		// Token: 0x060098CB RID: 39115 RVA: 0x00162666 File Offset: 0x00160866
		public new IFlowDefineNpcCancelMotorcycleSharingPerform_SetValue ToSetValue()
		{
			return new IFlowDefineNpcCancelMotorcycleSharingPerform_SetValue
			{
				Type = this.Type,
				Key = this.Key
			};
		}

		// Token: 0x1700304D RID: 12365
		// (get) Token: 0x060098CC RID: 39116 RVA: 0x00162685 File Offset: 0x00160885
		// (set) Token: 0x060098CD RID: 39117 RVA: 0x001626B0 File Offset: 0x001608B0
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

		// Token: 0x1700304E RID: 12366
		// (get) Token: 0x060098CE RID: 39118 RVA: 0x001626BE File Offset: 0x001608BE
		// (set) Token: 0x060098CF RID: 39119 RVA: 0x001626E9 File Offset: 0x001608E9
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

		// Token: 0x04005E0E RID: 24078
		[Nullable(2)]
		protected new IFlowDefineNpcCancelMotorcycleSharingPerform FbInstance;

		// Token: 0x04005E0F RID: 24079
		[Nullable(2)]
		protected new IFlowDefineNpcCancelMotorcycleSharingPerform_SetValue PocoInterface;
	}
}
