using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200559B RID: 21915
	public class FishingQuestShapePanelItem : GridProxyAbstract<ValueTuple<int, int>>
	{
		// Token: 0x06036552 RID: 222546 RVA: 0x00F29B18 File Offset: 0x00F27D18
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

		// Token: 0x06036553 RID: 222547 RVA: 0x00F29B60 File Offset: 0x00F27D60
		public override void Refresh(ValueTuple<int, int> data, bool isSelected, int gridIndex)
		{
			this.RowIndex = data.Item1;
			this.ColumnIndex = data.Item2;
		}

		// Token: 0x06036554 RID: 222548 RVA: 0x00F29B7C File Offset: 0x00F27D7C
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

		// Token: 0x0401CABF RID: 117439
		public int RowIndex;

		// Token: 0x0401CAC0 RID: 117440
		public int ColumnIndex;

		// Token: 0x0200B214 RID: 45588
		private class EComponentDefine
		{
			// Token: 0x040370B6 RID: 225462
			public const int Sprite = 0;
		}
	}
}
