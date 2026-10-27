using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem.Item;
using CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.ChallengeDetail
{
	// Token: 0x020051BA RID: 20922
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		2
	})]
	public class PhantomArenaChallengeDetailDeckItem : GridProxyAbstract<DeckInfo>
	{
		// Token: 0x0603592E RID: 219438 RVA: 0x00CB0E38 File Offset: 0x00CAF038
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUITexture)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUIText)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIText)),
				new ValueTuple<int, Type>(8, typeof(UUISprite)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUIItem)),
				new ValueTuple<int, Type>(12, typeof(UUIText)),
				new ValueTuple<int, Type>(13, typeof(UUISprite))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnItemButtonInternal))
			};
		}

		// Token: 0x0603592F RID: 219439 RVA: 0x00CB0FAC File Offset: 0x00CAF1AC
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaChallengeDetailDeckItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaChallengeDetailDeckItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035930 RID: 219440 RVA: 0x00CB0FEF File Offset: 0x00CAF1EF
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x06035931 RID: 219441 RVA: 0x00CB1004 File Offset: 0x00CAF204
		public override void Refresh(DeckInfo data, bool isSelected, int gridIndex)
		{
			this.DeckInfo = data;
			UUIText text = base.GetText(5);
			UUIText text2 = base.GetText(7);
			UUITexture texture = base.GetTexture(2);
			if (data == null)
			{
				base.GetItem(6).SetUIActive(true);
				base.GetItem(1).SetUIActive(false);
				text.SetUIActive(false);
				text2.SetUIActive(false);
				texture.SetUIActive(false);
				return;
			}
			base.GetItem(6).SetUIActive(false);
			base.GetItem(1).SetUIActive(true);
			base.GetText(3).SetText("1", true);
			base.GetText(4).SetText(data.GetName(), true);
			text.SetUIActive(true);
			text2.SetUIActive(true);
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
			bool flag = data.IsCoreCardSlotLocked();
			base.GetSprite(8).SetIsGray(flag);
			UUIItem uuiitem = text2;
			bool bUseChangeColor = flag;
			FColor? fcolor = new FColor?(text2.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			if (flag)
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
			base.GetItem(11).SetUIActive(data.GetFieldCardCountLimit() != 0);
			UUIText text3 = base.GetText(12);
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
			int? num = (fieldCardSlot != null) ? new int?(fieldCardSlot.Element) : null;
			string path;
			if (num != null)
			{
				path = PhantomArenaConfig.Instance.GetPhantomBattleElementConfig(num.Value).FieldCardElementInDeck;
			}
			else
			{
				path = UiResourceConfig.Instance.GetResourcePath("SP_IconSoundRemnantArenaField");
			}
			this.SetSpriteByPath(path, base.GetSprite(13), false, null, null);
			int deckFaceCardId = data.GetDeckFaceCardId();
			texture.SetUIActive(deckFaceCardId > 0);
			if (deckFaceCardId > 0)
			{
				base.SetTextureByPath(PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(deckFaceCardId).DeckFaceTexture, texture, null, null);
			}
			List<ECardElement> elementList = data.GetElementList();
			for (int i = 0; i < this.ElementList.Count; i++)
			{
				if (i >= elementList.Count)
				{
					this.ElementList[i].SetActive(false);
				}
				else
				{
					this.ElementList[i].SetActive(true);
					this.ElementList[i].RefreshElement(elementList[i]);
				}
			}
		}

		// Token: 0x06035932 RID: 219442 RVA: 0x00CB13B4 File Offset: 0x00CAF5B4
		public void PlaySelectAnim()
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlayLevelSequenceByName("In", false, null, false);
		}

		// Token: 0x06035933 RID: 219443 RVA: 0x00CB13E1 File Offset: 0x00CAF5E1
		private void OnItemButtonInternal()
		{
			Action onButtonClick = this.OnButtonClick;
			if (onButtonClick == null)
			{
				return;
			}
			onButtonClick();
		}

		// Token: 0x0401C700 RID: 116480
		protected DeckInfo DeckInfo;

		// Token: 0x0401C701 RID: 116481
		protected LevelSequencePlayer SequencePlayer;

		// Token: 0x0401C702 RID: 116482
		[Nullable(1)]
		protected List<CardElementItem> ElementList = new List<CardElementItem>();

		// Token: 0x0401C703 RID: 116483
		public Action OnButtonClick;

		// Token: 0x0200B347 RID: 45895
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x0403655C RID: 222556
			public const int ItemButton = 0;

			// Token: 0x0403655D RID: 222557
			public const int CardItem = 1;

			// Token: 0x0403655E RID: 222558
			public const int DeckFaceTexture = 2;

			// Token: 0x0403655F RID: 222559
			public const int IndexText = 3;

			// Token: 0x04036560 RID: 222560
			public const int NameText = 4;

			// Token: 0x04036561 RID: 222561
			public const int NormalCardCountText = 5;

			// Token: 0x04036562 RID: 222562
			public const int EmptyDeckItem = 6;

			// Token: 0x04036563 RID: 222563
			public const int CoreCardCountText = 7;

			// Token: 0x04036564 RID: 222564
			public const int CoreCardTagSprite = 8;

			// Token: 0x04036565 RID: 222565
			public const int FirstElementItem = 9;

			// Token: 0x04036566 RID: 222566
			public const int SecondElementItem = 10;

			// Token: 0x04036567 RID: 222567
			public const int ItemFieldPanel = 11;

			// Token: 0x04036568 RID: 222568
			public const int TextFieldNum = 12;

			// Token: 0x04036569 RID: 222569
			public const int SpriteFieldTagIcon = 13;
		}
	}
}
