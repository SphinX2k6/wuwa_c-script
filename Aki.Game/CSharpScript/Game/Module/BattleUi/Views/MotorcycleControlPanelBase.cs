using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D9B RID: 23963
	public class MotorcycleControlPanelBase : BattleVisibleChildView
	{
		// Token: 0x0603CD36 RID: 249142 RVA: 0x00E9B7BF File Offset: 0x00E999BF
		public virtual void Tick(float delta)
		{
		}

		// Token: 0x0603CD37 RID: 249143 RVA: 0x00E9B7C4 File Offset: 0x00E999C4
		[NullableContext(1)]
		public UniTask Init(UUIItem parentItem, string resourceId)
		{
			MotorcycleControlPanelBase.<Init>d__1 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.parentItem = parentItem;
			<Init>d__.resourceId = resourceId;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<MotorcycleControlPanelBase.<Init>d__1>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x0603CD38 RID: 249144 RVA: 0x00E9B817 File Offset: 0x00E99A17
		protected override void OnBeforeDestroy()
		{
			base.OnBeforeDestroy();
			this.Reset();
		}
	}
}
