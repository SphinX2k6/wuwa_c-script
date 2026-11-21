using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D7D RID: 19837
	public class MotorcycleControlPanelBase : BattleVisibleChildView
	{
		// Token: 0x06031C93 RID: 203923 RVA: 0x00DEC077 File Offset: 0x00DEA277
		public virtual void Tick(float delta)
		{
		}

		// Token: 0x06031C94 RID: 203924 RVA: 0x00DEC07C File Offset: 0x00DEA27C
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

		// Token: 0x06031C95 RID: 203925 RVA: 0x00DEC0CF File Offset: 0x00DEA2CF
		protected override void OnBeforeDestroy()
		{
			base.OnBeforeDestroy();
			this.Reset();
		}
	}
}
