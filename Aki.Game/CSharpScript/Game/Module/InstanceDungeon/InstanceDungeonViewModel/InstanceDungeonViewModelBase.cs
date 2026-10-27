using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.InstanceDungeon.Define;
using CSharpScript.Game.Module.InstanceDungeon.ExchangeReward;
using CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonComponentModel;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonViewModel
{
	// Token: 0x0200588E RID: 22670
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class InstanceDungeonViewModelBase
	{
		// Token: 0x17008A8B RID: 35467
		// (get) Token: 0x06039B04 RID: 236292 RVA: 0x00DB5DB7 File Offset: 0x00DB3FB7
		// (set) Token: 0x06039B05 RID: 236293 RVA: 0x00DB5DBF File Offset: 0x00DB3FBF
		[Nullable(2)]
		public virtual RankTimeItemModelBase RankItemModel { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x06039B06 RID: 236294 RVA: 0x00DB5DC8 File Offset: 0x00DB3FC8
		public InstanceDungeonViewModelBase()
		{
			this.EntranceId = InstanceDungeonEntranceModel.Instance.EntranceId;
			this.InitInstanceData();
			this.InitGetterData();
		}

		// Token: 0x06039B07 RID: 236295 RVA: 0x00DB5E04 File Offset: 0x00DB4004
		private void InitInstanceData()
		{
			this.InstanceByTitleMap = this.GetInstanceByTitleMap();
			foreach (KeyValuePair<int, List<int>> keyValuePair in this.InstanceByTitleMap)
			{
				int num;
				List<int> list;
				keyValuePair.Deconstruct(out num, out list);
				List<int> list2 = list;
				int[] instanceIdList = this.InstanceIdList;
				list = list2;
				num = 0;
				int[] array = new int[instanceIdList.Length + list.Count];
				ReadOnlySpan<int> readOnlySpan = new ReadOnlySpan<int>(instanceIdList);
				readOnlySpan.CopyTo(new Span<int>(array).Slice(num, readOnlySpan.Length));
				num += readOnlySpan.Length;
				Span<int> span = CollectionsMarshal.AsSpan<int>(list);
				span.CopyTo(new Span<int>(array).Slice(num, span.Length));
				num += span.Length;
				this.InstanceIdList = array;
			}
		}

		// Token: 0x06039B08 RID: 236296 RVA: 0x00DB5EFC File Offset: 0x00DB40FC
		private void InitGetterData()
		{
			EInstanceEntranceFlowType flowId = (EInstanceEntranceFlowType)InstanceDungeonEntranceConfig.Instance.GetConfig(this.EntranceId).Value.FlowId;
			InstanceDungeonMapDefine.InstanceDungeonEntranceViewGetterDataMap.TryGetValue(flowId, out this.GetterData);
		}

		// Token: 0x06039B09 RID: 236297 RVA: 0x00DB5F3C File Offset: 0x00DB413C
		public void RegisterView(InstanceDungeonEntranceView view)
		{
			this.View = view;
		}

		// Token: 0x06039B0A RID: 236298 RVA: 0x00DB5F45 File Offset: 0x00DB4145
		public virtual UniTask OnBeforeStartAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06039B0B RID: 236299 RVA: 0x00DB5F4C File Offset: 0x00DB414C
		public virtual void OnBeforeHide()
		{
		}

		// Token: 0x06039B0C RID: 236300 RVA: 0x00DB5F4E File Offset: 0x00DB414E
		public virtual void OnBeforeDestroy()
		{
		}

		// Token: 0x06039B0D RID: 236301 RVA: 0x00DB5F50 File Offset: 0x00DB4150
		public UniTask RequestServerData()
		{
			InstanceDungeonViewModelBase.<RequestServerData>d__16 <RequestServerData>d__;
			<RequestServerData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestServerData>d__.<>4__this = this;
			<RequestServerData>d__.<>1__state = -1;
			<RequestServerData>d__.<>t__builder.Start<InstanceDungeonViewModelBase.<RequestServerData>d__16>(ref <RequestServerData>d__);
			return <RequestServerData>d__.<>t__builder.Task;
		}

		// Token: 0x06039B0E RID: 236302 RVA: 0x00DB5F93 File Offset: 0x00DB4193
		public void SortInstanceArray(List<int> instanceArray)
		{
			this.OnSortInstanceArray(instanceArray);
		}

		// Token: 0x06039B0F RID: 236303 RVA: 0x00DB5F9C File Offset: 0x00DB419C
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public virtual ValueTuple<InstanceDetectionDynamicData[], int> GetDiyInstanceDetectionDynamicData(int currentSeriesId, int currentInstanceId)
		{
			return new ValueTuple<InstanceDetectionDynamicData[], int>(Array.Empty<InstanceDetectionDynamicData>(), 0);
		}

		// Token: 0x06039B10 RID: 236304 RVA: 0x00DB5FA9 File Offset: 0x00DB41A9
		public string GetInstanceItemTextureBg(int instanceId)
		{
			return this.OnGetInstanceItemTextureBg(instanceId);
		}

		// Token: 0x06039B11 RID: 236305 RVA: 0x00DB5FB2 File Offset: 0x00DB41B2
		public bool CheckInstanceUnlock(int instanceId)
		{
			return this.OnCheckInstanceUnlock(instanceId);
		}

		// Token: 0x06039B12 RID: 236306 RVA: 0x00DB5FBB File Offset: 0x00DB41BB
		[NullableContext(2)]
		public TableTextArgNew GetUnlockConditionTextId(int instanceId)
		{
			return this.OnGetUnlockConditionTextId(instanceId);
		}

		// Token: 0x06039B13 RID: 236307 RVA: 0x00DB5FC4 File Offset: 0x00DB41C4
		public bool IsFinishInstance(int instanceId)
		{
			return this.OnIsFinishInstance(instanceId);
		}

		// Token: 0x06039B14 RID: 236308 RVA: 0x00DB5FCD File Offset: 0x00DB41CD
		public string GetInstanceDetectItemIcon(int instanceId)
		{
			return this.OnGetInstanceDetectItemIcon(instanceId);
		}

		// Token: 0x06039B15 RID: 236309 RVA: 0x00DB5FD6 File Offset: 0x00DB41D6
		[NullableContext(2)]
		public InstanceDungeonEntranceViewSelectData GetDefaultSelectData()
		{
			return this.OnGetDefaultSelectData();
		}

		// Token: 0x06039B16 RID: 236310 RVA: 0x00DB5FDE File Offset: 0x00DB41DE
		public bool CheckNeedOnTimer(int instanceId)
		{
			return this.OnCheckNeedOnTimer(instanceId);
		}

		// Token: 0x06039B17 RID: 236311 RVA: 0x00DB5FE7 File Offset: 0x00DB41E7
		public void TimerRefreshFunction(float delta)
		{
			this.OnTimerRefreshFunction(delta);
		}

		// Token: 0x06039B18 RID: 236312 RVA: 0x00DB5FF0 File Offset: 0x00DB41F0
		public bool CheckInstanceItemHasRedDot(int instanceId)
		{
			return this.OnCheckInstanceHasRedDot(instanceId);
		}

		// Token: 0x06039B19 RID: 236313 RVA: 0x00DB5FF9 File Offset: 0x00DB41F9
		protected virtual void OnSortInstanceArray(List<int> instanceArray)
		{
		}

		// Token: 0x06039B1A RID: 236314 RVA: 0x00DB5FFB File Offset: 0x00DB41FB
		protected virtual string OnGetInstanceItemTextureBg(int instanceId)
		{
			return "T_TogListNor";
		}

		// Token: 0x06039B1B RID: 236315 RVA: 0x00DB6004 File Offset: 0x00DB4204
		protected virtual Dictionary<int, List<int>> GetInstanceByTitleMap()
		{
			Dictionary<int, int> sortedByTitleEntranceInstanceIdList = InstanceDungeonEntranceModel.Instance.GetSortedByTitleEntranceInstanceIdList(this.EntranceId);
			Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
			foreach (KeyValuePair<int, int> keyValuePair in sortedByTitleEntranceInstanceIdList)
			{
				int num;
				int num2;
				keyValuePair.Deconstruct(out num, out num2);
				int item = num;
				int key = num2;
				List<int> list;
				if (!dictionary.TryGetValue(key, out list))
				{
					list = new List<int>();
					dictionary[key] = list;
				}
				list.Add(item);
			}
			return dictionary;
		}

		// Token: 0x06039B1C RID: 236316 RVA: 0x00DB6098 File Offset: 0x00DB4298
		protected virtual bool OnCheckInstanceUnlock(int instanceId)
		{
			return InstanceDungeonEntranceModel.Instance.CheckInstanceUnlock(instanceId);
		}

		// Token: 0x06039B1D RID: 236317 RVA: 0x00DB60A8 File Offset: 0x00DB42A8
		[NullableContext(2)]
		protected virtual TableTextArgNew OnGetUnlockConditionTextId(int instanceId)
		{
			string unlockConditionGroupHintText = InstanceDungeonConfig.Instance.GetUnlockConditionGroupHintText(instanceId);
			if (!string.IsNullOrEmpty(unlockConditionGroupHintText))
			{
				return new TableTextArgNew(unlockConditionGroupHintText, Array.Empty<object>());
			}
			return null;
		}

		// Token: 0x06039B1E RID: 236318 RVA: 0x00DB60D6 File Offset: 0x00DB42D6
		protected virtual bool OnIsFinishInstance(int instanceId)
		{
			return ExchangeRewardModel.Instance.IsFinishInstance(instanceId);
		}

		// Token: 0x06039B1F RID: 236319 RVA: 0x00DB60E4 File Offset: 0x00DB42E4
		protected virtual string OnGetInstanceDetectItemIcon(int instanceId)
		{
			return InstanceDungeonConfig.Instance.GetConfig(instanceId).Value.DifficultyIcon;
		}

		// Token: 0x06039B20 RID: 236320 RVA: 0x00DB610C File Offset: 0x00DB430C
		[NullableContext(2)]
		protected virtual InstanceDungeonEntranceViewSelectData OnGetDefaultSelectData()
		{
			InstanceDungeonEntranceViewGetterData getterData = this.GetterData;
			if (((getterData != null) ? getterData.DefaultSelectDataGetter : null) == null)
			{
				return null;
			}
			return this.GetterData.DefaultSelectDataGetter(this.InstanceByTitleMap) as InstanceDungeonEntranceViewSelectData;
		}

		// Token: 0x06039B21 RID: 236321 RVA: 0x00DB613F File Offset: 0x00DB433F
		protected virtual bool OnCheckNeedOnTimer(int instanceId)
		{
			return false;
		}

		// Token: 0x06039B22 RID: 236322 RVA: 0x00DB6142 File Offset: 0x00DB4342
		protected virtual void OnTimerRefreshFunction(float delta)
		{
		}

		// Token: 0x06039B23 RID: 236323 RVA: 0x00DB6144 File Offset: 0x00DB4344
		protected virtual bool OnCheckInstanceHasRedDot(int instanceId)
		{
			return false;
		}

		// Token: 0x06039B24 RID: 236324 RVA: 0x00DB6147 File Offset: 0x00DB4347
		protected virtual UniTask OnRequestServerData()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0401E23E RID: 123454
		protected InstanceDungeonEntranceView View;

		// Token: 0x0401E23F RID: 123455
		public int EntranceId;

		// Token: 0x0401E240 RID: 123456
		public int[] InstanceIdList = Array.Empty<int>();

		// Token: 0x0401E241 RID: 123457
		public Dictionary<int, List<int>> InstanceByTitleMap = new Dictionary<int, List<int>>();

		// Token: 0x0401E242 RID: 123458
		[Nullable(2)]
		private InstanceDungeonEntranceViewGetterData GetterData;
	}
}
