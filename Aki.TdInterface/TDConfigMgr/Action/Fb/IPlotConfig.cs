using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200285D RID: 10333
	public class IPlotConfig
	{
		// Token: 0x0600E678 RID: 59000 RVA: 0x00221DFA File Offset: 0x0021FFFA
		public static IPlotConfig Create(IPlotConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlotConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700426C RID: 17004
		// (get) Token: 0x0600E679 RID: 59001 RVA: 0x00221E19 File Offset: 0x00220019
		public virtual string EdPlotNode
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700426D RID: 17005
		// (get) Token: 0x0600E67A RID: 59002 RVA: 0x00221E1C File Offset: 0x0022001C
		public virtual bool EdPlotHandleJump
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700426E RID: 17006
		// (get) Token: 0x0600E67B RID: 59003 RVA: 0x00221E1F File Offset: 0x0022001F
		public virtual string EdPlotFileId
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700426F RID: 17007
		// (get) Token: 0x0600E67C RID: 59004 RVA: 0x00221E24 File Offset: 0x00220024
		public virtual EVisualNovelLayout? EdPlotLayout
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04007EF3 RID: 32499
		private IPlotConfig Instance;
	}
}
