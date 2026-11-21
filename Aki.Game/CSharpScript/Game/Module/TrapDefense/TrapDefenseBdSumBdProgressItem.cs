using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A87 RID: 14983
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseBdSumBdProgressItem : GridProxyAbstract<ITrapDefenseBdProgressInfo>
	{
		// Token: 0x060267EA RID: 157674 RVA: 0x00AC8DB0 File Offset: 0x00AC6FB0
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

		// Token: 0x060267EB RID: 157675 RVA: 0x00AC8E3C File Offset: 0x00AC703C
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

		// Token: 0x060267EC RID: 157676 RVA: 0x00AC8F09 File Offset: 0x00AC7109
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

		// Token: 0x0401518B RID: 86411
		public ITrapDefenseBdProgressInfo ItemData;

		// Token: 0x0401518C RID: 86412
		public Action<ITrapDefenseBdProgressInfo> ClickCallBack;

		// Token: 0x02009688 RID: 38536
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x0402F00A RID: 192522
			public const int SpriteArrow = 0;

			// Token: 0x0402F00B RID: 192523
			public const int ItemProgressRoot = 1;

			// Token: 0x0402F00C RID: 192524
			public const int SpriteProgress = 2;
		}
	}
}
