using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Camera;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B6D RID: 27501
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventSeparateCamera : LevelEventBase
	{
		// Token: 0x0604421D RID: 279069 RVA: 0x010C67A4 File Offset: 0x010C49A4
		public LevelEventSeparateCamera(int id) : base(id)
		{
		}

		// Token: 0x0604421E RID: 279070 RVA: 0x010C67D0 File Offset: 0x010C49D0
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			SetSubScreenMode setSubScreenMode = inParams as SetSubScreenMode;
			if (setSubScreenMode == null)
			{
				base.FinishExecute(false, false, true);
				return;
			}
			this.Params = setSubScreenMode;
			global::Log.Instance.Info(ELogModule.Event, ELogAuthor.LJM, "[分屏相机][关卡事件]行为开始", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.ExecuteInternal().Forget();
		}

		// Token: 0x0604421F RID: 279071 RVA: 0x010C6820 File Offset: 0x010C4A20
		private UniTask ExecuteInternal()
		{
			LevelEventSeparateCamera.<ExecuteInternal>d__7 <ExecuteInternal>d__;
			<ExecuteInternal>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteInternal>d__.<>4__this = this;
			<ExecuteInternal>d__.<>1__state = -1;
			<ExecuteInternal>d__.<>t__builder.Start<LevelEventSeparateCamera.<ExecuteInternal>d__7>(ref <ExecuteInternal>d__);
			return <ExecuteInternal>d__.<>t__builder.Task;
		}

		// Token: 0x06044220 RID: 279072 RVA: 0x010C6864 File Offset: 0x010C4A64
		private UniTask WaitForResource()
		{
			LevelEventSeparateCamera.<WaitForResource>d__8 <WaitForResource>d__;
			<WaitForResource>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitForResource>d__.<>4__this = this;
			<WaitForResource>d__.<>1__state = -1;
			<WaitForResource>d__.<>t__builder.Start<LevelEventSeparateCamera.<WaitForResource>d__8>(ref <WaitForResource>d__);
			return <WaitForResource>d__.<>t__builder.Task;
		}

		// Token: 0x06044221 RID: 279073 RVA: 0x010C68A8 File Offset: 0x010C4AA8
		private void ApplySeparateCamera()
		{
			switch (this.Params.Config.Type)
			{
			case ESubScreenOperationType.Init:
				global::Log.Instance.Info(ELogModule.Event, ELogAuthor.LJM, "[分屏相机][关卡事件]初始化分屏", default(ReadOnlySpan<ValueTuple<string, object>>));
				using (List<ISubScreenInitData>.Enumerator enumerator = (this.Params.Config as ISubScreenModeInit).InitConfigs.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						ISubScreenInitData subScreenInitData = enumerator.Current;
						global::Log instance = global::Log.Instance;
						ELogModule module = ELogModule.Event;
						ELogAuthor author = ELogAuthor.LJM;
						string message = "[分屏相机][关卡事件]初始化分屏";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("cameraName", subScreenInitData.SubScreenKey);
						instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
						if (subScreenInitData.Type == ESubScreenInitDataType.Preset)
						{
							ISubScreenPresetInitData subScreenPresetInitData = subScreenInitData as ISubScreenPresetInitData;
							this.GetInitViewLocation(subScreenPresetInitData.AnchorType, this.ViewLocation);
							this.GetInitViewSize(subScreenPresetInitData.AnchorType, this.ViewSize);
						}
						else
						{
							ISubScreenCustomInitData subScreenCustomInitData = subScreenInitData as ISubScreenCustomInitData;
							this.ViewLocation.X = (double)subScreenCustomInitData.InitConfig.Anchor.X.GetValueOrDefault();
							this.ViewLocation.Y = (double)subScreenCustomInitData.InitConfig.Anchor.Y.GetValueOrDefault();
							this.ViewSize.X = (double)subScreenCustomInitData.InitConfig.Size.X.GetValueOrDefault();
							this.ViewSize.Y = (double)subScreenCustomInitData.InitConfig.Size.Y.GetValueOrDefault();
						}
						string subScreenKey = subScreenInitData.SubScreenKey;
						this.CameraModel = CameraController.Instance.InitSeparateCamera(subScreenKey, this.ViewLocation, this.ViewSize, false, true);
					}
					return;
				}
				break;
			case ESubScreenOperationType.Adjust:
				break;
			case ESubScreenOperationType.Exit:
				goto IL_391;
			default:
				return;
			}
			global::Log.Instance.Info(ELogModule.Event, ELogAuthor.LJM, "[分屏相机][关卡事件]调整分屏", default(ReadOnlySpan<ValueTuple<string, object>>));
			using (List<ISetSubScreenData>.Enumerator enumerator2 = (this.Params.Config as ISubScreenModeAdjust).AdjustConfigs.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					ISetSubScreenData setSubScreenData = enumerator2.Current;
					string text = (setSubScreenData.TargetScreen.Type == EScreenType.Main) ? "MainCamera" : (setSubScreenData.TargetScreen as ISubScreen).SubScreenKey;
					global::Log instance2 = global::Log.Instance;
					ELogModule module2 = ELogModule.Event;
					ELogAuthor author2 = ELogAuthor.LJM;
					string message2 = "[分屏相机][关卡事件]调整分屏";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("cameraName", text);
					instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					this.ViewLocation.X = (double)setSubScreenData.TargetSubScreenConfig.Anchor.X.GetValueOrDefault();
					this.ViewLocation.Y = (double)setSubScreenData.TargetSubScreenConfig.Anchor.Y.GetValueOrDefault();
					this.ViewSize.X = (double)setSubScreenData.TargetSubScreenConfig.Size.X.GetValueOrDefault();
					this.ViewSize.Y = (double)setSubScreenData.TargetSubScreenConfig.Size.Y.GetValueOrDefault();
					float transitionDuration = setSubScreenData.Transition.TransitionDuration;
					bool valueOrDefault = setSubScreenData.TargetSubScreenConfig.IsSeamlessScreen.GetValueOrDefault();
					this.CameraModel = CameraController.Instance.GetSeparateCameraModel(text);
					CameraController.Instance.FadeSeparateCamera(text, transitionDuration, this.ViewLocation, this.ViewSize, valueOrDefault, this.GetLoadedCurveFloat(setSubScreenData.Transition.TransitionCurve), delegate
					{
					}, true);
				}
				return;
			}
			IL_391:
			global::Log.Instance.Info(ELogModule.Event, ELogAuthor.LJM, "[分屏相机][关卡事件]离开分屏", default(ReadOnlySpan<ValueTuple<string, object>>));
			foreach (ISetSubScreenData setSubScreenData2 in (this.Params.Config as ISubScreenModeExit).ExitConfigs)
			{
				string text2 = (setSubScreenData2.TargetScreen.Type == EScreenType.Main) ? "MainCamera" : (setSubScreenData2.TargetScreen as ISubScreen).SubScreenKey;
				global::Log instance3 = global::Log.Instance;
				ELogModule module3 = ELogModule.Event;
				ELogAuthor author3 = ELogAuthor.LJM;
				string message3 = "[分屏相机][关卡事件]离开分屏";
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("cameraName", text2);
				instance3.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
				this.ViewLocation.X = (double)setSubScreenData2.TargetSubScreenConfig.Anchor.X.GetValueOrDefault();
				this.ViewLocation.Y = (double)setSubScreenData2.TargetSubScreenConfig.Anchor.Y.GetValueOrDefault();
				this.ViewSize.X = (double)setSubScreenData2.TargetSubScreenConfig.Size.X.GetValueOrDefault();
				this.ViewSize.Y = (double)setSubScreenData2.TargetSubScreenConfig.Size.Y.GetValueOrDefault();
				float transitionDuration2 = setSubScreenData2.Transition.TransitionDuration;
				bool valueOrDefault2 = setSubScreenData2.TargetSubScreenConfig.IsSeamlessScreen.GetValueOrDefault();
				this.CameraModel = CameraController.Instance.GetSeparateCameraModel(text2);
				CameraController.Instance.DestroySeparateCameraModel(text2, transitionDuration2, this.ViewLocation, this.ViewSize, valueOrDefault2, this.GetLoadedCurveFloat(setSubScreenData2.Transition.TransitionCurve), delegate
				{
				});
			}
		}

		// Token: 0x06044222 RID: 279074 RVA: 0x010C6E60 File Offset: 0x010C5060
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private UniTask<UCurveFloat> LoadCurveFloat(string path)
		{
			LevelEventSeparateCamera.<LoadCurveFloat>d__10 <LoadCurveFloat>d__;
			<LoadCurveFloat>d__.<>t__builder = AsyncUniTaskMethodBuilder<UCurveFloat>.Create();
			<LoadCurveFloat>d__.path = path;
			<LoadCurveFloat>d__.<>1__state = -1;
			<LoadCurveFloat>d__.<>t__builder.Start<LevelEventSeparateCamera.<LoadCurveFloat>d__10>(ref <LoadCurveFloat>d__);
			return <LoadCurveFloat>d__.<>t__builder.Task;
		}

		// Token: 0x06044223 RID: 279075 RVA: 0x010C6EA4 File Offset: 0x010C50A4
		[return: Nullable(2)]
		private UCurveFloat GetLoadedCurveFloat(string path)
		{
			if (this.LoadedCurveFloatArray.Count <= 0)
			{
				return null;
			}
			foreach (UCurveFloat ucurveFloat in this.LoadedCurveFloatArray)
			{
				if (ucurveFloat != null && path.EndsWith(ucurveFloat.GetName()))
				{
					return ucurveFloat;
				}
			}
			return null;
		}

		// Token: 0x06044224 RID: 279076 RVA: 0x010C6F18 File Offset: 0x010C5118
		private Vector2D GetInitViewLocation(ESubScreenInitPreset presetAnchor, Vector2D outVector2D)
		{
			switch (presetAnchor)
			{
			case ESubScreenInitPreset.Left:
				outVector2D.Set(0.0, 0.0);
				break;
			case ESubScreenInitPreset.Right:
				outVector2D.Set(1.0, 0.0);
				break;
			case ESubScreenInitPreset.Top:
				outVector2D.Set(0.0, 0.0);
				break;
			case ESubScreenInitPreset.Bottom:
				outVector2D.Set(0.0, 1.0);
				break;
			default:
				outVector2D.Set(0.0, 0.0);
				break;
			}
			return outVector2D;
		}

		// Token: 0x06044225 RID: 279077 RVA: 0x010C6FC0 File Offset: 0x010C51C0
		private Vector2D GetInitViewSize(ESubScreenInitPreset presetAnchor, Vector2D outVector2D)
		{
			switch (presetAnchor)
			{
			case ESubScreenInitPreset.Left:
				outVector2D.Set(0.0, 1.0);
				break;
			case ESubScreenInitPreset.Right:
				outVector2D.Set(0.0, 1.0);
				break;
			case ESubScreenInitPreset.Top:
				outVector2D.Set(1.0, 0.0);
				break;
			case ESubScreenInitPreset.Bottom:
				outVector2D.Set(1.0, 0.0);
				break;
			default:
				outVector2D.Set(0.0, 0.0);
				break;
			}
			return outVector2D;
		}

		// Token: 0x06044226 RID: 279078 RVA: 0x010C7066 File Offset: 0x010C5266
		protected override void OnReset()
		{
			this.LoadedCurveFloatArray.Clear();
		}

		// Token: 0x04023944 RID: 145732
		[Nullable(2)]
		public SetSubScreenMode Params;

		// Token: 0x04023945 RID: 145733
		[Nullable(2)]
		public CameraModelInstance CameraModel;

		// Token: 0x04023946 RID: 145734
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private readonly List<UCurveFloat> LoadedCurveFloatArray = new List<UCurveFloat>();

		// Token: 0x04023947 RID: 145735
		private readonly Vector2D ViewLocation = Vector2D.Create();

		// Token: 0x04023948 RID: 145736
		private readonly Vector2D ViewSize = Vector2D.Create();
	}
}
