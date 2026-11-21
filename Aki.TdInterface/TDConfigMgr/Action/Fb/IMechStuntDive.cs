using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002ADE RID: 10974
	public class IMechStuntDive : IMechStuntConfigType
	{
		// Token: 0x0600F19D RID: 61853 RVA: 0x002354EA File Offset: 0x002336EA
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

		// Token: 0x1700488F RID: 18575
		// (get) Token: 0x0600F19E RID: 61854 RVA: 0x00235509 File Offset: 0x00233709
		public override EMechStuntType Type
		{
			get
			{
				return (EMechStuntType)this.Instance.Type;
			}
		}

		// Token: 0x040084AE RID: 33966
		private IMechStuntDive Instance;
	}
}
