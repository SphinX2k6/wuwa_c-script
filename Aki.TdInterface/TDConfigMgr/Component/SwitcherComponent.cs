using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008B1 RID: 2225
	[NullableContext(1)]
	[Nullable(0)]
	public class SwitcherComponent : InteractiveComponent
	{
		// Token: 0x060031E3 RID: 12771 RVA: 0x0007FEF4 File Offset: 0x0007E0F4
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

		// Token: 0x060031E4 RID: 12772 RVA: 0x0007FF2C File Offset: 0x0007E12C
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

		// Token: 0x060031E5 RID: 12773 RVA: 0x0007FF3F File Offset: 0x0007E13F
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

		// Token: 0x060031E6 RID: 12774 RVA: 0x0007FF54 File Offset: 0x0007E154
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

		// Token: 0x17000D4B RID: 3403
		// (get) Token: 0x060031E7 RID: 12775 RVA: 0x0007FFB0 File Offset: 0x0007E1B0
		// (set) Token: 0x060031E8 RID: 12776 RVA: 0x0007FFEA File Offset: 0x0007E1EA
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

		// Token: 0x17000D4C RID: 3404
		// (get) Token: 0x060031E9 RID: 12777 RVA: 0x0007FFF8 File Offset: 0x0007E1F8
		// (set) Token: 0x060031EA RID: 12778 RVA: 0x00080023 File Offset: 0x0007E223
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

		// Token: 0x17000D4D RID: 3405
		// (get) Token: 0x060031EB RID: 12779 RVA: 0x00080031 File Offset: 0x0007E231
		// (set) Token: 0x060031EC RID: 12780 RVA: 0x0008005C File Offset: 0x0007E25C
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

		// Token: 0x17000D4E RID: 3406
		// (get) Token: 0x060031ED RID: 12781 RVA: 0x0008006C File Offset: 0x0007E26C
		// (set) Token: 0x060031EE RID: 12782 RVA: 0x00080096 File Offset: 0x0007E296
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

		// Token: 0x17000D4F RID: 3407
		// (get) Token: 0x060031EF RID: 12783 RVA: 0x000800A4 File Offset: 0x0007E2A4
		// (set) Token: 0x060031F0 RID: 12784 RVA: 0x00080137 File Offset: 0x0007E337
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

		// Token: 0x17000D50 RID: 3408
		// (get) Token: 0x060031F1 RID: 12785 RVA: 0x0008014C File Offset: 0x0007E34C
		// (set) Token: 0x060031F2 RID: 12786 RVA: 0x000801DF File Offset: 0x0007E3DF
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

		// Token: 0x040020B3 RID: 8371
		[Nullable(2)]
		protected new SwitcherComponent FbInstance;

		// Token: 0x040020B4 RID: 8372
		[Nullable(2)]
		protected new SwitcherComponent_SetValue PocoInterface;

		// Token: 0x040020B5 RID: 8373
		private List<Aki.TDConfigMgr.Action.ActionInfo> _OnActionsCache;

		// Token: 0x040020B6 RID: 8374
		private bool _OnActionsInited;

		// Token: 0x040020B7 RID: 8375
		private List<Aki.TDConfigMgr.Action.ActionInfo> _OffActionsCache;

		// Token: 0x040020B8 RID: 8376
		private bool _OffActionsInited;
	}
}
