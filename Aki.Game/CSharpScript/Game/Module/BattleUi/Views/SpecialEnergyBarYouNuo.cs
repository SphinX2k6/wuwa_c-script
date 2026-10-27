using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E13 RID: 24083
	public class SpecialEnergyBarYouNuo : SpecialEnergyBarBase
	{
		// Token: 0x0603D3E3 RID: 250851 RVA: 0x00EC1E88 File Offset: 0x00EC0088
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

		// Token: 0x0603D3E4 RID: 250852 RVA: 0x00EC2020 File Offset: 0x00EC0220
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarYouNuo.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarYouNuo.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D3E5 RID: 250853 RVA: 0x00EC2064 File Offset: 0x00EC0264
		protected UniTask InitBarItem()
		{
			SpecialEnergyBarYouNuo.<InitBarItem>d__15 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarYouNuo.<InitBarItem>d__15>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603D3E6 RID: 250854 RVA: 0x00EC20A8 File Offset: 0x00EC02A8
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

		// Token: 0x0603D3E7 RID: 250855 RVA: 0x00EC2144 File Offset: 0x00EC0344
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarYouNuo.QuarterMoonTag, new BaseTagComponent.TTagSwitchedCallback(this.OnQuarterMoonTagChange));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarYouNuo.NewMoonTag, new BaseTagComponent.TTagSwitchedCallback(this.OnNewMoonTagChange));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarYouNuo.NormalSkillEnableTag, new BaseTagComponent.TTagSwitchedCallback(this.OnNormalSkillEnableTagChange));
		}

		// Token: 0x0603D3E8 RID: 250856 RVA: 0x00EC219C File Offset: 0x00EC039C
		private void OnQuarterMoonTagChange(int tagId, bool tagExist)
		{
			this.IsQuarterMoon = tagExist;
			this.RefreshState(false);
		}

		// Token: 0x0603D3E9 RID: 250857 RVA: 0x00EC21AC File Offset: 0x00EC03AC
		private void OnNewMoonTagChange(int tagId, bool tagExist)
		{
			this.IsNewMoon = tagExist;
			this.RefreshState(false);
		}

		// Token: 0x0603D3EA RID: 250858 RVA: 0x00EC21BC File Offset: 0x00EC03BC
		private void OnNormalSkillEnableTagChange(int tagId, bool tagExist)
		{
			this.IsNormalSkillEnable = tagExist;
			this.BarItem.SetKeyItemEnable(0, this.IsNormalSkillEnable, true);
		}

		// Token: 0x0603D3EB RID: 250859 RVA: 0x00EC21D8 File Offset: 0x00EC03D8
		protected override void OnBarPercentChanged()
		{
			this.RefreshBarPercent(false);
		}

		// Token: 0x0603D3EC RID: 250860 RVA: 0x00EC21E1 File Offset: 0x00EC03E1
		protected override void OnKeyEnableChanged()
		{
			this.RefreshBarPercent(false);
		}

		// Token: 0x0603D3ED RID: 250861 RVA: 0x00EC21EC File Offset: 0x00EC03EC
		private void RefreshBarPercent(bool isStart = false)
		{
			float curPercent = this.PercentMachine.GetCurPercent();
			this.IsFull = (curPercent >= 1f);
			this.RefreshNewMoonEffectPercent(curPercent);
			this.RefreshState(isStart);
		}

		// Token: 0x0603D3EE RID: 250862 RVA: 0x00EC2224 File Offset: 0x00EC0424
		private void RefreshNewMoonEffectPercent(float percent)
		{
			if (this.State != SpecialEnergyBarYouNuo.EState.NewMoon)
			{
				return;
			}
			base.GetUiNiagara(9).SetNiagaraVarFloat("Dissolve", Math.Min(percent * 2f, 1f));
			base.GetUiNiagara(10).SetNiagaraVarFloat("Dissolve", Math.Max(percent * 2f - 1f, 0f));
		}

		// Token: 0x0603D3EF RID: 250863 RVA: 0x00EC2288 File Offset: 0x00EC0488
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

		// Token: 0x0603D3F0 RID: 250864 RVA: 0x00EC2396 File Offset: 0x00EC0596
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

		// Token: 0x0401FEFB RID: 130811
		private const float EFFECT_BASE_PERCENT = 0.4390244f;

		// Token: 0x0401FEFC RID: 130812
		[StaticVariableRuleIgnore]
		private static readonly int QuarterMoonTag = GameplayTagDefine.EGameplayTagId["角色.R2T1YounuoMd10011.状态标识.环刃模式"];

		// Token: 0x0401FEFD RID: 130813
		[StaticVariableRuleIgnore]
		private static readonly int NewMoonTag = GameplayTagDefine.EGameplayTagId["角色.R2T1YounuoMd10011.状态标识.月弓模式"];

		// Token: 0x0401FEFE RID: 130814
		[StaticVariableRuleIgnore]
		private static readonly int NormalSkillEnableTag = GameplayTagDefine.EGameplayTagId["角色.R2T1YounuoMd10011.状态标识.E2可使用"];

		// Token: 0x0401FEFF RID: 130815
		[Nullable(2)]
		private SpecialEnergyBarYouNuoSlot BarItem;

		// Token: 0x0401FF00 RID: 130816
		private bool IsFull;

		// Token: 0x0401FF01 RID: 130817
		private bool IsQuarterMoon;

		// Token: 0x0401FF02 RID: 130818
		private bool IsNewMoon;

		// Token: 0x0401FF03 RID: 130819
		private bool IsNormalSkillEnable;

		// Token: 0x0401FF04 RID: 130820
		private SpecialEnergyBarYouNuo.EState State;

		// Token: 0x0401FF05 RID: 130821
		private int CurAnim = -1;

		// Token: 0x0200C180 RID: 49536
		private enum EChildType
		{
			// Token: 0x0403A77E RID: 239486
			SlotBarItem,
			// Token: 0x0403A77F RID: 239487
			NormalItem,
			// Token: 0x0403A780 RID: 239488
			FullItem,
			// Token: 0x0403A781 RID: 239489
			QuarterMoonItem,
			// Token: 0x0403A782 RID: 239490
			NewMoonItem,
			// Token: 0x0403A783 RID: 239491
			AniFull,
			// Token: 0x0403A784 RID: 239492
			AniQuarterMoon,
			// Token: 0x0403A785 RID: 239493
			AniNewMoon,
			// Token: 0x0403A786 RID: 239494
			AniNormal,
			// Token: 0x0403A787 RID: 239495
			NewMoonBarEffectL,
			// Token: 0x0403A788 RID: 239496
			NewMoonBarEffectR
		}

		// Token: 0x0200C181 RID: 49537
		private enum EState
		{
			// Token: 0x0403A78A RID: 239498
			Normal,
			// Token: 0x0403A78B RID: 239499
			Full,
			// Token: 0x0403A78C RID: 239500
			QuarterMoon,
			// Token: 0x0403A78D RID: 239501
			NewMoon
		}
	}
}
