using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DF5 RID: 28149
	public struct IQteHourglassConfig : IFlatbufferObject
	{
		// Token: 0x1700D1C9 RID: 53705
		// (get) Token: 0x06031B87 RID: 203655 RVA: 0x006BB8B5 File Offset: 0x006B9AB5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031B88 RID: 203656 RVA: 0x006BB8C2 File Offset: 0x006B9AC2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031B89 RID: 203657 RVA: 0x006BB8CC File Offset: 0x006B9ACC
		public static IQteHourglassConfig GetRootAsIQteHourglassConfig(ByteBuffer _bb)
		{
			return IQteHourglassConfig.GetRootAsIQteHourglassConfig(_bb, default(IQteHourglassConfig));
		}

		// Token: 0x06031B8A RID: 203658 RVA: 0x006BB8E8 File Offset: 0x006B9AE8
		public static IQteHourglassConfig GetRootAsIQteHourglassConfig(ByteBuffer _bb, IQteHourglassConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031B8B RID: 203659 RVA: 0x006BB905 File Offset: 0x006B9B05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031B8C RID: 203660 RVA: 0x006BB914 File Offset: 0x006B9B14
		public IQteHourglassConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D1CA RID: 53706
		// (get) Token: 0x06031B8D RID: 203661 RVA: 0x006BB924 File Offset: 0x006B9B24
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

		// Token: 0x1700D1CB RID: 53707
		// (get) Token: 0x06031B8E RID: 203662 RVA: 0x006BB960 File Offset: 0x006B9B60
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

		// Token: 0x1700D1CC RID: 53708
		// (get) Token: 0x06031B8F RID: 203663 RVA: 0x006BB9A0 File Offset: 0x006B9BA0
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

		// Token: 0x06031B90 RID: 203664 RVA: 0x006BB9D7 File Offset: 0x006B9BD7
		public Span<byte> GetTrailCurveXBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06031B91 RID: 203665 RVA: 0x006BB9E6 File Offset: 0x006B9BE6
		public byte[] GetTrailCurveXArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700D1CD RID: 53709
		// (get) Token: 0x06031B92 RID: 203666 RVA: 0x006BB9F4 File Offset: 0x006B9BF4
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

		// Token: 0x06031B93 RID: 203667 RVA: 0x006BBA2C File Offset: 0x006B9C2C
		public Span<byte> GetTrailCurveYBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06031B94 RID: 203668 RVA: 0x006BBA3C File Offset: 0x006B9C3C
		public byte[] GetTrailCurveYArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x06031B95 RID: 203669 RVA: 0x006BBA4B File Offset: 0x006B9C4B
		public static Offset<IQteHourglassConfig> CreateIQteHourglassConfig(FlatBufferBuilder builder, int QteId = 0, float TrailTime = 0f, StringOffset TrailCurveXOffset = default(StringOffset), StringOffset TrailCurveYOffset = default(StringOffset))
		{
			builder.StartTable(4);
			IQteHourglassConfig.AddTrailCurveY(builder, TrailCurveYOffset);
			IQteHourglassConfig.AddTrailCurveX(builder, TrailCurveXOffset);
			IQteHourglassConfig.AddTrailTime(builder, TrailTime);
			IQteHourglassConfig.AddQteId(builder, QteId);
			return IQteHourglassConfig.EndIQteHourglassConfig(builder);
		}

		// Token: 0x06031B96 RID: 203670 RVA: 0x006BBA77 File Offset: 0x006B9C77
		public static void StartIQteHourglassConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06031B97 RID: 203671 RVA: 0x006BBA80 File Offset: 0x006B9C80
		public static void AddQteId(FlatBufferBuilder builder, int qteId)
		{
			builder.AddInt(0, qteId, 0);
		}

		// Token: 0x06031B98 RID: 203672 RVA: 0x006BBA8B File Offset: 0x006B9C8B
		public static void AddTrailTime(FlatBufferBuilder builder, float trailTime)
		{
			builder.AddFloat(1, trailTime, 0.0);
		}

		// Token: 0x06031B99 RID: 203673 RVA: 0x006BBA9E File Offset: 0x006B9C9E
		public static void AddTrailCurveX(FlatBufferBuilder builder, StringOffset trailCurveXOffset)
		{
			builder.AddOffset(2, trailCurveXOffset.Value, 0);
		}

		// Token: 0x06031B9A RID: 203674 RVA: 0x006BBAAE File Offset: 0x006B9CAE
		public static void AddTrailCurveY(FlatBufferBuilder builder, StringOffset trailCurveYOffset)
		{
			builder.AddOffset(3, trailCurveYOffset.Value, 0);
		}

		// Token: 0x06031B9B RID: 203675 RVA: 0x006BBABE File Offset: 0x006B9CBE
		public static Offset<IQteHourglassConfig> EndIQteHourglassConfig(FlatBufferBuilder builder)
		{
			return new Offset<IQteHourglassConfig>(builder.EndTable());
		}

		// Token: 0x06031B9C RID: 203676 RVA: 0x006BBACC File Offset: 0x006B9CCC
		public IQteHourglassConfigT UnPack()
		{
			IQteHourglassConfigT qteHourglassConfigT = new IQteHourglassConfigT();
			this.UnPackTo(qteHourglassConfigT);
			return qteHourglassConfigT;
		}

		// Token: 0x06031B9D RID: 203677 RVA: 0x006BBAE7 File Offset: 0x006B9CE7
		public void UnPackTo(IQteHourglassConfigT _o)
		{
			_o.QteId = this.QteId;
			_o.TrailTime = this.TrailTime;
			_o.TrailCurveX = this.TrailCurveX;
			_o.TrailCurveY = this.TrailCurveY;
		}

		// Token: 0x06031B9E RID: 203678 RVA: 0x006BBB1C File Offset: 0x006B9D1C
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

		// Token: 0x040117D1 RID: 71633
		private Table __p;
	}
}
