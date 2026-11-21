using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002ABE RID: 10942
	public class IFaithJump : ILeisureInteractType
	{
		// Token: 0x0600F12C RID: 61740 RVA: 0x00234D0E File Offset: 0x00232F0E
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

		// Token: 0x1700485E RID: 18526
		// (get) Token: 0x0600F12D RID: 61741 RVA: 0x00234D2D File Offset: 0x00232F2D
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x0400848C RID: 33932
		private IFaithJump Instance;
	}
}
