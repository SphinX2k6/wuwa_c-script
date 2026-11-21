using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.BossPiling.View.Item;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BossPiling.View
{
	// Token: 0x02004BF2 RID: 19442
	[NullableContext(1)]
	[Nullable(0)]
	public class BossPilingNewBuffTipsView : UiViewBase
	{
		// Token: 0x06030848 RID: 198728 RVA: 0x00D841CD File Offset: 0x00D823CD
		public BossPilingNewBuffTipsView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06030849 RID: 198729 RVA: 0x00D841E4 File Offset: 0x00D823E4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603084A RID: 198730 RVA: 0x00D84314 File Offset: 0x00D82514
		protected override UniTask OnBeforeStartAsync()
		{
			BossPilingNewBuffTipsView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BossPilingNewBuffTipsView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603084B RID: 198731 RVA: 0x00D84358 File Offset: 0x00D82558
		protected override void OnStart()
		{
			BossPilingNewBuffInfo bossPilingNewBuffInfo = this.OpenParam as BossPilingNewBuffInfo;
			ValueTuple<int, int> tipsPlayRate = BossPilingConfig.Instance.GetTipsPlayRate();
			int item = tipsPlayRate.Item1;
			int item2 = tipsPlayRate.Item2;
			this.PlayRate = (float)((BossPilingModel.Instance.InstBuffAcquireCount > 1) ? item2 : item);
			BossPilingBuff value = BossPilingConfig.Instance.GetBuffInfo(bossPilingNewBuffInfo.BuffId).Value;
			BossPilingBuffCountPanel countPanel = this.CountPanel;
			if (countPanel != null)
			{
				countPanel.Refresh(bossPilingNewBuffInfo.OldValue, bossPilingNewBuffInfo.NewValue, value.BuffId);
			}
			QualityInfo value2 = InventoryConfig.Instance.GetItemQualityConfig(value.Quality).Value;
			FColor color = FColor.FromHex(value2.TextColor);
			this.IsGolden = (value2.Id >= 5);
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(this.IsGolden ? "NS_Fx_LGUI_Item_Golden" : "NS_Fx_LGUI_Item_Other");
			ResourceSystem.Instance.LoadAsync<UNiagaraSystem>(resourcePath, delegate([Nullable(2)] UNiagaraSystem niagaraSystem, string _)
			{
				if (niagaraSystem == null || !UiManager.Instance.IsViewOpen(EUiViewName.BossPilingNewBuffTipsView) || this.RootItem == null)
				{
					return;
				}
				UUINiagara uiNiagara = this.GetUiNiagara(5);
				uiNiagara.SetNiagaraSystem(niagaraSystem);
				if (!this.IsGolden)
				{
					uiNiagara.ColorParameter.Get("Color").Constant = FLinearColor.FromSRGBColor(color);
				}
			}, ResourceSystem.EResourceLoadPriority.Default, this.MemoryTag);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), value.Name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), value.Desc, value.DescArgs());
			this.BuffItem.Refresh(bossPilingNewBuffInfo.BuffId, false, 0);
			this.RefreshQualityTexture(value2.TextureAcquireBg, value2.TextureAcquireFlow);
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.LevelSequencePlayer.BindSequenceCloseEvent(delegate(string sequenceName)
			{
				if (sequenceName == "Golden" || sequenceName == "Start01")
				{
					this.CloseMe(null);
				}
			}, false);
			UUIItem item3 = base.GetItem(6);
			if (item3 != null)
			{
				item3.SetUIActive(bossPilingNewBuffInfo.OldValue == 0);
			}
			UUITexture texture = base.GetTexture(0);
			if (texture == null)
			{
				return;
			}
			texture.SetUIActive(false);
		}

		// Token: 0x0603084C RID: 198732 RVA: 0x00D84528 File Offset: 0x00D82728
		private void RefreshQualityTexture(string bgPath, string flowPath)
		{
			base.SetTextureByPath(bgPath, base.GetTexture(4), null, null);
			base.SetTextureByPath(flowPath, base.GetTexture(7), null, null);
		}

		// Token: 0x0603084D RID: 198733 RVA: 0x00D84568 File Offset: 0x00D82768
		protected override void OnAfterShow()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.PlayLevelSequenceByName(this.IsGolden ? "Golden" : "Start01", false, new float?(this.PlayRate), false);
			}
			BossPilingBuffCountPanel countPanel = this.CountPanel;
			if (countPanel == null)
			{
				return;
			}
			countPanel.PlaySequence(this.PlayRate);
		}

		// Token: 0x0603084E RID: 198734 RVA: 0x00D845BD File Offset: 0x00D827BD
		protected override void OnBeforeDestroy()
		{
			BossPilingModel.Instance.InstBuffAcquireCount--;
			ItemModel.Instance.LastCloseTimeStamp = TimeUtil.Instance.GetServerTimeStamp();
		}

		// Token: 0x04019AEA RID: 105194
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04019AEB RID: 105195
		private bool IsGolden;

		// Token: 0x04019AEC RID: 105196
		[Nullable(2)]
		private BossPilingBuffCountPanel CountPanel;

		// Token: 0x04019AED RID: 105197
		protected BossPilingBuffSimpleItem BuffItem;

		// Token: 0x04019AEE RID: 105198
		protected float PlayRate = 1f;

		// Token: 0x0200A7FC RID: 43004
		[NullableContext(0)]
		private enum ENewItemTipsViewCom
		{
			// Token: 0x04033E2A RID: 212522
			MainTypeIconTexture,
			// Token: 0x04033E2B RID: 212523
			ItemNameText,
			// Token: 0x04033E2C RID: 212524
			BuffItem,
			// Token: 0x04033E2D RID: 212525
			ItemDescribeText,
			// Token: 0x04033E2E RID: 212526
			QualityTexture,
			// Token: 0x04033E2F RID: 212527
			QualityNiagara,
			// Token: 0x04033E30 RID: 212528
			NewPanel,
			// Token: 0x04033E31 RID: 212529
			FlowTexture
		}
	}
}
