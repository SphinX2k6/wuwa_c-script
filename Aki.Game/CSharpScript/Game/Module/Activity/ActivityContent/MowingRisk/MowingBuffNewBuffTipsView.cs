using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x020063DA RID: 25562
	public class MowingBuffNewBuffTipsView : UiTickViewBase, INewItemTipsViewLike
	{
		// Token: 0x060404AD RID: 263341 RVA: 0x00F8CCE8 File Offset: 0x00F8AEE8
		[NullableContext(1)]
		public MowingBuffNewBuffTipsView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060404AE RID: 263342 RVA: 0x00F8CCF1 File Offset: 0x00F8AEF1
		public void RefreshMainTypeIconTexture()
		{
			UUITexture texture = base.GetTexture(0);
			if (texture == null)
			{
				return;
			}
			texture.SetUIActive(false);
		}

		// Token: 0x060404AF RID: 263343 RVA: 0x00F8CD08 File Offset: 0x00F8AF08
		public void RefreshItemNameText()
		{
			if (this.Color != null)
			{
				UUIText text = base.GetText(1);
				if (text != null)
				{
					text.SetColor(this.Color.Value);
				}
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), this.PassData.NameTextId, Array.Empty<object>());
		}

		// Token: 0x060404B0 RID: 263344 RVA: 0x00F8CD60 File Offset: 0x00F8AF60
		public void RefreshItemIconTexture()
		{
			base.SetTextureByPath(this.PassData.IconPath, base.GetTexture(2), null, null);
		}

		// Token: 0x060404B1 RID: 263345 RVA: 0x00F8CD8F File Offset: 0x00F8AF8F
		public void RefreshItemDescribeText()
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), this.PassData.DescriptionTextId, this.PassData.DescriptionArgs);
		}

		// Token: 0x060404B2 RID: 263346 RVA: 0x00F8CDB8 File Offset: 0x00F8AFB8
		public void RefreshQualityTexture()
		{
			base.SetTextureByPath(this.PassData.QualityTexPath, base.GetTexture(4), null, null);
			base.SetTextureByPath(this.PassData.QualityFlowPath, base.GetTexture(7), null, null);
		}

		// Token: 0x060404B3 RID: 263347 RVA: 0x00F8CE0C File Offset: 0x00F8B00C
		public void RefreshQualityNiagara()
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(this.PassData.IsGolden ? "NS_Fx_LGUI_Item_Golden" : "NS_Fx_LGUI_Item_Other");
			ResourceSystem.Instance.LoadAsync<UNiagaraSystem>(resourcePath, delegate([Nullable(2)] UNiagaraSystem niagaraSystem, string path)
			{
				if (niagaraSystem == null || !UiManager.Instance.IsViewOpen(EUiViewName.NewItemTipsView) || this.RootItem == null)
				{
					return;
				}
				UUINiagara uiNiagara = base.GetUiNiagara(5);
				uiNiagara.SetNiagaraSystem(niagaraSystem);
				if (!this.PassData.IsGolden && this.Color != null)
				{
					FKuroCurveLinearColor fkuroCurveLinearColor = uiNiagara.ColorParameter.Get("Color");
					FColor value = this.Color.Value;
					fkuroCurveLinearColor.Constant = FLinearColor.FromSRGBColor(value);
				}
			}, 100, this.MemoryTag);
		}

		// Token: 0x060404B4 RID: 263348 RVA: 0x00F8CE60 File Offset: 0x00F8B060
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060404B5 RID: 263349 RVA: 0x00F8CF70 File Offset: 0x00F8B170
		protected override void OnStart()
		{
			if (this.OpenParam == null)
			{
				base.CloseMe(null);
				return;
			}
			this.PassData = (this.OpenParam as IMowingRiskNewBasicBuffTipsData);
			this.Color = new FColor?(FColor.FromHex(this.PassData.NameHexColor));
			this.RefreshMainTypeIconTexture();
			this.RefreshItemNameText();
			this.RefreshItemIconTexture();
			this.RefreshItemDescribeText();
			this.RefreshQualityTexture();
			this.RefreshQualityNiagara();
		}

		// Token: 0x060404B6 RID: 263350 RVA: 0x00F8CFE0 File Offset: 0x00F8B1E0
		protected override UniTask OnBeforeStartAsync()
		{
			MowingBuffNewBuffTipsView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MowingBuffNewBuffTipsView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060404B7 RID: 263351 RVA: 0x00F8D023 File Offset: 0x00F8B223
		protected override void OnAfterShow()
		{
			this.HandleOnAfterShowAsync().Forget();
		}

		// Token: 0x060404B8 RID: 263352 RVA: 0x00F8D030 File Offset: 0x00F8B230
		protected override void OnAfterDestroy()
		{
			EventSystem.Instance.Emit(EEventName.MowingRiskOnBuffTipsAfterDestroy);
		}

		// Token: 0x060404B9 RID: 263353 RVA: 0x00F8D044 File Offset: 0x00F8B244
		private UniTask HandleOnAfterShowAsync()
		{
			MowingBuffNewBuffTipsView.<HandleOnAfterShowAsync>d__16 <HandleOnAfterShowAsync>d__;
			<HandleOnAfterShowAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HandleOnAfterShowAsync>d__.<>4__this = this;
			<HandleOnAfterShowAsync>d__.<>1__state = -1;
			<HandleOnAfterShowAsync>d__.<>t__builder.Start<MowingBuffNewBuffTipsView.<HandleOnAfterShowAsync>d__16>(ref <HandleOnAfterShowAsync>d__);
			return <HandleOnAfterShowAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0402174A RID: 137034
		[Nullable(1)]
		private UiSequencePlayer UiSequencePlayer;

		// Token: 0x0402174B RID: 137035
		[Nullable(1)]
		private IMowingRiskNewBasicBuffTipsData PassData;

		// Token: 0x0402174C RID: 137036
		private FColor? Color;

		// Token: 0x0200C5DA RID: 50650
		private class ENewItemTipsViewLikeComponent
		{
			// Token: 0x0403BBD3 RID: 244691
			public const int MainTypeIconTexture = 0;

			// Token: 0x0403BBD4 RID: 244692
			public const int ItemNameText = 1;

			// Token: 0x0403BBD5 RID: 244693
			public const int ItemIconTexture = 2;

			// Token: 0x0403BBD6 RID: 244694
			public const int ItemDescribeText = 3;

			// Token: 0x0403BBD7 RID: 244695
			public const int QualityTexture = 4;

			// Token: 0x0403BBD8 RID: 244696
			public const int QualityNiagara = 5;

			// Token: 0x0403BBD9 RID: 244697
			public const int FlowTexture = 7;
		}
	}
}
