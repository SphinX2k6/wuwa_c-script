using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x0200588B RID: 22667
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class PowerRewardButtonItemData : IPowerRewardButtonItemData
	{
		// Token: 0x17008A87 RID: 35463
		// (get) Token: 0x06039AF2 RID: 236274 RVA: 0x00DB5B1E File Offset: 0x00DB3D1E
		// (set) Token: 0x06039AF3 RID: 236275 RVA: 0x00DB5B26 File Offset: 0x00DB3D26
		public int PowerNum { get; set; }

		// Token: 0x17008A88 RID: 35464
		// (get) Token: 0x06039AF4 RID: 236276 RVA: 0x00DB5B2F File Offset: 0x00DB3D2F
		// (set) Token: 0x06039AF5 RID: 236277 RVA: 0x00DB5B37 File Offset: 0x00DB3D37
		public string RewardTextId { get; set; } = string.Empty;

		// Token: 0x17008A89 RID: 35465
		// (get) Token: 0x06039AF6 RID: 236278 RVA: 0x00DB5B40 File Offset: 0x00DB3D40
		// (set) Token: 0x06039AF7 RID: 236279 RVA: 0x00DB5B48 File Offset: 0x00DB3D48
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

		// Token: 0x17008A8A RID: 35466
		// (get) Token: 0x06039AF8 RID: 236280 RVA: 0x00DB5B51 File Offset: 0x00DB3D51
		// (set) Token: 0x06039AF9 RID: 236281 RVA: 0x00DB5B59 File Offset: 0x00DB3D59
		[RequiredMember]
		public Action RewardCallBack { get; set; }

		// Token: 0x06039AFA RID: 236282 RVA: 0x00DB5B62 File Offset: 0x00DB3D62
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public PowerRewardButtonItemData()
		{
		}
	}
}
