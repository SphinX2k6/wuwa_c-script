using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027F0 RID: 10224
	public class IWindProtagonistParkour5 : ILeisureInteractType
	{
		// Token: 0x0600E316 RID: 58134 RVA: 0x00217FAF File Offset: 0x002161AF
		[NullableContext(1)]
		public static IWindProtagonistParkour5 Create(IWindProtagonistParkour5? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWindProtagonistParkour5
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044F8 RID: 17656
		// (get) Token: 0x0600E317 RID: 58135 RVA: 0x00217FCE File Offset: 0x002161CE
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x04007DD4 RID: 32212
		private IWindProtagonistParkour5 Instance;
	}
}
