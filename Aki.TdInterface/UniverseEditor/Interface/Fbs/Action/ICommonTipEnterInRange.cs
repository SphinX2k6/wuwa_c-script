using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006495 RID: 25749
	public struct ICommonTipEnterInRange : IFlatbufferObject
	{
		// Token: 0x1700BF9E RID: 49054
		// (get) Token: 0x0602C9FE RID: 182782 RVA: 0x006209E9 File Offset: 0x0061EBE9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C9FF RID: 182783 RVA: 0x006209F6 File Offset: 0x0061EBF6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CA00 RID: 182784 RVA: 0x00620A00 File Offset: 0x0061EC00
		public static ICommonTipEnterInRange GetRootAsICommonTipEnterInRange(ByteBuffer _bb)
		{
			return ICommonTipEnterInRange.GetRootAsICommonTipEnterInRange(_bb, default(ICommonTipEnterInRange));
		}

		// Token: 0x0602CA01 RID: 182785 RVA: 0x00620A1C File Offset: 0x0061EC1C
		public static ICommonTipEnterInRange GetRootAsICommonTipEnterInRange(ByteBuffer _bb, ICommonTipEnterInRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CA02 RID: 182786 RVA: 0x00620A39 File Offset: 0x0061EC39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CA03 RID: 182787 RVA: 0x00620A48 File Offset: 0x0061EC48
		public ICommonTipEnterInRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BF9F RID: 49055
		// (get) Token: 0x0602CA04 RID: 182788 RVA: 0x00620A58 File Offset: 0x0061EC58
		public ECommonTipType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECommonTipType.ChallengeCondition;
				}
				return (ECommonTipType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BFA0 RID: 49056
		// (get) Token: 0x0602CA05 RID: 182789 RVA: 0x00620A94 File Offset: 0x0061EC94
		public string TidText
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

		// Token: 0x0602CA06 RID: 182790 RVA: 0x00620ACB File Offset: 0x0061ECCB
		public Span<byte> GetTidTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602CA07 RID: 182791 RVA: 0x00620ADA File Offset: 0x0061ECDA
		public byte[] GetTidTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602CA08 RID: 182792 RVA: 0x00620AE8 File Offset: 0x0061ECE8
		public static Offset<ICommonTipEnterInRange> CreateICommonTipEnterInRange(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, StringOffset TidTextOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ICommonTipEnterInRange.AddTidText(builder, TidTextOffset);
			ICommonTipEnterInRange.AddType(builder, Type);
			return ICommonTipEnterInRange.EndICommonTipEnterInRange(builder);
		}

		// Token: 0x0602CA09 RID: 182793 RVA: 0x00620B05 File Offset: 0x0061ED05
		public static void StartICommonTipEnterInRange(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602CA0A RID: 182794 RVA: 0x00620B0E File Offset: 0x0061ED0E
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CA0B RID: 182795 RVA: 0x00620B19 File Offset: 0x0061ED19
		public static void AddTidText(FlatBufferBuilder builder, StringOffset tidTextOffset)
		{
			builder.AddOffset(1, tidTextOffset.Value, 0);
		}

		// Token: 0x0602CA0C RID: 182796 RVA: 0x00620B29 File Offset: 0x0061ED29
		public static Offset<ICommonTipEnterInRange> EndICommonTipEnterInRange(FlatBufferBuilder builder)
		{
			return new Offset<ICommonTipEnterInRange>(builder.EndTable());
		}

		// Token: 0x0602CA0D RID: 182797 RVA: 0x00620B38 File Offset: 0x0061ED38
		public ICommonTipEnterInRangeT UnPack()
		{
			ICommonTipEnterInRangeT commonTipEnterInRangeT = new ICommonTipEnterInRangeT();
			this.UnPackTo(commonTipEnterInRangeT);
			return commonTipEnterInRangeT;
		}

		// Token: 0x0602CA0E RID: 182798 RVA: 0x00620B53 File Offset: 0x0061ED53
		public void UnPackTo(ICommonTipEnterInRangeT _o)
		{
			_o.Type = this.Type;
			_o.TidText = this.TidText;
		}

		// Token: 0x0602CA0F RID: 182799 RVA: 0x00620B70 File Offset: 0x0061ED70
		public static Offset<ICommonTipEnterInRange> Pack(FlatBufferBuilder builder, ICommonTipEnterInRangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonTipEnterInRange>);
			}
			StringOffset tidTextOffset = (_o.TidText == null) ? default(StringOffset) : builder.CreateString(_o.TidText);
			return ICommonTipEnterInRange.CreateICommonTipEnterInRange(builder, _o.Type, tidTextOffset);
		}

		// Token: 0x04010AA2 RID: 68258
		private Table __p;
	}
}
