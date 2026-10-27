using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002913 RID: 10515
	public class ICameraShakeConfig
	{
		// Token: 0x0600E969 RID: 59753 RVA: 0x002238D1 File Offset: 0x00221AD1
		[NullableContext(1)]
		public static ICameraShakeConfig Create(ICameraShakeConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICameraShakeConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004905 RID: 18693
		// (get) Token: 0x0600E96A RID: 59754 RVA: 0x002238F0 File Offset: 0x00221AF0
		public virtual ECameraShakeType Type
		{
			get
			{
				return (ECameraShakeType)this.Instance.Type;
			}
		}

		// Token: 0x040080D7 RID: 32983
		private ICameraShakeConfig Instance;
	}
}
