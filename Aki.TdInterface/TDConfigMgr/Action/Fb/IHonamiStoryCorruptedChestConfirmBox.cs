using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028CD RID: 10445
	public class IHonamiStoryCorruptedChestConfirmBox : IInteractionConfirmBoxType
	{
		// Token: 0x0600E887 RID: 59527 RVA: 0x00225CE6 File Offset: 0x00223EE6
		public static IHonamiStoryCorruptedChestConfirmBox Create(IHonamiStoryCorruptedChestConfirmBox? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHonamiStoryCorruptedChestConfirmBox
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700439B RID: 17307
		// (get) Token: 0x0600E888 RID: 59528 RVA: 0x00225D05 File Offset: 0x00223F05
		public override EInteractionConfirmBoxType Type
		{
			get
			{
				return (EInteractionConfirmBoxType)this.Instance.Type;
			}
		}

		// Token: 0x1700439C RID: 17308
		// (get) Token: 0x0600E889 RID: 59529 RVA: 0x00225D12 File Offset: 0x00223F12
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x04008017 RID: 32791
		private IHonamiStoryCorruptedChestConfirmBox Instance;
	}
}
