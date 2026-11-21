using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C1A RID: 7194
	public class IFlowDefineNpcCancelSupportedWalkingPerform : IFlowDefineNpcGroupPerformType
	{
		// Token: 0x060098D2 RID: 39122 RVA: 0x00162708 File Offset: 0x00160908
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

		// Token: 0x060098D3 RID: 39123 RVA: 0x00162740 File Offset: 0x00160940
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

		// Token: 0x060098D4 RID: 39124 RVA: 0x00162753 File Offset: 0x00160953
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

		// Token: 0x060098D5 RID: 39125 RVA: 0x00162766 File Offset: 0x00160966
		public new IFlowDefineNpcCancelSupportedWalkingPerform_SetValue ToSetValue()
		{
			return new IFlowDefineNpcCancelSupportedWalkingPerform_SetValue
			{
				Type = this.Type,
				Key = this.Key
			};
		}

		// Token: 0x1700304F RID: 12367
		// (get) Token: 0x060098D6 RID: 39126 RVA: 0x00162785 File Offset: 0x00160985
		// (set) Token: 0x060098D7 RID: 39127 RVA: 0x001627B0 File Offset: 0x001609B0
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

		// Token: 0x17003050 RID: 12368
		// (get) Token: 0x060098D8 RID: 39128 RVA: 0x001627BE File Offset: 0x001609BE
		// (set) Token: 0x060098D9 RID: 39129 RVA: 0x001627E9 File Offset: 0x001609E9
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

		// Token: 0x04005E12 RID: 24082
		[Nullable(2)]
		protected new IFlowDefineNpcCancelSupportedWalkingPerform FbInstance;

		// Token: 0x04005E13 RID: 24083
		[Nullable(2)]
		protected new IFlowDefineNpcCancelSupportedWalkingPerform_SetValue PocoInterface;
	}
}
