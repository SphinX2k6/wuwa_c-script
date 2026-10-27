using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002882 RID: 10370
	public class ICloseUiGame
	{
		// Token: 0x0600E5B5 RID: 58805 RVA: 0x0021C348 File Offset: 0x0021A548
		[NullableContext(1)]
		public static ICloseUiGame Create(ICloseUiGame? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICloseUiGame
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004673 RID: 18035
		// (get) Token: 0x0600E5B6 RID: 58806 RVA: 0x0021C367 File Offset: 0x0021A567
		public virtual ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x04007F04 RID: 32516
		private ICloseUiGame Instance;
	}
}
