using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.GamePlay.FindSunSpirit;
using CSharpScript.Game.LevelGamePlay.FindSunSprite.Performance.Level;
using CSharpScript.Game.LevelGamePlay.FindSunSprite.Performance.SunSpiritMove;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.FindSunSprite.Performance
{
	// Token: 0x02005FD5 RID: 24533
	[NullableContext(1)]
	[Nullable(0)]
	public class FindSunSpiritPerformManager
	{
		// Token: 0x0603AEF7 RID: 241399 RVA: 0x010A78D0 File Offset: 0x010A5AD0
		public UniTask RefreshPerformAsync(bool isLevelConfigChange, bool withLoading)
		{
			FindSunSpiritPerformManager.<RefreshPerformAsync>d__19 <RefreshPerformAsync>d__;
			<RefreshPerformAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshPerformAsync>d__.<>4__this = this;
			<RefreshPerformAsync>d__.isLevelConfigChange = isLevelConfigChange;
			<RefreshPerformAsync>d__.withLoading = withLoading;
			<RefreshPerformAsync>d__.<>1__state = -1;
			<RefreshPerformAsync>d__.<>t__builder.Start<FindSunSpiritPerformManager.<RefreshPerformAsync>d__19>(ref <RefreshPerformAsync>d__);
			return <RefreshPerformAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603AEF8 RID: 241400 RVA: 0x010A7924 File Offset: 0x010A5B24
		private UniTask RefreshLoading(bool isOpen)
		{
			FindSunSpiritPerformManager.<RefreshLoading>d__20 <RefreshLoading>d__;
			<RefreshLoading>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshLoading>d__.isOpen = isOpen;
			<RefreshLoading>d__.<>1__state = -1;
			<RefreshLoading>d__.<>t__builder.Start<FindSunSpiritPerformManager.<RefreshLoading>d__20>(ref <RefreshLoading>d__);
			return <RefreshLoading>d__.<>t__builder.Task;
		}

		// Token: 0x0603AEF9 RID: 241401 RVA: 0x010A7968 File Offset: 0x010A5B68
		private void StopSunSpiritEndMontage()
		{
			SunSpiritActionManager actionManager = this.ActionManager;
			if (actionManager == null)
			{
				this.FinishStartGridIndexSet.Clear();
				return;
			}
			foreach (int key in this.FinishStartGridIndexSet)
			{
				EntityHandle entityHandle;
				if (this.StartGridIndexToSunSpiritMap.TryGetValue(key, out entityHandle) && entityHandle != null && entityHandle.IsInit)
				{
					actionManager.ExecuteSunSpiritStopEndMontage(entityHandle);
				}
			}
			this.FinishStartGridIndexSet.Clear();
		}

		// Token: 0x0603AEFA RID: 241402 RVA: 0x010A7A00 File Offset: 0x010A5C00
		private void InitConfig()
		{
			if (this.IsGlobalInit)
			{
				return;
			}
			BP_FindSunSpiritGlobalConfig_C globalConfig = FindSunSpiritModel.Instance.GlobalConfig;
			if (globalConfig != null && globalConfig.IsValid())
			{
				this.IsGlobalInit = true;
				this.GuideLineDuration = globalConfig.导航线持续时间;
				this.SuccessGuideLinePath = globalConfig.成功导航线特效.ToAssetPathName();
				this.FailGuideLinePath = globalConfig.失败导航线特效.ToAssetPathName();
				this.LevelFloorGridSize = globalConfig.关卡地板单位大小;
				this.TriggerDuration = globalConfig.扩散触发持续时间;
				this.LevelFloorPath = globalConfig.关卡地板Niagara.ToAssetPathName();
				FSoftObjectPath 扩散装置路径 = globalConfig.扩散装置路径;
				FindSunSpiritShootEffect shootEffect = this.ShootEffect;
				if (shootEffect != null)
				{
					shootEffect.InitConfig(globalConfig.射击轨迹特效.ToAssetPathName(), globalConfig.射击终点特效.ToAssetPathName());
				}
				if (ObjectUtils.SoftObjectPathIsValid(扩散装置路径))
				{
					this.ModifyPrefabPath = 扩散装置路径.AssetPathName.ToString();
				}
			}
		}

		// Token: 0x0603AEFB RID: 241403 RVA: 0x010A7AE0 File Offset: 0x010A5CE0
		private UniTask RefreshLevelFloor()
		{
			FindSunSpiritPerformManager.<RefreshLevelFloor>d__23 <RefreshLevelFloor>d__;
			<RefreshLevelFloor>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshLevelFloor>d__.<>4__this = this;
			<RefreshLevelFloor>d__.<>1__state = -1;
			<RefreshLevelFloor>d__.<>t__builder.Start<FindSunSpiritPerformManager.<RefreshLevelFloor>d__23>(ref <RefreshLevelFloor>d__);
			return <RefreshLevelFloor>d__.<>t__builder.Task;
		}

		// Token: 0x0603AEFC RID: 241404 RVA: 0x010A7B24 File Offset: 0x010A5D24
		private UniTask WaitSunSpiritEntity()
		{
			FindSunSpiritPerformManager.<WaitSunSpiritEntity>d__24 <WaitSunSpiritEntity>d__;
			<WaitSunSpiritEntity>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitSunSpiritEntity>d__.<>4__this = this;
			<WaitSunSpiritEntity>d__.<>1__state = -1;
			<WaitSunSpiritEntity>d__.<>t__builder.Start<FindSunSpiritPerformManager.<WaitSunSpiritEntity>d__24>(ref <WaitSunSpiritEntity>d__);
			return <WaitSunSpiritEntity>d__.<>t__builder.Task;
		}

		// Token: 0x0603AEFD RID: 241405 RVA: 0x010A7B68 File Offset: 0x010A5D68
		private UniTask RefreshSunSpirit()
		{
			FindSunSpiritPerformManager.<RefreshSunSpirit>d__25 <RefreshSunSpirit>d__;
			<RefreshSunSpirit>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshSunSpirit>d__.<>4__this = this;
			<RefreshSunSpirit>d__.<>1__state = -1;
			<RefreshSunSpirit>d__.<>t__builder.Start<FindSunSpiritPerformManager.<RefreshSunSpirit>d__25>(ref <RefreshSunSpirit>d__);
			return <RefreshSunSpirit>d__.<>t__builder.Task;
		}

		// Token: 0x0603AEFE RID: 241406 RVA: 0x010A7BAC File Offset: 0x010A5DAC
		private UniTask RefreshModifierPerformAsync(bool isLevelConfigChange)
		{
			FindSunSpiritPerformManager.<RefreshModifierPerformAsync>d__26 <RefreshModifierPerformAsync>d__;
			<RefreshModifierPerformAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshModifierPerformAsync>d__.<>4__this = this;
			<RefreshModifierPerformAsync>d__.isLevelConfigChange = isLevelConfigChange;
			<RefreshModifierPerformAsync>d__.<>1__state = -1;
			<RefreshModifierPerformAsync>d__.<>t__builder.Start<FindSunSpiritPerformManager.<RefreshModifierPerformAsync>d__26>(ref <RefreshModifierPerformAsync>d__);
			return <RefreshModifierPerformAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603AEFF RID: 241407 RVA: 0x010A7BF8 File Offset: 0x010A5DF8
		private void RefreshGuideLine()
		{
			FindSunSpiritModel instance = FindSunSpiritModel.Instance;
			FindSunSpiritLevelConfig levelConfig = instance.LevelConfig;
			Quat levelQuat = instance.LevelQuat;
			Vector vector = Vector.Create();
			Transform transform = Transform.Create();
			foreach (int num in levelConfig.SunSpiritStartGridIndices)
			{
				FindSunSpiritGuideLine findSunSpiritGuideLine;
				if (!this.StartGridIndexToGuideLineMap.TryGetValue(num, out findSunSpiritGuideLine))
				{
					findSunSpiritGuideLine = new FindSunSpiritGuideLine();
					this.StartGridIndexToGuideLineMap[num] = findSunSpiritGuideLine;
					this.GetGridLocation(num, 0f, 0f, vector);
					transform.SetLocation(vector);
					transform.SetRotation(levelQuat);
					transform.SetScale3D(Vector.OneVectorProxy);
					findSunSpiritGuideLine.Init(transform);
				}
			}
		}

		// Token: 0x0603AF00 RID: 241408 RVA: 0x010A7CC0 File Offset: 0x010A5EC0
		public void SelectModifier(int releaseGridIndex, int selectGridIndex)
		{
			FindSunSpiritLevelModifier findSunSpiritLevelModifier;
			if (this.GridIndexToModifierMap.TryGetValue(releaseGridIndex, out findSunSpiritLevelModifier))
			{
				findSunSpiritLevelModifier.UpdateSelect(false);
			}
			FindSunSpiritLevelModifier findSunSpiritLevelModifier2;
			if (this.GridIndexToModifierMap.TryGetValue(selectGridIndex, out findSunSpiritLevelModifier2))
			{
				findSunSpiritLevelModifier2.UpdateSelect(true);
			}
			FindSunSpiritLevelFloor levelFloor = this.LevelFloor;
			if (levelFloor == null)
			{
				return;
			}
			levelFloor.RefreshOutline();
		}

		// Token: 0x0603AF01 RID: 241409 RVA: 0x010A7D0C File Offset: 0x010A5F0C
		public void TriggerModifier(int gridIndex)
		{
			FindSunSpiritLevelModifier findSunSpiritLevelModifier;
			if (this.GridIndexToModifierMap.TryGetValue(gridIndex, out findSunSpiritLevelModifier))
			{
				findSunSpiritLevelModifier.Trigger(this.TriggerDuration);
			}
			Vector vector;
			if (this.TempVectorList.Count > 0)
			{
				vector = this.TempVectorList[0];
			}
			else
			{
				vector = Vector.Create();
				this.TempVectorList.Add(vector);
			}
			this.GetModifierLocation(gridIndex, vector);
			FindSunSpiritShootEffect shootEffect = this.ShootEffect;
			if (shootEffect != null)
			{
				shootEffect.SpawnEffect(vector);
			}
			FindSunSpiritLevelFloor levelFloor = this.LevelFloor;
			if (levelFloor == null)
			{
				return;
			}
			levelFloor.RefreshFloor();
		}

		// Token: 0x0603AF02 RID: 241410 RVA: 0x010A7D90 File Offset: 0x010A5F90
		public void ShowGuideLine(List<int> path, bool isReachEnd)
		{
			int key = path[0];
			FindSunSpiritGuideLine findSunSpiritGuideLine;
			if (!this.StartGridIndexToGuideLineMap.TryGetValue(key, out findSunSpiritGuideLine))
			{
				return;
			}
			int levelWidth = FindSunSpiritModel.Instance.LevelConfig.LevelWidth;
			int count = this.TempVectorList.Count;
			List<Vector> list = new List<Vector>();
			int num = path.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				int num2 = path[i];
				int num3 = (i == num) ? num2 : path[i + 1];
				Vector vector;
				if (i < count)
				{
					vector = this.TempVectorList[i];
				}
				else
				{
					vector = Vector.Create();
					this.TempVectorList.Add(vector);
				}
				float horizontalOffsetScale = 0f;
				float verticalOffsetScale = 0f;
				int num4 = num3 - num2;
				if (num4 > levelWidth)
				{
					verticalOffsetScale = 0.25f;
				}
				else if (num4 < 0 && Math.Abs(num4) > levelWidth - 1)
				{
					horizontalOffsetScale = 0.5f;
				}
				this.GetGridLocation(num2, horizontalOffsetScale, verticalOffsetScale, vector);
				list.Add(vector);
			}
			findSunSpiritGuideLine.SpawnGuideLine(isReachEnd ? this.SuccessGuideLinePath : this.FailGuideLinePath, list.ToArray(), this.GuideLineDuration);
		}

		// Token: 0x0603AF03 RID: 241411 RVA: 0x010A7EBC File Offset: 0x010A60BC
		public UniTask PlaySunSpiritPerformAsync([Nullable(new byte[]
		{
			2,
			1
		})] List<List<int>> successPaths)
		{
			FindSunSpiritPerformManager.<PlaySunSpiritPerformAsync>d__31 <PlaySunSpiritPerformAsync>d__;
			<PlaySunSpiritPerformAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlaySunSpiritPerformAsync>d__.<>4__this = this;
			<PlaySunSpiritPerformAsync>d__.successPaths = successPaths;
			<PlaySunSpiritPerformAsync>d__.<>1__state = -1;
			<PlaySunSpiritPerformAsync>d__.<>t__builder.Start<FindSunSpiritPerformManager.<PlaySunSpiritPerformAsync>d__31>(ref <PlaySunSpiritPerformAsync>d__);
			return <PlaySunSpiritPerformAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603AF04 RID: 241412 RVA: 0x010A7F08 File Offset: 0x010A6108
		public void ClearPerform(bool revertSunSpirit)
		{
			if (revertSunSpirit)
			{
				this.StopSunSpiritEndMontage();
			}
			FindSunSpiritLevelFloor levelFloor = this.LevelFloor;
			if (levelFloor != null)
			{
				levelFloor.ClearFloor();
			}
			this.LevelFloor = null;
			SunSpiritActionManager actionManager = this.ActionManager;
			if (actionManager != null)
			{
				actionManager.Clear();
			}
			this.ActionManager = null;
			if (!revertSunSpirit)
			{
				foreach (ISunSpiritOriginInfo sunSpiritOriginInfo in this.SunSpiritOriginInfoList)
				{
					EntityHandle entityHandle = sunSpiritOriginInfo.EntityHandle;
					if (entityHandle.Valid)
					{
						WorldEntity entity = entityHandle.Entity;
						BaseMoveComponent component = entity.GetComponent<BaseMoveComponent>();
						if (component != null)
						{
							component.Enable(new int?(sunSpiritOriginInfo.DisableMoveHandle), "虚影找日灵固定位置");
						}
						UeMovementTickManageComponent component2 = entity.GetComponent<UeMovementTickManageComponent>();
						if (component2 != null)
						{
							component2.Enable(new int?(sunSpiritOriginInfo.DisableMoveTickHandle), "虚影找日灵固定位置");
						}
					}
				}
			}
			foreach (FindSunSpiritGuideLine findSunSpiritGuideLine in this.StartGridIndexToGuideLineMap.Values)
			{
				findSunSpiritGuideLine.Clear();
			}
			foreach (FindSunSpiritLevelModifier findSunSpiritLevelModifier in this.GridIndexToModifierMap.Values)
			{
				findSunSpiritLevelModifier.Clear();
			}
			this.GridIndexToModifierMap.Clear();
			this.StartGridIndexToGuideLineMap.Clear();
			this.StartGridIndexToSunSpiritMap.Clear();
			this.FinishStartGridIndexSet.Clear();
			this.SunSpiritOriginInfoList.Clear();
		}

		// Token: 0x0603AF05 RID: 241413 RVA: 0x010A80AC File Offset: 0x010A62AC
		private void GetSunSpiritLocation(int gridIndex, float halfHeight, Vector outVector)
		{
			int levelFloorGridSize = this.LevelFloorGridSize;
			FindSunSpiritModel instance = FindSunSpiritModel.Instance;
			int levelWidth = instance.LevelConfig.LevelWidth;
			int num = gridIndex % levelWidth;
			int num2 = (int)Math.Floor((double)((float)gridIndex / (float)levelWidth));
			outVector.Set((double)(num * levelFloorGridSize), 0.0, (double)((float)(num2 * levelFloorGridSize - levelFloorGridSize / 2) + halfHeight));
			instance.LevelQuat.RotateVector(outVector, outVector);
			outVector.AdditionEqual(instance.LevelPosition);
		}

		// Token: 0x0603AF06 RID: 241414 RVA: 0x010A8120 File Offset: 0x010A6320
		private void GetModifierLocation(int gridIndex, Vector outVector)
		{
			int levelFloorGridSize = this.LevelFloorGridSize;
			FindSunSpiritModel instance = FindSunSpiritModel.Instance;
			int levelWidth = instance.LevelConfig.LevelWidth;
			int num = gridIndex % levelWidth;
			int num2 = (int)Math.Floor((double)((float)gridIndex / (float)levelWidth));
			outVector.Set((double)(num * levelFloorGridSize), (double)levelFloorGridSize, (double)(num2 * levelFloorGridSize));
			instance.LevelQuat.RotateVector(outVector, outVector);
			outVector.AdditionEqual(instance.LevelPosition);
		}

		// Token: 0x0603AF07 RID: 241415 RVA: 0x010A8184 File Offset: 0x010A6384
		private void GetGridLocation(int gridIndex, float horizontalOffsetScale, float verticalOffsetScale, Vector outVector)
		{
			int levelFloorGridSize = this.LevelFloorGridSize;
			FindSunSpiritModel instance = FindSunSpiritModel.Instance;
			int levelWidth = instance.LevelConfig.LevelWidth;
			float num = (float)(gridIndex % levelWidth) + horizontalOffsetScale;
			float num2 = (float)((int)Math.Floor((double)((float)gridIndex / (float)levelWidth))) + verticalOffsetScale;
			outVector.Set((double)(num * (float)levelFloorGridSize), 0.0, (double)(num2 * (float)levelFloorGridSize));
			instance.LevelQuat.RotateVector(outVector, outVector);
			outVector.AdditionEqual(instance.LevelPosition);
		}

		// Token: 0x0401EFC0 RID: 126912
		private const float NIAGARA_SCALE_SIZE = 0.185f;

		// Token: 0x0401EFC1 RID: 126913
		private bool IsGlobalInit;

		// Token: 0x0401EFC2 RID: 126914
		private string LevelFloorPath = "";

		// Token: 0x0401EFC3 RID: 126915
		private string ModifyPrefabPath = "";

		// Token: 0x0401EFC4 RID: 126916
		private string SuccessGuideLinePath = "";

		// Token: 0x0401EFC5 RID: 126917
		private string FailGuideLinePath = "";

		// Token: 0x0401EFC6 RID: 126918
		private int GuideLineDuration;

		// Token: 0x0401EFC7 RID: 126919
		private int LevelFloorGridSize;

		// Token: 0x0401EFC8 RID: 126920
		private int TriggerDuration;

		// Token: 0x0401EFC9 RID: 126921
		[Nullable(2)]
		private FindSunSpiritLevelFloor LevelFloor;

		// Token: 0x0401EFCA RID: 126922
		private Dictionary<int, FindSunSpiritLevelModifier> GridIndexToModifierMap = new Dictionary<int, FindSunSpiritLevelModifier>();

		// Token: 0x0401EFCB RID: 126923
		private readonly Dictionary<int, FindSunSpiritGuideLine> StartGridIndexToGuideLineMap = new Dictionary<int, FindSunSpiritGuideLine>();

		// Token: 0x0401EFCC RID: 126924
		[Nullable(2)]
		private FindSunSpiritShootEffect ShootEffect;

		// Token: 0x0401EFCD RID: 126925
		public List<EntityHandle> SunSpiritEntityHandleList = new List<EntityHandle>();

		// Token: 0x0401EFCE RID: 126926
		[Nullable(2)]
		private SunSpiritActionManager ActionManager;

		// Token: 0x0401EFCF RID: 126927
		private readonly List<ISunSpiritOriginInfo> SunSpiritOriginInfoList = new List<ISunSpiritOriginInfo>();

		// Token: 0x0401EFD0 RID: 126928
		private readonly Dictionary<int, EntityHandle> StartGridIndexToSunSpiritMap = new Dictionary<int, EntityHandle>();

		// Token: 0x0401EFD1 RID: 126929
		private readonly HashSet<int> FinishStartGridIndexSet = new HashSet<int>();

		// Token: 0x0401EFD2 RID: 126930
		private readonly List<Vector> TempVectorList = new List<Vector>();
	}
}
