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
	// Token: 0x020061DF RID: 25055
	[NullableContext(1)]
	[Nullable(0)]
	public class RoadBookTabDynamicItem : UiPanelBase, IDynamicScrollBaseItem<RoadBookAreaData>
	{
		// Token: 0x0603F418 RID: 259096 RVA: 0x00F490A8 File Offset: 0x00F472A8
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

		// Token: 0x0603F419 RID: 259097 RVA: 0x00F490F3 File Offset: 0x00F472F3
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x0603F41A RID: 259098 RVA: 0x00F4912C File Offset: 0x00F4732C
		public FVector2D GetItemSize(RoadBookAreaData itemData)
		{
			UUIItem rootItem = base.GetRootItem();
			this.VectorValue.Set((double)rootItem.GetWidth(), (double)rootItem.GetHeight());
			return this.VectorValue.ToUeVector2D(false);
		}

		// Token: 0x0603F41B RID: 259099 RVA: 0x00F49165 File Offset: 0x00F47365
		public void ClearItem()
		{
		}

		// Token: 0x04020FB8 RID: 135096
		private Vector2D VectorValue;
	}
}
