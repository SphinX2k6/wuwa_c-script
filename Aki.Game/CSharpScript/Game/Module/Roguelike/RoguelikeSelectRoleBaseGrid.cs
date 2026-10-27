using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004E1E RID: 19998
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeSelectRoleBaseGrid : UiPanelBase, IDynamicScrollBaseItem<RoguelikeSelectRoleData>
	{
		// Token: 0x0603394C RID: 211276 RVA: 0x00C0FC84 File Offset: 0x00C0DE84
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

		// Token: 0x0603394D RID: 211277 RVA: 0x00C0FCD0 File Offset: 0x00C0DED0
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

		// Token: 0x0603394E RID: 211278 RVA: 0x00C0FD1B File Offset: 0x00C0DF1B
		public void ClearItem()
		{
		}

		// Token: 0x0401B5BF RID: 112063
		private Vector2D ItemSizeVector;
	}
}
