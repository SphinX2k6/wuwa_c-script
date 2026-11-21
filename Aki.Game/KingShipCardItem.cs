using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200150A RID: 5386
[NullableContext(2)]
[Nullable(0)]
public class KingShipCardItem : UiPanelBase
{
	// Token: 0x0600D76F RID: 55151 RVA: 0x003FDD4C File Offset: 0x003FBF4C
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

	// Token: 0x0600D770 RID: 55152 RVA: 0x003FDF58 File Offset: 0x003FC158
	protected override UniTask OnBeforeStartAsync()
	{
		KingShipCardItem.<OnBeforeStartAsync>d__52 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<KingShipCardItem.<OnBeforeStartAsync>d__52>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D771 RID: 55153 RVA: 0x003FDF9B File Offset: 0x003FC19B
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.Clear();
		}
		this.LevelSequencePlayer = null;
	}

	// Token: 0x0600D772 RID: 55154 RVA: 0x003FDFB8 File Offset: 0x003FC1B8
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

	// Token: 0x0600D773 RID: 55155 RVA: 0x003FE17C File Offset: 0x003FC37C
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

	// Token: 0x0600D774 RID: 55156 RVA: 0x003FE290 File Offset: 0x003FC490
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

	// Token: 0x0600D775 RID: 55157 RVA: 0x003FE360 File Offset: 0x003FC560
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

	// Token: 0x0600D776 RID: 55158 RVA: 0x003FE49C File Offset: 0x003FC69C
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

	// Token: 0x0600D777 RID: 55159 RVA: 0x003FE534 File Offset: 0x003FC734
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

	// Token: 0x0600D778 RID: 55160 RVA: 0x003FE57F File Offset: 0x003FC77F
	public void SetCardItemInputPitch(float pitch)
	{
		this.PitchInput = pitch;
	}

	// Token: 0x0600D779 RID: 55161 RVA: 0x003FE588 File Offset: 0x003FC788
	public void SetCardItemPitchByPercentage(float percentage)
	{
		float num = MathUtils.Instance.Clamp(percentage, -this.ViewPortPercentage, this.ViewPortPercentage);
		this.TargetPitch = -(num / this.ViewPortPercentage) * this.MaxCardPitch;
	}

	// Token: 0x0600D77A RID: 55162 RVA: 0x003FE5C4 File Offset: 0x003FC7C4
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

	// Token: 0x0600D77B RID: 55163 RVA: 0x003FE642 File Offset: 0x003FC842
	public void ClearTargetRotation()
	{
		this.TargetPitch = 0f;
	}

	// Token: 0x0600D77C RID: 55164 RVA: 0x003FE650 File Offset: 0x003FC850
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

	// Token: 0x0600D77D RID: 55165 RVA: 0x003FE6B0 File Offset: 0x003FC8B0
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

	// Token: 0x0600D77E RID: 55166 RVA: 0x003FE730 File Offset: 0x003FC930
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

	// Token: 0x0600D77F RID: 55167 RVA: 0x003FE8CC File Offset: 0x003FCACC
	private void UpdatePitch()
	{
		float num = this.CacheRotator.Pitch;
		num %= 360f;
		num = ((num > 180f) ? (num - 360f) : num);
		num = MathUtils.Instance.Clamp(num, -this.MaxCardPitch, this.MaxCardPitch);
		this.CacheRotator.Pitch = num;
	}

	// Token: 0x0600D780 RID: 55168 RVA: 0x003FE928 File Offset: 0x003FCB28
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

	// Token: 0x0600D781 RID: 55169 RVA: 0x003FEBE8 File Offset: 0x003FCDE8
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

	// Token: 0x0600D782 RID: 55170 RVA: 0x003FEEA8 File Offset: 0x003FD0A8
	[NullableContext(1)]
	public void SetLeftAndRight(string leftText, string rightText)
	{
		string flowConfigLocalText = PublicUtil.Instance.GetFlowConfigLocalText(leftText);
		base.GetText(0).SetText(flowConfigLocalText ?? "", true);
		string flowConfigLocalText2 = PublicUtil.Instance.GetFlowConfigLocalText(rightText);
		base.GetText(1).SetText(flowConfigLocalText2 ?? "", true);
	}

	// Token: 0x0600D783 RID: 55171 RVA: 0x003FEEFC File Offset: 0x003FD0FC
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

	// Token: 0x0600D784 RID: 55172 RVA: 0x003FEF58 File Offset: 0x003FD158
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

	// Token: 0x04007891 RID: 30865
	private const float MATERIAL_LAYA = -0.001f;

	// Token: 0x04007892 RID: 30866
	private const float MATERIAL_LAYB = 0.0025f;

	// Token: 0x04007893 RID: 30867
	private const float MATERIAL_LAYC = 0.0075f;

	// Token: 0x04007894 RID: 30868
	private const float MATERIAL_LAYD = 0.01f;

	// Token: 0x04007895 RID: 30869
	private const float MATERIAL_LAYG = -0.01f;

	// Token: 0x04007896 RID: 30870
	[Nullable(1)]
	private const string CLICK_AUDIO_EVENT = "play_ui_com_slider_tick";

	// Token: 0x04007897 RID: 30871
	[Nullable(1)]
	private readonly Rotator CacheRotator = Rotator.Create();

	// Token: 0x04007898 RID: 30872
	[Nullable(1)]
	private readonly Rotator CacheContentRotator = Rotator.Create();

	// Token: 0x04007899 RID: 30873
	[Nullable(1)]
	private readonly global::Vector CacheCardVector = global::Vector.Create();

	// Token: 0x0400789A RID: 30874
	[Nullable(1)]
	private readonly global::Vector CacheBarVector = global::Vector.Create();

	// Token: 0x0400789B RID: 30875
	[Nullable(1)]
	private readonly global::Vector CacheBarRootVector = global::Vector.Create();

	// Token: 0x0400789C RID: 30876
	private float GamepadInputRate = 1f;

	// Token: 0x0400789D RID: 30877
	private float MobileRotateInputRate = 1f;

	// Token: 0x0400789E RID: 30878
	private float SensitivityPitch;

	// Token: 0x0400789F RID: 30879
	private float ViewPortPercentage;

	// Token: 0x040078A0 RID: 30880
	private float MaxCardPitch;

	// Token: 0x040078A1 RID: 30881
	private float LocationWhenPitch;

	// Token: 0x040078A2 RID: 30882
	private float KingShipCardContentTextRotateRate;

	// Token: 0x040078A3 RID: 30883
	private UUIItem RotationItem;

	// Token: 0x040078A4 RID: 30884
	private UUIItem LocationItem;

	// Token: 0x040078A5 RID: 30885
	private UUIItem RightItem;

	// Token: 0x040078A6 RID: 30886
	private UUIItem LeftItem;

	// Token: 0x040078A7 RID: 30887
	private UUITexture RightTexture;

	// Token: 0x040078A8 RID: 30888
	private UUITexture LeftTexture;

	// Token: 0x040078A9 RID: 30889
	private UCurveFloat ReignsCardMouseMoveCurve;

	// Token: 0x040078AA RID: 30890
	private UCurveVector ReignsCardRotatorCurve;

	// Token: 0x040078AB RID: 30891
	private UCurveFloat ReignsCardOffsetCurve;

	// Token: 0x040078AC RID: 30892
	private UCurveFloat ReignsBarRootOffsetCurve;

	// Token: 0x040078AD RID: 30893
	private UCurveFloat ReignsBarRootAlphaCurve;

	// Token: 0x040078AE RID: 30894
	private UCurveFloat ReignsBarOffsetCurve;

	// Token: 0x040078AF RID: 30895
	private UUITexture LayerTextureA;

	// Token: 0x040078B0 RID: 30896
	private UUITexture LayerTextureB;

	// Token: 0x040078B1 RID: 30897
	private UUITexture LayerTextureC;

	// Token: 0x040078B2 RID: 30898
	private UUITexture LayerTextureD;

	// Token: 0x040078B3 RID: 30899
	private UUITexture LayerTextureE;

	// Token: 0x040078B4 RID: 30900
	private UUITexture LayerTextureF;

	// Token: 0x040078B5 RID: 30901
	private UUITexture LayerTextureG;

	// Token: 0x040078B6 RID: 30902
	private float PitchInput;

	// Token: 0x040078B7 RID: 30903
	private float TargetPitch;

	// Token: 0x040078B8 RID: 30904
	public bool RightEnd;

	// Token: 0x040078B9 RID: 30905
	public bool LeftEnd;

	// Token: 0x040078BA RID: 30906
	public Action<bool> OnPostionMaxCallBack;

	// Token: 0x040078BB RID: 30907
	public Action OnClearPostionMax;

	// Token: 0x040078BC RID: 30908
	public UUIItem ContentItem;

	// Token: 0x040078BD RID: 30909
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x040078BE RID: 30910
	private int CardSequencePlayering;

	// Token: 0x040078BF RID: 30911
	private readonly FName CardMaterialParamOffsetX = new FName("OffsetX");

	// Token: 0x040078C0 RID: 30912
	private readonly FName CardMaterialParamOffsetY = new FName("OffsetY");

	// Token: 0x040078C1 RID: 30913
	public Action<bool> OnCallBackDropSequence;

	// Token: 0x040078C2 RID: 30914
	private bool IsShowBuffCard;

	// Token: 0x020077B8 RID: 30648
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x04026DBE RID: 159166
		public const int LeftText = 0;

		// Token: 0x04026DBF RID: 159167
		public const int RightText = 1;

		// Token: 0x04026DC0 RID: 159168
		public const int CardNameText = 2;

		// Token: 0x04026DC1 RID: 159169
		public const int CardDesText = 3;

		// Token: 0x04026DC2 RID: 159170
		public const int LeftBarTexture = 4;

		// Token: 0x04026DC3 RID: 159171
		public const int RightBarTexture = 5;

		// Token: 0x04026DC4 RID: 159172
		public const int OldItem = 6;

		// Token: 0x04026DC5 RID: 159173
		public const int LeftItem = 7;

		// Token: 0x04026DC6 RID: 159174
		public const int RightItem = 8;

		// Token: 0x04026DC7 RID: 159175
		public const int CallCardItem = 9;

		// Token: 0x04026DC8 RID: 159176
		public const int CallCardItemIconItem = 10;

		// Token: 0x04026DC9 RID: 159177
		public const int CallCardItemIconSprite = 11;

		// Token: 0x04026DCA RID: 159178
		public const int CallCardItemText = 12;

		// Token: 0x04026DCB RID: 159179
		public const int LayerDTexture = 13;

		// Token: 0x04026DCC RID: 159180
		public const int LayerCTexture = 14;

		// Token: 0x04026DCD RID: 159181
		public const int LayerBTexture = 15;

		// Token: 0x04026DCE RID: 159182
		public const int LayerATexture = 16;

		// Token: 0x04026DCF RID: 159183
		public const int LayerFTexture = 17;

		// Token: 0x04026DD0 RID: 159184
		public const int LocationItem = 18;

		// Token: 0x04026DD1 RID: 159185
		public const int RotatorItem = 19;

		// Token: 0x04026DD2 RID: 159186
		public const int LayerETexture = 20;

		// Token: 0x04026DD3 RID: 159187
		public const int LayerGTexture = 21;

		// Token: 0x04026DD4 RID: 159188
		public const int GreenItem = 22;
	}
}
