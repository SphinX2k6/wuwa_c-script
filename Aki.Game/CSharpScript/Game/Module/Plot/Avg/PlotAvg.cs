using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot.Flow;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Plot.Avg
{
	// Token: 0x020040AF RID: 16559
	[NullableContext(1)]
	[Nullable(0)]
	public class PlotAvg
	{
		// Token: 0x06029E6A RID: 171626 RVA: 0x00BD92C8 File Offset: 0x00BD74C8
		[NullableContext(0)]
		public UniTask<bool> AvgCharacterEnterAsync([Nullable(1)] AvgTalkerEnterActionContext context)
		{
			PlotAvg.<AvgCharacterEnterAsync>d__2 <AvgCharacterEnterAsync>d__;
			<AvgCharacterEnterAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<AvgCharacterEnterAsync>d__.<>4__this = this;
			<AvgCharacterEnterAsync>d__.context = context;
			<AvgCharacterEnterAsync>d__.<>1__state = -1;
			<AvgCharacterEnterAsync>d__.<>t__builder.Start<PlotAvg.<AvgCharacterEnterAsync>d__2>(ref <AvgCharacterEnterAsync>d__);
			return <AvgCharacterEnterAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06029E6B RID: 171627 RVA: 0x00BD9314 File Offset: 0x00BD7514
		private UniTask PlayCharacterEnterPerformAsync(AvgTalkerEnterActionContext context)
		{
			PlotAvg.<PlayCharacterEnterPerformAsync>d__3 <PlayCharacterEnterPerformAsync>d__;
			<PlayCharacterEnterPerformAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayCharacterEnterPerformAsync>d__.<>4__this = this;
			<PlayCharacterEnterPerformAsync>d__.context = context;
			<PlayCharacterEnterPerformAsync>d__.<>1__state = -1;
			<PlayCharacterEnterPerformAsync>d__.<>t__builder.Start<PlotAvg.<PlayCharacterEnterPerformAsync>d__3>(ref <PlayCharacterEnterPerformAsync>d__);
			return <PlayCharacterEnterPerformAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06029E6C RID: 171628 RVA: 0x00BD935F File Offset: 0x00BD755F
		public void SetPerformHandler(IPlotAvgPerformHandler handler)
		{
			this.PerformHandler = handler;
		}

		// Token: 0x06029E6D RID: 171629 RVA: 0x00BD9368 File Offset: 0x00BD7568
		public void ClearPerformHandler()
		{
			this.PerformHandler = null;
		}

		// Token: 0x06029E6E RID: 171630 RVA: 0x00BD9374 File Offset: 0x00BD7574
		[NullableContext(0)]
		public UniTask<bool> AvgCharacterExitAsync(int characterId)
		{
			PlotAvg.<AvgCharacterExitAsync>d__6 <AvgCharacterExitAsync>d__;
			<AvgCharacterExitAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<AvgCharacterExitAsync>d__.<>4__this = this;
			<AvgCharacterExitAsync>d__.characterId = characterId;
			<AvgCharacterExitAsync>d__.<>1__state = -1;
			<AvgCharacterExitAsync>d__.<>t__builder.Start<PlotAvg.<AvgCharacterExitAsync>d__6>(ref <AvgCharacterExitAsync>d__);
			return <AvgCharacterExitAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06029E6F RID: 171631 RVA: 0x00BD93C0 File Offset: 0x00BD75C0
		private UniTask PlayCharacterExitPerformAsync(int characterId)
		{
			PlotAvg.<PlayCharacterExitPerformAsync>d__7 <PlayCharacterExitPerformAsync>d__;
			<PlayCharacterExitPerformAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayCharacterExitPerformAsync>d__.<>4__this = this;
			<PlayCharacterExitPerformAsync>d__.characterId = characterId;
			<PlayCharacterExitPerformAsync>d__.<>1__state = -1;
			<PlayCharacterExitPerformAsync>d__.<>t__builder.Start<PlotAvg.<PlayCharacterExitPerformAsync>d__7>(ref <PlayCharacterExitPerformAsync>d__);
			return <PlayCharacterExitPerformAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06029E70 RID: 171632 RVA: 0x00BD940C File Offset: 0x00BD760C
		public UniTask AvgCharacterMoveAsync(AvgTalkerMoveActionContext context)
		{
			PlotAvg.<AvgCharacterMoveAsync>d__8 <AvgCharacterMoveAsync>d__;
			<AvgCharacterMoveAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<AvgCharacterMoveAsync>d__.<>4__this = this;
			<AvgCharacterMoveAsync>d__.context = context;
			<AvgCharacterMoveAsync>d__.<>1__state = -1;
			<AvgCharacterMoveAsync>d__.<>t__builder.Start<PlotAvg.<AvgCharacterMoveAsync>d__8>(ref <AvgCharacterMoveAsync>d__);
			return <AvgCharacterMoveAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06029E71 RID: 171633 RVA: 0x00BD9458 File Offset: 0x00BD7658
		private UniTask PlayCharacterMovePerformAsync(AvgTalkerMoveActionContext context)
		{
			PlotAvg.<PlayCharacterMovePerformAsync>d__9 <PlayCharacterMovePerformAsync>d__;
			<PlayCharacterMovePerformAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayCharacterMovePerformAsync>d__.<>4__this = this;
			<PlayCharacterMovePerformAsync>d__.context = context;
			<PlayCharacterMovePerformAsync>d__.<>1__state = -1;
			<PlayCharacterMovePerformAsync>d__.<>t__builder.Start<PlotAvg.<PlayCharacterMovePerformAsync>d__9>(ref <PlayCharacterMovePerformAsync>d__);
			return <PlayCharacterMovePerformAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06029E72 RID: 171634 RVA: 0x00BD94A4 File Offset: 0x00BD76A4
		public void ChangeCharacterAnim(int characterId, EAvgRoleAnimationType animationType, bool isLoop)
		{
			PlotAvgCharacter plotAvgCharacter;
			if (!this.CharacterMap.TryGetValue(characterId, out plotAvgCharacter))
			{
				global::Log.Instance.Error(ELogModule.Plot, ELogAuthor.LZK, "[PlotAvg] 角色动画失败，角色不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (plotAvgCharacter.AnimationType == animationType)
			{
				return;
			}
			plotAvgCharacter.AnimationType = animationType;
			if (this.PerformHandler == null)
			{
				global::Log.Instance.Error(ELogModule.Plot, ELogAuthor.LZK, "[PlotAvg] PerformHandler 未设置，跳过角色动画表现", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.PerformHandler.ChangeCharacterAnim(characterId, animationType, isLoop);
		}

		// Token: 0x06029E73 RID: 171635 RVA: 0x00BD9524 File Offset: 0x00BD7724
		public UniTask AvgCharacterEnterOrChangeAnim(AvgTalkerEnterActionContext context)
		{
			PlotAvg.<AvgCharacterEnterOrChangeAnim>d__11 <AvgCharacterEnterOrChangeAnim>d__;
			<AvgCharacterEnterOrChangeAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<AvgCharacterEnterOrChangeAnim>d__.<>4__this = this;
			<AvgCharacterEnterOrChangeAnim>d__.context = context;
			<AvgCharacterEnterOrChangeAnim>d__.<>1__state = -1;
			<AvgCharacterEnterOrChangeAnim>d__.<>t__builder.Start<PlotAvg.<AvgCharacterEnterOrChangeAnim>d__11>(ref <AvgCharacterEnterOrChangeAnim>d__);
			return <AvgCharacterEnterOrChangeAnim>d__.<>t__builder.Task;
		}

		// Token: 0x06029E74 RID: 171636 RVA: 0x00BD956F File Offset: 0x00BD776F
		public void OnPlotEnd()
		{
			this.ClearPerformHandler();
			this.CharacterMap.Clear();
		}

		// Token: 0x06029E75 RID: 171637 RVA: 0x00BD9582 File Offset: 0x00BD7782
		[NullableContext(2)]
		public PlotAvgCharacter GetCharacter(int characterId)
		{
			return this.CharacterMap.GetValueOrDefault(characterId);
		}

		// Token: 0x06029E76 RID: 171638 RVA: 0x00BD9590 File Offset: 0x00BD7790
		[NullableContext(2)]
		public PlotAvgCharacter GetCharacterByPosition(EAvgRolePosition position)
		{
			foreach (PlotAvgCharacter plotAvgCharacter in this.CharacterMap.Values)
			{
				if (plotAvgCharacter.Position == position)
				{
					return plotAvgCharacter;
				}
			}
			return null;
		}

		// Token: 0x06029E77 RID: 171639 RVA: 0x00BD95F4 File Offset: 0x00BD77F4
		public HashSet<int> CollectCharacters(string flowListName, int flowId, int stateId)
		{
			HashSet<int> hashSet = new HashSet<int>();
			List<ActionInfo> flowStateActions = FlowConfig.Instance.GetFlowStateActions(flowListName, flowId, stateId);
			if (flowStateActions == null)
			{
				return hashSet;
			}
			ShowTalk showTalk = null;
			foreach (ActionInfo actionInfo in flowStateActions)
			{
				if (actionInfo.Name == EAction.ShowTalk)
				{
					showTalk = (actionInfo.Params as ShowTalk);
					break;
				}
			}
			if (showTalk == null)
			{
				return hashSet;
			}
			List<ITalkItem> talkItems = showTalk.TalkItems;
			if (talkItems == null)
			{
				return hashSet;
			}
			foreach (ITalkItem talkItem in talkItems)
			{
				this.CollectCharactersFromAvgTalk(talkItem, hashSet);
				this.CollectCharactersFromActions(talkItem, hashSet);
			}
			return hashSet;
		}

		// Token: 0x06029E78 RID: 171640 RVA: 0x00BD96D0 File Offset: 0x00BD78D0
		public void CollectCharactersFromAvgTalk(ITalkItem talkItem, HashSet<int> characterIdSet)
		{
			if (talkItem.Type.GetValueOrDefault() != ETalkItemType.AvgTalk)
			{
				return;
			}
			ITalkItemAvgTalk talkItemAvgTalk = talkItem as ITalkItemAvgTalk;
			if (talkItemAvgTalk == null || talkItemAvgTalk.WhoId == null || talkItemAvgTalk.WhoId.Value == 0)
			{
				return;
			}
			characterIdSet.Add(talkItemAvgTalk.WhoId.Value);
		}

		// Token: 0x06029E79 RID: 171641 RVA: 0x00BD9730 File Offset: 0x00BD7930
		public void CollectCharactersFromActions(ITalkItem talkItem, HashSet<int> characterIdSet)
		{
			if (talkItem.IntroActions != null)
			{
				foreach (ActionInfo actionInfo in talkItem.IntroActions)
				{
					this.CollectCharactersFromAction(actionInfo, characterIdSet);
				}
			}
			if (talkItem.Actions != null)
			{
				foreach (ActionInfo actionInfo2 in talkItem.Actions)
				{
					this.CollectCharactersFromAction(actionInfo2, characterIdSet);
				}
			}
		}

		// Token: 0x06029E7A RID: 171642 RVA: 0x00BD97D8 File Offset: 0x00BD79D8
		public void CollectCharactersFromAction(ActionInfo actionInfo, HashSet<int> characterIdSet)
		{
			if (actionInfo.Name != EAction.AvgPlayRoleAction)
			{
				return;
			}
			AvgPlayRoleAction avgPlayRoleAction = (AvgPlayRoleAction)actionInfo.Params;
			this.CollectCharactersFromRoleActions(avgPlayRoleAction, characterIdSet);
		}

		// Token: 0x06029E7B RID: 171643 RVA: 0x00BD9808 File Offset: 0x00BD7A08
		public void CollectCharactersFromRoleActions(AvgPlayRoleAction avgPlayRoleAction, HashSet<int> characterIdSet)
		{
			foreach (IAvgPlayRoleActionItem avgPlayRoleActionItem in avgPlayRoleAction.RoleActionList)
			{
				if (avgPlayRoleActionItem.PositionConfig != null)
				{
					characterIdSet.Add(avgPlayRoleActionItem.RoleId);
				}
			}
		}

		// Token: 0x04016D4A RID: 93514
		private readonly Dictionary<int, PlotAvgCharacter> CharacterMap = new Dictionary<int, PlotAvgCharacter>();

		// Token: 0x04016D4B RID: 93515
		[Nullable(2)]
		private IPlotAvgPerformHandler PerformHandler;
	}
}
