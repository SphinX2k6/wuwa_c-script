using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200496A RID: 18794
	public struct IAngleRange : IFlatbufferObject
	{
		// Token: 0x170087C6 RID: 34758
		// (get) Token: 0x0601D4A2 RID: 119970 RVA: 0x00421CB1 File Offset: 0x0041FEB1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D4A3 RID: 119971 RVA: 0x00421CBE File Offset: 0x0041FEBE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D4A4 RID: 119972 RVA: 0x00421CC8 File Offset: 0x0041FEC8
		public static IAngleRange GetRootAsIAngleRange(ByteBuffer _bb)
		{
			return IAngleRange.GetRootAsIAngleRange(_bb, default(IAngleRange));
		}

		// Token: 0x0601D4A5 RID: 119973 RVA: 0x00421CE4 File Offset: 0x0041FEE4
		public static IAngleRange GetRootAsIAngleRange(ByteBuffer _bb, IAngleRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D4A6 RID: 119974 RVA: 0x00421D01 File Offset: 0x0041FF01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D4A7 RID: 119975 RVA: 0x00421D10 File Offset: 0x0041FF10
		public IAngleRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170087C7 RID: 34759
		// (get) Token: 0x0601D4A8 RID: 119976 RVA: 0x00421D20 File Offset: 0x0041FF20
		public float Min
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170087C8 RID: 34760
		// (get) Token: 0x0601D4A9 RID: 119977 RVA: 0x00421D60 File Offset: 0x0041FF60
		public float Max
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601D4AA RID: 119978 RVA: 0x00421DA0 File Offset: 0x0041FFA0
		public static Offset<IAngleRange> CreateIAngleRange(FlatBufferBuilder builder, float Min = 0f, float Max = 0f)
		{
			builder.StartTable(2);
			IAngleRange.AddMax(builder, Max);
			IAngleRange.AddMin(builder, Min);
			return IAngleRange.EndIAngleRange(builder);
		}

		// Token: 0x0601D4AB RID: 119979 RVA: 0x00421DBD File Offset: 0x0041FFBD
		public static void StartIAngleRange(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601D4AC RID: 119980 RVA: 0x00421DC6 File Offset: 0x0041FFC6
		public static void AddMin(FlatBufferBuilder builder, float min)
		{
			builder.AddFloat(0, min, 0.0);
		}

		// Token: 0x0601D4AD RID: 119981 RVA: 0x00421DD9 File Offset: 0x0041FFD9
		public static void AddMax(FlatBufferBuilder builder, float max)
		{
			builder.AddFloat(1, max, 0.0);
		}

		// Token: 0x0601D4AE RID: 119982 RVA: 0x00421DEC File Offset: 0x0041FFEC
		public static Offset<IAngleRange> EndIAngleRange(FlatBufferBuilder builder)
		{
			return new Offset<IAngleRange>(builder.EndTable());
		}

		// Token: 0x0601D4AF RID: 119983 RVA: 0x00421DFC File Offset: 0x0041FFFC
		public IAngleRangeT UnPack()
		{
			IAngleRangeT angleRangeT = new IAngleRangeT();
			this.UnPackTo(angleRangeT);
			return angleRangeT;
		}

		// Token: 0x0601D4B0 RID: 119984 RVA: 0x00421E17 File Offset: 0x00420017
		public void UnPackTo(IAngleRangeT _o)
		{
			_o.Min = this.Min;
			_o.Max = this.Max;
		}

		// Token: 0x0601D4B1 RID: 119985 RVA: 0x00421E34 File Offset: 0x00420034
		public static Offset<IAngleRange> Pack(FlatBufferBuilder builder, IAngleRangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAngleRange>);
			}
			return IAngleRange.CreateIAngleRange(builder, _o.Min, _o.Max);
		}

		// Token: 0x0400D162 RID: 53602
		private Table __p;
	}
}
