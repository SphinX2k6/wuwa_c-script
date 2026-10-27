using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C1F RID: 3103
	public class IMonsterCommunicationGroupConfig
	{
		// Token: 0x06004719 RID: 18201 RVA: 0x000B312E File Offset: 0x000B132E
		[NullableContext(1)]
		public static IMonsterCommunicationGroupConfig Create(IMonsterCommunicationGroupConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterCommunicationGroupConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001498 RID: 5272
		// (get) Token: 0x0600471A RID: 18202 RVA: 0x000B314D File Offset: 0x000B134D
		public virtual int GroupId
		{
			get
			{
				return this.Instance.GroupId;
			}
		}

		// Token: 0x0400285C RID: 10332
		private IMonsterCommunicationGroupConfig Instance;
	}
}
