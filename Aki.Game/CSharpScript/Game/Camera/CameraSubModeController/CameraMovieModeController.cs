using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera.MovieCamera;
using AkiClient.Game.Aki.Data.Camera;
using CSharpScript.Game.LevelGamePlay.StaticScene;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Camera.CameraSubModeController
{
	// Token: 0x0200730E RID: 29454
	[NullableContext(1)]
	[Nullable(0)]
	public class CameraMovieModeController : CameraSubModeController, IStaticVariableResetter
	{
		// Token: 0x0604847F RID: 296063 RVA: 0x012938E8 File Offset: 0x01291AE8
		static CameraMovieModeController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CameraMovieModeController.CreateStaticDefaultValue), new Action(CameraMovieModeController.ResetStaticDefaultValue));
		}

		// Token: 0x06048480 RID: 296064 RVA: 0x0129393E File Offset: 0x01291B3E
		protected override void OnStart(CameraModelInstance cameraModelInstance)
		{
			this.CameraModelInstance = cameraModelInstance;
			this.Inited = true;
		}

		// Token: 0x06048481 RID: 296065 RVA: 0x01293950 File Offset: 0x01291B50
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private UniTask<BP_MovieCameraConfig_C> InitConfig(string daPath)
		{
			CameraMovieModeController.<InitConfig>d__42 <InitConfig>d__;
			<InitConfig>d__.<>t__builder = AsyncUniTaskMethodBuilder<BP_MovieCameraConfig_C>.Create();
			<InitConfig>d__.<>4__this = this;
			<InitConfig>d__.daPath = daPath;
			<InitConfig>d__.<>1__state = -1;
			<InitConfig>d__.<>t__builder.Start<CameraMovieModeController.<InitConfig>d__42>(ref <InitConfig>d__);
			return <InitConfig>d__.<>t__builder.Task;
		}

		// Token: 0x06048482 RID: 296066 RVA: 0x0129399C File Offset: 0x01291B9C
		public UniTask PlaySpecialMovieCamera(string movieCameraConfigRowName, [Nullable(2)] Action<bool> callback = null)
		{
			CameraMovieModeController.<PlaySpecialMovieCamera>d__43 <PlaySpecialMovieCamera>d__;
			<PlaySpecialMovieCamera>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlaySpecialMovieCamera>d__.<>4__this = this;
			<PlaySpecialMovieCamera>d__.movieCameraConfigRowName = movieCameraConfigRowName;
			<PlaySpecialMovieCamera>d__.callback = callback;
			<PlaySpecialMovieCamera>d__.<>1__state = -1;
			<PlaySpecialMovieCamera>d__.<>t__builder.Start<CameraMovieModeController.<PlaySpecialMovieCamera>d__43>(ref <PlaySpecialMovieCamera>d__);
			return <PlaySpecialMovieCamera>d__.<>t__builder.Task;
		}

		// Token: 0x06048483 RID: 296067 RVA: 0x012939EF File Offset: 0x01291BEF
		private void LoadSpecialMovieCameraConfig()
		{
			if (this.SpecialMovieCameraConfigDataTable != null || this.SpecialMovieCameraConfigLoading)
			{
				return;
			}
			this.SpecialMovieCameraConfigLoading = true;
			ResourceSystem.Instance.LoadAsync<UDataTable>("/Game/Aki/Data/Camera/DT_SpecialMovieCameraConfigList.DT_SpecialMovieCameraConfigList", delegate([Nullable(2)] UDataTable dataTable, string _)
			{
				this.SpecialMovieCameraConfigLoading = false;
				if (dataTable != null)
				{
					this.SpecialMovieCameraConfigDataTable = dataTable;
					if (this.SpecialMovieCameraConfigKey != "")
					{
						this.PlaySpecialMovieCamera(this.SpecialMovieCameraConfigKey, this.SpecialPlayCallback).Forget();
					}
					return;
				}
				Log.Instance.Error(ELogModule.Camera, ELogAuthor.LJM, "[电影镜头][特殊]异步加载DT表失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				Action<bool> specialPlayCallback = this.SpecialPlayCallback;
				if (specialPlayCallback == null)
				{
					return;
				}
				specialPlayCallback(false);
			}, 100, "js_undefined");
		}

		// Token: 0x06048484 RID: 296068 RVA: 0x01293A2C File Offset: 0x01291C2C
		public UniTask PlayMovieCamera(string movieCameraConfigRowName, int initialPlayCameraIndex = -1, [Nullable(2)] Action<bool> callback = null)
		{
			CameraMovieModeController.<PlayMovieCamera>d__45 <PlayMovieCamera>d__;
			<PlayMovieCamera>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayMovieCamera>d__.<>4__this = this;
			<PlayMovieCamera>d__.movieCameraConfigRowName = movieCameraConfigRowName;
			<PlayMovieCamera>d__.initialPlayCameraIndex = initialPlayCameraIndex;
			<PlayMovieCamera>d__.callback = callback;
			<PlayMovieCamera>d__.<>1__state = -1;
			<PlayMovieCamera>d__.<>t__builder.Start<CameraMovieModeController.<PlayMovieCamera>d__45>(ref <PlayMovieCamera>d__);
			return <PlayMovieCamera>d__.<>t__builder.Task;
		}

		// Token: 0x06048485 RID: 296069 RVA: 0x01293A87 File Offset: 0x01291C87
		private void LoadMovieCameraConfig()
		{
			if (this.MovieCameraConfigDataTable != null || this.MovieCameraConfigLoading)
			{
				return;
			}
			this.MovieCameraConfigLoading = true;
			ResourceSystem.Instance.LoadAsync<UDataTable>("/Game/Aki/Data/Camera/DT_MovieCameraConfigList.DT_MovieCameraConfigList", delegate([Nullable(2)] UDataTable dataTable, string _)
			{
				if (dataTable != null)
				{
					this.MovieCameraConfigDataTable = dataTable;
					if (this.MovieCameraConfigKey != "")
					{
						this.PlayMovieCamera(this.MovieCameraConfigKey, this.InitialPlayCameraIndex, this.PlayCallback).Forget();
					}
					return;
				}
				Log.Instance.Error(ELogModule.Camera, ELogAuthor.LJM, "[电影镜头]异步加载DT表失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				Action<bool> playCallback = this.PlayCallback;
				if (playCallback == null)
				{
					return;
				}
				playCallback(false);
			}, 100, "js_undefined");
		}

		// Token: 0x06048486 RID: 296070 RVA: 0x01293AC4 File Offset: 0x01291CC4
		[NullableContext(2)]
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private UniTask<ULevelSequence> LoadLevelSequence(string path)
		{
			CameraMovieModeController.<LoadLevelSequence>d__47 <LoadLevelSequence>d__;
			<LoadLevelSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder<ULevelSequence>.Create();
			<LoadLevelSequence>d__.path = path;
			<LoadLevelSequence>d__.<>1__state = -1;
			<LoadLevelSequence>d__.<>t__builder.Start<CameraMovieModeController.<LoadLevelSequence>d__47>(ref <LoadLevelSequence>d__);
			return <LoadLevelSequence>d__.<>t__builder.Task;
		}

		// Token: 0x06048487 RID: 296071 RVA: 0x01293B08 File Offset: 0x01291D08
		private void PlaySequenceCamera(SMovieCameraConfigItem_SequenceSetting sequenceSetting)
		{
			this.StopMovieCameraInternal();
			if (Global.BaseCharacter == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Camera;
				ELogAuthor author = ELogAuthor.LJM;
				string message = "[电影镜头]Sequence镜头播放失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Global.BaseCharacter", Global.BaseCharacter != null);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			Vector tempVector = this.TempVector;
			FVectorDouble fvectorDouble = sequenceSetting.BindTargetSetting.AttachLocationOffset;
			tempVector.FromUeVector(fvectorDouble);
			Rotator tempRotator = this.TempRotator;
			FRotator frotator = sequenceSetting.BindTargetSetting.AttachRotatorOffset;
			tempRotator.FromUeRotator(frotator);
			Vector tempVector2 = this.TempVector1;
			fvectorDouble = sequenceSetting.BindTargetSetting.SpecificLocationOffset;
			tempVector2.FromUeVector(fvectorDouble);
			Rotator tempRotator2 = this.TempRotator1;
			frotator = sequenceSetting.BindTargetSetting.SpecificRotatorOffset;
			tempRotator2.FromUeRotator(frotator);
			Vector tempVector3 = this.TempVector2;
			fvectorDouble = sequenceSetting.BindTargetSetting.WorldLocation;
			tempVector3.FromUeVector(fvectorDouble);
			Rotator tempRotator3 = this.TempRotator2;
			frotator = sequenceSetting.BindTargetSetting.WorldRotation;
			tempRotator3.FromUeRotator(frotator);
			ULevelSequence valueOrDefault = this.CacheLevelSequenceMap.GetValueOrDefault(this.GetCurrentPlayCameraConfigItem());
			if (valueOrDefault == null)
			{
				Log.Instance.Error(ELogModule.Camera, ELogAuthor.LJM, "[电影镜头]Sequence镜头播放失败,不应出现此情况", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.StopMovieCameraInternal();
				return;
			}
			this.SimpleLevelSequenceActor = new SimpleLevelSequenceActor(valueOrDefault);
			this.SimpleLevelSequenceActor.PlaySequence(new DefaultLevelSequencePlayParam(sequenceSetting.BlendInTime, sequenceSetting.BlendOutTime, this.Config.SmoothFactor, this.Config.SmoothDelta, new BindTargetSetting(sequenceSetting.BindTargetSetting.BindTargetType, sequenceSetting.BindTargetSetting.AttachSocketName, this.TempVector, this.TempRotator, this.TempVector1, this.TempRotator1, this.TempVector2, this.TempRotator2), new FollowTargetSetting(sequenceSetting.FollowTargetSetting.IsFollowTarget, sequenceSetting.FollowTargetSetting.FollowType == EMovieCameraSequenceSettingFollowTargetType.俯仰跟随, sequenceSetting.FollowTargetSetting.PitchFollowSpeed, sequenceSetting.FollowTargetSetting.FollowType == EMovieCameraSequenceSettingFollowTargetType.偏航跟随, sequenceSetting.FollowTargetSetting.FollowSpeed, sequenceSetting.FollowTargetSetting.FollowType == EMovieCameraSequenceSettingFollowTargetType.俯仰_偏航跟随, sequenceSetting.FollowTargetSetting.AngleFollowSpeed), Global.BaseCharacter));
			this.SimpleLevelSequenceActor.AddOnFinishedCallback(new Action(this.OnSequenceCameraFinished));
			this.SimpleLevelSequenceActor.AddOnStopCallback(new Action<bool>(this.OnSequenceCameraStopped));
		}

		// Token: 0x06048488 RID: 296072 RVA: 0x01293D50 File Offset: 0x01291F50
		private unsafe void PlayFightCamera(SMovieCameraConfigItem_FightSubCameraSetting fightSetting)
		{
			this.StopMovieCameraInternal();
			int playerId = CreatureModel.Instance.GetPlayerId();
			if (!FormationDataController.Instance.IsPlayerExist(playerId))
			{
				Log.Instance.Error(ELogModule.Camera, ELogAuthor.LJM, "[电影镜头]Fight镜头播放失败, 因为没有玩家队伍", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (Global.BaseCharacter == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Camera;
				ELogAuthor author = ELogAuthor.LJM;
				string message = "[电影镜头]Fight镜头播放失败";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("sequenceSetting", fightSetting.ToString());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Global.BaseCharacter", Global.BaseCharacter != null);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			FormationDataController.Instance.AddPlayerTag(playerId, new int?(fightSetting.FightSubCameraTag.TagId()));
			this.FightCameraTagId = fightSetting.FightSubCameraTag.TagId();
			this.FightCameraTimerHandle = TimerSystem.FlowTimeInstance.Delay(new TTimerAction(this.OnFightCameraFinished), fightSetting.TimeLength * 1000f, null, null, true, 1f);
		}

		// Token: 0x06048489 RID: 296073 RVA: 0x01293E60 File Offset: 0x01292060
		public void PauseMovieCamera()
		{
			TimerHandle fightCameraTimerHandle = this.FightCameraTimerHandle;
			if (fightCameraTimerHandle != null && fightCameraTimerHandle.Valid())
			{
				TimerSystem.FlowTimeInstance.Pause(this.FightCameraTimerHandle, null);
			}
			if (this.SimpleLevelSequenceActor != null)
			{
				this.SimpleLevelSequenceActor.Pause();
			}
		}

		// Token: 0x0604848A RID: 296074 RVA: 0x01293E9B File Offset: 0x0129209B
		public void ResumeMovieCamera()
		{
			TimerHandle fightCameraTimerHandle = this.FightCameraTimerHandle;
			if (fightCameraTimerHandle != null && fightCameraTimerHandle.Valid())
			{
				TimerSystem.FlowTimeInstance.Resume(this.FightCameraTimerHandle);
			}
			if (this.SimpleLevelSequenceActor != null)
			{
				this.SimpleLevelSequenceActor.Resume();
			}
		}

		// Token: 0x0604848B RID: 296075 RVA: 0x01293ED8 File Offset: 0x012920D8
		private bool PlayNextMovieCamera()
		{
			if (this.MovieCameraConfig == null)
			{
				this.StopMovieCamera(null, "[电影镜头]没有常规电影镜头数据,停止电影镜头");
				return false;
			}
			if (!this.CheckValid())
			{
				return false;
			}
			this.CurrentPlayState = EMovieCameraPlayState.Play;
			EMovieCameraSwitchType emovieCameraSwitchType = this.MovieCameraConfig.MovieCameraSwitchType;
			if (emovieCameraSwitchType == EMovieCameraSwitchType.随机切换)
			{
				return this.RandomPlayMovieCamera();
			}
			if (emovieCameraSwitchType - EMovieCameraSwitchType.顺序切换 > 1)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Camera;
				ELogAuthor author = ELogAuthor.LJM;
				string message = "[电影镜头]未支持的播放模式";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", (int)this.MovieCameraConfig.MovieCameraSwitchType);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			return this.SequencePlayMovieCamera();
		}

		// Token: 0x0604848C RID: 296076 RVA: 0x01293F78 File Offset: 0x01292178
		private bool RandomPlayMovieCamera()
		{
			if (this.MovieCameraCacheList.Count <= 0)
			{
				return false;
			}
			int num = (int)Math.Round((double)MathUtils.Instance.GetRandomFloatNumber(0f, (float)(this.MovieCameraCacheList.Count - 1)));
			int valueOrDefault = this.MovieCameraCacheIndexMap.GetValueOrDefault(num, -1);
			int cacheIndex;
			if (this.MovieCameraIndexCacheMap.TryGetValue(this.DebugPlayIndex, out cacheIndex))
			{
				this.PlayMovieCameraByCacheIndex(this.DebugPlayIndex, cacheIndex);
			}
			else
			{
				this.PlayMovieCameraByCacheIndex(valueOrDefault, num);
			}
			return true;
		}

		// Token: 0x0604848D RID: 296077 RVA: 0x01293FF8 File Offset: 0x012921F8
		private bool SequencePlayMovieCamera()
		{
			if (this.MovieCameraCacheList.Count <= 0)
			{
				return false;
			}
			int num = (this.CurrentPlayCameraCacheIndex == -1) ? 0 : ((this.CurrentPlayCameraCacheIndex + 1) % this.MovieCameraCacheList.Count);
			int valueOrDefault = this.MovieCameraCacheIndexMap.GetValueOrDefault(num, -1);
			int cacheIndex;
			if (this.MovieCameraIndexCacheMap.TryGetValue(this.DebugPlayIndex, out cacheIndex))
			{
				this.PlayMovieCameraByCacheIndex(this.DebugPlayIndex, cacheIndex);
			}
			else
			{
				this.PlayMovieCameraByCacheIndex(valueOrDefault, num);
			}
			return true;
		}

		// Token: 0x0604848E RID: 296078 RVA: 0x01294074 File Offset: 0x01292274
		private bool PlayMovieCameraByConfigIndex(int index)
		{
			int cacheIndex;
			if (!this.MovieCameraIndexCacheMap.TryGetValue(index, out cacheIndex))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Camera;
				ELogAuthor author = ELogAuthor.LJM;
				string message = "[电影镜头]使用DT表的索引播放电影镜头失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("index", index);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			return this.PlayMovieCameraByCacheIndex(index, cacheIndex);
		}

		// Token: 0x0604848F RID: 296079 RVA: 0x012940C8 File Offset: 0x012922C8
		private unsafe bool PlayMovieCameraByCacheIndex(int index, int cacheIndex)
		{
			this.StopMovieCameraInternal();
			if (cacheIndex < 0 || cacheIndex >= this.MovieCameraCacheList.Count)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Camera;
				ELogAuthor author = ELogAuthor.LJM;
				string message = "[电影镜头]使用缓存的索引播放电影镜头失败";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("index", index);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("cacheIndex", cacheIndex);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("cacheLength", this.MovieCameraCacheList.Count);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return false;
			}
			this.CurrentPlayCameraIndex = index;
			this.CurrentPlayCameraCacheIndex = cacheIndex;
			this.CurrentPlayCameraConfigItem = this.MovieCameraConfigItemList[this.MovieCameraCacheList[cacheIndex]];
			EMovieCameraItemType emovieCameraItemType = this.CurrentPlayCameraConfigItem.Type;
			if (emovieCameraItemType != EMovieCameraItemType.战斗子镜头)
			{
				if (emovieCameraItemType == EMovieCameraItemType.Sequence镜头)
				{
					this.PlaySequenceCamera(this.CurrentPlayCameraConfigItem.SequenceSetting);
				}
			}
			else
			{
				this.PlayFightCamera(this.CurrentPlayCameraConfigItem.FightSubCameraSetting);
			}
			return true;
		}

		// Token: 0x06048490 RID: 296080 RVA: 0x012941E0 File Offset: 0x012923E0
		private bool PlayMovieCameraByConfigItem(SMovieCameraConfigItem movieCameraConfigItem)
		{
			this.StopMovieCameraInternal();
			this.CurrentPlaySpecialCameraConfigItem = movieCameraConfigItem;
			EMovieCameraItemType emovieCameraItemType = this.CurrentPlaySpecialCameraConfigItem.Type;
			if (emovieCameraItemType != EMovieCameraItemType.战斗子镜头)
			{
				if (emovieCameraItemType == EMovieCameraItemType.Sequence镜头)
				{
					this.PlaySequenceCamera(this.CurrentPlaySpecialCameraConfigItem.SequenceSetting);
				}
			}
			else
			{
				this.PlayFightCamera(this.CurrentPlaySpecialCameraConfigItem.FightSubCameraSetting);
			}
			return true;
		}

		// Token: 0x06048491 RID: 296081 RVA: 0x01294238 File Offset: 0x01292438
		public void StopMovieCamera([Nullable(2)] Action<bool> callback = null, string reason = "")
		{
			this.RemoveMovieCameraTag();
			this.CurrentPlayState = EMovieCameraPlayState.Stop;
			this.StopMovieCameraInternal();
			this.SpecialMovieCameraConfigLoading = false;
			this.SpecialMovieCameraConfigDataTable = null;
			this.SpecialMovieCameraConfigKey = "";
			this.SpecialCameraConfigItem = null;
			this.CurrentPlaySpecialCameraConfigItem = null;
			this.SpecialPlayCallback = null;
			this.CurrentPlaySpecialCameraConfigItem = null;
			this.MovieCameraConfigLoading = false;
			this.MovieCameraConfigDataTable = null;
			this.MovieCameraConfigKey = "";
			this.InitialPlayCameraIndex = -1;
			this.PlayCallback = null;
			this.MovieCameraConfig = null;
			this.MovieCameraConfigItemList.Clear();
			this.MovieCameraCacheList.Clear();
			this.MovieCameraIndexCacheMap.Clear();
			this.MovieCameraCacheIndexMap.Clear();
			this.CurrentPlayCameraIndex = -1;
			this.CurrentPlayCameraCacheIndex = -1;
			this.CurrentPlayCameraConfigItem = null;
			this.CacheLevelSequenceMap.Clear();
			this.FightCameraTagId = -1;
			this.FightCameraTimerHandle = null;
			this.SimpleLevelSequenceActor = null;
			if (callback != null)
			{
				callback(true);
			}
		}

		// Token: 0x06048492 RID: 296082 RVA: 0x01294326 File Offset: 0x01292526
		private void StopMovieCameraInternal()
		{
			this.StopSequenceCameraInternal();
			this.StopFightCameraInternal();
		}

		// Token: 0x06048493 RID: 296083 RVA: 0x01294334 File Offset: 0x01292534
		private void StopSequenceCameraInternal()
		{
			if (!this.CheckValid())
			{
				return;
			}
			if (this.SimpleLevelSequenceActor == null)
			{
				return;
			}
			this.SimpleLevelSequenceActor.StopSequence();
			this.SimpleLevelSequenceActor = null;
		}

		// Token: 0x06048494 RID: 296084 RVA: 0x0129435C File Offset: 0x0129255C
		private void StopFightCameraInternal()
		{
			if (!this.CheckValid())
			{
				return;
			}
			if (this.FightCameraTagId == -1)
			{
				return;
			}
			int playerId = CreatureModel.Instance.GetPlayerId();
			if (!FormationDataController.Instance.IsPlayerExist(playerId))
			{
				return;
			}
			TimerHandle fightCameraTimerHandle = this.FightCameraTimerHandle;
			if (fightCameraTimerHandle != null && fightCameraTimerHandle.Valid())
			{
				TimerSystem.FlowTimeInstance.Remove(this.FightCameraTimerHandle);
				this.FightCameraTimerHandle = null;
			}
			FormationDataController.Instance.RemovePlayerTag(playerId, new int?(this.FightCameraTagId));
			this.CameraModelInstance.FightCamera.LogicComponent.ForceTickOutSide();
			this.FightCameraTagId = -1;
		}

		// Token: 0x06048495 RID: 296085 RVA: 0x012943F3 File Offset: 0x012925F3
		public int GetCurrentPlayState()
		{
			return (int)this.CurrentPlayState;
		}

		// Token: 0x06048496 RID: 296086 RVA: 0x012943FB File Offset: 0x012925FB
		public int GetCurrentPlayCameraIndex()
		{
			return this.CurrentPlayCameraIndex;
		}

		// Token: 0x06048497 RID: 296087 RVA: 0x01294403 File Offset: 0x01292603
		public int GetCurrentPlayCameraCacheIndex()
		{
			return this.CurrentPlayCameraCacheIndex;
		}

		// Token: 0x06048498 RID: 296088 RVA: 0x0129440B File Offset: 0x0129260B
		[NullableContext(2)]
		public SMovieCameraConfigItem GetCurrentPlayCameraConfigItem()
		{
			if (this.CurrentPlayState == EMovieCameraPlayState.PlaySpecial)
			{
				return this.CurrentPlaySpecialCameraConfigItem;
			}
			return this.CurrentPlayCameraConfigItem;
		}

		// Token: 0x06048499 RID: 296089 RVA: 0x01294423 File Offset: 0x01292623
		public bool IsPlayingSpecialMovieCamera(string specialMovieCameraConfigKey)
		{
			return this.CurrentPlayState == EMovieCameraPlayState.PlaySpecial && this.SpecialMovieCameraConfigKey == specialMovieCameraConfigKey;
		}

		// Token: 0x0604849A RID: 296090 RVA: 0x0129443C File Offset: 0x0129263C
		private bool CheckValid()
		{
			return this.Inited;
		}

		// Token: 0x0604849B RID: 296091 RVA: 0x01294444 File Offset: 0x01292644
		private void AddMovieCameraTag()
		{
			int playerId = CreatureModel.Instance.GetPlayerId();
			if (!FormationDataController.Instance.IsPlayerExist(playerId))
			{
				return;
			}
			foreach (int num in CameraMovieModeController.MovieModeTagList)
			{
				if (!FormationDataController.Instance.HasPlayerTag(playerId, num, true))
				{
					FormationDataController.Instance.AddPlayerTag(playerId, new int?(num));
				}
			}
		}

		// Token: 0x0604849C RID: 296092 RVA: 0x012944A4 File Offset: 0x012926A4
		private void RemoveMovieCameraTag()
		{
			int playerId = CreatureModel.Instance.GetPlayerId();
			if (!FormationDataController.Instance.IsPlayerExist(playerId))
			{
				return;
			}
			foreach (int num in CameraMovieModeController.MovieModeTagList)
			{
				if (FormationDataController.Instance.HasPlayerTag(playerId, num, true))
				{
					FormationDataController.Instance.RemovePlayerTag(playerId, new int?(num));
				}
			}
		}

		// Token: 0x0604849D RID: 296093 RVA: 0x01294502 File Offset: 0x01292702
		private void OnSequenceCameraStopped(bool isSequenceStopWithFinish)
		{
			if (!isSequenceStopWithFinish)
			{
				return;
			}
			this.StopSequenceCameraInternal();
			if (this.CurrentPlayState == EMovieCameraPlayState.Stop)
			{
				return;
			}
			this.PlayNextMovieCamera();
		}

		// Token: 0x0604849E RID: 296094 RVA: 0x0129451F File Offset: 0x0129271F
		private void OnSequenceCameraFinished()
		{
			this.StopSequenceCameraInternal();
			if (this.CurrentPlayState == EMovieCameraPlayState.Stop)
			{
				return;
			}
			this.PlayNextMovieCamera();
		}

		// Token: 0x0604849F RID: 296095 RVA: 0x01294538 File Offset: 0x01292738
		private void OnFightCameraFinished(float delta)
		{
			this.StopFightCameraInternal();
			if (this.CurrentPlayState == EMovieCameraPlayState.Stop)
			{
				return;
			}
			this.PlayNextMovieCamera();
		}

		// Token: 0x060484A0 RID: 296096 RVA: 0x01294551 File Offset: 0x01292751
		protected override void OnEnd()
		{
			this.StopMovieCamera(null, "系统销毁,停止电影镜头");
			this.Inited = false;
		}

		// Token: 0x060484A1 RID: 296097 RVA: 0x01294566 File Offset: 0x01292766
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060484A2 RID: 296098 RVA: 0x01294568 File Offset: 0x01292768
		public static void ResetStaticDefaultValue()
		{
		}

		// Token: 0x04026336 RID: 156470
		private const string MOVIE_CAMERA_CONFIG_PATH = "/Game/Aki/Data/Camera/DT_MovieCameraConfigList.DT_MovieCameraConfigList";

		// Token: 0x04026337 RID: 156471
		private const string SPECIAL_MOVIE_CAMERA_CONFIG_PATH = "/Game/Aki/Data/Camera/DT_SpecialMovieCameraConfigList.DT_SpecialMovieCameraConfigList";

		// Token: 0x04026338 RID: 156472
		private const string MOVIE_CONFIG_DA_PATH = "/Game/Aki/Data/Camera/DA_MovieCameraConfig.DA_MovieCameraConfig";

		// Token: 0x04026339 RID: 156473
		private const int INVALID_GAMEPLAY_TAG_ID = -1;

		// Token: 0x0402633A RID: 156474
		private static readonly FName CameraTag = new FName("SequenceCamera");

		// Token: 0x0402633B RID: 156475
		[StaticVariableRuleIgnore]
		private static readonly int[] MovieModeTagList = new int[]
		{
			GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.开启电影模式"]
		};

		// Token: 0x0402633C RID: 156476
		private bool Inited;

		// Token: 0x0402633D RID: 156477
		[Nullable(2)]
		private CameraModelInstance CameraModelInstance;

		// Token: 0x0402633E RID: 156478
		[Nullable(2)]
		private MovieCameraConfig Config;

		// Token: 0x0402633F RID: 156479
		private bool SpecialMovieCameraConfigLoading;

		// Token: 0x04026340 RID: 156480
		[Nullable(2)]
		private UDataTable SpecialMovieCameraConfigDataTable;

		// Token: 0x04026341 RID: 156481
		private string SpecialMovieCameraConfigKey = "";

		// Token: 0x04026342 RID: 156482
		[Nullable(2)]
		private SMovieCameraConfigItem SpecialCameraConfigItem;

		// Token: 0x04026343 RID: 156483
		[Nullable(2)]
		private Action<bool> SpecialPlayCallback;

		// Token: 0x04026344 RID: 156484
		[Nullable(2)]
		private SMovieCameraConfigItem CurrentPlaySpecialCameraConfigItem;

		// Token: 0x04026345 RID: 156485
		private bool MovieCameraConfigLoading;

		// Token: 0x04026346 RID: 156486
		[Nullable(2)]
		private UDataTable MovieCameraConfigDataTable;

		// Token: 0x04026347 RID: 156487
		private string MovieCameraConfigKey = "";

		// Token: 0x04026348 RID: 156488
		private int InitialPlayCameraIndex = -1;

		// Token: 0x04026349 RID: 156489
		[Nullable(2)]
		private Action<bool> PlayCallback;

		// Token: 0x0402634A RID: 156490
		[Nullable(2)]
		private SMovieCameraConfig MovieCameraConfig;

		// Token: 0x0402634B RID: 156491
		private readonly List<SMovieCameraConfigItem> MovieCameraConfigItemList = new List<SMovieCameraConfigItem>();

		// Token: 0x0402634C RID: 156492
		private readonly List<int> MovieCameraCacheList = new List<int>();

		// Token: 0x0402634D RID: 156493
		private readonly Dictionary<int, int> MovieCameraIndexCacheMap = new Dictionary<int, int>();

		// Token: 0x0402634E RID: 156494
		private readonly Dictionary<int, int> MovieCameraCacheIndexMap = new Dictionary<int, int>();

		// Token: 0x0402634F RID: 156495
		private int CurrentPlayCameraIndex = -1;

		// Token: 0x04026350 RID: 156496
		private int CurrentPlayCameraCacheIndex = -1;

		// Token: 0x04026351 RID: 156497
		[Nullable(2)]
		private SMovieCameraConfigItem CurrentPlayCameraConfigItem;

		// Token: 0x04026352 RID: 156498
		private EMovieCameraPlayState CurrentPlayState;

		// Token: 0x04026353 RID: 156499
		private readonly Dictionary<SMovieCameraConfigItem, ULevelSequence> CacheLevelSequenceMap = new Dictionary<SMovieCameraConfigItem, ULevelSequence>();

		// Token: 0x04026354 RID: 156500
		private int FightCameraTagId = -1;

		// Token: 0x04026355 RID: 156501
		[Nullable(2)]
		private TimerHandle FightCameraTimerHandle;

		// Token: 0x04026356 RID: 156502
		[Nullable(2)]
		private SimpleLevelSequenceActor SimpleLevelSequenceActor;

		// Token: 0x04026357 RID: 156503
		private readonly Vector TempVector = Vector.Create();

		// Token: 0x04026358 RID: 156504
		private readonly Vector TempVector1 = Vector.Create();

		// Token: 0x04026359 RID: 156505
		private readonly Vector TempVector2 = Vector.Create();

		// Token: 0x0402635A RID: 156506
		private readonly Rotator TempRotator = Rotator.Create();

		// Token: 0x0402635B RID: 156507
		private readonly Rotator TempRotator1 = Rotator.Create();

		// Token: 0x0402635C RID: 156508
		private readonly Rotator TempRotator2 = Rotator.Create();

		// Token: 0x0402635D RID: 156509
		private readonly int DebugPlayIndex = -1;
	}
}
