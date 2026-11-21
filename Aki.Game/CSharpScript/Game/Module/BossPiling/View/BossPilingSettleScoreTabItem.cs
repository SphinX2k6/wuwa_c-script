using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.BossPiling.View
{
	// Token: 0x02004BF7 RID: 19447
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class BossPilingSettleScoreTabItem : GridProxyAbstract<BossPilingScoreTabInfo>
	{
		// Token: 0x0603086E RID: 198766 RVA: 0x00D85360 File Offset: 0x00D83560
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603086F RID: 198767 RVA: 0x00D853EC File Offset: 0x00D835EC
		[NullableContext(1)]
		public override void Refresh(BossPilingScoreTabInfo data, bool isSelected, int gridIndex)
		{
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(data.IsAchieve);
			}
			string resourceId = BossPilingDefine.BossPilingScoreTexMap[data.Quality];
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			this.SetSpriteByPath(resourcePath, base.GetSprite(0), false, null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "BossPilingActivity_DungeonDetail04", new <>z__ReadOnlySingleElementList<object>(data.BossHp));
			FColor changeColor = base.GetText(1).changeColor;
			UUIItem text = base.GetText(1);
			bool isAchieve = data.IsAchieve;
			FColor? fcolor = new FColor?(changeColor);
			text.SetChangeColor(isAchieve, fcolor);
		}

		// Token: 0x0200A80A RID: 43018
		private enum EItem
		{
			// Token: 0x04033E72 RID: 212594
			SpriteScore,
			// Token: 0x04033E73 RID: 212595
			TxtTarget,
			// Token: 0x04033E74 RID: 212596
			PanelFinish
		}
	}
}
