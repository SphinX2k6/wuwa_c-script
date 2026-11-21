using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006092 RID: 24722
	public struct ITimePathConfig : IFlatbufferObject
	{
		// Token: 0x1700B7BE RID: 47038
		// (get) Token: 0x06029CF3 RID: 171251 RVA: 0x005B53B0 File Offset: 0x005B35B0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029CF4 RID: 171252 RVA: 0x005B53BD File Offset: 0x005B35BD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029CF5 RID: 171253 RVA: 0x005B53C4 File Offset: 0x005B35C4
		public static ITimePathConfig GetRootAsITimePathConfig(ByteBuffer _bb)
		{
			return ITimePathConfig.GetRootAsITimePathConfig(_bb, default(ITimePathConfig));
		}

		// Token: 0x06029CF6 RID: 171254 RVA: 0x005B53E0 File Offset: 0x005B35E0
		public static ITimePathConfig GetRootAsITimePathConfig(ByteBuffer _bb, ITimePathConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029CF7 RID: 171255 RVA: 0x005B53FD File Offset: 0x005B35FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029CF8 RID: 171256 RVA: 0x005B540C File Offset: 0x005B360C
		public ITimePathConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B7BF RID: 47039
		// (get) Token: 0x06029CF9 RID: 171257 RVA: 0x005B541C File Offset: 0x005B361C
		public float TotalTime
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

		// Token: 0x1700B7C0 RID: 47040
		// (get) Token: 0x06029CFA RID: 171258 RVA: 0x005B545C File Offset: 0x005B365C
		public string TimePathCurve
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

		// Token: 0x06029CFB RID: 171259 RVA: 0x005B5493 File Offset: 0x005B3693
		public Span<byte> GetTimePathCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06029CFC RID: 171260 RVA: 0x005B54A2 File Offset: 0x005B36A2
		public byte[] GetTimePathCurveArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06029CFD RID: 171261 RVA: 0x005B54B0 File Offset: 0x005B36B0
		public static Offset<ITimePathConfig> CreateITimePathConfig(FlatBufferBuilder builder, float TotalTime = 0f, StringOffset TimePathCurveOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ITimePathConfig.AddTimePathCurve(builder, TimePathCurveOffset);
			ITimePathConfig.AddTotalTime(builder, TotalTime);
			return ITimePathConfig.EndITimePathConfig(builder);
		}

		// Token: 0x06029CFE RID: 171262 RVA: 0x005B54CD File Offset: 0x005B36CD
		public static void StartITimePathConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06029CFF RID: 171263 RVA: 0x005B54D6 File Offset: 0x005B36D6
		public static void AddTotalTime(FlatBufferBuilder builder, float totalTime)
		{
			builder.AddFloat(0, totalTime, 0.0);
		}

		// Token: 0x06029D00 RID: 171264 RVA: 0x005B54E9 File Offset: 0x005B36E9
		public static void AddTimePathCurve(FlatBufferBuilder builder, StringOffset timePathCurveOffset)
		{
			builder.AddOffset(1, timePathCurveOffset.Value, 0);
		}

		// Token: 0x06029D01 RID: 171265 RVA: 0x005B54F9 File Offset: 0x005B36F9
		public static Offset<ITimePathConfig> EndITimePathConfig(FlatBufferBuilder builder)
		{
			return new Offset<ITimePathConfig>(builder.EndTable());
		}

		// Token: 0x06029D02 RID: 171266 RVA: 0x005B5508 File Offset: 0x005B3708
		public ITimePathConfigT UnPack()
		{
			ITimePathConfigT timePathConfigT = new ITimePathConfigT();
			this.UnPackTo(timePathConfigT);
			return timePathConfigT;
		}

		// Token: 0x06029D03 RID: 171267 RVA: 0x005B5523 File Offset: 0x005B3723
		public void UnPackTo(ITimePathConfigT _o)
		{
			_o.TotalTime = this.TotalTime;
			_o.TimePathCurve = this.TimePathCurve;
		}

		// Token: 0x06029D04 RID: 171268 RVA: 0x005B5540 File Offset: 0x005B3740
		public static Offset<ITimePathConfig> Pack(FlatBufferBuilder builder, ITimePathConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimePathConfig>);
			}
			StringOffset timePathCurveOffset = (_o.TimePathCurve == null) ? default(StringOffset) : builder.CreateString(_o.TimePathCurve);
			return ITimePathConfig.CreateITimePathConfig(builder, _o.TotalTime, timePathCurveOffset);
		}

		// Token: 0x0400FE31 RID: 65073
		private Table __p;
	}
}
