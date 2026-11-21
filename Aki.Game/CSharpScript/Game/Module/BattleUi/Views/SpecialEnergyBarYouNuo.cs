using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DF8 RID: 19960
	public class SpecialEnergyBarYouNuo : SpecialEnergyBarBase
	{
		// Token: 0x06032372 RID: 205682 RVA: 0x00E133E8 File Offset: 0x00E115E8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 11;
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
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUINiagara));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06032373 RID: 205683 RVA: 0x00E13580 File Offset: 0x00E11780
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarYouNuo.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarYouNuo.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032374 RID: 205684 RVA: 0x00E135C4 File Offset: 0x00E117C4
		protected UniTask InitBarItem()
		{
			SpecialEnergyBarYouNuo.<InitBarItem>d__15 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarYouNuo.<InitBarItem>d__15>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x06032375 RID: 205685 RVA: 0x00E13608 File Offset: 0x00E11808
		protected override void OnStart()
		{
			base.InitTweenAnim(5);
			base.InitTweenAnim(6);
			base.InitTweenAnim(7);
			base.InitTweenAnim(8);
			BaseTagComponent tagComponent = this.TagComponent;
			this.IsQuarterMoon = (tagComponent != null && tagComponent.HasTag(SpecialEnergyBarYouNuo.QuarterMoonTag));
			BaseTagComponent tagComponent2 = this.TagComponent;
			this.IsNewMoon = (tagComponent2 != null && tagComponent2.HasTag(SpecialEnergyBarYouNuo.NewMoonTag));
			BaseTagComponent tagComponent3 = this.TagComponent;
			this.IsNormalSkillEnable = (tagComponent3 != null && tagComponent3.HasTag(SpecialEnergyBarYouNuo.NormalSkillEnableTag));
			this.RefreshBarPercent(true);
			this.BarItem.SetKeyItemEnable(0, this.IsNormalSkillEnable, true);
		}

		// Token: 0x06032376 RID: 205686 RVA: 0x00E136A4 File Offset: 0x00E118A4
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarYouNuo.QuarterMoonTag, new BaseTagComponent.TTagSwitchedCallback(this.OnQuarterMoonTagChange));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarYouNuo.NewMoonTag, new BaseTagComponent.TTagSwitchedCallback(this.OnNewMoonTagChange));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarYouNuo.NormalSkillEnableTag, new BaseTagComponent.TTagSwitchedCallback(this.OnNormalSkillEnableTagChange));
		}

		// Token: 0x06032377 RID: 205687 RVA: 0x00E136FC File Offset: 0x00E118FC
		private void OnQuarterMoonTagChange(int tagId, bool tagExist)
		{
			this.IsQuarterMoon = tagExist;
			this.RefreshState(false);
		}

		// Token: 0x06032378 RID: 205688 RVA: 0x00E1370C File Offset: 0x00E1190C
		private void OnNewMoonTagChange(int tagId, bool tagExist)
		{
			this.IsNewMoon = tagExist;
			this.RefreshState(false);
		}

		// Token: 0x06032379 RID: 205689 RVA: 0x00E1371C File Offset: 0x00E1191C
		private void OnNormalSkillEnableTagChange(int tagId, bool tagExist)
		{
			this.IsNormalSkillEnable = tagExist;
			this.BarItem.SetKeyItemEnable(0, this.IsNormalSkillEnable, true);
		}

		// Token: 0x0603237A RID: 205690 RVA: 0x00E13738 File Offset: 0x00E11938
		protected override void OnBarPercentChanged()
		{
			this.RefreshBarPercent(false);
		}

		// Token: 0x0603237B RID: 205691 RVA: 0x00E13741 File Offset: 0x00E11941
		protected override void OnKeyEnableChanged()
		{
			this.RefreshBarPercent(false);
		}

		// Token: 0x0603237C RID: 205692 RVA: 0x00E1374C File Offset: 0x00E1194C
		private void RefreshBarPercent(bool isStart = false)
		{
			float curPercent = this.PercentMachine.GetCurPercent();
			this.IsFull = (curPercent >= 1f);
			this.RefreshNewMoonEffectPercent(curPercent);
			this.RefreshState(isStart);
		}

		// Token: 0x0603237D RID: 205693 RVA: 0x00E13784 File Offset: 0x00E11984
		private void RefreshNewMoonEffectPercent(float percent)
		{
			if (this.State != SpecialEnergyBarYouNuo.EState.NewMoon)
			{
				return;
			}
			base.GetUiNiagara(9).SetNiagaraVarFloat("Dissolve", Math.Min(percent * 2f, 1f));
			base.GetUiNiagara(10).SetNiagaraVarFloat("Dissolve", Math.Max(percent * 2f - 1f, 0f));
		}

		// Token: 0x0603237E RID: 205694 RVA: 0x00E137E8 File Offset: 0x00E119E8
		private void RefreshState(bool isStart = false)
		{
			SpecialEnergyBarYouNuo.EState estate = SpecialEnergyBarYouNuo.EState.Normal;
			if (this.IsQuarterMoon)
			{
				estate = SpecialEnergyBarYouNuo.EState.QuarterMoon;
			}
			else if (this.IsNewMoon)
			{
				estate = SpecialEnergyBarYouNuo.EState.NewMoon;
			}
			else if (this.IsFull)
			{
				estate = SpecialEnergyBarYouNuo.EState.Full;
			}
			if (this.State == estate && !isStart)
			{
				return;
			}
			this.State = estate;
			if (this.CurAnim >= 0)
			{
				base.StopTweenAnim(this.CurAnim);
				this.CurAnim = -1;
			}
			float fullEffectPercent = 1.1f;
			int keyItemType = 0;
			int barColor = 0;
			switch (this.State)
			{
			case SpecialEnergyBarYouNuo.EState.Normal:
				this.CurAnim = 8;
				break;
			case SpecialEnergyBarYouNuo.EState.Full:
				this.CurAnim = 5;
				break;
			case SpecialEnergyBarYouNuo.EState.QuarterMoon:
				keyItemType = 1;
				barColor = 1;
				this.CurAnim = 6;
				break;
			case SpecialEnergyBarYouNuo.EState.NewMoon:
				keyItemType = 2;
				barColor = 2;
				this.CurAnim = 7;
				fullEffectPercent = 0f;
				this.RefreshNewMoonEffectPercent(this.PercentMachine.GetCurPercent());
				break;
			}
			if (this.CurAnim >= 0)
			{
				base.PlayTweenAnim(this.CurAnim);
			}
			if (this.BarItem != null)
			{
				this.BarItem.SetKeyItemType(keyItemType);
				this.BarItem.SetFullEffectPercent(fullEffectPercent);
				this.BarItem.SetBarColor(barColor);
			}
		}

		// Token: 0x0603237F RID: 205695 RVA: 0x00E138F6 File Offset: 0x00E11AF6
		public override void Tick(float delta)
		{
			base.Tick(delta);
			SpecialEnergyBarYouNuoSlot barItem = this.BarItem;
			if (barItem == null)
			{
				return;
			}
			barItem.Tick(delta);
		}

		// Token: 0x0401A9C2 RID: 108994
		private const float EFFECT_BASE_PERCENT = 0.4390244f;

		// Token: 0x0401A9C3 RID: 108995
		[StaticVariableRuleIgnore]
		private static readonly int QuarterMoonTag = GameplayTagDefine.EGameplayTagId["角色.R2T1YounuoMd10011.状态标识.环刃模式"];

		// Token: 0x0401A9C4 RID: 108996
		[StaticVariableRuleIgnore]
		private static readonly int NewMoonTag = GameplayTagDefine.EGameplayTagId["角色.R2T1YounuoMd10011.状态标识.月弓模式"];

		// Token: 0x0401A9C5 RID: 108997
		[StaticVariableRuleIgnore]
		private static readonly int NormalSkillEnableTag = GameplayTagDefine.EGameplayTagId["角色.R2T1YounuoMd10011.状态标识.E2可使用"];

		// Token: 0x0401A9C6 RID: 108998
		[Nullable(2)]
		private SpecialEnergyBarYouNuoSlot BarItem;

		// Token: 0x0401A9C7 RID: 108999
		private bool IsFull;

		// Token: 0x0401A9C8 RID: 109000
		private bool IsQuarterMoon;

		// Token: 0x0401A9C9 RID: 109001
		private bool IsNewMoon;

		// Token: 0x0401A9CA RID: 109002
		private bool IsNormalSkillEnable;

		// Token: 0x0401A9CB RID: 109003
		private SpecialEnergyBarYouNuo.EState State;

		// Token: 0x0401A9CC RID: 109004
		private int CurAnim = -1;

		// Token: 0x0200AB8F RID: 43919
		private enum EChildType
		{
			// Token: 0x04035170 RID: 217456
			SlotBarItem,
			// Token: 0x04035171 RID: 217457
			NormalItem,
			// Token: 0x04035172 RID: 217458
			FullItem,
			// Token: 0x04035173 RID: 217459
			QuarterMoonItem,
			// Token: 0x04035174 RID: 217460
			NewMoonItem,
			// Token: 0x04035175 RID: 217461
			AniFull,
			// Token: 0x04035176 RID: 217462
			AniQuarterMoon,
			// Token: 0x04035177 RID: 217463
			AniNewMoon,
			// Token: 0x04035178 RID: 217464
			AniNormal,
			// Token: 0x04035179 RID: 217465
			NewMoonBarEffectL,
			// Token: 0x0403517A RID: 217466
			NewMoonBarEffectR
		}

		// Token: 0x0200AB90 RID: 43920
		private enum EState
		{
			// Token: 0x0403517C RID: 217468
			Normal,
			// Token: 0x0403517D RID: 217469
			Full,
			// Token: 0x0403517E RID: 217470
			QuarterMoon,
			// Token: 0x0403517F RID: 217471
			NewMoon
		}
	}
}
