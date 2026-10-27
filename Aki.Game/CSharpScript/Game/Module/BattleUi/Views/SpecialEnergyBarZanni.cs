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
	// Token: 0x02005E15 RID: 24085
	[NullableContext(2)]
	[Nullable(0)]
	public class SpecialEnergyBarZanni : SpecialEnergyBarBase
	{
		// Token: 0x0603D3FE RID: 250878 RVA: 0x00EC272C File Offset: 0x00EC092C
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

		// Token: 0x0603D3FF RID: 250879 RVA: 0x00EC2927 File Offset: 0x00EC0B27
		protected override void OnInitData()
		{
			this.MorphConfig = BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(150701);
			this.AttributeId = (EAttributeType)this.MorphConfig.AttributeId;
			this.MaxAttributeId = (EAttributeType)this.MorphConfig.MaxAttributeId;
		}

		// Token: 0x0603D400 RID: 250880 RVA: 0x00EC2965 File Offset: 0x00EC0B65
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagAddOrRemoveChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1ZanniMd10011.技能标识.认真状态"], new BaseTagComponent.TTagSwitchedCallback(this.OnMorphTagChange));
		}

		// Token: 0x0603D401 RID: 250881 RVA: 0x00EC298E File Offset: 0x00EC0B8E
		private void OnMorphTagChange(int tagId, bool tagExist)
		{
			this.SetState(tagExist ? SpecialEnergyBarZanni.EState.Morph : SpecialEnergyBarZanni.EState.Normal, false);
		}

		// Token: 0x0603D402 RID: 250882 RVA: 0x00EC29A0 File Offset: 0x00EC0BA0
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarZanni.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarZanni.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D403 RID: 250883 RVA: 0x00EC29E4 File Offset: 0x00EC0BE4
		protected UniTask InitBarItem()
		{
			SpecialEnergyBarZanni.<InitBarItem>d__16 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarZanni.<InitBarItem>d__16>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603D404 RID: 250884 RVA: 0x00EC2A28 File Offset: 0x00EC0C28
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

		// Token: 0x0603D405 RID: 250885 RVA: 0x00EC2A7F File Offset: 0x00EC0C7F
		protected override void ClearAllTweenAnim()
		{
			base.StopTweenAnim(11);
			base.ClearAllTweenAnim();
		}

		// Token: 0x0603D406 RID: 250886 RVA: 0x00EC2A90 File Offset: 0x00EC0C90
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

		// Token: 0x0603D407 RID: 250887 RVA: 0x00EC2AF4 File Offset: 0x00EC0CF4
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

		// Token: 0x0603D408 RID: 250888 RVA: 0x00EC2B2C File Offset: 0x00EC0D2C
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

		// Token: 0x0603D409 RID: 250889 RVA: 0x00EC2BC0 File Offset: 0x00EC0DC0
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

		// Token: 0x0603D40A RID: 250890 RVA: 0x00EC2C5C File Offset: 0x00EC0E5C
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

		// Token: 0x0603D40B RID: 250891 RVA: 0x00EC2CC9 File Offset: 0x00EC0EC9
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

		// Token: 0x0401FF0B RID: 130827
		private const int MORPH_CONFIG_ID = 150701;

		// Token: 0x0401FF0C RID: 130828
		private SpecialEnergyBarInfo MorphConfig;

		// Token: 0x0401FF0D RID: 130829
		private SpecialEnergyBarZanniSlot BarItemNormal;

		// Token: 0x0401FF0E RID: 130830
		private SpecialEnergyBarZanniSlot BarItemMorph;

		// Token: 0x0401FF0F RID: 130831
		private SpecialEnergyBarZanni.EState CurState;

		// Token: 0x0401FF10 RID: 130832
		private IActiveBuff Buff;

		// Token: 0x0401FF11 RID: 130833
		private int BuffHandle;

		// Token: 0x0401FF12 RID: 130834
		private bool IsPlayWarnAnim;

		// Token: 0x0401FF13 RID: 130835
		private bool InDrive;

		// Token: 0x0200C185 RID: 49541
		[NullableContext(0)]
		private enum EState
		{
			// Token: 0x0403A79C RID: 239516
			Normal,
			// Token: 0x0403A79D RID: 239517
			Morph
		}

		// Token: 0x0200C186 RID: 49542
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403A79F RID: 239519
			SlotBarItemNormal,
			// Token: 0x0403A7A0 RID: 239520
			BarSprite,
			// Token: 0x0403A7A1 RID: 239521
			ActivateItem,
			// Token: 0x0403A7A2 RID: 239522
			SlotBarItemMorph,
			// Token: 0x0403A7A3 RID: 239523
			ArrowItem,
			// Token: 0x0403A7A4 RID: 239524
			NormalItem,
			// Token: 0x0403A7A5 RID: 239525
			MorphItem,
			// Token: 0x0403A7A6 RID: 239526
			AniMorphIn,
			// Token: 0x0403A7A7 RID: 239527
			AniMorphOut,
			// Token: 0x0403A7A8 RID: 239528
			AnimDriveIn,
			// Token: 0x0403A7A9 RID: 239529
			AnimDriveOut,
			// Token: 0x0403A7AA RID: 239530
			AnimWarning,
			// Token: 0x0403A7AB RID: 239531
			DarkLeftItem,
			// Token: 0x0403A7AC RID: 239532
			DarkRightItem
		}
	}
}
