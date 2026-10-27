using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B35 RID: 2869
	public class IEntityAngleWeight
	{
		// Token: 0x0600423C RID: 16956 RVA: 0x000A9A2E File Offset: 0x000A7C2E
		[NullableContext(1)]
		public static IEntityAngleWeight Create(IEntityAngleWeight? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityAngleWeight
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700118F RID: 4495
		// (get) Token: 0x0600423D RID: 16957 RVA: 0x000A9A4D File Offset: 0x000A7C4D
		public virtual int Angle
		{
			get
			{
				return this.Instance.Angle;
			}
		}

		// Token: 0x17001190 RID: 4496
		// (get) Token: 0x0600423E RID: 16958 RVA: 0x000A9A5A File Offset: 0x000A7C5A
		public virtual int Weight
		{
			get
			{
				return this.Instance.Weight;
			}
		}

		// Token: 0x04002558 RID: 9560
		private IEntityAngleWeight Instance;
	}
}
