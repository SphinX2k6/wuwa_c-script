using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002955 RID: 10581
	public class ChangeEntityPrefabPerformance : ActionParams
	{
		// Token: 0x0600EAA6 RID: 60070 RVA: 0x00225CA1 File Offset: 0x00223EA1
		[NullableContext(1)]
		public static ChangeEntityPrefabPerformance Create(IChangeEntityPrefabPerformance? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangeEntityPrefabPerformance
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170049BE RID: 18878
		// (get) Token: 0x0600EAA7 RID: 60071 RVA: 0x00225CC0 File Offset: 0x00223EC0
		public virtual EChangeEntityPrefabPerformanceType Type
		{
			get
			{
				return (EChangeEntityPrefabPerformanceType)this.Instance.Type;
			}
		}

		// Token: 0x04008151 RID: 33105
		private IChangeEntityPrefabPerformance Instance;
	}
}
