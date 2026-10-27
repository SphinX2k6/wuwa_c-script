using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.ActivityGamePlay.ActivityGameplayEntity.Component;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Entity.Component
{
	// Token: 0x02006899 RID: 26777
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DangoBrawlMontageComponent : ActivityGameplayComponentBase<IDangoBrawlEntityData>
	{
		// Token: 0x170097BE RID: 38846
		// (get) Token: 0x06042D2E RID: 273710 RVA: 0x01044030 File Offset: 0x01042230
		public new static List<Type> Dependencies
		{
			get
			{
				return new List<Type>
				{
					typeof(DangoBrawlDataComponent)
				};
			}
		}

		// Token: 0x06042D2F RID: 273711 RVA: 0x01044047 File Offset: 0x01042247
		public bool IsTerminalAnimFinished()
		{
			return this.IsTerminalFinished;
		}

		// Token: 0x06042D30 RID: 273712 RVA: 0x0104404F File Offset: 0x0104224F
		public bool IsPlayingDefeat()
		{
			return this.CurrentState == EDangoBrawlMontageState.Defeat;
		}

		// Token: 0x06042D31 RID: 273713 RVA: 0x0104405A File Offset: 0x0104225A
		public float GetJumpDurationMs()
		{
			return this.JumpDurationMs;
		}

		// Token: 0x06042D32 RID: 273714 RVA: 0x01044062 File Offset: 0x01042262
		public float GetLandDurationMs()
		{
			return this.LandDurationMs;
		}

		// Token: 0x170097BF RID: 38847
		// (get) Token: 0x06042D33 RID: 273715 RVA: 0x0104406C File Offset: 0x0104226C
		private string SideTag
		{
			get
			{
				DangoBrawlDataComponent component = base.OwnerEntity.GetComponent<DangoBrawlDataComponent>();
				if (component == null)
				{
					return "?";
				}
				if (component.Data.Identity != EDangoBrawlSide.Self)
				{
					return "Opponent";
				}
				return "Self";
			}
		}

		// Token: 0x06042D34 RID: 273716 RVA: 0x010440A6 File Offset: 0x010422A6
		protected override void OnInit()
		{
			base.SetNeedTick(true);
		}

		// Token: 0x06042D35 RID: 273717 RVA: 0x010440AF File Offset: 0x010422AF
		public void ResetTerminalState()
		{
			this.IsTerminated = false;
			this.IsTerminalFinished = false;
			this.PendingVictory = false;
			this.ChainAdvancedFrom = null;
			this.MovePhase = DangoBrawlMontageComponent.EMovePhase.None;
		}

		// Token: 0x06042D36 RID: 273718 RVA: 0x010440D4 File Offset: 0x010422D4
		public unsafe UniTask LoadAsync()
		{
			if (this.IsDisposed)
			{
				Log.Instance.Error(ELogModule.DangoBrawl, ELogAuthor.WHJ, "DangoBrawlMontageComponent 已 End，禁止 LoadAsync", default(ReadOnlySpan<ValueTuple<string, object>>));
				return UniTask.CompletedTask;
			}
			if (this.LoadSource != null)
			{
				return this.LoadSource.Task;
			}
			DangoBrawlDataComponent dangoBrawlDataComponent = base.OwnerEntity.CheckGetComponent<DangoBrawlDataComponent>();
			if (dangoBrawlDataComponent == null)
			{
				return UniTask.CompletedTask;
			}
			int dangoId = dangoBrawlDataComponent.Data.DangoId;
			bool flag = dangoBrawlDataComponent.Data.Identity == EDangoBrawlSide.Self;
			string value = "";
			string value2 = "";
			string value3 = "";
			string value4 = "";
			string value5 = "";
			string value6 = "";
			if (flag)
			{
				DangoBrawlRole? roleConfigById = DangoBrawlConfig.Instance.GetRoleConfigById(dangoId);
				if (roleConfigById != null)
				{
					value = roleConfigById.Value.MontageIdle;
					value2 = roleConfigById.Value.MontageAttack;
					value3 = roleConfigById.Value.MontageAttackLoop;
					value4 = roleConfigById.Value.MontageAttackEnd;
					value5 = roleConfigById.Value.MontageSuccess;
					value6 = roleConfigById.Value.MontageFail;
				}
			}
			else
			{
				DangoBrawlOpponent? opponentConfigById = DangoBrawlConfig.Instance.GetOpponentConfigById(dangoId);
				if (opponentConfigById != null)
				{
					value = opponentConfigById.Value.MontageIdle;
					value2 = opponentConfigById.Value.MontageAttack;
					value3 = opponentConfigById.Value.MontageAttackLoop;
					value4 = opponentConfigById.Value.MontageAttackEnd;
					value5 = opponentConfigById.Value.MontageSuccess;
					value6 = opponentConfigById.Value.MontageFail;
				}
			}
			Dictionary<EDangoBrawlMontageState, string> dictionary = new Dictionary<EDangoBrawlMontageState, string>();
			dictionary[EDangoBrawlMontageState.Idle] = value;
			dictionary[EDangoBrawlMontageState.AttackStart] = value2;
			dictionary[EDangoBrawlMontageState.AttackLoop] = value3;
			dictionary[EDangoBrawlMontageState.AttackEnd] = value4;
			dictionary[EDangoBrawlMontageState.Victory] = value5;
			dictionary[EDangoBrawlMontageState.Defeat] = value6;
			UniTaskCompletionSource tcs = new UniTaskCompletionSource();
			this.LoadSource = tcs;
			List<KeyValuePair<EDangoBrawlMontageState, string>> list = new List<KeyValuePair<EDangoBrawlMontageState, string>>();
			foreach (KeyValuePair<EDangoBrawlMontageState, string> item in dictionary)
			{
				if (!string.IsNullOrEmpty(item.Value))
				{
					list.Add(item);
				}
			}
			if (list.Count == 0)
			{
				tcs.TrySetResult();
				return tcs.Task;
			}
			int remaining = list.Count;
			foreach (KeyValuePair<EDangoBrawlMontageState, string> keyValuePair in list)
			{
				EDangoBrawlMontageState state = keyValuePair.Key;
				string path = keyValuePair.Value;
				ResourceSystem.Instance.LoadAsync<UAnimMontage>(path, delegate([Nullable(2)] UAnimMontage montage, string _)
				{
					if (this.IsDisposed)
					{
						remaining--;
						if (remaining == 0)
						{
							tcs.TrySetResult();
						}
						return;
					}
					if (montage == null)
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.DangoBrawl;
						ELogAuthor author = ELogAuthor.WHJ;
						string message = "DangoBrawlMontageComponent 加载蒙太奇失败";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("state", state);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("path", path);
						instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					}
					else
					{
						this.MontageMap[state] = montage;
						if (state == EDangoBrawlMontageState.AttackStart)
						{
							this.JumpDurationMs = montage.GetPlayLength() * 1000f;
						}
						else if (state == EDangoBrawlMontageState.AttackEnd)
						{
							this.LandDurationMs = montage.GetPlayLength() * 1000f;
						}
					}
					remaining--;
					if (remaining == 0)
					{
						tcs.TrySetResult();
					}
				}, 100, "js_undefined");
			}
			return tcs.Task;
		}

		// Token: 0x06042D37 RID: 273719 RVA: 0x01044404 File Offset: 0x01042604
		public void PlayMontage(EDangoBrawlMontageState state)
		{
			if (this.IsTerminated)
			{
				return;
			}
			UAnimInstance animInstance = this.GetAnimInstance();
			if (animInstance == null)
			{
				return;
			}
			UAnimMontage montageToPlay;
			if (!this.MontageMap.TryGetValue(state, out montageToPlay))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.DangoBrawl;
				ELogAuthor author = ELogAuthor.WHJ;
				string message = "DangoBrawlMontageComponent 播放失败：未加载该状态的蒙太奇";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("state", state);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (state == EDangoBrawlMontageState.AttackStart)
			{
				this.ChainAdvancedFrom = null;
			}
			this.CurrentState = state;
			this.TrySubscribeMontageEnded(animInstance);
			animInstance.Montage_Play(montageToPlay, 1f, EMontagePlayReturnType.MontageLength, 0f, true);
			if (state == EDangoBrawlMontageState.AttackStart)
			{
				this.StartRising();
				return;
			}
			if (state == EDangoBrawlMontageState.AttackEnd)
			{
				this.StartFalling();
			}
		}

		// Token: 0x06042D38 RID: 273720 RVA: 0x010444A8 File Offset: 0x010426A8
		public void PlayDefeat()
		{
			if (this.IsTerminated)
			{
				return;
			}
			this.IsTerminated = true;
			UAnimInstance animInstance = this.GetAnimInstance();
			if (animInstance == null)
			{
				return;
			}
			UAnimMontage montageToPlay;
			if (this.MontageMap.TryGetValue(EDangoBrawlMontageState.Defeat, out montageToPlay))
			{
				this.CurrentState = EDangoBrawlMontageState.Defeat;
				this.TrySubscribeMontageEnded(animInstance);
				animInstance.Montage_Play(montageToPlay, 1f, EMontagePlayReturnType.MontageLength, 0f, true);
			}
			this.StartFallingProportional();
		}

		// Token: 0x06042D39 RID: 273721 RVA: 0x01044508 File Offset: 0x01042708
		public void PlayVictorySequence()
		{
			if (this.IsTerminated)
			{
				return;
			}
			switch (this.CurrentState)
			{
			case EDangoBrawlMontageState.Idle:
				this.PlayVictory();
				return;
			case EDangoBrawlMontageState.AttackLoop:
				this.PendingVictory = true;
				this.PlayMontage(EDangoBrawlMontageState.AttackEnd);
				return;
			case EDangoBrawlMontageState.AttackEnd:
				this.PlayVictory();
				return;
			}
			this.PendingVictory = true;
		}

		// Token: 0x06042D3A RID: 273722 RVA: 0x01044564 File Offset: 0x01042764
		private void PlayVictory()
		{
			if (this.IsTerminated)
			{
				return;
			}
			this.IsTerminated = true;
			UAnimInstance animInstance = this.GetAnimInstance();
			if (animInstance == null)
			{
				return;
			}
			UAnimMontage montageToPlay;
			if (this.MontageMap.TryGetValue(EDangoBrawlMontageState.Victory, out montageToPlay))
			{
				this.CurrentState = EDangoBrawlMontageState.Victory;
				this.TrySubscribeMontageEnded(animInstance);
				animInstance.Montage_Play(montageToPlay, 1f, EMontagePlayReturnType.MontageLength, 0f, true);
				this.PostRoundWinAudio();
			}
		}

		// Token: 0x06042D3B RID: 273723 RVA: 0x010445C4 File Offset: 0x010427C4
		private void PostRoundWinAudio()
		{
			DangoBrawlDataComponent component = base.OwnerEntity.GetComponent<DangoBrawlDataComponent>();
			if (component == null)
			{
				return;
			}
			bool flag = component.Data.Identity == EDangoBrawlSide.Self;
			int dangoId = component.Data.DangoId;
			DangoBrawlRole? dangoBrawlRole;
			DangoBrawlOpponent? dangoBrawlOpponent;
			string text = flag ? ((DangoBrawlConfig.Instance.GetRoleConfigById(dangoId) != null) ? dangoBrawlRole.GetValueOrDefault().AudioRoundWin : null) : ((DangoBrawlConfig.Instance.GetOpponentConfigById(dangoId) != null) ? dangoBrawlOpponent.GetValueOrDefault().AudioRoundWin : null);
			if (string.IsNullOrEmpty(text))
			{
				return;
			}
			DangoBrawlActorComponent component2 = base.OwnerEntity.GetComponent<DangoBrawlActorComponent>();
			ACharacter acharacter = (component2 != null) ? component2.SpawnedActor : null;
			if (acharacter == null || !acharacter.IsValid())
			{
				return;
			}
			AudioSystem.Instance.PostEvent(text, acharacter, null);
		}

		// Token: 0x06042D3C RID: 273724 RVA: 0x0104469C File Offset: 0x0104289C
		public void PauseMontage()
		{
			DangoBrawlActorComponent component = base.OwnerEntity.GetComponent<DangoBrawlActorComponent>();
			if (component == null || !component.IsAnimationReady)
			{
				return;
			}
			UAnimInstance animInstance = this.GetAnimInstance();
			if (animInstance == null)
			{
				return;
			}
			animInstance.Montage_Pause(null);
		}

		// Token: 0x06042D3D RID: 273725 RVA: 0x010446CC File Offset: 0x010428CC
		public void ResumeMontage()
		{
			DangoBrawlActorComponent component = base.OwnerEntity.GetComponent<DangoBrawlActorComponent>();
			if (component == null || !component.IsAnimationReady)
			{
				return;
			}
			UAnimInstance animInstance = this.GetAnimInstance();
			if (animInstance == null)
			{
				return;
			}
			UAnimMontage montage;
			if (this.MontageMap.TryGetValue(this.CurrentState, out montage))
			{
				animInstance.Montage_Resume(montage);
			}
		}

		// Token: 0x06042D3E RID: 273726 RVA: 0x01044720 File Offset: 0x01042920
		private void StartRising()
		{
			DangoBrawlActorComponent component = base.OwnerEntity.GetComponent<DangoBrawlActorComponent>();
			if (component == null)
			{
				return;
			}
			double bornLocationZ = component.GetBornLocationZ();
			float dangoJumpHeight = DangoBrawlConfig.Instance.GetDangoJumpHeight();
			this.MovePhase = DangoBrawlMontageComponent.EMovePhase.Rising;
			this.MoveElapsedMs = 0f;
			this.MoveDurationMs = this.JumpDurationMs;
			this.MoveFromZ = bornLocationZ;
			this.MoveToZ = bornLocationZ + (double)dangoJumpHeight;
		}

		// Token: 0x06042D3F RID: 273727 RVA: 0x01044780 File Offset: 0x01042980
		private void StartFalling()
		{
			DangoBrawlActorComponent component = base.OwnerEntity.GetComponent<DangoBrawlActorComponent>();
			if (component == null)
			{
				return;
			}
			double bornLocationZ = component.GetBornLocationZ();
			this.MovePhase = DangoBrawlMontageComponent.EMovePhase.Falling;
			this.MoveElapsedMs = 0f;
			this.MoveDurationMs = this.LandDurationMs;
			this.MoveFromZ = component.GetActorLocationZ();
			this.MoveToZ = bornLocationZ;
		}

		// Token: 0x06042D40 RID: 273728 RVA: 0x010447D8 File Offset: 0x010429D8
		private void StartFallingProportional()
		{
			DangoBrawlActorComponent component = base.OwnerEntity.GetComponent<DangoBrawlActorComponent>();
			if (component == null)
			{
				return;
			}
			double bornLocationZ = component.GetBornLocationZ();
			double actorLocationZ = component.GetActorLocationZ();
			float dangoJumpHeight = DangoBrawlConfig.Instance.GetDangoJumpHeight();
			double num = actorLocationZ - bornLocationZ;
			if (num <= 0.0 || dangoJumpHeight <= 0f)
			{
				this.MovePhase = DangoBrawlMontageComponent.EMovePhase.None;
				return;
			}
			double num2 = num / (double)dangoJumpHeight;
			if (num2 > 1.0)
			{
				num2 = 1.0;
			}
			this.MovePhase = DangoBrawlMontageComponent.EMovePhase.Falling;
			this.MoveElapsedMs = 0f;
			this.MoveDurationMs = (float)((double)this.LandDurationMs * num2);
			this.MoveFromZ = actorLocationZ;
			this.MoveToZ = bornLocationZ;
		}

		// Token: 0x06042D41 RID: 273729 RVA: 0x01044880 File Offset: 0x01042A80
		protected override void OnTick(float deltaTime)
		{
			if (this.MovePhase == DangoBrawlMontageComponent.EMovePhase.None)
			{
				return;
			}
			DangoBrawlActorComponent component = base.OwnerEntity.GetComponent<DangoBrawlActorComponent>();
			if (component == null)
			{
				this.MovePhase = DangoBrawlMontageComponent.EMovePhase.None;
				return;
			}
			this.MoveElapsedMs += deltaTime;
			float num = (this.MoveDurationMs > 0f) ? (this.MoveElapsedMs / this.MoveDurationMs) : 1f;
			if (num >= 1f)
			{
				num = 1f;
			}
			double actorLocationZ = this.MoveFromZ + (this.MoveToZ - this.MoveFromZ) * (double)num;
			component.SetActorLocationZ(actorLocationZ);
			if (num >= 1f)
			{
				this.MovePhase = DangoBrawlMontageComponent.EMovePhase.None;
			}
		}

		// Token: 0x06042D42 RID: 273730 RVA: 0x0104491C File Offset: 0x01042B1C
		public void AddEndedListener(EDangoBrawlMontageState state, TMontageEndedCallback callback)
		{
			HashSet<TMontageEndedCallback> hashSet;
			if (!this.EndCallbacks.TryGetValue(state, out hashSet))
			{
				hashSet = new HashSet<TMontageEndedCallback>();
				this.EndCallbacks[state] = hashSet;
			}
			hashSet.Add(callback);
		}

		// Token: 0x06042D43 RID: 273731 RVA: 0x01044954 File Offset: 0x01042B54
		public void RemoveEndedListener(EDangoBrawlMontageState state, TMontageEndedCallback callback)
		{
			HashSet<TMontageEndedCallback> hashSet;
			if (this.EndCallbacks.TryGetValue(state, out hashSet))
			{
				hashSet.Remove(callback);
			}
		}

		// Token: 0x06042D44 RID: 273732 RVA: 0x0104497C File Offset: 0x01042B7C
		protected override void OnEnd()
		{
			this.IsDisposed = true;
			if (this.SubscribedAnimInstance != null)
			{
				this.SubscribedAnimInstance.OnMontageEnded.Remove(new Action<UAnimMontage, bool>(this.OnAnyMontageEnded));
				this.SubscribedAnimInstance.OnMontageBlendingOut.Remove(new Action<UAnimMontage, bool>(this.OnAnyMontageBlendingOut));
				this.SubscribedAnimInstance = null;
			}
			this.MontageMap.Clear();
			this.EndCallbacks.Clear();
			this.JumpDurationMs = 0f;
			this.LandDurationMs = 0f;
			this.MovePhase = DangoBrawlMontageComponent.EMovePhase.None;
			this.IsTerminated = false;
			this.IsTerminalFinished = false;
			this.PendingVictory = false;
			this.ChainAdvancedFrom = null;
			this.CurrentState = EDangoBrawlMontageState.Idle;
		}

		// Token: 0x06042D45 RID: 273733 RVA: 0x01044A30 File Offset: 0x01042C30
		[NullableContext(2)]
		private UAnimInstance GetAnimInstance()
		{
			DangoBrawlActorComponent component = base.OwnerEntity.GetComponent<DangoBrawlActorComponent>();
			if (component == null)
			{
				return null;
			}
			return component.GetAnimInstance();
		}

		// Token: 0x06042D46 RID: 273734 RVA: 0x01044A54 File Offset: 0x01042C54
		private void TrySubscribeMontageEnded(UAnimInstance animInstance)
		{
			if (this.SubscribedAnimInstance == animInstance)
			{
				return;
			}
			if (this.SubscribedAnimInstance != null)
			{
				this.SubscribedAnimInstance.OnMontageEnded.Remove(new Action<UAnimMontage, bool>(this.OnAnyMontageEnded));
				this.SubscribedAnimInstance.OnMontageBlendingOut.Remove(new Action<UAnimMontage, bool>(this.OnAnyMontageBlendingOut));
			}
			animInstance.OnMontageEnded.Add(new Action<UAnimMontage, bool>(this.OnAnyMontageEnded));
			animInstance.OnMontageBlendingOut.Add(new Action<UAnimMontage, bool>(this.OnAnyMontageBlendingOut));
			this.SubscribedAnimInstance = animInstance;
		}

		// Token: 0x06042D47 RID: 273735 RVA: 0x01044AE0 File Offset: 0x01042CE0
		[NullableContext(2)]
		private EDangoBrawlMontageState? ResolveState(UAnimMontage montage)
		{
			if (montage == null)
			{
				return null;
			}
			foreach (KeyValuePair<EDangoBrawlMontageState, UAnimMontage> keyValuePair in this.MontageMap)
			{
				if (keyValuePair.Value == montage)
				{
					return new EDangoBrawlMontageState?(keyValuePair.Key);
				}
			}
			return null;
		}

		// Token: 0x06042D48 RID: 273736 RVA: 0x01044B60 File Offset: 0x01042D60
		private bool TryAdvanceChain(UAnimMontage montage, EDangoBrawlMontageState endedState, bool interrupted)
		{
			if (this.IsTerminated || this.ChainAdvancedFrom == montage)
			{
				return false;
			}
			if (this.PendingVictory)
			{
				if (endedState == EDangoBrawlMontageState.AttackStart)
				{
					this.ChainAdvancedFrom = montage;
					this.PlayMontage(EDangoBrawlMontageState.AttackEnd);
					return true;
				}
				if (endedState == EDangoBrawlMontageState.AttackEnd || endedState == EDangoBrawlMontageState.AttackLoop)
				{
					this.ChainAdvancedFrom = montage;
					this.PlayVictory();
					return true;
				}
			}
			else if (!interrupted && endedState == EDangoBrawlMontageState.AttackStart)
			{
				this.ChainAdvancedFrom = montage;
				this.PlayMontage(EDangoBrawlMontageState.AttackLoop);
				return true;
			}
			return false;
		}

		// Token: 0x06042D49 RID: 273737 RVA: 0x01044BCC File Offset: 0x01042DCC
		[NullableContext(2)]
		private void OnAnyMontageBlendingOut(UAnimMontage montage, bool interrupted)
		{
			if (montage == null || interrupted)
			{
				return;
			}
			EDangoBrawlMontageState? edangoBrawlMontageState = this.ResolveState(montage);
			if (edangoBrawlMontageState == null)
			{
				return;
			}
			this.TryAdvanceChain(montage, edangoBrawlMontageState.Value, interrupted);
		}

		// Token: 0x06042D4A RID: 273738 RVA: 0x01044C04 File Offset: 0x01042E04
		[NullableContext(2)]
		private void OnAnyMontageEnded(UAnimMontage montage, bool interrupted)
		{
			if (montage == null)
			{
				return;
			}
			EDangoBrawlMontageState? edangoBrawlMontageState = this.ResolveState(montage);
			if (edangoBrawlMontageState == null)
			{
				return;
			}
			if (edangoBrawlMontageState.Value == EDangoBrawlMontageState.Victory || edangoBrawlMontageState.Value == EDangoBrawlMontageState.Defeat)
			{
				this.IsTerminalFinished = true;
			}
			this.TryAdvanceChain(montage, edangoBrawlMontageState.Value, interrupted);
			HashSet<TMontageEndedCallback> hashSet;
			if (!this.EndCallbacks.TryGetValue(edangoBrawlMontageState.Value, out hashSet))
			{
				return;
			}
			foreach (TMontageEndedCallback tmontageEndedCallback in hashSet)
			{
				tmontageEndedCallback(interrupted);
			}
		}

		// Token: 0x04022C59 RID: 142425
		private readonly Dictionary<EDangoBrawlMontageState, UAnimMontage> MontageMap = new Dictionary<EDangoBrawlMontageState, UAnimMontage>();

		// Token: 0x04022C5A RID: 142426
		private readonly Dictionary<EDangoBrawlMontageState, HashSet<TMontageEndedCallback>> EndCallbacks = new Dictionary<EDangoBrawlMontageState, HashSet<TMontageEndedCallback>>();

		// Token: 0x04022C5B RID: 142427
		[Nullable(2)]
		private UAnimInstance SubscribedAnimInstance;

		// Token: 0x04022C5C RID: 142428
		[Nullable(2)]
		private UniTaskCompletionSource LoadSource;

		// Token: 0x04022C5D RID: 142429
		private bool IsDisposed;

		// Token: 0x04022C5E RID: 142430
		private float JumpDurationMs;

		// Token: 0x04022C5F RID: 142431
		private float LandDurationMs;

		// Token: 0x04022C60 RID: 142432
		private DangoBrawlMontageComponent.EMovePhase MovePhase;

		// Token: 0x04022C61 RID: 142433
		private float MoveElapsedMs;

		// Token: 0x04022C62 RID: 142434
		private float MoveDurationMs;

		// Token: 0x04022C63 RID: 142435
		private double MoveFromZ;

		// Token: 0x04022C64 RID: 142436
		private double MoveToZ;

		// Token: 0x04022C65 RID: 142437
		private EDangoBrawlMontageState CurrentState;

		// Token: 0x04022C66 RID: 142438
		private bool IsTerminated;

		// Token: 0x04022C67 RID: 142439
		private bool IsTerminalFinished;

		// Token: 0x04022C68 RID: 142440
		private bool PendingVictory;

		// Token: 0x04022C69 RID: 142441
		[Nullable(2)]
		private UAnimMontage ChainAdvancedFrom;

		// Token: 0x0200CA62 RID: 51810
		[NullableContext(0)]
		private enum EMovePhase
		{
			// Token: 0x0403D2CF RID: 250575
			None,
			// Token: 0x0403D2D0 RID: 250576
			Rising,
			// Token: 0x0403D2D1 RID: 250577
			Falling
		}
	}
}
