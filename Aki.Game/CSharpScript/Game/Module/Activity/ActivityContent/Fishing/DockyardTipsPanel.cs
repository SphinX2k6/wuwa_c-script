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
	// Token: 0x020065CB RID: 26059
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardTipsPanel : UiPanelBase, IDockyardLeftTipsInterface
	{
		// Token: 0x17009594 RID: 38292
		// (get) Token: 0x060415C7 RID: 267719 RVA: 0x00FD6C5F File Offset: 0x00FD4E5F
		// (set) Token: 0x060415C8 RID: 267720 RVA: 0x00FD6C67 File Offset: 0x00FD4E67
		public bool LockState { get; set; }

		// Token: 0x060415C9 RID: 267721 RVA: 0x00FD6C70 File Offset: 0x00FD4E70
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

		// Token: 0x060415CA RID: 267722 RVA: 0x00FD6E8C File Offset: 0x00FD508C
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

		// Token: 0x060415CB RID: 267723 RVA: 0x00FD6EE1 File Offset: 0x00FD50E1
		protected override void OnBeforeDestroy()
		{
			this.SequencePlayer.Clear();
		}

		// Token: 0x060415CC RID: 267724 RVA: 0x00FD6EF0 File Offset: 0x00FD50F0
		private void RefreshQuality(bool isActive, int quality)
		{
			base.GetLayoutBase(5).RootUIComp.Get().SetUIActive(isActive);
			if (isActive)
			{
				this.StarLayout.RebuildLayout(quality);
			}
		}

		// Token: 0x060415CD RID: 267725 RVA: 0x00FD6F28 File Offset: 0x00FD5128
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

		// Token: 0x060415CE RID: 267726 RVA: 0x00FD6FB0 File Offset: 0x00FD51B0
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

		// Token: 0x060415CF RID: 267727 RVA: 0x00FD7004 File Offset: 0x00FD5204
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

		// Token: 0x060415D0 RID: 267728 RVA: 0x00FD7120 File Offset: 0x00FD5320
		public void SetPanelVisible(bool bVisible)
		{
			this.SetPanelVisible(bVisible, true);
		}

		// Token: 0x060415D1 RID: 267729 RVA: 0x00FD712A File Offset: 0x00FD532A
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

		// Token: 0x060415D2 RID: 267730 RVA: 0x00FD7148 File Offset: 0x00FD5348
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

		// Token: 0x060415D3 RID: 267731 RVA: 0x00FD719C File Offset: 0x00FD539C
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

		// Token: 0x0402201D RID: 139293
		protected int Id;

		// Token: 0x0402201E RID: 139294
		protected SimpleGenericLayout StarLayout;

		// Token: 0x0402201F RID: 139295
		private UiSequencePlayer SequencePlayer;

		// Token: 0x04022020 RID: 139296
		protected Action<int> SellClick;

		// Token: 0x0200C7F2 RID: 51186
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403C62E RID: 247342
			public const int TipsItem = 0;

			// Token: 0x0403C62F RID: 247343
			public const int EmptyItem = 1;

			// Token: 0x0403C630 RID: 247344
			public const int Title = 2;

			// Token: 0x0403C631 RID: 247345
			public const int Tag = 3;

			// Token: 0x0403C632 RID: 247346
			public const int TagBg = 4;

			// Token: 0x0403C633 RID: 247347
			public const int StarRoot = 5;

			// Token: 0x0403C634 RID: 247348
			public const int ContentRoot = 6;

			// Token: 0x0403C635 RID: 247349
			public const int SizeItem = 7;

			// Token: 0x0403C636 RID: 247350
			public const int CupIcon = 8;

			// Token: 0x0403C637 RID: 247351
			public const int SizeText = 9;

			// Token: 0x0403C638 RID: 247352
			public const int PriceItem = 10;

			// Token: 0x0403C639 RID: 247353
			public const int PriceText = 11;

			// Token: 0x0403C63A RID: 247354
			public const int PriceIcon = 12;

			// Token: 0x0403C63B RID: 247355
			public const int Description = 13;
		}
	}
}
