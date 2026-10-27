using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A43 RID: 10819
	public class IClientEventPianoSwitchPhase : IClientEventPianoEvent
	{
		// Token: 0x0600EE32 RID: 60978 RVA: 0x0022B072 File Offset: 0x00229272
		[NullableContext(1)]
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

		// Token: 0x17004B6E RID: 19310
		// (get) Token: 0x0600EE33 RID: 60979 RVA: 0x0022B091 File Offset: 0x00229291
		public override EClientEventPianoEventType Type
		{
			get
			{
				return (EClientEventPianoEventType)this.Instance.Type;
			}
		}

		// Token: 0x04008313 RID: 33555
		private IClientEventPianoSwitchPhase Instance;
	}
}
