using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.BossPiling.View.Item
{
	// Token: 0x02005C26 RID: 23590
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class BossPilingScoreTabItem : GridProxyAbstract<BossPilingScoreTabInfo>
	{
		// Token: 0x0603B97A RID: 244090 RVA: 0x00E36FB4 File Offset: 0x00E351B4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603B97B RID: 244091 RVA: 0x00E37060 File Offset: 0x00E35260
		[NullableContext(1)]
		public override void Refresh(BossPilingScoreTabInfo data, bool isSelected, int gridIndex)
		{
			UUISprite sprite = base.GetSprite(0);
			if (sprite != null)
			{
				sprite.SetUIActive(!data.IsAchieve);
			}
			UUISprite sprite2 = base.GetSprite(1);
			if (sprite2 != null)
			{
				sprite2.SetUIActive(data.IsAchieve);
			}
			string resourceId = BossPilingDefine.BossPilingScoreTexMap[data.Quality];
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			this.SetSpriteByPath(resourcePath, base.GetSprite(2), false, null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "BossPilingActivity_DungeonDetail04", new <>z__ReadOnlySingleElementList<object>(data.BossHp));
			FColor changeColor = base.GetText(3).changeColor;
			UUIItem text = base.GetText(3);
			bool isAchieve = data.IsAchieve;
			FColor? fcolor = new FColor?(changeColor);
			text.SetChangeColor(isAchieve, fcolor);
		}

		// Token: 0x0200BE10 RID: 48656
		private enum EDefine
		{
			// Token: 0x0403950A RID: 234762
			SpriteNorIcon,
			// Token: 0x0403950B RID: 234763
			SpriteFinish,
			// Token: 0x0403950C RID: 234764
			SpriteScore,
			// Token: 0x0403950D RID: 234765
			TxtTarget
		}
	}
}
