using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.ItemInspect.Point
{
	// Token: 0x02005F6F RID: 24431
	public static class ItemInspectPointManagerCreator
	{
		// Token: 0x0603AC0E RID: 240654 RVA: 0x0109D384 File Offset: 0x0109B584
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
