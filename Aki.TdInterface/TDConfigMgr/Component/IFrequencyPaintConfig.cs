using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000415 RID: 1045
	public class IFrequencyPaintConfig
	{
		// Token: 0x060014C9 RID: 5321 RVA: 0x000428C0 File Offset: 0x00040AC0
		private IFrequencyPaintConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFrequencyPaintConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFrequencyPaintConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFrequencyPaintConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060014CA RID: 5322 RVA: 0x000428F8 File Offset: 0x00040AF8
		public static IFrequencyPaintConfig Create([Nullable(2)] IFrequencyPaintConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFrequencyPaintConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060014CB RID: 5323 RVA: 0x0004290B File Offset: 0x00040B0B
		public static IFrequencyPaintConfig CreateFromSetValue([Nullable(2)] IFrequencyPaintConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFrequencyPaintConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060014CC RID: 5324 RVA: 0x0004291E File Offset: 0x00040B1E
		public IFrequencyPaintConfig_SetValue ToSetValue()
		{
			return new IFrequencyPaintConfig_SetValue
			{
				EntityState = this.EntityState,
				LineType = this.LineType,
				SuccessActions = this.SuccessActions
			};
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x060014CD RID: 5325 RVA: 0x00042949 File Offset: 0x00040B49
		// (set) Token: 0x060014CE RID: 5326 RVA: 0x00042974 File Offset: 0x00040B74
		public virtual string EntityState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityState;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.EntityState;
			}
			set
			{
				this.GetOrCreatePoco().EntityState = value;
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x060014CF RID: 5327 RVA: 0x00042982 File Offset: 0x00040B82
		// (set) Token: 0x060014D0 RID: 5328 RVA: 0x000429A9 File Offset: 0x00040BA9
		public virtual IFrequencyPaintLineBase LineType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LineType;
				}
				IFrequencyPaintConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.LineType;
			}
			set
			{
				this.GetOrCreatePoco().LineType = value;
			}
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x060014D1 RID: 5329 RVA: 0x000429B8 File Offset: 0x00040BB8
		// (set) Token: 0x060014D2 RID: 5330 RVA: 0x00042A4B File Offset: 0x00040C4B
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> SuccessActions
		{
			get
			{
				if (this._SuccessActionsInited)
				{
					return this._SuccessActionsCache;
				}
				this._SuccessActionsInited = true;
				if (this.FbInstance != null)
				{
					List<Aki.TDConfigMgr.Action.Fb.ActionInfo> successActions = this.FbInstance.SuccessActions;
					if (successActions != null)
					{
						this._SuccessActionsCache = new List<Aki.TDConfigMgr.Action.ActionInfo>(successActions.Count);
						for (int i = 0; i < successActions.Count; i++)
						{
							this._SuccessActionsCache.Add(Aki.TDConfigMgr.Action.ActionInfo.Create(successActions[i]));
						}
					}
				}
				else
				{
					IFrequencyPaintConfig_SetValue pocoInterface = this.PocoInterface;
					this._SuccessActionsCache = ((pocoInterface != null) ? pocoInterface.SuccessActions : null);
				}
				return this._SuccessActionsCache;
			}
			set
			{
				this.GetOrCreatePoco().SuccessActions = value;
				this._SuccessActionsInited = false;
			}
		}

		// Token: 0x04001080 RID: 4224
		[Nullable(2)]
		protected IFrequencyPaintConfig FbInstance;

		// Token: 0x04001081 RID: 4225
		[Nullable(2)]
		protected IFrequencyPaintConfig_SetValue PocoInterface;

		// Token: 0x04001082 RID: 4226
		private List<Aki.TDConfigMgr.Action.ActionInfo> _SuccessActionsCache;

		// Token: 0x04001083 RID: 4227
		private bool _SuccessActionsInited;
	}
}
