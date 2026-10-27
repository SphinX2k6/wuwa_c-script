using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02005C4D RID: 23629
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class MoraleBattleController : ControllerBase
	{
		// Token: 0x0603BB66 RID: 244582 RVA: 0x00E42818 File Offset: 0x00E40A18
		protected override bool OnInit()
		{
			Net.Instance.Register(ENotifyMessageId.MoraleInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.HandleMoraleInfoNotify));
			EventSystem.Instance.Add(EEventName.OnCloseLoadingView, new Action(this.OnCloseLoadingView));
			EventSystem.Instance.Add(EEventName.OnMoraleIndomitableLevelChanged, new Action<int, int>(this.OnMoraleIndomitableLevelChanged));
			EventSystem.Instance.Add(EEventName.CharOnBuffAddShowMoraleBuffTips, new Action<int, GameplayCue, bool, int>(this.OnBuffAddShowMoraleBuffTips));
			return true;
		}

		// Token: 0x0603BB67 RID: 244583 RVA: 0x00E42898 File Offset: 0x00E40A98
		protected override bool OnClear()
		{
			Net.Instance.UnRegister(ENotifyMessageId.MoraleInfoNotify);
			EventSystem.Instance.Remove(EEventName.OnCloseLoadingView, new Action(this.OnCloseLoadingView));
			EventSystem.Instance.Remove(EEventName.OnMoraleIndomitableLevelChanged, new Action<int, int>(this.OnMoraleIndomitableLevelChanged));
			EventSystem.Instance.Remove(EEventName.CharOnBuffAddShowMoraleBuffTips, new Action<int, GameplayCue, bool, int>(this.OnBuffAddShowMoraleBuffTips));
			return true;
		}

		// Token: 0x0603BB68 RID: 244584 RVA: 0x00E4290A File Offset: 0x00E40B0A
		protected override bool OnLeaveLevel()
		{
			this.IsReviveFromMoraleBattle = false;
			return true;
		}

		// Token: 0x0603BB69 RID: 244585 RVA: 0x00E42914 File Offset: 0x00E40B14
		[NullableContext(2)]
		private void HandleMoraleInfoNotify(IMessage msg, Net.CallbackStatus callbackStatus)
		{
			MoraleInfoNotify moraleInfoNotify = (MoraleInfoNotify)msg;
			if (moraleInfoNotify == null)
			{
				return;
			}
			if (CreatureModel.Instance.GetPlayerId() != moraleInfoNotify.PlayerId)
			{
				return;
			}
			MoraleBattleModel.Instance.HandleMoraleInfoNotify(moraleInfoNotify);
		}

		// Token: 0x0603BB6A RID: 244586 RVA: 0x00E4294A File Offset: 0x00E40B4A
		private void OnCloseLoadingView()
		{
			if (!this.IsReviveFromMoraleBattle)
			{
				return;
			}
			this.IsReviveFromMoraleBattle = false;
			if (!MoraleBattleModel.Instance.IsMoraleActive())
			{
				return;
			}
			if (MoraleBattleModel.Instance.GetLastMoraleLevel() > 1)
			{
				UiManager.Instance.OpenView(EUiViewName.MoraleLevelDecreaseView, null, null);
			}
		}

		// Token: 0x0603BB6B RID: 244587 RVA: 0x00E42988 File Offset: 0x00E40B88
		private void OnMoraleIndomitableLevelChanged(int oldLevel, int newLevel)
		{
			if (UiManager.Instance.IsViewOpen(EUiViewName.MoraleOccupiedSuccessView))
			{
				UiManager.Instance.CloseView(EUiViewName.MoraleOccupiedSuccessView, delegate(bool success)
				{
					if (success)
					{
						UiManager.Instance.OpenView(EUiViewName.MoraleOccupiedSuccessView, null, null);
					}
				});
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.MoraleOccupiedSuccessView, null, null);
		}

		// Token: 0x0603BB6C RID: 244588 RVA: 0x00E429E8 File Offset: 0x00E40BE8
		private void OnBuffAddShowMoraleBuffTips(int entityId, GameplayCue cue, bool isAdd, int handleId)
		{
			if (cue.Parameters(0) != "0")
			{
				return;
			}
			string text = (cue.ParametersLength > 1) ? cue.Parameters(1) : null;
			int num;
			if (!string.IsNullOrEmpty(text) && int.TryParse(text, out num) && num == 632400018)
			{
				MoraleBattleModel.Instance.SetIsUnlockTempMoraleMaxLevel(isAdd);
			}
		}

		// Token: 0x0603BB6D RID: 244589 RVA: 0x00E42A45 File Offset: 0x00E40C45
		public void SetReviveFromMoraleBattle(bool isReviveFromMoraleBattle)
		{
			this.IsReviveFromMoraleBattle = isReviveFromMoraleBattle;
		}

		// Token: 0x17008DBA RID: 36282
		// (get) Token: 0x0603BB6E RID: 244590 RVA: 0x00E42A4E File Offset: 0x00E40C4E
		public static MoraleBattleController Instance
		{
			get
			{
				return MoraleBattleController._Instance;
			}
		}

		// Token: 0x0603BB6F RID: 244591 RVA: 0x00E42A55 File Offset: 0x00E40C55
		public static MoraleBattleController GetOrCreateInstance()
		{
			if (MoraleBattleController._Instance == null)
			{
				MoraleBattleController.CreateInstance();
			}
			return MoraleBattleController._Instance;
		}

		// Token: 0x0603BB70 RID: 244592 RVA: 0x00E42A69 File Offset: 0x00E40C69
		public static bool CreateInstance()
		{
			if (MoraleBattleController._Instance != null)
			{
				return true;
			}
			MoraleBattleController._Instance = new MoraleBattleController();
			return true;
		}

		// Token: 0x0603BB71 RID: 244593 RVA: 0x00E42A7F File Offset: 0x00E40C7F
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603BB72 RID: 244594 RVA: 0x00E42A81 File Offset: 0x00E40C81
		public static void ResetStaticDefaultValue()
		{
			MoraleBattleController._Instance = null;
		}

		// Token: 0x0603BB73 RID: 244595 RVA: 0x00E42A89 File Offset: 0x00E40C89
		static MoraleBattleController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MoraleBattleController.CreateStaticDefaultValue), new Action(MoraleBattleController.ResetStaticDefaultValue));
		}

		// Token: 0x0401F169 RID: 127337
		private const string MORALE_CHARACTER_BUFF_TIPS_PARAM = "0";

		// Token: 0x0401F16A RID: 127338
		private const int EXTRA_TEMP_MORALE_MAX_LEVEL_BUFF_ID = 632400018;

		// Token: 0x0401F16B RID: 127339
		private bool IsReviveFromMoraleBattle;

		// Token: 0x0401F16C RID: 127340
		[Nullable(2)]
		private static MoraleBattleController _Instance;
	}
}
