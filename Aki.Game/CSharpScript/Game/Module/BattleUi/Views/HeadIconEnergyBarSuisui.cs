using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D1E RID: 19742
	public class HeadIconEnergyBarSuisui : HeadIconEnergyBarBase
	{
		// Token: 0x060317EB RID: 202731 RVA: 0x00DD68B0 File Offset: 0x00DD4AB0
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

		// Token: 0x060317EC RID: 202732 RVA: 0x00DD695B File Offset: 0x00DD4B5B
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagCountChanged(HeadIconEnergyBarSuisui.FeixianCountTagId, new BaseTagComponent.TTagChangedCallback(this.OnFeixianCountChanged));
			base.ListenForTagAddOrRemoveChanged(HeadIconEnergyBarSuisui.FeixianStateTagId, new BaseTagComponent.TTagSwitchedCallback(this.OnFeixianStateChanged));
		}

		// Token: 0x060317ED RID: 202733 RVA: 0x00DD6991 File Offset: 0x00DD4B91
		protected override void RemoveEvents()
		{
			base.RemoveEvents();
			base.RemoveListenTagCountChanged(HeadIconEnergyBarSuisui.FeixianCountTagId);
			base.RemoveListenTagAddOrRemove(HeadIconEnergyBarSuisui.FeixianStateTagId);
		}

		// Token: 0x060317EE RID: 202734 RVA: 0x00DD69AF File Offset: 0x00DD4BAF
		protected override void OnBeforeShow()
		{
			base.OnBeforeShow();
			this.SetState(this.GetCurrentState(), true);
		}

		// Token: 0x060317EF RID: 202735 RVA: 0x00DD69C4 File Offset: 0x00DD4BC4
		private HeadIconEnergyBarSuisui.EState GetCurrentState()
		{
			BaseTagComponent tagComponent = this.TagComponent;
			if (tagComponent == null || !tagComponent.HasTag(HeadIconEnergyBarSuisui.FeixianStateTagId))
			{
				return HeadIconEnergyBarSuisui.EState.Normal;
			}
			return HeadIconEnergyBarSuisui.EState.Feixian;
		}

		// Token: 0x060317F0 RID: 202736 RVA: 0x00DD69E2 File Offset: 0x00DD4BE2
		private void OnFeixianStateChanged(int tagId, bool tagExist)
		{
			this.SetState(tagExist ? HeadIconEnergyBarSuisui.EState.Feixian : HeadIconEnergyBarSuisui.EState.Normal, false);
		}

		// Token: 0x060317F1 RID: 202737 RVA: 0x00DD69F4 File Offset: 0x00DD4BF4
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

		// Token: 0x060317F2 RID: 202738 RVA: 0x00DD6A46 File Offset: 0x00DD4C46
		private int GetFeixianCount()
		{
			BaseTagComponent tagComponent = this.TagComponent;
			if (tagComponent == null)
			{
				return 0;
			}
			return tagComponent.GetTagCount(HeadIconEnergyBarSuisui.FeixianCountTagId);
		}

		// Token: 0x060317F3 RID: 202739 RVA: 0x00DD6A5E File Offset: 0x00DD4C5E
		private void OnFeixianCountChanged(int count, int tagId, int exactTagId, int oldCount)
		{
			if (count == oldCount || this.CurState == HeadIconEnergyBarSuisui.EState.Normal)
			{
				return;
			}
			this.RefreshFeixianCount(count, false);
		}

		// Token: 0x060317F4 RID: 202740 RVA: 0x00DD6A78 File Offset: 0x00DD4C78
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

		// Token: 0x0401A353 RID: 107347
		private static readonly int FeixianCountTagId = GameplayTagDefine.EGameplayTagId["角色.R2T1SuisuiMd10011.飞仙.飞仙次数"];

		// Token: 0x0401A354 RID: 107348
		private static readonly int FeixianStateTagId = GameplayTagDefine.EGameplayTagId["角色.R2T1SuisuiMd10011.飞仙.允许飞仙"];

		// Token: 0x0401A355 RID: 107349
		private int FeixianCount;

		// Token: 0x0401A356 RID: 107350
		private HeadIconEnergyBarSuisui.EState CurState;

		// Token: 0x0200A9E0 RID: 43488
		private enum EState
		{
			// Token: 0x040347D9 RID: 215001
			Normal,
			// Token: 0x040347DA RID: 215002
			Feixian
		}

		// Token: 0x0200A9E1 RID: 43489
		private enum EChildType
		{
			// Token: 0x040347DC RID: 215004
			SprPartFg01,
			// Token: 0x040347DD RID: 215005
			SprPartFg02,
			// Token: 0x040347DE RID: 215006
			SprPartFg03,
			// Token: 0x040347DF RID: 215007
			FullBar
		}
	}
}
