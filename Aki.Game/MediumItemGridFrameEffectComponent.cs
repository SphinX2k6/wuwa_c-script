using System;
using System.Runtime.CompilerServices;

// Token: 0x02000DCF RID: 3535
public class MediumItemGridFrameEffectComponent : MediumItemGridVisibleComponent
{
	// Token: 0x0600900A RID: 36874 RVA: 0x002B4958 File Offset: 0x002B2B58
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemAFetterVfx";
	}

	// Token: 0x0600900B RID: 36875 RVA: 0x002B4960 File Offset: 0x002B2B60
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		this.LevelSequencePlayer.PlayLevelSequenceByName("Loop", false, null, false);
	}

	// Token: 0x040055DD RID: 21981
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;
}
