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

// Token: 0x0200254D RID: 9549
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class PhonographController : UiControllerBase
{
	// Token: 0x060133B3 RID: 78771 RVA: 0x004C85BB File Offset: 0x004C67BB
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.PhantomMusicNotify, new Action<IMessage, Net.CallbackStatus>(this.OnPhantomMusicNotify));
	}

	// Token: 0x060133B4 RID: 78772 RVA: 0x004C85D9 File Offset: 0x004C67D9
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.PhantomMusicNotify);
	}

	// Token: 0x060133B5 RID: 78773 RVA: 0x004C85EB File Offset: 0x004C67EB
	protected override bool OnLeaveLevel()
	{
		PhonographModel.Instance.GlobalMusicId = 0;
		this.StopMusic(true);
		return true;
	}

	// Token: 0x060133B6 RID: 78774 RVA: 0x004C8600 File Offset: 0x004C6800
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

	// Token: 0x060133B7 RID: 78775 RVA: 0x004C864C File Offset: 0x004C684C
	public void SendMusicSaveRequest(int musicId)
	{
		PhantomMusicSaveRequest phantomMusicSaveRequest = PhantomMusicSaveRequest.Create();
		phantomMusicSaveRequest.Music = musicId;
		Net.Instance.Call(ERequestMessageId.PhantomMusicSaveRequest, phantomMusicSaveRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			PhantomMusicSaveResponse phantomMusicSaveResponse = (PhantomMusicSaveResponse)msg;
			if (phantomMusicSaveResponse != null && phantomMusicSaveResponse.ErrCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(phantomMusicSaveResponse.ErrCode, 25322, null, true, true);
			}
		}, 0);
	}

	// Token: 0x060133B8 RID: 78776 RVA: 0x004C8698 File Offset: 0x004C6898
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

	// Token: 0x060133B9 RID: 78777 RVA: 0x004C86FB File Offset: 0x004C68FB
	public void OpenView()
	{
		UiManager.Instance.OpenView(EUiViewName.PhonographView, null, null);
	}

	// Token: 0x060133BA RID: 78778 RVA: 0x004C8710 File Offset: 0x004C6910
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

	// Token: 0x060133BB RID: 78779 RVA: 0x004C8760 File Offset: 0x004C6960
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

	// Token: 0x060133BC RID: 78780 RVA: 0x004C88B8 File Offset: 0x004C6AB8
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

	// Token: 0x060133BD RID: 78781 RVA: 0x004C89E4 File Offset: 0x004C6BE4
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

	// Token: 0x060133BE RID: 78782 RVA: 0x004C8A18 File Offset: 0x004C6C18
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

	// Token: 0x060133BF RID: 78783 RVA: 0x004C8A7C File Offset: 0x004C6C7C
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

	// Token: 0x060133C0 RID: 78784 RVA: 0x004C8AB8 File Offset: 0x004C6CB8
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

	// Token: 0x060133C1 RID: 78785 RVA: 0x004C8B3C File Offset: 0x004C6D3C
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

	// Token: 0x060133C2 RID: 78786 RVA: 0x004C8C08 File Offset: 0x004C6E08
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

	// Token: 0x060133C3 RID: 78787 RVA: 0x004C8CDC File Offset: 0x004C6EDC
	public void StopMusicByEntityId(int entityId)
	{
		int playIdRecord = PhonographModel.Instance.GetPlayIdRecord(entityId);
		if (playIdRecord != 0)
		{
			AudioSystem.Instance.ExecuteAction(playIdRecord, EAudioActionType.Stop, null);
			PhonographModel.Instance.RemovePlayIdRecord(entityId);
		}
	}

	// Token: 0x170018D9 RID: 6361
	// (get) Token: 0x060133C4 RID: 78788 RVA: 0x004C8D18 File Offset: 0x004C6F18
	public static PhonographController Instance
	{
		get
		{
			return PhonographController._Instance;
		}
	}

	// Token: 0x060133C5 RID: 78789 RVA: 0x004C8D1F File Offset: 0x004C6F1F
	public static PhonographController GetOrCreateInstance()
	{
		if (PhonographController._Instance == null)
		{
			PhonographController.CreateInstance();
		}
		return PhonographController._Instance;
	}

	// Token: 0x060133C6 RID: 78790 RVA: 0x004C8D33 File Offset: 0x004C6F33
	public static bool CreateInstance()
	{
		if (PhonographController._Instance != null)
		{
			return true;
		}
		PhonographController._Instance = new PhonographController();
		return true;
	}

	// Token: 0x060133C7 RID: 78791 RVA: 0x004C8D49 File Offset: 0x004C6F49
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060133C8 RID: 78792 RVA: 0x004C8D4B File Offset: 0x004C6F4B
	public static void ResetStaticDefaultValue()
	{
		PhonographController._Instance = null;
	}

	// Token: 0x060133C9 RID: 78793 RVA: 0x004C8D53 File Offset: 0x004C6F53
	static PhonographController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PhonographController.CreateStaticDefaultValue), new Action(PhonographController.ResetStaticDefaultValue));
	}

	// Token: 0x04009137 RID: 37175
	[Nullable(2)]
	private static PhonographController _Instance;
}
