using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Panel
{
	// Token: 0x0200422D RID: 16941
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaRoleItem : UiPanelBase
	{
		// Token: 0x0602AD4A RID: 175434 RVA: 0x00C0E550 File Offset: 0x00C0C750
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUISprite)),
				new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUITexture)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIText)),
				new ValueTuple<int, Type>(9, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(4, new Action(this.OnPhantomBtnClick))
			};
		}

		// Token: 0x0602AD4B RID: 175435 RVA: 0x00C0E668 File Offset: 0x00C0C868
		private UniTask InitRoleHead()
		{
			PhantomArenaRoleItem.<InitRoleHead>d__9 <InitRoleHead>d__;
			<InitRoleHead>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRoleHead>d__.<>4__this = this;
			<InitRoleHead>d__.<>1__state = -1;
			<InitRoleHead>d__.<>t__builder.Start<PhantomArenaRoleItem.<InitRoleHead>d__9>(ref <InitRoleHead>d__);
			return <InitRoleHead>d__.<>t__builder.Task;
		}

		// Token: 0x0602AD4C RID: 175436 RVA: 0x00C0E6AC File Offset: 0x00C0C8AC
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaRoleItem.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaRoleItem.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602AD4D RID: 175437 RVA: 0x00C0E6F0 File Offset: 0x00C0C8F0
		protected override void OnStart()
		{
			this.Sequence = new UiSequencePlayer(this.RootItem);
			this.ShieldSequence = new UiSequencePlayer(base.GetItem(7));
			this.ShieldSequence.BindOnEndSequenceEvent(new Action<string>(this.OnSequenceEndEvent));
			this.ViewProxy.BanButtonClickModule.RegisterButton(base.GetButton(4));
			base.GetItem(7).SetUIActive(false);
		}

		// Token: 0x0602AD4E RID: 175438 RVA: 0x00C0E75B File Offset: 0x00C0C95B
		protected override void OnBeforeDestroy()
		{
			this.Sequence.Clear();
			this.ShieldSequence.Clear();
		}

		// Token: 0x0602AD4F RID: 175439 RVA: 0x00C0E773 File Offset: 0x00C0C973
		private void OnSequenceEndEvent(string sequenceName)
		{
			if (sequenceName == "ShiedBreak")
			{
				base.GetItem(7).SetUIActive(false);
			}
		}

		// Token: 0x0602AD50 RID: 175440 RVA: 0x00C0E78F File Offset: 0x00C0C98F
		private void OnPhantomBtnClick()
		{
			if (this.ViewProxy.InCantDragState())
			{
				return;
			}
			this.ViewProxy.SwitchFourCostTips(this.IsOwn, base.GetItem(5));
		}

		// Token: 0x0602AD51 RID: 175441 RVA: 0x00C0E7B7 File Offset: 0x00C0C9B7
		public void RefreshLifeNum(int lifeNum, int maxLifeNum)
		{
			this.LastLifeNum = lifeNum;
			base.GetText(2).SetText(lifeNum.ToString() + "/" + maxLifeNum.ToString(), true);
			this.RoleHead.RefreshLifeBar((float)lifeNum / (float)maxLifeNum);
		}

		// Token: 0x0602AD52 RID: 175442 RVA: 0x00C0E7F8 File Offset: 0x00C0C9F8
		public void RefreshLifeNumTween(float lifeNum, int maxLifeNum)
		{
			this.LastLifeNum = (int)lifeNum;
			base.GetText(2).SetText(Math.Floor((double)lifeNum).ToString() + "/" + maxLifeNum.ToString(), true);
			this.RoleHead.RefreshDamageBar(lifeNum / (float)maxLifeNum);
		}

		// Token: 0x0602AD53 RID: 175443 RVA: 0x00C0E849 File Offset: 0x00C0CA49
		public void RefreshLifeNumTweenStart(int lifeNum, int maxLifeNum)
		{
			this.RoleHead.RefreshLifeBar((float)lifeNum / (float)maxLifeNum);
		}

		// Token: 0x0602AD54 RID: 175444 RVA: 0x00C0E85B File Offset: 0x00C0CA5B
		public void SetBarActive(bool isOwn)
		{
			this.RoleHead.SetBarActive(isOwn);
		}

		// Token: 0x0602AD55 RID: 175445 RVA: 0x00C0E86C File Offset: 0x00C0CA6C
		public void SetPhantomBtnActive(bool isActive)
		{
			base.GetButton(4).RootUIComp.Get().SetUIActive(isActive);
		}

		// Token: 0x0602AD56 RID: 175446 RVA: 0x00C0E893 File Offset: 0x00C0CA93
		public void ShowPhantomBtn()
		{
			this.SetPhantomBtnActive(true);
			this.Sequence.PlaySequencePurely("4cShow", false, false);
		}

		// Token: 0x0602AD57 RID: 175447 RVA: 0x00C0E8AE File Offset: 0x00C0CAAE
		public void RefreshHeadIcon(string headIcon)
		{
			this.RoleHead.RefreshRoleIcon(headIcon);
		}

		// Token: 0x0602AD58 RID: 175448 RVA: 0x00C0E8BC File Offset: 0x00C0CABC
		public void RefreshMonsterIcon(string path)
		{
			base.SetTextureByPath(path, base.GetTexture(6), null, null);
		}

		// Token: 0x0602AD59 RID: 175449 RVA: 0x00C0E8E1 File Offset: 0x00C0CAE1
		public void RegisterViewProxy(PhantomArenaBattleProxy viewProxy)
		{
			this.ViewProxy = viewProxy;
		}

		// Token: 0x0602AD5A RID: 175450 RVA: 0x00C0E8EC File Offset: 0x00C0CAEC
		public void PlayHpEffect(int lifeNum)
		{
			int num = lifeNum - this.LastLifeNum;
			if (num > 0)
			{
				this.RoleHead.PlayAddHpEffect(num).Forget();
				return;
			}
			if (num < 0)
			{
				this.RoleHead.PlayReduceHpEffect(num).Forget();
			}
		}

		// Token: 0x0602AD5B RID: 175451 RVA: 0x00C0E92D File Offset: 0x00C0CB2D
		public void PlayHitAnim()
		{
			this.Sequence.PlaySequencePurely(EPhantomBattleHeadAnim.Hit.ToString(), false, false);
		}

		// Token: 0x0602AD5C RID: 175452 RVA: 0x00C0E94C File Offset: 0x00C0CB4C
		public void RefreshShieldNum(int shieldNum)
		{
			if (shieldNum > this.LastShieldNum && this.LastShieldNum == 0)
			{
				base.GetText(8).SetText(shieldNum.ToString(), true);
				this.ShieldSequence.PlaySequencePurely("ShieldStart", false, false);
				base.GetItem(7).SetUIActive(true);
				this.LastShieldNum = shieldNum;
				return;
			}
			if (shieldNum >= this.LastShieldNum)
			{
				base.GetText(8).SetText(shieldNum.ToString(), true);
				this.LastShieldNum = shieldNum;
				return;
			}
			if (shieldNum == 0)
			{
				this.ShieldSequence.PlaySequencePurely("ShiedBreak", false, false);
				this.LastShieldNum = shieldNum;
				return;
			}
			int num = shieldNum - this.LastShieldNum;
			base.GetText(8).SetText(shieldNum.ToString(), true);
			base.GetText(9).SetText(num.ToString(), true);
			this.ShieldSequence.PlaySequencePurely("ShieldHit", false, false);
			this.LastShieldNum = shieldNum;
		}

		// Token: 0x0602AD5D RID: 175453 RVA: 0x00C0EA34 File Offset: 0x00C0CC34
		public UniTask PlayBeHitEffect(int damage)
		{
			PhantomArenaRoleItem.<PlayBeHitEffect>d__27 <PlayBeHitEffect>d__;
			<PlayBeHitEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayBeHitEffect>d__.<>4__this = this;
			<PlayBeHitEffect>d__.damage = damage;
			<PlayBeHitEffect>d__.<>1__state = -1;
			<PlayBeHitEffect>d__.<>t__builder.Start<PhantomArenaRoleItem.<PlayBeHitEffect>d__27>(ref <PlayBeHitEffect>d__);
			return <PlayBeHitEffect>d__.<>t__builder.Task;
		}

		// Token: 0x0602AD5E RID: 175454 RVA: 0x00C0EA7F File Offset: 0x00C0CC7F
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams == null || configParams.Length == 0)
			{
				return null;
			}
			if (!(configParams[0] == "Task"))
			{
				return null;
			}
			PhantomArenaBattleProxy viewProxy = this.ViewProxy;
			if (viewProxy == null)
			{
				return null;
			}
			PhantomArenaBattleDetailsTips detailsTipsItem = viewProxy.DetailsTipsItem;
			if (detailsTipsItem == null)
			{
				return null;
			}
			return detailsTipsItem.GetGuideUiItemAndUiItemForShowEx(configParams);
		}

		// Token: 0x04017318 RID: 95000
		protected PhantomArenaHeadItem RoleHead;

		// Token: 0x04017319 RID: 95001
		protected PhantomArenaBattleProxy ViewProxy;

		// Token: 0x0401731A RID: 95002
		protected UiSequencePlayer Sequence;

		// Token: 0x0401731B RID: 95003
		protected UiSequencePlayer ShieldSequence;

		// Token: 0x0401731C RID: 95004
		protected int LastLifeNum;

		// Token: 0x0401731D RID: 95005
		protected int LastShieldNum;

		// Token: 0x0401731E RID: 95006
		public bool IsOwn;

		// Token: 0x02009E6A RID: 40554
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x040313DD RID: 201693
			public const int HeadItem = 0;

			// Token: 0x040313DE RID: 201694
			public const int TaskNum = 1;

			// Token: 0x040313DF RID: 201695
			public const int LifeNum = 2;

			// Token: 0x040313E0 RID: 201696
			public const int PhantomSprite = 3;

			// Token: 0x040313E1 RID: 201697
			public const int PhantomBtn = 4;

			// Token: 0x040313E2 RID: 201698
			public const int AttachItem = 5;

			// Token: 0x040313E3 RID: 201699
			public const int MonsterTex = 6;

			// Token: 0x040313E4 RID: 201700
			public const int ShieldItem = 7;

			// Token: 0x040313E5 RID: 201701
			public const int ShieldNum = 8;

			// Token: 0x040313E6 RID: 201702
			public const int ShieldReduceNum = 9;
		}
	}
}
