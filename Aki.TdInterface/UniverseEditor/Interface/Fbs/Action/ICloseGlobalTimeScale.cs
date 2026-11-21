using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A98 RID: 27288
	public struct ICloseGlobalTimeScale : IFlatbufferObject
	{
		// Token: 0x1700C869 RID: 51305
		// (get) Token: 0x0602ED41 RID: 191809 RVA: 0x00661AFB File Offset: 0x0065FCFB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602ED42 RID: 191810 RVA: 0x00661B08 File Offset: 0x0065FD08
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602ED43 RID: 191811 RVA: 0x00661B10 File Offset: 0x0065FD10
		public static ICloseGlobalTimeScale GetRootAsICloseGlobalTimeScale(ByteBuffer _bb)
		{
			return ICloseGlobalTimeScale.GetRootAsICloseGlobalTimeScale(_bb, default(ICloseGlobalTimeScale));
		}

		// Token: 0x0602ED44 RID: 191812 RVA: 0x00661B2C File Offset: 0x0065FD2C
		public static ICloseGlobalTimeScale GetRootAsICloseGlobalTimeScale(ByteBuffer _bb, ICloseGlobalTimeScale obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602ED45 RID: 191813 RVA: 0x00661B49 File Offset: 0x0065FD49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602ED46 RID: 191814 RVA: 0x00661B58 File Offset: 0x0065FD58
		public ICloseGlobalTimeScale __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C86A RID: 51306
		// (get) Token: 0x0602ED47 RID: 191815 RVA: 0x00661B68 File Offset: 0x0065FD68
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

		// Token: 0x1700C86B RID: 51307
		// (get) Token: 0x0602ED48 RID: 191816 RVA: 0x00661BA4 File Offset: 0x0065FDA4
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

		// Token: 0x1700C86C RID: 51308
		// (get) Token: 0x0602ED49 RID: 191817 RVA: 0x00661BE0 File Offset: 0x0065FDE0
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

		// Token: 0x0602ED4A RID: 191818 RVA: 0x00661C1C File Offset: 0x0065FE1C
		public static Offset<ICloseGlobalTimeScale> CreateICloseGlobalTimeScale(FlatBufferBuilder builder, ESetTimeScaleType Type = ESetTimeScaleType.Open, ETimeScaleCloseSource TimeScaleCloseSource = ETimeScaleCloseSource.All, byte NullMask = 0)
		{
			builder.StartTable(3);
			ICloseGlobalTimeScale.AddNullMask(builder, NullMask);
			ICloseGlobalTimeScale.AddTimeScaleCloseSource(builder, TimeScaleCloseSource);
			ICloseGlobalTimeScale.AddType(builder, Type);
			return ICloseGlobalTimeScale.EndICloseGlobalTimeScale(builder);
		}

		// Token: 0x0602ED4B RID: 191819 RVA: 0x00661C40 File Offset: 0x0065FE40
		public static void StartICloseGlobalTimeScale(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602ED4C RID: 191820 RVA: 0x00661C49 File Offset: 0x0065FE49
		public static void AddType(FlatBufferBuilder builder, ESetTimeScaleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602ED4D RID: 191821 RVA: 0x00661C54 File Offset: 0x0065FE54
		public static void AddTimeScaleCloseSource(FlatBufferBuilder builder, ETimeScaleCloseSource timeScaleCloseSource)
		{
			builder.AddByte(1, (byte)timeScaleCloseSource, 0);
		}

		// Token: 0x0602ED4E RID: 191822 RVA: 0x00661C5F File Offset: 0x0065FE5F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602ED4F RID: 191823 RVA: 0x00661C6A File Offset: 0x0065FE6A
		public static Offset<ICloseGlobalTimeScale> EndICloseGlobalTimeScale(FlatBufferBuilder builder)
		{
			return new Offset<ICloseGlobalTimeScale>(builder.EndTable());
		}

		// Token: 0x0602ED50 RID: 191824 RVA: 0x00661C78 File Offset: 0x0065FE78
		public ICloseGlobalTimeScaleT UnPack()
		{
			ICloseGlobalTimeScaleT closeGlobalTimeScaleT = new ICloseGlobalTimeScaleT();
			this.UnPackTo(closeGlobalTimeScaleT);
			return closeGlobalTimeScaleT;
		}

		// Token: 0x0602ED51 RID: 191825 RVA: 0x00661C93 File Offset: 0x0065FE93
		public void UnPackTo(ICloseGlobalTimeScaleT _o)
		{
			_o.Type = this.Type;
			_o.TimeScaleCloseSource = this.TimeScaleCloseSource;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602ED52 RID: 191826 RVA: 0x00661CBC File Offset: 0x0065FEBC
		public static Offset<ICloseGlobalTimeScale> Pack(FlatBufferBuilder builder, ICloseGlobalTimeScaleT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICloseGlobalTimeScale>);
			}
			return ICloseGlobalTimeScale.CreateICloseGlobalTimeScale(builder, _o.Type, _o.TimeScaleCloseSource, _o.NullMask);
		}

		// Token: 0x0401182E RID: 71726
		private Table __p;
	}
}
