using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode
{
	// Token: 0x020059E3 RID: 23011
	public class SpringManorGameplayCloseNode : ChildQuestNodeBase
	{
		// Token: 0x0603A510 RID: 238864 RVA: 0x00DDED17 File Offset: 0x00DDCF17
		public SpringManorGameplayCloseNode(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x0603A511 RID: 238865 RVA: 0x00DDED20 File Offset: 0x00DDCF20
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

		// Token: 0x0603A512 RID: 238866 RVA: 0x00DDEDFB File Offset: 0x00DDCFFB
		protected override void OnStart(ENodeStatusUpdateReason reason)
		{
		}

		// Token: 0x0603A513 RID: 238867 RVA: 0x00DDEDFD File Offset: 0x00DDCFFD
		protected override void OnDestroy()
		{
			base.OnDestroy();
			this.GameplayType = null;
			this.LevelId = 0;
		}

		// Token: 0x0603A514 RID: 238868 RVA: 0x00DDEE18 File Offset: 0x00DDD018
		protected override void AddEventsOnChildQuestStart()
		{
			base.AddEventsOnChildQuestStart();
			EventSystem.Instance.Add<ESpringFestivalGameplayType, int>(EEventName.OnSpringManorGameplayFinish, new Action<ESpringFestivalGameplayType, int>(this.OnGameplayFinish));
		}

		// Token: 0x0603A515 RID: 238869 RVA: 0x00DDEE3C File Offset: 0x00DDD03C
		protected override void RemoveEventsOnChildQuestEnd()
		{
			EventSystem.Instance.Remove<ESpringFestivalGameplayType, int>(EEventName.OnSpringManorGameplayFinish, new Action<ESpringFestivalGameplayType, int>(this.OnGameplayFinish));
			base.RemoveEventsOnChildQuestEnd();
		}

		// Token: 0x0603A516 RID: 238870 RVA: 0x00DDEE60 File Offset: 0x00DDD060
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

		// Token: 0x0603A517 RID: 238871 RVA: 0x00DDEEB1 File Offset: 0x00DDD0B1
		protected override void OnAfterSubmit(bool submitSuccess)
		{
			base.OnAfterSubmit(submitSuccess);
			if (submitSuccess)
			{
				this.GameplayType = null;
				this.LevelId = 0;
			}
		}

		// Token: 0x0401E675 RID: 124533
		private ESpringFestivalGameplayType? GameplayType;

		// Token: 0x0401E676 RID: 124534
		private int LevelId;
	}
}
