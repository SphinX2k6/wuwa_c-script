using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x0200416F RID: 16751
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DeckBuilderQuicklyBuildItem : GridProxyAbstract<DeckInfo>
	{
		// Token: 0x0602A666 RID: 173670 RVA: 0x00BF573C File Offset: 0x00BF393C
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

		// Token: 0x0602A667 RID: 173671 RVA: 0x00BF57E8 File Offset: 0x00BF39E8
		protected override void OnStart()
		{
			for (int i = 3; i <= 4; i++)
			{
				this.CardTextureList.Add(base.GetTexture(i));
			}
		}

		// Token: 0x0602A668 RID: 173672 RVA: 0x00BF5814 File Offset: 0x00BF3A14
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

		// Token: 0x0602A669 RID: 173673 RVA: 0x00BF5920 File Offset: 0x00BF3B20
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

		// Token: 0x0602A66A RID: 173674 RVA: 0x00BF59C4 File Offset: 0x00BF3BC4
		public override void OnSelected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, fireEvent, false, false);
		}

		// Token: 0x0602A66B RID: 173675 RVA: 0x00BF59D7 File Offset: 0x00BF3BD7
		public override void OnDeselected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x0602A66C RID: 173676 RVA: 0x00BF59EA File Offset: 0x00BF3BEA
		private void OnToggleStateChangeInternal(EToggleState toggleState)
		{
			if (this.OnToggleStateChange != null)
			{
				this.OnToggleStateChange(base.GridIndex);
			}
		}

		// Token: 0x0401709B RID: 94363
		[Nullable(2)]
		protected DeckInfo Data;

		// Token: 0x0401709C RID: 94364
		protected List<UUITexture> CardTextureList = new List<UUITexture>();

		// Token: 0x0401709D RID: 94365
		[Nullable(2)]
		public Action<int> OnToggleStateChange;

		// Token: 0x02009D48 RID: 40264
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04030EA8 RID: 200360
			public const int ItemToggle = 0;

			// Token: 0x04030EA9 RID: 200361
			public const int DeckNameText = 1;

			// Token: 0x04030EAA RID: 200362
			public const int CardCountText = 2;

			// Token: 0x04030EAB RID: 200363
			public const int ElementTexture1 = 3;

			// Token: 0x04030EAC RID: 200364
			public const int ElementTexture2 = 4;
		}
	}
}
