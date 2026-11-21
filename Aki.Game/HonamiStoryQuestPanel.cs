using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020013C0 RID: 5056
public class HonamiStoryQuestPanel : UiPanelBase
{
	// Token: 0x0600C872 RID: 51314 RVA: 0x003BA948 File Offset: 0x003B8B48
	protected unsafe override void OnRegisterComponent()
	{
		int num = 8;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnBtnQuestView));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600C873 RID: 51315 RVA: 0x003BAAB4 File Offset: 0x003B8CB4
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryQuestPanel.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryQuestPanel.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C874 RID: 51316 RVA: 0x003BAAF7 File Offset: 0x003B8CF7
	[NullableContext(1)]
	private HonamiStoryQuestPanelQuestItem CreateQuestItem()
	{
		return new HonamiStoryQuestPanelQuestItem();
	}

	// Token: 0x0600C875 RID: 51317 RVA: 0x003BAB00 File Offset: 0x003B8D00
	public void Refresh(bool showSubQuest = true)
	{
		bool flag = HonamiStoryUtil.CheckInActivityQuest();
		List<HonamiStoryQuestDataBase> questDataListByQuestType = HonamiStoryModel.Instance.GetQuestDataListByQuestType(EHonamiStoryQuestType.Main);
		if (flag && questDataListByQuestType.Count > 0)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), questDataListByQuestType[0].GetNameKey(), Array.Empty<object>());
			GenericScrollViewNew<HonamiStoryQuestPanelQuestItem, HonamiStoryQuestDataBase> mainQuestLayout = this.MainQuestLayout;
			if (mainQuestLayout != null)
			{
				mainQuestLayout.RefreshByData(questDataListByQuestType, null, false);
			}
		}
		base.GetItem(0).SetUIActive(flag && questDataListByQuestType.Count > 0);
		bool flag2 = FunctionModel.Instance != null && FunctionModel.Instance.IsOpen(10113);
		bool flag3 = showSubQuest && flag2;
		if (flag3)
		{
			List<HonamiStoryQuestDataBase> questDataListByQuestType2 = HonamiStoryModel.Instance.GetQuestDataListByQuestType(EHonamiStoryQuestType.Sub);
			if (questDataListByQuestType2.Count == 0)
			{
				flag3 = false;
			}
			else
			{
				GenericLayout<HonamiStoryQuestPanelQuestItem, HonamiStoryQuestDataBase> subQuestLayout = this.SubQuestLayout;
				if (subQuestLayout != null)
				{
					subQuestLayout.RefreshByData(questDataListByQuestType2, null, false);
				}
			}
		}
		base.GetItem(5).SetUIActive(flag3);
	}

	// Token: 0x0600C876 RID: 51318 RVA: 0x003BABD9 File Offset: 0x003B8DD9
	private void OnBtnQuestView()
	{
		UiManager.Instance.OpenView(EUiViewName.HonamiStoryQuestView, null, null);
	}

	// Token: 0x040071F6 RID: 29174
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<HonamiStoryQuestPanelQuestItem, HonamiStoryQuestDataBase> MainQuestLayout;

	// Token: 0x040071F7 RID: 29175
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<HonamiStoryQuestPanelQuestItem, HonamiStoryQuestDataBase> SubQuestLayout;

	// Token: 0x02007683 RID: 30339
	private enum EHonamiStoryQuestPanelComponent
	{
		// Token: 0x040267A0 RID: 157600
		MainContent,
		// Token: 0x040267A1 RID: 157601
		QuestViewButton,
		// Token: 0x040267A2 RID: 157602
		MainQuestTitleText,
		// Token: 0x040267A3 RID: 157603
		MainQuestVerticalLayout,
		// Token: 0x040267A4 RID: 157604
		MainQuestItem,
		// Token: 0x040267A5 RID: 157605
		SubContent,
		// Token: 0x040267A6 RID: 157606
		SubQuestVerticalLayout,
		// Token: 0x040267A7 RID: 157607
		SubQuestItem
	}
}
