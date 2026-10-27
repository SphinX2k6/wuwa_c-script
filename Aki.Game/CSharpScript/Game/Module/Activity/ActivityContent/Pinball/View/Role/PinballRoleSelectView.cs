using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Role
{
	// Token: 0x02006316 RID: 25366
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballRoleSelectView : UiViewBase
	{
		// Token: 0x0603FD0D RID: 261389 RVA: 0x00F701AC File Offset: 0x00F6E3AC
		public PinballRoleSelectView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603FD0E RID: 261390 RVA: 0x00F701CC File Offset: 0x00F6E3CC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.OnBackButtonClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603FD0F RID: 261391 RVA: 0x00F7037C File Offset: 0x00F6E57C
		protected override UniTask OnBeforeStartAsync()
		{
			PinballRoleSelectView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballRoleSelectView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FD10 RID: 261392 RVA: 0x00F703BF File Offset: 0x00F6E5BF
		protected override void OnBeforeShow()
		{
			this.RoleScrollView.ResetGridController();
		}

		// Token: 0x0603FD11 RID: 261393 RVA: 0x00F703CC File Offset: 0x00F6E5CC
		protected void BuildAllRoleDataList()
		{
			if (this.OpenData == null)
			{
				return;
			}
			this.AllGridDataList.Clear();
			PinballModel instance = PinballModel.Instance;
			foreach (PinballRoleDataBase pinballRoleDataBase in this.OpenData.RoleDataList)
			{
				PinballRoleConfig config = pinballRoleDataBase.GetConfig();
				TableTextArgNew bottomText = pinballRoleDataBase.IsLocked() ? new TableTextArgNew(instance.GetRoleNameByPinballRoleConfig(config), Array.Empty<object>()) : new TableTextArgNew("Pinball_Character_List_01", new object[]
				{
					pinballRoleDataBase.GetLevel()
				});
				PinballItemDataRole itemData = new PinballItemDataRole
				{
					Type = EPinballItemType.Role,
					Id = pinballRoleDataBase.GetId(),
					BdId = new int?(config.Bd),
					IsLocked = new bool?(pinballRoleDataBase.IsLocked()),
					IsUnavailable = new bool?(pinballRoleDataBase.IsLocked()),
					BottomText = bottomText
				};
				List<int> list = new List<int>();
				int pinballClassLength = config.PinballClassLength;
				for (int i = 0; i < pinballClassLength; i++)
				{
					list.Add(config.PinballClass(i));
				}
				int[] formationRoleIds = this.OpenData.FormationRoleIds;
				int formationIndex = (formationRoleIds != null) ? formationRoleIds.IndexOf(pinballRoleDataBase.GetId()) : -1;
				PinballRoleSelectGridItemData item = new PinballRoleSelectGridItemData
				{
					RoleData = pinballRoleDataBase,
					ItemData = itemData,
					ClassIdList = list,
					IsSelected = false,
					FormationIndex = formationIndex
				};
				this.AllGridDataList.Add(item);
			}
		}

		// Token: 0x0603FD12 RID: 261394 RVA: 0x00F70570 File Offset: 0x00F6E770
		public bool SetSelectedRoleDataByRoleId(int roleId)
		{
			int num = this.CurShowGridDataList.FindIndex((IPinballRoleSelectGridItemData role) => role.RoleData.GetId() == roleId);
			return num >= 0 && this.SetSelectedRoleDataByIndex(num);
		}

		// Token: 0x0603FD13 RID: 261395 RVA: 0x00F705B0 File Offset: 0x00F6E7B0
		public bool SetSelectedRoleDataByIndex(int index)
		{
			if (index < 0 || index >= this.CurShowGridDataList.Count)
			{
				return false;
			}
			if (this.CurShowGridDataList[index].IsSelected)
			{
				return false;
			}
			if (this.SelectedRoleData != null)
			{
				this.SelectedRoleData.IsSelected = false;
			}
			this.SelectedIndex = index;
			this.SelectedRoleData = this.CurShowGridDataList[index];
			this.SelectedRoleId = this.SelectedRoleData.RoleData.GetId();
			this.CurShowGridDataList[index].IsSelected = true;
			return true;
		}

		// Token: 0x0603FD14 RID: 261396 RVA: 0x00F7063C File Offset: 0x00F6E83C
		public void SelectRoleByIndex(int index)
		{
			int selectedIndex = this.SelectedIndex;
			if (!this.SetSelectedRoleDataByIndex(index))
			{
				return;
			}
			if (selectedIndex >= 0 && selectedIndex < this.CurShowGridDataList.Count)
			{
				PinballRoleSelectGridItem pinballRoleSelectGridItem = this.RoleScrollView.UnsafeGetGridProxy(selectedIndex, false);
				if (pinballRoleSelectGridItem != null)
				{
					pinballRoleSelectGridItem.RefreshSelectedState(false);
				}
			}
			this.RefreshRole();
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.PlayOrReplaySequenceByName("Switch", false, null);
		}

		// Token: 0x0603FD15 RID: 261397 RVA: 0x00F706AC File Offset: 0x00F6E8AC
		public void SelectRoleByRoleId(int roleId)
		{
			int num = this.CurShowGridDataList.FindIndex((IPinballRoleSelectGridItemData role) => role.RoleData.GetId() == roleId);
			if (num < 0)
			{
				return;
			}
			this.SelectRoleByIndex(num);
		}

		// Token: 0x0603FD16 RID: 261398 RVA: 0x00F706EC File Offset: 0x00F6E8EC
		public void RefreshRole()
		{
			PinballRoleSelectView.<>c__DisplayClass21_0 CS$<>8__locals1 = new PinballRoleSelectView.<>c__DisplayClass21_0();
			CS$<>8__locals1.<>4__this = this;
			if (this.SelectedIndex < 0 || this.SelectedIndex >= this.CurShowGridDataList.Count)
			{
				return;
			}
			CS$<>8__locals1.roleItemData = this.CurShowGridDataList[this.SelectedIndex];
			UiAsyncTask task = new UiAsyncTask("RefreshRole", delegate()
			{
				PinballRoleSelectView.<>c__DisplayClass21_0.<<RefreshRole>b__0>d <<RefreshRole>b__0>d;
				<<RefreshRole>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<RefreshRole>b__0>d.<>4__this = CS$<>8__locals1;
				<<RefreshRole>b__0>d.<>1__state = -1;
				<<RefreshRole>b__0>d.<>t__builder.Start<PinballRoleSelectView.<>c__DisplayClass21_0.<<RefreshRole>b__0>d>(ref <<RefreshRole>b__0>d);
				return <<RefreshRole>b__0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task).Forget();
		}

		// Token: 0x0603FD17 RID: 261399 RVA: 0x00F70760 File Offset: 0x00F6E960
		public UniTask RefreshRoleAsync()
		{
			PinballRoleSelectView.<RefreshRoleAsync>d__22 <RefreshRoleAsync>d__;
			<RefreshRoleAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshRoleAsync>d__.<>4__this = this;
			<RefreshRoleAsync>d__.<>1__state = -1;
			<RefreshRoleAsync>d__.<>t__builder.Start<PinballRoleSelectView.<RefreshRoleAsync>d__22>(ref <RefreshRoleAsync>d__);
			return <RefreshRoleAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FD18 RID: 261400 RVA: 0x00F707A4 File Offset: 0x00F6E9A4
		public UniTask RefreshRoleByRoleDataAsync(IPinballRoleSelectGridItemData gridData)
		{
			PinballRoleSelectView.<RefreshRoleByRoleDataAsync>d__23 <RefreshRoleByRoleDataAsync>d__;
			<RefreshRoleByRoleDataAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshRoleByRoleDataAsync>d__.<>4__this = this;
			<RefreshRoleByRoleDataAsync>d__.gridData = gridData;
			<RefreshRoleByRoleDataAsync>d__.<>1__state = -1;
			<RefreshRoleByRoleDataAsync>d__.<>t__builder.Start<PinballRoleSelectView.<RefreshRoleByRoleDataAsync>d__23>(ref <RefreshRoleByRoleDataAsync>d__);
			return <RefreshRoleByRoleDataAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FD19 RID: 261401 RVA: 0x00F707EF File Offset: 0x00F6E9EF
		private void UpdateRoleList(List<IPinballRoleSelectGridItemData> list, bool isOutSideChange, EFilterSortType operationType)
		{
			this.CurShowGridDataList = list;
			this.SelectedIndex = this.CurShowGridDataList.FindIndex((IPinballRoleSelectGridItemData role) => role.RoleData.GetId() == this.SelectedRoleId);
			if (!isOutSideChange)
			{
				this.RoleScrollView.RefreshByData(this.CurShowGridDataList, false, null, true);
			}
		}

		// Token: 0x0603FD1A RID: 261402 RVA: 0x00F7082C File Offset: 0x00F6EA2C
		private PinballRoleSelectGridItem CreateRoleSelectGridItem()
		{
			PinballRoleSelectGridItem pinballRoleSelectGridItem = new PinballRoleSelectGridItem();
			pinballRoleSelectGridItem.BindOnStateChangeCallback(new Action<IPinballItemToggleCallback>(this.OnGridStateChange));
			return pinballRoleSelectGridItem;
		}

		// Token: 0x0603FD1B RID: 261403 RVA: 0x00F70848 File Offset: 0x00F6EA48
		private void OnGridStateChange(IPinballItemToggleCallback callbackParameter)
		{
			if (callbackParameter.State == EToggleState.ETT_Checked)
			{
				PinballRoleSelectGridItem pinballRoleSelectGridItem = callbackParameter.View as PinballRoleSelectGridItem;
				this.SelectRoleByIndex(pinballRoleSelectGridItem.GridIndex);
			}
		}

		// Token: 0x0603FD1C RID: 261404 RVA: 0x00F70876 File Offset: 0x00F6EA76
		private void OnBackButtonClick()
		{
			IPinballRoleSelectViewOpenData openData = this.OpenData;
			if (openData != null)
			{
				openData.OnSelectConfirm(this.SelectedRoleId);
			}
			base.CloseMe(null);
		}

		// Token: 0x040214CD RID: 136397
		[Nullable(2)]
		protected IPinballRoleSelectViewOpenData OpenData;

		// Token: 0x040214CE RID: 136398
		protected List<IPinballRoleSelectGridItemData> AllGridDataList = new List<IPinballRoleSelectGridItemData>();

		// Token: 0x040214CF RID: 136399
		protected List<IPinballRoleSelectGridItemData> CurShowGridDataList = new List<IPinballRoleSelectGridItemData>();

		// Token: 0x040214D0 RID: 136400
		protected int SelectedIndex;

		// Token: 0x040214D1 RID: 136401
		protected int SelectedRoleId;

		// Token: 0x040214D2 RID: 136402
		[Nullable(2)]
		protected IPinballRoleSelectGridItemData SelectedRoleData;

		// Token: 0x040214D3 RID: 136403
		[Nullable(2)]
		protected PopupCaptionItem CaptionItem;

		// Token: 0x040214D4 RID: 136404
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected LoopScrollView<PinballRoleSelectGridItem, IPinballRoleSelectGridItemData> RoleScrollView;

		// Token: 0x040214D5 RID: 136405
		[Nullable(2)]
		protected PinballRoleSpineItem RoleSpineItem;

		// Token: 0x040214D6 RID: 136406
		[Nullable(2)]
		protected PinballRoleBdItem BdItem;

		// Token: 0x040214D7 RID: 136407
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected FilterSortEntrance<IPinballRoleSelectGridItemData> FilterSortEntrance;

		// Token: 0x0200C50A RID: 50442
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403B774 RID: 243572
			CaptionItem,
			// Token: 0x0403B775 RID: 243573
			RoleLoopScrollView,
			// Token: 0x0403B776 RID: 243574
			RoleTemplateItem,
			// Token: 0x0403B777 RID: 243575
			RoleSpineItem,
			// Token: 0x0403B778 RID: 243576
			NameText,
			// Token: 0x0403B779 RID: 243577
			BdItem,
			// Token: 0x0403B77A RID: 243578
			LevelText,
			// Token: 0x0403B77B RID: 243579
			BdBgTexture,
			// Token: 0x0403B77C RID: 243580
			BackButton,
			// Token: 0x0403B77D RID: 243581
			FilterSortItem
		}
	}
}
