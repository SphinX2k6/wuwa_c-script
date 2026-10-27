using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067CB RID: 26571
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlBenchData
	{
		// Token: 0x170096C6 RID: 38598
		// (get) Token: 0x060422C2 RID: 271042 RVA: 0x0100C445 File Offset: 0x0100A645
		public int MyActivityId
		{
			get
			{
				return this.ActivityId;
			}
		}

		// Token: 0x060422C3 RID: 271043 RVA: 0x0100C44D File Offset: 0x0100A64D
		public void Init(int activityId, DangoBrawlBenchServerData serverData)
		{
			this.ActivityId = activityId;
			this.InitItemDataMap(serverData);
		}

		// Token: 0x060422C4 RID: 271044 RVA: 0x0100C460 File Offset: 0x0100A660
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

		// Token: 0x060422C5 RID: 271045 RVA: 0x0100C4D8 File Offset: 0x0100A6D8
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

		// Token: 0x060422C6 RID: 271046 RVA: 0x0100C574 File Offset: 0x0100A774
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

		// Token: 0x060422C7 RID: 271047 RVA: 0x0100C5B4 File Offset: 0x0100A7B4
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

		// Token: 0x060422C8 RID: 271048 RVA: 0x0100C658 File Offset: 0x0100A858
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

		// Token: 0x060422C9 RID: 271049 RVA: 0x0100C678 File Offset: 0x0100A878
		public List<DangoBrawlBenchItemData> GetItemList()
		{
			return new List<DangoBrawlBenchItemData>(this.ItemDataMap.Values);
		}

		// Token: 0x060422CA RID: 271050 RVA: 0x0100C68A File Offset: 0x0100A88A
		public int GetAreaCount()
		{
			return DangoBrawlConfig.Instance.GetBenchAreaSizeByActivityId(this.ActivityId);
		}

		// Token: 0x060422CB RID: 271051 RVA: 0x0100C69C File Offset: 0x0100A89C
		public bool HasCapacityFor(int n)
		{
			return this.ItemDataMap.Count + n <= 999;
		}

		// Token: 0x040228B9 RID: 141497
		private int ActivityId;

		// Token: 0x040228BA RID: 141498
		private readonly Dictionary<int, DangoBrawlBenchItemData> ItemDataMap = new Dictionary<int, DangoBrawlBenchItemData>();

		// Token: 0x040228BB RID: 141499
		private const int MAX_CAPACITY = 999;
	}
}
