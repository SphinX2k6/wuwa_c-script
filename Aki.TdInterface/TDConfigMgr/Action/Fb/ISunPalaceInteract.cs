using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027FD RID: 10237
	public class ISunPalaceInteract : ILeisureInteractType
	{
		// Token: 0x0600E341 RID: 58177 RVA: 0x002182B2 File Offset: 0x002164B2
		[NullableContext(1)]
		public static ISunPalaceInteract Create(ISunPalaceInteract? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISunPalaceInteract
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004509 RID: 17673
		// (get) Token: 0x0600E342 RID: 58178 RVA: 0x002182D1 File Offset: 0x002164D1
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x04007DE1 RID: 32225
		private ISunPalaceInteract Instance;
	}
}
