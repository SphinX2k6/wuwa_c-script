using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D90 RID: 3472
	[NullableContext(1)]
	[Nullable(0)]
	public class IWindDirectionalStateGrade
	{
		// Token: 0x06004EF5 RID: 20213 RVA: 0x000C3D02 File Offset: 0x000C1F02
		public static IWindDirectionalStateGrade Create(IWindDirectionalStateGrade? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWindDirectionalStateGrade
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001992 RID: 6546
		// (get) Token: 0x06004EF6 RID: 20214 RVA: 0x000C3D21 File Offset: 0x000C1F21
		public virtual string State
		{
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x17001993 RID: 6547
		// (get) Token: 0x06004EF7 RID: 20215 RVA: 0x000C3D2E File Offset: 0x000C1F2E
		public virtual float Speed
		{
			get
			{
				return this.Instance.Speed;
			}
		}

		// Token: 0x17001994 RID: 6548
		// (get) Token: 0x06004EF8 RID: 20216 RVA: 0x000C3D3B File Offset: 0x000C1F3B
		public virtual float Strength
		{
			get
			{
				return this.Instance.Strength;
			}
		}

		// Token: 0x04002D63 RID: 11619
		private IWindDirectionalStateGrade Instance;
	}
}
