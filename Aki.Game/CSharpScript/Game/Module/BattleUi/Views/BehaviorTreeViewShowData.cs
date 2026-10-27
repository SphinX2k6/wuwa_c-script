using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D7A RID: 23930
	[NullableContext(2)]
	[Nullable(0)]
	public class BehaviorTreeViewShowData : IMissionItemViewShowData
	{
		// Token: 0x17008E30 RID: 36400
		// (get) Token: 0x0603CBC2 RID: 248770 RVA: 0x00E954C5 File Offset: 0x00E936C5
		public EMissionItemViewDataSource DataSource
		{
			get
			{
				return EMissionItemViewDataSource.BehaviorTree;
			}
		}

		// Token: 0x17008E31 RID: 36401
		// (get) Token: 0x0603CBC3 RID: 248771 RVA: 0x00E954C8 File Offset: 0x00E936C8
		// (set) Token: 0x0603CBC4 RID: 248772 RVA: 0x00E954D0 File Offset: 0x00E936D0
		public long Id { get; private set; }

		// Token: 0x17008E32 RID: 36402
		// (get) Token: 0x0603CBC5 RID: 248773 RVA: 0x00E954D9 File Offset: 0x00E936D9
		// (set) Token: 0x0603CBC6 RID: 248774 RVA: 0x00E954E1 File Offset: 0x00E936E1
		public int TrackIconConfigId { get; private set; }

		// Token: 0x17008E33 RID: 36403
		// (get) Token: 0x0603CBC7 RID: 248775 RVA: 0x00E954EA File Offset: 0x00E936EA
		// (set) Token: 0x0603CBC8 RID: 248776 RVA: 0x00E954F2 File Offset: 0x00E936F2
		public int ShowPriority { get; private set; }

		// Token: 0x17008E34 RID: 36404
		// (get) Token: 0x0603CBC9 RID: 248777 RVA: 0x00E954FB File Offset: 0x00E936FB
		// (set) Token: 0x0603CBCA RID: 248778 RVA: 0x00E95503 File Offset: 0x00E93703
		public string TitleTextKey { get; private set; }

		// Token: 0x17008E35 RID: 36405
		// (get) Token: 0x0603CBCB RID: 248779 RVA: 0x00E9550C File Offset: 0x00E9370C
		// (set) Token: 0x0603CBCC RID: 248780 RVA: 0x00E95514 File Offset: 0x00E93714
		public long? ParentId { get; private set; }

		// Token: 0x17008E36 RID: 36406
		// (get) Token: 0x0603CBCD RID: 248781 RVA: 0x00E9551D File Offset: 0x00E9371D
		[Nullable(1)]
		MissionViewStepTextInfoBase IMissionItemViewShowData.MainStepInfo
		{
			[NullableContext(1)]
			get
			{
				return this.MainStepInfo;
			}
		}

		// Token: 0x17008E37 RID: 36407
		// (get) Token: 0x0603CBCE RID: 248782 RVA: 0x00E95525 File Offset: 0x00E93725
		[Nullable(1)]
		IReadOnlyList<MissionViewStepTextInfoBase> IMissionItemViewShowData.SubStepInfos
		{
			[NullableContext(1)]
			get
			{
				return this.SubStepInfos;
			}
		}

		// Token: 0x0603CBCF RID: 248783 RVA: 0x00E95530 File Offset: 0x00E93730
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

		// Token: 0x0401FA41 RID: 129601
		public BtType BtType;

		// Token: 0x0401FA43 RID: 129603
		public int TreeConfigId;

		// Token: 0x0401FA44 RID: 129604
		public bool IsInChallenge;

		// Token: 0x0401FA48 RID: 129608
		public BehaviorTreeStepTextInfo MainStepInfo;

		// Token: 0x0401FA49 RID: 129609
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<BehaviorTreeStepTextInfo> SubStepInfos;
	}
}
