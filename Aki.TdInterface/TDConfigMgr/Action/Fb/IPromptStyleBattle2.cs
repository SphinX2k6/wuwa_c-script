using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002872 RID: 10354
	public class IPromptStyleBattle2 : IPromptStyleBase
	{
		// Token: 0x0600E6D9 RID: 59097 RVA: 0x0022290C File Offset: 0x00220B0C
		public static IPromptStyleBattle2 Create(IPromptStyleBattle2? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPromptStyleBattle2
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042A3 RID: 17059
		// (get) Token: 0x0600E6DA RID: 59098 RVA: 0x0022292B File Offset: 0x00220B2B
		public override EPromptStyle Type
		{
			get
			{
				return (EPromptStyle)this.Instance.Type;
			}
		}

		// Token: 0x04007F22 RID: 32546
		private IPromptStyleBattle2 Instance;
	}
}
