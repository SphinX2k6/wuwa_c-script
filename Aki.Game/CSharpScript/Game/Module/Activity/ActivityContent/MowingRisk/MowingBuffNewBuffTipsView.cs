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
	// Token: 0x02005358 RID: 21336
	public class MowingBuffNewBuffTipsView : UiTickViewBase, INewItemTipsViewLike
	{
		// Token: 0x0603516E RID: 217454 RVA: 0x00ED3C80 File Offset: 0x00ED1E80
		[NullableContext(1)]
		public MowingBuffNewBuffTipsView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603516F RID: 217455 RVA: 0x00ED3C89 File Offset: 0x00ED1E89
		public void RefreshMainTypeIconTexture()
		{
			UUITexture texture = base.GetTexture(0);
			if (texture == null)
			{
				return;
			}
			texture.SetUIActive(false);
		}

		// Token: 0x06035170 RID: 217456 RVA: 0x00ED3CA0 File Offset: 0x00ED1EA0
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

		// Token: 0x06035171 RID: 217457 RVA: 0x00ED3CF8 File Offset: 0x00ED1EF8
		public void RefreshItemIconTexture()
		{
			base.SetTextureByPath(this.PassData.IconPath, base.GetTexture(2), null, null);
		}

		// Token: 0x06035172 RID: 217458 RVA: 0x00ED3D27 File Offset: 0x00ED1F27
		public void RefreshItemDescribeText()
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), this.PassData.DescriptionTextId, this.PassData.DescriptionArgs);
		}

		// Token: 0x06035173 RID: 217459 RVA: 0x00ED3D50 File Offset: 0x00ED1F50
		public void RefreshQualityTexture()
		{
			base.SetTextureByPath(this.PassData.QualityTexPath, base.GetTexture(4), null, null);
			base.SetTextureByPath(this.PassData.QualityFlowPath, base.GetTexture(7), null, null);
		}

		// Token: 0x06035174 RID: 217460 RVA: 0x00ED3DA4 File Offset: 0x00ED1FA4
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

		// Token: 0x06035175 RID: 217461 RVA: 0x00ED3DF8 File Offset: 0x00ED1FF8
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

		// Token: 0x06035176 RID: 217462 RVA: 0x00ED3F08 File Offset: 0x00ED2108
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

		// Token: 0x06035177 RID: 217463 RVA: 0x00ED3F78 File Offset: 0x00ED2178
		protected override UniTask OnBeforeStartAsync()
		{
			MowingBuffNewBuffTipsView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MowingBuffNewBuffTipsView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035178 RID: 217464 RVA: 0x00ED3FBB File Offset: 0x00ED21BB
		protected override void OnAfterShow()
		{
			this.HandleOnAfterShowAsync().Forget();
		}

		// Token: 0x06035179 RID: 217465 RVA: 0x00ED3FC8 File Offset: 0x00ED21C8
		protected override void OnAfterDestroy()
		{
			EventSystem.Instance.Emit(EEventName.MowingRiskOnBuffTipsAfterDestroy);
		}

		// Token: 0x0603517A RID: 217466 RVA: 0x00ED3FDC File Offset: 0x00ED21DC
		private UniTask HandleOnAfterShowAsync()
		{
			MowingBuffNewBuffTipsView.<HandleOnAfterShowAsync>d__16 <HandleOnAfterShowAsync>d__;
			<HandleOnAfterShowAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HandleOnAfterShowAsync>d__.<>4__this = this;
			<HandleOnAfterShowAsync>d__.<>1__state = -1;
			<HandleOnAfterShowAsync>d__.<>t__builder.Start<MowingBuffNewBuffTipsView.<HandleOnAfterShowAsync>d__16>(ref <HandleOnAfterShowAsync>d__);
			return <HandleOnAfterShowAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0401C079 RID: 114809
		[Nullable(1)]
		private UiSequencePlayer UiSequencePlayer;

		// Token: 0x0401C07A RID: 114810
		[Nullable(1)]
		private IMowingRiskNewBasicBuffTipsData PassData;

		// Token: 0x0401C07B RID: 114811
		private FColor? Color;

		// Token: 0x0200AFC1 RID: 44993
		private class ENewItemTipsViewLikeComponent
		{
			// Token: 0x04036532 RID: 222514
			public const int MainTypeIconTexture = 0;

			// Token: 0x04036533 RID: 222515
			public const int ItemNameText = 1;

			// Token: 0x04036534 RID: 222516
			public const int ItemIconTexture = 2;

			// Token: 0x04036535 RID: 222517
			public const int ItemDescribeText = 3;

			// Token: 0x04036536 RID: 222518
			public const int QualityTexture = 4;

			// Token: 0x04036537 RID: 222519
			public const int QualityNiagara = 5;

			// Token: 0x04036538 RID: 222520
			public const int FlowTexture = 7;
		}
	}
}
