using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D6F RID: 3439
	public class IJigsawCompleteCondition
	{
		// Token: 0x06004E30 RID: 20016 RVA: 0x000C2D45 File Offset: 0x000C0F45
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

		// Token: 0x1700174D RID: 5965
		// (get) Token: 0x06004E31 RID: 20017 RVA: 0x000C2D64 File Offset: 0x000C0F64
		public virtual EJigsawCompleteCondition Type
		{
			get
			{
				return (EJigsawCompleteCondition)this.Instance.Type;
			}
		}

		// Token: 0x04002C66 RID: 11366
		private IJigsawCompleteCondition Instance;
	}
}
