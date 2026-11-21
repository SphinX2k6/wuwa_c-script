using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200039D RID: 925
	public class IExploreSkillMechascoutDrag : IExploreSkillInteractType
	{
		// Token: 0x06001229 RID: 4649 RVA: 0x0003D1B8 File Offset: 0x0003B3B8
		private IExploreSkillMechascoutDrag_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IExploreSkillMechascoutDrag 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IExploreSkillMechascoutDrag_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IExploreSkillMechascoutDrag_SetValue());
			}
			return result;
		}

		// Token: 0x0600122A RID: 4650 RVA: 0x0003D1F0 File Offset: 0x0003B3F0
		public static IExploreSkillMechascoutDrag Create([Nullable(2)] IExploreSkillMechascoutDrag instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExploreSkillMechascoutDrag
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600122B RID: 4651 RVA: 0x0003D203 File Offset: 0x0003B403
		public static IExploreSkillMechascoutDrag CreateFromSetValue([Nullable(2)] IExploreSkillMechascoutDrag_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IExploreSkillMechascoutDrag
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600122C RID: 4652 RVA: 0x0003D216 File Offset: 0x0003B416
		public new IExploreSkillMechascoutDrag_SetValue ToSetValue()
		{
			return new IExploreSkillMechascoutDrag_SetValue
			{
				Type = this.Type,
				DragType = this.DragType,
				TriggerPointList = this.TriggerPointList,
				FinishedActions = this.FinishedActions
			};
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x0600122D RID: 4653 RVA: 0x0003D24D File Offset: 0x0003B44D
		// (set) Token: 0x0600122E RID: 4654 RVA: 0x0003D278 File Offset: 0x0003B478
		public override EExploreSkillInteractType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EExploreSkillInteractType.PullGiant;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x0600122F RID: 4655 RVA: 0x0003D286 File Offset: 0x0003B486
		// (set) Token: 0x06001230 RID: 4656 RVA: 0x0003D2AD File Offset: 0x0003B4AD
		public virtual IMechascoutDragTypeBase DragType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DragType;
				}
				IExploreSkillMechascoutDrag_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DragType;
			}
			set
			{
				this.GetOrCreatePoco().DragType = value;
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06001231 RID: 4657 RVA: 0x0003D2BB File Offset: 0x0003B4BB
		// (set) Token: 0x06001232 RID: 4658 RVA: 0x0003D2E2 File Offset: 0x0003B4E2
		public virtual List<int> TriggerPointList
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TriggerPointList;
				}
				IExploreSkillMechascoutDrag_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TriggerPointList;
			}
			set
			{
				this.GetOrCreatePoco().TriggerPointList = value;
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06001233 RID: 4659 RVA: 0x0003D2F0 File Offset: 0x0003B4F0
		// (set) Token: 0x06001234 RID: 4660 RVA: 0x0003D383 File Offset: 0x0003B583
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> FinishedActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._FinishedActionsInited)
				{
					return this._FinishedActionsCache;
				}
				this._FinishedActionsInited = true;
				if (this.FbInstance != null)
				{
					List<Aki.TDConfigMgr.Action.Fb.ActionInfo> finishedActions = this.FbInstance.FinishedActions;
					if (finishedActions != null)
					{
						this._FinishedActionsCache = new List<Aki.TDConfigMgr.Action.ActionInfo>(finishedActions.Count);
						for (int i = 0; i < finishedActions.Count; i++)
						{
							this._FinishedActionsCache.Add(Aki.TDConfigMgr.Action.ActionInfo.Create(finishedActions[i]));
						}
					}
				}
				else
				{
					IExploreSkillMechascoutDrag_SetValue pocoInterface = this.PocoInterface;
					this._FinishedActionsCache = ((pocoInterface != null) ? pocoInterface.FinishedActions : null);
				}
				return this._FinishedActionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().FinishedActions = value;
				this._FinishedActionsInited = false;
			}
		}

		// Token: 0x04000F0A RID: 3850
		[Nullable(2)]
		protected new IExploreSkillMechascoutDrag FbInstance;

		// Token: 0x04000F0B RID: 3851
		[Nullable(2)]
		protected new IExploreSkillMechascoutDrag_SetValue PocoInterface;

		// Token: 0x04000F0C RID: 3852
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _FinishedActionsCache;

		// Token: 0x04000F0D RID: 3853
		private bool _FinishedActionsInited;
	}
}
