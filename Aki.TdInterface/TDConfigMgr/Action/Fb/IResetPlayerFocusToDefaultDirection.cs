using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B9F RID: 11167
	public class IResetPlayerFocusToDefaultDirection : IResetPlayerFocusType
	{
		// Token: 0x0600F621 RID: 63009 RVA: 0x0023DC29 File Offset: 0x0023BE29
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

		// Token: 0x17004B91 RID: 19345
		// (get) Token: 0x0600F622 RID: 63010 RVA: 0x0023DC48 File Offset: 0x0023BE48
		public override EResetPlayerFocusType Type
		{
			get
			{
				return (EResetPlayerFocusType)this.Instance.Type;
			}
		}

		// Token: 0x040086F7 RID: 34551
		private IResetPlayerFocusToDefaultDirection Instance;
	}
}
