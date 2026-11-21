using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001488 RID: 5256
	public class IPlayerHavingItemCount : IBindingProgressType
	{
		// Token: 0x06007763 RID: 30563 RVA: 0x0011E5CF File Offset: 0x0011C7CF
		public static IPlayerHavingItemCount Create(IPlayerHavingItemCount? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayerHavingItemCount
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170025F5 RID: 9717
		// (get) Token: 0x06007764 RID: 30564 RVA: 0x0011E5EE File Offset: 0x0011C7EE
		public override EBindingProgressType Type
		{
			get
			{
				return (EBindingProgressType)this.Instance.Type;
			}
		}

		// Token: 0x170025F6 RID: 9718
		// (get) Token: 0x06007765 RID: 30565 RVA: 0x0011E5FB File Offset: 0x0011C7FB
		public virtual int ItemId
		{
			get
			{
				return this.Instance.ItemId;
			}
		}

		// Token: 0x0400448A RID: 17546
		private IPlayerHavingItemCount Instance;
	}
}
