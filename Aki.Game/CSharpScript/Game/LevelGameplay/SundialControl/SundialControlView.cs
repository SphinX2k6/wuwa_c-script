using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SundialControl
{
	// Token: 0x02005B66 RID: 23398
	[NullableContext(1)]
	[Nullable(0)]
	public class SundialControlView : UiViewBase
	{
		// Token: 0x060398A5 RID: 235685 RVA: 0x010281C7 File Offset: 0x010263C7
		public SundialControlView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060398A6 RID: 235686 RVA: 0x010281D0 File Offset: 0x010263D0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 4;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnBtnResetClicked));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnBtnSwitchClicked));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnBtnBackClicked));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnBtnRotateClicked));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060398A7 RID: 235687 RVA: 0x010283A8 File Offset: 0x010265A8
		protected override void OnStart()
		{
			this.BtnReset = base.GetButton(0);
			this.BtnSwitch = base.GetButton(1);
			this.BtnRotate = base.GetButton(2);
			this.BtnBack = base.GetButton(3);
			this.BtnBack.RootUIComp.Get().SetUIActive(false);
			this.BtnReset.RootUIComp.Get().SetUIActive(false);
			UUIText text = base.GetText(4);
			LguiUtil.Instance.SetLocalTextNew(text, "PrefabTextItem_2335089801_Text", Array.Empty<object>());
			UUIText text2 = base.GetText(5);
			LguiUtil.Instance.SetLocalTextNew(text2, "PrefabTextItem_2335089802_Text", Array.Empty<object>());
			UUIText text3 = base.GetText(6);
			LguiUtil.Instance.SetLocalTextNew(text3, "PrefabTextItem_2335089799_Text", Array.Empty<object>());
			UUIText text4 = base.GetText(7);
			LguiUtil.Instance.SetLocalTextNew(text4, "PrefabTextItem_2335089800_Text", Array.Empty<object>());
			SundialControlController.Instance.SetOnFinishCallback(delegate
			{
				this.BtnReset.RootUIComp.Get().SetUIActive(false);
				this.BtnSwitch.RootUIComp.Get().SetUIActive(false);
				this.BtnRotate.RootUIComp.Get().SetUIActive(false);
				this.BtnBack.RootUIComp.Get().SetUIActive(false);
			});
			this.WaitModelLoad();
			TimerSystem.Instance.Delay(delegate(float delta)
			{
				SundialControlController.Instance.GenerateModel(delegate
				{
					this.AfterModelLoad();
				});
			}, 100f, null, null, true, 1f);
		}

		// Token: 0x060398A8 RID: 235688 RVA: 0x010284D2 File Offset: 0x010266D2
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnNeedUpdateSundialTips, new Action<int, int>(this.OnNeedUpdateSundialTips));
		}

		// Token: 0x060398A9 RID: 235689 RVA: 0x010284F0 File Offset: 0x010266F0
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnNeedUpdateSundialTips, new Action<int, int>(this.OnNeedUpdateSundialTips));
		}

		// Token: 0x060398AA RID: 235690 RVA: 0x01028510 File Offset: 0x01026710
		private UniTask WaitModelLoad()
		{
			SundialControlView.<WaitModelLoad>d__16 <WaitModelLoad>d__;
			<WaitModelLoad>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitModelLoad>d__.<>4__this = this;
			<WaitModelLoad>d__.<>1__state = -1;
			<WaitModelLoad>d__.<>t__builder.Start<SundialControlView.<WaitModelLoad>d__16>(ref <WaitModelLoad>d__);
			return <WaitModelLoad>d__.<>t__builder.Task;
		}

		// Token: 0x060398AB RID: 235691 RVA: 0x01028554 File Offset: 0x01026754
		private UniTask AfterModelLoad()
		{
			SundialControlView.<AfterModelLoad>d__17 <AfterModelLoad>d__;
			<AfterModelLoad>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<AfterModelLoad>d__.<>4__this = this;
			<AfterModelLoad>d__.<>1__state = -1;
			<AfterModelLoad>d__.<>t__builder.Start<SundialControlView.<AfterModelLoad>d__17>(ref <AfterModelLoad>d__);
			return <AfterModelLoad>d__.<>t__builder.Task;
		}

		// Token: 0x060398AC RID: 235692 RVA: 0x01028597 File Offset: 0x01026797
		protected override void OnBeforeDestroy()
		{
			SundialControlController.Instance.SetOnFinishCallback(null);
			SundialControlController.Instance.DestroyModel();
		}

		// Token: 0x060398AD RID: 235693 RVA: 0x010285AE File Offset: 0x010267AE
		private void OnBtnResetClicked()
		{
			this.OnBtnResetClickedImp();
		}

		// Token: 0x060398AE RID: 235694 RVA: 0x010285B8 File Offset: 0x010267B8
		private UniTask OnBtnResetClickedImp()
		{
			SundialControlView.<OnBtnResetClickedImp>d__20 <OnBtnResetClickedImp>d__;
			<OnBtnResetClickedImp>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBtnResetClickedImp>d__.<>4__this = this;
			<OnBtnResetClickedImp>d__.<>1__state = -1;
			<OnBtnResetClickedImp>d__.<>t__builder.Start<SundialControlView.<OnBtnResetClickedImp>d__20>(ref <OnBtnResetClickedImp>d__);
			return <OnBtnResetClickedImp>d__.<>t__builder.Task;
		}

		// Token: 0x060398AF RID: 235695 RVA: 0x010285FB File Offset: 0x010267FB
		private void OnBtnSwitchClicked()
		{
			SundialControlController.Instance.SwitchCurrentRing();
		}

		// Token: 0x060398B0 RID: 235696 RVA: 0x01028607 File Offset: 0x01026807
		private void OnBtnRotateClicked()
		{
			this.SetAllBtnInteractive(false);
			SundialControlController.Instance.StartRotate(delegate
			{
				this.SetAllBtnInteractive(true);
			});
		}

		// Token: 0x060398B1 RID: 235697 RVA: 0x01028626 File Offset: 0x01026826
		private void OnBtnBackClicked()
		{
			base.CloseMe(null);
		}

		// Token: 0x060398B2 RID: 235698 RVA: 0x0102862F File Offset: 0x0102682F
		private void SetAllBtnInteractive(bool interactiveEnable)
		{
			this.BtnReset.SetSelfInteractive(interactiveEnable);
			this.BtnSwitch.SetSelfInteractive(interactiveEnable);
			this.BtnRotate.SetSelfInteractive(interactiveEnable);
			this.BtnBack.SetSelfInteractive(interactiveEnable);
		}

		// Token: 0x060398B3 RID: 235699 RVA: 0x01028664 File Offset: 0x01026864
		private void OnNeedUpdateSundialTips(int ring, int socket)
		{
			string[] array = (ring == 0) ? SundialControlView.ringOneTips : SundialControlView.ringTwoTips;
			string textStringId = array[socket % array.Length];
			UUIText text = base.GetText(4);
			LguiUtil.Instance.SetLocalTextNew(text, textStringId, Array.Empty<object>());
		}

		// Token: 0x0401E5F2 RID: 124402
		public const string TIPS_TEXT = "PrefabTextItem_2335089801_Text";

		// Token: 0x0401E5F3 RID: 124403
		public const string RESET_TEXT = "PrefabTextItem_2335089802_Text";

		// Token: 0x0401E5F4 RID: 124404
		public const string SWITCH_TEXT = "PrefabTextItem_2335089799_Text";

		// Token: 0x0401E5F5 RID: 124405
		public const string ROTATE_TEXT = "PrefabTextItem_2335089800_Text";

		// Token: 0x0401E5F6 RID: 124406
		[StaticVariableRuleIgnore]
		public static readonly string[] ringOneTips = new string[]
		{
			"PrefabTextItem_2335089803_Text",
			"PrefabTextItem_2335089814_Text",
			"PrefabTextItem_2335089813_Text",
			"PrefabTextItem_2335089812_Text",
			"PrefabTextItem_2335089811_Text",
			"PrefabTextItem_2335089810_Text",
			"PrefabTextItem_2335089809_Text",
			"PrefabTextItem_2335089808_Text",
			"PrefabTextItem_2335089807_Text",
			"PrefabTextItem_2335089806_Text",
			"PrefabTextItem_2335089805_Text",
			"PrefabTextItem_2335089804_Text"
		};

		// Token: 0x0401E5F7 RID: 124407
		[StaticVariableRuleIgnore]
		public static readonly string[] ringTwoTips = new string[]
		{
			"PrefabTextItem_2335089818_Text",
			"PrefabTextItem_2335089817_Text",
			"PrefabTextItem_2335089815_Text",
			"PrefabTextItem_2335089816_Text"
		};

		// Token: 0x0401E5F8 RID: 124408
		[Nullable(2)]
		private UUIButtonComponent BtnReset;

		// Token: 0x0401E5F9 RID: 124409
		[Nullable(2)]
		private UUIButtonComponent BtnSwitch;

		// Token: 0x0401E5FA RID: 124410
		[Nullable(2)]
		private UUIButtonComponent BtnRotate;

		// Token: 0x0401E5FB RID: 124411
		[Nullable(2)]
		private UUIButtonComponent BtnBack;

		// Token: 0x0200B743 RID: 46915
		[NullableContext(0)]
		public enum ESundialControlView
		{
			// Token: 0x04038A6A RID: 232042
			BtnReset,
			// Token: 0x04038A6B RID: 232043
			BtnSwitch,
			// Token: 0x04038A6C RID: 232044
			BtnRotate,
			// Token: 0x04038A6D RID: 232045
			BtnBack,
			// Token: 0x04038A6E RID: 232046
			TextTip,
			// Token: 0x04038A6F RID: 232047
			TextReset,
			// Token: 0x04038A70 RID: 232048
			TextSwitch,
			// Token: 0x04038A71 RID: 232049
			TextRotate
		}
	}
}
