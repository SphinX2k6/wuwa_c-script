using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D3C RID: 23868
	public class HeadIconEnergyBarSuisui : HeadIconEnergyBarBase
	{
		// Token: 0x0603C892 RID: 247954 RVA: 0x00E86110 File Offset: 0x00E84310
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

		// Token: 0x0603C893 RID: 247955 RVA: 0x00E861BB File Offset: 0x00E843BB
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagCountChanged(HeadIconEnergyBarSuisui.FeixianCountTagId, new BaseTagComponent.TTagChangedCallback(this.OnFeixianCountChanged));
			base.ListenForTagAddOrRemoveChanged(HeadIconEnergyBarSuisui.FeixianStateTagId, new BaseTagComponent.TTagSwitchedCallback(this.OnFeixianStateChanged));
		}

		// Token: 0x0603C894 RID: 247956 RVA: 0x00E861F1 File Offset: 0x00E843F1
		protected override void RemoveEvents()
		{
			base.RemoveEvents();
			base.RemoveListenTagCountChanged(HeadIconEnergyBarSuisui.FeixianCountTagId);
			base.RemoveListenTagAddOrRemove(HeadIconEnergyBarSuisui.FeixianStateTagId);
		}

		// Token: 0x0603C895 RID: 247957 RVA: 0x00E8620F File Offset: 0x00E8440F
		protected override void OnBeforeShow()
		{
			base.OnBeforeShow();
			this.SetState(this.GetCurrentState(), true);
		}

		// Token: 0x0603C896 RID: 247958 RVA: 0x00E86224 File Offset: 0x00E84424
		private HeadIconEnergyBarSuisui.EState GetCurrentState()
		{
			BaseTagComponent tagComponent = this.TagComponent;
			if (tagComponent == null || !tagComponent.HasTag(HeadIconEnergyBarSuisui.FeixianStateTagId))
			{
				return HeadIconEnergyBarSuisui.EState.Normal;
			}
			return HeadIconEnergyBarSuisui.EState.Feixian;
		}

		// Token: 0x0603C897 RID: 247959 RVA: 0x00E86242 File Offset: 0x00E84442
		private void OnFeixianStateChanged(int tagId, bool tagExist)
		{
			this.SetState(tagExist ? HeadIconEnergyBarSuisui.EState.Feixian : HeadIconEnergyBarSuisui.EState.Normal, false);
		}

		// Token: 0x0603C898 RID: 247960 RVA: 0x00E86254 File Offset: 0x00E84454
		private void SetState(HeadIconEnergyBarSuisui.EState state, bool isForced = false)
		{
			if (this.CurState == state && !isForced)
			{
				return;
			}
			this.CurState = state;
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(this.CurState == HeadIconEnergyBarSuisui.EState.Feixian);
			}
			if (this.CurState == HeadIconEnergyBarSuisui.EState.Feixian)
			{
				this.RefreshFeixianCount(this.GetFeixianCount(), true);
			}
		}

		// Token: 0x0603C899 RID: 247961 RVA: 0x00E862A6 File Offset: 0x00E844A6
		private int GetFeixianCount()
		{
			BaseTagComponent tagComponent = this.TagComponent;
			if (tagComponent == null)
			{
				return 0;
			}
			return tagComponent.GetTagCount(HeadIconEnergyBarSuisui.FeixianCountTagId);
		}

		// Token: 0x0603C89A RID: 247962 RVA: 0x00E862BE File Offset: 0x00E844BE
		private void OnFeixianCountChanged(int count, int tagId, int exactTagId, int oldCount)
		{
			if (count == oldCount || this.CurState == HeadIconEnergyBarSuisui.EState.Normal)
			{
				return;
			}
			this.RefreshFeixianCount(count, false);
		}

		// Token: 0x0603C89B RID: 247963 RVA: 0x00E862D8 File Offset: 0x00E844D8
		private void RefreshFeixianCount(int count, bool isForced = false)
		{
			if (this.FeixianCount == count && !isForced)
			{
				return;
			}
			this.FeixianCount = count;
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				item.SetUIActive(count >= 1);
			}
			UUIItem item2 = base.GetItem(1);
			if (item2 != null)
			{
				item2.SetUIActive(count >= 2);
			}
			UUIItem item3 = base.GetItem(2);
			if (item3 == null)
			{
				return;
			}
			item3.SetUIActive(count >= 3);
		}

		// Token: 0x0401F89A RID: 129178
		private static readonly int FeixianCountTagId = GameplayTagDefine.EGameplayTagId["角色.R2T1SuisuiMd10011.飞仙.飞仙次数"];

		// Token: 0x0401F89B RID: 129179
		private static readonly int FeixianStateTagId = GameplayTagDefine.EGameplayTagId["角色.R2T1SuisuiMd10011.飞仙.允许飞仙"];

		// Token: 0x0401F89C RID: 129180
		private int FeixianCount;

		// Token: 0x0401F89D RID: 129181
		private HeadIconEnergyBarSuisui.EState CurState;

		// Token: 0x0200BFDA RID: 49114
		private enum EState
		{
			// Token: 0x04039E17 RID: 237079
			Normal,
			// Token: 0x04039E18 RID: 237080
			Feixian
		}

		// Token: 0x0200BFDB RID: 49115
		private enum EChildType
		{
			// Token: 0x04039E1A RID: 237082
			SprPartFg01,
			// Token: 0x04039E1B RID: 237083
			SprPartFg02,
			// Token: 0x04039E1C RID: 237084
			SprPartFg03,
			// Token: 0x04039E1D RID: 237085
			FullBar
		}
	}
}
