using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005C7A RID: 23674
	[NullableContext(2)]
	[Nullable(0)]
	public class LevelEventCheckBattleState : LevelEventBase
	{
		// Token: 0x0603A19E RID: 237982 RVA: 0x0105FF9F File Offset: 0x0105E19F
		public LevelEventCheckBattleState(int id) : base(id)
		{
		}

		// Token: 0x0603A19F RID: 237983 RVA: 0x0105FFA8 File Offset: 0x0105E1A8
		[NullableContext(1)]
		protected override void ExecuteInGm(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			base.FinishExecute(true, false, true);
		}

		// Token: 0x0603A1A0 RID: 237984 RVA: 0x0105FFB4 File Offset: 0x0105E1B4
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			this.GetResult = false;
			WaitBattleCondition waitBattleCondition = inParams as WaitBattleCondition;
			if (waitBattleCondition == null)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.ZS, "参数不合法", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.FinishExecute(false, false, true);
				return;
			}
			this.StateOption = waitBattleCondition.StateOption;
			if (this.StateOption == null || this.StateOption.TagOption == null)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.ZS, "StateOption不合法", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.FinishExecute(false, false, true);
				return;
			}
			this.BattleOption = this.StateOption.TagOption;
			base.CreateWaitEntityTask(this.StateOption.EntityId);
		}

		// Token: 0x0603A1A1 RID: 237985 RVA: 0x01060064 File Offset: 0x0105E264
		protected override void ExecuteWhenEntitiesReady()
		{
			this.MaxWaitTime = this.StateOption.MaxWaitTime * (float)TimeUtil.Instance.InverseMillisecond;
			this.EntityHandle = CreatureModel.Instance.GetEntityByPbDataId(this.StateOption.EntityId);
			this.CheckType = new EDetectBattleConditionType?(this.StateOption.Type);
		}

		// Token: 0x0603A1A2 RID: 237986 RVA: 0x010600C0 File Offset: 0x0105E2C0
		protected override void OnTick(float deltaTime)
		{
			float num = (this.BaseContext != null) ? (deltaTime * LevelGamePlayUtils.GetCustomTimeDilationByContext(this.BaseContext).GetValueOrDefault(1f)) : deltaTime;
			if (this.MaxWaitTime > 0f)
			{
				this.MaxWaitTime -= num;
				if (this.MaxWaitTime <= 0f)
				{
					base.FinishExecute(true, false, true);
				}
			}
			this.CurInterval++;
			if (this.CurInterval < 5)
			{
				return;
			}
			this.CurInterval = 0;
			if ((this.CheckType ?? ((EDetectBattleConditionType)1)) == EDetectBattleConditionType.DetectBattleTag)
			{
				this.GetResult = this.GetGameplayTag();
			}
			if (!this.GetResult)
			{
				return;
			}
			base.FinishExecute(true, false, true);
		}

		// Token: 0x0603A1A3 RID: 237987 RVA: 0x0106017C File Offset: 0x0105E37C
		private bool GetGameplayTag()
		{
			EntityHandle entityHandle = this.EntityHandle;
			if (entityHandle == null || !entityHandle.Valid)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.LevelEvent;
				ELogAuthor author = ELogAuthor.ZS;
				string message = "目标实体不存在，action视为执行成功";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityId", this.StateOption.EntityId);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return true;
			}
			string tagName = this.BattleOption.Type.ToEnumString();
			BaseTagComponent component = this.EntityHandle.Entity.GetComponent<BaseTagComponent>();
			return component != null && component.HasTag(GameplayTagUtils.GetTagIdByName(tagName));
		}

		// Token: 0x0603A1A4 RID: 237988 RVA: 0x0106020A File Offset: 0x0105E40A
		public override void Release()
		{
			base.Release();
			this.EntityHandle = null;
		}

		// Token: 0x0401EB64 RID: 125796
		private bool GetResult;

		// Token: 0x0401EB65 RID: 125797
		private EntityHandle EntityHandle;

		// Token: 0x0401EB66 RID: 125798
		private IDetectBattleTag StateOption;

		// Token: 0x0401EB67 RID: 125799
		private EDetectBattleConditionType? CheckType;

		// Token: 0x0401EB68 RID: 125800
		private IDetectBattleMonsterOnGround BattleOption;

		// Token: 0x0401EB69 RID: 125801
		private const int CheckInterval = 5;

		// Token: 0x0401EB6A RID: 125802
		private int CurInterval;

		// Token: 0x0401EB6B RID: 125803
		private float MaxWaitTime;
	}
}
