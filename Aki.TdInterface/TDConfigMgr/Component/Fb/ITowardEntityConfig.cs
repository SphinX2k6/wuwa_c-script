using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D6F RID: 3439
	[NullableContext(1)]
	[Nullable(0)]
	public class ITowardEntityConfig
	{
		// Token: 0x06004E46 RID: 20038 RVA: 0x000C2465 File Offset: 0x000C0665
		public static ITowardEntityConfig Create(ITowardEntityConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITowardEntityConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001925 RID: 6437
		// (get) Token: 0x06004E47 RID: 20039 RVA: 0x000C2484 File Offset: 0x000C0684
		public virtual string ReferenceActorKey
		{
			get
			{
				return this.Instance.ReferenceActorKey;
			}
		}

		// Token: 0x17001926 RID: 6438
		// (get) Token: 0x06004E48 RID: 20040 RVA: 0x000C2491 File Offset: 0x000C0691
		public virtual int TargetEntityId
		{
			get
			{
				return this.Instance.TargetEntityId;
			}
		}

		// Token: 0x04002CE6 RID: 11494
		private ITowardEntityConfig Instance;
	}
}
