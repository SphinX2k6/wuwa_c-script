using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002037 RID: 8247
[NullableContext(2)]
[Nullable(0)]
public class KingShipCardItem : UiPanelBase
{
	// Token: 0x06010307 RID: 66311 RVA: 0x003F1754 File Offset: 0x003EF954
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUITexture)),
			new ValueTuple<int, Type>(5, typeof(UUITexture)),
			new ValueTuple<int, Type>(18, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUISprite)),
			new ValueTuple<int, Type>(12, typeof(UUIText)),
			new ValueTuple<int, Type>(13, typeof(UUITexture)),
			new ValueTuple<int, Type>(14, typeof(UUITexture)),
			new ValueTuple<int, Type>(15, typeof(UUITexture)),
			new ValueTuple<int, Type>(16, typeof(UUITexture)),
			new ValueTuple<int, Type>(20, typeof(UUITexture)),
			new ValueTuple<int, Type>(17, typeof(UUITexture)),
			new ValueTuple<int, Type>(21, typeof(UUITexture)),
			new ValueTuple<int, Type>(19, typeof(UUIItem)),
			new ValueTuple<int, Type>(22, typeof(UUIItem))
		};
	}

	// Token: 0x06010308 RID: 66312 RVA: 0x003F1960 File Offset: 0x003EFB60
	protected override UniTask OnBeforeStartAsync()
	{
		KingShipCardItem.<OnBeforeStartAsync>d__52 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<KingShipCardItem.<OnBeforeStartAsync>d__52>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010309 RID: 66313 RVA: 0x003F19A3 File Offset: 0x003EFBA3
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.Clear();
		}
		this.LevelSequencePlayer = null;
	}

	// Token: 0x0601030A RID: 66314 RVA: 0x003F19C0 File Offset: 0x003EFBC0
	protected override void OnStart()
	{
		this.RotationItem = base.GetItem(19);
		this.LocationItem = base.GetItem(18);
		UUIItem rotationItem = this.RotationItem;
		if (rotationItem != null)
		{
			FRotator frotator = this.CacheRotator.ToUeRotator();
			rotationItem.SetUIRelativeRotation(frotator);
		}
		this.RightItem = base.GetItem(8);
		this.LeftItem = base.GetItem(7);
		this.RightTexture = base.GetTexture(5);
		this.LeftTexture = base.GetTexture(4);
		this.LayerTextureA = base.GetTexture(16);
		this.LayerTextureB = base.GetTexture(15);
		this.LayerTextureC = base.GetTexture(14);
		this.LayerTextureD = base.GetTexture(13);
		this.LayerTextureE = base.GetTexture(20);
		this.LayerTextureF = base.GetTexture(17);
		this.LayerTextureG = base.GetTexture(21);
		base.GetItem(9).SetUIActive(false);
		this.CacheBarVector.Y = (double)this.RightTexture.RelativeLocation.Y;
		this.ViewPortPercentage = ConfigCommonParamById.GetFloatConfig("KingShipViewPortPercentage").GetValueOrDefault();
		this.SensitivityPitch = ConfigCommonParamById.GetFloatConfig("KingShipSensitivityPitch").GetValueOrDefault();
		this.GamepadInputRate = ConfigCommonParamById.GetFloatConfig("KingShipGamepadInputRate").GetValueOrDefault();
		this.MobileRotateInputRate = ConfigCommonParamById.GetFloatConfig("KingShipMobileRotateInputRate").GetValueOrDefault();
		this.LocationWhenPitch = ConfigCommonParamById.GetFloatConfig("KingShipXLocationWhenPitch").GetValueOrDefault();
		this.KingShipCardContentTextRotateRate = ConfigCommonParamById.GetFloatConfig("KingShipCardContentTextRotateRate").GetValueOrDefault();
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.LevelSequencePlayer.BindSequenceCloseEvent(delegate(string name)
		{
			if (name == "DropL" || name == "DropR")
			{
				Action<bool> onCallBackDropSequence = this.OnCallBackDropSequence;
				if (onCallBackDropSequence != null)
				{
					onCallBackDropSequence(name == "DropR");
				}
				this.CardSequencePlayering++;
				if (!this.IsShowBuffCard)
				{
					base.GetItem(9).SetUIActive(false);
					base.GetItem(22).SetUIActive(false);
					LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
					if (levelSequencePlayer != null)
					{
						levelSequencePlayer.PlayLevelSequenceByName("Flip", false, null, false);
					}
				}
				else
				{
					LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
					if (levelSequencePlayer2 != null)
					{
						levelSequencePlayer2.PlayLevelSequenceByName("FlipB", false, null, false);
					}
				}
				this.ClearCardItemRotation();
			}
			if (name == "ResetL" || name == "ResetR")
			{
				this.ClearCardItemRotation();
			}
			this.CardSequencePlayering--;
		}, false);
	}

	// Token: 0x0601030B RID: 66315 RVA: 0x003F1B84 File Offset: 0x003EFD84
	[NullableContext(1)]
	public void RefreshCardItemByShowTalk(int whoId, string backGroundPath)
	{
		this.IsShowBuffCard = false;
		if (!string.IsNullOrEmpty(backGroundPath))
		{
			this.SetCardBackGroud(backGroundPath);
		}
		Speaker? speaker = (whoId != 0) ? ConfigSpeakerById.GetConfig(whoId, true) : null;
		if (speaker == null)
		{
			return;
		}
		string newText = PublicUtil.Instance.GetConfigTextByTable(ETableText.SpeakerName, new int?(speaker.Value.Id)) ?? "";
		UUIText text = base.GetText(2);
		if (text != null)
		{
			text.SetText(newText, true);
		}
		if (speaker.Value.Title == 0)
		{
			UUIText text2 = base.GetText(3);
			if (text2 != null)
			{
				text2.SetUIActive(false);
			}
		}
		UUIText text3 = base.GetText(3);
		if (text3 != null)
		{
			text3.SetUIActive(true);
		}
		string newText2 = PublicUtil.Instance.GetConfigTextByTable(ETableText.SpeakerTitle, new int?(speaker.Value.Id)) ?? "";
		UUIText text4 = base.GetText(3);
		if (text4 != null)
		{
			text4.SetText(newText2, true);
		}
		base.GetText(0).SetUIActive(true);
		base.GetText(1).SetUIActive(true);
	}

	// Token: 0x0601030C RID: 66316 RVA: 0x003F1C98 File Offset: 0x003EFE98
	public void RefreshCardItemByCallCard(int cardId)
	{
		this.IsShowBuffCard = false;
		base.GetItem(9).SetUIActive(true);
		base.GetText(0).SetUIActive(false);
		base.GetText(1).SetUIActive(false);
		UUIText text = base.GetText(3);
		if (text != null)
		{
			text.SetUIActive(false);
		}
		base.GetItem(22).SetUIActive(false);
		ReignsCard reignsCallCard = KingShipConfig.Instance.GetReignsCallCard(cardId);
		if (!string.IsNullOrEmpty(reignsCallCard.CardBackground))
		{
			this.SetCardBackGroud(reignsCallCard.CardBackground);
		}
		base.GetText(12).SetUIActive(false);
		string configTextByKey = PublicUtil.Instance.GetConfigTextByKey("ReignsCard_" + cardId.ToString() + "_CardTitle");
		base.GetText(2).SetText(configTextByKey, true);
		base.GetSprite(11).SetUIActive(false);
	}

	// Token: 0x0601030D RID: 66317 RVA: 0x003F1D68 File Offset: 0x003EFF68
	public void RefreshCardItemByBuffCard(int cardId)
	{
		this.IsShowBuffCard = true;
		base.GetItem(9).SetUIActive(true);
		base.GetText(0).SetUIActive(false);
		base.GetText(1).SetUIActive(false);
		UUIText text = base.GetText(3);
		if (text != null)
		{
			text.SetUIActive(false);
		}
		base.GetText(12).SetUIActive(true);
		base.GetItem(22).SetUIActive(true);
		ReignsCard reignsCallCard = KingShipConfig.Instance.GetReignsCallCard(cardId);
		if (!string.IsNullOrEmpty(reignsCallCard.CardBackground))
		{
			this.SetCardBackGroud(reignsCallCard.CardBackground);
		}
		string configTextByKey = PublicUtil.Instance.GetConfigTextByKey("ReignsCard_" + cardId.ToString() + "_CardDesc");
		base.GetText(12).SetText(configTextByKey, true);
		string configTextByKey2 = PublicUtil.Instance.GetConfigTextByKey("ReignsCard_" + cardId.ToString() + "_CardTitle");
		base.GetText(2).SetText(configTextByKey2, true);
		base.GetSprite(11).SetUIActive(!StringUtils.IsEmpty(reignsCallCard.CardIcon));
		if (!string.IsNullOrEmpty(reignsCallCard.CardIcon))
		{
			this.SetSpriteByPath(reignsCallCard.CardIcon, base.GetSprite(11), false, null, null);
		}
	}

	// Token: 0x0601030E RID: 66318 RVA: 0x003F1EA4 File Offset: 0x003F00A4
	[NullableContext(1)]
	private void SetCardBackGroud(string backGroundPath)
	{
		UUITexture layerTextureA = this.LayerTextureA;
		if (layerTextureA != null)
		{
			layerTextureA.SetUIActive(false);
		}
		UUITexture layerTextureB = this.LayerTextureB;
		if (layerTextureB != null)
		{
			layerTextureB.SetUIActive(false);
		}
		UUITexture layerTextureC = this.LayerTextureC;
		if (layerTextureC != null)
		{
			layerTextureC.SetUIActive(false);
		}
		UUITexture layerTextureD = this.LayerTextureD;
		if (layerTextureD != null)
		{
			layerTextureD.SetUIActive(false);
		}
		UUITexture layerTextureE = this.LayerTextureE;
		if (layerTextureE != null)
		{
			layerTextureE.SetUIActive(false);
		}
		UUITexture layerTextureF = this.LayerTextureF;
		if (layerTextureF != null)
		{
			layerTextureF.SetUIActive(false);
		}
		this.SetCardBackGroudAsync(backGroundPath).ContinueWith(delegate()
		{
			UUITexture layerTextureA2 = this.LayerTextureA;
			if (layerTextureA2 != null)
			{
				layerTextureA2.SetUIActive(true);
			}
			UUITexture layerTextureB2 = this.LayerTextureB;
			if (layerTextureB2 != null)
			{
				layerTextureB2.SetUIActive(true);
			}
			UUITexture layerTextureC2 = this.LayerTextureC;
			if (layerTextureC2 != null)
			{
				layerTextureC2.SetUIActive(true);
			}
			UUITexture layerTextureD2 = this.LayerTextureD;
			if (layerTextureD2 != null)
			{
				layerTextureD2.SetUIActive(true);
			}
			UUITexture layerTextureE2 = this.LayerTextureE;
			if (layerTextureE2 != null)
			{
				layerTextureE2.SetUIActive(true);
			}
			UUITexture layerTextureF2 = this.LayerTextureF;
			if (layerTextureF2 == null)
			{
				return;
			}
			layerTextureF2.SetUIActive(true);
		}).Forget();
	}

	// Token: 0x0601030F RID: 66319 RVA: 0x003F1F3C File Offset: 0x003F013C
	[NullableContext(1)]
	private UniTask SetCardBackGroudAsync(string backGroundPath)
	{
		KingShipCardItem.<SetCardBackGroudAsync>d__59 <SetCardBackGroudAsync>d__;
		<SetCardBackGroudAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SetCardBackGroudAsync>d__.<>4__this = this;
		<SetCardBackGroudAsync>d__.backGroundPath = backGroundPath;
		<SetCardBackGroudAsync>d__.<>1__state = -1;
		<SetCardBackGroudAsync>d__.<>t__builder.Start<KingShipCardItem.<SetCardBackGroudAsync>d__59>(ref <SetCardBackGroudAsync>d__);
		return <SetCardBackGroudAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010310 RID: 66320 RVA: 0x003F1F87 File Offset: 0x003F0187
	public void SetCardItemInputPitch(float pitch)
	{
		this.PitchInput = pitch;
	}

	// Token: 0x06010311 RID: 66321 RVA: 0x003F1F90 File Offset: 0x003F0190
	public void SetCardItemPitchByPercentage(float percentage)
	{
		float num = MathUtils.Instance.Clamp(percentage, -this.ViewPortPercentage, this.ViewPortPercentage);
		this.TargetPitch = -(num / this.ViewPortPercentage) * this.MaxCardPitch;
	}

	// Token: 0x06010312 RID: 66322 RVA: 0x003F1FCC File Offset: 0x003F01CC
	public void ClearCardItemRotation()
	{
		this.CacheRotator.Pitch = 0f;
		this.CacheRotator.Yaw = 0f;
		this.CacheRotator.Roll = 0f;
		this.PitchInput = 0f;
		this.TargetPitch = 0f;
		this.RightEnd = false;
		this.LeftEnd = false;
		Action onClearPostionMax = this.OnClearPostionMax;
		if (onClearPostionMax != null)
		{
			onClearPostionMax();
		}
		this.UpdateRotator();
		this.UpdateBarSprite();
	}

	// Token: 0x06010313 RID: 66323 RVA: 0x003F204A File Offset: 0x003F024A
	public void ClearTargetRotation()
	{
		this.TargetPitch = 0f;
	}

	// Token: 0x06010314 RID: 66324 RVA: 0x003F2058 File Offset: 0x003F0258
	public void Update(float deltaTime)
	{
		if (this.CardSequencePlayering > 0 || !base.IsShowOrShowing)
		{
			return;
		}
		if (MathUtils.Instance.IsNearlyZero((double)this.TargetPitch, null))
		{
			this.UpdateInput(deltaTime);
		}
		else
		{
			this.UpdateTarget(deltaTime);
		}
		this.UpdatePitch();
		this.UpdateRotator();
		this.UpdateBarSprite();
	}

	// Token: 0x06010315 RID: 66325 RVA: 0x003F20B8 File Offset: 0x003F02B8
	private void UpdateInput(float deltaTime)
	{
		float num = this.PitchInput;
		this.PitchInput = 0f;
		if (Info.Instance.IsInGamepad())
		{
			num *= this.GamepadInputRate;
		}
		else if (Info.Instance.IsInTouch())
		{
			num *= this.MobileRotateInputRate;
		}
		num = num * this.SensitivityPitch * deltaTime;
		if (!MathUtils.Instance.IsNearlyZero((double)num, null))
		{
			this.CacheRotator.Pitch -= num;
		}
	}

	// Token: 0x06010316 RID: 66326 RVA: 0x003F2138 File Offset: 0x003F0338
	private void UpdateTarget(float deltaTime)
	{
		if (MathUtils.Instance.IsNearlyEqual((double)this.TargetPitch, (double)this.CacheRotator.Pitch, null))
		{
			return;
		}
		float num = Math.Abs(this.CacheRotator.Pitch - this.TargetPitch);
		float num2 = Math.Abs(this.CacheRotator.Pitch);
		float num3 = (float)Math.Sign(this.CacheRotator.Pitch);
		float num4 = Math.Abs(this.TargetPitch);
		float num5 = (float)Math.Sign(this.TargetPitch);
		UCurveFloat reignsCardMouseMoveCurve = this.ReignsCardMouseMoveCurve;
		float num6 = (reignsCardMouseMoveCurve != null) ? reignsCardMouseMoveCurve.GetFloatValue(num2 / num4) : 0f;
		if (num5 >= 0f)
		{
			if (num2 < num4)
			{
				if (num <= num6)
				{
					this.CacheRotator.Pitch = this.TargetPitch;
				}
				else
				{
					this.CacheRotator.Pitch += num6;
				}
			}
			else if (num <= num6)
			{
				this.CacheRotator.Pitch = this.TargetPitch;
			}
			else
			{
				this.CacheRotator.Pitch -= (float)((num3 >= 0f) ? 1 : -1) * num6;
			}
		}
		else if (num2 < num4)
		{
			if (num <= num6)
			{
				this.CacheRotator.Pitch = this.TargetPitch;
			}
			else
			{
				this.CacheRotator.Pitch -= num6;
			}
		}
		else if (num <= num6)
		{
			this.CacheRotator.Pitch = this.TargetPitch;
		}
		else
		{
			this.CacheRotator.Pitch += (float)((num3 >= 0f) ? -1 : 1) * num6;
		}
		this.TargetPitch = 0f;
	}

	// Token: 0x06010317 RID: 66327 RVA: 0x003F22D4 File Offset: 0x003F04D4
	private void UpdatePitch()
	{
		float num = this.CacheRotator.Pitch;
		num %= 360f;
		num = ((num > 180f) ? (num - 360f) : num);
		num = MathUtils.Instance.Clamp(num, -this.MaxCardPitch, this.MaxCardPitch);
		this.CacheRotator.Pitch = num;
	}

	// Token: 0x06010318 RID: 66328 RVA: 0x003F2330 File Offset: 0x003F0530
	private void UpdateRotator()
	{
		float inTime = this.CacheRotator.Pitch / this.MaxCardPitch;
		UCurveVector reignsCardRotatorCurve = this.ReignsCardRotatorCurve;
		FVector? fvector = (reignsCardRotatorCurve != null) ? new FVector?(reignsCardRotatorCurve.GetVectorValue(inTime)) : null;
		this.CacheRotator.Roll = ((fvector != null) ? fvector.GetValueOrDefault().X : 0f);
		this.CacheRotator.Yaw = ((fvector != null) ? fvector.GetValueOrDefault().Z : 0f);
		global::Vector cacheCardVector = this.CacheCardVector;
		UCurveFloat reignsCardOffsetCurve = this.ReignsCardOffsetCurve;
		cacheCardVector.X = (double)(((reignsCardOffsetCurve != null) ? reignsCardOffsetCurve.GetFloatValue(inTime) : 0f) * this.LocationWhenPitch);
		UUIItem locationItem = this.LocationItem;
		if (locationItem != null)
		{
			locationItem.SetUIRelativeLocation(this.CacheCardVector.ToUeVectorOld());
		}
		UUIItem rotationItem = this.RotationItem;
		if (rotationItem != null)
		{
			FRotator frotator = this.CacheRotator.ToUeRotator();
			rotationItem.SetUIRelativeRotation(frotator);
		}
		this.CacheContentRotator.Pitch = this.CacheRotator.Pitch * this.KingShipCardContentTextRotateRate;
		UUIItem contentItem = this.ContentItem;
		if (contentItem != null)
		{
			FRotator frotator = this.CacheContentRotator.ToUeRotator();
			contentItem.SetUIRelativeRotation(frotator);
		}
		UUITexture layerTextureA = this.LayerTextureA;
		if (layerTextureA != null)
		{
			layerTextureA.SetCustomMaterialScalarParameter(this.CardMaterialParamOffsetX, this.CacheRotator.Pitch * -0.001f);
		}
		UUITexture layerTextureA2 = this.LayerTextureA;
		if (layerTextureA2 != null)
		{
			layerTextureA2.SetCustomMaterialScalarParameter(this.CardMaterialParamOffsetY, this.CacheRotator.Roll * -0.001f);
		}
		UUITexture layerTextureB = this.LayerTextureB;
		if (layerTextureB != null)
		{
			layerTextureB.SetCustomMaterialScalarParameter(this.CardMaterialParamOffsetX, this.CacheRotator.Pitch * 0.0025f);
		}
		UUITexture layerTextureB2 = this.LayerTextureB;
		if (layerTextureB2 != null)
		{
			layerTextureB2.SetCustomMaterialScalarParameter(this.CardMaterialParamOffsetY, this.CacheRotator.Roll * 0.0025f);
		}
		UUITexture layerTextureC = this.LayerTextureC;
		if (layerTextureC != null)
		{
			layerTextureC.SetCustomMaterialScalarParameter(this.CardMaterialParamOffsetX, this.CacheRotator.Pitch * 0.0075f);
		}
		UUITexture layerTextureC2 = this.LayerTextureC;
		if (layerTextureC2 != null)
		{
			layerTextureC2.SetCustomMaterialScalarParameter(this.CardMaterialParamOffsetY, this.CacheRotator.Roll * 0.0075f);
		}
		UUITexture layerTextureD = this.LayerTextureD;
		if (layerTextureD != null)
		{
			layerTextureD.SetCustomMaterialScalarParameter(this.CardMaterialParamOffsetX, this.CacheRotator.Pitch * 0.01f);
		}
		UUITexture layerTextureD2 = this.LayerTextureD;
		if (layerTextureD2 != null)
		{
			layerTextureD2.SetCustomMaterialScalarParameter(this.CardMaterialParamOffsetY, this.CacheRotator.Roll * 0.01f);
		}
		UUITexture layerTextureG = this.LayerTextureG;
		if (layerTextureG != null)
		{
			layerTextureG.SetCustomMaterialScalarParameter(this.CardMaterialParamOffsetX, this.CacheRotator.Pitch * -0.01f);
		}
		UUITexture layerTextureG2 = this.LayerTextureG;
		if (layerTextureG2 == null)
		{
			return;
		}
		layerTextureG2.SetCustomMaterialScalarParameter(this.CardMaterialParamOffsetY, this.CacheRotator.Roll * -0.01f);
	}

	// Token: 0x06010319 RID: 66329 RVA: 0x003F25F0 File Offset: 0x003F07F0
	private void UpdateBarSprite()
	{
		float pitch = this.CacheRotator.Pitch;
		if (Math.Abs(pitch) < 1f)
		{
			UUIItem rightItem = this.RightItem;
			if (rightItem != null)
			{
				rightItem.SetUIActive(false);
			}
			UUIItem leftItem = this.LeftItem;
			if (leftItem == null)
			{
				return;
			}
			leftItem.SetUIActive(false);
			return;
		}
		else if (pitch > 0f)
		{
			UUIItem rightItem2 = this.RightItem;
			if (rightItem2 != null)
			{
				rightItem2.SetUIActive(false);
			}
			UUIItem leftItem2 = this.LeftItem;
			if (leftItem2 != null)
			{
				leftItem2.SetUIActive(true);
			}
			float inTime = pitch / this.MaxCardPitch;
			global::Vector cacheBarVector = this.CacheBarVector;
			UCurveFloat reignsBarOffsetCurve = this.ReignsBarOffsetCurve;
			cacheBarVector.X = (double)((reignsBarOffsetCurve != null) ? reignsBarOffsetCurve.GetFloatValue(inTime) : 0f);
			UUITexture leftTexture = this.LeftTexture;
			if (leftTexture != null)
			{
				leftTexture.SetUIRelativeLocation(this.CacheBarVector.ToUeVectorOld());
			}
			UUIItem leftItem3 = this.LeftItem;
			if (leftItem3 != null)
			{
				UCurveFloat reignsBarRootAlphaCurve = this.ReignsBarRootAlphaCurve;
				leftItem3.SetAlpha((reignsBarRootAlphaCurve != null) ? reignsBarRootAlphaCurve.GetFloatValue(inTime) : 0f);
			}
			global::Vector cacheBarRootVector = this.CacheBarRootVector;
			UCurveFloat reignsBarRootOffsetCurve = this.ReignsBarRootOffsetCurve;
			cacheBarRootVector.X = (double)((reignsBarRootOffsetCurve != null) ? reignsBarRootOffsetCurve.GetFloatValue(inTime) : 0f);
			UUIItem leftItem4 = this.LeftItem;
			if (leftItem4 != null)
			{
				leftItem4.SetUIRelativeLocation(this.CacheBarRootVector.ToUeVectorOld());
			}
			if (pitch >= this.MaxCardPitch)
			{
				if (!this.LeftEnd)
				{
					Action<bool> onPostionMaxCallBack = this.OnPostionMaxCallBack;
					if (onPostionMaxCallBack != null)
					{
						onPostionMaxCallBack(false);
					}
					AudioSystem.Instance.PostEvent("play_ui_com_slider_tick");
				}
				this.LeftEnd = true;
				this.RightEnd = false;
				return;
			}
			this.RightEnd = false;
			this.LeftEnd = false;
			Action onClearPostionMax = this.OnClearPostionMax;
			if (onClearPostionMax == null)
			{
				return;
			}
			onClearPostionMax();
			return;
		}
		else
		{
			UUIItem rightItem3 = this.RightItem;
			if (rightItem3 != null)
			{
				rightItem3.SetUIActive(true);
			}
			UUIItem leftItem5 = this.LeftItem;
			if (leftItem5 != null)
			{
				leftItem5.SetUIActive(false);
			}
			float inTime2 = pitch / this.MaxCardPitch;
			global::Vector cacheBarVector2 = this.CacheBarVector;
			UCurveFloat reignsBarOffsetCurve2 = this.ReignsBarOffsetCurve;
			cacheBarVector2.X = (double)((reignsBarOffsetCurve2 != null) ? reignsBarOffsetCurve2.GetFloatValue(inTime2) : 0f);
			UUITexture rightTexture = this.RightTexture;
			if (rightTexture != null)
			{
				rightTexture.SetUIRelativeLocation(this.CacheBarVector.ToUeVectorOld());
			}
			UUIItem rightItem4 = this.RightItem;
			if (rightItem4 != null)
			{
				UCurveFloat reignsBarRootAlphaCurve2 = this.ReignsBarRootAlphaCurve;
				rightItem4.SetAlpha((reignsBarRootAlphaCurve2 != null) ? reignsBarRootAlphaCurve2.GetFloatValue(inTime2) : 0f);
			}
			global::Vector cacheBarRootVector2 = this.CacheBarRootVector;
			UCurveFloat reignsBarRootOffsetCurve2 = this.ReignsBarRootOffsetCurve;
			cacheBarRootVector2.X = (double)((reignsBarRootOffsetCurve2 != null) ? reignsBarRootOffsetCurve2.GetFloatValue(inTime2) : 0f);
			UUIItem rightItem5 = this.RightItem;
			if (rightItem5 != null)
			{
				rightItem5.SetUIRelativeLocation(this.CacheBarRootVector.ToUeVectorOld());
			}
			if (pitch <= -this.MaxCardPitch)
			{
				if (!this.RightEnd)
				{
					Action<bool> onPostionMaxCallBack2 = this.OnPostionMaxCallBack;
					if (onPostionMaxCallBack2 != null)
					{
						onPostionMaxCallBack2(true);
					}
					AudioSystem.Instance.PostEvent("play_ui_com_slider_tick");
				}
				this.RightEnd = true;
				this.LeftEnd = false;
				return;
			}
			this.RightEnd = false;
			this.LeftEnd = false;
			Action onClearPostionMax2 = this.OnClearPostionMax;
			if (onClearPostionMax2 == null)
			{
				return;
			}
			onClearPostionMax2();
			return;
		}
	}

	// Token: 0x0601031A RID: 66330 RVA: 0x003F28B0 File Offset: 0x003F0AB0
	[NullableContext(1)]
	public void SetLeftAndRight(string leftText, string rightText)
	{
		string flowConfigLocalText = PublicUtil.Instance.GetFlowConfigLocalText(leftText);
		base.GetText(0).SetText(flowConfigLocalText ?? "", true);
		string flowConfigLocalText2 = PublicUtil.Instance.GetFlowConfigLocalText(rightText);
		base.GetText(1).SetText(flowConfigLocalText2 ?? "", true);
	}

	// Token: 0x0601031B RID: 66331 RVA: 0x003F2904 File Offset: 0x003F0B04
	[NullableContext(1)]
	public void PlaySequenceByName(string name)
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.StopCurrentSequence(true, true);
		}
		LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
		if (levelSequencePlayer2 != null)
		{
			levelSequencePlayer2.PlayLevelSequenceByName(name, false, null, false);
		}
		this.CardSequencePlayering++;
		this.LeftEnd = false;
		this.RightEnd = false;
	}

	// Token: 0x0601031C RID: 66332 RVA: 0x003F2960 File Offset: 0x003F0B60
	public void PlayReSetSequence()
	{
		UUIItem rightItem = this.RightItem;
		if (rightItem == null || !rightItem.IsUIActiveSelf())
		{
			UUIItem leftItem = this.LeftItem;
			if (leftItem != null && leftItem.IsUIActiveSelf())
			{
				this.CardSequencePlayering++;
				LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
				if (levelSequencePlayer != null)
				{
					levelSequencePlayer.StopCurrentSequence(true, true);
				}
				LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
				if (levelSequencePlayer2 == null)
				{
					return;
				}
				levelSequencePlayer2.PlayLevelSequenceByName("ResetL", false, null, false);
			}
			return;
		}
		this.CardSequencePlayering++;
		LevelSequencePlayer levelSequencePlayer3 = this.LevelSequencePlayer;
		if (levelSequencePlayer3 != null)
		{
			levelSequencePlayer3.StopCurrentSequence(true, true);
		}
		LevelSequencePlayer levelSequencePlayer4 = this.LevelSequencePlayer;
		if (levelSequencePlayer4 == null)
		{
			return;
		}
		levelSequencePlayer4.PlayLevelSequenceByName("ResetR", false, null, false);
	}

	// Token: 0x040077A8 RID: 30632
	private const float MATERIAL_LAYA = -0.001f;

	// Token: 0x040077A9 RID: 30633
	private const float MATERIAL_LAYB = 0.0025f;

	// Token: 0x040077AA RID: 30634
	private const float MATERIAL_LAYC = 0.0075f;

	// Token: 0x040077AB RID: 30635
	private const float MATERIAL_LAYD = 0.01f;

	// Token: 0x040077AC RID: 30636
	private const float MATERIAL_LAYG = -0.01f;

	// Token: 0x040077AD RID: 30637
	[Nullable(1)]
	private const string CLICK_AUDIO_EVENT = "play_ui_com_slider_tick";

	// Token: 0x040077AE RID: 30638
	[Nullable(1)]
	private readonly Rotator CacheRotator = Rotator.Create();

	// Token: 0x040077AF RID: 30639
	[Nullable(1)]
	private readonly Rotator CacheContentRotator = Rotator.Create();

	// Token: 0x040077B0 RID: 30640
	[Nullable(1)]
	private readonly global::Vector CacheCardVector = global::Vector.Create();

	// Token: 0x040077B1 RID: 30641
	[Nullable(1)]
	private readonly global::Vector CacheBarVector = global::Vector.Create();

	// Token: 0x040077B2 RID: 30642
	[Nullable(1)]
	private readonly global::Vector CacheBarRootVector = global::Vector.Create();

	// Token: 0x040077B3 RID: 30643
	private float GamepadInputRate = 1f;

	// Token: 0x040077B4 RID: 30644
	private float MobileRotateInputRate = 1f;

	// Token: 0x040077B5 RID: 30645
	private float SensitivityPitch;

	// Token: 0x040077B6 RID: 30646
	private float ViewPortPercentage;

	// Token: 0x040077B7 RID: 30647
	private float MaxCardPitch;

	// Token: 0x040077B8 RID: 30648
	private float LocationWhenPitch;

	// Token: 0x040077B9 RID: 30649
	private float KingShipCardContentTextRotateRate;

	// Token: 0x040077BA RID: 30650
	private UUIItem RotationItem;

	// Token: 0x040077BB RID: 30651
	private UUIItem LocationItem;

	// Token: 0x040077BC RID: 30652
	private UUIItem RightItem;

	// Token: 0x040077BD RID: 30653
	private UUIItem LeftItem;

	// Token: 0x040077BE RID: 30654
	private UUITexture RightTexture;

	// Token: 0x040077BF RID: 30655
	private UUITexture LeftTexture;

	// Token: 0x040077C0 RID: 30656
	private UCurveFloat ReignsCardMouseMoveCurve;

	// Token: 0x040077C1 RID: 30657
	private UCurveVector ReignsCardRotatorCurve;

	// Token: 0x040077C2 RID: 30658
	private UCurveFloat ReignsCardOffsetCurve;

	// Token: 0x040077C3 RID: 30659
	private UCurveFloat ReignsBarRootOffsetCurve;

	// Token: 0x040077C4 RID: 30660
	private UCurveFloat ReignsBarRootAlphaCurve;

	// Token: 0x040077C5 RID: 30661
	private UCurveFloat ReignsBarOffsetCurve;

	// Token: 0x040077C6 RID: 30662
	private UUITexture LayerTextureA;

	// Token: 0x040077C7 RID: 30663
	private UUITexture LayerTextureB;

	// Token: 0x040077C8 RID: 30664
	private UUITexture LayerTextureC;

	// Token: 0x040077C9 RID: 30665
	private UUITexture LayerTextureD;

	// Token: 0x040077CA RID: 30666
	private UUITexture LayerTextureE;

	// Token: 0x040077CB RID: 30667
	private UUITexture LayerTextureF;

	// Token: 0x040077CC RID: 30668
	private UUITexture LayerTextureG;

	// Token: 0x040077CD RID: 30669
	private float PitchInput;

	// Token: 0x040077CE RID: 30670
	private float TargetPitch;

	// Token: 0x040077CF RID: 30671
	public bool RightEnd;

	// Token: 0x040077D0 RID: 30672
	public bool LeftEnd;

	// Token: 0x040077D1 RID: 30673
	public Action<bool> OnPostionMaxCallBack;

	// Token: 0x040077D2 RID: 30674
	public Action OnClearPostionMax;

	// Token: 0x040077D3 RID: 30675
	public UUIItem ContentItem;

	// Token: 0x040077D4 RID: 30676
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x040077D5 RID: 30677
	private int CardSequencePlayering;

	// Token: 0x040077D6 RID: 30678
	private readonly FName CardMaterialParamOffsetX = new FName("OffsetX");

	// Token: 0x040077D7 RID: 30679
	private readonly FName CardMaterialParamOffsetY = new FName("OffsetY");

	// Token: 0x040077D8 RID: 30680
	public Action<bool> OnCallBackDropSequence;

	// Token: 0x040077D9 RID: 30681
	private bool IsShowBuffCard;

	// Token: 0x02008631 RID: 34353
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x0402BAAF RID: 178863
		public const int LeftText = 0;

		// Token: 0x0402BAB0 RID: 178864
		public const int RightText = 1;

		// Token: 0x0402BAB1 RID: 178865
		public const int CardNameText = 2;

		// Token: 0x0402BAB2 RID: 178866
		public const int CardDesText = 3;

		// Token: 0x0402BAB3 RID: 178867
		public const int LeftBarTexture = 4;

		// Token: 0x0402BAB4 RID: 178868
		public const int RightBarTexture = 5;

		// Token: 0x0402BAB5 RID: 178869
		public const int OldItem = 6;

		// Token: 0x0402BAB6 RID: 178870
		public const int LeftItem = 7;

		// Token: 0x0402BAB7 RID: 178871
		public const int RightItem = 8;

		// Token: 0x0402BAB8 RID: 178872
		public const int CallCardItem = 9;

		// Token: 0x0402BAB9 RID: 178873
		public const int CallCardItemIconItem = 10;

		// Token: 0x0402BABA RID: 178874
		public const int CallCardItemIconSprite = 11;

		// Token: 0x0402BABB RID: 178875
		public const int CallCardItemText = 12;

		// Token: 0x0402BABC RID: 178876
		public const int LayerDTexture = 13;

		// Token: 0x0402BABD RID: 178877
		public const int LayerCTexture = 14;

		// Token: 0x0402BABE RID: 178878
		public const int LayerBTexture = 15;

		// Token: 0x0402BABF RID: 178879
		public const int LayerATexture = 16;

		// Token: 0x0402BAC0 RID: 178880
		public const int LayerFTexture = 17;

		// Token: 0x0402BAC1 RID: 178881
		public const int LocationItem = 18;

		// Token: 0x0402BAC2 RID: 178882
		public const int RotatorItem = 19;

		// Token: 0x0402BAC3 RID: 178883
		public const int LayerETexture = 20;

		// Token: 0x0402BAC4 RID: 178884
		public const int LayerGTexture = 21;

		// Token: 0x0402BAC5 RID: 178885
		public const int GreenItem = 22;
	}
}
