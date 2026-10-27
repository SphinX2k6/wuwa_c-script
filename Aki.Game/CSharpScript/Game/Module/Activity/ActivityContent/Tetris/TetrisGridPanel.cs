using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02006000 RID: 24576
	public class TetrisGridPanel : UiPanelBase
	{
		// Token: 0x0603E40E RID: 254990 RVA: 0x00F07A6B File Offset: 0x00F05C6B
		public TetrisGridPanel(int row = 0, int column = 0)
		{
			this.Row = row;
			this.Column = column;
		}

		// Token: 0x0603E40F RID: 254991 RVA: 0x00F07A84 File Offset: 0x00F05C84
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUISprite)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x0603E410 RID: 254992 RVA: 0x00F07AE0 File Offset: 0x00F05CE0
		[NullableContext(1)]
		public void Refresh(ICellInstance data)
		{
			TetrisGem? gemConfig = ActivityTetrisConfig.Instance.GetGemConfig(data.ColorId);
			base.GetSprite(1).SetUIActive(true);
			this.SetSpriteByPath((data.GemType == EGemType.None) ? gemConfig.Value.IconPath : gemConfig.Value.GemPath, base.GetSprite(1), false, null, null);
			this.SetSpriteByPath(gemConfig.Value.BgPath, base.GetSprite(0), false, null, null);
		}

		// Token: 0x0402084A RID: 133194
		public int Row;

		// Token: 0x0402084B RID: 133195
		public int Column;
	}
}
