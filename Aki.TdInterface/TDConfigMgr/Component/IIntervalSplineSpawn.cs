using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004F0 RID: 1264
	public class IIntervalSplineSpawn : IPathDrivenActorSpawnBase
	{
		// Token: 0x06001940 RID: 6464 RVA: 0x0004B35C File Offset: 0x0004955C
		private IIntervalSplineSpawn_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IIntervalSplineSpawn 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IIntervalSplineSpawn_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IIntervalSplineSpawn_SetValue());
			}
			return result;
		}

		// Token: 0x06001941 RID: 6465 RVA: 0x0004B394 File Offset: 0x00049594
		public static IIntervalSplineSpawn Create([Nullable(2)] IIntervalSplineSpawn instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IIntervalSplineSpawn
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001942 RID: 6466 RVA: 0x0004B3A7 File Offset: 0x000495A7
		public static IIntervalSplineSpawn CreateFromSetValue([Nullable(2)] IIntervalSplineSpawn_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IIntervalSplineSpawn
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001943 RID: 6467 RVA: 0x0004B3BC File Offset: 0x000495BC
		public new IIntervalSplineSpawn_SetValue ToSetValue()
		{
			return new IIntervalSplineSpawn_SetValue
			{
				Type = this.Type,
				ActorBlueprintPath = this.ActorBlueprintPath,
				MoveMode = this.MoveMode,
				SpawnInterval = this.SpawnInterval,
				MaxActiveCount = this.MaxActiveCount,
				MaxSpawnInterval = this.MaxSpawnInterval,
				InitialSpawnConfig = this.InitialSpawnConfig,
				AudioConfig = this.AudioConfig
			};
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x06001944 RID: 6468 RVA: 0x0004B42E File Offset: 0x0004962E
		// (set) Token: 0x06001945 RID: 6469 RVA: 0x0004B459 File Offset: 0x00049659
		public override EPathDrivenActorSpawnType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPathDrivenActorSpawnType.IntervalSplineSpawn;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x06001946 RID: 6470 RVA: 0x0004B467 File Offset: 0x00049667
		// (set) Token: 0x06001947 RID: 6471 RVA: 0x0004B492 File Offset: 0x00049692
		public virtual string ActorBlueprintPath
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ActorBlueprintPath;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.ActorBlueprintPath;
			}
			set
			{
				this.GetOrCreatePoco().ActorBlueprintPath = value;
			}
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x06001948 RID: 6472 RVA: 0x0004B4A0 File Offset: 0x000496A0
		// (set) Token: 0x06001949 RID: 6473 RVA: 0x0004B501 File Offset: 0x00049701
		public virtual IPathDrivenActorSplineMove MoveMode
		{
			get
			{
				if (this._MoveModeInited)
				{
					return this._MoveModeCache;
				}
				this._MoveModeInited = true;
				if (this.FbInstance != null)
				{
					this._MoveModeCache = IPathDrivenActorSplineMove.Create(this.FbInstance.MoveMode);
				}
				else
				{
					IIntervalSplineSpawn_SetValue pocoInterface = this.PocoInterface;
					this._MoveModeCache = ((pocoInterface != null) ? pocoInterface.MoveMode : null);
				}
				return this._MoveModeCache;
			}
			set
			{
				this.GetOrCreatePoco().MoveMode = value;
				this._MoveModeInited = false;
			}
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x0600194A RID: 6474 RVA: 0x0004B516 File Offset: 0x00049716
		// (set) Token: 0x0600194B RID: 6475 RVA: 0x0004B545 File Offset: 0x00049745
		public virtual float SpawnInterval
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SpawnInterval;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.SpawnInterval;
			}
			set
			{
				this.GetOrCreatePoco().SpawnInterval = value;
			}
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x0600194C RID: 6476 RVA: 0x0004B554 File Offset: 0x00049754
		// (set) Token: 0x0600194D RID: 6477 RVA: 0x0004B58E File Offset: 0x0004978E
		public virtual int? MaxActiveCount
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxActiveCount;
				}
				IIntervalSplineSpawn_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MaxActiveCount;
			}
			set
			{
				this.GetOrCreatePoco().MaxActiveCount = value;
			}
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x0600194E RID: 6478 RVA: 0x0004B59C File Offset: 0x0004979C
		// (set) Token: 0x0600194F RID: 6479 RVA: 0x0004B5D6 File Offset: 0x000497D6
		public virtual float? MaxSpawnInterval
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxSpawnInterval;
				}
				IIntervalSplineSpawn_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MaxSpawnInterval;
			}
			set
			{
				this.GetOrCreatePoco().MaxSpawnInterval = value;
			}
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x06001950 RID: 6480 RVA: 0x0004B5E4 File Offset: 0x000497E4
		// (set) Token: 0x06001951 RID: 6481 RVA: 0x0004B645 File Offset: 0x00049845
		[Nullable(2)]
		public virtual IPathDrivenActorInitialSpawnConfig InitialSpawnConfig
		{
			[NullableContext(2)]
			get
			{
				if (this._InitialSpawnConfigInited)
				{
					return this._InitialSpawnConfigCache;
				}
				this._InitialSpawnConfigInited = true;
				if (this.FbInstance != null)
				{
					this._InitialSpawnConfigCache = IPathDrivenActorInitialSpawnConfig.Create(this.FbInstance.InitialSpawnConfig);
				}
				else
				{
					IIntervalSplineSpawn_SetValue pocoInterface = this.PocoInterface;
					this._InitialSpawnConfigCache = ((pocoInterface != null) ? pocoInterface.InitialSpawnConfig : null);
				}
				return this._InitialSpawnConfigCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().InitialSpawnConfig = value;
				this._InitialSpawnConfigInited = false;
			}
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x06001952 RID: 6482 RVA: 0x0004B65C File Offset: 0x0004985C
		// (set) Token: 0x06001953 RID: 6483 RVA: 0x0004B6BD File Offset: 0x000498BD
		[Nullable(2)]
		public virtual IIntervalSplineSpawnAllActorAudio AudioConfig
		{
			[NullableContext(2)]
			get
			{
				if (this._AudioConfigInited)
				{
					return this._AudioConfigCache;
				}
				this._AudioConfigInited = true;
				if (this.FbInstance != null)
				{
					this._AudioConfigCache = IIntervalSplineSpawnAllActorAudio.Create(this.FbInstance.AudioConfig);
				}
				else
				{
					IIntervalSplineSpawn_SetValue pocoInterface = this.PocoInterface;
					this._AudioConfigCache = ((pocoInterface != null) ? pocoInterface.AudioConfig : null);
				}
				return this._AudioConfigCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().AudioConfig = value;
				this._AudioConfigInited = false;
			}
		}

		// Token: 0x040012CA RID: 4810
		[Nullable(2)]
		protected new IIntervalSplineSpawn FbInstance;

		// Token: 0x040012CB RID: 4811
		[Nullable(2)]
		protected new IIntervalSplineSpawn_SetValue PocoInterface;

		// Token: 0x040012CC RID: 4812
		private IPathDrivenActorSplineMove _MoveModeCache;

		// Token: 0x040012CD RID: 4813
		private bool _MoveModeInited;

		// Token: 0x040012CE RID: 4814
		private IPathDrivenActorInitialSpawnConfig _InitialSpawnConfigCache;

		// Token: 0x040012CF RID: 4815
		private bool _InitialSpawnConfigInited;

		// Token: 0x040012D0 RID: 4816
		private IIntervalSplineSpawnAllActorAudio _AudioConfigCache;

		// Token: 0x040012D1 RID: 4817
		private bool _AudioConfigInited;
	}
}
