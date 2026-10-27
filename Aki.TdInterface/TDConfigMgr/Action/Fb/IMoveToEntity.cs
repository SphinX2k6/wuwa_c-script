using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200282B RID: 10283
	[NullableContext(1)]
	[Nullable(0)]
	public class IMoveToEntity : IMoveSceneItemType
	{
		// Token: 0x0600E40C RID: 58380 RVA: 0x00219559 File Offset: 0x00217759
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

		// Token: 0x17004578 RID: 17784
		// (get) Token: 0x0600E40D RID: 58381 RVA: 0x00219578 File Offset: 0x00217778
		public override EMoveSceneItemType Type
		{
			get
			{
				return (EMoveSceneItemType)this.Instance.Type;
			}
		}

		// Token: 0x17004579 RID: 17785
		// (get) Token: 0x0600E40E RID: 58382 RVA: 0x00219585 File Offset: 0x00217785
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x1700457A RID: 17786
		// (get) Token: 0x0600E40F RID: 58383 RVA: 0x00219592 File Offset: 0x00217792
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

		// Token: 0x04007E33 RID: 32307
		private IMoveToEntity Instance;

		// Token: 0x04007E34 RID: 32308
		private ISceneItemMoveMotionType _MoveMotionCache;

		// Token: 0x04007E35 RID: 32309
		private bool _MoveMotionInited;
	}
}
