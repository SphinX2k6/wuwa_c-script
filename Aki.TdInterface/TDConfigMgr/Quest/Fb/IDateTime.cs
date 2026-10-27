using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001384 RID: 4996
	public class IDateTime
	{
		// Token: 0x06007252 RID: 29266 RVA: 0x001130B2 File Offset: 0x001112B2
		[NullableContext(1)]
		public static IDateTime Create(IDateTime? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDateTime
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700251D RID: 9501
		// (get) Token: 0x06007253 RID: 29267 RVA: 0x001130D1 File Offset: 0x001112D1
		public virtual int Hours
		{
			get
			{
				return this.Instance.Hours;
			}
		}

		// Token: 0x1700251E RID: 9502
		// (get) Token: 0x06007254 RID: 29268 RVA: 0x001130DE File Offset: 0x001112DE
		public virtual int Minutes
		{
			get
			{
				return this.Instance.Minutes;
			}
		}

		// Token: 0x1700251F RID: 9503
		// (get) Token: 0x06007255 RID: 29269 RVA: 0x001130EC File Offset: 0x001112EC
		public virtual int? Days
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.Days);
			}
		}

		// Token: 0x04004212 RID: 16914
		private IDateTime Instance;
	}
}
