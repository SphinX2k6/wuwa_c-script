using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02004C39 RID: 19513
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class BattleScoreController : ControllerBase
	{
		// Token: 0x06030B6F RID: 199535 RVA: 0x00D96438 File Offset: 0x00D94638
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

		// Token: 0x06030B70 RID: 199536 RVA: 0x00D9649C File Offset: 0x00D9469C
		protected override bool OnClear()
		{
			Net.Instance.UnRegister(ENotifyMessageId.BattleScoreNotify);
			Net.Instance.UnRegister(ENotifyMessageId.BattleScoreEnableNotify);
			return true;
		}

		// Token: 0x06030B71 RID: 199537 RVA: 0x00D964C0 File Offset: 0x00D946C0
		[NullableContext(2)]
		private static void HandleBattleScoreNotify(IMessage msg, Net.CallbackStatus callbackStatus)
		{
			BattleScoreNotify notify = (BattleScoreNotify)msg;
			BattleScoreModel.Instance.HandleBattleScoreNotify(notify);
		}

		// Token: 0x06030B72 RID: 199538 RVA: 0x00D964E0 File Offset: 0x00D946E0
		[NullableContext(2)]
		private static void HandleBattleScoreEnableNotify(IMessage msg, Net.CallbackStatus callbackStatus)
		{
			BattleScoreEnableNotify notify = (BattleScoreEnableNotify)msg;
			BattleScoreModel.Instance.HandleBattleScoreEnableNotify(notify);
		}

		// Token: 0x1700618F RID: 24975
		// (get) Token: 0x06030B73 RID: 199539 RVA: 0x00D964FF File Offset: 0x00D946FF
		public static BattleScoreController Instance
		{
			get
			{
				return BattleScoreController._Instance;
			}
		}

		// Token: 0x06030B74 RID: 199540 RVA: 0x00D96506 File Offset: 0x00D94706
		public static BattleScoreController GetOrCreateInstance()
		{
			if (BattleScoreController._Instance == null)
			{
				BattleScoreController.CreateInstance();
			}
			return BattleScoreController._Instance;
		}

		// Token: 0x06030B75 RID: 199541 RVA: 0x00D9651A File Offset: 0x00D9471A
		public static bool CreateInstance()
		{
			if (BattleScoreController._Instance != null)
			{
				return true;
			}
			BattleScoreController._Instance = new BattleScoreController();
			return true;
		}

		// Token: 0x06030B76 RID: 199542 RVA: 0x00D96530 File Offset: 0x00D94730
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06030B77 RID: 199543 RVA: 0x00D96532 File Offset: 0x00D94732
		public static void ResetStaticDefaultValue()
		{
			BattleScoreController._Instance = null;
		}

		// Token: 0x06030B78 RID: 199544 RVA: 0x00D9653A File Offset: 0x00D9473A
		static BattleScoreController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(BattleScoreController.CreateStaticDefaultValue), new Action(BattleScoreController.ResetStaticDefaultValue));
		}

		// Token: 0x04019C96 RID: 105622
		[Nullable(2)]
		private static BattleScoreController _Instance;

		// Token: 0x0200A874 RID: 43124
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04034097 RID: 213143
			[Nullable(new byte[]
			{
				0,
				2,
				2
			})]
			public static Action<IMessage, Net.CallbackStatus> <0>__HandleBattleScoreNotify;

			// Token: 0x04034098 RID: 213144
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
