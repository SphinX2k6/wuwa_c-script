using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200505D RID: 20573
	public struct ICustomPrimitiveMapping : IFlatbufferObject
	{
		// Token: 0x17009543 RID: 38211
		// (get) Token: 0x06020F83 RID: 135043 RVA: 0x004950BF File Offset: 0x004932BF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020F84 RID: 135044 RVA: 0x004950CC File Offset: 0x004932CC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020F85 RID: 135045 RVA: 0x004950D4 File Offset: 0x004932D4
		public static ICustomPrimitiveMapping GetRootAsICustomPrimitiveMapping(ByteBuffer _bb)
		{
			return ICustomPrimitiveMapping.GetRootAsICustomPrimitiveMapping(_bb, default(ICustomPrimitiveMapping));
		}

		// Token: 0x06020F86 RID: 135046 RVA: 0x004950F0 File Offset: 0x004932F0
		public static ICustomPrimitiveMapping GetRootAsICustomPrimitiveMapping(ByteBuffer _bb, ICustomPrimitiveMapping obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020F87 RID: 135047 RVA: 0x0049510D File Offset: 0x0049330D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020F88 RID: 135048 RVA: 0x0049511C File Offset: 0x0049331C
		public ICustomPrimitiveMapping __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009544 RID: 38212
		// (get) Token: 0x06020F89 RID: 135049 RVA: 0x0049512C File Offset: 0x0049332C
		public string KeyPrefix
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020F8A RID: 135050 RVA: 0x00495163 File Offset: 0x00493363
		public Span<byte> GetKeyPrefixBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06020F8B RID: 135051 RVA: 0x00495172 File Offset: 0x00493372
		public byte[] GetKeyPrefixArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17009545 RID: 38213
		// (get) Token: 0x06020F8C RID: 135052 RVA: 0x00495180 File Offset: 0x00493380
		public int Index
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020F8D RID: 135053 RVA: 0x004951BC File Offset: 0x004933BC
		public static Offset<ICustomPrimitiveMapping> CreateICustomPrimitiveMapping(FlatBufferBuilder builder, StringOffset KeyPrefixOffset = default(StringOffset), int Index = 0)
		{
			builder.StartTable(2);
			ICustomPrimitiveMapping.AddIndex(builder, Index);
			ICustomPrimitiveMapping.AddKeyPrefix(builder, KeyPrefixOffset);
			return ICustomPrimitiveMapping.EndICustomPrimitiveMapping(builder);
		}

		// Token: 0x06020F8E RID: 135054 RVA: 0x004951D9 File Offset: 0x004933D9
		public static void StartICustomPrimitiveMapping(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06020F8F RID: 135055 RVA: 0x004951E2 File Offset: 0x004933E2
		public static void AddKeyPrefix(FlatBufferBuilder builder, StringOffset keyPrefixOffset)
		{
			builder.AddOffset(0, keyPrefixOffset.Value, 0);
		}

		// Token: 0x06020F90 RID: 135056 RVA: 0x004951F2 File Offset: 0x004933F2
		public static void AddIndex(FlatBufferBuilder builder, int index)
		{
			builder.AddInt(1, index, 0);
		}

		// Token: 0x06020F91 RID: 135057 RVA: 0x004951FD File Offset: 0x004933FD
		public static Offset<ICustomPrimitiveMapping> EndICustomPrimitiveMapping(FlatBufferBuilder builder)
		{
			return new Offset<ICustomPrimitiveMapping>(builder.EndTable());
		}

		// Token: 0x06020F92 RID: 135058 RVA: 0x0049520C File Offset: 0x0049340C
		public ICustomPrimitiveMappingT UnPack()
		{
			ICustomPrimitiveMappingT customPrimitiveMappingT = new ICustomPrimitiveMappingT();
			this.UnPackTo(customPrimitiveMappingT);
			return customPrimitiveMappingT;
		}

		// Token: 0x06020F93 RID: 135059 RVA: 0x00495227 File Offset: 0x00493427
		public void UnPackTo(ICustomPrimitiveMappingT _o)
		{
			_o.KeyPrefix = this.KeyPrefix;
			_o.Index = this.Index;
		}

		// Token: 0x06020F94 RID: 135060 RVA: 0x00495244 File Offset: 0x00493444
		public static Offset<ICustomPrimitiveMapping> Pack(FlatBufferBuilder builder, ICustomPrimitiveMappingT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICustomPrimitiveMapping>);
			}
			StringOffset keyPrefixOffset = (_o.KeyPrefix == null) ? default(StringOffset) : builder.CreateString(_o.KeyPrefix);
			return ICustomPrimitiveMapping.CreateICustomPrimitiveMapping(builder, keyPrefixOffset, _o.Index);
		}

		// Token: 0x0400E059 RID: 57433
		private Table __p;
	}
}
