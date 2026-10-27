using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Audio;
using CSharpScript.Core.Common;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Module.Audio;
using UnrealEngine;

// Token: 0x02000269 RID: 617
[NullableContext(1)]
[Nullable(0)]
[TickController(0)]
public class EffectAudioController : ControllerBase
{
	// Token: 0x170005C3 RID: 1475
	// (get) Token: 0x06002598 RID: 9624 RVA: 0x000E116E File Offset: 0x000DF36E
	protected override bool IsTickEvenPausedInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x06002599 RID: 9625 RVA: 0x000E1174 File Offset: 0x000DF374
	protected override bool OnInit()
	{
		for (int i = 0; i < 20; i++)
		{
			AActor aactor = ActorSystem.Instance.Get(BP_EffectAudio_C.StaticClass(), this.ZeroTransform.ToUeTransform(), null, true);
			if (aactor != null)
			{
				aactor.bIsPermanentActor = true;
				ActorSystem.Instance.Put("特效音频播放Actor预创建回池", aactor, null);
			}
		}
		return true;
	}

	// Token: 0x0600259A RID: 9626 RVA: 0x000E11C8 File Offset: 0x000DF3C8
	protected override void OnTick(float delta)
	{
		CharacterModel instance = CharacterModel.Instance;
		float num = (instance != null) ? instance.InverseSelfCenteredTimeDilation : 1f;
		this.DeltaTime += delta * num;
		if (this.DeltaTime < 25f)
		{
			return;
		}
		this.DeltaTime = 0f;
		this.HandlePendingMap();
		this.UpdateLocationOffsets();
	}

	// Token: 0x0600259B RID: 9627 RVA: 0x000E1224 File Offset: 0x000DF424
	private unsafe void UpdateLocationOffsets()
	{
		if (this.ActorInfoMap.Count == 0)
		{
			return;
		}
		foreach (KeyValuePair<int, IEffectActorInfo> keyValuePair in this.ActorInfoMap)
		{
			IEffectActorInfo value = keyValuePair.Value;
			if (value.EffectUidList.Count != 0)
			{
				foreach (int key in value.EffectUidList)
				{
					IEffectAudioInfo effectAudioInfo;
					if (this.AudioInfoMap.TryGetValue(key, out effectAudioInfo) && effectAudioInfo.EffectActor != null)
					{
						AActor aactor = effectAudioInfo.EffectActor as AActor;
						if (aactor == null || aactor.IsValid())
						{
							if (effectAudioInfo.IsTransform.GetValueOrDefault())
							{
								if (!value.EffectModel.Start)
								{
									object effectActor = effectAudioInfo.EffectActor;
									if (effectActor is FTransformDouble)
									{
										FVectorDouble fvectorDouble = ((FTransformDouble)effectActor).GetLocation();
										FVector fvector = fvectorDouble;
										FVector value2 = new FVector(fvector.X, fvector.Y, fvector.Z);
										value.Locations.Add(value2);
									}
								}
							}
							else
							{
								AActor aactor2 = effectAudioInfo.EffectActor as AActor;
								if (aactor2 == null)
								{
									Log instance = Log.Instance;
									ELogModule module = ELogModule.Audio;
									ELogAuthor author = ELogAuthor.CWZ;
									string message = "[EffectAudioCtrl] 类型判断失败";
									<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
									*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ActorUid", value.ActorUid);
									ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
									string item = "GetType";
									object effectActor2 = effectAudioInfo.EffectActor;
									ptr = new ValueTuple<string, object>(item, (effectActor2 != null) ? effectActor2.GetType() : null);
									*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("EffectActor", effectAudioInfo.EffectActor);
									instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
								}
								else
								{
									FVectorDouble fvectorDouble = aactor2.D_K2_GetActorLocation();
									FVector fvector2 = fvectorDouble;
									FVector value3 = new FVector(fvector2.X, fvector2.Y, fvector2.Z);
									EffectModelInfo effectModelInfo = value.EffectModel as EffectModelInfo;
									if (effectModelInfo != null)
									{
										EffectModelAudio model = effectModelInfo.Model;
										if (model == null || model.LocationOffsets.Num() != 0)
										{
											for (int i = 0; i < effectModelInfo.Model.LocationOffsets.Num(); i++)
											{
												TArray<FVector> locations = value.Locations;
												FVector fvector3 = effectModelInfo.Model.LocationOffsets.Get(i);
												locations.Add(value3 + fvector3);
											}
											continue;
										}
									}
									if (value.EffectModel is EventModelInfo)
									{
										value.Locations.Add(value3);
									}
									else
									{
										value.Locations.Add(value3);
									}
								}
							}
						}
					}
				}
				if (value.EffectModel is EventModelInfo && !value.EffectModel.Start)
				{
					AudioSystem.Instance.SetRtpcValue("effect_count", (float)value.EffectUidList.Count, new SetRtpcValueArgs?(new SetRtpcValueArgs(null, null, value.Actor)));
				}
				value.EffectModel.Start = true;
				if (value.Locations.Num() > 0)
				{
					UAkComponent akComponent = value.AkComponent;
					TArray<FVector> locations2 = value.Locations;
					akComponent.SetLocationOffsets(locations2);
					value.Locations.Empty(true);
				}
			}
		}
	}

	// Token: 0x0600259C RID: 9628 RVA: 0x000E15C8 File Offset: 0x000DF7C8
	private IAudioInfo CreateEffectModel(object effectModel)
	{
		EffectModelAudio effectModelAudio = effectModel as EffectModelAudio;
		if (effectModelAudio != null)
		{
			return new EffectModelInfo(effectModelAudio);
		}
		return new EventModelInfo((effectModel as string) ?? "");
	}

	// Token: 0x0600259D RID: 9629 RVA: 0x000E15FA File Offset: 0x000DF7FA
	[NullableContext(2)]
	public int AddPlayEffectAudio([Nullable(new byte[]
	{
		0,
		1,
		1
	})] OneOf<UEffectModelAudio, string> param, [Nullable(new byte[]
	{
		0,
		1
	})] OneOf<AActor, FTransformDouble> effectActor = default(OneOf<AActor, FTransformDouble>), EHitEffectType? effectType = null, ERoleAudioPriorityType? priority = null, Action callback = null, bool? isTransform = null)
	{
		return this.AddPlayEffectAudioInternal(param, effectActor, effectType, priority, callback, isTransform);
	}

	// Token: 0x0600259E RID: 9630 RVA: 0x000E1618 File Offset: 0x000DF818
	[NullableContext(2)]
	private int AddPlayEffectAudioInternal([Nullable(1)] object param, object effectActor, EHitEffectType? effectType, ERoleAudioPriorityType? priority, Action callback, bool? isTransform)
	{
		object effectModel = param;
		if (param is OneOf<UEffectModelAudio, string>)
		{
			OneOf<UEffectModelAudio, string> oneOf = (OneOf<UEffectModelAudio, string>)param;
			effectModel = (oneOf.IsT1 ? oneOf.AsT1 : oneOf.AsT2);
		}
		object obj = effectActor;
		if (effectActor is OneOf<AActor, FTransformDouble>)
		{
			OneOf<AActor, FTransformDouble> oneOf2 = (OneOf<AActor, FTransformDouble>)effectActor;
			obj = (oneOf2.IsT1 ? oneOf2.AsT1 : oneOf2.AsT2);
		}
		IAudioInfo audioInfo = this.CreateEffectModel(effectModel);
		AActor aactor = obj as AActor;
		if (aactor != null)
		{
			EffectModelInfo effectModelInfo = audioInfo as EffectModelInfo;
			if (effectModelInfo != null)
			{
				EffectModelAudio model = effectModelInfo.Model;
				if (model != null && model.EnableOcclusion)
				{
					return this.PostAudioEventFromEffectModel(aactor, effectModelInfo.Model, priority);
				}
			}
		}
		string audioEvent = audioInfo.GetAudioEvent();
		if (string.IsNullOrEmpty(audioEvent) || this.CheckSpecialInstanceDungeonEvent(audioEvent) || this.CheckHitEffectCooldownTime(effectType, audioEvent) || this.CheckSpecialInstanceDungeonCooldown(audioEvent))
		{
			return 0;
		}
		int num = this.EffectAudioUid + 1;
		this.EffectAudioUid = num;
		int num2 = num;
		IEffectAudioInfo value = new EffectAudioInfo
		{
			ActorUid = 0,
			EffectActor = obj,
			IsTransform = isTransform,
			Callback = callback
		};
		this.PendingHandleMap[num2] = value;
		this.PendingEffectModelMap[num2] = new PendingEffectInfo
		{
			EffectModel = audioInfo,
			Priority = priority
		};
		return num2;
	}

	// Token: 0x0600259F RID: 9631 RVA: 0x000E176C File Offset: 0x000DF96C
	[NullableContext(2)]
	public unsafe void OnStopEffectAudio(int uid, string context = null, bool callback = true)
	{
		if (this.EffectModelAudioHandleMap.ContainsKey(uid))
		{
			this.StopAudioEventFromEffectModel(uid);
			return;
		}
		if (this.PendingHandleMap.ContainsKey(uid))
		{
			this.PendingHandleMap.Remove(uid);
			this.PendingEffectModelMap.Remove(uid);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Audio;
			ELogAuthor author = ELogAuthor.CWZ;
			string message = "[EffectAudioCtrl] Audio还在待处理列表中就Stop了";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EffectUid", uid);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		IEffectAudioInfo effectAudioInfo;
		if (!this.AudioInfoMap.TryGetValue(uid, out effectAudioInfo))
		{
			return;
		}
		if (callback && effectAudioInfo.Callback != null)
		{
			effectAudioInfo.Callback();
		}
		int actorUid = effectAudioInfo.ActorUid;
		IEffectActorInfo effectActorInfo;
		if (!this.ActorInfoMap.TryGetValue(actorUid, out effectActorInfo))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Audio;
			ELogAuthor author2 = ELogAuthor.CWZ;
			string message2 = "[EffectAudioCtrl] ActorInfoMap没有指定ActorUid";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ActorUid", actorUid);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("EffectUid", uid);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		IAudioInfo effectModel = effectActorInfo.EffectModel;
		if (effectModel == null || !effectModel.IsValid())
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.Audio;
			ELogAuthor author3 = ELogAuthor.CWZ;
			string message3 = "[EffectAudioCtrl] EffectModel无效";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("ActorUid", actorUid);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("EffectUid", uid);
			instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			return;
		}
		effectActorInfo.EffectUidList.Remove(uid);
		this.PlayTrailingAudioEvent(effectAudioInfo, effectActorInfo);
		if (effectActorInfo.EffectUidList.Count == 0)
		{
			string audioEvent = effectActorInfo.EffectModel.GetAudioEvent();
			if (!string.IsNullOrEmpty(audioEvent))
			{
				this.AudioEventMap.Remove(audioEvent);
			}
			this.StopAudioEvent(effectActorInfo);
			this.RecycleEffectActor(effectActorInfo, effectActorInfo.Priority);
			this.ActorInfoMap.Remove(actorUid);
		}
		this.AudioInfoMap.Remove(uid);
	}

	// Token: 0x060025A0 RID: 9632 RVA: 0x000E196C File Offset: 0x000DFB6C
	public bool CheckInSpecialInstanceDungeon()
	{
		GameModeModel instance = GameModeModel.Instance;
		InstanceDungeon? instanceDungeon;
		return ((instance != null) ? ((instance.InstanceDungeon != null) ? new int?(instanceDungeon.GetValueOrDefault().MapConfigId) : null) : null).GetValueOrDefault() == 9300;
	}

	// Token: 0x060025A1 RID: 9633 RVA: 0x000E19CC File Offset: 0x000DFBCC
	public bool CheckSpecialInstanceDungeonEvent(string name)
	{
		GameModeModel instance = GameModeModel.Instance;
		InstanceDungeon? instanceDungeon;
		if (((instance != null) ? ((instance.InstanceDungeon != null) ? new int?(instanceDungeon.GetValueOrDefault().MapConfigId) : null) : null).GetValueOrDefault() == 9300)
		{
			if (name.Contains("play_role_com_imp_texture") || name.Contains("play_enm_com_imp_texture"))
			{
				return true;
			}
			if (name.Contains("DA_Au_Role_Common_Imp_Texture"))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060025A2 RID: 9634 RVA: 0x000E1A58 File Offset: 0x000DFC58
	public bool CheckHitEffectCooldownTime(EHitEffectType? effectType, string @event)
	{
		GameModeModel instance = GameModeModel.Instance;
		InstanceDungeon? instanceDungeon;
		if (((instance != null) ? ((instance.InstanceDungeon != null) ? new int?(instanceDungeon.GetValueOrDefault().MapConfigId) : null) : null).GetValueOrDefault() != 9300 || effectType == null || effectType.GetValueOrDefault() == EHitEffectType.NeedAudio)
		{
			return false;
		}
		double num;
		bool flag = Time.Instance.Now - (this.HitEffectMap.TryGetValue(effectType.Value, out num) ? num : 0.0) < 80.0;
		if (!flag)
		{
			this.HitEffectMap[effectType.Value] = Time.Instance.Now;
		}
		return flag;
	}

	// Token: 0x060025A3 RID: 9635 RVA: 0x000E1B24 File Offset: 0x000DFD24
	private void HandlePendingMap()
	{
		if (this.PendingHandleMap.Count == 0)
		{
			return;
		}
		foreach (KeyValuePair<int, IEffectAudioInfo> keyValuePair in this.PendingHandleMap)
		{
			int key = keyValuePair.Key;
			IEffectAudioInfo value = keyValuePair.Value;
			this.HandlePendingItem(key, value);
		}
		foreach (int key2 in this.DeletePendingList)
		{
			this.PendingHandleMap.Remove(key2);
			this.PendingEffectModelMap.Remove(key2);
		}
		this.DeletePendingList.Clear();
		if (this.CurrentSpawnActorCount >= 2 && this.PendingHandleMap.Count != 0)
		{
			this.DeltaTime = 25f;
		}
		this.CurrentSpawnActorCount = 0;
		this.PlayerCtrlEffectModelMap.Clear();
		this.OtherCtrlEffectModelMap.Clear();
	}

	// Token: 0x060025A4 RID: 9636 RVA: 0x000E1C38 File Offset: 0x000DFE38
	private unsafe void HandlePendingItem(int uid, IEffectAudioInfo effectInfo)
	{
		IPendingEffectInfo pendingEffectInfo;
		if (!this.PendingEffectModelMap.TryGetValue(uid, out pendingEffectInfo))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Audio;
			ELogAuthor author = ELogAuthor.CWZ;
			string message = "[EffectAudioCtrl] PendingEffectModelMap不含指定UID";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EffectUid", uid);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		if (!pendingEffectInfo.EffectModel.IsAudioEventValid())
		{
			this.DeletePendingList.Add(uid);
			return;
		}
		if (this.CurrentSpawnActorCount >= 2 && this.CheckNeedSpawnActor(pendingEffectInfo.EffectModel, pendingEffectInfo.Priority))
		{
			return;
		}
		this.DeletePendingList.Add(uid);
		int spawnActorUid = this.GetSpawnActorUid(pendingEffectInfo.EffectModel, pendingEffectInfo.Priority);
		effectInfo.ActorUid = spawnActorUid;
		IEffectActorInfo effectActorInfo;
		if (!this.ActorInfoMap.TryGetValue(spawnActorUid, out effectActorInfo))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Audio;
			ELogAuthor author2 = ELogAuthor.CWZ;
			string message2 = "[EffectAudioCtrl] 未能正常获取指定ActorInfo";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ActorUid", spawnActorUid);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("EffectUid", uid);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("AudioEvent", pendingEffectInfo.EffectModel.GetAudioEvent());
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return;
		}
		effectActorInfo.EffectUidList.Add(uid);
		this.AudioInfoMap[uid] = effectInfo;
	}

	// Token: 0x060025A5 RID: 9637 RVA: 0x000E1D8D File Offset: 0x000DFF8D
	private bool CheckNeedSpawnActor(IAudioInfo effectModel, ERoleAudioPriorityType? priority)
	{
		if (priority.GetValueOrDefault() == ERoleAudioPriorityType.OtherControl)
		{
			return !this.OtherCtrlEffectModelMap.ContainsKey(effectModel.GetCompare());
		}
		return !this.PlayerCtrlEffectModelMap.ContainsKey(effectModel.GetCompare());
	}

	// Token: 0x060025A6 RID: 9638 RVA: 0x000E1DC2 File Offset: 0x000DFFC2
	private int GetSpawnActorUid(IAudioInfo effectModel, ERoleAudioPriorityType? priority)
	{
		if (priority.GetValueOrDefault() == ERoleAudioPriorityType.OtherControl)
		{
			return this.GetActorUidFromMap(effectModel, this.OtherCtrlEffectModelMap, priority);
		}
		return this.GetActorUidFromMap(effectModel, this.PlayerCtrlEffectModelMap, priority);
	}

	// Token: 0x060025A7 RID: 9639 RVA: 0x000E1DEC File Offset: 0x000DFFEC
	private int GetActorUidFromMap(IAudioInfo effectModel, Dictionary<object, int> map, ERoleAudioPriorityType? priority)
	{
		object compare = effectModel.GetCompare();
		if (!map.ContainsKey(compare))
		{
			this.CurrentSpawnActorCount++;
			IEffectActorInfo effectActorInfo = this.CreateEffectActorInfo(effectModel, priority);
			if (effectActorInfo == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Audio;
				ELogAuthor author = ELogAuthor.CWZ;
				string message = "[EffectAudioCtrl] 未能正常SpawnActor";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("AudioEvent", effectModel.GetAudioEvent());
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return 0;
			}
			if (priority != null)
			{
				GameAudioController.Instance.SetRolePriority(priority.Value, effectActorInfo.Actor);
			}
			map[compare] = effectActorInfo.ActorUid;
			this.ActorInfoMap[effectActorInfo.ActorUid] = effectActorInfo;
			string audioEvent = effectModel.GetAudioEvent();
			if (!string.IsNullOrEmpty(audioEvent))
			{
				this.AudioEventMap[audioEvent] = Time.Instance.Now;
				this.PostAudioEvent(effectActorInfo, effectModel, audioEvent);
			}
		}
		return map[compare];
	}

	// Token: 0x060025A8 RID: 9640 RVA: 0x000E1EC8 File Offset: 0x000E00C8
	[return: Nullable(2)]
	private IEffectActorInfo CreateEffectActorInfo(IAudioInfo model, ERoleAudioPriorityType? priority)
	{
		AActor aactor = ActorSystem.Instance.Get(BP_EffectAudio_C.StaticClass(), this.ZeroTransform.ToUeTransform(), null, true);
		if (aactor == null)
		{
			Log.Instance.Error(ELogModule.Audio, ELogAuthor.CWZ, "GetActor失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		aactor.bIsPermanentActor = true;
		UAkComponent uakComponent = aactor.GetComponentByClass(UAkComponent.StaticClass()) as UAkComponent;
		if (uakComponent == null)
		{
			Log.Instance.Error(ELogModule.Audio, ELogAuthor.CWZ, "[EffectAudioCtrl] 获取AkComponent失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			ActorSystem.Instance.Put("获取AkComponent失败", aactor, null);
			return null;
		}
		EffectActorInfo effectActorInfo = new EffectActorInfo();
		int actorUid = this.ActorUid + 1;
		this.ActorUid = actorUid;
		effectActorInfo.ActorUid = actorUid;
		effectActorInfo.Actor = aactor;
		effectActorInfo.AkComponent = uakComponent;
		effectActorInfo.Locations = new TArray<FVector>();
		effectActorInfo.EffectUidList = new HashSet<int>();
		effectActorInfo.AudioHandle = 0;
		effectActorInfo.EffectModel = model;
		effectActorInfo.Priority = priority;
		return effectActorInfo;
	}

	// Token: 0x060025A9 RID: 9641 RVA: 0x000E1FB8 File Offset: 0x000E01B8
	private void RecycleEffectActor(IEffectActorInfo actorHandle, ERoleAudioPriorityType? priority)
	{
		if (priority != null)
		{
			GameAudioController.Instance.SetRolePriority(ERoleAudioPriorityType.PlayerControl, actorHandle.Actor);
		}
		actorHandle.AkComponent.SetComponentTickEnabled(false);
		ActorSystem.Instance.Put("特效音频播放完成Actor回池", actorHandle.Actor, null);
	}

	// Token: 0x060025AA RID: 9642 RVA: 0x000E1FF8 File Offset: 0x000E01F8
	private void PostAudioEvent(IEffectActorInfo actorHandle, IAudioInfo effectModel, string eventName)
	{
		UAkComponent akComponent = actorHandle.AkComponent;
		if (akComponent == null)
		{
			return;
		}
		if (akComponent != null)
		{
			actorHandle.AudioHandle = AudioSystem.Instance.PostEvent(eventName, akComponent, new PostEventArgs?(new PostEventArgs
			{
				StopWhenOwnerDestroyed = new bool?(!Info.Instance.IsGameRunning()),
				CallbackMask = new ECallbackMask?(ECallbackMask.EndOfEvent),
				CallbackHandler = delegate(EAkCallbackType callbackType, UAkCallbackInfo callbackInfo)
				{
					if (actorHandle.AudioHandle == 0 || callbackType != EAkCallbackType.EndOfEvent)
					{
						return;
					}
					foreach (int uid in new List<int>(actorHandle.EffectUidList))
					{
						this.OnStopEffectAudio(uid, "Callback", true);
					}
				}
			}));
		}
	}

	// Token: 0x060025AB RID: 9643 RVA: 0x000E208C File Offset: 0x000E028C
	public int PostAudioEventFromEffectModel(AActor actor, EffectModelAudio effectModel, ERoleAudioPriorityType? priority = null)
	{
		EffectAudioController.<>c__DisplayClass43_0 CS$<>8__locals1 = new EffectAudioController.<>c__DisplayClass43_0();
		CS$<>8__locals1.<>4__this = this;
		EffectAudioController.<>c__DisplayClass43_0 CS$<>8__locals2 = CS$<>8__locals1;
		int num = this.EffectAudioUid + 1;
		this.EffectAudioUid = num;
		CS$<>8__locals2.uid = num;
		this.EffectModelAudioHandleMap[CS$<>8__locals1.uid] = new EffectModelAudioHandleInfo
		{
			AudioHandle = 0,
			EffectModel = effectModel
		};
		UAkComponent akComponent = AudioSystem.Instance.GetAkComponent(actor, new FName?(null), null);
		UAkAudioEvent audioEvent = effectModel.AudioEvent;
		string text = (audioEvent != null) ? audioEvent.GetName() : null;
		if (string.IsNullOrEmpty(text) || akComponent == null)
		{
			return 0;
		}
		if (priority != null)
		{
			GameAudioController.Instance.SetRolePriority(priority.Value, actor);
		}
		akComponent.bEnableOcclusion = effectModel.EnableOcclusion;
		CS$<>8__locals1.audioHandle = 0;
		CS$<>8__locals1.audioHandle = AudioSystem.Instance.PostEvent(text, akComponent, new PostEventArgs?(new PostEventArgs
		{
			StopWhenOwnerDestroyed = new bool?(!Info.Instance.IsGameRunning()),
			CallbackMask = new ECallbackMask?(ECallbackMask.EndOfEvent),
			CallbackHandler = delegate(EAkCallbackType callbackType, UAkCallbackInfo callbackInfo)
			{
				if (CS$<>8__locals1.audioHandle == 0 || callbackType != EAkCallbackType.EndOfEvent)
				{
					return;
				}
				CS$<>8__locals1.<>4__this.StopAudioEventFromEffectModel(CS$<>8__locals1.uid);
			}
		}));
		this.EffectModelAudioHandleMap[CS$<>8__locals1.uid] = new EffectModelAudioHandleInfo
		{
			AudioHandle = CS$<>8__locals1.audioHandle,
			EffectModel = effectModel,
			AkComponent = akComponent
		};
		return CS$<>8__locals1.uid;
	}

	// Token: 0x060025AC RID: 9644 RVA: 0x000E21DC File Offset: 0x000E03DC
	private void StopAudioEventFromEffectModel(int uid)
	{
		EffectModelAudioHandleInfo effectModelAudioHandleInfo;
		if (!this.EffectModelAudioHandleMap.TryGetValue(uid, out effectModelAudioHandleInfo))
		{
			return;
		}
		int audioHandle = effectModelAudioHandleInfo.AudioHandle;
		UAkComponent akComponent = effectModelAudioHandleInfo.AkComponent;
		EffectModelAudio effectModel = effectModelAudioHandleInfo.EffectModel;
		if (audioHandle != 0 && (effectModel == null || !effectModel.KeepAlive))
		{
			AudioSystem.Instance.ExecuteAction(audioHandle, EAudioActionType.Stop, new ExecuteActionArgs?(new ExecuteActionArgs((effectModel != null) ? new int?(effectModel.FadeOutTime) : null, (effectModel != null) ? new EAudioFadeCurve?(effectModel.FadeOutCurve) : null, null)));
		}
		string text;
		if (effectModel == null)
		{
			text = null;
		}
		else
		{
			UAkAudioEvent trailingAudioEvent = effectModel.TrailingAudioEvent;
			text = ((trailingAudioEvent != null) ? trailingAudioEvent.GetName() : null);
		}
		string text2 = text;
		UAkAudioEvent uakAudioEvent = (effectModel != null) ? effectModel.TrailingAudioEvent : null;
		if (!string.IsNullOrEmpty(text2) && uakAudioEvent != null && uakAudioEvent.IsValid() && akComponent != null)
		{
			FVectorDouble fvectorDouble = akComponent.D_K2_GetComponentLocation();
			FTransformDouble value = new FTransformDouble(ref fvectorDouble);
			AudioSystem.Instance.PostEvent(text2, new FTransformDouble?(value), null);
		}
		this.EffectModelAudioHandleMap.Remove(uid);
	}

	// Token: 0x060025AD RID: 9645 RVA: 0x000E22EC File Offset: 0x000E04EC
	private void StopAudioEvent(IEffectActorInfo actorHandle)
	{
		if (actorHandle.AudioHandle == 0)
		{
			return;
		}
		if (actorHandle.EffectModel is EffectModelInfo)
		{
			EffectModelInfo effectModelInfo = actorHandle.EffectModel as EffectModelInfo;
			bool flag;
			if (effectModelInfo == null)
			{
				flag = true;
			}
			else
			{
				EffectModelAudio model = effectModelInfo.Model;
				flag = !((model != null) ? new bool?(model.KeepAlive) : null).GetValueOrDefault();
			}
			if (flag)
			{
				AudioSystem instance = AudioSystem.Instance;
				int audioHandle = actorHandle.AudioHandle;
				EAudioActionType action = EAudioActionType.Stop;
				int? transitionDuration;
				if (effectModelInfo == null)
				{
					transitionDuration = null;
				}
				else
				{
					EffectModelAudio model2 = effectModelInfo.Model;
					transitionDuration = ((model2 != null) ? new int?(model2.FadeOutTime) : null);
				}
				EAudioFadeCurve? transitionFadeCurve;
				if (effectModelInfo == null)
				{
					transitionFadeCurve = null;
				}
				else
				{
					EffectModelAudio model3 = effectModelInfo.Model;
					transitionFadeCurve = ((model3 != null) ? new EAudioFadeCurve?(model3.FadeOutCurve) : null);
				}
				instance.ExecuteAction(audioHandle, action, new ExecuteActionArgs?(new ExecuteActionArgs(transitionDuration, transitionFadeCurve, null)));
				actorHandle.AudioHandle = 0;
				return;
			}
		}
		else
		{
			AudioSystem.Instance.ExecuteAction(actorHandle.AudioHandle, EAudioActionType.Stop, null);
			actorHandle.AudioHandle = 0;
		}
	}

	// Token: 0x060025AE RID: 9646 RVA: 0x000E23F4 File Offset: 0x000E05F4
	private unsafe void PlayTrailingAudioEvent(IEffectAudioInfo effect, IEffectActorInfo actorHandle)
	{
		EffectModelInfo effectModelInfo = actorHandle.EffectModel as EffectModelInfo;
		string text;
		if (effectModelInfo == null)
		{
			text = null;
		}
		else
		{
			EffectModelAudio model = effectModelInfo.Model;
			if (model == null)
			{
				text = null;
			}
			else
			{
				UAkAudioEvent trailingAudioEvent = model.TrailingAudioEvent;
				text = ((trailingAudioEvent != null) ? trailingAudioEvent.GetName() : null);
			}
		}
		string text2 = text;
		UAkAudioEvent uakAudioEvent;
		if (effectModelInfo == null)
		{
			uakAudioEvent = null;
		}
		else
		{
			EffectModelAudio model2 = effectModelInfo.Model;
			uakAudioEvent = ((model2 != null) ? model2.TrailingAudioEvent : null);
		}
		UAkAudioEvent uakAudioEvent2 = uakAudioEvent;
		if (string.IsNullOrEmpty(text2) || (uakAudioEvent2 == null || !uakAudioEvent2.IsValid()) || effect == null)
		{
			return;
		}
		if (uakAudioEvent2.IsInfinite)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Audio;
			ELogAuthor author = ELogAuthor.CWZ;
			string message = "[EffectAudioCtrl] 拖尾AudioEvent事件IsInfinite";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EventName", text2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("EffectModel", effectModelInfo);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("EffectActor", actorHandle.Actor.GetName());
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return;
		}
		FTransformDouble? ftransformDouble = null;
		AActor aactor = effect.EffectActor as AActor;
		if (aactor != null)
		{
			FVectorDouble fvectorDouble = aactor.D_K2_GetActorLocation();
			ftransformDouble = new FTransformDouble?(new FTransformDouble(ref fvectorDouble));
		}
		else
		{
			object effectActor = effect.EffectActor;
			if (effectActor is FTransformDouble)
			{
				FTransformDouble value = (FTransformDouble)effectActor;
				ftransformDouble = new FTransformDouble?(value);
			}
		}
		if (ftransformDouble != null)
		{
			this.AddPlayEffectAudio(text2, ftransformDouble.Value, null, actorHandle.Priority, null, new bool?(true));
		}
	}

	// Token: 0x060025AF RID: 9647 RVA: 0x000E2574 File Offset: 0x000E0774
	private bool CheckSpecialInstanceDungeonCooldown(string @event)
	{
		GameModeModel instance = GameModeModel.Instance;
		InstanceDungeon? instanceDungeon;
		double num;
		return ((instance != null) ? ((instance.InstanceDungeon != null) ? new int?(instanceDungeon.GetValueOrDefault().MapConfigId) : null) : null).GetValueOrDefault() == 9300 && this.AudioEventMap.TryGetValue(@event, out num) && Time.Instance.Now - num < 100.0;
	}

	// Token: 0x060025B0 RID: 9648 RVA: 0x000E2608 File Offset: 0x000E0808
	private string GetHitEffectTypeDesc(EHitEffectType type)
	{
		switch (type)
		{
		case EHitEffectType.OnHitEffect:
			return "受击特效";
		case EHitEffectType.OnHitAudio:
			return "受击音效";
		case EHitEffectType.BulletHitEffect:
			return "子弹的命中音效";
		default:
			return type.ToString();
		}
	}

	// Token: 0x170005C4 RID: 1476
	// (get) Token: 0x060025B1 RID: 9649 RVA: 0x000E263F File Offset: 0x000E083F
	public static EffectAudioController Instance
	{
		get
		{
			return EffectAudioController._Instance;
		}
	}

	// Token: 0x060025B2 RID: 9650 RVA: 0x000E2646 File Offset: 0x000E0846
	public static EffectAudioController GetOrCreateInstance()
	{
		if (EffectAudioController._Instance == null)
		{
			EffectAudioController.CreateInstance();
		}
		return EffectAudioController._Instance;
	}

	// Token: 0x060025B3 RID: 9651 RVA: 0x000E265A File Offset: 0x000E085A
	public static bool CreateInstance()
	{
		if (EffectAudioController._Instance != null)
		{
			return true;
		}
		EffectAudioController._Instance = new EffectAudioController();
		return true;
	}

	// Token: 0x060025B4 RID: 9652 RVA: 0x000E2670 File Offset: 0x000E0870
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060025B5 RID: 9653 RVA: 0x000E2672 File Offset: 0x000E0872
	public static void ResetStaticDefaultValue()
	{
		EffectAudioController._Instance = null;
	}

	// Token: 0x060025B6 RID: 9654 RVA: 0x000E267A File Offset: 0x000E087A
	static EffectAudioController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(EffectAudioController.CreateStaticDefaultValue), new Action(EffectAudioController.ResetStaticDefaultValue));
	}

	// Token: 0x04002445 RID: 9285
	private const int SPECIAL_MAP_ID = 9300;

	// Token: 0x04002446 RID: 9286
	private const int SPECIAL_MAP_AUDIO_CD = 80;

	// Token: 0x04002447 RID: 9287
	private const int SPECIAL_MAP_EVENT_SPAWN_CD = 100;

	// Token: 0x04002448 RID: 9288
	private const int DELTA_TIME_INTERVAL = 25;

	// Token: 0x04002449 RID: 9289
	private const int PRELOAD_ACTOR_COUNT = 20;

	// Token: 0x0400244A RID: 9290
	private const int SPAWN_ACTOR_COUNT = 2;

	// Token: 0x0400244B RID: 9291
	private int ActorUid;

	// Token: 0x0400244C RID: 9292
	private int EffectAudioUid;

	// Token: 0x0400244D RID: 9293
	private float DeltaTime;

	// Token: 0x0400244E RID: 9294
	private readonly Transform ZeroTransform = Transform.Create(FQuat.Identity, global::Vector.ZeroVector, global::Vector.ZeroVector);

	// Token: 0x0400244F RID: 9295
	private readonly Dictionary<int, IEffectActorInfo> ActorInfoMap = new Dictionary<int, IEffectActorInfo>();

	// Token: 0x04002450 RID: 9296
	private readonly Dictionary<int, IEffectAudioInfo> AudioInfoMap = new Dictionary<int, IEffectAudioInfo>();

	// Token: 0x04002451 RID: 9297
	private readonly Dictionary<string, double> AudioEventMap = new Dictionary<string, double>();

	// Token: 0x04002452 RID: 9298
	private readonly Stat EffectStat = Stat.Create("EffectAudioController.HandlePendingMap", "", "");

	// Token: 0x04002453 RID: 9299
	private readonly Stat LocationStat = Stat.Create("EffectAudioController.UpdateLocationOffsets", "", "");

	// Token: 0x04002454 RID: 9300
	private readonly Dictionary<int, IEffectAudioInfo> PendingHandleMap = new Dictionary<int, IEffectAudioInfo>();

	// Token: 0x04002455 RID: 9301
	private readonly Dictionary<int, IPendingEffectInfo> PendingEffectModelMap = new Dictionary<int, IPendingEffectInfo>();

	// Token: 0x04002456 RID: 9302
	private readonly Dictionary<EHitEffectType, double> HitEffectMap = new Dictionary<EHitEffectType, double>();

	// Token: 0x04002457 RID: 9303
	private readonly Dictionary<object, int> PlayerCtrlEffectModelMap = new Dictionary<object, int>();

	// Token: 0x04002458 RID: 9304
	private readonly Dictionary<object, int> OtherCtrlEffectModelMap = new Dictionary<object, int>();

	// Token: 0x04002459 RID: 9305
	private readonly List<int> DeletePendingList = new List<int>();

	// Token: 0x0400245A RID: 9306
	private int CurrentSpawnActorCount;

	// Token: 0x0400245B RID: 9307
	private readonly Dictionary<int, EffectModelAudioHandleInfo> EffectModelAudioHandleMap = new Dictionary<int, EffectModelAudioHandleInfo>();

	// Token: 0x0400245C RID: 9308
	[Nullable(2)]
	private static EffectAudioController _Instance;
}
