using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055BF RID: 21951
	public struct ICustomPrimitiveMapping : IFlatbufferObject
	{
		// Token: 0x17009D29 RID: 40233
		// (get) Token: 0x06022EBD RID: 143037 RVA: 0x004CED73 File Offset: 0x004CCF73
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022EBE RID: 143038 RVA: 0x004CED80 File Offset: 0x004CCF80
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022EBF RID: 143039 RVA: 0x004CED88 File Offset: 0x004CCF88
		public static ICustomPrimitiveMapping GetRootAsICustomPrimitiveMapping(ByteBuffer _bb)
		{
			return ICustomPrimitiveMapping.GetRootAsICustomPrimitiveMapping(_bb, default(ICustomPrimitiveMapping));
		}

		// Token: 0x06022EC0 RID: 143040 RVA: 0x004CEDA4 File Offset: 0x004CCFA4
		public static ICustomPrimitiveMapping GetRootAsICustomPrimitiveMapping(ByteBuffer _bb, ICustomPrimitiveMapping obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022EC1 RID: 143041 RVA: 0x004CEDC1 File Offset: 0x004CCFC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022EC2 RID: 143042 RVA: 0x004CEDD0 File Offset: 0x004CCFD0
		public ICustomPrimitiveMapping __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009D2A RID: 40234
		// (get) Token: 0x06022EC3 RID: 143043 RVA: 0x004CEDE0 File Offset: 0x004CCFE0
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

		// Token: 0x06022EC4 RID: 143044 RVA: 0x004CEE17 File Offset: 0x004CD017
		public Span<byte> GetKeyPrefixBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06022EC5 RID: 143045 RVA: 0x004CEE26 File Offset: 0x004CD026
		public byte[] GetKeyPrefixArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17009D2B RID: 40235
		// (get) Token: 0x06022EC6 RID: 143046 RVA: 0x004CEE34 File Offset: 0x004CD034
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

		// Token: 0x06022EC7 RID: 143047 RVA: 0x004CEE70 File Offset: 0x004CD070
		public static Offset<ICustomPrimitiveMapping> CreateICustomPrimitiveMapping(FlatBufferBuilder builder, StringOffset KeyPrefixOffset = default(StringOffset), int Index = 0)
		{
			builder.StartTable(2);
			ICustomPrimitiveMapping.AddIndex(builder, Index);
			ICustomPrimitiveMapping.AddKeyPrefix(builder, KeyPrefixOffset);
			return ICustomPrimitiveMapping.EndICustomPrimitiveMapping(builder);
		}

		// Token: 0x06022EC8 RID: 143048 RVA: 0x004CEE8D File Offset: 0x004CD08D
		public static void StartICustomPrimitiveMapping(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06022EC9 RID: 143049 RVA: 0x004CEE96 File Offset: 0x004CD096
		public static void AddKeyPrefix(FlatBufferBuilder builder, StringOffset keyPrefixOffset)
		{
			builder.AddOffset(0, keyPrefixOffset.Value, 0);
		}

		// Token: 0x06022ECA RID: 143050 RVA: 0x004CEEA6 File Offset: 0x004CD0A6
		public static void AddIndex(FlatBufferBuilder builder, int index)
		{
			builder.AddInt(1, index, 0);
		}

		// Token: 0x06022ECB RID: 143051 RVA: 0x004CEEB1 File Offset: 0x004CD0B1
		public static Offset<ICustomPrimitiveMapping> EndICustomPrimitiveMapping(FlatBufferBuilder builder)
		{
			return new Offset<ICustomPrimitiveMapping>(builder.EndTable());
		}

		// Token: 0x06022ECC RID: 143052 RVA: 0x004CEEC0 File Offset: 0x004CD0C0
		public ICustomPrimitiveMappingT UnPack()
		{
			ICustomPrimitiveMappingT customPrimitiveMappingT = new ICustomPrimitiveMappingT();
			this.UnPackTo(customPrimitiveMappingT);
			return customPrimitiveMappingT;
		}

		// Token: 0x06022ECD RID: 143053 RVA: 0x004CEEDB File Offset: 0x004CD0DB
		public void UnPackTo(ICustomPrimitiveMappingT _o)
		{
			_o.KeyPrefix = this.KeyPrefix;
			_o.Index = this.Index;
		}

		// Token: 0x06022ECE RID: 143054 RVA: 0x004CEEF8 File Offset: 0x004CD0F8
		public static Offset<ICustomPrimitiveMapping> Pack(FlatBufferBuilder builder, ICustomPrimitiveMappingT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICustomPrimitiveMapping>);
			}
			StringOffset keyPrefixOffset = (_o.KeyPrefix == null) ? default(StringOffset) : builder.CreateString(_o.KeyPrefix);
			return ICustomPrimitiveMapping.CreateICustomPrimitiveMapping(builder, keyPrefixOffset, _o.Index);
		}

		// Token: 0x0400EC52 RID: 60498
		private Table __p;
	}
}
