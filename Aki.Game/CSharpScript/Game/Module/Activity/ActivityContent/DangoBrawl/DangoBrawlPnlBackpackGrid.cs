using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005742 RID: 22338
	public class DangoBrawlPnlBackpackGrid : UiPanelBase
	{
		// Token: 0x17006A4B RID: 27211
		// (get) Token: 0x06037079 RID: 225401 RVA: 0x00F5BEA0 File Offset: 0x00F5A0A0
		public PanelPos MyPanelPos
		{
			get
			{
				return this.PanelPos;
			}
		}

		// Token: 0x17006A4C RID: 27212
		// (get) Token: 0x0603707A RID: 225402 RVA: 0x00F5BEA8 File Offset: 0x00F5A0A8
		public EDangoBrawlGridState MyState
		{
			get
			{
				return this.State;
			}
		}

		// Token: 0x0603707B RID: 225403 RVA: 0x00F5BEB0 File Offset: 0x00F5A0B0
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

		// Token: 0x0603707C RID: 225404 RVA: 0x00F5BF19 File Offset: 0x00F5A119
		public void BindData(PanelPos panelPos)
		{
			this.PanelPos = panelPos;
			this.SetGridState(EDangoBrawlGridState.Default);
		}

		// Token: 0x0603707D RID: 225405 RVA: 0x00F5BF29 File Offset: 0x00F5A129
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

		// Token: 0x0401D1E3 RID: 119267
		private PanelPos PanelPos = new PanelPos(0, 0);

		// Token: 0x0401D1E4 RID: 119268
		private EDangoBrawlGridState State;

		// Token: 0x0200B314 RID: 45844
		private enum EComponents
		{
			// Token: 0x0403753D RID: 226621
			SprGreen,
			// Token: 0x0403753E RID: 226622
			SprRed
		}
	}
}
