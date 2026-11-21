using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005517 RID: 21783
	public struct IColorChangeStrategyOfRGB : IFlatbufferObject
	{
		// Token: 0x17009BAC RID: 39852
		// (get) Token: 0x060226CF RID: 141007 RVA: 0x004BE673 File Offset: 0x004BC873
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060226D0 RID: 141008 RVA: 0x004BE680 File Offset: 0x004BC880
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060226D1 RID: 141009 RVA: 0x004BE688 File Offset: 0x004BC888
		public static IColorChangeStrategyOfRGB GetRootAsIColorChangeStrategyOfRGB(ByteBuffer _bb)
		{
			return IColorChangeStrategyOfRGB.GetRootAsIColorChangeStrategyOfRGB(_bb, default(IColorChangeStrategyOfRGB));
		}

		// Token: 0x060226D2 RID: 141010 RVA: 0x004BE6A4 File Offset: 0x004BC8A4
		public static IColorChangeStrategyOfRGB GetRootAsIColorChangeStrategyOfRGB(ByteBuffer _bb, IColorChangeStrategyOfRGB obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060226D3 RID: 141011 RVA: 0x004BE6C1 File Offset: 0x004BC8C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060226D4 RID: 141012 RVA: 0x004BE6D0 File Offset: 0x004BC8D0
		public IColorChangeStrategyOfRGB __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009BAD RID: 39853
		// (get) Token: 0x060226D5 RID: 141013 RVA: 0x004BE6E0 File Offset: 0x004BC8E0
		public EColorChangeStrategyOfSplineEffect Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EColorChangeStrategyOfSplineEffect.RGB;
				}
				return (EColorChangeStrategyOfSplineEffect)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009BAE RID: 39854
		// (get) Token: 0x060226D6 RID: 141014 RVA: 0x004BE71C File Offset: 0x004BC91C
		public string BlueState
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

		// Token: 0x060226D7 RID: 141015 RVA: 0x004BE753 File Offset: 0x004BC953
		public Span<byte> GetBlueStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060226D8 RID: 141016 RVA: 0x004BE762 File Offset: 0x004BC962
		public byte[] GetBlueStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17009BAF RID: 39855
		// (get) Token: 0x060226D9 RID: 141017 RVA: 0x004BE770 File Offset: 0x004BC970
		public string YellowState
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

		// Token: 0x060226DA RID: 141018 RVA: 0x004BE7A7 File Offset: 0x004BC9A7
		public Span<byte> GetYellowStateBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060226DB RID: 141019 RVA: 0x004BE7B6 File Offset: 0x004BC9B6
		public byte[] GetYellowStateArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17009BB0 RID: 39856
		// (get) Token: 0x060226DC RID: 141020 RVA: 0x004BE7C4 File Offset: 0x004BC9C4
		public string RedState
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060226DD RID: 141021 RVA: 0x004BE7FC File Offset: 0x004BC9FC
		public Span<byte> GetRedStateBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060226DE RID: 141022 RVA: 0x004BE80C File Offset: 0x004BCA0C
		public byte[] GetRedStateArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x060226DF RID: 141023 RVA: 0x004BE81B File Offset: 0x004BCA1B
		public static Offset<IColorChangeStrategyOfRGB> CreateIColorChangeStrategyOfRGB(FlatBufferBuilder builder, EColorChangeStrategyOfSplineEffect Type = EColorChangeStrategyOfSplineEffect.RGB, StringOffset BlueStateOffset = default(StringOffset), StringOffset YellowStateOffset = default(StringOffset), StringOffset RedStateOffset = default(StringOffset))
		{
			builder.StartTable(4);
			IColorChangeStrategyOfRGB.AddRedState(builder, RedStateOffset);
			IColorChangeStrategyOfRGB.AddYellowState(builder, YellowStateOffset);
			IColorChangeStrategyOfRGB.AddBlueState(builder, BlueStateOffset);
			IColorChangeStrategyOfRGB.AddType(builder, Type);
			return IColorChangeStrategyOfRGB.EndIColorChangeStrategyOfRGB(builder);
		}

		// Token: 0x060226E0 RID: 141024 RVA: 0x004BE847 File Offset: 0x004BCA47
		public static void StartIColorChangeStrategyOfRGB(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060226E1 RID: 141025 RVA: 0x004BE850 File Offset: 0x004BCA50
		public static void AddType(FlatBufferBuilder builder, EColorChangeStrategyOfSplineEffect type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060226E2 RID: 141026 RVA: 0x004BE85B File Offset: 0x004BCA5B
		public static void AddBlueState(FlatBufferBuilder builder, StringOffset blueStateOffset)
		{
			builder.AddOffset(1, blueStateOffset.Value, 0);
		}

		// Token: 0x060226E3 RID: 141027 RVA: 0x004BE86B File Offset: 0x004BCA6B
		public static void AddYellowState(FlatBufferBuilder builder, StringOffset yellowStateOffset)
		{
			builder.AddOffset(2, yellowStateOffset.Value, 0);
		}

		// Token: 0x060226E4 RID: 141028 RVA: 0x004BE87B File Offset: 0x004BCA7B
		public static void AddRedState(FlatBufferBuilder builder, StringOffset redStateOffset)
		{
			builder.AddOffset(3, redStateOffset.Value, 0);
		}

		// Token: 0x060226E5 RID: 141029 RVA: 0x004BE88B File Offset: 0x004BCA8B
		public static Offset<IColorChangeStrategyOfRGB> EndIColorChangeStrategyOfRGB(FlatBufferBuilder builder)
		{
			return new Offset<IColorChangeStrategyOfRGB>(builder.EndTable());
		}

		// Token: 0x060226E6 RID: 141030 RVA: 0x004BE898 File Offset: 0x004BCA98
		public IColorChangeStrategyOfRGBT UnPack()
		{
			IColorChangeStrategyOfRGBT colorChangeStrategyOfRGBT = new IColorChangeStrategyOfRGBT();
			this.UnPackTo(colorChangeStrategyOfRGBT);
			return colorChangeStrategyOfRGBT;
		}

		// Token: 0x060226E7 RID: 141031 RVA: 0x004BE8B3 File Offset: 0x004BCAB3
		public void UnPackTo(IColorChangeStrategyOfRGBT _o)
		{
			_o.Type = this.Type;
			_o.BlueState = this.BlueState;
			_o.YellowState = this.YellowState;
			_o.RedState = this.RedState;
		}

		// Token: 0x060226E8 RID: 141032 RVA: 0x004BE8E8 File Offset: 0x004BCAE8
		public static Offset<IColorChangeStrategyOfRGB> Pack(FlatBufferBuilder builder, IColorChangeStrategyOfRGBT _o)
		{
			if (_o == null)
			{
				return default(Offset<IColorChangeStrategyOfRGB>);
			}
			StringOffset blueStateOffset = (_o.BlueState == null) ? default(StringOffset) : builder.CreateString(_o.BlueState);
			StringOffset yellowStateOffset = (_o.YellowState == null) ? default(StringOffset) : builder.CreateString(_o.YellowState);
			StringOffset redStateOffset = (_o.RedState == null) ? default(StringOffset) : builder.CreateString(_o.RedState);
			return IColorChangeStrategyOfRGB.CreateIColorChangeStrategyOfRGB(builder, _o.Type, blueStateOffset, yellowStateOffset, redStateOffset);
		}

		// Token: 0x0400EA83 RID: 60035
		private Table __p;
	}
}
