using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001057 RID: 4183
	[NullableContext(1)]
	[Nullable(0)]
	public class IPlotHandBookNode
	{
		// Token: 0x06005DB6 RID: 23990 RVA: 0x000E2C70 File Offset: 0x000E0E70
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

		// Token: 0x06005DB7 RID: 23991 RVA: 0x000E2CA8 File Offset: 0x000E0EA8
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

		// Token: 0x06005DB8 RID: 23992 RVA: 0x000E2CBB File Offset: 0x000E0EBB
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

		// Token: 0x06005DB9 RID: 23993 RVA: 0x000E2CCE File Offset: 0x000E0ECE
		public IPlotHandBookNode_SetValue ToSetValue()
		{
			return new IPlotHandBookNode_SetValue
			{
				TidTip = this.TidTip,
				Flow = this.Flow,
				IsHideUi = this.IsHideUi
			};
		}

		// Token: 0x17001EDA RID: 7898
		// (get) Token: 0x06005DBA RID: 23994 RVA: 0x000E2CF9 File Offset: 0x000E0EF9
		// (set) Token: 0x06005DBB RID: 23995 RVA: 0x000E2D24 File Offset: 0x000E0F24
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

		// Token: 0x17001EDB RID: 7899
		// (get) Token: 0x06005DBC RID: 23996 RVA: 0x000E2D34 File Offset: 0x000E0F34
		// (set) Token: 0x06005DBD RID: 23997 RVA: 0x000E2D95 File Offset: 0x000E0F95
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

		// Token: 0x17001EDC RID: 7900
		// (get) Token: 0x06005DBE RID: 23998 RVA: 0x000E2DAA File Offset: 0x000E0FAA
		// (set) Token: 0x06005DBF RID: 23999 RVA: 0x000E2DD5 File Offset: 0x000E0FD5
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

		// Token: 0x0400386B RID: 14443
		[Nullable(2)]
		protected IPlotHandBookNode FbInstance;

		// Token: 0x0400386C RID: 14444
		[Nullable(2)]
		protected IPlotHandBookNode_SetValue PocoInterface;

		// Token: 0x0400386D RID: 14445
		private IFlowStateIndex _FlowCache;

		// Token: 0x0400386E RID: 14446
		private bool _FlowInited;
	}
}
