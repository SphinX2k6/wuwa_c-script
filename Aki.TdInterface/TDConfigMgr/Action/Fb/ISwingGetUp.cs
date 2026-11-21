using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AC6 RID: 10950
	public class ISwingGetUp : ILeisureInteractType
	{
		// Token: 0x0600F146 RID: 61766 RVA: 0x00234EC8 File Offset: 0x002330C8
		public static ISwingGetUp Create(ISwingGetUp? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISwingGetUp
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004868 RID: 18536
		// (get) Token: 0x0600F147 RID: 61767 RVA: 0x00234EE7 File Offset: 0x002330E7
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x04008494 RID: 33940
		private ISwingGetUp Instance;
	}
}
