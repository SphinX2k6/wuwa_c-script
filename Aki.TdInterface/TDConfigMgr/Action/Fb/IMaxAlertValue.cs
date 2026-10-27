using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029F6 RID: 10742
	public class IMaxAlertValue : ISetAlertValueType
	{
		// Token: 0x0600ED21 RID: 60705 RVA: 0x002297B2 File Offset: 0x002279B2
		[NullableContext(1)]
		public static IMaxAlertValue Create(IMaxAlertValue? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMaxAlertValue
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004AF7 RID: 19191
		// (get) Token: 0x0600ED22 RID: 60706 RVA: 0x002297D1 File Offset: 0x002279D1
		public override EValueChangeType Type
		{
			get
			{
				return (EValueChangeType)this.Instance.Type;
			}
		}

		// Token: 0x04008290 RID: 33424
		private IMaxAlertValue Instance;
	}
}
