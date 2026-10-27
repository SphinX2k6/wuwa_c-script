using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E0D RID: 24077
	public class SpecialEnergyBarXinYueHuPillarItem : UiPanelBase
	{
		// Token: 0x0603D3AD RID: 250797 RVA: 0x00EC0E5C File Offset: 0x00EBF05C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603D3AE RID: 250798 RVA: 0x00EC0F07 File Offset: 0x00EBF107
		protected override void OnStart()
		{
			this.InitTweenAnim(2);
			this.InitTweenAnim(3);
		}

		// Token: 0x0603D3AF RID: 250799 RVA: 0x00EC0F17 File Offset: 0x00EBF117
		protected override void OnBeforeDestroy()
		{
			this.ClearAllTweenAnim();
			base.OnBeforeDestroy();
		}

		// Token: 0x0603D3B0 RID: 250800 RVA: 0x00EC0F25 File Offset: 0x00EBF125
		public void Reset()
		{
			base.GetItem(0).SetUIActive(false);
			base.GetItem(1).SetUIActive(false);
		}

		// Token: 0x0603D3B1 RID: 250801 RVA: 0x00EC0F41 File Offset: 0x00EBF141
		public void PlayStart()
		{
			this.StopTweenAnim(3);
			base.GetItem(0).SetUIActive(true);
			base.GetItem(1).SetUIActive(false);
			this.PlayTweenAnim(2);
		}

		// Token: 0x0603D3B2 RID: 250802 RVA: 0x00EC0F6B File Offset: 0x00EBF16B
		public void PlayFull()
		{
			this.StopTweenAnim(2);
			base.GetItem(0).SetUIActive(false);
			base.GetItem(1).SetUIActive(true);
			this.PlayTweenAnim(3);
		}

		// Token: 0x0603D3B3 RID: 250803 RVA: 0x00EC0F95 File Offset: 0x00EBF195
		public void InitByState(bool isFull)
		{
			if (isFull)
			{
				this.PlayFull();
				return;
			}
			this.PlayStart();
		}

		// Token: 0x0603D3B4 RID: 250804 RVA: 0x00EC0FA7 File Offset: 0x00EBF1A7
		protected void InitTweenAnim(int componentType)
		{
			this.TweenAnimPlayer.InitTweenAnim(componentType, base.GetItem(componentType), false);
		}

		// Token: 0x0603D3B5 RID: 250805 RVA: 0x00EC0FBD File Offset: 0x00EBF1BD
		protected void PlayTweenAnim(int componentType)
		{
			this.TweenAnimPlayer.PlayTweenAnim(componentType);
		}

		// Token: 0x0603D3B6 RID: 250806 RVA: 0x00EC0FCB File Offset: 0x00EBF1CB
		protected void StopTweenAnim(int componentType)
		{
			this.TweenAnimPlayer.StopTweenAnim(componentType);
		}

		// Token: 0x0603D3B7 RID: 250807 RVA: 0x00EC0FD9 File Offset: 0x00EBF1D9
		protected virtual void ClearAllTweenAnim()
		{
			this.TweenAnimPlayer.Clear(false);
		}

		// Token: 0x0401FEDE RID: 130782
		[Nullable(1)]
		protected BattleUiTweenAnimPlayer TweenAnimPlayer = new BattleUiTweenAnimPlayer();

		// Token: 0x0200C179 RID: 49529
		internal enum EChildType
		{
			// Token: 0x0403A756 RID: 239446
			NormalItem,
			// Token: 0x0403A757 RID: 239447
			LightNodeItem,
			// Token: 0x0403A758 RID: 239448
			AniStart,
			// Token: 0x0403A759 RID: 239449
			AniFull
		}
	}
}
