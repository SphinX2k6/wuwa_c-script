using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005549 RID: 21833
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardTipsPanel : UiPanelBase, IDockyardLeftTipsInterface
	{
		// Token: 0x170068F6 RID: 26870
		// (get) Token: 0x0603628C RID: 221836 RVA: 0x00F1DC9F File Offset: 0x00F1BE9F
		// (set) Token: 0x0603628D RID: 221837 RVA: 0x00F1DCA7 File Offset: 0x00F1BEA7
		public bool LockState { get; set; }

		// Token: 0x0603628E RID: 221838 RVA: 0x00F1DCB0 File Offset: 0x00F1BEB0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 15;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUILayoutBase));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603628F RID: 221839 RVA: 0x00F1DECC File Offset: 0x00F1C0CC
		protected override void OnStart()
		{
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
			this.StarLayout = new SimpleGenericLayout(base.GetLayoutBase(5));
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(0);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(true);
		}

		// Token: 0x06036290 RID: 221840 RVA: 0x00F1DF21 File Offset: 0x00F1C121
		protected override void OnBeforeDestroy()
		{
			this.SequencePlayer.Clear();
		}

		// Token: 0x06036291 RID: 221841 RVA: 0x00F1DF30 File Offset: 0x00F1C130
		private void RefreshQuality(bool isActive, int quality)
		{
			base.GetLayoutBase(5).RootUIComp.Get().SetUIActive(isActive);
			if (isActive)
			{
				this.StarLayout.RebuildLayout(quality);
			}
		}

		// Token: 0x06036292 RID: 221842 RVA: 0x00F1DF68 File Offset: 0x00F1C168
		private void RefreshSize(bool isActive, int size, int cup)
		{
			base.GetItem(7).SetUIActive(isActive);
			if (isActive)
			{
				UUIText text = base.GetText(9);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int>(size);
				defaultInterpolatedStringHandler.AppendLiteral("cm");
				text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
				UUITexture texture = base.GetTexture(8);
				string texturePathByCup = DockyardPanelUtil.GetTexturePathByCup(cup);
				bool flag = !StringUtils.IsBlank(texturePathByCup);
				texture.SetUIActive(flag);
				if (flag)
				{
					base.SetTextureByPath(texturePathByCup, texture, null, null);
				}
			}
		}

		// Token: 0x06036293 RID: 221843 RVA: 0x00F1DFF0 File Offset: 0x00F1C1F0
		private void RefreshPrice(int price)
		{
			bool flag = price > 0;
			base.GetItem(10).SetUIActive(flag);
			if (flag)
			{
				base.GetText(11).SetText(price.ToString(), true);
			}
			base.SetItemIcon(base.GetTexture(12), 27, null, null);
		}

		// Token: 0x06036294 RID: 221844 RVA: 0x00F1E044 File Offset: 0x00F1C244
		public void Refresh(DockyardItemBlockOriginalData data)
		{
			this.Id = data.IncId;
			FishingItem? fishingItemConfig = FishingConfig.Instance.GetFishingItemConfig(data.ItemId);
			FishingTag? fishingTagConfig = FishingConfig.Instance.GetFishingTagConfig(fishingItemConfig.Value.Tech(0));
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), fishingItemConfig.Value.Name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(13), fishingItemConfig.Value.Desc, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), fishingTagConfig.Value.Name, Array.Empty<object>());
			FColor color = FColor.FromHex(fishingTagConfig.Value.Color);
			base.GetSprite(4).SetColor(color);
			bool isActive = fishingItemConfig.Value.Type == 1;
			this.RefreshQuality(isActive, data.Quality);
			this.RefreshSize(isActive, data.Size, data.Cup);
			this.RefreshPrice(data.Price);
		}

		// Token: 0x06036295 RID: 221845 RVA: 0x00F1E160 File Offset: 0x00F1C360
		public void SetPanelVisible(bool bVisible)
		{
			this.SetPanelVisible(bVisible, true);
		}

		// Token: 0x06036296 RID: 221846 RVA: 0x00F1E16A File Offset: 0x00F1C36A
		public void SetPanelVisible(bool bVisible, bool needAnim)
		{
			if (this.LockState)
			{
				return;
			}
			if (bVisible)
			{
				this.ShowTipsPanel(needAnim);
				return;
			}
			this.HideTipsPanel(needAnim);
		}

		// Token: 0x06036297 RID: 221847 RVA: 0x00F1E188 File Offset: 0x00F1C388
		private void ShowTipsPanel(bool needAnim = true)
		{
			if (needAnim)
			{
				this.SequencePlayer.StopCurrentSequenceByName("Hide", false, true);
				this.SequencePlayer.PlaySequencePurely("Show", false, false);
			}
			base.GetItem(0).SetUIActive(true);
			EventSystem.Instance.Emit<bool>(EEventName.FishingDockyardItemTipsShown, true);
		}

		// Token: 0x06036298 RID: 221848 RVA: 0x00F1E1DC File Offset: 0x00F1C3DC
		private void HideTipsPanel(bool needAnim = true)
		{
			if (needAnim)
			{
				this.SequencePlayer.StopCurrentSequenceByName("Show", false, true);
				this.SequencePlayer.PlaySequencePurely("Hide", false, false);
			}
			base.GetItem(0).SetUIActive(false);
			EventSystem.Instance.Emit<bool>(EEventName.FishingDockyardItemTipsShown, false);
		}

		// Token: 0x0401C94E RID: 117070
		protected int Id;

		// Token: 0x0401C94F RID: 117071
		protected SimpleGenericLayout StarLayout;

		// Token: 0x0401C950 RID: 117072
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0401C951 RID: 117073
		protected Action<int> SellClick;

		// Token: 0x0200B1D5 RID: 45525
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04036F7C RID: 225148
			public const int TipsItem = 0;

			// Token: 0x04036F7D RID: 225149
			public const int EmptyItem = 1;

			// Token: 0x04036F7E RID: 225150
			public const int Title = 2;

			// Token: 0x04036F7F RID: 225151
			public const int Tag = 3;

			// Token: 0x04036F80 RID: 225152
			public const int TagBg = 4;

			// Token: 0x04036F81 RID: 225153
			public const int StarRoot = 5;

			// Token: 0x04036F82 RID: 225154
			public const int ContentRoot = 6;

			// Token: 0x04036F83 RID: 225155
			public const int SizeItem = 7;

			// Token: 0x04036F84 RID: 225156
			public const int CupIcon = 8;

			// Token: 0x04036F85 RID: 225157
			public const int SizeText = 9;

			// Token: 0x04036F86 RID: 225158
			public const int PriceItem = 10;

			// Token: 0x04036F87 RID: 225159
			public const int PriceText = 11;

			// Token: 0x04036F88 RID: 225160
			public const int PriceIcon = 12;

			// Token: 0x04036F89 RID: 225161
			public const int Description = 13;
		}
	}
}
