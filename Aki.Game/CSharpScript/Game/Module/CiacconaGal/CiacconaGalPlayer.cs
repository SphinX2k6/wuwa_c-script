using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02004BA9 RID: 19369
	[NullableContext(1)]
	[Nullable(0)]
	public class CiacconaGalPlayer : Singleton
	{
		// Token: 0x170060D2 RID: 24786
		// (get) Token: 0x060305A8 RID: 198056 RVA: 0x00D7AF2C File Offset: 0x00D7912C
		public ECiacconaGalPlayerState StatePendingToSwitch
		{
			get
			{
				return (ECiacconaGalPlayerState)this.InternalStatePendingToSwitch;
			}
		}

		// Token: 0x170060D3 RID: 24787
		// (get) Token: 0x060305A9 RID: 198057 RVA: 0x00D7AF34 File Offset: 0x00D79134
		[Nullable(2)]
		public ICiacconaGalTextAnimHandler AnimHandler
		{
			[NullableContext(2)]
			get
			{
				return this.InternalAnimHandler;
			}
		}

		// Token: 0x060305AA RID: 198058 RVA: 0x00D7AF3C File Offset: 0x00D7913C
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

		// Token: 0x060305AB RID: 198059 RVA: 0x00D7AFF4 File Offset: 0x00D791F4
		public void AddOnStateChange(Action<ECiacconaGalPlayerState> callback)
		{
			this.StateChangeCallbacks.Add(callback);
		}

		// Token: 0x060305AC RID: 198060 RVA: 0x00D7B004 File Offset: 0x00D79204
		public void RemoveOnStateChange(Action<ECiacconaGalPlayerState> callback)
		{
			int num = this.StateChangeCallbacks.IndexOf(callback);
			if (num >= 0)
			{
				this.StateChangeCallbacks.RemoveAt(num);
			}
		}

		// Token: 0x060305AD RID: 198061 RVA: 0x00D7B02E File Offset: 0x00D7922E
		public void SetAnimHandler(ICiacconaGalTextAnimHandler handler)
		{
			this.InternalAnimHandler = handler;
		}

		// Token: 0x060305AE RID: 198062 RVA: 0x00D7B038 File Offset: 0x00D79238
		public bool HasPlayedStepAnim(int stepId)
		{
			bool flag;
			return this.InternalStepAnimPlayRecordMap.TryGetValue(stepId, out flag) && flag;
		}

		// Token: 0x060305AF RID: 198063 RVA: 0x00D7B058 File Offset: 0x00D79258
		public ECiacconaGalPlayerState GetCurState()
		{
			return this.StateMachine.CurrentState.Value;
		}

		// Token: 0x060305B0 RID: 198064 RVA: 0x00D7B078 File Offset: 0x00D79278
		public void TrySwitchToState(ECiacconaGalPlayerState state)
		{
			this.InternalStatePendingToSwitch = (int)state;
		}

		// Token: 0x060305B1 RID: 198065 RVA: 0x00D7B084 File Offset: 0x00D79284
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

		// Token: 0x060305B2 RID: 198066 RVA: 0x00D7B111 File Offset: 0x00D79311
		public void ClearStatePendingToSwitchByState(BaseCiacconaGalPlayerState state)
		{
			if (state == null)
			{
				return;
			}
			this.InternalStatePendingToSwitch = 0;
		}

		// Token: 0x060305B3 RID: 198067 RVA: 0x00D7B120 File Offset: 0x00D79320
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

		// Token: 0x060305B4 RID: 198068 RVA: 0x00D7B188 File Offset: 0x00D79388
		public void OnClick(int? id = null)
		{
			(this.StateMachine.GetState(this.StateMachine.CurrentState.Value) as BaseCiacconaGalPlayerState).OnClick(id);
		}

		// Token: 0x060305B5 RID: 198069 RVA: 0x00D7B1C0 File Offset: 0x00D793C0
		public void NotifyStateChange(ECiacconaGalPlayerState state)
		{
			foreach (Action<ECiacconaGalPlayerState> action in this.StateChangeCallbacks)
			{
				action(state);
			}
		}

		// Token: 0x060305B6 RID: 198070 RVA: 0x00D7B214 File Offset: 0x00D79414
		public void Reset()
		{
			this.CurHandlingStepId = 0;
			this.CurHandlingChapterId = 0;
			this.InternalStatePendingToSwitch = 0;
			this.StateMachine.Switch(ECiacconaGalPlayerState.Initializing);
			this.InternalStepAnimPlayRecordMap.Clear();
		}

		// Token: 0x060305B7 RID: 198071 RVA: 0x00D7B243 File Offset: 0x00D79443
		public void Release()
		{
			this.Reset();
			this.StateChangeCallbacks.Clear();
		}

		// Token: 0x060305B8 RID: 198072 RVA: 0x00D7B258 File Offset: 0x00D79458
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

		// Token: 0x170060D4 RID: 24788
		// (get) Token: 0x060305B9 RID: 198073 RVA: 0x00D7B2BF File Offset: 0x00D794BF
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

		// Token: 0x060305BA RID: 198074 RVA: 0x00D7B2E2 File Offset: 0x00D794E2
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060305BB RID: 198075 RVA: 0x00D7B2E4 File Offset: 0x00D794E4
		public static void ResetStaticDefaultValue()
		{
			CiacconaGalPlayer instance = CiacconaGalPlayer._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			CiacconaGalPlayer._instance = null;
		}

		// Token: 0x060305BC RID: 198076 RVA: 0x00D7B2FD File Offset: 0x00D794FD
		static CiacconaGalPlayer()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CiacconaGalPlayer.CreateStaticDefaultValue), new Action(CiacconaGalPlayer.ResetStaticDefaultValue));
		}

		// Token: 0x04019A08 RID: 104968
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private readonly StateMachine<CiacconaGalPlayer, ECiacconaGalPlayerState> StateMachine;

		// Token: 0x04019A09 RID: 104969
		private readonly List<Action<ECiacconaGalPlayerState>> StateChangeCallbacks;

		// Token: 0x04019A0A RID: 104970
		public int CurHandlingStepId;

		// Token: 0x04019A0B RID: 104971
		public int CurHandlingChapterId;

		// Token: 0x04019A0C RID: 104972
		private int InternalStatePendingToSwitch;

		// Token: 0x04019A0D RID: 104973
		[Nullable(2)]
		private ICiacconaGalTextAnimHandler InternalAnimHandler;

		// Token: 0x04019A0E RID: 104974
		private readonly Dictionary<int, bool> InternalStepAnimPlayRecordMap;

		// Token: 0x04019A0F RID: 104975
		[Nullable(2)]
		private static CiacconaGalPlayer _instance;
	}
}
