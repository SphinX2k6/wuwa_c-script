using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D30 RID: 11568
	public class IClientEventPianoSwitchPhase : IClientEventPianoEvent
	{
		// Token: 0x0600FCCA RID: 64714 RVA: 0x00248A26 File Offset: 0x00246C26
		public static IClientEventPianoSwitchPhase Create(IClientEventPianoSwitchPhase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientEventPianoSwitchPhase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F18 RID: 20248
		// (get) Token: 0x0600FCCB RID: 64715 RVA: 0x00248A45 File Offset: 0x00246C45
		public override EClientEventPianoEventType Type
		{
			get
			{
				return (EClientEventPianoEventType)this.Instance.Type;
			}
		}

		// Token: 0x04008A06 RID: 35334
		private IClientEventPianoSwitchPhase Instance;
	}
}
