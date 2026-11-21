using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;
using UnrealEngine;

namespace CSharpScript.Game.World.Controller
{
	// Token: 0x02003464 RID: 13412
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class ServerGmController : ControllerBase
	{
		// Token: 0x060223C3 RID: 140227 RVA: 0x009B2282 File Offset: 0x009B0482
		protected override bool OnInit()
		{
			Net.Instance.Register(ENotifyMessageId.ServerCommandNotify, new Action<IMessage, Net.CallbackStatus>(this.OnServerCommandNotify));
			return true;
		}

		// Token: 0x060223C4 RID: 140228 RVA: 0x009B22A1 File Offset: 0x009B04A1
		protected override bool OnClear()
		{
			Net.Instance.UnRegister(ENotifyMessageId.ServerCommandNotify);
			return true;
		}

		// Token: 0x060223C5 RID: 140229 RVA: 0x009B22B4 File Offset: 0x009B04B4
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

		// Token: 0x170047FD RID: 18429
		// (get) Token: 0x060223C6 RID: 140230 RVA: 0x009B23D3 File Offset: 0x009B05D3
		public static ServerGmController Instance
		{
			get
			{
				return ServerGmController._Instance;
			}
		}

		// Token: 0x060223C7 RID: 140231 RVA: 0x009B23DA File Offset: 0x009B05DA
		public static ServerGmController GetOrCreateInstance()
		{
			if (ServerGmController._Instance == null)
			{
				ServerGmController.CreateInstance();
			}
			return ServerGmController._Instance;
		}

		// Token: 0x060223C8 RID: 140232 RVA: 0x009B23EE File Offset: 0x009B05EE
		public static bool CreateInstance()
		{
			if (ServerGmController._Instance != null)
			{
				return true;
			}
			ServerGmController._Instance = new ServerGmController();
			return true;
		}

		// Token: 0x060223C9 RID: 140233 RVA: 0x009B2404 File Offset: 0x009B0604
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060223CA RID: 140234 RVA: 0x009B2406 File Offset: 0x009B0606
		public static void ResetStaticDefaultValue()
		{
			ServerGmController._Instance = null;
		}

		// Token: 0x060223CB RID: 140235 RVA: 0x009B240E File Offset: 0x009B060E
		static ServerGmController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ServerGmController.CreateStaticDefaultValue), new Action(ServerGmController.ResetStaticDefaultValue));
		}

		// Token: 0x04012D9B RID: 77211
		public bool AnimalDebug;

		// Token: 0x04012D9C RID: 77212
		public bool MingzhongzhiguiDebug;

		// Token: 0x04012D9D RID: 77213
		public bool ShowConfigVersion = true;

		// Token: 0x04012D9E RID: 77214
		[Nullable(2)]
		private static ServerGmController _Instance;
	}
}
