using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200131C RID: 4892
public class HelpGuidePage : UiPanelBase
{
	// Token: 0x0600C042 RID: 49218 RVA: 0x0038CB40 File Offset: 0x0038AD40
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUITexture))
		};
	}

	// Token: 0x0600C043 RID: 49219 RVA: 0x0038CBB0 File Offset: 0x0038ADB0
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		base.GetTexture(3).SetUIActive(false);
		base.GetText(2).SetUIActive(false);
		base.GetItem(0).SetUIActive(false);
	}

	// Token: 0x0600C044 RID: 49220 RVA: 0x0038CBEA File Offset: 0x0038ADEA
	protected override void OnBeforeDestroy()
	{
		this.LevelSequencePlayer.Clear();
		this.LevelSequencePlayer = null;
	}

	// Token: 0x0600C045 RID: 49221 RVA: 0x0038CC00 File Offset: 0x0038AE00
	public void RefreshPage(HelpText? pageConfig)
	{
		if (pageConfig == null)
		{
			return;
		}
		bool flag = !StringUtils.IsEmpty(pageConfig.Value.Picture);
		base.GetTexture(3).SetUIActive(flag);
		if (flag)
		{
			base.SetTextureByPath(pageConfig.Value.Picture, base.GetTexture(3), null, delegate(bool _)
			{
				base.GetTexture(3).SetUIActive(true);
			});
		}
		bool flag2 = !StringUtils.IsEmpty(pageConfig.Value.Content);
		base.GetText(2).SetUIActive(flag2);
		if (flag2)
		{
			base.GetText(2).ShowTextNew(pageConfig.Value.Content);
		}
	}

	// Token: 0x0600C046 RID: 49222 RVA: 0x0038CCB4 File Offset: 0x0038AEB4
	public void PlayAnime(bool isShow)
	{
		this.LevelSequencePlayer.PlayLevelSequenceByName(isShow ? "Show" : "Hide", false, null, false);
	}

	// Token: 0x04006E5F RID: 28255
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x02007591 RID: 30097
	private static class ETutorialsPageComponents
	{
		// Token: 0x040262CC RID: 156364
		public const int PnlOffset = 0;

		// Token: 0x040262CD RID: 156365
		public const int TxtSubTitle = 1;

		// Token: 0x040262CE RID: 156366
		public const int TxtTutorials = 2;

		// Token: 0x040262CF RID: 156367
		public const int TexPicture = 3;
	}
}
