using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C8D RID: 3213
	public class IJigsawCompleteCondition
	{
		// Token: 0x06004982 RID: 18818 RVA: 0x000B8335 File Offset: 0x000B6535
		[NullableContext(1)]
		public static IJigsawCompleteCondition Create(IJigsawCompleteCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IJigsawCompleteCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001625 RID: 5669
		// (get) Token: 0x06004983 RID: 18819 RVA: 0x000B8354 File Offset: 0x000B6554
		public virtual EJigsawCompleteCondition Type
		{
			get
			{
				return (EJigsawCompleteCondition)this.Instance.Type;
			}
		}

		// Token: 0x040029EC RID: 10732
		private IJigsawCompleteCondition Instance;
	}
}
