using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Item
{
	// Token: 0x020047F3 RID: 18419
	[NullableContext(1)]
	[Nullable(0)]
	public class ItemRewardSelectView : UiViewBase
	{
		// Token: 0x0602E419 RID: 189465 RVA: 0x00CE68A5 File Offset: 0x00CE4AA5
		public ItemRewardSelectView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602E41A RID: 189466 RVA: 0x00CE68C4 File Offset: 0x00CE4AC4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602E41B RID: 189467 RVA: 0x00CE6930 File Offset: 0x00CE4B30
		protected override UniTask OnBeforeStartAsync()
		{
			ItemRewardSelectView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ItemRewardSelectView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E41C RID: 189468 RVA: 0x00CE6974 File Offset: 0x00CE4B74
		private UniTask InitBgPrefabs()
		{
			ItemRewardSelectView.<InitBgPrefabs>d__10 <InitBgPrefabs>d__;
			<InitBgPrefabs>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBgPrefabs>d__.<>4__this = this;
			<InitBgPrefabs>d__.<>1__state = -1;
			<InitBgPrefabs>d__.<>t__builder.Start<ItemRewardSelectView.<InitBgPrefabs>d__10>(ref <InitBgPrefabs>d__);
			return <InitBgPrefabs>d__.<>t__builder.Task;
		}

		// Token: 0x0602E41D RID: 189469 RVA: 0x00CE69B8 File Offset: 0x00CE4BB8
		private UniTask LoadBgPrefabAsync(int itemId, string path)
		{
			ItemRewardSelectView.<LoadBgPrefabAsync>d__11 <LoadBgPrefabAsync>d__;
			<LoadBgPrefabAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadBgPrefabAsync>d__.<>4__this = this;
			<LoadBgPrefabAsync>d__.itemId = itemId;
			<LoadBgPrefabAsync>d__.path = path;
			<LoadBgPrefabAsync>d__.<>1__state = -1;
			<LoadBgPrefabAsync>d__.<>t__builder.Start<ItemRewardSelectView.<LoadBgPrefabAsync>d__11>(ref <LoadBgPrefabAsync>d__);
			return <LoadBgPrefabAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E41E RID: 189470 RVA: 0x00CE6A0B File Offset: 0x00CE4C0B
		private void OnClickBackButton()
		{
			UiManager.Instance.CloseView(EUiViewName.ItemRewardSelectView, delegate(bool _)
			{
				int accumulateSourceId = this.ItemData.AccumulateSourceId;
				if (accumulateSourceId > 0)
				{
					UiManager.Instance.OpenView(EUiViewName.GachaAccumulateBonusView, accumulateSourceId, null);
				}
			});
		}

		// Token: 0x0602E41F RID: 189471 RVA: 0x00CE6A28 File Offset: 0x00CE4C28
		private void OnConfirmButton(int index, int itemId)
		{
			int[] resonantItemRoleId = RoleModel.Instance.GetResonantItemRoleId(itemId);
			if (resonantItemRoleId == null || resonantItemRoleId.Length == 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Inventory;
				ELogAuthor author = ELogAuthor.YZY;
				string message = "找不到角色配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("itemId", itemId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (!this.CheckSelectItemIfResonant(itemId))
			{
				this.DoSelectItemCallBackAndClose(index, itemId);
				return;
			}
			if (RoleModel.Instance.GetRoleLeftResonantCountWithInventoryItem(resonantItemRoleId[0]) <= 0)
			{
				ItemConvertTipsParam itemConvertTipsParam = new ItemConvertTipsParam();
				List<TItem> resonantItemConvertItemResult = RoleModel.Instance.GetResonantItemConvertItemResult(itemId);
				TItem value = new TItem(new InventoryDefine.GetItemData(itemId, 0), 1);
				TItem titem = resonantItemConvertItemResult[0];
				itemConvertTipsParam.BeforeItemData = new TItem?(value);
				itemConvertTipsParam.AfterItemData = new TItem?(titem);
				string localTextNew = ConfigMultiTextLang.GetLocalTextNew(InventoryConfig.Instance.GetItemConfigData(titem.ItemData.ItemId).Name, null);
				itemConvertTipsParam.ShowText = string.Format(ConfigMultiTextLang.GetLocalTextNew("WavebandChooseTest_1", null), localTextNew);
				itemConvertTipsParam.OnConfirmCallBack = delegate()
				{
					this.DoSelectItemCallBackAndClose(index, itemId);
				};
				UiManager.Instance.OpenView(EUiViewName.ItemConvertTipsView, itemConvertTipsParam, null);
				return;
			}
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ResonantItemConvertConfirm);
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				this.DoSelectItemCallBackAndClose(index, itemId);
			};
			ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(itemId);
			if (itemConfigData != null)
			{
				string localTextNew2 = ConfigMultiTextLang.GetLocalTextNew(itemConfigData.Name, null);
				confirmBoxDataNew.SetTextArgs(new string[]
				{
					localTextNew2
				});
			}
			UiManager.Instance.OpenView(EUiViewName.ConfirmBoxView, confirmBoxDataNew, null);
		}

		// Token: 0x0602E420 RID: 189472 RVA: 0x00CE6BEA File Offset: 0x00CE4DEA
		private void DoSelectItemCallBackAndClose(int index, int itemId)
		{
			Action<int, int> onSelectItemCallBack = this.ItemData.OnSelectItemCallBack;
			if (onSelectItemCallBack != null)
			{
				onSelectItemCallBack(index, itemId);
			}
			base.CloseMe(null);
		}

		// Token: 0x0602E421 RID: 189473 RVA: 0x00CE6C0C File Offset: 0x00CE4E0C
		private bool CheckSelectItemIfResonant(int itemId)
		{
			ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(itemId);
			return itemConfigData != null && itemConfigData.ShowTypes != null && Array.IndexOf<int>(itemConfigData.ShowTypes, 30) >= 0;
		}

		// Token: 0x0602E422 RID: 189474 RVA: 0x00CE6C45 File Offset: 0x00CE4E45
		private void OnSelectItem(int itemId, int index)
		{
			this.RefreshBgRoot(itemId).Forget();
			this.CurrentSelectItemId = itemId;
		}

		// Token: 0x0602E423 RID: 189475 RVA: 0x00CE6C5A File Offset: 0x00CE4E5A
		protected override void OnBeforeShow()
		{
			this.ItemRewardSelectContent.Refresh(this.ItemData.GiftPackageId);
		}

		// Token: 0x0602E424 RID: 189476 RVA: 0x00CE6C74 File Offset: 0x00CE4E74
		private UniTask RefreshBgRoot(int itemId)
		{
			ItemRewardSelectView.<RefreshBgRoot>d__18 <RefreshBgRoot>d__;
			<RefreshBgRoot>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshBgRoot>d__.<>4__this = this;
			<RefreshBgRoot>d__.itemId = itemId;
			<RefreshBgRoot>d__.<>1__state = -1;
			<RefreshBgRoot>d__.<>t__builder.Start<ItemRewardSelectView.<RefreshBgRoot>d__18>(ref <RefreshBgRoot>d__);
			return <RefreshBgRoot>d__.<>t__builder.Task;
		}

		// Token: 0x0602E425 RID: 189477 RVA: 0x00CE6CC0 File Offset: 0x00CE4EC0
		protected override UniTask OnPlayingStartSequenceAsync()
		{
			ItemRewardSelectView.<OnPlayingStartSequenceAsync>d__19 <OnPlayingStartSequenceAsync>d__;
			<OnPlayingStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPlayingStartSequenceAsync>d__.<>4__this = this;
			<OnPlayingStartSequenceAsync>d__.<>1__state = -1;
			<OnPlayingStartSequenceAsync>d__.<>t__builder.Start<ItemRewardSelectView.<OnPlayingStartSequenceAsync>d__19>(ref <OnPlayingStartSequenceAsync>d__);
			return <OnPlayingStartSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E426 RID: 189478 RVA: 0x00CE6D04 File Offset: 0x00CE4F04
		protected override UniTask OnPlayingCloseSequenceAsync()
		{
			ItemRewardSelectView.<OnPlayingCloseSequenceAsync>d__20 <OnPlayingCloseSequenceAsync>d__;
			<OnPlayingCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPlayingCloseSequenceAsync>d__.<>4__this = this;
			<OnPlayingCloseSequenceAsync>d__.<>1__state = -1;
			<OnPlayingCloseSequenceAsync>d__.<>t__builder.Start<ItemRewardSelectView.<OnPlayingCloseSequenceAsync>d__20>(ref <OnPlayingCloseSequenceAsync>d__);
			return <OnPlayingCloseSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x04018A1F RID: 100895
		[Nullable(2)]
		private ItemRewardSelectViewOpenParam ItemData;

		// Token: 0x04018A20 RID: 100896
		[Nullable(2)]
		private ItemRewardSelectContent ItemRewardSelectContent;

		// Token: 0x04018A21 RID: 100897
		private int CurrentSelectItemId;

		// Token: 0x04018A22 RID: 100898
		private readonly Dictionary<int, UUIItem> RootPrefabMap = new Dictionary<int, UUIItem>();

		// Token: 0x04018A23 RID: 100899
		private readonly Dictionary<int, UiSequencePlayer> BgSequencePlayerMap = new Dictionary<int, UiSequencePlayer>();

		// Token: 0x04018A24 RID: 100900
		[Nullable(2)]
		private ResonantChainOptionLimitInfo LimitInfo;

		// Token: 0x04018A25 RID: 100901
		[Nullable(2)]
		private UUIItem CurrentShowItem;
	}
}
