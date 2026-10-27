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
	// Token: 0x02005C12 RID: 23570
	[NullableContext(1)]
	[Nullable(0)]
	public class BossPilingNewBuffTipsView : UiViewBase
	{
		// Token: 0x0603B8FD RID: 243965 RVA: 0x00E33E85 File Offset: 0x00E32085
		public BossPilingNewBuffTipsView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603B8FE RID: 243966 RVA: 0x00E33E9C File Offset: 0x00E3209C
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

		// Token: 0x0603B8FF RID: 243967 RVA: 0x00E33FCC File Offset: 0x00E321CC
		protected override UniTask OnBeforeStartAsync()
		{
			BossPilingNewBuffTipsView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BossPilingNewBuffTipsView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603B900 RID: 243968 RVA: 0x00E34010 File Offset: 0x00E32210
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

		// Token: 0x0603B901 RID: 243969 RVA: 0x00E341E0 File Offset: 0x00E323E0
		private void RefreshQualityTexture(string bgPath, string flowPath)
		{
			base.SetTextureByPath(bgPath, base.GetTexture(4), null, null);
			base.SetTextureByPath(flowPath, base.GetTexture(7), null, null);
		}

		// Token: 0x0603B902 RID: 243970 RVA: 0x00E34220 File Offset: 0x00E32420
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

		// Token: 0x0603B903 RID: 243971 RVA: 0x00E34275 File Offset: 0x00E32475
		protected override void OnBeforeDestroy()
		{
			BossPilingModel.Instance.InstBuffAcquireCount--;
			ItemModel.Instance.LastCloseTimeStamp = TimeUtil.Instance.GetServerTimeStamp();
		}

		// Token: 0x0401F039 RID: 127033
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401F03A RID: 127034
		private bool IsGolden;

		// Token: 0x0401F03B RID: 127035
		[Nullable(2)]
		private BossPilingBuffCountPanel CountPanel;

		// Token: 0x0401F03C RID: 127036
		protected BossPilingBuffSimpleItem BuffItem;

		// Token: 0x0401F03D RID: 127037
		protected float PlayRate = 1f;

		// Token: 0x0200BDF4 RID: 48628
		[NullableContext(0)]
		private enum ENewItemTipsViewCom
		{
			// Token: 0x04039467 RID: 234599
			MainTypeIconTexture,
			// Token: 0x04039468 RID: 234600
			ItemNameText,
			// Token: 0x04039469 RID: 234601
			BuffItem,
			// Token: 0x0403946A RID: 234602
			ItemDescribeText,
			// Token: 0x0403946B RID: 234603
			QualityTexture,
			// Token: 0x0403946C RID: 234604
			QualityNiagara,
			// Token: 0x0403946D RID: 234605
			NewPanel,
			// Token: 0x0403946E RID: 234606
			FlowTexture
		}
	}
}
