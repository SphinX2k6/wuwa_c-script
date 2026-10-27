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
	// Token: 0x020054F4 RID: 21748
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneGameplayMarkItem : ConfigMarkItem
	{
		// Token: 0x060378DE RID: 227550 RVA: 0x00D309C2 File Offset: 0x00D2EBC2
		public SceneGameplayMarkItem(int markId, MapMark markConfig, UUIItem parent, EMapType mapType, float markScale, ETrackSource? trackSource = null) : base(markId, markConfig, parent, mapType, markScale, trackSource)
		{
		}

		// Token: 0x060378DF RID: 227551 RVA: 0x00D309D3 File Offset: 0x00D2EBD3
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.SceneGameplayMarkItemView;
		}

		// Token: 0x060378E0 RID: 227552 RVA: 0x00D309D7 File Offset: 0x00D2EBD7
		protected override MarkItemView CreateView()
		{
			return new SceneGameplayMarkItemView(this);
		}

		// Token: 0x060378E1 RID: 227553 RVA: 0x00D309E0 File Offset: 0x00D2EBE0
		public override bool CheckCanShowView()
		{
			LevelPlayInfo levelPlayInfo = LevelPlayModel.Instance.GetLevelPlayInfo(this.MarkConfig.Value.RelativeId);
			return levelPlayInfo != null && !levelPlayInfo.IsClose && base.CheckCanShowView();
		}

		// Token: 0x060378E2 RID: 227554 RVA: 0x00D30A20 File Offset: 0x00D2EC20
		protected override void InitIcon()
		{
			LevelPlayInfo levelPlayInfo = LevelPlayModel.Instance.GetLevelPlayInfo(this.MarkConfig.Value.RelativeId);
			if (levelPlayInfo == null || levelPlayInfo.IsClose)
			{
				this.IconPath = this.MarkConfig.Value.LockMarkPic;
			}
			this.IconPath = this.MarkConfig.Value.UnlockMarkPic;
		}

		// Token: 0x060378E3 RID: 227555 RVA: 0x00D30A88 File Offset: 0x00D2EC88
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
