using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200286F RID: 10351
	public class IPromptStyleDefault : IPromptStyleBase
	{
		// Token: 0x0600E6D0 RID: 59088 RVA: 0x00222870 File Offset: 0x00220A70
		public static IPromptStyleDefault Create(IPromptStyleDefault? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPromptStyleDefault
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042A0 RID: 17056
		// (get) Token: 0x0600E6D1 RID: 59089 RVA: 0x0022288F File Offset: 0x00220A8F
		public override EPromptStyle Type
		{
			get
			{
				return (EPromptStyle)this.Instance.Type;
			}
		}

		// Token: 0x04007F1F RID: 32543
		private IPromptStyleDefault Instance;
	}
}
