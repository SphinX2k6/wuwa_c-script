using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.SceneItem.ExploreInteractiveCondition
{
	// Token: 0x020062B3 RID: 25267
	public abstract class CustomConditionListener
	{
		// Token: 0x0603CFD5 RID: 249813 RVA: 0x01189272 File Offset: 0x01187472
		[NullableContext(1)]
		public CustomConditionListener(Action<bool> onConditionChange)
		{
			this.OnConditionChange = onConditionChange;
		}

		// Token: 0x0603CFD6 RID: 249814
		public abstract bool CheckCondition();

		// Token: 0x0603CFD7 RID: 249815
		public abstract void SetListenerEnable(bool enable);

		// Token: 0x0603CFD8 RID: 249816 RVA: 0x01189281 File Offset: 0x01187481
		public void Clear()
		{
			this.SetListenerEnable(false);
			this.OnConditionChange = null;
		}

		// Token: 0x04020575 RID: 132469
		[Nullable(2)]
		protected Action<bool> OnConditionChange;
	}
}
