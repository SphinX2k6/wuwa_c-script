using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B31 RID: 11057
	public class IMorseCode : IUiGame
	{
		// Token: 0x0600F332 RID: 62258 RVA: 0x00238095 File Offset: 0x00236295
		public static IMorseCode Create(IMorseCode? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMorseCode
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700497E RID: 18814
		// (get) Token: 0x0600F333 RID: 62259 RVA: 0x002380B4 File Offset: 0x002362B4
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x1700497F RID: 18815
		// (get) Token: 0x0600F334 RID: 62260 RVA: 0x002380C1 File Offset: 0x002362C1
		public virtual string MorseCodeId
		{
			get
			{
				return this.Instance.MorseCodeId;
			}
		}

		// Token: 0x04008573 RID: 34163
		private IMorseCode Instance;
	}
}
