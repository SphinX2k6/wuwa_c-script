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

// Token: 0x02001EFE RID: 7934
public class HonamiStoryQuestPanel : UiPanelBase
{
	// Token: 0x0600F453 RID: 62547 RVA: 0x003AEE54 File Offset: 0x003AD054
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

	// Token: 0x0600F454 RID: 62548 RVA: 0x003AEFC0 File Offset: 0x003AD1C0
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryQuestPanel.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryQuestPanel.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F455 RID: 62549 RVA: 0x003AF003 File Offset: 0x003AD203
	[NullableContext(1)]
	private HonamiStoryQuestPanelQuestItem CreateQuestItem()
	{
		return new HonamiStoryQuestPanelQuestItem();
	}

	// Token: 0x0600F456 RID: 62550 RVA: 0x003AF00C File Offset: 0x003AD20C
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

	// Token: 0x0600F457 RID: 62551 RVA: 0x003AF0E5 File Offset: 0x003AD2E5
	private void OnBtnQuestView()
	{
		UiManager.Instance.OpenView(EUiViewName.HonamiStoryQuestView, null, null);
	}

	// Token: 0x04007115 RID: 28949
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<HonamiStoryQuestPanelQuestItem, HonamiStoryQuestDataBase> MainQuestLayout;

	// Token: 0x04007116 RID: 28950
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<HonamiStoryQuestPanelQuestItem, HonamiStoryQuestDataBase> SubQuestLayout;

	// Token: 0x020084FE RID: 34046
	private enum EHonamiStoryQuestPanelComponent
	{
		// Token: 0x0402B47C RID: 177276
		MainContent,
		// Token: 0x0402B47D RID: 177277
		QuestViewButton,
		// Token: 0x0402B47E RID: 177278
		MainQuestTitleText,
		// Token: 0x0402B47F RID: 177279
		MainQuestVerticalLayout,
		// Token: 0x0402B480 RID: 177280
		MainQuestItem,
		// Token: 0x0402B481 RID: 177281
		SubContent,
		// Token: 0x0402B482 RID: 177282
		SubQuestVerticalLayout,
		// Token: 0x0402B483 RID: 177283
		SubQuestItem
	}
}
