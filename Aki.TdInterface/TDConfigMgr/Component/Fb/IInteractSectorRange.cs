using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B3A RID: 2874
	public class IInteractSectorRange
	{
		// Token: 0x060041C2 RID: 16834 RVA: 0x000A7738 File Offset: 0x000A5938
		public static IInteractSectorRange Create(IInteractSectorRange? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractSectorRange
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000F49 RID: 3913
		// (get) Token: 0x060041C3 RID: 16835 RVA: 0x000A7757 File Offset: 0x000A5957
		public virtual float Begin
		{
			get
			{
				return this.Instance.Begin;
			}
		}

		// Token: 0x17000F4A RID: 3914
		// (get) Token: 0x060041C4 RID: 16836 RVA: 0x000A7764 File Offset: 0x000A5964
		public virtual float End
		{
			get
			{
				return this.Instance.End;
			}
		}

		// Token: 0x0400246D RID: 9325
		private IInteractSectorRange Instance;
	}
}
