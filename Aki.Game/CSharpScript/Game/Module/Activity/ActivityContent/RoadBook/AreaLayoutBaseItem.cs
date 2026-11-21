using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x0200516F RID: 20847
	[NullableContext(1)]
	[Nullable(0)]
	public class AreaLayoutBaseItem : UiPanelBase, IDynamicScrollBaseItem<AreaLayoutItemData>
	{
		// Token: 0x0603412A RID: 213290 RVA: 0x00E91554 File Offset: 0x00E8F754
		public UniTask Init(UUIItem actor)
		{
			AreaLayoutBaseItem.<Init>d__1 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.actor = actor;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<AreaLayoutBaseItem.<Init>d__1>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x0603412B RID: 213291 RVA: 0x00E915A0 File Offset: 0x00E8F7A0
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIVerticalLayout))
			};
		}

		// Token: 0x0603412C RID: 213292 RVA: 0x00E91628 File Offset: 0x00E8F828
		public FVector2D GetItemSize(AreaLayoutItemData itemData)
		{
			float width = this.RootItem.Width;
			if (itemData.IsTitle)
			{
				this.VectorValue.Set((double)width, (double)base.GetVerticalLayout(4).RootUIComp.Get().Height);
				if (!itemData.AreaData.IsUnlock)
				{
					this.VectorValue.Y += (double)(base.GetItem(3).GetHeight() + base.GetVerticalLayout(4).GetSpacing());
				}
			}
			else
			{
				this.VectorValue.Set((double)width, (double)base.GetItem(1).GetHeight());
			}
			this.VectorValue.Y += (double)itemData.ExtraHeight.GetValueOrDefault();
			return this.VectorValue.ToUeVector2D(false);
		}

		// Token: 0x0603412D RID: 213293 RVA: 0x00E916EF File Offset: 0x00E8F8EF
		public void ClearItem()
		{
		}

		// Token: 0x0401B936 RID: 112950
		private Vector2D VectorValue;
	}
}
