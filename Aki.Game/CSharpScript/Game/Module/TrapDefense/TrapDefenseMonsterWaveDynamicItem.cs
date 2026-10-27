using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004AC4 RID: 19140
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseMonsterWaveDynamicItem : UiPanelBase, IDynamicScrollBaseItem<TrapDefenseMonsterWaveData>
	{
		// Token: 0x06031969 RID: 203113 RVA: 0x00B7F9A0 File Offset: 0x00B7DBA0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 13;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIGridLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIVerticalLayout));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603196A RID: 203114 RVA: 0x00B7FB7C File Offset: 0x00B7DD7C
		public FVector2D GetItemSize(TrapDefenseMonsterWaveData data)
		{
			if (this.VectorValue == null)
			{
				this.VectorValue = Vector2D.Create();
			}
			this.CalcValue();
			double num = Math.Ceiling((double)((float)data.GetMonsterDataList().Count / (float)this.ColCount));
			float num2 = data.IsEndlessStart ? this.EndlessTotalHeight : 0f;
			double inY = (double)(this.ItemRootHeight + num2) + (num - 1.0) * (double)this.CellHeight;
			this.VectorValue.Set((double)this.ItemRootWidth, inY);
			return this.VectorValue.ToUeVector2D(false);
		}

		// Token: 0x0603196B RID: 203115 RVA: 0x00B7FC10 File Offset: 0x00B7DE10
		private void CalcValue()
		{
			if (this.ItemRootWidth > 0f)
			{
				return;
			}
			UUIItem item = base.GetItem(10);
			UUIGridLayout gridLayout = base.GetGridLayout(7);
			UUIItem item2 = base.GetItem(9);
			UUIVerticalLayout verticalLayout = base.GetVerticalLayout(12);
			this.ItemRootWidth = this.RootItem.GetWidth() - 10f;
			this.ItemRootHeight = item.GetHeight();
			this.EndlessTotalHeight = verticalLayout.Padding.Top + verticalLayout.Padding.Bottom + item2.GetHeight();
			FVector2D cellSize = gridLayout.CellSize;
			FMargin padding = gridLayout.Padding;
			FVector2D spacing = gridLayout.Spacing;
			this.CellHeight = cellSize.Y + spacing.Y;
			this.ColCount = (int)Math.Floor((double)((this.ItemRootWidth - padding.Left - padding.Right + spacing.X) / this.CellHeight));
		}

		// Token: 0x0603196C RID: 203116 RVA: 0x00B7FCF0 File Offset: 0x00B7DEF0
		public UniTask Init(UUIItem actor)
		{
			TrapDefenseMonsterWaveDynamicItem.<Init>d__9 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.actor = actor;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<TrapDefenseMonsterWaveDynamicItem.<Init>d__9>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x0603196D RID: 203117 RVA: 0x00B7FD3B File Offset: 0x00B7DF3B
		public void ClearItem()
		{
		}

		// Token: 0x0401A7E0 RID: 108512
		private Vector2D VectorValue;

		// Token: 0x0401A7E1 RID: 108513
		private float ItemRootWidth;

		// Token: 0x0401A7E2 RID: 108514
		private float ItemRootHeight;

		// Token: 0x0401A7E3 RID: 108515
		private float EndlessTotalHeight;

		// Token: 0x0401A7E4 RID: 108516
		private int ColCount;

		// Token: 0x0401A7E5 RID: 108517
		private float CellHeight;
	}
}
