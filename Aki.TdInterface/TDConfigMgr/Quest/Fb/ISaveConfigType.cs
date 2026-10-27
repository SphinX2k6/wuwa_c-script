using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001449 RID: 5193
	public class ISaveConfigType
	{
		// Token: 0x06007618 RID: 30232 RVA: 0x0011A1B1 File Offset: 0x001183B1
		[NullableContext(1)]
		public static ISaveConfigType Create(ISaveConfigType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISaveConfigType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002759 RID: 10073
		// (get) Token: 0x06007619 RID: 30233 RVA: 0x0011A1D0 File Offset: 0x001183D0
		public virtual ESaveConfig Type
		{
			get
			{
				return (ESaveConfig)this.Instance.Type;
			}
		}

		// Token: 0x04004491 RID: 17553
		private ISaveConfigType Instance;
	}
}
