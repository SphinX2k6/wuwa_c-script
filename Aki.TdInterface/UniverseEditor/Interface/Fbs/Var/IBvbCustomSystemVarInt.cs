using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A4E RID: 14926
	public struct IBvbCustomSystemVarInt : IFlatbufferObject
	{
		// Token: 0x17006652 RID: 26194
		// (get) Token: 0x0601437A RID: 82810 RVA: 0x002F4595 File Offset: 0x002F2795
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601437B RID: 82811 RVA: 0x002F45A2 File Offset: 0x002F27A2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601437C RID: 82812 RVA: 0x002F45AC File Offset: 0x002F27AC
		public static IBvbCustomSystemVarInt GetRootAsIBvbCustomSystemVarInt(ByteBuffer _bb)
		{
			return IBvbCustomSystemVarInt.GetRootAsIBvbCustomSystemVarInt(_bb, default(IBvbCustomSystemVarInt));
		}

		// Token: 0x0601437D RID: 82813 RVA: 0x002F45C8 File Offset: 0x002F27C8
		public static IBvbCustomSystemVarInt GetRootAsIBvbCustomSystemVarInt(ByteBuffer _bb, IBvbCustomSystemVarInt obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601437E RID: 82814 RVA: 0x002F45E5 File Offset: 0x002F27E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601437F RID: 82815 RVA: 0x002F45F4 File Offset: 0x002F27F4
		public IBvbCustomSystemVarInt __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006653 RID: 26195
		// (get) Token: 0x06014380 RID: 82816 RVA: 0x002F4604 File Offset: 0x002F2804
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

		// Token: 0x17006654 RID: 26196
		// (get) Token: 0x06014381 RID: 82817 RVA: 0x002F4640 File Offset: 0x002F2840
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

		// Token: 0x06014382 RID: 82818 RVA: 0x002F4677 File Offset: 0x002F2877
		public Span<byte> GetVarNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06014383 RID: 82819 RVA: 0x002F4686 File Offset: 0x002F2886
		public byte[] GetVarNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17006655 RID: 26197
		// (get) Token: 0x06014384 RID: 82820 RVA: 0x002F4694 File Offset: 0x002F2894
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

		// Token: 0x06014385 RID: 82821 RVA: 0x002F46CB File Offset: 0x002F28CB
		public Span<byte> GetVarParamsBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06014386 RID: 82822 RVA: 0x002F46DA File Offset: 0x002F28DA
		public byte[] GetVarParamsArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x06014387 RID: 82823 RVA: 0x002F46E8 File Offset: 0x002F28E8
		public static Offset<IBvbCustomSystemVarInt> CreateIBvbCustomSystemVarInt(FlatBufferBuilder builder, ESystemVarName Type = ESystemVarName.CommonHotFixVar, StringOffset VarNameOffset = default(StringOffset), StringOffset VarParamsOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IBvbCustomSystemVarInt.AddVarParams(builder, VarParamsOffset);
			IBvbCustomSystemVarInt.AddVarName(builder, VarNameOffset);
			IBvbCustomSystemVarInt.AddType(builder, Type);
			return IBvbCustomSystemVarInt.EndIBvbCustomSystemVarInt(builder);
		}

		// Token: 0x06014388 RID: 82824 RVA: 0x002F470C File Offset: 0x002F290C
		public static void StartIBvbCustomSystemVarInt(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06014389 RID: 82825 RVA: 0x002F4715 File Offset: 0x002F2915
		public static void AddType(FlatBufferBuilder builder, ESystemVarName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601438A RID: 82826 RVA: 0x002F4720 File Offset: 0x002F2920
		public static void AddVarName(FlatBufferBuilder builder, StringOffset varNameOffset)
		{
			builder.AddOffset(1, varNameOffset.Value, 0);
		}

		// Token: 0x0601438B RID: 82827 RVA: 0x002F4730 File Offset: 0x002F2930
		public static void AddVarParams(FlatBufferBuilder builder, StringOffset varParamsOffset)
		{
			builder.AddOffset(2, varParamsOffset.Value, 0);
		}

		// Token: 0x0601438C RID: 82828 RVA: 0x002F4740 File Offset: 0x002F2940
		public static Offset<IBvbCustomSystemVarInt> EndIBvbCustomSystemVarInt(FlatBufferBuilder builder)
		{
			return new Offset<IBvbCustomSystemVarInt>(builder.EndTable());
		}

		// Token: 0x0601438D RID: 82829 RVA: 0x002F4750 File Offset: 0x002F2950
		public IBvbCustomSystemVarIntT UnPack()
		{
			IBvbCustomSystemVarIntT bvbCustomSystemVarIntT = new IBvbCustomSystemVarIntT();
			this.UnPackTo(bvbCustomSystemVarIntT);
			return bvbCustomSystemVarIntT;
		}

		// Token: 0x0601438E RID: 82830 RVA: 0x002F476B File Offset: 0x002F296B
		public void UnPackTo(IBvbCustomSystemVarIntT _o)
		{
			_o.Type = this.Type;
			_o.VarName = this.VarName;
			_o.VarParams = this.VarParams;
		}

		// Token: 0x0601438F RID: 82831 RVA: 0x002F4794 File Offset: 0x002F2994
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

		// Token: 0x0400AED3 RID: 44755
		private Table __p;
	}
}
