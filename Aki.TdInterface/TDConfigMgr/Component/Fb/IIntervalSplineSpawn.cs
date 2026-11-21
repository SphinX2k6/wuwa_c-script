using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F1B RID: 3867
	[NullableContext(2)]
	[Nullable(0)]
	public class IIntervalSplineSpawn : IPathDrivenActorSpawnBase
	{
		// Token: 0x060056EF RID: 22255 RVA: 0x000D52B7 File Offset: 0x000D34B7
		[NullableContext(0)]
		public static IIntervalSplineSpawn Create(IIntervalSplineSpawn? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IIntervalSplineSpawn
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001CB4 RID: 7348
		// (get) Token: 0x060056F0 RID: 22256 RVA: 0x000D52D6 File Offset: 0x000D34D6
		public override EPathDrivenActorSpawnType Type
		{
			get
			{
				return (EPathDrivenActorSpawnType)this.Instance.Type;
			}
		}

		// Token: 0x17001CB5 RID: 7349
		// (get) Token: 0x060056F1 RID: 22257 RVA: 0x000D52E3 File Offset: 0x000D34E3
		[Nullable(0)]
		public virtual string ActorBlueprintPath
		{
			[NullableContext(0)]
			get
			{
				return this.Instance.ActorBlueprintPath;
			}
		}

		// Token: 0x17001CB6 RID: 7350
		// (get) Token: 0x060056F2 RID: 22258 RVA: 0x000D52F0 File Offset: 0x000D34F0
		[Nullable(0)]
		public virtual IPathDrivenActorSplineMove MoveMode
		{
			[NullableContext(0)]
			get
			{
				if (this._MoveModeInited)
				{
					return this._MoveModeCache;
				}
				this._MoveModeInited = true;
				this._MoveModeCache = IPathDrivenActorSplineMove.Create(this.Instance.MoveMode);
				return this._MoveModeCache;
			}
		}

		// Token: 0x17001CB7 RID: 7351
		// (get) Token: 0x060056F3 RID: 22259 RVA: 0x000D5324 File Offset: 0x000D3524
		public virtual float SpawnInterval
		{
			get
			{
				return this.Instance.SpawnInterval;
			}
		}

		// Token: 0x17001CB8 RID: 7352
		// (get) Token: 0x060056F4 RID: 22260 RVA: 0x000D5334 File Offset: 0x000D3534
		public virtual int? MaxActiveCount
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.MaxActiveCount);
			}
		}

		// Token: 0x17001CB9 RID: 7353
		// (get) Token: 0x060056F5 RID: 22261 RVA: 0x000D536C File Offset: 0x000D356C
		public virtual float? MaxSpawnInterval
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new float?(this.Instance.MaxSpawnInterval);
			}
		}

		// Token: 0x17001CBA RID: 7354
		// (get) Token: 0x060056F6 RID: 22262 RVA: 0x000D53A2 File Offset: 0x000D35A2
		public virtual IPathDrivenActorInitialSpawnConfig InitialSpawnConfig
		{
			get
			{
				if (this._InitialSpawnConfigInited)
				{
					return this._InitialSpawnConfigCache;
				}
				this._InitialSpawnConfigInited = true;
				this._InitialSpawnConfigCache = IPathDrivenActorInitialSpawnConfig.Create(this.Instance.InitialSpawnConfig);
				return this._InitialSpawnConfigCache;
			}
		}

		// Token: 0x17001CBB RID: 7355
		// (get) Token: 0x060056F7 RID: 22263 RVA: 0x000D53D6 File Offset: 0x000D35D6
		public virtual IIntervalSplineSpawnAllActorAudio AudioConfig
		{
			get
			{
				if (this._AudioConfigInited)
				{
					return this._AudioConfigCache;
				}
				this._AudioConfigInited = true;
				this._AudioConfigCache = IIntervalSplineSpawnAllActorAudio.Create(this.Instance.AudioConfig);
				return this._AudioConfigCache;
			}
		}

		// Token: 0x040031E0 RID: 12768
		private IIntervalSplineSpawn Instance;

		// Token: 0x040031E1 RID: 12769
		private IPathDrivenActorSplineMove _MoveModeCache;

		// Token: 0x040031E2 RID: 12770
		private bool _MoveModeInited;

		// Token: 0x040031E3 RID: 12771
		private IPathDrivenActorInitialSpawnConfig _InitialSpawnConfigCache;

		// Token: 0x040031E4 RID: 12772
		private bool _InitialSpawnConfigInited;

		// Token: 0x040031E5 RID: 12773
		private IIntervalSplineSpawnAllActorAudio _AudioConfigCache;

		// Token: 0x040031E6 RID: 12774
		private bool _AudioConfigInited;
	}
}
