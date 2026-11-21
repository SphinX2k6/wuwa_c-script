using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.QuestMultiLine.QuestMultiLineData;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;

namespace CSharpScript.Game.Module.QuestMultiLine
{
	// Token: 0x02003F71 RID: 16241
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class QuestMultiLineModel : ModelBase
	{
		// Token: 0x0602919C RID: 168348 RVA: 0x00B8A348 File Offset: 0x00B88548
		public bool IsBranchTimePoint()
		{
			return this.CurSelectLineId != 0;
		}

		// Token: 0x0602919D RID: 168349 RVA: 0x00B8A354 File Offset: 0x00B88554
		public void SetData(QuestBranchInfo branchInfo)
		{
			this.BranchInfoMap.Clear();
			this.UnlockTimePointMap.Clear();
			this.UnlockComponentsGroupMap.Clear();
			if (branchInfo.QuestBranchInfos != null)
			{
				foreach (OneQuestBranchPageInfo oneQuestBranchPageInfo in branchInfo.QuestBranchInfos)
				{
					this.BranchInfoMap[oneQuestBranchPageInfo.Id] = oneQuestBranchPageInfo;
				}
			}
			if (branchInfo.UnlockTimePoints != null)
			{
				foreach (int key in branchInfo.UnlockTimePoints)
				{
					this.UnlockTimePointMap[key] = true;
				}
			}
			if (branchInfo.UnlockBranchComponentsGroup != null)
			{
				foreach (int key2 in branchInfo.UnlockBranchComponentsGroup)
				{
					this.UnlockComponentsGroupMap[key2] = true;
				}
			}
			this.RefreshTimePoints();
			foreach (QuestMultiLineTimePointData questMultiLineTimePointData in this.TimePointDataArray)
			{
				questMultiLineTimePointData.RefreshBranchInfo(this.BranchInfoMap);
			}
		}

		// Token: 0x0602919E RID: 168350 RVA: 0x00B8A4B8 File Offset: 0x00B886B8
		public void AddData(QuestBranchInfo branchInfo)
		{
			if (branchInfo.QuestBranchInfos != null)
			{
				foreach (OneQuestBranchPageInfo oneQuestBranchPageInfo in branchInfo.QuestBranchInfos)
				{
					this.BranchInfoMap[oneQuestBranchPageInfo.Id] = oneQuestBranchPageInfo;
				}
			}
			if (branchInfo.UnlockTimePoints != null)
			{
				foreach (int key in branchInfo.UnlockTimePoints)
				{
					this.UnlockTimePointMap[key] = true;
				}
			}
			if (branchInfo.UnlockBranchComponentsGroup != null)
			{
				foreach (int key2 in branchInfo.UnlockBranchComponentsGroup)
				{
					this.UnlockComponentsGroupMap[key2] = true;
				}
			}
			this.RefreshTimePoints();
			foreach (QuestMultiLineTimePointData questMultiLineTimePointData in this.TimePointDataArray)
			{
				questMultiLineTimePointData.RefreshBranchInfo(this.BranchInfoMap);
			}
		}

		// Token: 0x0602919F RID: 168351 RVA: 0x00B8A5FC File Offset: 0x00B887FC
		private void RefreshTimePoints()
		{
			foreach (QuestMultiLineTimePointData questMultiLineTimePointData in this.TimePointDataArray)
			{
				questMultiLineTimePointData.IsUnLock = this.UnlockTimePointMap.GetValueOrDefault(questMultiLineTimePointData.Id, false);
				questMultiLineTimePointData.RefreshUnComponentGroups(this.UnlockComponentsGroupMap);
			}
		}

		// Token: 0x060291A0 RID: 168352 RVA: 0x00B8A66C File Offset: 0x00B8886C
		public List<QuestMultiLineTimePointData> GetQuestTimePoints()
		{
			return this.TimePointDataArray;
		}

		// Token: 0x060291A1 RID: 168353 RVA: 0x00B8A674 File Offset: 0x00B88874
		[NullableContext(2)]
		public QuestMultiLineTimePointData GetLastUnlockTimePoint()
		{
			for (int i = this.TimePointDataArray.Count - 1; i >= 0; i--)
			{
				QuestMultiLineTimePointData questMultiLineTimePointData = this.TimePointDataArray[i];
				if (questMultiLineTimePointData.IsUnLock)
				{
					return questMultiLineTimePointData;
				}
			}
			return null;
		}

		// Token: 0x060291A2 RID: 168354 RVA: 0x00B8A6B4 File Offset: 0x00B888B4
		public void RefreshOneBranchPage(OneQuestBranchPageInfo branchPageInfo)
		{
			this.BranchInfoMap[branchPageInfo.Id] = branchPageInfo;
			QuestMultiLineTimePointData questMultiLineTimePointData = this.FindTimePointByBranchPageId(branchPageInfo.Id);
			if (questMultiLineTimePointData != null)
			{
				questMultiLineTimePointData.RefreshBranchInfo(this.BranchInfoMap);
			}
			EventSystem.Instance.Emit<List<QuestMultiLineTimePointData>>(EEventName.QuestMultiLineTimePointChange, this.TimePointDataArray);
		}

		// Token: 0x060291A3 RID: 168355 RVA: 0x00B8A708 File Offset: 0x00B88908
		[NullableContext(2)]
		private QuestMultiLineTimePointData FindTimePointByBranchPageId(int branchPageId)
		{
			foreach (QuestMultiLineTimePointData questMultiLineTimePointData in this.TimePointDataArray)
			{
				if (questMultiLineTimePointData.BranchPage == branchPageId)
				{
					return questMultiLineTimePointData;
				}
			}
			return null;
		}

		// Token: 0x060291A4 RID: 168356 RVA: 0x00B8A764 File Offset: 0x00B88964
		private void InitData()
		{
			this.TimePointDataArray = new List<QuestMultiLineTimePointData>();
			IReadOnlyList<QuestTimePointConfig> allTimePointConfigs = QuestMultiLineConfig.GetAllTimePointConfigs();
			if (allTimePointConfigs == null)
			{
				return;
			}
			foreach (QuestTimePointConfig config in allTimePointConfigs)
			{
				QuestMultiLineTimePointData item = new QuestMultiLineTimePointData(config);
				this.TimePointDataArray.Add(item);
			}
			this.TimePointDataArray.Sort((QuestMultiLineTimePointData a, QuestMultiLineTimePointData b) => a.Sort - b.Sort);
		}

		// Token: 0x060291A5 RID: 168357 RVA: 0x00B8A7F8 File Offset: 0x00B889F8
		protected override bool OnInit()
		{
			this.InitData();
			return true;
		}

		// Token: 0x060291A6 RID: 168358 RVA: 0x00B8A804 File Offset: 0x00B88A04
		public bool GetTimePointRedDot(int configId)
		{
			ServerStorageMap serverStorageMap = (ServerStorageMap)ServerStorageModel.Instance.Get(EClientStorageSystemIdType.QuestBranchSystem);
			if (!serverStorageMap.Has(configId))
			{
				serverStorageMap.Set(configId, 1);
				return true;
			}
			return serverStorageMap.Get(configId).GetValueOrDefault() == 1;
		}

		// Token: 0x060291A7 RID: 168359 RVA: 0x00B8A848 File Offset: 0x00B88A48
		public void ClearTimePointRedDot(int configId)
		{
			((ServerStorageMap)ServerStorageModel.Instance.Get(EClientStorageSystemIdType.QuestBranchSystem)).Set(configId, 0);
		}

		// Token: 0x060291A8 RID: 168360 RVA: 0x00B8A864 File Offset: 0x00B88A64
		public bool GetComponentRedDot(int componentId, EQuestMultiLineRoleType type)
		{
			if (type != EQuestMultiLineRoleType.MainRole)
			{
				return false;
			}
			ServerStorageMap serverStorageMap = (ServerStorageMap)ServerStorageModel.Instance.Get(EClientStorageSystemIdType.QuestBranchSystem);
			if (!serverStorageMap.Has(componentId))
			{
				serverStorageMap.Set(componentId, 1);
				return true;
			}
			return serverStorageMap.Get(componentId).GetValueOrDefault() == 1;
		}

		// Token: 0x060291A9 RID: 168361 RVA: 0x00B8A8AE File Offset: 0x00B88AAE
		public void ClearComponentRedDot(int componentId)
		{
			((ServerStorageMap)ServerStorageModel.Instance.Get(EClientStorageSystemIdType.QuestBranchSystem)).Set(componentId, 0);
		}

		// Token: 0x17005327 RID: 21287
		// (get) Token: 0x060291AA RID: 168362 RVA: 0x00B8A8C8 File Offset: 0x00B88AC8
		public static QuestMultiLineModel Instance
		{
			get
			{
				return QuestMultiLineModel._Instance;
			}
		}

		// Token: 0x060291AB RID: 168363 RVA: 0x00B8A8CF File Offset: 0x00B88ACF
		public static QuestMultiLineModel GetOrCreateInstance()
		{
			if (QuestMultiLineModel._Instance == null)
			{
				QuestMultiLineModel.CreateInstance();
			}
			return QuestMultiLineModel._Instance;
		}

		// Token: 0x060291AC RID: 168364 RVA: 0x00B8A8E3 File Offset: 0x00B88AE3
		public static bool CreateInstance()
		{
			if (QuestMultiLineModel._Instance != null)
			{
				return true;
			}
			QuestMultiLineModel._Instance = new QuestMultiLineModel();
			return true;
		}

		// Token: 0x060291AD RID: 168365 RVA: 0x00B8A8F9 File Offset: 0x00B88AF9
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060291AE RID: 168366 RVA: 0x00B8A8FB File Offset: 0x00B88AFB
		public static void ResetStaticDefaultValue()
		{
			QuestMultiLineModel._Instance = null;
		}

		// Token: 0x060291AF RID: 168367 RVA: 0x00B8A903 File Offset: 0x00B88B03
		static QuestMultiLineModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(QuestMultiLineModel.CreateStaticDefaultValue), new Action(QuestMultiLineModel.ResetStaticDefaultValue));
		}

		// Token: 0x040165F6 RID: 91638
		private List<QuestMultiLineTimePointData> TimePointDataArray = new List<QuestMultiLineTimePointData>();

		// Token: 0x040165F7 RID: 91639
		private readonly Dictionary<int, OneQuestBranchPageInfo> BranchInfoMap = new Dictionary<int, OneQuestBranchPageInfo>();

		// Token: 0x040165F8 RID: 91640
		private readonly Dictionary<int, bool> UnlockTimePointMap = new Dictionary<int, bool>();

		// Token: 0x040165F9 RID: 91641
		private readonly Dictionary<int, bool> UnlockComponentsGroupMap = new Dictionary<int, bool>();

		// Token: 0x040165FA RID: 91642
		private readonly int CurSelectLineId;

		// Token: 0x040165FB RID: 91643
		[Nullable(2)]
		private static QuestMultiLineModel _Instance;
	}
}
