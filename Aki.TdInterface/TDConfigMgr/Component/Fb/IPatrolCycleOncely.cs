using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C49 RID: 3145
	public class IPatrolCycleOncely : ICycleModeType
	{
		// Token: 0x06004802 RID: 18434 RVA: 0x000B5204 File Offset: 0x000B3404
		[NullableContext(1)]
		public static IPatrolCycleOncely Create(IPatrolCycleOncely? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPatrolCycleOncely
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700152D RID: 5421
		// (get) Token: 0x06004803 RID: 18435 RVA: 0x000B5223 File Offset: 0x000B3423
		public override EPatrolCycleMode Type
		{
			get
			{
				return (EPatrolCycleMode)this.Instance.Type;
			}
		}

		// Token: 0x040028FC RID: 10492
		private IPatrolCycleOncely Instance;
	}
}
