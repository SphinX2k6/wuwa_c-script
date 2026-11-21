using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;
using CSharpScript.Game.Module.WorldMap;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020044C7 RID: 17607
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneGameplayMarkItem : ConfigMarkItem
	{
		// Token: 0x0602C7AA RID: 182186 RVA: 0x00C7E8E0 File Offset: 0x00C7CAE0
		public SceneGameplayMarkItem(int markId, MapMark markConfig, UUIItem parent, EMapType mapType, float markScale, ETrackSource? trackSource = null) : base(markId, markConfig, parent, mapType, markScale, trackSource)
		{
		}

		// Token: 0x0602C7AB RID: 182187 RVA: 0x00C7E8F1 File Offset: 0x00C7CAF1
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.SceneGameplayMarkItemView;
		}

		// Token: 0x0602C7AC RID: 182188 RVA: 0x00C7E8F5 File Offset: 0x00C7CAF5
		protected override MarkItemView CreateView()
		{
			return new SceneGameplayMarkItemView(this);
		}

		// Token: 0x0602C7AD RID: 182189 RVA: 0x00C7E900 File Offset: 0x00C7CB00
		public override bool CheckCanShowView()
		{
			LevelPlayInfo levelPlayInfo = LevelPlayModel.Instance.GetLevelPlayInfo(base.MarkConfig.Value.RelativeId);
			return levelPlayInfo != null && !levelPlayInfo.IsClose && base.CheckCanShowView();
		}

		// Token: 0x0602C7AE RID: 182190 RVA: 0x00C7E944 File Offset: 0x00C7CB44
		protected override void InitIcon()
		{
			LevelPlayInfo levelPlayInfo = LevelPlayModel.Instance.GetLevelPlayInfo(base.MarkConfig.Value.RelativeId);
			if (levelPlayInfo == null || levelPlayInfo.IsClose)
			{
				this.IconPath = base.MarkConfig.Value.LockMarkPic;
			}
			this.IconPath = base.MarkConfig.Value.UnlockMarkPic;
		}

		// Token: 0x0602C7AF RID: 182191 RVA: 0x00C7E9B5 File Offset: 0x00C7CBB5
		public override ESecondaryPanel GetSecondaryUiType()
		{
			if (this.MarkType == EMarkType.CorniceMeeting)
			{
				return ESecondaryPanel.CorniceMeetingPanel;
			}
			if (base.IsLordGym() || base.IsNewLordGym())
			{
				return ESecondaryPanel.LordGymPanel;
			}
			return ESecondaryPanel.SceneGameplayPanel;
		}
	}
}
