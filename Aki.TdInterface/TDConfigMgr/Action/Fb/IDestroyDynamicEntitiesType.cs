using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002598 RID: 9624
	public class IDestroyDynamicEntitiesType
	{
		// Token: 0x0600D8A9 RID: 55465 RVA: 0x002058CE File Offset: 0x00203ACE
		[NullableContext(1)]
		public static IDestroyDynamicEntitiesType Create(IDestroyDynamicEntitiesType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDestroyDynamicEntitiesType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003F3B RID: 16187
		// (get) Token: 0x0600D8AA RID: 55466 RVA: 0x002058ED File Offset: 0x00203AED
		public virtual EDynamicEntityType Type
		{
			get
			{
				return (EDynamicEntityType)this.Instance.Type;
			}
		}

		// Token: 0x0400786C RID: 30828
		private IDestroyDynamicEntitiesType Instance;
	}
}
