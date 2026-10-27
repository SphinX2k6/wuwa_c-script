using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BF8 RID: 19448
	public struct IDistanceRange : IFlatbufferObject
	{
		// Token: 0x17008D44 RID: 36164
		// (get) Token: 0x0601ECAB RID: 126123 RVA: 0x00450309 File Offset: 0x0044E509
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601ECAC RID: 126124 RVA: 0x00450316 File Offset: 0x0044E516
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601ECAD RID: 126125 RVA: 0x00450320 File Offset: 0x0044E520
		public static IDistanceRange GetRootAsIDistanceRange(ByteBuffer _bb)
		{
			return IDistanceRange.GetRootAsIDistanceRange(_bb, default(IDistanceRange));
		}

		// Token: 0x0601ECAE RID: 126126 RVA: 0x0045033C File Offset: 0x0044E53C
		public static IDistanceRange GetRootAsIDistanceRange(ByteBuffer _bb, IDistanceRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601ECAF RID: 126127 RVA: 0x00450359 File Offset: 0x0044E559
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601ECB0 RID: 126128 RVA: 0x00450368 File Offset: 0x0044E568
		public IDistanceRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008D45 RID: 36165
		// (get) Token: 0x0601ECB1 RID: 126129 RVA: 0x00450378 File Offset: 0x0044E578
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

		// Token: 0x17008D46 RID: 36166
		// (get) Token: 0x0601ECB2 RID: 126130 RVA: 0x004503B8 File Offset: 0x0044E5B8
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

		// Token: 0x17008D47 RID: 36167
		// (get) Token: 0x0601ECB3 RID: 126131 RVA: 0x004503F8 File Offset: 0x0044E5F8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601ECB4 RID: 126132 RVA: 0x00450434 File Offset: 0x0044E634
		public static Offset<IDistanceRange> CreateIDistanceRange(FlatBufferBuilder builder, float Min = 0f, float Max = 0f, byte NullMask = 0)
		{
			builder.StartTable(3);
			IDistanceRange.AddMax(builder, Max);
			IDistanceRange.AddMin(builder, Min);
			IDistanceRange.AddNullMask(builder, NullMask);
			return IDistanceRange.EndIDistanceRange(builder);
		}

		// Token: 0x0601ECB5 RID: 126133 RVA: 0x00450458 File Offset: 0x0044E658
		public static void StartIDistanceRange(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601ECB6 RID: 126134 RVA: 0x00450461 File Offset: 0x0044E661
		public static void AddMin(FlatBufferBuilder builder, float min)
		{
			builder.AddFloat(0, min, 0.0);
		}

		// Token: 0x0601ECB7 RID: 126135 RVA: 0x00450474 File Offset: 0x0044E674
		public static void AddMax(FlatBufferBuilder builder, float max)
		{
			builder.AddFloat(1, max, 0.0);
		}

		// Token: 0x0601ECB8 RID: 126136 RVA: 0x00450487 File Offset: 0x0044E687
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0601ECB9 RID: 126137 RVA: 0x00450492 File Offset: 0x0044E692
		public static Offset<IDistanceRange> EndIDistanceRange(FlatBufferBuilder builder)
		{
			return new Offset<IDistanceRange>(builder.EndTable());
		}

		// Token: 0x0601ECBA RID: 126138 RVA: 0x004504A0 File Offset: 0x0044E6A0
		public IDistanceRangeT UnPack()
		{
			IDistanceRangeT distanceRangeT = new IDistanceRangeT();
			this.UnPackTo(distanceRangeT);
			return distanceRangeT;
		}

		// Token: 0x0601ECBB RID: 126139 RVA: 0x004504BB File Offset: 0x0044E6BB
		public void UnPackTo(IDistanceRangeT _o)
		{
			_o.Min = this.Min;
			_o.Max = this.Max;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601ECBC RID: 126140 RVA: 0x004504E4 File Offset: 0x0044E6E4
		public static Offset<IDistanceRange> Pack(FlatBufferBuilder builder, IDistanceRangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDistanceRange>);
			}
			return IDistanceRange.CreateIDistanceRange(builder, _o.Min, _o.Max, _o.NullMask);
		}

		// Token: 0x0400D584 RID: 54660
		private Table __p;
	}
}
