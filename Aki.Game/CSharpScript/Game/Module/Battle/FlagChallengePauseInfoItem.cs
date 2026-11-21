using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02004C1C RID: 19484
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class FlagChallengePauseInfoItem : GridProxyAbstract<FlagChallengePauseInfo>
	{
		// Token: 0x060309C3 RID: 199107 RVA: 0x00D8C834 File Offset: 0x00D8AA34
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

		// Token: 0x060309C4 RID: 199108 RVA: 0x00D8C8E0 File Offset: 0x00D8AAE0
		[NullableContext(1)]
		public override void Refresh(FlagChallengePauseInfo data, bool isSelected, int gridIndex)
		{
			this.SetSpriteByPath(data.IconPath, base.GetSprite(0), false, null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.TitleKey, Array.Empty<object>());
			base.GetText(2).SetText(data.Content, true);
			base.GetSprite(3).SetUIActive(data.ShowLine);
		}

		// Token: 0x0200A839 RID: 43065
		private enum EInfoItemType
		{
			// Token: 0x04033F6A RID: 212842
			IconSprite,
			// Token: 0x04033F6B RID: 212843
			TitleTxt,
			// Token: 0x04033F6C RID: 212844
			ContentTxt,
			// Token: 0x04033F6D RID: 212845
			SplitSprite
		}
	}
}
