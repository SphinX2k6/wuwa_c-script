using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200276B RID: 10091
	public class IFlowActionContext : IActionContextType
	{
		// Token: 0x0600DFB0 RID: 57264 RVA: 0x0020F02B File Offset: 0x0020D22B
		public static IFlowActionContext Create(IFlowActionContext? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowActionContext
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003D88 RID: 15752
		// (get) Token: 0x0600DFB1 RID: 57265 RVA: 0x0020F04A File Offset: 0x0020D24A
		public new virtual string Type
		{
			get
			{
				return this.Instance.Type;
			}
		}

		// Token: 0x040079BB RID: 31163
		private IFlowActionContext Instance;
	}
}
