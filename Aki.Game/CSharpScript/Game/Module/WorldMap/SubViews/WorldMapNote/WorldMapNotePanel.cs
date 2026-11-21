using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.WorldMap.ViewComponent;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.WorldMapNote
{
	// Token: 0x02003711 RID: 14097
	public class WorldMapNotePanel : WorldMapSecondaryUi
	{
		// Token: 0x06024AFD RID: 150269 RVA: 0x00A5BA39 File Offset: 0x00A59C39
		[NullableContext(1)]
		public override string GetResourceId()
		{
			return "UiView_MapPopupTrack";
		}

		// Token: 0x06024AFE RID: 150270 RVA: 0x00A5BA40 File Offset: 0x00A59C40
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06024AFF RID: 150271 RVA: 0x00A5BACC File Offset: 0x00A59CCC
		protected override void OnStart()
		{
			this.PopupCaption = new PopupCaptionItem(base.GetItem(0));
			PopupCaptionItem popupCaption = this.PopupCaption;
			if (popupCaption != null)
			{
				popupCaption.SetCloseCallBack(new Action(base.Close));
			}
			this.NoteLayout = new GenericLayout<WorldMapNoteItemNew, WorldMapNoteItemData>(base.GetVerticalLayout(1), () => new WorldMapNoteItemNew(), null, false, true);
		}

		// Token: 0x06024B00 RID: 150272 RVA: 0x00A5BB3C File Offset: 0x00A59D3C
		[NullableContext(1)]
		protected override void OnShowWorldMapSecondaryUi(params object[] param)
		{
			if (param.Length != 0)
			{
				List<IMapNoteParams> list = param[0] as List<IMapNoteParams>;
				if (list != null)
				{
					List<WorldMapNoteItemData> list2 = new List<WorldMapNoteItemData>();
					foreach (IMapNoteParams mapNoteParams in list)
					{
						MapNote? config = ConfigMapNoteById.GetConfig((int)mapNoteParams.MapNoteId, true);
						if (config != null)
						{
							list2.Add(new WorldMapNoteItemData
							{
								Id = mapNoteParams.MapMarkId.GetValueOrDefault(),
								IconRes = (config.Value.Icon ?? ""),
								DescId = (config.Value.Desc ?? ""),
								NoteStyle = (EMapNoteStyle)config.Value.Style,
								ClickCallback = mapNoteParams.ClickCallBack,
								CustomDesc = mapNoteParams.CustomDesc
							});
						}
					}
					GenericLayout<WorldMapNoteItemNew, WorldMapNoteItemData> noteLayout = this.NoteLayout;
					if (noteLayout == null)
					{
						return;
					}
					noteLayout.RefreshByData(list2, null, true);
				}
			}
		}

		// Token: 0x06024B01 RID: 150273 RVA: 0x00A5BC60 File Offset: 0x00A59E60
		protected override void OnCloseWorldMapSecondaryUi()
		{
		}

		// Token: 0x06024B02 RID: 150274 RVA: 0x00A5BC62 File Offset: 0x00A59E62
		protected override void OnBeforeDestroy()
		{
			this.PopupCaption = null;
			this.NoteLayout = null;
		}

		// Token: 0x06024B03 RID: 150275 RVA: 0x00A5BC72 File Offset: 0x00A59E72
		protected override bool GetNeedBgItem()
		{
			return false;
		}

		// Token: 0x04014607 RID: 83463
		[Nullable(2)]
		private PopupCaptionItem PopupCaption;

		// Token: 0x04014608 RID: 83464
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<WorldMapNoteItemNew, WorldMapNoteItemData> NoteLayout;

		// Token: 0x0200944B RID: 37963
		public static class EChildType
		{
			// Token: 0x0402E5F6 RID: 189942
			public const int ItemCaption = 0;

			// Token: 0x0402E5F7 RID: 189943
			public const int VerticalLayoutNote = 1;

			// Token: 0x0402E5F8 RID: 189944
			public const int ItemNote = 2;
		}
	}
}
