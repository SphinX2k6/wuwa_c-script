using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FFF RID: 4095
	[NullableContext(1)]
	[Nullable(0)]
	public class ILogicNodeOccupation
	{
		// Token: 0x06005B68 RID: 23400 RVA: 0x000DDE44 File Offset: 0x000DC044
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

		// Token: 0x06005B69 RID: 23401 RVA: 0x000DDE7C File Offset: 0x000DC07C
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

		// Token: 0x06005B6A RID: 23402 RVA: 0x000DDE8F File Offset: 0x000DC08F
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

		// Token: 0x06005B6B RID: 23403 RVA: 0x000DDEA4 File Offset: 0x000DC0A4
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

		// Token: 0x17001E37 RID: 7735
		// (get) Token: 0x06005B6C RID: 23404 RVA: 0x000DDF0A File Offset: 0x000DC10A
		// (set) Token: 0x06005B6D RID: 23405 RVA: 0x000DDF31 File Offset: 0x000DC131
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

		// Token: 0x17001E38 RID: 7736
		// (get) Token: 0x06005B6E RID: 23406 RVA: 0x000DDF3F File Offset: 0x000DC13F
		// (set) Token: 0x06005B6F RID: 23407 RVA: 0x000DDF6A File Offset: 0x000DC16A
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

		// Token: 0x17001E39 RID: 7737
		// (get) Token: 0x06005B70 RID: 23408 RVA: 0x000DDF78 File Offset: 0x000DC178
		// (set) Token: 0x06005B71 RID: 23409 RVA: 0x000DE00B File Offset: 0x000DC20B
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> ExitActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().ExitActions = value;
				this._ExitActionsInited = false;
			}
		}

		// Token: 0x17001E3A RID: 7738
		// (get) Token: 0x06005B72 RID: 23410 RVA: 0x000DE020 File Offset: 0x000DC220
		// (set) Token: 0x06005B73 RID: 23411 RVA: 0x000DE0B3 File Offset: 0x000DC2B3
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> ReenterActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().ReenterActions = value;
				this._ReenterActionsInited = false;
			}
		}

		// Token: 0x17001E3B RID: 7739
		// (get) Token: 0x06005B74 RID: 23412 RVA: 0x000DE0C8 File Offset: 0x000DC2C8
		// (set) Token: 0x06005B75 RID: 23413 RVA: 0x000DE0EF File Offset: 0x000DC2EF
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

		// Token: 0x17001E3C RID: 7740
		// (get) Token: 0x06005B76 RID: 23414 RVA: 0x000DE100 File Offset: 0x000DC300
		// (set) Token: 0x06005B77 RID: 23415 RVA: 0x000DE13A File Offset: 0x000DC33A
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

		// Token: 0x17001E3D RID: 7741
		// (get) Token: 0x06005B78 RID: 23416 RVA: 0x000DE148 File Offset: 0x000DC348
		// (set) Token: 0x06005B79 RID: 23417 RVA: 0x000DE15F File Offset: 0x000DC35F
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

		// Token: 0x04003714 RID: 14100
		[Nullable(2)]
		protected ILogicNodeOccupation FbInstance;

		// Token: 0x04003715 RID: 14101
		[Nullable(2)]
		protected ILogicNodeOccupation_SetValue PocoInterface;

		// Token: 0x04003716 RID: 14102
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ExitActionsCache;

		// Token: 0x04003717 RID: 14103
		private bool _ExitActionsInited;

		// Token: 0x04003718 RID: 14104
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ReenterActionsCache;

		// Token: 0x04003719 RID: 14105
		private bool _ReenterActionsInited;
	}
}
