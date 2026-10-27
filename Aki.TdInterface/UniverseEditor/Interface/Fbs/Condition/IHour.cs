using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C3D RID: 19517
	public struct IHour : IFlatbufferObject
	{
		// Token: 0x17008DC9 RID: 36297
		// (get) Token: 0x0601EEED RID: 126701 RVA: 0x00453DEC File Offset: 0x00451FEC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EEEE RID: 126702 RVA: 0x00453DF9 File Offset: 0x00451FF9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EEEF RID: 126703 RVA: 0x00453E00 File Offset: 0x00452000
		public static IHour GetRootAsIHour(ByteBuffer _bb)
		{
			return IHour.GetRootAsIHour(_bb, default(IHour));
		}

		// Token: 0x0601EEF0 RID: 126704 RVA: 0x00453E1C File Offset: 0x0045201C
		public static IHour GetRootAsIHour(ByteBuffer _bb, IHour obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EEF1 RID: 126705 RVA: 0x00453E39 File Offset: 0x00452039
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EEF2 RID: 126706 RVA: 0x00453E48 File Offset: 0x00452048
		public IHour __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008DCA RID: 36298
		// (get) Token: 0x0601EEF3 RID: 126707 RVA: 0x00453E58 File Offset: 0x00452058
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

		// Token: 0x17008DCB RID: 36299
		// (get) Token: 0x0601EEF4 RID: 126708 RVA: 0x00453E94 File Offset: 0x00452094
		public int Min
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

		// Token: 0x0601EEF5 RID: 126709 RVA: 0x00453ED0 File Offset: 0x004520D0
		public static Offset<IHour> CreateIHour(FlatBufferBuilder builder, int Hour = 0, int Min = 0)
		{
			builder.StartTable(2);
			IHour.AddMin(builder, Min);
			IHour.AddHour(builder, Hour);
			return IHour.EndIHour(builder);
		}

		// Token: 0x0601EEF6 RID: 126710 RVA: 0x00453EED File Offset: 0x004520ED
		public static void StartIHour(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601EEF7 RID: 126711 RVA: 0x00453EF6 File Offset: 0x004520F6
		public static void AddHour(FlatBufferBuilder builder, int hour)
		{
			builder.AddInt(0, hour, 0);
		}

		// Token: 0x0601EEF8 RID: 126712 RVA: 0x00453F01 File Offset: 0x00452101
		public static void AddMin(FlatBufferBuilder builder, int min)
		{
			builder.AddInt(1, min, 0);
		}

		// Token: 0x0601EEF9 RID: 126713 RVA: 0x00453F0C File Offset: 0x0045210C
		public static Offset<IHour> EndIHour(FlatBufferBuilder builder)
		{
			return new Offset<IHour>(builder.EndTable());
		}

		// Token: 0x0601EEFA RID: 126714 RVA: 0x00453F1C File Offset: 0x0045211C
		public IHourT UnPack()
		{
			IHourT hourT = new IHourT();
			this.UnPackTo(hourT);
			return hourT;
		}

		// Token: 0x0601EEFB RID: 126715 RVA: 0x00453F37 File Offset: 0x00452137
		public void UnPackTo(IHourT _o)
		{
			_o.Hour = this.Hour;
			_o.Min = this.Min;
		}

		// Token: 0x0601EEFC RID: 126716 RVA: 0x00453F54 File Offset: 0x00452154
		public static Offset<IHour> Pack(FlatBufferBuilder builder, IHourT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHour>);
			}
			return IHour.CreateIHour(builder, _o.Hour, _o.Min);
		}

		// Token: 0x0400D5E2 RID: 54754
		private Table __p;
	}
}
