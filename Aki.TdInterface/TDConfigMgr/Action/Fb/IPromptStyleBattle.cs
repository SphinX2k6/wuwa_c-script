using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002871 RID: 10353
	public class IPromptStyleBattle : IPromptStyleBase
	{
		// Token: 0x0600E6D6 RID: 59094 RVA: 0x002228D8 File Offset: 0x00220AD8
		public static IPromptStyleBattle Create(IPromptStyleBattle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPromptStyleBattle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042A2 RID: 17058
		// (get) Token: 0x0600E6D7 RID: 59095 RVA: 0x002228F7 File Offset: 0x00220AF7
		public override EPromptStyle Type
		{
			get
			{
				return (EPromptStyle)this.Instance.Type;
			}
		}

		// Token: 0x04007F21 RID: 32545
		private IPromptStyleBattle Instance;
	}
}
