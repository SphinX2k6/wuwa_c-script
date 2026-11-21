using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Panel
{
	// Token: 0x0200422A RID: 16938
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaHeadItem : UiPanelBase
	{
		// Token: 0x0602AD07 RID: 175367 RVA: 0x00C0D65C File Offset: 0x00C0B85C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUISprite)),
				new ValueTuple<int, Type>(2, typeof(UUISprite)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUISprite))
			};
		}

		// Token: 0x0602AD08 RID: 175368 RVA: 0x00C0D6E4 File Offset: 0x00C0B8E4
		protected UniTask InitAddHpItem()
		{
			PhantomArenaHeadItem.<InitAddHpItem>d__8 <InitAddHpItem>d__;
			<InitAddHpItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitAddHpItem>d__.<>4__this = this;
			<InitAddHpItem>d__.<>1__state = -1;
			<InitAddHpItem>d__.<>t__builder.Start<PhantomArenaHeadItem.<InitAddHpItem>d__8>(ref <InitAddHpItem>d__);
			return <InitAddHpItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602AD09 RID: 175369 RVA: 0x00C0D727 File Offset: 0x00C0B927
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.SequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnDamageAccumulateEnd), false);
			this.RefreshDamageBar(0f);
		}

		// Token: 0x0602AD0A RID: 175370 RVA: 0x00C0D760 File Offset: 0x00C0B960
		private UniTask InitDialogItem()
		{
			PhantomArenaHeadItem.<InitDialogItem>d__10 <InitDialogItem>d__;
			<InitDialogItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDialogItem>d__.<>4__this = this;
			<InitDialogItem>d__.<>1__state = -1;
			<InitDialogItem>d__.<>t__builder.Start<PhantomArenaHeadItem.<InitDialogItem>d__10>(ref <InitDialogItem>d__);
			return <InitDialogItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602AD0B RID: 175371 RVA: 0x00C0D7A4 File Offset: 0x00C0B9A4
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaHeadItem.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaHeadItem.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602AD0C RID: 175372 RVA: 0x00C0D7E7 File Offset: 0x00C0B9E7
		public void SetBarActive(bool isOwn)
		{
			base.GetSprite(1).SetUIActive(isOwn);
			base.GetSprite(2).SetUIActive(!isOwn);
		}

		// Token: 0x0602AD0D RID: 175373 RVA: 0x00C0D806 File Offset: 0x00C0BA06
		public void RefreshLifeBar(float fillAmount)
		{
			base.GetSprite(2).SetFillAmount(fillAmount);
			base.GetSprite(1).SetFillAmount(fillAmount);
		}

		// Token: 0x0602AD0E RID: 175374 RVA: 0x00C0D822 File Offset: 0x00C0BA22
		public void RefreshDamageBar(float fillAmount)
		{
			UUISprite sprite = base.GetSprite(4);
			if (sprite == null)
			{
				return;
			}
			sprite.SetFillAmount(fillAmount);
		}

		// Token: 0x0602AD0F RID: 175375 RVA: 0x00C0D838 File Offset: 0x00C0BA38
		public void RefreshRoleIcon(string headIcon)
		{
			base.SetTextureByPath(headIcon, base.GetTexture(0), null, null);
		}

		// Token: 0x0602AD10 RID: 175376 RVA: 0x00C0D85D File Offset: 0x00C0BA5D
		public UUIItem GetAttachItem()
		{
			return base.GetItem(3);
		}

		// Token: 0x0602AD11 RID: 175377 RVA: 0x00C0D868 File Offset: 0x00C0BA68
		public void PlayAccumulateDamage()
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlayLevelSequenceByName(EPhantomBattleHeadAnim.DamageAccumulate.ToString(), false, null, false);
		}

		// Token: 0x0602AD12 RID: 175378 RVA: 0x00C0D8A0 File Offset: 0x00C0BAA0
		public UniTask PlayAddHpEffect(int addCount)
		{
			PhantomArenaHeadItem.<PlayAddHpEffect>d__18 <PlayAddHpEffect>d__;
			<PlayAddHpEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayAddHpEffect>d__.<>4__this = this;
			<PlayAddHpEffect>d__.addCount = addCount;
			<PlayAddHpEffect>d__.<>1__state = -1;
			<PlayAddHpEffect>d__.<>t__builder.Start<PhantomArenaHeadItem.<PlayAddHpEffect>d__18>(ref <PlayAddHpEffect>d__);
			return <PlayAddHpEffect>d__.<>t__builder.Task;
		}

		// Token: 0x0602AD13 RID: 175379 RVA: 0x00C0D8EC File Offset: 0x00C0BAEC
		public UniTask PlayReduceHpEffect(int reduceCount)
		{
			PhantomArenaHeadItem.<PlayReduceHpEffect>d__19 <PlayReduceHpEffect>d__;
			<PlayReduceHpEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayReduceHpEffect>d__.<>4__this = this;
			<PlayReduceHpEffect>d__.reduceCount = reduceCount;
			<PlayReduceHpEffect>d__.<>1__state = -1;
			<PlayReduceHpEffect>d__.<>t__builder.Start<PhantomArenaHeadItem.<PlayReduceHpEffect>d__19>(ref <PlayReduceHpEffect>d__);
			return <PlayReduceHpEffect>d__.<>t__builder.Task;
		}

		// Token: 0x0602AD14 RID: 175380 RVA: 0x00C0D937 File Offset: 0x00C0BB37
		private void OnDamageAccumulateEnd(string name)
		{
			if (name != EPhantomBattleHeadAnim.DamageAccumulate.ToString())
			{
				return;
			}
			EventSystem.Instance.Emit(EEventName.OnPhantomArenaBattleDamageAccumulateEnd);
		}

		// Token: 0x04017306 RID: 94982
		public PhantomArenaDialogItem DialogItem;

		// Token: 0x04017307 RID: 94983
		public bool IsOwn;

		// Token: 0x04017308 RID: 94984
		public bool NeedAddHpEffect;

		// Token: 0x04017309 RID: 94985
		protected LevelSequencePlayer SequencePlayer;

		// Token: 0x0401730A RID: 94986
		protected HpItem AddHpItem;

		// Token: 0x0401730B RID: 94987
		protected HpItem ReduceHpItem;

		// Token: 0x02009E51 RID: 40529
		[NullableContext(0)]
		private class ERoleHead
		{
			// Token: 0x0403136F RID: 201583
			public const int RoleIcon = 0;

			// Token: 0x04031370 RID: 201584
			public const int OwnBar = 1;

			// Token: 0x04031371 RID: 201585
			public const int OpponentBar = 2;

			// Token: 0x04031372 RID: 201586
			public const int AttachItem = 3;

			// Token: 0x04031373 RID: 201587
			public const int DamageBar = 4;
		}
	}
}
