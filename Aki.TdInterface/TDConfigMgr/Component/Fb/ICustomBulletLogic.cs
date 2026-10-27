using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C6F RID: 3183
	public class ICustomBulletLogic
	{
		// Token: 0x060048F7 RID: 18679 RVA: 0x000B73E9 File Offset: 0x000B55E9
		[NullableContext(1)]
		public static ICustomBulletLogic Create(ICustomBulletLogic? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICustomBulletLogic
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170015D6 RID: 5590
		// (get) Token: 0x060048F8 RID: 18680 RVA: 0x000B7408 File Offset: 0x000B5608
		public virtual ECustomBulletLogic Type
		{
			get
			{
				return (ECustomBulletLogic)this.Instance.Type;
			}
		}

		// Token: 0x040029A2 RID: 10658
		private ICustomBulletLogic Instance;
	}
}
