using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02005BC9 RID: 23497
	[NullableContext(1)]
	[Nullable(0)]
	public class CiacconaGalPlayer : Singleton
	{
		// Token: 0x17008D00 RID: 36096
		// (get) Token: 0x0603B65C RID: 243292 RVA: 0x00E2AC38 File Offset: 0x00E28E38
		public ECiacconaGalPlayerState StatePendingToSwitch
		{
			get
			{
				return (ECiacconaGalPlayerState)this.InternalStatePendingToSwitch;
			}
		}

		// Token: 0x17008D01 RID: 36097
		// (get) Token: 0x0603B65D RID: 243293 RVA: 0x00E2AC40 File Offset: 0x00E28E40
		[Nullable(2)]
		public ICiacconaGalTextAnimHandler AnimHandler
		{
			[NullableContext(2)]
			get
			{
				return this.InternalAnimHandler;
			}
		}

		// Token: 0x0603B65E RID: 243294 RVA: 0x00E2AC48 File Offset: 0x00E28E48
		public CiacconaGalPlayer()
		{
			this.StateMachine = new StateMachine<CiacconaGalPlayer, ECiacconaGalPlayerState>(this, null);
			this.StateMachine.AddState<CiacconaGalPlayerInitializingState>(ECiacconaGalPlayerState.Initializing, null);
			this.StateMachine.AddState<CiacconaGalPlayerPausingState>(ECiacconaGalPlayerState.Pausing, null);
			this.StateMachine.AddState<CiacconaGalPlayerPlayingState>(ECiacconaGalPlayerState.Playing, null);
			this.StateMachine.AddState<CiacconaGalPlayerSkippingState>(ECiacconaGalPlayerState.Skipping, null);
			this.StateMachine.AddState<CiacconaGalPlayerChoosingState>(ECiacconaGalPlayerState.Choosing, null);
			this.StateMachine.AddState<CiacconaGalPlayerSubEndingState>(ECiacconaGalPlayerState.SubEnding, null);
			this.StateMachine.AddState<CiacconaGalPlayerProtectingState>(ECiacconaGalPlayerState.Protecting, null);
			this.StateMachine.AddState<CiacconaGalPlayerBeforeSubEndingState>(ECiacconaGalPlayerState.BeforeSubEnding, null);
			this.StateMachine.AddState<CiacconaGalPlayerChoiceProtectingState>(ECiacconaGalPlayerState.ChoiceProtecting, null);
			this.StateMachine.Start(ECiacconaGalPlayerState.Initializing);
			this.StateChangeCallbacks = new List<Action<ECiacconaGalPlayerState>>();
			this.InternalStepAnimPlayRecordMap = new Dictionary<int, bool>();
		}

		// Token: 0x0603B65F RID: 243295 RVA: 0x00E2AD00 File Offset: 0x00E28F00
		public void AddOnStateChange(Action<ECiacconaGalPlayerState> callback)
		{
			this.StateChangeCallbacks.Add(callback);
		}

		// Token: 0x0603B660 RID: 243296 RVA: 0x00E2AD10 File Offset: 0x00E28F10
		public void RemoveOnStateChange(Action<ECiacconaGalPlayerState> callback)
		{
			int num = this.StateChangeCallbacks.IndexOf(callback);
			if (num >= 0)
			{
				this.StateChangeCallbacks.RemoveAt(num);
			}
		}

		// Token: 0x0603B661 RID: 243297 RVA: 0x00E2AD3A File Offset: 0x00E28F3A
		public void SetAnimHandler(ICiacconaGalTextAnimHandler handler)
		{
			this.InternalAnimHandler = handler;
		}

		// Token: 0x0603B662 RID: 243298 RVA: 0x00E2AD44 File Offset: 0x00E28F44
		public bool HasPlayedStepAnim(int stepId)
		{
			bool flag;
			return this.InternalStepAnimPlayRecordMap.TryGetValue(stepId, out flag) && flag;
		}

		// Token: 0x0603B663 RID: 243299 RVA: 0x00E2AD64 File Offset: 0x00E28F64
		public ECiacconaGalPlayerState GetCurState()
		{
			return this.StateMachine.CurrentState.Value;
		}

		// Token: 0x0603B664 RID: 243300 RVA: 0x00E2AD84 File Offset: 0x00E28F84
		public void TrySwitchToState(ECiacconaGalPlayerState state)
		{
			this.InternalStatePendingToSwitch = (int)state;
		}

		// Token: 0x0603B665 RID: 243301 RVA: 0x00E2AD90 File Offset: 0x00E28F90
		public void SwitchState()
		{
			if (this.InternalStatePendingToSwitch == 0)
			{
				Log.Instance.Warn(ELogModule.CiacconaGal, ELogAuthor.HYF, "GalPlayer: 无状态切换请求", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (this.AnimHandler == null && this.InternalStatePendingToSwitch == 2)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.CiacconaGal;
				ELogAuthor author = ELogAuthor.HYF;
				string message = "GalPlayer: 未注册TextAnim组件, 禁止切换至播放态";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("目标状态: ", this.InternalStatePendingToSwitch);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.StateMachine.Switch((ECiacconaGalPlayerState)this.InternalStatePendingToSwitch);
		}

		// Token: 0x0603B666 RID: 243302 RVA: 0x00E2AE1D File Offset: 0x00E2901D
		public void ClearStatePendingToSwitchByState(BaseCiacconaGalPlayerState state)
		{
			if (state == null)
			{
				return;
			}
			this.InternalStatePendingToSwitch = 0;
		}

		// Token: 0x0603B667 RID: 243303 RVA: 0x00E2AE2C File Offset: 0x00E2902C
		public void TryContinue(int toStepId)
		{
			if (CiacconaGalModel.Instance.TryPushCurStepDataById(toStepId))
			{
				this.CurHandlingStepId = toStepId;
				CiacconaGalStepData stepDataById = CiacconaGalModel.Instance.GetStepDataById(toStepId);
				if (stepDataById.HasText)
				{
					this.TrySwitchToState(ECiacconaGalPlayerState.Playing);
					return;
				}
				if (stepDataById.Type == ECiacconaGalStepType.Choice)
				{
					this.TrySwitchToState(ECiacconaGalPlayerState.ChoiceProtecting);
					return;
				}
				if (stepDataById.Type == ECiacconaGalStepType.End)
				{
					this.TrySwitchToState(ECiacconaGalPlayerState.SubEnding);
					return;
				}
				this.TrySwitchToState(ECiacconaGalPlayerState.Pausing);
			}
		}

		// Token: 0x0603B668 RID: 243304 RVA: 0x00E2AE94 File Offset: 0x00E29094
		public void OnClick(int? id = null)
		{
			(this.StateMachine.GetState(this.StateMachine.CurrentState.Value) as BaseCiacconaGalPlayerState).OnClick(id);
		}

		// Token: 0x0603B669 RID: 243305 RVA: 0x00E2AECC File Offset: 0x00E290CC
		public void NotifyStateChange(ECiacconaGalPlayerState state)
		{
			foreach (Action<ECiacconaGalPlayerState> action in this.StateChangeCallbacks)
			{
				action(state);
			}
		}

		// Token: 0x0603B66A RID: 243306 RVA: 0x00E2AF20 File Offset: 0x00E29120
		public void Reset()
		{
			this.CurHandlingStepId = 0;
			this.CurHandlingChapterId = 0;
			this.InternalStatePendingToSwitch = 0;
			this.StateMachine.Switch(ECiacconaGalPlayerState.Initializing);
			this.InternalStepAnimPlayRecordMap.Clear();
		}

		// Token: 0x0603B66B RID: 243307 RVA: 0x00E2AF4F File Offset: 0x00E2914F
		public void Release()
		{
			this.Reset();
			this.StateChangeCallbacks.Clear();
		}

		// Token: 0x0603B66C RID: 243308 RVA: 0x00E2AF64 File Offset: 0x00E29164
		public void OnAnimEnd()
		{
			CiacconaGalStepData stepDataById = CiacconaGalModel.Instance.GetStepDataById(this.CurHandlingStepId);
			if (stepDataById == null)
			{
				return;
			}
			this.InternalStepAnimPlayRecordMap[stepDataById.Id] = true;
			switch (stepDataById.Type)
			{
			case ECiacconaGalStepType.Normal:
				this.TrySwitchToState(ECiacconaGalPlayerState.Protecting);
				return;
			case ECiacconaGalStepType.Choice:
				this.TrySwitchToState(ECiacconaGalPlayerState.ChoiceProtecting);
				return;
			case ECiacconaGalStepType.End:
				this.TrySwitchToState(ECiacconaGalPlayerState.BeforeSubEnding);
				return;
			default:
				return;
			}
		}

		// Token: 0x17008D02 RID: 36098
		// (get) Token: 0x0603B66D RID: 243309 RVA: 0x00E2AFCB File Offset: 0x00E291CB
		public static CiacconaGalPlayer Instance
		{
			get
			{
				if (CiacconaGalPlayer._instance == null)
				{
					CiacconaGalPlayer._instance = new CiacconaGalPlayer();
					CiacconaGalPlayer._instance.OnInit();
				}
				return CiacconaGalPlayer._instance;
			}
		}

		// Token: 0x0603B66E RID: 243310 RVA: 0x00E2AFEE File Offset: 0x00E291EE
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603B66F RID: 243311 RVA: 0x00E2AFF0 File Offset: 0x00E291F0
		public static void ResetStaticDefaultValue()
		{
			CiacconaGalPlayer instance = CiacconaGalPlayer._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			CiacconaGalPlayer._instance = null;
		}

		// Token: 0x0603B670 RID: 243312 RVA: 0x00E2B009 File Offset: 0x00E29209
		static CiacconaGalPlayer()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CiacconaGalPlayer.CreateStaticDefaultValue), new Action(CiacconaGalPlayer.ResetStaticDefaultValue));
		}

		// Token: 0x0401EF57 RID: 126807
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private readonly StateMachine<CiacconaGalPlayer, ECiacconaGalPlayerState> StateMachine;

		// Token: 0x0401EF58 RID: 126808
		private readonly List<Action<ECiacconaGalPlayerState>> StateChangeCallbacks;

		// Token: 0x0401EF59 RID: 126809
		public int CurHandlingStepId;

		// Token: 0x0401EF5A RID: 126810
		public int CurHandlingChapterId;

		// Token: 0x0401EF5B RID: 126811
		private int InternalStatePendingToSwitch;

		// Token: 0x0401EF5C RID: 126812
		[Nullable(2)]
		private ICiacconaGalTextAnimHandler InternalAnimHandler;

		// Token: 0x0401EF5D RID: 126813
		private readonly Dictionary<int, bool> InternalStepAnimPlayRecordMap;

		// Token: 0x0401EF5E RID: 126814
		[Nullable(2)]
		private static CiacconaGalPlayer _instance;
	}
}
