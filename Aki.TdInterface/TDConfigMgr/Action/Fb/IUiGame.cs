using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200283B RID: 10299
	public class IUiGame
	{
		// Token: 0x0600E459 RID: 58457 RVA: 0x00219D2E File Offset: 0x00217F2E
		[NullableContext(1)]
		public static IUiGame Create(IUiGame? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUiGame
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045A5 RID: 17829
		// (get) Token: 0x0600E45A RID: 58458 RVA: 0x00219D4D File Offset: 0x00217F4D
		public virtual ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x04007E57 RID: 32343
		private IUiGame Instance;
	}
}
