using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027E1 RID: 10209
	public class ISoar : ILeisureInteractType
	{
		// Token: 0x0600E2E6 RID: 58086 RVA: 0x00217C55 File Offset: 0x00215E55
		[NullableContext(1)]
		public static ISoar Create(ISoar? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISoar
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044E6 RID: 17638
		// (get) Token: 0x0600E2E7 RID: 58087 RVA: 0x00217C74 File Offset: 0x00215E74
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x04007DC3 RID: 32195
		private ISoar Instance;
	}
}
