using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem.Item;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x02004179 RID: 16761
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PhantomArenaDeckOverviewItem : GridProxyAbstract<DeckInfo>
	{
		// Token: 0x0602A728 RID: 173864 RVA: 0x00BF916C File Offset: 0x00BF736C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUITexture)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIText)),
				new ValueTuple<int, Type>(9, typeof(UUISprite)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUIItem)),
				new ValueTuple<int, Type>(12, typeof(UUIItem)),
				new ValueTuple<int, Type>(13, typeof(UUIText)),
				new ValueTuple<int, Type>(14, typeof(UUISprite))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleSelectInternal))
			};
		}

		// Token: 0x0602A729 RID: 173865 RVA: 0x00BF92F8 File Offset: 0x00BF74F8
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaDeckOverviewItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaDeckOverviewItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602A72A RID: 173866 RVA: 0x00BF933C File Offset: 0x00BF753C
		public override void Refresh(DeckInfo data, bool isSelected, int gridIndex)
		{
			this.DeckInfo = data;
			List<ECardElement> list = (data != null) ? data.GetElementList() : null;
			int num = (list != null) ? list.Count : 0;
			for (int i = 0; i < this.ElementList.Count; i++)
			{
				if (i >= num)
				{
					this.ElementList[i].SetActive(false);
				}
				else
				{
					this.ElementList[i].SetActive(true);
					this.ElementList[i].RefreshElement(list[i]);
				}
			}
			base.GetExtendToggle(0).SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			UUIText text = base.GetText(4);
			UUIText text2 = base.GetText(8);
			UUITexture texture = base.GetTexture(2);
			UUIItem item = base.GetItem(12);
			base.GetText(1).SetText((gridIndex + 1).ToString(), true);
			if (data.GetDeckServerId() == -100)
			{
				string deckDefaultName = PhantomArenaConfig.Instance.GetDeckDefaultName();
				base.GetText(3).SetText(deckDefaultName, true);
				base.GetItem(6).SetUIActive(true);
				base.GetItem(5).SetUIActive(false);
				base.GetItem(7).SetUIActive(false);
				text.SetUIActive(false);
				text2.SetUIActive(false);
				texture.SetUIActive(false);
				item.SetUIActive(false);
				return;
			}
			base.GetText(3).SetText(data.GetName(), true);
			base.GetItem(6).SetUIActive(false);
			bool uiactive = PhantomArenaModel.Instance.GetLastUsedCardDeckServerId(this.ActivityId) == data.GetDeckServerId();
			base.GetItem(7).SetUIActive(uiactive);
			text.SetUIActive(true);
			text2.SetUIActive(true);
			item.SetUIActive(data.GetFieldCardCountLimit() != 0);
			bool flag = data.CanDeckBeUsed();
			base.GetItem(5).SetUIActive(!flag);
			int normalCardCount = data.GetNormalCardCount();
			int normalCardCountLimit = data.GetNormalCardCountLimit();
			if (normalCardCount == normalCardCountLimit)
			{
				UUIText uuitext = text;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(normalCardCount);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(normalCardCountLimit);
				uuitext.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			else
			{
				LguiUtil.Instance.SetLocalTextNew(text, "PhantomBattle_1042", new <>z__ReadOnlyArray<object>(new object[]
				{
					normalCardCount,
					normalCardCountLimit
				}));
			}
			bool flag2 = data.IsCoreCardSlotLocked();
			base.GetSprite(9).SetIsGray(flag2);
			UUIItem uuiitem = text2;
			bool bUseChangeColor = flag2;
			FColor? fcolor = new FColor?(text2.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			if (flag2)
			{
				LguiUtil.Instance.SetLocalTextNew(text2, "PhantomBattle_1039", Array.Empty<object>());
			}
			else
			{
				int coreCardCount = data.GetCoreCardCount();
				int coreCardCountLimit = data.GetCoreCardCountLimit();
				if (coreCardCount == coreCardCountLimit)
				{
					UUIText uuitext2 = text2;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
					defaultInterpolatedStringHandler.AppendFormatted<int>(coreCardCount);
					defaultInterpolatedStringHandler.AppendLiteral("/");
					defaultInterpolatedStringHandler.AppendFormatted<int>(coreCardCountLimit);
					uuitext2.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
				}
				else
				{
					LguiUtil.Instance.SetLocalTextNew(text2, "PhantomBattle_1042", new <>z__ReadOnlyArray<object>(new object[]
					{
						coreCardCount,
						coreCardCountLimit
					}));
				}
			}
			UUIText text3 = base.GetText(13);
			int fieldCardCount = data.GetFieldCardCount();
			int fieldCardCountLimit = data.GetFieldCardCountLimit();
			if (fieldCardCount == fieldCardCountLimit)
			{
				UUIText uuitext3 = text3;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(fieldCardCount);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(fieldCardCountLimit);
				uuitext3.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			else
			{
				LguiUtil.Instance.SetLocalTextNew(text3, "PhantomBattle_1042", new <>z__ReadOnlyArray<object>(new object[]
				{
					fieldCardCount,
					fieldCardCountLimit
				}));
			}
			DeckCardSlotInfo fieldCardSlot = data.GetFieldCardSlot();
			int? num2 = (fieldCardSlot != null) ? new int?(fieldCardSlot.Element) : null;
			string path;
			if (num2 != null)
			{
				path = PhantomArenaConfig.Instance.GetPhantomBattleElementConfig(num2.Value).FieldCardElementInDeck;
			}
			else
			{
				path = UiResourceConfig.Instance.GetResourcePath("SP_IconSoundRemnantArenaField");
			}
			this.SetSpriteByPath(path, base.GetSprite(14), false, null, null);
			int deckFaceCardId = data.GetDeckFaceCardId();
			texture.SetUIActive(deckFaceCardId > 0);
			if (deckFaceCardId > 0)
			{
				base.SetTextureByPath(PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(deckFaceCardId).DeckFaceTexture, texture, null, null);
				UUIItem uuiitem2 = texture;
				bool bUseChangeColor2 = !flag;
				fcolor = new FColor?(texture.changeColor);
				uuiitem2.SetChangeColor(bUseChangeColor2, fcolor);
			}
		}

		// Token: 0x0602A72B RID: 173867 RVA: 0x00BF97A8 File Offset: 0x00BF79A8
		public override void OnSelected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, fireEvent, false, false);
		}

		// Token: 0x0602A72C RID: 173868 RVA: 0x00BF97BB File Offset: 0x00BF79BB
		public override void OnDeselected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x0602A72D RID: 173869 RVA: 0x00BF97CE File Offset: 0x00BF79CE
		private void OnToggleSelectInternal(EToggleState toggleState)
		{
			Action<int> onToggleSelect = this.OnToggleSelect;
			if (onToggleSelect == null)
			{
				return;
			}
			onToggleSelect(base.GridIndex);
		}

		// Token: 0x040170E0 RID: 94432
		[Nullable(2)]
		protected DeckInfo DeckInfo;

		// Token: 0x040170E1 RID: 94433
		public int ActivityId;

		// Token: 0x040170E2 RID: 94434
		protected List<CardElementItem> ElementList = new List<CardElementItem>();

		// Token: 0x040170E3 RID: 94435
		[Nullable(2)]
		public Action<int> OnToggleSelect;

		// Token: 0x02009D5A RID: 40282
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04030EF6 RID: 200438
			public const int ItemToggle = 0;

			// Token: 0x04030EF7 RID: 200439
			public const int IndexText = 1;

			// Token: 0x04030EF8 RID: 200440
			public const int DeckFaceTexture = 2;

			// Token: 0x04030EF9 RID: 200441
			public const int NameText = 3;

			// Token: 0x04030EFA RID: 200442
			public const int NormalCardCountText = 4;

			// Token: 0x04030EFB RID: 200443
			public const int UnDoneItem = 5;

			// Token: 0x04030EFC RID: 200444
			public const int CreateDeckItem = 6;

			// Token: 0x04030EFD RID: 200445
			public const int LastUsedItem = 7;

			// Token: 0x04030EFE RID: 200446
			public const int CoreCardCountText = 8;

			// Token: 0x04030EFF RID: 200447
			public const int CoreCardTagSprite = 9;

			// Token: 0x04030F00 RID: 200448
			public const int FirstElementItem = 10;

			// Token: 0x04030F01 RID: 200449
			public const int SecondElementItem = 11;

			// Token: 0x04030F02 RID: 200450
			public const int ItemFieldPanel = 12;

			// Token: 0x04030F03 RID: 200451
			public const int TextFieldNum = 13;

			// Token: 0x04030F04 RID: 200452
			public const int SpriteFieldTagIcon = 14;
		}
	}
}
