using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x0200581C RID: 22556
	[NullableContext(1)]
	[Nullable(0)]
	public class ItemRewardSelectView : UiViewBase
	{
		// Token: 0x06039505 RID: 234757 RVA: 0x00D97A14 File Offset: 0x00D95C14
		public ItemRewardSelectView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06039506 RID: 234758 RVA: 0x00D97A34 File Offset: 0x00D95C34
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

		// Token: 0x06039507 RID: 234759 RVA: 0x00D97AA0 File Offset: 0x00D95CA0
		protected override UniTask OnBeforeStartAsync()
		{
			ItemRewardSelectView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ItemRewardSelectView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039508 RID: 234760 RVA: 0x00D97AE4 File Offset: 0x00D95CE4
		private UniTask InitBgPrefabs()
		{
			ItemRewardSelectView.<InitBgPrefabs>d__10 <InitBgPrefabs>d__;
			<InitBgPrefabs>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBgPrefabs>d__.<>4__this = this;
			<InitBgPrefabs>d__.<>1__state = -1;
			<InitBgPrefabs>d__.<>t__builder.Start<ItemRewardSelectView.<InitBgPrefabs>d__10>(ref <InitBgPrefabs>d__);
			return <InitBgPrefabs>d__.<>t__builder.Task;
		}

		// Token: 0x06039509 RID: 234761 RVA: 0x00D97B28 File Offset: 0x00D95D28
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

		// Token: 0x0603950A RID: 234762 RVA: 0x00D97B7B File Offset: 0x00D95D7B
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

		// Token: 0x0603950B RID: 234763 RVA: 0x00D97B98 File Offset: 0x00D95D98
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

		// Token: 0x0603950C RID: 234764 RVA: 0x00D97D5A File Offset: 0x00D95F5A
		private void DoSelectItemCallBackAndClose(int index, int itemId)
		{
			Action<int, int> onSelectItemCallBack = this.ItemData.OnSelectItemCallBack;
			if (onSelectItemCallBack != null)
			{
				onSelectItemCallBack(index, itemId);
			}
			base.CloseMe(null);
		}

		// Token: 0x0603950D RID: 234765 RVA: 0x00D97D7C File Offset: 0x00D95F7C
		private bool CheckSelectItemIfResonant(int itemId)
		{
			ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(itemId);
			if (itemConfigData == null)
			{
				return false;
			}
			int[] showTypes = itemConfigData.ShowTypes;
			return showTypes != null && showTypes.Contains(30);
		}

		// Token: 0x0603950E RID: 234766 RVA: 0x00D97DB6 File Offset: 0x00D95FB6
		private void OnSelectItem(int itemId, int index)
		{
			this.RefreshBgRoot(itemId).Forget();
			this.CurrentSelectItemId = itemId;
		}

		// Token: 0x0603950F RID: 234767 RVA: 0x00D97DCB File Offset: 0x00D95FCB
		protected override void OnBeforeShow()
		{
			this.ItemRewardSelectContent.Refresh(this.ItemData.GiftPackageId);
		}

		// Token: 0x06039510 RID: 234768 RVA: 0x00D97DE4 File Offset: 0x00D95FE4
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

		// Token: 0x06039511 RID: 234769 RVA: 0x00D97E30 File Offset: 0x00D96030
		protected override UniTask OnPlayingStartSequenceAsync()
		{
			ItemRewardSelectView.<OnPlayingStartSequenceAsync>d__19 <OnPlayingStartSequenceAsync>d__;
			<OnPlayingStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPlayingStartSequenceAsync>d__.<>4__this = this;
			<OnPlayingStartSequenceAsync>d__.<>1__state = -1;
			<OnPlayingStartSequenceAsync>d__.<>t__builder.Start<ItemRewardSelectView.<OnPlayingStartSequenceAsync>d__19>(ref <OnPlayingStartSequenceAsync>d__);
			return <OnPlayingStartSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039512 RID: 234770 RVA: 0x00D97E74 File Offset: 0x00D96074
		protected override UniTask OnPlayingCloseSequenceAsync()
		{
			ItemRewardSelectView.<OnPlayingCloseSequenceAsync>d__20 <OnPlayingCloseSequenceAsync>d__;
			<OnPlayingCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPlayingCloseSequenceAsync>d__.<>4__this = this;
			<OnPlayingCloseSequenceAsync>d__.<>1__state = -1;
			<OnPlayingCloseSequenceAsync>d__.<>t__builder.Start<ItemRewardSelectView.<OnPlayingCloseSequenceAsync>d__20>(ref <OnPlayingCloseSequenceAsync>d__);
			return <OnPlayingCloseSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0401DF88 RID: 122760
		[Nullable(2)]
		private ItemRewardSelectViewOpenParam ItemData;

		// Token: 0x0401DF89 RID: 122761
		[Nullable(2)]
		private ItemRewardSelectContent ItemRewardSelectContent;

		// Token: 0x0401DF8A RID: 122762
		private int CurrentSelectItemId;

		// Token: 0x0401DF8B RID: 122763
		private readonly Dictionary<int, UUIItem> RootPrefabMap = new Dictionary<int, UUIItem>();

		// Token: 0x0401DF8C RID: 122764
		private readonly Dictionary<int, UiSequencePlayer> BgSequencePlayerMap = new Dictionary<int, UiSequencePlayer>();

		// Token: 0x0401DF8D RID: 122765
		[Nullable(2)]
		private ResonantChainOptionLimitInfo LimitInfo;

		// Token: 0x0401DF8E RID: 122766
		[Nullable(2)]
		private UUIItem CurrentShowItem;
	}
}
