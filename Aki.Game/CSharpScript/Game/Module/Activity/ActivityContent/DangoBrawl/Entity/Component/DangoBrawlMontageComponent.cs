using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.ActivityGamePlay.ActivityGameplayEntity.Component;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Entity.Component
{
	// Token: 0x020057E9 RID: 22505
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DangoBrawlMontageComponent : ActivityGameplayComponentBase<IDangoBrawlEntityData>
	{
		// Token: 0x17006AFE RID: 27390
		// (get) Token: 0x06037886 RID: 227462 RVA: 0x00F855AC File Offset: 0x00F837AC
		public override Type[] Dependencies
		{
			get
			{
				return new Type[]
				{
					typeof(DangoBrawlDataComponent)
				};
			}
		}

		// Token: 0x06037887 RID: 227463 RVA: 0x00F855C1 File Offset: 0x00F837C1
		public bool IsTerminalAnimFinished()
		{
			return this.IsTerminalFinished;
		}

		// Token: 0x06037888 RID: 227464 RVA: 0x00F855C9 File Offset: 0x00F837C9
		public bool IsPlayingDefeat()
		{
			return this.CurrentState == EDangoBrawlMontageState.Defeat;
		}

		// Token: 0x06037889 RID: 227465 RVA: 0x00F855D4 File Offset: 0x00F837D4
		public float GetJumpDurationMs()
		{
			return this.JumpDurationMs;
		}

		// Token: 0x0603788A RID: 227466 RVA: 0x00F855DC File Offset: 0x00F837DC
		public float GetLandDurationMs()
		{
			return this.LandDurationMs;
		}

		// Token: 0x17006AFF RID: 27391
		// (get) Token: 0x0603788B RID: 227467 RVA: 0x00F855E4 File Offset: 0x00F837E4
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

		// Token: 0x0603788C RID: 227468 RVA: 0x00F8561E File Offset: 0x00F8381E
		protected override void OnInit()
		{
			base.SetNeedTick(true);
		}

		// Token: 0x0603788D RID: 227469 RVA: 0x00F85627 File Offset: 0x00F83827
		public void ResetTerminalState()
		{
			this.IsTerminated = false;
			this.IsTerminalFinished = false;
			this.PendingVictory = false;
			this.ChainAdvancedFrom = null;
			this.MovePhase = DangoBrawlMontageComponent.EMovePhase.None;
		}

		// Token: 0x0603788E RID: 227470 RVA: 0x00F8564C File Offset: 0x00F8384C
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

		// Token: 0x0603788F RID: 227471 RVA: 0x00F8597C File Offset: 0x00F83B7C
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

		// Token: 0x06037890 RID: 227472 RVA: 0x00F85A20 File Offset: 0x00F83C20
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

		// Token: 0x06037891 RID: 227473 RVA: 0x00F85A80 File Offset: 0x00F83C80
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

		// Token: 0x06037892 RID: 227474 RVA: 0x00F85ADC File Offset: 0x00F83CDC
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

		// Token: 0x06037893 RID: 227475 RVA: 0x00F85B3C File Offset: 0x00F83D3C
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

		// Token: 0x06037894 RID: 227476 RVA: 0x00F85C14 File Offset: 0x00F83E14
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

		// Token: 0x06037895 RID: 227477 RVA: 0x00F85C44 File Offset: 0x00F83E44
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

		// Token: 0x06037896 RID: 227478 RVA: 0x00F85C98 File Offset: 0x00F83E98
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

		// Token: 0x06037897 RID: 227479 RVA: 0x00F85CF8 File Offset: 0x00F83EF8
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

		// Token: 0x06037898 RID: 227480 RVA: 0x00F85D50 File Offset: 0x00F83F50
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

		// Token: 0x06037899 RID: 227481 RVA: 0x00F85DF8 File Offset: 0x00F83FF8
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

		// Token: 0x0603789A RID: 227482 RVA: 0x00F85E94 File Offset: 0x00F84094
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

		// Token: 0x0603789B RID: 227483 RVA: 0x00F85ECC File Offset: 0x00F840CC
		public void RemoveEndedListener(EDangoBrawlMontageState state, TMontageEndedCallback callback)
		{
			HashSet<TMontageEndedCallback> hashSet;
			if (this.EndCallbacks.TryGetValue(state, out hashSet))
			{
				hashSet.Remove(callback);
			}
		}

		// Token: 0x0603789C RID: 227484 RVA: 0x00F85EF4 File Offset: 0x00F840F4
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

		// Token: 0x0603789D RID: 227485 RVA: 0x00F85FA8 File Offset: 0x00F841A8
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

		// Token: 0x0603789E RID: 227486 RVA: 0x00F85FCC File Offset: 0x00F841CC
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

		// Token: 0x0603789F RID: 227487 RVA: 0x00F86058 File Offset: 0x00F84258
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

		// Token: 0x060378A0 RID: 227488 RVA: 0x00F860D8 File Offset: 0x00F842D8
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

		// Token: 0x060378A1 RID: 227489 RVA: 0x00F86144 File Offset: 0x00F84344
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

		// Token: 0x060378A2 RID: 227490 RVA: 0x00F8617C File Offset: 0x00F8437C
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

		// Token: 0x0401D4B5 RID: 119989
		private readonly Dictionary<EDangoBrawlMontageState, UAnimMontage> MontageMap = new Dictionary<EDangoBrawlMontageState, UAnimMontage>();

		// Token: 0x0401D4B6 RID: 119990
		private readonly Dictionary<EDangoBrawlMontageState, HashSet<TMontageEndedCallback>> EndCallbacks = new Dictionary<EDangoBrawlMontageState, HashSet<TMontageEndedCallback>>();

		// Token: 0x0401D4B7 RID: 119991
		[Nullable(2)]
		private UAnimInstance SubscribedAnimInstance;

		// Token: 0x0401D4B8 RID: 119992
		[Nullable(2)]
		private UniTaskCompletionSource LoadSource;

		// Token: 0x0401D4B9 RID: 119993
		private bool IsDisposed;

		// Token: 0x0401D4BA RID: 119994
		private float JumpDurationMs;

		// Token: 0x0401D4BB RID: 119995
		private float LandDurationMs;

		// Token: 0x0401D4BC RID: 119996
		private DangoBrawlMontageComponent.EMovePhase MovePhase;

		// Token: 0x0401D4BD RID: 119997
		private float MoveElapsedMs;

		// Token: 0x0401D4BE RID: 119998
		private float MoveDurationMs;

		// Token: 0x0401D4BF RID: 119999
		private double MoveFromZ;

		// Token: 0x0401D4C0 RID: 120000
		private double MoveToZ;

		// Token: 0x0401D4C1 RID: 120001
		private EDangoBrawlMontageState CurrentState;

		// Token: 0x0401D4C2 RID: 120002
		private bool IsTerminated;

		// Token: 0x0401D4C3 RID: 120003
		private bool IsTerminalFinished;

		// Token: 0x0401D4C4 RID: 120004
		private bool PendingVictory;

		// Token: 0x0401D4C5 RID: 120005
		[Nullable(2)]
		private UAnimMontage ChainAdvancedFrom;

		// Token: 0x0200B42C RID: 46124
		[NullableContext(0)]
		private enum EMovePhase
		{
			// Token: 0x04037BAE RID: 228270
			None,
			// Token: 0x04037BAF RID: 228271
			Rising,
			// Token: 0x04037BB0 RID: 228272
			Falling
		}
	}
}
