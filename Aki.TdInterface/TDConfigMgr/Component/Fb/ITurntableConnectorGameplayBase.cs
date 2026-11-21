using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F5A RID: 3930
	public class ITurntableConnectorGameplayBase
	{
		// Token: 0x06005815 RID: 22549 RVA: 0x000D762D File Offset: 0x000D582D
		public static ITurntableConnectorGameplayBase Create(ITurntableConnectorGameplayBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITurntableConnectorGameplayBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001D5C RID: 7516
		// (get) Token: 0x06005816 RID: 22550 RVA: 0x000D764C File Offset: 0x000D584C
		public virtual ETurntableConnectorGameplayType Type
		{
			get
			{
				return (ETurntableConnectorGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x04003293 RID: 12947
		private ITurntableConnectorGameplayBase Instance;
	}
}
