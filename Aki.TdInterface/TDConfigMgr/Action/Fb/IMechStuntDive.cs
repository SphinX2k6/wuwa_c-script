using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200280B RID: 10251
	public class IMechStuntDive : IMechStuntConfigType
	{
		// Token: 0x0600E378 RID: 58232 RVA: 0x00218686 File Offset: 0x00216886
		[NullableContext(1)]
		public static IMechStuntDive Create(IMechStuntDive? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechStuntDive
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004524 RID: 17700
		// (get) Token: 0x0600E379 RID: 58233 RVA: 0x002186A5 File Offset: 0x002168A5
		public override EMechStuntType Type
		{
			get
			{
				return (EMechStuntType)this.Instance.Type;
			}
		}

		// Token: 0x04007DF1 RID: 32241
		private IMechStuntDive Instance;
	}
}
