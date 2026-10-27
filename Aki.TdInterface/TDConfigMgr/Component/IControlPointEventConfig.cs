using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000285 RID: 645
	[NullableContext(1)]
	[Nullable(0)]
	public class IControlPointEventConfig
	{
		// Token: 0x06000C01 RID: 3073 RVA: 0x0002F4C4 File Offset: 0x0002D6C4
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

		// Token: 0x06000C02 RID: 3074 RVA: 0x0002F4FC File Offset: 0x0002D6FC
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

		// Token: 0x06000C03 RID: 3075 RVA: 0x0002F50F File Offset: 0x0002D70F
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

		// Token: 0x06000C04 RID: 3076 RVA: 0x0002F524 File Offset: 0x0002D724
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

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000C05 RID: 3077 RVA: 0x0002F572 File Offset: 0x0002D772
		// (set) Token: 0x06000C06 RID: 3078 RVA: 0x0002F59D File Offset: 0x0002D79D
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

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000C07 RID: 3079 RVA: 0x0002F5AC File Offset: 0x0002D7AC
		// (set) Token: 0x06000C08 RID: 3080 RVA: 0x0002F63F File Offset: 0x0002D83F
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> LeftInEventActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().LeftInEventActions = value;
				this._LeftInEventActionsInited = false;
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06000C09 RID: 3081 RVA: 0x0002F654 File Offset: 0x0002D854
		// (set) Token: 0x06000C0A RID: 3082 RVA: 0x0002F6E7 File Offset: 0x0002D8E7
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> LeftOutEventActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().LeftOutEventActions = value;
				this._LeftOutEventActionsInited = false;
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06000C0B RID: 3083 RVA: 0x0002F6FC File Offset: 0x0002D8FC
		// (set) Token: 0x06000C0C RID: 3084 RVA: 0x0002F78F File Offset: 0x0002D98F
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> RightInEventActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().RightInEventActions = value;
				this._RightInEventActionsInited = false;
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06000C0D RID: 3085 RVA: 0x0002F7A4 File Offset: 0x0002D9A4
		// (set) Token: 0x06000C0E RID: 3086 RVA: 0x0002F837 File Offset: 0x0002DA37
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> RightOutEventActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().RightOutEventActions = value;
				this._RightOutEventActionsInited = false;
			}
		}

		// Token: 0x04000B71 RID: 2929
		[Nullable(2)]
		protected IControlPointEventConfig FbInstance;

		// Token: 0x04000B72 RID: 2930
		[Nullable(2)]
		protected IControlPointEventConfig_SetValue PocoInterface;

		// Token: 0x04000B73 RID: 2931
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _LeftInEventActionsCache;

		// Token: 0x04000B74 RID: 2932
		private bool _LeftInEventActionsInited;

		// Token: 0x04000B75 RID: 2933
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _LeftOutEventActionsCache;

		// Token: 0x04000B76 RID: 2934
		private bool _LeftOutEventActionsInited;

		// Token: 0x04000B77 RID: 2935
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _RightInEventActionsCache;

		// Token: 0x04000B78 RID: 2936
		private bool _RightInEventActionsInited;

		// Token: 0x04000B79 RID: 2937
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _RightOutEventActionsCache;

		// Token: 0x04000B7A RID: 2938
		private bool _RightOutEventActionsInited;
	}
}
