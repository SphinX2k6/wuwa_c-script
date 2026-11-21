using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DFA RID: 19962
	[NullableContext(2)]
	[Nullable(0)]
	public class SpecialEnergyBarZanni : SpecialEnergyBarBase
	{
		// Token: 0x0603238D RID: 205709 RVA: 0x00E13C8C File Offset: 0x00E11E8C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 14;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603238E RID: 205710 RVA: 0x00E13E87 File Offset: 0x00E12087
		protected override void OnInitData()
		{
			this.MorphConfig = BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(150701);
			this.AttributeId = (EAttributeType)this.MorphConfig.AttributeId;
			this.MaxAttributeId = (EAttributeType)this.MorphConfig.MaxAttributeId;
		}

		// Token: 0x0603238F RID: 205711 RVA: 0x00E13EC5 File Offset: 0x00E120C5
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagAddOrRemoveChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1ZanniMd10011.技能标识.认真状态"], new BaseTagComponent.TTagSwitchedCallback(this.OnMorphTagChange));
		}

		// Token: 0x06032390 RID: 205712 RVA: 0x00E13EEE File Offset: 0x00E120EE
		private void OnMorphTagChange(int tagId, bool tagExist)
		{
			this.SetState(tagExist ? SpecialEnergyBarZanni.EState.Morph : SpecialEnergyBarZanni.EState.Normal, false);
		}

		// Token: 0x06032391 RID: 205713 RVA: 0x00E13F00 File Offset: 0x00E12100
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarZanni.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarZanni.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032392 RID: 205714 RVA: 0x00E13F44 File Offset: 0x00E12144
		protected UniTask InitBarItem()
		{
			SpecialEnergyBarZanni.<InitBarItem>d__16 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarZanni.<InitBarItem>d__16>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x06032393 RID: 205715 RVA: 0x00E13F88 File Offset: 0x00E12188
		protected override void OnStart()
		{
			base.InitTweenAnim(7);
			base.InitTweenAnim(8);
			base.InitTweenAnim(9);
			base.InitTweenAnim(10);
			base.InitTweenAnim(11);
			UUIItem item = base.GetItem(6);
			if (item != null)
			{
				item.SetAlpha(1f);
			}
			this.RefreshState(true);
			this.OnBarPercentChanged();
		}

		// Token: 0x06032394 RID: 205716 RVA: 0x00E13FDF File Offset: 0x00E121DF
		protected override void ClearAllTweenAnim()
		{
			base.StopTweenAnim(11);
			base.ClearAllTweenAnim();
		}

		// Token: 0x06032395 RID: 205717 RVA: 0x00E13FF0 File Offset: 0x00E121F0
		protected override void OnBarPercentChanged()
		{
			float curPercent = this.PercentMachine.GetCurPercent();
			UUISprite sprite = base.GetSprite(1);
			if (sprite != null)
			{
				sprite.SetFillAmount(curPercent);
			}
			bool flag = curPercent >= this.MorphConfig.ExtraFloatParams[1];
			if (this.InDrive == flag)
			{
				return;
			}
			this.InDrive = flag;
			base.PlayTweenAnim(flag ? 9 : 10);
		}

		// Token: 0x06032396 RID: 205718 RVA: 0x00E14054 File Offset: 0x00E12254
		private void RefreshState(bool isStart = false)
		{
			BaseTagComponent tagComponent = this.TagComponent;
			if (tagComponent != null && tagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.R2T1ZanniMd10011.技能标识.认真状态"]))
			{
				this.SetState(SpecialEnergyBarZanni.EState.Morph, isStart);
				return;
			}
			this.SetState(SpecialEnergyBarZanni.EState.Normal, isStart);
		}

		// Token: 0x06032397 RID: 205719 RVA: 0x00E1408C File Offset: 0x00E1228C
		private void SetState(SpecialEnergyBarZanni.EState state, bool isStart = false)
		{
			if (state == this.CurState && !isStart)
			{
				return;
			}
			this.CurState = state;
			SpecialEnergyBarZanni.EState curState = this.CurState;
			if (curState != SpecialEnergyBarZanni.EState.Normal)
			{
				if (curState != SpecialEnergyBarZanni.EState.Morph)
				{
					return;
				}
				if (!isStart)
				{
					base.PlayTweenAnim(7);
					return;
				}
				UUIItem item = base.GetItem(5);
				if (item != null)
				{
					item.SetUIActive(false);
				}
				UUIItem item2 = base.GetItem(6);
				if (item2 == null)
				{
					return;
				}
				item2.SetUIActive(true);
				return;
			}
			else
			{
				if (!isStart)
				{
					base.PlayTweenAnim(8);
					return;
				}
				UUIItem item3 = base.GetItem(5);
				if (item3 != null)
				{
					item3.SetUIActive(true);
				}
				UUIItem item4 = base.GetItem(6);
				if (item4 == null)
				{
					return;
				}
				item4.SetUIActive(false);
				return;
			}
		}

		// Token: 0x06032398 RID: 205720 RVA: 0x00E14120 File Offset: 0x00E12320
		public override void Tick(float delta)
		{
			base.Tick(delta);
			SpecialEnergyBarZanniSlot barItemNormal = this.BarItemNormal;
			if (barItemNormal != null)
			{
				barItemNormal.Tick(delta);
			}
			SpecialEnergyBarZanniSlot barItemMorph = this.BarItemMorph;
			if (barItemMorph != null)
			{
				barItemMorph.Tick(delta);
			}
			if (this.CurState == SpecialEnergyBarZanni.EState.Normal)
			{
				this.PlayWarnAnim(false);
				return;
			}
			if (this.Buff != null)
			{
				CharacterBuffComponent buffComponent = this.BuffComponent;
				if (((buffComponent != null) ? buffComponent.GetBuffByHandle(this.BuffHandle) : null) != null)
				{
					goto IL_63;
				}
			}
			this.RefreshBuff();
			IL_63:
			if (this.Buff != null)
			{
				this.PlayWarnAnim(this.Buff.GetRemainDuration() < this.MorphConfig.ExtraFloatParams[0]);
			}
		}

		// Token: 0x06032399 RID: 205721 RVA: 0x00E141BC File Offset: 0x00E123BC
		private void RefreshBuff()
		{
			SpecialEnergyBarInfo morphConfig = this.MorphConfig;
			bool flag;
			if (morphConfig == null)
			{
				flag = false;
			}
			else
			{
				long buffId = morphConfig.BuffId;
				flag = true;
			}
			if (flag)
			{
				CharacterBuffComponent buffComponent = this.BuffComponent;
				this.Buff = ((buffComponent != null) ? buffComponent.GetBuffById(this.MorphConfig.BuffId) : null);
				IActiveBuff buff = this.Buff;
				this.BuffHandle = ((buff != null) ? buff.Handle : 0);
				return;
			}
			this.Buff = null;
			this.BuffHandle = 0;
		}

		// Token: 0x0603239A RID: 205722 RVA: 0x00E14229 File Offset: 0x00E12429
		private void PlayWarnAnim(bool bPlay)
		{
			if (this.IsPlayWarnAnim == bPlay)
			{
				return;
			}
			this.IsPlayWarnAnim = bPlay;
			if (bPlay)
			{
				base.PlayTweenAnim(11);
				return;
			}
			base.StopTweenAnim(11);
			UUIItem item = base.GetItem(6);
			if (item == null)
			{
				return;
			}
			item.SetAlpha(1f);
		}

		// Token: 0x0401A9D2 RID: 109010
		private const int MORPH_CONFIG_ID = 150701;

		// Token: 0x0401A9D3 RID: 109011
		private SpecialEnergyBarInfo MorphConfig;

		// Token: 0x0401A9D4 RID: 109012
		private SpecialEnergyBarZanniSlot BarItemNormal;

		// Token: 0x0401A9D5 RID: 109013
		private SpecialEnergyBarZanniSlot BarItemMorph;

		// Token: 0x0401A9D6 RID: 109014
		private SpecialEnergyBarZanni.EState CurState;

		// Token: 0x0401A9D7 RID: 109015
		private IActiveBuff Buff;

		// Token: 0x0401A9D8 RID: 109016
		private int BuffHandle;

		// Token: 0x0401A9D9 RID: 109017
		private bool IsPlayWarnAnim;

		// Token: 0x0401A9DA RID: 109018
		private bool InDrive;

		// Token: 0x0200AB94 RID: 43924
		[NullableContext(0)]
		private enum EState
		{
			// Token: 0x0403518E RID: 217486
			Normal,
			// Token: 0x0403518F RID: 217487
			Morph
		}

		// Token: 0x0200AB95 RID: 43925
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04035191 RID: 217489
			SlotBarItemNormal,
			// Token: 0x04035192 RID: 217490
			BarSprite,
			// Token: 0x04035193 RID: 217491
			ActivateItem,
			// Token: 0x04035194 RID: 217492
			SlotBarItemMorph,
			// Token: 0x04035195 RID: 217493
			ArrowItem,
			// Token: 0x04035196 RID: 217494
			NormalItem,
			// Token: 0x04035197 RID: 217495
			MorphItem,
			// Token: 0x04035198 RID: 217496
			AniMorphIn,
			// Token: 0x04035199 RID: 217497
			AniMorphOut,
			// Token: 0x0403519A RID: 217498
			AnimDriveIn,
			// Token: 0x0403519B RID: 217499
			AnimDriveOut,
			// Token: 0x0403519C RID: 217500
			AnimWarning,
			// Token: 0x0403519D RID: 217501
			DarkLeftItem,
			// Token: 0x0403519E RID: 217502
			DarkRightItem
		}
	}
}
