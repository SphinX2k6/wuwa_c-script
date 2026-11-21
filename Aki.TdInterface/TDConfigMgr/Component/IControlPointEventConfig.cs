using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002C8 RID: 712
	public class IControlPointEventConfig
	{
		// Token: 0x06000D1B RID: 3355 RVA: 0x000321B4 File Offset: 0x000303B4
		private IControlPointEventConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IControlPointEventConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IControlPointEventConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IControlPointEventConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06000D1C RID: 3356 RVA: 0x000321EC File Offset: 0x000303EC
		public static IControlPointEventConfig Create([Nullable(2)] IControlPointEventConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IControlPointEventConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000D1D RID: 3357 RVA: 0x000321FF File Offset: 0x000303FF
		public static IControlPointEventConfig CreateFromSetValue([Nullable(2)] IControlPointEventConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IControlPointEventConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000D1E RID: 3358 RVA: 0x00032214 File Offset: 0x00030414
		public IControlPointEventConfig_SetValue ToSetValue()
		{
			return new IControlPointEventConfig_SetValue
			{
				Index = this.Index,
				LeftInEventActions = this.LeftInEventActions,
				LeftOutEventActions = this.LeftOutEventActions,
				RightInEventActions = this.RightInEventActions,
				RightOutEventActions = this.RightOutEventActions
			};
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06000D1F RID: 3359 RVA: 0x00032262 File Offset: 0x00030462
		// (set) Token: 0x06000D20 RID: 3360 RVA: 0x0003228D File Offset: 0x0003048D
		public virtual int Index
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Index;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Index;
			}
			set
			{
				this.GetOrCreatePoco().Index = value;
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06000D21 RID: 3361 RVA: 0x0003229C File Offset: 0x0003049C
		// (set) Token: 0x06000D22 RID: 3362 RVA: 0x0003232F File Offset: 0x0003052F
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> LeftInEventActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._LeftInEventActionsInited)
				{
					return this._LeftInEventActionsCache;
				}
				this._LeftInEventActionsInited = true;
				if (this.FbInstance != null)
				{
					List<Aki.TDConfigMgr.Action.Fb.ActionInfo> leftInEventActions = this.FbInstance.LeftInEventActions;
					if (leftInEventActions != null)
					{
						this._LeftInEventActionsCache = new List<Aki.TDConfigMgr.Action.ActionInfo>(leftInEventActions.Count);
						for (int i = 0; i < leftInEventActions.Count; i++)
						{
							this._LeftInEventActionsCache.Add(Aki.TDConfigMgr.Action.ActionInfo.Create(leftInEventActions[i]));
						}
					}
				}
				else
				{
					IControlPointEventConfig_SetValue pocoInterface = this.PocoInterface;
					this._LeftInEventActionsCache = ((pocoInterface != null) ? pocoInterface.LeftInEventActions : null);
				}
				return this._LeftInEventActionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().LeftInEventActions = value;
				this._LeftInEventActionsInited = false;
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06000D23 RID: 3363 RVA: 0x00032344 File Offset: 0x00030544
		// (set) Token: 0x06000D24 RID: 3364 RVA: 0x000323D7 File Offset: 0x000305D7
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> LeftOutEventActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._LeftOutEventActionsInited)
				{
					return this._LeftOutEventActionsCache;
				}
				this._LeftOutEventActionsInited = true;
				if (this.FbInstance != null)
				{
					List<Aki.TDConfigMgr.Action.Fb.ActionInfo> leftOutEventActions = this.FbInstance.LeftOutEventActions;
					if (leftOutEventActions != null)
					{
						this._LeftOutEventActionsCache = new List<Aki.TDConfigMgr.Action.ActionInfo>(leftOutEventActions.Count);
						for (int i = 0; i < leftOutEventActions.Count; i++)
						{
							this._LeftOutEventActionsCache.Add(Aki.TDConfigMgr.Action.ActionInfo.Create(leftOutEventActions[i]));
						}
					}
				}
				else
				{
					IControlPointEventConfig_SetValue pocoInterface = this.PocoInterface;
					this._LeftOutEventActionsCache = ((pocoInterface != null) ? pocoInterface.LeftOutEventActions : null);
				}
				return this._LeftOutEventActionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().LeftOutEventActions = value;
				this._LeftOutEventActionsInited = false;
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06000D25 RID: 3365 RVA: 0x000323EC File Offset: 0x000305EC
		// (set) Token: 0x06000D26 RID: 3366 RVA: 0x0003247F File Offset: 0x0003067F
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> RightInEventActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._RightInEventActionsInited)
				{
					return this._RightInEventActionsCache;
				}
				this._RightInEventActionsInited = true;
				if (this.FbInstance != null)
				{
					List<Aki.TDConfigMgr.Action.Fb.ActionInfo> rightInEventActions = this.FbInstance.RightInEventActions;
					if (rightInEventActions != null)
					{
						this._RightInEventActionsCache = new List<Aki.TDConfigMgr.Action.ActionInfo>(rightInEventActions.Count);
						for (int i = 0; i < rightInEventActions.Count; i++)
						{
							this._RightInEventActionsCache.Add(Aki.TDConfigMgr.Action.ActionInfo.Create(rightInEventActions[i]));
						}
					}
				}
				else
				{
					IControlPointEventConfig_SetValue pocoInterface = this.PocoInterface;
					this._RightInEventActionsCache = ((pocoInterface != null) ? pocoInterface.RightInEventActions : null);
				}
				return this._RightInEventActionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().RightInEventActions = value;
				this._RightInEventActionsInited = false;
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06000D27 RID: 3367 RVA: 0x00032494 File Offset: 0x00030694
		// (set) Token: 0x06000D28 RID: 3368 RVA: 0x00032527 File Offset: 0x00030727
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> RightOutEventActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._RightOutEventActionsInited)
				{
					return this._RightOutEventActionsCache;
				}
				this._RightOutEventActionsInited = true;
				if (this.FbInstance != null)
				{
					List<Aki.TDConfigMgr.Action.Fb.ActionInfo> rightOutEventActions = this.FbInstance.RightOutEventActions;
					if (rightOutEventActions != null)
					{
						this._RightOutEventActionsCache = new List<Aki.TDConfigMgr.Action.ActionInfo>(rightOutEventActions.Count);
						for (int i = 0; i < rightOutEventActions.Count; i++)
						{
							this._RightOutEventActionsCache.Add(Aki.TDConfigMgr.Action.ActionInfo.Create(rightOutEventActions[i]));
						}
					}
				}
				else
				{
					IControlPointEventConfig_SetValue pocoInterface = this.PocoInterface;
					this._RightOutEventActionsCache = ((pocoInterface != null) ? pocoInterface.RightOutEventActions : null);
				}
				return this._RightOutEventActionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().RightOutEventActions = value;
				this._RightOutEventActionsInited = false;
			}
		}

		// Token: 0x04000C52 RID: 3154
		[Nullable(2)]
		protected IControlPointEventConfig FbInstance;

		// Token: 0x04000C53 RID: 3155
		[Nullable(2)]
		protected IControlPointEventConfig_SetValue PocoInterface;

		// Token: 0x04000C54 RID: 3156
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _LeftInEventActionsCache;

		// Token: 0x04000C55 RID: 3157
		private bool _LeftInEventActionsInited;

		// Token: 0x04000C56 RID: 3158
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _LeftOutEventActionsCache;

		// Token: 0x04000C57 RID: 3159
		private bool _LeftOutEventActionsInited;

		// Token: 0x04000C58 RID: 3160
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _RightInEventActionsCache;

		// Token: 0x04000C59 RID: 3161
		private bool _RightInEventActionsInited;

		// Token: 0x04000C5A RID: 3162
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _RightOutEventActionsCache;

		// Token: 0x04000C5B RID: 3163
		private bool _RightOutEventActionsInited;
	}
}
