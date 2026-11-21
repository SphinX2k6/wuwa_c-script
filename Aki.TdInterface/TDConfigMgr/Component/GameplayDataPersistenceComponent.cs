using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000196 RID: 406
	public class GameplayDataPersistenceComponent : IComponentBase
	{
		// Token: 0x06000552 RID: 1362 RVA: 0x00020D00 File Offset: 0x0001EF00
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

		// Token: 0x06000553 RID: 1363 RVA: 0x00020D38 File Offset: 0x0001EF38
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

		// Token: 0x06000554 RID: 1364 RVA: 0x00020D4B File Offset: 0x0001EF4B
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

		// Token: 0x06000555 RID: 1365 RVA: 0x00020D5E File Offset: 0x0001EF5E
		public new GameplayDataPersistenceComponent_SetValue ToSetValue()
		{
			return new GameplayDataPersistenceComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				DataPersistenceGameplay = this.DataPersistenceGameplay
			};
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000556 RID: 1366 RVA: 0x00020D8C File Offset: 0x0001EF8C
		// (set) Token: 0x06000557 RID: 1367 RVA: 0x00020DC6 File Offset: 0x0001EFC6
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

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000558 RID: 1368 RVA: 0x00020DD4 File Offset: 0x0001EFD4
		// (set) Token: 0x06000559 RID: 1369 RVA: 0x00020DFE File Offset: 0x0001EFFE
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

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x0600055A RID: 1370 RVA: 0x00020E0C File Offset: 0x0001F00C
		// (set) Token: 0x0600055B RID: 1371 RVA: 0x00020E6D File Offset: 0x0001F06D
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

		// Token: 0x040007A6 RID: 1958
		[Nullable(2)]
		protected new GameplayDataPersistenceComponent FbInstance;

		// Token: 0x040007A7 RID: 1959
		[Nullable(2)]
		protected new GameplayDataPersistenceComponent_SetValue PocoInterface;

		// Token: 0x040007A8 RID: 1960
		private IGameplayDataPersistenceTetrisBoardGame _DataPersistenceGameplayCache;

		// Token: 0x040007A9 RID: 1961
		private bool _DataPersistenceGameplayInited;
	}
}
