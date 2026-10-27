using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02006023 RID: 24611
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class TetrisTipsTargetGrid : GridProxyAbstract<ITetrisTargetData>
	{
		// Token: 0x0603E4D6 RID: 255190 RVA: 0x00F0C38F File Offset: 0x00F0A58F
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x0603E4D7 RID: 255191 RVA: 0x00F0C3C8 File Offset: 0x00F0A5C8
		public override void Refresh(ITetrisTargetData data, bool isSelected, int gridIndex)
		{
			this.SetSpriteByPath(data.Icon, base.GetSprite(0), false, null, null);
			base.GetText(1).SetText(data.Num.ToString(), true);
		}
	}
}
