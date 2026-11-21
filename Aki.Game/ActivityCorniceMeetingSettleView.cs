using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020006AD RID: 1709
[NullableContext(1)]
[Nullable(0)]
public class ActivityCorniceMeetingSettleView : UiViewBase
{
	// Token: 0x06004E9C RID: 20124 RVA: 0x001A7664 File Offset: 0x001A5864
	public ActivityCorniceMeetingSettleView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06004E9D RID: 20125 RVA: 0x001A7670 File Offset: 0x001A5870
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

	// Token: 0x06004E9E RID: 20126 RVA: 0x001A7740 File Offset: 0x001A5940
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityCorniceMeetingSettleView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityCorniceMeetingSettleView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06004E9F RID: 20127 RVA: 0x001A7783 File Offset: 0x001A5983
	protected override void OnBeforeShow()
	{
		this.InitAutoLeaveTimer();
		this.RefreshTitle();
	}

	// Token: 0x06004EA0 RID: 20128 RVA: 0x001A7791 File Offset: 0x001A5991
	protected override void OnBeforeDestroy()
	{
		this.ClearAutoLeaveTimer();
	}

	// Token: 0x06004EA1 RID: 20129 RVA: 0x001A779C File Offset: 0x001A599C
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

	// Token: 0x06004EA2 RID: 20130 RVA: 0x001A78EA File Offset: 0x001A5AEA
	private void ClearAutoLeaveTimer()
	{
		if (TimerSystem.GameplayTimeInstance.Has(this.AutoLeaveTimerId))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.AutoLeaveTimerId);
		}
		this.AutoLeaveTimerId = null;
	}

	// Token: 0x06004EA3 RID: 20131 RVA: 0x001A7916 File Offset: 0x001A5B16
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

	// Token: 0x06004EA4 RID: 20132 RVA: 0x001A792A File Offset: 0x001A5B2A
	private void OnClickBtnLeave()
	{
		base.CloseMe(null);
	}

	// Token: 0x06004EA5 RID: 20133 RVA: 0x001A7934 File Offset: 0x001A5B34
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

	// Token: 0x06004EA6 RID: 20134 RVA: 0x001A7980 File Offset: 0x001A5B80
	private UniTask InitButtonAsync()
	{
		ActivityCorniceMeetingSettleView.<InitButtonAsync>d__23 <InitButtonAsync>d__;
		<InitButtonAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitButtonAsync>d__.<>4__this = this;
		<InitButtonAsync>d__.<>1__state = -1;
		<InitButtonAsync>d__.<>t__builder.Start<ActivityCorniceMeetingSettleView.<InitButtonAsync>d__23>(ref <InitButtonAsync>d__);
		return <InitButtonAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06004EA7 RID: 20135 RVA: 0x001A79C4 File Offset: 0x001A5BC4
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

	// Token: 0x040038E9 RID: 14569
	private const int LEAVETIME = 30;

	// Token: 0x040038EA RID: 14570
	private const string ICON_PATH = "/Game/Aki/UI/UIResources/Common/Image/IconForceLogo/T_Logo_12_UI.T_Logo_12_UI";

	// Token: 0x040038EB RID: 14571
	private const string SUCCESS_OUTLINE_COLOR = "C48B29FF";

	// Token: 0x040038EC RID: 14572
	private const string FAIL_OUTLINE_COLOR = "B33100FF";

	// Token: 0x040038ED RID: 14573
	private const string FAIL_TEXT_COLOR = "F08086FF";

	// Token: 0x040038EE RID: 14574
	private const string SUCCESS_TEXT_COLOR = "f2efd5";

	// Token: 0x040038EF RID: 14575
	protected Dictionary<int, ActivityCorniceMeetingButton> ButtonMap;

	// Token: 0x040038F0 RID: 14576
	[Nullable(2)]
	private TimerHandle AutoLeaveTimerId;

	// Token: 0x040038F1 RID: 14577
	protected CorniceChallengeEndNotify Data;

	// Token: 0x040038F2 RID: 14578
	protected ActivityCorniceMeetingSettleDetailPanel DetailPanel;

	// Token: 0x040038F3 RID: 14579
	protected RewardExploreDescription RewardExploreDescription;

	// Token: 0x02006966 RID: 26982
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04022B64 RID: 142180
		public const int TxtTitle = 1;

		// Token: 0x04022B65 RID: 142181
		public const int TextureIcon = 2;

		// Token: 0x04022B66 RID: 142182
		public const int ButtonHorizontalItem = 4;

		// Token: 0x04022B67 RID: 142183
		public const int ButtonItem = 5;

		// Token: 0x04022B68 RID: 142184
		public const int Content = 20;
	}

	// Token: 0x02006967 RID: 26983
	[NullableContext(0)]
	private class EButtons
	{
		// Token: 0x04022B69 RID: 142185
		public const int LeftButton = 0;

		// Token: 0x04022B6A RID: 142186
		public const int RightButton = 1;
	}
}
