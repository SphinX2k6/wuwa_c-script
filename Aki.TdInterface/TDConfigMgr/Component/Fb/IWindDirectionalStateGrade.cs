using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E8C RID: 3724
	public class IWindDirectionalStateGrade
	{
		// Token: 0x0600541A RID: 21530 RVA: 0x000CF552 File Offset: 0x000CD752
		public static IWindDirectionalStateGrade Create(IWindDirectionalStateGrade? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWindDirectionalStateGrade
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001AFD RID: 6909
		// (get) Token: 0x0600541B RID: 21531 RVA: 0x000CF571 File Offset: 0x000CD771
		public virtual string State
		{
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x17001AFE RID: 6910
		// (get) Token: 0x0600541C RID: 21532 RVA: 0x000CF57E File Offset: 0x000CD77E
		public virtual float Speed
		{
			get
			{
				return this.Instance.Speed;
			}
		}

		// Token: 0x17001AFF RID: 6911
		// (get) Token: 0x0600541D RID: 21533 RVA: 0x000CF58B File Offset: 0x000CD78B
		public virtual float Strength
		{
			get
			{
				return this.Instance.Strength;
			}
		}

		// Token: 0x04003029 RID: 12329
		private IWindDirectionalStateGrade Instance;
	}
}
