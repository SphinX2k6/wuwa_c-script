using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02004BC4 RID: 19396
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CiacconaGalChapterEntryItem : GridProxyAbstract<CiacconaGalChapterSlotData>
	{
		// Token: 0x060306C1 RID: 198337 RVA: 0x00D7E7EC File Offset: 0x00D7C9EC
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

		// Token: 0x060306C2 RID: 198338 RVA: 0x00D7E958 File Offset: 0x00D7CB58
		protected override void OnStart()
		{
			this.LayoutIcon = new GenericLayout<CiacconaSubEndingIcon, CiacconaGalSubEndingData>(base.GetHorizontalLayout(5), new Func<CiacconaSubEndingIcon>(this.GetEndingItem), null, false, true);
		}

		// Token: 0x060306C3 RID: 198339 RVA: 0x00D7E97C File Offset: 0x00D7CB7C
		public override void Refresh(CiacconaGalChapterSlotData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			CiacconaGalChapterData chapterDataById = CiacconaGalModel.Instance.GetChapterDataById(data.ChapterId);
			base.GetSprite(1).SetUIActive(!chapterDataById.IsUnlocked);
			string path = chapterDataById.IsUnlocked ? data.SlotImagePath : data.SlotLockImagePath;
			base.SetTextureByPath(path, base.GetTexture(0), null, null);
			this.SetSpriteByPath(data.RomanNumberIconPath, base.GetSprite(3), false, null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), chapterDataById.Title, Array.Empty<object>());
			List<CiacconaGalSubEndingData> list = new List<CiacconaGalSubEndingData>();
			foreach (int id in chapterDataById.SubEndingIds)
			{
				list.Add(CiacconaGalModel.Instance.GetSubEndingDataById(id));
			}
			this.LayoutIcon.RefreshByData(list, null, false);
			base.GetItem(7).SetUIActive(CiacconaGalModel.Instance.HasAnySubEndingRewardByChapterId(data.ChapterId));
		}

		// Token: 0x060306C4 RID: 198340 RVA: 0x00D7EA84 File Offset: 0x00D7CC84
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

		// Token: 0x060306C5 RID: 198341 RVA: 0x00D7EAF1 File Offset: 0x00D7CCF1
		private CiacconaSubEndingIcon GetEndingItem()
		{
			return new CiacconaSubEndingIcon();
		}

		// Token: 0x04019A69 RID: 105065
		[Nullable(2)]
		private CiacconaGalChapterSlotData Data;

		// Token: 0x04019A6A RID: 105066
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<CiacconaSubEndingIcon, CiacconaGalSubEndingData> LayoutIcon;

		// Token: 0x0200A7D1 RID: 42961
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04033D61 RID: 212321
			public const int TextureChapterImage = 0;

			// Token: 0x04033D62 RID: 212322
			public const int SpriteLock = 1;

			// Token: 0x04033D63 RID: 212323
			public const int TextName = 2;

			// Token: 0x04033D64 RID: 212324
			public const int SpriteRomanNumber = 3;

			// Token: 0x04033D65 RID: 212325
			public const int TogSelf = 4;

			// Token: 0x04033D66 RID: 212326
			public const int LayoutIcon = 5;

			// Token: 0x04033D67 RID: 212327
			public const int ItemIcon = 6;

			// Token: 0x04033D68 RID: 212328
			public const int ItemRedDot = 7;
		}
	}
}
