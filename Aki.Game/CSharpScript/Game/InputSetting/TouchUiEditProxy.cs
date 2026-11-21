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
	// Token: 0x0200619E RID: 24990
	[NullableContext(1)]
	[Nullable(0)]
	public class TouchUiEditProxy
	{
		// Token: 0x170070FD RID: 28925
		// (get) Token: 0x0603BF50 RID: 245584 RVA: 0x0110829A File Offset: 0x0110649A
		[Nullable(2)]
		private ITouchUiEditItem CurrentSelectedItem
		{
			[NullableContext(2)]
			get
			{
				return TouchUiEditViewModel.GetCurrentSelectedItem();
			}
		}

		// Token: 0x0603BF51 RID: 245585 RVA: 0x011082A1 File Offset: 0x011064A1
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

		// Token: 0x0603BF52 RID: 245586 RVA: 0x011082D4 File Offset: 0x011064D4
		public void SetView(ITouchUiEditView view)
		{
			this.View = view;
		}

		// Token: 0x0603BF53 RID: 245587 RVA: 0x011082E0 File Offset: 0x011064E0
		public UniTask OnBeforeStartAsync()
		{
			TouchUiEditProxy.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TouchUiEditProxy.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603BF54 RID: 245588 RVA: 0x01108324 File Offset: 0x01106524
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

		// Token: 0x0603BF55 RID: 245589 RVA: 0x01108504 File Offset: 0x01106704
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

		// Token: 0x0603BF56 RID: 245590 RVA: 0x01108584 File Offset: 0x01106784
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

		// Token: 0x0603BF57 RID: 245591 RVA: 0x011085EE File Offset: 0x011067EE
		public void SetOffsetDeltaX(int offset)
		{
			this.OffsetDeltaX = offset;
		}

		// Token: 0x0603BF58 RID: 245592 RVA: 0x011085F7 File Offset: 0x011067F7
		public void SetOffsetDeltaY(int offset)
		{
			this.OffsetDeltaY = offset;
		}

		// Token: 0x0603BF59 RID: 245593 RVA: 0x01108600 File Offset: 0x01106800
		public void SetScale(float scale)
		{
			ITouchUiEditItem currentSelectedItem = this.CurrentSelectedItem;
			if (currentSelectedItem == null)
			{
				return;
			}
			currentSelectedItem.SetScale(scale);
		}

		// Token: 0x0603BF5A RID: 245594 RVA: 0x01108613 File Offset: 0x01106813
		public void SetAlpha(float alpha)
		{
			ITouchUiEditItem currentSelectedItem = this.CurrentSelectedItem;
			if (currentSelectedItem == null)
			{
				return;
			}
			currentSelectedItem.SetAlpha(alpha);
		}

		// Token: 0x0603BF5B RID: 245595 RVA: 0x01108626 File Offset: 0x01106826
		public void SetHierarchyIndex(int index)
		{
			ITouchUiEditItem currentSelectedItem = this.CurrentSelectedItem;
			if (currentSelectedItem == null)
			{
				return;
			}
			currentSelectedItem.SetHierarchyIndex(index);
		}

		// Token: 0x0603BF5C RID: 245596 RVA: 0x0110863C File Offset: 0x0110683C
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

		// Token: 0x0603BF5D RID: 245597 RVA: 0x011086A0 File Offset: 0x011068A0
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

		// Token: 0x0603BF5E RID: 245598 RVA: 0x0110877C File Offset: 0x0110697C
		public void ResetEditData()
		{
			this.DataFacade.ResetEditData();
		}

		// Token: 0x0603BF5F RID: 245599 RVA: 0x0110878C File Offset: 0x0110698C
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

		// Token: 0x0603BF60 RID: 245600 RVA: 0x011087EC File Offset: 0x011069EC
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

		// Token: 0x0603BF61 RID: 245601 RVA: 0x011088C0 File Offset: 0x01106AC0
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

		// Token: 0x0603BF62 RID: 245602 RVA: 0x0110895F File Offset: 0x01106B5F
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

		// Token: 0x0603BF63 RID: 245603 RVA: 0x01108989 File Offset: 0x01106B89
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

		// Token: 0x0603BF64 RID: 245604 RVA: 0x011089B8 File Offset: 0x01106BB8
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

		// Token: 0x0603BF65 RID: 245605 RVA: 0x011089E8 File Offset: 0x01106BE8
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

		// Token: 0x0603BF66 RID: 245606 RVA: 0x01108AD0 File Offset: 0x01106CD0
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

		// Token: 0x0401FAEA RID: 129770
		[Nullable(2)]
		private ITouchUiEditView View;

		// Token: 0x0401FAEB RID: 129771
		private readonly Dictionary<int, ITouchUiEditItem> EditableItemMap = new Dictionary<int, ITouchUiEditItem>();

		// Token: 0x0401FAEC RID: 129772
		private readonly List<ITouchUiEditItem> AllItemList = new List<ITouchUiEditItem>();

		// Token: 0x0401FAED RID: 129773
		private int OffsetDeltaX;

		// Token: 0x0401FAEE RID: 129774
		private int OffsetDeltaY;

		// Token: 0x0401FAEF RID: 129775
		private readonly ITouchUiEditContainer Container;

		// Token: 0x0401FAF0 RID: 129776
		private readonly ITouchUiEditDataFacade DataFacade;

		// Token: 0x0401FAF1 RID: 129777
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
