using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028CE RID: 10446
	public class IHonamiStoryEvacuateConfirmBox : IInteractionConfirmBoxType
	{
		// Token: 0x0600E88B RID: 59531 RVA: 0x00225D27 File Offset: 0x00223F27
		public static IHonamiStoryEvacuateConfirmBox Create(IHonamiStoryEvacuateConfirmBox? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHonamiStoryEvacuateConfirmBox
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700439D RID: 17309
		// (get) Token: 0x0600E88C RID: 59532 RVA: 0x00225D46 File Offset: 0x00223F46
		public override EInteractionConfirmBoxType Type
		{
			get
			{
				return (EInteractionConfirmBoxType)this.Instance.Type;
			}
		}

		// Token: 0x04008018 RID: 32792
		private IHonamiStoryEvacuateConfirmBox Instance;
	}
}
