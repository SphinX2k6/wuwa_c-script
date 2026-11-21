using System;
using System.Collections.Generic;
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
	// Token: 0x020047F5 RID: 18421
	[NullableContext(1)]
	[Nullable(0)]
	internal class ItemRewardSelectContent : UiPanelBase
	{
		// Token: 0x0602E428 RID: 189480 RVA: 0x00CE6D7B File Offset: 0x00CE4F7B
		public void SetOnClickBackButtonCallBack(Action callback)
		{
			this.OnClickBackButtonCallBack = callback;
		}

		// Token: 0x0602E429 RID: 189481 RVA: 0x00CE6D84 File Offset: 0x00CE4F84
		public void SetOnSelectItemCallBack(Action<int, int> callback)
		{
			this.OnSelectItemCallBack = callback;
		}

		// Token: 0x0602E42A RID: 189482 RVA: 0x00CE6D8D File Offset: 0x00CE4F8D
		public void SetOnConfirmButtonCallBack(Action<int, int> callback)
		{
			this.OnConfirmButtonCallBack = callback;
		}

		// Token: 0x0602E42B RID: 189483 RVA: 0x00CE6D98 File Offset: 0x00CE4F98
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

		// Token: 0x0602E42C RID: 189484 RVA: 0x00CE6EEC File Offset: 0x00CE50EC
		protected override UniTask OnBeforeStartAsync()
		{
			ItemRewardSelectContent.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ItemRewardSelectContent.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E42D RID: 189485 RVA: 0x00CE6F30 File Offset: 0x00CE5130
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

		// Token: 0x0602E42E RID: 189486 RVA: 0x00CE6FD8 File Offset: 0x00CE51D8
		private void OnClickConfirmButton(int _)
		{
			this.OnConfirmButtonCallBack(this.CurrentSelectIndex, this.CurrentRewardList[this.CurrentSelectIndex]);
		}

		// Token: 0x0602E42F RID: 189487 RVA: 0x00CE6FFC File Offset: 0x00CE51FC
		private ItemSelectRewardItem OnCreateRewardItem()
		{
			return new ItemSelectRewardItem();
		}

		// Token: 0x0602E430 RID: 189488 RVA: 0x00CE7003 File Offset: 0x00CE5203
		private void OnClickToggle(int index)
		{
			this.CurrentSelectIndex = index;
			this.Refresh(this.GiftPackageId);
		}

		// Token: 0x0602E431 RID: 189489 RVA: 0x00CE7018 File Offset: 0x00CE5218
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

		// Token: 0x0602E432 RID: 189490 RVA: 0x00CE704C File Offset: 0x00CE524C
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

		// Token: 0x0602E433 RID: 189491 RVA: 0x00CE70C4 File Offset: 0x00CE52C4
		private void RefreshResonantItem()
		{
			int num = this.CurrentRewardList[this.CurrentSelectIndex];
			ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(num);
			if (itemConfigData == null)
			{
				return;
			}
			if (itemConfigData.ShowTypes == null || Array.IndexOf<int>(itemConfigData.ShowTypes, 30) < 0)
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

		// Token: 0x0602E434 RID: 189492 RVA: 0x00CE71B4 File Offset: 0x00CE53B4
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

		// Token: 0x0602E435 RID: 189493 RVA: 0x00CE7225 File Offset: 0x00CE5425
		[NullableContext(2)]
		public void SetLimitInfo(ResonantChainOptionLimitInfo limitInfo)
		{
			this.LimitInfo = limitInfo;
		}

		// Token: 0x0602E436 RID: 189494 RVA: 0x00CE7230 File Offset: 0x00CE5430
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

		// Token: 0x0602E437 RID: 189495 RVA: 0x00CE73D4 File Offset: 0x00CE55D4
		private void RefreshRoleSpine()
		{
			int itemId = this.CurrentRewardList[this.CurrentSelectIndex];
			USpineSkeletonAnimationComponent spine = base.GetSpine(7);
			SelectRoleItemPerformance? selectRoleItemPerformance = GachaAccumulateConfig.Instance.GetSelectRoleItemPerformance(itemId);
			string spineAtlasPath = selectRoleItemPerformance.Value.SpineAtlasPath;
			string spineDataPath = selectRoleItemPerformance.Value.SpineDataPath;
			base.SetSpineAssetByPath(spineAtlasPath, spineDataPath, spine).Forget();
		}

		// Token: 0x0602E438 RID: 189496 RVA: 0x00CE743C File Offset: 0x00CE563C
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

		// Token: 0x0602E439 RID: 189497 RVA: 0x00CE747B File Offset: 0x00CE567B
		private void PlaySelectSequence()
		{
			this.UiSequencePlayerInstance.PlaySequencePurely("SwitchIn", false, false);
			this.UiSequencePlayerInstance.PlaySequencePurely("SwitchOut", false, false);
		}

		// Token: 0x0602E43A RID: 189498 RVA: 0x00CE74A4 File Offset: 0x00CE56A4
		public UniTask PlayStartSequenceAsync()
		{
			ItemRewardSelectContent.<PlayStartSequenceAsync>d__30 <PlayStartSequenceAsync>d__;
			<PlayStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayStartSequenceAsync>d__.<>4__this = this;
			<PlayStartSequenceAsync>d__.<>1__state = -1;
			<PlayStartSequenceAsync>d__.<>t__builder.Start<ItemRewardSelectContent.<PlayStartSequenceAsync>d__30>(ref <PlayStartSequenceAsync>d__);
			return <PlayStartSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E43B RID: 189499 RVA: 0x00CE74E8 File Offset: 0x00CE56E8
		public UniTask PlayCloseSequenceAsync()
		{
			ItemRewardSelectContent.<PlayCloseSequenceAsync>d__31 <PlayCloseSequenceAsync>d__;
			<PlayCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayCloseSequenceAsync>d__.<>4__this = this;
			<PlayCloseSequenceAsync>d__.<>1__state = -1;
			<PlayCloseSequenceAsync>d__.<>t__builder.Start<ItemRewardSelectContent.<PlayCloseSequenceAsync>d__31>(ref <PlayCloseSequenceAsync>d__);
			return <PlayCloseSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x04018A30 RID: 100912
		[Nullable(2)]
		private UiSequencePlayer UiSequencePlayerInstance;

		// Token: 0x04018A31 RID: 100913
		[Nullable(2)]
		private RoleDescribeComponent RoleDescribeComp;

		// Token: 0x04018A32 RID: 100914
		private Action OnClickBackButtonCallBack = delegate()
		{
		};

		// Token: 0x04018A33 RID: 100915
		private Action<int, int> OnSelectItemCallBack = delegate(int _, int __)
		{
		};

		// Token: 0x04018A34 RID: 100916
		private Action<int, int> OnConfirmButtonCallBack = delegate(int _, int __)
		{
		};

		// Token: 0x04018A35 RID: 100917
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x04018A36 RID: 100918
		[Nullable(2)]
		private ButtonItem ButtonItem;

		// Token: 0x04018A37 RID: 100919
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<ItemSelectRewardItem, ItemSelectRewardItemData> Layout;

		// Token: 0x04018A38 RID: 100920
		private int CurrentSelectIndex;

		// Token: 0x04018A39 RID: 100921
		private int GiftPackageId;

		// Token: 0x04018A3A RID: 100922
		private readonly List<int> CurrentRewardList = new List<int>();

		// Token: 0x04018A3B RID: 100923
		[Nullable(2)]
		private ResonantChainOptionLimitInfo LimitInfo;
	}
}
