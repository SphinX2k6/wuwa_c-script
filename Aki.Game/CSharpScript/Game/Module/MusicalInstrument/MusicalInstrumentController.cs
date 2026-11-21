using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Action;
using CSharpScript.Game.Common;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.FlatBuffers;
using Google.Protobuf;
using UnrealEngine;

namespace CSharpScript.Game.Module.MusicalInstrument
{
	// Token: 0x02004354 RID: 17236
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class MusicalInstrumentController : ControllerBase
	{
		// Token: 0x0602B87A RID: 178298 RVA: 0x00C3B715 File Offset: 0x00C39915
		protected override bool OnInit()
		{
			Net.Instance.Register(ENotifyMessageId.ZitherPlayNoteNotify, new Action<IMessage, Net.CallbackStatus>(this.OnZitherPlayNoteNotify));
			return true;
		}

		// Token: 0x0602B87B RID: 178299 RVA: 0x00C3B734 File Offset: 0x00C39934
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

		// Token: 0x0602B87C RID: 178300 RVA: 0x00C3B7C8 File Offset: 0x00C399C8
		protected override bool OnClear()
		{
			Net.Instance.UnRegister(ENotifyMessageId.ZitherPlayNoteNotify);
			this.SubControllerMap.Clear();
			this.IsEntering = false;
			this.IsExiting = false;
			return true;
		}

		// Token: 0x0602B87D RID: 178301 RVA: 0x00C3B7F4 File Offset: 0x00C399F4
		[NullableContext(2)]
		private MusicalInstrumentQteData GetQteData(int qteId)
		{
			Aki.TDConfigMgr.Action.IInstrumentQteConfig instrumentQteConfig = this.QteConfigFbLru.Get(qteId);
			if (instrumentQteConfig == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.MusicalInstrument;
				ELogAuthor author = ELogAuthor.CB;
				string message = "乐器玩法:读取乐器Qte配置FB数据失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("QteId", qteId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			List<List<int>> qteSequence = instrumentQteConfig.QteSequence;
			Aki.TDConfigMgr.Action.EInstrumentType instrumentType = instrumentQteConfig.InstrumentType;
			string preludeAsset = instrumentQteConfig.PreludeAsset;
			List<MusicalInstrumentQteItemData> list = new List<MusicalInstrumentQteItemData>();
			foreach (List<int> list2 in qteSequence)
			{
				list.Add(new MusicalInstrumentQteItemData
				{
					RowIndex = list2[0],
					ColumnIndex = list2[1],
					Finished = false,
					IsFocus = false
				});
			}
			list[0].IsFocus = true;
			return new MusicalInstrumentQteData
			{
				InstrumentType = instrumentType,
				QteId = qteId,
				ItemDataList = list,
				AudioEvent = AudioSystem.Instance.parseAudioEventPath(preludeAsset)
			};
		}

		// Token: 0x0602B87E RID: 178302 RVA: 0x00C3B90C File Offset: 0x00C39B0C
		public UniTask Enter(MusicalInstrumentEnterParam param)
		{
			MusicalInstrumentController.<Enter>d__9 <Enter>d__;
			<Enter>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Enter>d__.<>4__this = this;
			<Enter>d__.param = param;
			<Enter>d__.<>1__state = -1;
			<Enter>d__.<>t__builder.Start<MusicalInstrumentController.<Enter>d__9>(ref <Enter>d__);
			return <Enter>d__.<>t__builder.Task;
		}

		// Token: 0x0602B87F RID: 178303 RVA: 0x00C3B958 File Offset: 0x00C39B58
		[NullableContext(0)]
		public UniTask<bool> Exit([Nullable(1)] MusicalInstrumentExitParam param)
		{
			MusicalInstrumentController.<Exit>d__10 <Exit>d__;
			<Exit>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<Exit>d__.<>4__this = this;
			<Exit>d__.param = param;
			<Exit>d__.<>1__state = -1;
			<Exit>d__.<>t__builder.Start<MusicalInstrumentController.<Exit>d__10>(ref <Exit>d__);
			return <Exit>d__.<>t__builder.Task;
		}

		// Token: 0x0602B880 RID: 178304 RVA: 0x00C3B9A3 File Offset: 0x00C39BA3
		[NullableContext(2)]
		public MusicalInstrumentSubController GetSubController(Aki.TDConfigMgr.Action.EInstrumentType type)
		{
			return this.SubControllerMap.GetValueOrDefault(type);
		}

		// Token: 0x0602B881 RID: 178305 RVA: 0x00C3B9B4 File Offset: 0x00C39BB4
		public void SyncServerRequest(string @event)
		{
			ZitherPlayNotePush zitherPlayNotePush = ZitherPlayNotePush.Create();
			zitherPlayNotePush.Note = @event;
			Net.Instance.Send(EPushMessageId.ZitherPlayNotePush, zitherPlayNotePush);
		}

		// Token: 0x0602B882 RID: 178306 RVA: 0x00C3B9DE File Offset: 0x00C39BDE
		private void MuteOtherAudio()
		{
			AudioSystem.Instance.SetState("instrument_game_mode", "mute_other_bgm", true);
		}

		// Token: 0x0602B883 RID: 178307 RVA: 0x00C3B9F5 File Offset: 0x00C39BF5
		private void ResumeOtherAudio()
		{
			AudioSystem.Instance.SetState("instrument_game_mode", "none", true);
		}

		// Token: 0x1700571D RID: 22301
		// (get) Token: 0x0602B884 RID: 178308 RVA: 0x00C3BA0C File Offset: 0x00C39C0C
		public static MusicalInstrumentController Instance
		{
			get
			{
				return MusicalInstrumentController._Instance;
			}
		}

		// Token: 0x0602B885 RID: 178309 RVA: 0x00C3BA13 File Offset: 0x00C39C13
		public static MusicalInstrumentController GetOrCreateInstance()
		{
			if (MusicalInstrumentController._Instance == null)
			{
				MusicalInstrumentController.CreateInstance();
			}
			return MusicalInstrumentController._Instance;
		}

		// Token: 0x0602B886 RID: 178310 RVA: 0x00C3BA27 File Offset: 0x00C39C27
		public static bool CreateInstance()
		{
			if (MusicalInstrumentController._Instance != null)
			{
				return true;
			}
			MusicalInstrumentController._Instance = new MusicalInstrumentController();
			return true;
		}

		// Token: 0x0602B887 RID: 178311 RVA: 0x00C3BA3D File Offset: 0x00C39C3D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602B888 RID: 178312 RVA: 0x00C3BA3F File Offset: 0x00C39C3F
		public static void ResetStaticDefaultValue()
		{
			MusicalInstrumentController._Instance = null;
		}

		// Token: 0x0602B889 RID: 178313 RVA: 0x00C3BA47 File Offset: 0x00C39C47
		static MusicalInstrumentController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MusicalInstrumentController.CreateStaticDefaultValue), new Action(MusicalInstrumentController.ResetStaticDefaultValue));
		}

		// Token: 0x04017826 RID: 96294
		private readonly Dictionary<Aki.TDConfigMgr.Action.EInstrumentType, MusicalInstrumentSubController> SubControllerMap = new Dictionary<Aki.TDConfigMgr.Action.EInstrumentType, MusicalInstrumentSubController>();

		// Token: 0x04017827 RID: 96295
		private bool IsEntering;

		// Token: 0x04017828 RID: 96296
		private bool IsExiting;

		// Token: 0x04017829 RID: 96297
		private const int INSTRUMENT_QTE_CONFIG_FB_LRU_CAPACITY = 50;

		// Token: 0x0401782A RID: 96298
		private readonly CacheLru<int, Aki.TDConfigMgr.Action.IInstrumentQteConfig> QteConfigFbLru = new CacheLru<int, Aki.TDConfigMgr.Action.IInstrumentQteConfig>(50, delegate(int configId)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(59, 2);
			defaultInterpolatedStringHandler.AppendFormatted(UBlueprintPathsLibrary.ProjectContentDir());
			defaultInterpolatedStringHandler.AppendLiteral("Aki/Config/UniverseEditorConfig/InstrumentQteConfigs/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(configId);
			defaultInterpolatedStringHandler.AppendLiteral(".bytes");
			ByteBuffer byteBuffer = FbFileLoader.LoadBytes(defaultInterpolatedStringHandler.ToStringAndClear());
			if (byteBuffer == null)
			{
				return null;
			}
			return Aki.TDConfigMgr.Action.IInstrumentQteConfig.Create(Aki.TDConfigMgr.Action.Fb.IInstrumentQteConfig.Create(new Aki.UniverseEditor.Interface.Fbs.Action.IInstrumentQteConfig?(Aki.UniverseEditor.Interface.Fbs.Action.IInstrumentQteConfig.GetRootAsIInstrumentQteConfig(byteBuffer))));
		});

		// Token: 0x0401782B RID: 96299
		[Nullable(2)]
		private static MusicalInstrumentController _Instance;
	}
}
