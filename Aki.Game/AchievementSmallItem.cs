using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020003E9 RID: 1001
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class AchievementSmallItem : GridProxyAbstract<AchievementData>
{
	// Token: 0x0600365F RID: 13919 RVA: 0x0013DF40 File Offset: 0x0013C140
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

	// Token: 0x06003660 RID: 13920 RVA: 0x0013E0AC File Offset: 0x0013C2AC
	protected override void OnStart()
	{
		this.AddEventListener();
	}

	// Token: 0x06003661 RID: 13921 RVA: 0x0013E0B4 File Offset: 0x0013C2B4
	protected void AddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.OnAchievementDataWithIdNotify, new Action<int>(this.OnAchievementDataWithIdNotify));
	}

	// Token: 0x06003662 RID: 13922 RVA: 0x0013E0D2 File Offset: 0x0013C2D2
	protected void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnAchievementDataWithIdNotify, new Action<int>(this.OnAchievementDataWithIdNotify));
	}

	// Token: 0x06003663 RID: 13923 RVA: 0x0013E0F0 File Offset: 0x0013C2F0
	public override void Refresh(AchievementData data, bool isSelected, int gridIndex)
	{
		this.AchievementData = data;
		base.GridIndex = gridIndex;
		this.RefreshUi(data);
	}

	// Token: 0x06003664 RID: 13924 RVA: 0x0013E108 File Offset: 0x0013C308
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

	// Token: 0x06003665 RID: 13925 RVA: 0x0013E1C4 File Offset: 0x0013C3C4
	private void OnAchievementDataWithIdNotify(int id)
	{
		AchievementData achievementData = this.AchievementData;
		int? num = (achievementData != null) ? new int?(achievementData.GetId()) : null;
		if (id == num.GetValueOrDefault() & num != null)
		{
			this.RefreshUi(this.AchievementData);
		}
	}

	// Token: 0x06003666 RID: 13926 RVA: 0x0013E214 File Offset: 0x0013C414
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

	// Token: 0x06003667 RID: 13927 RVA: 0x0013E297 File Offset: 0x0013C497
	protected override void OnBeforeDestroy()
	{
		this.RemoveEventListener();
	}

	// Token: 0x04002D64 RID: 11620
	[Nullable(2)]
	private AchievementData AchievementData;

	// Token: 0x04002D65 RID: 11621
	[Nullable(2)]
	public Action<int> OnClickButtonCallback;

	// Token: 0x02006715 RID: 26389
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x040220D3 RID: 139475
		Desc,
		// Token: 0x040220D4 RID: 139476
		Icon,
		// Token: 0x040220D5 RID: 139477
		ReceiveFrameObj,
		// Token: 0x040220D6 RID: 139478
		RedPoint,
		// Token: 0x040220D7 RID: 139479
		ArrowObj,
		// Token: 0x040220D8 RID: 139480
		ReceivedObj,
		// Token: 0x040220D9 RID: 139481
		ConfirmButton,
		// Token: 0x040220DA RID: 139482
		IconTransition
	}
}
