using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E29 RID: 15913
	public struct IBvbCustomSystemVarInt : IFlatbufferObject
	{
		// Token: 0x17006B82 RID: 27522
		// (get) Token: 0x06015696 RID: 87702 RVA: 0x00317781 File Offset: 0x00315981
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015697 RID: 87703 RVA: 0x0031778E File Offset: 0x0031598E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015698 RID: 87704 RVA: 0x00317798 File Offset: 0x00315998
		public static IBvbCustomSystemVarInt GetRootAsIBvbCustomSystemVarInt(ByteBuffer _bb)
		{
			return IBvbCustomSystemVarInt.GetRootAsIBvbCustomSystemVarInt(_bb, default(IBvbCustomSystemVarInt));
		}

		// Token: 0x06015699 RID: 87705 RVA: 0x003177B4 File Offset: 0x003159B4
		public static IBvbCustomSystemVarInt GetRootAsIBvbCustomSystemVarInt(ByteBuffer _bb, IBvbCustomSystemVarInt obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601569A RID: 87706 RVA: 0x003177D1 File Offset: 0x003159D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601569B RID: 87707 RVA: 0x003177E0 File Offset: 0x003159E0
		public IBvbCustomSystemVarInt __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006B83 RID: 27523
		// (get) Token: 0x0601569C RID: 87708 RVA: 0x003177F0 File Offset: 0x003159F0
		public ESystemVarName Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESystemVarName.CommonHotFixVar;
				}
				return (ESystemVarName)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006B84 RID: 27524
		// (get) Token: 0x0601569D RID: 87709 RVA: 0x0031782C File Offset: 0x00315A2C
		public string VarName
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

		// Token: 0x0601569E RID: 87710 RVA: 0x00317863 File Offset: 0x00315A63
		public Span<byte> GetVarNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601569F RID: 87711 RVA: 0x00317872 File Offset: 0x00315A72
		public byte[] GetVarNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17006B85 RID: 27525
		// (get) Token: 0x060156A0 RID: 87712 RVA: 0x00317880 File Offset: 0x00315A80
		public string VarParams
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060156A1 RID: 87713 RVA: 0x003178B7 File Offset: 0x00315AB7
		public Span<byte> GetVarParamsBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060156A2 RID: 87714 RVA: 0x003178C6 File Offset: 0x00315AC6
		public byte[] GetVarParamsArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x060156A3 RID: 87715 RVA: 0x003178D4 File Offset: 0x00315AD4
		public static Offset<IBvbCustomSystemVarInt> CreateIBvbCustomSystemVarInt(FlatBufferBuilder builder, ESystemVarName Type = ESystemVarName.CommonHotFixVar, StringOffset VarNameOffset = default(StringOffset), StringOffset VarParamsOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IBvbCustomSystemVarInt.AddVarParams(builder, VarParamsOffset);
			IBvbCustomSystemVarInt.AddVarName(builder, VarNameOffset);
			IBvbCustomSystemVarInt.AddType(builder, Type);
			return IBvbCustomSystemVarInt.EndIBvbCustomSystemVarInt(builder);
		}

		// Token: 0x060156A4 RID: 87716 RVA: 0x003178F8 File Offset: 0x00315AF8
		public static void StartIBvbCustomSystemVarInt(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060156A5 RID: 87717 RVA: 0x00317901 File Offset: 0x00315B01
		public static void AddType(FlatBufferBuilder builder, ESystemVarName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060156A6 RID: 87718 RVA: 0x0031790C File Offset: 0x00315B0C
		public static void AddVarName(FlatBufferBuilder builder, StringOffset varNameOffset)
		{
			builder.AddOffset(1, varNameOffset.Value, 0);
		}

		// Token: 0x060156A7 RID: 87719 RVA: 0x0031791C File Offset: 0x00315B1C
		public static void AddVarParams(FlatBufferBuilder builder, StringOffset varParamsOffset)
		{
			builder.AddOffset(2, varParamsOffset.Value, 0);
		}

		// Token: 0x060156A8 RID: 87720 RVA: 0x0031792C File Offset: 0x00315B2C
		public static Offset<IBvbCustomSystemVarInt> EndIBvbCustomSystemVarInt(FlatBufferBuilder builder)
		{
			return new Offset<IBvbCustomSystemVarInt>(builder.EndTable());
		}

		// Token: 0x060156A9 RID: 87721 RVA: 0x0031793C File Offset: 0x00315B3C
		public IBvbCustomSystemVarIntT UnPack()
		{
			IBvbCustomSystemVarIntT bvbCustomSystemVarIntT = new IBvbCustomSystemVarIntT();
			this.UnPackTo(bvbCustomSystemVarIntT);
			return bvbCustomSystemVarIntT;
		}

		// Token: 0x060156AA RID: 87722 RVA: 0x00317957 File Offset: 0x00315B57
		public void UnPackTo(IBvbCustomSystemVarIntT _o)
		{
			_o.Type = this.Type;
			_o.VarName = this.VarName;
			_o.VarParams = this.VarParams;
		}

		// Token: 0x060156AB RID: 87723 RVA: 0x00317980 File Offset: 0x00315B80
		public static Offset<IBvbCustomSystemVarInt> Pack(FlatBufferBuilder builder, IBvbCustomSystemVarIntT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbCustomSystemVarInt>);
			}
			StringOffset varNameOffset = (_o.VarName == null) ? default(StringOffset) : builder.CreateString(_o.VarName);
			StringOffset varParamsOffset = (_o.VarParams == null) ? default(StringOffset) : builder.CreateString(_o.VarParams);
			return IBvbCustomSystemVarInt.CreateIBvbCustomSystemVarInt(builder, _o.Type, varNameOffset, varParamsOffset);
		}

		// Token: 0x0400B7F5 RID: 47093
		private Table __p;
	}
}
