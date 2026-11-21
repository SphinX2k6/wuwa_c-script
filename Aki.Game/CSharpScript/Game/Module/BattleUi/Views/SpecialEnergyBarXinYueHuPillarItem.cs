using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DF2 RID: 19954
	public class SpecialEnergyBarXinYueHuPillarItem : UiPanelBase
	{
		// Token: 0x0603233C RID: 205628 RVA: 0x00E123BC File Offset: 0x00E105BC
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

		// Token: 0x0603233D RID: 205629 RVA: 0x00E12467 File Offset: 0x00E10667
		protected override void OnStart()
		{
			this.InitTweenAnim(2);
			this.InitTweenAnim(3);
		}

		// Token: 0x0603233E RID: 205630 RVA: 0x00E12477 File Offset: 0x00E10677
		protected override void OnBeforeDestroy()
		{
			this.ClearAllTweenAnim();
			base.OnBeforeDestroy();
		}

		// Token: 0x0603233F RID: 205631 RVA: 0x00E12485 File Offset: 0x00E10685
		public void Reset()
		{
			base.GetItem(0).SetUIActive(false);
			base.GetItem(1).SetUIActive(false);
		}

		// Token: 0x06032340 RID: 205632 RVA: 0x00E124A1 File Offset: 0x00E106A1
		public void PlayStart()
		{
			this.StopTweenAnim(3);
			base.GetItem(0).SetUIActive(true);
			base.GetItem(1).SetUIActive(false);
			this.PlayTweenAnim(2);
		}

		// Token: 0x06032341 RID: 205633 RVA: 0x00E124CB File Offset: 0x00E106CB
		public void PlayFull()
		{
			this.StopTweenAnim(2);
			base.GetItem(0).SetUIActive(false);
			base.GetItem(1).SetUIActive(true);
			this.PlayTweenAnim(3);
		}

		// Token: 0x06032342 RID: 205634 RVA: 0x00E124F5 File Offset: 0x00E106F5
		public void InitByState(bool isFull)
		{
			if (isFull)
			{
				this.PlayFull();
				return;
			}
			this.PlayStart();
		}

		// Token: 0x06032343 RID: 205635 RVA: 0x00E12507 File Offset: 0x00E10707
		protected void InitTweenAnim(int componentType)
		{
			this.TweenAnimPlayer.InitTweenAnim(componentType, base.GetItem(componentType), false);
		}

		// Token: 0x06032344 RID: 205636 RVA: 0x00E1251D File Offset: 0x00E1071D
		protected void PlayTweenAnim(int componentType)
		{
			this.TweenAnimPlayer.PlayTweenAnim(componentType);
		}

		// Token: 0x06032345 RID: 205637 RVA: 0x00E1252B File Offset: 0x00E1072B
		protected void StopTweenAnim(int componentType)
		{
			this.TweenAnimPlayer.StopTweenAnim(componentType);
		}

		// Token: 0x06032346 RID: 205638 RVA: 0x00E12539 File Offset: 0x00E10739
		protected virtual void ClearAllTweenAnim()
		{
			this.TweenAnimPlayer.Clear(false);
		}

		// Token: 0x0401A9A5 RID: 108965
		[Nullable(1)]
		protected BattleUiTweenAnimPlayer TweenAnimPlayer = new BattleUiTweenAnimPlayer();

		// Token: 0x0200AB88 RID: 43912
		internal enum EChildType
		{
			// Token: 0x04035148 RID: 217416
			NormalItem,
			// Token: 0x04035149 RID: 217417
			LightNodeItem,
			// Token: 0x0403514A RID: 217418
			AniStart,
			// Token: 0x0403514B RID: 217419
			AniFull
		}
	}
}
