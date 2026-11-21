using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003D7A RID: 15738
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoguelikeAchieveSmallTokenGrid : LoopScrollSmallItemGrid<RogueGainEntry>
	{
		// Token: 0x0602840F RID: 164879 RVA: 0x00B468EB File Offset: 0x00B44AEB
		protected override void OnStart()
		{
			base.SetToggleInteractive(false);
			base.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
		}

		// Token: 0x06028410 RID: 164880 RVA: 0x00B4691C File Offset: 0x00B44B1C
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
