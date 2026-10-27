using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005485 RID: 21637
	public struct IIntervalSplineSpawnAllActorAudio : IFlatbufferObject
	{
		// Token: 0x17009F54 RID: 40788
		// (get) Token: 0x060239B1 RID: 145841 RVA: 0x004EC704 File Offset: 0x004EA904
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060239B2 RID: 145842 RVA: 0x004EC711 File Offset: 0x004EA911
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060239B3 RID: 145843 RVA: 0x004EC718 File Offset: 0x004EA918
		public static IIntervalSplineSpawnAllActorAudio GetRootAsIIntervalSplineSpawnAllActorAudio(ByteBuffer _bb)
		{
			return IIntervalSplineSpawnAllActorAudio.GetRootAsIIntervalSplineSpawnAllActorAudio(_bb, default(IIntervalSplineSpawnAllActorAudio));
		}

		// Token: 0x060239B4 RID: 145844 RVA: 0x004EC734 File Offset: 0x004EA934
		public static IIntervalSplineSpawnAllActorAudio GetRootAsIIntervalSplineSpawnAllActorAudio(ByteBuffer _bb, IIntervalSplineSpawnAllActorAudio obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060239B5 RID: 145845 RVA: 0x004EC751 File Offset: 0x004EA951
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060239B6 RID: 145846 RVA: 0x004EC760 File Offset: 0x004EA960
		public IIntervalSplineSpawnAllActorAudio __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009F55 RID: 40789
		// (get) Token: 0x060239B7 RID: 145847 RVA: 0x004EC770 File Offset: 0x004EA970
		public EIntervalSplineSpawnAudioConfigType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EIntervalSplineSpawnAudioConfigType.AllActorAddAudio;
				}
				return (EIntervalSplineSpawnAudioConfigType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009F56 RID: 40790
		// (get) Token: 0x060239B8 RID: 145848 RVA: 0x004EC7AC File Offset: 0x004EA9AC
		public string AkEvent
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060239B9 RID: 145849 RVA: 0x004EC7E3 File Offset: 0x004EA9E3
		public Span<byte> GetAkEventBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060239BA RID: 145850 RVA: 0x004EC7F2 File Offset: 0x004EA9F2
		public byte[] GetAkEventArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17009F57 RID: 40791
		// (get) Token: 0x060239BB RID: 145851 RVA: 0x004EC800 File Offset: 0x004EAA00
		public IVectorInfo? Offset
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060239BC RID: 145852 RVA: 0x004EC85D File Offset: 0x004EAA5D
		public static Offset<IIntervalSplineSpawnAllActorAudio> CreateIIntervalSplineSpawnAllActorAudio(FlatBufferBuilder builder, EIntervalSplineSpawnAudioConfigType Type = EIntervalSplineSpawnAudioConfigType.AllActorAddAudio, StringOffset AkEventOffset = default(StringOffset), Offset<IVectorInfo> OffsetOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(3);
			IIntervalSplineSpawnAllActorAudio.AddOffset(builder, OffsetOffset);
			IIntervalSplineSpawnAllActorAudio.AddAkEvent(builder, AkEventOffset);
			IIntervalSplineSpawnAllActorAudio.AddType(builder, Type);
			return IIntervalSplineSpawnAllActorAudio.EndIIntervalSplineSpawnAllActorAudio(builder);
		}

		// Token: 0x060239BD RID: 145853 RVA: 0x004EC881 File Offset: 0x004EAA81
		public static void StartIIntervalSplineSpawnAllActorAudio(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060239BE RID: 145854 RVA: 0x004EC88A File Offset: 0x004EAA8A
		public static void AddType(FlatBufferBuilder builder, EIntervalSplineSpawnAudioConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060239BF RID: 145855 RVA: 0x004EC895 File Offset: 0x004EAA95
		public static void AddAkEvent(FlatBufferBuilder builder, StringOffset akEventOffset)
		{
			builder.AddOffset(1, akEventOffset.Value, 0);
		}

		// Token: 0x060239C0 RID: 145856 RVA: 0x004EC8A5 File Offset: 0x004EAAA5
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(2, offsetOffset.Value, 0);
		}

		// Token: 0x060239C1 RID: 145857 RVA: 0x004EC8B5 File Offset: 0x004EAAB5
		public static Offset<IIntervalSplineSpawnAllActorAudio> EndIIntervalSplineSpawnAllActorAudio(FlatBufferBuilder builder)
		{
			return new Offset<IIntervalSplineSpawnAllActorAudio>(builder.EndTable());
		}

		// Token: 0x060239C2 RID: 145858 RVA: 0x004EC8C4 File Offset: 0x004EAAC4
		public IIntervalSplineSpawnAllActorAudioT UnPack()
		{
			IIntervalSplineSpawnAllActorAudioT intervalSplineSpawnAllActorAudioT = new IIntervalSplineSpawnAllActorAudioT();
			this.UnPackTo(intervalSplineSpawnAllActorAudioT);
			return intervalSplineSpawnAllActorAudioT;
		}

		// Token: 0x060239C3 RID: 145859 RVA: 0x004EC8E0 File Offset: 0x004EAAE0
		public void UnPackTo(IIntervalSplineSpawnAllActorAudioT _o)
		{
			_o.Type = this.Type;
			_o.AkEvent = this.AkEvent;
			_o.Offset = ((this.Offset != null) ? this.Offset.Value.UnPack() : null);
		}

		// Token: 0x060239C4 RID: 145860 RVA: 0x004EC934 File Offset: 0x004EAB34
		public static Offset<IIntervalSplineSpawnAllActorAudio> Pack(FlatBufferBuilder builder, IIntervalSplineSpawnAllActorAudioT _o)
		{
			if (_o == null)
			{
				return default(Offset<IIntervalSplineSpawnAllActorAudio>);
			}
			StringOffset akEventOffset = (_o.AkEvent == null) ? default(StringOffset) : builder.CreateString(_o.AkEvent);
			Offset<IVectorInfo> offsetOffset = (_o.Offset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Offset);
			return IIntervalSplineSpawnAllActorAudio.CreateIIntervalSplineSpawnAllActorAudio(builder, _o.Type, akEventOffset, offsetOffset);
		}

		// Token: 0x0400E713 RID: 59155
		private Table __p;
	}
}
