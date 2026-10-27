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
	// Token: 0x02004E25 RID: 20005
	public class RoguelikeSettleCurrencyItem : UiPanelBase
	{
		// Token: 0x06033976 RID: 211318 RVA: 0x00C117D8 File Offset: 0x00C0F9D8
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

		// Token: 0x06033977 RID: 211319 RVA: 0x00C118E8 File Offset: 0x00C0FAE8
		protected override UniTask OnBeforeStartAsync()
		{
			RoguelikeSettleCurrencyItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoguelikeSettleCurrencyItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033978 RID: 211320 RVA: 0x00C1192B File Offset: 0x00C0FB2B
		protected override void OnBeforeDestroy()
		{
			if (this.ScrollingNumberTool != null)
			{
				this.ScrollingNumberTool.Clear();
				this.ScrollingNumberTool = null;
			}
		}

		// Token: 0x06033979 RID: 211321 RVA: 0x00C11948 File Offset: 0x00C0FB48
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

		// Token: 0x0603397A RID: 211322 RVA: 0x00C11A34 File Offset: 0x00C0FC34
		public UniTask StartAnim()
		{
			RoguelikeSettleCurrencyItem.<StartAnim>d__10 <StartAnim>d__;
			<StartAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<StartAnim>d__.<>4__this = this;
			<StartAnim>d__.<>1__state = -1;
			<StartAnim>d__.<>t__builder.Start<RoguelikeSettleCurrencyItem.<StartAnim>d__10>(ref <StartAnim>d__);
			return <StartAnim>d__.<>t__builder.Task;
		}

		// Token: 0x0401B5DA RID: 112090
		public int CurrencyId;

		// Token: 0x0401B5DB RID: 112091
		public int InitCount;

		// Token: 0x0401B5DC RID: 112092
		public int Count;

		// Token: 0x0401B5DD RID: 112093
		[Nullable(2)]
		private ScrollingNumberTool ScrollingNumberTool;

		// Token: 0x0401B5DE RID: 112094
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200AFCC RID: 45004
		public static class ERoguelikeSettleCurrencyItemDefine
		{
			// Token: 0x040355EA RID: 218602
			public const int TexIcon = 0;

			// Token: 0x040355EB RID: 218603
			public const int TxtTitle = 1;

			// Token: 0x040355EC RID: 218604
			public const int TxtNum = 2;

			// Token: 0x040355ED RID: 218605
			public const int RateItem = 3;

			// Token: 0x040355EE RID: 218606
			public const int RateSpriteBg = 4;

			// Token: 0x040355EF RID: 218607
			public const int RateText = 5;

			// Token: 0x040355F0 RID: 218608
			public const int TxtAddNum = 6;
		}
	}
}
