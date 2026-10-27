using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Mark.Component;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020054FD RID: 21757
	[NullableContext(1)]
	[Nullable(0)]
	public class TraceExploreEntityMarkItem : ServerMarkItem
	{
		// Token: 0x17008595 RID: 34197
		// (get) Token: 0x0603795E RID: 227678 RVA: 0x00D32A3F File Offset: 0x00D30C3F
		// (set) Token: 0x0603795F RID: 227679 RVA: 0x00D32A4C File Offset: 0x00D30C4C
		public MapMark MarkConfig
		{
			get
			{
				return this.MarkConfigInternal.Value;
			}
			set
			{
				this.MarkConfigInternal = new MapMark?(value);
			}
		}

		// Token: 0x17008596 RID: 34198
		// (get) Token: 0x06037960 RID: 227680 RVA: 0x00D32A5A File Offset: 0x00D30C5A
		public override int MapId
		{
			get
			{
				return this.ServerMarkInfo.MapId;
			}
		}

		// Token: 0x17008597 RID: 34199
		// (get) Token: 0x06037961 RID: 227681 RVA: 0x00D32A67 File Offset: 0x00D30C67
		public override int? InstanceDungeonId
		{
			get
			{
				return this.ServerMarkInfo.InstanceDungeonId;
			}
		}

		// Token: 0x06037962 RID: 227682 RVA: 0x00D32A74 File Offset: 0x00D30C74
		public TraceExploreEntityMarkItem(DynamicMarkCreateInfo markPointInfo, UUIItem parent, EMapType mapType, float markScale) : base(markPointInfo, parent, mapType, markScale)
		{
		}

		// Token: 0x06037963 RID: 227683 RVA: 0x00D32A84 File Offset: 0x00D30C84
		protected override void OnInitialize()
		{
			base.OnInitialize();
			DynamicMarkCreateInfo serverMarkInfo = this.ServerMarkInfo;
			base.SetTrackData(serverMarkInfo.TrackTarget);
			this.SetConfigId(serverMarkInfo.MarkConfigId);
			this.UpdateVisibleRelativeState();
		}

		// Token: 0x06037964 RID: 227684 RVA: 0x00D32ABC File Offset: 0x00D30CBC
		public void SetConfigId(int configId)
		{
			this.ServerMarkInfo.MarkConfigId = configId;
			this.OnSetConfigId(configId);
		}

		// Token: 0x06037965 RID: 227685 RVA: 0x00D32AD4 File Offset: 0x00D30CD4
		public void OnSetConfigId(int configId)
		{
			MapMark value = MapConfig.Instance.GetConfigMark(configId).Value;
			this.MarkConfigInternal = new MapMark?(value);
			base.MarkItemEntity.GetComponent<MarkConfigComponent>(EMapComponent.MarkConfig).Config = value;
			this.OnAfterSetConfigId(new MarkItemData
			{
				ShowRange = value.ShowRange(),
				MarkPic = value.UnlockMarkPic,
				ShowPriority = new int?(value.ShowPriority),
				Scale = new float?(value.Scale),
				CornerScale = new float?(value.CornerScale)
			});
		}

		// Token: 0x06037966 RID: 227686 RVA: 0x00D32B74 File Offset: 0x00D30D74
		public override bool CheckCanShowView()
		{
			if (!this.CanConditionShowView())
			{
				return base.IsTracked;
			}
			float currentMapShowScale = this.GetCurrentMapShowScale();
			bool flag = base.CheckInShowRange(currentMapShowScale) || base.IsTracked;
			if (base.MapType == EMapType.WorldMap)
			{
				bool isCanShowViewIntermediately = base.IsCanShowViewIntermediately;
				bool flag2 = flag || base.IsIgnoreScaleShow;
				if (isCanShowViewIntermediately != flag2)
				{
					base.NeedPlayShowOrHideSeq = (flag2 ? "ShowView" : "HideView");
				}
				return flag2;
			}
			return true;
		}

		// Token: 0x06037967 RID: 227687 RVA: 0x00D32BE4 File Offset: 0x00D30DE4
		public bool CanConditionShowView()
		{
			HashSet<int> pendingAddTempMapMarkList = MapModel.Instance.GetPendingAddTempMapMarkList();
			base.MarkItemEntity.IsTempMapMark = pendingAddTempMapMarkList.Contains(this.MarkId);
			return base.MarkItemEntity.IsTempMapMark && this.IsTempMapMarkShow();
		}

		// Token: 0x06037968 RID: 227688 RVA: 0x00D32C2C File Offset: 0x00D30E2C
		public override string GetTitleText()
		{
			return MapConfig.Instance.GetLocalText(this.MarkConfig.MarkTitle);
		}

		// Token: 0x0401D3FF RID: 119807
		private MapMark? MarkConfigInternal;
	}
}
