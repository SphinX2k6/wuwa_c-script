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

// Token: 0x02001132 RID: 4402
[NullableContext(2)]
[Nullable(0)]
public class DrawMainView : GachaSceneView
{
	// Token: 0x0600AF8D RID: 44941 RVA: 0x0033C092 File Offset: 0x0033A292
	[NullableContext(1)]
	public DrawMainView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600AF8E RID: 44942 RVA: 0x0033C0B4 File Offset: 0x0033A2B4
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

	// Token: 0x0600AF8F RID: 44943 RVA: 0x0033C15A File Offset: 0x0033A35A
	private void OnClickSkipBtn()
	{
		this.IsSkip = true;
		if (this.IsLoadComplete)
		{
			this.ShowNextView();
		}
	}

	// Token: 0x0600AF90 RID: 44944 RVA: 0x0033C174 File Offset: 0x0033A374
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

	// Token: 0x0600AF91 RID: 44945 RVA: 0x0033C36C File Offset: 0x0033A56C
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

	// Token: 0x0600AF92 RID: 44946 RVA: 0x0033C4B8 File Offset: 0x0033A6B8
	protected override void OnStart()
	{
		this.InitLevelSequence();
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		int num = 0;
		int num2 = 0;
		Global.CharacterController.GetViewportSize(ref num, ref num2);
		this.ScreenX = (float)num;
	}

	// Token: 0x0600AF93 RID: 44947 RVA: 0x0033C4F6 File Offset: 0x0033A6F6
	protected override void OnBeforeDestroy()
	{
		TimerSystem.GameplayTimeInstance.Next(delegate(float _)
		{
			ActorSystem.Instance.Put("DrawMainView.OnBeforeDestroy", this.ShowSequence, null);
		}, null, null);
		this.ShowSequence = null;
		this.LevelSequencePlayer.Clear();
	}

	// Token: 0x0600AF94 RID: 44948 RVA: 0x0033C524 File Offset: 0x0033A724
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

	// Token: 0x0600AF95 RID: 44949 RVA: 0x0033C604 File Offset: 0x0033A804
	public void OnDragBeginCallBack(ULGUIPointerEventData eventData)
	{
		this.BeginDragPosition = new FVector?(eventData.pointerPosition);
		this.BeginValue = this.StartValue;
		this.IsDrag = true;
		this.TipWaitTime = 0f;
		this.LevelSequencePlayer.PlayLevelSequenceByName("DrawTipsHide", false, null, false);
		this.IsShowTips = false;
	}

	// Token: 0x0600AF96 RID: 44950 RVA: 0x0033C664 File Offset: 0x0033A864
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

	// Token: 0x0600AF97 RID: 44951 RVA: 0x0033C76D File Offset: 0x0033A96D
	public void OnDragEndCallBack(ULGUIPointerEventData eventData)
	{
		this.IsDrag = false;
	}

	// Token: 0x0600AF98 RID: 44952 RVA: 0x0033C778 File Offset: 0x0033A978
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

	// Token: 0x0600AF99 RID: 44953 RVA: 0x0033C7E8 File Offset: 0x0033A9E8
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

	// Token: 0x04006573 RID: 25971
	private ALevelSequenceActor ShowSequence;

	// Token: 0x04006574 RID: 25972
	private readonly ULevelSequencePlayer ShowSequencePlayer;

	// Token: 0x04006575 RID: 25973
	[Nullable(1)]
	private string ShowSequencePath = "";

	// Token: 0x04006576 RID: 25974
	private AActor OriginCameraActor;

	// Token: 0x04006577 RID: 25975
	private BP_GachaArt_C GachaArtBP;

	// Token: 0x04006578 RID: 25976
	private float Value;

	// Token: 0x04006579 RID: 25977
	private float PlaySequenceProcess;

	// Token: 0x0400657A RID: 25978
	private float DefaultProcess;

	// Token: 0x0400657B RID: 25979
	private float ChangeColorProcess;

	// Token: 0x0400657C RID: 25980
	private FVector? BeginDragPosition;

	// Token: 0x0400657D RID: 25981
	private float CompleteChangeColorProcess;

	// Token: 0x0400657E RID: 25982
	private FLinearColor? FinalColor;

	// Token: 0x0400657F RID: 25983
	private FVector2D MousePosition = new FVector2D();

	// Token: 0x04006580 RID: 25984
	private float ScreenX;

	// Token: 0x04006581 RID: 25985
	private bool IsPlay;

	// Token: 0x04006582 RID: 25986
	public UCurveFloat SlideCurve;

	// Token: 0x04006583 RID: 25987
	private float StartValue;

	// Token: 0x04006584 RID: 25988
	private float BeginValue;

	// Token: 0x04006585 RID: 25989
	private bool IsLoadComplete;

	// Token: 0x04006586 RID: 25990
	private bool IsDone;

	// Token: 0x04006587 RID: 25991
	private bool IsSkip;

	// Token: 0x04006588 RID: 25992
	private float TipWaitTime;

	// Token: 0x04006589 RID: 25993
	private bool IsDrag;

	// Token: 0x0400658A RID: 25994
	private bool IsShowTips;

	// Token: 0x0400658B RID: 25995
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x020073B3 RID: 29619
	[NullableContext(0)]
	private enum EDrawMainViewDefine
	{
		// Token: 0x04025ABE RID: 154302
		DragArea,
		// Token: 0x04025ABF RID: 154303
		SkipBtn
	}
}
