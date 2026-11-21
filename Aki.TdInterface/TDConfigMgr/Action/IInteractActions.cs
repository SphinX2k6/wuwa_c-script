using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CF3 RID: 7411
	public class IInteractActions : IInteractType
	{
		// Token: 0x06009D4B RID: 40267 RVA: 0x0016A2B8 File Offset: 0x001684B8
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

		// Token: 0x06009D4C RID: 40268 RVA: 0x0016A2F0 File Offset: 0x001684F0
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

		// Token: 0x06009D4D RID: 40269 RVA: 0x0016A303 File Offset: 0x00168503
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

		// Token: 0x06009D4E RID: 40270 RVA: 0x0016A316 File Offset: 0x00168516
		public new IInteractActions_SetValue ToSetValue()
		{
			return new IInteractActions_SetValue
			{
				Type = this.Type,
				Actions = this.Actions
			};
		}

		// Token: 0x17003147 RID: 12615
		// (get) Token: 0x06009D4F RID: 40271 RVA: 0x0016A335 File Offset: 0x00168535
		// (set) Token: 0x06009D50 RID: 40272 RVA: 0x0016A360 File Offset: 0x00168560
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

		// Token: 0x17003148 RID: 12616
		// (get) Token: 0x06009D51 RID: 40273 RVA: 0x0016A370 File Offset: 0x00168570
		// (set) Token: 0x06009D52 RID: 40274 RVA: 0x0016A403 File Offset: 0x00168603
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

		// Token: 0x04006008 RID: 24584
		[Nullable(2)]
		protected new IInteractActions FbInstance;

		// Token: 0x04006009 RID: 24585
		[Nullable(2)]
		protected new IInteractActions_SetValue PocoInterface;

		// Token: 0x0400600A RID: 24586
		private List<ActionInfo> _ActionsCache;

		// Token: 0x0400600B RID: 24587
		private bool _ActionsInited;
	}
}
