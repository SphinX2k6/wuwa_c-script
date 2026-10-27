using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020012F9 RID: 4857
	public class ISunSpiritProcess
	{
		// Token: 0x06006EC8 RID: 28360 RVA: 0x0010B945 File Offset: 0x00109B45
		[NullableContext(1)]
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

		// Token: 0x170022A9 RID: 8873
		// (get) Token: 0x06006EC9 RID: 28361 RVA: 0x0010B964 File Offset: 0x00109B64
		public virtual int LauncherId
		{
			get
			{
				return this.Instance.LauncherId;
			}
		}

		// Token: 0x170022AA RID: 8874
		// (get) Token: 0x06006ECA RID: 28362 RVA: 0x0010B974 File Offset: 0x00109B74
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

		// Token: 0x04003F85 RID: 16261
		private ISunSpiritProcess Instance;
	}
}
