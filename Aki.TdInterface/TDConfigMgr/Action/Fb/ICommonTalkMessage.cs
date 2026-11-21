using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A31 RID: 10801
	public class ICommonTalkMessage
	{
		// Token: 0x0600EEAC RID: 61100 RVA: 0x0022FF20 File Offset: 0x0022E120
		public static ICommonTalkMessage Create(ICommonTalkMessage? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonTalkMessage
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170046F8 RID: 18168
		// (get) Token: 0x0600EEAD RID: 61101 RVA: 0x0022FF3F File Offset: 0x0022E13F
		public virtual string Text
		{
			get
			{
				return this.Instance.Text;
			}
		}

		// Token: 0x170046F9 RID: 18169
		// (get) Token: 0x0600EEAE RID: 61102 RVA: 0x0022FF4C File Offset: 0x0022E14C
		public virtual int? TalkerId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.TalkerId);
			}
		}

		// Token: 0x170046FA RID: 18170
		// (get) Token: 0x0600EEAF RID: 61103 RVA: 0x0022FF84 File Offset: 0x0022E184
		public virtual float? TextShowDelay
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new float?(this.Instance.TextShowDelay);
			}
		}

		// Token: 0x170046FB RID: 18171
		// (get) Token: 0x0600EEB0 RID: 61104 RVA: 0x0022FFBC File Offset: 0x0022E1BC
		public virtual float? TextShowDuration
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new float?(this.Instance.TextShowDuration);
			}
		}

		// Token: 0x04008313 RID: 33555
		private ICommonTalkMessage Instance;
	}
}
