using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004911 RID: 18705
	public struct ILoopTeleportClientScreenEffect : IFlatbufferObject
	{
		// Token: 0x1700879B RID: 34715
		// (get) Token: 0x0601D3DC RID: 119772 RVA: 0x0041FF08 File Offset: 0x0041E108
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D3DD RID: 119773 RVA: 0x0041FF15 File Offset: 0x0041E115
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D3DE RID: 119774 RVA: 0x0041FF1C File Offset: 0x0041E11C
		public static ILoopTeleportClientScreenEffect GetRootAsILoopTeleportClientScreenEffect(ByteBuffer _bb)
		{
			return ILoopTeleportClientScreenEffect.GetRootAsILoopTeleportClientScreenEffect(_bb, default(ILoopTeleportClientScreenEffect));
		}

		// Token: 0x0601D3DF RID: 119775 RVA: 0x0041FF38 File Offset: 0x0041E138
		public static ILoopTeleportClientScreenEffect GetRootAsILoopTeleportClientScreenEffect(ByteBuffer _bb, ILoopTeleportClientScreenEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D3E0 RID: 119776 RVA: 0x0041FF55 File Offset: 0x0041E155
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D3E1 RID: 119777 RVA: 0x0041FF64 File Offset: 0x0041E164
		public ILoopTeleportClientScreenEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700879C RID: 34716
		// (get) Token: 0x0601D3E2 RID: 119778 RVA: 0x0041FF74 File Offset: 0x0041E174
		public ELoopTeleportClientEffectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELoopTeleportClientEffectType.ScreenEffect;
				}
				return (ELoopTeleportClientEffectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700879D RID: 34717
		// (get) Token: 0x0601D3E3 RID: 119779 RVA: 0x0041FFB0 File Offset: 0x0041E1B0
		public string Path
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

		// Token: 0x0601D3E4 RID: 119780 RVA: 0x0041FFE7 File Offset: 0x0041E1E7
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601D3E5 RID: 119781 RVA: 0x0041FFF6 File Offset: 0x0041E1F6
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601D3E6 RID: 119782 RVA: 0x00420004 File Offset: 0x0041E204
		public static Offset<ILoopTeleportClientScreenEffect> CreateILoopTeleportClientScreenEffect(FlatBufferBuilder builder, ELoopTeleportClientEffectType Type = ELoopTeleportClientEffectType.ScreenEffect, StringOffset PathOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ILoopTeleportClientScreenEffect.AddPath(builder, PathOffset);
			ILoopTeleportClientScreenEffect.AddType(builder, Type);
			return ILoopTeleportClientScreenEffect.EndILoopTeleportClientScreenEffect(builder);
		}

		// Token: 0x0601D3E7 RID: 119783 RVA: 0x00420021 File Offset: 0x0041E221
		public static void StartILoopTeleportClientScreenEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601D3E8 RID: 119784 RVA: 0x0042002A File Offset: 0x0041E22A
		public static void AddType(FlatBufferBuilder builder, ELoopTeleportClientEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D3E9 RID: 119785 RVA: 0x00420035 File Offset: 0x0041E235
		public static void AddPath(FlatBufferBuilder builder, StringOffset pathOffset)
		{
			builder.AddOffset(1, pathOffset.Value, 0);
		}

		// Token: 0x0601D3EA RID: 119786 RVA: 0x00420045 File Offset: 0x0041E245
		public static Offset<ILoopTeleportClientScreenEffect> EndILoopTeleportClientScreenEffect(FlatBufferBuilder builder)
		{
			return new Offset<ILoopTeleportClientScreenEffect>(builder.EndTable());
		}

		// Token: 0x0601D3EB RID: 119787 RVA: 0x00420054 File Offset: 0x0041E254
		public ILoopTeleportClientScreenEffectT UnPack()
		{
			ILoopTeleportClientScreenEffectT loopTeleportClientScreenEffectT = new ILoopTeleportClientScreenEffectT();
			this.UnPackTo(loopTeleportClientScreenEffectT);
			return loopTeleportClientScreenEffectT;
		}

		// Token: 0x0601D3EC RID: 119788 RVA: 0x0042006F File Offset: 0x0041E26F
		public void UnPackTo(ILoopTeleportClientScreenEffectT _o)
		{
			_o.Type = this.Type;
			_o.Path = this.Path;
		}

		// Token: 0x0601D3ED RID: 119789 RVA: 0x0042008C File Offset: 0x0041E28C
		public static Offset<ILoopTeleportClientScreenEffect> Pack(FlatBufferBuilder builder, ILoopTeleportClientScreenEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILoopTeleportClientScreenEffect>);
			}
			StringOffset pathOffset = (_o.Path == null) ? default(StringOffset) : builder.CreateString(_o.Path);
			return ILoopTeleportClientScreenEffect.CreateILoopTeleportClientScreenEffect(builder, _o.Type, pathOffset);
		}

		// Token: 0x0400CF85 RID: 53125
		private Table __p;
	}
}
