using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A53 RID: 10835
	public class ReignsTriggerGuide : ActionParams
	{
		// Token: 0x0600EE6C RID: 61036 RVA: 0x0022B50F File Offset: 0x0022970F
		[NullableContext(1)]
		public static ReignsTriggerGuide Create(IReignsTriggerGuide? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ReignsTriggerGuide
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B88 RID: 19336
		// (get) Token: 0x0600EE6D RID: 61037 RVA: 0x0022B52E File Offset: 0x0022972E
		public virtual int GuideId
		{
			get
			{
				return this.Instance.GuideId;
			}
		}

		// Token: 0x0400832F RID: 33583
		private IReignsTriggerGuide Instance;
	}
}
