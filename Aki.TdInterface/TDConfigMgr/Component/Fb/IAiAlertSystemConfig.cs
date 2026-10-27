using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A95 RID: 2709
	public class IAiAlertSystemConfig
	{
		// Token: 0x06003E4B RID: 15947 RVA: 0x0009F74F File Offset: 0x0009D94F
		[NullableContext(1)]
		public static IAiAlertSystemConfig Create(IAiAlertSystemConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAiAlertSystemConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000EDE RID: 3806
		// (get) Token: 0x06003E4C RID: 15948 RVA: 0x0009F76E File Offset: 0x0009D96E
		public virtual int AreaId
		{
			get
			{
				return this.Instance.AreaId;
			}
		}

		// Token: 0x17000EDF RID: 3807
		// (get) Token: 0x06003E4D RID: 15949 RVA: 0x0009F77C File Offset: 0x0009D97C
		public virtual float? PlayerHatredDeltaValue
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.PlayerHatredDeltaValue);
			}
		}

		// Token: 0x040022B2 RID: 8882
		private IAiAlertSystemConfig Instance;
	}
}
