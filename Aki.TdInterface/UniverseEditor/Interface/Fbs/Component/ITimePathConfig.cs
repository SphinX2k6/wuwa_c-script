using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A85 RID: 23173
	public struct ITimePathConfig : IFlatbufferObject
	{
		// Token: 0x1700AE86 RID: 44678
		// (get) Token: 0x0602777B RID: 161659 RVA: 0x0056E3A4 File Offset: 0x0056C5A4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602777C RID: 161660 RVA: 0x0056E3B1 File Offset: 0x0056C5B1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602777D RID: 161661 RVA: 0x0056E3B8 File Offset: 0x0056C5B8
		public static ITimePathConfig GetRootAsITimePathConfig(ByteBuffer _bb)
		{
			return ITimePathConfig.GetRootAsITimePathConfig(_bb, default(ITimePathConfig));
		}

		// Token: 0x0602777E RID: 161662 RVA: 0x0056E3D4 File Offset: 0x0056C5D4
		public static ITimePathConfig GetRootAsITimePathConfig(ByteBuffer _bb, ITimePathConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602777F RID: 161663 RVA: 0x0056E3F1 File Offset: 0x0056C5F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027780 RID: 161664 RVA: 0x0056E400 File Offset: 0x0056C600
		public ITimePathConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AE87 RID: 44679
		// (get) Token: 0x06027781 RID: 161665 RVA: 0x0056E410 File Offset: 0x0056C610
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

		// Token: 0x1700AE88 RID: 44680
		// (get) Token: 0x06027782 RID: 161666 RVA: 0x0056E450 File Offset: 0x0056C650
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

		// Token: 0x06027783 RID: 161667 RVA: 0x0056E487 File Offset: 0x0056C687
		public Span<byte> GetTimePathCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06027784 RID: 161668 RVA: 0x0056E496 File Offset: 0x0056C696
		public byte[] GetTimePathCurveArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06027785 RID: 161669 RVA: 0x0056E4A4 File Offset: 0x0056C6A4
		public static Offset<ITimePathConfig> CreateITimePathConfig(FlatBufferBuilder builder, float TotalTime = 0f, StringOffset TimePathCurveOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ITimePathConfig.AddTimePathCurve(builder, TimePathCurveOffset);
			ITimePathConfig.AddTotalTime(builder, TotalTime);
			return ITimePathConfig.EndITimePathConfig(builder);
		}

		// Token: 0x06027786 RID: 161670 RVA: 0x0056E4C1 File Offset: 0x0056C6C1
		public static void StartITimePathConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06027787 RID: 161671 RVA: 0x0056E4CA File Offset: 0x0056C6CA
		public static void AddTotalTime(FlatBufferBuilder builder, float totalTime)
		{
			builder.AddFloat(0, totalTime, 0.0);
		}

		// Token: 0x06027788 RID: 161672 RVA: 0x0056E4DD File Offset: 0x0056C6DD
		public static void AddTimePathCurve(FlatBufferBuilder builder, StringOffset timePathCurveOffset)
		{
			builder.AddOffset(1, timePathCurveOffset.Value, 0);
		}

		// Token: 0x06027789 RID: 161673 RVA: 0x0056E4ED File Offset: 0x0056C6ED
		public static Offset<ITimePathConfig> EndITimePathConfig(FlatBufferBuilder builder)
		{
			return new Offset<ITimePathConfig>(builder.EndTable());
		}

		// Token: 0x0602778A RID: 161674 RVA: 0x0056E4FC File Offset: 0x0056C6FC
		public ITimePathConfigT UnPack()
		{
			ITimePathConfigT timePathConfigT = new ITimePathConfigT();
			this.UnPackTo(timePathConfigT);
			return timePathConfigT;
		}

		// Token: 0x0602778B RID: 161675 RVA: 0x0056E517 File Offset: 0x0056C717
		public void UnPackTo(ITimePathConfigT _o)
		{
			_o.TotalTime = this.TotalTime;
			_o.TimePathCurve = this.TimePathCurve;
		}

		// Token: 0x0602778C RID: 161676 RVA: 0x0056E534 File Offset: 0x0056C734
		public static Offset<ITimePathConfig> Pack(FlatBufferBuilder builder, ITimePathConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimePathConfig>);
			}
			StringOffset timePathCurveOffset = (_o.TimePathCurve == null) ? default(StringOffset) : builder.CreateString(_o.TimePathCurve);
			return ITimePathConfig.CreateITimePathConfig(builder, _o.TotalTime, timePathCurveOffset);
		}

		// Token: 0x0400F13A RID: 61754
		private Table __p;
	}
}
