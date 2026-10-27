using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D3B RID: 23867
	public class HeadIconEnergyBarRuibeika : HeadIconEnergyBarBase
	{
		// Token: 0x0603C884 RID: 247940 RVA: 0x00E85CEC File Offset: 0x00E83EEC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
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
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603C885 RID: 247941 RVA: 0x00E85DFC File Offset: 0x00E83FFC
		protected override UniTask OnBeforeStartAsync()
		{
			HeadIconEnergyBarRuibeika.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<HeadIconEnergyBarRuibeika.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603C886 RID: 247942 RVA: 0x00E85E40 File Offset: 0x00E84040
		[NullableContext(1)]
		private void InitDotItems(List<SpecialEnergyBarRuibeikaDot> arr, int org, int parent)
		{
			UUIItem item = base.GetItem(org);
			UUIItem item2 = base.GetItem(parent);
			int num = this.Config.Value.Params(0);
			int num2 = (num != 0) ? num : 9;
			for (int i = 0; i < num2; i++)
			{
				AActor actor = (i == 0) ? item.GetOwner() : LguiUtil.Instance.DuplicateActor(item.GetOwner(), item2);
				SpecialEnergyBarRuibeikaDot specialEnergyBarRuibeikaDot = new SpecialEnergyBarRuibeikaDot(0);
				specialEnergyBarRuibeikaDot.SkipDestroyActor = true;
				specialEnergyBarRuibeikaDot.Index = i;
				specialEnergyBarRuibeikaDot.CreateByActorAsync(actor, null, false);
				arr.Add(specialEnergyBarRuibeikaDot);
			}
		}

		// Token: 0x0603C887 RID: 247943 RVA: 0x00E85ED8 File Offset: 0x00E840D8
		protected override void OnStart()
		{
			base.OnStart();
			for (int i = 3; i <= 6; i++)
			{
				base.InitTweenAnim(i);
			}
			base.ListenForTagAddOrRemoveChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1RebeccaMd10011.状态.手枪状态"], this.<OnStart>g__onStateChanged|8_0(HeadIconEnergyBarRuibeika.EState.StateGun));
			base.ListenForTagAddOrRemoveChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1RebeccaMd10011.状态.铁胆状态"], this.<OnStart>g__onStateChanged|8_0(HeadIconEnergyBarRuibeika.EState.StateRifle));
			this.SetState(this.GetCurrentStateByTag(), true);
		}

		// Token: 0x0603C888 RID: 247944 RVA: 0x00E85F43 File Offset: 0x00E84143
		protected override void OnBeforeShow()
		{
			this.CurState = this.GetCurrentStateByTag();
			base.OnBeforeShow();
			this.RefreshBarPercent(true, true);
		}

		// Token: 0x0603C889 RID: 247945 RVA: 0x00E85F60 File Offset: 0x00E84160
		private HeadIconEnergyBarRuibeika.EState GetCurrentStateByTag()
		{
			BaseTagComponent tagComponent = this.TagComponent;
			if (!((tagComponent != null) ? new bool?(tagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.R2T1RebeccaMd10011.状态.铁胆状态"])) : null).GetValueOrDefault())
			{
				return HeadIconEnergyBarRuibeika.EState.StateGun;
			}
			return HeadIconEnergyBarRuibeika.EState.StateRifle;
		}

		// Token: 0x0603C88A RID: 247946 RVA: 0x00E85FA8 File Offset: 0x00E841A8
		private int GetCurrentColorAnim()
		{
			if (this.CurState != HeadIconEnergyBarRuibeika.EState.StateGun)
			{
				return 3;
			}
			return 4;
		}

		// Token: 0x0603C88B RID: 247947 RVA: 0x00E85FB8 File Offset: 0x00E841B8
		private void PlayCurrentColorAnim()
		{
			int currentColorAnim = this.GetCurrentColorAnim();
			base.StopTweenAnim((currentColorAnim == 4) ? 3 : 4);
			base.PlayTweenAnim(currentColorAnim);
		}

		// Token: 0x0603C88C RID: 247948 RVA: 0x00E85FE1 File Offset: 0x00E841E1
		private void SetState(HeadIconEnergyBarRuibeika.EState state, bool force = false)
		{
			if (this.CurState == state && !force)
			{
				return;
			}
			this.CurState = state;
			this.RefreshBarPercent(true, true);
		}

		// Token: 0x0603C88D RID: 247949 RVA: 0x00E85FFF File Offset: 0x00E841FF
		protected override void OnBarPercentChanged()
		{
			this.RefreshBarPercent(false, false);
		}

		// Token: 0x0603C88E RID: 247950 RVA: 0x00E8600C File Offset: 0x00E8420C
		private void RefreshBarPercent(bool bForce = false, bool forceColor = false)
		{
			float curPercent = this.PercentMachine.GetCurPercent();
			bool flag = curPercent >= 1f;
			List<SpecialEnergyBarRuibeikaDot> c1DotItems = this.C1DotItems;
			float num = 0.5f / (float)c1DotItems.Count;
			double num2 = flag ? ((double)c1DotItems.Count) : Math.Floor((double)(curPercent * (float)c1DotItems.Count));
			for (int i = 0; i < c1DotItems.Count; i++)
			{
				bool b = (i == 0) ? (curPercent > num) : ((double)i < num2);
				c1DotItems[i].SetVisible(b, this.CurState == HeadIconEnergyBarRuibeika.EState.StateGun, bForce);
			}
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			if (forceColor || (flag && !this.IsFull))
			{
				this.PlayCurrentColorAnim();
			}
			this.IsFull = flag;
		}

		// Token: 0x0603C891 RID: 247953 RVA: 0x00E860ED File Offset: 0x00E842ED
		[NullableContext(1)]
		[CompilerGenerated]
		private BaseTagComponent.TTagSwitchedCallback <OnStart>g__onStateChanged|8_0(HeadIconEnergyBarRuibeika.EState state)
		{
			return delegate(int tagId, bool tagExist)
			{
				if (tagExist)
				{
					this.SetState(state, false);
				}
			};
		}

		// Token: 0x0401F897 RID: 129175
		private HeadIconEnergyBarRuibeika.EState CurState;

		// Token: 0x0401F898 RID: 129176
		private bool IsFull;

		// Token: 0x0401F899 RID: 129177
		[Nullable(1)]
		private readonly List<SpecialEnergyBarRuibeikaDot> C1DotItems = new List<SpecialEnergyBarRuibeikaDot>();

		// Token: 0x0200BFD6 RID: 49110
		private enum EState
		{
			// Token: 0x04039E06 RID: 237062
			StateGun,
			// Token: 0x04039E07 RID: 237063
			StateRifle,
			// Token: 0x04039E08 RID: 237064
			StateUlt
		}

		// Token: 0x0200BFD7 RID: 49111
		private class EChildType
		{
			// Token: 0x04039E09 RID: 237065
			public const int PnlBarC1 = 0;

			// Token: 0x04039E0A RID: 237066
			public const int PnlItemC1 = 1;

			// Token: 0x04039E0B RID: 237067
			public const int FullCtrl = 2;

			// Token: 0x04039E0C RID: 237068
			public const int AniRed = 3;

			// Token: 0x04039E0D RID: 237069
			public const int AniGreen = 4;

			// Token: 0x04039E0E RID: 237070
			public const int AniR2G = 5;

			// Token: 0x04039E0F RID: 237071
			public const int AniG2R = 6;
		}
	}
}
