using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DEE RID: 24046
	public class SpecialEnergyBarLuoselaPoint : UiPanelBase
	{
		// Token: 0x0603D214 RID: 250388 RVA: 0x00EB7E74 File Offset: 0x00EB6074
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

		// Token: 0x0603D215 RID: 250389 RVA: 0x00EB7EFE File Offset: 0x00EB60FE
		protected override void OnStart()
		{
			base.OnStart();
			this.TweenAnimPlayer.InitTweenAnim(2, base.GetItem(2), false);
		}

		// Token: 0x0603D216 RID: 250390 RVA: 0x00EB7F1C File Offset: 0x00EB611C
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

		// Token: 0x0603D217 RID: 250391 RVA: 0x00EB7F77 File Offset: 0x00EB6177
		public void SetUlt(bool b)
		{
			this.IsUlt = b;
			base.GetItem(0).SetUIActive(!b);
			base.GetItem(1).SetUIActive(b);
		}

		// Token: 0x0401FDDA RID: 130522
		[Nullable(1)]
		private readonly BattleUiTweenAnimPlayer TweenAnimPlayer = new BattleUiTweenAnimPlayer();

		// Token: 0x0401FDDB RID: 130523
		private bool IsVisible;

		// Token: 0x0401FDDC RID: 130524
		private bool IsUlt;

		// Token: 0x0200C126 RID: 49446
		private class EPointChildType
		{
			// Token: 0x0403A547 RID: 238919
			public const int PnlNor = 0;

			// Token: 0x0403A548 RID: 238920
			public const int PnlUlt = 1;

			// Token: 0x0403A549 RID: 238921
			public const int AniIn = 2;
		}
	}
}
