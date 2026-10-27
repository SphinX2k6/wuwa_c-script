using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E5A RID: 7770
public class HelpGuidePage : UiPanelBase
{
	// Token: 0x0600EC23 RID: 60451 RVA: 0x00380E94 File Offset: 0x0037F094
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

	// Token: 0x0600EC24 RID: 60452 RVA: 0x00380F04 File Offset: 0x0037F104
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		base.GetTexture(3).SetUIActive(false);
		base.GetText(2).SetUIActive(false);
		base.GetItem(0).SetUIActive(false);
	}

	// Token: 0x0600EC25 RID: 60453 RVA: 0x00380F3E File Offset: 0x0037F13E
	protected override void OnBeforeDestroy()
	{
		this.LevelSequencePlayer.Clear();
		this.LevelSequencePlayer = null;
	}

	// Token: 0x0600EC26 RID: 60454 RVA: 0x00380F54 File Offset: 0x0037F154
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

	// Token: 0x0600EC27 RID: 60455 RVA: 0x00381008 File Offset: 0x0037F208
	public void PlayAnime(bool isShow)
	{
		this.LevelSequencePlayer.PlayLevelSequenceByName(isShow ? "Show" : "Hide", false, null, false);
	}

	// Token: 0x04006D7E RID: 28030
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0200840C RID: 33804
	private static class ETutorialsPageComponents
	{
		// Token: 0x0402AFA8 RID: 176040
		public const int PnlOffset = 0;

		// Token: 0x0402AFA9 RID: 176041
		public const int TxtSubTitle = 1;

		// Token: 0x0402AFAA RID: 176042
		public const int TxtTutorials = 2;

		// Token: 0x0402AFAB RID: 176043
		public const int TexPicture = 3;
	}
}
