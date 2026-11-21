using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Game.Module.Activity.ActivityContent.Tetris.Activity;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris.View
{
	// Token: 0x02002FE6 RID: 12262
	[NullableContext(1)]
	[Nullable(0)]
	public class TetrisTipsTargetView : TetrisTipsBaseView
	{
		// Token: 0x0601D198 RID: 119192 RVA: 0x008E514A File Offset: 0x008E334A
		public TetrisTipsTargetView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0601D199 RID: 119193 RVA: 0x008E5154 File Offset: 0x008E3354
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0601D19A RID: 119194 RVA: 0x008E51BD File Offset: 0x008E33BD
		protected override void OnStart()
		{
			base.OnStart();
			this.Param = (this.OpenParam as Dictionary<int, int>);
			this.TargetsList = new GenericLayout<TetrisTipsTargetGrid, TetrisTargetData>(base.GetHorizontalLayout(0), new Func<TetrisTipsTargetGrid>(this.UpdateItem), null, false, true);
		}

		// Token: 0x0601D19B RID: 119195 RVA: 0x008E51F7 File Offset: 0x008E33F7
		protected override void OnBeforeShow()
		{
			this.Refresh();
		}

		// Token: 0x0601D19C RID: 119196 RVA: 0x008E5200 File Offset: 0x008E3400
		private void Refresh()
		{
			List<TetrisTargetData> list = new List<TetrisTargetData>();
			foreach (KeyValuePair<int, int> keyValuePair in this.Param)
			{
				list.Add(new TetrisTargetData
				{
					Icon = ActivityTetrisConfig.Instance.GetGemConfig(keyValuePair.Key).Value.TargetIconPath,
					Num = keyValuePair.Value,
					Tip = ((keyValuePair.Key == 0) ? "Tetristext_09" : "Tetristext_10")
				});
			}
			this.TargetsList.RefreshByData(list, null, false);
		}

		// Token: 0x0601D19D RID: 119197 RVA: 0x008E52BC File Offset: 0x008E34BC
		private TetrisTipsTargetGrid UpdateItem()
		{
			return new TetrisTipsTargetGrid();
		}

		// Token: 0x0400F541 RID: 62785
		[Nullable(2)]
		private Dictionary<int, int> Param;

		// Token: 0x0400F542 RID: 62786
		private GenericLayout<TetrisTipsTargetGrid, TetrisTargetData> TargetsList;

		// Token: 0x02008C5F RID: 35935
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x0402C6D8 RID: 181976
			public const int List = 0;

			// Token: 0x0402C6D9 RID: 181977
			public const int Item = 1;
		}
	}
}
