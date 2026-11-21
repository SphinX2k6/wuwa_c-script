using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D06 RID: 11526
	public class IAiFollowerSlideRailEnd : ISlideRailEndType
	{
		// Token: 0x0600FC2F RID: 64559 RVA: 0x00247A7A File Offset: 0x00245C7A
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

		// Token: 0x17004ED1 RID: 20177
		// (get) Token: 0x0600FC30 RID: 64560 RVA: 0x00247A99 File Offset: 0x00245C99
		public override ESlideRailEndType Type
		{
			get
			{
				return (ESlideRailEndType)this.Instance.Type;
			}
		}

		// Token: 0x17004ED2 RID: 20178
		// (get) Token: 0x0600FC31 RID: 64561 RVA: 0x00247AA6 File Offset: 0x00245CA6
		public virtual int AiEntityId
		{
			get
			{
				return this.Instance.AiEntityId;
			}
		}

		// Token: 0x040089B8 RID: 35256
		private IAiFollowerSlideRailEnd Instance;
	}
}
