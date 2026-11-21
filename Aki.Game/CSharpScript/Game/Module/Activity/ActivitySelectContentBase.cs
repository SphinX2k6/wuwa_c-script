using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity
{
	// Token: 0x02004EE5 RID: 20197
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivitySelectContentBase : UiPanelBase, IDynamicScrollBaseItem<ActivityBaseData>
	{
		// Token: 0x06032C4C RID: 207948 RVA: 0x00E423BC File Offset: 0x00E405BC
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

		// Token: 0x06032C4D RID: 207949 RVA: 0x00E42407 File Offset: 0x00E40607
		public void ClearItem()
		{
		}

		// Token: 0x06032C4E RID: 207950 RVA: 0x00E42409 File Offset: 0x00E40609
		public FVector2D GetItemSize(ActivityBaseData data)
		{
			Vector2D vector2D = Vector2D.Create();
			vector2D.Set((double)this.RootItem.Width, (double)this.RootItem.Height);
			return vector2D.ToUeVector2D(false);
		}
	}
}
