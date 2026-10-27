using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.MapDefine;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020054DD RID: 21725
	public class DreamLinkRunMarkItem : SceneGameplayMarkItem
	{
		// Token: 0x06037788 RID: 227208 RVA: 0x00D2CFA0 File Offset: 0x00D2B1A0
		[NullableContext(1)]
		public DreamLinkRunMarkItem(int markId, MapMark markConfig, UUIItem parent, EMapType mapType, float markScale, ETrackSource? trackSource = null) : base(markId, markConfig, parent, mapType, markScale, trackSource)
		{
		}

		// Token: 0x06037789 RID: 227209 RVA: 0x00D2CFB1 File Offset: 0x00D2B1B1
		public override bool CheckCanShowView()
		{
			return ActivityModel.Instance.GetActivityMapMarkState(26, this.MarkId);
		}
	}
}
