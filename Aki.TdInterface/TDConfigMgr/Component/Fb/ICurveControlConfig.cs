using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D9C RID: 3484
	public class ICurveControlConfig
	{
		// Token: 0x06004F36 RID: 20278 RVA: 0x000C463E File Offset: 0x000C283E
		[NullableContext(1)]
		public static ICurveControlConfig Create(ICurveControlConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICurveControlConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170019BB RID: 6587
		// (get) Token: 0x06004F37 RID: 20279 RVA: 0x000C465D File Offset: 0x000C285D
		public virtual ECurveControlType Type
		{
			get
			{
				return (ECurveControlType)this.Instance.Type;
			}
		}

		// Token: 0x04002D7D RID: 11645
		private ICurveControlConfig Instance;
	}
}
