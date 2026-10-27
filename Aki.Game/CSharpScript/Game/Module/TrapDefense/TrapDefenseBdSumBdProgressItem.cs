using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004ADF RID: 19167
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseBdSumBdProgressItem : GridProxyAbstract<ITrapDefenseBdProgressInfo>
	{
		// Token: 0x06031A5A RID: 203354 RVA: 0x00B84DFC File Offset: 0x00B82FFC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06031A5B RID: 203355 RVA: 0x00B84E88 File Offset: 0x00B83088
		public override void Refresh(ITrapDefenseBdProgressInfo data, bool isSelected, int gridIndex)
		{
			this.ItemData = data;
			bool isShowQualityArrow = data.IsShowQualityArrow;
			UUISprite sprite = base.GetSprite(0);
			sprite.SetUIActive(false);
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(data.IsActive);
			}
			if (isShowQualityArrow)
			{
				string resourcePath = UiResourceConfig.Instance.GetResourcePath(data.QualityArrowRes.ToString());
				this.SetSpriteByPath(resourcePath, sprite, false, null, null);
			}
			ETrapDefenseBdBuffQuality curActiveQualityPool = data.BdData.GetCurActiveQualityPool();
			UiResourceConfig instance = UiResourceConfig.Instance;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 1);
			defaultInterpolatedStringHandler.AppendLiteral("SP_BdProgress_");
			defaultInterpolatedStringHandler.AppendFormatted<int>((int)curActiveQualityPool);
			string resourcePath2 = instance.GetResourcePath(defaultInterpolatedStringHandler.ToStringAndClear());
			this.SetSpriteByPath(resourcePath2, base.GetSprite(2), false, null, null);
		}

		// Token: 0x06031A5C RID: 203356 RVA: 0x00B84F55 File Offset: 0x00B83155
		public void SetQualityArrowShow(bool show)
		{
			if (!this.ItemData.IsShowQualityArrow)
			{
				return;
			}
			UUISprite sprite = base.GetSprite(0);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(show);
		}

		// Token: 0x0401A839 RID: 108601
		public ITrapDefenseBdProgressInfo ItemData;

		// Token: 0x0401A83A RID: 108602
		public Action<ITrapDefenseBdProgressInfo> ClickCallBack;

		// Token: 0x0200AC68 RID: 44136
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04034659 RID: 214617
			public const int SpriteArrow = 0;

			// Token: 0x0403465A RID: 214618
			public const int ItemProgressRoot = 1;

			// Token: 0x0403465B RID: 214619
			public const int SpriteProgress = 2;
		}
	}
}
