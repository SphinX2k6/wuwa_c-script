using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A70 RID: 2672
	public class IInteractSectorRange
	{
		// Token: 0x06003D99 RID: 15769 RVA: 0x0009E180 File Offset: 0x0009C380
		[NullableContext(1)]
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

		// Token: 0x17000E76 RID: 3702
		// (get) Token: 0x06003D9A RID: 15770 RVA: 0x0009E19F File Offset: 0x0009C39F
		public virtual float Begin
		{
			get
			{
				return this.Instance.Begin;
			}
		}

		// Token: 0x17000E77 RID: 3703
		// (get) Token: 0x06003D9B RID: 15771 RVA: 0x0009E1AC File Offset: 0x0009C3AC
		public virtual float End
		{
			get
			{
				return this.Instance.End;
			}
		}

		// Token: 0x04002251 RID: 8785
		private IInteractSectorRange Instance;
	}
}
