using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020044C0 RID: 17600
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelPlayReportMarkItem : ConfigMarkItem
	{
		// Token: 0x0602C6D6 RID: 181974 RVA: 0x00C7C7CE File Offset: 0x00C7A9CE
		public LevelPlayReportMarkItem(int markId, MapMark markConfig, UUIItem parent, EMapType mapType, float markScale, ETrackSource trackSource = ETrackSource.MapMark) : base(markId, markConfig, parent, mapType, markScale, new ETrackSource?(trackSource))
		{
		}

		// Token: 0x0602C6D7 RID: 181975 RVA: 0x00C7C7E4 File Offset: 0x00C7A9E4
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.LevelPlayReportMarkItemView;
		}

		// Token: 0x0602C6D8 RID: 181976 RVA: 0x00C7C7E8 File Offset: 0x00C7A9E8
		[PreserveBaseOverrides]
		protected new virtual LevelPlayReportMarkItemView CreateView()
		{
			return new LevelPlayReportMarkItemView(this);
		}

		// Token: 0x0602C6D9 RID: 181977 RVA: 0x00C7C7F0 File Offset: 0x00C7A9F0
		public bool IsPunishReportFinish()
		{
			return this.IsGamePlayFinishWithReward;
		}

		// Token: 0x0602C6DA RID: 181978 RVA: 0x00C7C7F8 File Offset: 0x00C7A9F8
		public bool CanGetReward()
		{
			int relativeId = base.MarkConfig.Value.RelativeId;
			return LevelPlayReportModel.Instance.HaveLevelPlayReportRewardCanGet(base.MarkConfig.Value.RelativeDungeonId, relativeId);
		}

		// Token: 0x0602C6DB RID: 181979 RVA: 0x00C7C840 File Offset: 0x00C7AA40
		public PunishReportTarget GetPunishReportTarget()
		{
			int relativeId = base.MarkConfig.Value.RelativeId;
			return LevelPlayReportModel.Instance.GetLevelPlayReportTarget(base.MarkConfig.Value.RelativeDungeonId, relativeId);
		}

		// Token: 0x0602C6DC RID: 181980 RVA: 0x00C7C885 File Offset: 0x00C7AA85
		protected override void InitIcon()
		{
			this.UpdateIconPath();
		}

		// Token: 0x0602C6DD RID: 181981 RVA: 0x00C7C890 File Offset: 0x00C7AA90
		public override void UpdateIconPath()
		{
			this.IconPath = base.MarkConfig.Value.UnlockMarkPic;
		}
	}
}
