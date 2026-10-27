using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;
using UnrealEngine;

namespace CSharpScript.Game.World.Controller
{
	// Token: 0x0200453C RID: 17724
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class ServerGmController : ControllerBase
	{
		// Token: 0x0602DCE1 RID: 187617 RVA: 0x00A86A5A File Offset: 0x00A84C5A
		protected override bool OnInit()
		{
			Net.Instance.Register(ENotifyMessageId.ServerCommandNotify, new Action<IMessage, Net.CallbackStatus>(this.OnServerCommandNotify));
			return true;
		}

		// Token: 0x0602DCE2 RID: 187618 RVA: 0x00A86A79 File Offset: 0x00A84C79
		protected override bool OnClear()
		{
			Net.Instance.UnRegister(ENotifyMessageId.ServerCommandNotify);
			return true;
		}

		// Token: 0x0602DCE3 RID: 187619 RVA: 0x00A86A8C File Offset: 0x00A84C8C
		[NullableContext(2)]
		protected void OnServerCommandNotify(IMessage msg, Net.CallbackStatus status)
		{
			ServerCommandNotify serverCommandNotify = (ServerCommandNotify)msg;
			if (serverCommandNotify.Cmd.StartsWith("GM "))
			{
				EventSystem.Instance.Emit<string>(EEventName.RunGm, serverCommandNotify.Cmd.Substring(3));
				return;
			}
			if (serverCommandNotify.Cmd.StartsWith("AnimalDebug"))
			{
				this.AnimalDebug = true;
			}
			else if (serverCommandNotify.Cmd.StartsWith("MingzhongzhiguiDebug"))
			{
				this.MingzhongzhiguiDebug = true;
			}
			else if (serverCommandNotify.Cmd.StartsWith("AnimErrorCheck"))
			{
				Log.Instance.Info(ELogModule.Test, ELogAuthor.LCZ, "AnimErrorCheck Begin", default(ReadOnlySpan<ValueTuple<string, object>>));
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "a.CheckBoneNan true", null);
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "a.PrintSkeletalMeshText true", null);
				TimerSystem.Instance.Delay(delegate(float _)
				{
					UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "a.CheckBoneNan false", null);
					UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "a.PrintSkeletalMeshText false", null);
					Log.Instance.Info(ELogModule.Test, ELogAuthor.LCZ, "AnimErrorCheck End", default(ReadOnlySpan<ValueTuple<string, object>>));
				}, 3000f, null, null, true, 1f);
			}
			if (serverCommandNotify.Cmd == "DumpLoadingAssets")
			{
				ResourceSystem.Instance.DebugDumpLoadingAssets();
			}
		}

		// Token: 0x17007546 RID: 30022
		// (get) Token: 0x0602DCE4 RID: 187620 RVA: 0x00A86BAB File Offset: 0x00A84DAB
		public static ServerGmController Instance
		{
			get
			{
				return ServerGmController._Instance;
			}
		}

		// Token: 0x0602DCE5 RID: 187621 RVA: 0x00A86BB2 File Offset: 0x00A84DB2
		public static ServerGmController GetOrCreateInstance()
		{
			if (ServerGmController._Instance == null)
			{
				ServerGmController.CreateInstance();
			}
			return ServerGmController._Instance;
		}

		// Token: 0x0602DCE6 RID: 187622 RVA: 0x00A86BC6 File Offset: 0x00A84DC6
		public static bool CreateInstance()
		{
			if (ServerGmController._Instance != null)
			{
				return true;
			}
			ServerGmController._Instance = new ServerGmController();
			return true;
		}

		// Token: 0x0602DCE7 RID: 187623 RVA: 0x00A86BDC File Offset: 0x00A84DDC
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602DCE8 RID: 187624 RVA: 0x00A86BDE File Offset: 0x00A84DDE
		public static void ResetStaticDefaultValue()
		{
			ServerGmController._Instance = null;
		}

		// Token: 0x0602DCE9 RID: 187625 RVA: 0x00A86BE6 File Offset: 0x00A84DE6
		static ServerGmController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ServerGmController.CreateStaticDefaultValue), new Action(ServerGmController.ResetStaticDefaultValue));
		}

		// Token: 0x04018761 RID: 100193
		public bool AnimalDebug;

		// Token: 0x04018762 RID: 100194
		public bool MingzhongzhiguiDebug;

		// Token: 0x04018763 RID: 100195
		public bool ShowConfigVersion = true;

		// Token: 0x04018764 RID: 100196
		[Nullable(2)]
		private static ServerGmController _Instance;
	}
}
