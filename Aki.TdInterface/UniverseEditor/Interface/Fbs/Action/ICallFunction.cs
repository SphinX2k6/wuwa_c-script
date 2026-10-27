using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006272 RID: 25202
	public struct ICallFunction : IFlatbufferObject
	{
		// Token: 0x1700BBD2 RID: 48082
		// (get) Token: 0x0602B7F9 RID: 178169 RVA: 0x005FD51C File Offset: 0x005FB71C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B7FA RID: 178170 RVA: 0x005FD529 File Offset: 0x005FB729
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B7FB RID: 178171 RVA: 0x005FD530 File Offset: 0x005FB730
		public static ICallFunction GetRootAsICallFunction(ByteBuffer _bb)
		{
			return ICallFunction.GetRootAsICallFunction(_bb, default(ICallFunction));
		}

		// Token: 0x0602B7FC RID: 178172 RVA: 0x005FD54C File Offset: 0x005FB74C
		public static ICallFunction GetRootAsICallFunction(ByteBuffer _bb, ICallFunction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B7FD RID: 178173 RVA: 0x005FD569 File Offset: 0x005FB769
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B7FE RID: 178174 RVA: 0x005FD578 File Offset: 0x005FB778
		public ICallFunction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BBD3 RID: 48083
		// (get) Token: 0x0602B7FF RID: 178175 RVA: 0x005FD588 File Offset: 0x005FB788
		public string Name
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

		// Token: 0x0602B800 RID: 178176 RVA: 0x005FD5BF File Offset: 0x005FB7BF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602B801 RID: 178177 RVA: 0x005FD5CE File Offset: 0x005FB7CE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0602B802 RID: 178178 RVA: 0x005FD5DC File Offset: 0x005FB7DC
		public static Offset<ICallFunction> CreateICallFunction(FlatBufferBuilder builder, StringOffset NameOffset = default(StringOffset))
		{
			builder.StartTable(1);
			ICallFunction.AddName(builder, NameOffset);
			return ICallFunction.EndICallFunction(builder);
		}

		// Token: 0x0602B803 RID: 178179 RVA: 0x005FD5F2 File Offset: 0x005FB7F2
		public static void StartICallFunction(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602B804 RID: 178180 RVA: 0x005FD5FB File Offset: 0x005FB7FB
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(0, nameOffset.Value, 0);
		}

		// Token: 0x0602B805 RID: 178181 RVA: 0x005FD60B File Offset: 0x005FB80B
		public static Offset<ICallFunction> EndICallFunction(FlatBufferBuilder builder)
		{
			return new Offset<ICallFunction>(builder.EndTable());
		}

		// Token: 0x0602B806 RID: 178182 RVA: 0x005FD618 File Offset: 0x005FB818
		public ICallFunctionT UnPack()
		{
			ICallFunctionT callFunctionT = new ICallFunctionT();
			this.UnPackTo(callFunctionT);
			return callFunctionT;
		}

		// Token: 0x0602B807 RID: 178183 RVA: 0x005FD633 File Offset: 0x005FB833
		public void UnPackTo(ICallFunctionT _o)
		{
			_o.Name = this.Name;
		}

		// Token: 0x0602B808 RID: 178184 RVA: 0x005FD644 File Offset: 0x005FB844
		public static Offset<ICallFunction> Pack(FlatBufferBuilder builder, ICallFunctionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICallFunction>);
			}
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			return ICallFunction.CreateICallFunction(builder, nameOffset);
		}

		// Token: 0x040107D0 RID: 67536
		private Table __p;
	}
}
