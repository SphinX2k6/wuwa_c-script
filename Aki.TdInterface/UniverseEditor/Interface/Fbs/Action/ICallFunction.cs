using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068E3 RID: 26851
	public struct ICallFunction : IFlatbufferObject
	{
		// Token: 0x1700C55A RID: 50522
		// (get) Token: 0x0602DF5A RID: 188250 RVA: 0x00648324 File Offset: 0x00646524
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DF5B RID: 188251 RVA: 0x00648331 File Offset: 0x00646531
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DF5C RID: 188252 RVA: 0x00648338 File Offset: 0x00646538
		public static ICallFunction GetRootAsICallFunction(ByteBuffer _bb)
		{
			return ICallFunction.GetRootAsICallFunction(_bb, default(ICallFunction));
		}

		// Token: 0x0602DF5D RID: 188253 RVA: 0x00648354 File Offset: 0x00646554
		public static ICallFunction GetRootAsICallFunction(ByteBuffer _bb, ICallFunction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DF5E RID: 188254 RVA: 0x00648371 File Offset: 0x00646571
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DF5F RID: 188255 RVA: 0x00648380 File Offset: 0x00646580
		public ICallFunction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C55B RID: 50523
		// (get) Token: 0x0602DF60 RID: 188256 RVA: 0x00648390 File Offset: 0x00646590
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

		// Token: 0x0602DF61 RID: 188257 RVA: 0x006483C7 File Offset: 0x006465C7
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602DF62 RID: 188258 RVA: 0x006483D6 File Offset: 0x006465D6
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0602DF63 RID: 188259 RVA: 0x006483E4 File Offset: 0x006465E4
		public static Offset<ICallFunction> CreateICallFunction(FlatBufferBuilder builder, StringOffset NameOffset = default(StringOffset))
		{
			builder.StartTable(1);
			ICallFunction.AddName(builder, NameOffset);
			return ICallFunction.EndICallFunction(builder);
		}

		// Token: 0x0602DF64 RID: 188260 RVA: 0x006483FA File Offset: 0x006465FA
		public static void StartICallFunction(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602DF65 RID: 188261 RVA: 0x00648403 File Offset: 0x00646603
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(0, nameOffset.Value, 0);
		}

		// Token: 0x0602DF66 RID: 188262 RVA: 0x00648413 File Offset: 0x00646613
		public static Offset<ICallFunction> EndICallFunction(FlatBufferBuilder builder)
		{
			return new Offset<ICallFunction>(builder.EndTable());
		}

		// Token: 0x0602DF67 RID: 188263 RVA: 0x00648420 File Offset: 0x00646620
		public ICallFunctionT UnPack()
		{
			ICallFunctionT callFunctionT = new ICallFunctionT();
			this.UnPackTo(callFunctionT);
			return callFunctionT;
		}

		// Token: 0x0602DF68 RID: 188264 RVA: 0x0064843B File Offset: 0x0064663B
		public void UnPackTo(ICallFunctionT _o)
		{
			_o.Name = this.Name;
		}

		// Token: 0x0602DF69 RID: 188265 RVA: 0x0064844C File Offset: 0x0064664C
		public static Offset<ICallFunction> Pack(FlatBufferBuilder builder, ICallFunctionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICallFunction>);
			}
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			return ICallFunction.CreateICallFunction(builder, nameOffset);
		}

		// Token: 0x040115E5 RID: 71141
		private Table __p;
	}
}
