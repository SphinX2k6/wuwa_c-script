using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002962 RID: 10594
	public class IDisableMapMark : ToggleMapMarkState
	{
		// Token: 0x0600EADC RID: 60124 RVA: 0x00226213 File Offset: 0x00224413
		[NullableContext(1)]
		public static IDisableMapMark Create(IDisableMapMark? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDisableMapMark
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170049DA RID: 18906
		// (get) Token: 0x0600EADD RID: 60125 RVA: 0x00226232 File Offset: 0x00224432
		public override EMapMarkState Type
		{
			get
			{
				return (EMapMarkState)this.Instance.Type;
			}
		}

		// Token: 0x170049DB RID: 18907
		// (get) Token: 0x0600EADE RID: 60126 RVA: 0x0022623F File Offset: 0x0022443F
		public virtual int MarkId
		{
			get
			{
				return this.Instance.MarkId;
			}
		}

		// Token: 0x0400816A RID: 33130
		private IDisableMapMark Instance;
	}
}
