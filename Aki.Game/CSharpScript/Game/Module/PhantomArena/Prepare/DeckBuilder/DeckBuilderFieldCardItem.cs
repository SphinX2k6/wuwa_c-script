using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Common.CardDetail;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x0200519E RID: 20894
	[NullableContext(1)]
	[Nullable(0)]
	public class DeckBuilderFieldCardItem : UiPanelBase
	{
		// Token: 0x06035762 RID: 218978 RVA: 0x00CA7DD8 File Offset: 0x00CA5FD8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIText)),
				new ValueTuple<int, Type>(10, typeof(UUISprite))
			};
		}

		// Token: 0x06035763 RID: 218979 RVA: 0x00CA7ED0 File Offset: 0x00CA60D0
		protected override UniTask OnBeforeStartAsync()
		{
			DeckBuilderFieldCardItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DeckBuilderFieldCardItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035764 RID: 218980 RVA: 0x00CA7F14 File Offset: 0x00CA6114
		public void RefreshItem(DeckInfo deckInfo, int? needPlayAddAnimCard = null)
		{
			DeckCardSlotInfo fieldCardSlot = deckInfo.GetFieldCardSlot();
			bool flag = fieldCardSlot != null;
			base.GetItem(7).SetUIActive(flag);
			base.GetItem(8).SetUIActive(!flag);
			if (!flag)
			{
				this.IsSkillActivate = false;
			}
			int value = (fieldCardSlot != null) ? fieldCardSlot.Count : 0;
			int fieldCardCountLimit = deckInfo.GetFieldCardCountLimit();
			UUIText text = base.GetText(2);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(value);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(fieldCardCountLimit);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			List<int> list = new List<int>();
			if (fieldCardSlot != null)
			{
				list.Add(fieldCardSlot.Element);
			}
			GenericLayout<CardElementItem, ECardElement> fieldElementLayout = this.FieldElementLayout;
			if (fieldElementLayout == null)
			{
				return;
			}
			fieldElementLayout.RefreshByData(list.Cast<ECardElement>().ToList<ECardElement>(), null, false);
		}

		// Token: 0x06035765 RID: 218981 RVA: 0x00CA7FD6 File Offset: 0x00CA61D6
		public void RefreshSlotItem(IDeckBuilderCardSlotItemData data)
		{
			DeckBuilderCardSlotItem fieldSlotItem = this.FieldSlotItem;
			if (fieldSlotItem == null)
			{
				return;
			}
			fieldSlotItem.Refresh(data, false, 0);
		}

		// Token: 0x06035766 RID: 218982 RVA: 0x00CA7FEC File Offset: 0x00CA61EC
		public void RefreshEffectUnlock(ICardDetailConditionOutData data)
		{
			bool flag = data.CurrentProgress >= data.MaxProgress;
			UUIItem item = base.GetItem(5);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			UUIItem item2 = base.GetItem(6);
			if (item2 != null)
			{
				item2.SetUIActive(!flag);
			}
			string textStringId = flag ? "PhantomBattle_1163" : "PhantomBattle_1162";
			LguiUtil.Instance.SetLocalTextNew(base.GetText(9), textStringId, new <>z__ReadOnlyArray<object>(new object[]
			{
				data.CurrentProgress,
				data.MaxProgress
			}));
			if (!string.IsNullOrEmpty(data.Icon))
			{
				this.SetSpriteByPath(data.Icon, base.GetSprite(10), false, null, null);
			}
			if (flag != this.IsSkillActivate)
			{
				this.OnFieldCardSkillActivated(flag);
				this.IsSkillActivate = flag;
			}
		}

		// Token: 0x06035767 RID: 218983 RVA: 0x00CA80C1 File Offset: 0x00CA62C1
		protected override void OnBeforeDestroy()
		{
			this.LevelSequencePlayer.Clear();
			this.LevelSequencePlayer = null;
		}

		// Token: 0x06035768 RID: 218984 RVA: 0x00CA80D8 File Offset: 0x00CA62D8
		private void OnFieldCardSkillActivated(bool isActivate)
		{
			string sequenceName = isActivate ? "Activate" : "InActivate";
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayLevelSequenceByName(sequenceName, false, null, false);
		}

		// Token: 0x06035769 RID: 218985 RVA: 0x00CA8111 File Offset: 0x00CA6311
		private CardElementItem CreateElementItem()
		{
			return new CardElementItem();
		}

		// Token: 0x0401C661 RID: 116321
		private bool IsSkillActivate;

		// Token: 0x0401C662 RID: 116322
		[Nullable(2)]
		public DeckBuilderCardSlotItem FieldSlotItem;

		// Token: 0x0401C663 RID: 116323
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected GenericLayout<CardElementItem, ECardElement> FieldElementLayout;

		// Token: 0x0401C664 RID: 116324
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401C665 RID: 116325
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<DeckBuilderCardSlotItem> OnEffectBtnClickCallback;

		// Token: 0x0200B30D RID: 45837
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04036444 RID: 222276
			public const int LayoutElement = 0;

			// Token: 0x04036445 RID: 222277
			public const int ItemElement = 1;

			// Token: 0x04036446 RID: 222278
			public const int TextNum = 2;

			// Token: 0x04036447 RID: 222279
			public const int ItemCardSlot = 3;

			// Token: 0x04036448 RID: 222280
			public const int ItemEffect = 4;

			// Token: 0x04036449 RID: 222281
			public const int ItemActivatePanel = 5;

			// Token: 0x0403644A RID: 222282
			public const int ItemInactivatePanel = 6;

			// Token: 0x0403644B RID: 222283
			public const int ItemCardPanel = 7;

			// Token: 0x0403644C RID: 222284
			public const int ItemNonePanel = 8;

			// Token: 0x0403644D RID: 222285
			public const int TextEffectCondition = 9;

			// Token: 0x0403644E RID: 222286
			public const int SpriteEffectCondition = 10;
		}
	}
}
