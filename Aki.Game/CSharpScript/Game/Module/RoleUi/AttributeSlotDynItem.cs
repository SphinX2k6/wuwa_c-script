using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi
{
	// Token: 0x02004CDE RID: 19678
	[NullableContext(1)]
	[Nullable(0)]
	public class AttributeSlotDynItem : UiPanelBase, IDynamicScrollBaseItem<IAttributeInfo>
	{
		// Token: 0x06032CBC RID: 208060 RVA: 0x00BD5FCC File Offset: 0x00BD41CC
		public FVector2D GetItemSize(IAttributeInfo data)
		{
			if (this.ItemSizeVector == null)
			{
				this.ItemSizeVector = Vector2D.Create();
			}
			UUIItem rootItem = base.GetRootItem();
			this.ItemSizeVector.Set((double)rootItem.GetWidth(), (double)rootItem.GetHeight());
			return this.ItemSizeVector.ToUeVector2D(false);
		}

		// Token: 0x06032CBD RID: 208061 RVA: 0x00BD6018 File Offset: 0x00BD4218
		public UniTask Init(UUIItem actor)
		{
			AttributeSlotDynItem.<Init>d__2 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.actor = actor;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<AttributeSlotDynItem.<Init>d__2>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x06032CBE RID: 208062 RVA: 0x00BD6063 File Offset: 0x00BD4263
		public void ClearItem()
		{
		}

		// Token: 0x0401B0AA RID: 110762
		[Nullable(2)]
		private Vector2D ItemSizeVector;
	}
}
