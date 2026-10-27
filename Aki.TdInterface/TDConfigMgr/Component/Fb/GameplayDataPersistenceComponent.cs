using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DEA RID: 3562
	[NullableContext(1)]
	[Nullable(0)]
	public class GameplayDataPersistenceComponent : IComponentBase
	{
		// Token: 0x060050B6 RID: 20662 RVA: 0x000C7398 File Offset: 0x000C5598
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

		// Token: 0x17001A9F RID: 6815
		// (get) Token: 0x060050B7 RID: 20663 RVA: 0x000C73B8 File Offset: 0x000C55B8
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

		// Token: 0x17001AA0 RID: 6816
		// (get) Token: 0x060050B8 RID: 20664 RVA: 0x000C73F0 File Offset: 0x000C55F0
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001AA1 RID: 6817
		// (get) Token: 0x060050B9 RID: 20665 RVA: 0x000C7406 File Offset: 0x000C5606
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

		// Token: 0x04002E57 RID: 11863
		private IGameplayDataPersistenceComponent Instance;

		// Token: 0x04002E58 RID: 11864
		[Nullable(2)]
		private IGameplayDataPersistenceTetrisBoardGame _DataPersistenceGameplayCache;

		// Token: 0x04002E59 RID: 11865
		private bool _DataPersistenceGameplayInited;
	}
}
