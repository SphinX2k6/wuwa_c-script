using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027E2 RID: 10210
	public class ISoar2 : ILeisureInteractType
	{
		// Token: 0x0600E2E9 RID: 58089 RVA: 0x00217C89 File Offset: 0x00215E89
		[NullableContext(1)]
		public static ISoar2 Create(ISoar2? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISoar2
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044E7 RID: 17639
		// (get) Token: 0x0600E2EA RID: 58090 RVA: 0x00217CA8 File Offset: 0x00215EA8
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x04007DC4 RID: 32196
		private ISoar2 Instance;
	}
}
