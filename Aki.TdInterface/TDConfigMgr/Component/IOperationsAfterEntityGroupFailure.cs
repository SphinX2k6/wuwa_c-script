using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200061F RID: 1567
	public class IOperationsAfterEntityGroupFailure
	{
		// Token: 0x060020E2 RID: 8418 RVA: 0x0005BF14 File Offset: 0x0005A114
		private IOperationsAfterEntityGroupFailure_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IOperationsAfterEntityGroupFailure 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IOperationsAfterEntityGroupFailure_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IOperationsAfterEntityGroupFailure_SetValue());
			}
			return result;
		}

		// Token: 0x060020E3 RID: 8419 RVA: 0x0005BF4C File Offset: 0x0005A14C
		public static IOperationsAfterEntityGroupFailure Create([Nullable(2)] IOperationsAfterEntityGroupFailure instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOperationsAfterEntityGroupFailure
			{
				FbInstance = instance
			};
		}

		// Token: 0x060020E4 RID: 8420 RVA: 0x0005BF5F File Offset: 0x0005A15F
		public static IOperationsAfterEntityGroupFailure CreateFromSetValue([Nullable(2)] IOperationsAfterEntityGroupFailure_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IOperationsAfterEntityGroupFailure
			{
				PocoInterface = value
			};
		}

		// Token: 0x060020E5 RID: 8421 RVA: 0x0005BF72 File Offset: 0x0005A172
		public IOperationsAfterEntityGroupFailure_SetValue ToSetValue()
		{
			return new IOperationsAfterEntityGroupFailure_SetValue
			{
				IsResetState = this.IsResetState,
				Actions = this.Actions
			};
		}

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x060020E6 RID: 8422 RVA: 0x0005BF94 File Offset: 0x0005A194
		// (set) Token: 0x060020E7 RID: 8423 RVA: 0x0005BFCE File Offset: 0x0005A1CE
		public virtual bool? IsResetState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsResetState;
				}
				IOperationsAfterEntityGroupFailure_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsResetState;
			}
			set
			{
				this.GetOrCreatePoco().IsResetState = value;
			}
		}

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x060020E8 RID: 8424 RVA: 0x0005BFDC File Offset: 0x0005A1DC
		// (set) Token: 0x060020E9 RID: 8425 RVA: 0x0005C06F File Offset: 0x0005A26F
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> Actions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._ActionsInited)
				{
					return this._ActionsCache;
				}
				this._ActionsInited = true;
				if (this.FbInstance != null)
				{
					List<Aki.TDConfigMgr.Action.Fb.ActionInfo> actions = this.FbInstance.Actions;
					if (actions != null)
					{
						this._ActionsCache = new List<Aki.TDConfigMgr.Action.ActionInfo>(actions.Count);
						for (int i = 0; i < actions.Count; i++)
						{
							this._ActionsCache.Add(Aki.TDConfigMgr.Action.ActionInfo.Create(actions[i]));
						}
					}
				}
				else
				{
					IOperationsAfterEntityGroupFailure_SetValue pocoInterface = this.PocoInterface;
					this._ActionsCache = ((pocoInterface != null) ? pocoInterface.Actions : null);
				}
				return this._ActionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().Actions = value;
				this._ActionsInited = false;
			}
		}

		// Token: 0x04001756 RID: 5974
		[Nullable(2)]
		protected IOperationsAfterEntityGroupFailure FbInstance;

		// Token: 0x04001757 RID: 5975
		[Nullable(2)]
		protected IOperationsAfterEntityGroupFailure_SetValue PocoInterface;

		// Token: 0x04001758 RID: 5976
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ActionsCache;

		// Token: 0x04001759 RID: 5977
		private bool _ActionsInited;
	}
}
