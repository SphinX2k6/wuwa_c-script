using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using UnrealEngine;

// Token: 0x02001A38 RID: 6712
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class PhonographController : UiControllerBase
{
	// Token: 0x06010893 RID: 67731 RVA: 0x004D7137 File Offset: 0x004D5337
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.PhantomMusicNotify, new Action<IMessage, Net.CallbackStatus>(this.OnPhantomMusicNotify));
	}

	// Token: 0x06010894 RID: 67732 RVA: 0x004D7155 File Offset: 0x004D5355
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.PhantomMusicNotify);
	}

	// Token: 0x06010895 RID: 67733 RVA: 0x004D7167 File Offset: 0x004D5367
	protected override bool OnLeaveLevel()
	{
		PhonographModel.Instance.GlobalMusicId = 0;
		this.StopMusic(true);
		return true;
	}

	// Token: 0x06010896 RID: 67734 RVA: 0x004D717C File Offset: 0x004D537C
	[NullableContext(0)]
	public UniTask<bool> UnlockMusicRequest([Nullable(1)] List<int> itemList)
	{
		PhonographController.<UnlockMusicRequest>d__3 <UnlockMusicRequest>d__;
		<UnlockMusicRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<UnlockMusicRequest>d__.<>4__this = this;
		<UnlockMusicRequest>d__.itemList = itemList;
		<UnlockMusicRequest>d__.<>1__state = -1;
		<UnlockMusicRequest>d__.<>t__builder.Start<PhonographController.<UnlockMusicRequest>d__3>(ref <UnlockMusicRequest>d__);
		return <UnlockMusicRequest>d__.<>t__builder.Task;
	}

	// Token: 0x06010897 RID: 67735 RVA: 0x004D71C8 File Offset: 0x004D53C8
	public void SendMusicSaveRequest(int musicId)
	{
		PhantomMusicSaveRequest phantomMusicSaveRequest = PhantomMusicSaveRequest.Create();
		phantomMusicSaveRequest.Music = musicId;
		Net.Instance.Call(ERequestMessageId.PhantomMusicSaveRequest, phantomMusicSaveRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			PhantomMusicSaveResponse phantomMusicSaveResponse = (PhantomMusicSaveResponse)msg;
			if (phantomMusicSaveResponse != null && phantomMusicSaveResponse.ErrCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(phantomMusicSaveResponse.ErrCode, 17072, null, true, true);
			}
		}, 0);
	}

	// Token: 0x06010898 RID: 67736 RVA: 0x004D7214 File Offset: 0x004D5414
	[NullableContext(2)]
	private void OnPhantomMusicNotify(IMessage msg, Net.CallbackStatus status)
	{
		PhantomMusicNotify phantomMusicNotify = (PhantomMusicNotify)msg;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Audio;
		ELogAuthor author = ELogAuthor.BB;
		string message = "Server Notify Post Audio";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("musicId", phantomMusicNotify.Music);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		PhonographModel.Instance.GlobalMusicId = phantomMusicNotify.Music;
		this.PlayGlobalMusic(phantomMusicNotify.Music, true);
	}

	// Token: 0x06010899 RID: 67737 RVA: 0x004D7277 File Offset: 0x004D5477
	public void OpenView()
	{
		UiManager.Instance.OpenView(EUiViewName.PhonographView, null, null);
	}

	// Token: 0x0601089A RID: 67738 RVA: 0x004D728C File Offset: 0x004D548C
	public void SwitchMusicRequest(int musicId, Action callback)
	{
		PhantomMusicSwitchRequest phantomMusicSwitchRequest = PhantomMusicSwitchRequest.Create();
		phantomMusicSwitchRequest.MusicId = musicId;
		Net.Instance.Call(ERequestMessageId.PhantomMusicSwitchRequest, phantomMusicSwitchRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			PhantomMusicSwitchResponse phantomMusicSwitchResponse = (PhantomMusicSwitchResponse)msg;
			if (phantomMusicSwitchResponse != null && phantomMusicSwitchResponse.ErrorCode == Aki.Protocol.ErrorCode.Success)
			{
				ScrollingTipsController.Instance.ShowTipsById("PhonographSwitchMusicSuccess", Array.Empty<object>());
				PhonographModel.Instance.RecordMusicId = musicId;
				callback();
			}
		}, 0);
	}

	// Token: 0x0601089B RID: 67739 RVA: 0x004D72DC File Offset: 0x004D54DC
	public int PlayMusic(int musicId, bool isGlobal = false)
	{
		if (musicId != 0 && this.IsMusicAlbumExpired(musicId))
		{
			this.HandleTimeLimitMusicExpired(musicId);
			return 0;
		}
		if (isGlobal)
		{
			return this.PlayGlobalMusic(musicId, false);
		}
		PhonographModel instance = PhonographModel.Instance;
		AActor aactor = (instance != null) ? instance.EntityActor : null;
		if (aactor != null && aactor.IsValid())
		{
			AudioSystem.Instance.StopAll(aactor);
		}
		PhonographConfig instance2 = PhonographConfig.Instance;
		PhonographMusic? phonographMusic = (instance2 != null) ? instance2.GetMusicById(musicId) : null;
		if (phonographMusic == null)
		{
			return 0;
		}
		if (aactor == null || !aactor.IsValid())
		{
			return 0;
		}
		this.StopMusic(false);
		int handleId = 0;
		handleId = AudioSystem.Instance.PostEvent(phonographMusic.Value.MusicEvent, aactor, new PostEventArgs?(new PostEventArgs
		{
			CallbackMask = new ECallbackMask?(ECallbackMask.EndOfEvent),
			CallbackHandler = delegate(EAkCallbackType callbackType, UAkCallbackInfo callbackInfo)
			{
				if (callbackType == (EAkCallbackType)1 && handleId == PhonographModel.Instance.CurrentMusicHandleId)
				{
					this.OnMusicEnd();
				}
			}
		}));
		PhonographModel.Instance.CurrentMusicHandleId = handleId;
		PhonographModel.Instance.GetMusicDuration(musicId).ContinueWith(delegate(float d)
		{
			PhonographModel.Instance.CurrentPlayMusicTotalTime = (int)d;
			PhonographModel.Instance.CurrentPlayMusicTime = 0;
			PhonographModel.Instance.CurrentPlayMusicId = musicId;
		}).Forget();
		return handleId;
	}

	// Token: 0x0601089C RID: 67740 RVA: 0x004D7434 File Offset: 0x004D5634
	public int PlayGlobalMusic(int musicId, bool isForce = false)
	{
		if (musicId == 0)
		{
			this.StopMusic(false);
			return 0;
		}
		if (musicId == PhonographModel.Instance.GlobalMusicId && !isForce)
		{
			return 0;
		}
		PhonographConfig instance = PhonographConfig.Instance;
		PhonographMusic? phonographMusic = (instance != null) ? instance.GetMusicById(musicId) : null;
		if (phonographMusic == null)
		{
			return 0;
		}
		this.StopMusic(false);
		AudioSystem.Instance.SetRtpcValue("phonograph_switch_to_2d", 1f, null);
		int handleId = 0;
		handleId = AudioSystem.Instance.PostEvent(phonographMusic.Value.MusicEvent, null, new PostEventArgs?(new PostEventArgs
		{
			CallbackMask = new ECallbackMask?(ECallbackMask.EndOfEvent),
			CallbackHandler = delegate(EAkCallbackType callbackType, UAkCallbackInfo callbackInfo)
			{
				if (callbackType == (EAkCallbackType)1 && handleId == PhonographModel.Instance.CurrentMusicHandleId)
				{
					this.OnMusicEnd();
				}
			}
		}));
		PhonographModel.Instance.CurrentMusicHandleId = handleId;
		PhonographModel.Instance.GetMusicDuration(musicId).ContinueWith(delegate(float d)
		{
			PhonographModel.Instance.CurrentPlayMusicTotalTime = (int)d;
			PhonographModel.Instance.CurrentPlayMusicTime = 0;
			PhonographModel.Instance.CurrentPlayMusicId = musicId;
		}).Forget();
		return handleId;
	}

	// Token: 0x0601089D RID: 67741 RVA: 0x004D7560 File Offset: 0x004D5760
	private void OnMusicEnd()
	{
		int currentPlayMusicId = PhonographModel.Instance.CurrentPlayMusicId;
		if (currentPlayMusicId != 0 && this.IsMusicAlbumExpired(currentPlayMusicId))
		{
			this.HandleTimeLimitMusicExpired(currentPlayMusicId);
			return;
		}
		this.ContinuePlayAfterMusicEnd();
	}

	// Token: 0x0601089E RID: 67742 RVA: 0x004D7594 File Offset: 0x004D5794
	public bool IsMusicAlbumExpired(int musicId)
	{
		PhonographConfig instance = PhonographConfig.Instance;
		PhonographMusic? phonographMusic = (instance != null) ? instance.GetMusicById(musicId) : null;
		if (phonographMusic == null)
		{
			return false;
		}
		PhonographMusic value = phonographMusic.Value;
		for (int i = 0; i < value.AlbumLength; i++)
		{
			if (MotorcycleMusicPlayerModel.Instance.ShouldFallbackForExpired(value.Album(i)))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0601089F RID: 67743 RVA: 0x004D75F8 File Offset: 0x004D57F8
	private void ContinuePlayAfterMusicEnd()
	{
		if (PhonographModel.Instance.CurrentPlayMusicId == 0)
		{
			this.StopMusic(true);
			return;
		}
		if (!PhonographModel.Instance.IsGlobal)
		{
			this.StopMusic(true);
			return;
		}
		this.PlayGlobalMusic(PhonographModel.Instance.GlobalMusicId, true);
	}

	// Token: 0x060108A0 RID: 67744 RVA: 0x004D7634 File Offset: 0x004D5834
	private void HandleTimeLimitMusicExpired(int expiredMusicId)
	{
		this.StopMusic(true);
		if (PhonographModel.Instance.GlobalMusicId == expiredMusicId)
		{
			PhonographModel.Instance.GlobalMusicId = 0;
			this.SendMusicSaveRequest(0);
		}
		if (PhonographModel.Instance.RecordMusicId == expiredMusicId)
		{
			PhonographModel.Instance.RecordMusicId = 0;
		}
		ScrollingTipsController.Instance.ShowTipsByTextId("MotorMusic_TimeLimited_tips", Array.Empty<object>());
		if (UiManager.Instance.IsViewShow(EUiViewName.PhonographView))
		{
			EventSystem.Instance.Emit<int>(EEventName.OnPhonographMusicForceRefresh, 1);
		}
	}

	// Token: 0x060108A1 RID: 67745 RVA: 0x004D76B8 File Offset: 0x004D58B8
	public void StopMusic(bool isEmit = true)
	{
		AudioSystem.Instance.SetRtpcValue("phonograph_switch_to_2d", 0f, null);
		PhonographModel instance = PhonographModel.Instance;
		AActor aactor = (instance != null) ? instance.EntityActor : null;
		if (aactor != null && aactor.IsValid())
		{
			AudioSystem.Instance.StopAll(aactor);
		}
		if (PhonographModel.Instance.CurrentMusicHandleId != 0)
		{
			AudioSystem.Instance.ExecuteAction(PhonographModel.Instance.CurrentMusicHandleId, EAudioActionType.Stop, null);
			PhonographModel.Instance.CurrentMusicHandleId = 0;
		}
		EventSystem.Instance.Emit(EEventName.OnPhonographPlayStop);
		PhonographModel.Instance.CurrentPlayMusicId = 0;
		PhonographModel.Instance.CurrentPlayMusicTime = 0;
		PhonographModel.Instance.CurrentPlayMusicTotalTime = 0;
		if (isEmit)
		{
			EventSystem.Instance.Emit(EEventName.OnPhonographSwitchMusic);
		}
	}

	// Token: 0x060108A2 RID: 67746 RVA: 0x004D7784 File Offset: 0x004D5984
	public void PlayMusicByEntityId(int entityId)
	{
		int playIdRecord = PhonographModel.Instance.GetPlayIdRecord(entityId);
		if (playIdRecord != 0)
		{
			AudioSystem.Instance.ExecuteAction(playIdRecord, EAudioActionType.Stop, null);
		}
		int recordMusicId = PhonographModel.Instance.GetRecordMusicId(entityId);
		if (recordMusicId == 0)
		{
			return;
		}
		PhonographConfig instance = PhonographConfig.Instance;
		PhonographMusic? phonographMusic = (instance != null) ? instance.GetMusicById(recordMusicId) : null;
		if (phonographMusic == null)
		{
			return;
		}
		CreatureModel instance2 = CreatureModel.Instance;
		EntityHandle entityHandle = (instance2 != null) ? instance2.GetEntityByPbDataId(entityId) : null;
		if (entityHandle == null)
		{
			return;
		}
		WorldEntity entity = entityHandle.Entity;
		BaseActorComponent baseActorComponent = (entity != null) ? entity.GetComponent<BaseActorComponent>() : null;
		if (baseActorComponent == null)
		{
			return;
		}
		int musicId = AudioSystem.Instance.PostEvent(phonographMusic.Value.MusicEvent, baseActorComponent.Owner, null);
		PhonographModel.Instance.SetPlayIdRecord(entityId, musicId);
	}

	// Token: 0x060108A3 RID: 67747 RVA: 0x004D7858 File Offset: 0x004D5A58
	public void StopMusicByEntityId(int entityId)
	{
		int playIdRecord = PhonographModel.Instance.GetPlayIdRecord(entityId);
		if (playIdRecord != 0)
		{
			AudioSystem.Instance.ExecuteAction(playIdRecord, EAudioActionType.Stop, null);
			PhonographModel.Instance.RemovePlayIdRecord(entityId);
		}
	}

	// Token: 0x17001912 RID: 6418
	// (get) Token: 0x060108A4 RID: 67748 RVA: 0x004D7894 File Offset: 0x004D5A94
	public static PhonographController Instance
	{
		get
		{
			return PhonographController._Instance;
		}
	}

	// Token: 0x060108A5 RID: 67749 RVA: 0x004D789B File Offset: 0x004D5A9B
	public static PhonographController GetOrCreateInstance()
	{
		if (PhonographController._Instance == null)
		{
			PhonographController.CreateInstance();
		}
		return PhonographController._Instance;
	}

	// Token: 0x060108A6 RID: 67750 RVA: 0x004D78AF File Offset: 0x004D5AAF
	public static bool CreateInstance()
	{
		if (PhonographController._Instance != null)
		{
			return true;
		}
		PhonographController._Instance = new PhonographController();
		return true;
	}

	// Token: 0x060108A7 RID: 67751 RVA: 0x004D78C5 File Offset: 0x004D5AC5
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060108A8 RID: 67752 RVA: 0x004D78C7 File Offset: 0x004D5AC7
	public static void ResetStaticDefaultValue()
	{
		PhonographController._Instance = null;
	}

	// Token: 0x060108A9 RID: 67753 RVA: 0x004D78CF File Offset: 0x004D5ACF
	static PhonographController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PhonographController.CreateStaticDefaultValue), new Action(PhonographController.ResetStaticDefaultValue));
	}

	// Token: 0x04009290 RID: 37520
	[Nullable(2)]
	private static PhonographController _Instance;
}
