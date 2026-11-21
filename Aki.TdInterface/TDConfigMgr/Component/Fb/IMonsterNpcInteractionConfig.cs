using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CE9 RID: 3305
	public class IMonsterNpcInteractionConfig
	{
		// Token: 0x06004B6A RID: 19306 RVA: 0x000BD1A0 File Offset: 0x000BB3A0
		public static IMonsterNpcInteractionConfig Create(IMonsterNpcInteractionConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterNpcInteractionConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001593 RID: 5523
		// (get) Token: 0x06004B6B RID: 19307 RVA: 0x000BD1BF File Offset: 0x000BB3BF
		public virtual EMonsterNpcInteractionType Type
		{
			get
			{
				return (EMonsterNpcInteractionType)this.Instance.Type;
			}
		}

		// Token: 0x04002AA0 RID: 10912
		private IMonsterNpcInteractionConfig Instance;
	}
}
