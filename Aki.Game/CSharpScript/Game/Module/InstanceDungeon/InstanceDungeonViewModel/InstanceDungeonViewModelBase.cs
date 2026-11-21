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
	// Token: 0x02004866 RID: 18534
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class InstanceDungeonViewModelBase
	{
		// Token: 0x17005E57 RID: 24151
		// (get) Token: 0x0602EA27 RID: 191015 RVA: 0x00D04CCF File Offset: 0x00D02ECF
		// (set) Token: 0x0602EA28 RID: 191016 RVA: 0x00D04CD7 File Offset: 0x00D02ED7
		[Nullable(2)]
		public virtual RankTimeItemModelBase RankItemModel { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x0602EA29 RID: 191017 RVA: 0x00D04CE0 File Offset: 0x00D02EE0
		public InstanceDungeonViewModelBase()
		{
			this.EntranceId = InstanceDungeonEntranceModel.Instance.EntranceId;
			this.InitInstanceData();
			this.InitGetterData();
		}

		// Token: 0x0602EA2A RID: 191018 RVA: 0x00D04D1C File Offset: 0x00D02F1C
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

		// Token: 0x0602EA2B RID: 191019 RVA: 0x00D04E14 File Offset: 0x00D03014
		private void InitGetterData()
		{
			EInstanceEntranceFlowType flowId = (EInstanceEntranceFlowType)InstanceDungeonEntranceConfig.Instance.GetConfig(this.EntranceId).Value.FlowId;
			InstanceDungeonMapDefine.InstanceDungeonEntranceViewGetterDataMap.TryGetValue(flowId, out this.GetterData);
		}

		// Token: 0x0602EA2C RID: 191020 RVA: 0x00D04E54 File Offset: 0x00D03054
		public void RegisterView(InstanceDungeonEntranceView view)
		{
			this.View = view;
		}

		// Token: 0x0602EA2D RID: 191021 RVA: 0x00D04E5D File Offset: 0x00D0305D
		public virtual UniTask OnBeforeStartAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0602EA2E RID: 191022 RVA: 0x00D04E64 File Offset: 0x00D03064
		public virtual void OnBeforeHide()
		{
		}

		// Token: 0x0602EA2F RID: 191023 RVA: 0x00D04E66 File Offset: 0x00D03066
		public virtual void OnBeforeDestroy()
		{
		}

		// Token: 0x0602EA30 RID: 191024 RVA: 0x00D04E68 File Offset: 0x00D03068
		public UniTask RequestServerData()
		{
			InstanceDungeonViewModelBase.<RequestServerData>d__16 <RequestServerData>d__;
			<RequestServerData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestServerData>d__.<>4__this = this;
			<RequestServerData>d__.<>1__state = -1;
			<RequestServerData>d__.<>t__builder.Start<InstanceDungeonViewModelBase.<RequestServerData>d__16>(ref <RequestServerData>d__);
			return <RequestServerData>d__.<>t__builder.Task;
		}

		// Token: 0x0602EA31 RID: 191025 RVA: 0x00D04EAB File Offset: 0x00D030AB
		public void SortInstanceArray(List<int> instanceArray)
		{
			this.OnSortInstanceArray(instanceArray);
		}

		// Token: 0x0602EA32 RID: 191026 RVA: 0x00D04EB4 File Offset: 0x00D030B4
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

		// Token: 0x0602EA33 RID: 191027 RVA: 0x00D04EC1 File Offset: 0x00D030C1
		public string GetInstanceItemTextureBg(int instanceId)
		{
			return this.OnGetInstanceItemTextureBg(instanceId);
		}

		// Token: 0x0602EA34 RID: 191028 RVA: 0x00D04ECA File Offset: 0x00D030CA
		public bool CheckInstanceUnlock(int instanceId)
		{
			return this.OnCheckInstanceUnlock(instanceId);
		}

		// Token: 0x0602EA35 RID: 191029 RVA: 0x00D04ED3 File Offset: 0x00D030D3
		[NullableContext(2)]
		public TableTextArgNew GetUnlockConditionTextId(int instanceId)
		{
			return this.OnGetUnlockConditionTextId(instanceId);
		}

		// Token: 0x0602EA36 RID: 191030 RVA: 0x00D04EDC File Offset: 0x00D030DC
		public bool IsFinishInstance(int instanceId)
		{
			return this.OnIsFinishInstance(instanceId);
		}

		// Token: 0x0602EA37 RID: 191031 RVA: 0x00D04EE5 File Offset: 0x00D030E5
		public string GetInstanceDetectItemIcon(int instanceId)
		{
			return this.OnGetInstanceDetectItemIcon(instanceId);
		}

		// Token: 0x0602EA38 RID: 191032 RVA: 0x00D04EEE File Offset: 0x00D030EE
		[NullableContext(2)]
		public InstanceDungeonEntranceViewSelectData GetDefaultSelectData()
		{
			return this.OnGetDefaultSelectData();
		}

		// Token: 0x0602EA39 RID: 191033 RVA: 0x00D04EF6 File Offset: 0x00D030F6
		public bool CheckNeedOnTimer(int instanceId)
		{
			return this.OnCheckNeedOnTimer(instanceId);
		}

		// Token: 0x0602EA3A RID: 191034 RVA: 0x00D04EFF File Offset: 0x00D030FF
		public void TimerRefreshFunction(float delta)
		{
			this.OnTimerRefreshFunction(delta);
		}

		// Token: 0x0602EA3B RID: 191035 RVA: 0x00D04F08 File Offset: 0x00D03108
		public bool CheckInstanceItemHasRedDot(int instanceId)
		{
			return this.OnCheckInstanceHasRedDot(instanceId);
		}

		// Token: 0x0602EA3C RID: 191036 RVA: 0x00D04F11 File Offset: 0x00D03111
		protected virtual void OnSortInstanceArray(List<int> instanceArray)
		{
		}

		// Token: 0x0602EA3D RID: 191037 RVA: 0x00D04F13 File Offset: 0x00D03113
		protected virtual string OnGetInstanceItemTextureBg(int instanceId)
		{
			return "T_TogListNor";
		}

		// Token: 0x0602EA3E RID: 191038 RVA: 0x00D04F1C File Offset: 0x00D0311C
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

		// Token: 0x0602EA3F RID: 191039 RVA: 0x00D04FB0 File Offset: 0x00D031B0
		protected virtual bool OnCheckInstanceUnlock(int instanceId)
		{
			return InstanceDungeonEntranceModel.Instance.CheckInstanceUnlock(instanceId);
		}

		// Token: 0x0602EA40 RID: 191040 RVA: 0x00D04FC0 File Offset: 0x00D031C0
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

		// Token: 0x0602EA41 RID: 191041 RVA: 0x00D04FEE File Offset: 0x00D031EE
		protected virtual bool OnIsFinishInstance(int instanceId)
		{
			return ExchangeRewardModel.Instance.IsFinishInstance(instanceId);
		}

		// Token: 0x0602EA42 RID: 191042 RVA: 0x00D04FFC File Offset: 0x00D031FC
		protected virtual string OnGetInstanceDetectItemIcon(int instanceId)
		{
			return InstanceDungeonConfig.Instance.GetConfig(instanceId).Value.DifficultyIcon;
		}

		// Token: 0x0602EA43 RID: 191043 RVA: 0x00D05024 File Offset: 0x00D03224
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

		// Token: 0x0602EA44 RID: 191044 RVA: 0x00D05057 File Offset: 0x00D03257
		protected virtual bool OnCheckNeedOnTimer(int instanceId)
		{
			return false;
		}

		// Token: 0x0602EA45 RID: 191045 RVA: 0x00D0505A File Offset: 0x00D0325A
		protected virtual void OnTimerRefreshFunction(float delta)
		{
		}

		// Token: 0x0602EA46 RID: 191046 RVA: 0x00D0505C File Offset: 0x00D0325C
		protected virtual bool OnCheckInstanceHasRedDot(int instanceId)
		{
			return false;
		}

		// Token: 0x0602EA47 RID: 191047 RVA: 0x00D0505F File Offset: 0x00D0325F
		protected virtual UniTask OnRequestServerData()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x04018CDB RID: 101595
		protected InstanceDungeonEntranceView View;

		// Token: 0x04018CDC RID: 101596
		public int EntranceId;

		// Token: 0x04018CDD RID: 101597
		public int[] InstanceIdList = Array.Empty<int>();

		// Token: 0x04018CDE RID: 101598
		public Dictionary<int, List<int>> InstanceByTitleMap = new Dictionary<int, List<int>>();

		// Token: 0x04018CDF RID: 101599
		[Nullable(2)]
		private InstanceDungeonEntranceViewGetterData GetterData;
	}
}
