using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris.View
{
	// Token: 0x02002FE3 RID: 12259
	[NullableContext(1)]
	[Nullable(0)]
	public class TetrisShapePanel : UiPanelBase
	{
		// Token: 0x0601D188 RID: 119176 RVA: 0x008E4CF8 File Offset: 0x008E2EF8
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

		// Token: 0x0601D189 RID: 119177 RVA: 0x008E4D61 File Offset: 0x008E2F61
		public void SetPoolManager(IGridPoolManager manager)
		{
			this.PoolManager = manager;
		}

		// Token: 0x0601D18A RID: 119178 RVA: 0x008E4D6C File Offset: 0x008E2F6C
		[NullableContext(2)]
		public void RefreshView(BlockInstance data)
		{
			if (base.IsDestroyOrDestroying || this.WaitToDestroy)
			{
				return;
			}
			this.ClearItems();
			if (data == null)
			{
				return;
			}
			UUIItem item = base.GetItem(0);
			UUIItem item2 = base.GetItem(1);
			int boundRectWidth = data.BoundRectWidth;
			int boundRectHeight = data.BoundRectHeight;
			int num = int.MaxValue;
			int num2 = int.MinValue;
			int num3 = int.MaxValue;
			int num4 = int.MinValue;
			ValueTuple<int, int>[] offsets = data.Offsets;
			for (int i = 0; i < offsets.Length; i++)
			{
				ValueTuple<int, int> rotatedOffset = TetrisUtils.GetRotatedOffset(offsets[i], boundRectWidth, boundRectHeight, data.Rotation);
				if (rotatedOffset.Item1 < num)
				{
					num = rotatedOffset.Item1;
				}
				if (rotatedOffset.Item1 > num2)
				{
					num2 = rotatedOffset.Item1;
				}
				if (rotatedOffset.Item2 < num3)
				{
					num3 = rotatedOffset.Item2;
				}
				if (rotatedOffset.Item2 > num4)
				{
					num4 = rotatedOffset.Item2;
				}
			}
			int num5 = num4 - num3 + 1;
			int num6 = num2 - num + 1;
			float num7 = (float)(5 - num5) / 2f - (float)num3;
			float num8 = (float)(5 - num6) / 2f - (float)num;
			for (int j = 0; j < data.Offsets.Length; j++)
			{
				ValueTuple<int, int> rotatedOffset2 = TetrisUtils.GetRotatedOffset(data.Offsets[j], boundRectWidth, boundRectHeight, data.Rotation);
				ValueTuple<EGemType, EBombType> cellAttachmentTypes = data.GetCellAttachmentTypes(j);
				EGemType item3 = cellAttachmentTypes.Item1;
				EBombType item4 = cellAttachmentTypes.Item2;
				CellInstance data2 = new CellInstance
				{
					ColorId = data.ColorId,
					GemType = item3,
					BombType = item4
				};
				ValueTuple<float, float> offset = new ValueTuple<float, float>((float)rotatedOffset2.Item1 + num8, (float)rotatedOffset2.Item2 + num7);
				this.CreateShape(item, item2, offset, data2);
			}
		}

		// Token: 0x0601D18B RID: 119179 RVA: 0x008E4F28 File Offset: 0x008E3128
		private void CreateShape(UUIItem itemTemplate, UUIItem list, [TupleElementNames(new string[]
		{
			"Row",
			"Column"
		})] [Nullable(0)] ValueTuple<float, float> offset, CellInstance data)
		{
			float width = itemTemplate.GetWidth();
			float height = itemTemplate.GetHeight();
			ValueTuple<TetrisGridPanel, bool> grid = this.PoolManager.GetGrid(list);
			TetrisGridPanel item = grid.Item1;
			bool item2 = grid.Item2;
			UUIItem uuiitem;
			if (item2)
			{
				uuiitem = LguiUtil.Instance.CopyItem(itemTemplate, list);
			}
			else
			{
				uuiitem = item.GetRootItem();
			}
			float anchorOffsetX = width / 2f + offset.Item2 * width;
			uuiitem.SetAnchorOffsetX(anchorOffsetX);
			float anchorOffsetY = -(height / 2f) - offset.Item1 * height;
			uuiitem.SetAnchorOffsetY(anchorOffsetY);
			if (item2)
			{
				this.CreateItemTemplate(uuiitem, item, data, this.RefreshVersion).Forget();
				return;
			}
			this.ListItems.Add(item);
			item.SetUiActive(true);
			item.Refresh(data);
		}

		// Token: 0x0601D18C RID: 119180 RVA: 0x008E4FE0 File Offset: 0x008E31E0
		private UniTask CreateItemTemplate(UUIItem item, TetrisGridPanel itemView, CellInstance data, long refreshVersion)
		{
			TetrisShapePanel.<CreateItemTemplate>d__7 <CreateItemTemplate>d__;
			<CreateItemTemplate>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateItemTemplate>d__.<>4__this = this;
			<CreateItemTemplate>d__.item = item;
			<CreateItemTemplate>d__.itemView = itemView;
			<CreateItemTemplate>d__.data = data;
			<CreateItemTemplate>d__.refreshVersion = refreshVersion;
			<CreateItemTemplate>d__.<>1__state = -1;
			<CreateItemTemplate>d__.<>t__builder.Start<TetrisShapePanel.<CreateItemTemplate>d__7>(ref <CreateItemTemplate>d__);
			return <CreateItemTemplate>d__.<>t__builder.Task;
		}

		// Token: 0x0601D18D RID: 119181 RVA: 0x008E5044 File Offset: 0x008E3244
		public List<TetrisGridPanel> GetAllListItems()
		{
			return this.ListItems;
		}

		// Token: 0x0601D18E RID: 119182 RVA: 0x008E504C File Offset: 0x008E324C
		public void ClearItems()
		{
			this.RefreshVersion += 1L;
			foreach (TetrisGridPanel grid in this.ListItems)
			{
				this.PoolManager.ReturnGrid(grid);
			}
			this.ListItems.Clear();
		}

		// Token: 0x0601D18F RID: 119183 RVA: 0x008E50C0 File Offset: 0x008E32C0
		protected override void OnBeforeDestroy()
		{
			base.OnBeforeDestroy();
			this.ClearItems();
			this.PoolManager = null;
		}

		// Token: 0x0400F53D RID: 62781
		private readonly List<TetrisGridPanel> ListItems = new List<TetrisGridPanel>();

		// Token: 0x0400F53E RID: 62782
		[Nullable(2)]
		private IGridPoolManager PoolManager;

		// Token: 0x0400F53F RID: 62783
		private long RefreshVersion;
	}
}
