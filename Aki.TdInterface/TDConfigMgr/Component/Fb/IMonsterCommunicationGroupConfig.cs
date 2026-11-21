using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CF2 RID: 3314
	public class IMonsterCommunicationGroupConfig
	{
		// Token: 0x06004B86 RID: 19334 RVA: 0x000BD3A3 File Offset: 0x000BB5A3
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

		// Token: 0x1700159D RID: 5533
		// (get) Token: 0x06004B87 RID: 19335 RVA: 0x000BD3C2 File Offset: 0x000BB5C2
		public virtual int GroupId
		{
			get
			{
				return this.Instance.GroupId;
			}
		}

		// Token: 0x04002AAB RID: 10923
		private IMonsterCommunicationGroupConfig Instance;
	}
}
