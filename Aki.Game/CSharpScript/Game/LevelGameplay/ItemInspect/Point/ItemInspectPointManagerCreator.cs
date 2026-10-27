using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.ItemInspect.Point
{
	// Token: 0x02006DF0 RID: 28144
	public static class ItemInspectPointManagerCreator
	{
		// Token: 0x06044AAA RID: 281258 RVA: 0x010F3138 File Offset: 0x010F1338
		[NullableContext(1)]
		[return: Nullable(2)]
		public static ItemInspectPointManager createPointManager(ISequenceUnlockPoints config)
		{
			ItemInspectPointManager itemInspectPointManager = null;
			if (config.Type == EInteractUnlockType.Sequence)
			{
				itemInspectPointManager = new SequenceUnlockPointManager();
			}
			if (itemInspectPointManager == null)
			{
				return null;
			}
			itemInspectPointManager.Init(config);
			return itemInspectPointManager;
		}
	}
}
