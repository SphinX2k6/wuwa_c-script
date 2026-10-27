using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02005C3C RID: 23612
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class FlagChallengePauseInfoItem : GridProxyAbstract<FlagChallengePauseInfo>
	{
		// Token: 0x0603BA78 RID: 244344 RVA: 0x00E3C4C4 File Offset: 0x00E3A6C4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603BA79 RID: 244345 RVA: 0x00E3C570 File Offset: 0x00E3A770
		[NullableContext(1)]
		public override void Refresh(FlagChallengePauseInfo data, bool isSelected, int gridIndex)
		{
			this.SetSpriteByPath(data.IconPath, base.GetSprite(0), false, null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.TitleKey, Array.Empty<object>());
			base.GetText(2).SetText(data.Content, true);
			base.GetSprite(3).SetUIActive(data.ShowLine);
		}

		// Token: 0x0200BE31 RID: 48689
		private enum EInfoItemType
		{
			// Token: 0x040395A7 RID: 234919
			IconSprite,
			// Token: 0x040395A8 RID: 234920
			TitleTxt,
			// Token: 0x040395A9 RID: 234921
			ContentTxt,
			// Token: 0x040395AA RID: 234922
			SplitSprite
		}
	}
}
