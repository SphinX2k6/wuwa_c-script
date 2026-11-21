using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002972 RID: 10610
	public class IFireBulletType
	{
		// Token: 0x0600EB6B RID: 60267 RVA: 0x0022B062 File Offset: 0x00229262
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

		// Token: 0x17004535 RID: 17717
		// (get) Token: 0x0600EB6C RID: 60268 RVA: 0x0022B081 File Offset: 0x00229281
		public virtual EFireBulletType Type
		{
			get
			{
				return (EFireBulletType)this.Instance.Type;
			}
		}

		// Token: 0x040081A4 RID: 33188
		private IFireBulletType Instance;
	}
}
