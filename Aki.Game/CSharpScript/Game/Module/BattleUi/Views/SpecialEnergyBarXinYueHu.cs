using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E0C RID: 24076
	[NullableContext(2)]
	[Nullable(0)]
	public class SpecialEnergyBarXinYueHu : SpecialEnergyBarBase
	{
		// Token: 0x0603D38E RID: 250766 RVA: 0x00EC00DC File Offset: 0x00EBE2DC
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

		// Token: 0x0603D38F RID: 250767 RVA: 0x00EC03A3 File Offset: 0x00EBE5A3
		protected override void OnInitData()
		{
			this.MorphConfig = BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(131102);
			this.NormalConfig = BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(131101);
		}

		// Token: 0x0603D390 RID: 250768 RVA: 0x00EC03DC File Offset: 0x00EBE5DC
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarXinYueHu.<OnBeforeStartAsync>d__32 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarXinYueHu.<OnBeforeStartAsync>d__32>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D391 RID: 250769 RVA: 0x00EC0420 File Offset: 0x00EBE620
		protected UniTask InitBarItem()
		{
			SpecialEnergyBarXinYueHu.<InitBarItem>d__33 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarXinYueHu.<InitBarItem>d__33>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603D392 RID: 250770 RVA: 0x00EC0464 File Offset: 0x00EBE664
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

		// Token: 0x0603D393 RID: 250771 RVA: 0x00EC05A0 File Offset: 0x00EBE7A0
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarXinYueHu.MorphUnlockId, new BaseTagComponent.TTagSwitchedCallback(this.OnMorphUnlockTagChange));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarXinYueHu.MorphTagId, new BaseTagComponent.TTagSwitchedCallback(this.OnMorphTagChange));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarXinYueHu.SecondMorphUnlockId, new BaseTagComponent.TTagSwitchedCallback(this.OnSecondMorphUnlockTagChange));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarXinYueHu.SubTagId, new BaseTagComponent.TTagSwitchedCallback(this.OnSubTagChange));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarXinYueHu.StarTagId, new BaseTagComponent.TTagSwitchedCallback(this.OnStarTagChange));
		}

		// Token: 0x0603D394 RID: 250772 RVA: 0x00EC0626 File Offset: 0x00EBE826
		protected override void ClearAllTweenAnim()
		{
			base.StopTweenAnim(18);
			base.ClearAllTweenAnim();
		}

		// Token: 0x0603D395 RID: 250773 RVA: 0x00EC0636 File Offset: 0x00EBE836
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

		// Token: 0x0603D396 RID: 250774 RVA: 0x00EC0656 File Offset: 0x00EBE856
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

		// Token: 0x0603D397 RID: 250775 RVA: 0x00EC068B File Offset: 0x00EBE88B
		protected override void OnKeyEnableChanged()
		{
			this.RefreshKeyEnable(false);
		}

		// Token: 0x0603D398 RID: 250776 RVA: 0x00EC0694 File Offset: 0x00EBE894
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

		// Token: 0x0603D399 RID: 250777 RVA: 0x00EC06BA File Offset: 0x00EBE8BA
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

		// Token: 0x0603D39A RID: 250778 RVA: 0x00EC06E0 File Offset: 0x00EBE8E0
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

		// Token: 0x0603D39B RID: 250779 RVA: 0x00EC0708 File Offset: 0x00EBE908
		private void OnMorphTagChange(int tagId, bool tagExist)
		{
			this.HasMorphTag = tagExist;
			this.RefreshState(false);
		}

		// Token: 0x0603D39C RID: 250780 RVA: 0x00EC0718 File Offset: 0x00EBE918
		private void OnSecondMorphUnlockTagChange(int tagId, bool tagExist)
		{
			this.HasSecondMorphUnlockTag = tagExist;
			this.RefreshState(false);
		}

		// Token: 0x0603D39D RID: 250781 RVA: 0x00EC0728 File Offset: 0x00EBE928
		private void OnSubTagChange(int tagId, bool tagExist)
		{
			this.HasSubTag = tagExist;
			this.RefreshState(false);
		}

		// Token: 0x0603D39E RID: 250782 RVA: 0x00EC0738 File Offset: 0x00EBE938
		private void OnStarTagChange(int tagId, bool tagExist)
		{
			this.HasStarTag = tagExist;
		}

		// Token: 0x0603D39F RID: 250783 RVA: 0x00EC0744 File Offset: 0x00EBE944
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

		// Token: 0x0603D3A0 RID: 250784 RVA: 0x00EC07D0 File Offset: 0x00EBE9D0
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

		// Token: 0x0603D3A1 RID: 250785 RVA: 0x00EC0940 File Offset: 0x00EBEB40
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

		// Token: 0x0603D3A2 RID: 250786 RVA: 0x00EC09AC File Offset: 0x00EBEBAC
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

		// Token: 0x0603D3A3 RID: 250787 RVA: 0x00EC0A04 File Offset: 0x00EBEC04
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

		// Token: 0x0603D3A4 RID: 250788 RVA: 0x00EC0A30 File Offset: 0x00EBEC30
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

		// Token: 0x0603D3A5 RID: 250789 RVA: 0x00EC0B22 File Offset: 0x00EBED22
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

		// Token: 0x0603D3A6 RID: 250790 RVA: 0x00EC0B5C File Offset: 0x00EBED5C
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

		// Token: 0x0603D3A7 RID: 250791 RVA: 0x00EC0BA8 File Offset: 0x00EBEDA8
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

		// Token: 0x0603D3A8 RID: 250792 RVA: 0x00EC0C0C File Offset: 0x00EBEE0C
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

		// Token: 0x0603D3A9 RID: 250793 RVA: 0x00EC0C70 File Offset: 0x00EBEE70
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

		// Token: 0x0603D3AA RID: 250794 RVA: 0x00EC0D4C File Offset: 0x00EBEF4C
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

		// Token: 0x0401FEC2 RID: 130754
		private const int NORMAL_CONFIG_ID = 131101;

		// Token: 0x0401FEC3 RID: 130755
		private const int MORPH_CONFIG_ID = 131102;

		// Token: 0x0401FEC4 RID: 130756
		private static readonly int MorphUnlockId = GameplayTagDefine.EGameplayTagId["角色.R2T1XinMd10011.状态标记.一阶段大招可用"];

		// Token: 0x0401FEC5 RID: 130757
		private static readonly int MorphTagId = GameplayTagDefine.EGameplayTagId["角色.R2T1XinMd10011.状态标记.岁主形态"];

		// Token: 0x0401FEC6 RID: 130758
		private static readonly int SecondMorphUnlockId = GameplayTagDefine.EGameplayTagId["角色.R2T1XinMd10011.状态标记.二阶段大招可用"];

		// Token: 0x0401FEC7 RID: 130759
		private static readonly int SubTagId = GameplayTagDefine.EGameplayTagId["角色.R2T1XinMd10011.状态标记.岁主强化状态"];

		// Token: 0x0401FEC8 RID: 130760
		private static readonly int StarTagId = GameplayTagDefine.EGameplayTagId["角色.R2T1XinMd10011.状态标记.大招期间"];

		// Token: 0x0401FEC9 RID: 130761
		private SpecialEnergyBarInfo MorphConfig;

		// Token: 0x0401FECA RID: 130762
		private SpecialEnergyBarInfo NormalConfig;

		// Token: 0x0401FECB RID: 130763
		private SpecialEnergyBarXinYueHuSlot BarItemNormal;

		// Token: 0x0401FECC RID: 130764
		private SpecialEnergyBarXinYueHuSlot BarItemMorph;

		// Token: 0x0401FECD RID: 130765
		private SpecialEnergyBarXinYueHu.EState CurState;

		// Token: 0x0401FECE RID: 130766
		private IActiveBuff SubBuff;

		// Token: 0x0401FECF RID: 130767
		private int SubBuffHandle;

		// Token: 0x0401FED0 RID: 130768
		private IActiveBuff StarBuff;

		// Token: 0x0401FED1 RID: 130769
		private int StarBuffHandle;

		// Token: 0x0401FED2 RID: 130770
		private bool HasMorphUnlockTag;

		// Token: 0x0401FED3 RID: 130771
		private bool HasMorphTag;

		// Token: 0x0401FED4 RID: 130772
		private bool HasSecondMorphUnlockTag;

		// Token: 0x0401FED5 RID: 130773
		private bool HasSubTag;

		// Token: 0x0401FED6 RID: 130774
		private bool HasStarTag;

		// Token: 0x0401FED7 RID: 130775
		private float SubBuffPercent = -1f;

		// Token: 0x0401FED8 RID: 130776
		[Nullable(1)]
		private readonly bool[] FullStateList = new bool[2];

		// Token: 0x0401FED9 RID: 130777
		[Nullable(1)]
		private List<UUIItem> DecorItemList = new List<UUIItem>();

		// Token: 0x0401FEDA RID: 130778
		private bool IsPlayWarnAnim;

		// Token: 0x0401FEDB RID: 130779
		private int CurDecorIndex = -1;

		// Token: 0x0401FEDC RID: 130780
		[Nullable(1)]
		private readonly List<SpecialEnergyBarXinYueHuStar> StarList = new List<SpecialEnergyBarXinYueHuStar>();

		// Token: 0x0401FEDD RID: 130781
		private SpecialEnergyBarXinYueHuPillar Pillar;

		// Token: 0x0200C175 RID: 49525
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403A733 RID: 239411
			SlotNodeItem,
			// Token: 0x0403A734 RID: 239412
			SlotBarItemNormal,
			// Token: 0x0403A735 RID: 239413
			DecorItem1,
			// Token: 0x0403A736 RID: 239414
			DecorItem2,
			// Token: 0x0403A737 RID: 239415
			DecorItem3,
			// Token: 0x0403A738 RID: 239416
			DecorItem4,
			// Token: 0x0403A739 RID: 239417
			SubNodeItem,
			// Token: 0x0403A73A RID: 239418
			PillarItem,
			// Token: 0x0403A73B RID: 239419
			SubBarSprite,
			// Token: 0x0403A73C RID: 239420
			KeyContainerItem,
			// Token: 0x0403A73D RID: 239421
			SlotBarItemMorph,
			// Token: 0x0403A73E RID: 239422
			AniStateAToB,
			// Token: 0x0403A73F RID: 239423
			AniStateBToA,
			// Token: 0x0403A740 RID: 239424
			FireItem,
			// Token: 0x0403A741 RID: 239425
			FullEffectItem1,
			// Token: 0x0403A742 RID: 239426
			FullEffectItem2,
			// Token: 0x0403A743 RID: 239427
			StarLeftItem,
			// Token: 0x0403A744 RID: 239428
			StarRightItem,
			// Token: 0x0403A745 RID: 239429
			AniWarning,
			// Token: 0x0403A746 RID: 239430
			NiaFullEffect
		}

		// Token: 0x0200C176 RID: 49526
		[NullableContext(0)]
		private enum EState
		{
			// Token: 0x0403A748 RID: 239432
			Normal,
			// Token: 0x0403A749 RID: 239433
			Morph,
			// Token: 0x0403A74A RID: 239434
			Sub
		}
	}
}
