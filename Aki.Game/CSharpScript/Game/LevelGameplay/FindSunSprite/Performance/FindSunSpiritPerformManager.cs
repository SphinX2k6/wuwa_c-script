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
	// Token: 0x02006E54 RID: 28244
	[NullableContext(1)]
	[Nullable(0)]
	public class FindSunSpiritPerformManager
	{
		// Token: 0x06044D6A RID: 281962 RVA: 0x010FD370 File Offset: 0x010FB570
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

		// Token: 0x06044D6B RID: 281963 RVA: 0x010FD3C4 File Offset: 0x010FB5C4
		private UniTask RefreshLoading(bool isOpen)
		{
			FindSunSpiritPerformManager.<RefreshLoading>d__20 <RefreshLoading>d__;
			<RefreshLoading>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshLoading>d__.isOpen = isOpen;
			<RefreshLoading>d__.<>1__state = -1;
			<RefreshLoading>d__.<>t__builder.Start<FindSunSpiritPerformManager.<RefreshLoading>d__20>(ref <RefreshLoading>d__);
			return <RefreshLoading>d__.<>t__builder.Task;
		}

		// Token: 0x06044D6C RID: 281964 RVA: 0x010FD408 File Offset: 0x010FB608
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

		// Token: 0x06044D6D RID: 281965 RVA: 0x010FD4A0 File Offset: 0x010FB6A0
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

		// Token: 0x06044D6E RID: 281966 RVA: 0x010FD580 File Offset: 0x010FB780
		private UniTask RefreshLevelFloor()
		{
			FindSunSpiritPerformManager.<RefreshLevelFloor>d__23 <RefreshLevelFloor>d__;
			<RefreshLevelFloor>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshLevelFloor>d__.<>4__this = this;
			<RefreshLevelFloor>d__.<>1__state = -1;
			<RefreshLevelFloor>d__.<>t__builder.Start<FindSunSpiritPerformManager.<RefreshLevelFloor>d__23>(ref <RefreshLevelFloor>d__);
			return <RefreshLevelFloor>d__.<>t__builder.Task;
		}

		// Token: 0x06044D6F RID: 281967 RVA: 0x010FD5C4 File Offset: 0x010FB7C4
		private UniTask WaitSunSpiritEntity()
		{
			FindSunSpiritPerformManager.<WaitSunSpiritEntity>d__24 <WaitSunSpiritEntity>d__;
			<WaitSunSpiritEntity>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitSunSpiritEntity>d__.<>4__this = this;
			<WaitSunSpiritEntity>d__.<>1__state = -1;
			<WaitSunSpiritEntity>d__.<>t__builder.Start<FindSunSpiritPerformManager.<WaitSunSpiritEntity>d__24>(ref <WaitSunSpiritEntity>d__);
			return <WaitSunSpiritEntity>d__.<>t__builder.Task;
		}

		// Token: 0x06044D70 RID: 281968 RVA: 0x010FD608 File Offset: 0x010FB808
		private UniTask RefreshSunSpirit()
		{
			FindSunSpiritPerformManager.<RefreshSunSpirit>d__25 <RefreshSunSpirit>d__;
			<RefreshSunSpirit>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshSunSpirit>d__.<>4__this = this;
			<RefreshSunSpirit>d__.<>1__state = -1;
			<RefreshSunSpirit>d__.<>t__builder.Start<FindSunSpiritPerformManager.<RefreshSunSpirit>d__25>(ref <RefreshSunSpirit>d__);
			return <RefreshSunSpirit>d__.<>t__builder.Task;
		}

		// Token: 0x06044D71 RID: 281969 RVA: 0x010FD64C File Offset: 0x010FB84C
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

		// Token: 0x06044D72 RID: 281970 RVA: 0x010FD698 File Offset: 0x010FB898
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

		// Token: 0x06044D73 RID: 281971 RVA: 0x010FD760 File Offset: 0x010FB960
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

		// Token: 0x06044D74 RID: 281972 RVA: 0x010FD7AC File Offset: 0x010FB9AC
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

		// Token: 0x06044D75 RID: 281973 RVA: 0x010FD830 File Offset: 0x010FBA30
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

		// Token: 0x06044D76 RID: 281974 RVA: 0x010FD95C File Offset: 0x010FBB5C
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

		// Token: 0x06044D77 RID: 281975 RVA: 0x010FD9A8 File Offset: 0x010FBBA8
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

		// Token: 0x06044D78 RID: 281976 RVA: 0x010FDB4C File Offset: 0x010FBD4C
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

		// Token: 0x06044D79 RID: 281977 RVA: 0x010FDBC0 File Offset: 0x010FBDC0
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

		// Token: 0x06044D7A RID: 281978 RVA: 0x010FDC24 File Offset: 0x010FBE24
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

		// Token: 0x04023D0B RID: 146699
		private const float NIAGARA_SCALE_SIZE = 0.185f;

		// Token: 0x04023D0C RID: 146700
		private bool IsGlobalInit;

		// Token: 0x04023D0D RID: 146701
		private string LevelFloorPath = "";

		// Token: 0x04023D0E RID: 146702
		private string ModifyPrefabPath = "";

		// Token: 0x04023D0F RID: 146703
		private string SuccessGuideLinePath = "";

		// Token: 0x04023D10 RID: 146704
		private string FailGuideLinePath = "";

		// Token: 0x04023D11 RID: 146705
		private int GuideLineDuration;

		// Token: 0x04023D12 RID: 146706
		private int LevelFloorGridSize;

		// Token: 0x04023D13 RID: 146707
		private int TriggerDuration;

		// Token: 0x04023D14 RID: 146708
		[Nullable(2)]
		private FindSunSpiritLevelFloor LevelFloor;

		// Token: 0x04023D15 RID: 146709
		private Dictionary<int, FindSunSpiritLevelModifier> GridIndexToModifierMap = new Dictionary<int, FindSunSpiritLevelModifier>();

		// Token: 0x04023D16 RID: 146710
		private readonly Dictionary<int, FindSunSpiritGuideLine> StartGridIndexToGuideLineMap = new Dictionary<int, FindSunSpiritGuideLine>();

		// Token: 0x04023D17 RID: 146711
		[Nullable(2)]
		private FindSunSpiritShootEffect ShootEffect;

		// Token: 0x04023D18 RID: 146712
		public List<EntityHandle> SunSpiritEntityHandleList = new List<EntityHandle>();

		// Token: 0x04023D19 RID: 146713
		[Nullable(2)]
		private SunSpiritActionManager ActionManager;

		// Token: 0x04023D1A RID: 146714
		private readonly List<ISunSpiritOriginInfo> SunSpiritOriginInfoList = new List<ISunSpiritOriginInfo>();

		// Token: 0x04023D1B RID: 146715
		private readonly Dictionary<int, EntityHandle> StartGridIndexToSunSpiritMap = new Dictionary<int, EntityHandle>();

		// Token: 0x04023D1C RID: 146716
		private readonly HashSet<int> FinishStartGridIndexSet = new HashSet<int>();

		// Token: 0x04023D1D RID: 146717
		private readonly List<Vector> TempVectorList = new List<Vector>();
	}
}
