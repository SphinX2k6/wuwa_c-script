using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027EF RID: 10223
	public class IWindProtagonistParkour4 : ILeisureInteractType
	{
		// Token: 0x0600E313 RID: 58131 RVA: 0x00217F7B File Offset: 0x0021617B
		[NullableContext(1)]
		public static IWindProtagonistParkour4 Create(IWindProtagonistParkour4? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWindProtagonistParkour4
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044F7 RID: 17655
		// (get) Token: 0x0600E314 RID: 58132 RVA: 0x00217F9A File Offset: 0x0021619A
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x04007DD3 RID: 32211
		private IWindProtagonistParkour4 Instance;
	}
}
