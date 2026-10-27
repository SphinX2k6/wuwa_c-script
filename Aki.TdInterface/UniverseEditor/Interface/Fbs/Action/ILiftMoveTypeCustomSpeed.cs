using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A05 RID: 27141
	public struct ILiftMoveTypeCustomSpeed : IFlatbufferObject
	{
		// Token: 0x1700C95D RID: 51549
		// (get) Token: 0x0602F7DB RID: 194523 RVA: 0x00677A51 File Offset: 0x00675C51
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F7DC RID: 194524 RVA: 0x00677A5E File Offset: 0x00675C5E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F7DD RID: 194525 RVA: 0x00677A68 File Offset: 0x00675C68
		public static ILiftMoveTypeCustomSpeed GetRootAsILiftMoveTypeCustomSpeed(ByteBuffer _bb)
		{
			return ILiftMoveTypeCustomSpeed.GetRootAsILiftMoveTypeCustomSpeed(_bb, default(ILiftMoveTypeCustomSpeed));
		}

		// Token: 0x0602F7DE RID: 194526 RVA: 0x00677A84 File Offset: 0x00675C84
		public static ILiftMoveTypeCustomSpeed GetRootAsILiftMoveTypeCustomSpeed(ByteBuffer _bb, ILiftMoveTypeCustomSpeed obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F7DF RID: 194527 RVA: 0x00677AA1 File Offset: 0x00675CA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F7E0 RID: 194528 RVA: 0x00677AB0 File Offset: 0x00675CB0
		public ILiftMoveTypeCustomSpeed __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C95E RID: 51550
		// (get) Token: 0x0602F7E1 RID: 194529 RVA: 0x00677AC0 File Offset: 0x00675CC0
		public ELiftMoveType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELiftMoveType.Default;
				}
				return (ELiftMoveType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C95F RID: 51551
		// (get) Token: 0x0602F7E2 RID: 194530 RVA: 0x00677AFC File Offset: 0x00675CFC
		public float TotalTime
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

		// Token: 0x1700C960 RID: 51552
		// (get) Token: 0x0602F7E3 RID: 194531 RVA: 0x00677B3C File Offset: 0x00675D3C
		public string TimePathCurve
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

		// Token: 0x0602F7E4 RID: 194532 RVA: 0x00677B73 File Offset: 0x00675D73
		public Span<byte> GetTimePathCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602F7E5 RID: 194533 RVA: 0x00677B82 File Offset: 0x00675D82
		public byte[] GetTimePathCurveArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0602F7E6 RID: 194534 RVA: 0x00677B90 File Offset: 0x00675D90
		public static Offset<ILiftMoveTypeCustomSpeed> CreateILiftMoveTypeCustomSpeed(FlatBufferBuilder builder, ELiftMoveType Type = ELiftMoveType.Default, float TotalTime = 0f, StringOffset TimePathCurveOffset = default(StringOffset))
		{
			builder.StartTable(3);
			ILiftMoveTypeCustomSpeed.AddTimePathCurve(builder, TimePathCurveOffset);
			ILiftMoveTypeCustomSpeed.AddTotalTime(builder, TotalTime);
			ILiftMoveTypeCustomSpeed.AddType(builder, Type);
			return ILiftMoveTypeCustomSpeed.EndILiftMoveTypeCustomSpeed(builder);
		}

		// Token: 0x0602F7E7 RID: 194535 RVA: 0x00677BB4 File Offset: 0x00675DB4
		public static void StartILiftMoveTypeCustomSpeed(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602F7E8 RID: 194536 RVA: 0x00677BBD File Offset: 0x00675DBD
		public static void AddType(FlatBufferBuilder builder, ELiftMoveType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F7E9 RID: 194537 RVA: 0x00677BC8 File Offset: 0x00675DC8
		public static void AddTotalTime(FlatBufferBuilder builder, float totalTime)
		{
			builder.AddFloat(1, totalTime, 0.0);
		}

		// Token: 0x0602F7EA RID: 194538 RVA: 0x00677BDB File Offset: 0x00675DDB
		public static void AddTimePathCurve(FlatBufferBuilder builder, StringOffset timePathCurveOffset)
		{
			builder.AddOffset(2, timePathCurveOffset.Value, 0);
		}

		// Token: 0x0602F7EB RID: 194539 RVA: 0x00677BEB File Offset: 0x00675DEB
		public static Offset<ILiftMoveTypeCustomSpeed> EndILiftMoveTypeCustomSpeed(FlatBufferBuilder builder)
		{
			return new Offset<ILiftMoveTypeCustomSpeed>(builder.EndTable());
		}

		// Token: 0x0602F7EC RID: 194540 RVA: 0x00677BF8 File Offset: 0x00675DF8
		public ILiftMoveTypeCustomSpeedT UnPack()
		{
			ILiftMoveTypeCustomSpeedT liftMoveTypeCustomSpeedT = new ILiftMoveTypeCustomSpeedT();
			this.UnPackTo(liftMoveTypeCustomSpeedT);
			return liftMoveTypeCustomSpeedT;
		}

		// Token: 0x0602F7ED RID: 194541 RVA: 0x00677C13 File Offset: 0x00675E13
		public void UnPackTo(ILiftMoveTypeCustomSpeedT _o)
		{
			_o.Type = this.Type;
			_o.TotalTime = this.TotalTime;
			_o.TimePathCurve = this.TimePathCurve;
		}

		// Token: 0x0602F7EE RID: 194542 RVA: 0x00677C3C File Offset: 0x00675E3C
		public static Offset<ILiftMoveTypeCustomSpeed> Pack(FlatBufferBuilder builder, ILiftMoveTypeCustomSpeedT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILiftMoveTypeCustomSpeed>);
			}
			StringOffset timePathCurveOffset = (_o.TimePathCurve == null) ? default(StringOffset) : builder.CreateString(_o.TimePathCurve);
			return ILiftMoveTypeCustomSpeed.CreateILiftMoveTypeCustomSpeed(builder, _o.Type, _o.TotalTime, timePathCurveOffset);
		}

		// Token: 0x04011204 RID: 70148
		private Table __p;
	}
}
