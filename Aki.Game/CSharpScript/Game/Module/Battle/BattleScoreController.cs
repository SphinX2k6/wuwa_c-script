using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02005C59 RID: 23641
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class BattleScoreController : ControllerBase
	{
		// Token: 0x0603BC24 RID: 244772 RVA: 0x00E46058 File Offset: 0x00E44258
		protected override bool OnInit()
		{
			Net instance = Net.Instance;
			ENotifyMessageId id = ENotifyMessageId.BattleScoreNotify;
			Action<IMessage, Net.CallbackStatus> callback;
			if ((callback = BattleScoreController.<>O.<0>__HandleBattleScoreNotify) == null)
			{
				callback = (BattleScoreController.<>O.<0>__HandleBattleScoreNotify = new Action<IMessage, Net.CallbackStatus>(BattleScoreController.HandleBattleScoreNotify));
			}
			instance.Register(id, callback);
			Net instance2 = Net.Instance;
			ENotifyMessageId id2 = ENotifyMessageId.BattleScoreEnableNotify;
			Action<IMessage, Net.CallbackStatus> callback2;
			if ((callback2 = BattleScoreController.<>O.<1>__HandleBattleScoreEnableNotify) == null)
			{
				callback2 = (BattleScoreController.<>O.<1>__HandleBattleScoreEnableNotify = new Action<IMessage, Net.CallbackStatus>(BattleScoreController.HandleBattleScoreEnableNotify));
			}
			instance2.Register(id2, callback2);
			return true;
		}

		// Token: 0x0603BC25 RID: 244773 RVA: 0x00E460BC File Offset: 0x00E442BC
		protected override bool OnClear()
		{
			Net.Instance.UnRegister(ENotifyMessageId.BattleScoreNotify);
			Net.Instance.UnRegister(ENotifyMessageId.BattleScoreEnableNotify);
			return true;
		}

		// Token: 0x0603BC26 RID: 244774 RVA: 0x00E460E0 File Offset: 0x00E442E0
		[NullableContext(2)]
		private static void HandleBattleScoreNotify(IMessage msg, Net.CallbackStatus callbackStatus)
		{
			BattleScoreNotify notify = (BattleScoreNotify)msg;
			BattleScoreModel.Instance.HandleBattleScoreNotify(notify);
		}

		// Token: 0x0603BC27 RID: 244775 RVA: 0x00E46100 File Offset: 0x00E44300
		[NullableContext(2)]
		private static void HandleBattleScoreEnableNotify(IMessage msg, Net.CallbackStatus callbackStatus)
		{
			BattleScoreEnableNotify notify = (BattleScoreEnableNotify)msg;
			BattleScoreModel.Instance.HandleBattleScoreEnableNotify(notify);
		}

		// Token: 0x17008DBD RID: 36285
		// (get) Token: 0x0603BC28 RID: 244776 RVA: 0x00E4611F File Offset: 0x00E4431F
		public static BattleScoreController Instance
		{
			get
			{
				return BattleScoreController._Instance;
			}
		}

		// Token: 0x0603BC29 RID: 244777 RVA: 0x00E46126 File Offset: 0x00E44326
		public static BattleScoreController GetOrCreateInstance()
		{
			if (BattleScoreController._Instance == null)
			{
				BattleScoreController.CreateInstance();
			}
			return BattleScoreController._Instance;
		}

		// Token: 0x0603BC2A RID: 244778 RVA: 0x00E4613A File Offset: 0x00E4433A
		public static bool CreateInstance()
		{
			if (BattleScoreController._Instance != null)
			{
				return true;
			}
			BattleScoreController._Instance = new BattleScoreController();
			return true;
		}

		// Token: 0x0603BC2B RID: 244779 RVA: 0x00E46150 File Offset: 0x00E44350
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603BC2C RID: 244780 RVA: 0x00E46152 File Offset: 0x00E44352
		public static void ResetStaticDefaultValue()
		{
			BattleScoreController._Instance = null;
		}

		// Token: 0x0603BC2D RID: 244781 RVA: 0x00E4615A File Offset: 0x00E4435A
		static BattleScoreController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(BattleScoreController.CreateStaticDefaultValue), new Action(BattleScoreController.ResetStaticDefaultValue));
		}

		// Token: 0x0401F1E5 RID: 127461
		[Nullable(2)]
		private static BattleScoreController _Instance;

		// Token: 0x0200BE6E RID: 48750
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040396D6 RID: 235222
			[Nullable(new byte[]
			{
				0,
				2,
				2
			})]
			public static Action<IMessage, Net.CallbackStatus> <0>__HandleBattleScoreNotify;

			// Token: 0x040396D7 RID: 235223
			[Nullable(new byte[]
			{
				0,
				2,
				2
			})]
			public static Action<IMessage, Net.CallbackStatus> <1>__HandleBattleScoreEnableNotify;
		}
	}
}
