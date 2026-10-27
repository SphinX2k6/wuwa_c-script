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
	// Token: 0x02004A94 RID: 19092
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseBuildingDevelopBottomGrid : GridProxyAbstract<TrapDefenseBuildingSlotData>
	{
		// Token: 0x060317D4 RID: 202708 RVA: 0x00B7888C File Offset: 0x00B76A8C
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

		// Token: 0x060317D5 RID: 202709 RVA: 0x00B788D4 File Offset: 0x00B76AD4
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseBuildingDevelopBottomGrid.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseBuildingDevelopBottomGrid.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060317D6 RID: 202710 RVA: 0x00B78917 File Offset: 0x00B76B17
		protected override void OnBeforeDestroy()
		{
			this.DataItem = null;
		}

		// Token: 0x060317D7 RID: 202711 RVA: 0x00B78920 File Offset: 0x00B76B20
		public override void Refresh(TrapDefenseBuildingSlotData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			this.UpdateData();
		}

		// Token: 0x060317D8 RID: 202712 RVA: 0x00B7892F File Offset: 0x00B76B2F
		public void UpdateData()
		{
			this.DataItem.Refresh(this.Data);
		}

		// Token: 0x060317D9 RID: 202713 RVA: 0x00B78942 File Offset: 0x00B76B42
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

		// Token: 0x060317DA RID: 202714 RVA: 0x00B7896F File Offset: 0x00B76B6F
		public override void OnDeselected(bool fireEvent)
		{
			TrapDefenseBuildingDevelopBottomInfoItem dataItem = this.DataItem;
			if (dataItem == null)
			{
				return;
			}
			dataItem.SetSelected(false);
		}

		// Token: 0x060317DB RID: 202715 RVA: 0x00B78982 File Offset: 0x00B76B82
		public TrapDefenseBuildingDevelopBottomInfoItem GetDataItem()
		{
			return this.DataItem;
		}

		// Token: 0x0401A752 RID: 108370
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<TrapDefenseBuildingSlotData> OnClickCb;

		// Token: 0x0401A753 RID: 108371
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<TrapDefenseBuildingSlotData, bool> CanExecuteChangeCb;

		// Token: 0x0401A754 RID: 108372
		[Nullable(2)]
		protected TrapDefenseBuildingSlotData Data;

		// Token: 0x0401A755 RID: 108373
		[Nullable(2)]
		protected TrapDefenseBuildingDevelopBottomInfoItem DataItem;

		// Token: 0x0200ABE8 RID: 44008
		[NullableContext(0)]
		private class EGrid
		{
			// Token: 0x040343D7 RID: 213975
			public const int Item = 0;
		}
	}
}
