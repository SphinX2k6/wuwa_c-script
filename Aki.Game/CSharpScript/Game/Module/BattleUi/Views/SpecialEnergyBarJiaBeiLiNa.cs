using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DBE RID: 19902
	[NullableContext(2)]
	[Nullable(0)]
	public class SpecialEnergyBarJiaBeiLiNa : SpecialEnergyBarBase
	{
		// Token: 0x0603209A RID: 204954 RVA: 0x00E02618 File Offset: 0x00E00818
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

		// Token: 0x0603209B RID: 204955 RVA: 0x00E02813 File Offset: 0x00E00A13
		protected override void OnInitData()
		{
			this.MorphConfig = BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(120801);
			this.SubConfig = BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(120802);
		}

		// Token: 0x0603209C RID: 204956 RVA: 0x00E02849 File Offset: 0x00E00A49
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarJiaBeiLiNa.MorphTagId, new BaseTagComponent.TTagSwitchedCallback(this.OnMorphTagChange));
			base.ListenForTagAddOrRemoveChanged(this.SubConfig.KeyEnableTagId, new BaseTagComponent.TTagSwitchedCallback(this.OnSubTagChange));
		}

		// Token: 0x0603209D RID: 204957 RVA: 0x00E02885 File Offset: 0x00E00A85
		private void OnMorphTagChange(int tagId, bool tagExist)
		{
			this.SetState(tagExist ? SpecialEnergyBarJiaBeiLiNa.EState.Morph : SpecialEnergyBarJiaBeiLiNa.EState.Normal, false);
		}

		// Token: 0x0603209E RID: 204958 RVA: 0x00E02895 File Offset: 0x00E00A95
		private void OnSubTagChange(int tagId, bool tagExist)
		{
			this.ShowSubBar = tagExist;
		}

		// Token: 0x0603209F RID: 204959 RVA: 0x00E028A0 File Offset: 0x00E00AA0
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarJiaBeiLiNa.<OnBeforeStartAsync>d__21 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarJiaBeiLiNa.<OnBeforeStartAsync>d__21>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060320A0 RID: 204960 RVA: 0x00E028E4 File Offset: 0x00E00AE4
		protected UniTask InitBarItem()
		{
			SpecialEnergyBarJiaBeiLiNa.<InitBarItem>d__22 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarJiaBeiLiNa.<InitBarItem>d__22>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x060320A1 RID: 204961 RVA: 0x00E02928 File Offset: 0x00E00B28
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

		// Token: 0x060320A2 RID: 204962 RVA: 0x00E029A3 File Offset: 0x00E00BA3
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

		// Token: 0x060320A3 RID: 204963 RVA: 0x00E029C0 File Offset: 0x00E00BC0
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

		// Token: 0x060320A4 RID: 204964 RVA: 0x00E02A9C File Offset: 0x00E00C9C
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

		// Token: 0x060320A5 RID: 204965 RVA: 0x00E02AF8 File Offset: 0x00E00CF8
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

		// Token: 0x060320A6 RID: 204966 RVA: 0x00E02B50 File Offset: 0x00E00D50
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

		// Token: 0x060320A7 RID: 204967 RVA: 0x00E02B8F File Offset: 0x00E00D8F
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

		// Token: 0x060320A8 RID: 204968 RVA: 0x00E02BC4 File Offset: 0x00E00DC4
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

		// Token: 0x0401A7E0 RID: 108512
		private const int MORPH_CONFIG_ID = 120801;

		// Token: 0x0401A7E1 RID: 108513
		private const int SUB_CONFIG_ID = 120802;

		// Token: 0x0401A7E2 RID: 108514
		[StaticVariableRuleIgnore]
		private static readonly int MorphTagId = GameplayTagDefine.EGameplayTagId["角色.R2T1CalbrenaMd10011.状态标识.强化状态"];

		// Token: 0x0401A7E3 RID: 108515
		private const int EXTRA_SUB_BUFF_ID = 1208003423;

		// Token: 0x0401A7E4 RID: 108516
		private SpecialEnergyBarInfo MorphConfig;

		// Token: 0x0401A7E5 RID: 108517
		private SpecialEnergyBarInfo SubConfig;

		// Token: 0x0401A7E6 RID: 108518
		private SpecialEnergyBarJiaBeiLiNaSlot BarItemNormal;

		// Token: 0x0401A7E7 RID: 108519
		private SpecialEnergyBarJiaBeiLiNaMorphSlot BarItemMorph;

		// Token: 0x0401A7E8 RID: 108520
		private SpecialEnergyBarJiaBeiLiNa.EState CurState;

		// Token: 0x0401A7E9 RID: 108521
		private IActiveBuff Buff;

		// Token: 0x0401A7EA RID: 108522
		private int BuffHandle;

		// Token: 0x0401A7EB RID: 108523
		private bool ShowSubBar;

		// Token: 0x0401A7EC RID: 108524
		private float SubBarPercent = -1f;

		// Token: 0x0401A7ED RID: 108525
		[Nullable(1)]
		private readonly bool[] FullStateList = new bool[2];

		// Token: 0x0200AB03 RID: 43779
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04034DCC RID: 216524
			MorphItem,
			// Token: 0x04034DCD RID: 216525
			SlotBarItemMorph,
			// Token: 0x04034DCE RID: 216526
			MorphExtraBarSprite,
			// Token: 0x04034DCF RID: 216527
			MorphExtraBarLightItem,
			// Token: 0x04034DD0 RID: 216528
			NormalItem,
			// Token: 0x04034DD1 RID: 216529
			SlotBarItemNormal,
			// Token: 0x04034DD2 RID: 216530
			ExtraBarSprite,
			// Token: 0x04034DD3 RID: 216531
			ExtraBarLightItem,
			// Token: 0x04034DD4 RID: 216532
			AniDefault,
			// Token: 0x04034DD5 RID: 216533
			AniRed,
			// Token: 0x04034DD6 RID: 216534
			AniBlue,
			// Token: 0x04034DD7 RID: 216535
			AniMorphIn,
			// Token: 0x04034DD8 RID: 216536
			AniMorphOut,
			// Token: 0x04034DD9 RID: 216537
			MorphEffect
		}

		// Token: 0x0200AB04 RID: 43780
		[NullableContext(0)]
		private enum EState
		{
			// Token: 0x04034DDB RID: 216539
			Normal,
			// Token: 0x04034DDC RID: 216540
			Morph
		}
	}
}
