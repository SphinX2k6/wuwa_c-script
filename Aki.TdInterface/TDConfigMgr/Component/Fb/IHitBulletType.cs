using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B92 RID: 2962
	public class IHitBulletType
	{
		// Token: 0x06004415 RID: 17429 RVA: 0x000AD2B2 File Offset: 0x000AB4B2
		[NullableContext(1)]
		public static IHitBulletType Create(IHitBulletType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHitBulletType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170012AE RID: 4782
		// (get) Token: 0x06004416 RID: 17430 RVA: 0x000AD2D1 File Offset: 0x000AB4D1
		public virtual EHitBulletType Type
		{
			get
			{
				return (EHitBulletType)this.Instance.Type;
			}
		}

		// Token: 0x0400266D RID: 9837
		private IHitBulletType Instance;
	}
}
