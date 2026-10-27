using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002806 RID: 10246
	public class IFoxPutDown : ILeisureInteractType
	{
		// Token: 0x0600E360 RID: 58208 RVA: 0x002184E6 File Offset: 0x002166E6
		[NullableContext(1)]
		public static IFoxPutDown Create(IFoxPutDown? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFoxPutDown
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004516 RID: 17686
		// (get) Token: 0x0600E361 RID: 58209 RVA: 0x00218505 File Offset: 0x00216705
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x04007DEA RID: 32234
		private IFoxPutDown Instance;
	}
}
