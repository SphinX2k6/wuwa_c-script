using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027ED RID: 10221
	public class IWindProtagonistParkour2 : ILeisureInteractType
	{
		// Token: 0x0600E30D RID: 58125 RVA: 0x00217F13 File Offset: 0x00216113
		[NullableContext(1)]
		public static IWindProtagonistParkour2 Create(IWindProtagonistParkour2? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWindProtagonistParkour2
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044F5 RID: 17653
		// (get) Token: 0x0600E30E RID: 58126 RVA: 0x00217F32 File Offset: 0x00216132
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x04007DD1 RID: 32209
		private IWindProtagonistParkour2 Instance;
	}
}
