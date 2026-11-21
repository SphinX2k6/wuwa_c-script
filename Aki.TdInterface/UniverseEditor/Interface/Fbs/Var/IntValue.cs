using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EA7 RID: 16039
	public struct IntValue : IFlatbufferObject
	{
		// Token: 0x17006C8C RID: 27788
		// (get) Token: 0x06015AF2 RID: 88818 RVA: 0x0031F7C8 File Offset: 0x0031D9C8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015AF3 RID: 88819 RVA: 0x0031F7D5 File Offset: 0x0031D9D5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015AF4 RID: 88820 RVA: 0x0031F7DC File Offset: 0x0031D9DC
		public static IntValue GetRootAsIntValue(ByteBuffer _bb)
		{
			return IntValue.GetRootAsIntValue(_bb, default(IntValue));
		}

		// Token: 0x06015AF5 RID: 88821 RVA: 0x0031F7F8 File Offset: 0x0031D9F8
		public static IntValue GetRootAsIntValue(ByteBuffer _bb, IntValue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015AF6 RID: 88822 RVA: 0x0031F815 File Offset: 0x0031DA15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015AF7 RID: 88823 RVA: 0x0031F824 File Offset: 0x0031DA24
		public IntValue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006C8D RID: 27789
		// (get) Token: 0x06015AF8 RID: 88824 RVA: 0x0031F834 File Offset: 0x0031DA34
		public int Value
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06015AF9 RID: 88825 RVA: 0x0031F870 File Offset: 0x0031DA70
		public static Offset<IntValue> CreateIntValue(FlatBufferBuilder builder, int value = 0)
		{
			builder.StartTable(1);
			IntValue.AddValue(builder, value);
			return IntValue.EndIntValue(builder);
		}

		// Token: 0x06015AFA RID: 88826 RVA: 0x0031F886 File Offset: 0x0031DA86
		public static void StartIntValue(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06015AFB RID: 88827 RVA: 0x0031F88F File Offset: 0x0031DA8F
		public static void AddValue(FlatBufferBuilder builder, int value)
		{
			builder.AddInt(0, value, 0);
		}

		// Token: 0x06015AFC RID: 88828 RVA: 0x0031F89A File Offset: 0x0031DA9A
		public static Offset<IntValue> EndIntValue(FlatBufferBuilder builder)
		{
			return new Offset<IntValue>(builder.EndTable());
		}

		// Token: 0x06015AFD RID: 88829 RVA: 0x0031F8A8 File Offset: 0x0031DAA8
		public IntValueT UnPack()
		{
			IntValueT intValueT = new IntValueT();
			this.UnPackTo(intValueT);
			return intValueT;
		}

		// Token: 0x06015AFE RID: 88830 RVA: 0x0031F8C3 File Offset: 0x0031DAC3
		public void UnPackTo(IntValueT _o)
		{
			_o.Value = this.Value;
		}

		// Token: 0x06015AFF RID: 88831 RVA: 0x0031F8D4 File Offset: 0x0031DAD4
		public static Offset<IntValue> Pack(FlatBufferBuilder builder, IntValueT _o)
		{
			if (_o == null)
			{
				return default(Offset<IntValue>);
			}
			return IntValue.CreateIntValue(builder, _o.Value);
		}

		// Token: 0x0400B89C RID: 47260
		private Table __p;
	}
}
