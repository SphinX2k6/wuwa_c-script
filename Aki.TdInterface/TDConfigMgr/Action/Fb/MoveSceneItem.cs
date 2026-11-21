using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AFF RID: 11007
	public class MoveSceneItem : ActionParams
	{
		// Token: 0x0600F236 RID: 62006 RVA: 0x0023642D File Offset: 0x0023462D
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

		// Token: 0x170048E6 RID: 18662
		// (get) Token: 0x0600F237 RID: 62007 RVA: 0x0023644C File Offset: 0x0023464C
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x170048E7 RID: 18663
		// (get) Token: 0x0600F238 RID: 62008 RVA: 0x0023645C File Offset: 0x0023465C
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

		// Token: 0x170048E8 RID: 18664
		// (get) Token: 0x0600F239 RID: 62009 RVA: 0x00236492 File Offset: 0x00234692
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

		// Token: 0x170048E9 RID: 18665
		// (get) Token: 0x0600F23A RID: 62010 RVA: 0x002364C4 File Offset: 0x002346C4
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

		// Token: 0x040084F3 RID: 34035
		private IMoveSceneItem Instance;

		// Token: 0x040084F4 RID: 34036
		private IMoveSceneItemType _MoveConfigCache;

		// Token: 0x040084F5 RID: 34037
		private bool _MoveConfigInited;
	}
}
