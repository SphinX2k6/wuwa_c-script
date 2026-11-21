using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C20 RID: 7200
	public class IFlowDefineNpcMotorcycleSharingPerform : IFlowDefineNpcGroupPerformType
	{
		// Token: 0x060098EE RID: 39150 RVA: 0x001629C4 File Offset: 0x00160BC4
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

		// Token: 0x060098EF RID: 39151 RVA: 0x001629FC File Offset: 0x00160BFC
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

		// Token: 0x060098F0 RID: 39152 RVA: 0x00162A0F File Offset: 0x00160C0F
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

		// Token: 0x060098F1 RID: 39153 RVA: 0x00162A22 File Offset: 0x00160C22
		public new IFlowDefineNpcMotorcycleSharingPerform_SetValue ToSetValue()
		{
			return new IFlowDefineNpcMotorcycleSharingPerform_SetValue
			{
				Type = this.Type,
				Key = this.Key
			};
		}

		// Token: 0x17003054 RID: 12372
		// (get) Token: 0x060098F2 RID: 39154 RVA: 0x00162A41 File Offset: 0x00160C41
		// (set) Token: 0x060098F3 RID: 39155 RVA: 0x00162A6C File Offset: 0x00160C6C
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

		// Token: 0x17003055 RID: 12373
		// (get) Token: 0x060098F4 RID: 39156 RVA: 0x00162A7A File Offset: 0x00160C7A
		// (set) Token: 0x060098F5 RID: 39157 RVA: 0x00162AA5 File Offset: 0x00160CA5
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

		// Token: 0x04005E1D RID: 24093
		[Nullable(2)]
		protected new IFlowDefineNpcMotorcycleSharingPerform FbInstance;

		// Token: 0x04005E1E RID: 24094
		[Nullable(2)]
		protected new IFlowDefineNpcMotorcycleSharingPerform_SetValue PocoInterface;
	}
}
