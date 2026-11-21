using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029D8 RID: 10712
	public class IUnlockPhotoMemoryCollectSystemItem : IUnlockSystemItemType
	{
		// Token: 0x0600ED09 RID: 60681 RVA: 0x0022DB3D File Offset: 0x0022BD3D
		public static IUnlockPhotoMemoryCollectSystemItem Create(IUnlockPhotoMemoryCollectSystemItem? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUnlockPhotoMemoryCollectSystemItem
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004607 RID: 17927
		// (get) Token: 0x0600ED0A RID: 60682 RVA: 0x0022DB5C File Offset: 0x0022BD5C
		public override EUnlockSystemItemType Type
		{
			get
			{
				return (EUnlockSystemItemType)this.Instance.Type;
			}
		}

		// Token: 0x17004608 RID: 17928
		// (get) Token: 0x0600ED0B RID: 60683 RVA: 0x0022DB69 File Offset: 0x0022BD69
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x04008276 RID: 33398
		private IUnlockPhotoMemoryCollectSystemItem Instance;
	}
}
