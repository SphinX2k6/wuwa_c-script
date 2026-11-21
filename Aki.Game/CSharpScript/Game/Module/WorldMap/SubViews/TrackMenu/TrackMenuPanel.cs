using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.WorldMap.ViewComponent;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.TrackMenu
{
	// Token: 0x0200371A RID: 14106
	[NullableContext(1)]
	[Nullable(0)]
	public class TrackMenuPanel : WorldMapSecondaryUi
	{
		// Token: 0x06024B50 RID: 150352 RVA: 0x00A5CD5C File Offset: 0x00A5AF5C
		public override string GetResourceId()
		{
			return "UiItem_MapHandleNav";
		}

		// Token: 0x06024B51 RID: 150353 RVA: 0x00A5CD64 File Offset: 0x00A5AF64
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

		// Token: 0x06024B52 RID: 150354 RVA: 0x00A5CE2B File Offset: 0x00A5B02B
		protected override void OnStart()
		{
			UUIItem item = base.GetItem(1);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x06024B53 RID: 150355 RVA: 0x00A5CE40 File Offset: 0x00A5B040
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

		// Token: 0x06024B54 RID: 150356 RVA: 0x00A5CEEC File Offset: 0x00A5B0EC
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

		// Token: 0x06024B55 RID: 150357 RVA: 0x00A5CF68 File Offset: 0x00A5B168
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

		// Token: 0x06024B56 RID: 150358 RVA: 0x00A5CFD1 File Offset: 0x00A5B1D1
		protected override void OnBeforeDestroy()
		{
			this.TrackMenuItems = Array.Empty<TrackMenuItem>();
		}

		// Token: 0x06024B57 RID: 150359 RVA: 0x00A5CFDE File Offset: 0x00A5B1DE
		protected override bool GetNeedBgItem()
		{
			return false;
		}

		// Token: 0x0401461A RID: 83482
		private TrackMenuItem[] TrackMenuItems = Array.Empty<TrackMenuItem>();

		// Token: 0x0401461B RID: 83483
		private readonly List<UUIItem> MenuUiItems = new List<UUIItem>();

		// Token: 0x0200945E RID: 37982
		[NullableContext(0)]
		public static class EChildType
		{
			// Token: 0x0402E643 RID: 190019
			public const int VerticalLayout = 0;

			// Token: 0x0402E644 RID: 190020
			public const int ItemRoot = 1;

			// Token: 0x0402E645 RID: 190021
			public const int BtnMask = 2;
		}
	}
}
