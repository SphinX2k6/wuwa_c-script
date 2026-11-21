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
	// Token: 0x02004DC7 RID: 19911
	[NullableContext(2)]
	[Nullable(0)]
	public class SpecialEnergyBarKaTiXiYa : SpecialEnergyBarBase
	{
		// Token: 0x06032106 RID: 205062 RVA: 0x00E05080 File Offset: 0x00E03280
		protected unsafe override void OnRegisterComponent()
		{
			int num = 18;
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
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06032107 RID: 205063 RVA: 0x00E05303 File Offset: 0x00E03503
		protected override void OnInitData()
		{
			this.BigConfig = BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(140901);
			this.AttributeId = (EAttributeType)this.BigConfig.AttributeId;
			this.MaxAttributeId = (EAttributeType)this.BigConfig.MaxAttributeId;
		}

		// Token: 0x06032108 RID: 205064 RVA: 0x00E05344 File Offset: 0x00E03544
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagAddOrRemoveChanged(GameplayTagDefine.EGameplayTagId["角色.Katixiya.状态.凭依时间"], new BaseTagComponent.TTagSwitchedCallback(this.OnUltraTagChange));
			base.ListenForTagAddOrRemoveChanged(GameplayTagDefine.EGameplayTagId["角色.Katixiya.解放状态.状态.大形态标记"], new BaseTagComponent.TTagSwitchedCallback(this.OnAdultTagChange));
			base.ListenForTagAddOrRemoveChanged(GameplayTagDefine.EGameplayTagId["角色.Katixiya.技能.大招变身"], new BaseTagComponent.TTagSwitchedCallback(this.OnUltarSkillTagChange));
		}

		// Token: 0x06032109 RID: 205065 RVA: 0x00E053BA File Offset: 0x00E035BA
		private void OnUltraTagChange(int tagId, bool tagExist)
		{
			this.SetUltraState(tagExist, false);
		}

		// Token: 0x0603210A RID: 205066 RVA: 0x00E053C4 File Offset: 0x00E035C4
		private void OnAdultTagChange(int tagId, bool tagExist)
		{
			this.SetAdultState(tagExist, false);
		}

		// Token: 0x0603210B RID: 205067 RVA: 0x00E053CE File Offset: 0x00E035CE
		private void OnUltarSkillTagChange(int tagId, bool tagExist)
		{
			this.SetUltraSkillState(tagExist, false);
		}

		// Token: 0x0603210C RID: 205068 RVA: 0x00E053D8 File Offset: 0x00E035D8
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarKaTiXiYa.<OnBeforeStartAsync>d__24 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarKaTiXiYa.<OnBeforeStartAsync>d__24>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603210D RID: 205069 RVA: 0x00E0541C File Offset: 0x00E0361C
		protected UniTask InitBarItem()
		{
			SpecialEnergyBarKaTiXiYa.<InitBarItem>d__25 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarKaTiXiYa.<InitBarItem>d__25>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603210E RID: 205070 RVA: 0x00E05460 File Offset: 0x00E03660
		protected override void OnStart()
		{
			base.InitTweenAnim(7);
			base.InitTweenAnim(8);
			base.InitTweenAnim(9);
			base.InitTweenAnim(10);
			base.InitTweenAnim(11);
			base.InitTweenAnim(12);
			base.InitTweenAnim(13);
			base.InitTweenAnim(14);
			base.InitTweenAnim(15);
			base.InitTweenAnim(16);
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				item.SetAlpha(1f);
			}
			UUIItem item2 = base.GetItem(1);
			if (item2 != null)
			{
				item2.SetAlpha(1f);
			}
			UUIItem item3 = base.GetItem(17);
			if (item3 != null)
			{
				item3.SetAlpha(1f);
			}
			UUIItem item4 = base.GetItem(2);
			if (item4 != null)
			{
				item4.SetAlpha(1f);
			}
			BaseTagComponent tagComponent = this.TagComponent;
			this.SetUltraState(tagComponent != null && tagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.Katixiya.状态.凭依时间"]), true);
			BaseTagComponent tagComponent2 = this.TagComponent;
			this.SetAdultState(tagComponent2 != null && tagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["角色.Katixiya.解放状态.状态.大形态标记"]), true);
			BaseTagComponent tagComponent3 = this.TagComponent;
			this.SetUltraSkillState(tagComponent3 != null && tagComponent3.HasTag(GameplayTagDefine.EGameplayTagId["角色.Katixiya.技能.大招变身"]), true);
			this.RefreshState(true);
		}

		// Token: 0x0603210F RID: 205071 RVA: 0x00E05597 File Offset: 0x00E03797
		protected override void ClearAllTweenAnim()
		{
			base.StopTweenAnim(15);
			base.ClearAllTweenAnim();
		}

		// Token: 0x06032110 RID: 205072 RVA: 0x00E055A7 File Offset: 0x00E037A7
		private void SetUltraState(bool isUltra, bool isStart = false)
		{
			if (isUltra == this.IsUltra && !isStart)
			{
				return;
			}
			this.IsUltra = isUltra;
			if (!isStart)
			{
				this.RefreshState(false);
			}
		}

		// Token: 0x06032111 RID: 205073 RVA: 0x00E055C7 File Offset: 0x00E037C7
		private void SetAdultState(bool isAdult, bool isStart = false)
		{
			if (isAdult == this.IsAdult && !isStart)
			{
				return;
			}
			this.IsAdult = isAdult;
			if (!isStart)
			{
				this.RefreshState(false);
			}
		}

		// Token: 0x06032112 RID: 205074 RVA: 0x00E055E7 File Offset: 0x00E037E7
		private void SetUltraSkillState(bool isUltraSkill, bool isStart = false)
		{
			if (isUltraSkill == this.IsUltraSkill && !isStart)
			{
				return;
			}
			this.IsUltraSkill = isUltraSkill;
			if (!isStart)
			{
				this.RefreshState(false);
			}
		}

		// Token: 0x06032113 RID: 205075 RVA: 0x00E05608 File Offset: 0x00E03808
		private void RefreshState(bool isStart = false)
		{
			SpecialEnergyBarKaTiXiYa.EState estate = SpecialEnergyBarKaTiXiYa.EState.Small;
			if (this.IsAdult || (this.IsUltraSkill && this.IsUltra))
			{
				estate = SpecialEnergyBarKaTiXiYa.EState.Big;
			}
			else if (this.IsUltra)
			{
				estate = SpecialEnergyBarKaTiXiYa.EState.UltraSmall;
			}
			if (this.State == estate && !isStart)
			{
				return;
			}
			this.State = estate;
			if (isStart)
			{
				switch (this.State)
				{
				case SpecialEnergyBarKaTiXiYa.EState.Small:
					base.PlayTweenAnim(12);
					break;
				case SpecialEnergyBarKaTiXiYa.EState.Big:
					base.PlayTweenAnim(13);
					break;
				case SpecialEnergyBarKaTiXiYa.EState.UltraSmall:
					base.PlayTweenAnim(14);
					break;
				}
				this.LastState = this.State;
			}
			UUIItem item = base.GetItem(6);
			if (item != null)
			{
				item.SetUIActive(this.State != SpecialEnergyBarKaTiXiYa.EState.Big);
			}
			UUIItem item2 = base.GetItem(0);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(this.State != SpecialEnergyBarKaTiXiYa.EState.Big);
		}

		// Token: 0x06032114 RID: 205076 RVA: 0x00E056D4 File Offset: 0x00E038D4
		private void PlayChangeStateAnim()
		{
			if (this.LastState == this.State || (float)Time.Instance.WorldTime < this.NextAnimTime)
			{
				return;
			}
			switch (this.State)
			{
			case SpecialEnergyBarKaTiXiYa.EState.Small:
				if (this.LastState == SpecialEnergyBarKaTiXiYa.EState.Big)
				{
					base.PlayTweenAnim(8);
				}
				else
				{
					base.PlayTweenAnim(11);
				}
				break;
			case SpecialEnergyBarKaTiXiYa.EState.Big:
				if (this.LastState == SpecialEnergyBarKaTiXiYa.EState.Small)
				{
					base.PlayTweenAnim(7);
				}
				else
				{
					base.PlayTweenAnim(10);
				}
				break;
			case SpecialEnergyBarKaTiXiYa.EState.UltraSmall:
				if (this.LastState == SpecialEnergyBarKaTiXiYa.EState.Small)
				{
					base.PlayTweenAnim(14);
				}
				else
				{
					base.PlayTweenAnim(9);
				}
				break;
			}
			this.LastState = this.State;
			this.NextAnimTime = (float)Time.Instance.WorldTime + 500f;
		}

		// Token: 0x06032115 RID: 205077 RVA: 0x00E05794 File Offset: 0x00E03994
		public override void Tick(float delta)
		{
			base.Tick(delta);
			SpecialEnergyBarKaTiXiYaSlot barItemSmall = this.BarItemSmall;
			if (barItemSmall != null)
			{
				barItemSmall.Tick(delta);
			}
			SpecialEnergyBarKaTiXiYaAdultSlot barItemBig = this.BarItemBig;
			if (barItemBig != null)
			{
				barItemBig.Tick(delta);
			}
			this.PlayChangeStateAnim();
			if (!this.IsUltra)
			{
				this.PlayWarnAnim(false);
				using (List<SpecialEnergyBarKaTiXiYaStar>.Enumerator enumerator = this.StarList.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						SpecialEnergyBarKaTiXiYaStar specialEnergyBarKaTiXiYaStar = enumerator.Current;
						specialEnergyBarKaTiXiYaStar.SetStarNum(0);
					}
					goto IL_16F;
				}
			}
			if (this.Buff != null)
			{
				CharacterBuffComponent buffComponent = this.BuffComponent;
				if (((buffComponent != null) ? buffComponent.GetBuffByHandle(this.BuffHandle) : null) != null)
				{
					goto IL_9F;
				}
			}
			this.RefreshBuff();
			IL_9F:
			if (this.Buff != null)
			{
				float remainDuration = this.Buff.GetRemainDuration();
				float num = MathF.Ceiling(remainDuration / this.Buff.Duration * 6f);
				this.PlayWarnAnim(this.IsAdult && remainDuration < this.BigConfig.ExtraFloatParams[0] && num <= 1f);
				using (List<SpecialEnergyBarKaTiXiYaStar>.Enumerator enumerator = this.StarList.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						SpecialEnergyBarKaTiXiYaStar specialEnergyBarKaTiXiYaStar2 = enumerator.Current;
						specialEnergyBarKaTiXiYaStar2.SetStarNum((int)num);
					}
					goto IL_16F;
				}
			}
			this.PlayWarnAnim(false);
			foreach (SpecialEnergyBarKaTiXiYaStar specialEnergyBarKaTiXiYaStar3 in this.StarList)
			{
				specialEnergyBarKaTiXiYaStar3.SetStarNum(0);
			}
			IL_16F:
			foreach (SpecialEnergyBarKaTiXiYaStar specialEnergyBarKaTiXiYaStar4 in this.StarList)
			{
				specialEnergyBarKaTiXiYaStar4.Tick(delta);
			}
		}

		// Token: 0x06032116 RID: 205078 RVA: 0x00E05978 File Offset: 0x00E03B78
		private void RefreshBuff()
		{
			SpecialEnergyBarInfo bigConfig = this.BigConfig;
			bool flag;
			if (bigConfig == null)
			{
				flag = false;
			}
			else
			{
				long buffId = bigConfig.BuffId;
				flag = true;
			}
			if (flag)
			{
				CharacterBuffComponent buffComponent = this.BuffComponent;
				this.Buff = ((buffComponent != null) ? buffComponent.GetBuffById(this.BigConfig.BuffId) : null);
				IActiveBuff buff = this.Buff;
				this.BuffHandle = ((buff != null) ? buff.Handle : 0);
				return;
			}
			this.Buff = null;
			this.BuffHandle = 0;
		}

		// Token: 0x06032117 RID: 205079 RVA: 0x00E059E8 File Offset: 0x00E03BE8
		private void PlayWarnAnim(bool bPlay)
		{
			if (this.IsPlayWarnAnim == bPlay)
			{
				return;
			}
			this.IsPlayWarnAnim = bPlay;
			if (bPlay)
			{
				base.PlayTweenAnim(15);
				return;
			}
			base.StopTweenAnim(15);
			UUIItem item = base.GetItem(17);
			if (item != null)
			{
				item.SetAlpha(1f);
			}
			UUIItem item2 = base.GetItem(2);
			if (item2 == null)
			{
				return;
			}
			item2.SetAlpha(1f);
		}

		// Token: 0x06032118 RID: 205080 RVA: 0x00E05A48 File Offset: 0x00E03C48
		protected override void OnBarPercentChanged()
		{
			float curPercent = this.PercentMachine.GetCurPercent();
			this.PlayBurstAnim(curPercent >= 1f);
		}

		// Token: 0x06032119 RID: 205081 RVA: 0x00E05A72 File Offset: 0x00E03C72
		private void PlayBurstAnim(bool bPlay)
		{
			if (this.IsPlayBurstAnim == bPlay)
			{
				return;
			}
			this.IsPlayBurstAnim = bPlay;
			if (bPlay && this.State == SpecialEnergyBarKaTiXiYa.EState.Big)
			{
				base.PlayTweenAnim(16);
			}
		}

		// Token: 0x0401A82E RID: 108590
		private const int ULTRA_CONFIG_ID = 140901;

		// Token: 0x0401A82F RID: 108591
		private const int ANIM_DURATION = 500;

		// Token: 0x0401A830 RID: 108592
		private SpecialEnergyBarInfo BigConfig;

		// Token: 0x0401A831 RID: 108593
		private SpecialEnergyBarKaTiXiYaSlot BarItemSmall;

		// Token: 0x0401A832 RID: 108594
		private SpecialEnergyBarKaTiXiYaAdultSlot BarItemBig;

		// Token: 0x0401A833 RID: 108595
		[Nullable(1)]
		private readonly List<SpecialEnergyBarKaTiXiYaStar> StarList = new List<SpecialEnergyBarKaTiXiYaStar>();

		// Token: 0x0401A834 RID: 108596
		private bool IsUltra;

		// Token: 0x0401A835 RID: 108597
		private bool IsAdult;

		// Token: 0x0401A836 RID: 108598
		private bool IsUltraSkill;

		// Token: 0x0401A837 RID: 108599
		private SpecialEnergyBarKaTiXiYa.EState State;

		// Token: 0x0401A838 RID: 108600
		private SpecialEnergyBarKaTiXiYa.EState LastState;

		// Token: 0x0401A839 RID: 108601
		private float NextAnimTime;

		// Token: 0x0401A83A RID: 108602
		private IActiveBuff Buff;

		// Token: 0x0401A83B RID: 108603
		private int BuffHandle;

		// Token: 0x0401A83C RID: 108604
		private bool IsPlayWarnAnim;

		// Token: 0x0401A83D RID: 108605
		private bool IsPlayBurstAnim;

		// Token: 0x0200AB14 RID: 43796
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04034E43 RID: 216643
			SmallItem,
			// Token: 0x04034E44 RID: 216644
			BigItem,
			// Token: 0x04034E45 RID: 216645
			StarItem,
			// Token: 0x04034E46 RID: 216646
			SlotBarItemBig,
			// Token: 0x04034E47 RID: 216647
			StarLeftItem,
			// Token: 0x04034E48 RID: 216648
			StarRightItem,
			// Token: 0x04034E49 RID: 216649
			KeyItem,
			// Token: 0x04034E4A RID: 216650
			AniSmallToBig,
			// Token: 0x04034E4B RID: 216651
			AniBigToSmall,
			// Token: 0x04034E4C RID: 216652
			AniChangeUltraSmall,
			// Token: 0x04034E4D RID: 216653
			AniChangeUltraBig,
			// Token: 0x04034E4E RID: 216654
			AniUltraSmallOut,
			// Token: 0x04034E4F RID: 216655
			AniSmall,
			// Token: 0x04034E50 RID: 216656
			AniBig,
			// Token: 0x04034E51 RID: 216657
			AniUltraSmall,
			// Token: 0x04034E52 RID: 216658
			AniWarning,
			// Token: 0x04034E53 RID: 216659
			AniBurst,
			// Token: 0x04034E54 RID: 216660
			BigWarnItem
		}

		// Token: 0x0200AB15 RID: 43797
		[NullableContext(0)]
		private enum EState
		{
			// Token: 0x04034E56 RID: 216662
			Small,
			// Token: 0x04034E57 RID: 216663
			Big,
			// Token: 0x04034E58 RID: 216664
			UltraSmall
		}
	}
}
