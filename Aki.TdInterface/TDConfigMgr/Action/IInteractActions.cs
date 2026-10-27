using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B44 RID: 6980
	[NullableContext(1)]
	[Nullable(0)]
	public class IInteractActions : IInteractType
	{
		// Token: 0x06009561 RID: 38241 RVA: 0x001595DC File Offset: 0x001577DC
		private IInteractActions_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInteractActions 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInteractActions_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInteractActions_SetValue());
			}
			return result;
		}

		// Token: 0x06009562 RID: 38242 RVA: 0x00159614 File Offset: 0x00157814
		public static IInteractActions Create([Nullable(2)] IInteractActions instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractActions
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009563 RID: 38243 RVA: 0x00159627 File Offset: 0x00157827
		public static IInteractActions CreateFromSetValue([Nullable(2)] IInteractActions_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInteractActions
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009564 RID: 38244 RVA: 0x0015963A File Offset: 0x0015783A
		public new IInteractActions_SetValue ToSetValue()
		{
			return new IInteractActions_SetValue
			{
				Type = this.Type,
				Actions = this.Actions
			};
		}

		// Token: 0x17002F21 RID: 12065
		// (get) Token: 0x06009565 RID: 38245 RVA: 0x00159659 File Offset: 0x00157859
		// (set) Token: 0x06009566 RID: 38246 RVA: 0x00159684 File Offset: 0x00157884
		public override EInteractOption Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInteractOption.Flow;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002F22 RID: 12066
		// (get) Token: 0x06009567 RID: 38247 RVA: 0x00159694 File Offset: 0x00157894
		// (set) Token: 0x06009568 RID: 38248 RVA: 0x00159727 File Offset: 0x00157927
		public virtual List<ActionInfo> Actions
		{
			get
			{
				if (this._ActionsInited)
				{
					return this._ActionsCache;
				}
				this._ActionsInited = true;
				if (this.FbInstance != null)
				{
					List<ActionInfo> actions = this.FbInstance.Actions;
					if (actions != null)
					{
						this._ActionsCache = new List<ActionInfo>(actions.Count);
						for (int i = 0; i < actions.Count; i++)
						{
							this._ActionsCache.Add(ActionInfo.Create(actions[i]));
						}
					}
				}
				else
				{
					IInteractActions_SetValue pocoInterface = this.PocoInterface;
					this._ActionsCache = ((pocoInterface != null) ? pocoInterface.Actions : null);
				}
				return this._ActionsCache;
			}
			set
			{
				this.GetOrCreatePoco().Actions = value;
				this._ActionsInited = false;
			}
		}

		// Token: 0x04005B6A RID: 23402
		[Nullable(2)]
		protected new IInteractActions FbInstance;

		// Token: 0x04005B6B RID: 23403
		[Nullable(2)]
		protected new IInteractActions_SetValue PocoInterface;

		// Token: 0x04005B6C RID: 23404
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04005B6D RID: 23405
		private bool _ActionsInited;
	}
}
