using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028DD RID: 10461
	public class IAirPassageMoveLimit
	{
		// Token: 0x0600E85D RID: 59485 RVA: 0x00221A85 File Offset: 0x0021FC85
		[NullableContext(1)]
		public static IAirPassageMoveLimit Create(IAirPassageMoveLimit? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAirPassageMoveLimit
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004865 RID: 18533
		// (get) Token: 0x0600E85E RID: 59486 RVA: 0x00221AA4 File Offset: 0x0021FCA4
		public virtual float DirectionAngleLimit
		{
			get
			{
				return this.Instance.DirectionAngleLimit;
			}
		}

		// Token: 0x17004866 RID: 18534
		// (get) Token: 0x0600E85F RID: 59487 RVA: 0x00221AB1 File Offset: 0x0021FCB1
		public virtual float EdgeLimitCurveFactor
		{
			get
			{
				return this.Instance.EdgeLimitCurveFactor;
			}
		}

		// Token: 0x0400805D RID: 32861
		private IAirPassageMoveLimit Instance;
	}
}
