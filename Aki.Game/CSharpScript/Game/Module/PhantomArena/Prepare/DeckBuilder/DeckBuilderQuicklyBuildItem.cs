using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x0200519F RID: 20895
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DeckBuilderQuicklyBuildItem : GridProxyAbstract<DeckInfo>
	{
		// Token: 0x0603576B RID: 218987 RVA: 0x00CA8120 File Offset: 0x00CA6320
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUITexture)),
				new ValueTuple<int, Type>(4, typeof(UUITexture))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleStateChangeInternal))
			};
		}

		// Token: 0x0603576C RID: 218988 RVA: 0x00CA81CC File Offset: 0x00CA63CC
		protected override void OnStart()
		{
			for (int i = 3; i <= 4; i++)
			{
				this.CardTextureList.Add(base.GetTexture(i));
			}
		}

		// Token: 0x0603576D RID: 218989 RVA: 0x00CA81F8 File Offset: 0x00CA63F8
		public override void Refresh(DeckInfo data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			base.GetText(1).SetText(data.GetDeckName(), true);
			this.RefreshCountText();
			base.GetExtendToggle(0).SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			List<ECardElement> elementList = data.GetElementList();
			if (elementList.Count > this.CardTextureList.Count)
			{
				Log.Instance.Error(ELogModule.PhantomArena, ELogAuthor.LZK, "元素数量超过上限", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			for (int i = 0; i < elementList.Count; i++)
			{
				this.CardTextureList[i].SetUIActive(true);
				base.SetTextureByPath(PhantomArenaConfig.Instance.GetPhantomBattleElementConfig((int)elementList[i]).QuicklyBuildFilterIcon, this.CardTextureList[i], null, null);
			}
			for (int j = elementList.Count; j < this.CardTextureList.Count; j++)
			{
				this.CardTextureList[j].SetUIActive(false);
			}
		}

		// Token: 0x0603576E RID: 218990 RVA: 0x00CA8304 File Offset: 0x00CA6504
		public void RefreshCountText()
		{
			if (this.Data == null)
			{
				return;
			}
			int unlockCardCountInDeck = PhantomArenaModel.Instance.GetUnlockCardCountInDeck(this.Data);
			int totalCardCount = this.Data.GetTotalCardCount();
			if (unlockCardCountInDeck == totalCardCount)
			{
				UUIText text = base.GetText(2);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(unlockCardCountInDeck);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(totalCardCount);
				text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "PhantomBattle_1078", new <>z__ReadOnlyArray<object>(new object[]
			{
				unlockCardCountInDeck,
				totalCardCount
			}));
		}

		// Token: 0x0603576F RID: 218991 RVA: 0x00CA83A8 File Offset: 0x00CA65A8
		public override void OnSelected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, fireEvent, false, false);
		}

		// Token: 0x06035770 RID: 218992 RVA: 0x00CA83BB File Offset: 0x00CA65BB
		public override void OnDeselected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x06035771 RID: 218993 RVA: 0x00CA83CE File Offset: 0x00CA65CE
		private void OnToggleStateChangeInternal(EToggleState toggleState)
		{
			if (this.OnToggleStateChange != null)
			{
				this.OnToggleStateChange(base.GridIndex);
			}
		}

		// Token: 0x0401C666 RID: 116326
		[Nullable(2)]
		protected DeckInfo Data;

		// Token: 0x0401C667 RID: 116327
		protected List<UUITexture> CardTextureList = new List<UUITexture>();

		// Token: 0x0401C668 RID: 116328
		[Nullable(2)]
		public Action<int> OnToggleStateChange;

		// Token: 0x0200B30F RID: 45839
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04036453 RID: 222291
			public const int ItemToggle = 0;

			// Token: 0x04036454 RID: 222292
			public const int DeckNameText = 1;

			// Token: 0x04036455 RID: 222293
			public const int CardCountText = 2;

			// Token: 0x04036456 RID: 222294
			public const int ElementTexture1 = 3;

			// Token: 0x04036457 RID: 222295
			public const int ElementTexture2 = 4;
		}
	}
}
