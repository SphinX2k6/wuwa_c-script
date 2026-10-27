using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200277A RID: 10106
	public class EndFlowTemplate : ActionParams
	{
		// Token: 0x0600E106 RID: 57606 RVA: 0x00213F61 File Offset: 0x00212161
		[NullableContext(1)]
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

		// Token: 0x170043D4 RID: 17364
		// (get) Token: 0x0600E107 RID: 57607 RVA: 0x00213F80 File Offset: 0x00212180
		public virtual bool IsResetPosition
		{
			get
			{
				return this.Instance.IsResetPosition;
			}
		}

		// Token: 0x04007CA0 RID: 31904
		private IEndFlowTemplate Instance;
	}
}
