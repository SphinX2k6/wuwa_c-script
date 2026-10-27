using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E6A RID: 28266
	public struct IRemoveScreenEffect : IFlatbufferObject
	{
		// Token: 0x1700D287 RID: 53895
		// (get) Token: 0x06031F2E RID: 204590 RVA: 0x006C1DC7 File Offset: 0x006BFFC7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031F2F RID: 204591 RVA: 0x006C1DD4 File Offset: 0x006BFFD4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031F30 RID: 204592 RVA: 0x006C1DDC File Offset: 0x006BFFDC
		public static IRemoveScreenEffect GetRootAsIRemoveScreenEffect(ByteBuffer _bb)
		{
			return IRemoveScreenEffect.GetRootAsIRemoveScreenEffect(_bb, default(IRemoveScreenEffect));
		}

		// Token: 0x06031F31 RID: 204593 RVA: 0x006C1DF8 File Offset: 0x006BFFF8
		public static IRemoveScreenEffect GetRootAsIRemoveScreenEffect(ByteBuffer _bb, IRemoveScreenEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031F32 RID: 204594 RVA: 0x006C1E15 File Offset: 0x006C0015
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031F33 RID: 204595 RVA: 0x006C1E24 File Offset: 0x006C0024
		public IRemoveScreenEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D288 RID: 53896
		// (get) Token: 0x06031F34 RID: 204596 RVA: 0x006C1E34 File Offset: 0x006C0034
		public EEffectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEffectType.Effect;
				}
				return (EEffectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D289 RID: 53897
		// (get) Token: 0x06031F35 RID: 204597 RVA: 0x006C1E70 File Offset: 0x006C0070
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

		// Token: 0x06031F36 RID: 204598 RVA: 0x006C1EA7 File Offset: 0x006C00A7
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06031F37 RID: 204599 RVA: 0x006C1EB6 File Offset: 0x006C00B6
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06031F38 RID: 204600 RVA: 0x006C1EC4 File Offset: 0x006C00C4
		public static Offset<IRemoveScreenEffect> CreateIRemoveScreenEffect(FlatBufferBuilder builder, EEffectType Type = EEffectType.Effect, StringOffset PathOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IRemoveScreenEffect.AddPath(builder, PathOffset);
			IRemoveScreenEffect.AddType(builder, Type);
			return IRemoveScreenEffect.EndIRemoveScreenEffect(builder);
		}

		// Token: 0x06031F39 RID: 204601 RVA: 0x006C1EE1 File Offset: 0x006C00E1
		public static void StartIRemoveScreenEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031F3A RID: 204602 RVA: 0x006C1EEA File Offset: 0x006C00EA
		public static void AddType(FlatBufferBuilder builder, EEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031F3B RID: 204603 RVA: 0x006C1EF5 File Offset: 0x006C00F5
		public static void AddPath(FlatBufferBuilder builder, StringOffset pathOffset)
		{
			builder.AddOffset(1, pathOffset.Value, 0);
		}

		// Token: 0x06031F3C RID: 204604 RVA: 0x006C1F05 File Offset: 0x006C0105
		public static Offset<IRemoveScreenEffect> EndIRemoveScreenEffect(FlatBufferBuilder builder)
		{
			return new Offset<IRemoveScreenEffect>(builder.EndTable());
		}

		// Token: 0x06031F3D RID: 204605 RVA: 0x006C1F14 File Offset: 0x006C0114
		public IRemoveScreenEffectT UnPack()
		{
			IRemoveScreenEffectT removeScreenEffectT = new IRemoveScreenEffectT();
			this.UnPackTo(removeScreenEffectT);
			return removeScreenEffectT;
		}

		// Token: 0x06031F3E RID: 204606 RVA: 0x006C1F2F File Offset: 0x006C012F
		public void UnPackTo(IRemoveScreenEffectT _o)
		{
			_o.Type = this.Type;
			_o.Path = this.Path;
		}

		// Token: 0x06031F3F RID: 204607 RVA: 0x006C1F4C File Offset: 0x006C014C
		public static Offset<IRemoveScreenEffect> Pack(FlatBufferBuilder builder, IRemoveScreenEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRemoveScreenEffect>);
			}
			StringOffset pathOffset = (_o.Path == null) ? default(StringOffset) : builder.CreateString(_o.Path);
			return IRemoveScreenEffect.CreateIRemoveScreenEffect(builder, _o.Type, pathOffset);
		}

		// Token: 0x04011854 RID: 71764
		private Table __p;
	}
}
