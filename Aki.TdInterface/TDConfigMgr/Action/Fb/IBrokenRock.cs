using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B37 RID: 11063
	public class IBrokenRock : IUiGame
	{
		// Token: 0x0600F350 RID: 62288 RVA: 0x002383F9 File Offset: 0x002365F9
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

		// Token: 0x17004990 RID: 18832
		// (get) Token: 0x0600F351 RID: 62289 RVA: 0x00238418 File Offset: 0x00236618
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x17004991 RID: 18833
		// (get) Token: 0x0600F352 RID: 62290 RVA: 0x00238425 File Offset: 0x00236625
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x04008583 RID: 34179
		private IBrokenRock Instance;
	}
}
