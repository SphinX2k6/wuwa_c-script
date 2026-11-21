using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A3C RID: 14908
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseBuildingDevelopBottomGrid : GridProxyAbstract<TrapDefenseBuildingSlotData>
	{
		// Token: 0x06026564 RID: 157028 RVA: 0x00ABC840 File Offset: 0x00ABAA40
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06026565 RID: 157029 RVA: 0x00ABC888 File Offset: 0x00ABAA88
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseBuildingDevelopBottomGrid.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseBuildingDevelopBottomGrid.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06026566 RID: 157030 RVA: 0x00ABC8CB File Offset: 0x00ABAACB
		protected override void OnBeforeDestroy()
		{
			this.DataItem = null;
		}

		// Token: 0x06026567 RID: 157031 RVA: 0x00ABC8D4 File Offset: 0x00ABAAD4
		public override void Refresh(TrapDefenseBuildingSlotData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			this.UpdateData();
		}

		// Token: 0x06026568 RID: 157032 RVA: 0x00ABC8E3 File Offset: 0x00ABAAE3
		public void UpdateData()
		{
			this.DataItem.Refresh(this.Data);
		}

		// Token: 0x06026569 RID: 157033 RVA: 0x00ABC8F6 File Offset: 0x00ABAAF6
		public override void OnSelected(bool fireEvent)
		{
			TrapDefenseBuildingDevelopBottomInfoItem dataItem = this.DataItem;
			if (dataItem != null)
			{
				dataItem.SetSelected(true);
			}
			if (fireEvent)
			{
				Action<TrapDefenseBuildingSlotData> onClickCb = this.OnClickCb;
				if (onClickCb == null)
				{
					return;
				}
				onClickCb(this.Data);
			}
		}

		// Token: 0x0602656A RID: 157034 RVA: 0x00ABC923 File Offset: 0x00ABAB23
		public override void OnDeselected(bool fireEvent)
		{
			TrapDefenseBuildingDevelopBottomInfoItem dataItem = this.DataItem;
			if (dataItem == null)
			{
				return;
			}
			dataItem.SetSelected(false);
		}

		// Token: 0x0602656B RID: 157035 RVA: 0x00ABC936 File Offset: 0x00ABAB36
		public TrapDefenseBuildingDevelopBottomInfoItem GetDataItem()
		{
			return this.DataItem;
		}

		// Token: 0x040150A4 RID: 86180
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<TrapDefenseBuildingSlotData> OnClickCb;

		// Token: 0x040150A5 RID: 86181
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<TrapDefenseBuildingSlotData, bool> CanExecuteChangeCb;

		// Token: 0x040150A6 RID: 86182
		[Nullable(2)]
		protected TrapDefenseBuildingSlotData Data;

		// Token: 0x040150A7 RID: 86183
		[Nullable(2)]
		protected TrapDefenseBuildingDevelopBottomInfoItem DataItem;

		// Token: 0x02009608 RID: 38408
		[NullableContext(0)]
		private class EGrid
		{
			// Token: 0x0402ED88 RID: 191880
			public const int Item = 0;
		}
	}
}
