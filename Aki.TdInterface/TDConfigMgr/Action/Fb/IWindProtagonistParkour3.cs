using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027EE RID: 10222
	public class IWindProtagonistParkour3 : ILeisureInteractType
	{
		// Token: 0x0600E310 RID: 58128 RVA: 0x00217F47 File Offset: 0x00216147
		[NullableContext(1)]
		public static IWindProtagonistParkour3 Create(IWindProtagonistParkour3? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWindProtagonistParkour3
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044F6 RID: 17654
		// (get) Token: 0x0600E311 RID: 58129 RVA: 0x00217F66 File Offset: 0x00216166
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x04007DD2 RID: 32210
		private IWindProtagonistParkour3 Instance;
	}
}
