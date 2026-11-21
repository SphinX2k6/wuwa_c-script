using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200592D RID: 22829
	public struct IHitTimeScaleRatio : IFlatbufferObject
	{
		// Token: 0x1700A58A RID: 42378
		// (get) Token: 0x060251E8 RID: 152040 RVA: 0x00518016 File Offset: 0x00516216
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060251E9 RID: 152041 RVA: 0x00518023 File Offset: 0x00516223
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060251EA RID: 152042 RVA: 0x0051802C File Offset: 0x0051622C
		public static IHitTimeScaleRatio GetRootAsIHitTimeScaleRatio(ByteBuffer _bb)
		{
			return IHitTimeScaleRatio.GetRootAsIHitTimeScaleRatio(_bb, default(IHitTimeScaleRatio));
		}

		// Token: 0x060251EB RID: 152043 RVA: 0x00518048 File Offset: 0x00516248
		public static IHitTimeScaleRatio GetRootAsIHitTimeScaleRatio(ByteBuffer _bb, IHitTimeScaleRatio obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060251EC RID: 152044 RVA: 0x00518065 File Offset: 0x00516265
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060251ED RID: 152045 RVA: 0x00518074 File Offset: 0x00516274
		public IHitTimeScaleRatio __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A58B RID: 42379
		// (get) Token: 0x060251EE RID: 152046 RVA: 0x00518084 File Offset: 0x00516284
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

		// Token: 0x1700A58C RID: 42380
		// (get) Token: 0x060251EF RID: 152047 RVA: 0x005180C4 File Offset: 0x005162C4
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

		// Token: 0x1700A58D RID: 42381
		// (get) Token: 0x060251F0 RID: 152048 RVA: 0x00518104 File Offset: 0x00516304
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

		// Token: 0x1700A58E RID: 42382
		// (get) Token: 0x060251F1 RID: 152049 RVA: 0x00518144 File Offset: 0x00516344
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

		// Token: 0x060251F2 RID: 152050 RVA: 0x00518181 File Offset: 0x00516381
		public static Offset<IHitTimeScaleRatio> CreateIHitTimeScaleRatio(FlatBufferBuilder builder, float TimeRatio = 0f, float MaxExtraTime = 0f, float ValueRatio = 0f, byte NullMask = 0)
		{
			builder.StartTable(4);
			IHitTimeScaleRatio.AddValueRatio(builder, ValueRatio);
			IHitTimeScaleRatio.AddMaxExtraTime(builder, MaxExtraTime);
			IHitTimeScaleRatio.AddTimeRatio(builder, TimeRatio);
			IHitTimeScaleRatio.AddNullMask(builder, NullMask);
			return IHitTimeScaleRatio.EndIHitTimeScaleRatio(builder);
		}

		// Token: 0x060251F3 RID: 152051 RVA: 0x005181AD File Offset: 0x005163AD
		public static void StartIHitTimeScaleRatio(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060251F4 RID: 152052 RVA: 0x005181B6 File Offset: 0x005163B6
		public static void AddTimeRatio(FlatBufferBuilder builder, float timeRatio)
		{
			builder.AddFloat(0, timeRatio, 0.0);
		}

		// Token: 0x060251F5 RID: 152053 RVA: 0x005181C9 File Offset: 0x005163C9
		public static void AddMaxExtraTime(FlatBufferBuilder builder, float maxExtraTime)
		{
			builder.AddFloat(1, maxExtraTime, 0.0);
		}

		// Token: 0x060251F6 RID: 152054 RVA: 0x005181DC File Offset: 0x005163DC
		public static void AddValueRatio(FlatBufferBuilder builder, float valueRatio)
		{
			builder.AddFloat(2, valueRatio, 0.0);
		}

		// Token: 0x060251F7 RID: 152055 RVA: 0x005181EF File Offset: 0x005163EF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060251F8 RID: 152056 RVA: 0x005181FA File Offset: 0x005163FA
		public static Offset<IHitTimeScaleRatio> EndIHitTimeScaleRatio(FlatBufferBuilder builder)
		{
			return new Offset<IHitTimeScaleRatio>(builder.EndTable());
		}

		// Token: 0x060251F9 RID: 152057 RVA: 0x00518208 File Offset: 0x00516408
		public IHitTimeScaleRatioT UnPack()
		{
			IHitTimeScaleRatioT hitTimeScaleRatioT = new IHitTimeScaleRatioT();
			this.UnPackTo(hitTimeScaleRatioT);
			return hitTimeScaleRatioT;
		}

		// Token: 0x060251FA RID: 152058 RVA: 0x00518223 File Offset: 0x00516423
		public void UnPackTo(IHitTimeScaleRatioT _o)
		{
			_o.TimeRatio = this.TimeRatio;
			_o.MaxExtraTime = this.MaxExtraTime;
			_o.ValueRatio = this.ValueRatio;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060251FB RID: 152059 RVA: 0x00518258 File Offset: 0x00516458
		public static Offset<IHitTimeScaleRatio> Pack(FlatBufferBuilder builder, IHitTimeScaleRatioT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHitTimeScaleRatio>);
			}
			return IHitTimeScaleRatio.CreateIHitTimeScaleRatio(builder, _o.TimeRatio, _o.MaxExtraTime, _o.ValueRatio, _o.NullMask);
		}

		// Token: 0x0400F1C9 RID: 61897
		private Table __p;
	}
}
