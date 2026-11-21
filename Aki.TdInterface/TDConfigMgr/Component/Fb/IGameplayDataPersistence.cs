using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EE4 RID: 3812
	public class IGameplayDataPersistence
	{
		// Token: 0x060055D6 RID: 21974 RVA: 0x000D2BC9 File Offset: 0x000D0DC9
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

		// Token: 0x17001C09 RID: 7177
		// (get) Token: 0x060055D7 RID: 21975 RVA: 0x000D2BE8 File Offset: 0x000D0DE8
		public virtual EDataPersistenceGameplayType Type
		{
			get
			{
				return (EDataPersistenceGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x0400311B RID: 12571
		private IGameplayDataPersistence Instance;
	}
}
