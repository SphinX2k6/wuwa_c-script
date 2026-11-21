using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029D9 RID: 10713
	public class IUnLockDangoCollectSystemItem : IUnlockSystemItemType
	{
		// Token: 0x0600ED0D RID: 60685 RVA: 0x0022DB7E File Offset: 0x0022BD7E
		public static IUnLockDangoCollectSystemItem Create(IUnLockDangoCollectSystemItem? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUnLockDangoCollectSystemItem
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004609 RID: 17929
		// (get) Token: 0x0600ED0E RID: 60686 RVA: 0x0022DB9D File Offset: 0x0022BD9D
		public override EUnlockSystemItemType Type
		{
			get
			{
				return (EUnlockSystemItemType)this.Instance.Type;
			}
		}

		// Token: 0x1700460A RID: 17930
		// (get) Token: 0x0600ED0F RID: 60687 RVA: 0x0022DBAA File Offset: 0x0022BDAA
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x04008277 RID: 33399
		private IUnLockDangoCollectSystemItem Instance;
	}
}
