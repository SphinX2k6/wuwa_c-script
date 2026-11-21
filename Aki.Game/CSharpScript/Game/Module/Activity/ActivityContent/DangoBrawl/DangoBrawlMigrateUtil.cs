using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005726 RID: 22310
	[NullableContext(1)]
	[Nullable(0)]
	public static class DangoBrawlMigrateUtil
	{
		// Token: 0x06036EA9 RID: 224937 RVA: 0x00F504A4 File Offset: 0x00F4E6A4
		public static void MoveItemsToBenchDataOnly(List<DangoBrawlBackpackItemData> items)
		{
			DangoBrawlModel instance = DangoBrawlModel.Instance;
			DangoBrawlTouchController dangoBrawlTouchController = (instance != null) ? instance.GetTouchController() : null;
			if (dangoBrawlTouchController == null)
			{
				return;
			}
			DangoBrawlBackpackData bagpackData = dangoBrawlTouchController.Data.BagpackData;
			DangoBrawlBenchData benchData = dangoBrawlTouchController.Data.BenchData;
			foreach (DangoBrawlBackpackItemData dangoBrawlBackpackItemData in items)
			{
				DangoBrawlBenchItemServerData serverData = DangoBrawlBenchServerData.MakeData(dangoBrawlBackpackItemData.MyUid, dangoBrawlBackpackItemData.MyConfigId);
				bagpackData.RemoveItemData(dangoBrawlBackpackItemData.MyUid, true);
				benchData.AddItemDataToMap(serverData, null, dangoBrawlBackpackItemData.MyRotation, true);
			}
		}

		// Token: 0x06036EAA RID: 224938 RVA: 0x00F50558 File Offset: 0x00F4E758
		public static void EmitBagToBenchForItems(List<DangoBrawlBackpackItemData> items)
		{
			foreach (DangoBrawlBackpackItemData dangoBrawlBackpackItemData in items)
			{
				EventSystem.Instance.Emit<EBagOpKind, int>(EEventName.OnDangoBrawlBagOperated, EBagOpKind.BagToBench, dangoBrawlBackpackItemData.MyUid);
			}
		}
	}
}
