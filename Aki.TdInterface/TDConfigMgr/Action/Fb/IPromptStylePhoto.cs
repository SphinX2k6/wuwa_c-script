using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002870 RID: 10352
	public class IPromptStylePhoto : IPromptStyleBase
	{
		// Token: 0x0600E6D3 RID: 59091 RVA: 0x002228A4 File Offset: 0x00220AA4
		public static IPromptStylePhoto Create(IPromptStylePhoto? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPromptStylePhoto
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042A1 RID: 17057
		// (get) Token: 0x0600E6D4 RID: 59092 RVA: 0x002228C3 File Offset: 0x00220AC3
		public override EPromptStyle Type
		{
			get
			{
				return (EPromptStyle)this.Instance.Type;
			}
		}

		// Token: 0x04007F20 RID: 32544
		private IPromptStylePhoto Instance;
	}
}
