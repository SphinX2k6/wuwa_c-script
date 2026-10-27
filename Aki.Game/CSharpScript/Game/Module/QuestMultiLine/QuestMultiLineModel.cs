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
	// Token: 0x02004FA8 RID: 20392
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class QuestMultiLineModel : ModelBase
	{
		// Token: 0x0603432E RID: 213806 RVA: 0x00C40B9C File Offset: 0x00C3ED9C
		public bool IsBranchTimePoint()
		{
			return this.CurSelectLineId != 0;
		}

		// Token: 0x0603432F RID: 213807 RVA: 0x00C40BA8 File Offset: 0x00C3EDA8
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

		// Token: 0x06034330 RID: 213808 RVA: 0x00C40D0C File Offset: 0x00C3EF0C
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

		// Token: 0x06034331 RID: 213809 RVA: 0x00C40E50 File Offset: 0x00C3F050
		private void RefreshTimePoints()
		{
			foreach (QuestMultiLineTimePointData questMultiLineTimePointData in this.TimePointDataArray)
			{
				questMultiLineTimePointData.IsUnLock = this.UnlockTimePointMap.GetValueOrDefault(questMultiLineTimePointData.Id, false);
				questMultiLineTimePointData.RefreshUnComponentGroups(this.UnlockComponentsGroupMap);
			}
		}

		// Token: 0x06034332 RID: 213810 RVA: 0x00C40EC0 File Offset: 0x00C3F0C0
		public List<QuestMultiLineTimePointData> GetQuestTimePoints()
		{
			return this.TimePointDataArray;
		}

		// Token: 0x06034333 RID: 213811 RVA: 0x00C40EC8 File Offset: 0x00C3F0C8
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

		// Token: 0x06034334 RID: 213812 RVA: 0x00C40F08 File Offset: 0x00C3F108
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

		// Token: 0x06034335 RID: 213813 RVA: 0x00C40F5C File Offset: 0x00C3F15C
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

		// Token: 0x06034336 RID: 213814 RVA: 0x00C40FB8 File Offset: 0x00C3F1B8
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

		// Token: 0x06034337 RID: 213815 RVA: 0x00C4104C File Offset: 0x00C3F24C
		protected override bool OnInit()
		{
			this.InitData();
			return true;
		}

		// Token: 0x06034338 RID: 213816 RVA: 0x00C41058 File Offset: 0x00C3F258
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

		// Token: 0x06034339 RID: 213817 RVA: 0x00C4109C File Offset: 0x00C3F29C
		public void ClearTimePointRedDot(int configId)
		{
			((ServerStorageMap)ServerStorageModel.Instance.Get(EClientStorageSystemIdType.QuestBranchSystem)).Set(configId, 0);
		}

		// Token: 0x0603433A RID: 213818 RVA: 0x00C410B8 File Offset: 0x00C3F2B8
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

		// Token: 0x0603433B RID: 213819 RVA: 0x00C41102 File Offset: 0x00C3F302
		public void ClearComponentRedDot(int componentId)
		{
			((ServerStorageMap)ServerStorageModel.Instance.Get(EClientStorageSystemIdType.QuestBranchSystem)).Set(componentId, 0);
		}

		// Token: 0x17007F77 RID: 32631
		// (get) Token: 0x0603433C RID: 213820 RVA: 0x00C4111C File Offset: 0x00C3F31C
		public static QuestMultiLineModel Instance
		{
			get
			{
				return QuestMultiLineModel._Instance;
			}
		}

		// Token: 0x0603433D RID: 213821 RVA: 0x00C41123 File Offset: 0x00C3F323
		public static QuestMultiLineModel GetOrCreateInstance()
		{
			if (QuestMultiLineModel._Instance == null)
			{
				QuestMultiLineModel.CreateInstance();
			}
			return QuestMultiLineModel._Instance;
		}

		// Token: 0x0603433E RID: 213822 RVA: 0x00C41137 File Offset: 0x00C3F337
		public static bool CreateInstance()
		{
			if (QuestMultiLineModel._Instance != null)
			{
				return true;
			}
			QuestMultiLineModel._Instance = new QuestMultiLineModel();
			return true;
		}

		// Token: 0x0603433F RID: 213823 RVA: 0x00C4114D File Offset: 0x00C3F34D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06034340 RID: 213824 RVA: 0x00C4114F File Offset: 0x00C3F34F
		public static void ResetStaticDefaultValue()
		{
			QuestMultiLineModel._Instance = null;
		}

		// Token: 0x06034341 RID: 213825 RVA: 0x00C41157 File Offset: 0x00C3F357
		static QuestMultiLineModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(QuestMultiLineModel.CreateStaticDefaultValue), new Action(QuestMultiLineModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401BC21 RID: 113697
		private List<QuestMultiLineTimePointData> TimePointDataArray = new List<QuestMultiLineTimePointData>();

		// Token: 0x0401BC22 RID: 113698
		private readonly Dictionary<int, OneQuestBranchPageInfo> BranchInfoMap = new Dictionary<int, OneQuestBranchPageInfo>();

		// Token: 0x0401BC23 RID: 113699
		private readonly Dictionary<int, bool> UnlockTimePointMap = new Dictionary<int, bool>();

		// Token: 0x0401BC24 RID: 113700
		private readonly Dictionary<int, bool> UnlockComponentsGroupMap = new Dictionary<int, bool>();

		// Token: 0x0401BC25 RID: 113701
		private readonly int CurSelectLineId;

		// Token: 0x0401BC26 RID: 113702
		[Nullable(2)]
		private static QuestMultiLineModel _Instance;
	}
}
