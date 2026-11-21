using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D1D RID: 19741
	public class HeadIconEnergyBarRuibeika : HeadIconEnergyBarBase
	{
		// Token: 0x060317DD RID: 202717 RVA: 0x00DD648C File Offset: 0x00DD468C
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

		// Token: 0x060317DE RID: 202718 RVA: 0x00DD659C File Offset: 0x00DD479C
		protected override UniTask OnBeforeStartAsync()
		{
			HeadIconEnergyBarRuibeika.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<HeadIconEnergyBarRuibeika.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060317DF RID: 202719 RVA: 0x00DD65E0 File Offset: 0x00DD47E0
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

		// Token: 0x060317E0 RID: 202720 RVA: 0x00DD6678 File Offset: 0x00DD4878
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

		// Token: 0x060317E1 RID: 202721 RVA: 0x00DD66E3 File Offset: 0x00DD48E3
		protected override void OnBeforeShow()
		{
			this.CurState = this.GetCurrentStateByTag();
			base.OnBeforeShow();
			this.RefreshBarPercent(true, true);
		}

		// Token: 0x060317E2 RID: 202722 RVA: 0x00DD6700 File Offset: 0x00DD4900
		private HeadIconEnergyBarRuibeika.EState GetCurrentStateByTag()
		{
			BaseTagComponent tagComponent = this.TagComponent;
			if (!((tagComponent != null) ? new bool?(tagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.R2T1RebeccaMd10011.状态.铁胆状态"])) : null).GetValueOrDefault())
			{
				return HeadIconEnergyBarRuibeika.EState.StateGun;
			}
			return HeadIconEnergyBarRuibeika.EState.StateRifle;
		}

		// Token: 0x060317E3 RID: 202723 RVA: 0x00DD6748 File Offset: 0x00DD4948
		private int GetCurrentColorAnim()
		{
			if (this.CurState != HeadIconEnergyBarRuibeika.EState.StateGun)
			{
				return 3;
			}
			return 4;
		}

		// Token: 0x060317E4 RID: 202724 RVA: 0x00DD6758 File Offset: 0x00DD4958
		private void PlayCurrentColorAnim()
		{
			int currentColorAnim = this.GetCurrentColorAnim();
			base.StopTweenAnim((currentColorAnim == 4) ? 3 : 4);
			base.PlayTweenAnim(currentColorAnim);
		}

		// Token: 0x060317E5 RID: 202725 RVA: 0x00DD6781 File Offset: 0x00DD4981
		private void SetState(HeadIconEnergyBarRuibeika.EState state, bool force = false)
		{
			if (this.CurState == state && !force)
			{
				return;
			}
			this.CurState = state;
			this.RefreshBarPercent(true, true);
		}

		// Token: 0x060317E6 RID: 202726 RVA: 0x00DD679F File Offset: 0x00DD499F
		protected override void OnBarPercentChanged()
		{
			this.RefreshBarPercent(false, false);
		}

		// Token: 0x060317E7 RID: 202727 RVA: 0x00DD67AC File Offset: 0x00DD49AC
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

		// Token: 0x060317EA RID: 202730 RVA: 0x00DD688D File Offset: 0x00DD4A8D
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

		// Token: 0x0401A350 RID: 107344
		private HeadIconEnergyBarRuibeika.EState CurState;

		// Token: 0x0401A351 RID: 107345
		private bool IsFull;

		// Token: 0x0401A352 RID: 107346
		[Nullable(1)]
		private readonly List<SpecialEnergyBarRuibeikaDot> C1DotItems = new List<SpecialEnergyBarRuibeikaDot>();

		// Token: 0x0200A9DC RID: 43484
		private enum EState
		{
			// Token: 0x040347C8 RID: 214984
			StateGun,
			// Token: 0x040347C9 RID: 214985
			StateRifle,
			// Token: 0x040347CA RID: 214986
			StateUlt
		}

		// Token: 0x0200A9DD RID: 43485
		private class EChildType
		{
			// Token: 0x040347CB RID: 214987
			public const int PnlBarC1 = 0;

			// Token: 0x040347CC RID: 214988
			public const int PnlItemC1 = 1;

			// Token: 0x040347CD RID: 214989
			public const int FullCtrl = 2;

			// Token: 0x040347CE RID: 214990
			public const int AniRed = 3;

			// Token: 0x040347CF RID: 214991
			public const int AniGreen = 4;

			// Token: 0x040347D0 RID: 214992
			public const int AniR2G = 5;

			// Token: 0x040347D1 RID: 214993
			public const int AniG2R = 6;
		}
	}
}
