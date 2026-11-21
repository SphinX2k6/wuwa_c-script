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
	// Token: 0x02004804 RID: 18436
	public class NewItemTipsView : UiTickViewBase
	{
		// Token: 0x0602E4A4 RID: 189604 RVA: 0x00CE8AEB File Offset: 0x00CE6CEB
		[NullableContext(1)]
		public NewItemTipsView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602E4A5 RID: 189605 RVA: 0x00CE8AF4 File Offset: 0x00CE6CF4
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

		// Token: 0x0602E4A6 RID: 189606 RVA: 0x00CE8BA8 File Offset: 0x00CE6DA8
		private UniTask CreateGridItem()
		{
			NewItemTipsView.<CreateGridItem>d__6 <CreateGridItem>d__;
			<CreateGridItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateGridItem>d__.<>4__this = this;
			<CreateGridItem>d__.<>1__state = -1;
			<CreateGridItem>d__.<>t__builder.Start<NewItemTipsView.<CreateGridItem>d__6>(ref <CreateGridItem>d__);
			return <CreateGridItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602E4A7 RID: 189607 RVA: 0x00CE8BEC File Offset: 0x00CE6DEC
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

		// Token: 0x0602E4A8 RID: 189608 RVA: 0x00CE8C3C File Offset: 0x00CE6E3C
		private UniTask CreateNiagaraSystem()
		{
			NewItemTipsView.<CreateNiagaraSystem>d__8 <CreateNiagaraSystem>d__;
			<CreateNiagaraSystem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateNiagaraSystem>d__.<>4__this = this;
			<CreateNiagaraSystem>d__.<>1__state = -1;
			<CreateNiagaraSystem>d__.<>t__builder.Start<NewItemTipsView.<CreateNiagaraSystem>d__8>(ref <CreateNiagaraSystem>d__);
			return <CreateNiagaraSystem>d__.<>t__builder.Task;
		}

		// Token: 0x0602E4A9 RID: 189609 RVA: 0x00CE8C80 File Offset: 0x00CE6E80
		protected override UniTask OnBeforeStartAsync()
		{
			NewItemTipsView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<NewItemTipsView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E4AA RID: 189610 RVA: 0x00CE8CC4 File Offset: 0x00CE6EC4
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

		// Token: 0x0602E4AB RID: 189611 RVA: 0x00CE8E3C File Offset: 0x00CE703C
		[NullableContext(1)]
		private void RefreshQualityTexture(string bgPath, string flowPath)
		{
			base.SetTextureByPath(bgPath, base.GetTexture(4), null, null);
			base.SetTextureByPath(flowPath, base.GetTexture(7), null, null);
		}

		// Token: 0x0602E4AC RID: 189612 RVA: 0x00CE8E7C File Offset: 0x00CE707C
		protected override void OnAfterShow()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayLevelSequenceByName(this.IsGolden ? "Golden" : "Start01", false, null, false);
		}

		// Token: 0x0602E4AD RID: 189613 RVA: 0x00CE8EB8 File Offset: 0x00CE70B8
		protected override void OnBeforeDestroy()
		{
			ItemModel.Instance.LastCloseTimeStamp = TimeUtil.Instance.GetServerTimeStamp();
		}

		// Token: 0x04018A79 RID: 100985
		[Nullable(2)]
		protected SmallItemGrid GridItem;

		// Token: 0x04018A7A RID: 100986
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04018A7B RID: 100987
		private bool IsGolden;

		// Token: 0x0200A443 RID: 42051
		private class ENewItemTipsViewCom
		{
			// Token: 0x04032E3C RID: 208444
			public const int MainTypeIconTexture = 0;

			// Token: 0x04032E3D RID: 208445
			public const int ItemNameText = 1;

			// Token: 0x04032E3E RID: 208446
			public const int GridItem = 2;

			// Token: 0x04032E3F RID: 208447
			public const int ItemDescribeText = 3;

			// Token: 0x04032E40 RID: 208448
			public const int QualityTexture = 4;

			// Token: 0x04032E41 RID: 208449
			public const int QualityNiagara = 5;

			// Token: 0x04032E42 RID: 208450
			public const int FlowTexture = 7;
		}
	}
}
