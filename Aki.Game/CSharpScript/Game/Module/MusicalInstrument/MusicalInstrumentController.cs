using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using UnrealEngine;

namespace CSharpScript.Game.Module.MusicalInstrument
{
	// Token: 0x02005371 RID: 21361
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class MusicalInstrumentController : ControllerBase
	{
		// Token: 0x06036934 RID: 223540 RVA: 0x00CEC889 File Offset: 0x00CEAA89
		protected override bool OnInit()
		{
			Net.Instance.Register(ENotifyMessageId.ZitherPlayNoteNotify, new Action<IMessage, Net.CallbackStatus>(this.OnZitherPlayNoteNotify));
			return true;
		}

		// Token: 0x06036935 RID: 223541 RVA: 0x00CEC8A8 File Offset: 0x00CEAAA8
		[NullableContext(2)]
		private void OnZitherPlayNoteNotify(IMessage msg, Net.CallbackStatus status)
		{
			ZitherPlayNoteNotify zitherPlayNoteNotify = (ZitherPlayNoteNotify)msg;
			if (string.IsNullOrEmpty(zitherPlayNoteNotify.Note))
			{
				return;
			}
			long creatureDataId = MathUtils.Instance.LongToNumber(zitherPlayNoteNotify.EntityId);
			EntityHandle entity = CreatureModel.Instance.GetEntity(creatureDataId);
			AActor aactor;
			if (entity == null)
			{
				aactor = null;
			}
			else
			{
				WorldEntity entity2 = entity.Entity;
				if (entity2 == null)
				{
					aactor = null;
				}
				else
				{
					BaseActorComponent component = entity2.GetComponent<BaseActorComponent>();
					aactor = ((component != null) ? component.Owner : null);
				}
			}
			AActor aactor2 = aactor;
			if (aactor2 == null)
			{
				return;
			}
			AudioSystem.Instance.PostEvent(zitherPlayNoteNotify.Note, aactor2, new PostEventArgs?(new PostEventArgs
			{
				StopWhenOwnerDestroyed = new bool?(true)
			}));
		}

		// Token: 0x06036936 RID: 223542 RVA: 0x00CEC93C File Offset: 0x00CEAB3C
		protected override bool OnClear()
		{
			Net.Instance.UnRegister(ENotifyMessageId.ZitherPlayNoteNotify);
			this.SubControllerMap.Clear();
			this.IsEntering = false;
			this.IsExiting = false;
			return true;
		}

		// Token: 0x06036937 RID: 223543 RVA: 0x00CEC968 File Offset: 0x00CEAB68
		public UniTask Enter(MusicalInstrumentEnterParam param)
		{
			MusicalInstrumentController.<Enter>d__6 <Enter>d__;
			<Enter>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Enter>d__.<>4__this = this;
			<Enter>d__.param = param;
			<Enter>d__.<>1__state = -1;
			<Enter>d__.<>t__builder.Start<MusicalInstrumentController.<Enter>d__6>(ref <Enter>d__);
			return <Enter>d__.<>t__builder.Task;
		}

		// Token: 0x06036938 RID: 223544 RVA: 0x00CEC9B4 File Offset: 0x00CEABB4
		[NullableContext(0)]
		public UniTask<bool> Exit([Nullable(1)] MusicalInstrumentExitParam param)
		{
			MusicalInstrumentController.<Exit>d__7 <Exit>d__;
			<Exit>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<Exit>d__.<>4__this = this;
			<Exit>d__.param = param;
			<Exit>d__.<>1__state = -1;
			<Exit>d__.<>t__builder.Start<MusicalInstrumentController.<Exit>d__7>(ref <Exit>d__);
			return <Exit>d__.<>t__builder.Task;
		}

		// Token: 0x06036939 RID: 223545 RVA: 0x00CEC9FF File Offset: 0x00CEABFF
		[NullableContext(2)]
		public MusicalInstrumentSubController GetSubController(EInstrumentType type)
		{
			return this.SubControllerMap.GetValueOrDefault(type);
		}

		// Token: 0x0603693A RID: 223546 RVA: 0x00CECA10 File Offset: 0x00CEAC10
		public void SyncServerRequest(string @event)
		{
			ZitherPlayNotePush zitherPlayNotePush = ZitherPlayNotePush.Create();
			zitherPlayNotePush.Note = @event;
			Net.Instance.Send(EPushMessageId.ZitherPlayNotePush, zitherPlayNotePush);
		}

		// Token: 0x0603693B RID: 223547 RVA: 0x00CECA3A File Offset: 0x00CEAC3A
		private void MuteOtherAudio()
		{
			AudioSystem.Instance.SetState("instrument_game_mode", "mute_other_bgm", true);
		}

		// Token: 0x0603693C RID: 223548 RVA: 0x00CECA51 File Offset: 0x00CEAC51
		private void ResumeOtherAudio()
		{
			AudioSystem.Instance.SetState("instrument_game_mode", "none", true);
		}

		// Token: 0x17008351 RID: 33617
		// (get) Token: 0x0603693D RID: 223549 RVA: 0x00CECA68 File Offset: 0x00CEAC68
		public static MusicalInstrumentController Instance
		{
			get
			{
				return MusicalInstrumentController._Instance;
			}
		}

		// Token: 0x0603693E RID: 223550 RVA: 0x00CECA6F File Offset: 0x00CEAC6F
		public static MusicalInstrumentController GetOrCreateInstance()
		{
			if (MusicalInstrumentController._Instance == null)
			{
				MusicalInstrumentController.CreateInstance();
			}
			return MusicalInstrumentController._Instance;
		}

		// Token: 0x0603693F RID: 223551 RVA: 0x00CECA83 File Offset: 0x00CEAC83
		public static bool CreateInstance()
		{
			if (MusicalInstrumentController._Instance != null)
			{
				return true;
			}
			MusicalInstrumentController._Instance = new MusicalInstrumentController();
			return true;
		}

		// Token: 0x06036940 RID: 223552 RVA: 0x00CECA99 File Offset: 0x00CEAC99
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06036941 RID: 223553 RVA: 0x00CECA9B File Offset: 0x00CEAC9B
		public static void ResetStaticDefaultValue()
		{
			MusicalInstrumentController._Instance = null;
		}

		// Token: 0x06036942 RID: 223554 RVA: 0x00CECAA3 File Offset: 0x00CEACA3
		static MusicalInstrumentController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MusicalInstrumentController.CreateStaticDefaultValue), new Action(MusicalInstrumentController.ResetStaticDefaultValue));
		}

		// Token: 0x0401CD90 RID: 118160
		private readonly Dictionary<EInstrumentType, MusicalInstrumentSubController> SubControllerMap = new Dictionary<EInstrumentType, MusicalInstrumentSubController>();

		// Token: 0x0401CD91 RID: 118161
		private bool IsEntering;

		// Token: 0x0401CD92 RID: 118162
		private bool IsExiting;

		// Token: 0x0401CD93 RID: 118163
		[Nullable(2)]
		private static MusicalInstrumentController _Instance;
	}
}
