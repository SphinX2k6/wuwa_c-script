using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ResManager;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.DiffPatch.Update;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002AB0 RID: 10928
[NullableContext(1)]
[Nullable(0)]
public class SubPackageDownLoadView : UiViewBase
{
	// Token: 0x06016C04 RID: 93188 RVA: 0x005C6145 File Offset: 0x005C4345
	public SubPackageDownLoadView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06016C05 RID: 93189 RVA: 0x005C6170 File Offset: 0x005C4370
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(3, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(4, typeof(UUIDynScrollViewComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIText)),
			new ValueTuple<int, Type>(10, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(5, new Action(this.OnStartBtnClick)),
			new ValueTuple<int, Delegate>(3, new Action<EToggleState>(this.OnClickMobileDataToggle))
		};
	}

	// Token: 0x06016C06 RID: 93190 RVA: 0x005C62B8 File Offset: 0x005C44B8
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnRefreshSubPackDownLoadState, new Action(this.OnRefreshSubPackDownLoadState));
		EventSystem.Instance.Add(EEventName.OnRefreshSubPackageDownLoadByPriority, new Action(this.OnRefreshSubPackageDownLoadByPriority));
		EventSystem.Instance.Add(EEventName.OnRefreshSubPackUseCellData, new Action(this.OnRefreshSubPackUseCellData));
	}

	// Token: 0x06016C07 RID: 93191 RVA: 0x005C631C File Offset: 0x005C451C
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnRefreshSubPackageDownLoadByPriority, new Action(this.OnRefreshSubPackageDownLoadByPriority));
		EventSystem.Instance.Remove(EEventName.OnRefreshSubPackDownLoadState, new Action(this.OnRefreshSubPackDownLoadState));
		EventSystem.Instance.Remove(EEventName.OnRefreshSubPackUseCellData, new Action(this.OnRefreshSubPackUseCellData));
	}

	// Token: 0x06016C08 RID: 93192 RVA: 0x005C6380 File Offset: 0x005C4580
	protected override UniTask OnBeforeStartAsync()
	{
		SubPackageDownLoadView.<OnBeforeStartAsync>d__20 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SubPackageDownLoadView.<OnBeforeStartAsync>d__20>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06016C09 RID: 93193 RVA: 0x005C63C4 File Offset: 0x005C45C4
	protected override void OnStart()
	{
		SubPackageDownLoadModel.Instance.UpdaterDownLoadSize();
		SubPackageDownLoadModel.Instance.UpdaterFinishState();
		ResourceManagerController.Instance.ChangeHttpTickFrequency();
		bool player = LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.SubDownLoadAgreeUseCellData, false);
		base.GetExtendToggle(3).SetToggleState(player ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		SubPackageDownLoadViewOpenData param = this.OpenParam as SubPackageDownLoadViewOpenData;
		List<int> subPackageList = new List<int>();
		SubPackageDownLoadViewOpenData param2 = param;
		if (((param2 != null) ? param2.SubPackageIdList : null) != null)
		{
			for (int i = 0; i < param.SubPackageIdList.Length; i++)
			{
				int num = param.SubPackageIdList[i];
				if (num != 0)
				{
					subPackageList.Add(num);
				}
			}
		}
		List<int> data = new List<int>
		{
			0,
			1
		};
		GenericLayout<SubPackageTab, int> tabScrollview = this.TabScrollview;
		if (tabScrollview != null)
		{
			tabScrollview.RefreshByData(data, delegate
			{
				if (param != null && subPackageList.Count > 0)
				{
					for (int j = 0; j < subPackageList.Count; j++)
					{
						int num3 = subPackageList[j];
						if (num3 != 0)
						{
							DownLoadSubPackage? downLoadSubPackageById = SubPackageConfig.Instance.GetDownLoadSubPackageById(num3);
							if (downLoadSubPackageById != null && downLoadSubPackageById.Value.Type == 4)
							{
								GenericLayout<SubPackageTab, int> tabScrollview2 = this.TabScrollview;
								if (tabScrollview2 == null)
								{
									return;
								}
								SubPackageTab layoutItemByIndex = tabScrollview2.GetLayoutItemByIndex(1);
								if (layoutItemByIndex == null)
								{
									return;
								}
								layoutItemByIndex.SelectToggle();
								return;
							}
						}
					}
				}
				GenericLayout<SubPackageTab, int> tabScrollview3 = this.TabScrollview;
				if (tabScrollview3 == null)
				{
					return;
				}
				SubPackageTab layoutItemByIndex2 = tabScrollview3.GetLayoutItemByIndex(0);
				if (layoutItemByIndex2 == null)
				{
					return;
				}
				layoutItemByIndex2.SelectToggle();
			}, false);
		}
		string logoPathByLanguage = UiResourceConfig.Instance.GetLogoPathByLanguage("LoginLogo");
		base.SetTextureByPath(logoPathByLanguage, base.GetTexture(1), null, null);
		if (SubPackageDownLoadModel.Instance.IsKeyPackageDownLoadingNone())
		{
			SubPackageController.Instance.AutoDownLoadKeySubPackage();
		}
		else if (SubPackageDownLoadModel.Instance.IsKeyPackageDownLoadingFinish() && subPackageList.Count > 0)
		{
			SubPackageController.Instance.PrioritySubPackageDownLoading(subPackageList, null).Forget();
		}
		this.TimerHandle = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
		{
			this.RefreshDownLoadState();
		}, (float)TimeUtil.Instance.InverseMillisecond, 1f, null, null, true);
		if (param != null)
		{
			PopupCaptionItem captionItem = this.CaptionItem;
			if (captionItem != null)
			{
				captionItem.SetCloseBtnActive(param.IsShowCloseBtn);
			}
			base.GetButton(5).RootUIComp.Get().SetUIActive(!param.IsShowCloseBtn);
			base.GetText(9).SetUIActive(!param.IsShowCloseBtn);
		}
		else
		{
			PopupCaptionItem captionItem2 = this.CaptionItem;
			if (captionItem2 != null)
			{
				captionItem2.SetCloseBtnActive(true);
			}
			base.GetButton(5).RootUIComp.Get().SetUIActive(false);
			base.GetText(9).SetUIActive(false);
		}
		this.RefreshFreeSpace();
		this.RefreshStartBtn();
		ValueTuple<bool, List<int>> valueTuple = SubPackageDownLoadModel.Instance.CheckGuideQuestNeedDownLoad();
		bool item = valueTuple.Item1;
		List<int> notFinishedList = valueTuple.Item2;
		if (item)
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.SubPackageRecommendConfirm);
			long num2 = 0L;
			foreach (int id in notFinishedList)
			{
				num2 += SubPackageDownLoadModel.Instance.GetSubPackageSpace(id);
			}
			confirmBoxDataNew.SetTextArgs(new string[]
			{
				SubPackageDownLoadModel.Instance.ByteConverter(num2)
			});
			confirmBoxDataNew.FunctionMap.Add(2, delegate
			{
				SubPackageController.Instance.PrioritySubPackageDownLoading(notFinishedList, null).Forget();
			});
			ConfirmBoxController.Instance.ShowNetWorkConfirmBoxView(confirmBoxDataNew, null);
		}
		this.AniPlay(SubPackageDownLoadView.StartTag);
	}

	// Token: 0x06016C0A RID: 93194 RVA: 0x005C66E4 File Offset: 0x005C48E4
	private void RefreshDownLoadState()
	{
		for (int i = 0; i < this.SubPackageDownLoadItemList.Count; i++)
		{
			this.SubPackageDownLoadItemList[i].RefreshDownLoadState();
		}
	}

	// Token: 0x06016C0B RID: 93195 RVA: 0x005C6718 File Offset: 0x005C4918
	private void RefreshFreeSpace()
	{
		long freeSpace = VideoResUpdate.Instance.GetFreeSpace();
		LguiUtil.Instance.SetLocalTextNew(base.GetText(6), "SubPackageDownLoad_FreeSpace", new <>z__ReadOnlySingleElementList<object>(SubPackageDownLoadModel.Instance.ByteConverter(freeSpace)));
	}

	// Token: 0x06016C0C RID: 93196 RVA: 0x005C6756 File Offset: 0x005C4956
	protected override void OnBeforeHide()
	{
		this.AniPlay(SubPackageDownLoadView.CloseTag);
	}

	// Token: 0x06016C0D RID: 93197 RVA: 0x005C6763 File Offset: 0x005C4963
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer.SetBanned(this.LevelSequenceBannadHandle);
		ResourceManagerController.Instance.RestoreHttpTickFrequency();
		if (this.TimerHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x06016C0E RID: 93198 RVA: 0x005C679C File Offset: 0x005C499C
	private SubPackageDownLoadItem CreateNodeGrid(SubPackageDownLoadDynamicData data, UUIItem uiItem, int index)
	{
		SubPackageDownLoadItem subPackageDownLoadItem = new SubPackageDownLoadItem();
		subPackageDownLoadItem.OnClickCallBack = new Action<int, bool>(this.OnClickSubPackageDownLoadVersionCallBack);
		subPackageDownLoadItem.OnClickHelpBtnCallBack = new Action<int, UUIItem>(this.OnClickSubPackageDownLoadVersionTipsCallBack);
		subPackageDownLoadItem.OnClickBtnCallBack = new Action<SubPackageDownLoadDynamicData>(this.OnClickChileItemBtn);
		this.SubPackageDownLoadItemList.Add(subPackageDownLoadItem);
		return subPackageDownLoadItem;
	}

	// Token: 0x06016C0F RID: 93199 RVA: 0x005C67F2 File Offset: 0x005C49F2
	private SubPackageTab InitTabItem()
	{
		return new SubPackageTab
		{
			OnClickCallBack = new Action<UUIExtendToggle, int>(this.OnClickTabCallBack)
		};
	}

	// Token: 0x06016C10 RID: 93200 RVA: 0x005C680C File Offset: 0x005C4A0C
	private void OnClickSubPackageDownLoadVersionCallBack(int versionId, bool isShowSubItem)
	{
		List<SubPackageDownLoadDynamicData> list = (this.CurrentTabType == 0) ? this.KeySubPackageDataList : this.ExpendSubPackageDataList;
		if (isShowSubItem)
		{
			int num = -1;
			for (int i = 0; i < list.Count; i++)
			{
				int? versionId2 = list[i].VersionId;
				int versionId3 = versionId;
				if (versionId2.GetValueOrDefault() == versionId3 & versionId2 != null)
				{
					num = i;
					break;
				}
			}
			if (num < 0)
			{
				return;
			}
			list[num].IsShowItem = true;
			IReadOnlyList<DownLoadSubPackage> readOnlyList = SubPackageConfig.Instance.GetDownLoadSubPackageListByVersion(versionId) ?? new List<DownLoadSubPackage>();
			List<SubPackageDownLoadDynamicData> list2 = new List<SubPackageDownLoadDynamicData>();
			for (int j = 0; j < readOnlyList.Count; j++)
			{
				list2.Add(new SubPackageDownLoadDynamicData
				{
					SubPackageId = new int?(readOnlyList[j].Id)
				});
			}
			foreach (int value in SubPackageDownLoadModel.Instance.GetDynamicRecallItemsByVersion(versionId))
			{
				list2.Add(new SubPackageDownLoadDynamicData
				{
					SubPackageId = new int?(value),
					IsDynamicRecall = true
				});
			}
			list2.Sort(new Comparison<SubPackageDownLoadDynamicData>(this.SortSubPackage));
			list.InsertRange(num + 1, list2);
		}
		else
		{
			HashSet<int> hashSet = new HashSet<int>(SubPackageDownLoadModel.Instance.GetDynamicRecallItemsByVersion(versionId));
			for (int k = 0; k < list.Count; k++)
			{
				int? versionId2 = list[k].VersionId;
				int versionId3 = versionId;
				if (versionId2.GetValueOrDefault() == versionId3 & versionId2 != null)
				{
					list[k].IsShowItem = false;
				}
				int? subPackageId = list[k].SubPackageId;
				if (subPackageId != null && subPackageId.Value != 0)
				{
					if (list[k].IsDynamicRecall)
					{
						if (hashSet.Contains(subPackageId.Value))
						{
							list.RemoveAt(k);
							k--;
						}
					}
					else
					{
						DownLoadSubPackage? downLoadSubPackageById = SubPackageConfig.Instance.GetDownLoadSubPackageById(subPackageId.Value);
						if (downLoadSubPackageById != null && downLoadSubPackageById.Value.Version == versionId)
						{
							list.RemoveAt(k);
							k--;
						}
					}
				}
			}
		}
		DynamicScrollView<SubPackageDownLoadItem, SubPackageDownLoadDynamicItem, SubPackageDownLoadDynamicData> subPackageDownLoadScrollView = this.SubPackageDownLoadScrollView;
		if (subPackageDownLoadScrollView != null)
		{
			subPackageDownLoadScrollView.RefreshByData(list.ToArray(), true, true);
		}
		DynamicScrollView<SubPackageDownLoadItem, SubPackageDownLoadDynamicItem, SubPackageDownLoadDynamicData> subPackageDownLoadScrollView2 = this.SubPackageDownLoadScrollView;
		if (subPackageDownLoadScrollView2 == null)
		{
			return;
		}
		subPackageDownLoadScrollView2.BindLateUpdate(delegate(float _)
		{
			for (int l = 0; l < this.SubPackageDownLoadItemList.Count; l++)
			{
				SubPackageDownLoadItem subPackageDownLoadItem = this.SubPackageDownLoadItemList[l];
				SubPackageDownLoadDynamicData data = subPackageDownLoadItem.GetData();
				bool flag;
				if (data == null)
				{
					flag = false;
				}
				else
				{
					int? versionId4 = data.VersionId;
					int versionId5 = versionId;
					flag = (versionId4.GetValueOrDefault() == versionId5 & versionId4 != null);
				}
				if (flag)
				{
					UiNavigationNewController.Instance.SetNavigationFocusForView(subPackageDownLoadItem.GetInteractItem(), true, true, false);
					break;
				}
			}
			DynamicScrollView<SubPackageDownLoadItem, SubPackageDownLoadDynamicItem, SubPackageDownLoadDynamicData> subPackageDownLoadScrollView3 = this.SubPackageDownLoadScrollView;
			if (subPackageDownLoadScrollView3 == null)
			{
				return;
			}
			subPackageDownLoadScrollView3.UnBindLateUpdate();
		});
	}

	// Token: 0x06016C11 RID: 93201 RVA: 0x005C6AD0 File Offset: 0x005C4CD0
	private void OnRefreshSubPackageDownLoadByPriority()
	{
		List<SubPackageDownLoadDynamicData> list = new List<SubPackageDownLoadDynamicData>();
		List<SubPackageDownLoadDynamicData> list2 = (this.CurrentTabType == 0) ? this.KeySubPackageDataList : this.ExpendSubPackageDataList;
		for (int i = 0; i < list2.Count; i++)
		{
			SubPackageDownLoadDynamicData subPackageDownLoadDynamicData = list2[i];
			if (subPackageDownLoadDynamicData.SubPackageId == null || subPackageDownLoadDynamicData.SubPackageId.Value == 0)
			{
				list.Add(subPackageDownLoadDynamicData);
				if (subPackageDownLoadDynamicData.IsShowItem)
				{
					IReadOnlyList<DownLoadSubPackage> readOnlyList = SubPackageConfig.Instance.GetDownLoadSubPackageListByVersion(subPackageDownLoadDynamicData.VersionId.Value) ?? new List<DownLoadSubPackage>();
					List<SubPackageDownLoadDynamicData> list3 = new List<SubPackageDownLoadDynamicData>();
					for (int j = 0; j < readOnlyList.Count; j++)
					{
						list3.Add(new SubPackageDownLoadDynamicData
						{
							SubPackageId = new int?(readOnlyList[j].Id)
						});
					}
					foreach (int value in SubPackageDownLoadModel.Instance.GetDynamicRecallItemsByVersion(subPackageDownLoadDynamicData.VersionId.Value))
					{
						list3.Add(new SubPackageDownLoadDynamicData
						{
							SubPackageId = new int?(value),
							IsDynamicRecall = true
						});
					}
					list3.Sort(new Comparison<SubPackageDownLoadDynamicData>(this.SortSubPackage));
					list.AddRange(list3);
				}
			}
		}
		if (this.CurrentTabType == 0)
		{
			this.KeySubPackageDataList = list;
			DynamicScrollView<SubPackageDownLoadItem, SubPackageDownLoadDynamicItem, SubPackageDownLoadDynamicData> subPackageDownLoadScrollView = this.SubPackageDownLoadScrollView;
			if (subPackageDownLoadScrollView != null)
			{
				subPackageDownLoadScrollView.RefreshByData(this.KeySubPackageDataList.ToArray(), true, true);
			}
		}
		else
		{
			this.ExpendSubPackageDataList = list;
			DynamicScrollView<SubPackageDownLoadItem, SubPackageDownLoadDynamicItem, SubPackageDownLoadDynamicData> subPackageDownLoadScrollView2 = this.SubPackageDownLoadScrollView;
			if (subPackageDownLoadScrollView2 != null)
			{
				subPackageDownLoadScrollView2.RefreshByData(this.ExpendSubPackageDataList.ToArray(), true, true);
			}
		}
		DynamicScrollView<SubPackageDownLoadItem, SubPackageDownLoadDynamicItem, SubPackageDownLoadDynamicData> subPackageDownLoadScrollView3 = this.SubPackageDownLoadScrollView;
		if (subPackageDownLoadScrollView3 != null)
		{
			subPackageDownLoadScrollView3.BindLateUpdate(delegate(float _)
			{
				int k = 0;
				while (k < this.SubPackageDownLoadItemList.Count)
				{
					SubPackageDownLoadItem subPackageDownLoadItem = this.SubPackageDownLoadItemList[k];
					SubPackageDownLoadDynamicData data = subPackageDownLoadItem.GetData();
					if (data != null && data.VersionId != null && data.VersionId.Value != 0)
					{
						int? num = data.VersionId;
						SubPackageDownLoadDynamicData targetData = this.TargetData;
						int? num2 = (targetData != null) ? targetData.VersionId : null;
						if (num.GetValueOrDefault() == num2.GetValueOrDefault() & num != null == (num2 != null))
						{
							goto IL_E3;
						}
					}
					if (data != null && data.SubPackageId != null && data.SubPackageId.Value != 0)
					{
						int? num2 = data.SubPackageId;
						SubPackageDownLoadDynamicData targetData2 = this.TargetData;
						int? num = (targetData2 != null) ? targetData2.SubPackageId : null;
						if (num2.GetValueOrDefault() == num.GetValueOrDefault() & num2 != null == (num != null))
						{
							goto IL_E3;
						}
					}
					k++;
					continue;
					IL_E3:
					UiNavigationNewController.Instance.SetNavigationFocusForView(subPackageDownLoadItem.GetInteractItem(), true, true, false);
					break;
				}
				this.TargetData = null;
				DynamicScrollView<SubPackageDownLoadItem, SubPackageDownLoadDynamicItem, SubPackageDownLoadDynamicData> subPackageDownLoadScrollView4 = this.SubPackageDownLoadScrollView;
				if (subPackageDownLoadScrollView4 == null)
				{
					return;
				}
				subPackageDownLoadScrollView4.UnBindLateUpdate();
			});
		}
		this.RefreshStartBtn();
	}

	// Token: 0x06016C12 RID: 93202 RVA: 0x005C6CBC File Offset: 0x005C4EBC
	private void OnRefreshSubPackUseCellData()
	{
		base.GetExtendToggle(3).SetToggleState(EToggleState.ETT_Checked, true, false, false);
	}

	// Token: 0x06016C13 RID: 93203 RVA: 0x005C6CD0 File Offset: 0x005C4ED0
	private int SortSubPackage(SubPackageDownLoadDynamicData a, SubPackageDownLoadDynamicData b)
	{
		ESubPackageDownLoadState subPackageDownLoadItemStateById = SubPackageDownLoadModel.Instance.GetSubPackageDownLoadItemStateById(a.SubPackageId.Value);
		ESubPackageDownLoadState subPackageDownLoadItemStateById2 = SubPackageDownLoadModel.Instance.GetSubPackageDownLoadItemStateById(b.SubPackageId.Value);
		if (subPackageDownLoadItemStateById != subPackageDownLoadItemStateById2)
		{
			return subPackageDownLoadItemStateById - subPackageDownLoadItemStateById2;
		}
		int num = SubPackageDownLoadModel.Instance.SubPackageDownLoadList.IndexOf(a.SubPackageId.Value);
		int num2 = SubPackageDownLoadModel.Instance.SubPackageDownLoadList.IndexOf(b.SubPackageId.Value);
		if (num == num2 && num == -1)
		{
			return a.SubPackageId.Value - b.SubPackageId.Value;
		}
		if (num != num2 && (num == -1 || num2 == -1))
		{
			return num2 - num;
		}
		if (num != num2)
		{
			return num - num2;
		}
		return a.SubPackageId.Value - b.SubPackageId.Value;
	}

	// Token: 0x06016C14 RID: 93204 RVA: 0x005C6D96 File Offset: 0x005C4F96
	private void OnRefreshSubPackDownLoadState()
	{
		this.RefreshFreeSpace();
		this.RefreshStartBtn();
	}

	// Token: 0x06016C15 RID: 93205 RVA: 0x005C6DA4 File Offset: 0x005C4FA4
	private void OnClickSubPackageDownLoadVersionTipsCallBack(int versionId, UUIItem item)
	{
		FVectorDouble fvectorDouble = item.D_K2_GetComponentLocation();
		FVectorDouble vector = new FVectorDouble
		{
			X = fvectorDouble.X,
			Z = fvectorDouble.Z
		};
		SubPackageDownLoadVersionTipsView versionTipsView = this.VersionTipsView;
		if (versionTipsView != null)
		{
			versionTipsView.RefreshItem(versionId, vector);
		}
		SubPackageDownLoadVersionTipsView versionTipsView2 = this.VersionTipsView;
		if (versionTipsView2 == null)
		{
			return;
		}
		versionTipsView2.SetUiActive(true);
	}

	// Token: 0x06016C16 RID: 93206 RVA: 0x005C6DFF File Offset: 0x005C4FFF
	private void OnClickTabCallBack(UUIExtendToggle toggle, int type)
	{
		UUIExtendToggle currentTabToggle = this.CurrentTabToggle;
		if (currentTabToggle != null)
		{
			currentTabToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
		}
		this.CurrentTabToggle = toggle;
		this.CurrentTabType = type;
		this.RefreshSubPackageDownLoadScrollView(type);
	}

	// Token: 0x06016C17 RID: 93207 RVA: 0x005C6E2C File Offset: 0x005C502C
	private void RefreshSubPackageDownLoadScrollView(int type)
	{
		if (type != 0)
		{
			if (type == 1)
			{
				if (this.ExpendSubPackageDataList.Count <= 0)
				{
					this.ExpendSubPackageDataList = new List<SubPackageDownLoadDynamicData>(SubPackageDownLoadModel.Instance.GetExpendSubPackageData());
				}
				DynamicScrollView<SubPackageDownLoadItem, SubPackageDownLoadDynamicItem, SubPackageDownLoadDynamicData> subPackageDownLoadScrollView = this.SubPackageDownLoadScrollView;
				if (subPackageDownLoadScrollView == null)
				{
					return;
				}
				subPackageDownLoadScrollView.RefreshByData(this.ExpendSubPackageDataList.ToArray(), true, true);
			}
			return;
		}
		if (this.KeySubPackageDataList.Count <= 0)
		{
			this.KeySubPackageDataList = new List<SubPackageDownLoadDynamicData>(SubPackageDownLoadModel.Instance.GetKeySubPackageData());
		}
		DynamicScrollView<SubPackageDownLoadItem, SubPackageDownLoadDynamicItem, SubPackageDownLoadDynamicData> subPackageDownLoadScrollView2 = this.SubPackageDownLoadScrollView;
		if (subPackageDownLoadScrollView2 == null)
		{
			return;
		}
		subPackageDownLoadScrollView2.RefreshByData(this.KeySubPackageDataList.ToArray(), true, true);
	}

	// Token: 0x06016C18 RID: 93208 RVA: 0x005C6EC4 File Offset: 0x005C50C4
	private void OnStartBtnClick()
	{
		if (!SubPackageDownLoadModel.Instance.IsKeyPackageDownLoadingFinish())
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.KeySubPackageDownLoadConfirm);
			confirmBoxDataNew.FunctionMap[1] = delegate()
			{
				ConfirmBoxController.Instance.CloseConfirmBoxView();
			};
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				SubPackageController.Instance.RestartSubPackageDownLoading(1, null).Forget();
			};
			ConfirmBoxController.Instance.ShowNetWorkConfirmBoxView(confirmBoxDataNew, null);
			return;
		}
		base.CloseMe(null);
		CustomPromise loginPrepareResCheckPromise = ResourceManagerController.Instance.LoginPrepareResCheckPromise;
		if (loginPrepareResCheckPromise == null)
		{
			return;
		}
		loginPrepareResCheckPromise.SetResult();
	}

	// Token: 0x06016C19 RID: 93209 RVA: 0x005C6F68 File Offset: 0x005C5168
	private void OnClickMobileDataToggle(EToggleState state)
	{
		bool flag = state == EToggleState.ETT_Checked;
		LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.SubDownLoadAgreeUseCellData, flag);
		int currentDownLoadId = SubPackageDownLoadModel.Instance.DownLoadingSubPackageId;
		if (!flag && SubPackageDownLoadModel.Instance.NetworkListener.GetNetworkType() == 3 && currentDownLoadId > 0)
		{
			SubPackageController.Instance.StopSubPackageDownLoading(currentDownLoadId, null);
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.SubPackageDownloadCellNetworkConfirm);
			confirmBoxDataNew.FunctionMap[1] = delegate()
			{
				ConfirmBoxController.Instance.CloseConfirmBoxView();
			};
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				this.OnRefreshSubPackUseCellData();
				SubPackageController.Instance.RestartSubPackageDownLoading(currentDownLoadId, null).Forget();
			};
			ConfirmBoxController.Instance.ShowNetWorkConfirmBoxView(confirmBoxDataNew, null);
		}
	}

	// Token: 0x06016C1A RID: 93210 RVA: 0x005C7030 File Offset: 0x005C5230
	private void RefreshStartBtn()
	{
		bool selfInteractive = SubPackageDownLoadModel.Instance.IsKeyPackageDownLoadingFinish();
		UUIButtonComponent button = base.GetButton(5);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(selfInteractive);
	}

	// Token: 0x06016C1B RID: 93211 RVA: 0x005C705C File Offset: 0x005C525C
	public void AniPlay(FName tag)
	{
		UUIItem item = base.GetItem(10);
		TArray<UActorComponent> tarray;
		if (item == null)
		{
			tarray = null;
		}
		else
		{
			AActor owner = item.GetOwner();
			tarray = ((owner != null) ? owner.GetComponentsByTag(UUIInturnAnimController.StaticClass(), tag) : null);
		}
		TArray<UActorComponent> tarray2 = tarray;
		if (tarray2 != null && tarray2.Num() > 0)
		{
			UUIInturnAnimController uuiinturnAnimController = tarray2.Get(0) as UUIInturnAnimController;
			if (uuiinturnAnimController == null)
			{
				return;
			}
			uuiinturnAnimController.Play("", -1, false);
		}
	}

	// Token: 0x06016C1C RID: 93212 RVA: 0x005C70BE File Offset: 0x005C52BE
	private void OnClickChileItemBtn(SubPackageDownLoadDynamicData data)
	{
		this.TargetData = data;
	}

	// Token: 0x0400A8E0 RID: 43232
	private static readonly FName StartTag = new FName("Start");

	// Token: 0x0400A8E1 RID: 43233
	private static readonly FName CloseTag = new FName("Close");

	// Token: 0x0400A8E2 RID: 43234
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400A8E3 RID: 43235
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private DynamicScrollView<SubPackageDownLoadItem, SubPackageDownLoadDynamicItem, SubPackageDownLoadDynamicData> SubPackageDownLoadScrollView;

	// Token: 0x0400A8E4 RID: 43236
	[Nullable(2)]
	private SubPackageDownLoadVersionTipsView VersionTipsView;

	// Token: 0x0400A8E5 RID: 43237
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<SubPackageTab, int> TabScrollview;

	// Token: 0x0400A8E6 RID: 43238
	[Nullable(2)]
	private UUIExtendToggle CurrentTabToggle;

	// Token: 0x0400A8E7 RID: 43239
	[Nullable(2)]
	private SubPackageDownLoadDynamicItem SubPackageDownLoadItem;

	// Token: 0x0400A8E8 RID: 43240
	private readonly List<SubPackageDownLoadItem> SubPackageDownLoadItemList = new List<SubPackageDownLoadItem>();

	// Token: 0x0400A8E9 RID: 43241
	private int CurrentTabType;

	// Token: 0x0400A8EA RID: 43242
	private List<SubPackageDownLoadDynamicData> KeySubPackageDataList = new List<SubPackageDownLoadDynamicData>();

	// Token: 0x0400A8EB RID: 43243
	private List<SubPackageDownLoadDynamicData> ExpendSubPackageDataList = new List<SubPackageDownLoadDynamicData>();

	// Token: 0x0400A8EC RID: 43244
	[Nullable(2)]
	private TimerHandle TimerHandle;

	// Token: 0x0400A8ED RID: 43245
	private bool LevelSequenceBannadHandle;

	// Token: 0x0400A8EE RID: 43246
	[Nullable(2)]
	private SubPackageDownLoadDynamicData TargetData;

	// Token: 0x020090DF RID: 37087
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x0402EEF6 RID: 192246
		public const int TitleItem = 0;

		// Token: 0x0402EEF7 RID: 192247
		public const int LogoTexture = 1;

		// Token: 0x0402EEF8 RID: 192248
		public const int TabVerticalLayout = 2;

		// Token: 0x0402EEF9 RID: 192249
		public const int MobileDataToggle = 3;

		// Token: 0x0402EEFA RID: 192250
		public const int SubPackageDyncScrollView = 4;

		// Token: 0x0402EEFB RID: 192251
		public const int StartBtn = 5;

		// Token: 0x0402EEFC RID: 192252
		public const int LeftMemoryText = 6;

		// Token: 0x0402EEFD RID: 192253
		public const int VersionTipsParentItem = 7;

		// Token: 0x0402EEFE RID: 192254
		public const int SubPackageItem = 8;

		// Token: 0x0402EEFF RID: 192255
		public const int StartBtnText = 9;

		// Token: 0x0402EF00 RID: 192256
		public const int ContentItem = 10;
	}
}
