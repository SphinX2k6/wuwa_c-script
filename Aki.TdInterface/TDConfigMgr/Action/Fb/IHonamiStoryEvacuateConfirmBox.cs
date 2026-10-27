using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200260E RID: 9742
	public class IHonamiStoryEvacuateConfirmBox : IInteractionConfirmBoxType
	{
		// Token: 0x0600DABE RID: 55998 RVA: 0x002095D3 File Offset: 0x002077D3
		[NullableContext(1)]
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

		// Token: 0x17004064 RID: 16484
		// (get) Token: 0x0600DABF RID: 55999 RVA: 0x002095F2 File Offset: 0x002077F2
		public override EInteractionConfirmBoxType Type
		{
			get
			{
				return (EInteractionConfirmBoxType)this.Instance.Type;
			}
		}

		// Token: 0x0400797E RID: 31102
		private IHonamiStoryEvacuateConfirmBox Instance;
	}
}
