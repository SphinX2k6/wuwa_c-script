using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000954 RID: 2388
	public class SwitcherComponent : InteractiveComponent
	{
		// Token: 0x0600351F RID: 13599 RVA: 0x000873DC File Offset: 0x000855DC
		private SwitcherComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SwitcherComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SwitcherComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SwitcherComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06003520 RID: 13600 RVA: 0x00087414 File Offset: 0x00085614
		public static SwitcherComponent Create([Nullable(2)] SwitcherComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SwitcherComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06003521 RID: 13601 RVA: 0x00087427 File Offset: 0x00085627
		public static SwitcherComponent CreateFromSetValue([Nullable(2)] SwitcherComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SwitcherComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06003522 RID: 13602 RVA: 0x0008743C File Offset: 0x0008563C
		public new SwitcherComponent_SetValue ToSetValue()
		{
			return new SwitcherComponent_SetValue
			{
				Disabled = this.Disabled,
				Content = this.Content,
				Icon = this.Icon,
				EdIsLocked = this.EdIsLocked,
				OnActions = this.OnActions,
				OffActions = this.OffActions
			};
		}

		// Token: 0x17000E14 RID: 3604
		// (get) Token: 0x06003523 RID: 13603 RVA: 0x00087498 File Offset: 0x00085698
		// (set) Token: 0x06003524 RID: 13604 RVA: 0x000874D2 File Offset: 0x000856D2
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				SwitcherComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x17000E15 RID: 3605
		// (get) Token: 0x06003525 RID: 13605 RVA: 0x000874E0 File Offset: 0x000856E0
		// (set) Token: 0x06003526 RID: 13606 RVA: 0x0008750B File Offset: 0x0008570B
		public override string Content
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Content;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Content;
			}
			set
			{
				this.GetOrCreatePoco().Content = value;
			}
		}

		// Token: 0x17000E16 RID: 3606
		// (get) Token: 0x06003527 RID: 13607 RVA: 0x00087519 File Offset: 0x00085719
		// (set) Token: 0x06003528 RID: 13608 RVA: 0x00087544 File Offset: 0x00085744
		public override string Icon
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Icon;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Icon;
			}
			set
			{
				this.GetOrCreatePoco().Icon = value;
			}
		}

		// Token: 0x17000E17 RID: 3607
		// (get) Token: 0x06003529 RID: 13609 RVA: 0x00087554 File Offset: 0x00085754
		// (set) Token: 0x0600352A RID: 13610 RVA: 0x0008757E File Offset: 0x0008577E
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x17000E18 RID: 3608
		// (get) Token: 0x0600352B RID: 13611 RVA: 0x0008758C File Offset: 0x0008578C
		// (set) Token: 0x0600352C RID: 13612 RVA: 0x0008761F File Offset: 0x0008581F
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> OnActions
		{
			get
			{
				if (this._OnActionsInited)
				{
					return this._OnActionsCache;
				}
				this._OnActionsInited = true;
				if (this.FbInstance != null)
				{
					List<Aki.TDConfigMgr.Action.Fb.ActionInfo> onActions = this.FbInstance.OnActions;
					if (onActions != null)
					{
						this._OnActionsCache = new List<Aki.TDConfigMgr.Action.ActionInfo>(onActions.Count);
						for (int i = 0; i < onActions.Count; i++)
						{
							this._OnActionsCache.Add(Aki.TDConfigMgr.Action.ActionInfo.Create(onActions[i]));
						}
					}
				}
				else
				{
					SwitcherComponent_SetValue pocoInterface = this.PocoInterface;
					this._OnActionsCache = ((pocoInterface != null) ? pocoInterface.OnActions : null);
				}
				return this._OnActionsCache;
			}
			set
			{
				this.GetOrCreatePoco().OnActions = value;
				this._OnActionsInited = false;
			}
		}

		// Token: 0x17000E19 RID: 3609
		// (get) Token: 0x0600352D RID: 13613 RVA: 0x00087634 File Offset: 0x00085834
		// (set) Token: 0x0600352E RID: 13614 RVA: 0x000876C7 File Offset: 0x000858C7
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> OffActions
		{
			get
			{
				if (this._OffActionsInited)
				{
					return this._OffActionsCache;
				}
				this._OffActionsInited = true;
				if (this.FbInstance != null)
				{
					List<Aki.TDConfigMgr.Action.Fb.ActionInfo> offActions = this.FbInstance.OffActions;
					if (offActions != null)
					{
						this._OffActionsCache = new List<Aki.TDConfigMgr.Action.ActionInfo>(offActions.Count);
						for (int i = 0; i < offActions.Count; i++)
						{
							this._OffActionsCache.Add(Aki.TDConfigMgr.Action.ActionInfo.Create(offActions[i]));
						}
					}
				}
				else
				{
					SwitcherComponent_SetValue pocoInterface = this.PocoInterface;
					this._OffActionsCache = ((pocoInterface != null) ? pocoInterface.OffActions : null);
				}
				return this._OffActionsCache;
			}
			set
			{
				this.GetOrCreatePoco().OffActions = value;
				this._OffActionsInited = false;
			}
		}

		// Token: 0x040022C5 RID: 8901
		[Nullable(2)]
		protected new SwitcherComponent FbInstance;

		// Token: 0x040022C6 RID: 8902
		[Nullable(2)]
		protected new SwitcherComponent_SetValue PocoInterface;

		// Token: 0x040022C7 RID: 8903
		private List<Aki.TDConfigMgr.Action.ActionInfo> _OnActionsCache;

		// Token: 0x040022C8 RID: 8904
		private bool _OnActionsInited;

		// Token: 0x040022C9 RID: 8905
		private List<Aki.TDConfigMgr.Action.ActionInfo> _OffActionsCache;

		// Token: 0x040022CA RID: 8906
		private bool _OffActionsInited;
	}
}
