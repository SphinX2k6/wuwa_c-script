using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.MoonChasing;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x020048F8 RID: 18680
	[NullableContext(1)]
	[Nullable(0)]
	public class InfrRoadNetworkMainView : UiViewBase
	{
		// Token: 0x0602EE28 RID: 192040 RVA: 0x00D14004 File Offset: 0x00D12204
		public InfrRoadNetworkMainView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602EE29 RID: 192041 RVA: 0x00D14070 File Offset: 0x00D12270
		protected unsafe override void OnRegisterComponent()
		{
			int num = 16;
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
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISliderComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIDraggableComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(15, new Action(this.OnClickMask));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602EE2A RID: 192042 RVA: 0x00D142ED File Offset: 0x00D124ED
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<IReadOnlyList<InfrastructureDefine.InfrNoticeData>>(EEventName.InfrastructureRoadNoticeUpdate, new Action<IReadOnlyList<InfrastructureDefine.InfrNoticeData>>(this.OnNoticeUpdate));
			EventSystem.Instance.Add(EEventName.InfrastructureTraceRoadUpdate, new Action(this.OnTraceRoadUpdate));
		}

		// Token: 0x0602EE2B RID: 192043 RVA: 0x00D14327 File Offset: 0x00D12527
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<IReadOnlyList<InfrastructureDefine.InfrNoticeData>>(EEventName.InfrastructureRoadNoticeUpdate, new Action<IReadOnlyList<InfrastructureDefine.InfrNoticeData>>(this.OnNoticeUpdate));
			EventSystem.Instance.Remove(EEventName.InfrastructureTraceRoadUpdate, new Action(this.OnTraceRoadUpdate));
		}

		// Token: 0x0602EE2C RID: 192044 RVA: 0x00D14364 File Offset: 0x00D12564
		protected override UniTask OnBeforeStartAsync()
		{
			InfrRoadNetworkMainView.<OnBeforeStartAsync>d__19 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<InfrRoadNetworkMainView.<OnBeforeStartAsync>d__19>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602EE2D RID: 192045 RVA: 0x00D143A8 File Offset: 0x00D125A8
		private void SetupOpenParam(InfrastructureDefine.IInfrRoadNetworkOpenParam openParam)
		{
			if (openParam == null)
			{
				return;
			}
			this.OpenDeliveryType = openParam.DeliveryType;
			this.OpenRoadId = openParam.RoadId;
			this.NeedPlayFinishSeq = openParam.NeedPlayFinishSeq.GetValueOrDefault();
		}

		// Token: 0x0602EE2E RID: 192046 RVA: 0x00D143E8 File Offset: 0x00D125E8
		private UniTask CreateCaption()
		{
			InfrRoadNetworkMainView.<CreateCaption>d__21 <CreateCaption>d__;
			<CreateCaption>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateCaption>d__.<>4__this = this;
			<CreateCaption>d__.<>1__state = -1;
			<CreateCaption>d__.<>t__builder.Start<InfrRoadNetworkMainView.<CreateCaption>d__21>(ref <CreateCaption>d__);
			return <CreateCaption>d__.<>t__builder.Task;
		}

		// Token: 0x0602EE2F RID: 192047 RVA: 0x00D1442C File Offset: 0x00D1262C
		private UniTask CreateMapPanel()
		{
			InfrRoadNetworkMainView.<CreateMapPanel>d__22 <CreateMapPanel>d__;
			<CreateMapPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateMapPanel>d__.<>4__this = this;
			<CreateMapPanel>d__.<>1__state = -1;
			<CreateMapPanel>d__.<>t__builder.Start<InfrRoadNetworkMainView.<CreateMapPanel>d__22>(ref <CreateMapPanel>d__);
			return <CreateMapPanel>d__.<>t__builder.Task;
		}

		// Token: 0x0602EE30 RID: 192048 RVA: 0x00D14470 File Offset: 0x00D12670
		private UniTask CreateFireExpItem()
		{
			InfrRoadNetworkMainView.<CreateFireExpItem>d__23 <CreateFireExpItem>d__;
			<CreateFireExpItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateFireExpItem>d__.<>4__this = this;
			<CreateFireExpItem>d__.<>1__state = -1;
			<CreateFireExpItem>d__.<>t__builder.Start<InfrRoadNetworkMainView.<CreateFireExpItem>d__23>(ref <CreateFireExpItem>d__);
			return <CreateFireExpItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602EE31 RID: 192049 RVA: 0x00D144B4 File Offset: 0x00D126B4
		private UniTask RefreshCaption()
		{
			InfrRoadNetworkMainView.<RefreshCaption>d__24 <RefreshCaption>d__;
			<RefreshCaption>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshCaption>d__.<>4__this = this;
			<RefreshCaption>d__.<>1__state = -1;
			<RefreshCaption>d__.<>t__builder.Start<InfrRoadNetworkMainView.<RefreshCaption>d__24>(ref <RefreshCaption>d__);
			return <RefreshCaption>d__.<>t__builder.Task;
		}

		// Token: 0x0602EE32 RID: 192050 RVA: 0x00D144F7 File Offset: 0x00D126F7
		protected override void OnStart()
		{
			this.CreateMoveComponent();
			this.RefreshFireExpItem();
			this.InitZoom();
			this.OnNoticeUpdate(new List<InfrastructureDefine.InfrNoticeData>());
			this.RefreshMapInitialParam();
		}

		// Token: 0x0602EE33 RID: 192051 RVA: 0x00D1451C File Offset: 0x00D1271C
		protected override void OnBeforeShow()
		{
			this.MapPanel.RefreshMarkScale((float)this.MoveComponent.MapScale);
			this.MoveComponent.BindTouch();
			this.MoveComponent.AddGamepadEvent();
			this.SetMapMarkTraced();
		}

		// Token: 0x0602EE34 RID: 192052 RVA: 0x00D14551 File Offset: 0x00D12751
		protected override void OnAfterHide()
		{
			this.MoveComponent.UnbindTouch();
			this.MoveComponent.RemoveGamepadEvent();
		}

		// Token: 0x0602EE35 RID: 192053 RVA: 0x00D14569 File Offset: 0x00D12769
		protected override void OnAfterPlayStartSequence()
		{
			this.MapPanel.ShowMarkUnlock(this.NeedPlayFinishSeq, new Action(this.ShowBuildFinishSequence));
		}

		// Token: 0x0602EE36 RID: 192054 RVA: 0x00D14588 File Offset: 0x00D12788
		private void CreateMoveComponent()
		{
			this.MoveComponent = new BuildingMapMoveComponent(base.GetDraggable(9), true, true, false);
			IReadOnlyList<float> floatArrayConfig = ConfigCommonParamById.GetFloatArrayConfig("InfrRoadNetworkMapSizeParam");
			this.MoveComponent.SetScaleSafeArea((double)floatArrayConfig[0], (double)floatArrayConfig[1]);
			this.MoveComponent.PointerBeginDragExtraCallBack = new Action<ULGUIPointerEventData>(this.CheckInfoPanel);
			this.MoveComponent.PointerUpExtraCallBack = new Action<ULGUIPointerEventData>(this.CheckInfoPanel);
			this.MoveComponent.SetChangeScaleCallback(new Action<ESetScaleSource>(this.OnChangeSlider));
		}

		// Token: 0x0602EE37 RID: 192055 RVA: 0x00D14618 File Offset: 0x00D12818
		private void InitZoom()
		{
			UUISliderComponent slider = base.GetSlider(7);
			slider.SetMinValue((float)this.MoveComponent.MapScaleSafeArea.Min, false, false);
			slider.SetMaxValue((float)this.MoveComponent.MapScaleSafeArea.Max, false, false);
			slider.OnValueChangeCb.Bind(new Action<float>(this.OnSliderValueChange));
			this.ZoomIn = new LongPressButton(base.GetButton(5), new Action<float>(this.OnZoomIn), 100);
			this.ZoomOut = new LongPressButton(base.GetButton(6), new Action<float>(this.OnZoomOut), 100);
		}

		// Token: 0x0602EE38 RID: 192056 RVA: 0x00D146B4 File Offset: 0x00D128B4
		private void RefreshFireExpItem()
		{
			this.FireExpPanel.SetOnClickHelpCb(delegate
			{
				int helpIdRoadProcess = InfrastructureConfig.Instance.GetHelpIdRoadProcess();
				HelpController.Instance.OpenHelpById(helpIdRoadProcess);
			});
			if (this.NeedPlayFinishSeq)
			{
				this.FireExpPanel.RefreshExpBeforeRoadBuilt(this.OpenRoadId);
			}
		}

		// Token: 0x0602EE39 RID: 192057 RVA: 0x00D14704 File Offset: 0x00D12904
		private void SetMapMarkTraced()
		{
			InfrastructureDefine.IInfrRoadNetworkOpenParam infrRoadNetworkOpenParam = this.OpenParam as InfrastructureDefine.IInfrRoadNetworkOpenParam;
			if (infrRoadNetworkOpenParam != null && !infrRoadNetworkOpenParam.NeedPlayFinishSeq.GetValueOrDefault())
			{
				this.MapPanel.SelectMark(this.OpenDeliveryType, this.OpenRoadId);
			}
		}

		// Token: 0x0602EE3A RID: 192058 RVA: 0x00D14748 File Offset: 0x00D12948
		private void ShowBuildFinishSequence()
		{
			if (this.NeedPlayFinishSeq)
			{
				Action allFinishFunc = delegate()
				{
					if (!this.NeedPlayFinishSeq)
					{
						return;
					}
					this.NeedPlayFinishSeq = false;
					UUITexture texture2 = this.GetTexture(11);
					if (texture2 != null)
					{
						texture2.SetUIActive(false);
					}
					UiManager.Instance.OpenView(EUiViewName.InfrastructureSettleView, new InfrastructureDefine.InfrSettleViewOpenParam
					{
						DeliveryType = this.OpenDeliveryType,
						RoadId = this.OpenRoadId
					}, null);
				};
				this.FireExpPanel.SetOnDigitSequenceFinishCb(allFinishFunc);
				this.MapPanel.RefreshFinishTextureLine(this.OpenRoadId);
				Action <>9__2;
				base.PlaySequence("Finish", delegate
				{
					InfrRoadNetworkMapPanel mapPanel = this.MapPanel;
					ActionInfrastructureItemDeliveryType openDeliveryType = this.OpenDeliveryType;
					int openRoadId = this.OpenRoadId;
					Action onFinishPlayEnd;
					if ((onFinishPlayEnd = <>9__2) == null)
					{
						onFinishPlayEnd = (<>9__2 = delegate()
						{
							if (!this.FireExpPanel.UpdateExp())
							{
								allFinishFunc();
							}
						});
					}
					mapPanel.ShowMarkFinishSeq(openDeliveryType, openRoadId, onFinishPlayEnd);
				}, false);
				return;
			}
			UUITexture texture = base.GetTexture(11);
			if (texture == null)
			{
				return;
			}
			texture.SetUIActive(false);
		}

		// Token: 0x0602EE3B RID: 192059 RVA: 0x00D147CC File Offset: 0x00D129CC
		private void RefreshMapInitialParam()
		{
			float value = ConfigCommonParamById.GetFloatConfig("InfrRoadNetworkMapDefaultSize").Value;
			IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("InfrRoadNetworkMapDefaultPos");
			this.PreScale = (double)value;
			this.PreOffset = new Tuple<double, double>((double)intArrayConfig[0], (double)intArrayConfig[1]);
			if (!this.NeedPlayFinishSeq)
			{
				this.MoveComponent.SetScale((double)value, ESetScaleSource.Other, null);
				this.MoveComponent.MoveToTarget(new double[]
				{
					(double)intArrayConfig[0],
					(double)intArrayConfig[1]
				}, LTweenEase.Linear, 0.0, null);
				return;
			}
			Tuple<float, float> tuple;
			if (this.OpenDeliveryType == ActionInfrastructureItemDeliveryType.Road)
			{
				tuple = this.MapPanel.GetMarkUiPosition(this.OpenRoadId);
			}
			else
			{
				tuple = this.MapPanel.GetObservatoryMarkUiPosition();
			}
			float? floatConfig = ConfigCommonParamById.GetFloatConfig("InfrRoadNetworkFoaclScale");
			this.MoveComponent.SetScale((double)floatConfig.Value, ESetScaleSource.Other, null);
			this.MoveComponent.MoveToTarget(new double[]
			{
				(double)tuple.Item1,
				(double)tuple.Item2
			}, LTweenEase.Linear, 0.0, null);
		}

		// Token: 0x0602EE3C RID: 192060 RVA: 0x00D148E0 File Offset: 0x00D12AE0
		private void RefreshPartUiVisible()
		{
			this.Caption.SetUiActive(!this.ShowInfoPanel);
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(!this.ShowInfoPanel);
			}
			UUIButtonComponent button = base.GetButton(15);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(this.ShowInfoPanel);
			}
			if (this.ShowInfoPanel && !UiManager.Instance.IsViewOpen(EUiViewName.InfrRoadNetworkInfoView))
			{
				UiManager.Instance.OpenView(EUiViewName.InfrRoadNetworkInfoView, new InfrastructureDefine.InfrRoadNetworkInfoOpenParam
				{
					InfoParam = this.SelectedParam,
					BuildCb = delegate
					{
						this.OnClickBtnBuild();
					},
					CloseCb = delegate
					{
						this.CheckInfoPanel(null);
					}
				}, delegate(bool isSuccess, int viewId)
				{
					if (isSuccess)
					{
						base.AddChildViewById(viewId);
					}
				});
			}
		}

		// Token: 0x0602EE3D RID: 192061 RVA: 0x00D149AB File Offset: 0x00D12BAB
		protected override void OnBeforeDestroy()
		{
			this.MoveComponent.Destroy();
			if (this.TimerId != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimerId);
				this.TimerId = null;
			}
		}

		// Token: 0x0602EE3E RID: 192062 RVA: 0x00D149D8 File Offset: 0x00D12BD8
		private void OnZoomOut(float _)
		{
			this.MoveComponent.LongPressScroll((float)(-(float)this.MoveComponent.ScaleStep));
		}

		// Token: 0x0602EE3F RID: 192063 RVA: 0x00D149F2 File Offset: 0x00D12BF2
		private void OnZoomIn(float _)
		{
			this.MoveComponent.LongPressScroll((float)this.MoveComponent.ScaleStep);
		}

		// Token: 0x0602EE40 RID: 192064 RVA: 0x00D14A0B File Offset: 0x00D12C0B
		private void OnSliderValueChange(float value)
		{
			this.MoveComponent.SliderScroll(value);
		}

		// Token: 0x0602EE41 RID: 192065 RVA: 0x00D14A19 File Offset: 0x00D12C19
		private void OnChangeSlider(ESetScaleSource source)
		{
			UUISliderComponent slider = base.GetSlider(7);
			if (slider != null)
			{
				slider.SetValue((float)this.MoveComponent.MapScale, true);
			}
			this.MapPanel.RefreshMarkScale((float)this.MoveComponent.MapScale);
		}

		// Token: 0x0602EE42 RID: 192066 RVA: 0x00D14A54 File Offset: 0x00D12C54
		private void CheckInfoPanel(ULGUIPointerEventData data)
		{
			if (this.ShowInfoPanel)
			{
				this.ShowInfoPanel = false;
				this.SelectedParam = null;
				UiManager.Instance.CloseView(EUiViewName.InfrRoadNetworkInfoView, null);
				this.MapPanel.DeselectMark();
				base.PlaySequence("ShowView", null, false);
				float value = ConfigCommonParamById.GetFloatConfig("InfrRoadNetworkFocalTime").Value;
				this.MoveComponent.ScaleToTarget(this.PreScale, new float[]
				{
					(float)this.PreOffset.Item1,
					(float)this.PreOffset.Item2
				}, LTweenEase.Linear, value, ETweenScaleType.Normal, null);
			}
			FVector2D anchorOffset = this.MapPanel.GetRootItem().GetAnchorOffset();
			this.PreOffset = new Tuple<double, double>((double)(-(double)anchorOffset.X) / this.PreScale, (double)(-(double)anchorOffset.Y) / this.PreScale);
			this.RefreshPartUiVisible();
		}

		// Token: 0x0602EE43 RID: 192067 RVA: 0x00D14B30 File Offset: 0x00D12D30
		private void OnSelectMark(InfrastructureDefine.IInfrMaterialsDeliveryOpenParam param)
		{
			if (this.SelectedParam == null)
			{
				base.PlaySequence("SweepCarrier", null, false);
			}
			this.SelectedParam = param;
			this.ShowInfoPanel = true;
			InfrastructureDefine.InfrRoadNetworkInfoOpenParam infrRoadNetworkInfoOpenParam = new InfrastructureDefine.InfrRoadNetworkInfoOpenParam
			{
				InfoParam = param,
				BuildCb = delegate
				{
					this.OnClickBtnBuild();
				},
				CloseCb = delegate
				{
					this.CheckInfoPanel(null);
				}
			};
			if (!UiManager.Instance.IsViewOpen(EUiViewName.InfrRoadNetworkInfoView))
			{
				UiManager.Instance.OpenView(EUiViewName.InfrRoadNetworkInfoView, infrRoadNetworkInfoOpenParam, delegate(bool isSuccess, int viewId)
				{
					if (isSuccess)
					{
						base.AddChildViewById(viewId);
					}
				});
			}
			else
			{
				EventSystem.Instance.Emit<InfrastructureDefine.IInfrRoadNetworkInfoOpenParam>(EEventName.InfrastructureSelectRoadNetworkMark, infrRoadNetworkInfoOpenParam);
			}
			this.PreScale = this.MoveComponent.MapScale;
			FVector2D anchorOffset = this.MapPanel.GetRootItem().GetAnchorOffset();
			this.PreOffset = new Tuple<double, double>((double)(-(double)anchorOffset.X) / this.PreScale, (double)(-(double)anchorOffset.Y) / this.PreScale);
			float value = ConfigCommonParamById.GetFloatConfig("InfrRoadNetworkFocalTime").Value;
			Tuple<float, float> tuple;
			if (param.DeliveryType == ActionInfrastructureItemDeliveryType.Road)
			{
				tuple = this.MapPanel.GetMarkUiPosition(param.RoadId);
			}
			else
			{
				tuple = this.MapPanel.GetObservatoryMarkUiPosition();
			}
			UUIItem item = base.GetItem(12);
			FVector? fvector = (item != null) ? new FVector?(item.GetUIWorldPosition()) : null;
			float value2 = ConfigCommonParamById.GetFloatConfig("InfrRoadNetworkFoaclScale").Value;
			tuple = new Tuple<float, float>(tuple.Item1 - fvector.Value.X / value2, tuple.Item2 - fvector.Value.Y / value2);
			this.MoveComponent.ScaleToTarget((double)value2, new float[]
			{
				tuple.Item1,
				tuple.Item2
			}, LTweenEase.Linear, value, ETweenScaleType.PreventOverScaling, null);
			this.RefreshPartUiVisible();
		}

		// Token: 0x0602EE44 RID: 192068 RVA: 0x00D14CF8 File Offset: 0x00D12EF8
		private void OnNoticeUpdate(IReadOnlyList<InfrastructureDefine.InfrNoticeData> notices)
		{
			if (notices.Count != 0)
			{
				UUIText text = base.GetText(10);
				if (text != null)
				{
					text.SetUIActive(true);
				}
				InfrastructureDefine.InfrNoticeData infrNoticeData = notices[0];
				for (int i = 1; i < notices.Count; i++)
				{
					if (notices[i].CreateTime > infrNoticeData.CreateTime)
					{
						infrNoticeData = notices[i];
					}
				}
				InfrPasser? infrPasserConfigById = InfrastructureConfig.Instance.GetInfrPasserConfigById(infrNoticeData.PasserId);
				InfrRoadBuild? roadConfigById = InfrastructureConfig.Instance.GetRoadConfigById(infrNoticeData.RoadId);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(8), "BuildRoad_InfrPasser", new <>z__ReadOnlyArray<object>(new object[]
				{
					new TableTextArgNew(infrPasserConfigById.Value.Name, Array.Empty<object>()),
					new TableTextArgNew(roadConfigById.Value.Name, Array.Empty<object>()),
					infrNoticeData.GiftCount
				}));
				return;
			}
			UUIText text2 = base.GetText(8);
			if (text2 != null)
			{
				text2.ShowTextNew("BuildRoadNet_SmsNotReceived");
			}
			UUIText text3 = base.GetText(10);
			if (text3 == null)
			{
				return;
			}
			text3.SetUIActive(false);
		}

		// Token: 0x0602EE45 RID: 192069 RVA: 0x00D14E0C File Offset: 0x00D1300C
		private UniTask OnClickBtnBuild()
		{
			InfrRoadNetworkMainView.<OnClickBtnBuild>d__44 <OnClickBtnBuild>d__;
			<OnClickBtnBuild>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnClickBtnBuild>d__.<>4__this = this;
			<OnClickBtnBuild>d__.<>1__state = -1;
			<OnClickBtnBuild>d__.<>t__builder.Start<InfrRoadNetworkMainView.<OnClickBtnBuild>d__44>(ref <OnClickBtnBuild>d__);
			return <OnClickBtnBuild>d__.<>t__builder.Task;
		}

		// Token: 0x0602EE46 RID: 192070 RVA: 0x00D14E4F File Offset: 0x00D1304F
		private void OnTraceRoadUpdate()
		{
			this.MapPanel.RefreshAllMarks();
		}

		// Token: 0x0602EE47 RID: 192071 RVA: 0x00D14E5C File Offset: 0x00D1305C
		private void OnClickMask()
		{
			this.CheckInfoPanel(null);
		}

		// Token: 0x0602EE48 RID: 192072 RVA: 0x00D14E65 File Offset: 0x00D13065
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams.Length == 0)
			{
				return null;
			}
			if (!(configParams[0] == "RoadMark"))
			{
				return null;
			}
			InfrRoadNetworkMapPanel mapPanel = this.MapPanel;
			if (mapPanel == null)
			{
				return null;
			}
			return mapPanel.GetGuideUiItemAndUiItemForShowEx(configParams);
		}

		// Token: 0x04018DEF RID: 101871
		private readonly PopupCaptionItem Caption = new PopupCaptionItem(null);

		// Token: 0x04018DF0 RID: 101872
		private readonly InfrRoadNetworkMapPanel MapPanel = new InfrRoadNetworkMapPanel();

		// Token: 0x04018DF1 RID: 101873
		private readonly InfrastructureFireExpPanel FireExpPanel = new InfrastructureFireExpPanel();

		// Token: 0x04018DF2 RID: 101874
		private InfrastructureDefine.IInfrMaterialsDeliveryOpenParam SelectedParam;

		// Token: 0x04018DF3 RID: 101875
		private BuildingMapMoveComponent MoveComponent;

		// Token: 0x04018DF4 RID: 101876
		protected LongPressButton ZoomIn;

		// Token: 0x04018DF5 RID: 101877
		protected LongPressButton ZoomOut;

		// Token: 0x04018DF6 RID: 101878
		private bool ShowInfoPanel;

		// Token: 0x04018DF7 RID: 101879
		private TimerHandle TimerId;

		// Token: 0x04018DF8 RID: 101880
		private ActionInfrastructureItemDeliveryType OpenDeliveryType = ActionInfrastructureItemDeliveryType.Road;

		// Token: 0x04018DF9 RID: 101881
		private int OpenRoadId;

		// Token: 0x04018DFA RID: 101882
		private bool NeedPlayFinishSeq;

		// Token: 0x04018DFB RID: 101883
		private double PreScale = 1.0;

		// Token: 0x04018DFC RID: 101884
		private Tuple<double, double> PreOffset = new Tuple<double, double>(0.0, 0.0);

		// Token: 0x0200A5BF RID: 42431
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04033473 RID: 210035
			public const int ItemCaption = 0;

			// Token: 0x04033474 RID: 210036
			public const int PanelMapRoot = 1;

			// Token: 0x04033475 RID: 210037
			public const int PanelViewRoot = 2;

			// Token: 0x04033476 RID: 210038
			public const int PanelUi = 3;

			// Token: 0x04033477 RID: 210039
			public const int FireExpPanel = 4;

			// Token: 0x04033478 RID: 210040
			public const int BtnAdd = 5;

			// Token: 0x04033479 RID: 210041
			public const int BtnReduce = 6;

			// Token: 0x0403347A RID: 210042
			public const int SliderScaleCtrl = 7;

			// Token: 0x0403347B RID: 210043
			public const int TextInfo = 8;

			// Token: 0x0403347C RID: 210044
			public const int MapItem = 9;

			// Token: 0x0403347D RID: 210045
			public const int TextTips = 10;

			// Token: 0x0403347E RID: 210046
			public const int TextureMask = 11;

			// Token: 0x0403347F RID: 210047
			public const int PanelPos = 12;

			// Token: 0x04033480 RID: 210048
			public const int PanelMsgLayout = 13;

			// Token: 0x04033481 RID: 210049
			public const int MsgItem = 14;

			// Token: 0x04033482 RID: 210050
			public const int BtnMask = 15;
		}
	}
}
