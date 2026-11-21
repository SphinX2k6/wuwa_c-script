using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A2E RID: 23086
	[NullableContext(2)]
	[Nullable(0)]
	public class SolarSchoolLocationPanel : SolarSchoolChildViewBase
	{
		// Token: 0x17006C72 RID: 27762
		// (get) Token: 0x06038D9E RID: 232862 RVA: 0x00FEA4B1 File Offset: 0x00FE86B1
		private int CurrentLocationId
		{
			get
			{
				return base.SolarSchoolViewModel.CurLocationId;
			}
		}

		// Token: 0x17006C73 RID: 27763
		// (get) Token: 0x06038D9F RID: 232863 RVA: 0x00FEA4BE File Offset: 0x00FE86BE
		private int CurrentRoleId
		{
			get
			{
				return SolarSchoolGamePlayModel.Instance.MapData.GetLocationRole(this.CurrentLocationId).RoleId;
			}
		}

		// Token: 0x06038DA0 RID: 232864 RVA: 0x00FEA4DC File Offset: 0x00FE86DC
		[NullableContext(1)]
		protected override SolarSchoolRootUiParams CreateRootUiParams()
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			SolarSchoolLocation? solarSchoolLocation;
			string text = ((SolarSchoolConfig.Instance.GetLocation(this.CurrentLocationId) != null) ? solarSchoolLocation.GetValueOrDefault().Name : null) ?? string.Empty;
			return new SolarSchoolRootUiParams
			{
				Caption = new SolarSchoolCaptionParams
				{
					BackVisible = true,
					SetVisible = true,
					TipCostVisible = true,
					HelpGroupId = 732
				},
				FestivalTips = (instance.IsFestivalInstance ? new SolarSchoolFestivalTipsParams(instance.FestivalName) : null),
				LocationName = (string.IsNullOrEmpty(text) ? null : new SolarSchoolLocationNameParams(text))
			};
		}

		// Token: 0x06038DA1 RID: 232865 RVA: 0x00FEA588 File Offset: 0x00FE8788
		protected unsafe override void OnRegisterComponent()
		{
			int num = 15;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
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
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnDoubleCheckMaskClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038DA2 RID: 232866 RVA: 0x00FEA7E4 File Offset: 0x00FE89E4
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolLocationPanel.<OnBeforeStartAsync>d__19 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolLocationPanel.<OnBeforeStartAsync>d__19>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038DA3 RID: 232867 RVA: 0x00FEA828 File Offset: 0x00FE8A28
		protected override void OnStart()
		{
			this.TogLayout = new GenericLayout<SolarSchoolTogItem, SolarSchoolTogItemData>(base.GetVerticalLayout(1), new Func<SolarSchoolTogItem>(this.CreateTogItem), base.GetItem(2).GetOwner() as AUIBaseActor, false, true);
			SolarSchoolFavorPanel favorPanel = this.FavorPanel;
			if (favorPanel != null)
			{
				favorPanel.SetHelpCallback(new Action<int>(this.OnFavorHelpClick));
			}
			UUIButtonComponent button = base.GetButton(3);
			object obj;
			if (button == null)
			{
				obj = null;
			}
			else
			{
				AActor owner = button.GetOwner();
				obj = ((owner != null) ? owner.GetComponentByClass(UUIItem.StaticClass()) : null);
			}
			this.DoubleCheckMask = (obj as UUIItem);
		}

		// Token: 0x06038DA4 RID: 232868 RVA: 0x00FEA8B7 File Offset: 0x00FE8AB7
		protected override void OnBeforeShow()
		{
			this.RefreshAll();
		}

		// Token: 0x06038DA5 RID: 232869 RVA: 0x00FEA8BF File Offset: 0x00FE8ABF
		public override void OnReopen()
		{
			this.RefreshAll();
		}

		// Token: 0x06038DA6 RID: 232870 RVA: 0x00FEA8C7 File Offset: 0x00FE8AC7
		protected override void OnBeforeHide()
		{
			this.SetDoubleCheckVisible(false, false);
		}

		// Token: 0x06038DA7 RID: 232871 RVA: 0x00FEA8D4 File Offset: 0x00FE8AD4
		private void RefreshAll()
		{
			base.SolarSchoolViewModel.SetBackgroundByLocationId(this.CurrentLocationId, null);
			Action refreshDate = base.SolarSchoolViewModel.RefreshDate;
			if (refreshDate != null)
			{
				refreshDate();
			}
			this.SetDoubleCheckVisible(false, false);
			SolarSchoolAttrPanel scorePanel = this.ScorePanel;
			if (scorePanel != null)
			{
				scorePanel.RefreshAttr();
			}
			this.RefreshConditionStates();
			this.RefreshDialogue(this.CurrentRoleId);
		}

		// Token: 0x06038DA8 RID: 232872 RVA: 0x00FEA934 File Offset: 0x00FE8B34
		private void RefreshConditionStates()
		{
			this.RefreshOptions();
			this.RefreshRoleEntries();
			SolarSchoolFavorPanel favorPanel = this.FavorPanel;
			if (favorPanel == null)
			{
				return;
			}
			favorPanel.SetRole(this.CurrentRoleId, SolarSchoolGamePlayModel.Instance.IsFavorLevelUpPending(this.CurrentRoleId));
		}

		// Token: 0x06038DA9 RID: 232873 RVA: 0x00FEA968 File Offset: 0x00FE8B68
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.SolarSchoolTimeChanged, new Action(this.RefreshConditionStates));
			foreach (EEventName name in this.RefreshEvents)
			{
				EventSystem.Instance.Add(name, new GenericEventHandler(this.OnConditionRelatedEventChanged));
			}
		}

		// Token: 0x06038DAA RID: 232874 RVA: 0x00FEA9C4 File Offset: 0x00FE8BC4
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.SolarSchoolTimeChanged, new Action(this.RefreshConditionStates));
			foreach (EEventName name in this.RefreshEvents)
			{
				EventSystem.Instance.Remove(name, new GenericEventHandler(this.OnConditionRelatedEventChanged));
			}
		}

		// Token: 0x06038DAB RID: 232875 RVA: 0x00FEAA1E File Offset: 0x00FE8C1E
		[NullableContext(1)]
		private void OnConditionRelatedEventChanged(params object[] args)
		{
			this.RefreshConditionStates();
		}

		// Token: 0x06038DAC RID: 232876 RVA: 0x00FEAA26 File Offset: 0x00FE8C26
		[NullableContext(1)]
		private SolarSchoolTogItem CreateTogItem()
		{
			return new SolarSchoolTogItem
			{
				ClickCallback = new Action<SolarSchoolTogItemData>(this.OnOptionClick)
			};
		}

		// Token: 0x06038DAD RID: 232877 RVA: 0x00FEAA40 File Offset: 0x00FE8C40
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams.Length >= 2 && configParams[0] == "RoleTog")
			{
				string a = configParams[1];
				SolarSchoolRoleTogItem solarSchoolRoleTogItem;
				if (!(a == "1"))
				{
					if (!(a == "2"))
					{
						if (!(a == "3"))
						{
							solarSchoolRoleTogItem = null;
						}
						else
						{
							solarSchoolRoleTogItem = this.SpecialTog;
						}
					}
					else
					{
						solarSchoolRoleTogItem = this.DatingTog;
					}
				}
				else
				{
					solarSchoolRoleTogItem = this.GiftTog;
				}
				SolarSchoolRoleTogItem solarSchoolRoleTogItem2 = solarSchoolRoleTogItem;
				UUIItem uuiitem = (solarSchoolRoleTogItem2 != null) ? solarSchoolRoleTogItem2.GetGuideToggleItem() : null;
				if (uuiitem == null)
				{
					return null;
				}
				return new UUIItem[]
				{
					uuiitem,
					uuiitem
				};
			}
			else
			{
				int num;
				if (configParams.Length < 2 || configParams[0] != "MainTog" || !int.TryParse(configParams[1], out num) || num <= 0)
				{
					return null;
				}
				GenericLayout<SolarSchoolTogItem, SolarSchoolTogItemData> togLayout = this.TogLayout;
				UUIItem uuiitem2;
				if (togLayout == null)
				{
					uuiitem2 = null;
				}
				else
				{
					SolarSchoolTogItem layoutItemByIndex = togLayout.GetLayoutItemByIndex(num - 1);
					uuiitem2 = ((layoutItemByIndex != null) ? layoutItemByIndex.GetGuideTogItem() : null);
				}
				UUIItem uuiitem3 = uuiitem2;
				if (uuiitem3 == null)
				{
					return null;
				}
				return new UUIItem[]
				{
					uuiitem3,
					uuiitem3
				};
			}
		}

		// Token: 0x06038DAE RID: 232878 RVA: 0x00FEAB30 File Offset: 0x00FE8D30
		private void RefreshOptions()
		{
			bool flag = SolarSchoolGamePlayModel.Instance.CanPlayerFreeChoose();
			List<SolarSchoolTogItemData> list = new List<SolarSchoolTogItemData>();
			foreach (SolarSchoolOptionInfo solarSchoolOptionInfo in SolarSchoolGamePlayModel.Instance.MapData.GetLocationOptions(this.CurrentLocationId))
			{
				list.Add(new SolarSchoolTogItemData
				{
					OptionId = solarSchoolOptionInfo.Row.Id,
					Text = SolarSchoolUtils.GetTextWithPlaceholder(solarSchoolOptionInfo.Row.TextKey),
					IconPath = solarSchoolOptionInfo.Row.OptionIcon,
					CanClick = (solarSchoolOptionInfo.CanClick && flag),
					LockHint = (solarSchoolOptionInfo.CanClick ? string.Empty : SolarSchoolUtils.GetConditionHintText(solarSchoolOptionInfo.Row.ConditionId))
				});
			}
			SolarSchoolPlayerData playerData = SolarSchoolGamePlayModel.Instance.PlayerData;
			foreach (int behaviorId in SolarSchoolGamePlayModel.Instance.GetLocationBehaviors(this.CurrentLocationId))
			{
				SolarSchoolBehavior? currentLevelRow = playerData.GetCurrentLevelRow(behaviorId);
				list.Add(new SolarSchoolTogItemData
				{
					BehaviorId = behaviorId,
					Text = playerData.GetBehaviorName(behaviorId),
					IconPath = ((currentLevelRow != null) ? currentLevelRow.GetValueOrDefault().OptionIcon : null),
					CanClick = flag,
					Level = ((currentLevelRow != null) ? currentLevelRow.GetValueOrDefault().Level : 0),
					OccupySlot = SolarSchoolGamePlayModel.Instance.GetBehaviorOccupySlot(currentLevelRow)
				});
			}
			GenericLayout<SolarSchoolTogItem, SolarSchoolTogItemData> togLayout = this.TogLayout;
			if (togLayout == null)
			{
				return;
			}
			togLayout.RefreshByData(list, null, false);
		}

		// Token: 0x06038DAF RID: 232879 RVA: 0x00FEAD24 File Offset: 0x00FE8F24
		private void RefreshDialogue(int roleId)
		{
			SolarSchoolRootViewModel solarSchoolViewModel = base.SolarSchoolViewModel;
			UUIItem item = base.GetItem(5);
			if (item != null)
			{
				item.SetUIActive(roleId != 0);
			}
			if (roleId == 0)
			{
				this.FrozenTalkRoleId = 0;
				this.FrozenTalkSpineId = 0;
				solarSchoolViewModel.RefreshLocationRole();
				return;
			}
			bool flag = solarSchoolViewModel.ConsumeLocationEnterPending();
			if (flag || this.FrozenTalkRoleId != roleId)
			{
				SolarSchoolRoleTalkInfo solarSchoolRoleTalkInfo = SolarSchoolGamePlayModel.Instance.FriendData.PickTalk(roleId);
				this.FrozenTalkRoleId = roleId;
				this.FrozenTalkSpineId = solarSchoolRoleTalkInfo.RoleSpineId;
			}
			int frozenTalkSpineId = this.FrozenTalkSpineId;
			UUIText text = base.GetText(6);
			if (text != null)
			{
				SolarSchoolRoleSpine? solarSchoolRoleSpine;
				text.SetText(SolarSchoolUtils.GetTextWithPlaceholder((SolarSchoolConfig.Instance.GetRoleSpine(frozenTalkSpineId) != null) ? solarSchoolRoleSpine.GetValueOrDefault().TextKey : null), true);
			}
			solarSchoolViewModel.LocationRoleSpineId = frozenTalkSpineId;
			solarSchoolViewModel.LocationRolePlayVoice = flag;
			solarSchoolViewModel.RefreshLocationRole();
		}

		// Token: 0x06038DB0 RID: 232880 RVA: 0x00FEADFC File Offset: 0x00FE8FFC
		private void RefreshRoleEntries()
		{
			int currentRoleId = this.CurrentRoleId;
			UUIItem item = base.GetItem(9);
			if (item != null)
			{
				item.SetUIActive(currentRoleId != 0);
			}
			if (currentRoleId == 0)
			{
				SolarSchoolRoleTogItem giftTog = this.GiftTog;
				if (giftTog != null)
				{
					giftTog.Refresh(null);
				}
				SolarSchoolRoleTogItem datingTog = this.DatingTog;
				if (datingTog != null)
				{
					datingTog.Refresh(null);
				}
				SolarSchoolRoleTogItem specialTog = this.SpecialTog;
				if (specialTog != null)
				{
					specialTog.Refresh(null);
				}
				this.RefreshCenterLineType(0);
				return;
			}
			bool canFreeChoose = SolarSchoolGamePlayModel.Instance.CanPlayerFreeChoose();
			SolarSchoolTogItemData giftData = this.GetGiftData(currentRoleId, canFreeChoose);
			SolarSchoolTogItemData datingData = this.GetDatingData(currentRoleId, canFreeChoose);
			SolarSchoolTogItemData specialData = this.GetSpecialData(currentRoleId, canFreeChoose);
			SolarSchoolRoleTogItem giftTog2 = this.GiftTog;
			if (giftTog2 != null)
			{
				giftTog2.Refresh(giftData);
			}
			SolarSchoolRoleTogItem datingTog2 = this.DatingTog;
			if (datingTog2 != null)
			{
				datingTog2.Refresh(datingData);
			}
			SolarSchoolRoleTogItem specialTog2 = this.SpecialTog;
			if (specialTog2 != null)
			{
				specialTog2.Refresh(specialData);
			}
			int count = ((giftData != null) + (datingData != null) + (specialData != null)) ? 1 : 0;
			this.RefreshCenterLineType(count);
		}

		// Token: 0x06038DB1 RID: 232881 RVA: 0x00FEAEDF File Offset: 0x00FE90DF
		private void RefreshCenterLineType(int count)
		{
			UUIItem item = base.GetItem(10);
			if (item != null)
			{
				item.SetUIActive(count == 2);
			}
			UUIItem item2 = base.GetItem(11);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(count >= 3);
		}

		// Token: 0x06038DB2 RID: 232882 RVA: 0x00FEAF14 File Offset: 0x00FE9114
		private unsafe SolarSchoolTogItemData GetGiftData(int roleId, bool canFreeChoose)
		{
			List<SolarSchoolOptionInfo> roleOptions = SolarSchoolGamePlayModel.Instance.FriendData.GetRoleOptions(roleId);
			if (roleOptions.Count == 0)
			{
				return null;
			}
			if (roleOptions.Count > 1)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 角色选项只有送礼一个槽位，配了多条只取第一条";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("roleId", roleId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("count", roleOptions.Count);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			SolarSchoolOptionInfo solarSchoolOptionInfo = roleOptions[0];
			return new SolarSchoolTogItemData
			{
				OptionId = solarSchoolOptionInfo.Row.Id,
				CanClick = (solarSchoolOptionInfo.CanClick && canFreeChoose)
			};
		}

		// Token: 0x06038DB3 RID: 232883 RVA: 0x00FEAFDC File Offset: 0x00FE91DC
		private unsafe SolarSchoolTogItemData GetDatingData(int roleId, bool canFreeChoose)
		{
			List<int> roleBehaviors = SolarSchoolGamePlayModel.Instance.GetRoleBehaviors(roleId);
			if (roleBehaviors.Count == 0)
			{
				return null;
			}
			if (roleBehaviors.Count > 1)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 角色行为只有约会一个槽位，配了多条只取第一条";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("roleId", roleId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("count", roleBehaviors.Count);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			int behaviorId = roleBehaviors[0];
			if (!SolarSchoolGamePlayModel.Instance.CanExecuteBehavior(behaviorId))
			{
				return null;
			}
			SolarSchoolBehavior? currentLevelRow = SolarSchoolGamePlayModel.Instance.PlayerData.GetCurrentLevelRow(behaviorId);
			return new SolarSchoolTogItemData
			{
				BehaviorId = behaviorId,
				CanClick = canFreeChoose,
				Level = ((currentLevelRow != null) ? currentLevelRow.GetValueOrDefault().Level : 0),
				OccupySlot = SolarSchoolGamePlayModel.Instance.GetBehaviorOccupySlot(currentLevelRow)
			};
		}

		// Token: 0x06038DB4 RID: 232884 RVA: 0x00FEB0DB File Offset: 0x00FE92DB
		private SolarSchoolTogItemData GetSpecialData(int roleId, bool canFreeChoose)
		{
			if (!SolarSchoolSpecialBehaviorCenter.Instance.ShowAcceptEntry(roleId))
			{
				return null;
			}
			return new SolarSchoolTogItemData
			{
				CanClick = canFreeChoose,
				IsExtraEntry = true,
				ShowRedDot = SolarSchoolSpecialBehaviorCenter.Instance.HasUnviewedSpecialBehavior(roleId)
			};
		}

		// Token: 0x06038DB5 RID: 232885 RVA: 0x00FEB110 File Offset: 0x00FE9310
		private void OpenSpecialBehaviorAcceptView()
		{
			int appearedBehaviorIdByRole = SolarSchoolSpecialBehaviorCenter.Instance.GetAppearedBehaviorIdByRole(this.CurrentRoleId);
			if (appearedBehaviorIdByRole == 0)
			{
				return;
			}
			SolarSchoolSpecialBehaviorCenter.Instance.MarkSpecialTalkViewed(appearedBehaviorIdByRole);
			this.RefreshRoleEntries();
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolSpecialBehaviorAcceptView, new SolarSchoolSpecialBehaviorAcceptParam
			{
				BehaviorId = appearedBehaviorIdByRole,
				OnAccepted = new Action(this.RefreshRoleEntries)
			}, null);
		}

		// Token: 0x06038DB6 RID: 232886 RVA: 0x00FEB174 File Offset: 0x00FE9374
		private void SetDoubleCheckVisible(bool visible, bool isCenter = false)
		{
			UUIItem doubleCheckMask = this.DoubleCheckMask;
			if (doubleCheckMask != null)
			{
				doubleCheckMask.SetUIActive(visible);
			}
			SolarSchoolDoubleCheckItem doubleCheckRight = this.DoubleCheckRight;
			if (doubleCheckRight != null)
			{
				doubleCheckRight.SetUiActive(visible && !isCenter);
			}
			SolarSchoolDoubleCheckItem doubleCheckCenter = this.DoubleCheckCenter;
			if (doubleCheckCenter != null)
			{
				doubleCheckCenter.SetUiActive(visible && isCenter);
			}
			SolarSchoolAttrPanel scorePanel = this.ScorePanel;
			if (scorePanel != null)
			{
				scorePanel.SetAboveMask(visible);
			}
			if (visible)
			{
				return;
			}
			base.SolarSchoolViewModel.ClearFatiguePreview();
			SolarSchoolAttrPanel scorePanel2 = this.ScorePanel;
			if (scorePanel2 != null)
			{
				scorePanel2.ClearBehaviorPreview();
			}
			GenericLayout<SolarSchoolTogItem, SolarSchoolTogItemData> togLayout = this.TogLayout;
			if (togLayout != null)
			{
				togLayout.DeselectCurrentGridProxy();
			}
			SolarSchoolRoleTogItem datingTog = this.DatingTog;
			if (datingTog != null)
			{
				datingTog.SetAboveMask(false);
			}
			SolarSchoolRoleTogItem datingTog2 = this.DatingTog;
			if (datingTog2 == null)
			{
				return;
			}
			datingTog2.SetSelected(false);
		}

		// Token: 0x06038DB7 RID: 232887 RVA: 0x00FEB228 File Offset: 0x00FE9428
		private void OnDoubleCheckMaskClick()
		{
			this.SetDoubleCheckVisible(false, false);
			SolarSchoolDoubleCheckItem doubleCheckRight = this.DoubleCheckRight;
			if (doubleCheckRight != null)
			{
				doubleCheckRight.CancelCheck();
			}
			SolarSchoolDoubleCheckItem doubleCheckCenter = this.DoubleCheckCenter;
			if (doubleCheckCenter == null)
			{
				return;
			}
			doubleCheckCenter.CancelCheck();
		}

		// Token: 0x06038DB8 RID: 232888 RVA: 0x00FEB254 File Offset: 0x00FE9454
		[NullableContext(1)]
		private void OnOptionClick(SolarSchoolTogItemData data)
		{
			if (!data.CanClick)
			{
				return;
			}
			if (data.BehaviorId == 0)
			{
				SolarSchoolGamePlayModel.Instance.PlayerChooseOption(this.CurrentLocationId, data.OptionId);
				this.RefreshOptions();
				return;
			}
			this.SetDoubleCheckVisible(true, false);
			base.SolarSchoolViewModel.SetFatiguePreview(SolarSchoolGamePlayModel.Instance.GetFatigueAfterBehavior(data.BehaviorId));
			SolarSchoolAttrPanel scorePanel = this.ScorePanel;
			if (scorePanel != null)
			{
				scorePanel.SetBehaviorPreview(data.BehaviorId);
			}
			GenericLayout<SolarSchoolTogItem, SolarSchoolTogItemData> togLayout = this.TogLayout;
			if (togLayout != null)
			{
				SolarSchoolTogItem selectedProxy = togLayout.GetSelectedProxy();
				if (selectedProxy != null)
				{
					selectedProxy.SetAboveMask(true);
				}
			}
			SolarSchoolDoubleCheckItem doubleCheckRight = this.DoubleCheckRight;
			if (doubleCheckRight == null)
			{
				return;
			}
			doubleCheckRight.ShowBehaviorCheck(data.BehaviorId, delegate
			{
				this.SetDoubleCheckVisible(false, false);
				if (SolarSchoolGamePlayModel.Instance.CanPlayerFreeChoose())
				{
					this.SolarSchoolViewModel.HoldFatigueUntilSettled(SolarSchoolGamePlayModel.Instance.GetFatigueAfterBehavior(data.BehaviorId));
					SolarSchoolGamePlayModel.Instance.PlayerChooseBehavior(data.BehaviorId);
				}
				this.RefreshOptions();
			});
		}

		// Token: 0x06038DB9 RID: 232889 RVA: 0x00FEB33A File Offset: 0x00FE953A
		[NullableContext(1)]
		private void OnGiftClick(SolarSchoolTogItemData data)
		{
			if (!data.CanClick)
			{
				return;
			}
			SolarSchoolGamePlayModel.Instance.PlayerChooseRoleOption(this.CurrentRoleId, data.OptionId);
			this.RefreshRoleEntries();
		}

		// Token: 0x06038DBA RID: 232890 RVA: 0x00FEB364 File Offset: 0x00FE9564
		[NullableContext(1)]
		private void OnDatingClick(SolarSchoolTogItemData data)
		{
			if (!data.CanClick)
			{
				return;
			}
			SolarSchoolFriendData friendData = SolarSchoolGamePlayModel.Instance.FriendData;
			if (friendData.IsFavorFrozen(this.CurrentRoleId))
			{
				ScrollingTipsController.Instance.ShowTipsByText(SolarSchoolUtils.GetConditionHintText(friendData.GetNextLevelPreUnlockConditionId(this.CurrentRoleId)));
				return;
			}
			this.SetDoubleCheckVisible(true, true);
			base.SolarSchoolViewModel.SetFatiguePreview(SolarSchoolGamePlayModel.Instance.GetFatigueAfterBehavior(data.BehaviorId));
			SolarSchoolAttrPanel scorePanel = this.ScorePanel;
			if (scorePanel != null)
			{
				scorePanel.SetBehaviorPreview(data.BehaviorId);
			}
			SolarSchoolRoleTogItem datingTog = this.DatingTog;
			if (datingTog != null)
			{
				datingTog.SetAboveMask(true);
			}
			SolarSchoolRoleTogItem datingTog2 = this.DatingTog;
			if (datingTog2 != null)
			{
				datingTog2.SetSelected(true);
			}
			SolarSchoolDoubleCheckItem doubleCheckCenter = this.DoubleCheckCenter;
			if (doubleCheckCenter == null)
			{
				return;
			}
			doubleCheckCenter.ShowBehaviorCheck(data.BehaviorId, delegate
			{
				this.SetDoubleCheckVisible(false, false);
				if (SolarSchoolGamePlayModel.Instance.CanPlayerFreeChoose())
				{
					this.SolarSchoolViewModel.HoldFatigueUntilSettled(SolarSchoolGamePlayModel.Instance.GetFatigueAfterBehavior(data.BehaviorId));
					SolarSchoolGamePlayModel.Instance.PlayerChooseBehavior(data.BehaviorId);
				}
				this.RefreshRoleEntries();
			});
		}

		// Token: 0x06038DBB RID: 232891 RVA: 0x00FEB457 File Offset: 0x00FE9657
		[NullableContext(1)]
		private void OnSpecialClick(SolarSchoolTogItemData data)
		{
			if (!data.CanClick)
			{
				return;
			}
			this.OpenSpecialBehaviorAcceptView();
		}

		// Token: 0x06038DBC RID: 232892 RVA: 0x00FEB468 File Offset: 0x00FE9668
		private void OnFavorHelpClick(int roleId)
		{
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolInfoOverviewView, new SolarSchoolInfoOverviewViewParam
			{
				TargetTabViewName = new EUiTabViewName?(EUiTabViewName.SolarSchoolInfoFriendTabView),
				TargetRoleId = roleId
			}, null);
		}

		// Token: 0x0401DEB4 RID: 122548
		private SolarSchoolAttrPanel ScorePanel;

		// Token: 0x0401DEB5 RID: 122549
		private SolarSchoolFavorPanel FavorPanel;

		// Token: 0x0401DEB6 RID: 122550
		private SolarSchoolDoubleCheckItem DoubleCheckRight;

		// Token: 0x0401DEB7 RID: 122551
		private SolarSchoolDoubleCheckItem DoubleCheckCenter;

		// Token: 0x0401DEB8 RID: 122552
		private SolarSchoolRoleTogItem GiftTog;

		// Token: 0x0401DEB9 RID: 122553
		private SolarSchoolRoleTogItem DatingTog;

		// Token: 0x0401DEBA RID: 122554
		private SolarSchoolRoleTogItem SpecialTog;

		// Token: 0x0401DEBB RID: 122555
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<SolarSchoolTogItem, SolarSchoolTogItemData> TogLayout;

		// Token: 0x0401DEBC RID: 122556
		private UUIItem DoubleCheckMask;

		// Token: 0x0401DEBD RID: 122557
		private int FrozenTalkRoleId;

		// Token: 0x0401DEBE RID: 122558
		private int FrozenTalkSpineId;

		// Token: 0x0401DEBF RID: 122559
		[Nullable(1)]
		private readonly EEventName[] RefreshEvents = new EEventName[]
		{
			EEventName.SolarSchoolAttrChanged,
			EEventName.SolarSchoolFavorChanged,
			EEventName.SolarSchoolItemChanged,
			EEventName.SolarSchoolBehaviorSettled,
			EEventName.SolarSchoolSpecialStateChanged,
			EEventName.SolarSchoolExamScoreChanged,
			EEventName.SolarSchoolAvgParamChanged
		};

		// Token: 0x0200B600 RID: 46592
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04038472 RID: 230514
			public const int ScorePanel = 0;

			// Token: 0x04038473 RID: 230515
			public const int TogLayout = 1;

			// Token: 0x04038474 RID: 230516
			public const int TogItem = 2;

			// Token: 0x04038475 RID: 230517
			public const int PnlDoubleCheck = 3;

			// Token: 0x04038476 RID: 230518
			public const int DoubleCheckRightItem = 4;

			// Token: 0x04038477 RID: 230519
			public const int PnlDialogue = 5;

			// Token: 0x04038478 RID: 230520
			public const int TxtDialogue = 6;

			// Token: 0x04038479 RID: 230521
			public const int FavorPanel = 7;

			// Token: 0x0403847A RID: 230522
			public const int DoubleCheckCenterItem = 8;

			// Token: 0x0403847B RID: 230523
			public const int PnlCenterBtn = 9;

			// Token: 0x0403847C RID: 230524
			public const int PnlTypeLineTwo = 10;

			// Token: 0x0403847D RID: 230525
			public const int PnlTypeLineThree = 11;

			// Token: 0x0403847E RID: 230526
			public const int TogGift = 12;

			// Token: 0x0403847F RID: 230527
			public const int TogDating = 13;

			// Token: 0x04038480 RID: 230528
			public const int TogSpecial = 14;
		}
	}
}
