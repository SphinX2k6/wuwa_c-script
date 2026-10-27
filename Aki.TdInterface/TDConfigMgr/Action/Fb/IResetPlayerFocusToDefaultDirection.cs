using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028CA RID: 10442
	public class IResetPlayerFocusToDefaultDirection : IResetPlayerFocusType
	{
		// Token: 0x0600E7F2 RID: 59378 RVA: 0x00220CA9 File Offset: 0x0021EEA9
		[NullableContext(1)]
		public static IResetPlayerFocusToDefaultDirection Create(IResetPlayerFocusToDefaultDirection? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IResetPlayerFocusToDefaultDirection
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004820 RID: 18464
		// (get) Token: 0x0600E7F3 RID: 59379 RVA: 0x00220CC8 File Offset: 0x0021EEC8
		public override EResetPlayerFocusType Type
		{
			get
			{
				return (EResetPlayerFocusType)this.Instance.Type;
			}
		}

		// Token: 0x04008038 RID: 32824
		private IResetPlayerFocusToDefaultDirection Instance;
	}
}
