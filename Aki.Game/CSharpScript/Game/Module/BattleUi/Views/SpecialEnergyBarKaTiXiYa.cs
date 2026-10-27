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
	// Token: 0x02005DE3 RID: 24035
	[NullableContext(2)]
	[Nullable(0)]
	public class SpecialEnergyBarKaTiXiYa : SpecialEnergyBarBase
	{
		// Token: 0x0603D18F RID: 250255 RVA: 0x00EB4180 File Offset: 0x00EB2380
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

		// Token: 0x0603D190 RID: 250256 RVA: 0x00EB4403 File Offset: 0x00EB2603
		protected override void OnInitData()
		{
			this.BigConfig = BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(140901);
			this.AttributeId = (EAttributeType)this.BigConfig.AttributeId;
			this.MaxAttributeId = (EAttributeType)this.BigConfig.MaxAttributeId;
		}

		// Token: 0x0603D191 RID: 250257 RVA: 0x00EB4444 File Offset: 0x00EB2644
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagAddOrRemoveChanged(GameplayTagDefine.EGameplayTagId["角色.Katixiya.状态.凭依时间"], new BaseTagComponent.TTagSwitchedCallback(this.OnUltraTagChange));
			base.ListenForTagAddOrRemoveChanged(GameplayTagDefine.EGameplayTagId["角色.Katixiya.解放状态.状态.大形态标记"], new BaseTagComponent.TTagSwitchedCallback(this.OnAdultTagChange));
			base.ListenForTagAddOrRemoveChanged(GameplayTagDefine.EGameplayTagId["角色.Katixiya.技能.大招变身"], new BaseTagComponent.TTagSwitchedCallback(this.OnUltarSkillTagChange));
		}

		// Token: 0x0603D192 RID: 250258 RVA: 0x00EB44BA File Offset: 0x00EB26BA
		private void OnUltraTagChange(int tagId, bool tagExist)
		{
			this.SetUltraState(tagExist, false);
		}

		// Token: 0x0603D193 RID: 250259 RVA: 0x00EB44C4 File Offset: 0x00EB26C4
		private void OnAdultTagChange(int tagId, bool tagExist)
		{
			this.SetAdultState(tagExist, false);
		}

		// Token: 0x0603D194 RID: 250260 RVA: 0x00EB44CE File Offset: 0x00EB26CE
		private void OnUltarSkillTagChange(int tagId, bool tagExist)
		{
			this.SetUltraSkillState(tagExist, false);
		}

		// Token: 0x0603D195 RID: 250261 RVA: 0x00EB44D8 File Offset: 0x00EB26D8
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarKaTiXiYa.<OnBeforeStartAsync>d__24 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarKaTiXiYa.<OnBeforeStartAsync>d__24>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D196 RID: 250262 RVA: 0x00EB451C File Offset: 0x00EB271C
		protected UniTask InitBarItem()
		{
			SpecialEnergyBarKaTiXiYa.<InitBarItem>d__25 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarKaTiXiYa.<InitBarItem>d__25>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603D197 RID: 250263 RVA: 0x00EB4560 File Offset: 0x00EB2760
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

		// Token: 0x0603D198 RID: 250264 RVA: 0x00EB4697 File Offset: 0x00EB2897
		protected override void ClearAllTweenAnim()
		{
			base.StopTweenAnim(15);
			base.ClearAllTweenAnim();
		}

		// Token: 0x0603D199 RID: 250265 RVA: 0x00EB46A7 File Offset: 0x00EB28A7
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

		// Token: 0x0603D19A RID: 250266 RVA: 0x00EB46C7 File Offset: 0x00EB28C7
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

		// Token: 0x0603D19B RID: 250267 RVA: 0x00EB46E7 File Offset: 0x00EB28E7
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

		// Token: 0x0603D19C RID: 250268 RVA: 0x00EB4708 File Offset: 0x00EB2908
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

		// Token: 0x0603D19D RID: 250269 RVA: 0x00EB47D4 File Offset: 0x00EB29D4
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

		// Token: 0x0603D19E RID: 250270 RVA: 0x00EB4894 File Offset: 0x00EB2A94
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

		// Token: 0x0603D19F RID: 250271 RVA: 0x00EB4A78 File Offset: 0x00EB2C78
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

		// Token: 0x0603D1A0 RID: 250272 RVA: 0x00EB4AE8 File Offset: 0x00EB2CE8
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

		// Token: 0x0603D1A1 RID: 250273 RVA: 0x00EB4B48 File Offset: 0x00EB2D48
		protected override void OnBarPercentChanged()
		{
			float curPercent = this.PercentMachine.GetCurPercent();
			this.PlayBurstAnim(curPercent >= 1f);
		}

		// Token: 0x0603D1A2 RID: 250274 RVA: 0x00EB4B72 File Offset: 0x00EB2D72
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

		// Token: 0x0401FD71 RID: 130417
		private const int ULTRA_CONFIG_ID = 140901;

		// Token: 0x0401FD72 RID: 130418
		private const int ANIM_DURATION = 500;

		// Token: 0x0401FD73 RID: 130419
		private SpecialEnergyBarInfo BigConfig;

		// Token: 0x0401FD74 RID: 130420
		private SpecialEnergyBarKaTiXiYaSlot BarItemSmall;

		// Token: 0x0401FD75 RID: 130421
		private SpecialEnergyBarKaTiXiYaAdultSlot BarItemBig;

		// Token: 0x0401FD76 RID: 130422
		[Nullable(1)]
		private readonly List<SpecialEnergyBarKaTiXiYaStar> StarList = new List<SpecialEnergyBarKaTiXiYaStar>();

		// Token: 0x0401FD77 RID: 130423
		private bool IsUltra;

		// Token: 0x0401FD78 RID: 130424
		private bool IsAdult;

		// Token: 0x0401FD79 RID: 130425
		private bool IsUltraSkill;

		// Token: 0x0401FD7A RID: 130426
		private SpecialEnergyBarKaTiXiYa.EState State;

		// Token: 0x0401FD7B RID: 130427
		private SpecialEnergyBarKaTiXiYa.EState LastState;

		// Token: 0x0401FD7C RID: 130428
		private float NextAnimTime;

		// Token: 0x0401FD7D RID: 130429
		private IActiveBuff Buff;

		// Token: 0x0401FD7E RID: 130430
		private int BuffHandle;

		// Token: 0x0401FD7F RID: 130431
		private bool IsPlayWarnAnim;

		// Token: 0x0401FD80 RID: 130432
		private bool IsPlayBurstAnim;

		// Token: 0x0200C10B RID: 49419
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403A471 RID: 238705
			SmallItem,
			// Token: 0x0403A472 RID: 238706
			BigItem,
			// Token: 0x0403A473 RID: 238707
			StarItem,
			// Token: 0x0403A474 RID: 238708
			SlotBarItemBig,
			// Token: 0x0403A475 RID: 238709
			StarLeftItem,
			// Token: 0x0403A476 RID: 238710
			StarRightItem,
			// Token: 0x0403A477 RID: 238711
			KeyItem,
			// Token: 0x0403A478 RID: 238712
			AniSmallToBig,
			// Token: 0x0403A479 RID: 238713
			AniBigToSmall,
			// Token: 0x0403A47A RID: 238714
			AniChangeUltraSmall,
			// Token: 0x0403A47B RID: 238715
			AniChangeUltraBig,
			// Token: 0x0403A47C RID: 238716
			AniUltraSmallOut,
			// Token: 0x0403A47D RID: 238717
			AniSmall,
			// Token: 0x0403A47E RID: 238718
			AniBig,
			// Token: 0x0403A47F RID: 238719
			AniUltraSmall,
			// Token: 0x0403A480 RID: 238720
			AniWarning,
			// Token: 0x0403A481 RID: 238721
			AniBurst,
			// Token: 0x0403A482 RID: 238722
			BigWarnItem
		}

		// Token: 0x0200C10C RID: 49420
		[NullableContext(0)]
		private enum EState
		{
			// Token: 0x0403A484 RID: 238724
			Small,
			// Token: 0x0403A485 RID: 238725
			Big,
			// Token: 0x0403A486 RID: 238726
			UltraSmall
		}
	}
}
