using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x020051FF RID: 20991
	[NullableContext(1)]
	[Nullable(0)]
	public class RealmBetweenTabDynamicItem : UiPanelBase, IDynamicScrollBaseItem<RealmBetweenAreaData>
	{
		// Token: 0x06034453 RID: 214099 RVA: 0x00E9F4AC File Offset: 0x00E9D6AC
		public UniTask Init(UUIItem actor)
		{
			RealmBetweenTabDynamicItem.<Init>d__1 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.actor = actor;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<RealmBetweenTabDynamicItem.<Init>d__1>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x06034454 RID: 214100 RVA: 0x00E9F4F7 File Offset: 0x00E9D6F7
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x06034455 RID: 214101 RVA: 0x00E9F530 File Offset: 0x00E9D730
		public FVector2D GetItemSize(RealmBetweenAreaData itemData)
		{
			UUIItem rootItem = base.GetRootItem();
			this.VectorValue.Set((double)rootItem.GetWidth(), (double)rootItem.GetHeight());
			return this.VectorValue.ToUeVector2D(false);
		}

		// Token: 0x06034456 RID: 214102 RVA: 0x00E9F569 File Offset: 0x00E9D769
		public void ClearItem()
		{
		}

		// Token: 0x0401BBEC RID: 113644
		private Vector2D VectorValue;
	}
}
