using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.SkillInteract
{
	// Token: 0x02005282 RID: 21122
	public class PhantomArenaSelectSkillInteract : PhantomArenaSkillInteractBase, ISkillInteractMainUiInteract
	{
		// Token: 0x06036046 RID: 221254 RVA: 0x00CC87E0 File Offset: 0x00CC69E0
		private void TriggerCardActiveSkill()
		{
			PhantomCardData phantomCardData;
			if (this.Data.IsFight)
			{
				phantomCardData = PhantomArenaBattleModel.Instance.OwnData.GetBattleCardByCardId(this.Data.DataId.Value);
			}
			else
			{
				phantomCardData = PhantomArenaBattleModel.Instance.OwnData.GetHandCardDataByCardId(this.Data.DataId.Value);
			}
			PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(phantomCardData.ConfigId);
			this.BattleProxy.SkillTriggerMask.ShowTriggerMask(new int?(phantomBattleCardConfig.ActiveSkillId));
			this.BattleProxy.SkillTriggerMask.RefreshSkill(phantomBattleCardConfig.Name, phantomBattleCardConfig.CardEffectDescription, phantomBattleCardConfig.CardEffectDescriptionParams());
		}

		// Token: 0x06036047 RID: 221255 RVA: 0x00CC8898 File Offset: 0x00CC6A98
		private void TriggerCardClickSkill()
		{
			PhantomCardData battleCardByCardId = PhantomArenaBattleModel.Instance.OwnData.GetBattleCardByCardId(this.Data.DataId.Value);
			PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(battleCardByCardId.ConfigId);
			this.BattleProxy.SkillTriggerMask.ShowTriggerMask(new int?(battleCardByCardId.ClickActiveSkillId));
			this.BattleProxy.SkillTriggerMask.RefreshSkill(phantomBattleCardConfig.Name, phantomBattleCardConfig.DurableSkillDescription, phantomBattleCardConfig.DurableSkillDescriptionParams());
		}

		// Token: 0x06036048 RID: 221256 RVA: 0x00CC891C File Offset: 0x00CC6B1C
		private void TriggerPassiveSkill()
		{
			this.BattleProxy.SkillTriggerMask.ShowTriggerMask(this.Data.DataId);
			if (this.Data.DataId != null)
			{
				PhantomCardData battleCardByCardId = PhantomArenaBattleModel.Instance.OwnData.GetBattleCardByCardId(this.Data.DataId.Value);
				PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(battleCardByCardId.ConfigId);
				if (battleCardByCardId.IsField)
				{
					Span<int> passiveSkillIdBytes = phantomBattleCardConfig.GetPassiveSkillIdBytes();
					string skillDesc = (passiveSkillIdBytes.Length > 0) ? phantomBattleCardConfig.CardEffectDescription : phantomBattleCardConfig.CountSkillDescription;
					string[] paramsList = (passiveSkillIdBytes.Length > 0) ? phantomBattleCardConfig.CardEffectDescriptionParams() : phantomBattleCardConfig.CountSkillDescriptionParams();
					this.BattleProxy.SkillTriggerMask.RefreshSkill(phantomBattleCardConfig.Name, skillDesc, paramsList);
					return;
				}
				this.BattleProxy.SkillTriggerMask.RefreshSkill(phantomBattleCardConfig.Name, phantomBattleCardConfig.CardEffectDescription, phantomBattleCardConfig.CardEffectDescriptionParams());
			}
		}

		// Token: 0x06036049 RID: 221257 RVA: 0x00CC8A1C File Offset: 0x00CC6C1C
		private void TriggerRoleSkill()
		{
			this.BattleProxy.SkillTriggerMask.ShowTriggerMask(this.Data.DataId);
			if (this.Data.DataId != null)
			{
				int roleId = PhantomArenaBattleModel.Instance.OwnData.RoleId;
				PhantomBattleCardRole phantomBattleCardRole = PhantomArenaConfig.Instance.GetPhantomBattleCardRole(roleId);
				int num = phantomBattleCardRole.GetActiveSkillIdBytes().IndexOf(this.Data.DataId.Value);
				string skillName = phantomBattleCardRole.SkillNameList()[num];
				string skillDesc = phantomBattleCardRole.SkillDescList()[num];
				string[] paramsList = (phantomBattleCardRole.SkillDescParamsList() != null && num < phantomBattleCardRole.SkillDescParamsList().Length) ? phantomBattleCardRole.SkillDescParamsList()[num].ArrayString() : new string[0];
				this.BattleProxy.SkillTriggerMask.RefreshSkill(skillName, skillDesc, paramsList);
			}
		}

		// Token: 0x0603604A RID: 221258 RVA: 0x00CC8AF8 File Offset: 0x00CC6CF8
		private void TriggerSkill()
		{
			if (this.Data.IsRole)
			{
				this.TriggerRoleSkill();
				return;
			}
			if (this.Data.IsPassive)
			{
				this.TriggerPassiveSkill();
				return;
			}
			if (this.Data.DataId != null)
			{
				if (this.Data.IsClickInteract)
				{
					this.TriggerCardClickSkill();
					return;
				}
				this.TriggerCardActiveSkill();
			}
		}

		// Token: 0x0603604B RID: 221259 RVA: 0x00CC8B5C File Offset: 0x00CC6D5C
		private void ShowSkillTriggerMask()
		{
			this.TriggerSkill();
			this.BattleProxy.SkillTriggerMask.RefreshTips(this.SelectedIdMap.Count, this.ConditionSize);
			this.BattleProxy.SkillTriggerMask.RefreshCancelBtnActive(this.Data.IsPassive);
		}

		// Token: 0x0603604C RID: 221260 RVA: 0x00CC8BAC File Offset: 0x00CC6DAC
		private void SortOrderAreaCanvas()
		{
			List<EPhantomArenaInteractTag> list = new List<EPhantomArenaInteractTag>
			{
				EPhantomArenaInteractTag.OwnMonster,
				EPhantomArenaInteractTag.OpponentAreaMonster
			};
			if (this.Data.IsRole)
			{
				list.Add(EPhantomArenaInteractTag.OwnSkill);
			}
			this.BattleProxy.CanvasManager.SortOrderAreaCanvas(list, this.Data, this);
		}

		// Token: 0x0603604D RID: 221261 RVA: 0x00CC8BFC File Offset: 0x00CC6DFC
		protected override UniTask<EPhantomArenaSkillInteractExecuteResult> OnExecute([Nullable(1)] PhantomArenaBattleProxy proxy)
		{
			PhantomArenaSelectSkillInteract.<OnExecute>d__10 <OnExecute>d__;
			<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder<EPhantomArenaSkillInteractExecuteResult>.Create();
			<OnExecute>d__.<>4__this = this;
			<OnExecute>d__.proxy = proxy;
			<OnExecute>d__.<>1__state = -1;
			<OnExecute>d__.<>t__builder.Start<PhantomArenaSelectSkillInteract.<OnExecute>d__10>(ref <OnExecute>d__);
			return <OnExecute>d__.<>t__builder.Task;
		}

		// Token: 0x0603604E RID: 221262 RVA: 0x00CC8C48 File Offset: 0x00CC6E48
		protected UniTask<bool> TryHandleFinish()
		{
			PhantomArenaSelectSkillInteract.<TryHandleFinish>d__11 <TryHandleFinish>d__;
			<TryHandleFinish>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<TryHandleFinish>d__.<>4__this = this;
			<TryHandleFinish>d__.<>1__state = -1;
			<TryHandleFinish>d__.<>t__builder.Start<PhantomArenaSelectSkillInteract.<TryHandleFinish>d__11>(ref <TryHandleFinish>d__);
			return <TryHandleFinish>d__.<>t__builder.Task;
		}

		// Token: 0x0603604F RID: 221263 RVA: 0x00CC8C8C File Offset: 0x00CC6E8C
		private void Reset()
		{
			this.BattleProxy.HideLine();
			this.BattleProxy.SkillTriggerMask.HideTriggerMask();
			this.BattleProxy.CanvasManager.ResetAreaCanvas();
			foreach (int index in this.SelectedIdMap.Values)
			{
				this.BattleProxy.OwnArea.FunctionalArea.ResetCardSelectState(index);
			}
			this.BattleProxy.UnRegisterCantDragReason(EPhantomArenaCantDragReason.SelectSkillInteract);
		}

		// Token: 0x06036050 RID: 221264 RVA: 0x00CC8D2C File Offset: 0x00CC6F2C
		protected unsafe bool OnReceiveClickData(int cardId, int index, bool isSelected)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.PhantomArena;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "Buff期间,接收到卡牌点击";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("卡牌Id", cardId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("是否选中", isSelected);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			if (isSelected && this.SelectedIdMap.Count >= this.ConditionSize)
			{
				Log.Instance.Info(ELogModule.PhantomArena, ELogAuthor.XXJ, "Buff期间,已经选择的卡牌数量达到上限,无法再选择", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			if (isSelected)
			{
				this.SelectedIdMap[cardId] = index;
				this.LastSelectedId = cardId;
			}
			else
			{
				this.SelectedIdMap.Remove(cardId);
			}
			this.BattleProxy.SkillTriggerMask.RefreshTips(this.SelectedIdMap.Count, this.ConditionSize);
			return true;
		}

		// Token: 0x06036051 RID: 221265 RVA: 0x00CC8E18 File Offset: 0x00CC7018
		protected bool OnCheckCondition()
		{
			return this.SelectedIdMap.Count >= this.ConditionSize;
		}

		// Token: 0x06036052 RID: 221266 RVA: 0x00CC8E30 File Offset: 0x00CC7030
		protected UniTask<bool> OnHandleFinish()
		{
			PhantomArenaSelectSkillInteract.<OnHandleFinish>d__15 <OnHandleFinish>d__;
			<OnHandleFinish>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OnHandleFinish>d__.<>4__this = this;
			<OnHandleFinish>d__.<>1__state = -1;
			<OnHandleFinish>d__.<>t__builder.Start<PhantomArenaSelectSkillInteract.<OnHandleFinish>d__15>(ref <OnHandleFinish>d__);
			return <OnHandleFinish>d__.<>t__builder.Task;
		}

		// Token: 0x06036053 RID: 221267 RVA: 0x00CC8E74 File Offset: 0x00CC7074
		[NullableContext(1)]
		public bool ReceiveClickData(ESkillInteractMainUiInteractType type, params object[] data)
		{
			if (type == ESkillInteractMainUiInteractType.CancelBtn)
			{
				Log.Instance.Info(ELogModule.PhantomArena, ELogAuthor.XXJ, "取消执行Buff交互操作", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.Reset();
				this.Info.CancelSkillInteract();
				return true;
			}
			if (type == ESkillInteractMainUiInteractType.ConfirmBtn)
			{
				this.TryHandleFinish().Forget<bool>();
				return true;
			}
			return this.OnReceiveClickData((int)data[0], (int)data[1], (bool)data[2]);
		}

		// Token: 0x0401C99D RID: 117149
		[Nullable(1)]
		private readonly Dictionary<int, int> SelectedIdMap = new Dictionary<int, int>();

		// Token: 0x0401C99E RID: 117150
		private int LastSelectedId = -1;

		// Token: 0x0401C99F RID: 117151
		private int ConditionSize;
	}
}
