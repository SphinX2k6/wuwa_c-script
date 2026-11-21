using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B8C RID: 11148
	public class IAdjustFixedLookAtTargetBase
	{
		// Token: 0x0600F593 RID: 62867 RVA: 0x0023CB0A File Offset: 0x0023AD0A
		public static IAdjustFixedLookAtTargetBase Create(IAdjustFixedLookAtTargetBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAdjustFixedLookAtTargetBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B29 RID: 19241
		// (get) Token: 0x0600F594 RID: 62868 RVA: 0x0023CB29 File Offset: 0x0023AD29
		public virtual EFixedLookAtTargetType Type
		{
			get
			{
				return (EFixedLookAtTargetType)this.Instance.Type;
			}
		}

		// Token: 0x040086A2 RID: 34466
		private IAdjustFixedLookAtTargetBase Instance;
	}
}
