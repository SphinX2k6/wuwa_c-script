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
	// Token: 0x020047E0 RID: 18400
	public class WorldMapNotePanel : WorldMapSecondaryUi
	{
		// Token: 0x0603032D RID: 197421 RVA: 0x00B2BB6D File Offset: 0x00B29D6D
		[NullableContext(1)]
		public override string GetResourceId()
		{
			return "UiView_MapPopupTrack";
		}

		// Token: 0x0603032E RID: 197422 RVA: 0x00B2BB74 File Offset: 0x00B29D74
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

		// Token: 0x0603032F RID: 197423 RVA: 0x00B2BC00 File Offset: 0x00B29E00
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

		// Token: 0x06030330 RID: 197424 RVA: 0x00B2BC70 File Offset: 0x00B29E70
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

		// Token: 0x06030331 RID: 197425 RVA: 0x00B2BD94 File Offset: 0x00B29F94
		protected override void OnCloseWorldMapSecondaryUi()
		{
		}

		// Token: 0x06030332 RID: 197426 RVA: 0x00B2BD96 File Offset: 0x00B29F96
		protected override void OnBeforeDestroy()
		{
			this.PopupCaption = null;
			this.NoteLayout = null;
		}

		// Token: 0x06030333 RID: 197427 RVA: 0x00B2BDA6 File Offset: 0x00B29FA6
		protected override bool GetNeedBgItem()
		{
			return false;
		}

		// Token: 0x04019F53 RID: 106323
		[Nullable(2)]
		private PopupCaptionItem PopupCaption;

		// Token: 0x04019F54 RID: 106324
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<WorldMapNoteItemNew, WorldMapNoteItemData> NoteLayout;

		// Token: 0x0200AA99 RID: 43673
		public static class EChildType
		{
			// Token: 0x04033E6F RID: 212591
			public const int ItemCaption = 0;

			// Token: 0x04033E70 RID: 212592
			public const int VerticalLayoutNote = 1;

			// Token: 0x04033E71 RID: 212593
			public const int ItemNote = 2;
		}
	}
}
