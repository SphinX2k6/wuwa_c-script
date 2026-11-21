using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B40 RID: 11072
	public class IWuWaGoGame : IUiGame
	{
		// Token: 0x0600F376 RID: 62326 RVA: 0x002386B1 File Offset: 0x002368B1
		public static IWuWaGoGame Create(IWuWaGoGame? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWuWaGoGame
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170049A4 RID: 18852
		// (get) Token: 0x0600F377 RID: 62327 RVA: 0x002386D0 File Offset: 0x002368D0
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x170049A5 RID: 18853
		// (get) Token: 0x0600F378 RID: 62328 RVA: 0x002386DD File Offset: 0x002368DD
		public virtual int LevelCenterId
		{
			get
			{
				return this.Instance.LevelCenterId;
			}
		}

		// Token: 0x0400858C RID: 34188
		private IWuWaGoGame Instance;
	}
}
