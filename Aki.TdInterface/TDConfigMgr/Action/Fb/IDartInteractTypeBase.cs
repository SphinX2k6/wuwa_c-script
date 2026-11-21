using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B46 RID: 11078
	public class IDartInteractTypeBase
	{
		// Token: 0x0600F393 RID: 62355 RVA: 0x00238952 File Offset: 0x00236B52
		public static IDartInteractTypeBase Create(IDartInteractTypeBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDartInteractTypeBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170049B5 RID: 18869
		// (get) Token: 0x0600F394 RID: 62356 RVA: 0x00238971 File Offset: 0x00236B71
		public virtual EDartInteractType Type
		{
			get
			{
				return (EDartInteractType)this.Instance.Type;
			}
		}

		// Token: 0x04008596 RID: 34198
		private IDartInteractTypeBase Instance;
	}
}
