using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000354 RID: 852
	[NullableContext(1)]
	[Nullable(0)]
	public class IExploreSkillMechascoutDrag : IExploreSkillInteractType
	{
		// Token: 0x060010E5 RID: 4325 RVA: 0x00039ED4 File Offset: 0x000380D4
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

		// Token: 0x060010E6 RID: 4326 RVA: 0x00039F0C File Offset: 0x0003810C
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

		// Token: 0x060010E7 RID: 4327 RVA: 0x00039F1F File Offset: 0x0003811F
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

		// Token: 0x060010E8 RID: 4328 RVA: 0x00039F32 File Offset: 0x00038132
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

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x060010E9 RID: 4329 RVA: 0x00039F69 File Offset: 0x00038169
		// (set) Token: 0x060010EA RID: 4330 RVA: 0x00039F94 File Offset: 0x00038194
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

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x060010EB RID: 4331 RVA: 0x00039FA2 File Offset: 0x000381A2
		// (set) Token: 0x060010EC RID: 4332 RVA: 0x00039FC9 File Offset: 0x000381C9
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

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x060010ED RID: 4333 RVA: 0x00039FD7 File Offset: 0x000381D7
		// (set) Token: 0x060010EE RID: 4334 RVA: 0x00039FFE File Offset: 0x000381FE
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

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x060010EF RID: 4335 RVA: 0x0003A00C File Offset: 0x0003820C
		// (set) Token: 0x060010F0 RID: 4336 RVA: 0x0003A09F File Offset: 0x0003829F
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> FinishedActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().FinishedActions = value;
				this._FinishedActionsInited = false;
			}
		}

		// Token: 0x04000E13 RID: 3603
		[Nullable(2)]
		protected new IExploreSkillMechascoutDrag FbInstance;

		// Token: 0x04000E14 RID: 3604
		[Nullable(2)]
		protected new IExploreSkillMechascoutDrag_SetValue PocoInterface;

		// Token: 0x04000E15 RID: 3605
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _FinishedActionsCache;

		// Token: 0x04000E16 RID: 3606
		private bool _FinishedActionsInited;
	}
}
