using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200285E RID: 10334
	[NullableContext(1)]
	[Nullable(0)]
	public class IMorseCode : IUiGame
	{
		// Token: 0x0600E50D RID: 58637 RVA: 0x0021B231 File Offset: 0x00219431
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

		// Token: 0x17004613 RID: 17939
		// (get) Token: 0x0600E50E RID: 58638 RVA: 0x0021B250 File Offset: 0x00219450
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x17004614 RID: 17940
		// (get) Token: 0x0600E50F RID: 58639 RVA: 0x0021B25D File Offset: 0x0021945D
		public virtual string MorseCodeId
		{
			get
			{
				return this.Instance.MorseCodeId;
			}
		}

		// Token: 0x04007EB6 RID: 32438
		private IMorseCode Instance;
	}
}
