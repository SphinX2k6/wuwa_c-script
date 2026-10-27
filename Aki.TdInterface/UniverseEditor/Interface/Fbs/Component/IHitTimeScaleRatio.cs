using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053A7 RID: 21415
	public struct IHitTimeScaleRatio : IFlatbufferObject
	{
		// Token: 0x17009D52 RID: 40274
		// (get) Token: 0x06023134 RID: 143668 RVA: 0x004DB142 File Offset: 0x004D9342
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023135 RID: 143669 RVA: 0x004DB14F File Offset: 0x004D934F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023136 RID: 143670 RVA: 0x004DB158 File Offset: 0x004D9358
		public static IHitTimeScaleRatio GetRootAsIHitTimeScaleRatio(ByteBuffer _bb)
		{
			return IHitTimeScaleRatio.GetRootAsIHitTimeScaleRatio(_bb, default(IHitTimeScaleRatio));
		}

		// Token: 0x06023137 RID: 143671 RVA: 0x004DB174 File Offset: 0x004D9374
		public static IHitTimeScaleRatio GetRootAsIHitTimeScaleRatio(ByteBuffer _bb, IHitTimeScaleRatio obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023138 RID: 143672 RVA: 0x004DB191 File Offset: 0x004D9391
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023139 RID: 143673 RVA: 0x004DB1A0 File Offset: 0x004D93A0
		public IHitTimeScaleRatio __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009D53 RID: 40275
		// (get) Token: 0x0602313A RID: 143674 RVA: 0x004DB1B0 File Offset: 0x004D93B0
		public float TimeRatio
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

		// Token: 0x17009D54 RID: 40276
		// (get) Token: 0x0602313B RID: 143675 RVA: 0x004DB1F0 File Offset: 0x004D93F0
		public float MaxExtraTime
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

		// Token: 0x17009D55 RID: 40277
		// (get) Token: 0x0602313C RID: 143676 RVA: 0x004DB230 File Offset: 0x004D9430
		public float ValueRatio
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

		// Token: 0x17009D56 RID: 40278
		// (get) Token: 0x0602313D RID: 143677 RVA: 0x004DB270 File Offset: 0x004D9470
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602313E RID: 143678 RVA: 0x004DB2AD File Offset: 0x004D94AD
		public static Offset<IHitTimeScaleRatio> CreateIHitTimeScaleRatio(FlatBufferBuilder builder, float TimeRatio = 0f, float MaxExtraTime = 0f, float ValueRatio = 0f, byte NullMask = 0)
		{
			builder.StartTable(4);
			IHitTimeScaleRatio.AddValueRatio(builder, ValueRatio);
			IHitTimeScaleRatio.AddMaxExtraTime(builder, MaxExtraTime);
			IHitTimeScaleRatio.AddTimeRatio(builder, TimeRatio);
			IHitTimeScaleRatio.AddNullMask(builder, NullMask);
			return IHitTimeScaleRatio.EndIHitTimeScaleRatio(builder);
		}

		// Token: 0x0602313F RID: 143679 RVA: 0x004DB2D9 File Offset: 0x004D94D9
		public static void StartIHitTimeScaleRatio(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06023140 RID: 143680 RVA: 0x004DB2E2 File Offset: 0x004D94E2
		public static void AddTimeRatio(FlatBufferBuilder builder, float timeRatio)
		{
			builder.AddFloat(0, timeRatio, 0.0);
		}

		// Token: 0x06023141 RID: 143681 RVA: 0x004DB2F5 File Offset: 0x004D94F5
		public static void AddMaxExtraTime(FlatBufferBuilder builder, float maxExtraTime)
		{
			builder.AddFloat(1, maxExtraTime, 0.0);
		}

		// Token: 0x06023142 RID: 143682 RVA: 0x004DB308 File Offset: 0x004D9508
		public static void AddValueRatio(FlatBufferBuilder builder, float valueRatio)
		{
			builder.AddFloat(2, valueRatio, 0.0);
		}

		// Token: 0x06023143 RID: 143683 RVA: 0x004DB31B File Offset: 0x004D951B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06023144 RID: 143684 RVA: 0x004DB326 File Offset: 0x004D9526
		public static Offset<IHitTimeScaleRatio> EndIHitTimeScaleRatio(FlatBufferBuilder builder)
		{
			return new Offset<IHitTimeScaleRatio>(builder.EndTable());
		}

		// Token: 0x06023145 RID: 143685 RVA: 0x004DB334 File Offset: 0x004D9534
		public IHitTimeScaleRatioT UnPack()
		{
			IHitTimeScaleRatioT hitTimeScaleRatioT = new IHitTimeScaleRatioT();
			this.UnPackTo(hitTimeScaleRatioT);
			return hitTimeScaleRatioT;
		}

		// Token: 0x06023146 RID: 143686 RVA: 0x004DB34F File Offset: 0x004D954F
		public void UnPackTo(IHitTimeScaleRatioT _o)
		{
			_o.TimeRatio = this.TimeRatio;
			_o.MaxExtraTime = this.MaxExtraTime;
			_o.ValueRatio = this.ValueRatio;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06023147 RID: 143687 RVA: 0x004DB384 File Offset: 0x004D9584
		public static Offset<IHitTimeScaleRatio> Pack(FlatBufferBuilder builder, IHitTimeScaleRatioT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHitTimeScaleRatio>);
			}
			return IHitTimeScaleRatio.CreateIHitTimeScaleRatio(builder, _o.TimeRatio, _o.MaxExtraTime, _o.ValueRatio, _o.NullMask);
		}

		// Token: 0x0400E599 RID: 58777
		private Table __p;
	}
}
