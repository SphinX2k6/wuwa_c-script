using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026AF RID: 9903
	public class IFireBulletType
	{
		// Token: 0x0600DD94 RID: 56724 RVA: 0x0020E8C2 File Offset: 0x0020CAC2
		[NullableContext(1)]
		public static IFireBulletType Create(IFireBulletType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFireBulletType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170041F8 RID: 16888
		// (get) Token: 0x0600DD95 RID: 56725 RVA: 0x0020E8E1 File Offset: 0x0020CAE1
		public virtual EFireBulletType Type
		{
			get
			{
				return (EFireBulletType)this.Instance.Type;
			}
		}

		// Token: 0x04007B07 RID: 31495
		private IFireBulletType Instance;
	}
}
