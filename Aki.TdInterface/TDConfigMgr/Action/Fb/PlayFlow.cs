using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028E3 RID: 10467
	public class PlayFlow : ActionParams
	{
		// Token: 0x0600E8F7 RID: 59639 RVA: 0x00226B21 File Offset: 0x00224D21
		public static PlayFlow Create(IPlayFlow? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PlayFlow
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170043DF RID: 17375
		// (get) Token: 0x0600E8F8 RID: 59640 RVA: 0x00226B40 File Offset: 0x00224D40
		public virtual string FlowListName
		{
			get
			{
				return this.Instance.FlowListName;
			}
		}

		// Token: 0x170043E0 RID: 17376
		// (get) Token: 0x0600E8F9 RID: 59641 RVA: 0x00226B4D File Offset: 0x00224D4D
		public virtual int FlowId
		{
			get
			{
				return this.Instance.FlowId;
			}
		}

		// Token: 0x170043E1 RID: 17377
		// (get) Token: 0x0600E8FA RID: 59642 RVA: 0x00226B5A File Offset: 0x00224D5A
		public virtual int StateId
		{
			get
			{
				return this.Instance.StateId;
			}
		}

		// Token: 0x170043E2 RID: 17378
		// (get) Token: 0x0600E8FB RID: 59643 RVA: 0x00226B67 File Offset: 0x00224D67
		[Nullable(2)]
		public virtual string FlowGuid
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.FlowGuid;
			}
		}

		// Token: 0x0400805F RID: 32863
		private IPlayFlow Instance;
	}
}
