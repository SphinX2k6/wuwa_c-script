using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B22 RID: 2850
	public class IHookFetchMoveUniform : IHookFetchMoveModeBase
	{
		// Token: 0x060041CF RID: 16847 RVA: 0x000A8CC2 File Offset: 0x000A6EC2
		[NullableContext(1)]
		public static IHookFetchMoveUniform Create(IHookFetchMoveUniform? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHookFetchMoveUniform
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001148 RID: 4424
		// (get) Token: 0x060041D0 RID: 16848 RVA: 0x000A8CE1 File Offset: 0x000A6EE1
		public override EHookFetchMoveMode Type
		{
			get
			{
				return (EHookFetchMoveMode)this.Instance.Type;
			}
		}

		// Token: 0x17001149 RID: 4425
		// (get) Token: 0x060041D1 RID: 16849 RVA: 0x000A8CEE File Offset: 0x000A6EEE
		public virtual float Speed
		{
			get
			{
				return this.Instance.Speed;
			}
		}

		// Token: 0x0400251B RID: 9499
		private IHookFetchMoveUniform Instance;
	}
}
