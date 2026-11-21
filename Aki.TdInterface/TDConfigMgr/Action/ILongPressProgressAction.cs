using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D93 RID: 7571
	public class ILongPressProgressAction
	{
		// Token: 0x0600A0B5 RID: 41141 RVA: 0x001707C4 File Offset: 0x0016E9C4
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

		// Token: 0x0600A0B6 RID: 41142 RVA: 0x001707FC File Offset: 0x0016E9FC
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

		// Token: 0x0600A0B7 RID: 41143 RVA: 0x0017080F File Offset: 0x0016EA0F
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

		// Token: 0x0600A0B8 RID: 41144 RVA: 0x00170822 File Offset: 0x0016EA22
		public ILongPressProgressAction_SetValue ToSetValue()
		{
			return new ILongPressProgressAction_SetValue
			{
				Percentage = this.Percentage,
				Actions = this.Actions
			};
		}

		// Token: 0x1700320C RID: 12812
		// (get) Token: 0x0600A0B9 RID: 41145 RVA: 0x00170841 File Offset: 0x0016EA41
		// (set) Token: 0x0600A0BA RID: 41146 RVA: 0x00170870 File Offset: 0x0016EA70
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

		// Token: 0x1700320D RID: 12813
		// (get) Token: 0x0600A0BB RID: 41147 RVA: 0x00170880 File Offset: 0x0016EA80
		// (set) Token: 0x0600A0BC RID: 41148 RVA: 0x00170913 File Offset: 0x0016EB13
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

		// Token: 0x040061A7 RID: 24999
		[Nullable(2)]
		protected ILongPressProgressAction FbInstance;

		// Token: 0x040061A8 RID: 25000
		[Nullable(2)]
		protected ILongPressProgressAction_SetValue PocoInterface;

		// Token: 0x040061A9 RID: 25001
		private List<ActionInfo> _ActionsCache;

		// Token: 0x040061AA RID: 25002
		private bool _ActionsInited;
	}
}
