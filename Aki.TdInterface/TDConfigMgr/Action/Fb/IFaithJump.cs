using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027EB RID: 10219
	public class IFaithJump : ILeisureInteractType
	{
		// Token: 0x0600E307 RID: 58119 RVA: 0x00217EAB File Offset: 0x002160AB
		[NullableContext(1)]
		public static IFaithJump Create(IFaithJump? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFaithJump
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044F3 RID: 17651
		// (get) Token: 0x0600E308 RID: 58120 RVA: 0x00217ECA File Offset: 0x002160CA
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x04007DCF RID: 32207
		private IFaithJump Instance;
	}
}
