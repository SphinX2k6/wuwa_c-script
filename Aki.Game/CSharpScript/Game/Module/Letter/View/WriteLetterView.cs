using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay.WriteLetter;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Letter.View
{
	// Token: 0x020046A7 RID: 18087
	[NullableContext(1)]
	[Nullable(0)]
	public class WriteLetterView : UiViewBase
	{
		// Token: 0x0602D78F RID: 186255 RVA: 0x00CBC47F File Offset: 0x00CBA67F
		public WriteLetterView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602D790 RID: 186256 RVA: 0x00CBC494 File Offset: 0x00CBA694
		protected unsafe override void OnRegisterComponent()
		{
			int num = 12;
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
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUILayoutBase));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 4;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.OnClickSkip));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(9, new Action(this.OnClickHelp));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(10, new Action(this.OnClickBlankClose));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(11, new Action(this.OnClickNextFull));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602D791 RID: 186257 RVA: 0x00CBC6F4 File Offset: 0x00CBA8F4
		protected override UniTask OnBeforeStartAsync()
		{
			WriteLetterView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<WriteLetterView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602D792 RID: 186258 RVA: 0x00CBC738 File Offset: 0x00CBA938
		protected override void OnBeforeDestroy()
		{
			this.BlackScreenSuppressor.Restore().Forget();
			if (this.SentFinishRequest)
			{
				return;
			}
			IWriteLetterViewOpenParam writeLetterViewOpenParam = this.OpenParam as IWriteLetterViewOpenParam;
			int? num = (writeLetterViewOpenParam != null) ? writeLetterViewOpenParam.LetterId : null;
			if (num != null)
			{
				WriteLetterController.Instance.RequestWriteLetterSaveContent(num.Value);
			}
			string text = (writeLetterViewOpenParam != null) ? writeLetterViewOpenParam.GameplayId : null;
			if (string.IsNullOrEmpty(text))
			{
				return;
			}
			this.SentFinishRequest = true;
			WriteLetterController.Instance.RequestWriteLetterComplete(text);
		}

		// Token: 0x0602D793 RID: 186259 RVA: 0x00CBC7C4 File Offset: 0x00CBA9C4
		private UniTask CloseWithBlackScreen()
		{
			WriteLetterView.<CloseWithBlackScreen>d__12 <CloseWithBlackScreen>d__;
			<CloseWithBlackScreen>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CloseWithBlackScreen>d__.<>4__this = this;
			<CloseWithBlackScreen>d__.<>1__state = -1;
			<CloseWithBlackScreen>d__.<>t__builder.Start<WriteLetterView.<CloseWithBlackScreen>d__12>(ref <CloseWithBlackScreen>d__);
			return <CloseWithBlackScreen>d__.<>t__builder.Task;
		}

		// Token: 0x0602D794 RID: 186260 RVA: 0x00CBC808 File Offset: 0x00CBAA08
		private void ApplyStyle(ELetterStyle letterStyle)
		{
			bool flag = letterStyle == ELetterStyle.A;
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			UUIItem item2 = base.GetItem(1);
			if (item2 != null)
			{
				item2.SetUIActive(flag);
			}
			UUIItem item3 = base.GetItem(2);
			if (item3 != null)
			{
				item3.SetUIActive(!flag);
			}
			UUIItem item4 = base.GetItem(3);
			if (item4 == null)
			{
				return;
			}
			item4.SetUIActive(!flag);
		}

		// Token: 0x0602D795 RID: 186261 RVA: 0x00CBC86C File Offset: 0x00CBAA6C
		[NullableContext(2)]
		private void RefreshOptions(ITalkItem talkItem)
		{
			List<ITalkOption> list = (talkItem != null) ? talkItem.Options : null;
			bool flag = ((list != null) ? list.Count : 0) > 0 && this.OptionList != null;
			LetterPanel innerLetterPanel = this.InnerLetterPanel;
			if (innerLetterPanel != null && innerLetterPanel.IsAllShowTalkExhausted() && this.LastShowTalkFinishReached)
			{
				LetterPanel innerLetterPanel2 = this.InnerLetterPanel;
				if (innerLetterPanel2 != null)
				{
					innerLetterPanel2.SetNextButtonVisible(false);
				}
				UUIButtonComponent button = base.GetButton(11);
				if (button != null)
				{
					UUIItem uuiitem = button.RootUIComp.Get();
					if (uuiitem != null)
					{
						uuiitem.SetUIActive(false);
					}
				}
				if (!this.SwitchSeqStarted)
				{
					this.SwitchSeqStarted = true;
					this.PlaySwitchSequence().Forget();
				}
			}
			else
			{
				LetterPanel innerLetterPanel3 = this.InnerLetterPanel;
				if (innerLetterPanel3 != null)
				{
					innerLetterPanel3.SetNextButtonVisible(!flag);
				}
				UUIButtonComponent button2 = base.GetButton(11);
				if (button2 != null)
				{
					UUIItem uuiitem2 = button2.RootUIComp.Get();
					if (uuiitem2 != null)
					{
						uuiitem2.SetUIActive(!flag);
					}
				}
			}
			if (list != null && list.Count != 0 && this.OptionList != null)
			{
				UUIItem item = base.GetItem(5);
				if (item != null)
				{
					item.SetUIActive(true);
				}
				this.OptionList.RefreshByData(list, null, false);
				return;
			}
			UUIItem item2 = base.GetItem(5);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(false);
		}

		// Token: 0x0602D796 RID: 186262 RVA: 0x00CBC99C File Offset: 0x00CBAB9C
		private UniTask PlaySwitchSequence()
		{
			WriteLetterView.<PlaySwitchSequence>d__15 <PlaySwitchSequence>d__;
			<PlaySwitchSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlaySwitchSequence>d__.<>4__this = this;
			<PlaySwitchSequence>d__.<>1__state = -1;
			<PlaySwitchSequence>d__.<>t__builder.Start<WriteLetterView.<PlaySwitchSequence>d__15>(ref <PlaySwitchSequence>d__);
			return <PlaySwitchSequence>d__.<>t__builder.Task;
		}

		// Token: 0x0602D797 RID: 186263 RVA: 0x00CBC9DF File Offset: 0x00CBABDF
		private LetterOptionItem CreateOptionItem()
		{
			LetterOptionItem letterOptionItem = new LetterOptionItem();
			letterOptionItem.SetOnClick(new Action<ITalkOption>(this.OnClickOption));
			return letterOptionItem;
		}

		// Token: 0x0602D798 RID: 186264 RVA: 0x00CBC9F8 File Offset: 0x00CBABF8
		[NullableContext(2)]
		private void OnCurrentTalkChanged(ITalkItem talkItem)
		{
			this.RefreshOptions(talkItem);
			if (talkItem == null)
			{
				return;
			}
			ITalkItemDialog talkItemDialog = talkItem as ITalkItemDialog;
			bool flag;
			if (talkItemDialog == null)
			{
				flag = false;
			}
			else
			{
				ITalkItemStyle style = talkItemDialog.Style;
				ETalkItemStyle? etalkItemStyle = (style != null) ? new ETalkItemStyle?(style.Type) : null;
				ETalkItemStyle etalkItemStyle2 = ETalkItemStyle.InnerVoice;
				flag = (etalkItemStyle.GetValueOrDefault() == etalkItemStyle2 & etalkItemStyle != null);
			}
			if (flag)
			{
				return;
			}
			IWriteLetterViewOpenParam writeLetterViewOpenParam = this.OpenParam as IWriteLetterViewOpenParam;
			int? num = (writeLetterViewOpenParam != null) ? writeLetterViewOpenParam.LetterId : null;
			if (num == null)
			{
				return;
			}
			WriteLetterController.Instance.RecordWriteLetterContent(num.Value, talkItem);
		}

		// Token: 0x0602D799 RID: 186265 RVA: 0x00CBCA90 File Offset: 0x00CBAC90
		private void OnClickOption(ITalkOption option)
		{
			List<ActionInfo> actions = option.Actions;
			ActionInfo actionInfo;
			if (actions == null)
			{
				actionInfo = null;
			}
			else
			{
				actionInfo = actions.Find((ActionInfo action) => action.Name == EAction.JumpTalk);
			}
			ActionInfo actionInfo2 = actionInfo;
			if (actionInfo2 == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.YZH;
				string message = "[WriteLetterView] 选项未配置JumpTalk";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("TidTalkOption", option.TidTalkOption);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			JumpTalk jumpTalk = actionInfo2.Params as JumpTalk;
			LetterPanel innerLetterPanel = this.InnerLetterPanel;
			if (innerLetterPanel == null)
			{
				return;
			}
			innerLetterPanel.RevealTalkById(jumpTalk.TalkId);
		}

		// Token: 0x0602D79A RID: 186266 RVA: 0x00CBCB21 File Offset: 0x00CBAD21
		private void OnClickSkip()
		{
			LetterPanel innerLetterPanel = this.InnerLetterPanel;
			if (innerLetterPanel != null)
			{
				innerLetterPanel.SkipToFinish();
			}
			this.CloseWithBlackScreen().Forget();
		}

		// Token: 0x0602D79B RID: 186267 RVA: 0x00CBCB40 File Offset: 0x00CBAD40
		private void OnLastShowTalkFinished()
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Plot;
			ELogAuthor author = ELogAuthor.YZH;
			string message = "[WL-Finish] View.OnLastShowTalkFinished 被调用";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("AlreadyReached", this.LastShowTalkFinishReached);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			if (this.LastShowTalkFinishReached)
			{
				return;
			}
			this.LastShowTalkFinishReached = true;
			LetterPanel innerLetterPanel = this.InnerLetterPanel;
			this.RefreshOptions((innerLetterPanel != null) ? innerLetterPanel.GetCurrentTalkItem() : null);
		}

		// Token: 0x0602D79C RID: 186268 RVA: 0x00CBCBA5 File Offset: 0x00CBADA5
		private void OnClickHelp()
		{
		}

		// Token: 0x0602D79D RID: 186269 RVA: 0x00CBCBA7 File Offset: 0x00CBADA7
		private void OnClickBlankClose()
		{
			if (!this.SwitchSeqCompleted)
			{
				return;
			}
			this.CloseWithBlackScreen().Forget();
		}

		// Token: 0x0602D79E RID: 186270 RVA: 0x00CBCBBD File Offset: 0x00CBADBD
		private void OnClickNextFull()
		{
			LetterPanel innerLetterPanel = this.InnerLetterPanel;
			if (innerLetterPanel == null)
			{
				return;
			}
			innerLetterPanel.Advance();
		}

		// Token: 0x040185AE RID: 99758
		[Nullable(2)]
		private LetterPanel InnerLetterPanel;

		// Token: 0x040185AF RID: 99759
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<LetterOptionItem, ITalkOption> OptionList;

		// Token: 0x040185B0 RID: 99760
		private bool SentFinishRequest;

		// Token: 0x040185B1 RID: 99761
		private bool SwitchSeqStarted;

		// Token: 0x040185B2 RID: 99762
		private bool SwitchSeqCompleted;

		// Token: 0x040185B3 RID: 99763
		private bool LastShowTalkFinishReached;

		// Token: 0x040185B4 RID: 99764
		private readonly LetterBlackScreenSuppressor BlackScreenSuppressor = new LetterBlackScreenSuppressor();

		// Token: 0x0200A2D6 RID: 41686
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403282F RID: 206895
			public const int ItemBgA = 0;

			// Token: 0x04032830 RID: 206896
			public const int ItemFgA = 1;

			// Token: 0x04032831 RID: 206897
			public const int ItemBgB = 2;

			// Token: 0x04032832 RID: 206898
			public const int ItemFgB = 3;

			// Token: 0x04032833 RID: 206899
			public const int ItemLetterPanel = 4;

			// Token: 0x04032834 RID: 206900
			public const int ItemOptionPanel = 5;

			// Token: 0x04032835 RID: 206901
			public const int OptionLayout = 6;

			// Token: 0x04032836 RID: 206902
			public const int OptionToggle = 7;

			// Token: 0x04032837 RID: 206903
			public const int BtnSkip = 8;

			// Token: 0x04032838 RID: 206904
			public const int BtnHelp = 9;

			// Token: 0x04032839 RID: 206905
			public const int BtnBlankClose = 10;

			// Token: 0x0403283A RID: 206906
			public const int BtnNextFull = 11;
		}
	}
}
