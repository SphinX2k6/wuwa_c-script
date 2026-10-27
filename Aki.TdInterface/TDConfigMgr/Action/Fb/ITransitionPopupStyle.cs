using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200265C RID: 9820
	public class ITransitionPopupStyle
	{
		// Token: 0x0600DC20 RID: 56352 RVA: 0x0020C14E File Offset: 0x0020A34E
		[NullableContext(1)]
		public static ITransitionPopupStyle Create(ITransitionPopupStyle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITransitionPopupStyle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700412A RID: 16682
		// (get) Token: 0x0600DC21 RID: 56353 RVA: 0x0020C16D File Offset: 0x0020A36D
		public virtual ETransitionPopupStyleType Type
		{
			get
			{
				return (ETransitionPopupStyleType)this.Instance.Type;
			}
		}

		// Token: 0x04007A5A RID: 31322
		private ITransitionPopupStyle Instance;
	}
}
