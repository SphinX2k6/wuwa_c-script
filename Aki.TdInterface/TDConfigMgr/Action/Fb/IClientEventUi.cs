using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D2D RID: 11565
	public class IClientEventUi
	{
		// Token: 0x0600FCBF RID: 64703 RVA: 0x00248949 File Offset: 0x00246B49
		public static IClientEventUi Create(IClientEventUi? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientEventUi
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F13 RID: 20243
		// (get) Token: 0x0600FCC0 RID: 64704 RVA: 0x00248968 File Offset: 0x00246B68
		public virtual EClientEventUiType Type
		{
			get
			{
				return (EClientEventUiType)this.Instance.Type;
			}
		}

		// Token: 0x04008A01 RID: 35329
		private IClientEventUi Instance;
	}
}
