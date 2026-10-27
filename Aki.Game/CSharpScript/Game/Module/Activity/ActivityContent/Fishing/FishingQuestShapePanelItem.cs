using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200661D RID: 26141
	public class FishingQuestShapePanelItem : GridProxyAbstract<ValueTuple<int, int>>
	{
		// Token: 0x0604188D RID: 268429 RVA: 0x00FE2AA8 File Offset: 0x00FE0CA8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0604188E RID: 268430 RVA: 0x00FE2AF0 File Offset: 0x00FE0CF0
		public override void Refresh(ValueTuple<int, int> data, bool isSelected, int gridIndex)
		{
			this.RowIndex = data.Item1;
			this.ColumnIndex = data.Item2;
		}

		// Token: 0x0604188F RID: 268431 RVA: 0x00FE2B0C File Offset: 0x00FE0D0C
		[NullableContext(1)]
		public void SetGirdSprite(int category, string path)
		{
			if (category == 0)
			{
				UUISprite sprite = base.GetSprite(0);
				string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_GridEmpty");
				this.SetSpriteByPath(resourcePath, sprite, false, null, null);
				return;
			}
			UUISprite sprite2 = base.GetSprite(0);
			this.SetSpriteByPath(path, sprite2, false, null, null);
		}

		// Token: 0x0402218E RID: 139662
		public int RowIndex;

		// Token: 0x0402218F RID: 139663
		public int ColumnIndex;

		// Token: 0x0200C832 RID: 51250
		private class EComponentDefine
		{
			// Token: 0x0403C771 RID: 247665
			public const int Sprite = 0;
		}
	}
}
