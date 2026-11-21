using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017BD RID: 6077
	public class EndFlowTemplate : ActionParams
	{
		// Token: 0x06008387 RID: 33671 RVA: 0x0013A9C8 File Offset: 0x00138BC8
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

		// Token: 0x06008388 RID: 33672 RVA: 0x0013AA00 File Offset: 0x00138C00
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

		// Token: 0x06008389 RID: 33673 RVA: 0x0013AA13 File Offset: 0x00138C13
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

		// Token: 0x0600838A RID: 33674 RVA: 0x0013AA26 File Offset: 0x00138C26
		public EndFlowTemplate_SetValue ToSetValue()
		{
			return new EndFlowTemplate_SetValue
			{
				IsResetPosition = this.IsResetPosition
			};
		}

		// Token: 0x17002B1A RID: 11034
		// (get) Token: 0x0600838B RID: 33675 RVA: 0x0013AA39 File Offset: 0x00138C39
		// (set) Token: 0x0600838C RID: 33676 RVA: 0x0013AA64 File Offset: 0x00138C64
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

		// Token: 0x04005079 RID: 20601
		[Nullable(2)]
		protected new EndFlowTemplate FbInstance;

		// Token: 0x0400507A RID: 20602
		[Nullable(2)]
		protected EndFlowTemplate_SetValue PocoInterface;
	}
}
