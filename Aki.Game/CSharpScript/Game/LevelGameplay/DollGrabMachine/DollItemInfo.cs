using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine
{
	// Token: 0x02006EB6 RID: 28342
	[NullableContext(1)]
	[Nullable(0)]
	public class DollItemInfo
	{
		// Token: 0x0604508D RID: 282765 RVA: 0x0110ECBA File Offset: 0x0110CEBA
		public bool IsCollectComplete()
		{
			return this.ShowedItemIds.Count == this.PartDollIdList.Count + 1;
		}

		// Token: 0x0604508E RID: 282766 RVA: 0x0110ECD6 File Offset: 0x0110CED6
		public int GetShowedItemCount()
		{
			return this.ShowedItemIds.Count;
		}

		// Token: 0x0604508F RID: 282767 RVA: 0x0110ECE3 File Offset: 0x0110CEE3
		public int GetTotalItemCount()
		{
			return this.PartDollIdList.Count + 1;
		}

		// Token: 0x06045090 RID: 282768 RVA: 0x0110ECF2 File Offset: 0x0110CEF2
		public bool HasShowedItem(int itemId)
		{
			return this.ShowedItemIds.Contains(itemId);
		}

		// Token: 0x06045091 RID: 282769 RVA: 0x0110ED00 File Offset: 0x0110CF00
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

		// Token: 0x04023F12 RID: 147218
		[Nullable(2)]
		public BP_DollShowCaseActor_C DollShowCaseActor;

		// Token: 0x04023F13 RID: 147219
		public string DollIdleAnimPath = string.Empty;

		// Token: 0x04023F14 RID: 147220
		public HashSet<int> ShowedItemIds = new HashSet<int>();

		// Token: 0x04023F15 RID: 147221
		[Nullable(2)]
		public DollViewCameraInfo ViewCameraInfo;

		// Token: 0x04023F16 RID: 147222
		public int MainItemId;

		// Token: 0x04023F17 RID: 147223
		public List<int> PartDollIdList = new List<int>();

		// Token: 0x04023F18 RID: 147224
		public Dictionary<int, UMaterialInterface[]> OriginalMaterialMap = new Dictionary<int, UMaterialInterface[]>();

		// Token: 0x04023F19 RID: 147225
		public HashSet<int> BindingItemIdSet = new HashSet<int>();
	}
}
