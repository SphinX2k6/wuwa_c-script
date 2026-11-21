using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.PhantomInteract;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roulette.View
{
	// Token: 0x02003C48 RID: 15432
	[NullableContext(2)]
	[Nullable(0)]
	public class RouletteAssemblyTips : UiPanelBase
	{
		// Token: 0x06027874 RID: 161908 RVA: 0x00B16B4C File Offset: 0x00B14D4C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 15;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OpenHelpView));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06027875 RID: 161909 RVA: 0x00B16DA8 File Offset: 0x00B14FA8
		protected override UniTask OnBeforeStartAsync()
		{
			RouletteAssemblyTips.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RouletteAssemblyTips.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06027876 RID: 161910 RVA: 0x00B16DEC File Offset: 0x00B14FEC
		protected override void OnStart()
		{
			UUIItem item = base.GetItem(9);
			this.TipsGetWayPanel = new TipsGetWayPanel(item);
		}

		// Token: 0x06027877 RID: 161911 RVA: 0x00B16E10 File Offset: 0x00B15010
		protected override void OnBeforeDestroy()
		{
			if (this.TipsGetWayPanel != null)
			{
				this.TipsGetWayPanel.Destroy(null);
				this.TipsGetWayPanel = null;
			}
			if (this.ItemPanel1 != null)
			{
				this.ItemPanel1.Destroy(null);
				this.ItemPanel1 = null;
			}
			if (this.ItemPanel2 != null)
			{
				this.ItemPanel2.Destroy(null);
				this.ItemPanel2 = null;
			}
		}

		// Token: 0x06027878 RID: 161912 RVA: 0x00B16E70 File Offset: 0x00B15070
		[NullableContext(1)]
		public void Refresh(AssemblyTipsData data)
		{
			this.Data = data;
			this.RefreshTitle();
			this.RefreshHelpBtn();
			this.RefreshBg();
			this.RefreshDescription();
			this.RefreshIcon();
			this.RefreshGetWay();
			this.RefreshSetItem();
			this.RefreshNeedItemPanel();
			this.RefreshAuthorizationItemPanel();
			this.RefreshPhantomInteractEquipmentPanel();
		}

		// Token: 0x06027879 RID: 161913 RVA: 0x00B16EC0 File Offset: 0x00B150C0
		private void RefreshTitle()
		{
			base.GetText(3).ShowTextNew(this.Data.Title);
		}

		// Token: 0x0602787A RID: 161914 RVA: 0x00B16EDC File Offset: 0x00B150DC
		private void OpenHelpView()
		{
			int helpId = this.Data.HelpId;
			if (helpId != 0)
			{
				HelpController.Instance.OpenHelpById(helpId);
			}
		}

		// Token: 0x0602787B RID: 161915 RVA: 0x00B16F04 File Offset: 0x00B15104
		private void RefreshHelpBtn()
		{
			int helpId = this.Data.HelpId;
			base.GetButton(4).RootUIComp.Get().SetUIActive(helpId != 0);
		}

		// Token: 0x0602787C RID: 161916 RVA: 0x00B16F3C File Offset: 0x00B1513C
		private void RefreshBg()
		{
			UUITexture texture = base.GetTexture(0);
			base.SetTextureByPath(InventoryConfig.Instance.GetItemQualityConfig((int)this.Data.BgQuality).Value.RouletteTipsQualityTexPath, texture, null, null);
		}

		// Token: 0x0602787D RID: 161917 RVA: 0x00B16F88 File Offset: 0x00B15188
		private void RefreshDescription()
		{
			bool flag = this.Data.TextMain != "" && this.Data.TextMain != null;
			base.GetText(5).SetUIActive(flag);
			if (flag)
			{
				base.GetText(5).ShowTextNew(this.Data.TextMain);
			}
			bool flag2 = this.Data.TextSub != "" && this.Data.TextSub != null;
			base.GetItem(6).SetUIActive(flag2);
			if (flag2)
			{
				base.GetText(7).ShowTextNew(this.Data.TextSub);
			}
		}

		// Token: 0x0602787E RID: 161918 RVA: 0x00B17038 File Offset: 0x00B15238
		private void RefreshIcon()
		{
			UUITexture textureIcon = base.GetTexture(2);
			textureIcon.SetUIActive(false);
			UUISprite spriteIcon = base.GetSprite(1);
			spriteIcon.SetUIActive(false);
			if (this.Data.GridType == ERouletteGridType.EquipItem)
			{
				base.SetItemIcon(textureIcon, this.Data.GridId, null, delegate(bool _)
				{
					textureIcon.SetUIActive(true);
				});
				return;
			}
			if (this.Data.IconPath == "")
			{
				return;
			}
			if (this.Data.IsIconTexture)
			{
				base.SetTextureByPath(this.Data.IconPath, textureIcon, null, delegate(bool _)
				{
					textureIcon.SetUIActive(true);
				});
				return;
			}
			this.SetSpriteByPath(this.Data.IconPath, spriteIcon, false, null, delegate(bool _)
			{
				spriteIcon.SetUIActive(true);
			});
		}

		// Token: 0x0602787F RID: 161919 RVA: 0x00B17138 File Offset: 0x00B15338
		private void RefreshGetWay()
		{
			List<IGetWayItemData> getWayData = this.Data.GetWayData;
			this.TipsGetWayPanel.SetActive(getWayData.Count > 0);
			if (getWayData != null)
			{
				this.TipsGetWayPanel.Refresh(getWayData.ToArray());
			}
		}

		// Token: 0x06027880 RID: 161920 RVA: 0x00B1717C File Offset: 0x00B1537C
		private void RefreshSetItem()
		{
			int item = this.Data.CanSetItemNum.Item1;
			int item2 = this.Data.CanSetItemNum.Item2;
			base.GetItem(12).SetUIActive(item2 != 0);
			if (item2 == 0)
			{
				return;
			}
			string item3 = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("Text_CollectProgress_Text", null), new string[]
			{
				item.ToString(),
				item2.ToString()
			});
			LguiUtil.Instance.SetLocalTextNew(base.GetText(13), "Explore_Count", new <>z__ReadOnlySingleElementList<object>(item3));
		}

		// Token: 0x06027881 RID: 161921 RVA: 0x00B17208 File Offset: 0x00B15408
		private void RefreshNeedItemPanel()
		{
			Dictionary<int, int> needItemMap = this.Data.NeedItemMap;
			this.ItemPanel1.SetActive(needItemMap.Count != 0);
			if (needItemMap.Count == 0)
			{
				return;
			}
			List<ItemRefreshData> list = new List<ItemRefreshData>();
			foreach (KeyValuePair<int, int> keyValuePair in needItemMap)
			{
				int key = keyValuePair.Key;
				int value = keyValuePair.Value;
				int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(key, 0);
				string text = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("Text_CollectProgress_Text", null), new string[]
				{
					itemCountByConfigId.ToString(),
					value.ToString()
				});
				ItemRefreshData item = new ItemRefreshData
				{
					ItemId = key,
					NeedLock = false,
					Text = text
				};
				list.Add(item);
			}
			this.ItemPanel1.RefreshItemPanel(list);
		}

		// Token: 0x06027882 RID: 161922 RVA: 0x00B17300 File Offset: 0x00B15500
		private void RefreshAuthorizationItemPanel()
		{
			List<int> authorization = this.Data.Authorization;
			this.ItemPanel2.SetActive(authorization.Count > 0);
			if (authorization.Count == 0)
			{
				return;
			}
			List<ItemRefreshData> list = new List<ItemRefreshData>();
			foreach (int num in authorization)
			{
				int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(num, 0);
				ItemRefreshData item = new ItemRefreshData
				{
					ItemId = num,
					NeedLock = (itemCountByConfigId <= 0)
				};
				list.Add(item);
			}
			this.ItemPanel2.RefreshItemPanel(list);
		}

		// Token: 0x06027883 RID: 161923 RVA: 0x00B173B4 File Offset: 0x00B155B4
		public void RefreshPhantomInteractEquipmentPanel()
		{
			AssemblyTipsData data = this.Data;
			if (data == null || !data.ShowPhantomInteractEquipment)
			{
				this.PhantomInteractRouletteTipsPanel.SetUiActive(false);
				return;
			}
			this.PhantomInteractRouletteTipsPanel.SetUiActive(true);
			this.PhantomInteractRouletteTipsPanel.Refresh();
		}

		// Token: 0x04015901 RID: 88321
		private AssemblyTipsData Data;

		// Token: 0x04015902 RID: 88322
		private TipsGetWayPanel TipsGetWayPanel;

		// Token: 0x04015903 RID: 88323
		private RouletteTipsItemPanel ItemPanel1;

		// Token: 0x04015904 RID: 88324
		private RouletteTipsItemPanel ItemPanel2;

		// Token: 0x04015905 RID: 88325
		private PhantomInteractRouletteTipsPanel PhantomInteractRouletteTipsPanel;
	}
}
