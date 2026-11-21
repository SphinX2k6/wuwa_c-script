using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DB6 RID: 19894
	[NullableContext(2)]
	[Nullable(0)]
	public class SpecialEnergyBarChun : SpecialEnergyBarBase
	{
		// Token: 0x0603200F RID: 204815 RVA: 0x00DFEDEC File Offset: 0x00DFCFEC
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

		// Token: 0x06032010 RID: 204816 RVA: 0x00DFF13C File Offset: 0x00DFD33C
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarChun.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarChun.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032011 RID: 204817 RVA: 0x00DFF180 File Offset: 0x00DFD380
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

		// Token: 0x06032012 RID: 204818 RVA: 0x00DFF1CB File Offset: 0x00DFD3CB
		protected override void OnInitData()
		{
			base.OnInitData();
			this.IsEvilStage = this.TagComponent.HasTag(SpecialEnergyBarChun.TagEvil);
			this.IsStrengthStage = this.TagComponent.HasTag(SpecialEnergyBarChun.TagStrength);
			this.IsEnergyStage = this.GetKeyEnable();
		}

		// Token: 0x06032013 RID: 204819 RVA: 0x00DFF20B File Offset: 0x00DFD40B
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarChun.TagEvil, new BaseTagComponent.TTagSwitchedCallback(this.OnTagEvilChange));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarChun.TagStrength, new BaseTagComponent.TTagSwitchedCallback(this.OnTagStrengthChange));
		}

		// Token: 0x06032014 RID: 204820 RVA: 0x00DFF241 File Offset: 0x00DFD441
		protected override void OnStart()
		{
			base.OnStart();
			this.InitAllTweenAnim();
			this.UpdatePointItemEffect();
			this.UpdateEvilState(false);
			this.UpdateStrengthState(false);
			this.RefreshBarPercent(true);
		}

		// Token: 0x06032015 RID: 204821 RVA: 0x00DFF26C File Offset: 0x00DFD46C
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

		// Token: 0x06032016 RID: 204822 RVA: 0x00DFF320 File Offset: 0x00DFD520
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

		// Token: 0x06032017 RID: 204823 RVA: 0x00DFF38C File Offset: 0x00DFD58C
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

		// Token: 0x06032018 RID: 204824 RVA: 0x00DFF548 File Offset: 0x00DFD748
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

		// Token: 0x06032019 RID: 204825 RVA: 0x00DFF620 File Offset: 0x00DFD820
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

		// Token: 0x0603201A RID: 204826 RVA: 0x00DFF69C File Offset: 0x00DFD89C
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

		// Token: 0x0603201B RID: 204827 RVA: 0x00DFF6F4 File Offset: 0x00DFD8F4
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

		// Token: 0x0603201C RID: 204828 RVA: 0x00DFF761 File Offset: 0x00DFD961
		private void OnTagEvilChange(int tagId, bool tagExist)
		{
			if (tagExist == this.IsEvilStage)
			{
				return;
			}
			this.IsEvilStage = tagExist;
			this.UpdateEvilState(true);
		}

		// Token: 0x0603201D RID: 204829 RVA: 0x00DFF77B File Offset: 0x00DFD97B
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

		// Token: 0x0603201E RID: 204830 RVA: 0x00DFF79B File Offset: 0x00DFD99B
		protected override void OnBarPercentChanged()
		{
			this.RefreshBarPercent(false);
		}

		// Token: 0x0603201F RID: 204831 RVA: 0x00DFF7A4 File Offset: 0x00DFD9A4
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

		// Token: 0x06032020 RID: 204832 RVA: 0x00DFF89C File Offset: 0x00DFDA9C
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

		// Token: 0x0401A788 RID: 108424
		private const int POINT_NUM = 41;

		// Token: 0x0401A789 RID: 108425
		private const float POINT_WIDTH = 9f;

		// Token: 0x0401A78A RID: 108426
		[StaticVariableRuleIgnore]
		private static readonly int TagEvil = GameplayTagDefine.EGameplayTagId["角色.R2T1ChunMd10011.标记机制.魔人化启动"];

		// Token: 0x0401A78B RID: 108427
		[StaticVariableRuleIgnore]
		private static readonly int TagStrength = GameplayTagDefine.EGameplayTagId["角色.R2T1ChunMd10011.标记机制.强化状态"];

		// Token: 0x0401A78C RID: 108428
		private bool IsEvilStage;

		// Token: 0x0401A78D RID: 108429
		private bool IsStrengthStage;

		// Token: 0x0401A78E RID: 108430
		private bool IsEnergyStage;

		// Token: 0x0401A78F RID: 108431
		private SpecialEnergyBarPointItem PointItem;

		// Token: 0x0401A790 RID: 108432
		private BattleUiTweenAnimPlayer TweenPlayer;

		// Token: 0x0401A791 RID: 108433
		private IActiveBuff Buff;

		// Token: 0x0401A792 RID: 108434
		private int BuffHandle;

		// Token: 0x0401A793 RID: 108435
		private bool IsPlayWarnAnim;

		// Token: 0x0200AAEE RID: 43758
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04034D27 RID: 216359
			PointItem,
			// Token: 0x04034D28 RID: 216360
			KeyContainerItem,
			// Token: 0x04034D29 RID: 216361
			ItemA,
			// Token: 0x04034D2A RID: 216362
			ItemA1,
			// Token: 0x04034D2B RID: 216363
			ItemA2,
			// Token: 0x04034D2C RID: 216364
			ItemA3,
			// Token: 0x04034D2D RID: 216365
			ItemA4,
			// Token: 0x04034D2E RID: 216366
			ItemA5,
			// Token: 0x04034D2F RID: 216367
			ItemB,
			// Token: 0x04034D30 RID: 216368
			ItemB1,
			// Token: 0x04034D31 RID: 216369
			ItemB2,
			// Token: 0x04034D32 RID: 216370
			ItemB3,
			// Token: 0x04034D33 RID: 216371
			ItemB4,
			// Token: 0x04034D34 RID: 216372
			ItemB5,
			// Token: 0x04034D35 RID: 216373
			ItemStar,
			// Token: 0x04034D36 RID: 216374
			ItemStar1,
			// Token: 0x04034D37 RID: 216375
			ItemStar2,
			// Token: 0x04034D38 RID: 216376
			AniStageA,
			// Token: 0x04034D39 RID: 216377
			AniStageB,
			// Token: 0x04034D3A RID: 216378
			AniStrengthIn,
			// Token: 0x04034D3B RID: 216379
			AniStrengthOut,
			// Token: 0x04034D3C RID: 216380
			AniStrengthWarn,
			// Token: 0x04034D3D RID: 216381
			AniEnergyIn,
			// Token: 0x04034D3E RID: 216382
			AniEnergyOut
		}
	}
}
