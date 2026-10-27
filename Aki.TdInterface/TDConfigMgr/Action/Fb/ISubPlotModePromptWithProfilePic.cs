using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025D4 RID: 9684
	public class ISubPlotModePromptWithProfilePic : ISubPlotModeBase
	{
		// Token: 0x0600D9B5 RID: 55733 RVA: 0x0020774E File Offset: 0x0020594E
		[NullableContext(1)]
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

		// Token: 0x17003FCF RID: 16335
		// (get) Token: 0x0600D9B6 RID: 55734 RVA: 0x0020776D File Offset: 0x0020596D
		public override ESubPlotModeType Type
		{
			get
			{
				return (ESubPlotModeType)this.Instance.Type;
			}
		}

		// Token: 0x040078E8 RID: 30952
		private ISubPlotModePromptWithProfilePic Instance;
	}
}
