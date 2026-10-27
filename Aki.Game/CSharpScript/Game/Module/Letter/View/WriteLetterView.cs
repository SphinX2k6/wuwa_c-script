using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x020056D0 RID: 22224
	[NullableContext(1)]
	[Nullable(0)]
	public class WriteLetterView : UiViewBase
	{
		// Token: 0x0603887F RID: 231551 RVA: 0x00D6DEB7 File Offset: 0x00D6C0B7
		public WriteLetterView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06038880 RID: 231552 RVA: 0x00D6DECC File Offset: 0x00D6C0CC
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

		// Token: 0x06038881 RID: 231553 RVA: 0x00D6E12C File Offset: 0x00D6C32C
		protected override UniTask OnBeforeStartAsync()
		{
			WriteLetterView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<WriteLetterView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038882 RID: 231554 RVA: 0x00D6E170 File Offset: 0x00D6C370
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

		// Token: 0x06038883 RID: 231555 RVA: 0x00D6E1FC File Offset: 0x00D6C3FC
		private UniTask CloseWithBlackScreen()
		{
			WriteLetterView.<CloseWithBlackScreen>d__12 <CloseWithBlackScreen>d__;
			<CloseWithBlackScreen>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CloseWithBlackScreen>d__.<>4__this = this;
			<CloseWithBlackScreen>d__.<>1__state = -1;
			<CloseWithBlackScreen>d__.<>t__builder.Start<WriteLetterView.<CloseWithBlackScreen>d__12>(ref <CloseWithBlackScreen>d__);
			return <CloseWithBlackScreen>d__.<>t__builder.Task;
		}

		// Token: 0x06038884 RID: 231556 RVA: 0x00D6E240 File Offset: 0x00D6C440
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

		// Token: 0x06038885 RID: 231557 RVA: 0x00D6E2A4 File Offset: 0x00D6C4A4
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
				this.OptionList.RefreshByData(list.ToList<ITalkOption>(), null, false);
				return;
			}
			UUIItem item2 = base.GetItem(5);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(false);
		}

		// Token: 0x06038886 RID: 231558 RVA: 0x00D6E3D8 File Offset: 0x00D6C5D8
		private UniTask PlaySwitchSequence()
		{
			WriteLetterView.<PlaySwitchSequence>d__15 <PlaySwitchSequence>d__;
			<PlaySwitchSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlaySwitchSequence>d__.<>4__this = this;
			<PlaySwitchSequence>d__.<>1__state = -1;
			<PlaySwitchSequence>d__.<>t__builder.Start<WriteLetterView.<PlaySwitchSequence>d__15>(ref <PlaySwitchSequence>d__);
			return <PlaySwitchSequence>d__.<>t__builder.Task;
		}

		// Token: 0x06038887 RID: 231559 RVA: 0x00D6E41B File Offset: 0x00D6C61B
		private LetterOptionItem CreateOptionItem()
		{
			LetterOptionItem letterOptionItem = new LetterOptionItem();
			letterOptionItem.SetOnClick(new Action<ITalkOption>(this.OnClickOption));
			return letterOptionItem;
		}

		// Token: 0x06038888 RID: 231560 RVA: 0x00D6E434 File Offset: 0x00D6C634
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

		// Token: 0x06038889 RID: 231561 RVA: 0x00D6E4CC File Offset: 0x00D6C6CC
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

		// Token: 0x0603888A RID: 231562 RVA: 0x00D6E55D File Offset: 0x00D6C75D
		private void OnClickSkip()
		{
			LetterPanel innerLetterPanel = this.InnerLetterPanel;
			if (innerLetterPanel != null)
			{
				innerLetterPanel.SkipToFinish();
			}
			this.CloseWithBlackScreen().Forget();
		}

		// Token: 0x0603888B RID: 231563 RVA: 0x00D6E57C File Offset: 0x00D6C77C
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

		// Token: 0x0603888C RID: 231564 RVA: 0x00D6E5E1 File Offset: 0x00D6C7E1
		private void OnClickHelp()
		{
		}

		// Token: 0x0603888D RID: 231565 RVA: 0x00D6E5E3 File Offset: 0x00D6C7E3
		private void OnClickBlankClose()
		{
			if (!this.SwitchSeqCompleted)
			{
				return;
			}
			this.CloseWithBlackScreen().Forget();
		}

		// Token: 0x0603888E RID: 231566 RVA: 0x00D6E5F9 File Offset: 0x00D6C7F9
		private void OnClickNextFull()
		{
			LetterPanel innerLetterPanel = this.InnerLetterPanel;
			if (innerLetterPanel == null)
			{
				return;
			}
			innerLetterPanel.Advance();
		}

		// Token: 0x0401DB18 RID: 121624
		[Nullable(2)]
		private LetterPanel InnerLetterPanel;

		// Token: 0x0401DB19 RID: 121625
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<LetterOptionItem, ITalkOption> OptionList;

		// Token: 0x0401DB1A RID: 121626
		private bool SentFinishRequest;

		// Token: 0x0401DB1B RID: 121627
		private bool SwitchSeqStarted;

		// Token: 0x0401DB1C RID: 121628
		private bool SwitchSeqCompleted;

		// Token: 0x0401DB1D RID: 121629
		private bool LastShowTalkFinishReached;

		// Token: 0x0401DB1E RID: 121630
		private readonly LetterBlackScreenSuppressor BlackScreenSuppressor = new LetterBlackScreenSuppressor();

		// Token: 0x0200B8AF RID: 47279
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04037E16 RID: 228886
			public const int ItemBgA = 0;

			// Token: 0x04037E17 RID: 228887
			public const int ItemFgA = 1;

			// Token: 0x04037E18 RID: 228888
			public const int ItemBgB = 2;

			// Token: 0x04037E19 RID: 228889
			public const int ItemFgB = 3;

			// Token: 0x04037E1A RID: 228890
			public const int ItemLetterPanel = 4;

			// Token: 0x04037E1B RID: 228891
			public const int ItemOptionPanel = 5;

			// Token: 0x04037E1C RID: 228892
			public const int OptionLayout = 6;

			// Token: 0x04037E1D RID: 228893
			public const int OptionToggle = 7;

			// Token: 0x04037E1E RID: 228894
			public const int BtnSkip = 8;

			// Token: 0x04037E1F RID: 228895
			public const int BtnHelp = 9;

			// Token: 0x04037E20 RID: 228896
			public const int BtnBlankClose = 10;

			// Token: 0x04037E21 RID: 228897
			public const int BtnNextFull = 11;
		}
	}
}
