using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A4C RID: 10828
	public class EndFlowTemplate : ActionParams
	{
		// Token: 0x0600EF24 RID: 61220 RVA: 0x00230CF5 File Offset: 0x0022EEF5
		public static EndFlowTemplate Create(IEndFlowTemplate? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EndFlowTemplate
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700473A RID: 18234
		// (get) Token: 0x0600EF25 RID: 61221 RVA: 0x00230D14 File Offset: 0x0022EF14
		public virtual bool IsResetPosition
		{
			get
			{
				return this.Instance.IsResetPosition;
			}
		}

		// Token: 0x04008356 RID: 33622
		private IEndFlowTemplate Instance;
	}
}
