using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.SceneItem.ExploreInteractiveCondition
{
	// Token: 0x020071FE RID: 29182
	public abstract class CustomConditionListener
	{
		// Token: 0x060476CD RID: 292557 RVA: 0x0122F6B0 File Offset: 0x0122D8B0
		[NullableContext(1)]
		public CustomConditionListener(Action<bool> onConditionChange)
		{
			this.OnConditionChange = onConditionChange;
		}

		// Token: 0x060476CE RID: 292558
		public abstract bool CheckCondition();

		// Token: 0x060476CF RID: 292559
		public abstract void SetListenerEnable(bool enable);

		// Token: 0x060476D0 RID: 292560 RVA: 0x0122F6BF File Offset: 0x0122D8BF
		public void Clear()
		{
			this.SetListenerEnable(false);
			this.OnConditionChange = null;
		}

		// Token: 0x04025906 RID: 153862
		[Nullable(2)]
		protected Action<bool> OnConditionChange;
	}
}
