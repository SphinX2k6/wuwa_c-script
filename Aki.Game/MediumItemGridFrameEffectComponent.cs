using System;
using System.Runtime.CompilerServices;

// Token: 0x02001916 RID: 6422
public class MediumItemGridFrameEffectComponent : MediumItemGridVisibleComponent
{
	// Token: 0x0600BC20 RID: 48160 RVA: 0x002AA1FC File Offset: 0x002A83FC
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemAFetterVfx";
	}

	// Token: 0x0600BC21 RID: 48161 RVA: 0x002AA204 File Offset: 0x002A8404
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		this.LevelSequencePlayer.PlayLevelSequenceByName("Loop", false, null, false);
	}

	// Token: 0x04005532 RID: 21810
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;
}
