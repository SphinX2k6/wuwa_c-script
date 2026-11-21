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
	// Token: 0x020044AF RID: 17583
	[NullableContext(1)]
	[Nullable(0)]
	public class DollGrabMachineMarkItem : ConfigMarkItem
	{
		// Token: 0x0602C639 RID: 181817 RVA: 0x00C7AF81 File Offset: 0x00C79181
		public DollGrabMachineMarkItem(int markId, MapMark markConfig, UUIItem parent, EMapType mapType, float markScale, ETrackSource trackSource = ETrackSource.MapMark) : base(markId, markConfig, parent, mapType, markScale, new ETrackSource?(trackSource))
		{
		}

		// Token: 0x0602C63A RID: 181818 RVA: 0x00C7AF97 File Offset: 0x00C79197
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.DollGrabMachineMarkItemView;
		}

		// Token: 0x0602C63B RID: 181819 RVA: 0x00C7AF9B File Offset: 0x00C7919B
		protected override MarkItemView CreateView()
		{
			return new DollGrabMachineMarkItemView(this);
		}

		// Token: 0x0602C63C RID: 181820 RVA: 0x00C7AFA4 File Offset: 0x00C791A4
		public int GetEntityId()
		{
			if (base.MarkConfig == null)
			{
				return 0;
			}
			MapMark? mapMark;
			return mapMark.GetValueOrDefault().EntityConfigId;
		}

		// Token: 0x0602C63D RID: 181821 RVA: 0x00C7AFD2 File Offset: 0x00C791D2
		public override bool IsMarkDisabled()
		{
			return MapModel.Instance.IsMarkHideByServer(this.MapId, this.GetEntityId());
		}

		// Token: 0x0602C63E RID: 181822 RVA: 0x00C7AFEA File Offset: 0x00C791EA
		protected override bool IsGamePlayFinishRaw()
		{
			return !this.IsMarkDisabled() && DollGrabModel.Instance.IsDollGrabMachineDeliveryComplete(this.MapId, this.GetEntityId());
		}
	}
}
