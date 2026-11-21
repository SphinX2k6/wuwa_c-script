using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.ActivityAction;
using CSharpScript.Game.Module.ActivityCondition;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058BE RID: 22718
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolPopupAction : SolarSchoolActionBase
	{
		// Token: 0x06037F21 RID: 229153 RVA: 0x00FA32EC File Offset: 0x00FA14EC
		public static Dictionary<string, string> CreateEventPopupParams(ESolarSchoolPopupId popupId, int behaviorId)
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary.Add("PopupType", SolarSchoolPopupAction.EPopupType.Event.ToString());
			string key = "PopupId";
			int num = (int)popupId;
			dictionary.Add(key, num.ToString());
			dictionary.Add("SolarSchoolBehaviorId", behaviorId.ToString());
			return dictionary;
		}

		// Token: 0x06037F22 RID: 229154 RVA: 0x00FA3340 File Offset: 0x00FA1540
		public static Dictionary<string, string> CreateAttrRankUpPopupParams(IReadOnlyList<SolarSchoolAttrRankUpInfo> attributeRankUps)
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>
			{
				{
					"PopupType",
					SolarSchoolPopupAction.EPopupType.AttrRankUp.ToString()
				},
				{
					"AttributeCount",
					attributeRankUps.Count.ToString()
				}
			};
			for (int i = 0; i < attributeRankUps.Count; i++)
			{
				SolarSchoolAttrRankUpInfo solarSchoolAttrRankUpInfo = attributeRankUps[i];
				Dictionary<string, string> dictionary2 = dictionary;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Attribute");
				defaultInterpolatedStringHandler.AppendFormatted<int>(i);
				string key = defaultInterpolatedStringHandler.ToStringAndClear();
				int attr = (int)solarSchoolAttrRankUpInfo.Attr;
				dictionary2[key] = attr.ToString();
				Dictionary<string, string> dictionary3 = dictionary;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 1);
				defaultInterpolatedStringHandler.AppendLiteral("OldValue");
				defaultInterpolatedStringHandler.AppendFormatted<int>(i);
				dictionary3[defaultInterpolatedStringHandler.ToStringAndClear()] = solarSchoolAttrRankUpInfo.OldValue.ToString();
				Dictionary<string, string> dictionary4 = dictionary;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 1);
				defaultInterpolatedStringHandler.AppendLiteral("NewValue");
				defaultInterpolatedStringHandler.AppendFormatted<int>(i);
				dictionary4[defaultInterpolatedStringHandler.ToStringAndClear()] = solarSchoolAttrRankUpInfo.NewValue.ToString();
			}
			return dictionary;
		}

		// Token: 0x06037F23 RID: 229155 RVA: 0x00FA3450 File Offset: 0x00FA1650
		public static Dictionary<string, string> CreateBehaviorDonePopupParams(int behaviorId, string textKey = "", bool showAttrList = true)
		{
			return new Dictionary<string, string>
			{
				{
					"PopupType",
					SolarSchoolPopupAction.EPopupType.BehaviorDone.ToString()
				},
				{
					"SolarSchoolBehaviorId",
					behaviorId.ToString()
				},
				{
					"TextKey",
					textKey
				},
				{
					"ShowAttrList",
					showAttrList ? "1" : "0"
				}
			};
		}

		// Token: 0x06037F24 RID: 229156 RVA: 0x00FA34B4 File Offset: 0x00FA16B4
		public static Dictionary<string, string> CreateBehaviorLevelUpPopupParams(int behaviorId)
		{
			return new Dictionary<string, string>
			{
				{
					"PopupType",
					SolarSchoolPopupAction.EPopupType.BehaviorLevelUp.ToString()
				},
				{
					"SolarSchoolBehaviorId",
					behaviorId.ToString()
				}
			};
		}

		// Token: 0x06037F25 RID: 229157 RVA: 0x00FA34F4 File Offset: 0x00FA16F4
		protected override void OnParse(IReadOnlyDictionary<string, string> parameters)
		{
			this.PopupType = this.ParsePopupType(ActivityActionBase.GetParamString(parameters, "PopupType", ""));
			this.ItemId = ActivityActionBase.GetParamInt(parameters, "ItemId", 0);
			this.Count = ActivityActionBase.GetParamInt(parameters, "Count", 0);
			this.RoleId = ActivityActionBase.GetParamInt(parameters, "RoleId", 0);
			this.PreviousLevel = ActivityActionBase.GetParamInt(parameters, "PreviousLevel", 0);
			this.FinalLevel = ActivityActionBase.GetParamInt(parameters, "FinalLevel", 0);
			this.ConditionGroupId = ActivityActionBase.GetParamInt(parameters, "ConditionGroupId", 0);
			this.TitleId = ActivityActionBase.GetParamString(parameters, "TitleId", "");
			this.TipsKey = ActivityActionBase.GetParamString(parameters, "TipsKey", "");
			this.IconPath = ActivityActionBase.GetParamString(parameters, "IconPath", "");
			this.TextKey = ActivityActionBase.GetParamString(parameters, "TextKey", "");
			this.ShowAttrList = (ActivityActionBase.GetParamInt(parameters, "ShowAttrList", 1) != 0);
			this.ConfirmId = ActivityActionBase.GetParamInt(parameters, "ConfirmId", 0);
			this.BehaviorId = ActivityActionBase.GetParamInt(parameters, "SolarSchoolBehaviorId", 0);
			this.QuestId = ActivityActionBase.GetParamInt(parameters, "QuestId", 0);
			this.PopupId = ActivityActionBase.GetParamInt(parameters, "PopupId", 0);
			this.CycleMin = ActivityActionBase.GetParamInt(parameters, "CycleMin", int.MinValue);
			this.CycleMax = ActivityActionBase.GetParamInt(parameters, "CycleMax", int.MaxValue);
			this.AttributeRankUps.Clear();
			int paramInt = ActivityActionBase.GetParamInt(parameters, "AttributeCount", 0);
			for (int i = 0; i < paramInt; i++)
			{
				List<SolarSchoolAttrRankUpInfo> attributeRankUps = this.AttributeRankUps;
				SolarSchoolAttrRankUpInfo item = default(SolarSchoolAttrRankUpInfo);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Attribute");
				defaultInterpolatedStringHandler.AppendFormatted<int>(i);
				item.Attr = (ESolarSchoolSecondAttr)ActivityActionBase.GetParamInt(parameters, defaultInterpolatedStringHandler.ToStringAndClear(), 0);
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 1);
				defaultInterpolatedStringHandler.AppendLiteral("OldValue");
				defaultInterpolatedStringHandler.AppendFormatted<int>(i);
				item.OldValue = ActivityActionBase.GetParamInt(parameters, defaultInterpolatedStringHandler.ToStringAndClear(), 0);
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 1);
				defaultInterpolatedStringHandler.AppendLiteral("NewValue");
				defaultInterpolatedStringHandler.AppendFormatted<int>(i);
				item.NewValue = ActivityActionBase.GetParamInt(parameters, defaultInterpolatedStringHandler.ToStringAndClear(), 0);
				attributeRankUps.Add(item);
			}
		}

		// Token: 0x06037F26 RID: 229158 RVA: 0x00FA3740 File Offset: 0x00FA1940
		protected override void OnStart()
		{
			if (!this.IsCycleMatched())
			{
				base.MarkDone();
				return;
			}
			switch (this.PopupType)
			{
			case SolarSchoolPopupAction.EPopupType.Tips:
				this.OpenTipsPopup();
				return;
			case SolarSchoolPopupAction.EPopupType.Favor:
				this.OpenFavorPopup();
				return;
			case SolarSchoolPopupAction.EPopupType.UnlockItem:
				this.OpenUnlockItemPopup();
				return;
			case SolarSchoolPopupAction.EPopupType.Build:
				this.OpenBuildPopup();
				return;
			case SolarSchoolPopupAction.EPopupType.Confirm:
				this.OpenConfirmPopup();
				return;
			case SolarSchoolPopupAction.EPopupType.BehaviorDone:
				this.OpenBehaviorDonePopup();
				return;
			case SolarSchoolPopupAction.EPopupType.BehaviorLevelUp:
				this.OpenBehaviorLevelUpPopup();
				return;
			case SolarSchoolPopupAction.EPopupType.QuestUnlock:
				this.OpenQuestUnlockPopup();
				return;
			case SolarSchoolPopupAction.EPopupType.Event:
				this.OpenEventPopup();
				return;
			case SolarSchoolPopupAction.EPopupType.AttrRankUp:
				this.OpenAttrRankUpPopup();
				return;
			default:
				this.FailWithLog("[SolarSchool] PopupAction 参数非法");
				return;
			}
		}

		// Token: 0x06037F27 RID: 229159 RVA: 0x00FA37E8 File Offset: 0x00FA19E8
		private bool IsCycleMatched()
		{
			int conditionCycleCount = SolarSchoolGamePlayModel.Instance.GetConditionCycleCount();
			return conditionCycleCount >= this.CycleMin && conditionCycleCount <= this.CycleMax;
		}

		// Token: 0x06037F28 RID: 229160 RVA: 0x00FA3818 File Offset: 0x00FA1A18
		private void OpenTipsPopup()
		{
			if (this.ItemId <= 0 || this.Count < 0 || SolarSchoolConfig.Instance.GetItem(this.ItemId) == null)
			{
				this.FailWithLog("[SolarSchool] TipsPopupAction 参数非法");
				return;
			}
			this.OpenedViewName = new EUiViewName?(EUiViewName.SolarSchoolTipsPopupView);
			SolarSchoolUtils.ShowTipsPopup(this.ItemId, this.Count, new Action(base.MarkDone));
		}

		// Token: 0x06037F29 RID: 229161 RVA: 0x00FA388C File Offset: 0x00FA1A8C
		private unsafe void OpenFavorPopup()
		{
			if (this.RoleId <= 0 || this.PreviousLevel < 0 || this.FinalLevel <= this.PreviousLevel || SolarSchoolConfig.Instance.GetRole(this.RoleId) == null || SolarSchoolConfig.Instance.GetRoleFavorLevel(this.RoleId, this.FinalLevel) == null)
			{
				this.FailWithLog("[SolarSchool] FavorPopupAction 参数非法");
				return;
			}
			this.OpenedViewName = new EUiViewName?(EUiViewName.SolarSchoolFavorLevelUpPopupView);
			SolarSchoolUtils.ShowFavorLevelUpPopup(this.RoleId, this.PreviousLevel, this.FinalLevel, new Action(base.MarkDone), delegate
			{
				this.OpenedViewName = null;
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 好感升级弹窗打开失败，按已完成跳过";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("roleId", this.RoleId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("previousLevel", this.PreviousLevel);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("finalLevel", this.FinalLevel);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				base.MarkDone();
			});
		}

		// Token: 0x06037F2A RID: 229162 RVA: 0x00FA3940 File Offset: 0x00FA1B40
		private void OpenUnlockItemPopup()
		{
			IReadOnlyList<int> readOnlyList;
			if (this.ConditionGroupId <= 0 || !ActivityConditionCenter.Instance.TryGetGroupConditionIds(this.ConditionGroupId, out readOnlyList))
			{
				this.FailWithLog("[SolarSchool] UnlockItemPopupAction 参数非法");
				return;
			}
			this.OpenedViewName = new EUiViewName?(EUiViewName.SolarSchoolUnlockItemPopupView);
			SolarSchoolUtils.ShowUnlockItemPopup(this.ConditionGroupId, this.TitleId, null, new Action(base.MarkDone));
		}

		// Token: 0x06037F2B RID: 229163 RVA: 0x00FA39A4 File Offset: 0x00FA1BA4
		private void OpenBuildPopup()
		{
			if (string.IsNullOrWhiteSpace(this.TipsKey) || string.IsNullOrWhiteSpace(this.IconPath))
			{
				this.FailWithLog("[SolarSchool] BuildPopupAction 参数非法");
				return;
			}
			this.OpenedViewName = new EUiViewName?(EUiViewName.SolarSchoolBuildPopupView);
			SolarSchoolUtils.ShowBuildPopup(this.TipsKey, this.IconPath, null, new Action(base.MarkDone), Array.Empty<object>());
		}

		// Token: 0x06037F2C RID: 229164 RVA: 0x00FA3A0C File Offset: 0x00FA1C0C
		private void OpenConfirmPopup()
		{
			if (this.ConfirmId <= 0 || ConfirmBoxConfig.Instance.GetConfirmBoxConfig(this.ConfirmId) == null)
			{
				this.FailWithLog("[SolarSchool] ConfirmPopupAction 参数非法");
				return;
			}
			ConfirmBoxDataNew param = new ConfirmBoxDataNew((EConfirmBoxConfigId)this.ConfirmId)
			{
				DestroyFunction = new Action(base.MarkDone)
			};
			this.OpenedViewName = new EUiViewName?(EUiViewName.SolarSchoolConfirmPopupView);
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolConfirmPopupView, param, null);
		}

		// Token: 0x06037F2D RID: 229165 RVA: 0x00FA3A88 File Offset: 0x00FA1C88
		private void OpenQuestUnlockPopup()
		{
			SolarSchoolQuest? quest = SolarSchoolConfig.Instance.GetQuest(this.QuestId);
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.SolarSchoolQuestUnlockTips)
			{
				DestroyFunction = new Action(base.MarkDone)
			};
			confirmBoxDataNew.SetTextArgs(new string[]
			{
				ConfigMultiTextLang.GetLocalTextNew(quest.Value.Name, null) ?? string.Empty
			});
			this.OpenedViewName = new EUiViewName?(EUiViewName.SolarSchoolConfirmPopupView);
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolConfirmPopupView, confirmBoxDataNew, null);
		}

		// Token: 0x06037F2E RID: 229166 RVA: 0x00FA3B14 File Offset: 0x00FA1D14
		private void OpenBehaviorDonePopup()
		{
			if (this.BehaviorId <= 0 || SolarSchoolGamePlayModel.Instance.PlayerData.GetCurrentLevelRow(this.BehaviorId) == null)
			{
				this.FailWithLog("[SolarSchool] BehaviorDonePopupAction 参数非法");
				return;
			}
			this.OpenedViewName = new EUiViewName?(EUiViewName.SolarSchoolBehaviorDonePopupView);
			SolarSchoolUtils.ShowBehaviorDonePopup(this.BehaviorId, new Action(base.MarkDone), this.TextKey, this.ShowAttrList);
		}

		// Token: 0x06037F2F RID: 229167 RVA: 0x00FA3B88 File Offset: 0x00FA1D88
		private void OpenBehaviorLevelUpPopup()
		{
			if (this.BehaviorId <= 0 || SolarSchoolGamePlayModel.Instance.PlayerData.GetCurrentLevelRow(this.BehaviorId) == null)
			{
				this.FailWithLog("[SolarSchool] BehaviorLevelUpPopupAction 参数非法");
				return;
			}
			this.OpenedViewName = new EUiViewName?(EUiViewName.SolarSchoolConfirmPopupView);
			SolarSchoolUtils.ShowBehaviorLevelUpPopup(this.BehaviorId, new Action(base.MarkDone));
		}

		// Token: 0x06037F30 RID: 229168 RVA: 0x00FA3BF0 File Offset: 0x00FA1DF0
		private void OpenEventPopup()
		{
			ESolarSchoolPopupId popupId = (ESolarSchoolPopupId)this.PopupId;
			if (popupId == ESolarSchoolPopupId.None || SolarSchoolConfig.Instance.GetSolarSchoolPopup(this.PopupId) == null)
			{
				this.FailWithLog("[SolarSchool] EventPopupAction 参数非法");
				return;
			}
			List<string> list = new List<string>();
			if (this.BehaviorId > 0)
			{
				list.Add(SolarSchoolGamePlayModel.Instance.PlayerData.GetBehaviorNameWithLevel(this.BehaviorId));
			}
			this.OpenedViewName = new EUiViewName?(EUiViewName.SolarSchoolEventPopupView);
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolEventPopupView, new SolarSchoolEventPopupParam
			{
				PopupId = popupId,
				MainTitleParams = list,
				OnCloseCallback = new Action(base.MarkDone)
			}, null);
		}

		// Token: 0x06037F31 RID: 229169 RVA: 0x00FA3C9C File Offset: 0x00FA1E9C
		private void OpenAttrRankUpPopup()
		{
			if (this.AttributeRankUps.Count == 0)
			{
				this.FailWithLog("[SolarSchool] AttrRankUpPopupAction 参数非法");
				return;
			}
			foreach (SolarSchoolAttrRankUpInfo solarSchoolAttrRankUpInfo in this.AttributeRankUps)
			{
				if (solarSchoolAttrRankUpInfo.Attr == ESolarSchoolSecondAttr.None || solarSchoolAttrRankUpInfo.NewValue <= solarSchoolAttrRankUpInfo.OldValue || SolarSchoolGamePlayModel.Instance.GetAttrConfig(solarSchoolAttrRankUpInfo.Attr) == null)
				{
					this.FailWithLog("[SolarSchool] AttrRankUpPopupAction 参数非法");
					return;
				}
			}
			this.OpenedViewName = new EUiViewName?(EUiViewName.SolarSchoolUpgradePopupView);
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolUpgradePopupView, new SolarSchoolUpgradePopupParam
			{
				AttrList = new List<SolarSchoolAttrRankUpInfo>(this.AttributeRankUps),
				CloseCallback = new Action(base.MarkDone)
			}, delegate(bool isSuccess, int _)
			{
				if (!isSuccess)
				{
					SolarSchoolGamePlayModel.Instance.RequeueAttrRankUps(this.AttributeRankUps);
					base.MarkDone();
				}
			});
		}

		// Token: 0x06037F32 RID: 229170 RVA: 0x00FA3D94 File Offset: 0x00FA1F94
		private unsafe void FailWithLog(string message)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.LRC;
			<>y__InlineArray19<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray19<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray19<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("actionId", base.ActionId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray19<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("popupType", this.PopupType);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray19<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("itemId", this.ItemId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray19<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("count", this.Count);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray19<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("roleId", this.RoleId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray19<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("previousLevel", this.PreviousLevel);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray19<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("finalLevel", this.FinalLevel);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray19<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 7) = new ValueTuple<string, object>("conditionGroupId", this.ConditionGroupId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray19<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 8) = new ValueTuple<string, object>("titleId", this.TitleId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray19<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 9) = new ValueTuple<string, object>("tipsKey", this.TipsKey);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray19<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 10) = new ValueTuple<string, object>("iconPath", this.IconPath);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray19<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 11) = new ValueTuple<string, object>("textKey", this.TextKey);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray19<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 12) = new ValueTuple<string, object>("confirmId", this.ConfirmId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray19<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 13) = new ValueTuple<string, object>("behaviorId", this.BehaviorId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray19<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 14) = new ValueTuple<string, object>("questId", this.QuestId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray19<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 15) = new ValueTuple<string, object>("popupId", this.PopupId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray19<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 16) = new ValueTuple<string, object>("cycleMin", this.CycleMin);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray19<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 17) = new ValueTuple<string, object>("cycleMax", this.CycleMax);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray19<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 18) = new ValueTuple<string, object>("attributeRankUpCount", this.AttributeRankUps.Count);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray19<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 19));
			base.MarkFailed();
		}

		// Token: 0x06037F33 RID: 229171 RVA: 0x00FA404B File Offset: 0x00FA224B
		protected override void OnDelete()
		{
			this.CloseOpenedView();
		}

		// Token: 0x06037F34 RID: 229172 RVA: 0x00FA4054 File Offset: 0x00FA2254
		private void CloseOpenedView()
		{
			if (this.OpenedViewName == null)
			{
				return;
			}
			EUiViewName value = this.OpenedViewName.Value;
			this.OpenedViewName = null;
			UiManager.Instance.CloseView(value, null);
		}

		// Token: 0x06037F35 RID: 229173 RVA: 0x00FA4094 File Offset: 0x00FA2294
		private SolarSchoolPopupAction.EPopupType ParsePopupType(string value)
		{
			foreach (SolarSchoolPopupAction.EPopupType epopupType in Enum.GetValues<SolarSchoolPopupAction.EPopupType>())
			{
				if (epopupType != SolarSchoolPopupAction.EPopupType.None && string.Equals(value, epopupType.ToString(), StringComparison.OrdinalIgnoreCase))
				{
					return epopupType;
				}
			}
			return SolarSchoolPopupAction.EPopupType.None;
		}

		// Token: 0x0401D826 RID: 120870
		private const string ParamKeyPopupType = "PopupType";

		// Token: 0x0401D827 RID: 120871
		private const string ParamKeyPopupId = "PopupId";

		// Token: 0x0401D828 RID: 120872
		private const string ParamKeyBehaviorId = "SolarSchoolBehaviorId";

		// Token: 0x0401D829 RID: 120873
		private const string ParamKeyAttributeCount = "AttributeCount";

		// Token: 0x0401D82A RID: 120874
		private const string ParamKeyTextKey = "TextKey";

		// Token: 0x0401D82B RID: 120875
		private const string ParamKeyShowAttrList = "ShowAttrList";

		// Token: 0x0401D82C RID: 120876
		private const string ParamKeyCycleMin = "CycleMin";

		// Token: 0x0401D82D RID: 120877
		private const string ParamKeyCycleMax = "CycleMax";

		// Token: 0x0401D82E RID: 120878
		private SolarSchoolPopupAction.EPopupType PopupType;

		// Token: 0x0401D82F RID: 120879
		private int ItemId;

		// Token: 0x0401D830 RID: 120880
		private int Count;

		// Token: 0x0401D831 RID: 120881
		private int RoleId;

		// Token: 0x0401D832 RID: 120882
		private int PreviousLevel;

		// Token: 0x0401D833 RID: 120883
		private int FinalLevel;

		// Token: 0x0401D834 RID: 120884
		private int ConditionGroupId;

		// Token: 0x0401D835 RID: 120885
		private int ConfirmId;

		// Token: 0x0401D836 RID: 120886
		private int BehaviorId;

		// Token: 0x0401D837 RID: 120887
		private int QuestId;

		// Token: 0x0401D838 RID: 120888
		private int PopupId;

		// Token: 0x0401D839 RID: 120889
		private string TitleId = string.Empty;

		// Token: 0x0401D83A RID: 120890
		private string TipsKey = string.Empty;

		// Token: 0x0401D83B RID: 120891
		private string IconPath = string.Empty;

		// Token: 0x0401D83C RID: 120892
		private string TextKey = string.Empty;

		// Token: 0x0401D83D RID: 120893
		private bool ShowAttrList = true;

		// Token: 0x0401D83E RID: 120894
		private int CycleMin;

		// Token: 0x0401D83F RID: 120895
		private int CycleMax;

		// Token: 0x0401D840 RID: 120896
		private readonly List<SolarSchoolAttrRankUpInfo> AttributeRankUps = new List<SolarSchoolAttrRankUpInfo>();

		// Token: 0x0401D841 RID: 120897
		private EUiViewName? OpenedViewName;

		// Token: 0x0200B4A9 RID: 46249
		[NullableContext(0)]
		private enum EPopupType
		{
			// Token: 0x04037DE1 RID: 228833
			None,
			// Token: 0x04037DE2 RID: 228834
			Tips,
			// Token: 0x04037DE3 RID: 228835
			Favor,
			// Token: 0x04037DE4 RID: 228836
			UnlockItem,
			// Token: 0x04037DE5 RID: 228837
			Build,
			// Token: 0x04037DE6 RID: 228838
			Confirm,
			// Token: 0x04037DE7 RID: 228839
			BehaviorDone,
			// Token: 0x04037DE8 RID: 228840
			BehaviorLevelUp,
			// Token: 0x04037DE9 RID: 228841
			QuestUnlock,
			// Token: 0x04037DEA RID: 228842
			Event,
			// Token: 0x04037DEB RID: 228843
			AttrRankUp
		}
	}
}
