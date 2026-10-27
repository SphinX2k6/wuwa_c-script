using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020024C9 RID: 9417
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class VisionIdentifyItem : GridProxyAbstract<VisionSubPropViewData>
{
	// Token: 0x06012E83 RID: 77443 RVA: 0x004ACBE6 File Offset: 0x004AADE6
	public override void Refresh(VisionSubPropViewData data, bool isSelected, int gridIndex)
	{
		if (data != null)
		{
			this.Update(data, data.SourceView);
		}
	}

	// Token: 0x06012E84 RID: 77444 RVA: 0x004ACBF8 File Offset: 0x004AADF8
	public override object GetKey(VisionSubPropViewData data, int displayIndex)
	{
		return base.GridIndex;
	}

	// Token: 0x06012E85 RID: 77445 RVA: 0x004ACC08 File Offset: 0x004AAE08
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

	// Token: 0x06012E86 RID: 77446 RVA: 0x004ACD38 File Offset: 0x004AAF38
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

	// Token: 0x06012E87 RID: 77447 RVA: 0x004ACDB5 File Offset: 0x004AAFB5
	protected override void OnStart()
	{
		this.LevelSequence = new LevelSequencePlayer(base.GetRootItem());
	}

	// Token: 0x06012E88 RID: 77448 RVA: 0x004ACDC8 File Offset: 0x004AAFC8
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

	// Token: 0x06012E89 RID: 77449 RVA: 0x004ACE1C File Offset: 0x004AB01C
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

	// Token: 0x06012E8A RID: 77450 RVA: 0x004ACE8C File Offset: 0x004AB08C
	private void RefreshButtonJumpState(VisionSubPropData data)
	{
		bool flag = data.SlotState == EVisionSlotState.UnlockAndNoProp && this.CheckCanJump();
		base.GetButton(5).RootUIComp.Get().SetRaycastTarget(flag);
		base.GetItem(2).SetUIActive(flag);
	}

	// Token: 0x06012E8B RID: 77451 RVA: 0x004ACED4 File Offset: 0x004AB0D4
	private bool CheckCanJump()
	{
		bool flag = PhantomBattleModel.Instance.GetVisionLevelUpIdentify() == EVisionLevelUpIdentify.EnableIdentify;
		return (this.SourceViewName == "VisionLevelUpView" && !flag) || this.SourceViewName == "VisionEquipmentView";
	}

	// Token: 0x06012E8C RID: 77452 RVA: 0x004ACF18 File Offset: 0x004AB118
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

	// Token: 0x06012E8D RID: 77453 RVA: 0x004ACFA0 File Offset: 0x004AB1A0
	private void RefreshTextColor(VisionSubPropData data)
	{
		FColor color = FColor.FromHex(this.GetColor(data));
		base.GetText(0).SetColor(color);
		base.GetText(1).SetColor(color);
		base.GetItem(2).SetColor(color);
	}

	// Token: 0x06012E8E RID: 77454 RVA: 0x004ACFE4 File Offset: 0x004AB1E4
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

	// Token: 0x06012E8F RID: 77455 RVA: 0x004AD0EC File Offset: 0x004AB2EC
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

	// Token: 0x06012E90 RID: 77456 RVA: 0x004AD1DC File Offset: 0x004AB3DC
	private void RefreshAttributeNum(VisionSubPropData data)
	{
		bool flag = data.SlotState == EVisionSlotState.UnlockAndHaveProp;
		base.GetText(1).SetUIActive(flag);
		if (flag)
		{
			base.GetText(1).SetText(data.GetAttributeValueString(), true);
		}
	}

	// Token: 0x06012E91 RID: 77457 RVA: 0x004AD216 File Offset: 0x004AB416
	private void RefreshHighLight(VisionSubPropViewData data)
	{
		base.GetItem(9).SetUIActive(data.NeedHighLight);
	}

	// Token: 0x06012E92 RID: 77458 RVA: 0x004AD22B File Offset: 0x004AB42B
	private bool IfShowLikeLevelUpView()
	{
		return this.SourceViewName == "VisionLevelUpView" || this.SourceViewName == "VisionEquipmentView";
	}

	// Token: 0x06012E93 RID: 77459 RVA: 0x004AD251 File Offset: 0x004AB451
	private void RefreshSpriteBg(VisionSubPropData data)
	{
		base.GetItem(3).SetUIActive(data.SlotState == EVisionSlotState.UnlockAndNoProp && this.IfShowLikeLevelUpView());
	}

	// Token: 0x04008E7F RID: 36479
	private const string NORMALCOLOR = "F9FFFFCC";

	// Token: 0x04008E80 RID: 36480
	private const string GREENCOLOR = "F7EBA6FF";

	// Token: 0x04008E81 RID: 36481
	private const string WHITECOLOR = "F9FFFFCC";

	// Token: 0x04008E82 RID: 36482
	private const string GRAYCOLOR = "F9FFFF66";

	// Token: 0x04008E83 RID: 36483
	private string SourceViewName = "";

	// Token: 0x04008E84 RID: 36484
	[Nullable(2)]
	private VisionSubPropData CurrentData;

	// Token: 0x04008E85 RID: 36485
	[Nullable(2)]
	private LevelSequencePlayer LevelSequence;

	// Token: 0x04008E86 RID: 36486
	[Nullable(2)]
	private CustomPromise AnimationCustomPromise;

	// Token: 0x04008E87 RID: 36487
	[Nullable(2)]
	private PhantomDataBase VisionData;

	// Token: 0x04008E88 RID: 36488
	[Nullable(2)]
	private VisionSubPropViewData ViewData;

	// Token: 0x02008A4D RID: 35405
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402CE7B RID: 183931
		AttributeText,
		// Token: 0x0402CE7C RID: 183932
		NumText,
		// Token: 0x0402CE7D RID: 183933
		ArrowItem,
		// Token: 0x0402CE7E RID: 183934
		BgSprite,
		// Token: 0x0402CE7F RID: 183935
		PointText,
		// Token: 0x0402CE80 RID: 183936
		Button,
		// Token: 0x0402CE81 RID: 183937
		PointTextTransition,
		// Token: 0x0402CE82 RID: 183938
		ArrowSpriteTransition,
		// Token: 0x0402CE83 RID: 183939
		AttributeTextTransition,
		// Token: 0x0402CE84 RID: 183940
		HighLightItem,
		// Token: 0x0402CE85 RID: 183941
		SprPointTransition
	}
}
