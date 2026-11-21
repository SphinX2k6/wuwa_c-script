using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine
{
	// Token: 0x02006036 RID: 24630
	[NullableContext(1)]
	[Nullable(0)]
	public class DollItemInfo
	{
		// Token: 0x0603B22E RID: 242222 RVA: 0x010B8D96 File Offset: 0x010B6F96
		public bool IsCollectComplete()
		{
			return this.ShowedItemIds.Count == this.PartDollIdList.Count + 1;
		}

		// Token: 0x0603B22F RID: 242223 RVA: 0x010B8DB2 File Offset: 0x010B6FB2
		public int GetShowedItemCount()
		{
			return this.ShowedItemIds.Count;
		}

		// Token: 0x0603B230 RID: 242224 RVA: 0x010B8DBF File Offset: 0x010B6FBF
		public int GetTotalItemCount()
		{
			return this.PartDollIdList.Count + 1;
		}

		// Token: 0x0603B231 RID: 242225 RVA: 0x010B8DCE File Offset: 0x010B6FCE
		public bool HasShowedItem(int itemId)
		{
			return this.ShowedItemIds.Contains(itemId);
		}

		// Token: 0x0603B232 RID: 242226 RVA: 0x010B8DDC File Offset: 0x010B6FDC
		public int GetIndexByItemId(int itemId)
		{
			if (itemId == this.MainItemId)
			{
				return 0;
			}
			int num = this.PartDollIdList.IndexOf(itemId);
			if (num >= 0)
			{
				return num + 1;
			}
			return -1;
		}

		// Token: 0x0401F1C5 RID: 127429
		[Nullable(2)]
		public BP_DollShowCaseActor_C DollShowCaseActor;

		// Token: 0x0401F1C6 RID: 127430
		public string DollIdleAnimPath = string.Empty;

		// Token: 0x0401F1C7 RID: 127431
		public HashSet<int> ShowedItemIds = new HashSet<int>();

		// Token: 0x0401F1C8 RID: 127432
		[Nullable(2)]
		public DollViewCameraInfo ViewCameraInfo;

		// Token: 0x0401F1C9 RID: 127433
		public int MainItemId;

		// Token: 0x0401F1CA RID: 127434
		public List<int> PartDollIdList = new List<int>();

		// Token: 0x0401F1CB RID: 127435
		public Dictionary<int, UMaterialInterface[]> OriginalMaterialMap = new Dictionary<int, UMaterialInterface[]>();

		// Token: 0x0401F1CC RID: 127436
		public HashSet<int> BindingItemIdSet = new HashSet<int>();
	}
}
