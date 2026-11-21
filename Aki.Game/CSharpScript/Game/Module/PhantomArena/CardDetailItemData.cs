using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Common.CardDetail;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x0200410A RID: 16650
	[NullableContext(2)]
	[Nullable(0)]
	[RequiredMember]
	public class CardDetailItemData
	{
		// Token: 0x0602A068 RID: 172136 RVA: 0x00BE16B8 File Offset: 0x00BDF8B8
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public CardDetailItemData()
		{
		}

		// Token: 0x04016EF9 RID: 93945
		[Nullable(1)]
		[RequiredMember]
		public string Name;

		// Token: 0x04016EFA RID: 93946
		public ICardAttributeData AttributeData;

		// Token: 0x04016EFB RID: 93947
		public ICardDescriptionData CardDescriptionData;

		// Token: 0x04016EFC RID: 93948
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<CardDetailFactorDescItemData> FactorDataList;

		// Token: 0x04016EFD RID: 93949
		public string BgDescription;

		// Token: 0x04016EFE RID: 93950
		public ICardDetailTaskData TaskData;

		// Token: 0x04016EFF RID: 93951
		public ICardDetailActiveSkillData ActiveSkillData;

		// Token: 0x04016F00 RID: 93952
		public ICardDetailPassiveSkillData PassiveSkillData;

		// Token: 0x04016F01 RID: 93953
		public ICardDetailLockData LockData;

		// Token: 0x04016F02 RID: 93954
		public ICardDetailDurationData DurationData;

		// Token: 0x04016F03 RID: 93955
		public ICardDetailRemainRoundData RemainRoundData;
	}
}
