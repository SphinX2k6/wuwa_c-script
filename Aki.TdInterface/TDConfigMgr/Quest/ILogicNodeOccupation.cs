using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200112B RID: 4395
	public class ILogicNodeOccupation
	{
		// Token: 0x06006148 RID: 24904 RVA: 0x000EAA84 File Offset: 0x000E8C84
		private ILogicNodeOccupation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILogicNodeOccupation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILogicNodeOccupation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILogicNodeOccupation_SetValue());
			}
			return result;
		}

		// Token: 0x06006149 RID: 24905 RVA: 0x000EAABC File Offset: 0x000E8CBC
		public static ILogicNodeOccupation Create([Nullable(2)] ILogicNodeOccupation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILogicNodeOccupation
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600614A RID: 24906 RVA: 0x000EAACF File Offset: 0x000E8CCF
		public static ILogicNodeOccupation CreateFromSetValue([Nullable(2)] ILogicNodeOccupation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILogicNodeOccupation
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600614B RID: 24907 RVA: 0x000EAAE4 File Offset: 0x000E8CE4
		public ILogicNodeOccupation_SetValue ToSetValue()
		{
			return new ILogicNodeOccupation_SetValue
			{
				Occupations = this.Occupations,
				TidDesc = this.TidDesc,
				ExitActions = this.ExitActions,
				ReenterActions = this.ReenterActions,
				BanInteractEntities = this.BanInteractEntities,
				ReclaimOccupationWhenEnter = this.ReclaimOccupationWhenEnter,
				EdTidDesc = this.EdTidDesc
			};
		}

		// Token: 0x17001FE0 RID: 8160
		// (get) Token: 0x0600614C RID: 24908 RVA: 0x000EAB4A File Offset: 0x000E8D4A
		// (set) Token: 0x0600614D RID: 24909 RVA: 0x000EAB71 File Offset: 0x000E8D71
		public virtual List<string> Occupations
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Occupations;
				}
				ILogicNodeOccupation_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Occupations;
			}
			set
			{
				this.GetOrCreatePoco().Occupations = value;
			}
		}

		// Token: 0x17001FE1 RID: 8161
		// (get) Token: 0x0600614E RID: 24910 RVA: 0x000EAB7F File Offset: 0x000E8D7F
		// (set) Token: 0x0600614F RID: 24911 RVA: 0x000EABAA File Offset: 0x000E8DAA
		public virtual string TidDesc
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidDesc;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TidDesc;
			}
			set
			{
				this.GetOrCreatePoco().TidDesc = value;
			}
		}

		// Token: 0x17001FE2 RID: 8162
		// (get) Token: 0x06006150 RID: 24912 RVA: 0x000EABB8 File Offset: 0x000E8DB8
		// (set) Token: 0x06006151 RID: 24913 RVA: 0x000EAC4B File Offset: 0x000E8E4B
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> ExitActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._ExitActionsInited)
				{
					return this._ExitActionsCache;
				}
				this._ExitActionsInited = true;
				if (this.FbInstance != null)
				{
					List<Aki.TDConfigMgr.Action.Fb.ActionInfo> exitActions = this.FbInstance.ExitActions;
					if (exitActions != null)
					{
						this._ExitActionsCache = new List<Aki.TDConfigMgr.Action.ActionInfo>(exitActions.Count);
						for (int i = 0; i < exitActions.Count; i++)
						{
							this._ExitActionsCache.Add(Aki.TDConfigMgr.Action.ActionInfo.Create(exitActions[i]));
						}
					}
				}
				else
				{
					ILogicNodeOccupation_SetValue pocoInterface = this.PocoInterface;
					this._ExitActionsCache = ((pocoInterface != null) ? pocoInterface.ExitActions : null);
				}
				return this._ExitActionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().ExitActions = value;
				this._ExitActionsInited = false;
			}
		}

		// Token: 0x17001FE3 RID: 8163
		// (get) Token: 0x06006152 RID: 24914 RVA: 0x000EAC60 File Offset: 0x000E8E60
		// (set) Token: 0x06006153 RID: 24915 RVA: 0x000EACF3 File Offset: 0x000E8EF3
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> ReenterActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._ReenterActionsInited)
				{
					return this._ReenterActionsCache;
				}
				this._ReenterActionsInited = true;
				if (this.FbInstance != null)
				{
					List<Aki.TDConfigMgr.Action.Fb.ActionInfo> reenterActions = this.FbInstance.ReenterActions;
					if (reenterActions != null)
					{
						this._ReenterActionsCache = new List<Aki.TDConfigMgr.Action.ActionInfo>(reenterActions.Count);
						for (int i = 0; i < reenterActions.Count; i++)
						{
							this._ReenterActionsCache.Add(Aki.TDConfigMgr.Action.ActionInfo.Create(reenterActions[i]));
						}
					}
				}
				else
				{
					ILogicNodeOccupation_SetValue pocoInterface = this.PocoInterface;
					this._ReenterActionsCache = ((pocoInterface != null) ? pocoInterface.ReenterActions : null);
				}
				return this._ReenterActionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().ReenterActions = value;
				this._ReenterActionsInited = false;
			}
		}

		// Token: 0x17001FE4 RID: 8164
		// (get) Token: 0x06006154 RID: 24916 RVA: 0x000EAD08 File Offset: 0x000E8F08
		// (set) Token: 0x06006155 RID: 24917 RVA: 0x000EAD2F File Offset: 0x000E8F2F
		[Nullable(2)]
		public virtual List<int> BanInteractEntities
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BanInteractEntities;
				}
				ILogicNodeOccupation_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.BanInteractEntities;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().BanInteractEntities = value;
			}
		}

		// Token: 0x17001FE5 RID: 8165
		// (get) Token: 0x06006156 RID: 24918 RVA: 0x000EAD40 File Offset: 0x000E8F40
		// (set) Token: 0x06006157 RID: 24919 RVA: 0x000EAD7A File Offset: 0x000E8F7A
		public virtual bool? ReclaimOccupationWhenEnter
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ReclaimOccupationWhenEnter;
				}
				ILogicNodeOccupation_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ReclaimOccupationWhenEnter;
			}
			set
			{
				this.GetOrCreatePoco().ReclaimOccupationWhenEnter = value;
			}
		}

		// Token: 0x17001FE6 RID: 8166
		// (get) Token: 0x06006158 RID: 24920 RVA: 0x000EAD88 File Offset: 0x000E8F88
		// (set) Token: 0x06006159 RID: 24921 RVA: 0x000EAD9F File Offset: 0x000E8F9F
		[Nullable(2)]
		public virtual string EdTidDesc
		{
			[NullableContext(2)]
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidDesc;
				}
				return null;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EdTidDesc = value;
			}
		}

		// Token: 0x04003A4C RID: 14924
		[Nullable(2)]
		protected ILogicNodeOccupation FbInstance;

		// Token: 0x04003A4D RID: 14925
		[Nullable(2)]
		protected ILogicNodeOccupation_SetValue PocoInterface;

		// Token: 0x04003A4E RID: 14926
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ExitActionsCache;

		// Token: 0x04003A4F RID: 14927
		private bool _ExitActionsInited;

		// Token: 0x04003A50 RID: 14928
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ReenterActionsCache;

		// Token: 0x04003A51 RID: 14929
		private bool _ReenterActionsInited;
	}
}
