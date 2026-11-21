using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefenseEvent.Model
{
	// Token: 0x02003AAD RID: 15021
	[NullableContext(2)]
	public interface ITowerDefenseEventCombatInfo
	{
		// Token: 0x17004EB3 RID: 20147
		// (get) Token: 0x06026976 RID: 158070
		// (set) Token: 0x06026977 RID: 158071
		long Uid { get; set; }

		// Token: 0x17004EB4 RID: 20148
		// (get) Token: 0x06026978 RID: 158072
		// (set) Token: 0x06026979 RID: 158073
		long OwnerId { get; set; }

		// Token: 0x17004EB5 RID: 20149
		// (get) Token: 0x0602697A RID: 158074
		// (set) Token: 0x0602697B RID: 158075
		int TemplateId { get; set; }

		// Token: 0x17004EB6 RID: 20150
		// (get) Token: 0x0602697C RID: 158076
		// (set) Token: 0x0602697D RID: 158077
		int CombatId { get; set; }

		// Token: 0x17004EB7 RID: 20151
		// (get) Token: 0x0602697E RID: 158078
		// (set) Token: 0x0602697F RID: 158079
		int SubTypeId { get; set; }

		// Token: 0x17004EB8 RID: 20152
		// (get) Token: 0x06026980 RID: 158080
		// (set) Token: 0x06026981 RID: 158081
		string PrefabPath { get; set; }

		// Token: 0x17004EB9 RID: 20153
		// (get) Token: 0x06026982 RID: 158082
		// (set) Token: 0x06026983 RID: 158083
		string AssetPath { get; set; }

		// Token: 0x17004EBA RID: 20154
		// (get) Token: 0x06026984 RID: 158084
		// (set) Token: 0x06026985 RID: 158085
		int PropertyId { get; set; }

		// Token: 0x17004EBB RID: 20155
		// (get) Token: 0x06026986 RID: 158086
		// (set) Token: 0x06026987 RID: 158087
		int? SplineId { get; set; }

		// Token: 0x17004EBC RID: 20156
		// (get) Token: 0x06026988 RID: 158088
		// (set) Token: 0x06026989 RID: 158089
		Dictionary<int, int> BuffIdLayers { get; set; }

		// Token: 0x17004EBD RID: 20157
		// (get) Token: 0x0602698A RID: 158090
		// (set) Token: 0x0602698B RID: 158091
		[Nullable(1)]
		Vector Position { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17004EBE RID: 20158
		// (get) Token: 0x0602698C RID: 158092
		// (set) Token: 0x0602698D RID: 158093
		[Nullable(1)]
		Rotator Rotation { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17004EBF RID: 20159
		// (get) Token: 0x0602698E RID: 158094
		// (set) Token: 0x0602698F RID: 158095
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

		// Token: 0x06026990 RID: 158096
		[NullableContext(1)]
		void Update(ITowerDefenseEventCombatInfo other);

		// Token: 0x06026991 RID: 158097
		bool IsValid();

		// Token: 0x06026992 RID: 158098
		void Reset();

		// Token: 0x06026993 RID: 158099
		void Release();

		// Token: 0x06026994 RID: 158100
		[NullableContext(1)]
		ITowerDefenseEventCombatInfo Clone();
	}
}
