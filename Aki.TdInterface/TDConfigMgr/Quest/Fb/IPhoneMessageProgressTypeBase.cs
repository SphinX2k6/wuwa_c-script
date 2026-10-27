using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001360 RID: 4960
	public class IPhoneMessageProgressTypeBase
	{
		// Token: 0x0600718C RID: 29068 RVA: 0x001119D0 File Offset: 0x0010FBD0
		[NullableContext(1)]
		public static IPhoneMessageProgressTypeBase Create(IPhoneMessageProgressTypeBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPhoneMessageProgressTypeBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700249F RID: 9375
		// (get) Token: 0x0600718D RID: 29069 RVA: 0x001119EF File Offset: 0x0010FBEF
		public virtual EPhoneMessageProgressType Type
		{
			get
			{
				return (EPhoneMessageProgressType)this.Instance.Type;
			}
		}

		// Token: 0x0400419C RID: 16796
		private IPhoneMessageProgressTypeBase Instance;
	}
}
