using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002864 RID: 10340
	public class IBrokenRock : IUiGame
	{
		// Token: 0x0600E52B RID: 58667 RVA: 0x0021B595 File Offset: 0x00219795
		[NullableContext(1)]
		public static IBrokenRock Create(IBrokenRock? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBrokenRock
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004625 RID: 17957
		// (get) Token: 0x0600E52C RID: 58668 RVA: 0x0021B5B4 File Offset: 0x002197B4
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x17004626 RID: 17958
		// (get) Token: 0x0600E52D RID: 58669 RVA: 0x0021B5C1 File Offset: 0x002197C1
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x04007EC6 RID: 32454
		private IBrokenRock Instance;
	}
}
