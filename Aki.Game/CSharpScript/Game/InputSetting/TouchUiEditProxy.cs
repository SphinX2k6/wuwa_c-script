using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x0200701D RID: 28701
	[NullableContext(1)]
	[Nullable(0)]
	public class TouchUiEditProxy
	{
		// Token: 0x17009BBD RID: 39869
		// (get) Token: 0x06045D9A RID: 286106 RVA: 0x0115DE9E File Offset: 0x0115C09E
		[Nullable(2)]
		private ITouchUiEditItem CurrentSelectedItem
		{
			[NullableContext(2)]
			get
			{
				return TouchUiEditViewModel.GetCurrentSelectedItem();
			}
		}

		// Token: 0x06045D9B RID: 286107 RVA: 0x0115DEA5 File Offset: 0x0115C0A5
		public TouchUiEditProxy(ITouchUiEditContainer container, ITouchUiEditDataFacade dataFacade, [Nullable(new byte[]
		{
			1,
			1,
			2,
			1
		})] Func<UUIItem, ITouchUiEditData, ITouchUiEditItem> itemCreator)
		{
			this.Container = container;
			this.DataFacade = dataFacade;
			this.ItemCreator = itemCreator;
		}

		// Token: 0x06045D9C RID: 286108 RVA: 0x0115DED8 File Offset: 0x0115C0D8
		public void SetView(ITouchUiEditView view)
		{
			this.View = view;
		}

		// Token: 0x06045D9D RID: 286109 RVA: 0x0115DEE4 File Offset: 0x0115C0E4
		public UniTask OnBeforeStartAsync()
		{
			TouchUiEditProxy.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TouchUiEditProxy.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06045D9E RID: 286110 RVA: 0x0115DF28 File Offset: 0x0115C128
		public void OnStart()
		{
			TouchUiEditViewModel.SetRootItem(this.Container.GetRootItem());
			string[] resIdList = this.DataFacade.GetResIdList();
			HashSet<UUIItem> hashSet = new HashSet<UUIItem>();
			CommonTouchUiEditGroup? commonTouchUiEditGroup;
			int num = (this.DataFacade.GetGroupConfig() != null) ? commonTouchUiEditGroup.GetValueOrDefault().Id : 0;
			foreach (string resId in resIdList)
			{
				IReadOnlyList<CommonTouchUiEdit> configListByPanelResId = CommonTouchUiEditConfig.Instance.GetConfigListByPanelResId(resId);
				if (configListByPanelResId != null)
				{
					foreach (CommonTouchUiEdit commonTouchUiEdit in configListByPanelResId)
					{
						if (commonTouchUiEdit.EditGroup == num)
						{
							int itemIndex = commonTouchUiEdit.ItemIndex;
							int subPanelIndex = commonTouchUiEdit.SubPanelIndex;
							UUIItem item = this.Container.GetItem(resId, itemIndex, subPanelIndex);
							if (item != null)
							{
								hashSet.Add(item);
								ITouchUiEditData data = this.DataFacade.GetData(resId, itemIndex);
								ITouchUiEditItem touchUiEditItem = this.ItemCreator(item, data);
								touchUiEditItem.SetData(data);
								int storageId = this.DataFacade.GetStorageId(resId, itemIndex);
								if (storageId != 0)
								{
									this.EditableItemMap[storageId] = touchUiEditItem;
								}
								this.AllItemList.Add(touchUiEditItem);
								ITouchUiEditData data2 = touchUiEditItem.Data;
								if (data2 != null && data2.DefaultSelect)
								{
									TouchUiEditViewModel.SetCurrentSelectedItem(touchUiEditItem);
								}
							}
						}
					}
					foreach (UUIItem uuiitem in this.Container.GetRegistryItemList(resId))
					{
						if (!hashSet.Contains(uuiitem))
						{
							ITouchUiEditItem item2 = this.ItemCreator(uuiitem, null);
							this.AllItemList.Add(item2);
						}
					}
				}
			}
			this.BindTouchEvents();
		}

		// Token: 0x06045D9F RID: 286111 RVA: 0x0115E108 File Offset: 0x0115C308
		public void OnBeforeDestroy()
		{
			this.UnBindTouchEvents();
			TouchUiEditViewModel.SetCurrentSelectedItem(null);
			foreach (ITouchUiEditItem touchUiEditItem in this.AllItemList)
			{
				touchUiEditItem.OnViewDestroy();
			}
			this.EditableItemMap.Clear();
			this.AllItemList.Clear();
			this.Container.OnViewDestroy();
		}

		// Token: 0x06045DA0 RID: 286112 RVA: 0x0115E188 File Offset: 0x0115C388
		public void OnTick(float deltaTime)
		{
			if (this.View == null)
			{
				return;
			}
			if (this.CurrentSelectedItem == null)
			{
				return;
			}
			if (this.OffsetDeltaX != 0 || this.OffsetDeltaY != 0)
			{
				this.CurrentSelectedItem.SetOffset(this.CurrentSelectedItem.Data.OffsetX + (float)this.OffsetDeltaX, this.CurrentSelectedItem.Data.OffsetY + (float)this.OffsetDeltaY);
			}
		}

		// Token: 0x06045DA1 RID: 286113 RVA: 0x0115E1F2 File Offset: 0x0115C3F2
		public void SetOffsetDeltaX(int offset)
		{
			this.OffsetDeltaX = offset;
		}

		// Token: 0x06045DA2 RID: 286114 RVA: 0x0115E1FB File Offset: 0x0115C3FB
		public void SetOffsetDeltaY(int offset)
		{
			this.OffsetDeltaY = offset;
		}

		// Token: 0x06045DA3 RID: 286115 RVA: 0x0115E204 File Offset: 0x0115C404
		public void SetScale(float scale)
		{
			ITouchUiEditItem currentSelectedItem = this.CurrentSelectedItem;
			if (currentSelectedItem == null)
			{
				return;
			}
			currentSelectedItem.SetScale(scale);
		}

		// Token: 0x06045DA4 RID: 286116 RVA: 0x0115E217 File Offset: 0x0115C417
		public void SetAlpha(float alpha)
		{
			ITouchUiEditItem currentSelectedItem = this.CurrentSelectedItem;
			if (currentSelectedItem == null)
			{
				return;
			}
			currentSelectedItem.SetAlpha(alpha);
		}

		// Token: 0x06045DA5 RID: 286117 RVA: 0x0115E22A File Offset: 0x0115C42A
		public void SetHierarchyIndex(int index)
		{
			ITouchUiEditItem currentSelectedItem = this.CurrentSelectedItem;
			if (currentSelectedItem == null)
			{
				return;
			}
			currentSelectedItem.SetHierarchyIndex(index);
		}

		// Token: 0x06045DA6 RID: 286118 RVA: 0x0115E240 File Offset: 0x0115C440
		public void Save(bool checkOverlap = true)
		{
			if (checkOverlap && this.CheckOverLap())
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.CheckOverlap);
				confirmBoxDataNew.FunctionMap[2] = delegate()
				{
					this.SaveImp();
					UiViewBase uiViewBase2 = this.View as UiViewBase;
					if (uiViewBase2 == null)
					{
						return;
					}
					uiViewBase2.CloseMe(null);
				};
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
			this.SaveImp();
			UiViewBase uiViewBase = this.View as UiViewBase;
			if (uiViewBase == null)
			{
				return;
			}
			uiViewBase.CloseMe(null);
		}

		// Token: 0x06045DA7 RID: 286119 RVA: 0x0115E2A4 File Offset: 0x0115C4A4
		public void Reset()
		{
			foreach (ITouchUiEditItem touchUiEditItem in this.EditableItemMap.Values)
			{
				ValueTuple<string, int>? resPair = this.DataFacade.GetResPair(touchUiEditItem.Data.StorageId);
				if (resPair != null)
				{
					ValueTuple<string, int> value = resPair.Value;
					string item = value.Item1;
					int item2 = value.Item2;
					ITouchUiEditData defaultData = this.DataFacade.GetDefaultData(item, item2);
					if (defaultData != null)
					{
						touchUiEditItem.SetScale(defaultData.Scale);
						touchUiEditItem.SetOffset(defaultData.OffsetX, defaultData.OffsetY);
						touchUiEditItem.SetAlpha(defaultData.Alpha);
						touchUiEditItem.SetHierarchyIndex(defaultData.HierarchyIndex);
					}
				}
			}
		}

		// Token: 0x06045DA8 RID: 286120 RVA: 0x0115E380 File Offset: 0x0115C580
		public void ResetEditData()
		{
			this.DataFacade.ResetEditData();
		}

		// Token: 0x06045DA9 RID: 286121 RVA: 0x0115E390 File Offset: 0x0115C590
		public bool IsEdited()
		{
			using (Dictionary<int, ITouchUiEditItem>.ValueCollection.Enumerator enumerator = this.EditableItemMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsEdited())
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06045DAA RID: 286122 RVA: 0x0115E3F0 File Offset: 0x0115C5F0
		private void SaveImp()
		{
			List<ITouchUiEditData> list = new List<ITouchUiEditData>();
			foreach (ITouchUiEditItem touchUiEditItem in this.EditableItemMap.Values)
			{
				list.Add(touchUiEditItem.Data);
			}
			this.DataFacade.SaveData(list.ToArray());
			CommonTouchUiEditGroup? commonTouchUiEditGroup;
			int num = (this.DataFacade.GetGroupConfig() != null) ? commonTouchUiEditGroup.GetValueOrDefault().Id : 0;
			if (num == 0)
			{
				Log.Instance.Error(ELogModule.TouchUiEdit, ELogAuthor.TZJ, "保存改键数据出错，分组Id无效", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			EventSystem.Instance.Emit<ECommonTouchUiEditGroup>(EEventName.OnTouchUiEditSave, (ECommonTouchUiEditGroup)num);
		}

		// Token: 0x06045DAB RID: 286123 RVA: 0x0115E4C4 File Offset: 0x0115C6C4
		private bool CheckOverLap()
		{
			for (int i = 0; i < this.AllItemList.Count; i++)
			{
				ITouchUiEditItem touchUiEditItem = this.AllItemList[i];
				ITouchUiEditData data = touchUiEditItem.Data;
				if (data != null && data.ShouldCheckOverlap && touchUiEditItem.RootItem.IsUIActiveInHierarchy() && touchUiEditItem.RootItem.IsRaycastTarget())
				{
					for (int j = i + 1; j < this.AllItemList.Count; j++)
					{
						ITouchUiEditItem touchUiEditItem2 = this.AllItemList[j];
						if (touchUiEditItem.RootItem.GetOverlapWith(touchUiEditItem2.RootItem))
						{
							return true;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x06045DAC RID: 286124 RVA: 0x0115E563 File Offset: 0x0115C763
		private void BindTouchEvents()
		{
			InputDistributeController.Instance.BindTouches(new int[]
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
				9
			}, new TInputHandle<InputDistributeDefine.ITouchData>(this.OnTouch));
		}

		// Token: 0x06045DAD RID: 286125 RVA: 0x0115E58D File Offset: 0x0115C78D
		private void UnBindTouchEvents()
		{
			InputDistributeController.Instance.UnBindTouches(new <>z__ReadOnlyArray<int>(new int[]
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
				9
			}), new TInputHandle<InputDistributeDefine.ITouchData>(this.OnTouch));
		}

		// Token: 0x06045DAE RID: 286126 RVA: 0x0115E5BC File Offset: 0x0115C7BC
		private void OnTouchTrigger(bool bPress, int touchId)
		{
			TouchFingerData touchFingerData = TouchFingerManager.Instance.GetTouchFingerData((EFingerIndex)touchId);
			if (touchFingerData == null)
			{
				return;
			}
			if (bPress)
			{
				TouchUiEditViewModel.AddTouchFingerData(touchFingerData);
				return;
			}
			TouchUiEditViewModel.RemoveTouchFingerData(touchFingerData);
		}

		// Token: 0x06045DAF RID: 286127 RVA: 0x0115E5EC File Offset: 0x0115C7EC
		private void OnTouchMove(int touchId)
		{
			if (this.CurrentSelectedItem == null)
			{
				return;
			}
			if (TouchUiEditViewModel.GetTouchFingerDataCount() < 2)
			{
				return;
			}
			TouchFingerData touchFingerData = TouchUiEditViewModel.GetTouchFingerData(0);
			TouchFingerData touchFingerData2 = TouchUiEditViewModel.GetTouchFingerData(1);
			EFingerIndex fingerIndex = touchFingerData.GetFingerIndex();
			EFingerIndex fingerIndex2 = touchFingerData2.GetFingerIndex();
			float fingerExpandCloseValue = TouchFingerManager.Instance.GetFingerExpandCloseValue(fingerIndex, fingerIndex2);
			float num = MathUtils.Instance.RangeClamp(fingerExpandCloseValue, (float)this.DataFacade.MinTouchMoveDifference, (float)this.DataFacade.MaxTouchMoveDifference, this.DataFacade.MinTouchMoveValue, this.DataFacade.MaxTouchMoveValue);
			float num2 = this.CurrentSelectedItem.Data.Scale + num * this.DataFacade.ControlScaleRate;
			UUISliderComponent scaleSlider = this.View.GetScaleSlider();
			float scale = num2;
			if (scaleSlider != null)
			{
				float minValue = scaleSlider.MinValue;
				float maxValue = scaleSlider.MaxValue;
				scale = MathUtils.Instance.Clamp(num2, minValue, maxValue);
			}
			this.CurrentSelectedItem.SetScale(scale);
		}

		// Token: 0x06045DB0 RID: 286128 RVA: 0x0115E6D4 File Offset: 0x0115C8D4
		private void OnTouch(string touchIdName, InputDistributeDefine.ITouchData touchData, InputIdentification inputIdentification)
		{
			InputDistributeDefine.ETouchType touchType = touchData.TouchType;
			int touchId = int.Parse(touchIdName);
			switch (touchType)
			{
			case InputDistributeDefine.ETouchType.TouchBegin:
				this.OnTouchTrigger(true, touchId);
				return;
			case InputDistributeDefine.ETouchType.TouchEnd:
				this.OnTouchTrigger(false, touchId);
				return;
			case InputDistributeDefine.ETouchType.TouchMove:
				this.OnTouchMove(touchId);
				return;
			default:
				return;
			}
		}

		// Token: 0x04024834 RID: 149556
		[Nullable(2)]
		private ITouchUiEditView View;

		// Token: 0x04024835 RID: 149557
		private readonly Dictionary<int, ITouchUiEditItem> EditableItemMap = new Dictionary<int, ITouchUiEditItem>();

		// Token: 0x04024836 RID: 149558
		private readonly List<ITouchUiEditItem> AllItemList = new List<ITouchUiEditItem>();

		// Token: 0x04024837 RID: 149559
		private int OffsetDeltaX;

		// Token: 0x04024838 RID: 149560
		private int OffsetDeltaY;

		// Token: 0x04024839 RID: 149561
		private readonly ITouchUiEditContainer Container;

		// Token: 0x0402483A RID: 149562
		private readonly ITouchUiEditDataFacade DataFacade;

		// Token: 0x0402483B RID: 149563
		[Nullable(new byte[]
		{
			1,
			1,
			2,
			1
		})]
		private readonly Func<UUIItem, ITouchUiEditData, ITouchUiEditItem> ItemCreator;
	}
}
