using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D9B RID: 3483
	public class IExploreSkillMechascoutDrag : IExploreSkillInteractType
	{
		// Token: 0x06004F29 RID: 20265 RVA: 0x000C4FAA File Offset: 0x000C31AA
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

		// Token: 0x170017EE RID: 6126
		// (get) Token: 0x06004F2A RID: 20266 RVA: 0x000C4FC9 File Offset: 0x000C31C9
		public override EExploreSkillInteractType Type
		{
			get
			{
				return (EExploreSkillInteractType)this.Instance.Type;
			}
		}

		// Token: 0x170017EF RID: 6127
		// (get) Token: 0x06004F2B RID: 20267 RVA: 0x000C4FD6 File Offset: 0x000C31D6
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

		// Token: 0x170017F0 RID: 6128
		// (get) Token: 0x06004F2C RID: 20268 RVA: 0x000C5008 File Offset: 0x000C3208
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

		// Token: 0x170017F1 RID: 6129
		// (get) Token: 0x06004F2D RID: 20269 RVA: 0x000C506C File Offset: 0x000C326C
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<ActionInfo> FinishedActions
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

		// Token: 0x04002CF8 RID: 11512
		private IExploreSkillMechascoutDrag Instance;

		// Token: 0x04002CF9 RID: 11513
		private IMechascoutDragTypeBase _DragTypeCache;

		// Token: 0x04002CFA RID: 11514
		private bool _DragTypeInited;

		// Token: 0x04002CFB RID: 11515
		private List<int> _TriggerPointListCache;

		// Token: 0x04002CFC RID: 11516
		private bool _TriggerPointListInited;

		// Token: 0x04002CFD RID: 11517
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _FinishedActionsCache;

		// Token: 0x04002CFE RID: 11518
		private bool _FinishedActionsInited;
	}
}
