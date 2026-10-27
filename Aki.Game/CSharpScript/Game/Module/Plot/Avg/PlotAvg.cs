using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot.Flow;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Plot.Avg
{
	// Token: 0x020050DF RID: 20703
	[NullableContext(1)]
	[Nullable(0)]
	public class PlotAvg
	{
		// Token: 0x06034F71 RID: 216945 RVA: 0x00C8BFE0 File Offset: 0x00C8A1E0
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

		// Token: 0x06034F72 RID: 216946 RVA: 0x00C8C02C File Offset: 0x00C8A22C
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

		// Token: 0x06034F73 RID: 216947 RVA: 0x00C8C077 File Offset: 0x00C8A277
		public void SetPerformHandler(IPlotAvgPerformHandler handler)
		{
			this.PerformHandler = handler;
		}

		// Token: 0x06034F74 RID: 216948 RVA: 0x00C8C080 File Offset: 0x00C8A280
		public void ClearPerformHandler()
		{
			this.PerformHandler = null;
		}

		// Token: 0x06034F75 RID: 216949 RVA: 0x00C8C08C File Offset: 0x00C8A28C
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

		// Token: 0x06034F76 RID: 216950 RVA: 0x00C8C0D8 File Offset: 0x00C8A2D8
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

		// Token: 0x06034F77 RID: 216951 RVA: 0x00C8C124 File Offset: 0x00C8A324
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

		// Token: 0x06034F78 RID: 216952 RVA: 0x00C8C170 File Offset: 0x00C8A370
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

		// Token: 0x06034F79 RID: 216953 RVA: 0x00C8C1BC File Offset: 0x00C8A3BC
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

		// Token: 0x06034F7A RID: 216954 RVA: 0x00C8C23C File Offset: 0x00C8A43C
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

		// Token: 0x06034F7B RID: 216955 RVA: 0x00C8C287 File Offset: 0x00C8A487
		public void OnPlotEnd()
		{
			this.ClearPerformHandler();
			this.CharacterMap.Clear();
		}

		// Token: 0x06034F7C RID: 216956 RVA: 0x00C8C29A File Offset: 0x00C8A49A
		[NullableContext(2)]
		public PlotAvgCharacter GetCharacter(int characterId)
		{
			return this.CharacterMap.GetValueOrDefault(characterId);
		}

		// Token: 0x06034F7D RID: 216957 RVA: 0x00C8C2A8 File Offset: 0x00C8A4A8
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

		// Token: 0x06034F7E RID: 216958 RVA: 0x00C8C30C File Offset: 0x00C8A50C
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

		// Token: 0x06034F7F RID: 216959 RVA: 0x00C8C3E8 File Offset: 0x00C8A5E8
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

		// Token: 0x06034F80 RID: 216960 RVA: 0x00C8C448 File Offset: 0x00C8A648
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

		// Token: 0x06034F81 RID: 216961 RVA: 0x00C8C4F0 File Offset: 0x00C8A6F0
		public void CollectCharactersFromAction(ActionInfo actionInfo, HashSet<int> characterIdSet)
		{
			if (actionInfo.Name != EAction.AvgPlayRoleAction)
			{
				return;
			}
			AvgPlayRoleAction avgPlayRoleAction = (AvgPlayRoleAction)actionInfo.Params;
			this.CollectCharactersFromRoleActions(avgPlayRoleAction, characterIdSet);
		}

		// Token: 0x06034F82 RID: 216962 RVA: 0x00C8C520 File Offset: 0x00C8A720
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

		// Token: 0x0401C319 RID: 115481
		private readonly Dictionary<int, PlotAvgCharacter> CharacterMap = new Dictionary<int, PlotAvgCharacter>();

		// Token: 0x0401C31A RID: 115482
		[Nullable(2)]
		private IPlotAvgPerformHandler PerformHandler;
	}
}
