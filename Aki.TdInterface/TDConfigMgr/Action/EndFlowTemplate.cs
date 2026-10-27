using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001650 RID: 5712
	[NullableContext(1)]
	[Nullable(0)]
	public class EndFlowTemplate : ActionParams
	{
		// Token: 0x06007CA9 RID: 31913 RVA: 0x0012B91C File Offset: 0x00129B1C
		private EndFlowTemplate_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("EndFlowTemplate 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			EndFlowTemplate_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new EndFlowTemplate_SetValue());
			}
			return result;
		}

		// Token: 0x06007CAA RID: 31914 RVA: 0x0012B954 File Offset: 0x00129B54
		public static EndFlowTemplate Create([Nullable(2)] EndFlowTemplate instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EndFlowTemplate
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007CAB RID: 31915 RVA: 0x0012B967 File Offset: 0x00129B67
		public static EndFlowTemplate CreateFromSetValue([Nullable(2)] EndFlowTemplate_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new EndFlowTemplate
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007CAC RID: 31916 RVA: 0x0012B97A File Offset: 0x00129B7A
		public EndFlowTemplate_SetValue ToSetValue()
		{
			return new EndFlowTemplate_SetValue
			{
				IsResetPosition = this.IsResetPosition
			};
		}

		// Token: 0x1700292F RID: 10543
		// (get) Token: 0x06007CAD RID: 31917 RVA: 0x0012B98D File Offset: 0x00129B8D
		// (set) Token: 0x06007CAE RID: 31918 RVA: 0x0012B9B8 File Offset: 0x00129BB8
		public virtual bool IsResetPosition
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsResetPosition;
				}
				return this.PocoInterface != null && this.PocoInterface.IsResetPosition;
			}
			set
			{
				this.GetOrCreatePoco().IsResetPosition = value;
			}
		}

		// Token: 0x04004C85 RID: 19589
		[Nullable(2)]
		protected new EndFlowTemplate FbInstance;

		// Token: 0x04004C86 RID: 19590
		[Nullable(2)]
		protected EndFlowTemplate_SetValue PocoInterface;
	}
}
