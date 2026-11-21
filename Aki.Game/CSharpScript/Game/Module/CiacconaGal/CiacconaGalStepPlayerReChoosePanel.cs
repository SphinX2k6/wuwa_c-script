using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02004BBF RID: 19391
	[NullableContext(2)]
	[Nullable(0)]
	public class CiacconaGalStepPlayerReChoosePanel : UiPanelBase
	{
		// Token: 0x0603068B RID: 198283 RVA: 0x00D7D408 File Offset: 0x00D7B608
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603068C RID: 198284 RVA: 0x00D7D4B4 File Offset: 0x00D7B6B4
		protected override UniTask OnBeforeStartAsync()
		{
			CiacconaGalStepPlayerReChoosePanel.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CiacconaGalStepPlayerReChoosePanel.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603068D RID: 198285 RVA: 0x00D7D4F7 File Offset: 0x00D7B6F7
		protected override void OnStart()
		{
			this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x0603068E RID: 198286 RVA: 0x00D7D50C File Offset: 0x00D7B70C
		[NullableContext(1)]
		public void Refresh(CiacconaGalStepData stepData, CiacconaGalChoiceData choiceData)
		{
			this.PlainTextTop.Refresh(stepData.Content);
			this.PlainTextTop.SetUiActive(!StringUtils.IsEmpty(stepData.Content));
			CiacconaGalReChooseChoiceParam data = new CiacconaGalReChooseChoiceParam
			{
				Text = choiceData.Content,
				TogState = EToggleState.ETT_UnDetermined,
				IconResId = "T_PlotReasoningIcon03"
			};
			this.ChoiceTop.Refresh(data, false, 0);
			this.ChoiceTop.SetInteractive(false);
			this.PlainTextBottom.Refresh("Xkjsx_Option_Title");
			this.ChoiceListBottom.Refresh(delegate
			{
				EventSystem.Instance.Emit<CiacconaGalStepData, CiacconaGalChoiceData>(EEventName.OnCiacconaReChooseConfirm, stepData, choiceData);
			}, delegate
			{
				EventSystem.Instance.Emit(EEventName.OnCiacconaReChooseCancel);
			});
		}

		// Token: 0x0603068F RID: 198287 RVA: 0x00D7D5EC File Offset: 0x00D7B7EC
		public void PlayStart()
		{
			LevelSequencePlayer seqPlayer = this.SeqPlayer;
			if (seqPlayer == null)
			{
				return;
			}
			seqPlayer.PlayLevelSequenceByName("Start", false, null, false);
		}

		// Token: 0x06030690 RID: 198288 RVA: 0x00D7D61C File Offset: 0x00D7B81C
		public UniTask PlayCloseAsync()
		{
			CiacconaGalStepPlayerReChoosePanel.<PlayCloseAsync>d__11 <PlayCloseAsync>d__;
			<PlayCloseAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayCloseAsync>d__.<>4__this = this;
			<PlayCloseAsync>d__.<>1__state = -1;
			<PlayCloseAsync>d__.<>t__builder.Start<CiacconaGalStepPlayerReChoosePanel.<PlayCloseAsync>d__11>(ref <PlayCloseAsync>d__);
			return <PlayCloseAsync>d__.<>t__builder.Task;
		}

		// Token: 0x04019A4B RID: 105035
		private CiacconaGalReChoosePlainTextItem PlainTextTop;

		// Token: 0x04019A4C RID: 105036
		private CiacconaGalReChooseChoiceItem ChoiceTop;

		// Token: 0x04019A4D RID: 105037
		private CiacconaGalReChoosePlainTextItem PlainTextBottom;

		// Token: 0x04019A4E RID: 105038
		private CiacconaGalReChooseChoiceList ChoiceListBottom;

		// Token: 0x04019A4F RID: 105039
		private LevelSequencePlayer SeqPlayer;

		// Token: 0x0200A7C7 RID: 42951
		[NullableContext(0)]
		public class EMainComponentDefine
		{
			// Token: 0x04033D3F RID: 212287
			public const int ItemChoiceTop = 1;

			// Token: 0x04033D40 RID: 212288
			public const int ItemPlainTextBottom = 2;

			// Token: 0x04033D41 RID: 212289
			public const int ItemChoiceListBottom = 3;

			// Token: 0x04033D42 RID: 212290
			public const int ItemPlainTextTop = 4;
		}
	}
}
