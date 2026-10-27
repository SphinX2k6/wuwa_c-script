using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002949 RID: 10569
	public class ICameraOperationType
	{
		// Token: 0x0600EA6C RID: 60012 RVA: 0x0022552E File Offset: 0x0022372E
		[NullableContext(1)]
		public static ICameraOperationType Create(ICameraOperationType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICameraOperationType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700499C RID: 18844
		// (get) Token: 0x0600EA6D RID: 60013 RVA: 0x0022554D File Offset: 0x0022374D
		public virtual ECameraOperationType Type
		{
			get
			{
				return (ECameraOperationType)this.Instance.Type;
			}
		}

		// Token: 0x04008139 RID: 33081
		private ICameraOperationType Instance;
	}
}
