using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.InstanceDungeon.Define;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x02005862 RID: 22626
	[NullableContext(1)]
	[Nullable(0)]
	public class InstanceDetectDynamicItem : UiPanelBase, IDynamicScrollBaseItem<InstanceDetectionDynamicData>
	{
		// Token: 0x06039860 RID: 235616 RVA: 0x00DA856C File Offset: 0x00DA676C
		public UniTask Init(UUIItem actor)
		{
			InstanceDetectDynamicItem.<Init>d__0 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.actor = actor;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<InstanceDetectDynamicItem.<Init>d__0>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x06039861 RID: 235617 RVA: 0x00DA85B8 File Offset: 0x00DA67B8
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

		// Token: 0x06039862 RID: 235618 RVA: 0x00DA8624 File Offset: 0x00DA6824
		public FVector2D GetItemSize(InstanceDetectionDynamicData data)
		{
			if (data.InstanceSeriesTitle != 0)
			{
				UUIItem item = base.GetItem(0);
				return new FVector2D(item.GetWidth(), item.GetHeight());
			}
			UUIItem item2 = base.GetItem(1);
			return new FVector2D(item2.GetWidth(), item2.GetHeight());
		}

		// Token: 0x06039863 RID: 235619 RVA: 0x00DA866C File Offset: 0x00DA686C
		public void ClearItem()
		{
		}
	}
}
