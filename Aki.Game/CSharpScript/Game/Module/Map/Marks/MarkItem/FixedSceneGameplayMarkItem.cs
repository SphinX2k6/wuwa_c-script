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
	// Token: 0x020044B8 RID: 17592
	[NullableContext(1)]
	[Nullable(0)]
	public class FixedSceneGameplayMarkItem : ConfigMarkItem
	{
		// Token: 0x0602C698 RID: 181912 RVA: 0x00C7C002 File Offset: 0x00C7A202
		public FixedSceneGameplayMarkItem(int markId, MapMark markConfig, UUIItem parent, EMapType mapType, float markScale, ETrackSource trackSource = ETrackSource.MapMark) : base(markId, markConfig, parent, mapType, markScale, new ETrackSource?(trackSource))
		{
		}

		// Token: 0x0602C699 RID: 181913 RVA: 0x00C7C018 File Offset: 0x00C7A218
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.FixedSceneGamePlayMarkItemView;
		}

		// Token: 0x0602C69A RID: 181914 RVA: 0x00C7C01C File Offset: 0x00C7A21C
		[PreserveBaseOverrides]
		protected new virtual FixedSceneGamePlayMarkItemView CreateView()
		{
			return new FixedSceneGamePlayMarkItemView(this);
		}

		// Token: 0x0602C69B RID: 181915 RVA: 0x00C7C024 File Offset: 0x00C7A224
		protected override void OnInitialize()
		{
			base.OnInitialize();
			this.UpdateMultiMapFloorSelectedState();
		}

		// Token: 0x0602C69C RID: 181916 RVA: 0x00C7C034 File Offset: 0x00C7A234
		protected override void InitIcon()
		{
			LevelPlayModel instance = LevelPlayModel.Instance;
			MapMark? markConfig = base.MarkConfig;
			LevelPlayInfo levelPlayInfo = instance.GetLevelPlayInfo((markConfig != null) ? markConfig.GetValueOrDefault().RelativeId : 0);
			if (levelPlayInfo == null || levelPlayInfo.IsClose)
			{
				markConfig = base.MarkConfig;
				this.IconPath = (((markConfig != null) ? markConfig.GetValueOrDefault().LockMarkPic : null) ?? "");
				return;
			}
			markConfig = base.MarkConfig;
			this.IconPath = (((markConfig != null) ? markConfig.GetValueOrDefault().UnlockMarkPic : null) ?? "");
		}

		// Token: 0x170058CF RID: 22735
		// (get) Token: 0x0602C69D RID: 181917 RVA: 0x00C7C0DC File Offset: 0x00C7A2DC
		public override bool IsGamePlayFinishWithReward
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0602C69E RID: 181918 RVA: 0x00C7C0E0 File Offset: 0x00C7A2E0
		public override bool IsMultiMap()
		{
			MapMark? mapMark;
			return base.MarkConfig == null || mapMark.GetValueOrDefault().MultiMapFloorId != 0;
		}

		// Token: 0x0602C69F RID: 181919 RVA: 0x00C7C114 File Offset: 0x00C7A314
		public override int GetMultiMapId()
		{
			if (base.MarkConfig == null)
			{
				return 0;
			}
			MapMark? mapMark;
			return mapMark.GetValueOrDefault().MultiMapFloorId;
		}

		// Token: 0x0602C6A0 RID: 181920 RVA: 0x00C7C142 File Offset: 0x00C7A342
		protected override void OnUpdate(global::Vector playerLocation)
		{
			base.OnUpdate(playerLocation);
			if (base.MapType == EMapType.MiniMap)
			{
				this.UpdateMultiMapFloorSelectedState();
			}
		}

		// Token: 0x0602C6A1 RID: 181921 RVA: 0x00C7C15A File Offset: 0x00C7A35A
		private void UpdateMultiMapFloorSelectedState()
		{
			bool isSelectThisFloor = base.IsSelectThisFloor;
			base.IsSelectThisFloor = this.GetIsSelectThisFloor();
			if (isSelectThisFloor != base.IsSelectThisFloor)
			{
				base.UpdateViewIcon();
			}
		}

		// Token: 0x0602C6A2 RID: 181922 RVA: 0x00C7C17C File Offset: 0x00C7A37C
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
