using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena.Battle.Canvas;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Module.PhantomArena.Battle.SkillInteract;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Panel
{
	// Token: 0x0200525E RID: 21086
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaSkill : UiPanelBase, IAreaCanvas, ISkillInteractMainInterface
	{
		// Token: 0x06035E65 RID: 220773 RVA: 0x00CC1430 File Offset: 0x00CBF630
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(2, new Action(this.OnClick))
			};
		}

		// Token: 0x06035E66 RID: 220774 RVA: 0x00CC14DC File Offset: 0x00CBF6DC
		protected override void OnStart()
		{
			this.Sequence = new UiSequencePlayer(this.RootItem);
			UUIButtonComponent button = base.GetButton(2);
			button.OnPointEnterCallBack.Bind(new Action(this.OnPointEnter));
			button.OnPointExitCallBack.Bind(new Action(this.OnPointExit));
			this.ViewProxy.BanButtonClickModule.RegisterButton(base.GetButton(2));
		}

		// Token: 0x06035E67 RID: 220775 RVA: 0x00CC1545 File Offset: 0x00CBF745
		private void OnPointEnter()
		{
			this.ViewProxy.ShowSkillTips(this.SkillData, base.GetItem(4));
		}

		// Token: 0x06035E68 RID: 220776 RVA: 0x00CC155F File Offset: 0x00CBF75F
		private void OnPointExit()
		{
			this.ViewProxy.HideSkillTips();
		}

		// Token: 0x06035E69 RID: 220777 RVA: 0x00CC156C File Offset: 0x00CBF76C
		private void OnClick()
		{
			if (this.ViewProxy.InCantDragState())
			{
				return;
			}
			if (this.SkillData.IsPassive)
			{
				return;
			}
			if (this.ViewProxy.GuideManager.CheckInGuideAndShowTips())
			{
				return;
			}
			int battleStatusValue;
			if (this.SkillData.IsOwn)
			{
				battleStatusValue = PhantomArenaBattleModel.Instance.OwnData.GetBattleStatusValue(PhantomBattleRoleStatus.PhantomBattleCostPoint);
			}
			else
			{
				battleStatusValue = PhantomArenaBattleModel.Instance.OpponentData.GetBattleStatusValue(PhantomBattleRoleStatus.PhantomBattleCostPoint);
			}
			if (PhantomArenaConfig.Instance.GetPhantomBattleSkillConfig(this.SkillData.SkillId).CostConsume > battleStatusValue)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("PhantomBattle_1063", Array.Empty<object>());
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.PhantomArena;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "使用角色技能";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("技能", this.SkillData.SkillId);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.OnHandleRoleSkillClick().Forget();
		}

		// Token: 0x06035E6A RID: 220778 RVA: 0x00CC1654 File Offset: 0x00CBF854
		protected UniTask OnHandleRoleSkillClick()
		{
			PhantomArenaSkill.<OnHandleRoleSkillClick>d__10 <OnHandleRoleSkillClick>d__;
			<OnHandleRoleSkillClick>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnHandleRoleSkillClick>d__.<>4__this = this;
			<OnHandleRoleSkillClick>d__.<>1__state = -1;
			<OnHandleRoleSkillClick>d__.<>t__builder.Start<PhantomArenaSkill.<OnHandleRoleSkillClick>d__10>(ref <OnHandleRoleSkillClick>d__);
			return <OnHandleRoleSkillClick>d__.<>t__builder.Task;
		}

		// Token: 0x06035E6B RID: 220779 RVA: 0x00CC1698 File Offset: 0x00CBF898
		protected UniTask ExecuteBuffEffect()
		{
			PhantomArenaSkill.<ExecuteBuffEffect>d__11 <ExecuteBuffEffect>d__;
			<ExecuteBuffEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteBuffEffect>d__.<>4__this = this;
			<ExecuteBuffEffect>d__.<>1__state = -1;
			<ExecuteBuffEffect>d__.<>t__builder.Start<PhantomArenaSkill.<ExecuteBuffEffect>d__11>(ref <ExecuteBuffEffect>d__);
			return <ExecuteBuffEffect>d__.<>t__builder.Task;
		}

		// Token: 0x06035E6C RID: 220780 RVA: 0x00CC16DC File Offset: 0x00CBF8DC
		private void RefreshPassiveSkill()
		{
			base.GetText(1).SetUIActive(false);
			base.GetItem(3).SetUIActive(false);
			base.SetTextureByPath(this.SkillData.Icon, base.GetTexture(0), null, null);
		}

		// Token: 0x06035E6D RID: 220781 RVA: 0x00CC1728 File Offset: 0x00CBF928
		private void RefreshActiveSkill()
		{
			base.GetText(1).SetUIActive(true);
			base.GetItem(3).SetUIActive(true);
			base.SetTextureByPath(this.SkillData.Icon, base.GetTexture(0), null, null);
			base.GetText(1).SetText(this.SkillData.CostConsume.ToString(), true);
		}

		// Token: 0x06035E6E RID: 220782 RVA: 0x00CC1791 File Offset: 0x00CBF991
		public void Refresh(IPhantomArenaSkillData skillData)
		{
			this.SkillData = skillData;
			if (skillData.IsPassive)
			{
				this.RefreshPassiveSkill();
			}
			else
			{
				this.RefreshActiveSkill();
			}
			this.RefreshSkillEffect();
		}

		// Token: 0x06035E6F RID: 220783 RVA: 0x00CC17B8 File Offset: 0x00CBF9B8
		public void RefreshSkillEffect()
		{
			if (this.SkillData == null || this.SkillData.IsPassive)
			{
				return;
			}
			bool flag = PhantomArenaBattleModel.Instance.CheckSkillEnoughCost(this.SkillData.SkillId);
			if (flag == this.IsCanUse)
			{
				return;
			}
			if (flag)
			{
				this.Sequence.StopSequenceByKey("Use", false, true);
				this.Sequence.PlaySequencePurely("Activate", false, false);
			}
			else
			{
				this.Sequence.StopSequenceByKey("Activate", false, true);
				this.Sequence.PlaySequencePurely("Use", false, false);
			}
			this.IsCanUse = flag;
		}

		// Token: 0x06035E70 RID: 220784 RVA: 0x00CC1850 File Offset: 0x00CBFA50
		public bool CheckCanvasSortOrder(List<EPhantomArenaInteractTag> tagList, ISkillTriggerInfo skillTriggerInfo)
		{
			if (!tagList.Contains(EPhantomArenaInteractTag.OwnSkill))
			{
				return false;
			}
			int? dataId = skillTriggerInfo.DataId;
			int skillId = this.SkillData.SkillId;
			return dataId.GetValueOrDefault() == skillId & dataId != null;
		}

		// Token: 0x06035E71 RID: 220785 RVA: 0x00CC1892 File Offset: 0x00CBFA92
		public void HandleSortOrder()
		{
			this.RootItem.GetRenderCanvas().SetSortOrderNew(2, true);
		}

		// Token: 0x06035E72 RID: 220786 RVA: 0x00CC18A6 File Offset: 0x00CBFAA6
		public void CancelSortOrder()
		{
			this.RootItem.GetRenderCanvas().SetSortOrderNew(0, true);
		}

		// Token: 0x06035E73 RID: 220787 RVA: 0x00CC18BC File Offset: 0x00CBFABC
		public UniTask StartSkillInteract()
		{
			return default(UniTask);
		}

		// Token: 0x06035E74 RID: 220788 RVA: 0x00CC18D2 File Offset: 0x00CBFAD2
		public ISkillTriggerInfo GetData()
		{
			return PhantomArenaBattleModel.Instance.BuffEffectData.RoleSkillTriggerInfo;
		}

		// Token: 0x06035E75 RID: 220789 RVA: 0x00CC18E3 File Offset: 0x00CBFAE3
		public void FinishSkillInteract()
		{
		}

		// Token: 0x06035E76 RID: 220790 RVA: 0x00CC18E5 File Offset: 0x00CBFAE5
		public void CancelSkillInteract()
		{
		}

		// Token: 0x06035E77 RID: 220791 RVA: 0x00CC18E7 File Offset: 0x00CBFAE7
		[NullableContext(2)]
		public void ReceiveUiInteract(ISkillInteractMainUiInteract uiInteract)
		{
		}

		// Token: 0x0401C8EA RID: 116970
		private IPhantomArenaSkillData SkillData;

		// Token: 0x0401C8EB RID: 116971
		private bool IsCanUse;

		// Token: 0x0401C8EC RID: 116972
		public PhantomArenaBattleProxy ViewProxy;

		// Token: 0x0401C8ED RID: 116973
		protected UiSequencePlayer Sequence;

		// Token: 0x0200B436 RID: 46134
		[NullableContext(0)]
		private class ESkillDefine
		{
			// Token: 0x040369A1 RID: 223649
			public const int SkillIcon = 0;

			// Token: 0x040369A2 RID: 223650
			public const int CostNum = 1;

			// Token: 0x040369A3 RID: 223651
			public const int Button = 2;

			// Token: 0x040369A4 RID: 223652
			public const int CostItem = 3;

			// Token: 0x040369A5 RID: 223653
			public const int AttachItem = 4;
		}
	}
}
