using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Mark.Component;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020054ED RID: 21741
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelPlayReportMarkItem : ConfigMarkItem
	{
		// Token: 0x0603781C RID: 227356 RVA: 0x00D2E700 File Offset: 0x00D2C900
		public LevelPlayReportMarkItem(int markId, MapMark markConfig, UUIItem parent, EMapType mapType, float markScale, ETrackSource trackSource = ETrackSource.MapMark) : base(markId, markConfig, parent, mapType, markScale, new ETrackSource?(trackSource))
		{
		}

		// Token: 0x0603781D RID: 227357 RVA: 0x00D2E716 File Offset: 0x00D2C916
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.LevelPlayReportMarkItemView;
		}

		// Token: 0x0603781E RID: 227358 RVA: 0x00D2E71A File Offset: 0x00D2C91A
		[PreserveBaseOverrides]
		protected new virtual LevelPlayReportMarkItemView CreateView()
		{
			return new LevelPlayReportMarkItemView(this);
		}

		// Token: 0x0603781F RID: 227359 RVA: 0x00D2E722 File Offset: 0x00D2C922
		public bool IsPunishReportFinish()
		{
			return base.MarkItemEntity.GetComponent<MarkGamePlayComponent>(EMapComponent.MarkGamePlay).IsFinish;
		}

		// Token: 0x06037820 RID: 227360 RVA: 0x00D2E738 File Offset: 0x00D2C938
		public bool CanGetReward()
		{
			int relativeId = this.MarkConfig.Value.RelativeId;
			return LevelPlayReportModel.Instance.HaveLevelPlayReportRewardCanGet(this.MarkConfig.Value.RelativeDungeonId, relativeId);
		}

		// Token: 0x06037821 RID: 227361 RVA: 0x00D2E778 File Offset: 0x00D2C978
		public PunishReportTarget GetPunishReportTarget()
		{
			int relativeId = this.MarkConfig.Value.RelativeId;
			return LevelPlayReportModel.Instance.GetLevelPlayReportTarget(this.MarkConfig.Value.RelativeDungeonId, relativeId);
		}

		// Token: 0x06037822 RID: 227362 RVA: 0x00D2E7B7 File Offset: 0x00D2C9B7
		protected override void InitIcon()
		{
			this.UpdateIconPath();
		}

		// Token: 0x06037823 RID: 227363 RVA: 0x00D2E7C0 File Offset: 0x00D2C9C0
		public override void UpdateIconPath()
		{
			this.IconPath = this.MarkConfig.Value.UnlockMarkPic;
		}

		// Token: 0x06037824 RID: 227364 RVA: 0x00D2E7E6 File Offset: 0x00D2C9E6
		protected override bool GamePlayIsFinish()
		{
			return this.IsPunishReportFinish();
		}
	}
}
