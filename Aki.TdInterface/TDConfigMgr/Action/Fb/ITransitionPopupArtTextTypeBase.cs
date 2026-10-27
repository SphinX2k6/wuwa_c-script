using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200265D RID: 9821
	public class ITransitionPopupArtTextTypeBase
	{
		// Token: 0x0600DC23 RID: 56355 RVA: 0x0020C182 File Offset: 0x0020A382
		[NullableContext(1)]
		public static ITransitionPopupArtTextTypeBase Create(ITransitionPopupArtTextTypeBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITransitionPopupArtTextTypeBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700412B RID: 16683
		// (get) Token: 0x0600DC24 RID: 56356 RVA: 0x0020C1A1 File Offset: 0x0020A3A1
		public virtual ETransitionPopupArtTextType Type
		{
			get
			{
				return (ETransitionPopupArtTextType)this.Instance.Type;
			}
		}

		// Token: 0x04007A5B RID: 31323
		private ITransitionPopupArtTextTypeBase Instance;
	}
}
