using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B00 RID: 27392
	public struct ICommonTipEnterInRange : IFlatbufferObject
	{
		// Token: 0x1700C92B RID: 51499
		// (get) Token: 0x0602F178 RID: 192888 RVA: 0x0066C5BD File Offset: 0x0066A7BD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F179 RID: 192889 RVA: 0x0066C5CA File Offset: 0x0066A7CA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F17A RID: 192890 RVA: 0x0066C5D4 File Offset: 0x0066A7D4
		public static ICommonTipEnterInRange GetRootAsICommonTipEnterInRange(ByteBuffer _bb)
		{
			return ICommonTipEnterInRange.GetRootAsICommonTipEnterInRange(_bb, default(ICommonTipEnterInRange));
		}

		// Token: 0x0602F17B RID: 192891 RVA: 0x0066C5F0 File Offset: 0x0066A7F0
		public static ICommonTipEnterInRange GetRootAsICommonTipEnterInRange(ByteBuffer _bb, ICommonTipEnterInRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F17C RID: 192892 RVA: 0x0066C60D File Offset: 0x0066A80D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F17D RID: 192893 RVA: 0x0066C61C File Offset: 0x0066A81C
		public ICommonTipEnterInRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C92C RID: 51500
		// (get) Token: 0x0602F17E RID: 192894 RVA: 0x0066C62C File Offset: 0x0066A82C
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

		// Token: 0x1700C92D RID: 51501
		// (get) Token: 0x0602F17F RID: 192895 RVA: 0x0066C668 File Offset: 0x0066A868
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

		// Token: 0x0602F180 RID: 192896 RVA: 0x0066C69F File Offset: 0x0066A89F
		public Span<byte> GetTidTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602F181 RID: 192897 RVA: 0x0066C6AE File Offset: 0x0066A8AE
		public byte[] GetTidTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602F182 RID: 192898 RVA: 0x0066C6BC File Offset: 0x0066A8BC
		public static Offset<ICommonTipEnterInRange> CreateICommonTipEnterInRange(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, StringOffset TidTextOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ICommonTipEnterInRange.AddTidText(builder, TidTextOffset);
			ICommonTipEnterInRange.AddType(builder, Type);
			return ICommonTipEnterInRange.EndICommonTipEnterInRange(builder);
		}

		// Token: 0x0602F183 RID: 192899 RVA: 0x0066C6D9 File Offset: 0x0066A8D9
		public static void StartICommonTipEnterInRange(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602F184 RID: 192900 RVA: 0x0066C6E2 File Offset: 0x0066A8E2
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F185 RID: 192901 RVA: 0x0066C6ED File Offset: 0x0066A8ED
		public static void AddTidText(FlatBufferBuilder builder, StringOffset tidTextOffset)
		{
			builder.AddOffset(1, tidTextOffset.Value, 0);
		}

		// Token: 0x0602F186 RID: 192902 RVA: 0x0066C6FD File Offset: 0x0066A8FD
		public static Offset<ICommonTipEnterInRange> EndICommonTipEnterInRange(FlatBufferBuilder builder)
		{
			return new Offset<ICommonTipEnterInRange>(builder.EndTable());
		}

		// Token: 0x0602F187 RID: 192903 RVA: 0x0066C70C File Offset: 0x0066A90C
		public ICommonTipEnterInRangeT UnPack()
		{
			ICommonTipEnterInRangeT commonTipEnterInRangeT = new ICommonTipEnterInRangeT();
			this.UnPackTo(commonTipEnterInRangeT);
			return commonTipEnterInRangeT;
		}

		// Token: 0x0602F188 RID: 192904 RVA: 0x0066C727 File Offset: 0x0066A927
		public void UnPackTo(ICommonTipEnterInRangeT _o)
		{
			_o.Type = this.Type;
			_o.TidText = this.TidText;
		}

		// Token: 0x0602F189 RID: 192905 RVA: 0x0066C744 File Offset: 0x0066A944
		public static Offset<ICommonTipEnterInRange> Pack(FlatBufferBuilder builder, ICommonTipEnterInRangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonTipEnterInRange>);
			}
			StringOffset tidTextOffset = (_o.TidText == null) ? default(StringOffset) : builder.CreateString(_o.TidText);
			return ICommonTipEnterInRange.CreateICommonTipEnterInRange(builder, _o.Type, tidTextOffset);
		}

		// Token: 0x040118B3 RID: 71859
		private Table __p;
	}
}
