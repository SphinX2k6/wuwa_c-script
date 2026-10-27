using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A19 RID: 10777
	public class IAiFollowerSlideRailEnd : ISlideRailEndType
	{
		// Token: 0x0600ED98 RID: 60824 RVA: 0x0022A0F6 File Offset: 0x002282F6
		[NullableContext(1)]
		public static IAiFollowerSlideRailEnd Create(IAiFollowerSlideRailEnd? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAiFollowerSlideRailEnd
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B28 RID: 19240
		// (get) Token: 0x0600ED99 RID: 60825 RVA: 0x0022A115 File Offset: 0x00228315
		public override ESlideRailEndType Type
		{
			get
			{
				return (ESlideRailEndType)this.Instance.Type;
			}
		}

		// Token: 0x17004B29 RID: 19241
		// (get) Token: 0x0600ED9A RID: 60826 RVA: 0x0022A122 File Offset: 0x00228322
		public virtual int AiEntityId
		{
			get
			{
				return this.Instance.AiEntityId;
			}
		}

		// Token: 0x040082C7 RID: 33479
		private IAiFollowerSlideRailEnd Instance;
	}
}
