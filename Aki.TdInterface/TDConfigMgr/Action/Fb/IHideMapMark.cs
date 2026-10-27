using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002961 RID: 10593
	public class IHideMapMark : ToggleMapMarkState
	{
		// Token: 0x0600EAD8 RID: 60120 RVA: 0x002261D2 File Offset: 0x002243D2
		[NullableContext(1)]
		public static IHideMapMark Create(IHideMapMark? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHideMapMark
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170049D8 RID: 18904
		// (get) Token: 0x0600EAD9 RID: 60121 RVA: 0x002261F1 File Offset: 0x002243F1
		public override EMapMarkState Type
		{
			get
			{
				return (EMapMarkState)this.Instance.Type;
			}
		}

		// Token: 0x170049D9 RID: 18905
		// (get) Token: 0x0600EADA RID: 60122 RVA: 0x002261FE File Offset: 0x002243FE
		public virtual int MarkId
		{
			get
			{
				return this.Instance.MarkId;
			}
		}

		// Token: 0x04008169 RID: 33129
		private IHideMapMark Instance;
	}
}
