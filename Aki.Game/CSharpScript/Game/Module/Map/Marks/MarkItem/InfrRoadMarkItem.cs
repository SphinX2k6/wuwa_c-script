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
	// Token: 0x020054EB RID: 21739
	[NullableContext(1)]
	[Nullable(0)]
	public class InfrRoadMarkItem : ConfigMarkItem
	{
		// Token: 0x06037812 RID: 227346 RVA: 0x00D2E648 File Offset: 0x00D2C848
		public InfrRoadMarkItem(int markId, MapMark markConfig, UUIItem parent, EMapType mapType, float markScale, ETrackSource trackSource = ETrackSource.MapMark) : base(markId, markConfig, parent, mapType, markScale, new ETrackSource?(trackSource))
		{
		}

		// Token: 0x06037813 RID: 227347 RVA: 0x00D2E65E File Offset: 0x00D2C85E
		protected override void OnInitialize()
		{
			base.OnInitialize();
			this.UpdateGamePlayState();
		}

		// Token: 0x06037814 RID: 227348 RVA: 0x00D2E66C File Offset: 0x00D2C86C
		[PreserveBaseOverrides]
		protected new virtual InfrRoadMarkItemView CreateView()
		{
			return new InfrRoadMarkItemView(this);
		}

		// Token: 0x06037815 RID: 227349 RVA: 0x00D2E674 File Offset: 0x00D2C874
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.InfrRoadMarkItemView;
		}

		// Token: 0x06037816 RID: 227350 RVA: 0x00D2E678 File Offset: 0x00D2C878
		protected override bool GamePlayIsFinish()
		{
			InfrRoadBuild? roadConfigByMarkId = InfrastructureConfig.Instance.GetRoadConfigByMarkId(this.MarkId);
			InfrastructureDefine.IInfrRoadData roadDataByRoadId = InfrastructureModel.Instance.GetRoadDataByRoadId(roadConfigByMarkId.Value.Id);
			return roadDataByRoadId != null && roadDataByRoadId.Status == InfrStatusPb.InfrStatusComplete;
		}

		// Token: 0x06037817 RID: 227351 RVA: 0x00D2E6BD File Offset: 0x00D2C8BD
		public void UpdateGamePlayState()
		{
			base.MarkItemEntity.GamePlay.GamePlayState = (this.GamePlayIsFinish() ? EMarkGamePlayState.Finish : EMarkGamePlayState.Processing);
		}

		// Token: 0x0401D3A8 RID: 119720
		[Nullable(2)]
		public InfrRoadMarkItemView InnerView;
	}
}
