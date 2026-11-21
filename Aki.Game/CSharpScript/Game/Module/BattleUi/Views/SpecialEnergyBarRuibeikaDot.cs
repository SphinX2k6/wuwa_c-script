using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DE2 RID: 19938
	public class SpecialEnergyBarRuibeikaDot : UiPanelBase
	{
		// Token: 0x0603224E RID: 205390 RVA: 0x00E0D0DB File Offset: 0x00E0B2DB
		public SpecialEnergyBarRuibeikaDot(int mode = 0)
		{
			this.Mode = mode;
		}

		// Token: 0x0603224F RID: 205391 RVA: 0x00E0D0F8 File Offset: 0x00E0B2F8
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

		// Token: 0x06032250 RID: 205392 RVA: 0x00E0D188 File Offset: 0x00E0B388
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

		// Token: 0x06032251 RID: 205393 RVA: 0x00E0D1E0 File Offset: 0x00E0B3E0
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

		// Token: 0x06032252 RID: 205394 RVA: 0x00E0D24E File Offset: 0x00E0B44E
		public float GetAniUseDuration()
		{
			return this.TweenAnimPlayer.GetDuration(1);
		}

		// Token: 0x0401A913 RID: 108819
		[Nullable(1)]
		private readonly BattleUiTweenAnimPlayer TweenAnimPlayer = new BattleUiTweenAnimPlayer();

		// Token: 0x0401A914 RID: 108820
		public int Mode;

		// Token: 0x0401A915 RID: 108821
		public int Index;

		// Token: 0x0401A916 RID: 108822
		private bool IsVisible;

		// Token: 0x0200AB58 RID: 43864
		private class EDotChildType
		{
			// Token: 0x04035015 RID: 217109
			public const int AniBrightG = 0;

			// Token: 0x04035016 RID: 217110
			public const int AniUse = 1;

			// Token: 0x04035017 RID: 217111
			public const int AniBrightR = 2;
		}
	}
}
