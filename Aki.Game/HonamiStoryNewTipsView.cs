using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020013A0 RID: 5024
public class HonamiStoryNewTipsView : UiTickViewBase
{
	// Token: 0x0600C744 RID: 51012 RVA: 0x003B555E File Offset: 0x003B375E
	[NullableContext(1)]
	public HonamiStoryNewTipsView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600C745 RID: 51013 RVA: 0x003B5568 File Offset: 0x003B3768
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUITexture)),
			new ValueTuple<int, Type>(5, typeof(UUINiagara)),
			new ValueTuple<int, Type>(7, typeof(UUITexture))
		};
	}

	// Token: 0x0600C746 RID: 51014 RVA: 0x003B561C File Offset: 0x003B381C
	private void ApplyGridItem(int itemId)
	{
		CSharpScript.Game.Module.Inventory.ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(itemId);
		PropSmallItemGrid parameters = new PropSmallItemGrid
		{
			Data = itemId,
			ItemConfigId = new int?(itemId),
			IconPath = itemConfigData.Icon
		};
		this.GridItem.Apply<PropSmallItemGrid>(parameters);
	}

	// Token: 0x0600C747 RID: 51015 RVA: 0x003B566C File Offset: 0x003B386C
	private UniTask CreateGridItem()
	{
		HonamiStoryNewTipsView.<CreateGridItem>d__7 <CreateGridItem>d__;
		<CreateGridItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateGridItem>d__.<>4__this = this;
		<CreateGridItem>d__.<>1__state = -1;
		<CreateGridItem>d__.<>t__builder.Start<HonamiStoryNewTipsView.<CreateGridItem>d__7>(ref <CreateGridItem>d__);
		return <CreateGridItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600C748 RID: 51016 RVA: 0x003B56B0 File Offset: 0x003B38B0
	private UniTask CreateNiagaraSystem()
	{
		HonamiStoryNewTipsView.<CreateNiagaraSystem>d__8 <CreateNiagaraSystem>d__;
		<CreateNiagaraSystem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateNiagaraSystem>d__.<>4__this = this;
		<CreateNiagaraSystem>d__.<>1__state = -1;
		<CreateNiagaraSystem>d__.<>t__builder.Start<HonamiStoryNewTipsView.<CreateNiagaraSystem>d__8>(ref <CreateNiagaraSystem>d__);
		return <CreateNiagaraSystem>d__.<>t__builder.Task;
	}

	// Token: 0x0600C749 RID: 51017 RVA: 0x003B56F4 File Offset: 0x003B38F4
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryNewTipsView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryNewTipsView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C74A RID: 51018 RVA: 0x003B5738 File Offset: 0x003B3938
	protected override void OnStart()
	{
		HonamiStoryItemDataBase honamiStoryItemDataBase = this.OpenParam as HonamiStoryItemDataBase;
		if (honamiStoryItemDataBase == null)
		{
			Log.Instance.Error(ELogModule.Item, ELogAuthor.ZJC, "新物品提示错误, 没有物品数据!", default(ReadOnlySpan<ValueTuple<string, object>>));
			base.CloseMe(null);
			return;
		}
		int itemId = honamiStoryItemDataBase.GetItemId();
		CSharpScript.Game.Module.Inventory.ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(itemId);
		if (itemConfigData == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Item;
			ELogAuthor author = ELogAuthor.ZJC;
			string message = "新物品提示错误, 没有物品配置!";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("itemId", itemId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.CloseMe(null);
			return;
		}
		TItemQualityConfig itemQualityByConfig = InventoryConfig.Instance.GetItemQualityByConfig(itemConfigData);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), itemConfigData.Name, Array.Empty<object>());
		HonamiStoryItem? honamiStoryItem = HonamiStoryConfig.Instance.GetHonamiStoryItem(itemId);
		if (honamiStoryItem != null && honamiStoryItem.Value.ItemType == 1)
		{
			HonamiStoryEquipItemData honamiStoryEquipItemData = honamiStoryItemDataBase as HonamiStoryEquipItemData;
			if (honamiStoryEquipItemData == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Item;
				ELogAuthor author2 = ELogAuthor.ZJC;
				string message2 = "新物品提示错误, 插件物品数据类型错误!";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("itemId", itemId);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				base.CloseMe(null);
				return;
			}
			int buffId = honamiStoryEquipItemData.GetBuffTempIdList(false)[0].BuffId;
			HonamiStoryBuffTemp? honamiStoryBuffTemp = HonamiStoryConfig.Instance.GetHonamiStoryBuffTemp(buffId);
			string[] array = honamiStoryBuffTemp.Value.DescSimpleArgs();
			if (array != null && array.Length != 0)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(3), honamiStoryBuffTemp.Value.DescSimple, array);
			}
			else
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(3), honamiStoryBuffTemp.Value.DescSimple, Array.Empty<object>());
			}
		}
		else if (honamiStoryItem != null && honamiStoryItem.Value.ItemType == 2)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), honamiStoryItem.Value.AttributesDescription, Array.Empty<object>());
		}
		base.SetTextureByPath(itemQualityByConfig.TextureAcquireBg, base.GetTexture(4), null, null);
		base.SetTextureByPath(itemQualityByConfig.TextureAcquireFlow, base.GetTexture(7), null, null);
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.LevelSequencePlayer.BindSequenceCloseEvent(delegate(string sequenceName)
		{
			if (sequenceName == "Golden" || sequenceName == "Start01")
			{
				base.CloseMe(null);
			}
		}, false);
		ItemMainType? mainTypeConfig = CSharpScript.Game.Module.Item.ItemConfig.Instance.GetMainTypeConfig((int)itemConfigData.MainTypeId);
		if (!string.IsNullOrEmpty((mainTypeConfig != null) ? mainTypeConfig.GetValueOrDefault().IconFirstAchieve : null))
		{
			base.SetTextureByPath(mainTypeConfig.Value.IconFirstAchieve, base.GetTexture(0), null, null);
		}
		this.ApplyGridItem(itemId);
	}

	// Token: 0x0600C74B RID: 51019 RVA: 0x003B59F0 File Offset: 0x003B3BF0
	protected override void OnAfterShow()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.PlayLevelSequenceByName(this.IsGolden ? "Golden" : "Start01", false, null, false);
		}
		AudioSystem.Instance.PostEvent("play_ui_honamistory_pick_up_normal");
	}

	// Token: 0x0600C74C RID: 51020 RVA: 0x003B5A3D File Offset: 0x003B3C3D
	protected override void OnBeforeDestroy()
	{
		ItemModel.Instance.LastCloseTimeStamp = TimeUtil.Instance.GetServerTimeStamp();
	}

	// Token: 0x04007182 RID: 29058
	[Nullable(2)]
	private SmallItemGrid GridItem;

	// Token: 0x04007183 RID: 29059
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04007184 RID: 29060
	private bool IsGolden;

	// Token: 0x02007648 RID: 30280
	private class ENewItemTipsViewCom
	{
		// Token: 0x04026675 RID: 157301
		public const int MainTypeIconTexture = 0;

		// Token: 0x04026676 RID: 157302
		public const int ItemNameText = 1;

		// Token: 0x04026677 RID: 157303
		public const int GridItem = 2;

		// Token: 0x04026678 RID: 157304
		public const int ItemDescribeText = 3;

		// Token: 0x04026679 RID: 157305
		public const int QualityTexture = 4;

		// Token: 0x0402667A RID: 157306
		public const int QualityNiagara = 5;

		// Token: 0x0402667B RID: 157307
		public const int FlowTexture = 7;
	}
}
