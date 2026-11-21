using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Infrastructure;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020044BE RID: 17598
	[NullableContext(1)]
	[Nullable(0)]
	public class InfrRoadMarkItem : ConfigMarkItem
	{
		// Token: 0x0602C6CE RID: 181966 RVA: 0x00C7C740 File Offset: 0x00C7A940
		public InfrRoadMarkItem(int markId, MapMark markConfig, UUIItem parent, EMapType mapType, float markScale, ETrackSource trackSource = ETrackSource.MapMark) : base(markId, markConfig, parent, mapType, markScale, new ETrackSource?(trackSource))
		{
		}

		// Token: 0x0602C6CF RID: 181967 RVA: 0x00C7C756 File Offset: 0x00C7A956
		[PreserveBaseOverrides]
		protected new virtual InfrRoadMarkItemView CreateView()
		{
			return new InfrRoadMarkItemView(this);
		}

		// Token: 0x0602C6D0 RID: 181968 RVA: 0x00C7C75E File Offset: 0x00C7A95E
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.InfrRoadMarkItemView;
		}

		// Token: 0x0602C6D1 RID: 181969 RVA: 0x00C7C764 File Offset: 0x00C7A964
		protected override bool IsGamePlayFinishRaw()
		{
			InfrRoadBuild? roadConfigByMarkId = InfrastructureConfig.Instance.GetRoadConfigByMarkId(this.MarkId);
			InfrastructureDefine.IInfrRoadData roadDataByRoadId = InfrastructureModel.Instance.GetRoadDataByRoadId(roadConfigByMarkId.Value.Id);
			return roadDataByRoadId != null && roadDataByRoadId.Status == InfrStatusPb.InfrStatusComplete;
		}
	}
}
