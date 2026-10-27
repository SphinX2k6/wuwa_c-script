using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DD2 RID: 24018
	[NullableContext(2)]
	[Nullable(0)]
	public class SpecialEnergyBarChun : SpecialEnergyBarBase
	{
		// Token: 0x0603D098 RID: 250008 RVA: 0x00EADEF8 File Offset: 0x00EAC0F8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 24;
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
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603D099 RID: 250009 RVA: 0x00EAE248 File Offset: 0x00EAC448
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarChun.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarChun.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D09A RID: 250010 RVA: 0x00EAE28C File Offset: 0x00EAC48C
		[NullableContext(1)]
		protected UniTask InitPointItem(UUIItem pointItem)
		{
			SpecialEnergyBarChun.<InitPointItem>d__15 <InitPointItem>d__;
			<InitPointItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitPointItem>d__.<>4__this = this;
			<InitPointItem>d__.pointItem = pointItem;
			<InitPointItem>d__.<>1__state = -1;
			<InitPointItem>d__.<>t__builder.Start<SpecialEnergyBarChun.<InitPointItem>d__15>(ref <InitPointItem>d__);
			return <InitPointItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603D09B RID: 250011 RVA: 0x00EAE2D7 File Offset: 0x00EAC4D7
		protected override void OnInitData()
		{
			base.OnInitData();
			this.IsEvilStage = this.TagComponent.HasTag(SpecialEnergyBarChun.TagEvil);
			this.IsStrengthStage = this.TagComponent.HasTag(SpecialEnergyBarChun.TagStrength);
			this.IsEnergyStage = this.GetKeyEnable();
		}

		// Token: 0x0603D09C RID: 250012 RVA: 0x00EAE317 File Offset: 0x00EAC517
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarChun.TagEvil, new BaseTagComponent.TTagSwitchedCallback(this.OnTagEvilChange));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarChun.TagStrength, new BaseTagComponent.TTagSwitchedCallback(this.OnTagStrengthChange));
		}

		// Token: 0x0603D09D RID: 250013 RVA: 0x00EAE34D File Offset: 0x00EAC54D
		protected override void OnStart()
		{
			base.OnStart();
			this.InitAllTweenAnim();
			this.UpdatePointItemEffect();
			this.UpdateEvilState(false);
			this.UpdateStrengthState(false);
			this.RefreshBarPercent(true);
		}

		// Token: 0x0603D09E RID: 250014 RVA: 0x00EAE378 File Offset: 0x00EAC578
		private void InitAllTweenAnim()
		{
			this.TweenPlayer = new BattleUiTweenAnimPlayer();
			this.TweenPlayer.InitTweenAnim(17, base.GetItem(17), false);
			this.TweenPlayer.InitTweenAnim(18, base.GetItem(18), false);
			this.TweenPlayer.InitTweenAnim(19, base.GetItem(19), false);
			this.TweenPlayer.InitTweenAnim(20, base.GetItem(20), false);
			this.TweenPlayer.InitTweenAnim(21, base.GetItem(21), false);
			this.TweenPlayer.InitTweenAnim(22, base.GetItem(22), false);
			this.TweenPlayer.InitTweenAnim(23, base.GetItem(23), false);
		}

		// Token: 0x0603D09F RID: 250015 RVA: 0x00EAE42C File Offset: 0x00EAC62C
		private void UpdatePointItemEffect()
		{
			if (!this.IsStrengthStage)
			{
				this.PointItem.ResetFullEffect();
				FColor fcolor = FColor.FromHex(this.Config.EffectColor);
				FLinearColor flinearColor = new FLinearColor(ref fcolor);
				this.PointItem.SetFullEffectColor(flinearColor, false);
				return;
			}
			UNiagaraSystem valueOrDefault = this.NiagaraList.GetValueOrDefault(0);
			if (valueOrDefault != null && this.PointItem != null)
			{
				this.PointItem.ReplaceFullEffect(valueOrDefault);
			}
		}

		// Token: 0x0603D0A0 RID: 250016 RVA: 0x00EAE498 File Offset: 0x00EAC698
		private void UpdateEvilState(bool playAnim = false)
		{
			if (!this.IsEvilStage)
			{
				base.GetItem(2).SetUIActive(true);
				base.GetItem(4).SetUIActive(this.IsEnergyStage);
				base.GetItem(5).SetUIActive(!this.IsEnergyStage);
				base.GetItem(6).SetUIActive(this.IsEnergyStage);
				base.GetItem(8).SetUIActive(false);
				if (!playAnim)
				{
					base.GetItem(3).SetAlpha(1f);
					base.GetItem(4).SetAlpha(1f);
					base.GetItem(9).SetAlpha(1f);
					base.GetItem(10).SetAlpha(1f);
					base.GetItem(7).SetUIActive(false);
					return;
				}
				BattleUiTweenAnimPlayer tweenPlayer = this.TweenPlayer;
				if (tweenPlayer != null)
				{
					tweenPlayer.StopTweenAnim(18);
				}
				BattleUiTweenAnimPlayer tweenPlayer2 = this.TweenPlayer;
				if (tweenPlayer2 == null)
				{
					return;
				}
				tweenPlayer2.PlayTweenAnim(17);
				return;
			}
			else
			{
				base.GetItem(8).SetUIActive(true);
				base.GetItem(10).SetUIActive(this.IsEnergyStage);
				base.GetItem(11).SetUIActive(!this.IsEnergyStage);
				base.GetItem(12).SetUIActive(this.IsEnergyStage);
				base.GetItem(2).SetUIActive(false);
				if (!playAnim)
				{
					base.GetItem(3).SetAlpha(1f);
					base.GetItem(4).SetAlpha(1f);
					base.GetItem(9).SetAlpha(1f);
					base.GetItem(10).SetAlpha(1f);
					base.GetItem(13).SetUIActive(false);
					return;
				}
				BattleUiTweenAnimPlayer tweenPlayer3 = this.TweenPlayer;
				if (tweenPlayer3 != null)
				{
					tweenPlayer3.StopTweenAnim(17);
				}
				BattleUiTweenAnimPlayer tweenPlayer4 = this.TweenPlayer;
				if (tweenPlayer4 == null)
				{
					return;
				}
				tweenPlayer4.PlayTweenAnim(18);
				return;
			}
		}

		// Token: 0x0603D0A1 RID: 250017 RVA: 0x00EAE654 File Offset: 0x00EAC854
		private void UpdateStrengthState(bool playAnim = false)
		{
			if (!this.IsStrengthStage)
			{
				base.GetItem(3).SetUIActive(true);
				base.GetItem(9).SetUIActive(true);
				if (!playAnim)
				{
					base.GetItem(14).SetUIActive(false);
					return;
				}
				BattleUiTweenAnimPlayer tweenPlayer = this.TweenPlayer;
				if (tweenPlayer != null)
				{
					tweenPlayer.StopTweenAnim(19);
				}
				BattleUiTweenAnimPlayer tweenPlayer2 = this.TweenPlayer;
				if (tweenPlayer2 == null)
				{
					return;
				}
				tweenPlayer2.PlayTweenAnim(20);
				return;
			}
			else
			{
				if (!playAnim)
				{
					base.GetItem(3).SetUIActive(false);
					base.GetItem(9).SetUIActive(false);
					base.GetItem(14).SetUIActive(true);
					base.GetItem(15).SetUIActive(true);
					base.GetItem(16).SetUIActive(false);
					return;
				}
				BattleUiTweenAnimPlayer tweenPlayer3 = this.TweenPlayer;
				if (tweenPlayer3 != null)
				{
					tweenPlayer3.StopTweenAnim(20);
				}
				BattleUiTweenAnimPlayer tweenPlayer4 = this.TweenPlayer;
				if (tweenPlayer4 == null)
				{
					return;
				}
				tweenPlayer4.PlayTweenAnim(19);
				return;
			}
		}

		// Token: 0x0603D0A2 RID: 250018 RVA: 0x00EAE72C File Offset: 0x00EAC92C
		private void UpdateEnergyState()
		{
			if (this.IsEnergyStage)
			{
				base.GetItem(4).SetUIActive(true);
				base.GetItem(10).SetUIActive(true);
				BattleUiTweenAnimPlayer tweenPlayer = this.TweenPlayer;
				if (tweenPlayer != null)
				{
					tweenPlayer.StopTweenAnim(23);
				}
				BattleUiTweenAnimPlayer tweenPlayer2 = this.TweenPlayer;
				if (tweenPlayer2 == null)
				{
					return;
				}
				tweenPlayer2.PlayTweenAnim(22);
				return;
			}
			else
			{
				BattleUiTweenAnimPlayer tweenPlayer3 = this.TweenPlayer;
				if (tweenPlayer3 != null)
				{
					tweenPlayer3.StopTweenAnim(22);
				}
				BattleUiTweenAnimPlayer tweenPlayer4 = this.TweenPlayer;
				if (tweenPlayer4 == null)
				{
					return;
				}
				tweenPlayer4.PlayTweenAnim(23);
				return;
			}
		}

		// Token: 0x0603D0A3 RID: 250019 RVA: 0x00EAE7A8 File Offset: 0x00EAC9A8
		protected void RefreshBarPercent(bool isStart = false)
		{
			float curPercent = this.PercentMachine.GetCurPercent();
			this.PointItem.UpdatePercent(curPercent, true, 0);
			bool flag = curPercent > 0f;
			if (flag != this.IsEnergyStage)
			{
				this.IsEnergyStage = flag;
				this.UpdateEnergyState();
			}
			SpecialEnergyBarKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.RefreshKeyEnable(flag, isStart);
		}

		// Token: 0x0603D0A4 RID: 250020 RVA: 0x00EAE800 File Offset: 0x00EACA00
		protected void RefreshBuff()
		{
			SpecialEnergyBarInfo config = this.Config;
			bool flag;
			if (config == null)
			{
				flag = false;
			}
			else
			{
				long buffId = config.BuffId;
				flag = true;
			}
			if (flag)
			{
				CharacterBuffComponent buffComponent = this.BuffComponent;
				this.Buff = ((buffComponent != null) ? buffComponent.GetBuffById(this.Config.BuffId) : null);
				IActiveBuff buff = this.Buff;
				this.BuffHandle = ((buff != null) ? buff.Handle : 0);
				return;
			}
			this.Buff = null;
			this.BuffHandle = 0;
		}

		// Token: 0x0603D0A5 RID: 250021 RVA: 0x00EAE86D File Offset: 0x00EACA6D
		private void OnTagEvilChange(int tagId, bool tagExist)
		{
			if (tagExist == this.IsEvilStage)
			{
				return;
			}
			this.IsEvilStage = tagExist;
			this.UpdateEvilState(true);
		}

		// Token: 0x0603D0A6 RID: 250022 RVA: 0x00EAE887 File Offset: 0x00EACA87
		private void OnTagStrengthChange(int tagId, bool tagExist)
		{
			if (tagExist == this.IsStrengthStage)
			{
				return;
			}
			this.IsStrengthStage = tagExist;
			this.UpdatePointItemEffect();
			this.UpdateStrengthState(true);
		}

		// Token: 0x0603D0A7 RID: 250023 RVA: 0x00EAE8A7 File Offset: 0x00EACAA7
		protected override void OnBarPercentChanged()
		{
			this.RefreshBarPercent(false);
		}

		// Token: 0x0603D0A8 RID: 250024 RVA: 0x00EAE8B0 File Offset: 0x00EACAB0
		public override void Tick(float delta)
		{
			base.Tick(delta);
			SpecialEnergyBarPointItem pointItem = this.PointItem;
			if (pointItem != null)
			{
				pointItem.Tick(delta);
			}
			if (this.Buff != null)
			{
				CharacterBuffComponent buffComponent = this.BuffComponent;
				if (((buffComponent != null) ? buffComponent.GetBuffByHandle(this.BuffHandle) : null) != null)
				{
					goto IL_41;
				}
			}
			this.RefreshBuff();
			IL_41:
			bool flag = this.Buff != null && this.Buff.GetRemainDuration() < this.Config.ExtraFloatParams[0];
			if (this.IsPlayWarnAnim != flag)
			{
				this.IsPlayWarnAnim = flag;
				if (flag)
				{
					BattleUiTweenAnimPlayer tweenPlayer = this.TweenPlayer;
					if (tweenPlayer == null)
					{
						return;
					}
					tweenPlayer.PlayTweenAnim(21);
					return;
				}
				else
				{
					BattleUiTweenAnimPlayer tweenPlayer2 = this.TweenPlayer;
					if (tweenPlayer2 != null)
					{
						tweenPlayer2.StopTweenAnim(21);
					}
					UUIItem item = base.GetItem(2);
					if (item != null)
					{
						item.SetAlpha(1f);
					}
					UUIItem item2 = base.GetItem(8);
					if (item2 != null)
					{
						item2.SetAlpha(1f);
					}
					UUIItem item3 = base.GetItem(14);
					if (item3 == null)
					{
						return;
					}
					item3.SetAlpha(1f);
				}
			}
		}

		// Token: 0x0603D0A9 RID: 250025 RVA: 0x00EAE9A8 File Offset: 0x00EACBA8
		protected override void OnBeforeDestroy()
		{
			base.OnBeforeDestroy();
			if (this.IsPlayWarnAnim)
			{
				this.IsPlayWarnAnim = false;
				BattleUiTweenAnimPlayer tweenPlayer = this.TweenPlayer;
				if (tweenPlayer != null)
				{
					tweenPlayer.StopTweenAnim(21);
				}
				UUIItem item = base.GetItem(2);
				if (item != null)
				{
					item.SetAlpha(1f);
				}
				UUIItem item2 = base.GetItem(8);
				if (item2 != null)
				{
					item2.SetAlpha(1f);
				}
				UUIItem item3 = base.GetItem(14);
				if (item3 != null)
				{
					item3.SetAlpha(1f);
				}
			}
			BattleUiTweenAnimPlayer tweenPlayer2 = this.TweenPlayer;
			if (tweenPlayer2 == null)
			{
				return;
			}
			tweenPlayer2.Clear(false);
		}

		// Token: 0x0401FCCB RID: 130251
		private const int POINT_NUM = 41;

		// Token: 0x0401FCCC RID: 130252
		private const float POINT_WIDTH = 9f;

		// Token: 0x0401FCCD RID: 130253
		[StaticVariableRuleIgnore]
		private static readonly int TagEvil = GameplayTagDefine.EGameplayTagId["角色.R2T1ChunMd10011.标记机制.魔人化启动"];

		// Token: 0x0401FCCE RID: 130254
		[StaticVariableRuleIgnore]
		private static readonly int TagStrength = GameplayTagDefine.EGameplayTagId["角色.R2T1ChunMd10011.标记机制.强化状态"];

		// Token: 0x0401FCCF RID: 130255
		private bool IsEvilStage;

		// Token: 0x0401FCD0 RID: 130256
		private bool IsStrengthStage;

		// Token: 0x0401FCD1 RID: 130257
		private bool IsEnergyStage;

		// Token: 0x0401FCD2 RID: 130258
		private SpecialEnergyBarPointItem PointItem;

		// Token: 0x0401FCD3 RID: 130259
		private BattleUiTweenAnimPlayer TweenPlayer;

		// Token: 0x0401FCD4 RID: 130260
		private IActiveBuff Buff;

		// Token: 0x0401FCD5 RID: 130261
		private int BuffHandle;

		// Token: 0x0401FCD6 RID: 130262
		private bool IsPlayWarnAnim;

		// Token: 0x0200C0E5 RID: 49381
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403A355 RID: 238421
			PointItem,
			// Token: 0x0403A356 RID: 238422
			KeyContainerItem,
			// Token: 0x0403A357 RID: 238423
			ItemA,
			// Token: 0x0403A358 RID: 238424
			ItemA1,
			// Token: 0x0403A359 RID: 238425
			ItemA2,
			// Token: 0x0403A35A RID: 238426
			ItemA3,
			// Token: 0x0403A35B RID: 238427
			ItemA4,
			// Token: 0x0403A35C RID: 238428
			ItemA5,
			// Token: 0x0403A35D RID: 238429
			ItemB,
			// Token: 0x0403A35E RID: 238430
			ItemB1,
			// Token: 0x0403A35F RID: 238431
			ItemB2,
			// Token: 0x0403A360 RID: 238432
			ItemB3,
			// Token: 0x0403A361 RID: 238433
			ItemB4,
			// Token: 0x0403A362 RID: 238434
			ItemB5,
			// Token: 0x0403A363 RID: 238435
			ItemStar,
			// Token: 0x0403A364 RID: 238436
			ItemStar1,
			// Token: 0x0403A365 RID: 238437
			ItemStar2,
			// Token: 0x0403A366 RID: 238438
			AniStageA,
			// Token: 0x0403A367 RID: 238439
			AniStageB,
			// Token: 0x0403A368 RID: 238440
			AniStrengthIn,
			// Token: 0x0403A369 RID: 238441
			AniStrengthOut,
			// Token: 0x0403A36A RID: 238442
			AniStrengthWarn,
			// Token: 0x0403A36B RID: 238443
			AniEnergyIn,
			// Token: 0x0403A36C RID: 238444
			AniEnergyOut
		}
	}
}
