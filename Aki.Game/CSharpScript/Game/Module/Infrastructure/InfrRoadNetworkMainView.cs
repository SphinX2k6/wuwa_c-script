using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x0200591F RID: 22815
	[NullableContext(1)]
	[Nullable(0)]
	public class InfrRoadNetworkMainView : UiViewBase
	{
		// Token: 0x06039F05 RID: 237317 RVA: 0x00DC4D10 File Offset: 0x00DC2F10
		public InfrRoadNetworkMainView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06039F06 RID: 237318 RVA: 0x00DC4D7C File Offset: 0x00DC2F7C
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

		// Token: 0x06039F07 RID: 237319 RVA: 0x00DC4FF9 File Offset: 0x00DC31F9
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<IReadOnlyList<InfrastructureDefine.InfrNoticeData>>(EEventName.InfrastructureRoadNoticeUpdate, new Action<IReadOnlyList<InfrastructureDefine.InfrNoticeData>>(this.OnNoticeUpdate));
			EventSystem.Instance.Add(EEventName.InfrastructureTraceRoadUpdate, new Action(this.OnTraceRoadUpdate));
		}

		// Token: 0x06039F08 RID: 237320 RVA: 0x00DC5033 File Offset: 0x00DC3233
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<IReadOnlyList<InfrastructureDefine.InfrNoticeData>>(EEventName.InfrastructureRoadNoticeUpdate, new Action<IReadOnlyList<InfrastructureDefine.InfrNoticeData>>(this.OnNoticeUpdate));
			EventSystem.Instance.Remove(EEventName.InfrastructureTraceRoadUpdate, new Action(this.OnTraceRoadUpdate));
		}

		// Token: 0x06039F09 RID: 237321 RVA: 0x00DC5070 File Offset: 0x00DC3270
		protected override UniTask OnBeforeStartAsync()
		{
			InfrRoadNetworkMainView.<OnBeforeStartAsync>d__19 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<InfrRoadNetworkMainView.<OnBeforeStartAsync>d__19>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039F0A RID: 237322 RVA: 0x00DC50B4 File Offset: 0x00DC32B4
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

		// Token: 0x06039F0B RID: 237323 RVA: 0x00DC50F4 File Offset: 0x00DC32F4
		private UniTask CreateCaption()
		{
			InfrRoadNetworkMainView.<CreateCaption>d__21 <CreateCaption>d__;
			<CreateCaption>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateCaption>d__.<>4__this = this;
			<CreateCaption>d__.<>1__state = -1;
			<CreateCaption>d__.<>t__builder.Start<InfrRoadNetworkMainView.<CreateCaption>d__21>(ref <CreateCaption>d__);
			return <CreateCaption>d__.<>t__builder.Task;
		}

		// Token: 0x06039F0C RID: 237324 RVA: 0x00DC5138 File Offset: 0x00DC3338
		private UniTask CreateMapPanel()
		{
			InfrRoadNetworkMainView.<CreateMapPanel>d__22 <CreateMapPanel>d__;
			<CreateMapPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateMapPanel>d__.<>4__this = this;
			<CreateMapPanel>d__.<>1__state = -1;
			<CreateMapPanel>d__.<>t__builder.Start<InfrRoadNetworkMainView.<CreateMapPanel>d__22>(ref <CreateMapPanel>d__);
			return <CreateMapPanel>d__.<>t__builder.Task;
		}

		// Token: 0x06039F0D RID: 237325 RVA: 0x00DC517C File Offset: 0x00DC337C
		private UniTask CreateFireExpItem()
		{
			InfrRoadNetworkMainView.<CreateFireExpItem>d__23 <CreateFireExpItem>d__;
			<CreateFireExpItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateFireExpItem>d__.<>4__this = this;
			<CreateFireExpItem>d__.<>1__state = -1;
			<CreateFireExpItem>d__.<>t__builder.Start<InfrRoadNetworkMainView.<CreateFireExpItem>d__23>(ref <CreateFireExpItem>d__);
			return <CreateFireExpItem>d__.<>t__builder.Task;
		}

		// Token: 0x06039F0E RID: 237326 RVA: 0x00DC51C0 File Offset: 0x00DC33C0
		private UniTask RefreshCaption()
		{
			InfrRoadNetworkMainView.<RefreshCaption>d__24 <RefreshCaption>d__;
			<RefreshCaption>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshCaption>d__.<>4__this = this;
			<RefreshCaption>d__.<>1__state = -1;
			<RefreshCaption>d__.<>t__builder.Start<InfrRoadNetworkMainView.<RefreshCaption>d__24>(ref <RefreshCaption>d__);
			return <RefreshCaption>d__.<>t__builder.Task;
		}

		// Token: 0x06039F0F RID: 237327 RVA: 0x00DC5203 File Offset: 0x00DC3403
		protected override void OnStart()
		{
			this.CreateMoveComponent();
			this.RefreshFireExpItem();
			this.InitZoom();
			this.OnNoticeUpdate(new List<InfrastructureDefine.InfrNoticeData>());
			this.RefreshMapInitialParam();
		}

		// Token: 0x06039F10 RID: 237328 RVA: 0x00DC5228 File Offset: 0x00DC3428
		protected override void OnBeforeShow()
		{
			this.MapPanel.RefreshMarkScale((float)this.MoveComponent.MapScale);
			this.MoveComponent.BindTouch();
			this.MoveComponent.AddGamepadEvent();
			this.SetMapMarkTraced();
		}

		// Token: 0x06039F11 RID: 237329 RVA: 0x00DC525D File Offset: 0x00DC345D
		protected override void OnAfterHide()
		{
			this.MoveComponent.UnbindTouch();
			this.MoveComponent.RemoveGamepadEvent();
		}

		// Token: 0x06039F12 RID: 237330 RVA: 0x00DC5275 File Offset: 0x00DC3475
		protected override void OnAfterPlayStartSequence()
		{
			this.MapPanel.ShowMarkUnlock(this.NeedPlayFinishSeq, new Action(this.ShowBuildFinishSequence));
		}

		// Token: 0x06039F13 RID: 237331 RVA: 0x00DC5294 File Offset: 0x00DC3494
		private void CreateMoveComponent()
		{
			this.MoveComponent = new BuildingMapMoveComponent(base.GetDraggable(9), true, true, false);
			IReadOnlyList<float> floatArrayConfig = ConfigCommonParamById.GetFloatArrayConfig("InfrRoadNetworkMapSizeParam");
			this.MoveComponent.SetScaleSafeArea((double)floatArrayConfig[0], (double)floatArrayConfig[1]);
			this.MoveComponent.PointerBeginDragExtraCallBack = new Action<ULGUIPointerEventData>(this.CheckInfoPanel);
			this.MoveComponent.PointerUpExtraCallBack = new Action<ULGUIPointerEventData>(this.CheckInfoPanel);
			this.MoveComponent.SetChangeScaleCallback(new Action<ESetScaleSource>(this.OnChangeSlider));
		}

		// Token: 0x06039F14 RID: 237332 RVA: 0x00DC5324 File Offset: 0x00DC3524
		private void InitZoom()
		{
			UUISliderComponent slider = base.GetSlider(7);
			slider.SetMinValue((float)this.MoveComponent.MapScaleSafeArea.Min, false, false);
			slider.SetMaxValue((float)this.MoveComponent.MapScaleSafeArea.Max, false, false);
			slider.OnValueChangeCb.Bind(new Action<float>(this.OnSliderValueChange));
			this.ZoomIn = new LongPressButton(base.GetButton(5), new Action<float>(this.OnZoomIn), 100);
			this.ZoomOut = new LongPressButton(base.GetButton(6), new Action<float>(this.OnZoomOut), 100);
		}

		// Token: 0x06039F15 RID: 237333 RVA: 0x00DC53C0 File Offset: 0x00DC35C0
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

		// Token: 0x06039F16 RID: 237334 RVA: 0x00DC5410 File Offset: 0x00DC3610
		private void SetMapMarkTraced()
		{
			InfrastructureDefine.IInfrRoadNetworkOpenParam infrRoadNetworkOpenParam = this.OpenParam as InfrastructureDefine.IInfrRoadNetworkOpenParam;
			if (infrRoadNetworkOpenParam != null && !infrRoadNetworkOpenParam.NeedPlayFinishSeq.GetValueOrDefault())
			{
				this.MapPanel.SelectMark(this.OpenDeliveryType, this.OpenRoadId);
			}
		}

		// Token: 0x06039F17 RID: 237335 RVA: 0x00DC5454 File Offset: 0x00DC3654
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

		// Token: 0x06039F18 RID: 237336 RVA: 0x00DC54D8 File Offset: 0x00DC36D8
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

		// Token: 0x06039F19 RID: 237337 RVA: 0x00DC55EC File Offset: 0x00DC37EC
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

		// Token: 0x06039F1A RID: 237338 RVA: 0x00DC56B7 File Offset: 0x00DC38B7
		protected override void OnBeforeDestroy()
		{
			this.MoveComponent.Destroy();
			if (this.TimerId != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimerId);
				this.TimerId = null;
			}
		}

		// Token: 0x06039F1B RID: 237339 RVA: 0x00DC56E4 File Offset: 0x00DC38E4
		private void OnZoomOut(float _)
		{
			this.MoveComponent.LongPressScroll((float)(-(float)this.MoveComponent.ScaleStep));
		}

		// Token: 0x06039F1C RID: 237340 RVA: 0x00DC56FE File Offset: 0x00DC38FE
		private void OnZoomIn(float _)
		{
			this.MoveComponent.LongPressScroll((float)this.MoveComponent.ScaleStep);
		}

		// Token: 0x06039F1D RID: 237341 RVA: 0x00DC5717 File Offset: 0x00DC3917
		private void OnSliderValueChange(float value)
		{
			this.MoveComponent.SliderScroll(value);
		}

		// Token: 0x06039F1E RID: 237342 RVA: 0x00DC5725 File Offset: 0x00DC3925
		private void OnChangeSlider(ESetScaleSource source)
		{
			UUISliderComponent slider = base.GetSlider(7);
			if (slider != null)
			{
				slider.SetValue((float)this.MoveComponent.MapScale, true);
			}
			this.MapPanel.RefreshMarkScale((float)this.MoveComponent.MapScale);
		}

		// Token: 0x06039F1F RID: 237343 RVA: 0x00DC5760 File Offset: 0x00DC3960
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

		// Token: 0x06039F20 RID: 237344 RVA: 0x00DC583C File Offset: 0x00DC3A3C
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

		// Token: 0x06039F21 RID: 237345 RVA: 0x00DC5A04 File Offset: 0x00DC3C04
		private void OnNoticeUpdate(IReadOnlyList<InfrastructureDefine.InfrNoticeData> notices)
		{
			if (notices.Count != 0)
			{
				UUIText text = base.GetText(10);
				if (text != null)
				{
					text.SetUIActive(true);
				}
				InfrastructureDefine.InfrNoticeData infrNoticeData = (from n in notices
				orderby n.CreateTime descending
				select n).FirstOrDefault<InfrastructureDefine.InfrNoticeData>();
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

		// Token: 0x06039F22 RID: 237346 RVA: 0x00DC5B10 File Offset: 0x00DC3D10
		private UniTask OnClickBtnBuild()
		{
			InfrRoadNetworkMainView.<OnClickBtnBuild>d__44 <OnClickBtnBuild>d__;
			<OnClickBtnBuild>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnClickBtnBuild>d__.<>4__this = this;
			<OnClickBtnBuild>d__.<>1__state = -1;
			<OnClickBtnBuild>d__.<>t__builder.Start<InfrRoadNetworkMainView.<OnClickBtnBuild>d__44>(ref <OnClickBtnBuild>d__);
			return <OnClickBtnBuild>d__.<>t__builder.Task;
		}

		// Token: 0x06039F23 RID: 237347 RVA: 0x00DC5B53 File Offset: 0x00DC3D53
		private void OnTraceRoadUpdate()
		{
			this.MapPanel.RefreshAllMarks();
		}

		// Token: 0x06039F24 RID: 237348 RVA: 0x00DC5B60 File Offset: 0x00DC3D60
		private void OnClickMask()
		{
			this.CheckInfoPanel(null);
		}

		// Token: 0x06039F25 RID: 237349 RVA: 0x00DC5B69 File Offset: 0x00DC3D69
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

		// Token: 0x0401E352 RID: 123730
		private readonly PopupCaptionItem Caption = new PopupCaptionItem(null);

		// Token: 0x0401E353 RID: 123731
		private readonly InfrRoadNetworkMapPanel MapPanel = new InfrRoadNetworkMapPanel();

		// Token: 0x0401E354 RID: 123732
		private readonly InfrastructureFireExpPanel FireExpPanel = new InfrastructureFireExpPanel();

		// Token: 0x0401E355 RID: 123733
		private InfrastructureDefine.IInfrMaterialsDeliveryOpenParam SelectedParam;

		// Token: 0x0401E356 RID: 123734
		private BuildingMapMoveComponent MoveComponent;

		// Token: 0x0401E357 RID: 123735
		protected LongPressButton ZoomIn;

		// Token: 0x0401E358 RID: 123736
		protected LongPressButton ZoomOut;

		// Token: 0x0401E359 RID: 123737
		private bool ShowInfoPanel;

		// Token: 0x0401E35A RID: 123738
		private TimerHandle TimerId;

		// Token: 0x0401E35B RID: 123739
		private ActionInfrastructureItemDeliveryType OpenDeliveryType = ActionInfrastructureItemDeliveryType.Road;

		// Token: 0x0401E35C RID: 123740
		private int OpenRoadId;

		// Token: 0x0401E35D RID: 123741
		private bool NeedPlayFinishSeq;

		// Token: 0x0401E35E RID: 123742
		private double PreScale = 1.0;

		// Token: 0x0401E35F RID: 123743
		private Tuple<double, double> PreOffset = new Tuple<double, double>(0.0, 0.0);

		// Token: 0x0200BBAF RID: 48047
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04038A8D RID: 232077
			public const int ItemCaption = 0;

			// Token: 0x04038A8E RID: 232078
			public const int PanelMapRoot = 1;

			// Token: 0x04038A8F RID: 232079
			public const int PanelViewRoot = 2;

			// Token: 0x04038A90 RID: 232080
			public const int PanelUi = 3;

			// Token: 0x04038A91 RID: 232081
			public const int FireExpPanel = 4;

			// Token: 0x04038A92 RID: 232082
			public const int BtnAdd = 5;

			// Token: 0x04038A93 RID: 232083
			public const int BtnReduce = 6;

			// Token: 0x04038A94 RID: 232084
			public const int SliderScaleCtrl = 7;

			// Token: 0x04038A95 RID: 232085
			public const int TextInfo = 8;

			// Token: 0x04038A96 RID: 232086
			public const int MapItem = 9;

			// Token: 0x04038A97 RID: 232087
			public const int TextTips = 10;

			// Token: 0x04038A98 RID: 232088
			public const int TextureMask = 11;

			// Token: 0x04038A99 RID: 232089
			public const int PanelPos = 12;

			// Token: 0x04038A9A RID: 232090
			public const int PanelMsgLayout = 13;

			// Token: 0x04038A9B RID: 232091
			public const int MsgItem = 14;

			// Token: 0x04038A9C RID: 232092
			public const int BtnMask = 15;
		}
	}
}
