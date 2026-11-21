using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002893 RID: 10387
	public class ISubPlotModePromptWithProfilePic : ISubPlotModeBase
	{
		// Token: 0x0600E77D RID: 59261 RVA: 0x00223E02 File Offset: 0x00222002
		public static ISubPlotModePromptWithProfilePic Create(ISubPlotModePromptWithProfilePic? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISubPlotModePromptWithProfilePic
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004305 RID: 17157
		// (get) Token: 0x0600E77E RID: 59262 RVA: 0x00223E21 File Offset: 0x00222021
		public override ESubPlotModeType Type
		{
			get
			{
				return (ESubPlotModeType)this.Instance.Type;
			}
		}

		// Token: 0x04007F7F RID: 32639
		private ISubPlotModePromptWithProfilePic Instance;
	}
}
