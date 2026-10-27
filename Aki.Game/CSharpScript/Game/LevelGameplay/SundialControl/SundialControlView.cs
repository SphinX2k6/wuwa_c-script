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
	// Token: 0x02006A09 RID: 27145
	[NullableContext(1)]
	[Nullable(0)]
	public class SundialControlView : UiViewBase
	{
		// Token: 0x06043859 RID: 276569 RVA: 0x01083BA3 File Offset: 0x01081DA3
		public SundialControlView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0604385A RID: 276570 RVA: 0x01083BAC File Offset: 0x01081DAC
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

		// Token: 0x0604385B RID: 276571 RVA: 0x01083D84 File Offset: 0x01081F84
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

		// Token: 0x0604385C RID: 276572 RVA: 0x01083EAE File Offset: 0x010820AE
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnNeedUpdateSundialTips, new Action<int, int>(this.OnNeedUpdateSundialTips));
		}

		// Token: 0x0604385D RID: 276573 RVA: 0x01083ECC File Offset: 0x010820CC
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnNeedUpdateSundialTips, new Action<int, int>(this.OnNeedUpdateSundialTips));
		}

		// Token: 0x0604385E RID: 276574 RVA: 0x01083EEC File Offset: 0x010820EC
		private UniTask WaitModelLoad()
		{
			SundialControlView.<WaitModelLoad>d__16 <WaitModelLoad>d__;
			<WaitModelLoad>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitModelLoad>d__.<>4__this = this;
			<WaitModelLoad>d__.<>1__state = -1;
			<WaitModelLoad>d__.<>t__builder.Start<SundialControlView.<WaitModelLoad>d__16>(ref <WaitModelLoad>d__);
			return <WaitModelLoad>d__.<>t__builder.Task;
		}

		// Token: 0x0604385F RID: 276575 RVA: 0x01083F30 File Offset: 0x01082130
		private UniTask AfterModelLoad()
		{
			SundialControlView.<AfterModelLoad>d__17 <AfterModelLoad>d__;
			<AfterModelLoad>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<AfterModelLoad>d__.<>4__this = this;
			<AfterModelLoad>d__.<>1__state = -1;
			<AfterModelLoad>d__.<>t__builder.Start<SundialControlView.<AfterModelLoad>d__17>(ref <AfterModelLoad>d__);
			return <AfterModelLoad>d__.<>t__builder.Task;
		}

		// Token: 0x06043860 RID: 276576 RVA: 0x01083F73 File Offset: 0x01082173
		protected override void OnBeforeDestroy()
		{
			SundialControlController.Instance.SetOnFinishCallback(null);
			SundialControlController.Instance.DestroyModel();
		}

		// Token: 0x06043861 RID: 276577 RVA: 0x01083F8A File Offset: 0x0108218A
		private void OnBtnResetClicked()
		{
			this.OnBtnResetClickedImp();
		}

		// Token: 0x06043862 RID: 276578 RVA: 0x01083F94 File Offset: 0x01082194
		private UniTask OnBtnResetClickedImp()
		{
			SundialControlView.<OnBtnResetClickedImp>d__20 <OnBtnResetClickedImp>d__;
			<OnBtnResetClickedImp>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBtnResetClickedImp>d__.<>4__this = this;
			<OnBtnResetClickedImp>d__.<>1__state = -1;
			<OnBtnResetClickedImp>d__.<>t__builder.Start<SundialControlView.<OnBtnResetClickedImp>d__20>(ref <OnBtnResetClickedImp>d__);
			return <OnBtnResetClickedImp>d__.<>t__builder.Task;
		}

		// Token: 0x06043863 RID: 276579 RVA: 0x01083FD7 File Offset: 0x010821D7
		private void OnBtnSwitchClicked()
		{
			SundialControlController.Instance.SwitchCurrentRing();
		}

		// Token: 0x06043864 RID: 276580 RVA: 0x01083FE3 File Offset: 0x010821E3
		private void OnBtnRotateClicked()
		{
			this.SetAllBtnInteractive(false);
			SundialControlController.Instance.StartRotate(delegate
			{
				this.SetAllBtnInteractive(true);
			});
		}

		// Token: 0x06043865 RID: 276581 RVA: 0x01084002 File Offset: 0x01082202
		private void OnBtnBackClicked()
		{
			base.CloseMe(null);
		}

		// Token: 0x06043866 RID: 276582 RVA: 0x0108400B File Offset: 0x0108220B
		private void SetAllBtnInteractive(bool interactiveEnable)
		{
			this.BtnReset.SetSelfInteractive(interactiveEnable);
			this.BtnSwitch.SetSelfInteractive(interactiveEnable);
			this.BtnRotate.SetSelfInteractive(interactiveEnable);
			this.BtnBack.SetSelfInteractive(interactiveEnable);
		}

		// Token: 0x06043867 RID: 276583 RVA: 0x01084040 File Offset: 0x01082240
		private void OnNeedUpdateSundialTips(int ring, int socket)
		{
			string[] array = (ring == 0) ? SundialControlView.ringOneTips : SundialControlView.ringTwoTips;
			string textStringId = array[socket % array.Length];
			UUIText text = base.GetText(4);
			LguiUtil.Instance.SetLocalTextNew(text, textStringId, Array.Empty<object>());
		}

		// Token: 0x04023400 RID: 144384
		public const string TIPS_TEXT = "PrefabTextItem_2335089801_Text";

		// Token: 0x04023401 RID: 144385
		public const string RESET_TEXT = "PrefabTextItem_2335089802_Text";

		// Token: 0x04023402 RID: 144386
		public const string SWITCH_TEXT = "PrefabTextItem_2335089799_Text";

		// Token: 0x04023403 RID: 144387
		public const string ROTATE_TEXT = "PrefabTextItem_2335089800_Text";

		// Token: 0x04023404 RID: 144388
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

		// Token: 0x04023405 RID: 144389
		[StaticVariableRuleIgnore]
		public static readonly string[] ringTwoTips = new string[]
		{
			"PrefabTextItem_2335089818_Text",
			"PrefabTextItem_2335089817_Text",
			"PrefabTextItem_2335089815_Text",
			"PrefabTextItem_2335089816_Text"
		};

		// Token: 0x04023406 RID: 144390
		[Nullable(2)]
		private UUIButtonComponent BtnReset;

		// Token: 0x04023407 RID: 144391
		[Nullable(2)]
		private UUIButtonComponent BtnSwitch;

		// Token: 0x04023408 RID: 144392
		[Nullable(2)]
		private UUIButtonComponent BtnRotate;

		// Token: 0x04023409 RID: 144393
		[Nullable(2)]
		private UUIButtonComponent BtnBack;

		// Token: 0x0200CB64 RID: 52068
		[NullableContext(0)]
		public enum ESundialControlView
		{
			// Token: 0x0403D688 RID: 251528
			BtnReset,
			// Token: 0x0403D689 RID: 251529
			BtnSwitch,
			// Token: 0x0403D68A RID: 251530
			BtnRotate,
			// Token: 0x0403D68B RID: 251531
			BtnBack,
			// Token: 0x0403D68C RID: 251532
			TextTip,
			// Token: 0x0403D68D RID: 251533
			TextReset,
			// Token: 0x0403D68E RID: 251534
			TextSwitch,
			// Token: 0x0403D68F RID: 251535
			TextRotate
		}
	}
}
