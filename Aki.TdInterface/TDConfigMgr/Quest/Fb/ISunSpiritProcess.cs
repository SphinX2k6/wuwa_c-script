using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001449 RID: 5193
	public class ISunSpiritProcess
	{
		// Token: 0x06007568 RID: 30056 RVA: 0x00119EB1 File Offset: 0x001180B1
		public static ISunSpiritProcess Create(ISunSpiritProcess? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISunSpiritProcess
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002478 RID: 9336
		// (get) Token: 0x06007569 RID: 30057 RVA: 0x00119ED0 File Offset: 0x001180D0
		public virtual int LauncherId
		{
			get
			{
				return this.Instance.LauncherId;
			}
		}

		// Token: 0x17002479 RID: 9337
		// (get) Token: 0x0600756A RID: 30058 RVA: 0x00119EE0 File Offset: 0x001180E0
		public virtual bool? IsRecycle
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsRecycle);
			}
		}

		// Token: 0x04004301 RID: 17153
		private ISunSpiritProcess Instance;
	}
}
