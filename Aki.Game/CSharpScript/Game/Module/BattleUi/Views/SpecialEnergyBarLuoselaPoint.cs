using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DD3 RID: 19923
	public class SpecialEnergyBarLuoselaPoint : UiPanelBase
	{
		// Token: 0x060321A3 RID: 205219 RVA: 0x00E093B4 File Offset: 0x00E075B4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060321A4 RID: 205220 RVA: 0x00E0943E File Offset: 0x00E0763E
		protected override void OnStart()
		{
			base.OnStart();
			this.TweenAnimPlayer.InitTweenAnim(2, base.GetItem(2), false);
		}

		// Token: 0x060321A5 RID: 205221 RVA: 0x00E0945C File Offset: 0x00E0765C
		public void SetVisible(bool b)
		{
			if (this.IsVisible == b)
			{
				return;
			}
			this.IsVisible = b;
			this.SetActive(b);
			if (b)
			{
				this.TweenAnimPlayer.PlayTweenAnim(2);
				base.GetItem(0).SetUIActive(!this.IsUlt);
				base.GetItem(1).SetUIActive(this.IsUlt);
			}
		}

		// Token: 0x060321A6 RID: 205222 RVA: 0x00E094B7 File Offset: 0x00E076B7
		public void SetUlt(bool b)
		{
			this.IsUlt = b;
			base.GetItem(0).SetUIActive(!b);
			base.GetItem(1).SetUIActive(b);
		}

		// Token: 0x0401A8A1 RID: 108705
		[Nullable(1)]
		private readonly BattleUiTweenAnimPlayer TweenAnimPlayer = new BattleUiTweenAnimPlayer();

		// Token: 0x0401A8A2 RID: 108706
		private bool IsVisible;

		// Token: 0x0401A8A3 RID: 108707
		private bool IsUlt;

		// Token: 0x0200AB35 RID: 43829
		private class EPointChildType
		{
			// Token: 0x04034F39 RID: 216889
			public const int PnlNor = 0;

			// Token: 0x04034F3A RID: 216890
			public const int PnlUlt = 1;

			// Token: 0x04034F3B RID: 216891
			public const int AniIn = 2;
		}
	}
}
