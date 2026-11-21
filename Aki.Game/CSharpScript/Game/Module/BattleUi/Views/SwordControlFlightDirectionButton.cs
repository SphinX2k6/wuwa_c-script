using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004E1F RID: 19999
	[NullableContext(2)]
	[Nullable(0)]
	public class SwordControlFlightDirectionButton : UiPanelBase
	{
		// Token: 0x17006240 RID: 25152
		// (get) Token: 0x060324DD RID: 206045 RVA: 0x00E1A4FE File Offset: 0x00E186FE
		// (set) Token: 0x060324DE RID: 206046 RVA: 0x00E1A506 File Offset: 0x00E18706
		public Action OnPressCallback { get; set; }

		// Token: 0x17006241 RID: 25153
		// (get) Token: 0x060324DF RID: 206047 RVA: 0x00E1A50F File Offset: 0x00E1870F
		// (set) Token: 0x060324E0 RID: 206048 RVA: 0x00E1A517 File Offset: 0x00E18717
		public Action OnReleaseCallback { get; set; }

		// Token: 0x17006242 RID: 25154
		// (get) Token: 0x060324E1 RID: 206049 RVA: 0x00E1A520 File Offset: 0x00E18720
		public bool IsPressed
		{
			get
			{
				return this.HasPressedInput;
			}
		}

		// Token: 0x060324E2 RID: 206050 RVA: 0x00E1A528 File Offset: 0x00E18728
		public SwordControlFlightDirectionButton()
		{
			base.SkipDestroyActor = true;
		}

		// Token: 0x060324E3 RID: 206051 RVA: 0x00E1A538 File Offset: 0x00E18738
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

		// Token: 0x060324E4 RID: 206052 RVA: 0x00E1A5A1 File Offset: 0x00E187A1
		protected override void OnStart()
		{
			this.Button = base.GetButton(0);
			this.BindButtonEvent();
		}

		// Token: 0x060324E5 RID: 206053 RVA: 0x00E1A5B6 File Offset: 0x00E187B6
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

		// Token: 0x060324E6 RID: 206054 RVA: 0x00E1A5E8 File Offset: 0x00E187E8
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

		// Token: 0x060324E7 RID: 206055 RVA: 0x00E1A65C File Offset: 0x00E1885C
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

		// Token: 0x060324E8 RID: 206056 RVA: 0x00E1A6AA File Offset: 0x00E188AA
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

		// Token: 0x060324E9 RID: 206057 RVA: 0x00E1A6CC File Offset: 0x00E188CC
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

		// Token: 0x0401AAA9 RID: 109225
		private UUIButtonComponent Button;

		// Token: 0x0401AAAA RID: 109226
		private bool HasPressedInput;

		// Token: 0x0200ABC7 RID: 43975
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04035295 RID: 217749
			Button,
			// Token: 0x04035296 RID: 217750
			StateHolder
		}
	}
}
