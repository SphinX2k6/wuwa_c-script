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
	// Token: 0x02005294 RID: 21140
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballRoleSelectView : UiViewBase
	{
		// Token: 0x060349CE RID: 215502 RVA: 0x00EB7108 File Offset: 0x00EB5308
		public PinballRoleSelectView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060349CF RID: 215503 RVA: 0x00EB7128 File Offset: 0x00EB5328
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

		// Token: 0x060349D0 RID: 215504 RVA: 0x00EB72D8 File Offset: 0x00EB54D8
		protected override UniTask OnBeforeStartAsync()
		{
			PinballRoleSelectView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballRoleSelectView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060349D1 RID: 215505 RVA: 0x00EB731B File Offset: 0x00EB551B
		protected override void OnBeforeShow()
		{
			this.RoleScrollView.ResetGridController();
		}

		// Token: 0x060349D2 RID: 215506 RVA: 0x00EB7328 File Offset: 0x00EB5528
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

		// Token: 0x060349D3 RID: 215507 RVA: 0x00EB74CC File Offset: 0x00EB56CC
		public bool SetSelectedRoleDataByRoleId(int roleId)
		{
			int num = this.CurShowGridDataList.FindIndex((IPinballRoleSelectGridItemData role) => role.RoleData.GetId() == roleId);
			return num >= 0 && this.SetSelectedRoleDataByIndex(num);
		}

		// Token: 0x060349D4 RID: 215508 RVA: 0x00EB750C File Offset: 0x00EB570C
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

		// Token: 0x060349D5 RID: 215509 RVA: 0x00EB7598 File Offset: 0x00EB5798
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

		// Token: 0x060349D6 RID: 215510 RVA: 0x00EB7608 File Offset: 0x00EB5808
		public void SelectRoleByRoleId(int roleId)
		{
			int num = this.CurShowGridDataList.FindIndex((IPinballRoleSelectGridItemData role) => role.RoleData.GetId() == roleId);
			if (num < 0)
			{
				return;
			}
			this.SelectRoleByIndex(num);
		}

		// Token: 0x060349D7 RID: 215511 RVA: 0x00EB7648 File Offset: 0x00EB5848
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

		// Token: 0x060349D8 RID: 215512 RVA: 0x00EB76BC File Offset: 0x00EB58BC
		public UniTask RefreshRoleAsync()
		{
			PinballRoleSelectView.<RefreshRoleAsync>d__22 <RefreshRoleAsync>d__;
			<RefreshRoleAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshRoleAsync>d__.<>4__this = this;
			<RefreshRoleAsync>d__.<>1__state = -1;
			<RefreshRoleAsync>d__.<>t__builder.Start<PinballRoleSelectView.<RefreshRoleAsync>d__22>(ref <RefreshRoleAsync>d__);
			return <RefreshRoleAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060349D9 RID: 215513 RVA: 0x00EB7700 File Offset: 0x00EB5900
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

		// Token: 0x060349DA RID: 215514 RVA: 0x00EB774B File Offset: 0x00EB594B
		private void UpdateRoleList(List<IPinballRoleSelectGridItemData> list, bool isOutSideChange, EFilterSortType operationType)
		{
			this.CurShowGridDataList = list;
			this.SelectedIndex = this.CurShowGridDataList.FindIndex((IPinballRoleSelectGridItemData role) => role.RoleData.GetId() == this.SelectedRoleId);
			if (!isOutSideChange)
			{
				this.RoleScrollView.RefreshByData(this.CurShowGridDataList, false, null, true);
			}
		}

		// Token: 0x060349DB RID: 215515 RVA: 0x00EB7788 File Offset: 0x00EB5988
		private PinballRoleSelectGridItem CreateRoleSelectGridItem()
		{
			PinballRoleSelectGridItem pinballRoleSelectGridItem = new PinballRoleSelectGridItem();
			pinballRoleSelectGridItem.BindOnStateChangeCallback(new Action<IPinballItemToggleCallback>(this.OnGridStateChange));
			return pinballRoleSelectGridItem;
		}

		// Token: 0x060349DC RID: 215516 RVA: 0x00EB77A4 File Offset: 0x00EB59A4
		private void OnGridStateChange(IPinballItemToggleCallback callbackParameter)
		{
			if (callbackParameter.State == EToggleState.ETT_Checked)
			{
				PinballRoleSelectGridItem pinballRoleSelectGridItem = callbackParameter.View as PinballRoleSelectGridItem;
				this.SelectRoleByIndex(pinballRoleSelectGridItem.GridIndex);
			}
		}

		// Token: 0x060349DD RID: 215517 RVA: 0x00EB77D2 File Offset: 0x00EB59D2
		private void OnBackButtonClick()
		{
			IPinballRoleSelectViewOpenData openData = this.OpenData;
			if (openData != null)
			{
				openData.OnSelectConfirm(this.SelectedRoleId);
			}
			base.CloseMe(null);
		}

		// Token: 0x0401BDFC RID: 114172
		[Nullable(2)]
		protected IPinballRoleSelectViewOpenData OpenData;

		// Token: 0x0401BDFD RID: 114173
		protected List<IPinballRoleSelectGridItemData> AllGridDataList = new List<IPinballRoleSelectGridItemData>();

		// Token: 0x0401BDFE RID: 114174
		protected List<IPinballRoleSelectGridItemData> CurShowGridDataList = new List<IPinballRoleSelectGridItemData>();

		// Token: 0x0401BDFF RID: 114175
		protected int SelectedIndex;

		// Token: 0x0401BE00 RID: 114176
		protected int SelectedRoleId;

		// Token: 0x0401BE01 RID: 114177
		[Nullable(2)]
		protected IPinballRoleSelectGridItemData SelectedRoleData;

		// Token: 0x0401BE02 RID: 114178
		[Nullable(2)]
		protected PopupCaptionItem CaptionItem;

		// Token: 0x0401BE03 RID: 114179
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected LoopScrollView<PinballRoleSelectGridItem, IPinballRoleSelectGridItemData> RoleScrollView;

		// Token: 0x0401BE04 RID: 114180
		[Nullable(2)]
		protected PinballRoleSpineItem RoleSpineItem;

		// Token: 0x0401BE05 RID: 114181
		[Nullable(2)]
		protected PinballRoleBdItem BdItem;

		// Token: 0x0401BE06 RID: 114182
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected FilterSortEntrance<IPinballRoleSelectGridItemData> FilterSortEntrance;

		// Token: 0x0200AEF1 RID: 44785
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x040360D6 RID: 221398
			CaptionItem,
			// Token: 0x040360D7 RID: 221399
			RoleLoopScrollView,
			// Token: 0x040360D8 RID: 221400
			RoleTemplateItem,
			// Token: 0x040360D9 RID: 221401
			RoleSpineItem,
			// Token: 0x040360DA RID: 221402
			NameText,
			// Token: 0x040360DB RID: 221403
			BdItem,
			// Token: 0x040360DC RID: 221404
			LevelText,
			// Token: 0x040360DD RID: 221405
			BdBgTexture,
			// Token: 0x040360DE RID: 221406
			BackButton,
			// Token: 0x040360DF RID: 221407
			FilterSortItem
		}
	}
}
