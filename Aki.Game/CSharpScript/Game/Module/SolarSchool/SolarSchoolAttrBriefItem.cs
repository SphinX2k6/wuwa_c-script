using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x0200598B RID: 22923
	public class SolarSchoolAttrBriefItem : GridProxyAbstract<ESolarSchoolSecondAttr>
	{
		// Token: 0x06038862 RID: 231522 RVA: 0x00FD07B4 File Offset: 0x00FCE9B4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038863 RID: 231523 RVA: 0x00FD0880 File Offset: 0x00FCEA80
		public override void Refresh(ESolarSchoolSecondAttr data, bool isSelected, int gridIndex)
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			UUISprite sprite = base.GetSprite(3);
			if (sprite != null)
			{
				Func<ESolarSchoolSecondAttr, bool> isAttrIncreased = this.IsAttrIncreased;
				sprite.SetUIActive(isAttrIncreased != null && isAttrIncreased(data));
			}
			UUISprite sprite2 = base.GetSprite(4);
			if (sprite2 != null)
			{
				sprite2.SetUIActive(instance.PlayerData.IsAttrImportant(data));
			}
			UUIText text = base.GetText(0);
			if (text != null)
			{
				text.SetText(instance.PlayerData.GetAttr(data).ToString(), true);
			}
			UUISprite sprite3 = base.GetSprite(1);
			if (sprite3 != null)
			{
				sprite3.SetUIActive(data == ESolarSchoolSecondAttr.Popularity);
			}
			SolarSchoolAttr? attrConfig = instance.GetAttrConfig(data);
			string text2 = ((attrConfig != null) ? attrConfig.GetValueOrDefault().IconSmall : null) ?? string.Empty;
			if (!string.IsNullOrEmpty(text2))
			{
				base.SetTextureByPath(text2, base.GetTexture(2), null, null);
			}
		}

		// Token: 0x0401DC6E RID: 121966
		[Nullable(2)]
		public Func<ESolarSchoolSecondAttr, bool> IsAttrIncreased;

		// Token: 0x0200B530 RID: 46384
		private class EComponents
		{
			// Token: 0x04038052 RID: 229458
			public const int TxtValue = 0;

			// Token: 0x04038053 RID: 229459
			public const int SprLineR = 1;

			// Token: 0x04038054 RID: 229460
			public const int TextureIcon = 2;

			// Token: 0x04038055 RID: 229461
			public const int SprUp = 3;

			// Token: 0x04038056 RID: 229462
			public const int SprScratch = 4;
		}
	}
}
