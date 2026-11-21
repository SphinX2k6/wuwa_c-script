using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020044D0 RID: 17616
	[NullableContext(1)]
	[Nullable(0)]
	public class TraceExploreEntityMarkItem : ServerMarkItem
	{
		// Token: 0x17005930 RID: 22832
		// (get) Token: 0x0602C82D RID: 182317 RVA: 0x00C80A1B File Offset: 0x00C7EC1B
		// (set) Token: 0x0602C82E RID: 182318 RVA: 0x00C80A28 File Offset: 0x00C7EC28
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

		// Token: 0x17005931 RID: 22833
		// (get) Token: 0x0602C82F RID: 182319 RVA: 0x00C80A36 File Offset: 0x00C7EC36
		public override int MapId
		{
			get
			{
				return this.ServerMarkInfo.MapId;
			}
		}

		// Token: 0x17005932 RID: 22834
		// (get) Token: 0x0602C830 RID: 182320 RVA: 0x00C80A43 File Offset: 0x00C7EC43
		public override int? InstanceDungeonId
		{
			get
			{
				return this.ServerMarkInfo.InstanceDungeonId;
			}
		}

		// Token: 0x0602C831 RID: 182321 RVA: 0x00C80A50 File Offset: 0x00C7EC50
		public TraceExploreEntityMarkItem(DynamicMarkCreateInfo markPointInfo, UUIItem parent, EMapType mapType, float markScale) : base(markPointInfo, parent, mapType, markScale)
		{
		}

		// Token: 0x0602C832 RID: 182322 RVA: 0x00C80A60 File Offset: 0x00C7EC60
		protected override void OnInitialize()
		{
			base.OnInitialize();
			DynamicMarkCreateInfo serverMarkInfo = this.ServerMarkInfo;
			base.SetTrackData(serverMarkInfo.TrackTarget);
			this.SetConfigId(serverMarkInfo.MarkConfigId);
			this.UpdateVisibleRelativeState();
		}

		// Token: 0x0602C833 RID: 182323 RVA: 0x00C80A98 File Offset: 0x00C7EC98
		public void SetConfigId(int configId)
		{
			this.ServerMarkInfo.MarkConfigId = configId;
			this.OnSetConfigId(configId);
		}

		// Token: 0x0602C834 RID: 182324 RVA: 0x00C80AB0 File Offset: 0x00C7ECB0
		public void OnSetConfigId(int configId)
		{
			MapMark value = MapConfig.Instance.GetConfigMark(configId).Value;
			this.MarkConfigInternal = new MapMark?(value);
			this.Config = new MapMarkConfig(value);
			this.OnAfterSetConfigId(new MarkItemData
			{
				ShowRange = value.ShowRange(),
				MarkPic = value.UnlockMarkPic,
				ShowPriority = new int?(value.ShowPriority),
				Scale = new float?(value.Scale),
				CornerScale = new float?(value.CornerScale)
			});
		}

		// Token: 0x0602C835 RID: 182325 RVA: 0x00C80B44 File Offset: 0x00C7ED44
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

		// Token: 0x0602C836 RID: 182326 RVA: 0x00C80BB4 File Offset: 0x00C7EDB4
		public bool CanConditionShowView()
		{
			HashSet<int> pendingAddTempMapMarkList = MapModel.Instance.GetPendingAddTempMapMarkList();
			this.IsTempMapMark = pendingAddTempMapMarkList.Contains(this.MarkId);
			return this.IsTempMapMark && this.IsTempMapMarkShow();
		}

		// Token: 0x0602C837 RID: 182327 RVA: 0x00C80BF4 File Offset: 0x00C7EDF4
		public override string GetTitleText()
		{
			return MapConfig.Instance.GetLocalText(this.MarkConfig.MarkTitle);
		}

		// Token: 0x04017E85 RID: 97925
		private MapMark? MarkConfigInternal;
	}
}
