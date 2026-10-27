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
	// Token: 0x02006281 RID: 25217
	[NullableContext(1)]
	[Nullable(0)]
	public class RealmBetweenTabDynamicItem : UiPanelBase, IDynamicScrollBaseItem<RealmBetweenAreaData>
	{
		// Token: 0x0603F792 RID: 259986 RVA: 0x00F58550 File Offset: 0x00F56750
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

		// Token: 0x0603F793 RID: 259987 RVA: 0x00F5859B File Offset: 0x00F5679B
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x0603F794 RID: 259988 RVA: 0x00F585D4 File Offset: 0x00F567D4
		public FVector2D GetItemSize(RealmBetweenAreaData itemData)
		{
			UUIItem rootItem = base.GetRootItem();
			this.VectorValue.Set((double)rootItem.GetWidth(), (double)rootItem.GetHeight());
			return this.VectorValue.ToUeVector2D(false);
		}

		// Token: 0x0603F795 RID: 259989 RVA: 0x00F5860D File Offset: 0x00F5680D
		public void ClearItem()
		{
		}

		// Token: 0x040212BD RID: 135869
		private Vector2D VectorValue;
	}
}
