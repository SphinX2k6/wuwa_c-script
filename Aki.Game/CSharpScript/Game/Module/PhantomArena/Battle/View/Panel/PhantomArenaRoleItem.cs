using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Panel
{
	// Token: 0x0200525D RID: 21085
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaRoleItem : UiPanelBase
	{
		// Token: 0x06035E4F RID: 220751 RVA: 0x00CC0EC0 File Offset: 0x00CBF0C0
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

		// Token: 0x06035E50 RID: 220752 RVA: 0x00CC0FD8 File Offset: 0x00CBF1D8
		private UniTask InitRoleHead()
		{
			PhantomArenaRoleItem.<InitRoleHead>d__9 <InitRoleHead>d__;
			<InitRoleHead>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRoleHead>d__.<>4__this = this;
			<InitRoleHead>d__.<>1__state = -1;
			<InitRoleHead>d__.<>t__builder.Start<PhantomArenaRoleItem.<InitRoleHead>d__9>(ref <InitRoleHead>d__);
			return <InitRoleHead>d__.<>t__builder.Task;
		}

		// Token: 0x06035E51 RID: 220753 RVA: 0x00CC101C File Offset: 0x00CBF21C
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaRoleItem.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaRoleItem.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035E52 RID: 220754 RVA: 0x00CC1060 File Offset: 0x00CBF260
		protected override void OnStart()
		{
			this.Sequence = new UiSequencePlayer(this.RootItem);
			this.ShieldSequence = new UiSequencePlayer(base.GetItem(7));
			this.ShieldSequence.BindOnEndSequenceEvent(new Action<string>(this.OnSequenceEndEvent));
			this.ViewProxy.BanButtonClickModule.RegisterButton(base.GetButton(4));
			base.GetItem(7).SetUIActive(false);
		}

		// Token: 0x06035E53 RID: 220755 RVA: 0x00CC10CB File Offset: 0x00CBF2CB
		protected override void OnBeforeDestroy()
		{
			this.Sequence.Clear();
			this.ShieldSequence.Clear();
		}

		// Token: 0x06035E54 RID: 220756 RVA: 0x00CC10E3 File Offset: 0x00CBF2E3
		private void OnSequenceEndEvent(string sequenceName)
		{
			if (sequenceName == "ShiedBreak")
			{
				base.GetItem(7).SetUIActive(false);
			}
		}

		// Token: 0x06035E55 RID: 220757 RVA: 0x00CC10FF File Offset: 0x00CBF2FF
		private void OnPhantomBtnClick()
		{
			if (this.ViewProxy.InCantDragState())
			{
				return;
			}
			this.ViewProxy.SwitchFourCostTips(this.IsOwn, base.GetItem(5));
		}

		// Token: 0x06035E56 RID: 220758 RVA: 0x00CC1127 File Offset: 0x00CBF327
		public void RefreshLifeNum(int lifeNum, int maxLifeNum)
		{
			this.LastLifeNum = lifeNum;
			base.GetText(2).SetText(lifeNum.ToString() + "/" + maxLifeNum.ToString(), true);
			this.RoleHead.RefreshLifeBar((float)lifeNum / (float)maxLifeNum);
		}

		// Token: 0x06035E57 RID: 220759 RVA: 0x00CC1168 File Offset: 0x00CBF368
		public void RefreshLifeNumTween(float lifeNum, int maxLifeNum)
		{
			this.LastLifeNum = (int)lifeNum;
			base.GetText(2).SetText(Math.Floor((double)lifeNum).ToString() + "/" + maxLifeNum.ToString(), true);
			this.RoleHead.RefreshDamageBar(lifeNum / (float)maxLifeNum);
		}

		// Token: 0x06035E58 RID: 220760 RVA: 0x00CC11B9 File Offset: 0x00CBF3B9
		public void RefreshLifeNumTweenStart(int lifeNum, int maxLifeNum)
		{
			this.RoleHead.RefreshLifeBar((float)lifeNum / (float)maxLifeNum);
		}

		// Token: 0x06035E59 RID: 220761 RVA: 0x00CC11CB File Offset: 0x00CBF3CB
		public void SetBarActive(bool isOwn)
		{
			this.RoleHead.SetBarActive(isOwn);
		}

		// Token: 0x06035E5A RID: 220762 RVA: 0x00CC11DC File Offset: 0x00CBF3DC
		public void SetPhantomBtnActive(bool isActive)
		{
			base.GetButton(4).RootUIComp.Get().SetUIActive(isActive);
		}

		// Token: 0x06035E5B RID: 220763 RVA: 0x00CC1203 File Offset: 0x00CBF403
		public void ShowPhantomBtn()
		{
			this.SetPhantomBtnActive(true);
			this.Sequence.PlaySequencePurely("4cShow", false, false);
		}

		// Token: 0x06035E5C RID: 220764 RVA: 0x00CC121E File Offset: 0x00CBF41E
		public void RefreshHeadIcon(string headIcon)
		{
			this.RoleHead.RefreshRoleIcon(headIcon);
		}

		// Token: 0x06035E5D RID: 220765 RVA: 0x00CC122C File Offset: 0x00CBF42C
		public void RefreshMonsterIcon(string path)
		{
			base.SetTextureByPath(path, base.GetTexture(6), null, null);
		}

		// Token: 0x06035E5E RID: 220766 RVA: 0x00CC1251 File Offset: 0x00CBF451
		public void RegisterViewProxy(PhantomArenaBattleProxy viewProxy)
		{
			this.ViewProxy = viewProxy;
		}

		// Token: 0x06035E5F RID: 220767 RVA: 0x00CC125C File Offset: 0x00CBF45C
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

		// Token: 0x06035E60 RID: 220768 RVA: 0x00CC129D File Offset: 0x00CBF49D
		public void PlayHitAnim()
		{
			this.Sequence.PlaySequencePurely(EPhantomBattleHeadAnim.Hit.ToString(), false, false);
		}

		// Token: 0x06035E61 RID: 220769 RVA: 0x00CC12BC File Offset: 0x00CBF4BC
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

		// Token: 0x06035E62 RID: 220770 RVA: 0x00CC13A4 File Offset: 0x00CBF5A4
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

		// Token: 0x06035E63 RID: 220771 RVA: 0x00CC13EF File Offset: 0x00CBF5EF
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

		// Token: 0x0401C8E3 RID: 116963
		protected PhantomArenaHeadItem RoleHead;

		// Token: 0x0401C8E4 RID: 116964
		protected PhantomArenaBattleProxy ViewProxy;

		// Token: 0x0401C8E5 RID: 116965
		protected UiSequencePlayer Sequence;

		// Token: 0x0401C8E6 RID: 116966
		protected UiSequencePlayer ShieldSequence;

		// Token: 0x0401C8E7 RID: 116967
		protected int LastLifeNum;

		// Token: 0x0401C8E8 RID: 116968
		protected int LastShieldNum;

		// Token: 0x0401C8E9 RID: 116969
		public bool IsOwn;

		// Token: 0x0200B432 RID: 46130
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403698A RID: 223626
			public const int HeadItem = 0;

			// Token: 0x0403698B RID: 223627
			public const int TaskNum = 1;

			// Token: 0x0403698C RID: 223628
			public const int LifeNum = 2;

			// Token: 0x0403698D RID: 223629
			public const int PhantomSprite = 3;

			// Token: 0x0403698E RID: 223630
			public const int PhantomBtn = 4;

			// Token: 0x0403698F RID: 223631
			public const int AttachItem = 5;

			// Token: 0x04036990 RID: 223632
			public const int MonsterTex = 6;

			// Token: 0x04036991 RID: 223633
			public const int ShieldItem = 7;

			// Token: 0x04036992 RID: 223634
			public const int ShieldNum = 8;

			// Token: 0x04036993 RID: 223635
			public const int ShieldReduceNum = 9;
		}
	}
}
