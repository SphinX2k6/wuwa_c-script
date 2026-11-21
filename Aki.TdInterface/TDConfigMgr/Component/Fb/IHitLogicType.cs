using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C52 RID: 3154
	public class IHitLogicType
	{
		// Token: 0x06004833 RID: 18483 RVA: 0x000B6BD6 File Offset: 0x000B4DD6
		public static IHitLogicType Create(IHitLogicType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHitLogicType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700138A RID: 5002
		// (get) Token: 0x06004834 RID: 18484 RVA: 0x000B6BF5 File Offset: 0x000B4DF5
		public virtual EHitLogicType Type
		{
			get
			{
				return (EHitLogicType)this.Instance.Type;
			}
		}

		// Token: 0x0400288B RID: 10379
		private IHitLogicType Instance;
	}
}
