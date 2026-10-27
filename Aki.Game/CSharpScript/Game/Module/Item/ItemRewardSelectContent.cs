using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Item
{
	// Token: 0x0200581E RID: 22558
	[NullableContext(1)]
	[Nullable(0)]
	internal class ItemRewardSelectContent : UiPanelBase
	{
		// Token: 0x06039514 RID: 234772 RVA: 0x00D97EEB File Offset: 0x00D960EB
		public void SetOnClickBackButtonCallBack(Action callback)
		{
			this.OnClickBackButtonCallBack = callback;
		}

		// Token: 0x06039515 RID: 234773 RVA: 0x00D97EF4 File Offset: 0x00D960F4
		public void SetOnSelectItemCallBack(Action<int, int> callback)
		{
			this.OnSelectItemCallBack = callback;
		}

		// Token: 0x06039516 RID: 234774 RVA: 0x00D97EFD File Offset: 0x00D960FD
		public void SetOnConfirmButtonCallBack(Action<int, int> callback)
		{
			this.OnConfirmButtonCallBack = callback;
		}

		// Token: 0x06039517 RID: 234775 RVA: 0x00D97F08 File Offset: 0x00D96108
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(USpineSkeletonAnimationComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06039518 RID: 234776 RVA: 0x00D9805C File Offset: 0x00D9625C
		protected override UniTask OnBeforeStartAsync()
		{
			ItemRewardSelectContent.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ItemRewardSelectContent.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039519 RID: 234777 RVA: 0x00D980A0 File Offset: 0x00D962A0
		protected override void OnStart()
		{
			this.UiSequencePlayerInstance = new UiSequencePlayer(this.RootItem);
			this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
			this.ButtonItem = new ButtonItem(base.GetItem(6));
			this.Layout = new GenericLayout<ItemSelectRewardItem, ItemSelectRewardItemData>(base.GetHorizontalLayout(1), new Func<ItemSelectRewardItem>(this.OnCreateRewardItem), null, false, true);
			this.CaptionItem.SetCloseCallBack(delegate
			{
				this.OnClickBackButtonCallBack();
			});
			this.CaptionItem.SetHelpCallBack(delegate
			{
				SelectRolePerformance? selectRolePerformanceConfig = GachaAccumulateConfig.Instance.GetSelectRolePerformanceConfig(this.GiftPackageId);
				if (selectRolePerformanceConfig != null)
				{
					HelpController.Instance.OpenHelpById(selectRolePerformanceConfig.Value.HelpId);
				}
			});
			this.ButtonItem.SetFunction(new Action<int>(this.OnClickConfirmButton));
		}

		// Token: 0x0603951A RID: 234778 RVA: 0x00D98148 File Offset: 0x00D96348
		private void OnClickConfirmButton(int _)
		{
			this.OnConfirmButtonCallBack(this.CurrentSelectIndex, this.CurrentRewardList[this.CurrentSelectIndex]);
		}

		// Token: 0x0603951B RID: 234779 RVA: 0x00D9816C File Offset: 0x00D9636C
		private ItemSelectRewardItem OnCreateRewardItem()
		{
			return new ItemSelectRewardItem();
		}

		// Token: 0x0603951C RID: 234780 RVA: 0x00D98173 File Offset: 0x00D96373
		private void OnClickToggle(int index)
		{
			this.CurrentSelectIndex = index;
			this.Refresh(this.GiftPackageId);
		}

		// Token: 0x0603951D RID: 234781 RVA: 0x00D98188 File Offset: 0x00D96388
		private bool IfHaveRoleCallBackItemNeedRole(int itemId)
		{
			int[] resonantItemRoleId = RoleModel.Instance.GetResonantItemRoleId(itemId);
			if (resonantItemRoleId == null)
			{
				return false;
			}
			int id = resonantItemRoleId[0];
			return RoleModel.Instance.GetRoleInstanceById(id) != null;
		}

		// Token: 0x0603951E RID: 234782 RVA: 0x00D981BC File Offset: 0x00D963BC
		private bool IfCanResonant(int itemId)
		{
			ResonantChainOptionLimitInfo limitInfo = this.LimitInfo;
			if (limitInfo == null)
			{
				return true;
			}
			foreach (ResonantChainOptionLimitItemInfo resonantChainOptionLimitItemInfo in limitInfo.ItemInfos)
			{
				if (resonantChainOptionLimitItemInfo.ItemId == itemId)
				{
					return resonantChainOptionLimitItemInfo.Count < limitInfo.LimitNum;
				}
			}
			return true;
		}

		// Token: 0x0603951F RID: 234783 RVA: 0x00D98234 File Offset: 0x00D96434
		private void RefreshResonantItem()
		{
			int num = this.CurrentRewardList[this.CurrentSelectIndex];
			ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(num);
			if (itemConfigData == null)
			{
				return;
			}
			int[] showTypes = itemConfigData.ShowTypes;
			if (showTypes == null || !showTypes.Contains(30))
			{
				return;
			}
			if (!this.IfHaveRoleCallBackItemNeedRole(num) || !this.IfCanResonant(num))
			{
				base.GetItem(3).SetUIActive(false);
				return;
			}
			int[] resonantItemRoleId = RoleModel.Instance.GetResonantItemRoleId(num);
			if (resonantItemRoleId == null || resonantItemRoleId.Length == 0)
			{
				return;
			}
			string textStringId = (RoleModel.Instance.GetRoleLeftResonantCountWithInventoryItem(resonantItemRoleId[0]) <= 0) ? "CurrentResonantCountMax" : "CurrentResonantCount";
			base.GetItem(3).SetUIActive(true);
			RoleResonanceConfig instance = RoleResonanceConfig.Instance;
			int num2 = ((instance != null) ? instance.GetResonanceMaxLevel() : 0) - RoleModel.Instance.GetRoleLeftResonantCountWithInventoryItem(resonantItemRoleId[0]);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), textStringId, new <>z__ReadOnlySingleElementList<object>(num2));
		}

		// Token: 0x06039520 RID: 234784 RVA: 0x00D98328 File Offset: 0x00D96528
		private void RefreshInActiveItem()
		{
			int itemId = this.CurrentRewardList[this.CurrentSelectIndex];
			if (this.IfHaveRoleCallBackItemNeedRole(itemId) && this.IfCanResonant(itemId))
			{
				base.GetItem(5).SetUIActive(false);
				ButtonItem buttonItem = this.ButtonItem;
				if (buttonItem == null)
				{
					return;
				}
				buttonItem.SetActive(true);
				return;
			}
			else
			{
				base.GetItem(5).SetUIActive(true);
				ButtonItem buttonItem2 = this.ButtonItem;
				if (buttonItem2 == null)
				{
					return;
				}
				buttonItem2.SetActive(false);
				return;
			}
		}

		// Token: 0x06039521 RID: 234785 RVA: 0x00D98399 File Offset: 0x00D96599
		[NullableContext(2)]
		public void SetLimitInfo(ResonantChainOptionLimitInfo limitInfo)
		{
			this.LimitInfo = limitInfo;
		}

		// Token: 0x06039522 RID: 234786 RVA: 0x00D983A4 File Offset: 0x00D965A4
		public void Refresh(int giftPackageId)
		{
			GiftPackage? giftPackageConfig = GiftPackageConfig.Instance.GetGiftPackageConfig(giftPackageId);
			if (giftPackageConfig == null || giftPackageConfig.GetValueOrDefault().Type != GiftType.ResonantChainOptional)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Inventory;
				ELogAuthor author = ELogAuthor.YZY;
				string message = "找不到礼包配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("GiftPackageId", giftPackageId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.CurrentRewardList.Clear();
			foreach (KeyValuePair<int, int> keyValuePair in giftPackageConfig.Value.Content())
			{
				this.CurrentRewardList.Add(keyValuePair.Key);
			}
			this.GiftPackageId = giftPackageId;
			List<ItemSelectRewardItemData> list = new List<ItemSelectRewardItemData>();
			for (int i = 0; i < this.CurrentRewardList.Count; i++)
			{
				ItemSelectRewardItemData item = new ItemSelectRewardItemData
				{
					Index = i,
					ItemId = this.CurrentRewardList[i],
					SelectState = (i == this.CurrentSelectIndex),
					LimitInfo = this.LimitInfo,
					OnClickToggleCallBack = new Action<int>(this.OnClickToggle)
				};
				list.Add(item);
			}
			this.Layout.RefreshByData(list, null, false);
			this.RefreshResonantItem();
			this.RefreshInActiveItem();
			int arg = this.CurrentRewardList[this.CurrentSelectIndex];
			this.OnSelectItemCallBack(arg, this.CurrentSelectIndex);
			this.RefreshRoleSpine();
			this.RefreshRoleDescribe();
			this.PlaySelectSequence();
		}

		// Token: 0x06039523 RID: 234787 RVA: 0x00D98548 File Offset: 0x00D96748
		private void RefreshRoleSpine()
		{
			int itemId = this.CurrentRewardList[this.CurrentSelectIndex];
			USpineSkeletonAnimationComponent spine = base.GetSpine(7);
			SelectRoleItemPerformance? selectRoleItemPerformance = GachaAccumulateConfig.Instance.GetSelectRoleItemPerformance(itemId);
			string spineAtlasPath = selectRoleItemPerformance.Value.SpineAtlasPath;
			string spineDataPath = selectRoleItemPerformance.Value.SpineDataPath;
			base.SetSpineAssetByPath(spineAtlasPath, spineDataPath, spine).Forget();
		}

		// Token: 0x06039524 RID: 234788 RVA: 0x00D985B0 File Offset: 0x00D967B0
		private void RefreshRoleDescribe()
		{
			int itemId = this.CurrentRewardList[this.CurrentSelectIndex];
			int[] resonantItemRoleId = RoleModel.Instance.GetResonantItemRoleId(itemId);
			if (resonantItemRoleId == null)
			{
				return;
			}
			int roleId = resonantItemRoleId[0];
			this.RoleDescribeComp.Update(roleId);
		}

		// Token: 0x06039525 RID: 234789 RVA: 0x00D985EF File Offset: 0x00D967EF
		private void PlaySelectSequence()
		{
			this.UiSequencePlayerInstance.PlaySequencePurely("SwitchIn", false, false);
			this.UiSequencePlayerInstance.PlaySequencePurely("SwitchOut", false, false);
		}

		// Token: 0x06039526 RID: 234790 RVA: 0x00D98618 File Offset: 0x00D96818
		public UniTask PlayStartSequenceAsync()
		{
			ItemRewardSelectContent.<PlayStartSequenceAsync>d__30 <PlayStartSequenceAsync>d__;
			<PlayStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayStartSequenceAsync>d__.<>4__this = this;
			<PlayStartSequenceAsync>d__.<>1__state = -1;
			<PlayStartSequenceAsync>d__.<>t__builder.Start<ItemRewardSelectContent.<PlayStartSequenceAsync>d__30>(ref <PlayStartSequenceAsync>d__);
			return <PlayStartSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039527 RID: 234791 RVA: 0x00D9865C File Offset: 0x00D9685C
		public UniTask PlayCloseSequenceAsync()
		{
			ItemRewardSelectContent.<PlayCloseSequenceAsync>d__31 <PlayCloseSequenceAsync>d__;
			<PlayCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayCloseSequenceAsync>d__.<>4__this = this;
			<PlayCloseSequenceAsync>d__.<>1__state = -1;
			<PlayCloseSequenceAsync>d__.<>t__builder.Start<ItemRewardSelectContent.<PlayCloseSequenceAsync>d__31>(ref <PlayCloseSequenceAsync>d__);
			return <PlayCloseSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0401DF99 RID: 122777
		[Nullable(2)]
		private UiSequencePlayer UiSequencePlayerInstance;

		// Token: 0x0401DF9A RID: 122778
		[Nullable(2)]
		private RoleDescribeComponent RoleDescribeComp;

		// Token: 0x0401DF9B RID: 122779
		private Action OnClickBackButtonCallBack = delegate()
		{
		};

		// Token: 0x0401DF9C RID: 122780
		private Action<int, int> OnSelectItemCallBack = delegate(int _, int __)
		{
		};

		// Token: 0x0401DF9D RID: 122781
		private Action<int, int> OnConfirmButtonCallBack = delegate(int _, int __)
		{
		};

		// Token: 0x0401DF9E RID: 122782
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401DF9F RID: 122783
		[Nullable(2)]
		private ButtonItem ButtonItem;

		// Token: 0x0401DFA0 RID: 122784
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<ItemSelectRewardItem, ItemSelectRewardItemData> Layout;

		// Token: 0x0401DFA1 RID: 122785
		private int CurrentSelectIndex;

		// Token: 0x0401DFA2 RID: 122786
		private int GiftPackageId;

		// Token: 0x0401DFA3 RID: 122787
		private readonly List<int> CurrentRewardList = new List<int>();

		// Token: 0x0401DFA4 RID: 122788
		[Nullable(2)]
		private ResonantChainOptionLimitInfo LimitInfo;
	}
}
