using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AFE RID: 11006
	public class IMoveToEntity : IMoveSceneItemType
	{
		// Token: 0x0600F231 RID: 62001 RVA: 0x002363BD File Offset: 0x002345BD
		public static IMoveToEntity Create(IMoveToEntity? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMoveToEntity
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170048E3 RID: 18659
		// (get) Token: 0x0600F232 RID: 62002 RVA: 0x002363DC File Offset: 0x002345DC
		public override EMoveSceneItemType Type
		{
			get
			{
				return (EMoveSceneItemType)this.Instance.Type;
			}
		}

		// Token: 0x170048E4 RID: 18660
		// (get) Token: 0x0600F233 RID: 62003 RVA: 0x002363E9 File Offset: 0x002345E9
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x170048E5 RID: 18661
		// (get) Token: 0x0600F234 RID: 62004 RVA: 0x002363F6 File Offset: 0x002345F6
		public virtual ISceneItemMoveMotionType MoveMotion
		{
			get
			{
				if (this._MoveMotionInited)
				{
					return this._MoveMotionCache;
				}
				this._MoveMotionInited = true;
				this._MoveMotionCache = ActionReadHelper.ReadIMoveToEntity_MoveMotion(this.Instance);
				return this._MoveMotionCache;
			}
		}

		// Token: 0x040084F0 RID: 34032
		private IMoveToEntity Instance;

		// Token: 0x040084F1 RID: 34033
		private ISceneItemMoveMotionType _MoveMotionCache;

		// Token: 0x040084F2 RID: 34034
		private bool _MoveMotionInited;
	}
}
