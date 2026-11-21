using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonComponentModel;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonSubComponent
{
	// Token: 0x0200487B RID: 18555
	public class InstanceDungeonRankTimeItem : UiPanelBase
	{
		// Token: 0x0602EACD RID: 191181 RVA: 0x00D07348 File Offset: 0x00D05548
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

		// Token: 0x0602EACE RID: 191182 RVA: 0x00D07414 File Offset: 0x00D05614
		public void Refresh()
		{
			TableTextArgNew content = this.ItemModel.GetContent();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), content.TextKey, content.Params);
			base.GetButton(0).RootUIComp.Get().SetUIActive(true);
		}

		// Token: 0x04018D0D RID: 101645
		[Nullable(1)]
		public RankTimeItemModelBase ItemModel;

		// Token: 0x0200A525 RID: 42277
		private enum EComponentDefine
		{
			// Token: 0x0403321E RID: 209438
			Button,
			// Token: 0x0403321F RID: 209439
			Content
		}
	}
}
