using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EE6 RID: 3814
	public class GameplayDataPersistenceComponent : IComponentBase
	{
		// Token: 0x060055DD RID: 21981 RVA: 0x000D2C60 File Offset: 0x000D0E60
		public static GameplayDataPersistenceComponent Create(IGameplayDataPersistenceComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new GameplayDataPersistenceComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001C0C RID: 7180
		// (get) Token: 0x060055DE RID: 21982 RVA: 0x000D2C80 File Offset: 0x000D0E80
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x17001C0D RID: 7181
		// (get) Token: 0x060055DF RID: 21983 RVA: 0x000D2CB8 File Offset: 0x000D0EB8
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C0E RID: 7182
		// (get) Token: 0x060055E0 RID: 21984 RVA: 0x000D2CCE File Offset: 0x000D0ECE
		public virtual IGameplayDataPersistenceTetrisBoardGame DataPersistenceGameplay
		{
			get
			{
				if (this._DataPersistenceGameplayInited)
				{
					return this._DataPersistenceGameplayCache;
				}
				this._DataPersistenceGameplayInited = true;
				this._DataPersistenceGameplayCache = IGameplayDataPersistenceTetrisBoardGame.Create(this.Instance.DataPersistenceGameplay);
				return this._DataPersistenceGameplayCache;
			}
		}

		// Token: 0x0400311F RID: 12575
		private IGameplayDataPersistenceComponent Instance;

		// Token: 0x04003120 RID: 12576
		[Nullable(2)]
		private IGameplayDataPersistenceTetrisBoardGame _DataPersistenceGameplayCache;

		// Token: 0x04003121 RID: 12577
		private bool _DataPersistenceGameplayInited;
	}
}
