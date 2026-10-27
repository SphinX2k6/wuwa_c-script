using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefenseEvent.Model
{
	// Token: 0x02004B05 RID: 19205
	[NullableContext(2)]
	public interface ITowerDefenseEventCombatInfo
	{
		// Token: 0x17007B06 RID: 31494
		// (get) Token: 0x06031BE6 RID: 203750
		// (set) Token: 0x06031BE7 RID: 203751
		long Uid { get; set; }

		// Token: 0x17007B07 RID: 31495
		// (get) Token: 0x06031BE8 RID: 203752
		// (set) Token: 0x06031BE9 RID: 203753
		long OwnerId { get; set; }

		// Token: 0x17007B08 RID: 31496
		// (get) Token: 0x06031BEA RID: 203754
		// (set) Token: 0x06031BEB RID: 203755
		int TemplateId { get; set; }

		// Token: 0x17007B09 RID: 31497
		// (get) Token: 0x06031BEC RID: 203756
		// (set) Token: 0x06031BED RID: 203757
		int CombatId { get; set; }

		// Token: 0x17007B0A RID: 31498
		// (get) Token: 0x06031BEE RID: 203758
		// (set) Token: 0x06031BEF RID: 203759
		int SubTypeId { get; set; }

		// Token: 0x17007B0B RID: 31499
		// (get) Token: 0x06031BF0 RID: 203760
		// (set) Token: 0x06031BF1 RID: 203761
		string PrefabPath { get; set; }

		// Token: 0x17007B0C RID: 31500
		// (get) Token: 0x06031BF2 RID: 203762
		// (set) Token: 0x06031BF3 RID: 203763
		string AssetPath { get; set; }

		// Token: 0x17007B0D RID: 31501
		// (get) Token: 0x06031BF4 RID: 203764
		// (set) Token: 0x06031BF5 RID: 203765
		int PropertyId { get; set; }

		// Token: 0x17007B0E RID: 31502
		// (get) Token: 0x06031BF6 RID: 203766
		// (set) Token: 0x06031BF7 RID: 203767
		int? SplineId { get; set; }

		// Token: 0x17007B0F RID: 31503
		// (get) Token: 0x06031BF8 RID: 203768
		// (set) Token: 0x06031BF9 RID: 203769
		Dictionary<int, int> BuffIdLayers { get; set; }

		// Token: 0x17007B10 RID: 31504
		// (get) Token: 0x06031BFA RID: 203770
		// (set) Token: 0x06031BFB RID: 203771
		[Nullable(1)]
		Vector Position { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17007B11 RID: 31505
		// (get) Token: 0x06031BFC RID: 203772
		// (set) Token: 0x06031BFD RID: 203773
		[Nullable(1)]
		Rotator Rotation { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17007B12 RID: 31506
		// (get) Token: 0x06031BFE RID: 203774
		// (set) Token: 0x06031BFF RID: 203775
		[Nullable(new byte[]
		{
			2,
			1
		})]
		Dictionary<ETowerDefenseEventCombatExtraInfoType, CombatExtraInfoBase> ExtraInfo { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x06031C00 RID: 203776
		[NullableContext(1)]
		void Update(ITowerDefenseEventCombatInfo other);

		// Token: 0x06031C01 RID: 203777
		bool IsValid();

		// Token: 0x06031C02 RID: 203778
		void Reset();

		// Token: 0x06031C03 RID: 203779
		void Release();

		// Token: 0x06031C04 RID: 203780
		[NullableContext(1)]
		ITowerDefenseEventCombatInfo Clone();
	}
}
