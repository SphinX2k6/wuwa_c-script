using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200217F RID: 8575
	[NullableContext(1)]
	[Nullable(0)]
	public class RunActions : ActionParams
	{
		// Token: 0x0600BC76 RID: 48246 RVA: 0x001B2794 File Offset: 0x001B0994
		private RunActions_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("RunActions 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			RunActions_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new RunActions_SetValue());
			}
			return result;
		}

		// Token: 0x0600BC77 RID: 48247 RVA: 0x001B27CC File Offset: 0x001B09CC
		public static RunActions Create([Nullable(2)] RunActions instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RunActions
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BC78 RID: 48248 RVA: 0x001B27DF File Offset: 0x001B09DF
		public static RunActions CreateFromSetValue([Nullable(2)] RunActions_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new RunActions
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BC79 RID: 48249 RVA: 0x001B27F2 File Offset: 0x001B09F2
		public RunActions_SetValue ToSetValue()
		{
			return new RunActions_SetValue
			{
				ActionList = this.ActionList
			};
		}

		// Token: 0x1700395D RID: 14685
		// (get) Token: 0x0600BC7A RID: 48250 RVA: 0x001B2808 File Offset: 0x001B0A08
		// (set) Token: 0x0600BC7B RID: 48251 RVA: 0x001B289B File Offset: 0x001B0A9B
		public virtual List<ActionInfo> ActionList
		{
			get
			{
				if (this._ActionListInited)
				{
					return this._ActionListCache;
				}
				this._ActionListInited = true;
				if (this.FbInstance != null)
				{
					List<ActionInfo> actionList = this.FbInstance.ActionList;
					if (actionList != null)
					{
						this._ActionListCache = new List<ActionInfo>(actionList.Count);
						for (int i = 0; i < actionList.Count; i++)
						{
							this._ActionListCache.Add(ActionInfo.Create(actionList[i]));
						}
					}
				}
				else
				{
					RunActions_SetValue pocoInterface = this.PocoInterface;
					this._ActionListCache = ((pocoInterface != null) ? pocoInterface.ActionList : null);
				}
				return this._ActionListCache;
			}
			set
			{
				this.GetOrCreatePoco().ActionList = value;
				this._ActionListInited = false;
			}
		}

		// Token: 0x0400708C RID: 28812
		[Nullable(2)]
		protected new RunActions FbInstance;

		// Token: 0x0400708D RID: 28813
		[Nullable(2)]
		protected RunActions_SetValue PocoInterface;

		// Token: 0x0400708E RID: 28814
		private List<ActionInfo> _ActionListCache;

		// Token: 0x0400708F RID: 28815
		private bool _ActionListInited;
	}
}
