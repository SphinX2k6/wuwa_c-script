using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x02004863 RID: 18531
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class PowerRewardButtonItemData : IPowerRewardButtonItemData
	{
		// Token: 0x17005E53 RID: 24147
		// (get) Token: 0x0602EA15 RID: 190997 RVA: 0x00D04A36 File Offset: 0x00D02C36
		// (set) Token: 0x0602EA16 RID: 190998 RVA: 0x00D04A3E File Offset: 0x00D02C3E
		public int PowerNum { get; set; }

		// Token: 0x17005E54 RID: 24148
		// (get) Token: 0x0602EA17 RID: 190999 RVA: 0x00D04A47 File Offset: 0x00D02C47
		// (set) Token: 0x0602EA18 RID: 191000 RVA: 0x00D04A4F File Offset: 0x00D02C4F
		public string RewardTextId { get; set; } = string.Empty;

		// Token: 0x17005E55 RID: 24149
		// (get) Token: 0x0602EA19 RID: 191001 RVA: 0x00D04A58 File Offset: 0x00D02C58
		// (set) Token: 0x0602EA1A RID: 191002 RVA: 0x00D04A60 File Offset: 0x00D02C60
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public string[] RewardTextArgs { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17005E56 RID: 24150
		// (get) Token: 0x0602EA1B RID: 191003 RVA: 0x00D04A69 File Offset: 0x00D02C69
		// (set) Token: 0x0602EA1C RID: 191004 RVA: 0x00D04A71 File Offset: 0x00D02C71
		[RequiredMember]
		public Action RewardCallBack { get; set; }

		// Token: 0x0602EA1D RID: 191005 RVA: 0x00D04A7A File Offset: 0x00D02C7A
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public PowerRewardButtonItemData()
		{
		}
	}
}
