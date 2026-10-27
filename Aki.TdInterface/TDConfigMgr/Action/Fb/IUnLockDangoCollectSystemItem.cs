using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002712 RID: 10002
	public class IUnLockDangoCollectSystemItem : IUnlockSystemItemType
	{
		// Token: 0x0600DF21 RID: 57121 RVA: 0x002111D6 File Offset: 0x0020F3D6
		[NullableContext(1)]
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

		// Token: 0x170042BF RID: 17087
		// (get) Token: 0x0600DF22 RID: 57122 RVA: 0x002111F5 File Offset: 0x0020F3F5
		public override EUnlockSystemItemType Type
		{
			get
			{
				return (EUnlockSystemItemType)this.Instance.Type;
			}
		}

		// Token: 0x170042C0 RID: 17088
		// (get) Token: 0x0600DF23 RID: 57123 RVA: 0x00211202 File Offset: 0x0020F402
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x04007BD2 RID: 31698
		private IUnLockDangoCollectSystemItem Instance;
	}
}
