using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002880 RID: 10368
	public class ICloseBrokenRock : ICloseUiGame
	{
		// Token: 0x0600E5AF RID: 58799 RVA: 0x0021C2E0 File Offset: 0x0021A4E0
		[NullableContext(1)]
		public static ICloseBrokenRock Create(ICloseBrokenRock? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICloseBrokenRock
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004671 RID: 18033
		// (get) Token: 0x0600E5B0 RID: 58800 RVA: 0x0021C2FF File Offset: 0x0021A4FF
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x04007F02 RID: 32514
		private ICloseBrokenRock Instance;
	}
}
