using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B02 RID: 27394
	[NullableContext(2)]
	[Nullable(0)]
	public class LevelEventCheckBattleState : LevelEventBase
	{
		// Token: 0x0604404C RID: 278604 RVA: 0x010B6703 File Offset: 0x010B4903
		public LevelEventCheckBattleState(int id) : base(id)
		{
		}

		// Token: 0x0604404D RID: 278605 RVA: 0x010B670C File Offset: 0x010B490C
		[NullableContext(1)]
		protected override void ExecuteInGm(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			base.FinishExecute(true, false, true);
		}

		// Token: 0x0604404E RID: 278606 RVA: 0x010B6718 File Offset: 0x010B4918
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

		// Token: 0x0604404F RID: 278607 RVA: 0x010B67C8 File Offset: 0x010B49C8
		protected override void ExecuteWhenEntitiesReady()
		{
			this.MaxWaitTime = this.StateOption.MaxWaitTime * (float)TimeUtil.Instance.InverseMillisecond;
			this.EntityHandle = CreatureModel.Instance.GetEntityByPbDataId(this.StateOption.EntityId);
			this.CheckType = new EDetectBattleConditionType?(this.StateOption.Type);
		}

		// Token: 0x06044050 RID: 278608 RVA: 0x010B6824 File Offset: 0x010B4A24
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

		// Token: 0x06044051 RID: 278609 RVA: 0x010B68E0 File Offset: 0x010B4AE0
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

		// Token: 0x06044052 RID: 278610 RVA: 0x010B696E File Offset: 0x010B4B6E
		public override void Release()
		{
			base.Release();
			this.EntityHandle = null;
		}

		// Token: 0x040238C2 RID: 145602
		private bool GetResult;

		// Token: 0x040238C3 RID: 145603
		private EntityHandle EntityHandle;

		// Token: 0x040238C4 RID: 145604
		private IDetectBattleTag StateOption;

		// Token: 0x040238C5 RID: 145605
		private EDetectBattleConditionType? CheckType;

		// Token: 0x040238C6 RID: 145606
		private IDetectBattleMonsterOnGround BattleOption;

		// Token: 0x040238C7 RID: 145607
		private const int CheckInterval = 5;

		// Token: 0x040238C8 RID: 145608
		private int CurInterval;

		// Token: 0x040238C9 RID: 145609
		private float MaxWaitTime;
	}
}
