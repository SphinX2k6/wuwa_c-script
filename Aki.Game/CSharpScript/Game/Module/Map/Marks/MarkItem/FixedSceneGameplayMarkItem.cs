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
	// Token: 0x020054E5 RID: 21733
	[NullableContext(1)]
	[Nullable(0)]
	public class FixedSceneGameplayMarkItem : ConfigMarkItem
	{
		// Token: 0x060377DC RID: 227292 RVA: 0x00D2DF22 File Offset: 0x00D2C122
		public FixedSceneGameplayMarkItem(int markId, MapMark markConfig, UUIItem parent, EMapType mapType, float markScale, ETrackSource trackSource = ETrackSource.MapMark) : base(markId, markConfig, parent, mapType, markScale, new ETrackSource?(trackSource))
		{
		}

		// Token: 0x060377DD RID: 227293 RVA: 0x00D2DF38 File Offset: 0x00D2C138
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.FixedSceneGamePlayMarkItemView;
		}

		// Token: 0x060377DE RID: 227294 RVA: 0x00D2DF3C File Offset: 0x00D2C13C
		[PreserveBaseOverrides]
		protected new virtual FixedSceneGamePlayMarkItemView CreateView()
		{
			return new FixedSceneGamePlayMarkItemView(this);
		}

		// Token: 0x060377DF RID: 227295 RVA: 0x00D2DF44 File Offset: 0x00D2C144
		protected override void OnInitialize()
		{
			base.OnInitialize();
			this.UpdateMultiMapFloorSelectedState();
		}

		// Token: 0x060377E0 RID: 227296 RVA: 0x00D2DF54 File Offset: 0x00D2C154
		protected override void InitIcon()
		{
			LevelPlayInfo levelPlayInfo = LevelPlayModel.Instance.GetLevelPlayInfo((this.MarkConfig != null) ? this.MarkConfig.GetValueOrDefault().RelativeId : 0);
			if (levelPlayInfo == null || levelPlayInfo.IsClose)
			{
				this.IconPath = (((this.MarkConfig != null) ? this.MarkConfig.GetValueOrDefault().LockMarkPic : null) ?? "");
				return;
			}
			this.IconPath = (((this.MarkConfig != null) ? this.MarkConfig.GetValueOrDefault().UnlockMarkPic : null) ?? "");
		}

		// Token: 0x060377E1 RID: 227297 RVA: 0x00D2DFF4 File Offset: 0x00D2C1F4
		public override bool IsMultiMap()
		{
			return this.MarkConfig == null || this.MarkConfig.GetValueOrDefault().MultiMapFloorId != 0;
		}

		// Token: 0x060377E2 RID: 227298 RVA: 0x00D2E024 File Offset: 0x00D2C224
		public override int GetMultiMapId()
		{
			if (this.MarkConfig == null)
			{
				return 0;
			}
			return this.MarkConfig.GetValueOrDefault().MultiMapFloorId;
		}

		// Token: 0x060377E3 RID: 227299 RVA: 0x00D2E04F File Offset: 0x00D2C24F
		protected override void OnUpdate(global::Vector playerLocation)
		{
			base.OnUpdate(playerLocation);
			if (base.MapType == EMapType.MiniMap)
			{
				this.UpdateMultiMapFloorSelectedState();
			}
		}

		// Token: 0x060377E4 RID: 227300 RVA: 0x00D2E067 File Offset: 0x00D2C267
		private void UpdateMultiMapFloorSelectedState()
		{
			bool isSelectThisFloor = base.IsSelectThisFloor;
			base.IsSelectThisFloor = this.GetIsSelectThisFloor();
			if (isSelectThisFloor != base.IsSelectThisFloor)
			{
				base.UpdateViewIcon();
			}
		}

		// Token: 0x060377E5 RID: 227301 RVA: 0x00D2E089 File Offset: 0x00D2C289
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
