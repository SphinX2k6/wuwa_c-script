using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020011F9 RID: 4601
[NullableContext(1)]
[Nullable(0)]
public class ActivityCorniceMeetingSettleView : UiViewBase
{
	// Token: 0x06007B06 RID: 31494 RVA: 0x0019E9AC File Offset: 0x0019CBAC
	public ActivityCorniceMeetingSettleView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06007B07 RID: 31495 RVA: 0x0019E9B8 File Offset: 0x0019CBB8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06007B08 RID: 31496 RVA: 0x0019EA88 File Offset: 0x0019CC88
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityCorniceMeetingSettleView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityCorniceMeetingSettleView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007B09 RID: 31497 RVA: 0x0019EACB File Offset: 0x0019CCCB
	protected override void OnBeforeShow()
	{
		this.InitAutoLeaveTimer();
		this.RefreshTitle();
	}

	// Token: 0x06007B0A RID: 31498 RVA: 0x0019EAD9 File Offset: 0x0019CCD9
	protected override void OnBeforeDestroy()
	{
		this.ClearAutoLeaveTimer();
	}

	// Token: 0x06007B0B RID: 31499 RVA: 0x0019EAE4 File Offset: 0x0019CCE4
	protected void RefreshTitle()
	{
		if (this.Data == null)
		{
			return;
		}
		UUIText text = base.GetText(1);
		UUITexture texture = base.GetTexture(2);
		UUIEffectOutline uuieffectOutline = text.GetOwner().GetComponentByClass(UUIEffectOutline.StaticClass()) as UUIEffectOutline;
		base.SetTextureByPath("/Game/Aki/UI/UIResources/Common/Image/IconForceLogo/T_Logo_12_UI.T_Logo_12_UI", texture, null, null);
		if (this.Data.Score > 0)
		{
			LguiUtil.Instance.SetLocalTextNew(text, "CorniceMeetingSettleSuccess", Array.Empty<object>());
			text.outlineColor = FColor.FromHex("C48B29FF");
			texture.SetColor(FColor.FromHex("8C754D7F"));
			uuieffectOutline.SetOutlineColor(FColor.FromHex("C48B29FF"));
			text.SetColor(FColor.FromHex("f2efd5"));
			RewardExploreDescription rewardExploreDescription = this.RewardExploreDescription;
			if (rewardExploreDescription != null)
			{
				rewardExploreDescription.SetUiActive(false);
			}
			base.PlaySequence("Success", null, false);
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(text, "GenericPromptTypes_4_GeneralText", Array.Empty<object>());
		texture.SetColor(FColor.FromHex("6e363f"));
		text.SetColor(FColor.FromHex("F08086FF"));
		text.outlineColor = FColor.FromHex("B33100FF");
		uuieffectOutline.SetOutlineColor(FColor.FromHex("B33100FF"));
		RewardExploreDescription rewardExploreDescription2 = this.RewardExploreDescription;
		if (rewardExploreDescription2 != null)
		{
			rewardExploreDescription2.SetUiActive(true);
		}
		base.PlaySequence("Fail", null, false);
	}

	// Token: 0x06007B0C RID: 31500 RVA: 0x0019EC32 File Offset: 0x0019CE32
	private void ClearAutoLeaveTimer()
	{
		if (TimerSystem.GameplayTimeInstance.Has(this.AutoLeaveTimerId))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.AutoLeaveTimerId);
		}
		this.AutoLeaveTimerId = null;
	}

	// Token: 0x06007B0D RID: 31501 RVA: 0x0019EC5E File Offset: 0x0019CE5E
	private void OnClickContinueButton()
	{
		base.CloseMe(delegate(bool success)
		{
			if (success)
			{
				ActivityCorniceMeetingController.Instance.CorniceMeetingChallengeTransRequest(this.Data.LevelPlayId);
			}
		});
	}

	// Token: 0x06007B0E RID: 31502 RVA: 0x0019EC72 File Offset: 0x0019CE72
	private void OnClickBtnLeave()
	{
		base.CloseMe(null);
	}

	// Token: 0x06007B0F RID: 31503 RVA: 0x0019EC7C File Offset: 0x0019CE7C
	private void InitAutoLeaveTimer()
	{
		int leftSecondToAutoLeave = 31;
		this.AutoLeaveTimerId = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
		{
			int leftSecondToAutoLeave;
			if (leftSecondToAutoLeave <= 0)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.AutoLeaveTimerId);
				this.OnClickBtnLeave();
				return;
			}
			ActivityCorniceMeetingButton activityCorniceMeetingButton = this.ButtonMap[0];
			string textId = "InstanceDungeonLeftTimeToAutoLeave";
			string[] array = new string[1];
			int num = 0;
			leftSecondToAutoLeave = leftSecondToAutoLeave;
			leftSecondToAutoLeave--;
			array[num] = leftSecondToAutoLeave.ToString();
			activityCorniceMeetingButton.SetFloatText(textId, array);
		}, 1000f, 1f, null, null, true);
	}

	// Token: 0x06007B10 RID: 31504 RVA: 0x0019ECC8 File Offset: 0x0019CEC8
	private UniTask InitButtonAsync()
	{
		ActivityCorniceMeetingSettleView.<InitButtonAsync>d__23 <InitButtonAsync>d__;
		<InitButtonAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitButtonAsync>d__.<>4__this = this;
		<InitButtonAsync>d__.<>1__state = -1;
		<InitButtonAsync>d__.<>t__builder.Start<ActivityCorniceMeetingSettleView.<InitButtonAsync>d__23>(ref <InitButtonAsync>d__);
		return <InitButtonAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007B11 RID: 31505 RVA: 0x0019ED0C File Offset: 0x0019CF0C
	private UniTask CreateButton(UUIItem uiItem, int buttonIndex, Action clickFunction)
	{
		ActivityCorniceMeetingSettleView.<CreateButton>d__24 <CreateButton>d__;
		<CreateButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateButton>d__.<>4__this = this;
		<CreateButton>d__.buttonIndex = buttonIndex;
		<CreateButton>d__.clickFunction = clickFunction;
		<CreateButton>d__.<>1__state = -1;
		<CreateButton>d__.<>t__builder.Start<ActivityCorniceMeetingSettleView.<CreateButton>d__24>(ref <CreateButton>d__);
		return <CreateButton>d__.<>t__builder.Task;
	}

	// Token: 0x04003850 RID: 14416
	private const int LEAVETIME = 30;

	// Token: 0x04003851 RID: 14417
	private const string ICON_PATH = "/Game/Aki/UI/UIResources/Common/Image/IconForceLogo/T_Logo_12_UI.T_Logo_12_UI";

	// Token: 0x04003852 RID: 14418
	private const string SUCCESS_OUTLINE_COLOR = "C48B29FF";

	// Token: 0x04003853 RID: 14419
	private const string FAIL_OUTLINE_COLOR = "B33100FF";

	// Token: 0x04003854 RID: 14420
	private const string FAIL_TEXT_COLOR = "F08086FF";

	// Token: 0x04003855 RID: 14421
	private const string SUCCESS_TEXT_COLOR = "f2efd5";

	// Token: 0x04003856 RID: 14422
	protected Dictionary<int, ActivityCorniceMeetingButton> ButtonMap;

	// Token: 0x04003857 RID: 14423
	[Nullable(2)]
	private TimerHandle AutoLeaveTimerId;

	// Token: 0x04003858 RID: 14424
	protected CorniceChallengeEndNotify Data;

	// Token: 0x04003859 RID: 14425
	protected ActivityCorniceMeetingSettleDetailPanel DetailPanel;

	// Token: 0x0400385A RID: 14426
	protected RewardExploreDescription RewardExploreDescription;

	// Token: 0x020077DB RID: 30683
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04027832 RID: 161842
		public const int TxtTitle = 1;

		// Token: 0x04027833 RID: 161843
		public const int TextureIcon = 2;

		// Token: 0x04027834 RID: 161844
		public const int ButtonHorizontalItem = 4;

		// Token: 0x04027835 RID: 161845
		public const int ButtonItem = 5;

		// Token: 0x04027836 RID: 161846
		public const int Content = 20;
	}

	// Token: 0x020077DC RID: 30684
	[NullableContext(0)]
	private class EButtons
	{
		// Token: 0x04027837 RID: 161847
		public const int LeftButton = 0;

		// Token: 0x04027838 RID: 161848
		public const int RightButton = 1;
	}
}
