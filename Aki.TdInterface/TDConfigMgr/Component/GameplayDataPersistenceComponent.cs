using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200017F RID: 383
	[NullableContext(1)]
	[Nullable(0)]
	public class GameplayDataPersistenceComponent : IComponentBase
	{
		// Token: 0x0600053E RID: 1342 RVA: 0x00020124 File Offset: 0x0001E324
		private GameplayDataPersistenceComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("GameplayDataPersistenceComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			GameplayDataPersistenceComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new GameplayDataPersistenceComponent_SetValue());
			}
			return result;
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x0002015C File Offset: 0x0001E35C
		public static GameplayDataPersistenceComponent Create([Nullable(2)] GameplayDataPersistenceComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new GameplayDataPersistenceComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x0002016F File Offset: 0x0001E36F
		public static GameplayDataPersistenceComponent CreateFromSetValue([Nullable(2)] GameplayDataPersistenceComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new GameplayDataPersistenceComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x00020182 File Offset: 0x0001E382
		public new GameplayDataPersistenceComponent_SetValue ToSetValue()
		{
			return new GameplayDataPersistenceComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				DataPersistenceGameplay = this.DataPersistenceGameplay
			};
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000542 RID: 1346 RVA: 0x000201B0 File Offset: 0x0001E3B0
		// (set) Token: 0x06000543 RID: 1347 RVA: 0x000201EA File Offset: 0x0001E3EA
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				GameplayDataPersistenceComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000544 RID: 1348 RVA: 0x000201F8 File Offset: 0x0001E3F8
		// (set) Token: 0x06000545 RID: 1349 RVA: 0x00020222 File Offset: 0x0001E422
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000546 RID: 1350 RVA: 0x00020230 File Offset: 0x0001E430
		// (set) Token: 0x06000547 RID: 1351 RVA: 0x00020291 File Offset: 0x0001E491
		public virtual IGameplayDataPersistenceTetrisBoardGame DataPersistenceGameplay
		{
			get
			{
				if (this._DataPersistenceGameplayInited)
				{
					return this._DataPersistenceGameplayCache;
				}
				this._DataPersistenceGameplayInited = true;
				if (this.FbInstance != null)
				{
					this._DataPersistenceGameplayCache = IGameplayDataPersistenceTetrisBoardGame.Create(this.FbInstance.DataPersistenceGameplay);
				}
				else
				{
					GameplayDataPersistenceComponent_SetValue pocoInterface = this.PocoInterface;
					this._DataPersistenceGameplayCache = ((pocoInterface != null) ? pocoInterface.DataPersistenceGameplay : null);
				}
				return this._DataPersistenceGameplayCache;
			}
			set
			{
				this.GetOrCreatePoco().DataPersistenceGameplay = value;
				this._DataPersistenceGameplayInited = false;
			}
		}

		// Token: 0x04000750 RID: 1872
		[Nullable(2)]
		protected new GameplayDataPersistenceComponent FbInstance;

		// Token: 0x04000751 RID: 1873
		[Nullable(2)]
		protected new GameplayDataPersistenceComponent_SetValue PocoInterface;

		// Token: 0x04000752 RID: 1874
		private IGameplayDataPersistenceTetrisBoardGame _DataPersistenceGameplayCache;

		// Token: 0x04000753 RID: 1875
		private bool _DataPersistenceGameplayInited;
	}
}
