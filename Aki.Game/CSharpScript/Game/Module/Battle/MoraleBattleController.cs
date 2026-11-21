using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02004C2D RID: 19501
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class MoraleBattleController : ControllerBase
	{
		// Token: 0x06030AB1 RID: 199345 RVA: 0x00D92BE4 File Offset: 0x00D90DE4
		protected override bool OnInit()
		{
			Net.Instance.Register(ENotifyMessageId.MoraleInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.HandleMoraleInfoNotify));
			EventSystem.Instance.Add(EEventName.OnCloseLoadingView, new Action(this.OnCloseLoadingView));
			EventSystem.Instance.Add(EEventName.OnMoraleIndomitableLevelChanged, new Action<int, int>(this.OnMoraleIndomitableLevelChanged));
			EventSystem.Instance.Add(EEventName.CharOnBuffAddShowMoraleBuffTips, new Action<int, GameplayCue, bool, int>(this.OnBuffAddShowMoraleBuffTips));
			return true;
		}

		// Token: 0x06030AB2 RID: 199346 RVA: 0x00D92C64 File Offset: 0x00D90E64
		protected override bool OnClear()
		{
			Net.Instance.UnRegister(ENotifyMessageId.MoraleInfoNotify);
			EventSystem.Instance.Remove(EEventName.OnCloseLoadingView, new Action(this.OnCloseLoadingView));
			EventSystem.Instance.Remove(EEventName.OnMoraleIndomitableLevelChanged, new Action<int, int>(this.OnMoraleIndomitableLevelChanged));
			EventSystem.Instance.Remove(EEventName.CharOnBuffAddShowMoraleBuffTips, new Action<int, GameplayCue, bool, int>(this.OnBuffAddShowMoraleBuffTips));
			return true;
		}

		// Token: 0x06030AB3 RID: 199347 RVA: 0x00D92CD6 File Offset: 0x00D90ED6
		protected override bool OnLeaveLevel()
		{
			this.IsReviveFromMoraleBattle = false;
			return true;
		}

		// Token: 0x06030AB4 RID: 199348 RVA: 0x00D92CE0 File Offset: 0x00D90EE0
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

		// Token: 0x06030AB5 RID: 199349 RVA: 0x00D92D16 File Offset: 0x00D90F16
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

		// Token: 0x06030AB6 RID: 199350 RVA: 0x00D92D54 File Offset: 0x00D90F54
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

		// Token: 0x06030AB7 RID: 199351 RVA: 0x00D92DB4 File Offset: 0x00D90FB4
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

		// Token: 0x06030AB8 RID: 199352 RVA: 0x00D92E11 File Offset: 0x00D91011
		public void SetReviveFromMoraleBattle(bool isReviveFromMoraleBattle)
		{
			this.IsReviveFromMoraleBattle = isReviveFromMoraleBattle;
		}

		// Token: 0x1700618C RID: 24972
		// (get) Token: 0x06030AB9 RID: 199353 RVA: 0x00D92E1A File Offset: 0x00D9101A
		public static MoraleBattleController Instance
		{
			get
			{
				return MoraleBattleController._Instance;
			}
		}

		// Token: 0x06030ABA RID: 199354 RVA: 0x00D92E21 File Offset: 0x00D91021
		public static MoraleBattleController GetOrCreateInstance()
		{
			if (MoraleBattleController._Instance == null)
			{
				MoraleBattleController.CreateInstance();
			}
			return MoraleBattleController._Instance;
		}

		// Token: 0x06030ABB RID: 199355 RVA: 0x00D92E35 File Offset: 0x00D91035
		public static bool CreateInstance()
		{
			if (MoraleBattleController._Instance != null)
			{
				return true;
			}
			MoraleBattleController._Instance = new MoraleBattleController();
			return true;
		}

		// Token: 0x06030ABC RID: 199356 RVA: 0x00D92E4B File Offset: 0x00D9104B
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06030ABD RID: 199357 RVA: 0x00D92E4D File Offset: 0x00D9104D
		public static void ResetStaticDefaultValue()
		{
			MoraleBattleController._Instance = null;
		}

		// Token: 0x06030ABE RID: 199358 RVA: 0x00D92E55 File Offset: 0x00D91055
		static MoraleBattleController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MoraleBattleController.CreateStaticDefaultValue), new Action(MoraleBattleController.ResetStaticDefaultValue));
		}

		// Token: 0x04019C1A RID: 105498
		private const string MORALE_CHARACTER_BUFF_TIPS_PARAM = "0";

		// Token: 0x04019C1B RID: 105499
		private const int EXTRA_TEMP_MORALE_MAX_LEVEL_BUFF_ID = 632400018;

		// Token: 0x04019C1C RID: 105500
		private bool IsReviveFromMoraleBattle;

		// Token: 0x04019C1D RID: 105501
		[Nullable(2)]
		private static MoraleBattleController _Instance;
	}
}
