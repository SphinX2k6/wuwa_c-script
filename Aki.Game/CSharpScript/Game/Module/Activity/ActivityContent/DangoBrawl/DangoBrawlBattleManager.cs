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
	// Token: 0x02006758 RID: 26456
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlBattleManager
	{
		// Token: 0x17009670 RID: 38512
		// (get) Token: 0x06042105 RID: 270597 RVA: 0x01007481 File Offset: 0x01005681
		// (set) Token: 0x06042106 RID: 270598 RVA: 0x01007489 File Offset: 0x01005689
		public bool IsForceEnterFinalState { get; private set; }

		// Token: 0x17009671 RID: 38513
		// (get) Token: 0x06042107 RID: 270599 RVA: 0x01007492 File Offset: 0x01005692
		// (set) Token: 0x06042108 RID: 270600 RVA: 0x0100749A File Offset: 0x0100569A
		public bool IsLeavingBattle { get; private set; }

		// Token: 0x06042109 RID: 270601 RVA: 0x010074A3 File Offset: 0x010056A3
		public void SetIsLeavingBattle(bool value)
		{
			this.IsLeavingBattle = value;
		}

		// Token: 0x17009672 RID: 38514
		// (get) Token: 0x0604210A RID: 270602 RVA: 0x010074AC File Offset: 0x010056AC
		// (set) Token: 0x0604210B RID: 270603 RVA: 0x010074B4 File Offset: 0x010056B4
		public bool HasEnteredAdditionRound { get; private set; }

		// Token: 0x0604210C RID: 270604 RVA: 0x010074BD File Offset: 0x010056BD
		public void SetForceEnterFinalState(bool force)
		{
			this.IsForceEnterFinalState = force;
		}

		// Token: 0x0604210D RID: 270605 RVA: 0x010074C6 File Offset: 0x010056C6
		public void SetHasEnteredAdditionRound(bool value)
		{
			this.HasEnteredAdditionRound = value;
		}

		// Token: 0x17009673 RID: 38515
		// (get) Token: 0x0604210E RID: 270606 RVA: 0x010074CF File Offset: 0x010056CF
		// (set) Token: 0x0604210F RID: 270607 RVA: 0x010074D7 File Offset: 0x010056D7
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

		// Token: 0x06042110 RID: 270608 RVA: 0x010074E0 File Offset: 0x010056E0
		public void Init()
		{
			this.BattleFsm = new DangoBrawlFsm();
			this.BattleFsm.Init();
			this.Damage = new DangoBrawlDamageReporter();
			this.HasEnteredAdditionRound = false;
		}

		// Token: 0x06042111 RID: 270609 RVA: 0x0100750C File Offset: 0x0100570C
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

		// Token: 0x06042112 RID: 270610 RVA: 0x0100757B File Offset: 0x0100577B
		public void DestroyBattleReportPlayer()
		{
			if (this.BattleReportPlayer == null)
			{
				return;
			}
			this.BattleReportPlayer.Destroy();
			this.BattleReportPlayer = null;
		}

		// Token: 0x06042113 RID: 270611 RVA: 0x01007598 File Offset: 0x01005798
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

		// Token: 0x06042114 RID: 270612 RVA: 0x01007698 File Offset: 0x01005898
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

		// Token: 0x06042115 RID: 270613 RVA: 0x010076F0 File Offset: 0x010058F0
		[NullableContext(2)]
		public ActivityGameplayEntity GetEntity(bool isSelf)
		{
			if (!isSelf)
			{
				return this.OpponentEntity;
			}
			return this.SelfEntity;
		}

		// Token: 0x06042116 RID: 270614 RVA: 0x01007704 File Offset: 0x01005904
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

		// Token: 0x06042117 RID: 270615 RVA: 0x010077B0 File Offset: 0x010059B0
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

		// Token: 0x06042118 RID: 270616 RVA: 0x0100783C File Offset: 0x01005A3C
		public int GetDangoId(bool isSelf)
		{
			if (!isSelf)
			{
				return this.OpponentId;
			}
			return this.SelfId;
		}

		// Token: 0x06042119 RID: 270617 RVA: 0x01007850 File Offset: 0x01005A50
		[NullableContext(2)]
		public void ShowDamageDA(int targetFighterUid, string targetDA, string oppositeDA, int internalMs)
		{
			bool isSelfByFighterUid = this.GetIsSelfByFighterUid(targetFighterUid);
			this.PlayDamageDAOnSide(targetDA, isSelfByFighterUid, internalMs);
			this.PlayDamageDAOnSide(oppositeDA, !isSelfByFighterUid, internalMs);
		}

		// Token: 0x0604211A RID: 270618 RVA: 0x0100787C File Offset: 0x01005A7C
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

		// Token: 0x0604211B RID: 270619 RVA: 0x01007958 File Offset: 0x01005B58
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

		// Token: 0x0604211C RID: 270620 RVA: 0x01007AA0 File Offset: 0x01005CA0
		public bool GetIsSelfByFighterUid(int fighterUid)
		{
			bool flag;
			return this.FighterUidToIsSelfMap.TryGetValue(fighterUid, out flag) && flag;
		}

		// Token: 0x0604211D RID: 270621 RVA: 0x01007AC0 File Offset: 0x01005CC0
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

		// Token: 0x0604211E RID: 270622 RVA: 0x01007B24 File Offset: 0x01005D24
		public IReadOnlyDictionary<int, bool> GetFighterUidToIsSelfMap()
		{
			return this.FighterUidToIsSelfMap;
		}

		// Token: 0x0604211F RID: 270623 RVA: 0x01007B2C File Offset: 0x01005D2C
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

		// Token: 0x06042120 RID: 270624 RVA: 0x01007B56 File Offset: 0x01005D56
		[NullableContext(2)]
		public DangoBrawlFsm GetBattleFsm()
		{
			return this.BattleFsm;
		}

		// Token: 0x06042121 RID: 270625 RVA: 0x01007B60 File Offset: 0x01005D60
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

		// Token: 0x06042122 RID: 270626 RVA: 0x01007BE4 File Offset: 0x01005DE4
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

		// Token: 0x06042123 RID: 270627 RVA: 0x01007CA8 File Offset: 0x01005EA8
		private void RefreshHasEnteredAdditionRound(int winCount)
		{
			DangoBrawlChallenge? challengeConfigById = DangoBrawlConfig.Instance.GetChallengeConfigById(this.ChallengeId);
			int num = (challengeConfigById != null) ? challengeConfigById.GetValueOrDefault().AdditionRound : 0;
			int num2 = (challengeConfigById != null) ? challengeConfigById.GetValueOrDefault().WinCount : 0;
			this.HasEnteredAdditionRound = (num > 0 && winCount >= num2);
		}

		// Token: 0x06042124 RID: 270628 RVA: 0x01007D14 File Offset: 0x01005F14
		public bool IsFinalRound()
		{
			DangoBrawlChallenge? challengeConfigById = DangoBrawlConfig.Instance.GetChallengeConfigById(this.ChallengeId);
			return challengeConfigById != null && (this.LoseCount >= challengeConfigById.Value.HpCount || this.Round >= challengeConfigById.Value.RoundListLength);
		}

		// Token: 0x06042125 RID: 270629 RVA: 0x01007D70 File Offset: 0x01005F70
		public UniTask LoadEntityResource()
		{
			if (this.LoadEntityTask != null)
			{
				return this.LoadEntityTask.Value;
			}
			this.LoadEntityTask = new UniTask?(this.LoadEntityResourceInternal().Preserve());
			return this.LoadEntityTask.Value;
		}

		// Token: 0x06042126 RID: 270630 RVA: 0x01007DBC File Offset: 0x01005FBC
		private UniTask LoadEntityResourceInternal()
		{
			DangoBrawlBattleManager.<LoadEntityResourceInternal>d__68 <LoadEntityResourceInternal>d__;
			<LoadEntityResourceInternal>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadEntityResourceInternal>d__.<>4__this = this;
			<LoadEntityResourceInternal>d__.<>1__state = -1;
			<LoadEntityResourceInternal>d__.<>t__builder.Start<DangoBrawlBattleManager.<LoadEntityResourceInternal>d__68>(ref <LoadEntityResourceInternal>d__);
			return <LoadEntityResourceInternal>d__.<>t__builder.Task;
		}

		// Token: 0x06042127 RID: 270631 RVA: 0x01007E00 File Offset: 0x01006000
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

		// Token: 0x06042128 RID: 270632 RVA: 0x01007E3C File Offset: 0x0100603C
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

		// Token: 0x06042129 RID: 270633 RVA: 0x01007E8C File Offset: 0x0100608C
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

		// Token: 0x0604212A RID: 270634 RVA: 0x01007FCC File Offset: 0x010061CC
		public bool CheckDangoReady()
		{
			return this.DangoReady && this.ReportEnd.GetValueOrDefault();
		}

		// Token: 0x0604212B RID: 270635 RVA: 0x01007FE4 File Offset: 0x010061E4
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

		// Token: 0x0604212C RID: 270636 RVA: 0x0100834C File Offset: 0x0100654C
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

		// Token: 0x0604212D RID: 270637 RVA: 0x01008398 File Offset: 0x01006598
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

		// Token: 0x0604212E RID: 270638 RVA: 0x010084BC File Offset: 0x010066BC
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

		// Token: 0x0604212F RID: 270639 RVA: 0x01008558 File Offset: 0x01006758
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

		// Token: 0x06042130 RID: 270640 RVA: 0x010085D4 File Offset: 0x010067D4
		public void SetIsPause(bool value)
		{
			this.IsPause = value;
			this.RefreshMontagePauseState();
		}

		// Token: 0x06042131 RID: 270641 RVA: 0x010085E3 File Offset: 0x010067E3
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

		// Token: 0x06042132 RID: 270642 RVA: 0x01008624 File Offset: 0x01006824
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

		// Token: 0x06042133 RID: 270643 RVA: 0x01008690 File Offset: 0x01006890
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

		// Token: 0x06042134 RID: 270644 RVA: 0x01008704 File Offset: 0x01006904
		[return: Nullable(2)]
		public TimerHandle RegisterFightingTickCallback(TTimerAction callback, float delta)
		{
			TimerHandle timerHandle = this.DangoBrawlTimerSystem.Forever(callback, delta, 1f, null, null, true);
			if (timerHandle != null)
			{
				this.FightingTickHandles.Add(timerHandle);
			}
			return timerHandle;
		}

		// Token: 0x06042135 RID: 270645 RVA: 0x01008737 File Offset: 0x01006937
		[NullableContext(2)]
		public void UnregisterFightingTickCallback(TimerHandle handle)
		{
			if (handle != null && this.DangoBrawlTimerSystem.Has(handle))
			{
				this.DangoBrawlTimerSystem.Remove(handle);
				this.FightingTickHandles.Remove(handle);
			}
		}

		// Token: 0x06042136 RID: 270646 RVA: 0x01008764 File Offset: 0x01006964
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

		// Token: 0x06042137 RID: 270647 RVA: 0x01008793 File Offset: 0x01006993
		private void TickFsm(float deltaTime)
		{
			DangoBrawlFsm battleFsm = this.BattleFsm;
			if (battleFsm == null)
			{
				return;
			}
			battleFsm.Tick(deltaTime);
		}

		// Token: 0x06042138 RID: 270648 RVA: 0x010087A8 File Offset: 0x010069A8
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

		// Token: 0x06042139 RID: 270649 RVA: 0x010087F5 File Offset: 0x010069F5
		private void ClearTimerHandle()
		{
			if (TimerSystem.GameplayTimeInstance.Has(this.TimerHandle))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
				this.TimerHandle = null;
			}
		}

		// Token: 0x0604213A RID: 270650 RVA: 0x01008824 File Offset: 0x01006A24
		public void ClearTimerSystem()
		{
			this.ClearTimerHandle();
			foreach (TimerHandle handle in this.FightingTickHandles)
			{
				this.DangoBrawlTimerSystem.Remove(handle);
			}
			this.FightingTickHandles.Clear();
			this.FightingClock = null;
			this.DamageDALastPlayMs.Clear();
			this.HitFlashLastPlayMs.Clear();
		}

		// Token: 0x04022662 RID: 140898
		private int RoundInternal;

		// Token: 0x04022663 RID: 140899
		protected int SelfId;

		// Token: 0x04022664 RID: 140900
		protected int OpponentId;

		// Token: 0x04022665 RID: 140901
		protected int ChallengeId;

		// Token: 0x04022666 RID: 140902
		protected int Coin;

		// Token: 0x04022667 RID: 140903
		protected int LoseCount;

		// Token: 0x04022668 RID: 140904
		protected int WinCount;

		// Token: 0x04022669 RID: 140905
		public bool IsRestoreFight;

		// Token: 0x0402266A RID: 140906
		public bool NeedTrashTalk;

		// Token: 0x0402266B RID: 140907
		public List<IDangoBrawlBattleAction> BattleReport = new List<IDangoBrawlBattleAction>();

		// Token: 0x0402266C RID: 140908
		public int CurrentBattleProgress;

		// Token: 0x0402266D RID: 140909
		public bool? IsWin;

		// Token: 0x0402266E RID: 140910
		public bool? ReportEnd;

		// Token: 0x0402266F RID: 140911
		public bool FinalWin;

		// Token: 0x04022673 RID: 140915
		[Nullable(2)]
		public DangoBrawlRoundSwitchNotify LastRoundSwitch;

		// Token: 0x04022674 RID: 140916
		[Nullable(2)]
		public ActivityGameplayEntity SelfEntity;

		// Token: 0x04022675 RID: 140917
		[Nullable(2)]
		public ActivityGameplayEntity OpponentEntity;

		// Token: 0x04022676 RID: 140918
		private UniTask? LoadEntityTask;

		// Token: 0x04022677 RID: 140919
		[Nullable(2)]
		public DangoBrawlFightingClock FightingClock;

		// Token: 0x04022678 RID: 140920
		[Nullable(2)]
		public DangoBrawlBattleReportPlayer BattleReportPlayer;

		// Token: 0x04022679 RID: 140921
		[Nullable(2)]
		public DangoBrawlDamageReporter Damage;

		// Token: 0x0402267A RID: 140922
		protected bool DangoReady;

		// Token: 0x0402267B RID: 140923
		[Nullable(2)]
		protected DangoBrawlFsm BattleFsm;

		// Token: 0x0402267C RID: 140924
		private const string DAMAGE_DA_REASON = "DangoBrawlDamageDA";

		// Token: 0x0402267D RID: 140925
		private readonly Dictionary<string, float> DamageDALastPlayMs = new Dictionary<string, float>();

		// Token: 0x0402267E RID: 140926
		private const string HIT_FLASH_REASON = "DangoBrawlHitFlash";

		// Token: 0x0402267F RID: 140927
		private readonly Dictionary<int, float> HitFlashLastPlayMs = new Dictionary<int, float>();

		// Token: 0x04022680 RID: 140928
		private readonly Dictionary<int, bool> FighterUidToIsSelfMap = new Dictionary<int, bool>();

		// Token: 0x04022681 RID: 140929
		public TimerSystemInstance DangoBrawlTimerSystem = new TimerSystemInstance();

		// Token: 0x04022682 RID: 140930
		[Nullable(2)]
		private TimerHandle TimerHandle;

		// Token: 0x04022683 RID: 140931
		private readonly List<TimerHandle> FightingTickHandles = new List<TimerHandle>();

		// Token: 0x04022684 RID: 140932
		protected bool IsPause;

		// Token: 0x04022685 RID: 140933
		private int PauseViewCount;
	}
}
