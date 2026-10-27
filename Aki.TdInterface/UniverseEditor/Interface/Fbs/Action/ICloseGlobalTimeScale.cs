using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200641E RID: 25630
	public struct ICloseGlobalTimeScale : IFlatbufferObject
	{
		// Token: 0x1700BED7 RID: 48855
		// (get) Token: 0x0602C593 RID: 181651 RVA: 0x00615FE7 File Offset: 0x006141E7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C594 RID: 181652 RVA: 0x00615FF4 File Offset: 0x006141F4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C595 RID: 181653 RVA: 0x00615FFC File Offset: 0x006141FC
		public static ICloseGlobalTimeScale GetRootAsICloseGlobalTimeScale(ByteBuffer _bb)
		{
			return ICloseGlobalTimeScale.GetRootAsICloseGlobalTimeScale(_bb, default(ICloseGlobalTimeScale));
		}

		// Token: 0x0602C596 RID: 181654 RVA: 0x00616018 File Offset: 0x00614218
		public static ICloseGlobalTimeScale GetRootAsICloseGlobalTimeScale(ByteBuffer _bb, ICloseGlobalTimeScale obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C597 RID: 181655 RVA: 0x00616035 File Offset: 0x00614235
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C598 RID: 181656 RVA: 0x00616044 File Offset: 0x00614244
		public ICloseGlobalTimeScale __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BED8 RID: 48856
		// (get) Token: 0x0602C599 RID: 181657 RVA: 0x00616054 File Offset: 0x00614254
		public ESetTimeScaleType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESetTimeScaleType.Open;
				}
				return (ESetTimeScaleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BED9 RID: 48857
		// (get) Token: 0x0602C59A RID: 181658 RVA: 0x00616090 File Offset: 0x00614290
		public ETimeScaleCloseSource TimeScaleCloseSource
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ETimeScaleCloseSource.All;
				}
				return (ETimeScaleCloseSource)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BEDA RID: 48858
		// (get) Token: 0x0602C59B RID: 181659 RVA: 0x006160CC File Offset: 0x006142CC
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

		// Token: 0x0602C59C RID: 181660 RVA: 0x00616108 File Offset: 0x00614308
		public static Offset<ICloseGlobalTimeScale> CreateICloseGlobalTimeScale(FlatBufferBuilder builder, ESetTimeScaleType Type = ESetTimeScaleType.Open, ETimeScaleCloseSource TimeScaleCloseSource = ETimeScaleCloseSource.All, byte NullMask = 0)
		{
			builder.StartTable(3);
			ICloseGlobalTimeScale.AddNullMask(builder, NullMask);
			ICloseGlobalTimeScale.AddTimeScaleCloseSource(builder, TimeScaleCloseSource);
			ICloseGlobalTimeScale.AddType(builder, Type);
			return ICloseGlobalTimeScale.EndICloseGlobalTimeScale(builder);
		}

		// Token: 0x0602C59D RID: 181661 RVA: 0x0061612C File Offset: 0x0061432C
		public static void StartICloseGlobalTimeScale(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602C59E RID: 181662 RVA: 0x00616135 File Offset: 0x00614335
		public static void AddType(FlatBufferBuilder builder, ESetTimeScaleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C59F RID: 181663 RVA: 0x00616140 File Offset: 0x00614340
		public static void AddTimeScaleCloseSource(FlatBufferBuilder builder, ETimeScaleCloseSource timeScaleCloseSource)
		{
			builder.AddByte(1, (byte)timeScaleCloseSource, 0);
		}

		// Token: 0x0602C5A0 RID: 181664 RVA: 0x0061614B File Offset: 0x0061434B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602C5A1 RID: 181665 RVA: 0x00616156 File Offset: 0x00614356
		public static Offset<ICloseGlobalTimeScale> EndICloseGlobalTimeScale(FlatBufferBuilder builder)
		{
			return new Offset<ICloseGlobalTimeScale>(builder.EndTable());
		}

		// Token: 0x0602C5A2 RID: 181666 RVA: 0x00616164 File Offset: 0x00614364
		public ICloseGlobalTimeScaleT UnPack()
		{
			ICloseGlobalTimeScaleT closeGlobalTimeScaleT = new ICloseGlobalTimeScaleT();
			this.UnPackTo(closeGlobalTimeScaleT);
			return closeGlobalTimeScaleT;
		}

		// Token: 0x0602C5A3 RID: 181667 RVA: 0x0061617F File Offset: 0x0061437F
		public void UnPackTo(ICloseGlobalTimeScaleT _o)
		{
			_o.Type = this.Type;
			_o.TimeScaleCloseSource = this.TimeScaleCloseSource;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602C5A4 RID: 181668 RVA: 0x006161A8 File Offset: 0x006143A8
		public static Offset<ICloseGlobalTimeScale> Pack(FlatBufferBuilder builder, ICloseGlobalTimeScaleT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICloseGlobalTimeScale>);
			}
			return ICloseGlobalTimeScale.CreateICloseGlobalTimeScale(builder, _o.Type, _o.TimeScaleCloseSource, _o.NullMask);
		}

		// Token: 0x04010A0D RID: 68109
		private Table __p;
	}
}
