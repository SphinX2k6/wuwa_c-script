using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002774 RID: 10100
	public class IActionFunctionalConfigItem
	{
		// Token: 0x0600DFCE RID: 57294 RVA: 0x0020F2A2 File Offset: 0x0020D4A2
		public static IActionFunctionalConfigItem Create(IActionFunctionalConfigItem? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActionFunctionalConfigItem
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003D94 RID: 15764
		// (get) Token: 0x0600DFCF RID: 57295 RVA: 0x0020F2C4 File Offset: 0x0020D4C4
		public virtual EOnlineParticipateRule? OnlineParticipateRule
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new EOnlineParticipateRule?((EOnlineParticipateRule)this.Instance.OnlineParticipateRule);
			}
		}

		// Token: 0x17003D95 RID: 15765
		// (get) Token: 0x0600DFD0 RID: 57296 RVA: 0x0020F2FC File Offset: 0x0020D4FC
		public virtual bool? IsDetectScreenOccupation
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsDetectScreenOccupation);
			}
		}

		// Token: 0x17003D96 RID: 15766
		// (get) Token: 0x0600DFD1 RID: 57297 RVA: 0x0020F334 File Offset: 0x0020D534
		public virtual bool? IsWithResultOnly
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsWithResultOnly);
			}
		}

		// Token: 0x17003D97 RID: 15767
		// (get) Token: 0x0600DFD2 RID: 57298 RVA: 0x0020F36C File Offset: 0x0020D56C
		public virtual bool? IsOperatePlayer
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsOperatePlayer);
			}
		}

		// Token: 0x040079C6 RID: 31174
		private IActionFunctionalConfigItem Instance;
	}
}
