using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BAC RID: 7084
	[NullableContext(1)]
	[Nullable(0)]
	public class ILongPressProgressAction
	{
		// Token: 0x060097B1 RID: 38833 RVA: 0x0015DD04 File Offset: 0x0015BF04
		private ILongPressProgressAction_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILongPressProgressAction 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILongPressProgressAction_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILongPressProgressAction_SetValue());
			}
			return result;
		}

		// Token: 0x060097B2 RID: 38834 RVA: 0x0015DD3C File Offset: 0x0015BF3C
		public static ILongPressProgressAction Create([Nullable(2)] ILongPressProgressAction instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILongPressProgressAction
			{
				FbInstance = instance
			};
		}

		// Token: 0x060097B3 RID: 38835 RVA: 0x0015DD4F File Offset: 0x0015BF4F
		public static ILongPressProgressAction CreateFromSetValue([Nullable(2)] ILongPressProgressAction_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILongPressProgressAction
			{
				PocoInterface = value
			};
		}

		// Token: 0x060097B4 RID: 38836 RVA: 0x0015DD62 File Offset: 0x0015BF62
		public ILongPressProgressAction_SetValue ToSetValue()
		{
			return new ILongPressProgressAction_SetValue
			{
				Percentage = this.Percentage,
				Actions = this.Actions
			};
		}

		// Token: 0x17002FAD RID: 12205
		// (get) Token: 0x060097B5 RID: 38837 RVA: 0x0015DD81 File Offset: 0x0015BF81
		// (set) Token: 0x060097B6 RID: 38838 RVA: 0x0015DDB0 File Offset: 0x0015BFB0
		public virtual float Percentage
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Percentage;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Percentage;
			}
			set
			{
				this.GetOrCreatePoco().Percentage = value;
			}
		}

		// Token: 0x17002FAE RID: 12206
		// (get) Token: 0x060097B7 RID: 38839 RVA: 0x0015DDC0 File Offset: 0x0015BFC0
		// (set) Token: 0x060097B8 RID: 38840 RVA: 0x0015DE53 File Offset: 0x0015C053
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
					ILongPressProgressAction_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04005C92 RID: 23698
		[Nullable(2)]
		protected ILongPressProgressAction FbInstance;

		// Token: 0x04005C93 RID: 23699
		[Nullable(2)]
		protected ILongPressProgressAction_SetValue PocoInterface;

		// Token: 0x04005C94 RID: 23700
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04005C95 RID: 23701
		private bool _ActionsInited;
	}
}
