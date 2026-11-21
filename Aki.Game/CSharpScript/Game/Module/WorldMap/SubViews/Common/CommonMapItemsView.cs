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
	// Token: 0x0200375F RID: 14175
	[NullableContext(2)]
	[Nullable(0)]
	public class CommonMapItemsView : UiPanelBase
	{
		// Token: 0x06024DA7 RID: 150951 RVA: 0x00A6A8B8 File Offset: 0x00A68AB8
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

		// Token: 0x06024DA8 RID: 150952 RVA: 0x00A6A9E4 File Offset: 0x00A68BE4
		protected override void OnStart()
		{
			this.InitZoomButton();
			this.SetMapChangeButtonActive(false);
			this.SetSwitchButtonActive(false);
			this.SetScaleSliderActive(false);
		}

		// Token: 0x06024DA9 RID: 150953 RVA: 0x00A6AA04 File Offset: 0x00A68C04
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

		// Token: 0x06024DAA RID: 150954 RVA: 0x00A6AA5B File Offset: 0x00A68C5B
		private void OnZoomOut()
		{
			AudioSystem.Instance.PostEvent("play_ui_com_slider_tick");
			EventSystem.Instance.Emit<float, EMapScaleSetType>(EEventName.WorldMapZoomBtnInput, -0.1f, EMapScaleSetType.ZoomButton);
		}

		// Token: 0x06024DAB RID: 150955 RVA: 0x00A6AA83 File Offset: 0x00A68C83
		private void OnZoomIn()
		{
			AudioSystem.Instance.PostEvent("play_ui_com_slider_tick");
			EventSystem.Instance.Emit<float, EMapScaleSetType>(EEventName.WorldMapZoomBtnInput, 0.1f, EMapScaleSetType.ZoomButton);
		}

		// Token: 0x06024DAC RID: 150956 RVA: 0x00A6AAAB File Offset: 0x00A68CAB
		public UUISliderComponent GetScaleSlider()
		{
			return base.GetSlider(2);
		}

		// Token: 0x06024DAD RID: 150957 RVA: 0x00A6AAB4 File Offset: 0x00A68CB4
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

		// Token: 0x06024DAE RID: 150958 RVA: 0x00A6AAE8 File Offset: 0x00A68CE8
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

		// Token: 0x06024DAF RID: 150959 RVA: 0x00A6AB1C File Offset: 0x00A68D1C
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

		// Token: 0x06024DB0 RID: 150960 RVA: 0x00A6AB99 File Offset: 0x00A68D99
		[NullableContext(1)]
		public void SetBtnMapChangeFunction(Action callback)
		{
			this.BtnMapChangeFunction = callback;
		}

		// Token: 0x06024DB1 RID: 150961 RVA: 0x00A6ABA2 File Offset: 0x00A68DA2
		[NullableContext(1)]
		public void SetBtnSwitchFunction(Action callback)
		{
			this.BtnSwitchFunction = callback;
		}

		// Token: 0x06024DB2 RID: 150962 RVA: 0x00A6ABAB File Offset: 0x00A68DAB
		private void OnBtnMapChange()
		{
			Action btnMapChangeFunction = this.BtnMapChangeFunction;
			if (btnMapChangeFunction == null)
			{
				return;
			}
			btnMapChangeFunction();
		}

		// Token: 0x06024DB3 RID: 150963 RVA: 0x00A6ABBD File Offset: 0x00A68DBD
		private void OnBtnSwitch()
		{
			Action btnSwitchFunction = this.BtnSwitchFunction;
			if (btnSwitchFunction == null)
			{
				return;
			}
			btnSwitchFunction();
		}

		// Token: 0x06024DB4 RID: 150964 RVA: 0x00A6ABD0 File Offset: 0x00A68DD0
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

		// Token: 0x06024DB5 RID: 150965 RVA: 0x00A6AC1B File Offset: 0x00A68E1B
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

		// Token: 0x040146E3 RID: 83683
		private LongPressButton ZoomInButton;

		// Token: 0x040146E4 RID: 83684
		private LongPressButton ZoomOutButton;

		// Token: 0x040146E5 RID: 83685
		private Action BtnMapChangeFunction;

		// Token: 0x040146E6 RID: 83686
		private Action BtnSwitchFunction;

		// Token: 0x020094B6 RID: 38070
		[NullableContext(0)]
		private static class EComponent
		{
			// Token: 0x0402E737 RID: 190263
			public const int ZoomIn = 0;

			// Token: 0x0402E738 RID: 190264
			public const int ZoomOut = 1;

			// Token: 0x0402E739 RID: 190265
			public const int VerticalSlider = 2;

			// Token: 0x0402E73A RID: 190266
			public const int BtnMapChange = 3;

			// Token: 0x0402E73B RID: 190267
			public const int BtnSwitch = 4;
		}
	}
}
