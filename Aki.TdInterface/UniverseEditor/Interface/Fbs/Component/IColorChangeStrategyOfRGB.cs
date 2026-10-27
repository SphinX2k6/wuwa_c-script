using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FBB RID: 20411
	public struct IColorChangeStrategyOfRGB : IFlatbufferObject
	{
		// Token: 0x170093D4 RID: 37844
		// (get) Token: 0x060207DB RID: 133083 RVA: 0x0048518F File Offset: 0x0048338F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060207DC RID: 133084 RVA: 0x0048519C File Offset: 0x0048339C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060207DD RID: 133085 RVA: 0x004851A4 File Offset: 0x004833A4
		public static IColorChangeStrategyOfRGB GetRootAsIColorChangeStrategyOfRGB(ByteBuffer _bb)
		{
			return IColorChangeStrategyOfRGB.GetRootAsIColorChangeStrategyOfRGB(_bb, default(IColorChangeStrategyOfRGB));
		}

		// Token: 0x060207DE RID: 133086 RVA: 0x004851C0 File Offset: 0x004833C0
		public static IColorChangeStrategyOfRGB GetRootAsIColorChangeStrategyOfRGB(ByteBuffer _bb, IColorChangeStrategyOfRGB obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060207DF RID: 133087 RVA: 0x004851DD File Offset: 0x004833DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060207E0 RID: 133088 RVA: 0x004851EC File Offset: 0x004833EC
		public IColorChangeStrategyOfRGB __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170093D5 RID: 37845
		// (get) Token: 0x060207E1 RID: 133089 RVA: 0x004851FC File Offset: 0x004833FC
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

		// Token: 0x170093D6 RID: 37846
		// (get) Token: 0x060207E2 RID: 133090 RVA: 0x00485238 File Offset: 0x00483438
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

		// Token: 0x060207E3 RID: 133091 RVA: 0x0048526F File Offset: 0x0048346F
		public Span<byte> GetBlueStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060207E4 RID: 133092 RVA: 0x0048527E File Offset: 0x0048347E
		public byte[] GetBlueStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x170093D7 RID: 37847
		// (get) Token: 0x060207E5 RID: 133093 RVA: 0x0048528C File Offset: 0x0048348C
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

		// Token: 0x060207E6 RID: 133094 RVA: 0x004852C3 File Offset: 0x004834C3
		public Span<byte> GetYellowStateBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060207E7 RID: 133095 RVA: 0x004852D2 File Offset: 0x004834D2
		public byte[] GetYellowStateArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x170093D8 RID: 37848
		// (get) Token: 0x060207E8 RID: 133096 RVA: 0x004852E0 File Offset: 0x004834E0
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

		// Token: 0x060207E9 RID: 133097 RVA: 0x00485318 File Offset: 0x00483518
		public Span<byte> GetRedStateBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060207EA RID: 133098 RVA: 0x00485328 File Offset: 0x00483528
		public byte[] GetRedStateArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x060207EB RID: 133099 RVA: 0x00485337 File Offset: 0x00483537
		public static Offset<IColorChangeStrategyOfRGB> CreateIColorChangeStrategyOfRGB(FlatBufferBuilder builder, EColorChangeStrategyOfSplineEffect Type = EColorChangeStrategyOfSplineEffect.RGB, StringOffset BlueStateOffset = default(StringOffset), StringOffset YellowStateOffset = default(StringOffset), StringOffset RedStateOffset = default(StringOffset))
		{
			builder.StartTable(4);
			IColorChangeStrategyOfRGB.AddRedState(builder, RedStateOffset);
			IColorChangeStrategyOfRGB.AddYellowState(builder, YellowStateOffset);
			IColorChangeStrategyOfRGB.AddBlueState(builder, BlueStateOffset);
			IColorChangeStrategyOfRGB.AddType(builder, Type);
			return IColorChangeStrategyOfRGB.EndIColorChangeStrategyOfRGB(builder);
		}

		// Token: 0x060207EC RID: 133100 RVA: 0x00485363 File Offset: 0x00483563
		public static void StartIColorChangeStrategyOfRGB(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060207ED RID: 133101 RVA: 0x0048536C File Offset: 0x0048356C
		public static void AddType(FlatBufferBuilder builder, EColorChangeStrategyOfSplineEffect type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060207EE RID: 133102 RVA: 0x00485377 File Offset: 0x00483577
		public static void AddBlueState(FlatBufferBuilder builder, StringOffset blueStateOffset)
		{
			builder.AddOffset(1, blueStateOffset.Value, 0);
		}

		// Token: 0x060207EF RID: 133103 RVA: 0x00485387 File Offset: 0x00483587
		public static void AddYellowState(FlatBufferBuilder builder, StringOffset yellowStateOffset)
		{
			builder.AddOffset(2, yellowStateOffset.Value, 0);
		}

		// Token: 0x060207F0 RID: 133104 RVA: 0x00485397 File Offset: 0x00483597
		public static void AddRedState(FlatBufferBuilder builder, StringOffset redStateOffset)
		{
			builder.AddOffset(3, redStateOffset.Value, 0);
		}

		// Token: 0x060207F1 RID: 133105 RVA: 0x004853A7 File Offset: 0x004835A7
		public static Offset<IColorChangeStrategyOfRGB> EndIColorChangeStrategyOfRGB(FlatBufferBuilder builder)
		{
			return new Offset<IColorChangeStrategyOfRGB>(builder.EndTable());
		}

		// Token: 0x060207F2 RID: 133106 RVA: 0x004853B4 File Offset: 0x004835B4
		public IColorChangeStrategyOfRGBT UnPack()
		{
			IColorChangeStrategyOfRGBT colorChangeStrategyOfRGBT = new IColorChangeStrategyOfRGBT();
			this.UnPackTo(colorChangeStrategyOfRGBT);
			return colorChangeStrategyOfRGBT;
		}

		// Token: 0x060207F3 RID: 133107 RVA: 0x004853CF File Offset: 0x004835CF
		public void UnPackTo(IColorChangeStrategyOfRGBT _o)
		{
			_o.Type = this.Type;
			_o.BlueState = this.BlueState;
			_o.YellowState = this.YellowState;
			_o.RedState = this.RedState;
		}

		// Token: 0x060207F4 RID: 133108 RVA: 0x00485404 File Offset: 0x00483604
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

		// Token: 0x0400DE95 RID: 56981
		private Table __p;
	}
}
