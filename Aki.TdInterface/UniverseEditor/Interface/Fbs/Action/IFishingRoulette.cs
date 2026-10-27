using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067C8 RID: 26568
	public struct IFishingRoulette : IFlatbufferObject
	{
		// Token: 0x1700C535 RID: 50485
		// (get) Token: 0x0602E3F1 RID: 189425 RVA: 0x00650CD1 File Offset: 0x0064EED1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E3F2 RID: 189426 RVA: 0x00650CDE File Offset: 0x0064EEDE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E3F3 RID: 189427 RVA: 0x00650CE8 File Offset: 0x0064EEE8
		public static IFishingRoulette GetRootAsIFishingRoulette(ByteBuffer _bb)
		{
			return IFishingRoulette.GetRootAsIFishingRoulette(_bb, default(IFishingRoulette));
		}

		// Token: 0x0602E3F4 RID: 189428 RVA: 0x00650D04 File Offset: 0x0064EF04
		public static IFishingRoulette GetRootAsIFishingRoulette(ByteBuffer _bb, IFishingRoulette obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E3F5 RID: 189429 RVA: 0x00650D21 File Offset: 0x0064EF21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E3F6 RID: 189430 RVA: 0x00650D30 File Offset: 0x0064EF30
		public IFishingRoulette __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C536 RID: 50486
		// (get) Token: 0x0602E3F7 RID: 189431 RVA: 0x00650D40 File Offset: 0x0064EF40
		public ESimpleGameplayType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESimpleGameplayType.Cipher;
				}
				return (ESimpleGameplayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E3F8 RID: 189432 RVA: 0x00650D7C File Offset: 0x0064EF7C
		public static Offset<IFishingRoulette> CreateIFishingRoulette(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher)
		{
			builder.StartTable(1);
			IFishingRoulette.AddType(builder, Type);
			return IFishingRoulette.EndIFishingRoulette(builder);
		}

		// Token: 0x0602E3F9 RID: 189433 RVA: 0x00650D92 File Offset: 0x0064EF92
		public static void StartIFishingRoulette(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602E3FA RID: 189434 RVA: 0x00650D9B File Offset: 0x0064EF9B
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E3FB RID: 189435 RVA: 0x00650DA6 File Offset: 0x0064EFA6
		public static Offset<IFishingRoulette> EndIFishingRoulette(FlatBufferBuilder builder)
		{
			return new Offset<IFishingRoulette>(builder.EndTable());
		}

		// Token: 0x0602E3FC RID: 189436 RVA: 0x00650DB4 File Offset: 0x0064EFB4
		public IFishingRouletteT UnPack()
		{
			IFishingRouletteT fishingRouletteT = new IFishingRouletteT();
			this.UnPackTo(fishingRouletteT);
			return fishingRouletteT;
		}

		// Token: 0x0602E3FD RID: 189437 RVA: 0x00650DCF File Offset: 0x0064EFCF
		public void UnPackTo(IFishingRouletteT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602E3FE RID: 189438 RVA: 0x00650DE0 File Offset: 0x0064EFE0
		public static Offset<IFishingRoulette> Pack(FlatBufferBuilder builder, IFishingRouletteT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFishingRoulette>);
			}
			return IFishingRoulette.CreateIFishingRoulette(builder, _o.Type);
		}

		// Token: 0x04010EE1 RID: 69345
		private Table __p;
	}
}
