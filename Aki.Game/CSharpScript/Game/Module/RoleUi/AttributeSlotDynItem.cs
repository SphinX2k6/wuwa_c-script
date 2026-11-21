using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi
{
	// Token: 0x02003C90 RID: 15504
	[NullableContext(1)]
	[Nullable(0)]
	public class AttributeSlotDynItem : UiPanelBase, IDynamicScrollBaseItem<IAttributeInfo>
	{
		// Token: 0x06027A91 RID: 162449 RVA: 0x00B1B6D4 File Offset: 0x00B198D4
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

		// Token: 0x06027A92 RID: 162450 RVA: 0x00B1B720 File Offset: 0x00B19920
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

		// Token: 0x06027A93 RID: 162451 RVA: 0x00B1B76B File Offset: 0x00B1996B
		public void ClearItem()
		{
		}

		// Token: 0x04015A2E RID: 88622
		[Nullable(2)]
		private Vector2D ItemSizeVector;
	}
}
