using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A40 RID: 10816
	public class IClientEventUi
	{
		// Token: 0x0600EE27 RID: 60967 RVA: 0x0022AF95 File Offset: 0x00229195
		[NullableContext(1)]
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

		// Token: 0x17004B69 RID: 19305
		// (get) Token: 0x0600EE28 RID: 60968 RVA: 0x0022AFB4 File Offset: 0x002291B4
		public virtual EClientEventUiType Type
		{
			get
			{
				return (EClientEventUiType)this.Instance.Type;
			}
		}

		// Token: 0x0400830E RID: 33550
		private IClientEventUi Instance;
	}
}
