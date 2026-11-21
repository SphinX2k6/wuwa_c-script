using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity
{
	// Token: 0x02004EE9 RID: 20201
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivitySwitchToggleDynamicItem : UiPanelBase, IDynamicScrollBaseItem<IActivityCategoryTabData>
	{
		// Token: 0x170062C6 RID: 25286
		// (get) Token: 0x06032C7C RID: 207996 RVA: 0x00E42A12 File Offset: 0x00E40C12
		// (set) Token: 0x06032C7D RID: 207997 RVA: 0x00E42A1A File Offset: 0x00E40C1A
		private Vector2D ItemSizeVector { get; set; }

		// Token: 0x06032C7E RID: 207998 RVA: 0x00E42A24 File Offset: 0x00E40C24
		[NullableContext(1)]
		public UniTask Init(UUIItem actor)
		{
			ActivitySwitchToggleDynamicItem.<Init>d__5 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.actor = actor;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<ActivitySwitchToggleDynamicItem.<Init>d__5>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x06032C7F RID: 207999 RVA: 0x00E42A70 File Offset: 0x00E40C70
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06032C80 RID: 208000 RVA: 0x00E42ADC File Offset: 0x00E40CDC
		[NullableContext(1)]
		public FVector2D GetItemSize(IActivityCategoryTabData data)
		{
			if (this.ItemSizeVector == null)
			{
				this.ItemSizeVector = Vector2D.Create();
			}
			if (data.IsLineType)
			{
				UUIItem item = base.GetItem(1);
				this.ItemSizeVector.Set((double)item.GetWidth(), (double)item.GetHeight());
				return this.ItemSizeVector.ToUeVector2D(false);
			}
			UUIItem rootItem = base.GetRootItem();
			this.ItemSizeVector.Set((double)rootItem.GetWidth(), (double)rootItem.GetHeight());
			return this.ItemSizeVector.ToUeVector2D(false);
		}

		// Token: 0x06032C81 RID: 208001 RVA: 0x00E42B5E File Offset: 0x00E40D5E
		public void ClearItem()
		{
		}

		// Token: 0x0200AC44 RID: 44100
		[NullableContext(0)]
		private class ECategoryComponents
		{
			// Token: 0x040354D0 RID: 218320
			public const int ItemTypeTitle = 1;

			// Token: 0x040354D1 RID: 218321
			public const int PanelTab = 0;
		}
	}
}
