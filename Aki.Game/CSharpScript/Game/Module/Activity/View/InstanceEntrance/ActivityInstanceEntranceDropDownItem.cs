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
	// Token: 0x02005F10 RID: 24336
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityInstanceEntranceDropDownItem : UiPanelBase
	{
		// Token: 0x0603DD55 RID: 253269 RVA: 0x00EF1D3C File Offset: 0x00EEFF3C
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

		// Token: 0x0603DD56 RID: 253270 RVA: 0x00EF1D84 File Offset: 0x00EEFF84
		protected override UniTask OnBeforeStartAsync()
		{
			ActivityInstanceEntranceDropDownItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityInstanceEntranceDropDownItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603DD57 RID: 253271 RVA: 0x00EF1DC8 File Offset: 0x00EEFFC8
		private UniTask CreateDropDownCom()
		{
			ActivityInstanceEntranceDropDownItem.<CreateDropDownCom>d__5 <CreateDropDownCom>d__;
			<CreateDropDownCom>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateDropDownCom>d__.<>4__this = this;
			<CreateDropDownCom>d__.<>1__state = -1;
			<CreateDropDownCom>d__.<>t__builder.Start<ActivityInstanceEntranceDropDownItem.<CreateDropDownCom>d__5>(ref <CreateDropDownCom>d__);
			return <CreateDropDownCom>d__.<>t__builder.Task;
		}

		// Token: 0x0603DD58 RID: 253272 RVA: 0x00EF1E0B File Offset: 0x00EF000B
		protected override void OnStart()
		{
		}

		// Token: 0x0603DD59 RID: 253273 RVA: 0x00EF1E0D File Offset: 0x00EF000D
		private ActivityEntranceDropDownContentData GetDropDownItemData(object data)
		{
			return data as ActivityEntranceDropDownContentData;
		}

		// Token: 0x0603DD5A RID: 253274 RVA: 0x00EF1E18 File Offset: 0x00EF0018
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

		// Token: 0x0603DD5B RID: 253275 RVA: 0x00EF1E68 File Offset: 0x00EF0068
		private DropDownItemBase<ActivityEntranceDropDownContentData> OnCreateDropDownItem(UUIItem item, ActivityEntranceDropDownContentData data)
		{
			return new DropDownItem(item);
		}

		// Token: 0x0603DD5C RID: 253276 RVA: 0x00EF1E70 File Offset: 0x00EF0070
		private TitleItemBase<ActivityEntranceDropDownContentData> OnCreateDropDownTitle(UUIItem item)
		{
			return new DropDownTitle(item);
		}

		// Token: 0x0603DD5D RID: 253277 RVA: 0x00EF1E78 File Offset: 0x00EF0078
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

		// Token: 0x040204C6 RID: 132294
		private CommonDropDown<ActivityEntranceDropDownContentData, ActivityEntranceDropDownContentData> DifficultyDropDown;

		// Token: 0x040204C7 RID: 132295
		protected ActivityInstanceEntranceData EntranceData;

		// Token: 0x0200C23D RID: 49725
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403AAEF RID: 240367
			public const int DropdownItem = 0;
		}
	}
}
