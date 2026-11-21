using System;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200725E RID: 29278
	public struct IMotorRadioDisableByAbsoluteRange : IFlatbufferObject
	{
		// Token: 0x1700D6AE RID: 54958
		// (get) Token: 0x06033031 RID: 208945 RVA: 0x006E2D64 File Offset: 0x006E0F64
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033032 RID: 208946 RVA: 0x006E2D71 File Offset: 0x006E0F71
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033033 RID: 208947 RVA: 0x006E2D78 File Offset: 0x006E0F78
		public static IMotorRadioDisableByAbsoluteRange GetRootAsIMotorRadioDisableByAbsoluteRange(ByteBuffer _bb)
		{
			return IMotorRadioDisableByAbsoluteRange.GetRootAsIMotorRadioDisableByAbsoluteRange(_bb, default(IMotorRadioDisableByAbsoluteRange));
		}

		// Token: 0x06033034 RID: 208948 RVA: 0x006E2D94 File Offset: 0x006E0F94
		public static IMotorRadioDisableByAbsoluteRange GetRootAsIMotorRadioDisableByAbsoluteRange(ByteBuffer _bb, IMotorRadioDisableByAbsoluteRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033035 RID: 208949 RVA: 0x006E2DB1 File Offset: 0x006E0FB1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033036 RID: 208950 RVA: 0x006E2DC0 File Offset: 0x006E0FC0
		public IMotorRadioDisableByAbsoluteRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D6AF RID: 54959
		// (get) Token: 0x06033037 RID: 208951 RVA: 0x006E2DD0 File Offset: 0x006E0FD0
		public EMotorRadioDisableRangeType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMotorRadioDisableRangeType.ByAreaId;
				}
				return (EMotorRadioDisableRangeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D6B0 RID: 54960
		// (get) Token: 0x06033038 RID: 208952 RVA: 0x006E2E0C File Offset: 0x006E100C
		public TRange RangeType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TRange.NONE;
				}
				return (TRange)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033039 RID: 208953 RVA: 0x006E2E48 File Offset: 0x006E1048
		public TTable? Range<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603303A RID: 208954 RVA: 0x006E2E8C File Offset: 0x006E108C
		public IBoxRange RangeAsIBoxRange()
		{
			return this.Range<IBoxRange>().Value;
		}

		// Token: 0x0603303B RID: 208955 RVA: 0x006E2EA8 File Offset: 0x006E10A8
		public ICircleRange RangeAsICircleRange()
		{
			return this.Range<ICircleRange>().Value;
		}

		// Token: 0x0603303C RID: 208956 RVA: 0x006E2EC4 File Offset: 0x006E10C4
		public ICylinder RangeAsICylinder()
		{
			return this.Range<ICylinder>().Value;
		}

		// Token: 0x1700D6B1 RID: 54961
		// (get) Token: 0x0603303D RID: 208957 RVA: 0x006E2EE0 File Offset: 0x006E10E0
		public int ExtraRange
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603303E RID: 208958 RVA: 0x006E2F1D File Offset: 0x006E111D
		public static Offset<IMotorRadioDisableByAbsoluteRange> CreateIMotorRadioDisableByAbsoluteRange(FlatBufferBuilder builder, EMotorRadioDisableRangeType Type = EMotorRadioDisableRangeType.ByAreaId, TRange Range_type = TRange.NONE, int RangeOffset = 0, int ExtraRange = 0)
		{
			builder.StartTable(4);
			IMotorRadioDisableByAbsoluteRange.AddExtraRange(builder, ExtraRange);
			IMotorRadioDisableByAbsoluteRange.AddRange(builder, RangeOffset);
			IMotorRadioDisableByAbsoluteRange.AddRangeType(builder, Range_type);
			IMotorRadioDisableByAbsoluteRange.AddType(builder, Type);
			return IMotorRadioDisableByAbsoluteRange.EndIMotorRadioDisableByAbsoluteRange(builder);
		}

		// Token: 0x0603303F RID: 208959 RVA: 0x006E2F49 File Offset: 0x006E1149
		public static void StartIMotorRadioDisableByAbsoluteRange(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06033040 RID: 208960 RVA: 0x006E2F52 File Offset: 0x006E1152
		public static void AddType(FlatBufferBuilder builder, EMotorRadioDisableRangeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033041 RID: 208961 RVA: 0x006E2F5D File Offset: 0x006E115D
		public static void AddRangeType(FlatBufferBuilder builder, TRange rangeType)
		{
			builder.AddByte(1, (byte)rangeType, 0);
		}

		// Token: 0x06033042 RID: 208962 RVA: 0x006E2F68 File Offset: 0x006E1168
		public static void AddRange(FlatBufferBuilder builder, int rangeOffset)
		{
			builder.AddOffset(2, rangeOffset, 0);
		}

		// Token: 0x06033043 RID: 208963 RVA: 0x006E2F73 File Offset: 0x006E1173
		public static void AddExtraRange(FlatBufferBuilder builder, int extraRange)
		{
			builder.AddInt(3, extraRange, 0);
		}

		// Token: 0x06033044 RID: 208964 RVA: 0x006E2F7E File Offset: 0x006E117E
		public static Offset<IMotorRadioDisableByAbsoluteRange> EndIMotorRadioDisableByAbsoluteRange(FlatBufferBuilder builder)
		{
			return new Offset<IMotorRadioDisableByAbsoluteRange>(builder.EndTable());
		}

		// Token: 0x06033045 RID: 208965 RVA: 0x006E2F8C File Offset: 0x006E118C
		public IMotorRadioDisableByAbsoluteRangeT UnPack()
		{
			IMotorRadioDisableByAbsoluteRangeT motorRadioDisableByAbsoluteRangeT = new IMotorRadioDisableByAbsoluteRangeT();
			this.UnPackTo(motorRadioDisableByAbsoluteRangeT);
			return motorRadioDisableByAbsoluteRangeT;
		}

		// Token: 0x06033046 RID: 208966 RVA: 0x006E2FA8 File Offset: 0x006E11A8
		public void UnPackTo(IMotorRadioDisableByAbsoluteRangeT _o)
		{
			_o.Type = this.Type;
			_o.Range = new TRangeUnion();
			_o.Range.Type = this.RangeType;
			switch (this.RangeType)
			{
			case TRange.IBoxRange:
				_o.Range.Value = ((this.Range<IBoxRange>() != null) ? this.Range<IBoxRange>().Value.UnPack() : null);
				break;
			case TRange.ICircleRange:
				_o.Range.Value = ((this.Range<ICircleRange>() != null) ? this.Range<ICircleRange>().Value.UnPack() : null);
				break;
			case TRange.ICylinder:
				_o.Range.Value = ((this.Range<ICylinder>() != null) ? this.Range<ICylinder>().Value.UnPack() : null);
				break;
			}
			_o.ExtraRange = this.ExtraRange;
		}

		// Token: 0x06033047 RID: 208967 RVA: 0x006E30B0 File Offset: 0x006E12B0
		public static Offset<IMotorRadioDisableByAbsoluteRange> Pack(FlatBufferBuilder builder, IMotorRadioDisableByAbsoluteRangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorRadioDisableByAbsoluteRange>);
			}
			TRange range_type = (_o.Range == null) ? TRange.NONE : _o.Range.Type;
			int rangeOffset = (_o.Range == null) ? 0 : TRangeUnion.Pack(builder, _o.Range);
			return IMotorRadioDisableByAbsoluteRange.CreateIMotorRadioDisableByAbsoluteRange(builder, _o.Type, range_type, rangeOffset, _o.ExtraRange);
		}

		// Token: 0x040122D0 RID: 74448
		private Table __p;
	}
}
