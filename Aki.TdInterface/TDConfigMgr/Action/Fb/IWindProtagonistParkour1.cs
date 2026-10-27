using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027EC RID: 10220
	public class IWindProtagonistParkour1 : ILeisureInteractType
	{
		// Token: 0x0600E30A RID: 58122 RVA: 0x00217EDF File Offset: 0x002160DF
		[NullableContext(1)]
		public static IWindProtagonistParkour1 Create(IWindProtagonistParkour1? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWindProtagonistParkour1
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044F4 RID: 17652
		// (get) Token: 0x0600E30B RID: 58123 RVA: 0x00217EFE File Offset: 0x002160FE
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x04007DD0 RID: 32208
		private IWindProtagonistParkour1 Instance;
	}
}
