using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002799 RID: 10137
	public class Prompt : ActionParams
	{
		// Token: 0x0600E095 RID: 57493 RVA: 0x00210D06 File Offset: 0x0020EF06
		public static Prompt Create(IPrompt? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new Prompt
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E11 RID: 15889
		// (get) Token: 0x0600E096 RID: 57494 RVA: 0x00210D25 File Offset: 0x0020EF25
		public virtual int GeneralTextId
		{
			get
			{
				return this.Instance.GeneralTextId;
			}
		}

		// Token: 0x04007A23 RID: 31267
		private IPrompt Instance;
	}
}
