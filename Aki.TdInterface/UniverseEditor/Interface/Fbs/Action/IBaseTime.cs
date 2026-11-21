using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006856 RID: 26710
	public struct IBaseTime : IFlatbufferObject
	{
		// Token: 0x1700C45E RID: 50270
		// (get) Token: 0x0602DA7C RID: 187004 RVA: 0x0063EC8E File Offset: 0x0063CE8E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DA7D RID: 187005 RVA: 0x0063EC9B File Offset: 0x0063CE9B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DA7E RID: 187006 RVA: 0x0063ECA4 File Offset: 0x0063CEA4
		public static IBaseTime GetRootAsIBaseTime(ByteBuffer _bb)
		{
			return IBaseTime.GetRootAsIBaseTime(_bb, default(IBaseTime));
		}

		// Token: 0x0602DA7F RID: 187007 RVA: 0x0063ECC0 File Offset: 0x0063CEC0
		public static IBaseTime GetRootAsIBaseTime(ByteBuffer _bb, IBaseTime obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DA80 RID: 187008 RVA: 0x0063ECDD File Offset: 0x0063CEDD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DA81 RID: 187009 RVA: 0x0063ECEC File Offset: 0x0063CEEC
		public IBaseTime __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C45F RID: 50271
		// (get) Token: 0x0602DA82 RID: 187010 RVA: 0x0063ECFC File Offset: 0x0063CEFC
		public int Hour
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

		// Token: 0x1700C460 RID: 50272
		// (get) Token: 0x0602DA83 RID: 187011 RVA: 0x0063ED38 File Offset: 0x0063CF38
		public int Minute
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602DA84 RID: 187012 RVA: 0x0063ED74 File Offset: 0x0063CF74
		public static Offset<IBaseTime> CreateIBaseTime(FlatBufferBuilder builder, int Hour = 0, int Minute = 0)
		{
			builder.StartTable(2);
			IBaseTime.AddMinute(builder, Minute);
			IBaseTime.AddHour(builder, Hour);
			return IBaseTime.EndIBaseTime(builder);
		}

		// Token: 0x0602DA85 RID: 187013 RVA: 0x0063ED91 File Offset: 0x0063CF91
		public static void StartIBaseTime(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602DA86 RID: 187014 RVA: 0x0063ED9A File Offset: 0x0063CF9A
		public static void AddHour(FlatBufferBuilder builder, int hour)
		{
			builder.AddInt(0, hour, 0);
		}

		// Token: 0x0602DA87 RID: 187015 RVA: 0x0063EDA5 File Offset: 0x0063CFA5
		public static void AddMinute(FlatBufferBuilder builder, int minute)
		{
			builder.AddInt(1, minute, 0);
		}

		// Token: 0x0602DA88 RID: 187016 RVA: 0x0063EDB0 File Offset: 0x0063CFB0
		public static Offset<IBaseTime> EndIBaseTime(FlatBufferBuilder builder)
		{
			return new Offset<IBaseTime>(builder.EndTable());
		}

		// Token: 0x0602DA89 RID: 187017 RVA: 0x0063EDC0 File Offset: 0x0063CFC0
		public IBaseTimeT UnPack()
		{
			IBaseTimeT baseTimeT = new IBaseTimeT();
			this.UnPackTo(baseTimeT);
			return baseTimeT;
		}

		// Token: 0x0602DA8A RID: 187018 RVA: 0x0063EDDB File Offset: 0x0063CFDB
		public void UnPackTo(IBaseTimeT _o)
		{
			_o.Hour = this.Hour;
			_o.Minute = this.Minute;
		}

		// Token: 0x0602DA8B RID: 187019 RVA: 0x0063EDF8 File Offset: 0x0063CFF8
		public static Offset<IBaseTime> Pack(FlatBufferBuilder builder, IBaseTimeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBaseTime>);
			}
			return IBaseTime.CreateIBaseTime(builder, _o.Hour, _o.Minute);
		}

		// Token: 0x0401152D RID: 70957
		private Table __p;
	}
}
