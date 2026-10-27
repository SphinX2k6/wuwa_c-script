using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SeamlessTravel
{
	// Token: 0x02004C8C RID: 19596
	[NullableContext(2)]
	[Nullable(0)]
	[Model(0)]
	public class SeamlessTravelModel : ModelBase
	{
		// Token: 0x17007CFB RID: 31995
		// (get) Token: 0x06032A5A RID: 207450 RVA: 0x00BCF934 File Offset: 0x00BCDB34
		// (set) Token: 0x06032A5B RID: 207451 RVA: 0x00BCF93C File Offset: 0x00BCDB3C
		public bool IsSeamlessTravel
		{
			get
			{
				return this.IsSeamlessTravelInternal;
			}
			set
			{
				if (this.InSeamlessTraveling)
				{
					Log.Instance.Error(ELogModule.SeamlessTravel, ELogAuthor.CJH, "无缝加载中，禁止修改是否无缝加载", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				this.IsSeamlessTravelInternal = value;
			}
		}

		// Token: 0x06032A5C RID: 207452 RVA: 0x00BCF977 File Offset: 0x00BCDB77
		protected override bool OnClear()
		{
			this.ClearSeamlessTravelActor();
			return true;
		}

		// Token: 0x06032A5D RID: 207453 RVA: 0x00BCF980 File Offset: 0x00BCDB80
		public bool AddSeamlessTravelActor(AActor actor)
		{
			if (actor == null || !actor.IsValid())
			{
				Log.Instance.Error(ELogModule.SeamlessTravel, ELogAuthor.CJH, "[AddSeamlessTravelActor] Actor Invalid", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			this.SeamlessTravelActorList.Add(actor);
			UKuroStaticLibrary.SetActorPermanent(actor, true, true);
			return true;
		}

		// Token: 0x06032A5E RID: 207454 RVA: 0x00BCF9D4 File Offset: 0x00BCDBD4
		[NullableContext(1)]
		public bool RemoveSeamlessTravelActor(AActor actor)
		{
			if (actor == null || !actor.IsValid())
			{
				Log.Instance.Error(ELogModule.SeamlessTravel, ELogAuthor.CJH, "[RemoveSeamlessTravelActor] Actor Invalid", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			int num = this.SeamlessTravelActorList.IndexOf(actor);
			if (num >= 0)
			{
				this.SeamlessTravelActorList.RemoveAt(num);
			}
			UKuroStaticLibrary.SetActorPermanent(actor, false, true);
			return true;
		}

		// Token: 0x06032A5F RID: 207455 RVA: 0x00BCFA3C File Offset: 0x00BCDC3C
		[NullableContext(1)]
		public bool IsSeamlessTravelActor(AActor actor)
		{
			if (actor == null || !actor.IsValid())
			{
				Log.Instance.Error(ELogModule.SeamlessTravel, ELogAuthor.CJH, "[IsSeamlessTravelActor] Actor Invalid", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			return this.SeamlessTravelActorList.IndexOf(actor) >= 0;
		}

		// Token: 0x06032A60 RID: 207456 RVA: 0x00BCFA90 File Offset: 0x00BCDC90
		public EntityHandle GetSeamlessTravelRoleEntityHandle(long creatureDataId)
		{
			foreach (EntityHandle entityHandle in this.SeamlessTravelPlayerTeamHandles)
			{
				if (entityHandle.Entity.GetComponent<CreatureDataComponent>().GetCreatureDataId() == creatureDataId)
				{
					return entityHandle;
				}
			}
			return null;
		}

		// Token: 0x06032A61 RID: 207457 RVA: 0x00BCFAF8 File Offset: 0x00BCDCF8
		public void CreatePromise()
		{
			this.MeshAssetLoadedPromise = new GameModePromise();
			this.ScreenEffectStartedPromise = new GameModePromise();
			this.ScreenEffectEndedPromise = new GameModePromise();
			this.EnterTransitionMapPromise = new GameModePromise();
			this.EnterDestinationMapPromise = new GameModePromise();
			this.TransitionFloorLoadedPromise = new GameModePromise();
			this.TransitionFloorUnloadedPromise = new GameModePromise();
			this.KiteInitPromise = new GameModePromise();
			this.EffectAssetLoadedPromise = new GameModePromise();
			this.PostProcessAssetLoadedPromise = new GameModePromise();
			this.PostProcessBlendedInPromise = new GameModePromise();
			this.PostProcessBlendedOutPromise = new GameModePromise();
			this.SceneEffectAssetLoadedPromise = new GameModePromise();
			this.SceneEffectStartedPromise = new GameModePromise();
			this.SceneEffectEndedPromise = new GameModePromise();
		}

		// Token: 0x06032A62 RID: 207458 RVA: 0x00BCFBAC File Offset: 0x00BCDDAC
		public void ClearPromise()
		{
			this.MeshAssetLoadedPromise = null;
			this.ScreenEffectStartedPromise = null;
			this.ScreenEffectEndedPromise = null;
			this.EnterTransitionMapPromise = null;
			this.EnterDestinationMapPromise = null;
			this.TransitionFloorLoadedPromise = null;
			this.TransitionFloorUnloadedPromise = null;
			this.KiteInitPromise = null;
			this.EffectAssetLoadedPromise = null;
			this.PostProcessAssetLoadedPromise = null;
			this.PostProcessBlendedInPromise = null;
			this.PostProcessBlendedOutPromise = null;
			this.SceneEffectAssetLoadedPromise = null;
			this.SceneEffectStartedPromise = null;
			this.SceneEffectEndedPromise = null;
		}

		// Token: 0x06032A63 RID: 207459 RVA: 0x00BCFC24 File Offset: 0x00BCDE24
		public void ClearSeamlessTravelActor()
		{
			foreach (AActor aactor in this.SeamlessTravelActorList)
			{
				if (aactor.IsValid())
				{
					UKuroStaticLibrary.SetActorPermanent(aactor, false, false);
				}
			}
			this.SeamlessTravelActorList.Clear();
		}

		// Token: 0x06032A64 RID: 207460 RVA: 0x00BCFC8C File Offset: 0x00BCDE8C
		public bool GetIsKeepingCurrentMovementMode()
		{
			if (this.IsSeamlessTravel)
			{
				SeamlessTravelKeepMovementMode seamlessTravelKeepMovementMode = this.SeamlessTravelKeepMovementMode;
				if (seamlessTravelKeepMovementMode != null && seamlessTravelKeepMovementMode.IsActive)
				{
					TsBaseCharacter baseCharacter = Global.BaseCharacter;
					object obj;
					if (baseCharacter == null)
					{
						obj = null;
					}
					else
					{
						CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
						if (characterActorComponent == null)
						{
							obj = null;
						}
						else
						{
							BaseMoveComponent moveComp = characterActorComponent.MoveComp;
							obj = ((moveComp != null) ? moveComp.CharacterMovement : null);
						}
					}
					object obj2 = obj;
					TEnumAsByte<EMovementMode>? tenumAsByte = (obj2 != null) ? new TEnumAsByte<EMovementMode>?(obj2.MovementMode) : null;
					byte? b = (obj2 != null) ? new byte?(obj2.CustomMovementMode) : null;
					if (tenumAsByte == null || b == null)
					{
						return false;
					}
					EMovementMode? targetMovementMode = this.SeamlessTravelKeepMovementMode.TargetMovementMode;
					if (((targetMovementMode != null) ? new TEnumAsByte<EMovementMode>?(targetMovementMode.GetValueOrDefault()) : null) == tenumAsByte)
					{
						byte? b2 = this.SeamlessTravelKeepMovementMode.TargetCustomMode;
						int? num = (b2 != null) ? new int?((int)b2.GetValueOrDefault()) : null;
						b2 = b;
						int? num2 = (b2 != null) ? new int?((int)b2.GetValueOrDefault()) : null;
						return num.GetValueOrDefault() == num2.GetValueOrDefault() & num != null == (num2 != null);
					}
					return false;
				}
			}
			return false;
		}

		// Token: 0x17007CFC RID: 31996
		// (get) Token: 0x06032A65 RID: 207461 RVA: 0x00BCFE0E File Offset: 0x00BCE00E
		[Nullable(1)]
		public static SeamlessTravelModel Instance
		{
			[NullableContext(1)]
			get
			{
				return SeamlessTravelModel._Instance;
			}
		}

		// Token: 0x06032A66 RID: 207462 RVA: 0x00BCFE15 File Offset: 0x00BCE015
		[NullableContext(1)]
		public static SeamlessTravelModel GetOrCreateInstance()
		{
			if (SeamlessTravelModel._Instance == null)
			{
				SeamlessTravelModel.CreateInstance();
			}
			return SeamlessTravelModel._Instance;
		}

		// Token: 0x06032A67 RID: 207463 RVA: 0x00BCFE29 File Offset: 0x00BCE029
		public static bool CreateInstance()
		{
			if (SeamlessTravelModel._Instance != null)
			{
				return true;
			}
			SeamlessTravelModel._Instance = new SeamlessTravelModel();
			return true;
		}

		// Token: 0x06032A68 RID: 207464 RVA: 0x00BCFE3F File Offset: 0x00BCE03F
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06032A69 RID: 207465 RVA: 0x00BCFE41 File Offset: 0x00BCE041
		public static void ResetStaticDefaultValue()
		{
			SeamlessTravelModel._Instance = null;
		}

		// Token: 0x06032A6A RID: 207466 RVA: 0x00BCFE49 File Offset: 0x00BCE049
		static SeamlessTravelModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SeamlessTravelModel.CreateStaticDefaultValue), new Action(SeamlessTravelModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401AF26 RID: 110374
		private bool IsSeamlessTravelInternal;

		// Token: 0x0401AF27 RID: 110375
		public bool InSeamlessTraveling;

		// Token: 0x0401AF28 RID: 110376
		public bool HasPreEnableSeamlessTravel;

		// Token: 0x0401AF29 RID: 110377
		public TimerHandle SeamlessEndHandle;

		// Token: 0x0401AF2A RID: 110378
		public SeamlessTravelContext Config;

		// Token: 0x0401AF2B RID: 110379
		public APlayerController SeamlessTravelController;

		// Token: 0x0401AF2C RID: 110380
		public AController SeamlessTravelDefaultController;

		// Token: 0x0401AF2D RID: 110381
		[Nullable(1)]
		public List<AController> SeamlessTravelTeamDefaultController = new List<AController>();

		// Token: 0x0401AF2E RID: 110382
		public EntityHandle SeamlessTravelPlayerEntityHandle;

		// Token: 0x0401AF2F RID: 110383
		[Nullable(1)]
		public List<EntityHandle> SeamlessTravelPlayerTeamHandles = new List<EntityHandle>();

		// Token: 0x0401AF30 RID: 110384
		public ACameraActor SeamlessTravelCamera;

		// Token: 0x0401AF31 RID: 110385
		public SeamlessTravelScreenEffect SeamlessTravelScreenEffect;

		// Token: 0x0401AF32 RID: 110386
		public bool UseTreadmill;

		// Token: 0x0401AF33 RID: 110387
		public SeamlessTravelTreadmill SeamlessTravelTreadmill;

		// Token: 0x0401AF34 RID: 110388
		public bool UseKeepKite;

		// Token: 0x0401AF35 RID: 110389
		public SeamlessTravelKeepKite SeamlessTravelKeepKite;

		// Token: 0x0401AF36 RID: 110390
		public bool UseKeepMovementMode;

		// Token: 0x0401AF37 RID: 110391
		public SeamlessTravelKeepMovementMode SeamlessTravelKeepMovementMode;

		// Token: 0x0401AF38 RID: 110392
		public SeamlessTravelPostProcess SeamlessTravelPostProcess;

		// Token: 0x0401AF39 RID: 110393
		public SeamlessTravelSceneEffect SeamlessTravelSceneEffect;

		// Token: 0x0401AF3A RID: 110394
		[Nullable(1)]
		private readonly List<AActor> SeamlessTravelActorList = new List<AActor>();

		// Token: 0x0401AF3B RID: 110395
		[Nullable(1)]
		public List<string> SeamlessTravelInputDistributeTags = new List<string>();

		// Token: 0x0401AF3C RID: 110396
		public GameModePromise MeshAssetLoadedPromise;

		// Token: 0x0401AF3D RID: 110397
		public GameModePromise ScreenEffectStartedPromise;

		// Token: 0x0401AF3E RID: 110398
		public GameModePromise ScreenEffectEndedPromise;

		// Token: 0x0401AF3F RID: 110399
		public GameModePromise TransitionFloorLoadedPromise;

		// Token: 0x0401AF40 RID: 110400
		public GameModePromise EnterTransitionMapPromise;

		// Token: 0x0401AF41 RID: 110401
		public GameModePromise EnterDestinationMapPromise;

		// Token: 0x0401AF42 RID: 110402
		public GameModePromise TransitionFloorUnloadedPromise;

		// Token: 0x0401AF43 RID: 110403
		public GameModePromise EffectAssetLoadedPromise;

		// Token: 0x0401AF44 RID: 110404
		public GameModePromise KiteInitPromise;

		// Token: 0x0401AF45 RID: 110405
		public GameModePromise PostProcessAssetLoadedPromise;

		// Token: 0x0401AF46 RID: 110406
		public GameModePromise PostProcessBlendedInPromise;

		// Token: 0x0401AF47 RID: 110407
		public GameModePromise PostProcessBlendedOutPromise;

		// Token: 0x0401AF48 RID: 110408
		public GameModePromise SceneEffectAssetLoadedPromise;

		// Token: 0x0401AF49 RID: 110409
		public GameModePromise SceneEffectStartedPromise;

		// Token: 0x0401AF4A RID: 110410
		public GameModePromise SceneEffectEndedPromise;

		// Token: 0x0401AF4B RID: 110411
		private static SeamlessTravelModel _Instance;
	}
}
