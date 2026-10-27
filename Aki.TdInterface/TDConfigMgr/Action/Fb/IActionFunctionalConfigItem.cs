using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024CF RID: 9423
	public class IActionFunctionalConfigItem
	{
		// Token: 0x0600D279 RID: 53881 RVA: 0x001F3A46 File Offset: 0x001F1C46
		[NullableContext(1)]
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

		// Token: 0x17003A9D RID: 15005
		// (get) Token: 0x0600D27A RID: 53882 RVA: 0x001F3A68 File Offset: 0x001F1C68
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

		// Token: 0x17003A9E RID: 15006
		// (get) Token: 0x0600D27B RID: 53883 RVA: 0x001F3AA0 File Offset: 0x001F1CA0
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

		// Token: 0x17003A9F RID: 15007
		// (get) Token: 0x0600D27C RID: 53884 RVA: 0x001F3AD8 File Offset: 0x001F1CD8
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

		// Token: 0x17003AA0 RID: 15008
		// (get) Token: 0x0600D27D RID: 53885 RVA: 0x001F3B10 File Offset: 0x001F1D10
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

		// Token: 0x04007379 RID: 29561
		private IActionFunctionalConfigItem Instance;
	}
}
