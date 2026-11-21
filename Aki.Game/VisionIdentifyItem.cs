using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020019B0 RID: 6576
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class VisionIdentifyItem : GridProxyAbstract<VisionSubPropViewData>
{
	// Token: 0x06010342 RID: 66370 RVA: 0x004BA7E6 File Offset: 0x004B89E6
	public override void Refresh(VisionSubPropViewData data, bool isSelected, int gridIndex)
	{
		if (data != null)
		{
			this.Update(data, data.SourceView);
		}
	}

	// Token: 0x06010343 RID: 66371 RVA: 0x004BA7F8 File Offset: 0x004B89F8
	public override object GetKey(VisionSubPropViewData data, int displayIndex)
	{
		return base.GridIndex;
	}

	// Token: 0x06010344 RID: 66372 RVA: 0x004BA808 File Offset: 0x004B8A08
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(5, new Action(this.OnClickButton))
		};
	}

	// Token: 0x06010345 RID: 66373 RVA: 0x004BA938 File Offset: 0x004B8B38
	private void OnClickButton()
	{
		if (UiManager.Instance.IsViewShow(EUiViewName.VisionIntensifyView))
		{
			EventSystem.Instance.Emit(EEventName.OnClickVisionIntensifyItemJump);
			return;
		}
		if (this.VisionData != null)
		{
			VisionIntensifyViewPassData visionIntensifyViewPassData = new VisionIntensifyViewPassData();
			visionIntensifyViewPassData.UniqueId = this.VisionData.GetIncrId();
			UiManager.Instance.OpenView(EUiViewName.VisionIntensifyView, visionIntensifyViewPassData, delegate(bool _1, int _2)
			{
				EventSystem.Instance.Emit(EEventName.OnClickVisionIntensifyItemJump);
			});
		}
	}

	// Token: 0x06010346 RID: 66374 RVA: 0x004BA9B5 File Offset: 0x004B8BB5
	protected override void OnStart()
	{
		this.LevelSequence = new LevelSequencePlayer(base.GetRootItem());
	}

	// Token: 0x06010347 RID: 66375 RVA: 0x004BA9C8 File Offset: 0x004B8BC8
	public UniTask PlaySequenceAndUpdate(float delayTime, float animateTime)
	{
		VisionIdentifyItem.<PlaySequenceAndUpdate>d__16 <PlaySequenceAndUpdate>d__;
		<PlaySequenceAndUpdate>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlaySequenceAndUpdate>d__.<>4__this = this;
		<PlaySequenceAndUpdate>d__.delayTime = delayTime;
		<PlaySequenceAndUpdate>d__.animateTime = animateTime;
		<PlaySequenceAndUpdate>d__.<>1__state = -1;
		<PlaySequenceAndUpdate>d__.<>t__builder.Start<VisionIdentifyItem.<PlaySequenceAndUpdate>d__16>(ref <PlaySequenceAndUpdate>d__);
		return <PlaySequenceAndUpdate>d__.<>t__builder.Task;
	}

	// Token: 0x06010348 RID: 66376 RVA: 0x004BAA1C File Offset: 0x004B8C1C
	public void Update(VisionSubPropViewData data, string sourceView)
	{
		this.ViewData = data;
		VisionSubPropData data2 = data.Data;
		this.SourceViewName = sourceView;
		this.VisionData = data.CurrentVisionData;
		this.CurrentData = data2;
		if (data.IfPreCache)
		{
			return;
		}
		this.RefreshAttributeName(data2);
		this.RefreshAttributeNum(data2);
		this.RefreshButtonJumpState(data2);
		this.RefreshSpriteBg(data2);
		this.RefreshTransitionColor(data2);
		this.RefreshHighLight(data);
		this.RefreshTextColor(data2);
	}

	// Token: 0x06010349 RID: 66377 RVA: 0x004BAA8C File Offset: 0x004B8C8C
	private void RefreshButtonJumpState(VisionSubPropData data)
	{
		bool flag = data.SlotState == EVisionSlotState.UnlockAndNoProp && this.CheckCanJump();
		base.GetButton(5).RootUIComp.Get().SetRaycastTarget(flag);
		base.GetItem(2).SetUIActive(flag);
	}

	// Token: 0x0601034A RID: 66378 RVA: 0x004BAAD4 File Offset: 0x004B8CD4
	private bool CheckCanJump()
	{
		bool flag = PhantomBattleModel.Instance.GetVisionLevelUpIdentify() == EVisionLevelUpIdentify.EnableIdentify;
		return (this.SourceViewName == "VisionLevelUpView" && !flag) || this.SourceViewName == "VisionEquipmentView";
	}

	// Token: 0x0601034B RID: 66379 RVA: 0x004BAB18 File Offset: 0x004B8D18
	private string GetColor(VisionSubPropData data)
	{
		string result = "";
		if (data.SlotState == EVisionSlotState.Lock)
		{
			result = "F9FFFF66";
		}
		else if (data.SlotState == EVisionSlotState.UnlockAndNoProp)
		{
			if (this.IfShowLikeLevelUpView())
			{
				result = "F7EBA6FF";
			}
			else
			{
				result = "F9FFFFCC";
			}
		}
		else if (data.SlotState == EVisionSlotState.UnlockAndHaveProp)
		{
			result = "F9FFFFCC";
		}
		else if (data.SlotState == EVisionSlotState.PreviewUnLock)
		{
			result = "F9FFFFCC";
		}
		else if (data.SlotState == EVisionSlotState.PrepareToIdentify)
		{
			result = "F7EBA6FF";
		}
		else if (data.SlotState == EVisionSlotState.PreviewCanIdentify)
		{
			result = "F7EBA6FF";
		}
		return result;
	}

	// Token: 0x0601034C RID: 66380 RVA: 0x004BABA0 File Offset: 0x004B8DA0
	private void RefreshTextColor(VisionSubPropData data)
	{
		FColor color = FColor.FromHex(this.GetColor(data));
		base.GetText(0).SetColor(color);
		base.GetText(1).SetColor(color);
		base.GetItem(2).SetColor(color);
	}

	// Token: 0x0601034D RID: 66381 RVA: 0x004BABE4 File Offset: 0x004B8DE4
	private void RefreshTransitionColor(VisionSubPropData data)
	{
		FColor fcolor = FColor.FromHex(this.GetColor(data));
		UUIItem item = base.GetItem(7);
		FSpriteTransitionInfo transitionInfo = (item.GetOwner().GetComponentByClass(UUISpriteTransition.StaticClass()) as UUISpriteTransition).TransitionInfo;
		transitionInfo.HighlightedTransition.Color = fcolor;
		transitionInfo.NormalTransition.Color = fcolor;
		transitionInfo.DisabledTransition.Color = fcolor;
		item.SetColor(fcolor);
		UUIItem item2 = base.GetItem(8);
		FTextTransitionInfo transitionInfo2 = (item2.GetOwner().GetComponentByClass(UUITextTransition.StaticClass()) as UUITextTransition).TransitionInfo;
		transitionInfo2.HighlightedTransition.FontColor = fcolor;
		transitionInfo2.DisabledTransition.FontColor = fcolor;
		transitionInfo2.NormalTransition.FontColor = fcolor;
		item2.SetColor(fcolor);
		UUIItem item3 = base.GetItem(10);
		FSpriteTransitionInfo transitionInfo3 = (item3.GetOwner().GetComponentByClass(UUISpriteTransition.StaticClass()) as UUISpriteTransition).TransitionInfo;
		transitionInfo3.HighlightedTransition.Color = fcolor;
		transitionInfo3.DisabledTransition.Color = fcolor;
		transitionInfo3.NormalTransition.Color = fcolor;
		item3.SetColor(fcolor);
	}

	// Token: 0x0601034E RID: 66382 RVA: 0x004BACEC File Offset: 0x004B8EEC
	private void RefreshAttributeName(VisionSubPropData data)
	{
		bool flag = PhantomBattleModel.Instance.GetVisionLevelUpIdentify() == EVisionLevelUpIdentify.EnableIdentify;
		bool flag2 = this.SourceViewName == "VisionLevelUpView" && flag;
		int? num = null;
		string textStringId;
		switch (data.SlotState)
		{
		case EVisionSlotState.Lock:
			textStringId = (flag2 ? "TuneEchoesProject_Warning01" : "LevelUpAndIdentify");
			num = new int?(data.GetUnlockLevel());
			break;
		case EVisionSlotState.UnlockAndNoProp:
			textStringId = (flag2 ? "TuneEchoesProject_Tips01" : "WaitForIdentify");
			break;
		case EVisionSlotState.PreviewUnLock:
			textStringId = (flag2 ? "TuneEchoesProject_Warning01" : "LevelUpAndIdentify");
			num = new int?(data.GetUnlockLevel());
			break;
		case EVisionSlotState.UnlockAndHaveProp:
			textStringId = data.GetSubPropName();
			break;
		case EVisionSlotState.PreviewCanIdentify:
			textStringId = "CurrentIdentifyUnlockText";
			break;
		case EVisionSlotState.PrepareToIdentify:
			textStringId = "CurrentIdentifyUnlockText";
			break;
		default:
			textStringId = "";
			break;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textStringId, new <>z__ReadOnlySingleElementList<object>(num));
	}

	// Token: 0x0601034F RID: 66383 RVA: 0x004BADDC File Offset: 0x004B8FDC
	private void RefreshAttributeNum(VisionSubPropData data)
	{
		bool flag = data.SlotState == EVisionSlotState.UnlockAndHaveProp;
		base.GetText(1).SetUIActive(flag);
		if (flag)
		{
			base.GetText(1).SetText(data.GetAttributeValueString(), true);
		}
	}

	// Token: 0x06010350 RID: 66384 RVA: 0x004BAE16 File Offset: 0x004B9016
	private void RefreshHighLight(VisionSubPropViewData data)
	{
		base.GetItem(9).SetUIActive(data.NeedHighLight);
	}

	// Token: 0x06010351 RID: 66385 RVA: 0x004BAE2B File Offset: 0x004B902B
	private bool IfShowLikeLevelUpView()
	{
		return this.SourceViewName == "VisionLevelUpView" || this.SourceViewName == "VisionEquipmentView";
	}

	// Token: 0x06010352 RID: 66386 RVA: 0x004BAE51 File Offset: 0x004B9051
	private void RefreshSpriteBg(VisionSubPropData data)
	{
		base.GetItem(3).SetUIActive(data.SlotState == EVisionSlotState.UnlockAndNoProp && this.IfShowLikeLevelUpView());
	}

	// Token: 0x04008FC9 RID: 36809
	private const string NORMALCOLOR = "F9FFFFCC";

	// Token: 0x04008FCA RID: 36810
	private const string GREENCOLOR = "F7EBA6FF";

	// Token: 0x04008FCB RID: 36811
	private const string WHITECOLOR = "F9FFFFCC";

	// Token: 0x04008FCC RID: 36812
	private const string GRAYCOLOR = "F9FFFF66";

	// Token: 0x04008FCD RID: 36813
	private string SourceViewName = "";

	// Token: 0x04008FCE RID: 36814
	[Nullable(2)]
	private VisionSubPropData CurrentData;

	// Token: 0x04008FCF RID: 36815
	[Nullable(2)]
	private LevelSequencePlayer LevelSequence;

	// Token: 0x04008FD0 RID: 36816
	[Nullable(2)]
	private CustomPromise AnimationCustomPromise;

	// Token: 0x04008FD1 RID: 36817
	[Nullable(2)]
	private PhantomDataBase VisionData;

	// Token: 0x04008FD2 RID: 36818
	[Nullable(2)]
	private VisionSubPropViewData ViewData;

	// Token: 0x02007BD6 RID: 31702
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04028199 RID: 164249
		AttributeText,
		// Token: 0x0402819A RID: 164250
		NumText,
		// Token: 0x0402819B RID: 164251
		ArrowItem,
		// Token: 0x0402819C RID: 164252
		BgSprite,
		// Token: 0x0402819D RID: 164253
		PointText,
		// Token: 0x0402819E RID: 164254
		Button,
		// Token: 0x0402819F RID: 164255
		PointTextTransition,
		// Token: 0x040281A0 RID: 164256
		ArrowSpriteTransition,
		// Token: 0x040281A1 RID: 164257
		AttributeTextTransition,
		// Token: 0x040281A2 RID: 164258
		HighLightItem,
		// Token: 0x040281A3 RID: 164259
		SprPointTransition
	}
}
