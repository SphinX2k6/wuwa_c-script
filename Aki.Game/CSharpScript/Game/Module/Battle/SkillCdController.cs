using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02004C3C RID: 19516
	[NullableContext(1)]
	[Nullable(0)]
	[TickController(0)]
	public class SkillCdController : ControllerBase
	{
		// Token: 0x06030B8E RID: 199566 RVA: 0x00D9677C File Offset: 0x00D9497C
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

		// Token: 0x06030B8F RID: 199567 RVA: 0x00D967E0 File Offset: 0x00D949E0
		protected override bool OnClear()
		{
			Net.Instance.UnRegister(ENotifyMessageId.PlayerSkillInfoPbNotify);
			Net.Instance.UnRegister(ENotifyMessageId.PassiveSkillNotify);
			return true;
		}

		// Token: 0x06030B90 RID: 199568 RVA: 0x00D96804 File Offset: 0x00D94A04
		[NullableContext(2)]
		private static void HandlePlayerSkillInfoPbNotify(IMessage msg, Net.CallbackStatus callbackStatus)
		{
			PlayerSkillInfoPbNotify notify = (PlayerSkillInfoPbNotify)msg;
			SkillCdModel.Instance.HandlePlayerSkillInfoPbNotify(notify);
		}

		// Token: 0x06030B91 RID: 199569 RVA: 0x00D96824 File Offset: 0x00D94A24
		[NullableContext(2)]
		private static void HandlePassiveSkillNotify(IMessage msg, Net.CallbackStatus callbackStatus)
		{
			PassiveSkillNotify notify = (PassiveSkillNotify)msg;
			SkillCdModel.Instance.HandlePassiveSkillNotify(notify);
		}

		// Token: 0x06030B92 RID: 199570 RVA: 0x00D96843 File Offset: 0x00D94A43
		protected override void OnTick(float delta)
		{
		}

		// Token: 0x06030B93 RID: 199571 RVA: 0x00D96848 File Offset: 0x00D94A48
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

		// Token: 0x06030B94 RID: 199572 RVA: 0x00D96889 File Offset: 0x00D94A89
		public bool IsPause()
		{
			return this._pauseState != 0;
		}

		// Token: 0x17006191 RID: 24977
		// (get) Token: 0x06030B95 RID: 199573 RVA: 0x00D96894 File Offset: 0x00D94A94
		public static SkillCdController Instance
		{
			get
			{
				return SkillCdController._Instance;
			}
		}

		// Token: 0x06030B96 RID: 199574 RVA: 0x00D9689B File Offset: 0x00D94A9B
		public static SkillCdController GetOrCreateInstance()
		{
			if (SkillCdController._Instance == null)
			{
				SkillCdController.CreateInstance();
			}
			return SkillCdController._Instance;
		}

		// Token: 0x06030B97 RID: 199575 RVA: 0x00D968AF File Offset: 0x00D94AAF
		public static bool CreateInstance()
		{
			if (SkillCdController._Instance != null)
			{
				return true;
			}
			SkillCdController._Instance = new SkillCdController();
			return true;
		}

		// Token: 0x06030B98 RID: 199576 RVA: 0x00D968C5 File Offset: 0x00D94AC5
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06030B99 RID: 199577 RVA: 0x00D968C7 File Offset: 0x00D94AC7
		public static void ResetStaticDefaultValue()
		{
			SkillCdController._Instance = null;
		}

		// Token: 0x06030B9A RID: 199578 RVA: 0x00D968CF File Offset: 0x00D94ACF
		static SkillCdController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SkillCdController.CreateStaticDefaultValue), new Action(SkillCdController.ResetStaticDefaultValue));
		}

		// Token: 0x04019C9F RID: 105631
		private int _pauseState;

		// Token: 0x04019CA0 RID: 105632
		[Nullable(2)]
		private static SkillCdController _Instance;

		// Token: 0x0200A875 RID: 43125
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04034099 RID: 213145
			[Nullable(new byte[]
			{
				0,
				2,
				2
			})]
			public static Action<IMessage, Net.CallbackStatus> <0>__HandlePlayerSkillInfoPbNotify;

			// Token: 0x0403409A RID: 213146
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
