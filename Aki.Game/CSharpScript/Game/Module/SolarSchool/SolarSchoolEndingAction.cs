using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.ActivityAction;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058B3 RID: 22707
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolEndingAction : SolarSchoolActionBase
	{
		// Token: 0x06037EE4 RID: 229092 RVA: 0x00FA20DF File Offset: 0x00FA02DF
		protected override void OnParse(IReadOnlyDictionary<string, string> parameters)
		{
			this.EndingType = (ESolarSchoolEndingType)ActivityActionBase.GetParamInt(parameters, "EndingType", 0);
		}

		// Token: 0x06037EE5 RID: 229093 RVA: 0x00FA20F4 File Offset: 0x00FA02F4
		protected override void OnStart()
		{
			List<SolarSchoolEnding> list = SolarSchoolUtils.FilterAvailableEndings(SolarSchoolConfig.Instance.GetEndingList(SolarSchoolGamePlayModel.Instance.ActivityId), this.EndingType);
			ESolarSchoolEndingType endingType = this.EndingType;
			if (endingType == ESolarSchoolEndingType.True)
			{
				this.StartTrueEnding(list);
				return;
			}
			if (endingType - ESolarSchoolEndingType.Career > 1)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.SWC;
				string message = "[SolarSchool] 结局 Action 的 EndingType 非法";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("endingType", this.EndingType);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				base.MarkFailed();
				return;
			}
			this.OpenChooseEndingView(list);
		}

		// Token: 0x06037EE6 RID: 229094 RVA: 0x00FA217E File Offset: 0x00FA037E
		protected override void OnDelete()
		{
			this.CancelRuntime();
		}

		// Token: 0x06037EE7 RID: 229095 RVA: 0x00FA2186 File Offset: 0x00FA0386
		protected override void OnFinish()
		{
			this.IsWaitingForSelection = false;
			SolarSchoolGamePlayModel.Instance.SetDateHiddenByEnding(false);
		}

		// Token: 0x06037EE8 RID: 229096 RVA: 0x00FA219C File Offset: 0x00FA039C
		private void StartTrueEnding(IReadOnlyList<SolarSchoolEnding> trueEndings)
		{
			if (trueEndings.Count == 0)
			{
				Log.Instance.Error(ELogModule.SolarSchool, ELogAuthor.SWC, "[SolarSchool] 真结局 Action 被触发但真结局条件未满足", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.MarkFailed();
				return;
			}
			this.PlayEndingAsync(trueEndings[0]).Forget();
		}

		// Token: 0x06037EE9 RID: 229097 RVA: 0x00FA21EC File Offset: 0x00FA03EC
		private void OpenChooseEndingView(IReadOnlyList<SolarSchoolEnding> endings)
		{
			if (endings.Count == 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 结局 Action 被触发但没有满足条件的结局";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("endingType", this.EndingType);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				base.MarkFailed();
				return;
			}
			this.IsWaitingForSelection = true;
			SolarSchoolGamePlayModel.Instance.SetDateHiddenByEnding(true);
			List<int> list = new List<int>(endings.Count);
			for (int i = 0; i < endings.Count; i++)
			{
				list.Add(endings[i].Id);
			}
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolChooseEndingView, new SolarSchoolChooseEndingViewParam(SolarSchoolGamePlayModel.Instance.ActivityId, this.EndingType, list, delegate(int endingId)
			{
				this.OnEndingSelected(endingId);
			}, new Action(this.OnSelectionCancelled)), delegate(bool success, int _)
			{
				if (success && !this.IsWaitingForSelection)
				{
					UiManager.Instance.CloseView(EUiViewName.SolarSchoolChooseEndingView, null);
					return;
				}
				if (!success)
				{
					this.OnSelectionCancelled();
				}
			});
		}

		// Token: 0x06037EEA RID: 229098 RVA: 0x00FA22CC File Offset: 0x00FA04CC
		private unsafe void OnEndingSelected(int endingId)
		{
			if (!this.IsWaitingForSelection)
			{
				return;
			}
			this.IsWaitingForSelection = false;
			List<SolarSchoolEnding> list = SolarSchoolUtils.FilterAvailableEndings(SolarSchoolConfig.Instance.GetEndingList(SolarSchoolGamePlayModel.Instance.ActivityId), this.EndingType);
			SolarSchoolEnding? solarSchoolEnding = null;
			foreach (SolarSchoolEnding value in list)
			{
				if (value.Id == endingId)
				{
					solarSchoolEnding = new SolarSchoolEnding?(value);
					break;
				}
			}
			if (solarSchoolEnding == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.SWC;
				string message = "[SolarSchool] 结局选择结果不在当前候选中";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("endingId", endingId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("endingType", this.EndingType);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				base.MarkFailed();
				return;
			}
			this.PlayEndingAsync(solarSchoolEnding.Value).Forget();
		}

		// Token: 0x06037EEB RID: 229099 RVA: 0x00FA23E4 File Offset: 0x00FA05E4
		private void OnSelectionCancelled()
		{
			if (!this.IsWaitingForSelection)
			{
				return;
			}
			this.IsWaitingForSelection = false;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.SWC;
			string message = "[SolarSchool] 玩家未完成结局选择";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("endingType", this.EndingType);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.MarkFailed();
		}

		// Token: 0x06037EEC RID: 229100 RVA: 0x00FA243C File Offset: 0x00FA063C
		private UniTask PlayEndingAsync(SolarSchoolEnding ending)
		{
			SolarSchoolEndingAction.<PlayEndingAsync>d__11 <PlayEndingAsync>d__;
			<PlayEndingAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayEndingAsync>d__.<>4__this = this;
			<PlayEndingAsync>d__.ending = ending;
			<PlayEndingAsync>d__.<>1__state = -1;
			<PlayEndingAsync>d__.<>t__builder.Start<SolarSchoolEndingAction.<PlayEndingAsync>d__11>(ref <PlayEndingAsync>d__);
			return <PlayEndingAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037EED RID: 229101 RVA: 0x00FA2488 File Offset: 0x00FA0688
		private unsafe void ShowTrueEndingConfirm(int endingId)
		{
			if (ConfirmBoxConfig.Instance.GetConfirmBoxConfig(624) == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.BB;
				string message = "[SolarSchool] 真结局确认框配置缺失，等待确认，不完成行为";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("configId", 624);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("endingId", endingId);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.SolarSchoolTrueEndingConfirm)
			{
				DestroyFunction = delegate()
				{
					this.EndingConfirmData = null;
				}
			};
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				this.CompleteEnding(endingId);
			};
			this.EndingConfirmData = confirmBoxDataNew;
			if (ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew))
			{
				return;
			}
			this.EndingConfirmData = null;
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.SolarSchool;
			ELogAuthor author2 = ELogAuthor.BB;
			string message2 = "[SolarSchool] 真结局确认框打开失败，等待确认，不完成行为";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("configId", 624);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("endingId", endingId);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
		}

		// Token: 0x06037EEE RID: 229102 RVA: 0x00FA25E6 File Offset: 0x00FA07E6
		private void CompleteEnding(int endingId)
		{
			SolarSchoolController.Instance.SendReachEnding(endingId);
			base.MarkDone();
		}

		// Token: 0x06037EEF RID: 229103 RVA: 0x00FA25FC File Offset: 0x00FA07FC
		private void CancelRuntime()
		{
			this.IsWaitingForSelection = false;
			if (this.EndingConfirmData != null)
			{
				this.EndingConfirmData.FunctionMap.Clear();
				this.EndingConfirmData = null;
				UiManager.Instance.CloseView(EUiViewName.SolarSchoolConfirmPopupView, null);
			}
			SolarSchoolVisualNovelEntry.StopCurrent();
			if (UiManager.Instance.IsViewOpen(EUiViewName.SolarSchoolChooseEndingView))
			{
				UiManager.Instance.CloseView(EUiViewName.SolarSchoolChooseEndingView, null);
			}
		}

		// Token: 0x0401D80D RID: 120845
		private ESolarSchoolEndingType EndingType;

		// Token: 0x0401D80E RID: 120846
		private bool IsWaitingForSelection;

		// Token: 0x0401D80F RID: 120847
		[Nullable(2)]
		private ConfirmBoxDataNew EndingConfirmData;
	}
}
