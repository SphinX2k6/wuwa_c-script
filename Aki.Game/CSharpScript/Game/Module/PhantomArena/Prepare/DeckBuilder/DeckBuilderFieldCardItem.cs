using System;
using System.Collections.Generic;
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
	// Token: 0x0200416E RID: 16750
	[NullableContext(1)]
	[Nullable(0)]
	public class DeckBuilderFieldCardItem : UiPanelBase
	{
		// Token: 0x0602A65D RID: 173661 RVA: 0x00BF53AC File Offset: 0x00BF35AC
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

		// Token: 0x0602A65E RID: 173662 RVA: 0x00BF54A4 File Offset: 0x00BF36A4
		protected override UniTask OnBeforeStartAsync()
		{
			DeckBuilderFieldCardItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DeckBuilderFieldCardItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602A65F RID: 173663 RVA: 0x00BF54E8 File Offset: 0x00BF36E8
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
			List<ECardElement> list2 = new List<ECardElement>();
			foreach (int item in list)
			{
				list2.Add((ECardElement)item);
			}
			GenericLayout<CardElementItem, ECardElement> fieldElementLayout = this.FieldElementLayout;
			if (fieldElementLayout == null)
			{
				return;
			}
			fieldElementLayout.RefreshByData(list2, null, false);
		}

		// Token: 0x0602A660 RID: 173664 RVA: 0x00BF55F0 File Offset: 0x00BF37F0
		public void RefreshSlotItem(IDeckBuilderCardSlotItemData data)
		{
			DeckBuilderCardSlotItem fieldSlotItem = this.FieldSlotItem;
			if (fieldSlotItem == null)
			{
				return;
			}
			fieldSlotItem.Refresh(data, false, 0);
		}

		// Token: 0x0602A661 RID: 173665 RVA: 0x00BF5608 File Offset: 0x00BF3808
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

		// Token: 0x0602A662 RID: 173666 RVA: 0x00BF56DD File Offset: 0x00BF38DD
		protected override void OnBeforeDestroy()
		{
			this.LevelSequencePlayer.Clear();
			this.LevelSequencePlayer = null;
		}

		// Token: 0x0602A663 RID: 173667 RVA: 0x00BF56F4 File Offset: 0x00BF38F4
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

		// Token: 0x0602A664 RID: 173668 RVA: 0x00BF572D File Offset: 0x00BF392D
		private CardElementItem CreateElementItem()
		{
			return new CardElementItem();
		}

		// Token: 0x04017096 RID: 94358
		private bool IsSkillActivate;

		// Token: 0x04017097 RID: 94359
		[Nullable(2)]
		public DeckBuilderCardSlotItem FieldSlotItem;

		// Token: 0x04017098 RID: 94360
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected GenericLayout<CardElementItem, ECardElement> FieldElementLayout;

		// Token: 0x04017099 RID: 94361
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401709A RID: 94362
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<DeckBuilderCardSlotItem> OnEffectBtnClickCallback;

		// Token: 0x02009D46 RID: 40262
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04030E99 RID: 200345
			public const int LayoutElement = 0;

			// Token: 0x04030E9A RID: 200346
			public const int ItemElement = 1;

			// Token: 0x04030E9B RID: 200347
			public const int TextNum = 2;

			// Token: 0x04030E9C RID: 200348
			public const int ItemCardSlot = 3;

			// Token: 0x04030E9D RID: 200349
			public const int ItemEffect = 4;

			// Token: 0x04030E9E RID: 200350
			public const int ItemActivatePanel = 5;

			// Token: 0x04030E9F RID: 200351
			public const int ItemInactivatePanel = 6;

			// Token: 0x04030EA0 RID: 200352
			public const int ItemCardPanel = 7;

			// Token: 0x04030EA1 RID: 200353
			public const int ItemNonePanel = 8;

			// Token: 0x04030EA2 RID: 200354
			public const int TextEffectCondition = 9;

			// Token: 0x04030EA3 RID: 200355
			public const int SpriteEffectCondition = 10;
		}
	}
}
