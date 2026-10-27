using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity
{
	// Token: 0x02005EFE RID: 24318
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivitySelectContentBase : UiPanelBase, IDynamicScrollBaseItem<ActivityBaseData>
	{
		// Token: 0x0603DCB1 RID: 253105 RVA: 0x00EF06F8 File Offset: 0x00EEE8F8
		public UniTask Init(UUIItem actor)
		{
			ActivitySelectContentBase.<Init>d__0 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.actor = actor;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<ActivitySelectContentBase.<Init>d__0>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x0603DCB2 RID: 253106 RVA: 0x00EF0743 File Offset: 0x00EEE943
		public void ClearItem()
		{
		}

		// Token: 0x0603DCB3 RID: 253107 RVA: 0x00EF0745 File Offset: 0x00EEE945
		public FVector2D GetItemSize(ActivityBaseData data)
		{
			Vector2D vector2D = Vector2D.Create();
			vector2D.Set((double)this.RootItem.Width, (double)this.RootItem.Height);
			return vector2D.ToUeVector2D(false);
		}
	}
}
