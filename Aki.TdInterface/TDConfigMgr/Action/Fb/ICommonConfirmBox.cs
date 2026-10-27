using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200260C RID: 9740
	public class ICommonConfirmBox : IInteractionConfirmBoxType
	{
		// Token: 0x0600DAB6 RID: 55990 RVA: 0x00209551 File Offset: 0x00207751
		[NullableContext(1)]
		public static ICommonConfirmBox Create(ICommonConfirmBox? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonConfirmBox
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004060 RID: 16480
		// (get) Token: 0x0600DAB7 RID: 55991 RVA: 0x00209570 File Offset: 0x00207770
		public override EInteractionConfirmBoxType Type
		{
			get
			{
				return (EInteractionConfirmBoxType)this.Instance.Type;
			}
		}

		// Token: 0x17004061 RID: 16481
		// (get) Token: 0x0600DAB8 RID: 55992 RVA: 0x0020957D File Offset: 0x0020777D
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x0400797C RID: 31100
		private ICommonConfirmBox Instance;
	}
}
