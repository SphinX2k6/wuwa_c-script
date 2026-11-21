using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001185 RID: 4485
	public class IPlotHandBookNode
	{
		// Token: 0x060063A8 RID: 25512 RVA: 0x000EFC44 File Offset: 0x000EDE44
		private IPlotHandBookNode_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPlotHandBookNode 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPlotHandBookNode_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPlotHandBookNode_SetValue());
			}
			return result;
		}

		// Token: 0x060063A9 RID: 25513 RVA: 0x000EFC7C File Offset: 0x000EDE7C
		public static IPlotHandBookNode Create([Nullable(2)] IPlotHandBookNode instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlotHandBookNode
			{
				FbInstance = instance
			};
		}

		// Token: 0x060063AA RID: 25514 RVA: 0x000EFC8F File Offset: 0x000EDE8F
		public static IPlotHandBookNode CreateFromSetValue([Nullable(2)] IPlotHandBookNode_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPlotHandBookNode
			{
				PocoInterface = value
			};
		}

		// Token: 0x060063AB RID: 25515 RVA: 0x000EFCA2 File Offset: 0x000EDEA2
		public IPlotHandBookNode_SetValue ToSetValue()
		{
			return new IPlotHandBookNode_SetValue
			{
				TidTip = this.TidTip,
				Flow = this.Flow,
				IsHideUi = this.IsHideUi
			};
		}

		// Token: 0x17002089 RID: 8329
		// (get) Token: 0x060063AC RID: 25516 RVA: 0x000EFCCD File Offset: 0x000EDECD
		// (set) Token: 0x060063AD RID: 25517 RVA: 0x000EFCF8 File Offset: 0x000EDEF8
		public virtual string TidTip
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidTip;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TidTip;
			}
			set
			{
				this.GetOrCreatePoco().TidTip = value;
			}
		}

		// Token: 0x1700208A RID: 8330
		// (get) Token: 0x060063AE RID: 25518 RVA: 0x000EFD08 File Offset: 0x000EDF08
		// (set) Token: 0x060063AF RID: 25519 RVA: 0x000EFD69 File Offset: 0x000EDF69
		public virtual IFlowStateIndex Flow
		{
			get
			{
				if (this._FlowInited)
				{
					return this._FlowCache;
				}
				this._FlowInited = true;
				if (this.FbInstance != null)
				{
					this._FlowCache = IFlowStateIndex.Create(this.FbInstance.Flow);
				}
				else
				{
					IPlotHandBookNode_SetValue pocoInterface = this.PocoInterface;
					this._FlowCache = ((pocoInterface != null) ? pocoInterface.Flow : null);
				}
				return this._FlowCache;
			}
			set
			{
				this.GetOrCreatePoco().Flow = value;
				this._FlowInited = false;
			}
		}

		// Token: 0x1700208B RID: 8331
		// (get) Token: 0x060063B0 RID: 25520 RVA: 0x000EFD7E File Offset: 0x000EDF7E
		// (set) Token: 0x060063B1 RID: 25521 RVA: 0x000EFDA9 File Offset: 0x000EDFA9
		public virtual bool IsHideUi
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsHideUi;
				}
				return this.PocoInterface != null && this.PocoInterface.IsHideUi;
			}
			set
			{
				this.GetOrCreatePoco().IsHideUi = value;
			}
		}

		// Token: 0x04003BB3 RID: 15283
		[Nullable(2)]
		protected IPlotHandBookNode FbInstance;

		// Token: 0x04003BB4 RID: 15284
		[Nullable(2)]
		protected IPlotHandBookNode_SetValue PocoInterface;

		// Token: 0x04003BB5 RID: 15285
		private IFlowStateIndex _FlowCache;

		// Token: 0x04003BB6 RID: 15286
		private bool _FlowInited;
	}
}
