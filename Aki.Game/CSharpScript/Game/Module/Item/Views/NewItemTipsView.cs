using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Item.Views
{
	// Token: 0x0200582D RID: 22573
	public class NewItemTipsView : UiTickViewBase
	{
		// Token: 0x06039590 RID: 234896 RVA: 0x00D99C57 File Offset: 0x00D97E57
		[NullableContext(1)]
		public NewItemTipsView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06039591 RID: 234897 RVA: 0x00D99C60 File Offset: 0x00D97E60
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

		// Token: 0x06039592 RID: 234898 RVA: 0x00D99D14 File Offset: 0x00D97F14
		private UniTask CreateGridItem()
		{
			NewItemTipsView.<CreateGridItem>d__6 <CreateGridItem>d__;
			<CreateGridItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateGridItem>d__.<>4__this = this;
			<CreateGridItem>d__.<>1__state = -1;
			<CreateGridItem>d__.<>t__builder.Start<NewItemTipsView.<CreateGridItem>d__6>(ref <CreateGridItem>d__);
			return <CreateGridItem>d__.<>t__builder.Task;
		}

		// Token: 0x06039593 RID: 234899 RVA: 0x00D99D58 File Offset: 0x00D97F58
		private void ApplyGridItem(int itemId)
		{
			ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(itemId);
			PropSmallItemGrid parameters = new PropSmallItemGrid
			{
				Data = itemId,
				ItemConfigId = new int?(itemId),
				IconPath = itemConfigData.Icon
			};
			this.GridItem.Apply<PropSmallItemGrid>(parameters);
		}

		// Token: 0x06039594 RID: 234900 RVA: 0x00D99DA8 File Offset: 0x00D97FA8
		private UniTask CreateNiagaraSystem()
		{
			NewItemTipsView.<CreateNiagaraSystem>d__8 <CreateNiagaraSystem>d__;
			<CreateNiagaraSystem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateNiagaraSystem>d__.<>4__this = this;
			<CreateNiagaraSystem>d__.<>1__state = -1;
			<CreateNiagaraSystem>d__.<>t__builder.Start<NewItemTipsView.<CreateNiagaraSystem>d__8>(ref <CreateNiagaraSystem>d__);
			return <CreateNiagaraSystem>d__.<>t__builder.Task;
		}

		// Token: 0x06039595 RID: 234901 RVA: 0x00D99DEC File Offset: 0x00D97FEC
		protected override UniTask OnBeforeStartAsync()
		{
			NewItemTipsView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<NewItemTipsView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039596 RID: 234902 RVA: 0x00D99E30 File Offset: 0x00D98030
		protected override void OnStart()
		{
			object openParam = this.OpenParam;
			int num2;
			if (openParam is int)
			{
				int num = (int)openParam;
				num2 = num;
			}
			else
			{
				num2 = 0;
			}
			int num3 = num2;
			if (num3 == 0)
			{
				Log.Instance.Error(ELogModule.Item, ELogAuthor.ZJC, "新物品提示错误, 没有物品id!", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.CloseMe(null);
				return;
			}
			ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(num3);
			if (itemConfigData == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Item;
				ELogAuthor author = ELogAuthor.ZJC;
				string message = "新物品提示错误, 没有物品配置!";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("itemId", num3);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				base.CloseMe(null);
				return;
			}
			TItemQualityConfig itemQualityByConfig = InventoryConfig.Instance.GetItemQualityByConfig(itemConfigData);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), itemConfigData.Name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), itemConfigData.ObtainedShowDescription, Array.Empty<object>());
			this.RefreshQualityTexture(itemQualityByConfig.TextureAcquireBg, itemQualityByConfig.TextureAcquireFlow);
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.LevelSequencePlayer.BindSequenceCloseEvent(delegate(string sequenceName)
			{
				if (sequenceName == "Golden".ToString() || sequenceName == "Start01".ToString())
				{
					base.CloseMe(null);
				}
			}, false);
			ItemMainType? mainTypeConfig = ItemConfig.Instance.GetMainTypeConfig((int)itemConfigData.MainTypeId);
			if (mainTypeConfig != null && !string.IsNullOrEmpty(mainTypeConfig.Value.IconFirstAchieve))
			{
				base.SetTextureByPath(mainTypeConfig.Value.IconFirstAchieve, base.GetTexture(0), null, null);
			}
			this.ApplyGridItem(num3);
		}

		// Token: 0x06039597 RID: 234903 RVA: 0x00D99FA8 File Offset: 0x00D981A8
		[NullableContext(1)]
		private void RefreshQualityTexture(string bgPath, string flowPath)
		{
			base.SetTextureByPath(bgPath, base.GetTexture(4), null, null);
			base.SetTextureByPath(flowPath, base.GetTexture(7), null, null);
		}

		// Token: 0x06039598 RID: 234904 RVA: 0x00D99FE8 File Offset: 0x00D981E8
		protected override void OnAfterShow()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayLevelSequenceByName(this.IsGolden ? "Golden" : "Start01", false, null, false);
		}

		// Token: 0x06039599 RID: 234905 RVA: 0x00D9A024 File Offset: 0x00D98224
		protected override void OnBeforeDestroy()
		{
			ItemModel.Instance.LastCloseTimeStamp = TimeUtil.Instance.GetServerTimeStamp();
		}

		// Token: 0x0401DFE0 RID: 122848
		[Nullable(2)]
		protected SmallItemGrid GridItem;

		// Token: 0x0401DFE1 RID: 122849
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401DFE2 RID: 122850
		private bool IsGolden;

		// Token: 0x0200BA2D RID: 47661
		private class ENewItemTipsViewCom
		{
			// Token: 0x0403844F RID: 230479
			public const int MainTypeIconTexture = 0;

			// Token: 0x04038450 RID: 230480
			public const int ItemNameText = 1;

			// Token: 0x04038451 RID: 230481
			public const int GridItem = 2;

			// Token: 0x04038452 RID: 230482
			public const int ItemDescribeText = 3;

			// Token: 0x04038453 RID: 230483
			public const int QualityTexture = 4;

			// Token: 0x04038454 RID: 230484
			public const int QualityNiagara = 5;

			// Token: 0x04038455 RID: 230485
			public const int FlowTexture = 7;
		}
	}
}
