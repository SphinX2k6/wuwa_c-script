using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200260D RID: 9741
	public class IHonamiStoryCorruptedChestConfirmBox : IInteractionConfirmBoxType
	{
		// Token: 0x0600DABA RID: 55994 RVA: 0x00209592 File Offset: 0x00207792
		[NullableContext(1)]
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

		// Token: 0x17004062 RID: 16482
		// (get) Token: 0x0600DABB RID: 55995 RVA: 0x002095B1 File Offset: 0x002077B1
		public override EInteractionConfirmBoxType Type
		{
			get
			{
				return (EInteractionConfirmBoxType)this.Instance.Type;
			}
		}

		// Token: 0x17004063 RID: 16483
		// (get) Token: 0x0600DABC RID: 55996 RVA: 0x002095BE File Offset: 0x002077BE
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x0400797D RID: 31101
		private IHonamiStoryCorruptedChestConfirmBox Instance;
	}
}
