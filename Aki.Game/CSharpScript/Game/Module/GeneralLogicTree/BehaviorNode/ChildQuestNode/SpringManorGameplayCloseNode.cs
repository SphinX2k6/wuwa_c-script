using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode
{
	// Token: 0x020049BC RID: 18876
	public class SpringManorGameplayCloseNode : ChildQuestNodeBase
	{
		// Token: 0x0602F437 RID: 193591 RVA: 0x00D2E583 File Offset: 0x00D2C783
		public SpringManorGameplayCloseNode(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x0602F438 RID: 193592 RVA: 0x00D2E58C File Offset: 0x00D2C78C
		[NullableContext(1)]
		protected override bool OnCreate(IBtNode nodeConfig)
		{
			IChildQuestBtNode childQuestBtNode = nodeConfig as IChildQuestBtNode;
			if (childQuestBtNode == null)
			{
				return false;
			}
			if (!base.OnCreate(nodeConfig))
			{
				return false;
			}
			ICheckSpringFestivalGameplayCompleted checkSpringFestivalGameplayCompleted = childQuestBtNode.Condition as ICheckSpringFestivalGameplayCompleted;
			if (checkSpringFestivalGameplayCompleted == null)
			{
				return false;
			}
			this.GameplayType = new ESpringFestivalGameplayType?(checkSpringFestivalGameplayCompleted.GameplayType.Type);
			ICheckSpringFestivalGameplayType gameplayType = checkSpringFestivalGameplayCompleted.GameplayType;
			ICheckSpringFestivalMixDrinksCompleted checkSpringFestivalMixDrinksCompleted = gameplayType as ICheckSpringFestivalMixDrinksCompleted;
			if (checkSpringFestivalMixDrinksCompleted == null)
			{
				ICheckSpringFestivalGuessJokerCompleted checkSpringFestivalGuessJokerCompleted = gameplayType as ICheckSpringFestivalGuessJokerCompleted;
				if (checkSpringFestivalGuessJokerCompleted == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Quest;
					ELogAuthor author = ELogAuthor.LRX;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
					defaultInterpolatedStringHandler.AppendLiteral("缺少的类型");
					defaultInterpolatedStringHandler.AppendFormatted<ICheckSpringFestivalGameplayType>(checkSpringFestivalGameplayCompleted.GameplayType);
					instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				else
				{
					this.LevelId = checkSpringFestivalGuessJokerCompleted.Id.GetValueOrDefault();
				}
			}
			else
			{
				this.LevelId = checkSpringFestivalMixDrinksCompleted.Id.GetValueOrDefault();
			}
			return true;
		}

		// Token: 0x0602F439 RID: 193593 RVA: 0x00D2E667 File Offset: 0x00D2C867
		protected override void OnStart(ENodeStatusUpdateReason reason)
		{
		}

		// Token: 0x0602F43A RID: 193594 RVA: 0x00D2E669 File Offset: 0x00D2C869
		protected override void OnDestroy()
		{
			base.OnDestroy();
			this.GameplayType = null;
			this.LevelId = 0;
		}

		// Token: 0x0602F43B RID: 193595 RVA: 0x00D2E684 File Offset: 0x00D2C884
		protected override void AddEventsOnChildQuestStart()
		{
			base.AddEventsOnChildQuestStart();
			EventSystem.Instance.Add<ESpringFestivalGameplayType, int>(EEventName.OnSpringManorGameplayFinish, new Action<ESpringFestivalGameplayType, int>(this.OnGameplayFinish));
		}

		// Token: 0x0602F43C RID: 193596 RVA: 0x00D2E6A8 File Offset: 0x00D2C8A8
		protected override void RemoveEventsOnChildQuestEnd()
		{
			EventSystem.Instance.Remove<ESpringFestivalGameplayType, int>(EEventName.OnSpringManorGameplayFinish, new Action<ESpringFestivalGameplayType, int>(this.OnGameplayFinish));
			base.RemoveEventsOnChildQuestEnd();
		}

		// Token: 0x0602F43D RID: 193597 RVA: 0x00D2E6CC File Offset: 0x00D2C8CC
		private void OnGameplayFinish(ESpringFestivalGameplayType type, int levelId)
		{
			if (this.GameplayType == null)
			{
				return;
			}
			ESpringFestivalGameplayType? gameplayType = this.GameplayType;
			if (!(gameplayType.GetValueOrDefault() == type & gameplayType != null))
			{
				return;
			}
			if (this.LevelId == 0 || levelId == this.LevelId)
			{
				this.SubmitNode(null);
			}
		}

		// Token: 0x0602F43E RID: 193598 RVA: 0x00D2E71D File Offset: 0x00D2C91D
		protected override void OnAfterSubmit(bool submitSuccess)
		{
			base.OnAfterSubmit(submitSuccess);
			if (submitSuccess)
			{
				this.GameplayType = null;
				this.LevelId = 0;
			}
		}

		// Token: 0x04019114 RID: 102676
		private ESpringFestivalGameplayType? GameplayType;

		// Token: 0x04019115 RID: 102677
		private int LevelId;
	}
}
