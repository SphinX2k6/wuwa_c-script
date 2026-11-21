using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002798 RID: 10136
	public class ShowMessage : ActionParams
	{
		// Token: 0x0600E092 RID: 57490 RVA: 0x00210CD2 File Offset: 0x0020EED2
		public static ShowMessage Create(IShowMessage? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ShowMessage
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E10 RID: 15888
		// (get) Token: 0x0600E093 RID: 57491 RVA: 0x00210CF1 File Offset: 0x0020EEF1
		public virtual string Content
		{
			get
			{
				return this.Instance.Content;
			}
		}

		// Token: 0x04007A22 RID: 31266
		private IShowMessage Instance;
	}
}
