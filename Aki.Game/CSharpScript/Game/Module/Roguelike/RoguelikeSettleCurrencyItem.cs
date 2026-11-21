using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DEE RID: 15854
	public class RoguelikeSettleCurrencyItem : UiPanelBase
	{
		// Token: 0x060287E1 RID: 165857 RVA: 0x00B5AD0C File Offset: 0x00B58F0C
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
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060287E2 RID: 165858 RVA: 0x00B5AE1C File Offset: 0x00B5901C
		protected override UniTask OnBeforeStartAsync()
		{
			RoguelikeSettleCurrencyItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoguelikeSettleCurrencyItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060287E3 RID: 165859 RVA: 0x00B5AE5F File Offset: 0x00B5905F
		protected override void OnBeforeDestroy()
		{
			if (this.ScrollingNumberTool != null)
			{
				this.ScrollingNumberTool.Clear();
				this.ScrollingNumberTool = null;
			}
		}

		// Token: 0x060287E4 RID: 165860 RVA: 0x00B5AE7C File Offset: 0x00B5907C
		public void Refresh(int currencyId, int count, int rate)
		{
			this.CurrencyId = currencyId;
			this.Count = count;
			RogueCurrency? rogueCurrencyConfig = RoguelikeConfig.Instance.GetRogueCurrencyConfig(this.CurrencyId);
			base.SetTextureByPath(rogueCurrencyConfig.Value.Icon, base.GetTexture(0), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), rogueCurrencyConfig.Value.Title, Array.Empty<object>());
			this.InitCount = (int)Math.Floor((double)((float)count / ((float)rate / 10000f) + 0.5f));
			base.GetText(2).SetText(this.InitCount.ToString(), true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), "Rogue_Result_Bonus", new <>z__ReadOnlySingleElementList<object>((float)rate / 100f));
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetUIActive(count > 0);
		}

		// Token: 0x060287E5 RID: 165861 RVA: 0x00B5AF68 File Offset: 0x00B59168
		public UniTask StartAnim()
		{
			RoguelikeSettleCurrencyItem.<StartAnim>d__10 <StartAnim>d__;
			<StartAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<StartAnim>d__.<>4__this = this;
			<StartAnim>d__.<>1__state = -1;
			<StartAnim>d__.<>t__builder.Start<RoguelikeSettleCurrencyItem.<StartAnim>d__10>(ref <StartAnim>d__);
			return <StartAnim>d__.<>t__builder.Task;
		}

		// Token: 0x04015FAD RID: 90029
		public int CurrencyId;

		// Token: 0x04015FAE RID: 90030
		public int InitCount;

		// Token: 0x04015FAF RID: 90031
		public int Count;

		// Token: 0x04015FB0 RID: 90032
		[Nullable(2)]
		private ScrollingNumberTool ScrollingNumberTool;

		// Token: 0x04015FB1 RID: 90033
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x020099FE RID: 39422
		public static class ERoguelikeSettleCurrencyItemDefine
		{
			// Token: 0x0403001A RID: 196634
			public const int TexIcon = 0;

			// Token: 0x0403001B RID: 196635
			public const int TxtTitle = 1;

			// Token: 0x0403001C RID: 196636
			public const int TxtNum = 2;

			// Token: 0x0403001D RID: 196637
			public const int RateItem = 3;

			// Token: 0x0403001E RID: 196638
			public const int RateSpriteBg = 4;

			// Token: 0x0403001F RID: 196639
			public const int RateText = 5;

			// Token: 0x04030020 RID: 196640
			public const int TxtAddNum = 6;
		}
	}
}
