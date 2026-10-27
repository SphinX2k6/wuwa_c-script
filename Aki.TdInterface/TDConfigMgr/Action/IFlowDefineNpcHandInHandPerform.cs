using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A89 RID: 6793
	[NullableContext(1)]
	[Nullable(0)]
	public class IFlowDefineNpcHandInHandPerform : IFlowDefineNpcGroupPerformType
	{
		// Token: 0x0600917A RID: 37242 RVA: 0x00152998 File Offset: 0x00150B98
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

		// Token: 0x0600917B RID: 37243 RVA: 0x001529D0 File Offset: 0x00150BD0
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

		// Token: 0x0600917C RID: 37244 RVA: 0x001529E3 File Offset: 0x00150BE3
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

		// Token: 0x0600917D RID: 37245 RVA: 0x001529F6 File Offset: 0x00150BF6
		public new IFlowDefineNpcHandInHandPerform_SetValue ToSetValue()
		{
			return new IFlowDefineNpcHandInHandPerform_SetValue
			{
				Type = this.Type,
				Key = this.Key
			};
		}

		// Token: 0x17002E45 RID: 11845
		// (get) Token: 0x0600917E RID: 37246 RVA: 0x00152A15 File Offset: 0x00150C15
		// (set) Token: 0x0600917F RID: 37247 RVA: 0x00152A40 File Offset: 0x00150C40
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

		// Token: 0x17002E46 RID: 11846
		// (get) Token: 0x06009180 RID: 37248 RVA: 0x00152A4E File Offset: 0x00150C4E
		// (set) Token: 0x06009181 RID: 37249 RVA: 0x00152A79 File Offset: 0x00150C79
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

		// Token: 0x040059B4 RID: 22964
		[Nullable(2)]
		protected new IFlowDefineNpcHandInHandPerform FbInstance;

		// Token: 0x040059B5 RID: 22965
		[Nullable(2)]
		protected new IFlowDefineNpcHandInHandPerform_SetValue PocoInterface;
	}
}
