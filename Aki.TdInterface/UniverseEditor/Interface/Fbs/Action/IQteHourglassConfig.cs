using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007570 RID: 30064
	public struct IQteHourglassConfig : IFlatbufferObject
	{
		// Token: 0x1700DD11 RID: 56593
		// (get) Token: 0x06034B83 RID: 215939 RVA: 0x00716F9D File Offset: 0x0071519D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034B84 RID: 215940 RVA: 0x00716FAA File Offset: 0x007151AA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034B85 RID: 215941 RVA: 0x00716FB4 File Offset: 0x007151B4
		public static IQteHourglassConfig GetRootAsIQteHourglassConfig(ByteBuffer _bb)
		{
			return IQteHourglassConfig.GetRootAsIQteHourglassConfig(_bb, default(IQteHourglassConfig));
		}

		// Token: 0x06034B86 RID: 215942 RVA: 0x00716FD0 File Offset: 0x007151D0
		public static IQteHourglassConfig GetRootAsIQteHourglassConfig(ByteBuffer _bb, IQteHourglassConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034B87 RID: 215943 RVA: 0x00716FED File Offset: 0x007151ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034B88 RID: 215944 RVA: 0x00716FFC File Offset: 0x007151FC
		public IQteHourglassConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DD12 RID: 56594
		// (get) Token: 0x06034B89 RID: 215945 RVA: 0x0071700C File Offset: 0x0071520C
		public int QteId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DD13 RID: 56595
		// (get) Token: 0x06034B8A RID: 215946 RVA: 0x00717048 File Offset: 0x00715248
		public float TrailTime
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

		// Token: 0x1700DD14 RID: 56596
		// (get) Token: 0x06034B8B RID: 215947 RVA: 0x00717088 File Offset: 0x00715288
		public string TrailCurveX
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

		// Token: 0x06034B8C RID: 215948 RVA: 0x007170BF File Offset: 0x007152BF
		public Span<byte> GetTrailCurveXBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06034B8D RID: 215949 RVA: 0x007170CE File Offset: 0x007152CE
		public byte[] GetTrailCurveXArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700DD15 RID: 56597
		// (get) Token: 0x06034B8E RID: 215950 RVA: 0x007170DC File Offset: 0x007152DC
		public string TrailCurveY
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

		// Token: 0x06034B8F RID: 215951 RVA: 0x00717114 File Offset: 0x00715314
		public Span<byte> GetTrailCurveYBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06034B90 RID: 215952 RVA: 0x00717124 File Offset: 0x00715324
		public byte[] GetTrailCurveYArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x06034B91 RID: 215953 RVA: 0x00717133 File Offset: 0x00715333
		public static Offset<IQteHourglassConfig> CreateIQteHourglassConfig(FlatBufferBuilder builder, int QteId = 0, float TrailTime = 0f, StringOffset TrailCurveXOffset = default(StringOffset), StringOffset TrailCurveYOffset = default(StringOffset))
		{
			builder.StartTable(4);
			IQteHourglassConfig.AddTrailCurveY(builder, TrailCurveYOffset);
			IQteHourglassConfig.AddTrailCurveX(builder, TrailCurveXOffset);
			IQteHourglassConfig.AddTrailTime(builder, TrailTime);
			IQteHourglassConfig.AddQteId(builder, QteId);
			return IQteHourglassConfig.EndIQteHourglassConfig(builder);
		}

		// Token: 0x06034B92 RID: 215954 RVA: 0x0071715F File Offset: 0x0071535F
		public static void StartIQteHourglassConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06034B93 RID: 215955 RVA: 0x00717168 File Offset: 0x00715368
		public static void AddQteId(FlatBufferBuilder builder, int qteId)
		{
			builder.AddInt(0, qteId, 0);
		}

		// Token: 0x06034B94 RID: 215956 RVA: 0x00717173 File Offset: 0x00715373
		public static void AddTrailTime(FlatBufferBuilder builder, float trailTime)
		{
			builder.AddFloat(1, trailTime, 0.0);
		}

		// Token: 0x06034B95 RID: 215957 RVA: 0x00717186 File Offset: 0x00715386
		public static void AddTrailCurveX(FlatBufferBuilder builder, StringOffset trailCurveXOffset)
		{
			builder.AddOffset(2, trailCurveXOffset.Value, 0);
		}

		// Token: 0x06034B96 RID: 215958 RVA: 0x00717196 File Offset: 0x00715396
		public static void AddTrailCurveY(FlatBufferBuilder builder, StringOffset trailCurveYOffset)
		{
			builder.AddOffset(3, trailCurveYOffset.Value, 0);
		}

		// Token: 0x06034B97 RID: 215959 RVA: 0x007171A6 File Offset: 0x007153A6
		public static Offset<IQteHourglassConfig> EndIQteHourglassConfig(FlatBufferBuilder builder)
		{
			return new Offset<IQteHourglassConfig>(builder.EndTable());
		}

		// Token: 0x06034B98 RID: 215960 RVA: 0x007171B4 File Offset: 0x007153B4
		public IQteHourglassConfigT UnPack()
		{
			IQteHourglassConfigT qteHourglassConfigT = new IQteHourglassConfigT();
			this.UnPackTo(qteHourglassConfigT);
			return qteHourglassConfigT;
		}

		// Token: 0x06034B99 RID: 215961 RVA: 0x007171CF File Offset: 0x007153CF
		public void UnPackTo(IQteHourglassConfigT _o)
		{
			_o.QteId = this.QteId;
			_o.TrailTime = this.TrailTime;
			_o.TrailCurveX = this.TrailCurveX;
			_o.TrailCurveY = this.TrailCurveY;
		}

		// Token: 0x06034B9A RID: 215962 RVA: 0x00717204 File Offset: 0x00715404
		public static Offset<IQteHourglassConfig> Pack(FlatBufferBuilder builder, IQteHourglassConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQteHourglassConfig>);
			}
			StringOffset trailCurveXOffset = (_o.TrailCurveX == null) ? default(StringOffset) : builder.CreateString(_o.TrailCurveX);
			StringOffset trailCurveYOffset = (_o.TrailCurveY == null) ? default(StringOffset) : builder.CreateString(_o.TrailCurveY);
			return IQteHourglassConfig.CreateIQteHourglassConfig(builder, _o.QteId, _o.TrailTime, trailCurveXOffset, trailCurveYOffset);
		}

		// Token: 0x0401274D RID: 75597
		private Table __p;
	}
}
