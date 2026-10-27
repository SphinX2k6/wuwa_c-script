using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000F34 RID: 3892
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class AchievementSmallItem : GridProxyAbstract<AchievementData>
{
	// Token: 0x060062C7 RID: 25287 RVA: 0x00135618 File Offset: 0x00133818
	protected unsafe override void OnRegisterComponent()
	{
		int num = 8;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUITextureTransitionComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060062C8 RID: 25288 RVA: 0x00135784 File Offset: 0x00133984
	protected override void OnStart()
	{
		this.AddEventListener();
	}

	// Token: 0x060062C9 RID: 25289 RVA: 0x0013578C File Offset: 0x0013398C
	protected void AddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.OnAchievementDataWithIdNotify, new Action<int>(this.OnAchievementDataWithIdNotify));
	}

	// Token: 0x060062CA RID: 25290 RVA: 0x001357AA File Offset: 0x001339AA
	protected void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnAchievementDataWithIdNotify, new Action<int>(this.OnAchievementDataWithIdNotify));
	}

	// Token: 0x060062CB RID: 25291 RVA: 0x001357C8 File Offset: 0x001339C8
	public override void Refresh(AchievementData data, bool isSelected, int gridIndex)
	{
		this.AchievementData = data;
		base.GridIndex = gridIndex;
		this.RefreshUi(data);
	}

	// Token: 0x060062CC RID: 25292 RVA: 0x001357E0 File Offset: 0x001339E0
	private void RefreshUi(AchievementData data)
	{
		EAchievementStateEnum finishState = data.GetFinishState();
		base.GetText(0).SetText(data.GetTitle(), true);
		base.GetItem(3).SetUIActive(data.RedPoint());
		base.GetItem(2).SetUIActive(finishState == EAchievementStateEnum.CanGetReward);
		base.GetItem(4).SetUIActive(finishState == EAchievementStateEnum.CanGetReward);
		base.GetItem(5).SetUIActive(finishState == EAchievementStateEnum.HaveGetReward);
		AchievementGroupData achievementGroupData = AchievementModel.Instance.GetAchievementGroupData(new int?(this.AchievementData.GetGroupId()));
		if (!StringUtils.IsEmpty(achievementGroupData.GetSmallIcon()))
		{
			base.SetTextureByPath(achievementGroupData.GetSmallIcon(), base.GetTexture(1), null, delegate(bool _)
			{
				base.GetUiTextureTransitionComponent(7).SetAllStateTexture(base.GetTexture(1).GetTexture());
			});
		}
	}

	// Token: 0x060062CD RID: 25293 RVA: 0x0013589C File Offset: 0x00133A9C
	private void OnAchievementDataWithIdNotify(int id)
	{
		AchievementData achievementData = this.AchievementData;
		int? num = (achievementData != null) ? new int?(achievementData.GetId()) : null;
		if (id == num.GetValueOrDefault() & num != null)
		{
			this.RefreshUi(this.AchievementData);
		}
	}

	// Token: 0x060062CE RID: 25294 RVA: 0x001358EC File Offset: 0x00133AEC
	private void OnClickButton()
	{
		Action<int> onClickButtonCallback = this.OnClickButtonCallback;
		if (onClickButtonCallback != null)
		{
			onClickButtonCallback(base.GridIndex);
		}
		if (this.AchievementData != null)
		{
			AchievementGroupData achievementGroupData = AchievementModel.Instance.GetAchievementGroupData(new int?(this.AchievementData.GetGroupId()));
			AchievementCategoryData category = AchievementModel.Instance.GetCategory(achievementGroupData.GetCategory());
			AchievementController.Instance.OpenAchievementDetailView(category.GetId(), new int?(this.AchievementData.GetGroupId()), this.AchievementData.GetId());
		}
	}

	// Token: 0x060062CF RID: 25295 RVA: 0x0013596F File Offset: 0x00133B6F
	protected override void OnBeforeDestroy()
	{
		this.RemoveEventListener();
	}

	// Token: 0x04002CCB RID: 11467
	[Nullable(2)]
	private AchievementData AchievementData;

	// Token: 0x04002CCC RID: 11468
	[Nullable(2)]
	public Action<int> OnClickButtonCallback;

	// Token: 0x02007581 RID: 30081
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04026D88 RID: 159112
		Desc,
		// Token: 0x04026D89 RID: 159113
		Icon,
		// Token: 0x04026D8A RID: 159114
		ReceiveFrameObj,
		// Token: 0x04026D8B RID: 159115
		RedPoint,
		// Token: 0x04026D8C RID: 159116
		ArrowObj,
		// Token: 0x04026D8D RID: 159117
		ReceivedObj,
		// Token: 0x04026D8E RID: 159118
		ConfirmButton,
		// Token: 0x04026D8F RID: 159119
		IconTransition
	}
}
