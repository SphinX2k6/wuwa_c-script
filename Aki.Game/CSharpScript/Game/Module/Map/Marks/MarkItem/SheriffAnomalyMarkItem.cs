using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;
using CSharpScript.Game.Module.Sheriff;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020044C9 RID: 17609
	[NullableContext(1)]
	[Nullable(0)]
	public class SheriffAnomalyMarkItem : ConfigMarkItem
	{
		// Token: 0x0602C7C7 RID: 182215 RVA: 0x00C7EE96 File Offset: 0x00C7D096
		public SheriffAnomalyMarkItem(int markId, MapMark markConfig, UUIItem parent, EMapType mapType, float markScale, ETrackSource trackSource = ETrackSource.MapMark) : base(markId, markConfig, parent, mapType, markScale, new ETrackSource?(trackSource))
		{
		}

		// Token: 0x0602C7C8 RID: 182216 RVA: 0x00C7EEAC File Offset: 0x00C7D0AC
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.SheriffAnomalyMarkItemView;
		}

		// Token: 0x0602C7C9 RID: 182217 RVA: 0x00C7EEB0 File Offset: 0x00C7D0B0
		[PreserveBaseOverrides]
		protected new virtual SheriffAnomalyMarkItemView CreateView()
		{
			return new SheriffAnomalyMarkItemView(this);
		}

		// Token: 0x0602C7CA RID: 182218 RVA: 0x00C7EEB8 File Offset: 0x00C7D0B8
		public override bool CheckCanShowView()
		{
			return MapModel.Instance.IsExtraUiMarkType(base.MapType, this.MarkType);
		}

		// Token: 0x0602C7CB RID: 182219 RVA: 0x00C7EED0 File Offset: 0x00C7D0D0
		public override bool CheckCanShowViewInExtraUi()
		{
			SheriffAnomaly? anomalyConfigByMarkId = SheriffConfig.Instance.GetAnomalyConfigByMarkId(this.MarkId);
			SheriffAnomalyInfo anomalyInfo = SheriffModel.Instance.GetAnomalyInfo(anomalyConfigByMarkId.Value.Id);
			return anomalyInfo.State != ESheriffAnomalyState.Lock && (anomalyInfo.State != ESheriffAnomalyState.Completed || !LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.SheriffHideCompletedMarkItem, false));
		}

		// Token: 0x0602C7CC RID: 182220 RVA: 0x00C7EF2B File Offset: 0x00C7D12B
		protected override bool IsTracking()
		{
			return !MapModel.Instance.IsExtraUiMarkType(base.MapType, this.MarkType) && base.IsTracking();
		}

		// Token: 0x0602C7CD RID: 182221 RVA: 0x00C7EF4D File Offset: 0x00C7D14D
		protected override bool IsGamePlayFinishRaw()
		{
			return false;
		}
	}
}
