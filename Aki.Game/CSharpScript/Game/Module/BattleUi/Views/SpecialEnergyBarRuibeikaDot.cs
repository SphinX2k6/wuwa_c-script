using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DFD RID: 24061
	public class SpecialEnergyBarRuibeikaDot : UiPanelBase
	{
		// Token: 0x0603D2BF RID: 250559 RVA: 0x00EBBB8F File Offset: 0x00EB9D8F
		public SpecialEnergyBarRuibeikaDot(int mode = 0)
		{
			this.Mode = mode;
		}

		// Token: 0x0603D2C0 RID: 250560 RVA: 0x00EBBBAC File Offset: 0x00EB9DAC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			if (this.Mode == 1)
			{
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(2, typeof(UUIItem)));
			}
		}

		// Token: 0x0603D2C1 RID: 250561 RVA: 0x00EBBC3C File Offset: 0x00EB9E3C
		protected override void OnStart()
		{
			base.OnStart();
			this.TweenAnimPlayer.InitTweenAnim(0, base.GetItem(0), false);
			this.TweenAnimPlayer.InitTweenAnim(1, base.GetItem(1), false);
			if (this.Mode == 1)
			{
				this.TweenAnimPlayer.InitTweenAnim(2, base.GetItem(2), false);
			}
		}

		// Token: 0x0603D2C2 RID: 250562 RVA: 0x00EBBC94 File Offset: 0x00EB9E94
		public void SetVisible(bool b, bool gun, bool force = false)
		{
			if (this.IsVisible == b && !force)
			{
				return;
			}
			if (b)
			{
				base.SetUiActive(true);
				if (this.Mode == 1)
				{
					this.TweenAnimPlayer.PlayTweenAnim(gun ? 0 : 2);
				}
				else
				{
					this.TweenAnimPlayer.PlayTweenAnim(0);
				}
			}
			else if (force)
			{
				base.SetUiActive(false);
			}
			else
			{
				this.TweenAnimPlayer.PlayTweenAnim(1);
			}
			this.IsVisible = b;
		}

		// Token: 0x0603D2C3 RID: 250563 RVA: 0x00EBBD02 File Offset: 0x00EB9F02
		public float GetAniUseDuration()
		{
			return this.TweenAnimPlayer.GetDuration(1);
		}

		// Token: 0x0401FE4C RID: 130636
		[Nullable(1)]
		private readonly BattleUiTweenAnimPlayer TweenAnimPlayer = new BattleUiTweenAnimPlayer();

		// Token: 0x0401FE4D RID: 130637
		public int Mode;

		// Token: 0x0401FE4E RID: 130638
		public int Index;

		// Token: 0x0401FE4F RID: 130639
		private bool IsVisible;

		// Token: 0x0200C149 RID: 49481
		private class EDotChildType
		{
			// Token: 0x0403A623 RID: 239139
			public const int AniBrightG = 0;

			// Token: 0x0403A624 RID: 239140
			public const int AniUse = 1;

			// Token: 0x0403A625 RID: 239141
			public const int AniBrightR = 2;
		}
	}
}
