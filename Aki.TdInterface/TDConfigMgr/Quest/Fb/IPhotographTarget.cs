using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001555 RID: 5461
	public class IPhotographTarget
	{
		// Token: 0x06007B2D RID: 31533 RVA: 0x00125218 File Offset: 0x00123418
		public static IPhotographTarget Create(IPhotographTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPhotographTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002825 RID: 10277
		// (get) Token: 0x06007B2E RID: 31534 RVA: 0x00125237 File Offset: 0x00123437
		public virtual EPhotographTargetType Type
		{
			get
			{
				return (EPhotographTargetType)this.Instance.Type;
			}
		}

		// Token: 0x040046F1 RID: 18161
		private IPhotographTarget Instance;
	}
}
