using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006011 RID: 24593
	public struct ISunSpiritGearPerformToGearRelativePos : IFlatbufferObject
	{
		// Token: 0x1700B659 RID: 46681
		// (get) Token: 0x06029736 RID: 169782 RVA: 0x005A83EF File Offset: 0x005A65EF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029737 RID: 169783 RVA: 0x005A83FC File Offset: 0x005A65FC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029738 RID: 169784 RVA: 0x005A8404 File Offset: 0x005A6604
		public static ISunSpiritGearPerformToGearRelativePos GetRootAsISunSpiritGearPerformToGearRelativePos(ByteBuffer _bb)
		{
			return ISunSpiritGearPerformToGearRelativePos.GetRootAsISunSpiritGearPerformToGearRelativePos(_bb, default(ISunSpiritGearPerformToGearRelativePos));
		}

		// Token: 0x06029739 RID: 169785 RVA: 0x005A8420 File Offset: 0x005A6620
		public static ISunSpiritGearPerformToGearRelativePos GetRootAsISunSpiritGearPerformToGearRelativePos(ByteBuffer _bb, ISunSpiritGearPerformToGearRelativePos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602973A RID: 169786 RVA: 0x005A843D File Offset: 0x005A663D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602973B RID: 169787 RVA: 0x005A844C File Offset: 0x005A664C
		public ISunSpiritGearPerformToGearRelativePos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B65A RID: 46682
		// (get) Token: 0x0602973C RID: 169788 RVA: 0x005A845C File Offset: 0x005A665C
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

		// Token: 0x0602973D RID: 169789 RVA: 0x005A8498 File Offset: 0x005A6698
		public static Offset<ISunSpiritGearPerformToGearRelativePos> CreateISunSpiritGearPerformToGearRelativePos(FlatBufferBuilder builder, ESunSpiritGearPerformType Type = ESunSpiritGearPerformType.ToGearRelativePos)
		{
			builder.StartTable(1);
			ISunSpiritGearPerformToGearRelativePos.AddType(builder, Type);
			return ISunSpiritGearPerformToGearRelativePos.EndISunSpiritGearPerformToGearRelativePos(builder);
		}

		// Token: 0x0602973E RID: 169790 RVA: 0x005A84AE File Offset: 0x005A66AE
		public static void StartISunSpiritGearPerformToGearRelativePos(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602973F RID: 169791 RVA: 0x005A84B7 File Offset: 0x005A66B7
		public static void AddType(FlatBufferBuilder builder, ESunSpiritGearPerformType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029740 RID: 169792 RVA: 0x005A84C2 File Offset: 0x005A66C2
		public static Offset<ISunSpiritGearPerformToGearRelativePos> EndISunSpiritGearPerformToGearRelativePos(FlatBufferBuilder builder)
		{
			return new Offset<ISunSpiritGearPerformToGearRelativePos>(builder.EndTable());
		}

		// Token: 0x06029741 RID: 169793 RVA: 0x005A84D0 File Offset: 0x005A66D0
		public ISunSpiritGearPerformToGearRelativePosT UnPack()
		{
			ISunSpiritGearPerformToGearRelativePosT sunSpiritGearPerformToGearRelativePosT = new ISunSpiritGearPerformToGearRelativePosT();
			this.UnPackTo(sunSpiritGearPerformToGearRelativePosT);
			return sunSpiritGearPerformToGearRelativePosT;
		}

		// Token: 0x06029742 RID: 169794 RVA: 0x005A84EB File Offset: 0x005A66EB
		public void UnPackTo(ISunSpiritGearPerformToGearRelativePosT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06029743 RID: 169795 RVA: 0x005A84FC File Offset: 0x005A66FC
		public static Offset<ISunSpiritGearPerformToGearRelativePos> Pack(FlatBufferBuilder builder, ISunSpiritGearPerformToGearRelativePosT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISunSpiritGearPerformToGearRelativePos>);
			}
			return ISunSpiritGearPerformToGearRelativePos.CreateISunSpiritGearPerformToGearRelativePos(builder, _o.Type);
		}

		// Token: 0x0400FD3E RID: 64830
		private Table __p;
	}
}
