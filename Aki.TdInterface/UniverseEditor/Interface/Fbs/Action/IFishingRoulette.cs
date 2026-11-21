using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E48 RID: 28232
	public struct IFishingRoulette : IFlatbufferObject
	{
		// Token: 0x1700CEEB RID: 52971
		// (get) Token: 0x06030C37 RID: 199735 RVA: 0x0069E415 File Offset: 0x0069C615
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030C38 RID: 199736 RVA: 0x0069E422 File Offset: 0x0069C622
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030C39 RID: 199737 RVA: 0x0069E42C File Offset: 0x0069C62C
		public static IFishingRoulette GetRootAsIFishingRoulette(ByteBuffer _bb)
		{
			return IFishingRoulette.GetRootAsIFishingRoulette(_bb, default(IFishingRoulette));
		}

		// Token: 0x06030C3A RID: 199738 RVA: 0x0069E448 File Offset: 0x0069C648
		public static IFishingRoulette GetRootAsIFishingRoulette(ByteBuffer _bb, IFishingRoulette obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030C3B RID: 199739 RVA: 0x0069E465 File Offset: 0x0069C665
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030C3C RID: 199740 RVA: 0x0069E474 File Offset: 0x0069C674
		public IFishingRoulette __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CEEC RID: 52972
		// (get) Token: 0x06030C3D RID: 199741 RVA: 0x0069E484 File Offset: 0x0069C684
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

		// Token: 0x06030C3E RID: 199742 RVA: 0x0069E4C0 File Offset: 0x0069C6C0
		public static Offset<IFishingRoulette> CreateIFishingRoulette(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher)
		{
			builder.StartTable(1);
			IFishingRoulette.AddType(builder, Type);
			return IFishingRoulette.EndIFishingRoulette(builder);
		}

		// Token: 0x06030C3F RID: 199743 RVA: 0x0069E4D6 File Offset: 0x0069C6D6
		public static void StartIFishingRoulette(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06030C40 RID: 199744 RVA: 0x0069E4DF File Offset: 0x0069C6DF
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030C41 RID: 199745 RVA: 0x0069E4EA File Offset: 0x0069C6EA
		public static Offset<IFishingRoulette> EndIFishingRoulette(FlatBufferBuilder builder)
		{
			return new Offset<IFishingRoulette>(builder.EndTable());
		}

		// Token: 0x06030C42 RID: 199746 RVA: 0x0069E4F8 File Offset: 0x0069C6F8
		public IFishingRouletteT UnPack()
		{
			IFishingRouletteT fishingRouletteT = new IFishingRouletteT();
			this.UnPackTo(fishingRouletteT);
			return fishingRouletteT;
		}

		// Token: 0x06030C43 RID: 199747 RVA: 0x0069E513 File Offset: 0x0069C713
		public void UnPackTo(IFishingRouletteT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06030C44 RID: 199748 RVA: 0x0069E524 File Offset: 0x0069C724
		public static Offset<IFishingRoulette> Pack(FlatBufferBuilder builder, IFishingRouletteT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFishingRoulette>);
			}
			return IFishingRoulette.CreateIFishingRoulette(builder, _o.Type);
		}

		// Token: 0x04011D13 RID: 72979
		private Table __p;
	}
}
