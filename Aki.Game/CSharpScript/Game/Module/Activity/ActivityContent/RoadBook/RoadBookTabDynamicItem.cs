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
	// Token: 0x0200515D RID: 20829
	[NullableContext(1)]
	[Nullable(0)]
	public class RoadBookTabDynamicItem : UiPanelBase, IDynamicScrollBaseItem<RoadBookAreaData>
	{
		// Token: 0x060340D9 RID: 213209 RVA: 0x00E90000 File Offset: 0x00E8E200
		public UniTask Init(UUIItem actor)
		{
			RoadBookTabDynamicItem.<Init>d__1 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.actor = actor;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<RoadBookTabDynamicItem.<Init>d__1>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x060340DA RID: 213210 RVA: 0x00E9004B File Offset: 0x00E8E24B
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x060340DB RID: 213211 RVA: 0x00E90084 File Offset: 0x00E8E284
		public FVector2D GetItemSize(RoadBookAreaData itemData)
		{
			UUIItem rootItem = base.GetRootItem();
			this.VectorValue.Set((double)rootItem.GetWidth(), (double)rootItem.GetHeight());
			return this.VectorValue.ToUeVector2D(false);
		}

		// Token: 0x060340DC RID: 213212 RVA: 0x00E900BD File Offset: 0x00E8E2BD
		public void ClearItem()
		{
		}

		// Token: 0x0401B8E7 RID: 112871
		private Vector2D VectorValue;
	}
}
