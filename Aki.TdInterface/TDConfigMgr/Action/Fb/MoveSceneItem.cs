using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200282C RID: 10284
	[NullableContext(1)]
	[Nullable(0)]
	public class MoveSceneItem : ActionParams
	{
		// Token: 0x0600E411 RID: 58385 RVA: 0x002195C9 File Offset: 0x002177C9
		public static MoveSceneItem Create(IMoveSceneItem? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new MoveSceneItem
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700457B RID: 17787
		// (get) Token: 0x0600E412 RID: 58386 RVA: 0x002195E8 File Offset: 0x002177E8
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x1700457C RID: 17788
		// (get) Token: 0x0600E413 RID: 58387 RVA: 0x002195F8 File Offset: 0x002177F8
		public virtual bool? StopBeforeMove
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.StopBeforeMove);
			}
		}

		// Token: 0x1700457D RID: 17789
		// (get) Token: 0x0600E414 RID: 58388 RVA: 0x0021962E File Offset: 0x0021782E
		public virtual IMoveSceneItemType MoveConfig
		{
			get
			{
				if (this._MoveConfigInited)
				{
					return this._MoveConfigCache;
				}
				this._MoveConfigInited = true;
				this._MoveConfigCache = ActionReadHelper.ReadMoveSceneItem_MoveConfig(this.Instance);
				return this._MoveConfigCache;
			}
		}

		// Token: 0x1700457E RID: 17790
		// (get) Token: 0x0600E415 RID: 58389 RVA: 0x00219660 File Offset: 0x00217860
		public virtual bool? BypassClientResponse
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.BypassClientResponse);
			}
		}

		// Token: 0x04007E36 RID: 32310
		private IMoveSceneItem Instance;

		// Token: 0x04007E37 RID: 32311
		private IMoveSceneItemType _MoveConfigCache;

		// Token: 0x04007E38 RID: 32312
		private bool _MoveConfigInited;
	}
}
