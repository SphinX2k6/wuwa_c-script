using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B86 RID: 2950
	public class IHitLogicChangeLockState : IHitLogicType
	{
		// Token: 0x060043E0 RID: 17376 RVA: 0x000ACB7A File Offset: 0x000AAD7A
		[NullableContext(1)]
		public static IHitLogicChangeLockState Create(IHitLogicChangeLockState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHitLogicChangeLockState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001291 RID: 4753
		// (get) Token: 0x060043E1 RID: 17377 RVA: 0x000ACB99 File Offset: 0x000AAD99
		public override EHitLogicType Type
		{
			get
			{
				return (EHitLogicType)this.Instance.Type;
			}
		}

		// Token: 0x04002645 RID: 9797
		private IHitLogicChangeLockState Instance;
	}
}
