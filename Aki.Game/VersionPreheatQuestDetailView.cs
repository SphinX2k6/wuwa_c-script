using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000A2C RID: 2604
[NullableContext(1)]
[Nullable(0)]
public class VersionPreheatQuestDetailView : UiViewBase
{
	// Token: 0x060070E9 RID: 28905 RVA: 0x002297B4 File Offset: 0x002279B4
	public VersionPreheatQuestDetailView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x060070EA RID: 28906 RVA: 0x00229814 File Offset: 0x00227A14
	protected unsafe override void OnRegisterComponent()
	{
		int num = 41;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISliderComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(24, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(25, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(26, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(27, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(28, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(29, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(30, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(31, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(32, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(33, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(34, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(35, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(36, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(37, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(38, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(39, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(40, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 3;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(16, new Action(this.HandleOnClickShare));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(27, new Action(this.HandleOnClickSelfChatContent));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(38, new Action(this.HandleOnClickExit));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060070EB RID: 28907 RVA: 0x00229E2C File Offset: 0x0022802C
	protected override UniTask OnBeforeStartAsync()
	{
		VersionPreheatQuestDetailView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VersionPreheatQuestDetailView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060070EC RID: 28908 RVA: 0x00229E70 File Offset: 0x00228070
	protected override void OnBeforeShow()
	{
		if (this.IsFirstIn)
		{
			this.IsFirstIn = false;
			return;
		}
		VersionPreheatModel instance = VersionPreheatModel.Instance;
		if (instance.CurrentUsingVersionPreheatId != null)
		{
			VersionPreheatQuestDetailData data = instance.BuildQuestDetailDataById(instance.CurrentUsingVersionPreheatId.Value);
			this.RefreshExternal(data);
		}
	}

	// Token: 0x060070ED RID: 28909 RVA: 0x00229EB9 File Offset: 0x002280B9
	protected override void OnBeforeDestroy()
	{
		VersionPreheatModel.Instance.CurrentUsingVersionPreheatId = null;
	}

	// Token: 0x060070EE RID: 28910 RVA: 0x00229ECC File Offset: 0x002280CC
	private void HandleOnClickShare()
	{
		VersionPreheatQuestDetailPersistentData persistentData = (this.OpenParam as VersionPreheatQuestDetailData).PersistentData;
		ActivityVersionPreheatController.Instance.OpenShareView(persistentData.QuestSharePhotoPath, persistentData.QuestTitleTextId, persistentData.QuestContentTextId);
	}

	// Token: 0x060070EF RID: 28911 RVA: 0x00229F06 File Offset: 0x00228106
	private void HandleOnClickSelfChatContent()
	{
	}

	// Token: 0x060070F0 RID: 28912 RVA: 0x00229F08 File Offset: 0x00228108
	private void HandleOnClickExit()
	{
		base.CloseMe(null);
	}

	// Token: 0x060070F1 RID: 28913 RVA: 0x00229F11 File Offset: 0x00228111
	private CommonItemSmallItemGrid GridProxyCreateFunction()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x060070F2 RID: 28914 RVA: 0x00229F18 File Offset: 0x00228118
	private void RefreshPersistentByData(VersionPreheatQuestDetailPersistentData data)
	{
		base.SetTextureByPath(data.QuestPhotoPath, base.GetTexture(15), null, null);
		this.RefreshQuestItem(data.Index);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.QuestContentTextId, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), data.QuestTitleTextId, Array.Empty<object>());
		UUITexture texture = base.GetTexture(1);
		if (texture != null)
		{
			texture.SetUIActive(data.QuestCrestIndex == 0);
		}
		UUITexture texture2 = base.GetTexture(2);
		if (texture2 != null)
		{
			texture2.SetUIActive(data.QuestCrestIndex == 1);
		}
		UUIButtonComponent button = base.GetButton(16);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(data.CanShare);
		}
		UUITexture texture3 = base.GetTexture(39);
		if (texture3 == null)
		{
			return;
		}
		texture3.SetUIActive(data.CanShare);
	}

	// Token: 0x060070F3 RID: 28915 RVA: 0x00229FFC File Offset: 0x002281FC
	private void RefreshQuestItem(int index)
	{
		for (int i = 0; i < this.QuestItemList.Count; i++)
		{
			UUIItem item = base.GetItem(this.QuestItemList[i]);
			if (item != null)
			{
				item.SetUIActive(i == index);
			}
		}
	}

	// Token: 0x060070F4 RID: 28916 RVA: 0x0022A040 File Offset: 0x00228240
	private void RefreshVoteByData(VersionPreheatQuestDetailVoteData data)
	{
		if (data == null)
		{
			UUIItem item = base.GetItem(4);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
			return;
		}
		else
		{
			UUIItem item2 = base.GetItem(4);
			if (item2 != null)
			{
				item2.SetUIActive(true);
			}
			UUIText text = base.GetText(9);
			if (text != null)
			{
				text.SetText(data.LeftPercentageText, true);
			}
			UUIText text2 = base.GetText(11);
			if (text2 != null)
			{
				text2.SetText(data.RightPercentageText, true);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(13), data.LeftThemeTextId, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(14), data.RightThemeTextId, Array.Empty<object>());
			UUISprite sprite = base.GetSprite(10);
			if (sprite != null)
			{
				sprite.SetUIActive(data.IsLeftChosen);
			}
			UUISprite sprite2 = base.GetSprite(12);
			if (sprite2 != null)
			{
				sprite2.SetUIActive(!data.IsLeftChosen);
			}
			UUISprite sprite3 = base.GetSprite(6);
			if (sprite3 != null)
			{
				sprite3.SetFillAmount(data.LeftNormalized);
			}
			UUISprite sprite4 = base.GetSprite(5);
			if (sprite4 != null)
			{
				sprite4.SetFillAmount(data.RightNormalized);
			}
			UUISliderComponent slider = base.GetSlider(7);
			if (slider == null)
			{
				return;
			}
			slider.SetValue(data.LeftNormalized, true);
			return;
		}
	}

	// Token: 0x060070F5 RID: 28917 RVA: 0x0022A164 File Offset: 0x00228364
	private void RefreshChatByData(VersionPreheatQuestDetailChatData data)
	{
		if (data == null)
		{
			UUIItem item = base.GetItem(21);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
			return;
		}
		else
		{
			UUIItem item2 = base.GetItem(21);
			if (item2 != null)
			{
				item2.SetUIActive(true);
			}
			this.NpcRoleItem.RefreshExternal(data.NpcIconPath);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(23), data.NpcContentTextId, Array.Empty<object>());
			VersionPreheatQuestDetailChatData selfChatData = data.SelfChatData;
			if (selfChatData == null)
			{
				UUIItem item3 = base.GetItem(24);
				if (item3 == null)
				{
					return;
				}
				item3.SetUIActive(false);
				return;
			}
			else
			{
				UUIItem item4 = base.GetItem(24);
				if (item4 != null)
				{
					item4.SetUIActive(true);
				}
				this.SelfRoleItem.RefreshExternal(selfChatData.NpcIconPath);
				if (selfChatData.NpcContentTextId == null)
				{
					UUIItem item5 = base.GetItem(26);
					if (item5 != null)
					{
						item5.SetUIActive(false);
					}
				}
				else
				{
					UUIItem item6 = base.GetItem(26);
					if (item6 != null)
					{
						item6.SetUIActive(true);
					}
					LguiUtil.Instance.SetLocalTextNew(base.GetText(28), selfChatData.NpcContentTextId, Array.Empty<object>());
				}
				UUIButtonComponent button = base.GetButton(27);
				if (button == null)
				{
					return;
				}
				button.RootUIComp.Get().SetUIActive(false);
				return;
			}
		}
	}

	// Token: 0x060070F6 RID: 28918 RVA: 0x0022A27C File Offset: 0x0022847C
	private void RefreshRewardByData(VersionPreheatQuestDetailRewardData data)
	{
		if (data != null)
		{
			UUIItem item = base.GetItem(17);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(18), data.QuestContentTextId, Array.Empty<object>());
			this.RefreshRewardItemsAsync(data);
			this.RewardConfirmButtonItem.ClickRewardFunc = data.ClickFunc;
			this.RewardConfirmButtonItem.ClickRewardPassData = new int?(data.ClickPassData);
			return;
		}
		UUIItem item2 = base.GetItem(17);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(false);
	}

	// Token: 0x060070F7 RID: 28919 RVA: 0x0022A300 File Offset: 0x00228500
	private UniTask RefreshRewardItemsAsync(VersionPreheatQuestDetailRewardData data)
	{
		VersionPreheatQuestDetailView.<RefreshRewardItemsAsync>d__21 <RefreshRewardItemsAsync>d__;
		<RefreshRewardItemsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshRewardItemsAsync>d__.<>4__this = this;
		<RefreshRewardItemsAsync>d__.data = data;
		<RefreshRewardItemsAsync>d__.<>1__state = -1;
		<RefreshRewardItemsAsync>d__.<>t__builder.Start<VersionPreheatQuestDetailView.<RefreshRewardItemsAsync>d__21>(ref <RefreshRewardItemsAsync>d__);
		return <RefreshRewardItemsAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060070F8 RID: 28920 RVA: 0x0022A34C File Offset: 0x0022854C
	private void RefreshBonus(string data)
	{
		if (data != null)
		{
			UUIText text = base.GetText(30);
			if (text != null)
			{
				text.SetUIActive(true);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(30), data, Array.Empty<object>());
			return;
		}
		UUIText text2 = base.GetText(30);
		if (text2 == null)
		{
			return;
		}
		text2.SetUIActive(false);
	}

	// Token: 0x060070F9 RID: 28921 RVA: 0x0022A39C File Offset: 0x0022859C
	private void RefreshExternal(VersionPreheatQuestDetailData data)
	{
		this.RefreshPersistentByData(data.PersistentData);
		this.RefreshVoteByData(data.VoteData);
		this.RefreshChatByData(data.ChatData);
		this.RefreshRewardByData(data.RewardData);
		this.RefreshBonus(data.BonusTextId);
	}

	// Token: 0x04004592 RID: 17810
	private readonly List<int> QuestItemList = new List<int>
	{
		31,
		32,
		33,
		34,
		35,
		36,
		37
	};

	// Token: 0x04004593 RID: 17811
	private VersionPreheatQuestDetailRoleItem NpcRoleItem;

	// Token: 0x04004594 RID: 17812
	private VersionPreheatQuestDetailRoleItem SelfRoleItem;

	// Token: 0x04004595 RID: 17813
	private GenericLayout<CommonItemSmallItemGrid, TItem> ItemLayoutInReward;

	// Token: 0x04004596 RID: 17814
	private VersionPreheatButton RewardConfirmButtonItem;

	// Token: 0x04004597 RID: 17815
	private bool IsFirstIn = true;

	// Token: 0x02006D2E RID: 27950
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x04023D7C RID: 146812
		public const int QuestContentText = 0;

		// Token: 0x04023D7D RID: 146813
		public const int Crest1Texture = 1;

		// Token: 0x04023D7E RID: 146814
		public const int Crest2Texture = 2;

		// Token: 0x04023D7F RID: 146815
		public const int QuestTitleText = 3;

		// Token: 0x04023D80 RID: 146816
		public const int VoteRootItem = 4;

		// Token: 0x04023D81 RID: 146817
		public const int BlueSprite = 5;

		// Token: 0x04023D82 RID: 146818
		public const int RedSprite = 6;

		// Token: 0x04023D83 RID: 146819
		public const int BlueAndRedSlider = 7;

		// Token: 0x04023D84 RID: 146820
		public const int HandleSprite = 8;

		// Token: 0x04023D85 RID: 146821
		public const int LeftPercentageText = 9;

		// Token: 0x04023D86 RID: 146822
		public const int LeftCheckSprite = 10;

		// Token: 0x04023D87 RID: 146823
		public const int RightPercentageText = 11;

		// Token: 0x04023D88 RID: 146824
		public const int RightCheckSprite = 12;

		// Token: 0x04023D89 RID: 146825
		public const int LeftTipsText = 13;

		// Token: 0x04023D8A RID: 146826
		public const int RightTipsText = 14;

		// Token: 0x04023D8B RID: 146827
		public const int PhotoTexture = 15;

		// Token: 0x04023D8C RID: 146828
		public const int ShareButton = 16;

		// Token: 0x04023D8D RID: 146829
		public const int RewardRootItem = 17;

		// Token: 0x04023D8E RID: 146830
		public const int RewardTitleText = 18;

		// Token: 0x04023D8F RID: 146831
		public const int RewardItemLayout = 19;

		// Token: 0x04023D90 RID: 146832
		public const int RewardItemLayoutItem = 20;

		// Token: 0x04023D91 RID: 146833
		public const int ChatRootItem = 21;

		// Token: 0x04023D92 RID: 146834
		public const int NpcRoleItem = 22;

		// Token: 0x04023D93 RID: 146835
		public const int NpcChatContentText = 23;

		// Token: 0x04023D94 RID: 146836
		public const int SelfChatRootItem = 24;

		// Token: 0x04023D95 RID: 146837
		public const int SelfRoleItem = 25;

		// Token: 0x04023D96 RID: 146838
		public const int SelfChatContentRootItem = 26;

		// Token: 0x04023D97 RID: 146839
		public const int SelfChatContentButton = 27;

		// Token: 0x04023D98 RID: 146840
		public const int SelfChatContentText = 28;

		// Token: 0x04023D99 RID: 146841
		public const int SelfChatRedDotItem = 29;

		// Token: 0x04023D9A RID: 146842
		public const int BonusTipsText = 30;

		// Token: 0x04023D9B RID: 146843
		public const int Quest1RootItem = 31;

		// Token: 0x04023D9C RID: 146844
		public const int Quest2RootItem = 32;

		// Token: 0x04023D9D RID: 146845
		public const int Quest3RootItem = 33;

		// Token: 0x04023D9E RID: 146846
		public const int Quest4RootItem = 34;

		// Token: 0x04023D9F RID: 146847
		public const int Quest5RootItem = 35;

		// Token: 0x04023DA0 RID: 146848
		public const int Quest6RootItem = 36;

		// Token: 0x04023DA1 RID: 146849
		public const int Quest7RootItem = 37;

		// Token: 0x04023DA2 RID: 146850
		public const int ExitButton = 38;

		// Token: 0x04023DA3 RID: 146851
		public const int ShareBgTexture = 39;

		// Token: 0x04023DA4 RID: 146852
		public const int RewardConfirmButtonItem = 40;
	}
}
