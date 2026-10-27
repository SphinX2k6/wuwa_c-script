using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DB1 RID: 19889
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoguelikeAchieveSmallTokenGrid : LoopScrollSmallItemGrid<RogueGainEntry>
	{
		// Token: 0x060335A2 RID: 210338 RVA: 0x00BFD3BB File Offset: 0x00BFB5BB
		protected override void OnStart()
		{
			base.SetToggleInteractive(false);
			base.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
		}

		// Token: 0x060335A3 RID: 210339 RVA: 0x00BFD3EC File Offset: 0x00BFB5EC
		protected override void OnRefresh(RogueGainEntry data, bool isSelected, int gridIndex)
		{
			RogueBuffPool? rogueBuffConfig = RoguelikeConfig.Instance.GetRogueBuffConfig(data.ConfigId);
			PropSmallItemGrid parameters = new PropSmallItemGrid
			{
				Data = data,
				IconPath = rogueBuffConfig.Value.BuffIcon,
				QualityId = new int?(rogueBuffConfig.Value.Quality)
			};
			base.Apply<PropSmallItemGrid>(parameters);
		}
	}
}
