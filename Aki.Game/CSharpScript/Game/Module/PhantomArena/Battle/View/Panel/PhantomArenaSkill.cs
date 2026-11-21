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
	// Token: 0x0200422E RID: 16942
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaSkill : UiPanelBase, IAreaCanvas, ISkillInteractMainInterface
	{
		// Token: 0x0602AD60 RID: 175456 RVA: 0x00C0EAC0 File Offset: 0x00C0CCC0
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

		// Token: 0x0602AD61 RID: 175457 RVA: 0x00C0EB6C File Offset: 0x00C0CD6C
		protected override void OnStart()
		{
			this.Sequence = new UiSequencePlayer(this.RootItem);
			UUIButtonComponent button = base.GetButton(2);
			button.OnPointEnterCallBack.Bind(new Action(this.OnPointEnter));
			button.OnPointExitCallBack.Bind(new Action(this.OnPointExit));
			this.ViewProxy.BanButtonClickModule.RegisterButton(base.GetButton(2));
		}

		// Token: 0x0602AD62 RID: 175458 RVA: 0x00C0EBD5 File Offset: 0x00C0CDD5
		private void OnPointEnter()
		{
			this.ViewProxy.ShowSkillTips(this.SkillData, base.GetItem(4));
		}

		// Token: 0x0602AD63 RID: 175459 RVA: 0x00C0EBEF File Offset: 0x00C0CDEF
		private void OnPointExit()
		{
			this.ViewProxy.HideSkillTips();
		}

		// Token: 0x0602AD64 RID: 175460 RVA: 0x00C0EBFC File Offset: 0x00C0CDFC
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

		// Token: 0x0602AD65 RID: 175461 RVA: 0x00C0ECE4 File Offset: 0x00C0CEE4
		protected UniTask OnHandleRoleSkillClick()
		{
			PhantomArenaSkill.<OnHandleRoleSkillClick>d__10 <OnHandleRoleSkillClick>d__;
			<OnHandleRoleSkillClick>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnHandleRoleSkillClick>d__.<>4__this = this;
			<OnHandleRoleSkillClick>d__.<>1__state = -1;
			<OnHandleRoleSkillClick>d__.<>t__builder.Start<PhantomArenaSkill.<OnHandleRoleSkillClick>d__10>(ref <OnHandleRoleSkillClick>d__);
			return <OnHandleRoleSkillClick>d__.<>t__builder.Task;
		}

		// Token: 0x0602AD66 RID: 175462 RVA: 0x00C0ED28 File Offset: 0x00C0CF28
		protected UniTask ExecuteBuffEffect()
		{
			PhantomArenaSkill.<ExecuteBuffEffect>d__11 <ExecuteBuffEffect>d__;
			<ExecuteBuffEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteBuffEffect>d__.<>4__this = this;
			<ExecuteBuffEffect>d__.<>1__state = -1;
			<ExecuteBuffEffect>d__.<>t__builder.Start<PhantomArenaSkill.<ExecuteBuffEffect>d__11>(ref <ExecuteBuffEffect>d__);
			return <ExecuteBuffEffect>d__.<>t__builder.Task;
		}

		// Token: 0x0602AD67 RID: 175463 RVA: 0x00C0ED6C File Offset: 0x00C0CF6C
		private void RefreshPassiveSkill()
		{
			base.GetText(1).SetUIActive(false);
			base.GetItem(3).SetUIActive(false);
			base.SetTextureByPath(this.SkillData.Icon, base.GetTexture(0), null, null);
		}

		// Token: 0x0602AD68 RID: 175464 RVA: 0x00C0EDB8 File Offset: 0x00C0CFB8
		private void RefreshActiveSkill()
		{
			base.GetText(1).SetUIActive(true);
			base.GetItem(3).SetUIActive(true);
			base.SetTextureByPath(this.SkillData.Icon, base.GetTexture(0), null, null);
			base.GetText(1).SetText(this.SkillData.CostConsume.ToString(), true);
		}

		// Token: 0x0602AD69 RID: 175465 RVA: 0x00C0EE21 File Offset: 0x00C0D021
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

		// Token: 0x0602AD6A RID: 175466 RVA: 0x00C0EE48 File Offset: 0x00C0D048
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

		// Token: 0x0602AD6B RID: 175467 RVA: 0x00C0EEE0 File Offset: 0x00C0D0E0
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

		// Token: 0x0602AD6C RID: 175468 RVA: 0x00C0EF22 File Offset: 0x00C0D122
		public void HandleSortOrder()
		{
			this.RootItem.GetRenderCanvas().SetSortOrderNew(2, true);
		}

		// Token: 0x0602AD6D RID: 175469 RVA: 0x00C0EF36 File Offset: 0x00C0D136
		public void CancelSortOrder()
		{
			this.RootItem.GetRenderCanvas().SetSortOrderNew(0, true);
		}

		// Token: 0x0602AD6E RID: 175470 RVA: 0x00C0EF4C File Offset: 0x00C0D14C
		public UniTask StartSkillInteract()
		{
			return default(UniTask);
		}

		// Token: 0x0602AD6F RID: 175471 RVA: 0x00C0EF62 File Offset: 0x00C0D162
		public ISkillTriggerInfo GetData()
		{
			return PhantomArenaBattleModel.Instance.BuffEffectData.RoleSkillTriggerInfo;
		}

		// Token: 0x0602AD70 RID: 175472 RVA: 0x00C0EF73 File Offset: 0x00C0D173
		public void FinishSkillInteract()
		{
		}

		// Token: 0x0602AD71 RID: 175473 RVA: 0x00C0EF75 File Offset: 0x00C0D175
		public void CancelSkillInteract()
		{
		}

		// Token: 0x0602AD72 RID: 175474 RVA: 0x00C0EF77 File Offset: 0x00C0D177
		[NullableContext(2)]
		public void ReceiveUiInteract(ISkillInteractMainUiInteract uiInteract)
		{
		}

		// Token: 0x0401731F RID: 95007
		private IPhantomArenaSkillData SkillData;

		// Token: 0x04017320 RID: 95008
		private bool IsCanUse;

		// Token: 0x04017321 RID: 95009
		public PhantomArenaBattleProxy ViewProxy;

		// Token: 0x04017322 RID: 95010
		protected UiSequencePlayer Sequence;

		// Token: 0x02009E6E RID: 40558
		[NullableContext(0)]
		private class ESkillDefine
		{
			// Token: 0x040313F4 RID: 201716
			public const int SkillIcon = 0;

			// Token: 0x040313F5 RID: 201717
			public const int CostNum = 1;

			// Token: 0x040313F6 RID: 201718
			public const int Button = 2;

			// Token: 0x040313F7 RID: 201719
			public const int CostItem = 3;

			// Token: 0x040313F8 RID: 201720
			public const int AttachItem = 4;
		}
	}
}
