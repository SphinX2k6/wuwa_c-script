using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D2E RID: 11566
	public class IClientEventPianoEvent
	{
		// Token: 0x0600FCC2 RID: 64706 RVA: 0x0024897D File Offset: 0x00246B7D
		public static IClientEventPianoEvent Create(IClientEventPianoEvent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientEventPianoEvent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F14 RID: 20244
		// (get) Token: 0x0600FCC3 RID: 64707 RVA: 0x0024899C File Offset: 0x00246B9C
		public virtual EClientEventPianoEventType Type
		{
			get
			{
				return (EClientEventPianoEventType)this.Instance.Type;
			}
		}

		// Token: 0x04008A02 RID: 35330
		private IClientEventPianoEvent Instance;
	}
}
