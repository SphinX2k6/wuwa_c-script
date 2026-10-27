using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001574 RID: 5492
[NullableContext(1)]
[Nullable(0)]
public class VersionPreheatQuestDetailView : UiViewBase
{
	// Token: 0x06009D0B RID: 40203 RVA: 0x0021FA04 File Offset: 0x0021DC04
	public VersionPreheatQuestDetailView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06009D0C RID: 40204 RVA: 0x0021FA64 File Offset: 0x0021DC64
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

	// Token: 0x06009D0D RID: 40205 RVA: 0x0022007C File Offset: 0x0021E27C
	protected override UniTask OnBeforeStartAsync()
	{
		VersionPreheatQuestDetailView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VersionPreheatQuestDetailView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009D0E RID: 40206 RVA: 0x002200C0 File Offset: 0x0021E2C0
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

	// Token: 0x06009D0F RID: 40207 RVA: 0x00220109 File Offset: 0x0021E309
	protected override void OnBeforeDestroy()
	{
		VersionPreheatModel.Instance.CurrentUsingVersionPreheatId = null;
	}

	// Token: 0x06009D10 RID: 40208 RVA: 0x0022011C File Offset: 0x0021E31C
	private void HandleOnClickShare()
	{
		VersionPreheatQuestDetailPersistentData persistentData = (this.OpenParam as VersionPreheatQuestDetailData).PersistentData;
		ActivityVersionPreheatController.Instance.OpenShareView(persistentData.QuestSharePhotoPath, persistentData.QuestTitleTextId, persistentData.QuestContentTextId);
	}

	// Token: 0x06009D11 RID: 40209 RVA: 0x00220156 File Offset: 0x0021E356
	private void HandleOnClickSelfChatContent()
	{
	}

	// Token: 0x06009D12 RID: 40210 RVA: 0x00220158 File Offset: 0x0021E358
	private void HandleOnClickExit()
	{
		base.CloseMe(null);
	}

	// Token: 0x06009D13 RID: 40211 RVA: 0x00220161 File Offset: 0x0021E361
	private CommonItemSmallItemGrid GridProxyCreateFunction()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x06009D14 RID: 40212 RVA: 0x00220168 File Offset: 0x0021E368
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

	// Token: 0x06009D15 RID: 40213 RVA: 0x0022024C File Offset: 0x0021E44C
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

	// Token: 0x06009D16 RID: 40214 RVA: 0x00220290 File Offset: 0x0021E490
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

	// Token: 0x06009D17 RID: 40215 RVA: 0x002203B4 File Offset: 0x0021E5B4
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

	// Token: 0x06009D18 RID: 40216 RVA: 0x002204CC File Offset: 0x0021E6CC
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

	// Token: 0x06009D19 RID: 40217 RVA: 0x00220550 File Offset: 0x0021E750
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

	// Token: 0x06009D1A RID: 40218 RVA: 0x0022059C File Offset: 0x0021E79C
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

	// Token: 0x06009D1B RID: 40219 RVA: 0x002205EC File Offset: 0x0021E7EC
	private void RefreshExternal(VersionPreheatQuestDetailData data)
	{
		this.RefreshPersistentByData(data.PersistentData);
		this.RefreshVoteByData(data.VoteData);
		this.RefreshChatByData(data.ChatData);
		this.RefreshRewardByData(data.RewardData);
		this.RefreshBonus(data.BonusTextId);
	}

	// Token: 0x040044EC RID: 17644
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

	// Token: 0x040044ED RID: 17645
	private VersionPreheatQuestDetailRoleItem NpcRoleItem;

	// Token: 0x040044EE RID: 17646
	private VersionPreheatQuestDetailRoleItem SelfRoleItem;

	// Token: 0x040044EF RID: 17647
	private GenericLayout<CommonItemSmallItemGrid, TItem> ItemLayoutInReward;

	// Token: 0x040044F0 RID: 17648
	private VersionPreheatButton RewardConfirmButtonItem;

	// Token: 0x040044F1 RID: 17649
	private bool IsFirstIn = true;

	// Token: 0x02007BA3 RID: 31651
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x04028A41 RID: 166465
		public const int QuestContentText = 0;

		// Token: 0x04028A42 RID: 166466
		public const int Crest1Texture = 1;

		// Token: 0x04028A43 RID: 166467
		public const int Crest2Texture = 2;

		// Token: 0x04028A44 RID: 166468
		public const int QuestTitleText = 3;

		// Token: 0x04028A45 RID: 166469
		public const int VoteRootItem = 4;

		// Token: 0x04028A46 RID: 166470
		public const int BlueSprite = 5;

		// Token: 0x04028A47 RID: 166471
		public const int RedSprite = 6;

		// Token: 0x04028A48 RID: 166472
		public const int BlueAndRedSlider = 7;

		// Token: 0x04028A49 RID: 166473
		public const int HandleSprite = 8;

		// Token: 0x04028A4A RID: 166474
		public const int LeftPercentageText = 9;

		// Token: 0x04028A4B RID: 166475
		public const int LeftCheckSprite = 10;

		// Token: 0x04028A4C RID: 166476
		public const int RightPercentageText = 11;

		// Token: 0x04028A4D RID: 166477
		public const int RightCheckSprite = 12;

		// Token: 0x04028A4E RID: 166478
		public const int LeftTipsText = 13;

		// Token: 0x04028A4F RID: 166479
		public const int RightTipsText = 14;

		// Token: 0x04028A50 RID: 166480
		public const int PhotoTexture = 15;

		// Token: 0x04028A51 RID: 166481
		public const int ShareButton = 16;

		// Token: 0x04028A52 RID: 166482
		public const int RewardRootItem = 17;

		// Token: 0x04028A53 RID: 166483
		public const int RewardTitleText = 18;

		// Token: 0x04028A54 RID: 166484
		public const int RewardItemLayout = 19;

		// Token: 0x04028A55 RID: 166485
		public const int RewardItemLayoutItem = 20;

		// Token: 0x04028A56 RID: 166486
		public const int ChatRootItem = 21;

		// Token: 0x04028A57 RID: 166487
		public const int NpcRoleItem = 22;

		// Token: 0x04028A58 RID: 166488
		public const int NpcChatContentText = 23;

		// Token: 0x04028A59 RID: 166489
		public const int SelfChatRootItem = 24;

		// Token: 0x04028A5A RID: 166490
		public const int SelfRoleItem = 25;

		// Token: 0x04028A5B RID: 166491
		public const int SelfChatContentRootItem = 26;

		// Token: 0x04028A5C RID: 166492
		public const int SelfChatContentButton = 27;

		// Token: 0x04028A5D RID: 166493
		public const int SelfChatContentText = 28;

		// Token: 0x04028A5E RID: 166494
		public const int SelfChatRedDotItem = 29;

		// Token: 0x04028A5F RID: 166495
		public const int BonusTipsText = 30;

		// Token: 0x04028A60 RID: 166496
		public const int Quest1RootItem = 31;

		// Token: 0x04028A61 RID: 166497
		public const int Quest2RootItem = 32;

		// Token: 0x04028A62 RID: 166498
		public const int Quest3RootItem = 33;

		// Token: 0x04028A63 RID: 166499
		public const int Quest4RootItem = 34;

		// Token: 0x04028A64 RID: 166500
		public const int Quest5RootItem = 35;

		// Token: 0x04028A65 RID: 166501
		public const int Quest6RootItem = 36;

		// Token: 0x04028A66 RID: 166502
		public const int Quest7RootItem = 37;

		// Token: 0x04028A67 RID: 166503
		public const int ExitButton = 38;

		// Token: 0x04028A68 RID: 166504
		public const int ShareBgTexture = 39;

		// Token: 0x04028A69 RID: 166505
		public const int RewardConfirmButtonItem = 40;
	}
}
