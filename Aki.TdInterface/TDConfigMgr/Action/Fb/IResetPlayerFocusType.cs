using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028C9 RID: 10441
	public class IResetPlayerFocusType
	{
		// Token: 0x0600E7EF RID: 59375 RVA: 0x00220C75 File Offset: 0x0021EE75
		[NullableContext(1)]
		public static IResetPlayerFocusType Create(IResetPlayerFocusType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IResetPlayerFocusType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700481F RID: 18463
		// (get) Token: 0x0600E7F0 RID: 59376 RVA: 0x00220C94 File Offset: 0x0021EE94
		public virtual EResetPlayerFocusType Type
		{
			get
			{
				return (EResetPlayerFocusType)this.Instance.Type;
			}
		}

		// Token: 0x04008037 RID: 32823
		private IResetPlayerFocusType Instance;
	}
}
