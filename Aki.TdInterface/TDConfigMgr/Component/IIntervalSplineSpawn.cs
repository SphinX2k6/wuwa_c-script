using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000497 RID: 1175
	[NullableContext(1)]
	[Nullable(0)]
	public class IIntervalSplineSpawn : IPathDrivenActorSpawnBase
	{
		// Token: 0x060017A6 RID: 6054 RVA: 0x00047614 File Offset: 0x00045814
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

		// Token: 0x060017A7 RID: 6055 RVA: 0x0004764C File Offset: 0x0004584C
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

		// Token: 0x060017A8 RID: 6056 RVA: 0x0004765F File Offset: 0x0004585F
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

		// Token: 0x060017A9 RID: 6057 RVA: 0x00047674 File Offset: 0x00045874
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

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x060017AA RID: 6058 RVA: 0x000476E6 File Offset: 0x000458E6
		// (set) Token: 0x060017AB RID: 6059 RVA: 0x00047711 File Offset: 0x00045911
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

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x060017AC RID: 6060 RVA: 0x0004771F File Offset: 0x0004591F
		// (set) Token: 0x060017AD RID: 6061 RVA: 0x0004774A File Offset: 0x0004594A
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

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x060017AE RID: 6062 RVA: 0x00047758 File Offset: 0x00045958
		// (set) Token: 0x060017AF RID: 6063 RVA: 0x000477B9 File Offset: 0x000459B9
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

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x060017B0 RID: 6064 RVA: 0x000477CE File Offset: 0x000459CE
		// (set) Token: 0x060017B1 RID: 6065 RVA: 0x000477FD File Offset: 0x000459FD
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

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x060017B2 RID: 6066 RVA: 0x0004780C File Offset: 0x00045A0C
		// (set) Token: 0x060017B3 RID: 6067 RVA: 0x00047846 File Offset: 0x00045A46
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

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x060017B4 RID: 6068 RVA: 0x00047854 File Offset: 0x00045A54
		// (set) Token: 0x060017B5 RID: 6069 RVA: 0x0004788E File Offset: 0x00045A8E
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

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x060017B6 RID: 6070 RVA: 0x0004789C File Offset: 0x00045A9C
		// (set) Token: 0x060017B7 RID: 6071 RVA: 0x000478FD File Offset: 0x00045AFD
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

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x060017B8 RID: 6072 RVA: 0x00047914 File Offset: 0x00045B14
		// (set) Token: 0x060017B9 RID: 6073 RVA: 0x00047975 File Offset: 0x00045B75
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

		// Token: 0x040011A8 RID: 4520
		[Nullable(2)]
		protected new IIntervalSplineSpawn FbInstance;

		// Token: 0x040011A9 RID: 4521
		[Nullable(2)]
		protected new IIntervalSplineSpawn_SetValue PocoInterface;

		// Token: 0x040011AA RID: 4522
		private IPathDrivenActorSplineMove _MoveModeCache;

		// Token: 0x040011AB RID: 4523
		private bool _MoveModeInited;

		// Token: 0x040011AC RID: 4524
		private IPathDrivenActorInitialSpawnConfig _InitialSpawnConfigCache;

		// Token: 0x040011AD RID: 4525
		private bool _InitialSpawnConfigInited;

		// Token: 0x040011AE RID: 4526
		private IIntervalSplineSpawnAllActorAudio _AudioConfigCache;

		// Token: 0x040011AF RID: 4527
		private bool _AudioConfigInited;
	}
}
