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
	// Token: 0x020054F6 RID: 21750
	[NullableContext(1)]
	[Nullable(0)]
	public class SheriffAnomalyMarkItem : ConfigMarkItem
	{
		// Token: 0x060378F9 RID: 227577 RVA: 0x00D30F49 File Offset: 0x00D2F149
		public SheriffAnomalyMarkItem(int markId, MapMark markConfig, UUIItem parent, EMapType mapType, float markScale, ETrackSource trackSource = ETrackSource.MapMark) : base(markId, markConfig, parent, mapType, markScale, new ETrackSource?(trackSource))
		{
		}

		// Token: 0x060378FA RID: 227578 RVA: 0x00D30F5F File Offset: 0x00D2F15F
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.SheriffAnomalyMarkItemView;
		}

		// Token: 0x060378FB RID: 227579 RVA: 0x00D30F63 File Offset: 0x00D2F163
		[PreserveBaseOverrides]
		protected new virtual SheriffAnomalyMarkItemView CreateView()
		{
			return new SheriffAnomalyMarkItemView(this);
		}

		// Token: 0x060378FC RID: 227580 RVA: 0x00D30F6B File Offset: 0x00D2F16B
		public override bool CheckCanShowView()
		{
			return MapModel.Instance.IsExtraUiMarkType(base.MapType, this.MarkType);
		}

		// Token: 0x060378FD RID: 227581 RVA: 0x00D30F84 File Offset: 0x00D2F184
		public override bool CheckCanShowViewInExtraUi()
		{
			SheriffAnomaly? anomalyConfigByMarkId = SheriffConfig.Instance.GetAnomalyConfigByMarkId(this.MarkId);
			SheriffAnomalyInfo anomalyInfo = SheriffModel.Instance.GetAnomalyInfo(anomalyConfigByMarkId.Value.Id);
			return anomalyInfo.State != ESheriffAnomalyState.Lock && (anomalyInfo.State != ESheriffAnomalyState.Completed || !LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.SheriffHideCompletedMarkItem, false));
		}

		// Token: 0x060378FE RID: 227582 RVA: 0x00D30FDF File Offset: 0x00D2F1DF
		protected override bool IsTracking()
		{
			return !MapModel.Instance.IsExtraUiMarkType(base.MapType, this.MarkType) && base.IsTracking();
		}

		// Token: 0x0401D3D3 RID: 119763
		[Nullable(2)]
		public SheriffAnomalyMarkItemView InnerView;
	}
}
