using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C1E RID: 7198
	public class IFlowDefineNpcHandInHandPerform : IFlowDefineNpcGroupPerformType
	{
		// Token: 0x060098E4 RID: 39140 RVA: 0x001628C4 File Offset: 0x00160AC4
		private IFlowDefineNpcHandInHandPerform_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFlowDefineNpcHandInHandPerform 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFlowDefineNpcHandInHandPerform_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFlowDefineNpcHandInHandPerform_SetValue());
			}
			return result;
		}

		// Token: 0x060098E5 RID: 39141 RVA: 0x001628FC File Offset: 0x00160AFC
		public static IFlowDefineNpcHandInHandPerform Create([Nullable(2)] IFlowDefineNpcHandInHandPerform instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowDefineNpcHandInHandPerform
			{
				FbInstance = instance
			};
		}

		// Token: 0x060098E6 RID: 39142 RVA: 0x0016290F File Offset: 0x00160B0F
		public static IFlowDefineNpcHandInHandPerform CreateFromSetValue([Nullable(2)] IFlowDefineNpcHandInHandPerform_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFlowDefineNpcHandInHandPerform
			{
				PocoInterface = value
			};
		}

		// Token: 0x060098E7 RID: 39143 RVA: 0x00162922 File Offset: 0x00160B22
		public new IFlowDefineNpcHandInHandPerform_SetValue ToSetValue()
		{
			return new IFlowDefineNpcHandInHandPerform_SetValue
			{
				Type = this.Type,
				Key = this.Key
			};
		}

		// Token: 0x17003052 RID: 12370
		// (get) Token: 0x060098E8 RID: 39144 RVA: 0x00162941 File Offset: 0x00160B41
		// (set) Token: 0x060098E9 RID: 39145 RVA: 0x0016296C File Offset: 0x00160B6C
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

		// Token: 0x17003053 RID: 12371
		// (get) Token: 0x060098EA RID: 39146 RVA: 0x0016297A File Offset: 0x00160B7A
		// (set) Token: 0x060098EB RID: 39147 RVA: 0x001629A5 File Offset: 0x00160BA5
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

		// Token: 0x04005E19 RID: 24089
		[Nullable(2)]
		protected new IFlowDefineNpcHandInHandPerform FbInstance;

		// Token: 0x04005E1A RID: 24090
		[Nullable(2)]
		protected new IFlowDefineNpcHandInHandPerform_SetValue PocoInterface;
	}
}
