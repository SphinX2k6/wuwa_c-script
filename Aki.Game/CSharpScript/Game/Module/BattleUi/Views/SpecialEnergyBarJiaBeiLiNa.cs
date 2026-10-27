using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DDA RID: 24026
	[NullableContext(2)]
	[Nullable(0)]
	public class SpecialEnergyBarJiaBeiLiNa : SpecialEnergyBarBase
	{
		// Token: 0x0603D123 RID: 250147 RVA: 0x00EB1724 File Offset: 0x00EAF924
		protected unsafe override void OnRegisterComponent()
		{
			int num = 14;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
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
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUINiagara));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603D124 RID: 250148 RVA: 0x00EB191F File Offset: 0x00EAFB1F
		protected override void OnInitData()
		{
			this.MorphConfig = BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(120801);
			this.SubConfig = BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(120802);
		}

		// Token: 0x0603D125 RID: 250149 RVA: 0x00EB1955 File Offset: 0x00EAFB55
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarJiaBeiLiNa.MorphTagId, new BaseTagComponent.TTagSwitchedCallback(this.OnMorphTagChange));
			base.ListenForTagAddOrRemoveChanged(this.SubConfig.KeyEnableTagId, new BaseTagComponent.TTagSwitchedCallback(this.OnSubTagChange));
		}

		// Token: 0x0603D126 RID: 250150 RVA: 0x00EB1991 File Offset: 0x00EAFB91
		private void OnMorphTagChange(int tagId, bool tagExist)
		{
			this.SetState(tagExist ? SpecialEnergyBarJiaBeiLiNa.EState.Morph : SpecialEnergyBarJiaBeiLiNa.EState.Normal, false);
		}

		// Token: 0x0603D127 RID: 250151 RVA: 0x00EB19A1 File Offset: 0x00EAFBA1
		private void OnSubTagChange(int tagId, bool tagExist)
		{
			this.ShowSubBar = tagExist;
		}

		// Token: 0x0603D128 RID: 250152 RVA: 0x00EB19AC File Offset: 0x00EAFBAC
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarJiaBeiLiNa.<OnBeforeStartAsync>d__21 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarJiaBeiLiNa.<OnBeforeStartAsync>d__21>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D129 RID: 250153 RVA: 0x00EB19F0 File Offset: 0x00EAFBF0
		protected UniTask InitBarItem()
		{
			SpecialEnergyBarJiaBeiLiNa.<InitBarItem>d__22 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarJiaBeiLiNa.<InitBarItem>d__22>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603D12A RID: 250154 RVA: 0x00EB1A34 File Offset: 0x00EAFC34
		protected override void OnStart()
		{
			base.InitTweenAnim(11);
			base.InitTweenAnim(12);
			base.InitTweenAnim(8);
			base.InitTweenAnim(9);
			base.InitTweenAnim(10);
			base.PlayTweenAnim(8);
			for (int i = 0; i < this.FullStateList.Length; i++)
			{
				if (this.FullStateList[i])
				{
					base.PlayTweenAnim((i == 0) ? 9 : 10);
				}
			}
			this.RefreshState(true);
			this.OnBarPercentChanged();
			this.RefreshSubBarPercent(true);
		}

		// Token: 0x0603D12B RID: 250155 RVA: 0x00EB1AAF File Offset: 0x00EAFCAF
		protected override void OnBeforeShow()
		{
			base.OnBeforeShow();
			UUINiagara uiNiagara = base.GetUiNiagara(13);
			if (uiNiagara == null)
			{
				return;
			}
			uiNiagara.SetUIActive(false);
		}

		// Token: 0x0603D12C RID: 250156 RVA: 0x00EB1ACC File Offset: 0x00EAFCCC
		private void RefreshSubBarPercent(bool isStart = false)
		{
			float num = 0f;
			if (this.ShowSubBar)
			{
				if (this.Buff != null)
				{
					CharacterBuffComponent buffComponent = this.BuffComponent;
					if (((buffComponent != null) ? buffComponent.GetBuffByHandle(this.BuffHandle) : null) != null)
					{
						goto IL_36;
					}
				}
				this.RefreshBuff();
				IL_36:
				if (this.Buff != null)
				{
					num = this.Buff.GetRemainDuration() / this.Buff.Duration;
				}
			}
			if (num == this.SubBarPercent && !isStart)
			{
				return;
			}
			this.SubBarPercent = num;
			UUISprite sprite = base.GetSprite(6);
			if (sprite != null)
			{
				sprite.SetFillAmount(num);
			}
			UUISprite sprite2 = base.GetSprite(2);
			if (sprite2 != null)
			{
				sprite2.SetFillAmount(num);
			}
			UUIItem item = base.GetItem(7);
			if (item != null)
			{
				item.SetAnchorOffsetX(320f * (num - 0.5f));
			}
			UUIItem item2 = base.GetItem(3);
			if (item2 == null)
			{
				return;
			}
			item2.SetAnchorOffsetX(289f * (num - 0.5f));
		}

		// Token: 0x0603D12D RID: 250157 RVA: 0x00EB1BA8 File Offset: 0x00EAFDA8
		private void RefreshState(bool isStart = false)
		{
			BaseTagComponent tagComponent = this.TagComponent;
			if (tagComponent != null && tagComponent.HasTag(SpecialEnergyBarJiaBeiLiNa.MorphTagId))
			{
				this.SetState(SpecialEnergyBarJiaBeiLiNa.EState.Morph, isStart);
			}
			else
			{
				this.SetState(SpecialEnergyBarJiaBeiLiNa.EState.Normal, isStart);
			}
			BaseTagComponent tagComponent2 = this.TagComponent;
			this.ShowSubBar = (tagComponent2 != null && tagComponent2.HasTag(this.SubConfig.KeyEnableTagId));
		}

		// Token: 0x0603D12E RID: 250158 RVA: 0x00EB1C04 File Offset: 0x00EAFE04
		private void SetState(SpecialEnergyBarJiaBeiLiNa.EState state, bool isStart = false)
		{
			if (state == this.CurState && !isStart)
			{
				return;
			}
			this.CurState = state;
			SpecialEnergyBarJiaBeiLiNa.EState curState = this.CurState;
			if (curState != SpecialEnergyBarJiaBeiLiNa.EState.Normal)
			{
				if (curState != SpecialEnergyBarJiaBeiLiNa.EState.Morph)
				{
					return;
				}
				if (!isStart)
				{
					base.StopTweenAnim(12);
				}
				base.PlayTweenAnim(11);
			}
			else if (!isStart)
			{
				base.StopTweenAnim(11);
				base.PlayTweenAnim(12);
				return;
			}
		}

		// Token: 0x0603D12F RID: 250159 RVA: 0x00EB1C5C File Offset: 0x00EAFE5C
		private void OnPercentCallback(int index, float percent)
		{
			bool flag = percent >= 1f;
			if (this.FullStateList[index] != flag)
			{
				this.FullStateList[index] = flag;
				if (flag)
				{
					base.PlayTweenAnim((index == 0) ? 9 : 10);
				}
			}
		}

		// Token: 0x0603D130 RID: 250160 RVA: 0x00EB1C9B File Offset: 0x00EAFE9B
		public override void Tick(float delta)
		{
			base.Tick(delta);
			SpecialEnergyBarJiaBeiLiNaSlot barItemNormal = this.BarItemNormal;
			if (barItemNormal != null)
			{
				barItemNormal.Tick(delta);
			}
			SpecialEnergyBarJiaBeiLiNaMorphSlot barItemMorph = this.BarItemMorph;
			if (barItemMorph != null)
			{
				barItemMorph.Tick(delta);
			}
			this.RefreshSubBarPercent(false);
		}

		// Token: 0x0603D131 RID: 250161 RVA: 0x00EB1CD0 File Offset: 0x00EAFED0
		private void RefreshBuff()
		{
			SpecialEnergyBarInfo subConfig = this.SubConfig;
			bool flag;
			if (subConfig == null)
			{
				flag = false;
			}
			else
			{
				long buffId = subConfig.BuffId;
				flag = true;
			}
			if (flag)
			{
				CharacterBuffComponent buffComponent = this.BuffComponent;
				ActiveBuffInternal buff;
				if ((buff = ((buffComponent != null) ? buffComponent.GetBuffById(1208003423L) : null)) == null)
				{
					CharacterBuffComponent buffComponent2 = this.BuffComponent;
					buff = ((buffComponent2 != null) ? buffComponent2.GetBuffById(this.SubConfig.BuffId) : null);
				}
				this.Buff = buff;
				IActiveBuff buff2 = this.Buff;
				this.BuffHandle = ((buff2 != null) ? buff2.Handle : 0);
				return;
			}
			this.Buff = null;
			this.BuffHandle = 0;
		}

		// Token: 0x0401FD23 RID: 130339
		private const int MORPH_CONFIG_ID = 120801;

		// Token: 0x0401FD24 RID: 130340
		private const int SUB_CONFIG_ID = 120802;

		// Token: 0x0401FD25 RID: 130341
		[StaticVariableRuleIgnore]
		private static readonly int MorphTagId = GameplayTagDefine.EGameplayTagId["角色.R2T1CalbrenaMd10011.状态标识.强化状态"];

		// Token: 0x0401FD26 RID: 130342
		private const int EXTRA_SUB_BUFF_ID = 1208003423;

		// Token: 0x0401FD27 RID: 130343
		private SpecialEnergyBarInfo MorphConfig;

		// Token: 0x0401FD28 RID: 130344
		private SpecialEnergyBarInfo SubConfig;

		// Token: 0x0401FD29 RID: 130345
		private SpecialEnergyBarJiaBeiLiNaSlot BarItemNormal;

		// Token: 0x0401FD2A RID: 130346
		private SpecialEnergyBarJiaBeiLiNaMorphSlot BarItemMorph;

		// Token: 0x0401FD2B RID: 130347
		private SpecialEnergyBarJiaBeiLiNa.EState CurState;

		// Token: 0x0401FD2C RID: 130348
		private IActiveBuff Buff;

		// Token: 0x0401FD2D RID: 130349
		private int BuffHandle;

		// Token: 0x0401FD2E RID: 130350
		private bool ShowSubBar;

		// Token: 0x0401FD2F RID: 130351
		private float SubBarPercent = -1f;

		// Token: 0x0401FD30 RID: 130352
		[Nullable(1)]
		private readonly bool[] FullStateList = new bool[2];

		// Token: 0x0200C0FA RID: 49402
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403A3FA RID: 238586
			MorphItem,
			// Token: 0x0403A3FB RID: 238587
			SlotBarItemMorph,
			// Token: 0x0403A3FC RID: 238588
			MorphExtraBarSprite,
			// Token: 0x0403A3FD RID: 238589
			MorphExtraBarLightItem,
			// Token: 0x0403A3FE RID: 238590
			NormalItem,
			// Token: 0x0403A3FF RID: 238591
			SlotBarItemNormal,
			// Token: 0x0403A400 RID: 238592
			ExtraBarSprite,
			// Token: 0x0403A401 RID: 238593
			ExtraBarLightItem,
			// Token: 0x0403A402 RID: 238594
			AniDefault,
			// Token: 0x0403A403 RID: 238595
			AniRed,
			// Token: 0x0403A404 RID: 238596
			AniBlue,
			// Token: 0x0403A405 RID: 238597
			AniMorphIn,
			// Token: 0x0403A406 RID: 238598
			AniMorphOut,
			// Token: 0x0403A407 RID: 238599
			MorphEffect
		}

		// Token: 0x0200C0FB RID: 49403
		[NullableContext(0)]
		private enum EState
		{
			// Token: 0x0403A409 RID: 238601
			Normal,
			// Token: 0x0403A40A RID: 238602
			Morph
		}
	}
}
