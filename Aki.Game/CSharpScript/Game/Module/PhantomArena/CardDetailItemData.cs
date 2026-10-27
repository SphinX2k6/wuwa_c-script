using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Common.CardDetail;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x0200513A RID: 20794
	[NullableContext(2)]
	[Nullable(0)]
	[RequiredMember]
	public class CardDetailItemData
	{
		// Token: 0x0603516F RID: 217455 RVA: 0x00C942A4 File Offset: 0x00C924A4
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public CardDetailItemData()
		{
		}

		// Token: 0x0401C4C4 RID: 115908
		[Nullable(1)]
		[RequiredMember]
		public string Name;

		// Token: 0x0401C4C5 RID: 115909
		public ICardAttributeData AttributeData;

		// Token: 0x0401C4C6 RID: 115910
		public ICardDescriptionData CardDescriptionData;

		// Token: 0x0401C4C7 RID: 115911
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<CardDetailFactorDescItemData> FactorDataList;

		// Token: 0x0401C4C8 RID: 115912
		public string BgDescription;

		// Token: 0x0401C4C9 RID: 115913
		public ICardDetailTaskData TaskData;

		// Token: 0x0401C4CA RID: 115914
		public ICardDetailActiveSkillData ActiveSkillData;

		// Token: 0x0401C4CB RID: 115915
		public ICardDetailPassiveSkillData PassiveSkillData;

		// Token: 0x0401C4CC RID: 115916
		public ICardDetailLockData LockData;

		// Token: 0x0401C4CD RID: 115917
		public ICardDetailDurationData DurationData;

		// Token: 0x0401C4CE RID: 115918
		public ICardDetailRemainRoundData RemainRoundData;
	}
}
