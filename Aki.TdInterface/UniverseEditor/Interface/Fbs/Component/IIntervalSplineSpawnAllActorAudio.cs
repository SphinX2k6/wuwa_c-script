using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A0B RID: 23051
	public struct IIntervalSplineSpawnAllActorAudio : IFlatbufferObject
	{
		// Token: 0x1700A78E RID: 42894
		// (get) Token: 0x06025A69 RID: 154217 RVA: 0x00529778 File Offset: 0x00527978
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025A6A RID: 154218 RVA: 0x00529785 File Offset: 0x00527985
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025A6B RID: 154219 RVA: 0x0052978C File Offset: 0x0052798C
		public static IIntervalSplineSpawnAllActorAudio GetRootAsIIntervalSplineSpawnAllActorAudio(ByteBuffer _bb)
		{
			return IIntervalSplineSpawnAllActorAudio.GetRootAsIIntervalSplineSpawnAllActorAudio(_bb, default(IIntervalSplineSpawnAllActorAudio));
		}

		// Token: 0x06025A6C RID: 154220 RVA: 0x005297A8 File Offset: 0x005279A8
		public static IIntervalSplineSpawnAllActorAudio GetRootAsIIntervalSplineSpawnAllActorAudio(ByteBuffer _bb, IIntervalSplineSpawnAllActorAudio obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025A6D RID: 154221 RVA: 0x005297C5 File Offset: 0x005279C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025A6E RID: 154222 RVA: 0x005297D4 File Offset: 0x005279D4
		public IIntervalSplineSpawnAllActorAudio __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A78F RID: 42895
		// (get) Token: 0x06025A6F RID: 154223 RVA: 0x005297E4 File Offset: 0x005279E4
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

		// Token: 0x1700A790 RID: 42896
		// (get) Token: 0x06025A70 RID: 154224 RVA: 0x00529820 File Offset: 0x00527A20
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

		// Token: 0x06025A71 RID: 154225 RVA: 0x00529857 File Offset: 0x00527A57
		public Span<byte> GetAkEventBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06025A72 RID: 154226 RVA: 0x00529866 File Offset: 0x00527A66
		public byte[] GetAkEventArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700A791 RID: 42897
		// (get) Token: 0x06025A73 RID: 154227 RVA: 0x00529874 File Offset: 0x00527A74
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

		// Token: 0x06025A74 RID: 154228 RVA: 0x005298D1 File Offset: 0x00527AD1
		public static Offset<IIntervalSplineSpawnAllActorAudio> CreateIIntervalSplineSpawnAllActorAudio(FlatBufferBuilder builder, EIntervalSplineSpawnAudioConfigType Type = EIntervalSplineSpawnAudioConfigType.AllActorAddAudio, StringOffset AkEventOffset = default(StringOffset), Offset<IVectorInfo> OffsetOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(3);
			IIntervalSplineSpawnAllActorAudio.AddOffset(builder, OffsetOffset);
			IIntervalSplineSpawnAllActorAudio.AddAkEvent(builder, AkEventOffset);
			IIntervalSplineSpawnAllActorAudio.AddType(builder, Type);
			return IIntervalSplineSpawnAllActorAudio.EndIIntervalSplineSpawnAllActorAudio(builder);
		}

		// Token: 0x06025A75 RID: 154229 RVA: 0x005298F5 File Offset: 0x00527AF5
		public static void StartIIntervalSplineSpawnAllActorAudio(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06025A76 RID: 154230 RVA: 0x005298FE File Offset: 0x00527AFE
		public static void AddType(FlatBufferBuilder builder, EIntervalSplineSpawnAudioConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025A77 RID: 154231 RVA: 0x00529909 File Offset: 0x00527B09
		public static void AddAkEvent(FlatBufferBuilder builder, StringOffset akEventOffset)
		{
			builder.AddOffset(1, akEventOffset.Value, 0);
		}

		// Token: 0x06025A78 RID: 154232 RVA: 0x00529919 File Offset: 0x00527B19
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(2, offsetOffset.Value, 0);
		}

		// Token: 0x06025A79 RID: 154233 RVA: 0x00529929 File Offset: 0x00527B29
		public static Offset<IIntervalSplineSpawnAllActorAudio> EndIIntervalSplineSpawnAllActorAudio(FlatBufferBuilder builder)
		{
			return new Offset<IIntervalSplineSpawnAllActorAudio>(builder.EndTable());
		}

		// Token: 0x06025A7A RID: 154234 RVA: 0x00529938 File Offset: 0x00527B38
		public IIntervalSplineSpawnAllActorAudioT UnPack()
		{
			IIntervalSplineSpawnAllActorAudioT intervalSplineSpawnAllActorAudioT = new IIntervalSplineSpawnAllActorAudioT();
			this.UnPackTo(intervalSplineSpawnAllActorAudioT);
			return intervalSplineSpawnAllActorAudioT;
		}

		// Token: 0x06025A7B RID: 154235 RVA: 0x00529954 File Offset: 0x00527B54
		public void UnPackTo(IIntervalSplineSpawnAllActorAudioT _o)
		{
			_o.Type = this.Type;
			_o.AkEvent = this.AkEvent;
			_o.Offset = ((this.Offset != null) ? this.Offset.Value.UnPack() : null);
		}

		// Token: 0x06025A7C RID: 154236 RVA: 0x005299A8 File Offset: 0x00527BA8
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

		// Token: 0x0400F344 RID: 62276
		private Table __p;
	}
}
