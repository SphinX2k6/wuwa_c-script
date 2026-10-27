using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045D2 RID: 17874
	public struct ITrapDefenseSpline : IFlatbufferObject
	{
		// Token: 0x17007F0D RID: 32525
		// (get) Token: 0x0601B0B1 RID: 110769 RVA: 0x003DAB6C File Offset: 0x003D8D6C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B0B2 RID: 110770 RVA: 0x003DAB79 File Offset: 0x003D8D79
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B0B3 RID: 110771 RVA: 0x003DAB80 File Offset: 0x003D8D80
		public static ITrapDefenseSpline GetRootAsITrapDefenseSpline(ByteBuffer _bb)
		{
			return ITrapDefenseSpline.GetRootAsITrapDefenseSpline(_bb, default(ITrapDefenseSpline));
		}

		// Token: 0x0601B0B4 RID: 110772 RVA: 0x003DAB9C File Offset: 0x003D8D9C
		public static ITrapDefenseSpline GetRootAsITrapDefenseSpline(ByteBuffer _bb, ITrapDefenseSpline obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B0B5 RID: 110773 RVA: 0x003DABB9 File Offset: 0x003D8DB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B0B6 RID: 110774 RVA: 0x003DABC8 File Offset: 0x003D8DC8
		public ITrapDefenseSpline __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007F0E RID: 32526
		// (get) Token: 0x0601B0B7 RID: 110775 RVA: 0x003DABD8 File Offset: 0x003D8DD8
		public string SplineEntityId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B0B8 RID: 110776 RVA: 0x003DAC0F File Offset: 0x003D8E0F
		public Span<byte> GetSplineEntityIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601B0B9 RID: 110777 RVA: 0x003DAC1E File Offset: 0x003D8E1E
		public byte[] GetSplineEntityIdArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17007F0F RID: 32527
		// (get) Token: 0x0601B0BA RID: 110778 RVA: 0x003DAC2C File Offset: 0x003D8E2C
		public float DelayTime
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

		// Token: 0x17007F10 RID: 32528
		// (get) Token: 0x0601B0BB RID: 110779 RVA: 0x003DAC6C File Offset: 0x003D8E6C
		public float IntervalTime
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B0BC RID: 110780 RVA: 0x003DACAC File Offset: 0x003D8EAC
		public static Offset<ITrapDefenseSpline> CreateITrapDefenseSpline(FlatBufferBuilder builder, StringOffset SplineEntityIdOffset = default(StringOffset), float DelayTime = 0f, float IntervalTime = 0f)
		{
			builder.StartTable(3);
			ITrapDefenseSpline.AddIntervalTime(builder, IntervalTime);
			ITrapDefenseSpline.AddDelayTime(builder, DelayTime);
			ITrapDefenseSpline.AddSplineEntityId(builder, SplineEntityIdOffset);
			return ITrapDefenseSpline.EndITrapDefenseSpline(builder);
		}

		// Token: 0x0601B0BD RID: 110781 RVA: 0x003DACD0 File Offset: 0x003D8ED0
		public static void StartITrapDefenseSpline(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601B0BE RID: 110782 RVA: 0x003DACD9 File Offset: 0x003D8ED9
		public static void AddSplineEntityId(FlatBufferBuilder builder, StringOffset splineEntityIdOffset)
		{
			builder.AddOffset(0, splineEntityIdOffset.Value, 0);
		}

		// Token: 0x0601B0BF RID: 110783 RVA: 0x003DACE9 File Offset: 0x003D8EE9
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(1, delayTime, 0.0);
		}

		// Token: 0x0601B0C0 RID: 110784 RVA: 0x003DACFC File Offset: 0x003D8EFC
		public static void AddIntervalTime(FlatBufferBuilder builder, float intervalTime)
		{
			builder.AddFloat(2, intervalTime, 0.0);
		}

		// Token: 0x0601B0C1 RID: 110785 RVA: 0x003DAD0F File Offset: 0x003D8F0F
		public static Offset<ITrapDefenseSpline> EndITrapDefenseSpline(FlatBufferBuilder builder)
		{
			return new Offset<ITrapDefenseSpline>(builder.EndTable());
		}

		// Token: 0x0601B0C2 RID: 110786 RVA: 0x003DAD1C File Offset: 0x003D8F1C
		public ITrapDefenseSplineT UnPack()
		{
			ITrapDefenseSplineT trapDefenseSplineT = new ITrapDefenseSplineT();
			this.UnPackTo(trapDefenseSplineT);
			return trapDefenseSplineT;
		}

		// Token: 0x0601B0C3 RID: 110787 RVA: 0x003DAD37 File Offset: 0x003D8F37
		public void UnPackTo(ITrapDefenseSplineT _o)
		{
			_o.SplineEntityId = this.SplineEntityId;
			_o.DelayTime = this.DelayTime;
			_o.IntervalTime = this.IntervalTime;
		}

		// Token: 0x0601B0C4 RID: 110788 RVA: 0x003DAD60 File Offset: 0x003D8F60
		public static Offset<ITrapDefenseSpline> Pack(FlatBufferBuilder builder, ITrapDefenseSplineT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrapDefenseSpline>);
			}
			StringOffset splineEntityIdOffset = (_o.SplineEntityId == null) ? default(StringOffset) : builder.CreateString(_o.SplineEntityId);
			return ITrapDefenseSpline.CreateITrapDefenseSpline(builder, splineEntityIdOffset, _o.DelayTime, _o.IntervalTime);
		}

		// Token: 0x0400C6A5 RID: 50853
		private Table __p;
	}
}
