using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DF1 RID: 19953
	[NullableContext(2)]
	[Nullable(0)]
	public class SpecialEnergyBarXinYueHu : SpecialEnergyBarBase
	{
		// Token: 0x0603231D RID: 205597 RVA: 0x00E1163C File Offset: 0x00E0F83C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 20;
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
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
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
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUINiagara));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603231E RID: 205598 RVA: 0x00E11903 File Offset: 0x00E0FB03
		protected override void OnInitData()
		{
			this.MorphConfig = BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(131102);
			this.NormalConfig = BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(131101);
		}

		// Token: 0x0603231F RID: 205599 RVA: 0x00E1193C File Offset: 0x00E0FB3C
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarXinYueHu.<OnBeforeStartAsync>d__32 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarXinYueHu.<OnBeforeStartAsync>d__32>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032320 RID: 205600 RVA: 0x00E11980 File Offset: 0x00E0FB80
		protected UniTask InitBarItem()
		{
			SpecialEnergyBarXinYueHu.<InitBarItem>d__33 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarXinYueHu.<InitBarItem>d__33>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x06032321 RID: 205601 RVA: 0x00E119C4 File Offset: 0x00E0FBC4
		protected override void OnStart()
		{
			base.InitTweenAnim(11);
			base.InitTweenAnim(12);
			base.InitTweenAnim(18);
			for (int i = 2; i <= 5; i++)
			{
				this.DecorItemList.Add(base.GetItem(i));
			}
			foreach (UUIItem uuiitem in this.DecorItemList)
			{
				uuiitem.SetUIActive(false);
			}
			BaseTagComponent tagComponent = this.TagComponent;
			this.HasMorphUnlockTag = (tagComponent != null && tagComponent.HasTag(SpecialEnergyBarXinYueHu.MorphUnlockId));
			BaseTagComponent tagComponent2 = this.TagComponent;
			this.HasMorphTag = (tagComponent2 != null && tagComponent2.HasTag(SpecialEnergyBarXinYueHu.MorphTagId));
			BaseTagComponent tagComponent3 = this.TagComponent;
			this.HasSecondMorphUnlockTag = (tagComponent3 != null && tagComponent3.HasTag(SpecialEnergyBarXinYueHu.SecondMorphUnlockId));
			BaseTagComponent tagComponent4 = this.TagComponent;
			this.HasSubTag = (tagComponent4 != null && tagComponent4.HasTag(SpecialEnergyBarXinYueHu.SubTagId));
			BaseTagComponent tagComponent5 = this.TagComponent;
			this.HasStarTag = (tagComponent5 != null && tagComponent5.HasTag(SpecialEnergyBarXinYueHu.StarTagId));
			this.RefreshState(true);
			this.OnBarPercentChanged();
			this.RefreshSubBarPercent(true);
			this.InitEffectItem();
			this.RefreshKeyEnable(true);
		}

		// Token: 0x06032322 RID: 205602 RVA: 0x00E11B00 File Offset: 0x00E0FD00
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarXinYueHu.MorphUnlockId, new BaseTagComponent.TTagSwitchedCallback(this.OnMorphUnlockTagChange));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarXinYueHu.MorphTagId, new BaseTagComponent.TTagSwitchedCallback(this.OnMorphTagChange));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarXinYueHu.SecondMorphUnlockId, new BaseTagComponent.TTagSwitchedCallback(this.OnSecondMorphUnlockTagChange));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarXinYueHu.SubTagId, new BaseTagComponent.TTagSwitchedCallback(this.OnSubTagChange));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarXinYueHu.StarTagId, new BaseTagComponent.TTagSwitchedCallback(this.OnStarTagChange));
		}

		// Token: 0x06032323 RID: 205603 RVA: 0x00E11B86 File Offset: 0x00E0FD86
		protected override void ClearAllTweenAnim()
		{
			base.StopTweenAnim(18);
			base.ClearAllTweenAnim();
		}

		// Token: 0x06032324 RID: 205604 RVA: 0x00E11B96 File Offset: 0x00E0FD96
		protected override void OnBeforeDestroy()
		{
			SpecialEnergyBarXinYueHuPillar pillar = this.Pillar;
			if (pillar != null)
			{
				pillar.Destroy();
			}
			this.Pillar = null;
			base.OnBeforeDestroy();
		}

		// Token: 0x06032325 RID: 205605 RVA: 0x00E11BB6 File Offset: 0x00E0FDB6
		private void InitEffectItem()
		{
			UUIItem item = base.GetItem(14);
			if (item != null)
			{
				item.SetUIActive(this.HasMorphUnlockTag);
			}
			UUIItem item2 = base.GetItem(15);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(this.FullStateList[1]);
		}

		// Token: 0x06032326 RID: 205606 RVA: 0x00E11BEB File Offset: 0x00E0FDEB
		protected override void OnKeyEnableChanged()
		{
			this.RefreshKeyEnable(false);
		}

		// Token: 0x06032327 RID: 205607 RVA: 0x00E11BF4 File Offset: 0x00E0FDF4
		private void RefreshKeyEnable(bool isStart = false)
		{
			bool keyEnable = this.GetKeyEnable();
			SpecialEnergyBarKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.RefreshKeyEnable(keyEnable, isStart);
		}

		// Token: 0x06032328 RID: 205608 RVA: 0x00E11C1A File Offset: 0x00E0FE1A
		protected override void OnBarPercentChanged()
		{
			if (this.CurState == SpecialEnergyBarXinYueHu.EState.Sub)
			{
				SpecialEnergyBarXinYueHuPillar pillar = this.Pillar;
				if (pillar == null)
				{
					return;
				}
				pillar.OnBarPercentChanged(this.PercentMachine.GetTargetPercent());
			}
		}

		// Token: 0x06032329 RID: 205609 RVA: 0x00E11C40 File Offset: 0x00E0FE40
		private void OnMorphUnlockTagChange(int tagId, bool tagExist)
		{
			this.HasMorphUnlockTag = tagExist;
			this.RefreshDecorItem(false);
			UUIItem item = base.GetItem(14);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(this.HasMorphUnlockTag);
		}

		// Token: 0x0603232A RID: 205610 RVA: 0x00E11C68 File Offset: 0x00E0FE68
		private void OnMorphTagChange(int tagId, bool tagExist)
		{
			this.HasMorphTag = tagExist;
			this.RefreshState(false);
		}

		// Token: 0x0603232B RID: 205611 RVA: 0x00E11C78 File Offset: 0x00E0FE78
		private void OnSecondMorphUnlockTagChange(int tagId, bool tagExist)
		{
			this.HasSecondMorphUnlockTag = tagExist;
			this.RefreshState(false);
		}

		// Token: 0x0603232C RID: 205612 RVA: 0x00E11C88 File Offset: 0x00E0FE88
		private void OnSubTagChange(int tagId, bool tagExist)
		{
			this.HasSubTag = tagExist;
			this.RefreshState(false);
		}

		// Token: 0x0603232D RID: 205613 RVA: 0x00E11C98 File Offset: 0x00E0FE98
		private void OnStarTagChange(int tagId, bool tagExist)
		{
			this.HasStarTag = tagExist;
		}

		// Token: 0x0603232E RID: 205614 RVA: 0x00E11CA4 File Offset: 0x00E0FEA4
		private void RefreshSubBarPercent(bool isStart = false)
		{
			float num = 0f;
			if (this.CurState == SpecialEnergyBarXinYueHu.EState.Sub)
			{
				if (this.SubBuff != null)
				{
					CharacterBuffComponent buffComponent = this.BuffComponent;
					if (((buffComponent != null) ? buffComponent.GetBuffByHandle(this.SubBuffHandle) : null) != null)
					{
						goto IL_37;
					}
				}
				this.RefreshSubBuff();
				IL_37:
				if (this.SubBuff != null)
				{
					num = this.SubBuff.GetRemainDuration() / this.SubBuff.Duration;
				}
			}
			if (num == this.SubBuffPercent && !isStart)
			{
				return;
			}
			this.SubBuffPercent = num;
			UUISprite sprite = base.GetSprite(8);
			if (sprite == null)
			{
				return;
			}
			sprite.SetFillAmount(num);
		}

		// Token: 0x0603232F RID: 205615 RVA: 0x00E11D30 File Offset: 0x00E0FF30
		private void TickStarBar(float delta)
		{
			if (!this.HasStarTag)
			{
				using (List<SpecialEnergyBarXinYueHuStar>.Enumerator enumerator = this.StarList.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						SpecialEnergyBarXinYueHuStar specialEnergyBarXinYueHuStar = enumerator.Current;
						specialEnergyBarXinYueHuStar.SetStarNum(0);
					}
					goto IL_FB;
				}
			}
			if (this.StarBuff != null)
			{
				CharacterBuffComponent buffComponent = this.BuffComponent;
				if (((buffComponent != null) ? buffComponent.GetBuffByHandle(this.StarBuffHandle) : null) != null)
				{
					goto IL_67;
				}
			}
			this.RefreshStarBuff();
			IL_67:
			if (this.StarBuff != null)
			{
				float num = MathF.Ceiling(this.StarBuff.GetRemainDuration() / this.StarBuff.Duration * 6f);
				using (List<SpecialEnergyBarXinYueHuStar>.Enumerator enumerator = this.StarList.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						SpecialEnergyBarXinYueHuStar specialEnergyBarXinYueHuStar2 = enumerator.Current;
						specialEnergyBarXinYueHuStar2.SetStarNum((int)num);
					}
					goto IL_FB;
				}
			}
			foreach (SpecialEnergyBarXinYueHuStar specialEnergyBarXinYueHuStar3 in this.StarList)
			{
				specialEnergyBarXinYueHuStar3.SetStarNum(0);
			}
			IL_FB:
			foreach (SpecialEnergyBarXinYueHuStar specialEnergyBarXinYueHuStar4 in this.StarList)
			{
				specialEnergyBarXinYueHuStar4.Tick(delta);
			}
		}

		// Token: 0x06032330 RID: 205616 RVA: 0x00E11EA0 File Offset: 0x00E100A0
		private void RefreshDecorItem(bool isStart = false)
		{
			if (this.DecorItemList.Count <= 0)
			{
				return;
			}
			if (this.CurState != SpecialEnergyBarXinYueHu.EState.Normal)
			{
				if (this.CurState == SpecialEnergyBarXinYueHu.EState.Morph)
				{
					if (this.HasSecondMorphUnlockTag)
					{
						this.SetDecorItemType(3, isStart);
						return;
					}
					this.SetDecorItemType(2, isStart);
				}
				return;
			}
			if (this.HasMorphUnlockTag || this.FullStateList[0])
			{
				this.SetDecorItemType(1, isStart);
				return;
			}
			this.SetDecorItemType(0, isStart);
		}

		// Token: 0x06032331 RID: 205617 RVA: 0x00E11F0C File Offset: 0x00E1010C
		private void SetDecorItemType(int index, bool isStart = false)
		{
			if (this.CurDecorIndex == index && !isStart)
			{
				return;
			}
			if (this.CurDecorIndex >= 0)
			{
				this.DecorItemList[this.CurDecorIndex].SetUIActive(false);
			}
			this.CurDecorIndex = index;
			this.DecorItemList[this.CurDecorIndex].SetUIActive(true);
		}

		// Token: 0x06032332 RID: 205618 RVA: 0x00E11F64 File Offset: 0x00E10164
		private void RefreshState(bool isStart = false)
		{
			if (this.HasSubTag)
			{
				this.SetState(SpecialEnergyBarXinYueHu.EState.Sub, isStart);
				return;
			}
			if (this.HasMorphTag)
			{
				this.SetState(SpecialEnergyBarXinYueHu.EState.Morph, isStart);
				return;
			}
			this.SetState(SpecialEnergyBarXinYueHu.EState.Normal, isStart);
		}

		// Token: 0x06032333 RID: 205619 RVA: 0x00E11F90 File Offset: 0x00E10190
		private void SetState(SpecialEnergyBarXinYueHu.EState state, bool isStart = false)
		{
			if (state == this.CurState && !isStart)
			{
				return;
			}
			SpecialEnergyBarXinYueHu.EState curState = this.CurState;
			this.CurState = state;
			base.GetItem(0).SetUIActive(this.CurState == SpecialEnergyBarXinYueHu.EState.Normal || this.CurState == SpecialEnergyBarXinYueHu.EState.Morph);
			base.GetItem(6).SetUIActive(this.CurState == SpecialEnergyBarXinYueHu.EState.Sub);
			this.BarItemNormal.SetVisible(this.CurState == SpecialEnergyBarXinYueHu.EState.Normal, 2);
			this.BarItemMorph.SetVisible(this.CurState == SpecialEnergyBarXinYueHu.EState.Morph, 2);
			if (!isStart)
			{
				if (this.CurState == SpecialEnergyBarXinYueHu.EState.Sub && curState != SpecialEnergyBarXinYueHu.EState.Sub)
				{
					base.StopTweenAnim(12);
					base.PlayTweenAnim(11);
				}
				else if (this.CurState != SpecialEnergyBarXinYueHu.EState.Sub && curState == SpecialEnergyBarXinYueHu.EState.Sub)
				{
					base.StopTweenAnim(11);
					base.PlayTweenAnim(12);
				}
			}
			if (this.CurState == SpecialEnergyBarXinYueHu.EState.Sub)
			{
				SpecialEnergyBarXinYueHuPillar pillar = this.Pillar;
				if (pillar != null)
				{
					pillar.InitByBarPercent(this.PercentMachine.GetTargetPercent());
				}
			}
			this.RefreshDecorItem(isStart);
		}

		// Token: 0x06032334 RID: 205620 RVA: 0x00E12082 File Offset: 0x00E10282
		private void OnPercentCallback(int index, float percent)
		{
			this.FullStateList[index] = (percent >= 1f);
			this.RefreshDecorItem(false);
			if (index == 1)
			{
				UUIItem item = base.GetItem(15);
				if (item == null)
				{
					return;
				}
				item.SetUIActive(this.FullStateList[1]);
			}
		}

		// Token: 0x06032335 RID: 205621 RVA: 0x00E120BC File Offset: 0x00E102BC
		public override void Tick(float delta)
		{
			base.Tick(delta);
			SpecialEnergyBarXinYueHuSlot barItemNormal = this.BarItemNormal;
			if (barItemNormal != null)
			{
				barItemNormal.Tick(delta);
			}
			SpecialEnergyBarXinYueHuSlot barItemMorph = this.BarItemMorph;
			if (barItemMorph != null)
			{
				barItemMorph.Tick(delta);
			}
			this.RefreshSubBarPercent(false);
			this.TickStarBar(delta);
			this.RefreshWarnAnim();
		}

		// Token: 0x06032336 RID: 205622 RVA: 0x00E12108 File Offset: 0x00E10308
		private void RefreshSubBuff()
		{
			if (this.Config.BuffId != 0L)
			{
				CharacterBuffComponent buffComponent = this.BuffComponent;
				this.SubBuff = ((buffComponent != null) ? buffComponent.GetBuffById(this.Config.BuffId) : null);
				IActiveBuff subBuff = this.SubBuff;
				this.SubBuffHandle = ((subBuff != null) ? subBuff.Handle : 0);
				return;
			}
			this.SubBuff = null;
			this.SubBuffHandle = 0;
		}

		// Token: 0x06032337 RID: 205623 RVA: 0x00E1216C File Offset: 0x00E1036C
		private void RefreshStarBuff()
		{
			if (this.MorphConfig.BuffId != 0L)
			{
				CharacterBuffComponent buffComponent = this.BuffComponent;
				this.StarBuff = ((buffComponent != null) ? buffComponent.GetBuffById(this.MorphConfig.BuffId) : null);
				IActiveBuff starBuff = this.StarBuff;
				this.StarBuffHandle = ((starBuff != null) ? starBuff.Handle : 0);
				return;
			}
			this.StarBuff = null;
			this.StarBuffHandle = 0;
		}

		// Token: 0x06032338 RID: 205624 RVA: 0x00E121D0 File Offset: 0x00E103D0
		private void RefreshWarnAnim()
		{
			if (this.CurState == SpecialEnergyBarXinYueHu.EState.Normal)
			{
				this.PlayWarnAnim(false);
				return;
			}
			if (this.CurState == SpecialEnergyBarXinYueHu.EState.Morph)
			{
				IActiveBuff starBuff = this.StarBuff;
				float num = (starBuff != null) ? starBuff.GetRemainDuration() : 0f;
				float num2 = 0f;
				if (num > 0f)
				{
					num2 = MathF.Ceiling(num / this.StarBuff.Duration * 6f);
				}
				this.PlayWarnAnim(num > 0f && num < this.MorphConfig.ExtraFloatParams[0] && num2 <= 1f);
				return;
			}
			if (this.CurState == SpecialEnergyBarXinYueHu.EState.Sub)
			{
				IActiveBuff subBuff = this.SubBuff;
				float num3 = (subBuff != null) ? subBuff.GetRemainDuration() : 0f;
				this.PlayWarnAnim(num3 > 0f && num3 < this.Config.ExtraFloatParams[0]);
			}
		}

		// Token: 0x06032339 RID: 205625 RVA: 0x00E122AC File Offset: 0x00E104AC
		private void PlayWarnAnim(bool bPlay)
		{
			if (this.IsPlayWarnAnim == bPlay)
			{
				return;
			}
			this.IsPlayWarnAnim = bPlay;
			if (bPlay)
			{
				base.PlayTweenAnim(18);
				return;
			}
			base.StopTweenAnim(18);
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				item.SetAlpha(1f);
			}
			UUIItem item2 = base.GetItem(6);
			if (item2 == null)
			{
				return;
			}
			item2.SetAlpha(1f);
		}

		// Token: 0x0401A989 RID: 108937
		private const int NORMAL_CONFIG_ID = 131101;

		// Token: 0x0401A98A RID: 108938
		private const int MORPH_CONFIG_ID = 131102;

		// Token: 0x0401A98B RID: 108939
		private static readonly int MorphUnlockId = GameplayTagDefine.EGameplayTagId["角色.R2T1XinMd10011.状态标记.一阶段大招可用"];

		// Token: 0x0401A98C RID: 108940
		private static readonly int MorphTagId = GameplayTagDefine.EGameplayTagId["角色.R2T1XinMd10011.状态标记.岁主形态"];

		// Token: 0x0401A98D RID: 108941
		private static readonly int SecondMorphUnlockId = GameplayTagDefine.EGameplayTagId["角色.R2T1XinMd10011.状态标记.二阶段大招可用"];

		// Token: 0x0401A98E RID: 108942
		private static readonly int SubTagId = GameplayTagDefine.EGameplayTagId["角色.R2T1XinMd10011.状态标记.岁主强化状态"];

		// Token: 0x0401A98F RID: 108943
		private static readonly int StarTagId = GameplayTagDefine.EGameplayTagId["角色.R2T1XinMd10011.状态标记.大招期间"];

		// Token: 0x0401A990 RID: 108944
		private SpecialEnergyBarInfo MorphConfig;

		// Token: 0x0401A991 RID: 108945
		private SpecialEnergyBarInfo NormalConfig;

		// Token: 0x0401A992 RID: 108946
		private SpecialEnergyBarXinYueHuSlot BarItemNormal;

		// Token: 0x0401A993 RID: 108947
		private SpecialEnergyBarXinYueHuSlot BarItemMorph;

		// Token: 0x0401A994 RID: 108948
		private SpecialEnergyBarXinYueHu.EState CurState;

		// Token: 0x0401A995 RID: 108949
		private IActiveBuff SubBuff;

		// Token: 0x0401A996 RID: 108950
		private int SubBuffHandle;

		// Token: 0x0401A997 RID: 108951
		private IActiveBuff StarBuff;

		// Token: 0x0401A998 RID: 108952
		private int StarBuffHandle;

		// Token: 0x0401A999 RID: 108953
		private bool HasMorphUnlockTag;

		// Token: 0x0401A99A RID: 108954
		private bool HasMorphTag;

		// Token: 0x0401A99B RID: 108955
		private bool HasSecondMorphUnlockTag;

		// Token: 0x0401A99C RID: 108956
		private bool HasSubTag;

		// Token: 0x0401A99D RID: 108957
		private bool HasStarTag;

		// Token: 0x0401A99E RID: 108958
		private float SubBuffPercent = -1f;

		// Token: 0x0401A99F RID: 108959
		[Nullable(1)]
		private readonly bool[] FullStateList = new bool[2];

		// Token: 0x0401A9A0 RID: 108960
		[Nullable(1)]
		private List<UUIItem> DecorItemList = new List<UUIItem>();

		// Token: 0x0401A9A1 RID: 108961
		private bool IsPlayWarnAnim;

		// Token: 0x0401A9A2 RID: 108962
		private int CurDecorIndex = -1;

		// Token: 0x0401A9A3 RID: 108963
		[Nullable(1)]
		private readonly List<SpecialEnergyBarXinYueHuStar> StarList = new List<SpecialEnergyBarXinYueHuStar>();

		// Token: 0x0401A9A4 RID: 108964
		private SpecialEnergyBarXinYueHuPillar Pillar;

		// Token: 0x0200AB84 RID: 43908
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04035125 RID: 217381
			SlotNodeItem,
			// Token: 0x04035126 RID: 217382
			SlotBarItemNormal,
			// Token: 0x04035127 RID: 217383
			DecorItem1,
			// Token: 0x04035128 RID: 217384
			DecorItem2,
			// Token: 0x04035129 RID: 217385
			DecorItem3,
			// Token: 0x0403512A RID: 217386
			DecorItem4,
			// Token: 0x0403512B RID: 217387
			SubNodeItem,
			// Token: 0x0403512C RID: 217388
			PillarItem,
			// Token: 0x0403512D RID: 217389
			SubBarSprite,
			// Token: 0x0403512E RID: 217390
			KeyContainerItem,
			// Token: 0x0403512F RID: 217391
			SlotBarItemMorph,
			// Token: 0x04035130 RID: 217392
			AniStateAToB,
			// Token: 0x04035131 RID: 217393
			AniStateBToA,
			// Token: 0x04035132 RID: 217394
			FireItem,
			// Token: 0x04035133 RID: 217395
			FullEffectItem1,
			// Token: 0x04035134 RID: 217396
			FullEffectItem2,
			// Token: 0x04035135 RID: 217397
			StarLeftItem,
			// Token: 0x04035136 RID: 217398
			StarRightItem,
			// Token: 0x04035137 RID: 217399
			AniWarning,
			// Token: 0x04035138 RID: 217400
			NiaFullEffect
		}

		// Token: 0x0200AB85 RID: 43909
		[NullableContext(0)]
		private enum EState
		{
			// Token: 0x0403513A RID: 217402
			Normal,
			// Token: 0x0403513B RID: 217403
			Morph,
			// Token: 0x0403513C RID: 217404
			Sub
		}
	}
}
