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
	// Token: 0x0200525A RID: 21082
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaHeadItem : UiPanelBase
	{
		// Token: 0x06035E0C RID: 220684 RVA: 0x00CBFFCC File Offset: 0x00CBE1CC
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

		// Token: 0x06035E0D RID: 220685 RVA: 0x00CC0054 File Offset: 0x00CBE254
		protected UniTask InitAddHpItem()
		{
			PhantomArenaHeadItem.<InitAddHpItem>d__8 <InitAddHpItem>d__;
			<InitAddHpItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitAddHpItem>d__.<>4__this = this;
			<InitAddHpItem>d__.<>1__state = -1;
			<InitAddHpItem>d__.<>t__builder.Start<PhantomArenaHeadItem.<InitAddHpItem>d__8>(ref <InitAddHpItem>d__);
			return <InitAddHpItem>d__.<>t__builder.Task;
		}

		// Token: 0x06035E0E RID: 220686 RVA: 0x00CC0097 File Offset: 0x00CBE297
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.SequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnDamageAccumulateEnd), false);
			this.RefreshDamageBar(0f);
		}

		// Token: 0x06035E0F RID: 220687 RVA: 0x00CC00D0 File Offset: 0x00CBE2D0
		private UniTask InitDialogItem()
		{
			PhantomArenaHeadItem.<InitDialogItem>d__10 <InitDialogItem>d__;
			<InitDialogItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDialogItem>d__.<>4__this = this;
			<InitDialogItem>d__.<>1__state = -1;
			<InitDialogItem>d__.<>t__builder.Start<PhantomArenaHeadItem.<InitDialogItem>d__10>(ref <InitDialogItem>d__);
			return <InitDialogItem>d__.<>t__builder.Task;
		}

		// Token: 0x06035E10 RID: 220688 RVA: 0x00CC0114 File Offset: 0x00CBE314
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaHeadItem.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaHeadItem.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035E11 RID: 220689 RVA: 0x00CC0157 File Offset: 0x00CBE357
		public void SetBarActive(bool isOwn)
		{
			base.GetSprite(1).SetUIActive(isOwn);
			base.GetSprite(2).SetUIActive(!isOwn);
		}

		// Token: 0x06035E12 RID: 220690 RVA: 0x00CC0176 File Offset: 0x00CBE376
		public void RefreshLifeBar(float fillAmount)
		{
			base.GetSprite(2).SetFillAmount(fillAmount);
			base.GetSprite(1).SetFillAmount(fillAmount);
		}

		// Token: 0x06035E13 RID: 220691 RVA: 0x00CC0192 File Offset: 0x00CBE392
		public void RefreshDamageBar(float fillAmount)
		{
			UUISprite sprite = base.GetSprite(4);
			if (sprite == null)
			{
				return;
			}
			sprite.SetFillAmount(fillAmount);
		}

		// Token: 0x06035E14 RID: 220692 RVA: 0x00CC01A8 File Offset: 0x00CBE3A8
		public void RefreshRoleIcon(string headIcon)
		{
			base.SetTextureByPath(headIcon, base.GetTexture(0), null, null);
		}

		// Token: 0x06035E15 RID: 220693 RVA: 0x00CC01CD File Offset: 0x00CBE3CD
		public UUIItem GetAttachItem()
		{
			return base.GetItem(3);
		}

		// Token: 0x06035E16 RID: 220694 RVA: 0x00CC01D8 File Offset: 0x00CBE3D8
		public void PlayAccumulateDamage()
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlayLevelSequenceByName(EPhantomBattleHeadAnim.DamageAccumulate.ToString(), false, null, false);
		}

		// Token: 0x06035E17 RID: 220695 RVA: 0x00CC0210 File Offset: 0x00CBE410
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

		// Token: 0x06035E18 RID: 220696 RVA: 0x00CC025C File Offset: 0x00CBE45C
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

		// Token: 0x06035E19 RID: 220697 RVA: 0x00CC02A7 File Offset: 0x00CBE4A7
		private void OnDamageAccumulateEnd(string name)
		{
			if (name != EPhantomBattleHeadAnim.DamageAccumulate.ToString())
			{
				return;
			}
			EventSystem.Instance.Emit(EEventName.OnPhantomArenaBattleDamageAccumulateEnd);
		}

		// Token: 0x0401C8D1 RID: 116945
		public PhantomArenaDialogItem DialogItem;

		// Token: 0x0401C8D2 RID: 116946
		public bool IsOwn;

		// Token: 0x0401C8D3 RID: 116947
		public bool NeedAddHpEffect;

		// Token: 0x0401C8D4 RID: 116948
		protected LevelSequencePlayer SequencePlayer;

		// Token: 0x0401C8D5 RID: 116949
		protected HpItem AddHpItem;

		// Token: 0x0401C8D6 RID: 116950
		protected HpItem ReduceHpItem;

		// Token: 0x0200B419 RID: 46105
		[NullableContext(0)]
		private class ERoleHead
		{
			// Token: 0x0403691C RID: 223516
			public const int RoleIcon = 0;

			// Token: 0x0403691D RID: 223517
			public const int OwnBar = 1;

			// Token: 0x0403691E RID: 223518
			public const int OpponentBar = 2;

			// Token: 0x0403691F RID: 223519
			public const int AttachItem = 3;

			// Token: 0x04036920 RID: 223520
			public const int DamageBar = 4;
		}
	}
}
