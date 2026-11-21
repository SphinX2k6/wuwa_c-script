using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.View.InstanceEntrance
{
	// Token: 0x02004EF7 RID: 20215
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityInstanceEntranceDropDownItem : UiPanelBase
	{
		// Token: 0x06032CF0 RID: 208112 RVA: 0x00E43A44 File Offset: 0x00E41C44
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06032CF1 RID: 208113 RVA: 0x00E43A8C File Offset: 0x00E41C8C
		protected override UniTask OnBeforeStartAsync()
		{
			ActivityInstanceEntranceDropDownItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityInstanceEntranceDropDownItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032CF2 RID: 208114 RVA: 0x00E43AD0 File Offset: 0x00E41CD0
		private UniTask CreateDropDownCom()
		{
			ActivityInstanceEntranceDropDownItem.<CreateDropDownCom>d__5 <CreateDropDownCom>d__;
			<CreateDropDownCom>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateDropDownCom>d__.<>4__this = this;
			<CreateDropDownCom>d__.<>1__state = -1;
			<CreateDropDownCom>d__.<>t__builder.Start<ActivityInstanceEntranceDropDownItem.<CreateDropDownCom>d__5>(ref <CreateDropDownCom>d__);
			return <CreateDropDownCom>d__.<>t__builder.Task;
		}

		// Token: 0x06032CF3 RID: 208115 RVA: 0x00E43B13 File Offset: 0x00E41D13
		protected override void OnStart()
		{
		}

		// Token: 0x06032CF4 RID: 208116 RVA: 0x00E43B15 File Offset: 0x00E41D15
		private ActivityEntranceDropDownContentData GetDropDownItemData(object data)
		{
			return data as ActivityEntranceDropDownContentData;
		}

		// Token: 0x06032CF5 RID: 208117 RVA: 0x00E43B20 File Offset: 0x00E41D20
		public void RefreshView(ActivityInstanceEntranceData entranceData, ActivityEntranceDropDownData data)
		{
			this.EntranceData = entranceData;
			ActivityEntranceDropDownContentData[] dropDownContentDataList = data.GetDropDownContentDataList();
			int defaultDifficultIndex = this.EntranceData.GetActivityEntranceSelectItemData().GetCurrentSelectData().GetDefaultDifficultIndex();
			CommonDropDown<ActivityEntranceDropDownContentData, ActivityEntranceDropDownContentData> difficultyDropDown = this.DifficultyDropDown;
			if (difficultyDropDown == null)
			{
				return;
			}
			difficultyDropDown.InitScroll(dropDownContentDataList, new Func<ActivityEntranceDropDownContentData, ActivityEntranceDropDownContentData>(this.GetDropDownItemData), defaultDifficultIndex, true);
		}

		// Token: 0x06032CF6 RID: 208118 RVA: 0x00E43B70 File Offset: 0x00E41D70
		private DropDownItemBase<ActivityEntranceDropDownContentData> OnCreateDropDownItem(UUIItem item, ActivityEntranceDropDownContentData data)
		{
			return new DropDownItem(item);
		}

		// Token: 0x06032CF7 RID: 208119 RVA: 0x00E43B78 File Offset: 0x00E41D78
		private TitleItemBase<ActivityEntranceDropDownContentData> OnCreateDropDownTitle(UUIItem item)
		{
			return new DropDownTitle(item);
		}

		// Token: 0x06032CF8 RID: 208120 RVA: 0x00E43B80 File Offset: 0x00E41D80
		private void OnSelectDifficulty(int index, object data)
		{
			ActivityEntranceDropDownContentData activityEntranceDropDownContentData = data as ActivityEntranceDropDownContentData;
			ActivityEntranceDropDownData activityEntranceDropDownData = this.EntranceData.GetActivityEntranceDropDownData();
			if (activityEntranceDropDownData != null)
			{
				activityEntranceDropDownData.SetDefaultIndex(activityEntranceDropDownContentData.GetDataIndex());
			}
			Action<ActivityInstanceEntranceData, int> onSelectCallBack = activityEntranceDropDownContentData.GetOnSelectCallBack();
			if (onSelectCallBack == null)
			{
				return;
			}
			onSelectCallBack(this.EntranceData, activityEntranceDropDownContentData.GetDataIndex());
		}

		// Token: 0x0401AF98 RID: 110488
		private CommonDropDown<ActivityEntranceDropDownContentData, ActivityEntranceDropDownContentData> DifficultyDropDown;

		// Token: 0x0401AF99 RID: 110489
		protected ActivityInstanceEntranceData EntranceData;

		// Token: 0x0200AC4A RID: 44106
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x040354E1 RID: 218337
			public const int DropdownItem = 0;
		}
	}
}
