using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E3A RID: 24122
	[NullableContext(2)]
	[Nullable(0)]
	public class SwordControlFlightDirectionButton : UiPanelBase
	{
		// Token: 0x17008E6E RID: 36462
		// (get) Token: 0x0603D54D RID: 251213 RVA: 0x00EC8F92 File Offset: 0x00EC7192
		// (set) Token: 0x0603D54E RID: 251214 RVA: 0x00EC8F9A File Offset: 0x00EC719A
		public Action OnPressCallback { get; set; }

		// Token: 0x17008E6F RID: 36463
		// (get) Token: 0x0603D54F RID: 251215 RVA: 0x00EC8FA3 File Offset: 0x00EC71A3
		// (set) Token: 0x0603D550 RID: 251216 RVA: 0x00EC8FAB File Offset: 0x00EC71AB
		public Action OnReleaseCallback { get; set; }

		// Token: 0x17008E70 RID: 36464
		// (get) Token: 0x0603D551 RID: 251217 RVA: 0x00EC8FB4 File Offset: 0x00EC71B4
		public bool IsPressed
		{
			get
			{
				return this.HasPressedInput;
			}
		}

		// Token: 0x0603D552 RID: 251218 RVA: 0x00EC8FBC File Offset: 0x00EC71BC
		public SwordControlFlightDirectionButton()
		{
			base.SkipDestroyActor = true;
		}

		// Token: 0x0603D553 RID: 251219 RVA: 0x00EC8FCC File Offset: 0x00EC71CC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISelectableStateHolder));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603D554 RID: 251220 RVA: 0x00EC9035 File Offset: 0x00EC7235
		protected override void OnStart()
		{
			this.Button = base.GetButton(0);
			this.BindButtonEvent();
		}

		// Token: 0x0603D555 RID: 251221 RVA: 0x00EC904A File Offset: 0x00EC724A
		protected override void OnBeforeDestroy()
		{
			if (this.HasPressedInput)
			{
				this.HasPressedInput = false;
				Action onReleaseCallback = this.OnReleaseCallback;
				if (onReleaseCallback != null)
				{
					onReleaseCallback();
				}
			}
			this.UnBindButtonEvent();
			this.Button = null;
		}

		// Token: 0x0603D556 RID: 251222 RVA: 0x00EC907C File Offset: 0x00EC727C
		private void BindButtonEvent()
		{
			UUIButtonComponent button = this.Button;
			if (button != null)
			{
				button.OnPointDownCallBack.Bind(new Action(this.OnPressButton));
			}
			UUIButtonComponent button2 = this.Button;
			if (button2 != null)
			{
				button2.OnPointUpCallBack.Bind(new Action(this.OnReleaseButton));
			}
			UUIButtonComponent button3 = this.Button;
			if (button3 == null)
			{
				return;
			}
			button3.OnPointCancelCallBack.Bind(new Action(this.OnReleaseButton));
		}

		// Token: 0x0603D557 RID: 251223 RVA: 0x00EC90F0 File Offset: 0x00EC72F0
		private void UnBindButtonEvent()
		{
			UUIButtonComponent button = this.Button;
			if (button != null)
			{
				button.OnPointDownCallBack.Unbind();
			}
			UUIButtonComponent button2 = this.Button;
			if (button2 != null)
			{
				button2.OnPointUpCallBack.Unbind();
			}
			UUIButtonComponent button3 = this.Button;
			if (button3 == null)
			{
				return;
			}
			button3.OnPointCancelCallBack.Unbind();
		}

		// Token: 0x0603D558 RID: 251224 RVA: 0x00EC913E File Offset: 0x00EC733E
		private void OnPressButton()
		{
			if (this.HasPressedInput)
			{
				return;
			}
			this.HasPressedInput = true;
			Action onPressCallback = this.OnPressCallback;
			if (onPressCallback == null)
			{
				return;
			}
			onPressCallback();
		}

		// Token: 0x0603D559 RID: 251225 RVA: 0x00EC9160 File Offset: 0x00EC7360
		private void OnReleaseButton()
		{
			if (!this.HasPressedInput)
			{
				return;
			}
			this.HasPressedInput = false;
			Action onReleaseCallback = this.OnReleaseCallback;
			if (onReleaseCallback == null)
			{
				return;
			}
			onReleaseCallback();
		}

		// Token: 0x0401FFE2 RID: 131042
		private UUIButtonComponent Button;

		// Token: 0x0401FFE3 RID: 131043
		private bool HasPressedInput;

		// Token: 0x0200C1B8 RID: 49592
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403A8A3 RID: 239779
			Button,
			// Token: 0x0403A8A4 RID: 239780
			StateHolder
		}
	}
}
