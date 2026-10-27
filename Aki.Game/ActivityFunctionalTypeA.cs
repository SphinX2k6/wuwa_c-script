using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ResManager;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001550 RID: 5456
[NullableContext(2)]
[Nullable(0)]
public class ActivityFunctionalTypeA : UiPanelBase
{
	// Token: 0x17000D61 RID: 3425
	// (get) Token: 0x06009C16 RID: 39958 RVA: 0x0021C778 File Offset: 0x0021A978
	// (set) Token: 0x06009C17 RID: 39959 RVA: 0x0021C780 File Offset: 0x0021A980
	public ActivityButtonItem FunctionButton { get; private set; }

	// Token: 0x17000D62 RID: 3426
	// (get) Token: 0x06009C18 RID: 39960 RVA: 0x0021C789 File Offset: 0x0021A989
	// (set) Token: 0x06009C19 RID: 39961 RVA: 0x0021C791 File Offset: 0x0021A991
	public ButtonSpriteItem CircleButton { get; private set; }

	// Token: 0x17000D63 RID: 3427
	// (get) Token: 0x06009C1A RID: 39962 RVA: 0x0021C79A File Offset: 0x0021A99A
	// (set) Token: 0x06009C1B RID: 39963 RVA: 0x0021C7A2 File Offset: 0x0021A9A2
	public FunctionalPanelConditionLock PanelLock { get; private set; }

	// Token: 0x17000D64 RID: 3428
	// (get) Token: 0x06009C1C RID: 39964 RVA: 0x0021C7AB File Offset: 0x0021A9AB
	// (set) Token: 0x06009C1D RID: 39965 RVA: 0x0021C7B3 File Offset: 0x0021A9B3
	public FunctionalPanelConditionActivate PanelActivate { get; private set; }

	// Token: 0x17000D65 RID: 3429
	// (get) Token: 0x06009C1E RID: 39966 RVA: 0x0021C7BC File Offset: 0x0021A9BC
	// (set) Token: 0x06009C1F RID: 39967 RVA: 0x0021C7C4 File Offset: 0x0021A9C4
	protected ActivityBaseData Data { get; set; }

	// Token: 0x06009C20 RID: 39968 RVA: 0x0021C7CD File Offset: 0x0021A9CD
	public ActivityFunctionalTypeA(ActivityBaseData data)
	{
		this.Data = data;
	}

	// Token: 0x06009C21 RID: 39969 RVA: 0x0021C7DC File Offset: 0x0021A9DC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 8;
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
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06009C22 RID: 39970 RVA: 0x0021C90C File Offset: 0x0021AB0C
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityFunctionalTypeA.<OnBeforeStartAsync>d__23 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityFunctionalTypeA.<OnBeforeStartAsync>d__23>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009C23 RID: 39971 RVA: 0x0021C94F File Offset: 0x0021AB4F
	[NullableContext(1)]
	public void SetLockTextByTextId(string textId, params string[] args)
	{
		this.PanelLock.SetTextByTextId(textId, args);
	}

	// Token: 0x06009C24 RID: 39972 RVA: 0x0021C95E File Offset: 0x0021AB5E
	[NullableContext(1)]
	public void SetLockTextByText(string text)
	{
		this.PanelLock.SetTextByText(text);
	}

	// Token: 0x06009C25 RID: 39973 RVA: 0x0021C96C File Offset: 0x0021AB6C
	public void SetLockSpriteVisible(bool bVisible)
	{
		this.PanelLock.SetSpriteVisible(bVisible);
	}

	// Token: 0x06009C26 RID: 39974 RVA: 0x0021C97A File Offset: 0x0021AB7A
	public void SetPanelConditionVisible(bool bVisible)
	{
		base.GetItem(0).SetUIActive(bVisible);
	}

	// Token: 0x06009C27 RID: 39975 RVA: 0x0021C989 File Offset: 0x0021AB89
	public void SetLockConditionButtonVisible(bool bVisible)
	{
		this.PanelLock.SetButtonVisible(bVisible);
	}

	// Token: 0x06009C28 RID: 39976 RVA: 0x0021C997 File Offset: 0x0021AB97
	[NullableContext(1)]
	public void SetActivateTextByTextId(string textId, params string[] args)
	{
		this.PanelActivate.SetTextByTextId(textId, args);
	}

	// Token: 0x06009C29 RID: 39977 RVA: 0x0021C9A6 File Offset: 0x0021ABA6
	[NullableContext(1)]
	public void SetActivateTextByText(string text)
	{
		this.PanelActivate.SetTextByText(text);
	}

	// Token: 0x06009C2A RID: 39978 RVA: 0x0021C9B4 File Offset: 0x0021ABB4
	public void SetActivateSpriteVisible(bool bVisible)
	{
		this.PanelActivate.SetSpriteVisible(bVisible);
	}

	// Token: 0x06009C2B RID: 39979 RVA: 0x0021C9C2 File Offset: 0x0021ABC2
	public void SetActivatePanelConditionVisible(bool bVisible)
	{
		base.GetItem(2).SetUIActive(bVisible);
	}

	// Token: 0x06009C2C RID: 39980 RVA: 0x0021C9D1 File Offset: 0x0021ABD1
	public void SetRewardButtonVisible(bool bVisible)
	{
		base.GetItem(4).SetUIActive(bVisible);
	}

	// Token: 0x06009C2D RID: 39981 RVA: 0x0021C9E0 File Offset: 0x0021ABE0
	[NullableContext(1)]
	public void SetRewardButtonFunction(Action buttonFunction)
	{
		this.CircleButton.SetFunction(buttonFunction);
	}

	// Token: 0x06009C2E RID: 39982 RVA: 0x0021C9EE File Offset: 0x0021ABEE
	public void SetFunctionRedDotVisible(bool bVisible)
	{
		this.FunctionButton.SetRedDotVisible(bVisible);
	}

	// Token: 0x06009C2F RID: 39983 RVA: 0x0021C9FC File Offset: 0x0021ABFC
	[NullableContext(1)]
	public void SetPanelTipByTextId(string textId, params string[] args)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(7), textId, args);
	}

	// Token: 0x06009C30 RID: 39984 RVA: 0x0021CA11 File Offset: 0x0021AC11
	[NullableContext(1)]
	public void SetPanelTipByText(string text)
	{
		base.GetText(7).SetText(text, true);
	}

	// Token: 0x06009C31 RID: 39985 RVA: 0x0021CA21 File Offset: 0x0021AC21
	public void SetPanelTipVisible(bool bVisible)
	{
		base.GetItem(6).SetUIActive(bVisible);
	}

	// Token: 0x06009C32 RID: 39986 RVA: 0x0021CA30 File Offset: 0x0021AC30
	public void RefreshGeneralPerformance(IActivityFunctionAreaParams parameters = null)
	{
		if (this.Data == null)
		{
			Log.Instance.Error(ELogModule.Activity, ELogAuthor.YYZ, "未传递活动数据,请传递数据再刷新", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		bool flag = this.Data.IsUnLock();
		bool flag2 = this.Data.CanPreOpen();
		bool flag3 = this.Data.HasPreOpenCondition();
		if (flag)
		{
			if (parameters != null)
			{
				this.SetGeneralUnlockPerformance(parameters);
			}
			return;
		}
		if (!flag3)
		{
			this.FunctionButton.SetUiActive(false);
			this.SetPerformanceConditionLock(this.Data.ConditionGroupId, this.Data.Id);
			return;
		}
		if (flag2)
		{
			this.SetPanelTipByTextId("ActivityPreOpenTip", Array.Empty<string>());
			this.SetPanelTipVisible(true);
			this.FunctionButton.SetLocalTextNew("ActivityPreOpen", Array.Empty<object>());
			Action <>9__1;
			this.FunctionButton.SetFunction(delegate
			{
				ActivityController instance = ActivityController.Instance;
				ActivityBaseData data = this.Data;
				Action onClicked;
				if ((onClicked = <>9__1) == null)
				{
					onClicked = (<>9__1 = delegate()
					{
						IActivityFunctionAreaParams parameters2 = parameters;
						if (((parameters2 != null) ? parameters2.BeforePreOpenCheck : null) != null && !parameters.BeforePreOpenCheck())
						{
							return;
						}
						this.OpenPreOpenRequestConfirmBox();
					});
				}
				instance.JumpAndLog(data, onClicked);
			});
			this.FunctionButton.SetUiActive(true);
			this.SetPanelConditionVisible(false);
			return;
		}
		this.FunctionButton.SetUiActive(false);
		this.SetPerformanceConditionLock(this.Data.PreOpenConditionGroupId, this.Data.Id);
	}

	// Token: 0x06009C33 RID: 39987 RVA: 0x0021CB64 File Offset: 0x0021AD64
	[NullableContext(1)]
	public void SetGeneralUnlockPerformance(IActivityFunctionAreaParams parameters)
	{
		this.SetPanelConditionVisible(false);
		this.SetPanelTipVisible(false);
		if (parameters.UnlockBtnTextId != null)
		{
			if (parameters.UnlockBtnTextArgs != null)
			{
				ActivityButtonItem functionButton = this.FunctionButton;
				string unlockBtnTextId = parameters.UnlockBtnTextId;
				object[] unlockBtnTextArgs = parameters.UnlockBtnTextArgs;
				functionButton.SetLocalTextNew(unlockBtnTextId, unlockBtnTextArgs);
			}
			else
			{
				this.FunctionButton.SetLocalTextNew(parameters.UnlockBtnTextId, Array.Empty<object>());
			}
		}
		if (parameters.UnlockBtnFunction != null)
		{
			this.FunctionButton.SetFunction(parameters.UnlockBtnFunction);
		}
		this.FunctionButton.SetUiActive(true);
	}

	// Token: 0x06009C34 RID: 39988 RVA: 0x0021CBE5 File Offset: 0x0021ADE5
	public void SetPerformanceOpenTimeOver()
	{
		this.SetPanelConditionVisible(true);
		this.SetLockTextByTextId("Activity_EndDesc01", Array.Empty<string>());
		this.SetActivatePanelConditionVisible(false);
		this.SetLockConditionButtonVisible(false);
		this.SetRewardButtonVisible(false);
		this.FunctionButton.SetUiActive(false);
	}

	// Token: 0x06009C35 RID: 39989 RVA: 0x0021CC20 File Offset: 0x0021AE20
	public void SetPerformanceConditionLock(int conditionGroupId, int activityId)
	{
		this.SetPanelConditionVisible(true);
		this.SetActivatePanelConditionVisible(false);
		this.SetLockConditionButtonVisible(true);
		string conditionGroupHintText = LevelGeneralCommons.GetConditionGroupHintText(conditionGroupId);
		if (conditionGroupHintText != null)
		{
			this.SetLockTextByTextId(conditionGroupHintText, Array.Empty<string>());
		}
		this.PanelLock.ButtonCallBack = delegate()
		{
			ActivityController.Instance.OpenActivityConditionView(activityId);
		};
	}

	// Token: 0x06009C36 RID: 39990 RVA: 0x0021CC7C File Offset: 0x0021AE7C
	[NullableContext(1)]
	public void SetPerformanceSubPackageLock(string textId, List<int> subPackageIdList)
	{
		this.SetPanelConditionVisible(true);
		this.SetActivatePanelConditionVisible(false);
		this.SetLockConditionButtonVisible(true);
		this.PanelLock.ButtonCallBack = delegate()
		{
			foreach (int id in subPackageIdList)
			{
				DownLoadSubPackage? downLoadSubPackageById = SubPackageConfig.Instance.GetDownLoadSubPackageById(id);
				if (downLoadSubPackageById != null)
				{
					foreach (int blockId in downLoadSubPackageById.Value.GetAreaArray())
					{
						if (ResourceManagerController.Instance.IsNeedReOpenMap(blockId))
						{
							SubPackageDownLoadModel.Instance.OpenBlockNeedReLoginConfirm();
							return;
						}
					}
				}
			}
			SubPackageDownLoadModel.Instance.OpenSubPackageDownLoadConfirmBySubPackageIds(textId, subPackageIdList);
		};
	}

	// Token: 0x06009C37 RID: 39991 RVA: 0x0021CCCC File Offset: 0x0021AECC
	public void OpenPreOpenRequestConfirmBox()
	{
		if (this.Data == null)
		{
			return;
		}
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ActivityPreOpen);
		Action value = delegate()
		{
			Action<bool> callback = delegate(bool success)
			{
				if (!success)
				{
					return;
				}
				EventSystem.Instance.Emit<int>(EEventName.ActivityViewRefreshCurrent, this.Data.Id);
			};
			ActivityController.Instance.RequestPreOpenActivity(this.Data, callback);
		};
		confirmBoxDataNew.FunctionMap.Add(2, value);
		string preOpenText = this.Data.LocalConfig.Value.PreOpenText;
		if (preOpenText != null)
		{
			confirmBoxDataNew.SetTextArgs(new string[]
			{
				ConfigMultiTextLang.GetLocalTextNew(preOpenText, null)
			});
		}
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06009C38 RID: 39992 RVA: 0x0021CD45 File Offset: 0x0021AF45
	public UUIItem GetFunctionButtonItem()
	{
		return base.GetItem(1);
	}

	// Token: 0x02007B8C RID: 31628
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040289CF RID: 166351
		public const int PanelCondition = 0;

		// Token: 0x040289D0 RID: 166352
		public const int FunctionButton = 1;

		// Token: 0x040289D1 RID: 166353
		public const int PanelActivate = 2;

		// Token: 0x040289D2 RID: 166354
		public const int FunctionRedDot = 3;

		// Token: 0x040289D3 RID: 166355
		public const int PanelCircle = 4;

		// Token: 0x040289D4 RID: 166356
		public const int ButtonCircle = 5;

		// Token: 0x040289D5 RID: 166357
		public const int PanelTip = 6;

		// Token: 0x040289D6 RID: 166358
		public const int TxtTip = 7;
	}
}
