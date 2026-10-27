using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200284D RID: 10317
	public class IInteractPointInteraction
	{
		// Token: 0x0600E4B1 RID: 58545 RVA: 0x0021A77A File Offset: 0x0021897A
		[NullableContext(1)]
		public static IInteractPointInteraction Create(IInteractPointInteraction? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractPointInteraction
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045D9 RID: 17881
		// (get) Token: 0x0600E4B2 RID: 58546 RVA: 0x0021A799 File Offset: 0x00218999
		public virtual EInteractPointInteractionType Type
		{
			get
			{
				return (EInteractPointInteractionType)this.Instance.Type;
			}
		}

		// Token: 0x04007E87 RID: 32391
		private IInteractPointInteraction Instance;
	}
}
