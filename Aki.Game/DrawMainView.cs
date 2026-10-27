using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using AkiClient.Game.Aki.Scene.Gacha.Blueprint;
using CSharpScript.Game;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001C73 RID: 7283
[NullableContext(2)]
[Nullable(0)]
public class DrawMainView : GachaSceneView
{
	// Token: 0x0600DB77 RID: 56183 RVA: 0x00330C46 File Offset: 0x0032EE46
	[NullableContext(1)]
	public DrawMainView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600DB78 RID: 56184 RVA: 0x00330C68 File Offset: 0x0032EE68
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIDraggableComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickSkipBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600DB79 RID: 56185 RVA: 0x00330D0E File Offset: 0x0032EF0E
	private void OnClickSkipBtn()
	{
		this.IsSkip = true;
		if (this.IsLoadComplete)
		{
			this.ShowNextView();
		}
	}

	// Token: 0x0600DB7A RID: 56186 RVA: 0x00330D28 File Offset: 0x0032EF28
	protected override void OnAfterOpenUiScene()
	{
		this.OriginCameraActor = CameraController.Instance.MainModel.CurrentCameraActor;
		int times = GachaModel.Instance.CurGachaResult.Length;
		int num = 1;
		foreach (GachaResult gachaResult in GachaModel.Instance.CurGachaResult)
		{
			ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(gachaResult.Proto_GachaReward.ItemId);
			int num2 = (itemConfigData != null) ? itemConfigData.QualityId : 0;
			if (num2 > num)
			{
				num = num2;
			}
		}
		GachaEffectConfig? gachaEffectConfigByTimesAndQuality = GachaConfig.Instance.GetGachaEffectConfigByTimesAndQuality(times, num);
		int num3 = 0;
		int num4 = 0;
		Global.CharacterController.GetViewportSize(ref num3, ref num4);
		this.GachaArtBP = (UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("GachaBP").Value, ECollectActorType.Default) as BP_GachaArt_C);
		int num5 = num3;
		int num6 = num4;
		CameraController.Instance.SetViewTarget(this.GachaArtBP.SceneCameraActor, "OnAfterOpenUi", 0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, null, null, "MainCamera", null, null);
		this.GachaArtBP.Gacha_Result = (E_GachaResult)num;
		this.DefaultProcess = gachaEffectConfigByTimesAndQuality.Value.DefaultProcess;
		this.Value = 0f;
		this.ChangeColorProcess = gachaEffectConfigByTimesAndQuality.Value.ChangeColorProcess;
		this.CompleteChangeColorProcess = gachaEffectConfigByTimesAndQuality.Value.CompleteChangeColorProcess;
		this.PlaySequenceProcess = gachaEffectConfigByTimesAndQuality.Value.PlaySequenceProcess;
		this.GachaArtBP.TSInitParameters(new FVector2D((float)num5, (float)num6), (float)num5 * this.DefaultProcess, this.FinalColor.Value, (E_GachaResult)num);
		ResourceSystem.Instance.LoadAsync<UCurveFloat>(gachaEffectConfigByTimesAndQuality.Value.SlideCurveAssetPath, delegate([Nullable(2)] UCurveFloat asset, string _)
		{
			this.SlideCurve = asset;
			UUIDraggableComponent draggable = base.GetDraggable(0);
			draggable.OnPointerDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnDragCallBack));
			draggable.OnPointerBeginDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnDragBeginCallBack));
			draggable.OnPointerEndDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnDragEndCallBack));
		}, 100, this.MemoryTag);
		GachaController.Instance.PreloadGachaResultResource(delegate(EUiRoleLoadResult result)
		{
			this.IsLoadComplete = true;
			if (this.IsDone || this.IsSkip)
			{
				this.ShowNextView();
			}
		});
	}

	// Token: 0x0600DB7B RID: 56187 RVA: 0x00330F20 File Offset: 0x0032F120
	protected void InitLevelSequence()
	{
		int times = GachaModel.Instance.CurGachaResult.Length;
		int num = 1;
		foreach (GachaResult gachaResult in GachaModel.Instance.CurGachaResult)
		{
			ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(gachaResult.Proto_GachaReward.ItemId);
			int num2 = (itemConfigData != null) ? itemConfigData.QualityId : 0;
			if (num2 > num)
			{
				num = num2;
			}
		}
		GachaEffectConfig? gachaEffectConfigByTimesAndQuality = GachaConfig.Instance.GetGachaEffectConfigByTimesAndQuality(times, num);
		this.ShowSequencePath = gachaEffectConfigByTimesAndQuality.Value.FinalShowSequencePath;
		this.FinalColor = new FLinearColor?(new FLinearColor(gachaEffectConfigByTimesAndQuality.Value.FinalColor.Value.R, gachaEffectConfigByTimesAndQuality.Value.FinalColor.Value.G, gachaEffectConfigByTimesAndQuality.Value.FinalColor.Value.B, gachaEffectConfigByTimesAndQuality.Value.FinalColor.Value.A));
		ResourceSystem.Instance.LoadAsync<ULevelSequence>(this.ShowSequencePath, delegate([Nullable(2)] ULevelSequence levelSequenceObject, string _)
		{
			if (ObjectUtils.IsValid(levelSequenceObject))
			{
				FMovieSceneSequencePlaybackSettings fmovieSceneSequencePlaybackSettings = new FMovieSceneSequencePlaybackSettings();
				fmovieSceneSequencePlaybackSettings.bRestoreState = true;
				this.ShowSequence = (ActorSystem.Instance.Get(ALevelSequenceActor.StaticClass(), MathUtils.Instance.DefaultTransformDouble, null, false) as ALevelSequenceActor);
				this.ShowSequence.PlaybackSettings = fmovieSceneSequencePlaybackSettings;
				this.ShowSequence.SetSequence(levelSequenceObject);
				this.ShowSequencePlayer.OnFinished.Add(delegate()
				{
					this.IsDone = true;
					if (this.IsLoadComplete)
					{
						this.ShowNextView();
					}
				});
			}
		}, 100, this.MemoryTag);
	}

	// Token: 0x0600DB7C RID: 56188 RVA: 0x0033106C File Offset: 0x0032F26C
	protected override void OnStart()
	{
		this.InitLevelSequence();
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		int num = 0;
		int num2 = 0;
		Global.CharacterController.GetViewportSize(ref num, ref num2);
		this.ScreenX = (float)num;
	}

	// Token: 0x0600DB7D RID: 56189 RVA: 0x003310AA File Offset: 0x0032F2AA
	protected override void OnBeforeDestroy()
	{
		TimerSystem.GameplayTimeInstance.Next(delegate(float _)
		{
			ActorSystem.Instance.Put("DrawMainView.OnBeforeDestroy", this.ShowSequence, null);
		}, null, null);
		this.ShowSequence = null;
		this.LevelSequencePlayer.Clear();
	}

	// Token: 0x0600DB7E RID: 56190 RVA: 0x003310D8 File Offset: 0x0032F2D8
	protected override void OnTick(float deltaTime)
	{
		BP_GachaArt_C gachaArtBP = this.GachaArtBP;
		if (gachaArtBP != null && gachaArtBP.SceneCameraActor.IsValid() && CameraModel.Instance.MainModel.CurrentCameraActor != this.GachaArtBP.SceneCameraActor && !this.IsPlay)
		{
			CameraController.Instance.SetViewTarget(this.GachaArtBP.SceneCameraActor, "DrawMainView.OnTick", 0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, null, null, "MainCamera", null, null);
		}
		if (!this.IsDrag && !this.IsShowTips && !this.IsPlay)
		{
			this.TipWaitTime += deltaTime;
			if (this.TipWaitTime >= 2000f)
			{
				this.LevelSequencePlayer.PlayLevelSequenceByName("DrawTipsShow", false, null, false);
				this.IsShowTips = true;
			}
		}
	}

	// Token: 0x0600DB7F RID: 56191 RVA: 0x003311B8 File Offset: 0x0032F3B8
	public void OnDragBeginCallBack(ULGUIPointerEventData eventData)
	{
		this.BeginDragPosition = new FVector?(eventData.pointerPosition);
		this.BeginValue = this.StartValue;
		this.IsDrag = true;
		this.TipWaitTime = 0f;
		this.LevelSequencePlayer.PlayLevelSequenceByName("DrawTipsHide", false, null, false);
		this.IsShowTips = false;
	}

	// Token: 0x0600DB80 RID: 56192 RVA: 0x00331218 File Offset: 0x0032F418
	public void OnDragCallBack(ULGUIPointerEventData eventData)
	{
		this.MousePosition.X = eventData.pointerPosition.X;
		this.MousePosition.Y = eventData.pointerPosition.Y;
		float num = (eventData.pointerPosition.X - this.BeginDragPosition.Value.X) / this.ScreenX;
		this.Value = this.SlideCurve.GetFloatValue(num + this.BeginValue);
		this.StartValue = MathUtils.Instance.Clamp(num + this.BeginValue, 0f, 1f);
		if (this.Value > this.PlaySequenceProcess)
		{
			if (this.IsPlay)
			{
				return;
			}
			this.IsPlay = true;
			this.PlayShowSequence();
		}
		float colorChangeProcess = MathUtils.Instance.Clamp((this.Value - this.ChangeColorProcess) / (this.CompleteChangeColorProcess - this.ChangeColorProcess), 0f, 1f);
		BP_GachaArt_C gachaArtBP = this.GachaArtBP;
		if (gachaArtBP == null)
		{
			return;
		}
		gachaArtBP.TSUpdateParameters(this.Value, colorChangeProcess, this.MousePosition);
	}

	// Token: 0x0600DB81 RID: 56193 RVA: 0x00331321 File Offset: 0x0032F521
	public void OnDragEndCallBack(ULGUIPointerEventData eventData)
	{
		this.IsDrag = false;
	}

	// Token: 0x0600DB82 RID: 56194 RVA: 0x0033132C File Offset: 0x0032F52C
	public void PlayShowSequence()
	{
		this.GachaArtBP.SetActorHiddenInGame(true);
		base.GetButton(1).RootUIComp.Get().SetUIActive(true);
		(base.GetDraggable(0).GetOwner().GetComponentByClass(UUIItem.StaticClass()) as UUIItem).SetUIActive(false);
		ALevelSequenceActor showSequence = this.ShowSequence;
		if (showSequence == null)
		{
			return;
		}
		showSequence.SequencePlayer.Play();
	}

	// Token: 0x0600DB83 RID: 56195 RVA: 0x0033139C File Offset: 0x0032F59C
	public void ShowNextView()
	{
		ULevelSequencePlayer showSequencePlayer = this.ShowSequencePlayer;
		if (showSequencePlayer != null)
		{
			showSequencePlayer.Stop();
		}
		CameraController.Instance.SetViewTarget(this.OriginCameraActor, "ShowNextView", 0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, null, null, "MainCamera", null, null);
		base.CloseMe(null);
		UiManager.Instance.OpenView(EUiViewName.GachaScanView, null, null);
	}

	// Token: 0x040064A1 RID: 25761
	private ALevelSequenceActor ShowSequence;

	// Token: 0x040064A2 RID: 25762
	private readonly ULevelSequencePlayer ShowSequencePlayer;

	// Token: 0x040064A3 RID: 25763
	[Nullable(1)]
	private string ShowSequencePath = "";

	// Token: 0x040064A4 RID: 25764
	private AActor OriginCameraActor;

	// Token: 0x040064A5 RID: 25765
	private BP_GachaArt_C GachaArtBP;

	// Token: 0x040064A6 RID: 25766
	private float Value;

	// Token: 0x040064A7 RID: 25767
	private float PlaySequenceProcess;

	// Token: 0x040064A8 RID: 25768
	private float DefaultProcess;

	// Token: 0x040064A9 RID: 25769
	private float ChangeColorProcess;

	// Token: 0x040064AA RID: 25770
	private FVector? BeginDragPosition;

	// Token: 0x040064AB RID: 25771
	private float CompleteChangeColorProcess;

	// Token: 0x040064AC RID: 25772
	private FLinearColor? FinalColor;

	// Token: 0x040064AD RID: 25773
	private FVector2D MousePosition = new FVector2D();

	// Token: 0x040064AE RID: 25774
	private float ScreenX;

	// Token: 0x040064AF RID: 25775
	private bool IsPlay;

	// Token: 0x040064B0 RID: 25776
	public UCurveFloat SlideCurve;

	// Token: 0x040064B1 RID: 25777
	private float StartValue;

	// Token: 0x040064B2 RID: 25778
	private float BeginValue;

	// Token: 0x040064B3 RID: 25779
	private bool IsLoadComplete;

	// Token: 0x040064B4 RID: 25780
	private bool IsDone;

	// Token: 0x040064B5 RID: 25781
	private bool IsSkip;

	// Token: 0x040064B6 RID: 25782
	private float TipWaitTime;

	// Token: 0x040064B7 RID: 25783
	private bool IsDrag;

	// Token: 0x040064B8 RID: 25784
	private bool IsShowTips;

	// Token: 0x040064B9 RID: 25785
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0200822A RID: 33322
	[NullableContext(0)]
	private enum EDrawMainViewDefine
	{
		// Token: 0x0402A798 RID: 173976
		DragArea,
		// Token: 0x0402A799 RID: 173977
		SkipBtn
	}
}
