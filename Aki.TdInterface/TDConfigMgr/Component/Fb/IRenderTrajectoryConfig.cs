using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B48 RID: 2888
	[NullableContext(1)]
	[Nullable(0)]
	public class IRenderTrajectoryConfig
	{
		// Token: 0x06004288 RID: 17032 RVA: 0x000AA0CD File Offset: 0x000A82CD
		public static IRenderTrajectoryConfig Create(IRenderTrajectoryConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRenderTrajectoryConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170011B5 RID: 4533
		// (get) Token: 0x06004289 RID: 17033 RVA: 0x000AA0EC File Offset: 0x000A82EC
		public virtual float Time
		{
			get
			{
				return this.Instance.Time;
			}
		}

		// Token: 0x170011B6 RID: 4534
		// (get) Token: 0x0600428A RID: 17034 RVA: 0x000AA0F9 File Offset: 0x000A82F9
		public virtual string Effect
		{
			get
			{
				return this.Instance.Effect;
			}
		}

		// Token: 0x04002579 RID: 9593
		private IRenderTrajectoryConfig Instance;
	}
}
