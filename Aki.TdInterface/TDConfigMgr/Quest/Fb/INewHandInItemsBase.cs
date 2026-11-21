using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020014CD RID: 5325
	public class INewHandInItemsBase
	{
		// Token: 0x060078CD RID: 30925 RVA: 0x00121362 File Offset: 0x0011F562
		public static INewHandInItemsBase Create(INewHandInItemsBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INewHandInItemsBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170026D5 RID: 9941
		// (get) Token: 0x060078CE RID: 30926 RVA: 0x00121381 File Offset: 0x0011F581
		public virtual ENewHandInItemsType Type
		{
			get
			{
				return (ENewHandInItemsType)this.Instance.Type;
			}
		}

		// Token: 0x04004581 RID: 17793
		private INewHandInItemsBase Instance;
	}
}
