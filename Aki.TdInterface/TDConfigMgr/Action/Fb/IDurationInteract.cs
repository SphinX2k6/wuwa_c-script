using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028CA RID: 10442
	public class IDurationInteract
	{
		// Token: 0x0600E87D RID: 59517 RVA: 0x00225C3D File Offset: 0x00223E3D
		public static IDurationInteract Create(IDurationInteract? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDurationInteract
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004397 RID: 17303
		// (get) Token: 0x0600E87E RID: 59518 RVA: 0x00225C5C File Offset: 0x00223E5C
		public virtual float Duration
		{
			get
			{
				return this.Instance.Duration;
			}
		}

		// Token: 0x04008014 RID: 32788
		private IDurationInteract Instance;
	}
}
