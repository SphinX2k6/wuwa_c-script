using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DE8 RID: 3560
	public class IGameplayDataPersistence
	{
		// Token: 0x060050AF RID: 20655 RVA: 0x000C7301 File Offset: 0x000C5501
		[NullableContext(1)]
		public static IGameplayDataPersistence Create(IGameplayDataPersistence? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGameplayDataPersistence
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A9C RID: 6812
		// (get) Token: 0x060050B0 RID: 20656 RVA: 0x000C7320 File Offset: 0x000C5520
		public virtual EDataPersistenceGameplayType Type
		{
			get
			{
				return (EDataPersistenceGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x04002E53 RID: 11859
		private IGameplayDataPersistence Instance;
	}
}
