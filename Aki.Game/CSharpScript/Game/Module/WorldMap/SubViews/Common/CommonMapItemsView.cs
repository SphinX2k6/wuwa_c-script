using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.Common
{
	// Token: 0x0200482E RID: 18478
	[NullableContext(2)]
	[Nullable(0)]
	public class CommonMapItemsView : UiPanelBase
	{
		// Token: 0x060305D7 RID: 198103 RVA: 0x00B3A7EC File Offset: 0x00B389EC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISliderComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnBtnMapChange));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnBtnSwitch));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060305D8 RID: 198104 RVA: 0x00B3A918 File Offset: 0x00B38B18
		protected override void OnStart()
		{
			this.InitZoomButton();
			this.SetMapChangeButtonActive(false);
			this.SetSwitchButtonActive(false);
			this.SetScaleSliderActive(false);
		}

		// Token: 0x060305D9 RID: 198105 RVA: 0x00B3A938 File Offset: 0x00B38B38
		private void InitZoomButton()
		{
			UUIButtonComponent button = base.GetButton(0);
			if (button != null)
			{
				this.ZoomInButton = new LongPressButton(button, delegate(float _)
				{
					this.OnZoomIn();
				}, 100);
			}
			UUIButtonComponent button2 = base.GetButton(1);
			if (button2 != null)
			{
				this.ZoomOutButton = new LongPressButton(button2, delegate(float _)
				{
					this.OnZoomOut();
				}, 100);
			}
		}

		// Token: 0x060305DA RID: 198106 RVA: 0x00B3A98F File Offset: 0x00B38B8F
		private void OnZoomOut()
		{
			AudioSystem.Instance.PostEvent("play_ui_com_slider_tick");
			EventSystem.Instance.Emit<float, EMapScaleSetType>(EEventName.WorldMapZoomBtnInput, -0.1f, EMapScaleSetType.ZoomButton);
		}

		// Token: 0x060305DB RID: 198107 RVA: 0x00B3A9B7 File Offset: 0x00B38BB7
		private void OnZoomIn()
		{
			AudioSystem.Instance.PostEvent("play_ui_com_slider_tick");
			EventSystem.Instance.Emit<float, EMapScaleSetType>(EEventName.WorldMapZoomBtnInput, 0.1f, EMapScaleSetType.ZoomButton);
		}

		// Token: 0x060305DC RID: 198108 RVA: 0x00B3A9DF File Offset: 0x00B38BDF
		public UUISliderComponent GetScaleSlider()
		{
			return base.GetSlider(2);
		}

		// Token: 0x060305DD RID: 198109 RVA: 0x00B3A9E8 File Offset: 0x00B38BE8
		public void SetMapChangeButtonActive(bool active)
		{
			UUIButtonComponent button = base.GetButton(3);
			if (button == null)
			{
				return;
			}
			UUIItem uuiitem = button.RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(active);
		}

		// Token: 0x060305DE RID: 198110 RVA: 0x00B3AA1C File Offset: 0x00B38C1C
		public void SetSwitchButtonActive(bool active)
		{
			UUIButtonComponent button = base.GetButton(4);
			if (button == null)
			{
				return;
			}
			UUIItem uuiitem = button.RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(active);
		}

		// Token: 0x060305DF RID: 198111 RVA: 0x00B3AA50 File Offset: 0x00B38C50
		public void SetScaleSliderActive(bool active)
		{
			UUISliderComponent slider = base.GetSlider(2);
			if (slider != null)
			{
				UUIItem uuiitem = slider.RootUIComp.Get();
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(active);
				}
			}
			UUIButtonComponent button = base.GetButton(0);
			if (button != null)
			{
				UUIItem uuiitem2 = button.RootUIComp.Get();
				if (uuiitem2 != null)
				{
					uuiitem2.SetUIActive(active);
				}
			}
			UUIButtonComponent button2 = base.GetButton(1);
			if (button2 == null)
			{
				return;
			}
			UUIItem uuiitem3 = button2.RootUIComp.Get();
			if (uuiitem3 == null)
			{
				return;
			}
			uuiitem3.SetUIActive(active);
		}

		// Token: 0x060305E0 RID: 198112 RVA: 0x00B3AACD File Offset: 0x00B38CCD
		[NullableContext(1)]
		public void SetBtnMapChangeFunction(Action callback)
		{
			this.BtnMapChangeFunction = callback;
		}

		// Token: 0x060305E1 RID: 198113 RVA: 0x00B3AAD6 File Offset: 0x00B38CD6
		[NullableContext(1)]
		public void SetBtnSwitchFunction(Action callback)
		{
			this.BtnSwitchFunction = callback;
		}

		// Token: 0x060305E2 RID: 198114 RVA: 0x00B3AADF File Offset: 0x00B38CDF
		private void OnBtnMapChange()
		{
			Action btnMapChangeFunction = this.BtnMapChangeFunction;
			if (btnMapChangeFunction == null)
			{
				return;
			}
			btnMapChangeFunction();
		}

		// Token: 0x060305E3 RID: 198115 RVA: 0x00B3AAF1 File Offset: 0x00B38CF1
		private void OnBtnSwitch()
		{
			Action btnSwitchFunction = this.BtnSwitchFunction;
			if (btnSwitchFunction == null)
			{
				return;
			}
			btnSwitchFunction();
		}

		// Token: 0x060305E4 RID: 198116 RVA: 0x00B3AB04 File Offset: 0x00B38D04
		[NullableContext(1)]
		public UniTask CreateThenShow(UUIItem parent)
		{
			CommonMapItemsView.<CreateThenShow>d__18 <CreateThenShow>d__;
			<CreateThenShow>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateThenShow>d__.<>4__this = this;
			<CreateThenShow>d__.parent = parent;
			<CreateThenShow>d__.<>1__state = -1;
			<CreateThenShow>d__.<>t__builder.Start<CommonMapItemsView.<CreateThenShow>d__18>(ref <CreateThenShow>d__);
			return <CreateThenShow>d__.<>t__builder.Task;
		}

		// Token: 0x060305E5 RID: 198117 RVA: 0x00B3AB4F File Offset: 0x00B38D4F
		protected override void OnBeforeDestroyImplement()
		{
			LongPressButton zoomInButton = this.ZoomInButton;
			if (zoomInButton != null)
			{
				zoomInButton.OnDestroy();
			}
			LongPressButton zoomOutButton = this.ZoomOutButton;
			if (zoomOutButton == null)
			{
				return;
			}
			zoomOutButton.OnDestroy();
		}

		// Token: 0x0401A02F RID: 106543
		private LongPressButton ZoomInButton;

		// Token: 0x0401A030 RID: 106544
		private LongPressButton ZoomOutButton;

		// Token: 0x0401A031 RID: 106545
		private Action BtnMapChangeFunction;

		// Token: 0x0401A032 RID: 106546
		private Action BtnSwitchFunction;

		// Token: 0x0200AB07 RID: 43783
		[NullableContext(0)]
		private static class EComponent
		{
			// Token: 0x04033FB7 RID: 212919
			public const int ZoomIn = 0;

			// Token: 0x04033FB8 RID: 212920
			public const int ZoomOut = 1;

			// Token: 0x04033FB9 RID: 212921
			public const int VerticalSlider = 2;

			// Token: 0x04033FBA RID: 212922
			public const int BtnMapChange = 3;

			// Token: 0x04033FBB RID: 212923
			public const int BtnSwitch = 4;
		}
	}
}
