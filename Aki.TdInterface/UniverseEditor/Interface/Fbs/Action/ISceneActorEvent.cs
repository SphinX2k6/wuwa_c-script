using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076A5 RID: 30373
	public struct ISceneActorEvent : IFlatbufferObject
	{
		// Token: 0x1700DED5 RID: 57045
		// (get) Token: 0x06035479 RID: 218233 RVA: 0x00725F9A File Offset: 0x0072419A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603547A RID: 218234 RVA: 0x00725FA7 File Offset: 0x007241A7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603547B RID: 218235 RVA: 0x00725FB0 File Offset: 0x007241B0
		public static ISceneActorEvent GetRootAsISceneActorEvent(ByteBuffer _bb)
		{
			return ISceneActorEvent.GetRootAsISceneActorEvent(_bb, default(ISceneActorEvent));
		}

		// Token: 0x0603547C RID: 218236 RVA: 0x00725FCC File Offset: 0x007241CC
		public static ISceneActorEvent GetRootAsISceneActorEvent(ByteBuffer _bb, ISceneActorEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603547D RID: 218237 RVA: 0x00725FE9 File Offset: 0x007241E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603547E RID: 218238 RVA: 0x00725FF8 File Offset: 0x007241F8
		public ISceneActorEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DED6 RID: 57046
		// (get) Token: 0x0603547F RID: 218239 RVA: 0x00726008 File Offset: 0x00724208
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

		// Token: 0x06035480 RID: 218240 RVA: 0x00726044 File Offset: 0x00724244
		public static Offset<ISceneActorEvent> CreateISceneActorEvent(FlatBufferBuilder builder, ESceneActorEventType Type = ESceneActorEventType.PlayMusicPlants)
		{
			builder.StartTable(1);
			ISceneActorEvent.AddType(builder, Type);
			return ISceneActorEvent.EndISceneActorEvent(builder);
		}

		// Token: 0x06035481 RID: 218241 RVA: 0x0072605A File Offset: 0x0072425A
		public static void StartISceneActorEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035482 RID: 218242 RVA: 0x00726063 File Offset: 0x00724263
		public static void AddType(FlatBufferBuilder builder, ESceneActorEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035483 RID: 218243 RVA: 0x0072606E File Offset: 0x0072426E
		public static Offset<ISceneActorEvent> EndISceneActorEvent(FlatBufferBuilder builder)
		{
			return new Offset<ISceneActorEvent>(builder.EndTable());
		}

		// Token: 0x06035484 RID: 218244 RVA: 0x0072607C File Offset: 0x0072427C
		public ISceneActorEventT UnPack()
		{
			ISceneActorEventT sceneActorEventT = new ISceneActorEventT();
			this.UnPackTo(sceneActorEventT);
			return sceneActorEventT;
		}

		// Token: 0x06035485 RID: 218245 RVA: 0x00726097 File Offset: 0x00724297
		public void UnPackTo(ISceneActorEventT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06035486 RID: 218246 RVA: 0x007260A8 File Offset: 0x007242A8
		public static Offset<ISceneActorEvent> Pack(FlatBufferBuilder builder, ISceneActorEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneActorEvent>);
			}
			return ISceneActorEvent.CreateISceneActorEvent(builder, _o.Type);
		}

		// Token: 0x04012891 RID: 75921
		private Table __p;
	}
}
