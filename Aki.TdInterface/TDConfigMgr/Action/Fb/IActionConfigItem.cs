using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002775 RID: 10101
	public class IActionConfigItem : IActionFunctionalConfigItem
	{
		// Token: 0x0600DFD4 RID: 57300 RVA: 0x0020F3AA File Offset: 0x0020D5AA
		public static IActionConfigItem Create(IActionConfigItem? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActionConfigItem
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003D98 RID: 15768
		// (get) Token: 0x0600DFD5 RID: 57301 RVA: 0x0020F3CC File Offset: 0x0020D5CC
		public override EOnlineParticipateRule? OnlineParticipateRule
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

		// Token: 0x17003D99 RID: 15769
		// (get) Token: 0x0600DFD6 RID: 57302 RVA: 0x0020F404 File Offset: 0x0020D604
		public override bool? IsDetectScreenOccupation
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

		// Token: 0x17003D9A RID: 15770
		// (get) Token: 0x0600DFD7 RID: 57303 RVA: 0x0020F43C File Offset: 0x0020D63C
		public override bool? IsWithResultOnly
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

		// Token: 0x17003D9B RID: 15771
		// (get) Token: 0x0600DFD8 RID: 57304 RVA: 0x0020F474 File Offset: 0x0020D674
		public override bool? IsOperatePlayer
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

		// Token: 0x17003D9C RID: 15772
		// (get) Token: 0x0600DFD9 RID: 57305 RVA: 0x0020F4AA File Offset: 0x0020D6AA
		public virtual string CnName
		{
			get
			{
				return this.Instance.CnName;
			}
		}

		// Token: 0x040079C7 RID: 31175
		private IActionConfigItem Instance;
	}
}
