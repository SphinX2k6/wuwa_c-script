using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.MapDefine;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020044B0 RID: 17584
	public class DreamLinkRunMarkItem : SceneGameplayMarkItem
	{
		// Token: 0x0602C63F RID: 181823 RVA: 0x00C7B00C File Offset: 0x00C7920C
		[NullableContext(1)]
		public DreamLinkRunMarkItem(int markId, MapMark markConfig, UUIItem parent, EMapType mapType, float markScale, ETrackSource? trackSource = null) : base(markId, markConfig, parent, mapType, markScale, trackSource)
		{
		}

		// Token: 0x0602C640 RID: 181824 RVA: 0x00C7B01D File Offset: 0x00C7921D
		public override bool CheckCanShowView()
		{
			return ActivityModel.Instance.GetActivityMapMarkState(26, this.MarkId);
		}
	}
}
