using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CB9 RID: 3257
	[NullableContext(1)]
	[Nullable(0)]
	public class IExploreSkillMechascoutDrag : IExploreSkillInteractType
	{
		// Token: 0x06004A7B RID: 19067 RVA: 0x000BA59A File Offset: 0x000B879A
		public static IExploreSkillMechascoutDrag Create(IExploreSkillMechascoutDrag? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExploreSkillMechascoutDrag
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170016C6 RID: 5830
		// (get) Token: 0x06004A7C RID: 19068 RVA: 0x000BA5B9 File Offset: 0x000B87B9
		public override EExploreSkillInteractType Type
		{
			get
			{
				return (EExploreSkillInteractType)this.Instance.Type;
			}
		}

		// Token: 0x170016C7 RID: 5831
		// (get) Token: 0x06004A7D RID: 19069 RVA: 0x000BA5C6 File Offset: 0x000B87C6
		public virtual IMechascoutDragTypeBase DragType
		{
			get
			{
				if (this._DragTypeInited)
				{
					return this._DragTypeCache;
				}
				this._DragTypeInited = true;
				this._DragTypeCache = ComponentReadHelper.ReadIExploreSkillMechascoutDrag_DragType(this.Instance);
				return this._DragTypeCache;
			}
		}

		// Token: 0x170016C8 RID: 5832
		// (get) Token: 0x06004A7E RID: 19070 RVA: 0x000BA5F8 File Offset: 0x000B87F8
		public virtual List<int> TriggerPointList
		{
			get
			{
				if (this._TriggerPointListInited)
				{
					return this._TriggerPointListCache;
				}
				this._TriggerPointListInited = true;
				int triggerPointListLength = this.Instance.TriggerPointListLength;
				this._TriggerPointListCache = new List<int>(triggerPointListLength);
				for (int i = 0; i < triggerPointListLength; i++)
				{
					this._TriggerPointListCache.Add(this.Instance.TriggerPointList(i));
				}
				return this._TriggerPointListCache;
			}
		}

		// Token: 0x170016C9 RID: 5833
		// (get) Token: 0x06004A7F RID: 19071 RVA: 0x000BA65C File Offset: 0x000B885C
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ActionInfo> FinishedActions
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
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int finishedActionsLength = this.Instance.FinishedActionsLength;
				this._FinishedActionsCache = new List<ActionInfo>(finishedActionsLength);
				for (int i = 0; i < finishedActionsLength; i++)
				{
					this._FinishedActionsCache.Add(ActionInfo.Create(this.Instance.FinishedActions(i)));
				}
				return this._FinishedActionsCache;
			}
		}

		// Token: 0x04002A7E RID: 10878
		private IExploreSkillMechascoutDrag Instance;

		// Token: 0x04002A7F RID: 10879
		private IMechascoutDragTypeBase _DragTypeCache;

		// Token: 0x04002A80 RID: 10880
		private bool _DragTypeInited;

		// Token: 0x04002A81 RID: 10881
		private List<int> _TriggerPointListCache;

		// Token: 0x04002A82 RID: 10882
		private bool _TriggerPointListInited;

		// Token: 0x04002A83 RID: 10883
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _FinishedActionsCache;

		// Token: 0x04002A84 RID: 10884
		private bool _FinishedActionsInited;
	}
}
