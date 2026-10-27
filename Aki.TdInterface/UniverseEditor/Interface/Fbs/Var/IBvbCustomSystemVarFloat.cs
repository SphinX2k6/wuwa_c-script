using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A4B RID: 14923
	public struct IBvbCustomSystemVarFloat : IFlatbufferObject
	{
		// Token: 0x1700664B RID: 26187
		// (get) Token: 0x0601435C RID: 82780 RVA: 0x002F42A5 File Offset: 0x002F24A5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601435D RID: 82781 RVA: 0x002F42B2 File Offset: 0x002F24B2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601435E RID: 82782 RVA: 0x002F42BC File Offset: 0x002F24BC
		public static IBvbCustomSystemVarFloat GetRootAsIBvbCustomSystemVarFloat(ByteBuffer _bb)
		{
			return IBvbCustomSystemVarFloat.GetRootAsIBvbCustomSystemVarFloat(_bb, default(IBvbCustomSystemVarFloat));
		}

		// Token: 0x0601435F RID: 82783 RVA: 0x002F42D8 File Offset: 0x002F24D8
		public static IBvbCustomSystemVarFloat GetRootAsIBvbCustomSystemVarFloat(ByteBuffer _bb, IBvbCustomSystemVarFloat obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014360 RID: 82784 RVA: 0x002F42F5 File Offset: 0x002F24F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014361 RID: 82785 RVA: 0x002F4304 File Offset: 0x002F2504
		public IBvbCustomSystemVarFloat __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700664C RID: 26188
		// (get) Token: 0x06014362 RID: 82786 RVA: 0x002F4314 File Offset: 0x002F2514
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

		// Token: 0x1700664D RID: 26189
		// (get) Token: 0x06014363 RID: 82787 RVA: 0x002F4350 File Offset: 0x002F2550
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

		// Token: 0x06014364 RID: 82788 RVA: 0x002F4387 File Offset: 0x002F2587
		public Span<byte> GetVarNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06014365 RID: 82789 RVA: 0x002F4396 File Offset: 0x002F2596
		public byte[] GetVarNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700664E RID: 26190
		// (get) Token: 0x06014366 RID: 82790 RVA: 0x002F43A4 File Offset: 0x002F25A4
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

		// Token: 0x06014367 RID: 82791 RVA: 0x002F43DB File Offset: 0x002F25DB
		public Span<byte> GetVarParamsBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06014368 RID: 82792 RVA: 0x002F43EA File Offset: 0x002F25EA
		public byte[] GetVarParamsArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x06014369 RID: 82793 RVA: 0x002F43F8 File Offset: 0x002F25F8
		public static Offset<IBvbCustomSystemVarFloat> CreateIBvbCustomSystemVarFloat(FlatBufferBuilder builder, ESystemVarName Type = ESystemVarName.CommonHotFixVar, StringOffset VarNameOffset = default(StringOffset), StringOffset VarParamsOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IBvbCustomSystemVarFloat.AddVarParams(builder, VarParamsOffset);
			IBvbCustomSystemVarFloat.AddVarName(builder, VarNameOffset);
			IBvbCustomSystemVarFloat.AddType(builder, Type);
			return IBvbCustomSystemVarFloat.EndIBvbCustomSystemVarFloat(builder);
		}

		// Token: 0x0601436A RID: 82794 RVA: 0x002F441C File Offset: 0x002F261C
		public static void StartIBvbCustomSystemVarFloat(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601436B RID: 82795 RVA: 0x002F4425 File Offset: 0x002F2625
		public static void AddType(FlatBufferBuilder builder, ESystemVarName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601436C RID: 82796 RVA: 0x002F4430 File Offset: 0x002F2630
		public static void AddVarName(FlatBufferBuilder builder, StringOffset varNameOffset)
		{
			builder.AddOffset(1, varNameOffset.Value, 0);
		}

		// Token: 0x0601436D RID: 82797 RVA: 0x002F4440 File Offset: 0x002F2640
		public static void AddVarParams(FlatBufferBuilder builder, StringOffset varParamsOffset)
		{
			builder.AddOffset(2, varParamsOffset.Value, 0);
		}

		// Token: 0x0601436E RID: 82798 RVA: 0x002F4450 File Offset: 0x002F2650
		public static Offset<IBvbCustomSystemVarFloat> EndIBvbCustomSystemVarFloat(FlatBufferBuilder builder)
		{
			return new Offset<IBvbCustomSystemVarFloat>(builder.EndTable());
		}

		// Token: 0x0601436F RID: 82799 RVA: 0x002F4460 File Offset: 0x002F2660
		public IBvbCustomSystemVarFloatT UnPack()
		{
			IBvbCustomSystemVarFloatT bvbCustomSystemVarFloatT = new IBvbCustomSystemVarFloatT();
			this.UnPackTo(bvbCustomSystemVarFloatT);
			return bvbCustomSystemVarFloatT;
		}

		// Token: 0x06014370 RID: 82800 RVA: 0x002F447B File Offset: 0x002F267B
		public void UnPackTo(IBvbCustomSystemVarFloatT _o)
		{
			_o.Type = this.Type;
			_o.VarName = this.VarName;
			_o.VarParams = this.VarParams;
		}

		// Token: 0x06014371 RID: 82801 RVA: 0x002F44A4 File Offset: 0x002F26A4
		public static Offset<IBvbCustomSystemVarFloat> Pack(FlatBufferBuilder builder, IBvbCustomSystemVarFloatT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbCustomSystemVarFloat>);
			}
			StringOffset varNameOffset = (_o.VarName == null) ? default(StringOffset) : builder.CreateString(_o.VarName);
			StringOffset varParamsOffset = (_o.VarParams == null) ? default(StringOffset) : builder.CreateString(_o.VarParams);
			return IBvbCustomSystemVarFloat.CreateIBvbCustomSystemVarFloat(builder, _o.Type, varNameOffset, varParamsOffset);
		}

		// Token: 0x0400AECF RID: 44751
		private Table __p;
	}
}
