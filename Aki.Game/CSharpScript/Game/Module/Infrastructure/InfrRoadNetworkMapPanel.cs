using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x02005920 RID: 22816
	[NullableContext(1)]
	[Nullable(0)]
	public class InfrRoadNetworkMapPanel : UiPanelBase
	{
		// Token: 0x06039F2D RID: 237357 RVA: 0x00DC5BDC File Offset: 0x00DC3DDC
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

		// Token: 0x06039F2E RID: 237358 RVA: 0x00DC6328 File Offset: 0x00DC4528
		protected override UniTask OnBeforeStartAsync()
		{
			InfrRoadNetworkMapPanel.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<InfrRoadNetworkMapPanel.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039F2F RID: 237359 RVA: 0x00DC636C File Offset: 0x00DC456C
		private List<int> GetRoadIdList()
		{
			return (from config in InfrastructureConfig.Instance.GetRoadConfigList()
			select config.Id into id
			orderby id
			select id).ToList<int>();
		}

		// Token: 0x06039F30 RID: 237360 RVA: 0x00DC63D0 File Offset: 0x00DC45D0
		private UniTask CreateMarkPanels()
		{
			InfrRoadNetworkMapPanel.<CreateMarkPanels>d__19 <CreateMarkPanels>d__;
			<CreateMarkPanels>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateMarkPanels>d__.<>4__this = this;
			<CreateMarkPanels>d__.<>1__state = -1;
			<CreateMarkPanels>d__.<>t__builder.Start<InfrRoadNetworkMapPanel.<CreateMarkPanels>d__19>(ref <CreateMarkPanels>d__);
			return <CreateMarkPanels>d__.<>t__builder.Task;
		}

		// Token: 0x06039F31 RID: 237361 RVA: 0x00DC6414 File Offset: 0x00DC4614
		private UniTask CreateObservatoryMark()
		{
			InfrRoadNetworkMapPanel.<CreateObservatoryMark>d__20 <CreateObservatoryMark>d__;
			<CreateObservatoryMark>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateObservatoryMark>d__.<>4__this = this;
			<CreateObservatoryMark>d__.<>1__state = -1;
			<CreateObservatoryMark>d__.<>t__builder.Start<InfrRoadNetworkMapPanel.<CreateObservatoryMark>d__20>(ref <CreateObservatoryMark>d__);
			return <CreateObservatoryMark>d__.<>t__builder.Task;
		}

		// Token: 0x06039F32 RID: 237362 RVA: 0x00DC6458 File Offset: 0x00DC4658
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

		// Token: 0x06039F33 RID: 237363 RVA: 0x00DC64C4 File Offset: 0x00DC46C4
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

		// Token: 0x06039F34 RID: 237364 RVA: 0x00DC6564 File Offset: 0x00DC4764
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

		// Token: 0x06039F35 RID: 237365 RVA: 0x00DC6704 File Offset: 0x00DC4904
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

		// Token: 0x06039F36 RID: 237366 RVA: 0x00DC685C File Offset: 0x00DC4A5C
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

		// Token: 0x06039F37 RID: 237367 RVA: 0x00DC68D9 File Offset: 0x00DC4AD9
		public void SetOnClickMarkCb(Action<InfrastructureDefine.IInfrMaterialsDeliveryOpenParam> cb)
		{
			this.OnClickMarkCb = cb;
		}

		// Token: 0x06039F38 RID: 237368 RVA: 0x00DC68E2 File Offset: 0x00DC4AE2
		public void SetNeedPlayFinishSeq(bool needPlayFinishSeq, int roadId, ActionInfrastructureItemDeliveryType deliveryType)
		{
			this.NeedPlayFinishSeq = needPlayFinishSeq;
			this.FinishRoadId = roadId;
			this.FinishDeliveryType = deliveryType;
		}

		// Token: 0x06039F39 RID: 237369 RVA: 0x00DC68FC File Offset: 0x00DC4AFC
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

		// Token: 0x06039F3A RID: 237370 RVA: 0x00DC69A0 File Offset: 0x00DC4BA0
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

		// Token: 0x06039F3B RID: 237371 RVA: 0x00DC6A4C File Offset: 0x00DC4C4C
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

		// Token: 0x06039F3C RID: 237372 RVA: 0x00DC6AB8 File Offset: 0x00DC4CB8
		public Tuple<float, float> GetObservatoryMarkUiPosition()
		{
			UUIItem rootItem = this.ObservatoryMarkItem.GetRootItem();
			FVector2D? fvector2D = (rootItem != null) ? new FVector2D?(rootItem.GetAnchorOffset()) : null;
			return new Tuple<float, float>(fvector2D.Value.X, fvector2D.Value.Y);
		}

		// Token: 0x06039F3D RID: 237373 RVA: 0x00DC6B08 File Offset: 0x00DC4D08
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

		// Token: 0x06039F3E RID: 237374 RVA: 0x00DC6BA4 File Offset: 0x00DC4DA4
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

		// Token: 0x06039F3F RID: 237375 RVA: 0x00DC6C14 File Offset: 0x00DC4E14
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

		// Token: 0x06039F40 RID: 237376 RVA: 0x00DC6C50 File Offset: 0x00DC4E50
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
			int player = LocalStorage.GetPlayer<int>(ELocalStoragePlayerKey.InfrObservatoryLevelUpSeq, 0);
			if (fireLevel > player && !needPlayFinishSeq)
			{
				this.ObservatoryMarkItem.ShowLevelUpSeq();
			}
			LocalStorage.SetPlayer<int>(ELocalStoragePlayerKey.InfrObservatoryLevelUpSeq, InfrastructureModel.Instance.FireLevel);
		}

		// Token: 0x06039F41 RID: 237377 RVA: 0x00DC6D04 File Offset: 0x00DC4F04
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

		// Token: 0x0401E360 RID: 123744
		private readonly Dictionary<int, InfrRoadNetworkMarkItem> MarkItemMap = new Dictionary<int, InfrRoadNetworkMarkItem>();

		// Token: 0x0401E361 RID: 123745
		private readonly InfrRoadNetworkObservatoryMarkItem ObservatoryMarkItem = new InfrRoadNetworkObservatoryMarkItem();

		// Token: 0x0401E362 RID: 123746
		private int SelectedRoadId;

		// Token: 0x0401E363 RID: 123747
		private InfrRoadNetworkMapPanel.ESelectedType SelectedType;

		// Token: 0x0401E364 RID: 123748
		private Action<InfrastructureDefine.IInfrMaterialsDeliveryOpenParam> OnClickMarkCb;

		// Token: 0x0401E365 RID: 123749
		private readonly global::Vector TempVector = global::Vector.Create();

		// Token: 0x0401E366 RID: 123750
		private bool NeedPlayFinishSeq;

		// Token: 0x0401E367 RID: 123751
		private int FinishRoadId;

		// Token: 0x0401E368 RID: 123752
		private ActionInfrastructureItemDeliveryType FinishDeliveryType = ActionInfrastructureItemDeliveryType.Road;

		// Token: 0x0401E369 RID: 123753
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

		// Token: 0x0401E36A RID: 123754
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

		// Token: 0x0401E36B RID: 123755
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

		// Token: 0x0401E36C RID: 123756
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

		// Token: 0x0401E36D RID: 123757
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

		// Token: 0x0200BBB8 RID: 48056
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04038ABD RID: 232125
			public const int MarkItem1 = 0;

			// Token: 0x04038ABE RID: 232126
			public const int MarkItem2 = 1;

			// Token: 0x04038ABF RID: 232127
			public const int MarkItem3 = 2;

			// Token: 0x04038AC0 RID: 232128
			public const int MarkItem4 = 3;

			// Token: 0x04038AC1 RID: 232129
			public const int MarkItem5 = 4;

			// Token: 0x04038AC2 RID: 232130
			public const int MarkItem6 = 5;

			// Token: 0x04038AC3 RID: 232131
			public const int MarkItem7 = 6;

			// Token: 0x04038AC4 RID: 232132
			public const int MarkItem8 = 7;

			// Token: 0x04038AC5 RID: 232133
			public const int MarkItem9 = 8;

			// Token: 0x04038AC6 RID: 232134
			public const int ObservatoryMarkItem = 9;

			// Token: 0x04038AC7 RID: 232135
			public const int TextureLine1 = 10;

			// Token: 0x04038AC8 RID: 232136
			public const int TextureLine2 = 11;

			// Token: 0x04038AC9 RID: 232137
			public const int TextureLine3 = 12;

			// Token: 0x04038ACA RID: 232138
			public const int TextureLine4 = 13;

			// Token: 0x04038ACB RID: 232139
			public const int TextureLine5 = 14;

			// Token: 0x04038ACC RID: 232140
			public const int TextureLine6 = 15;

			// Token: 0x04038ACD RID: 232141
			public const int TextureLine7 = 16;

			// Token: 0x04038ACE RID: 232142
			public const int TextureLine8 = 17;

			// Token: 0x04038ACF RID: 232143
			public const int MarkItem10 = 18;

			// Token: 0x04038AD0 RID: 232144
			public const int MarkItem11 = 19;

			// Token: 0x04038AD1 RID: 232145
			public const int TextureLine9 = 20;

			// Token: 0x04038AD2 RID: 232146
			public const int TextureLine10 = 21;

			// Token: 0x04038AD3 RID: 232147
			public const int TextureLine11 = 22;

			// Token: 0x04038AD4 RID: 232148
			public const int TextureLineDashedSweep1 = 23;

			// Token: 0x04038AD5 RID: 232149
			public const int TextureLineDashedSweep2 = 24;

			// Token: 0x04038AD6 RID: 232150
			public const int TextureLineDashedSweep3 = 25;

			// Token: 0x04038AD7 RID: 232151
			public const int TextureLineDashedSweep4 = 26;

			// Token: 0x04038AD8 RID: 232152
			public const int TextureLineDashedSweep5 = 27;

			// Token: 0x04038AD9 RID: 232153
			public const int TextureLineDashedSweep6 = 28;

			// Token: 0x04038ADA RID: 232154
			public const int TextureLineDashedSweep7 = 29;

			// Token: 0x04038ADB RID: 232155
			public const int TextureLineDashedSweep8 = 30;

			// Token: 0x04038ADC RID: 232156
			public const int TextureLineDashedSweep9 = 31;

			// Token: 0x04038ADD RID: 232157
			public const int TextureLineDashedSweep10 = 32;

			// Token: 0x04038ADE RID: 232158
			public const int TextureLineSweep1 = 33;

			// Token: 0x04038ADF RID: 232159
			public const int TextureLineSweep2 = 34;

			// Token: 0x04038AE0 RID: 232160
			public const int TextureLineSweep3 = 35;

			// Token: 0x04038AE1 RID: 232161
			public const int TextureLineSweep4 = 36;

			// Token: 0x04038AE2 RID: 232162
			public const int TextureLineSweep5 = 37;

			// Token: 0x04038AE3 RID: 232163
			public const int TextureLineSweep6 = 38;

			// Token: 0x04038AE4 RID: 232164
			public const int TextureLineSweep7 = 39;

			// Token: 0x04038AE5 RID: 232165
			public const int TextureLineSweep8 = 40;

			// Token: 0x04038AE6 RID: 232166
			public const int TextureLineSweep9 = 41;

			// Token: 0x04038AE7 RID: 232167
			public const int TextureLineSweep10 = 42;

			// Token: 0x04038AE8 RID: 232168
			public const int TextureLineDotted10 = 52;

			// Token: 0x04038AE9 RID: 232169
			public const int TextureStaticLine1 = 53;

			// Token: 0x04038AEA RID: 232170
			public const int TextureStaticLine2 = 54;

			// Token: 0x04038AEB RID: 232171
			public const int TextureStaticLine3 = 55;

			// Token: 0x04038AEC RID: 232172
			public const int TextureStaticLine4 = 56;

			// Token: 0x04038AED RID: 232173
			public const int TextureStaticLine5 = 57;

			// Token: 0x04038AEE RID: 232174
			public const int TextureStaticLine6 = 58;

			// Token: 0x04038AEF RID: 232175
			public const int TextureStaticLine7 = 59;

			// Token: 0x04038AF0 RID: 232176
			public const int TextureStaticLine8 = 60;

			// Token: 0x04038AF1 RID: 232177
			public const int TextureStaticLine9 = 61;

			// Token: 0x04038AF2 RID: 232178
			public const int TextureStaticLine10 = 62;
		}

		// Token: 0x0200BBB9 RID: 48057
		[NullableContext(0)]
		private enum ESelectedType
		{
			// Token: 0x04038AF4 RID: 232180
			None,
			// Token: 0x04038AF5 RID: 232181
			Road,
			// Token: 0x04038AF6 RID: 232182
			Observatory
		}
	}
}
