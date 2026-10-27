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
	// Token: 0x02005153 RID: 20819
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaRoleSelectTabView : PhantomArenaChildViewBase
	{
		// Token: 0x17008109 RID: 33033
		// (get) Token: 0x06035390 RID: 218000 RVA: 0x00C99B08 File Offset: 0x00C97D08
		// (set) Token: 0x06035391 RID: 218001 RVA: 0x00C99B15 File Offset: 0x00C97D15
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

		// Token: 0x06035392 RID: 218002 RVA: 0x00C99B20 File Offset: 0x00C97D20
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

		// Token: 0x06035393 RID: 218003 RVA: 0x00C99C80 File Offset: 0x00C97E80
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaRoleSelectTabView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaRoleSelectTabView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035394 RID: 218004 RVA: 0x00C99CC4 File Offset: 0x00C97EC4
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

		// Token: 0x06035395 RID: 218005 RVA: 0x00C99D54 File Offset: 0x00C97F54
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

		// Token: 0x06035396 RID: 218006 RVA: 0x00C99DC2 File Offset: 0x00C97FC2
		protected int GetSelectedCardRoleId()
		{
			return this.CardRoleDataList[this.SelectedRoleIndex].CardRoleId;
		}

		// Token: 0x06035397 RID: 218007 RVA: 0x00C99DDA File Offset: 0x00C97FDA
		protected IPhantomArenaRoleSelectionItemData GetSelectedCardRoleData()
		{
			return this.CardRoleDataList[this.SelectedRoleIndex];
		}

		// Token: 0x06035398 RID: 218008 RVA: 0x00C99DF0 File Offset: 0x00C97FF0
		public void SelectCardRoleByCardRoleId(int cardRoleId, bool bPlayRoleChangeAnim)
		{
			int num = this.CardRoleDataList.FindIndex((IPhantomArenaRoleSelectionItemData value) => value.CardRoleId == cardRoleId);
			if (num == -1)
			{
				return;
			}
			this.SelectCardRoleByIndex(num, bPlayRoleChangeAnim);
		}

		// Token: 0x06035399 RID: 218009 RVA: 0x00C99E30 File Offset: 0x00C98030
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

		// Token: 0x0603539A RID: 218010 RVA: 0x00C99E88 File Offset: 0x00C98088
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

		// Token: 0x0603539B RID: 218011 RVA: 0x00C9A038 File Offset: 0x00C98238
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

		// Token: 0x0603539C RID: 218012 RVA: 0x00C9A1D4 File Offset: 0x00C983D4
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

		// Token: 0x0603539D RID: 218013 RVA: 0x00C9A38C File Offset: 0x00C9858C
		private PhantomArenaRoleSelectionItem CreateRoleItem()
		{
			PhantomArenaRoleSelectionItem phantomArenaRoleSelectionItem = new PhantomArenaRoleSelectionItem();
			phantomArenaRoleSelectionItem.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.ToggleFunction));
			phantomArenaRoleSelectionItem.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.CanExecuteChange));
			return phantomArenaRoleSelectionItem;
		}

		// Token: 0x0603539E RID: 218014 RVA: 0x00C9A3B8 File Offset: 0x00C985B8
		private void ToggleFunction(MediumItemGridExtendCallback callbackParameter)
		{
			if (callbackParameter.State == EToggleState.ETT_Checked)
			{
				IPhantomArenaRoleSelectionItemData phantomArenaRoleSelectionItemData = callbackParameter.Data as IPhantomArenaRoleSelectionItemData;
				this.SelectCardRoleByCardRoleId(phantomArenaRoleSelectionItemData.CardRoleId, true);
			}
		}

		// Token: 0x0603539F RID: 218015 RVA: 0x00C9A3E7 File Offset: 0x00C985E7
		protected bool CanExecuteChange(object data, bool isForceSelected, EToggleState state)
		{
			return state != EToggleState.ETT_Checked || (data as IPhantomArenaRoleSelectionItemData).CardRoleId != this.GetSelectedCardRoleId();
		}

		// Token: 0x060353A0 RID: 218016 RVA: 0x00C9A408 File Offset: 0x00C98608
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

		// Token: 0x060353A1 RID: 218017 RVA: 0x00C9A463 File Offset: 0x00C98663
		private void OnConfirmBtnClick()
		{
			this.ViewModel.SelectedCardRoleId = this.GetSelectedCardRoleId();
			this.ViewModel.RoleSelectedConfirmFlag = true;
			base.CloseMe();
		}

		// Token: 0x060353A2 RID: 218018 RVA: 0x00C9A488 File Offset: 0x00C98688
		private void OnRewardItemClicked(MediumItemGridExtendCallback _)
		{
			int selectedCardRoleId = this.GetSelectedCardRoleId();
			PhantomArenaController.Instance.RoleRewardRequest(selectedCardRoleId, new Action<int>(this.OnRoleReward));
		}

		// Token: 0x060353A3 RID: 218019 RVA: 0x00C9A4B4 File Offset: 0x00C986B4
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

		// Token: 0x0401C52B RID: 116011
		private readonly List<IPhantomArenaRoleSelectionItemData> CardRoleDataList = new List<IPhantomArenaRoleSelectionItemData>();

		// Token: 0x0401C52C RID: 116012
		private int SelectedRoleIndex = -1;

		// Token: 0x0401C52D RID: 116013
		private int SelectedSkillIndex = -1;

		// Token: 0x0401C52E RID: 116014
		private MiniElementItem ElementItem;

		// Token: 0x0401C52F RID: 116015
		private LoopScrollView<PhantomArenaRoleSelectionItem, IPhantomArenaRoleSelectionItemData> RoleLoopScrollView;

		// Token: 0x0401C530 RID: 116016
		private readonly List<PhantomArenaRoleSkillItem> SkillItemList = new List<PhantomArenaRoleSkillItem>();

		// Token: 0x0401C531 RID: 116017
		private readonly List<PhantomArenaRoleSkillItemData> SkillItemDataList = new List<PhantomArenaRoleSkillItemData>();

		// Token: 0x0401C532 RID: 116018
		private CommonItemSmallItemGrid RewardItem;

		// Token: 0x0200B2B6 RID: 45750
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04036233 RID: 221747
			public const int RoleScrollView = 0;

			// Token: 0x04036234 RID: 221748
			public const int RoleItem = 1;

			// Token: 0x04036235 RID: 221749
			public const int RoleNameText = 2;

			// Token: 0x04036236 RID: 221750
			public const int ElementItem = 3;

			// Token: 0x04036237 RID: 221751
			public const int SkillItem1 = 4;

			// Token: 0x04036238 RID: 221752
			public const int SkillItem2 = 5;

			// Token: 0x04036239 RID: 221753
			public const int SkillNameText = 6;

			// Token: 0x0403623A RID: 221754
			public const int SkillDescText = 7;

			// Token: 0x0403623B RID: 221755
			public const int ConfirmBtn = 8;

			// Token: 0x0403623C RID: 221756
			public const int RewardItem = 9;

			// Token: 0x0403623D RID: 221757
			public const int RewardGridItem = 10;

			// Token: 0x0403623E RID: 221758
			public const int LockItem = 11;

			// Token: 0x0403623F RID: 221759
			public const int LockText = 12;
		}
	}
}
