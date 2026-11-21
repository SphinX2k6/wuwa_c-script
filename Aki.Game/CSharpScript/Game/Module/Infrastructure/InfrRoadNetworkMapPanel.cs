using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x020048F9 RID: 18681
	[NullableContext(1)]
	[Nullable(0)]
	public class InfrRoadNetworkMapPanel : UiPanelBase
	{
		// Token: 0x0602EE50 RID: 192080 RVA: 0x00D14ED8 File Offset: 0x00D130D8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 54;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(24, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(25, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(26, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(27, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(28, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(29, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(30, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(31, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(32, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(33, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(34, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(35, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(36, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(37, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(38, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(39, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(40, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(41, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(42, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(52, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(53, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(54, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(55, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(56, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(57, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(58, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(59, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(60, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(61, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(62, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602EE51 RID: 192081 RVA: 0x00D15624 File Offset: 0x00D13824
		protected override UniTask OnBeforeStartAsync()
		{
			InfrRoadNetworkMapPanel.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<InfrRoadNetworkMapPanel.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602EE52 RID: 192082 RVA: 0x00D15668 File Offset: 0x00D13868
		private List<int> GetRoadIdList()
		{
			IReadOnlyList<InfrRoadBuild> roadConfigList = InfrastructureConfig.Instance.GetRoadConfigList();
			List<int> list = new List<int>(roadConfigList.Count);
			for (int i = 0; i < roadConfigList.Count; i++)
			{
				list.Add(roadConfigList[i].Id);
			}
			list.Sort();
			return list;
		}

		// Token: 0x0602EE53 RID: 192083 RVA: 0x00D156BC File Offset: 0x00D138BC
		private UniTask CreateMarkPanels()
		{
			InfrRoadNetworkMapPanel.<CreateMarkPanels>d__19 <CreateMarkPanels>d__;
			<CreateMarkPanels>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateMarkPanels>d__.<>4__this = this;
			<CreateMarkPanels>d__.<>1__state = -1;
			<CreateMarkPanels>d__.<>t__builder.Start<InfrRoadNetworkMapPanel.<CreateMarkPanels>d__19>(ref <CreateMarkPanels>d__);
			return <CreateMarkPanels>d__.<>t__builder.Task;
		}

		// Token: 0x0602EE54 RID: 192084 RVA: 0x00D15700 File Offset: 0x00D13900
		private UniTask CreateObservatoryMark()
		{
			InfrRoadNetworkMapPanel.<CreateObservatoryMark>d__20 <CreateObservatoryMark>d__;
			<CreateObservatoryMark>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateObservatoryMark>d__.<>4__this = this;
			<CreateObservatoryMark>d__.<>1__state = -1;
			<CreateObservatoryMark>d__.<>t__builder.Start<InfrRoadNetworkMapPanel.<CreateObservatoryMark>d__20>(ref <CreateObservatoryMark>d__);
			return <CreateObservatoryMark>d__.<>t__builder.Task;
		}

		// Token: 0x0602EE55 RID: 192085 RVA: 0x00D15744 File Offset: 0x00D13944
		protected override void OnStart()
		{
			float value = ConfigCommonParamById.GetFloatConfig("InfrRoadNetworkMarkBaseScale").Value;
			this.TempVector.Set((double)value, (double)value, (double)value);
			InfrastructureDefine.IInfrRoadNetworkOpenParam infrRoadNetworkOpenParam = this.OpenParam as InfrastructureDefine.IInfrRoadNetworkOpenParam;
			if (infrRoadNetworkOpenParam != null)
			{
				this.SetNeedPlayFinishSeq(infrRoadNetworkOpenParam.NeedPlayFinishSeq.GetValueOrDefault(), infrRoadNetworkOpenParam.RoadId, infrRoadNetworkOpenParam.DeliveryType);
			}
			this.RefreshAllMarks();
			this.RefreshAllRoad();
		}

		// Token: 0x0602EE56 RID: 192086 RVA: 0x00D157B0 File Offset: 0x00D139B0
		public void RefreshAllMarks()
		{
			foreach (KeyValuePair<int, InfrRoadNetworkMarkItem> keyValuePair in this.MarkItemMap)
			{
				int key = keyValuePair.Key;
				InfrRoadNetworkMarkItem value = keyValuePair.Value;
				value.SetNeedPlayFinishSeq(this.NeedPlayFinishSeq && this.FinishDeliveryType == ActionInfrastructureItemDeliveryType.Road, this.FinishRoadId);
				value.Refresh(key);
			}
			this.ObservatoryMarkItem.SetNeedPlayFinishSeq(this.NeedPlayFinishSeq && this.FinishDeliveryType == ActionInfrastructureItemDeliveryType.Observatory);
		}

		// Token: 0x0602EE57 RID: 192087 RVA: 0x00D15850 File Offset: 0x00D13A50
		private void RefreshAllRoad()
		{
			List<int> roadIdList = this.GetRoadIdList();
			int i;
			for (i = 0; i < roadIdList.Count; i++)
			{
				int num = roadIdList[i];
				InfrastructureDefine.IInfrRoadData roadDataByRoadId = InfrastructureModel.Instance.GetRoadDataByRoadId(num);
				if (roadDataByRoadId != null && roadDataByRoadId.Status == InfrStatusPb.InfrStatusComplete)
				{
					if (this.FinishRoadId == num && this.FinishDeliveryType == ActionInfrastructureItemDeliveryType.Road)
					{
						UUIItem item = base.GetItem(this.TextureLineList[i]);
						if (item != null)
						{
							item.SetUIActive(false);
						}
						UUIItem item2 = base.GetItem(this.TextureStaticLineList[i]);
						if (item2 != null)
						{
							item2.SetUIActive(false);
						}
					}
					else
					{
						UUIItem item3 = base.GetItem(this.TextureLineList[i]);
						if (item3 != null)
						{
							item3.SetUIActive(false);
						}
						UUIItem item4 = base.GetItem(this.TextureStaticLineList[i]);
						if (item4 != null)
						{
							item4.SetUIActive(true);
						}
					}
					if (this.TextureLineList[i] == 21)
					{
						UUIItem item5 = base.GetItem(52);
						if (item5 != null)
						{
							item5.SetUIActive(false);
						}
					}
				}
				else
				{
					UUIItem item6 = base.GetItem(this.TextureLineList[i]);
					if (item6 != null)
					{
						item6.SetUIActive(false);
					}
					UUIItem item7 = base.GetItem(this.TextureStaticLineList[i]);
					if (item7 != null)
					{
						item7.SetUIActive(false);
					}
				}
			}
			while (i < this.TextureLineList.Count && i < this.MarkItemList.Count)
			{
				UUIItem item8 = base.GetItem(this.TextureLineList[i]);
				if (item8 != null)
				{
					item8.SetUIActive(false);
				}
				UUIItem item9 = base.GetItem(this.MarkItemList[i]);
				if (item9 != null)
				{
					item9.SetUIActive(false);
				}
				i++;
			}
		}

		// Token: 0x0602EE58 RID: 192088 RVA: 0x00D159F0 File Offset: 0x00D13BF0
		private void OnClickMark(int roadId)
		{
			if (this.SelectedType == InfrRoadNetworkMapPanel.ESelectedType.Road)
			{
				InfrRoadNetworkMarkItem infrRoadNetworkMarkItem;
				if (this.MarkItemMap.TryGetValue(this.SelectedRoadId, out infrRoadNetworkMarkItem))
				{
					infrRoadNetworkMarkItem.SetSelected(false);
					int num = this.GetRoadIdList().IndexOf(this.SelectedRoadId);
					if (num >= 0)
					{
						UUIItem item = base.GetItem(this.TextureLineSweepList[num]);
						if (item != null)
						{
							item.SetUIActive(false);
						}
						UUIItem item2 = base.GetItem(this.TextureLineDashedSweepList[num]);
						if (item2 != null)
						{
							item2.SetUIActive(false);
						}
					}
				}
			}
			else if (this.SelectedType == InfrRoadNetworkMapPanel.ESelectedType.Observatory)
			{
				this.ObservatoryMarkItem.SetSelected(false);
			}
			this.SelectedType = InfrRoadNetworkMapPanel.ESelectedType.Road;
			this.SelectedRoadId = roadId;
			InfrRoadNetworkMarkItem infrRoadNetworkMarkItem2;
			this.MarkItemMap.TryGetValue(roadId, out infrRoadNetworkMarkItem2);
			List<int> roadIdList = this.GetRoadIdList();
			InfrastructureDefine.IInfrRoadData roadDataByRoadId = InfrastructureModel.Instance.GetRoadDataByRoadId(roadId);
			int num2 = roadIdList.IndexOf(roadId);
			if (num2 >= 0)
			{
				if (roadDataByRoadId != null && roadDataByRoadId.Status == InfrStatusPb.InfrStatusComplete)
				{
					UUIItem item3 = base.GetItem(this.TextureLineSweepList[num2]);
					if (item3 != null)
					{
						item3.SetUIActive(true);
					}
				}
				else
				{
					UUIItem item4 = base.GetItem(this.TextureLineDashedSweepList[num2]);
					if (item4 != null)
					{
						item4.SetUIActive(true);
					}
				}
			}
			if (infrRoadNetworkMarkItem2 != null)
			{
				infrRoadNetworkMarkItem2.Refresh(roadId);
			}
			Action<InfrastructureDefine.IInfrMaterialsDeliveryOpenParam> onClickMarkCb = this.OnClickMarkCb;
			if (onClickMarkCb == null)
			{
				return;
			}
			onClickMarkCb(new InfrastructureDefine.InfrMaterialsDeliveryOpenParam
			{
				DeliveryType = ActionInfrastructureItemDeliveryType.Road,
				RoadId = roadId,
				OpenSource = InfrastructureDefine.EMaterialDeliveryOpenSource.RoadNetworkMap
			});
		}

		// Token: 0x0602EE59 RID: 192089 RVA: 0x00D15B48 File Offset: 0x00D13D48
		private void OnClickObservatoryMark()
		{
			if (this.SelectedType == InfrRoadNetworkMapPanel.ESelectedType.Observatory)
			{
				return;
			}
			InfrRoadNetworkMarkItem infrRoadNetworkMarkItem;
			if (this.SelectedType == InfrRoadNetworkMapPanel.ESelectedType.Road && this.MarkItemMap.TryGetValue(this.SelectedRoadId, out infrRoadNetworkMarkItem))
			{
				infrRoadNetworkMarkItem.SetSelected(false);
			}
			this.SelectedType = InfrRoadNetworkMapPanel.ESelectedType.Observatory;
			this.ObservatoryMarkItem.Refresh();
			Action<InfrastructureDefine.IInfrMaterialsDeliveryOpenParam> onClickMarkCb = this.OnClickMarkCb;
			if (onClickMarkCb == null)
			{
				return;
			}
			onClickMarkCb(new InfrastructureDefine.InfrMaterialsDeliveryOpenParam
			{
				DeliveryType = ActionInfrastructureItemDeliveryType.Observatory,
				RoadId = this.SelectedRoadId,
				OpenSource = InfrastructureDefine.EMaterialDeliveryOpenSource.RoadNetworkMap
			});
		}

		// Token: 0x0602EE5A RID: 192090 RVA: 0x00D15BC5 File Offset: 0x00D13DC5
		public void SetOnClickMarkCb(Action<InfrastructureDefine.IInfrMaterialsDeliveryOpenParam> cb)
		{
			this.OnClickMarkCb = cb;
		}

		// Token: 0x0602EE5B RID: 192091 RVA: 0x00D15BCE File Offset: 0x00D13DCE
		public void SetNeedPlayFinishSeq(bool needPlayFinishSeq, int roadId, ActionInfrastructureItemDeliveryType deliveryType)
		{
			this.NeedPlayFinishSeq = needPlayFinishSeq;
			this.FinishRoadId = roadId;
			this.FinishDeliveryType = deliveryType;
		}

		// Token: 0x0602EE5C RID: 192092 RVA: 0x00D15BE8 File Offset: 0x00D13DE8
		public void SelectMark(ActionInfrastructureItemDeliveryType deliveryType, int roadId)
		{
			if (deliveryType == ActionInfrastructureItemDeliveryType.Road)
			{
				InfrRoadNetworkMarkItem infrRoadNetworkMarkItem;
				if (this.MarkItemMap.TryGetValue(roadId, out infrRoadNetworkMarkItem))
				{
					infrRoadNetworkMarkItem.SetSelected(true);
					int num = this.GetRoadIdList().IndexOf(roadId);
					if (num >= 0)
					{
						InfrastructureDefine.IInfrRoadData roadDataByRoadId = InfrastructureModel.Instance.GetRoadDataByRoadId(roadId);
						if (roadDataByRoadId != null && roadDataByRoadId.Status == InfrStatusPb.InfrStatusComplete)
						{
							UUIItem item = base.GetItem(this.TextureLineSweepList[num]);
							if (item == null)
							{
								return;
							}
							item.SetUIActive(true);
							return;
						}
						else
						{
							UUIItem item2 = base.GetItem(this.TextureLineDashedSweepList[num]);
							if (item2 == null)
							{
								return;
							}
							item2.SetUIActive(true);
							return;
						}
					}
				}
			}
			else if (deliveryType == ActionInfrastructureItemDeliveryType.Observatory)
			{
				this.ObservatoryMarkItem.SetSelected(true);
			}
		}

		// Token: 0x0602EE5D RID: 192093 RVA: 0x00D15C8C File Offset: 0x00D13E8C
		public void DeselectMark()
		{
			if (this.SelectedType == InfrRoadNetworkMapPanel.ESelectedType.Road)
			{
				InfrRoadNetworkMarkItem infrRoadNetworkMarkItem;
				if (this.MarkItemMap.TryGetValue(this.SelectedRoadId, out infrRoadNetworkMarkItem))
				{
					infrRoadNetworkMarkItem.SetSelected(false);
					int num = this.GetRoadIdList().IndexOf(this.SelectedRoadId);
					if (num >= 0)
					{
						UUIItem item = base.GetItem(this.TextureLineSweepList[num]);
						if (item != null)
						{
							item.SetUIActive(false);
						}
						UUIItem item2 = base.GetItem(this.TextureLineDashedSweepList[num]);
						if (item2 != null)
						{
							item2.SetUIActive(false);
						}
					}
				}
			}
			else if (this.SelectedType == InfrRoadNetworkMapPanel.ESelectedType.Observatory)
			{
				this.ObservatoryMarkItem.SetSelected(false);
			}
			this.SelectedType = InfrRoadNetworkMapPanel.ESelectedType.None;
			this.SelectedRoadId = -1;
		}

		// Token: 0x0602EE5E RID: 192094 RVA: 0x00D15D38 File Offset: 0x00D13F38
		public Tuple<float, float> GetMarkUiPosition(int roadId)
		{
			InfrRoadNetworkMarkItem infrRoadNetworkMarkItem;
			if (this.MarkItemMap.TryGetValue(roadId, out infrRoadNetworkMarkItem))
			{
				UUIItem rootItem = infrRoadNetworkMarkItem.GetRootItem();
				FVector2D? fvector2D = (rootItem != null) ? new FVector2D?(rootItem.GetAnchorOffset()) : null;
				return new Tuple<float, float>(fvector2D.Value.X, fvector2D.Value.Y);
			}
			return new Tuple<float, float>(0f, 0f);
		}

		// Token: 0x0602EE5F RID: 192095 RVA: 0x00D15DA4 File Offset: 0x00D13FA4
		public Tuple<float, float> GetObservatoryMarkUiPosition()
		{
			UUIItem rootItem = this.ObservatoryMarkItem.GetRootItem();
			FVector2D? fvector2D = (rootItem != null) ? new FVector2D?(rootItem.GetAnchorOffset()) : null;
			return new Tuple<float, float>(fvector2D.Value.X, fvector2D.Value.Y);
		}

		// Token: 0x0602EE60 RID: 192096 RVA: 0x00D15DF4 File Offset: 0x00D13FF4
		public void RefreshMarkScale(float mapScale)
		{
			float value = ConfigCommonParamById.GetFloatConfig("InfrRoadNetworkMarkBaseScale").Value;
			global::Vector vector = global::Vector.Create((double)(value / mapScale), (double)(value / mapScale), (double)(value / mapScale));
			foreach (InfrRoadNetworkMarkItem infrRoadNetworkMarkItem in this.MarkItemMap.Values)
			{
				infrRoadNetworkMarkItem.GetRootItem().SetUIItemScale(vector.ToUeVectorOld());
			}
			this.ObservatoryMarkItem.GetRootItem().SetUIItemScale(vector.ToUeVectorOld());
		}

		// Token: 0x0602EE61 RID: 192097 RVA: 0x00D15E90 File Offset: 0x00D14090
		public void ShowMarkFinishSeq(ActionInfrastructureItemDeliveryType deliveryType, int roadId, Action onFinishPlayEnd)
		{
			if (deliveryType == ActionInfrastructureItemDeliveryType.Road)
			{
				InfrRoadNetworkMarkItem infrRoadNetworkMarkItem;
				if (this.MarkItemMap.TryGetValue(roadId, out infrRoadNetworkMarkItem))
				{
					infrRoadNetworkMarkItem.ShowMarkFinish(delegate
					{
						int num = this.GetRoadIdList().IndexOf(roadId);
						if (num >= 0 && this.TextureLineList[num] == 21)
						{
							UUIItem item = this.GetItem(52);
							if (item != null)
							{
								item.SetUIActive(false);
							}
						}
						Action onFinishPlayEnd2 = onFinishPlayEnd;
						if (onFinishPlayEnd2 == null)
						{
							return;
						}
						onFinishPlayEnd2();
					});
					return;
				}
			}
			else if (deliveryType == ActionInfrastructureItemDeliveryType.Observatory)
			{
				this.ObservatoryMarkItem.ShowMarkFinish(delegate
				{
					Action onFinishPlayEnd2 = onFinishPlayEnd;
					if (onFinishPlayEnd2 == null)
					{
						return;
					}
					onFinishPlayEnd2();
				});
			}
		}

		// Token: 0x0602EE62 RID: 192098 RVA: 0x00D15F00 File Offset: 0x00D14100
		public void RefreshFinishTextureLine(int roadId)
		{
			int num = this.GetRoadIdList().IndexOf(roadId);
			if (num >= 0)
			{
				UUIItem item = base.GetItem(this.TextureLineList[num]);
				if (item == null)
				{
					return;
				}
				item.SetUIActive(true);
			}
		}

		// Token: 0x0602EE63 RID: 192099 RVA: 0x00D15F3C File Offset: 0x00D1413C
		public void ShowMarkUnlock(bool needPlayFinishSeq, Action cb)
		{
			List<int> hasUnlockRoadAndNotPlaySeqMark = InfrastructureModel.Instance.GetHasUnlockRoadAndNotPlaySeqMark();
			foreach (int key in hasUnlockRoadAndNotPlaySeqMark)
			{
				InfrRoadNetworkMarkItem infrRoadNetworkMarkItem;
				if (this.MarkItemMap.TryGetValue(key, out infrRoadNetworkMarkItem))
				{
					infrRoadNetworkMarkItem.ShowMarkUnlock(cb);
				}
			}
			if (hasUnlockRoadAndNotPlaySeqMark.Count == 0)
			{
				cb();
			}
			int fireLevel = InfrastructureModel.Instance.FireLevel;
			ServerStorageUtil.OverrideLocalNumberToServerNumber(ELocalStoragePlayerKey.InfrObservatoryLevelUpSeq, EClientStorageSystemIdType.InfrObservatoryLevelUpSeq, true);
			ServerStorageNumber serverStorageNumber = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.InfrObservatoryLevelUpSeq) as ServerStorageNumber;
			int? num = serverStorageNumber.Get();
			if (num != null)
			{
				int num2 = fireLevel;
				int? num3 = num;
				if ((num2 > num3.GetValueOrDefault() & num3 != null) && !needPlayFinishSeq)
				{
					this.ObservatoryMarkItem.ShowLevelUpSeq();
				}
			}
			serverStorageNumber.Set(new int?(InfrastructureModel.Instance.FireLevel));
		}

		// Token: 0x0602EE64 RID: 192100 RVA: 0x00D1602C File Offset: 0x00D1422C
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams.Length == 0)
			{
				return null;
			}
			if (configParams[0] == "RoadMark")
			{
				int key = int.Parse(configParams[1]);
				InfrRoadNetworkMarkItem infrRoadNetworkMarkItem;
				if (this.MarkItemMap.TryGetValue(key, out infrRoadNetworkMarkItem))
				{
					return infrRoadNetworkMarkItem.GetGuideUiItemAndUiItemForShowEx(configParams);
				}
			}
			return null;
		}

		// Token: 0x04018DFD RID: 101885
		private readonly Dictionary<int, InfrRoadNetworkMarkItem> MarkItemMap = new Dictionary<int, InfrRoadNetworkMarkItem>();

		// Token: 0x04018DFE RID: 101886
		private readonly InfrRoadNetworkObservatoryMarkItem ObservatoryMarkItem = new InfrRoadNetworkObservatoryMarkItem();

		// Token: 0x04018DFF RID: 101887
		private int SelectedRoadId;

		// Token: 0x04018E00 RID: 101888
		private InfrRoadNetworkMapPanel.ESelectedType SelectedType;

		// Token: 0x04018E01 RID: 101889
		private Action<InfrastructureDefine.IInfrMaterialsDeliveryOpenParam> OnClickMarkCb;

		// Token: 0x04018E02 RID: 101890
		private readonly global::Vector TempVector = global::Vector.Create();

		// Token: 0x04018E03 RID: 101891
		private bool NeedPlayFinishSeq;

		// Token: 0x04018E04 RID: 101892
		private int FinishRoadId;

		// Token: 0x04018E05 RID: 101893
		private ActionInfrastructureItemDeliveryType FinishDeliveryType = ActionInfrastructureItemDeliveryType.Road;

		// Token: 0x04018E06 RID: 101894
		private readonly List<int> MarkItemList = new List<int>
		{
			0,
			1,
			2,
			3,
			4,
			5,
			6,
			7,
			8,
			18,
			19
		};

		// Token: 0x04018E07 RID: 101895
		private readonly List<int> TextureLineList = new List<int>
		{
			10,
			11,
			12,
			13,
			14,
			15,
			16,
			17,
			20,
			21,
			22
		};

		// Token: 0x04018E08 RID: 101896
		public readonly List<int> TextureStaticLineList = new List<int>
		{
			53,
			54,
			55,
			56,
			57,
			58,
			59,
			60,
			61,
			62
		};

		// Token: 0x04018E09 RID: 101897
		private readonly List<int> TextureLineDashedSweepList = new List<int>
		{
			23,
			24,
			25,
			26,
			27,
			28,
			29,
			30,
			31,
			32
		};

		// Token: 0x04018E0A RID: 101898
		public readonly List<int> TextureLineSweepList = new List<int>
		{
			33,
			34,
			35,
			36,
			37,
			38,
			39,
			40,
			41,
			42
		};

		// Token: 0x0200A5C8 RID: 42440
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x040334A2 RID: 210082
			public const int MarkItem1 = 0;

			// Token: 0x040334A3 RID: 210083
			public const int MarkItem2 = 1;

			// Token: 0x040334A4 RID: 210084
			public const int MarkItem3 = 2;

			// Token: 0x040334A5 RID: 210085
			public const int MarkItem4 = 3;

			// Token: 0x040334A6 RID: 210086
			public const int MarkItem5 = 4;

			// Token: 0x040334A7 RID: 210087
			public const int MarkItem6 = 5;

			// Token: 0x040334A8 RID: 210088
			public const int MarkItem7 = 6;

			// Token: 0x040334A9 RID: 210089
			public const int MarkItem8 = 7;

			// Token: 0x040334AA RID: 210090
			public const int MarkItem9 = 8;

			// Token: 0x040334AB RID: 210091
			public const int ObservatoryMarkItem = 9;

			// Token: 0x040334AC RID: 210092
			public const int TextureLine1 = 10;

			// Token: 0x040334AD RID: 210093
			public const int TextureLine2 = 11;

			// Token: 0x040334AE RID: 210094
			public const int TextureLine3 = 12;

			// Token: 0x040334AF RID: 210095
			public const int TextureLine4 = 13;

			// Token: 0x040334B0 RID: 210096
			public const int TextureLine5 = 14;

			// Token: 0x040334B1 RID: 210097
			public const int TextureLine6 = 15;

			// Token: 0x040334B2 RID: 210098
			public const int TextureLine7 = 16;

			// Token: 0x040334B3 RID: 210099
			public const int TextureLine8 = 17;

			// Token: 0x040334B4 RID: 210100
			public const int MarkItem10 = 18;

			// Token: 0x040334B5 RID: 210101
			public const int MarkItem11 = 19;

			// Token: 0x040334B6 RID: 210102
			public const int TextureLine9 = 20;

			// Token: 0x040334B7 RID: 210103
			public const int TextureLine10 = 21;

			// Token: 0x040334B8 RID: 210104
			public const int TextureLine11 = 22;

			// Token: 0x040334B9 RID: 210105
			public const int TextureLineDashedSweep1 = 23;

			// Token: 0x040334BA RID: 210106
			public const int TextureLineDashedSweep2 = 24;

			// Token: 0x040334BB RID: 210107
			public const int TextureLineDashedSweep3 = 25;

			// Token: 0x040334BC RID: 210108
			public const int TextureLineDashedSweep4 = 26;

			// Token: 0x040334BD RID: 210109
			public const int TextureLineDashedSweep5 = 27;

			// Token: 0x040334BE RID: 210110
			public const int TextureLineDashedSweep6 = 28;

			// Token: 0x040334BF RID: 210111
			public const int TextureLineDashedSweep7 = 29;

			// Token: 0x040334C0 RID: 210112
			public const int TextureLineDashedSweep8 = 30;

			// Token: 0x040334C1 RID: 210113
			public const int TextureLineDashedSweep9 = 31;

			// Token: 0x040334C2 RID: 210114
			public const int TextureLineDashedSweep10 = 32;

			// Token: 0x040334C3 RID: 210115
			public const int TextureLineSweep1 = 33;

			// Token: 0x040334C4 RID: 210116
			public const int TextureLineSweep2 = 34;

			// Token: 0x040334C5 RID: 210117
			public const int TextureLineSweep3 = 35;

			// Token: 0x040334C6 RID: 210118
			public const int TextureLineSweep4 = 36;

			// Token: 0x040334C7 RID: 210119
			public const int TextureLineSweep5 = 37;

			// Token: 0x040334C8 RID: 210120
			public const int TextureLineSweep6 = 38;

			// Token: 0x040334C9 RID: 210121
			public const int TextureLineSweep7 = 39;

			// Token: 0x040334CA RID: 210122
			public const int TextureLineSweep8 = 40;

			// Token: 0x040334CB RID: 210123
			public const int TextureLineSweep9 = 41;

			// Token: 0x040334CC RID: 210124
			public const int TextureLineSweep10 = 42;

			// Token: 0x040334CD RID: 210125
			public const int TextureLineDotted10 = 52;

			// Token: 0x040334CE RID: 210126
			public const int TextureStaticLine1 = 53;

			// Token: 0x040334CF RID: 210127
			public const int TextureStaticLine2 = 54;

			// Token: 0x040334D0 RID: 210128
			public const int TextureStaticLine3 = 55;

			// Token: 0x040334D1 RID: 210129
			public const int TextureStaticLine4 = 56;

			// Token: 0x040334D2 RID: 210130
			public const int TextureStaticLine5 = 57;

			// Token: 0x040334D3 RID: 210131
			public const int TextureStaticLine6 = 58;

			// Token: 0x040334D4 RID: 210132
			public const int TextureStaticLine7 = 59;

			// Token: 0x040334D5 RID: 210133
			public const int TextureStaticLine8 = 60;

			// Token: 0x040334D6 RID: 210134
			public const int TextureStaticLine9 = 61;

			// Token: 0x040334D7 RID: 210135
			public const int TextureStaticLine10 = 62;
		}

		// Token: 0x0200A5C9 RID: 42441
		[NullableContext(0)]
		private enum ESelectedType
		{
			// Token: 0x040334D9 RID: 210137
			None,
			// Token: 0x040334DA RID: 210138
			Road,
			// Token: 0x040334DB RID: 210139
			Observatory
		}
	}
}
