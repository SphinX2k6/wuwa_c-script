using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D5C RID: 19804
	[NullableContext(2)]
	[Nullable(0)]
	public class BehaviorTreeViewShowData : IMissionItemViewShowData
	{
		// Token: 0x17006202 RID: 25090
		// (get) Token: 0x06031B1E RID: 203550 RVA: 0x00DE5D0D File Offset: 0x00DE3F0D
		public EMissionItemViewDataSource DataSource
		{
			get
			{
				return EMissionItemViewDataSource.BehaviorTree;
			}
		}

		// Token: 0x17006203 RID: 25091
		// (get) Token: 0x06031B1F RID: 203551 RVA: 0x00DE5D10 File Offset: 0x00DE3F10
		// (set) Token: 0x06031B20 RID: 203552 RVA: 0x00DE5D18 File Offset: 0x00DE3F18
		public long Id { get; private set; }

		// Token: 0x17006204 RID: 25092
		// (get) Token: 0x06031B21 RID: 203553 RVA: 0x00DE5D21 File Offset: 0x00DE3F21
		// (set) Token: 0x06031B22 RID: 203554 RVA: 0x00DE5D29 File Offset: 0x00DE3F29
		public int TrackIconConfigId { get; private set; }

		// Token: 0x17006205 RID: 25093
		// (get) Token: 0x06031B23 RID: 203555 RVA: 0x00DE5D32 File Offset: 0x00DE3F32
		// (set) Token: 0x06031B24 RID: 203556 RVA: 0x00DE5D3A File Offset: 0x00DE3F3A
		public int ShowPriority { get; private set; }

		// Token: 0x17006206 RID: 25094
		// (get) Token: 0x06031B25 RID: 203557 RVA: 0x00DE5D43 File Offset: 0x00DE3F43
		// (set) Token: 0x06031B26 RID: 203558 RVA: 0x00DE5D4B File Offset: 0x00DE3F4B
		public string TitleTextKey { get; private set; }

		// Token: 0x17006207 RID: 25095
		// (get) Token: 0x06031B27 RID: 203559 RVA: 0x00DE5D54 File Offset: 0x00DE3F54
		// (set) Token: 0x06031B28 RID: 203560 RVA: 0x00DE5D5C File Offset: 0x00DE3F5C
		public long? ParentId { get; private set; }

		// Token: 0x17006208 RID: 25096
		// (get) Token: 0x06031B29 RID: 203561 RVA: 0x00DE5D65 File Offset: 0x00DE3F65
		[Nullable(1)]
		MissionViewStepTextInfoBase IMissionItemViewShowData.MainStepInfo
		{
			[NullableContext(1)]
			get
			{
				return this.MainStepInfo;
			}
		}

		// Token: 0x17006209 RID: 25097
		// (get) Token: 0x06031B2A RID: 203562 RVA: 0x00DE5D6D File Offset: 0x00DE3F6D
		[Nullable(1)]
		IReadOnlyList<MissionViewStepTextInfoBase> IMissionItemViewShowData.SubStepInfos
		{
			[NullableContext(1)]
			get
			{
				return this.SubStepInfos;
			}
		}

		// Token: 0x06031B2B RID: 203563 RVA: 0x00DE5D78 File Offset: 0x00DE3F78
		[return: Nullable(1)]
		public static BehaviorTreeViewShowData Create(BtType btType, long treeIncId, int treeConfigId, bool bInChallenge, int trackIconConfigId, int showPriority, string titleTextKey, BehaviorTreeStepTextInfo mainStepText, [Nullable(new byte[]
		{
			2,
			1
		})] List<BehaviorTreeStepTextInfo> subStepText, long? parentId)
		{
			return new BehaviorTreeViewShowData
			{
				BtType = btType,
				Id = treeIncId,
				TreeConfigId = treeConfigId,
				IsInChallenge = bInChallenge,
				TrackIconConfigId = trackIconConfigId,
				ShowPriority = showPriority,
				TitleTextKey = titleTextKey,
				MainStepInfo = mainStepText,
				SubStepInfos = subStepText,
				ParentId = parentId
			};
		}

		// Token: 0x0401A4F9 RID: 107769
		public BtType BtType;

		// Token: 0x0401A4FB RID: 107771
		public int TreeConfigId;

		// Token: 0x0401A4FC RID: 107772
		public bool IsInChallenge;

		// Token: 0x0401A500 RID: 107776
		public BehaviorTreeStepTextInfo MainStepInfo;

		// Token: 0x0401A501 RID: 107777
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<BehaviorTreeStepTextInfo> SubStepInfos;
	}
}
