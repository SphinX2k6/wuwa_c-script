using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F24 RID: 28452
	public struct ISceneActorMusicLightsEvent : IFlatbufferObject
	{
		// Token: 0x1700D37E RID: 54142
		// (get) Token: 0x06032443 RID: 205891 RVA: 0x006CA336 File Offset: 0x006C8536
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032444 RID: 205892 RVA: 0x006CA343 File Offset: 0x006C8543
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032445 RID: 205893 RVA: 0x006CA34C File Offset: 0x006C854C
		public static ISceneActorMusicLightsEvent GetRootAsISceneActorMusicLightsEvent(ByteBuffer _bb)
		{
			return ISceneActorMusicLightsEvent.GetRootAsISceneActorMusicLightsEvent(_bb, default(ISceneActorMusicLightsEvent));
		}

		// Token: 0x06032446 RID: 205894 RVA: 0x006CA368 File Offset: 0x006C8568
		public static ISceneActorMusicLightsEvent GetRootAsISceneActorMusicLightsEvent(ByteBuffer _bb, ISceneActorMusicLightsEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032447 RID: 205895 RVA: 0x006CA385 File Offset: 0x006C8585
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032448 RID: 205896 RVA: 0x006CA394 File Offset: 0x006C8594
		public ISceneActorMusicLightsEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D37F RID: 54143
		// (get) Token: 0x06032449 RID: 205897 RVA: 0x006CA3A4 File Offset: 0x006C85A4
		public ESceneActorEventType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESceneActorEventType.PlayMusicPlants;
				}
				return (ESceneActorEventType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603244A RID: 205898 RVA: 0x006CA3E0 File Offset: 0x006C85E0
		public static Offset<ISceneActorMusicLightsEvent> CreateISceneActorMusicLightsEvent(FlatBufferBuilder builder, ESceneActorEventType Type = ESceneActorEventType.PlayMusicPlants)
		{
			builder.StartTable(1);
			ISceneActorMusicLightsEvent.AddType(builder, Type);
			return ISceneActorMusicLightsEvent.EndISceneActorMusicLightsEvent(builder);
		}

		// Token: 0x0603244B RID: 205899 RVA: 0x006CA3F6 File Offset: 0x006C85F6
		public static void StartISceneActorMusicLightsEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603244C RID: 205900 RVA: 0x006CA3FF File Offset: 0x006C85FF
		public static void AddType(FlatBufferBuilder builder, ESceneActorEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603244D RID: 205901 RVA: 0x006CA40A File Offset: 0x006C860A
		public static Offset<ISceneActorMusicLightsEvent> EndISceneActorMusicLightsEvent(FlatBufferBuilder builder)
		{
			return new Offset<ISceneActorMusicLightsEvent>(builder.EndTable());
		}

		// Token: 0x0603244E RID: 205902 RVA: 0x006CA418 File Offset: 0x006C8618
		public ISceneActorMusicLightsEventT UnPack()
		{
			ISceneActorMusicLightsEventT sceneActorMusicLightsEventT = new ISceneActorMusicLightsEventT();
			this.UnPackTo(sceneActorMusicLightsEventT);
			return sceneActorMusicLightsEventT;
		}

		// Token: 0x0603244F RID: 205903 RVA: 0x006CA433 File Offset: 0x006C8633
		public void UnPackTo(ISceneActorMusicLightsEventT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06032450 RID: 205904 RVA: 0x006CA444 File Offset: 0x006C8644
		public static Offset<ISceneActorMusicLightsEvent> Pack(FlatBufferBuilder builder, ISceneActorMusicLightsEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneActorMusicLightsEvent>);
			}
			return ISceneActorMusicLightsEvent.CreateISceneActorMusicLightsEvent(builder, _o.Type);
		}

		// Token: 0x04011913 RID: 71955
		private Table __p;
	}
}
