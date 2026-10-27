using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02006008 RID: 24584
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TetrisTargetItemPanel : GridProxyAbstract<ITetrisTargetData>
	{
		// Token: 0x0603E43C RID: 255036 RVA: 0x00F08740 File Offset: 0x00F06940
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIText))
			};
		}

		// Token: 0x0603E43D RID: 255037 RVA: 0x00F0879C File Offset: 0x00F0699C
		public override void Refresh(ITetrisTargetData data, bool isSelected, int gridIndex)
		{
			this.SetSpriteByPath(data.Icon, base.GetSprite(0), false, null, null);
			base.GetText(1).SetText(data.Num.ToString(), true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), data.Tip, Array.Empty<object>());
		}
	}
}
