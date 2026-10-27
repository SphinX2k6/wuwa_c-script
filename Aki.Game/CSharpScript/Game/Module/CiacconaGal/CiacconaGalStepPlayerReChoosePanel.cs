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
	// Token: 0x02005BDF RID: 23519
	[NullableContext(2)]
	[Nullable(0)]
	public class CiacconaGalStepPlayerReChoosePanel : UiPanelBase
	{
		// Token: 0x0603B740 RID: 243520 RVA: 0x00E2D100 File Offset: 0x00E2B300
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

		// Token: 0x0603B741 RID: 243521 RVA: 0x00E2D1AC File Offset: 0x00E2B3AC
		protected override UniTask OnBeforeStartAsync()
		{
			CiacconaGalStepPlayerReChoosePanel.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CiacconaGalStepPlayerReChoosePanel.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603B742 RID: 243522 RVA: 0x00E2D1EF File Offset: 0x00E2B3EF
		protected override void OnStart()
		{
			this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x0603B743 RID: 243523 RVA: 0x00E2D204 File Offset: 0x00E2B404
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

		// Token: 0x0603B744 RID: 243524 RVA: 0x00E2D2E4 File Offset: 0x00E2B4E4
		public void PlayStart()
		{
			LevelSequencePlayer seqPlayer = this.SeqPlayer;
			if (seqPlayer == null)
			{
				return;
			}
			seqPlayer.PlayLevelSequenceByName("Start", false, null, false);
		}

		// Token: 0x0603B745 RID: 243525 RVA: 0x00E2D314 File Offset: 0x00E2B514
		public UniTask PlayCloseAsync()
		{
			CiacconaGalStepPlayerReChoosePanel.<PlayCloseAsync>d__11 <PlayCloseAsync>d__;
			<PlayCloseAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayCloseAsync>d__.<>4__this = this;
			<PlayCloseAsync>d__.<>1__state = -1;
			<PlayCloseAsync>d__.<>t__builder.Start<CiacconaGalStepPlayerReChoosePanel.<PlayCloseAsync>d__11>(ref <PlayCloseAsync>d__);
			return <PlayCloseAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0401EF9A RID: 126874
		private CiacconaGalReChoosePlainTextItem PlainTextTop;

		// Token: 0x0401EF9B RID: 126875
		private CiacconaGalReChooseChoiceItem ChoiceTop;

		// Token: 0x0401EF9C RID: 126876
		private CiacconaGalReChoosePlainTextItem PlainTextBottom;

		// Token: 0x0401EF9D RID: 126877
		private CiacconaGalReChooseChoiceList ChoiceListBottom;

		// Token: 0x0401EF9E RID: 126878
		private LevelSequencePlayer SeqPlayer;

		// Token: 0x0200BDBE RID: 48574
		[NullableContext(0)]
		public class EMainComponentDefine
		{
			// Token: 0x0403937A RID: 234362
			public const int ItemChoiceTop = 1;

			// Token: 0x0403937B RID: 234363
			public const int ItemPlainTextBottom = 2;

			// Token: 0x0403937C RID: 234364
			public const int ItemChoiceListBottom = 3;

			// Token: 0x0403937D RID: 234365
			public const int ItemPlainTextTop = 4;
		}
	}
}
