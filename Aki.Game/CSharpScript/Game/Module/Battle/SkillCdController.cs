using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02005C5C RID: 23644
	[NullableContext(1)]
	[Nullable(0)]
	[TickController(0)]
	public class SkillCdController : ControllerBase
	{
		// Token: 0x0603BC43 RID: 244803 RVA: 0x00E4639C File Offset: 0x00E4459C
		protected override bool OnInit()
		{
			Net instance = Net.Instance;
			ENotifyMessageId id = ENotifyMessageId.PlayerSkillInfoPbNotify;
			Action<IMessage, Net.CallbackStatus> callback;
			if ((callback = SkillCdController.<>O.<0>__HandlePlayerSkillInfoPbNotify) == null)
			{
				callback = (SkillCdController.<>O.<0>__HandlePlayerSkillInfoPbNotify = new Action<IMessage, Net.CallbackStatus>(SkillCdController.HandlePlayerSkillInfoPbNotify));
			}
			instance.Register(id, callback);
			Net instance2 = Net.Instance;
			ENotifyMessageId id2 = ENotifyMessageId.PassiveSkillNotify;
			Action<IMessage, Net.CallbackStatus> callback2;
			if ((callback2 = SkillCdController.<>O.<1>__HandlePassiveSkillNotify) == null)
			{
				callback2 = (SkillCdController.<>O.<1>__HandlePassiveSkillNotify = new Action<IMessage, Net.CallbackStatus>(SkillCdController.HandlePassiveSkillNotify));
			}
			instance2.Register(id2, callback2);
			return true;
		}

		// Token: 0x0603BC44 RID: 244804 RVA: 0x00E46400 File Offset: 0x00E44600
		protected override bool OnClear()
		{
			Net.Instance.UnRegister(ENotifyMessageId.PlayerSkillInfoPbNotify);
			Net.Instance.UnRegister(ENotifyMessageId.PassiveSkillNotify);
			return true;
		}

		// Token: 0x0603BC45 RID: 244805 RVA: 0x00E46424 File Offset: 0x00E44624
		[NullableContext(2)]
		private static void HandlePlayerSkillInfoPbNotify(IMessage msg, Net.CallbackStatus callbackStatus)
		{
			PlayerSkillInfoPbNotify notify = (PlayerSkillInfoPbNotify)msg;
			SkillCdModel.Instance.HandlePlayerSkillInfoPbNotify(notify);
		}

		// Token: 0x0603BC46 RID: 244806 RVA: 0x00E46444 File Offset: 0x00E44644
		[NullableContext(2)]
		private static void HandlePassiveSkillNotify(IMessage msg, Net.CallbackStatus callbackStatus)
		{
			PassiveSkillNotify notify = (PassiveSkillNotify)msg;
			SkillCdModel.Instance.HandlePassiveSkillNotify(notify);
		}

		// Token: 0x0603BC47 RID: 244807 RVA: 0x00E46463 File Offset: 0x00E44663
		protected override void OnTick(float delta)
		{
		}

		// Token: 0x0603BC48 RID: 244808 RVA: 0x00E46468 File Offset: 0x00E44668
		public void Pause(ESkillCdPauseReason reason, bool isPause)
		{
			bool flag = this.IsPause();
			this._pauseState = VisibleStateUtil.SetVisible(this._pauseState, !isPause, (int)reason);
			bool flag2 = this.IsPause();
			if (flag != flag2)
			{
				EventSystem.Instance.Emit<bool>(EEventName.CharSkillCdPauseStateChanged, flag2);
			}
		}

		// Token: 0x0603BC49 RID: 244809 RVA: 0x00E464A9 File Offset: 0x00E446A9
		public bool IsPause()
		{
			return this._pauseState != 0;
		}

		// Token: 0x17008DBF RID: 36287
		// (get) Token: 0x0603BC4A RID: 244810 RVA: 0x00E464B4 File Offset: 0x00E446B4
		public static SkillCdController Instance
		{
			get
			{
				return SkillCdController._Instance;
			}
		}

		// Token: 0x0603BC4B RID: 244811 RVA: 0x00E464BB File Offset: 0x00E446BB
		public static SkillCdController GetOrCreateInstance()
		{
			if (SkillCdController._Instance == null)
			{
				SkillCdController.CreateInstance();
			}
			return SkillCdController._Instance;
		}

		// Token: 0x0603BC4C RID: 244812 RVA: 0x00E464CF File Offset: 0x00E446CF
		public static bool CreateInstance()
		{
			if (SkillCdController._Instance != null)
			{
				return true;
			}
			SkillCdController._Instance = new SkillCdController();
			return true;
		}

		// Token: 0x0603BC4D RID: 244813 RVA: 0x00E464E5 File Offset: 0x00E446E5
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603BC4E RID: 244814 RVA: 0x00E464E7 File Offset: 0x00E446E7
		public static void ResetStaticDefaultValue()
		{
			SkillCdController._Instance = null;
		}

		// Token: 0x0603BC4F RID: 244815 RVA: 0x00E464EF File Offset: 0x00E446EF
		static SkillCdController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SkillCdController.CreateStaticDefaultValue), new Action(SkillCdController.ResetStaticDefaultValue));
		}

		// Token: 0x0401F1EE RID: 127470
		private int _pauseState;

		// Token: 0x0401F1EF RID: 127471
		[Nullable(2)]
		private static SkillCdController _Instance;

		// Token: 0x0200BE6F RID: 48751
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040396D8 RID: 235224
			[Nullable(new byte[]
			{
				0,
				2,
				2
			})]
			public static Action<IMessage, Net.CallbackStatus> <0>__HandlePlayerSkillInfoPbNotify;

			// Token: 0x040396D9 RID: 235225
			[Nullable(new byte[]
			{
				0,
				2,
				2
			})]
			public static Action<IMessage, Net.CallbackStatus> <1>__HandlePassiveSkillNotify;
		}
	}
}
