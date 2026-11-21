using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DE7 RID: 15847
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeSelectRoleBaseGrid : UiPanelBase, IDynamicScrollBaseItem<RoguelikeSelectRoleData>
	{
		// Token: 0x060287B7 RID: 165815 RVA: 0x00B591BC File Offset: 0x00B573BC
		public FVector2D GetItemSize(RoguelikeSelectRoleData data)
		{
			if (this.ItemSizeVector == null)
			{
				this.ItemSizeVector = Vector2D.Create();
			}
			UUIItem rootItem = base.GetRootItem();
			this.ItemSizeVector.Set((double)rootItem.GetWidth(), (double)rootItem.GetHeight());
			return this.ItemSizeVector.ToUeVector2D(false);
		}

		// Token: 0x060287B8 RID: 165816 RVA: 0x00B59208 File Offset: 0x00B57408
		public UniTask Init(UUIItem actor)
		{
			RoguelikeSelectRoleBaseGrid.<Init>d__2 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.actor = actor;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<RoguelikeSelectRoleBaseGrid.<Init>d__2>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x060287B9 RID: 165817 RVA: 0x00B59253 File Offset: 0x00B57453
		public void ClearItem()
		{
		}

		// Token: 0x04015F92 RID: 90002
		private Vector2D ItemSizeVector;
	}
}
