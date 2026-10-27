using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02005BE4 RID: 23524
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CiacconaGalChapterEntryItem : GridProxyAbstract<CiacconaGalChapterSlotData>
	{
		// Token: 0x0603B776 RID: 243574 RVA: 0x00E2E4E4 File Offset: 0x00E2C6E4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action<EToggleState>(this.OnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603B777 RID: 243575 RVA: 0x00E2E650 File Offset: 0x00E2C850
		protected override void OnStart()
		{
			this.LayoutIcon = new GenericLayout<CiacconaSubEndingIcon, CiacconaGalSubEndingData>(base.GetHorizontalLayout(5), new Func<CiacconaSubEndingIcon>(this.GetEndingItem), null, false, true);
		}

		// Token: 0x0603B778 RID: 243576 RVA: 0x00E2E674 File Offset: 0x00E2C874
		public override void Refresh(CiacconaGalChapterSlotData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			CiacconaGalChapterData chapterDataById = CiacconaGalModel.Instance.GetChapterDataById(data.ChapterId);
			base.GetSprite(1).SetUIActive(!chapterDataById.IsUnlocked);
			string path = chapterDataById.IsUnlocked ? data.SlotImagePath : data.SlotLockImagePath;
			base.SetTextureByPath(path, base.GetTexture(0), null, null);
			this.SetSpriteByPath(data.RomanNumberIconPath, base.GetSprite(3), false, null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), chapterDataById.Title, Array.Empty<object>());
			List<CiacconaGalSubEndingData> data2 = (from subEndingId in chapterDataById.SubEndingIds
			select CiacconaGalModel.Instance.GetSubEndingDataById(subEndingId)).ToList<CiacconaGalSubEndingData>();
			this.LayoutIcon.RefreshByData(data2, null, false);
			base.GetItem(7).SetUIActive(CiacconaGalModel.Instance.HasAnySubEndingRewardByChapterId(data.ChapterId));
		}

		// Token: 0x0603B779 RID: 243577 RVA: 0x00E2E774 File Offset: 0x00E2C974
		private void OnClick(EToggleState toggleState)
		{
			base.GetExtendToggle(4).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			if (!CiacconaGalModel.Instance.GetChapterDataById(this.Data.ChapterId).IsUnlocked)
			{
				GenericPromptController.Instance.ShowPromptByCode("RequirePreChapter", Array.Empty<object>());
				return;
			}
			CiacconaGalController.Instance.OpenChapterViewById(this.Data.ChapterId, null);
		}

		// Token: 0x0603B77A RID: 243578 RVA: 0x00E2E7E1 File Offset: 0x00E2C9E1
		private CiacconaSubEndingIcon GetEndingItem()
		{
			return new CiacconaSubEndingIcon();
		}

		// Token: 0x0401EFB8 RID: 126904
		[Nullable(2)]
		private CiacconaGalChapterSlotData Data;

		// Token: 0x0401EFB9 RID: 126905
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<CiacconaSubEndingIcon, CiacconaGalSubEndingData> LayoutIcon;

		// Token: 0x0200BDC8 RID: 48584
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403939C RID: 234396
			public const int TextureChapterImage = 0;

			// Token: 0x0403939D RID: 234397
			public const int SpriteLock = 1;

			// Token: 0x0403939E RID: 234398
			public const int TextName = 2;

			// Token: 0x0403939F RID: 234399
			public const int SpriteRomanNumber = 3;

			// Token: 0x040393A0 RID: 234400
			public const int TogSelf = 4;

			// Token: 0x040393A1 RID: 234401
			public const int LayoutIcon = 5;

			// Token: 0x040393A2 RID: 234402
			public const int ItemIcon = 6;

			// Token: 0x040393A3 RID: 234403
			public const int ItemRedDot = 7;
		}
	}
}
