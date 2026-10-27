using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A04 RID: 23044
	public struct ISunSpiritGearPerformToGearRelativePos : IFlatbufferObject
	{
		// Token: 0x1700AD21 RID: 44321
		// (get) Token: 0x060271BE RID: 160190 RVA: 0x0056142B File Offset: 0x0055F62B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060271BF RID: 160191 RVA: 0x00561438 File Offset: 0x0055F638
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060271C0 RID: 160192 RVA: 0x00561440 File Offset: 0x0055F640
		public static ISunSpiritGearPerformToGearRelativePos GetRootAsISunSpiritGearPerformToGearRelativePos(ByteBuffer _bb)
		{
			return ISunSpiritGearPerformToGearRelativePos.GetRootAsISunSpiritGearPerformToGearRelativePos(_bb, default(ISunSpiritGearPerformToGearRelativePos));
		}

		// Token: 0x060271C1 RID: 160193 RVA: 0x0056145C File Offset: 0x0055F65C
		public static ISunSpiritGearPerformToGearRelativePos GetRootAsISunSpiritGearPerformToGearRelativePos(ByteBuffer _bb, ISunSpiritGearPerformToGearRelativePos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060271C2 RID: 160194 RVA: 0x00561479 File Offset: 0x0055F679
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060271C3 RID: 160195 RVA: 0x00561488 File Offset: 0x0055F688
		public ISunSpiritGearPerformToGearRelativePos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AD22 RID: 44322
		// (get) Token: 0x060271C4 RID: 160196 RVA: 0x00561498 File Offset: 0x0055F698
		public ESunSpiritGearPerformType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESunSpiritGearPerformType.ToGearRelativePos;
				}
				return (ESunSpiritGearPerformType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060271C5 RID: 160197 RVA: 0x005614D4 File Offset: 0x0055F6D4
		public static Offset<ISunSpiritGearPerformToGearRelativePos> CreateISunSpiritGearPerformToGearRelativePos(FlatBufferBuilder builder, ESunSpiritGearPerformType Type = ESunSpiritGearPerformType.ToGearRelativePos)
		{
			builder.StartTable(1);
			ISunSpiritGearPerformToGearRelativePos.AddType(builder, Type);
			return ISunSpiritGearPerformToGearRelativePos.EndISunSpiritGearPerformToGearRelativePos(builder);
		}

		// Token: 0x060271C6 RID: 160198 RVA: 0x005614EA File Offset: 0x0055F6EA
		public static void StartISunSpiritGearPerformToGearRelativePos(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060271C7 RID: 160199 RVA: 0x005614F3 File Offset: 0x0055F6F3
		public static void AddType(FlatBufferBuilder builder, ESunSpiritGearPerformType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060271C8 RID: 160200 RVA: 0x005614FE File Offset: 0x0055F6FE
		public static Offset<ISunSpiritGearPerformToGearRelativePos> EndISunSpiritGearPerformToGearRelativePos(FlatBufferBuilder builder)
		{
			return new Offset<ISunSpiritGearPerformToGearRelativePos>(builder.EndTable());
		}

		// Token: 0x060271C9 RID: 160201 RVA: 0x0056150C File Offset: 0x0055F70C
		public ISunSpiritGearPerformToGearRelativePosT UnPack()
		{
			ISunSpiritGearPerformToGearRelativePosT sunSpiritGearPerformToGearRelativePosT = new ISunSpiritGearPerformToGearRelativePosT();
			this.UnPackTo(sunSpiritGearPerformToGearRelativePosT);
			return sunSpiritGearPerformToGearRelativePosT;
		}

		// Token: 0x060271CA RID: 160202 RVA: 0x00561527 File Offset: 0x0055F727
		public void UnPackTo(ISunSpiritGearPerformToGearRelativePosT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060271CB RID: 160203 RVA: 0x00561538 File Offset: 0x0055F738
		public static Offset<ISunSpiritGearPerformToGearRelativePos> Pack(FlatBufferBuilder builder, ISunSpiritGearPerformToGearRelativePosT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISunSpiritGearPerformToGearRelativePos>);
			}
			return ISunSpiritGearPerformToGearRelativePos.CreateISunSpiritGearPerformToGearRelativePos(builder, _o.Type);
		}

		// Token: 0x0400F047 RID: 61511
		private Table __p;
	}
}
