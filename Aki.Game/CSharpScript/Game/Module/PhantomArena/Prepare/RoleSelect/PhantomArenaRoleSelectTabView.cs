using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.RoleSelect
{
	// Token: 0x02004123 RID: 16675
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaRoleSelectTabView : PhantomArenaChildViewBase
	{
		// Token: 0x170054C9 RID: 21705
		// (get) Token: 0x0602A28C RID: 172684 RVA: 0x00BE7008 File Offset: 0x00BE5208
		// (set) Token: 0x0602A28D RID: 172685 RVA: 0x00BE7015 File Offset: 0x00BE5215
		public new IPhantomArenaRoleSelectTabViewModel ViewModel
		{
			get
			{
				return this.ViewModel as IPhantomArenaRoleSelectTabViewModel;
			}
			set
			{
				this.ViewModel = value;
			}
		}

		// Token: 0x0602A28E RID: 172686 RVA: 0x00BE7020 File Offset: 0x00BE5220
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUILoopScrollViewComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIText)),
				new ValueTuple<int, Type>(7, typeof(UUIText)),
				new ValueTuple<int, Type>(8, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUIItem)),
				new ValueTuple<int, Type>(12, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(8, new Action(this.OnConfirmBtnClick))
			};
		}

		// Token: 0x0602A28F RID: 172687 RVA: 0x00BE7180 File Offset: 0x00BE5380
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaRoleSelectTabView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaRoleSelectTabView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602A290 RID: 172688 RVA: 0x00BE71C4 File Offset: 0x00BE53C4
		protected override void OnBeforeShow()
		{
			this.ViewModel.SetViewTitle("PhantomArenaRoleSelectTabView_Name");
			this.ViewModel.SetViewHelpId(337);
			this.ViewModel.SetViewHelpBtnActive(true);
			this.ViewModel.SetViewIcon("SP_IconSoundRemnantArena4");
			this.ViewModel.TextureCardRoleId = this.GetSelectedCardRoleId();
			this.ViewModel.RefreshRoleTexture();
			this.ViewModel.ShowRoleTexture(true);
		}

		// Token: 0x0602A291 RID: 172689 RVA: 0x00BE7254 File Offset: 0x00BE5454
		protected IPhantomArenaRoleSelectionItemData CreateCardRoleItemData(int cardRoleId)
		{
			bool flag = PhantomArenaModel.Instance.IsRoleUnlock(cardRoleId);
			bool canShowSelectBtnInRoleSelectTabView = this.ViewModel.CanShowSelectBtnInRoleSelectTabView;
			bool canShowRewardInRoleSelectTabView = this.ViewModel.CanShowRewardInRoleSelectTabView;
			bool flag2 = PhantomArenaModel.Instance.IsRoleReward(cardRoleId);
			return new PhantomArenaRoleSelectionItemData
			{
				CardRoleId = cardRoleId,
				CanReceived = (canShowRewardInRoleSelectTabView && flag && !flag2),
				IsLocked = !flag,
				CanSelect = (flag && canShowSelectBtnInRoleSelectTabView)
			};
		}

		// Token: 0x0602A292 RID: 172690 RVA: 0x00BE72C2 File Offset: 0x00BE54C2
		protected int GetSelectedCardRoleId()
		{
			return this.CardRoleDataList[this.SelectedRoleIndex].CardRoleId;
		}

		// Token: 0x0602A293 RID: 172691 RVA: 0x00BE72DA File Offset: 0x00BE54DA
		protected IPhantomArenaRoleSelectionItemData GetSelectedCardRoleData()
		{
			return this.CardRoleDataList[this.SelectedRoleIndex];
		}

		// Token: 0x0602A294 RID: 172692 RVA: 0x00BE72F0 File Offset: 0x00BE54F0
		public void SelectCardRoleByCardRoleId(int cardRoleId, bool bPlayRoleChangeAnim)
		{
			int num = this.CardRoleDataList.FindIndex((IPhantomArenaRoleSelectionItemData value) => value.CardRoleId == cardRoleId);
			if (num == -1)
			{
				return;
			}
			this.SelectCardRoleByIndex(num, bPlayRoleChangeAnim);
		}

		// Token: 0x0602A295 RID: 172693 RVA: 0x00BE7330 File Offset: 0x00BE5530
		public void SelectCardRoleByIndex(int index, bool bPlayRoleChangeAnim)
		{
			if (index == -1)
			{
				return;
			}
			this.SelectedRoleIndex = index;
			LoopScrollView<PhantomArenaRoleSelectionItem, IPhantomArenaRoleSelectionItemData> roleLoopScrollView = this.RoleLoopScrollView;
			if (roleLoopScrollView != null)
			{
				roleLoopScrollView.SelectGridProxy(index, false);
			}
			int cardRoleId = this.CardRoleDataList[index].CardRoleId;
			this.ViewModel.ChangeRoleTexture(cardRoleId, bPlayRoleChangeAnim);
			this.RefreshDetailView();
		}

		// Token: 0x0602A296 RID: 172694 RVA: 0x00BE7388 File Offset: 0x00BE5588
		protected void RefreshDetailView()
		{
			if (this.SelectedRoleIndex == -1 || this.SelectedRoleIndex >= this.CardRoleDataList.Count)
			{
				return;
			}
			int selectedCardRoleId = this.GetSelectedCardRoleId();
			PhantomBattleCardRole phantomBattleCardRole = PhantomArenaConfig.Instance.GetPhantomBattleCardRole(selectedCardRoleId);
			int roleConfigId = phantomBattleCardRole.RoleConfigId;
			RoleInfo value = RoleConfig.Instance.GetRoleConfig(roleConfigId).Value;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), value.Name, Array.Empty<object>());
			MiniElementItem elementItem = this.ElementItem;
			if (elementItem != null)
			{
				elementItem.RefreshMiniElement(value.ElementId);
			}
			this.RefreshStates();
			List<string> list = new List<string>();
			list.AddRange(phantomBattleCardRole.PassiveSkillIconList());
			list.AddRange(phantomBattleCardRole.SkillIconList());
			this.SelectedSkillIndex = 0;
			int count = list.Count;
			this.SkillItemDataList.Clear();
			foreach (string iconPath in list)
			{
				PhantomArenaRoleSkillItemData item = new PhantomArenaRoleSkillItemData
				{
					IconPath = iconPath
				};
				this.SkillItemDataList.Add(item);
			}
			for (int i = 0; i < count; i++)
			{
				PhantomArenaRoleSkillItem phantomArenaRoleSkillItem = this.SkillItemList[i];
				PhantomArenaRoleSkillItemData data = this.SkillItemDataList[i];
				phantomArenaRoleSkillItem.SetActive(true);
				phantomArenaRoleSkillItem.Refresh(data, this.SelectedSkillIndex == i, i);
			}
			if (this.SkillItemList.Count > count)
			{
				for (int j = count; j < this.SkillItemList.Count; j++)
				{
					this.SkillItemList[j].SetActive(false);
				}
			}
			this.RefreshSkillDetailView();
		}

		// Token: 0x0602A297 RID: 172695 RVA: 0x00BE7538 File Offset: 0x00BE5738
		public void RefreshStates()
		{
			IPhantomArenaRoleSelectionItemData selectedCardRoleData = this.GetSelectedCardRoleData();
			int cardRoleId = selectedCardRoleData.CardRoleId;
			PhantomBattleCardRole phantomBattleCardRole = PhantomArenaConfig.Instance.GetPhantomBattleCardRole(cardRoleId);
			base.GetItem(11).SetUIActive(selectedCardRoleData.IsLocked);
			base.GetItem(9).SetUIActive(selectedCardRoleData.CanReceived);
			base.GetButton(8).RootUIComp.Get().SetUIActive(selectedCardRoleData.CanSelect);
			if (selectedCardRoleData.IsLocked)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(12), phantomBattleCardRole.UnlockConditionTip, Array.Empty<object>());
			}
			if (selectedCardRoleData.CanReceived)
			{
				int dropId = phantomBattleCardRole.DropId;
				if (dropId > 0)
				{
					Dictionary<int, int> dictionary = ConfigDropPackageById.GetConfig(dropId, true).Value.DropPreview();
					if (dictionary.Count > 1)
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.PhantomArena;
						ELogAuthor author = ELogAuthor.LZK;
						string message = "奖励物品数量大于1，请检查配置";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("cardRoleConfig", cardRoleId);
						instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					}
					using (Dictionary<int, int>.Enumerator enumerator = dictionary.GetEnumerator())
					{
						if (enumerator.MoveNext())
						{
							KeyValuePair<int, int> keyValuePair = enumerator.Current;
							int key = keyValuePair.Key;
							int value = keyValuePair.Value;
							TItem data = new TItem
							{
								ItemData = new InventoryDefine.GetItemData(key, 0),
								Count = value
							};
							CommonItemSmallItemGrid rewardItem = this.RewardItem;
							if (rewardItem != null)
							{
								rewardItem.Refresh(data);
							}
							CommonItemSmallItemGrid rewardItem2 = this.RewardItem;
							if (rewardItem2 != null)
							{
								rewardItem2.SetReceivableVisible(true);
							}
						}
					}
				}
			}
		}

		// Token: 0x0602A298 RID: 172696 RVA: 0x00BE76D4 File Offset: 0x00BE58D4
		public void RefreshSkillDetailView()
		{
			if (this.SelectedSkillIndex == -1)
			{
				return;
			}
			int selectedCardRoleId = this.GetSelectedCardRoleId();
			PhantomBattleCardRole phantomBattleCardRole = PhantomArenaConfig.Instance.GetPhantomBattleCardRole(selectedCardRoleId);
			List<string> list = new List<string>();
			list.AddRange(phantomBattleCardRole.PassiveSkillNameList());
			list.AddRange(phantomBattleCardRole.SkillNameList());
			List<Tuple<string, string[]>> list2 = new List<Tuple<string, string[]>>();
			for (int i = 0; i < phantomBattleCardRole.PassiveSkillDescList().Length; i++)
			{
				string item = phantomBattleCardRole.PassiveSkillDescList()[i];
				string[] item2 = (phantomBattleCardRole.PassiveSkillDescParamsList() != null && phantomBattleCardRole.PassiveSkillDescParamsList().Length > i) ? phantomBattleCardRole.PassiveSkillDescParamsList()[i].ArrayString() : new string[0];
				list2.Add(new Tuple<string, string[]>(item, item2));
			}
			for (int j = 0; j < phantomBattleCardRole.SkillDescList().Length; j++)
			{
				string item3 = phantomBattleCardRole.SkillDescList()[j];
				string[] item4 = (phantomBattleCardRole.SkillDescParamsList().Length > j) ? phantomBattleCardRole.SkillDescParamsList()[j].ArrayString() : new string[0];
				list2.Add(new Tuple<string, string[]>(item3, item4));
			}
			if (list.Count != this.SkillItemDataList.Count || list2.Count != this.SkillItemDataList.Count)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PhantomArena;
				ELogAuthor author = ELogAuthor.LZK;
				string message = "技能名称、技能描述数量不一致，请检查配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("cardRoleConfig", selectedCardRoleId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), list[this.SelectedSkillIndex], Array.Empty<object>());
			Tuple<string, string[]> tuple = list2[this.SelectedSkillIndex];
			LguiUtil.Instance.SetLocalTextNew(base.GetText(7), tuple.Item1, tuple.Item2);
		}

		// Token: 0x0602A299 RID: 172697 RVA: 0x00BE788C File Offset: 0x00BE5A8C
		private PhantomArenaRoleSelectionItem CreateRoleItem()
		{
			PhantomArenaRoleSelectionItem phantomArenaRoleSelectionItem = new PhantomArenaRoleSelectionItem();
			phantomArenaRoleSelectionItem.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.ToggleFunction));
			phantomArenaRoleSelectionItem.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.CanExecuteChange));
			return phantomArenaRoleSelectionItem;
		}

		// Token: 0x0602A29A RID: 172698 RVA: 0x00BE78B8 File Offset: 0x00BE5AB8
		private void ToggleFunction(MediumItemGridExtendCallback callbackParameter)
		{
			if (callbackParameter.State == EToggleState.ETT_Checked)
			{
				IPhantomArenaRoleSelectionItemData phantomArenaRoleSelectionItemData = callbackParameter.Data as IPhantomArenaRoleSelectionItemData;
				this.SelectCardRoleByCardRoleId(phantomArenaRoleSelectionItemData.CardRoleId, true);
			}
		}

		// Token: 0x0602A29B RID: 172699 RVA: 0x00BE78E7 File Offset: 0x00BE5AE7
		protected bool CanExecuteChange(object data, bool isForceSelected, EToggleState state)
		{
			return state != EToggleState.ETT_Checked || (data as IPhantomArenaRoleSelectionItemData).CardRoleId != this.GetSelectedCardRoleId();
		}

		// Token: 0x0602A29C RID: 172700 RVA: 0x00BE7908 File Offset: 0x00BE5B08
		private void OnSkillItemSelect(int gridIndex)
		{
			if (gridIndex == this.SelectedSkillIndex)
			{
				return;
			}
			if (this.SelectedSkillIndex >= 0)
			{
				this.SkillItemList[this.SelectedSkillIndex].SetSelected(false);
			}
			this.SelectedSkillIndex = gridIndex;
			this.SkillItemList[this.SelectedSkillIndex].SetSelected(true);
			this.RefreshSkillDetailView();
		}

		// Token: 0x0602A29D RID: 172701 RVA: 0x00BE7963 File Offset: 0x00BE5B63
		private void OnConfirmBtnClick()
		{
			this.ViewModel.SelectedCardRoleId = this.GetSelectedCardRoleId();
			this.ViewModel.RoleSelectedConfirmFlag = true;
			base.CloseMe();
		}

		// Token: 0x0602A29E RID: 172702 RVA: 0x00BE7988 File Offset: 0x00BE5B88
		private void OnRewardItemClicked(MediumItemGridExtendCallback _)
		{
			int selectedCardRoleId = this.GetSelectedCardRoleId();
			PhantomArenaController.Instance.RoleRewardRequest(selectedCardRoleId, new Action<int>(this.OnRoleReward));
		}

		// Token: 0x0602A29F RID: 172703 RVA: 0x00BE79B4 File Offset: 0x00BE5BB4
		private void OnRoleReward(int cardRoleId)
		{
			int i = 0;
			while (i < this.CardRoleDataList.Count)
			{
				IPhantomArenaRoleSelectionItemData phantomArenaRoleSelectionItemData = this.CardRoleDataList[i];
				if (phantomArenaRoleSelectionItemData.CardRoleId == cardRoleId)
				{
					PhantomArenaRoleSelectionItemData phantomArenaRoleSelectionItemData2 = phantomArenaRoleSelectionItemData as PhantomArenaRoleSelectionItemData;
					if (phantomArenaRoleSelectionItemData2 != null)
					{
						phantomArenaRoleSelectionItemData2.CanReceived = false;
					}
					LoopScrollView<PhantomArenaRoleSelectionItem, IPhantomArenaRoleSelectionItemData> roleLoopScrollView = this.RoleLoopScrollView;
					if (roleLoopScrollView == null)
					{
						break;
					}
					roleLoopScrollView.RefreshGridProxy(i);
					break;
				}
				else
				{
					i++;
				}
			}
			this.RefreshDetailView();
		}

		// Token: 0x04016F60 RID: 94048
		private readonly List<IPhantomArenaRoleSelectionItemData> CardRoleDataList = new List<IPhantomArenaRoleSelectionItemData>();

		// Token: 0x04016F61 RID: 94049
		private int SelectedRoleIndex = -1;

		// Token: 0x04016F62 RID: 94050
		private int SelectedSkillIndex = -1;

		// Token: 0x04016F63 RID: 94051
		private MiniElementItem ElementItem;

		// Token: 0x04016F64 RID: 94052
		private LoopScrollView<PhantomArenaRoleSelectionItem, IPhantomArenaRoleSelectionItemData> RoleLoopScrollView;

		// Token: 0x04016F65 RID: 94053
		private readonly List<PhantomArenaRoleSkillItem> SkillItemList = new List<PhantomArenaRoleSkillItem>();

		// Token: 0x04016F66 RID: 94054
		private readonly List<PhantomArenaRoleSkillItemData> SkillItemDataList = new List<PhantomArenaRoleSkillItemData>();

		// Token: 0x04016F67 RID: 94055
		private CommonItemSmallItemGrid RewardItem;

		// Token: 0x02009CEF RID: 40175
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04030C88 RID: 199816
			public const int RoleScrollView = 0;

			// Token: 0x04030C89 RID: 199817
			public const int RoleItem = 1;

			// Token: 0x04030C8A RID: 199818
			public const int RoleNameText = 2;

			// Token: 0x04030C8B RID: 199819
			public const int ElementItem = 3;

			// Token: 0x04030C8C RID: 199820
			public const int SkillItem1 = 4;

			// Token: 0x04030C8D RID: 199821
			public const int SkillItem2 = 5;

			// Token: 0x04030C8E RID: 199822
			public const int SkillNameText = 6;

			// Token: 0x04030C8F RID: 199823
			public const int SkillDescText = 7;

			// Token: 0x04030C90 RID: 199824
			public const int ConfirmBtn = 8;

			// Token: 0x04030C91 RID: 199825
			public const int RewardItem = 9;

			// Token: 0x04030C92 RID: 199826
			public const int RewardGridItem = 10;

			// Token: 0x04030C93 RID: 199827
			public const int LockItem = 11;

			// Token: 0x04030C94 RID: 199828
			public const int LockText = 12;
		}
	}
}
