using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Entity;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Entity.Component;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.FSM;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.FSM.State;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Playback;
using CSharpScript.Game.Module.ActivityGamePlay.ActivityGameplayEntity;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf.Collections;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020056A8 RID: 22184
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlBattleManager
	{
		// Token: 0x170069AF RID: 27055
		// (get) Token: 0x06036C57 RID: 224343 RVA: 0x00F48905 File Offset: 0x00F46B05
		// (set) Token: 0x06036C58 RID: 224344 RVA: 0x00F4890D File Offset: 0x00F46B0D
		public bool IsForceEnterFinalState { get; private set; }

		// Token: 0x170069B0 RID: 27056
		// (get) Token: 0x06036C59 RID: 224345 RVA: 0x00F48916 File Offset: 0x00F46B16
		// (set) Token: 0x06036C5A RID: 224346 RVA: 0x00F4891E File Offset: 0x00F46B1E
		public bool IsLeavingBattle { get; private set; }

		// Token: 0x06036C5B RID: 224347 RVA: 0x00F48927 File Offset: 0x00F46B27
		public void SetIsLeavingBattle(bool value)
		{
			this.IsLeavingBattle = value;
		}

		// Token: 0x170069B1 RID: 27057
		// (get) Token: 0x06036C5C RID: 224348 RVA: 0x00F48930 File Offset: 0x00F46B30
		// (set) Token: 0x06036C5D RID: 224349 RVA: 0x00F48938 File Offset: 0x00F46B38
		public bool HasEnteredAdditionRound { get; private set; }

		// Token: 0x06036C5E RID: 224350 RVA: 0x00F48941 File Offset: 0x00F46B41
		public void SetForceEnterFinalState(bool force)
		{
			this.IsForceEnterFinalState = force;
		}

		// Token: 0x06036C5F RID: 224351 RVA: 0x00F4894A File Offset: 0x00F46B4A
		public void SetHasEnteredAdditionRound(bool value)
		{
			this.HasEnteredAdditionRound = value;
		}

		// Token: 0x170069B2 RID: 27058
		// (get) Token: 0x06036C60 RID: 224352 RVA: 0x00F48953 File Offset: 0x00F46B53
		// (set) Token: 0x06036C61 RID: 224353 RVA: 0x00F4895B File Offset: 0x00F46B5B
		public int Round
		{
			get
			{
				return this.RoundInternal;
			}
			set
			{
				this.RoundInternal = value;
			}
		}

		// Token: 0x06036C62 RID: 224354 RVA: 0x00F48964 File Offset: 0x00F46B64
		public void Init()
		{
			this.BattleFsm = new DangoBrawlFsm();
			this.BattleFsm.Init();
			this.Damage = new DangoBrawlDamageReporter();
			this.HasEnteredAdditionRound = false;
		}

		// Token: 0x06036C63 RID: 224355 RVA: 0x00F48990 File Offset: 0x00F46B90
		public void Destroy()
		{
			this.DestroyEntity(true);
			this.DestroyEntity(false);
			this.ClearTimerSystem();
			DangoBrawlFsm battleFsm = this.BattleFsm;
			if (battleFsm != null)
			{
				battleFsm.Clear();
			}
			this.BattleFsm = null;
			this.DestroyBattleReportPlayer();
			DangoBrawlDamageReporter damage = this.Damage;
			if (damage != null)
			{
				damage.Reset();
			}
			this.Damage = null;
			DangoBrawlModel.Instance.ResetPlayRate();
			this.IsForceEnterFinalState = false;
			this.HasEnteredAdditionRound = false;
		}

		// Token: 0x06036C64 RID: 224356 RVA: 0x00F489FF File Offset: 0x00F46BFF
		public void DestroyBattleReportPlayer()
		{
			if (this.BattleReportPlayer == null)
			{
				return;
			}
			this.BattleReportPlayer.Destroy();
			this.BattleReportPlayer = null;
		}

		// Token: 0x06036C65 RID: 224357 RVA: 0x00F48A1C File Offset: 0x00F46C1C
		public void OnBaseNotify(DangoBrawlInstBaseNotify resp)
		{
			int selfId = this.SelfId;
			int opponentId = this.OpponentId;
			int roleId = resp.RoleId;
			int opponentId2 = resp.OpponentId;
			this.SelfId = roleId;
			this.OpponentId = opponentId2;
			this.ChallengeId = resp.ChallengeId;
			this.Round = resp.RoundNum;
			this.Coin = resp.Coin;
			this.WinCount = resp.WinCount;
			this.LoseCount = resp.LoseCount;
			this.IsRestoreFight = (resp.Phase == DangoBrawlPhase.FightRestore);
			this.RefreshHasEnteredAdditionRound(resp.WinCount);
			bool flag = selfId != roleId;
			if (flag)
			{
				this.CreateEntity(roleId, true);
			}
			bool flag2 = opponentId != opponentId2;
			if (flag2)
			{
				this.CreateEntity(opponentId2, false);
			}
			if (!this.IsRestoreFight)
			{
				this.NeedTrashTalk = true;
			}
			if (flag || flag2)
			{
				EventSystem.Instance.Emit<bool, bool>(EEventName.OnDangoBrawlEntityCreate, flag, flag2);
			}
			DangoBrawlFsm battleFsm = this.BattleFsm;
			if (battleFsm != null)
			{
				battleFsm.ChangeState(EDangoBrawlFsmState.GameStart).Forget();
			}
			this.UpdateFighterInfo(resp.Fighters);
		}

		// Token: 0x06036C66 RID: 224358 RVA: 0x00F48B1C File Offset: 0x00F46D1C
		protected void CreateEntity(int dangoId, bool isSelf)
		{
			IDangoBrawlEntityData data = new IDangoBrawlEntityData
			{
				DangoId = dangoId,
				Identity = (isSelf ? EDangoBrawlSide.Self : EDangoBrawlSide.Opponent)
			};
			this.DestroyEntity(isSelf);
			this.LoadEntityTask = null;
			if (isSelf)
			{
				this.SelfEntity = ActivityGameplayEntitySystem.CreateEntity<IDangoBrawlEntityData>(EActivityEntityKind.DangoBrawlDango, data);
				return;
			}
			this.OpponentEntity = ActivityGameplayEntitySystem.CreateEntity<IDangoBrawlEntityData>(EActivityEntityKind.DangoBrawlDango, data);
		}

		// Token: 0x06036C67 RID: 224359 RVA: 0x00F48B74 File Offset: 0x00F46D74
		[NullableContext(2)]
		public ActivityGameplayEntity GetEntity(bool isSelf)
		{
			if (!isSelf)
			{
				return this.OpponentEntity;
			}
			return this.SelfEntity;
		}

		// Token: 0x06036C68 RID: 224360 RVA: 0x00F48B88 File Offset: 0x00F46D88
		public void ShowSceneDamageText(int sceneDamageConfigId, int targetFighterUid, int value, bool isCrit, bool isCure)
		{
			UDamageUiManager ueDamageUiManager = DamageUiManager.Instance.UeDamageUiManager;
			if (ueDamageUiManager == null)
			{
				return;
			}
			if (!DamageUiManager.Instance.IsUeDamageConfigRegistered(sceneDamageConfigId))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.DangoBrawl;
				ELogAuthor author = ELogAuthor.WHJ;
				string message = "[ShowSceneDamageText] 飘字配置未注册进UE(缺 DamageText 行或未勾 UseForOptimization)，跳过";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("sceneDamageConfigId", sceneDamageConfigId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			bool isSelfByFighterUid = this.GetIsSelfByFighterUid(targetFighterUid);
			ActivityGameplayEntity entity = this.GetEntity(isSelfByFighterUid);
			DangoBrawlActorComponent dangoBrawlActorComponent = (entity != null) ? entity.GetComponent<DangoBrawlActorComponent>() : null;
			if (dangoBrawlActorComponent == null)
			{
				return;
			}
			FVectorDouble actorWorldLocation = dangoBrawlActorComponent.GetActorWorldLocation(0.0);
			FDamageInfo fdamageInfo = DamageUiManager.Instance.CreateDamageInfoForScene(value, sceneDamageConfigId, actorWorldLocation, isSelfByFighterUid, isCrit, isCure, "");
			ueDamageUiManager.AddDamageInfo(fdamageInfo);
		}

		// Token: 0x06036C69 RID: 224361 RVA: 0x00F48C34 File Offset: 0x00F46E34
		public void ShowUiDamageText(int uiDamageConfigId, UUIItem targetUiItem, bool isSelf, int value, bool isCrit, bool isCure, FVector2D? offset = null)
		{
			UDamageUiManager ueDamageUiManager = DamageUiManager.Instance.UeDamageUiManager;
			if (ueDamageUiManager == null)
			{
				return;
			}
			if (targetUiItem == null)
			{
				return;
			}
			if (!DamageUiManager.Instance.IsUeDamageConfigRegistered(uiDamageConfigId))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.DangoBrawl;
				ELogAuthor author = ELogAuthor.WHJ;
				string message = "[ShowUiDamageText] 飘字配置未注册进UE(缺 DamageText 行或未勾 UseForOptimization)，跳过";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("uiDamageConfigId", uiDamageConfigId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			FVector2D lguiPos = DamageUiManager.Instance.ConvertUiItemToLguiPosition(targetUiItem, offset);
			FDamageInfo fdamageInfo = DamageUiManager.Instance.CreateDamageInfoForLgui(value, uiDamageConfigId, lguiPos, isSelf, isCrit, isCure, "");
			ueDamageUiManager.AddDamageInfo(fdamageInfo);
		}

		// Token: 0x06036C6A RID: 224362 RVA: 0x00F48CC0 File Offset: 0x00F46EC0
		public int GetDangoId(bool isSelf)
		{
			if (!isSelf)
			{
				return this.OpponentId;
			}
			return this.SelfId;
		}

		// Token: 0x06036C6B RID: 224363 RVA: 0x00F48CD4 File Offset: 0x00F46ED4
		[NullableContext(2)]
		public void ShowDamageDA(int targetFighterUid, string targetDA, string oppositeDA, int internalMs)
		{
			bool isSelfByFighterUid = this.GetIsSelfByFighterUid(targetFighterUid);
			this.PlayDamageDAOnSide(targetDA, isSelfByFighterUid, internalMs);
			this.PlayDamageDAOnSide(oppositeDA, !isSelfByFighterUid, internalMs);
		}

		// Token: 0x06036C6C RID: 224364 RVA: 0x00F48D00 File Offset: 0x00F46F00
		[NullableContext(2)]
		private void PlayDamageDAOnSide(string effectPath, bool isSelf, int internalMs)
		{
			if (string.IsNullOrEmpty(effectPath))
			{
				return;
			}
			if (internalMs > 0 && this.FightingClock != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted(effectPath);
				defaultInterpolatedStringHandler.AppendLiteral("|");
				defaultInterpolatedStringHandler.AppendFormatted<int>((isSelf > false) ? 1 : 0);
				string key = defaultInterpolatedStringHandler.ToStringAndClear();
				float elapsed = this.FightingClock.Elapsed;
				float num;
				if (this.DamageDALastPlayMs.TryGetValue(key, out num) && elapsed - num < (float)internalMs)
				{
					return;
				}
				this.DamageDALastPlayMs[key] = elapsed;
			}
			ActivityGameplayEntity entity = this.GetEntity(isSelf);
			DangoBrawlActorComponent dangoBrawlActorComponent = (entity != null) ? entity.GetComponent<DangoBrawlActorComponent>() : null;
			FTransformDouble? ftransformDouble = (dangoBrawlActorComponent != null) ? dangoBrawlActorComponent.GetRootBoneTransform() : null;
			if (ftransformDouble == null)
			{
				return;
			}
			EffectSystem.Instance.SpawnEffect(GlobalData.World, ftransformDouble, effectPath, "DangoBrawlDamageDA", new EffectContext(), EEffectType.Scene, null, null, null, false, false);
		}

		// Token: 0x06036C6D RID: 224365 RVA: 0x00F48DDC File Offset: 0x00F46FDC
		public void PlayHitFlash(int targetFighterUid)
		{
			bool isSelfByFighterUid = this.GetIsSelfByFighterUid(targetFighterUid);
			int dangoId = this.GetDangoId(isSelfByFighterUid);
			DangoBrawlRole? dangoBrawlRole;
			DangoBrawlOpponent? dangoBrawlOpponent;
			string daPath = isSelfByFighterUid ? ((DangoBrawlConfig.Instance.GetRoleConfigById(dangoId) != null) ? dangoBrawlRole.GetValueOrDefault().HitDAPath : null) : ((DangoBrawlConfig.Instance.GetOpponentConfigById(dangoId) != null) ? dangoBrawlOpponent.GetValueOrDefault().HitDAPath : null);
			if (string.IsNullOrEmpty(daPath))
			{
				return;
			}
			if (this.FightingClock != null)
			{
				float elapsed = this.FightingClock.Elapsed;
				int hitDAInterval = DangoBrawlConfig.Instance.GetHitDAInterval();
				float num;
				if (this.HitFlashLastPlayMs.TryGetValue(targetFighterUid, out num) && elapsed - num < (float)hitDAInterval)
				{
					return;
				}
				this.HitFlashLastPlayMs[targetFighterUid] = elapsed;
			}
			ActivityGameplayEntity entity = this.GetEntity(isSelfByFighterUid);
			DangoBrawlActorComponent dangoBrawlActorComponent = (entity != null) ? entity.GetComponent<DangoBrawlActorComponent>() : null;
			ACharacter actor = (dangoBrawlActorComponent != null) ? dangoBrawlActorComponent.SpawnedActor : null;
			USkeletalMeshComponent mesh = (dangoBrawlActorComponent != null) ? dangoBrawlActorComponent.GetBodyMesh() : null;
			if (actor == null || mesh == null)
			{
				return;
			}
			ResourceSystem.Instance.LoadAsync<PD_CharacterControllerData_C>(daPath, delegate([Nullable(2)] PD_CharacterControllerData_C asset, string _)
			{
				if (asset == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.DangoBrawl;
					ELogAuthor author = ELogAuthor.WHJ;
					string message = "[PlayHitFlash] 受击闪白 DA 加载失败";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("daPath", daPath);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return;
				}
				if (!actor.IsValid() || !mesh.IsValid())
				{
					return;
				}
				TsBaseCharacter tsBaseCharacter = actor as TsBaseCharacter;
				CharRenderingComponent charRenderingComponent = (tsBaseCharacter != null) ? tsBaseCharacter.CharRenderingComponent : null;
				if (charRenderingComponent == null)
				{
					charRenderingComponent = (actor.GetComponentByClass(CharRenderingComponent.StaticClass()) as CharRenderingComponent);
				}
				if (charRenderingComponent == null)
				{
					charRenderingComponent = (actor.AddComponentByClass(CharRenderingComponent.StaticClass(), false, MathUtils.Instance.DefaultTransform, false, default(FName)) as CharRenderingComponent);
					if (charRenderingComponent != null)
					{
						charRenderingComponent.Init(ECharacterRenderingType.Effect);
					}
					if (charRenderingComponent != null)
					{
						charRenderingComponent.SetLogicOwner(actor);
					}
				}
				if (charRenderingComponent != null)
				{
					charRenderingComponent.QuickInitAndAddDataWithMeshComponent(asset, mesh);
				}
			}, 100, "js_undefined");
		}

		// Token: 0x06036C6E RID: 224366 RVA: 0x00F48F24 File Offset: 0x00F47124
		public bool GetIsSelfByFighterUid(int fighterUid)
		{
			bool flag;
			return this.FighterUidToIsSelfMap.TryGetValue(fighterUid, out flag) && flag;
		}

		// Token: 0x06036C6F RID: 224367 RVA: 0x00F48F44 File Offset: 0x00F47144
		public int GetOppositeFighterUid(int fighterUid)
		{
			foreach (KeyValuePair<int, bool> keyValuePair in this.FighterUidToIsSelfMap)
			{
				if (keyValuePair.Key != fighterUid)
				{
					return keyValuePair.Key;
				}
			}
			return fighterUid;
		}

		// Token: 0x06036C70 RID: 224368 RVA: 0x00F48FA8 File Offset: 0x00F471A8
		public IReadOnlyDictionary<int, bool> GetFighterUidToIsSelfMap()
		{
			return this.FighterUidToIsSelfMap;
		}

		// Token: 0x06036C71 RID: 224369 RVA: 0x00F48FB0 File Offset: 0x00F471B0
		public void DestroyEntity(bool isSelf)
		{
			ActivityGameplayEntitySystem.DestroyEntity(isSelf ? this.SelfEntity : this.OpponentEntity);
			if (isSelf)
			{
				this.SelfEntity = null;
				return;
			}
			this.OpponentEntity = null;
		}

		// Token: 0x06036C72 RID: 224370 RVA: 0x00F48FDA File Offset: 0x00F471DA
		[NullableContext(2)]
		public DangoBrawlFsm GetBattleFsm()
		{
			return this.BattleFsm;
		}

		// Token: 0x06036C73 RID: 224371 RVA: 0x00F48FE4 File Offset: 0x00F471E4
		public void CacheRoundSwitch(DangoBrawlRoundSwitchNotify resp)
		{
			this.LastRoundSwitch = resp;
			this.Round = resp.RoundNum;
			this.WinCount = resp.WinCount;
			this.LoseCount = resp.LoseCount;
			int opponentId = this.OpponentId;
			int opponentId2 = resp.OpponentId;
			this.OpponentId = opponentId2;
			if (opponentId != opponentId2)
			{
				this.CreateEntity(opponentId2, false);
				EventSystem.Instance.Emit<bool, bool>(EEventName.OnDangoBrawlEntityCreate, false, true);
			}
			this.NeedTrashTalk = true;
			this.UpdateFighterInfo(resp.Fighters);
		}

		// Token: 0x06036C74 RID: 224372 RVA: 0x00F49068 File Offset: 0x00F47268
		public void UpdateFighterInfo([Nullable(new byte[]
		{
			2,
			1
		})] IList<DangoBrawlFighterInfo> fighters)
		{
			if (fighters == null)
			{
				return;
			}
			foreach (DangoBrawlFighterInfo dangoBrawlFighterInfo in fighters)
			{
				ActivityGameplayEntity activityGameplayEntity = (dangoBrawlFighterInfo.Camp == DangoBrawlFightCamp.Player) ? this.SelfEntity : this.OpponentEntity;
				if (activityGameplayEntity != null)
				{
					DangoAttributeComponent component = activityGameplayEntity.GetComponent<DangoAttributeComponent>();
					if (component != null)
					{
						component.ClearData();
						foreach (KeyValuePair<int, int> keyValuePair in dangoBrawlFighterInfo.InitFinalAttrs)
						{
							component.SetAttribute(keyValuePair.Key, keyValuePair.Value);
						}
					}
				}
			}
		}

		// Token: 0x06036C75 RID: 224373 RVA: 0x00F4912C File Offset: 0x00F4732C
		private void RefreshHasEnteredAdditionRound(int winCount)
		{
			DangoBrawlChallenge? challengeConfigById = DangoBrawlConfig.Instance.GetChallengeConfigById(this.ChallengeId);
			int num = (challengeConfigById != null) ? challengeConfigById.GetValueOrDefault().AdditionRound : 0;
			int num2 = (challengeConfigById != null) ? challengeConfigById.GetValueOrDefault().WinCount : 0;
			this.HasEnteredAdditionRound = (num > 0 && winCount >= num2);
		}

		// Token: 0x06036C76 RID: 224374 RVA: 0x00F49198 File Offset: 0x00F47398
		public bool IsFinalRound()
		{
			DangoBrawlChallenge? challengeConfigById = DangoBrawlConfig.Instance.GetChallengeConfigById(this.ChallengeId);
			return challengeConfigById != null && (this.LoseCount >= challengeConfigById.Value.HpCount || this.Round >= challengeConfigById.Value.RoundListLength);
		}

		// Token: 0x06036C77 RID: 224375 RVA: 0x00F491F4 File Offset: 0x00F473F4
		public UniTask LoadEntityResource()
		{
			if (this.LoadEntityTask != null)
			{
				return this.LoadEntityTask.Value;
			}
			this.LoadEntityTask = new UniTask?(this.LoadEntityResourceInternal().Preserve());
			return this.LoadEntityTask.Value;
		}

		// Token: 0x06036C78 RID: 224376 RVA: 0x00F49240 File Offset: 0x00F47440
		private UniTask LoadEntityResourceInternal()
		{
			DangoBrawlBattleManager.<LoadEntityResourceInternal>d__68 <LoadEntityResourceInternal>d__;
			<LoadEntityResourceInternal>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadEntityResourceInternal>d__.<>4__this = this;
			<LoadEntityResourceInternal>d__.<>1__state = -1;
			<LoadEntityResourceInternal>d__.<>t__builder.Start<DangoBrawlBattleManager.<LoadEntityResourceInternal>d__68>(ref <LoadEntityResourceInternal>d__);
			return <LoadEntityResourceInternal>d__.<>t__builder.Task;
		}

		// Token: 0x06036C79 RID: 224377 RVA: 0x00F49284 File Offset: 0x00F47484
		private void CollectEntityLoadTasks(ActivityGameplayEntity entity, List<UniTask> tasks)
		{
			DangoBrawlActorComponent dangoBrawlActorComponent = entity.CheckGetComponent<DangoBrawlActorComponent>();
			if (dangoBrawlActorComponent != null)
			{
				tasks.Add(dangoBrawlActorComponent.SpawnAsync());
			}
			DangoBrawlMontageComponent dangoBrawlMontageComponent = entity.CheckGetComponent<DangoBrawlMontageComponent>();
			if (dangoBrawlMontageComponent != null)
			{
				tasks.Add(dangoBrawlMontageComponent.LoadAsync());
			}
		}

		// Token: 0x06036C7A RID: 224378 RVA: 0x00F492C0 File Offset: 0x00F474C0
		public void BattleReportClear()
		{
			this.BattleReport.Clear();
			this.CurrentBattleProgress = 0;
			this.IsWin = null;
			this.ReportEnd = null;
			this.DangoReady = false;
			DangoBrawlDamageReporter damage = this.Damage;
			if (damage == null)
			{
				return;
			}
			damage.Reset();
		}

		// Token: 0x06036C7B RID: 224379 RVA: 0x00F49310 File Offset: 0x00F47510
		public void InitDango(IList<DangoBrawlFighterInfo> fighters)
		{
			this.FighterUidToIsSelfMap.Clear();
			foreach (DangoBrawlFighterInfo dangoBrawlFighterInfo in fighters)
			{
				bool flag = dangoBrawlFighterInfo.Camp == DangoBrawlFightCamp.Player;
				this.FighterUidToIsSelfMap[dangoBrawlFighterInfo.FighterUId] = flag;
				ActivityGameplayEntity activityGameplayEntity = flag ? this.SelfEntity : this.OpponentEntity;
				if (activityGameplayEntity != null)
				{
					DangoBrawlDataComponent component = activityGameplayEntity.GetComponent<DangoBrawlDataComponent>();
					if (component != null)
					{
						component.SetUid(dangoBrawlFighterInfo.FighterUId);
					}
					DangoAttributeComponent component2 = activityGameplayEntity.GetComponent<DangoAttributeComponent>();
					if (component2 != null)
					{
						component2.ClearData();
						foreach (KeyValuePair<int, int> keyValuePair in dangoBrawlFighterInfo.InitFinalAttrs)
						{
							component2.SetAttribute(keyValuePair.Key, keyValuePair.Value);
						}
					}
				}
			}
			this.DangoReady = true;
			DangoBrawlFsm battleFsm = this.BattleFsm;
			if (battleFsm != null && battleFsm.GetCurrentStateType() == EDangoBrawlFsmState.FightingState)
			{
				DangoBrawlFsm battleFsm2 = this.BattleFsm;
				DangoBrawlFightingState dangoBrawlFightingState = ((battleFsm2 != null) ? battleFsm2.GetCurrentState() : null) as DangoBrawlFightingState;
				if (dangoBrawlFightingState == null)
				{
					return;
				}
				dangoBrawlFightingState.SetReportReady();
			}
		}

		// Token: 0x06036C7C RID: 224380 RVA: 0x00F49450 File Offset: 0x00F47650
		public bool CheckDangoReady()
		{
			return this.DangoReady && this.ReportEnd.GetValueOrDefault();
		}

		// Token: 0x06036C7D RID: 224381 RVA: 0x00F49468 File Offset: 0x00F47668
		public void OnReceiveBattleReport(DangoBrawlFightActionNotify message)
		{
			RepeatedField<DangoBrawlFightActionInfo> repeatedField = message.Actions ?? new RepeatedField<DangoBrawlFightActionInfo>();
			if (message.IsEnd)
			{
				this.ReportEnd = new bool?(true);
				this.IsWin = new bool?(message.PlayerWin);
			}
			if (repeatedField.Count > 0)
			{
				List<IDangoBrawlBattleAction> list = new List<IDangoBrawlBattleAction>();
				foreach (DangoBrawlFightActionInfo dangoBrawlFightActionInfo in repeatedField)
				{
					list.Add(new DangoBrawlBattleAction
					{
						TimeMs = dangoBrawlFightActionInfo.TimeMs,
						ActionGroupUid = dangoBrawlFightActionInfo.ActionGroupUId,
						SkillCast = dangoBrawlFightActionInfo.SkillCast,
						FatigueDamage = dangoBrawlFightActionInfo.FatigueDamage,
						BuffChange = dangoBrawlFightActionInfo.BuffChange,
						BuffRemove = dangoBrawlFightActionInfo.BuffRemove,
						AttrChange = dangoBrawlFightActionInfo.AttrChange,
						Death = dangoBrawlFightActionInfo.Death,
						BuffTick = dangoBrawlFightActionInfo.BuffTick,
						Heal = dangoBrawlFightActionInfo.Heal,
						ReflectDamage = dangoBrawlFightActionInfo.ReflectDamage,
						WeaponStop = dangoBrawlFightActionInfo.WeaponStop,
						ShieldAdd = dangoBrawlFightActionInfo.ShieldAdd,
						Lifesteal = dangoBrawlFightActionInfo.Lifesteal,
						EffectShow = dangoBrawlFightActionInfo.EffectShow,
						InitWeaponCd = dangoBrawlFightActionInfo.InitWeaponCd
					});
				}
				bool flag = true;
				for (int i = 1; i < list.Count; i++)
				{
					if (list[i - 1].TimeMs > list[i].TimeMs)
					{
						flag = false;
						break;
					}
				}
				if (!flag)
				{
					list.Sort((IDangoBrawlBattleAction a, IDangoBrawlBattleAction b) => a.TimeMs - b.TimeMs);
				}
				List<IDangoBrawlBattleAction> battleReport = this.BattleReport;
				int num = battleReport.Count - 1;
				if (num < 0 || battleReport[num].TimeMs <= list[0].TimeMs)
				{
					using (List<IDangoBrawlBattleAction>.Enumerator enumerator2 = list.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							IDangoBrawlBattleAction item = enumerator2.Current;
							battleReport.Add(item);
						}
						goto IL_2D9;
					}
				}
				List<IDangoBrawlBattleAction> list2 = new List<IDangoBrawlBattleAction>(battleReport.Count + list.Count);
				int j = 0;
				int k = 0;
				while (j < battleReport.Count)
				{
					if (k >= list.Count)
					{
						break;
					}
					if (battleReport[j].TimeMs <= list[k].TimeMs)
					{
						list2.Add(battleReport[j++]);
					}
					else
					{
						list2.Add(list[k++]);
					}
				}
				while (j < battleReport.Count)
				{
					list2.Add(battleReport[j++]);
				}
				while (k < list.Count)
				{
					list2.Add(list[k++]);
				}
				this.BattleReport = list2;
			}
			IL_2D9:
			if (message.IsEnd)
			{
				this.LogBattleReportReceived();
				this.DestroyBattleReportPlayer();
				this.BattleReportPlayer = new DangoBrawlBattleReportPlayer();
				this.BattleReportPlayer.Init();
			}
			DangoBrawlFsm battleFsm = this.BattleFsm;
			if (battleFsm != null && battleFsm.GetCurrentStateType() == EDangoBrawlFsmState.FightingState && message.IsEnd)
			{
				DangoBrawlFightingState dangoBrawlFightingState = this.BattleFsm.GetCurrentState() as DangoBrawlFightingState;
				if (dangoBrawlFightingState == null)
				{
					return;
				}
				dangoBrawlFightingState.SetReportReady();
			}
		}

		// Token: 0x06036C7E RID: 224382 RVA: 0x00F497D0 File Offset: 0x00F479D0
		private void LogBattleReportReceived()
		{
			List<IDangoBrawlBattleAction> battleReport = this.BattleReport;
			IReadOnlyDictionary<int, bool> fighterUidToIsSelfMap = this.GetFighterUidToIsSelfMap();
			for (int i = 0; i < battleReport.Count; i++)
			{
				IDangoBrawlBattleAction a = battleReport[i];
				DangoBrawlBattleManager.DescribeActionType(a);
				int key = DangoBrawlBattleManager.ResolveActionTargetForLog(a);
				bool flag;
				fighterUidToIsSelfMap.TryGetValue(key, out flag);
			}
		}

		// Token: 0x06036C7F RID: 224383 RVA: 0x00F4981C File Offset: 0x00F47A1C
		private static string DescribeActionType(IDangoBrawlBattleAction a)
		{
			List<string> list = new List<string>();
			if (a.SkillCast != null)
			{
				list.Add("SkillCast");
			}
			if (a.AttrChange != null)
			{
				list.Add("AttrChange");
			}
			if (a.Death != null)
			{
				list.Add("Death");
			}
			if (a.BuffChange != null)
			{
				list.Add("BuffChange");
			}
			if (a.BuffRemove != null)
			{
				list.Add("BuffRemove");
			}
			if (a.BuffTick != null)
			{
				list.Add("BuffTick");
			}
			if (a.FatigueDamage != null)
			{
				list.Add("Fatigue");
			}
			if (a.Heal != null)
			{
				list.Add("Heal");
			}
			if (a.ShieldAdd != null)
			{
				list.Add("Shield");
			}
			if (a.ReflectDamage != null)
			{
				list.Add("Reflect");
			}
			if (a.Lifesteal != null)
			{
				list.Add("Lifesteal");
			}
			if (a.WeaponStop != null)
			{
				list.Add("WeaponStop");
			}
			if (a.EffectShow != null)
			{
				list.Add("EffectShow");
			}
			if (list.Count <= 0)
			{
				return "Empty";
			}
			return string.Join("+", list);
		}

		// Token: 0x06036C80 RID: 224384 RVA: 0x00F49940 File Offset: 0x00F47B40
		private static int ResolveActionTargetForLog(IDangoBrawlBattleAction a)
		{
			if (a.AttrChange != null)
			{
				return a.AttrChange.TargetFighterUId;
			}
			if (a.Death != null)
			{
				return a.Death.TargetFighterUId;
			}
			if (a.Heal != null)
			{
				return a.Heal.TargetFighterUId;
			}
			if (a.ShieldAdd != null)
			{
				return a.ShieldAdd.TargetFighterUId;
			}
			if (a.ReflectDamage != null)
			{
				return a.ReflectDamage.TargetFighterUId;
			}
			if (a.Lifesteal != null)
			{
				return a.Lifesteal.TargetFighterUId;
			}
			if (a.SkillCast != null)
			{
				return a.SkillCast.TargetFighterUId;
			}
			return -1;
		}

		// Token: 0x06036C81 RID: 224385 RVA: 0x00F499DC File Offset: 0x00F47BDC
		private static string DescribeHpFinal(IDangoBrawlBattleAction a)
		{
			if (a.AttrChange == null)
			{
				return "";
			}
			foreach (KeyValuePair<int, int> keyValuePair in a.AttrChange.FinalAttrs)
			{
				if (keyValuePair.Key == 1)
				{
					return keyValuePair.Value.ToString();
				}
			}
			return "";
		}

		// Token: 0x06036C82 RID: 224386 RVA: 0x00F49A58 File Offset: 0x00F47C58
		public void SetIsPause(bool value)
		{
			this.IsPause = value;
			this.RefreshMontagePauseState();
		}

		// Token: 0x06036C83 RID: 224387 RVA: 0x00F49A67 File Offset: 0x00F47C67
		public void SetIsPauseByView(bool needPause, string reason)
		{
			int pauseViewCount = this.PauseViewCount;
			if (needPause)
			{
				this.PauseViewCount++;
			}
			else
			{
				this.PauseViewCount--;
				if (this.PauseViewCount < 0)
				{
					this.PauseViewCount = 0;
				}
			}
			this.RefreshMontagePauseState();
		}

		// Token: 0x06036C84 RID: 224388 RVA: 0x00F49AA8 File Offset: 0x00F47CA8
		private void RefreshMontagePauseState()
		{
			ActivityGameplayEntity selfEntity = this.SelfEntity;
			DangoBrawlMontageComponent dangoBrawlMontageComponent = (selfEntity != null) ? selfEntity.GetComponent<DangoBrawlMontageComponent>() : null;
			ActivityGameplayEntity opponentEntity = this.OpponentEntity;
			DangoBrawlMontageComponent dangoBrawlMontageComponent2 = (opponentEntity != null) ? opponentEntity.GetComponent<DangoBrawlMontageComponent>() : null;
			if (this.IsPause || this.PauseViewCount > 0)
			{
				if (dangoBrawlMontageComponent != null)
				{
					dangoBrawlMontageComponent.PauseMontage();
				}
				if (dangoBrawlMontageComponent2 != null)
				{
					dangoBrawlMontageComponent2.PauseMontage();
					return;
				}
			}
			else
			{
				if (dangoBrawlMontageComponent != null)
				{
					dangoBrawlMontageComponent.ResumeMontage();
				}
				if (dangoBrawlMontageComponent2 != null)
				{
					dangoBrawlMontageComponent2.ResumeMontage();
				}
			}
		}

		// Token: 0x06036C85 RID: 224389 RVA: 0x00F49B14 File Offset: 0x00F47D14
		public void InitTimerSystem()
		{
			if (this.TimerHandle != null)
			{
				this.ClearTimerHandle();
			}
			this.TimerHandle = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnTick), 20f, 1f, null, null, true);
			this.FightingClock = new DangoBrawlFightingClock();
			EventSystem.Instance.Emit(EEventName.OnDangoBrawlFightingTimerInit);
			EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "DangoBrawlFightStart");
		}

		// Token: 0x06036C86 RID: 224390 RVA: 0x00F49B88 File Offset: 0x00F47D88
		[return: Nullable(2)]
		public TimerHandle RegisterFightingTickCallback(TTimerAction callback, float delta)
		{
			return this.DangoBrawlTimerSystem.Forever(callback, delta, 1f, null, null, true);
		}

		// Token: 0x06036C87 RID: 224391 RVA: 0x00F49B9F File Offset: 0x00F47D9F
		[NullableContext(2)]
		public void UnregisterFightingTickCallback(TimerHandle handle)
		{
			if (handle != null && this.DangoBrawlTimerSystem.Has(handle))
			{
				this.DangoBrawlTimerSystem.Remove(handle);
			}
		}

		// Token: 0x06036C88 RID: 224392 RVA: 0x00F49BBF File Offset: 0x00F47DBF
		private void OnTick(float deltaTime)
		{
			if (this.IsPause || this.PauseViewCount > 0)
			{
				return;
			}
			this.TickFsm(deltaTime);
			this.TickEntity(deltaTime);
			this.DangoBrawlTimerSystem.Tick((double)deltaTime);
		}

		// Token: 0x06036C89 RID: 224393 RVA: 0x00F49BEE File Offset: 0x00F47DEE
		private void TickFsm(float deltaTime)
		{
			DangoBrawlFsm battleFsm = this.BattleFsm;
			if (battleFsm == null)
			{
				return;
			}
			battleFsm.Tick(deltaTime);
		}

		// Token: 0x06036C8A RID: 224394 RVA: 0x00F49C04 File Offset: 0x00F47E04
		private void TickEntity(float deltaTime)
		{
			ActivityGameplayEntity selfEntity = this.SelfEntity;
			if (selfEntity != null && selfEntity.NeedTick)
			{
				this.SelfEntity.Tick(deltaTime);
			}
			ActivityGameplayEntity opponentEntity = this.OpponentEntity;
			if (opponentEntity != null && opponentEntity.NeedTick)
			{
				this.OpponentEntity.Tick(deltaTime);
			}
		}

		// Token: 0x06036C8B RID: 224395 RVA: 0x00F49C51 File Offset: 0x00F47E51
		private void ClearTimerHandle()
		{
			if (TimerSystem.GameplayTimeInstance.Has(this.TimerHandle))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
				this.TimerHandle = null;
			}
		}

		// Token: 0x06036C8C RID: 224396 RVA: 0x00F49C7D File Offset: 0x00F47E7D
		public void ClearTimerSystem()
		{
			this.ClearTimerHandle();
			this.DangoBrawlTimerSystem.Clear();
			this.FightingClock = null;
			this.DamageDALastPlayMs.Clear();
			this.HitFlashLastPlayMs.Clear();
		}

		// Token: 0x0401CEBB RID: 118459
		private int RoundInternal;

		// Token: 0x0401CEBC RID: 118460
		protected int SelfId;

		// Token: 0x0401CEBD RID: 118461
		protected int OpponentId;

		// Token: 0x0401CEBE RID: 118462
		protected int ChallengeId;

		// Token: 0x0401CEBF RID: 118463
		protected int Coin;

		// Token: 0x0401CEC0 RID: 118464
		protected int LoseCount;

		// Token: 0x0401CEC1 RID: 118465
		protected int WinCount;

		// Token: 0x0401CEC2 RID: 118466
		public bool IsRestoreFight;

		// Token: 0x0401CEC3 RID: 118467
		public bool NeedTrashTalk;

		// Token: 0x0401CEC4 RID: 118468
		public List<IDangoBrawlBattleAction> BattleReport = new List<IDangoBrawlBattleAction>();

		// Token: 0x0401CEC5 RID: 118469
		public int CurrentBattleProgress;

		// Token: 0x0401CEC6 RID: 118470
		public bool? IsWin;

		// Token: 0x0401CEC7 RID: 118471
		public bool? ReportEnd;

		// Token: 0x0401CEC8 RID: 118472
		public bool FinalWin;

		// Token: 0x0401CECC RID: 118476
		[Nullable(2)]
		public DangoBrawlRoundSwitchNotify LastRoundSwitch;

		// Token: 0x0401CECD RID: 118477
		[Nullable(2)]
		public ActivityGameplayEntity SelfEntity;

		// Token: 0x0401CECE RID: 118478
		[Nullable(2)]
		public ActivityGameplayEntity OpponentEntity;

		// Token: 0x0401CECF RID: 118479
		private UniTask? LoadEntityTask;

		// Token: 0x0401CED0 RID: 118480
		[Nullable(2)]
		public DangoBrawlFightingClock FightingClock;

		// Token: 0x0401CED1 RID: 118481
		[Nullable(2)]
		public DangoBrawlBattleReportPlayer BattleReportPlayer;

		// Token: 0x0401CED2 RID: 118482
		[Nullable(2)]
		public DangoBrawlDamageReporter Damage;

		// Token: 0x0401CED3 RID: 118483
		protected bool DangoReady;

		// Token: 0x0401CED4 RID: 118484
		[Nullable(2)]
		protected DangoBrawlFsm BattleFsm;

		// Token: 0x0401CED5 RID: 118485
		private const string DAMAGE_DA_REASON = "DangoBrawlDamageDA";

		// Token: 0x0401CED6 RID: 118486
		private readonly Dictionary<string, float> DamageDALastPlayMs = new Dictionary<string, float>();

		// Token: 0x0401CED7 RID: 118487
		private const string HIT_FLASH_REASON = "DangoBrawlHitFlash";

		// Token: 0x0401CED8 RID: 118488
		private readonly Dictionary<int, float> HitFlashLastPlayMs = new Dictionary<int, float>();

		// Token: 0x0401CED9 RID: 118489
		private readonly Dictionary<int, bool> FighterUidToIsSelfMap = new Dictionary<int, bool>();

		// Token: 0x0401CEDA RID: 118490
		public TimerSystemInstance DangoBrawlTimerSystem = new TimerSystemInstance();

		// Token: 0x0401CEDB RID: 118491
		[Nullable(2)]
		private TimerHandle TimerHandle;

		// Token: 0x0401CEDC RID: 118492
		protected bool IsPause;

		// Token: 0x0401CEDD RID: 118493
		private int PauseViewCount;
	}
}
