using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C38 RID: 11320
	public class IDisablePlayerAiControl : IPlayerAiControlBase
	{
		// Token: 0x0600F910 RID: 63760 RVA: 0x002431D7 File Offset: 0x002413D7
		public static IDisablePlayerAiControl Create(IDisablePlayerAiControl? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDisablePlayerAiControl
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004D4E RID: 19790
		// (get) Token: 0x0600F911 RID: 63761 RVA: 0x002431F6 File Offset: 0x002413F6
		public override EPlayerAiControlType Type
		{
			get
			{
				return (EPlayerAiControlType)this.Instance.Type;
			}
		}

		// Token: 0x04008824 RID: 34852
		private IDisablePlayerAiControl Instance;
	}
}
