using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024D0 RID: 9424
	[NullableContext(1)]
	[Nullable(0)]
	public class IActionConfigItem : IActionFunctionalConfigItem
	{
		// Token: 0x0600D27F RID: 53887 RVA: 0x001F3B4E File Offset: 0x001F1D4E
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

		// Token: 0x17003AA1 RID: 15009
		// (get) Token: 0x0600D280 RID: 53888 RVA: 0x001F3B70 File Offset: 0x001F1D70
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

		// Token: 0x17003AA2 RID: 15010
		// (get) Token: 0x0600D281 RID: 53889 RVA: 0x001F3BA8 File Offset: 0x001F1DA8
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

		// Token: 0x17003AA3 RID: 15011
		// (get) Token: 0x0600D282 RID: 53890 RVA: 0x001F3BE0 File Offset: 0x001F1DE0
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

		// Token: 0x17003AA4 RID: 15012
		// (get) Token: 0x0600D283 RID: 53891 RVA: 0x001F3C18 File Offset: 0x001F1E18
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

		// Token: 0x17003AA5 RID: 15013
		// (get) Token: 0x0600D284 RID: 53892 RVA: 0x001F3C4E File Offset: 0x001F1E4E
		public virtual string CnName
		{
			get
			{
				return this.Instance.CnName;
			}
		}

		// Token: 0x0400737A RID: 29562
		private IActionConfigItem Instance;
	}
}
