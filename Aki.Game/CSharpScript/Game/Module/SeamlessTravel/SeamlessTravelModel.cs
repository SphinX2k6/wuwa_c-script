using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SeamlessTravel
{
	// Token: 0x02003C3D RID: 15421
	[NullableContext(2)]
	[Nullable(0)]
	[Model(0)]
	public class SeamlessTravelModel : ModelBase
	{
		// Token: 0x170050A5 RID: 20645
		// (get) Token: 0x0602780D RID: 161805 RVA: 0x00B14598 File Offset: 0x00B12798
		// (set) Token: 0x0602780E RID: 161806 RVA: 0x00B145A0 File Offset: 0x00B127A0
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

		// Token: 0x0602780F RID: 161807 RVA: 0x00B145DB File Offset: 0x00B127DB
		protected override bool OnClear()
		{
			this.ClearSeamlessTravelActor();
			return true;
		}

		// Token: 0x06027810 RID: 161808 RVA: 0x00B145E4 File Offset: 0x00B127E4
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

		// Token: 0x06027811 RID: 161809 RVA: 0x00B14638 File Offset: 0x00B12838
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

		// Token: 0x06027812 RID: 161810 RVA: 0x00B146A0 File Offset: 0x00B128A0
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

		// Token: 0x06027813 RID: 161811 RVA: 0x00B146F4 File Offset: 0x00B128F4
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

		// Token: 0x06027814 RID: 161812 RVA: 0x00B1475C File Offset: 0x00B1295C
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

		// Token: 0x06027815 RID: 161813 RVA: 0x00B14810 File Offset: 0x00B12A10
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

		// Token: 0x06027816 RID: 161814 RVA: 0x00B14888 File Offset: 0x00B12A88
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

		// Token: 0x06027817 RID: 161815 RVA: 0x00B148F0 File Offset: 0x00B12AF0
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

		// Token: 0x170050A6 RID: 20646
		// (get) Token: 0x06027818 RID: 161816 RVA: 0x00B14A72 File Offset: 0x00B12C72
		[Nullable(1)]
		public static SeamlessTravelModel Instance
		{
			[NullableContext(1)]
			get
			{
				return SeamlessTravelModel._Instance;
			}
		}

		// Token: 0x06027819 RID: 161817 RVA: 0x00B14A79 File Offset: 0x00B12C79
		[NullableContext(1)]
		public static SeamlessTravelModel GetOrCreateInstance()
		{
			if (SeamlessTravelModel._Instance == null)
			{
				SeamlessTravelModel.CreateInstance();
			}
			return SeamlessTravelModel._Instance;
		}

		// Token: 0x0602781A RID: 161818 RVA: 0x00B14A8D File Offset: 0x00B12C8D
		public static bool CreateInstance()
		{
			if (SeamlessTravelModel._Instance != null)
			{
				return true;
			}
			SeamlessTravelModel._Instance = new SeamlessTravelModel();
			return true;
		}

		// Token: 0x0602781B RID: 161819 RVA: 0x00B14AA3 File Offset: 0x00B12CA3
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602781C RID: 161820 RVA: 0x00B14AA5 File Offset: 0x00B12CA5
		public static void ResetStaticDefaultValue()
		{
			SeamlessTravelModel._Instance = null;
		}

		// Token: 0x0602781D RID: 161821 RVA: 0x00B14AAD File Offset: 0x00B12CAD
		static SeamlessTravelModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SeamlessTravelModel.CreateStaticDefaultValue), new Action(SeamlessTravelModel.ResetStaticDefaultValue));
		}

		// Token: 0x04015883 RID: 88195
		private bool IsSeamlessTravelInternal;

		// Token: 0x04015884 RID: 88196
		public bool InSeamlessTraveling;

		// Token: 0x04015885 RID: 88197
		public bool HasPreEnableSeamlessTravel;

		// Token: 0x04015886 RID: 88198
		public TimerHandle SeamlessEndHandle;

		// Token: 0x04015887 RID: 88199
		public SeamlessTravelContext Config;

		// Token: 0x04015888 RID: 88200
		public APlayerController SeamlessTravelController;

		// Token: 0x04015889 RID: 88201
		public AController SeamlessTravelDefaultController;

		// Token: 0x0401588A RID: 88202
		[Nullable(1)]
		public List<AController> SeamlessTravelTeamDefaultController = new List<AController>();

		// Token: 0x0401588B RID: 88203
		public EntityHandle SeamlessTravelPlayerEntityHandle;

		// Token: 0x0401588C RID: 88204
		[Nullable(1)]
		public List<EntityHandle> SeamlessTravelPlayerTeamHandles = new List<EntityHandle>();

		// Token: 0x0401588D RID: 88205
		public ACameraActor SeamlessTravelCamera;

		// Token: 0x0401588E RID: 88206
		public SeamlessTravelScreenEffect SeamlessTravelScreenEffect;

		// Token: 0x0401588F RID: 88207
		public bool UseTreadmill;

		// Token: 0x04015890 RID: 88208
		public SeamlessTravelTreadmill SeamlessTravelTreadmill;

		// Token: 0x04015891 RID: 88209
		public bool UseKeepKite;

		// Token: 0x04015892 RID: 88210
		public SeamlessTravelKeepKite SeamlessTravelKeepKite;

		// Token: 0x04015893 RID: 88211
		public bool UseKeepMovementMode;

		// Token: 0x04015894 RID: 88212
		public SeamlessTravelKeepMovementMode SeamlessTravelKeepMovementMode;

		// Token: 0x04015895 RID: 88213
		public SeamlessTravelPostProcess SeamlessTravelPostProcess;

		// Token: 0x04015896 RID: 88214
		public SeamlessTravelSceneEffect SeamlessTravelSceneEffect;

		// Token: 0x04015897 RID: 88215
		[Nullable(1)]
		private readonly List<AActor> SeamlessTravelActorList = new List<AActor>();

		// Token: 0x04015898 RID: 88216
		[Nullable(1)]
		public List<string> SeamlessTravelInputDistributeTags = new List<string>();

		// Token: 0x04015899 RID: 88217
		public GameModePromise MeshAssetLoadedPromise;

		// Token: 0x0401589A RID: 88218
		public GameModePromise ScreenEffectStartedPromise;

		// Token: 0x0401589B RID: 88219
		public GameModePromise ScreenEffectEndedPromise;

		// Token: 0x0401589C RID: 88220
		public GameModePromise TransitionFloorLoadedPromise;

		// Token: 0x0401589D RID: 88221
		public GameModePromise EnterTransitionMapPromise;

		// Token: 0x0401589E RID: 88222
		public GameModePromise EnterDestinationMapPromise;

		// Token: 0x0401589F RID: 88223
		public GameModePromise TransitionFloorUnloadedPromise;

		// Token: 0x040158A0 RID: 88224
		public GameModePromise EffectAssetLoadedPromise;

		// Token: 0x040158A1 RID: 88225
		public GameModePromise KiteInitPromise;

		// Token: 0x040158A2 RID: 88226
		public GameModePromise PostProcessAssetLoadedPromise;

		// Token: 0x040158A3 RID: 88227
		public GameModePromise PostProcessBlendedInPromise;

		// Token: 0x040158A4 RID: 88228
		public GameModePromise PostProcessBlendedOutPromise;

		// Token: 0x040158A5 RID: 88229
		public GameModePromise SceneEffectAssetLoadedPromise;

		// Token: 0x040158A6 RID: 88230
		public GameModePromise SceneEffectStartedPromise;

		// Token: 0x040158A7 RID: 88231
		public GameModePromise SceneEffectEndedPromise;

		// Token: 0x040158A8 RID: 88232
		private static SeamlessTravelModel _Instance;
	}
}
