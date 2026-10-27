using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.LevelGamePlay.DollGrabMachine;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020054DC RID: 21724
	[NullableContext(1)]
	[Nullable(0)]
	public class DollGrabMachineMarkItem : ConfigMarkItem
	{
		// Token: 0x06037782 RID: 227202 RVA: 0x00D2CEE1 File Offset: 0x00D2B0E1
		public DollGrabMachineMarkItem(int markId, MapMark markConfig, UUIItem parent, EMapType mapType, float markScale, ETrackSource trackSource = ETrackSource.MapMark) : base(markId, markConfig, parent, mapType, markScale, new ETrackSource?(trackSource))
		{
		}

		// Token: 0x06037783 RID: 227203 RVA: 0x00D2CEF7 File Offset: 0x00D2B0F7
		protected override void OnInitialize()
		{
			base.OnInitialize();
			this.UpdateGamePlayState();
		}

		// Token: 0x06037784 RID: 227204 RVA: 0x00D2CF05 File Offset: 0x00D2B105
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.DollGrabMachineMarkItemView;
		}

		// Token: 0x06037785 RID: 227205 RVA: 0x00D2CF09 File Offset: 0x00D2B109
		protected override MarkItemView CreateView()
		{
			return new DollGrabMachineMarkItemView(this);
		}

		// Token: 0x06037786 RID: 227206 RVA: 0x00D2CF14 File Offset: 0x00D2B114
		public int GetEntityId()
		{
			if (this.MarkConfig == null)
			{
				return 0;
			}
			return this.MarkConfig.GetValueOrDefault().EntityConfigId;
		}

		// Token: 0x06037787 RID: 227207 RVA: 0x00D2CF40 File Offset: 0x00D2B140
		protected void UpdateGamePlayState()
		{
			int entityId = this.GetEntityId();
			if (MapModel.Instance.IsMarkHideByServer(this.MapId, entityId))
			{
				base.MarkItemEntity.GamePlay.GamePlayState = EMarkGamePlayState.Hide;
				return;
			}
			base.MarkItemEntity.GamePlay.GamePlayState = (DollGrabModel.Instance.IsDollGrabMachineDeliveryComplete(this.MapId, entityId) ? EMarkGamePlayState.Finish : EMarkGamePlayState.Processing);
		}
	}
}
