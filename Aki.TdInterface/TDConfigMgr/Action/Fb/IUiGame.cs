using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B0E RID: 11022
	public class IUiGame
	{
		// Token: 0x0600F27E RID: 62078 RVA: 0x00236B92 File Offset: 0x00234D92
		public static IUiGame Create(IUiGame? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUiGame
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004910 RID: 18704
		// (get) Token: 0x0600F27F RID: 62079 RVA: 0x00236BB1 File Offset: 0x00234DB1
		public virtual ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x04008514 RID: 34068
		private IUiGame Instance;
	}
}
