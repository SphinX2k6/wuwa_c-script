using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x0200598E RID: 22926
	public class SolarSchoolAttrItem : GridProxyAbstract<ESolarSchoolSecondAttr>
	{
		// Token: 0x06038872 RID: 231538 RVA: 0x00FD0DEC File Offset: 0x00FCEFEC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038873 RID: 231539 RVA: 0x00FD0EDC File Offset: 0x00FCF0DC
		public override void Refresh(ESolarSchoolSecondAttr data, bool isSelected, int gridIndex)
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			UUISprite sprite = base.GetSprite(4);
			if (sprite != null)
			{
				Func<ESolarSchoolSecondAttr, bool> isAttrIncreased = this.IsAttrIncreased;
				sprite.SetUIActive(isAttrIncreased != null && isAttrIncreased(data));
			}
			UUISprite sprite2 = base.GetSprite(5);
			if (sprite2 != null)
			{
				sprite2.SetUIActive(instance.PlayerData.IsAttrImportant(data));
			}
			SolarSchoolAttr? attrConfig = instance.GetAttrConfig(data);
			if (attrConfig == null)
			{
				return;
			}
			SolarSchoolAttr value = attrConfig.Value;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), value.Name, Array.Empty<object>());
			base.SetTextureByPath(value.IconSmall, base.GetTexture(0), null, null);
			int attr = instance.PlayerData.GetAttr(data);
			UUIText text = base.GetText(3);
			if (text != null)
			{
				text.SetText(attr.ToString(), true);
			}
			int num = SolarSchoolUtils.CalcAttrRankTier(value, attr);
			string text2 = (num < value.RankIconLength) ? value.RankIcon(num) : null;
			if (!string.IsNullOrEmpty(text2))
			{
				base.SetTextureShowUntilLoaded(text2, base.GetTexture(1), null);
				return;
			}
			UUITexture texture = base.GetTexture(1);
			if (texture == null)
			{
				return;
			}
			texture.SetUIActive(false);
		}

		// Token: 0x0401DC75 RID: 121973
		[Nullable(2)]
		public Func<ESolarSchoolSecondAttr, bool> IsAttrIncreased;

		// Token: 0x0200B533 RID: 46387
		private class EComponents
		{
			// Token: 0x04038064 RID: 229476
			public const int TexIcon = 0;

			// Token: 0x04038065 RID: 229477
			public const int TexScore = 1;

			// Token: 0x04038066 RID: 229478
			public const int TxtName = 2;

			// Token: 0x04038067 RID: 229479
			public const int TxtValue = 3;

			// Token: 0x04038068 RID: 229480
			public const int SprUp = 4;

			// Token: 0x04038069 RID: 229481
			public const int SprScratch = 5;
		}
	}
}
