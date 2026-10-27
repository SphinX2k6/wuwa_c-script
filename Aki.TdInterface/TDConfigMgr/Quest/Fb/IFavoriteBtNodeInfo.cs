using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001443 RID: 5187
	[NullableContext(1)]
	[Nullable(0)]
	public class IFavoriteBtNodeInfo
	{
		// Token: 0x060075F5 RID: 30197 RVA: 0x00119C21 File Offset: 0x00117E21
		public static IFavoriteBtNodeInfo Create(IFavoriteBtNodeInfo? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFavoriteBtNodeInfo
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002742 RID: 10050
		// (get) Token: 0x060075F6 RID: 30198 RVA: 0x00119C40 File Offset: 0x00117E40
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17002743 RID: 10051
		// (get) Token: 0x060075F7 RID: 30199 RVA: 0x00119C4D File Offset: 0x00117E4D
		public virtual string Desc
		{
			get
			{
				return this.Instance.Desc;
			}
		}

		// Token: 0x04004473 RID: 17523
		private IFavoriteBtNodeInfo Instance;
	}
}
