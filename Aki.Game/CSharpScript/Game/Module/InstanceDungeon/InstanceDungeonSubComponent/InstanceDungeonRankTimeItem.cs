using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonComponentModel;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonSubComponent
{
	// Token: 0x020058A3 RID: 22691
	public class InstanceDungeonRankTimeItem : UiPanelBase
	{
		// Token: 0x06039BAA RID: 236458 RVA: 0x00DB8430 File Offset: 0x00DB6630
		protected unsafe override void OnRegisterComponent()
		{
			RankTimeItemModelBase rankTimeItemModelBase = this.OpenParam as RankTimeItemModelBase;
			if (rankTimeItemModelBase == null)
			{
				throw new ArgumentNullException("OpenParam");
			}
			this.ItemModel = rankTimeItemModelBase;
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.ItemModel.ButtonClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06039BAB RID: 236459 RVA: 0x00DB84FC File Offset: 0x00DB66FC
		public void Refresh()
		{
			TableTextArgNew content = this.ItemModel.GetContent();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), content.TextKey, content.Params);
			base.GetButton(0).RootUIComp.Get().SetUIActive(true);
		}

		// Token: 0x0401E270 RID: 123504
		[Nullable(1)]
		public RankTimeItemModelBase ItemModel;

		// Token: 0x0200BB0C RID: 47884
		private enum EComponentDefine
		{
			// Token: 0x0403881D RID: 231453
			Button,
			// Token: 0x0403881E RID: 231454
			Content
		}
	}
}
