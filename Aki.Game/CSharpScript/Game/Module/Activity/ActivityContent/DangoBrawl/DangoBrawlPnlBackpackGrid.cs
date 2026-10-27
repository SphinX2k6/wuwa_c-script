using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067F2 RID: 26610
	public class DangoBrawlPnlBackpackGrid : UiPanelBase
	{
		// Token: 0x1700970A RID: 38666
		// (get) Token: 0x06042524 RID: 271652 RVA: 0x0101A95C File Offset: 0x01018B5C
		public PanelPos MyPanelPos
		{
			get
			{
				return this.PanelPos;
			}
		}

		// Token: 0x1700970B RID: 38667
		// (get) Token: 0x06042525 RID: 271653 RVA: 0x0101A964 File Offset: 0x01018B64
		public EDangoBrawlGridState MyState
		{
			get
			{
				return this.State;
			}
		}

		// Token: 0x06042526 RID: 271654 RVA: 0x0101A96C File Offset: 0x01018B6C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06042527 RID: 271655 RVA: 0x0101A9D5 File Offset: 0x01018BD5
		public void BindData(PanelPos panelPos)
		{
			this.PanelPos = panelPos;
			this.SetGridState(EDangoBrawlGridState.Default);
		}

		// Token: 0x06042528 RID: 271656 RVA: 0x0101A9E5 File Offset: 0x01018BE5
		public void SetGridState(EDangoBrawlGridState state)
		{
			this.State = state;
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				item.SetUIActive(state == EDangoBrawlGridState.Success);
			}
			UUIItem item2 = base.GetItem(1);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(state == EDangoBrawlGridState.Fail);
		}

		// Token: 0x04022986 RID: 141702
		private PanelPos PanelPos = new PanelPos(0, 0);

		// Token: 0x04022987 RID: 141703
		private EDangoBrawlGridState State;

		// Token: 0x0200C947 RID: 51527
		private enum EComponents
		{
			// Token: 0x0403CC50 RID: 248912
			SprGreen,
			// Token: 0x0403CC51 RID: 248913
			SprRed
		}
	}
}
