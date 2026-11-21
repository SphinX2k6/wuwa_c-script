using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200571B RID: 22299
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlBenchData
	{
		// Token: 0x17006A07 RID: 27143
		// (get) Token: 0x06036E18 RID: 224792 RVA: 0x00F4D811 File Offset: 0x00F4BA11
		public int MyActivityId
		{
			get
			{
				return this.ActivityId;
			}
		}

		// Token: 0x06036E19 RID: 224793 RVA: 0x00F4D819 File Offset: 0x00F4BA19
		public void Init(int activityId, DangoBrawlBenchServerData serverData)
		{
			this.ActivityId = activityId;
			this.InitItemDataMap(serverData);
		}

		// Token: 0x06036E1A RID: 224794 RVA: 0x00F4D82C File Offset: 0x00F4BA2C
		private void InitItemDataMap(DangoBrawlBenchServerData serverData)
		{
			foreach (DangoBrawlBenchItemServerData dangoBrawlBenchItemServerData in serverData.GetItemList())
			{
				DangoBrawlBenchItemData dangoBrawlBenchItemData = new DangoBrawlBenchItemData(dangoBrawlBenchItemServerData, EDangoBrawlRotate.Direction0);
				dangoBrawlBenchItemData.MyLastAnchor = new ItemSucAnchor
				{
					SourceKind = EDragSourceKind.Bench
				};
				this.ItemDataMap[dangoBrawlBenchItemServerData.Uid] = dangoBrawlBenchItemData;
			}
		}

		// Token: 0x06036E1B RID: 224795 RVA: 0x00F4D8A4 File Offset: 0x00F4BAA4
		public void AddItemDataToMap(DangoBrawlBenchItemServerData serverData, FVector2D? dropLguiPos = null, EDangoBrawlRotate bagRotation = EDangoBrawlRotate.Direction0, bool emitEvent = true)
		{
			DangoBrawlBenchItemData dangoBrawlBenchItemData = new DangoBrawlBenchItemData(serverData, bagRotation);
			dangoBrawlBenchItemData.MyDropLguiPos = dropLguiPos;
			this.ItemDataMap[dangoBrawlBenchItemData.MyUid] = dangoBrawlBenchItemData;
			FVector2D? benchPos = (dropLguiPos != null) ? new FVector2D?(new FVector2D(dropLguiPos.Value.X, dropLguiPos.Value.Y)) : null;
			dangoBrawlBenchItemData.MyLastAnchor = new ItemSucAnchor
			{
				SourceKind = EDragSourceKind.Bench,
				BenchPos = benchPos
			};
			if (emitEvent)
			{
				EventSystem.Instance.Emit<EDangoBrawlModifyType, int>(EEventName.OnDangoBrawlBenchModified, EDangoBrawlModifyType.Add, dangoBrawlBenchItemData.MyUid);
			}
		}

		// Token: 0x06036E1C RID: 224796 RVA: 0x00F4D940 File Offset: 0x00F4BB40
		public void DelItemDataFromMap(int uid, bool emitEvent = true)
		{
			DangoBrawlBenchItemData dangoBrawlBenchItemData;
			if (!this.ItemDataMap.TryGetValue(uid, out dangoBrawlBenchItemData))
			{
				return;
			}
			this.ItemDataMap.Remove(uid);
			if (emitEvent)
			{
				EventSystem.Instance.Emit<EDangoBrawlModifyType, int>(EEventName.OnDangoBrawlBenchModified, EDangoBrawlModifyType.Remove, uid);
			}
		}

		// Token: 0x06036E1D RID: 224797 RVA: 0x00F4D980 File Offset: 0x00F4BB80
		public bool MoveItem(int uid, FVector2D? dropLguiPos = null, EDangoBrawlRotate? newRotation = null, bool emitEvent = true)
		{
			DangoBrawlBenchItemData dangoBrawlBenchItemData;
			if (!this.ItemDataMap.TryGetValue(uid, out dangoBrawlBenchItemData))
			{
				return false;
			}
			dangoBrawlBenchItemData.MyDropLguiPos = dropLguiPos;
			if (newRotation != null)
			{
				dangoBrawlBenchItemData.MyRotation = newRotation.Value;
			}
			FVector2D? benchPos = (dropLguiPos != null) ? new FVector2D?(new FVector2D(dropLguiPos.Value.X, dropLguiPos.Value.Y)) : null;
			dangoBrawlBenchItemData.MyLastAnchor = new ItemSucAnchor
			{
				SourceKind = EDragSourceKind.Bench,
				BenchPos = benchPos
			};
			if (emitEvent)
			{
				EventSystem.Instance.Emit<EDangoBrawlModifyType, int>(EEventName.OnDangoBrawlBenchModified, EDangoBrawlModifyType.Modify, uid);
			}
			return true;
		}

		// Token: 0x06036E1E RID: 224798 RVA: 0x00F4DA24 File Offset: 0x00F4BC24
		[NullableContext(2)]
		public DangoBrawlBenchItemData GetItem(int uid)
		{
			DangoBrawlBenchItemData result;
			if (!this.ItemDataMap.TryGetValue(uid, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06036E1F RID: 224799 RVA: 0x00F4DA44 File Offset: 0x00F4BC44
		public List<DangoBrawlBenchItemData> GetItemList()
		{
			return new List<DangoBrawlBenchItemData>(this.ItemDataMap.Values);
		}

		// Token: 0x06036E20 RID: 224800 RVA: 0x00F4DA56 File Offset: 0x00F4BC56
		public int GetAreaCount()
		{
			return DangoBrawlConfig.Instance.GetBenchAreaSizeByActivityId(this.ActivityId);
		}

		// Token: 0x06036E21 RID: 224801 RVA: 0x00F4DA68 File Offset: 0x00F4BC68
		public bool HasCapacityFor(int n)
		{
			return this.ItemDataMap.Count + n <= 999;
		}

		// Token: 0x0401D116 RID: 119062
		private int ActivityId;

		// Token: 0x0401D117 RID: 119063
		private readonly Dictionary<int, DangoBrawlBenchItemData> ItemDataMap = new Dictionary<int, DangoBrawlBenchItemData>();

		// Token: 0x0401D118 RID: 119064
		private const int MAX_CAPACITY = 999;
	}
}
