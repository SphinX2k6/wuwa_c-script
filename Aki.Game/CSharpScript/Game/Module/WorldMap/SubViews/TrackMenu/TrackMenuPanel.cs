using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.WorldMap.ViewComponent;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.TrackMenu
{
	// Token: 0x020047E9 RID: 18409
	[NullableContext(1)]
	[Nullable(0)]
	public class TrackMenuPanel : WorldMapSecondaryUi
	{
		// Token: 0x06030380 RID: 197504 RVA: 0x00B2CE18 File Offset: 0x00B2B018
		public override string GetResourceId()
		{
			return "UiItem_MapHandleNav";
		}

		// Token: 0x06030381 RID: 197505 RVA: 0x00B2CE20 File Offset: 0x00B2B020
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(base.Close));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06030382 RID: 197506 RVA: 0x00B2CEE7 File Offset: 0x00B2B0E7
		protected override void OnStart()
		{
			UUIItem item = base.GetItem(1);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x06030383 RID: 197507 RVA: 0x00B2CEFC File Offset: 0x00B2B0FC
		private void UpdateMenuUiItems(int count)
		{
			int count2 = this.MenuUiItems.Count;
			if (count == count2)
			{
				return;
			}
			if (count > count2)
			{
				for (int i = count2; i < count; i++)
				{
					LguiUtil instance = LguiUtil.Instance;
					UUIItem item = base.GetItem(1);
					UUIVerticalLayout verticalLayout = base.GetVerticalLayout(0);
					TWeakObjectPtr<UUIItem>? tweakObjectPtr = (verticalLayout != null) ? new TWeakObjectPtr<UUIItem>?(verticalLayout.RootUIComp) : null;
					UUIItem item2 = instance.CopyItem(item, (tweakObjectPtr != null) ? tweakObjectPtr.GetValueOrDefault() : null);
					this.MenuUiItems.Add(item2);
				}
				return;
			}
			for (int j = count; j < count2; j++)
			{
				this.MenuUiItems[j].SetUIActive(false);
			}
		}

		// Token: 0x06030384 RID: 197508 RVA: 0x00B2CFA8 File Offset: 0x00B2B1A8
		protected override void OnShowWorldMapSecondaryUi(params object[] param)
		{
			if (param.Length != 0)
			{
				List<ITrackMenuItemData> list = param[0] as List<ITrackMenuItemData>;
				if (list != null)
				{
					this.UpdateMenuUiItems(list.Count);
					this.TrackMenuItems = new TrackMenuItem[list.Count];
					for (int i = 0; i < list.Count; i++)
					{
						ITrackMenuItemData trackData = list[i];
						TrackMenuItem trackMenuItem = new TrackMenuItem();
						this.TrackMenuItems[i] = trackMenuItem;
						trackMenuItem.Init(this.MenuUiItems[i], trackData).Forget();
					}
				}
			}
		}

		// Token: 0x06030385 RID: 197509 RVA: 0x00B2D024 File Offset: 0x00B2B224
		protected override void OnCloseWorldMapSecondaryUi()
		{
			if (this.TrackMenuItems.Length != 0)
			{
				this.MenuUiItems.RemoveRange(0, Math.Min(this.TrackMenuItems.Length, this.MenuUiItems.Count));
			}
			foreach (TrackMenuItem trackMenuItem in this.TrackMenuItems)
			{
				if (trackMenuItem != null)
				{
					trackMenuItem.Destroy(null);
				}
			}
			this.TrackMenuItems = Array.Empty<TrackMenuItem>();
		}

		// Token: 0x06030386 RID: 197510 RVA: 0x00B2D08D File Offset: 0x00B2B28D
		protected override void OnBeforeDestroy()
		{
			this.TrackMenuItems = Array.Empty<TrackMenuItem>();
		}

		// Token: 0x06030387 RID: 197511 RVA: 0x00B2D09A File Offset: 0x00B2B29A
		protected override bool GetNeedBgItem()
		{
			return false;
		}

		// Token: 0x04019F66 RID: 106342
		private TrackMenuItem[] TrackMenuItems = Array.Empty<TrackMenuItem>();

		// Token: 0x04019F67 RID: 106343
		private readonly List<UUIItem> MenuUiItems = new List<UUIItem>();

		// Token: 0x0200AAAC RID: 43692
		[NullableContext(0)]
		public static class EChildType
		{
			// Token: 0x04033EBD RID: 212669
			public const int VerticalLayout = 0;

			// Token: 0x04033EBE RID: 212670
			public const int ItemRoot = 1;

			// Token: 0x04033EBF RID: 212671
			public const int BtnMask = 2;
		}
	}
}
