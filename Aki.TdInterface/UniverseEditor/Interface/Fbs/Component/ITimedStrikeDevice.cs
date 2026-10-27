using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A76 RID: 23158
	public struct ITimedStrikeDevice : IFlatbufferObject
	{
		// Token: 0x1700AE51 RID: 44625
		// (get) Token: 0x060276B9 RID: 161465 RVA: 0x0056C9AE File Offset: 0x0056ABAE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060276BA RID: 161466 RVA: 0x0056C9BB File Offset: 0x0056ABBB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060276BB RID: 161467 RVA: 0x0056C9C4 File Offset: 0x0056ABC4
		public static ITimedStrikeDevice GetRootAsITimedStrikeDevice(ByteBuffer _bb)
		{
			return ITimedStrikeDevice.GetRootAsITimedStrikeDevice(_bb, default(ITimedStrikeDevice));
		}

		// Token: 0x060276BC RID: 161468 RVA: 0x0056C9E0 File Offset: 0x0056ABE0
		public static ITimedStrikeDevice GetRootAsITimedStrikeDevice(ByteBuffer _bb, ITimedStrikeDevice obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060276BD RID: 161469 RVA: 0x0056C9FD File Offset: 0x0056ABFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060276BE RID: 161470 RVA: 0x0056CA0C File Offset: 0x0056AC0C
		public ITimedStrikeDevice __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AE52 RID: 44626
		// (get) Token: 0x060276BF RID: 161471 RVA: 0x0056CA1C File Offset: 0x0056AC1C
		public EProgressBarControlType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EProgressBarControlType.CaptureStrategicPoint;
				}
				return (EProgressBarControlType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AE53 RID: 44627
		// (get) Token: 0x060276C0 RID: 161472 RVA: 0x0056CA58 File Offset: 0x0056AC58
		public int MaxValue
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

		// Token: 0x1700AE54 RID: 44628
		// (get) Token: 0x060276C1 RID: 161473 RVA: 0x0056CA94 File Offset: 0x0056AC94
		public int InitValue
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AE55 RID: 44629
		// (get) Token: 0x060276C2 RID: 161474 RVA: 0x0056CAD0 File Offset: 0x0056ACD0
		public int ProgressPerformanceAttribute
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AE56 RID: 44630
		// (get) Token: 0x060276C3 RID: 161475 RVA: 0x0056CB10 File Offset: 0x0056AD10
		public int AddValue
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AE57 RID: 44631
		// (get) Token: 0x060276C4 RID: 161476 RVA: 0x0056CB50 File Offset: 0x0056AD50
		public int Timeout
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AE58 RID: 44632
		// (get) Token: 0x060276C5 RID: 161477 RVA: 0x0056CB90 File Offset: 0x0056AD90
		public int FallbackValue
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AE59 RID: 44633
		// (get) Token: 0x060276C6 RID: 161478 RVA: 0x0056CBD0 File Offset: 0x0056ADD0
		public int FallbackInterval
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AE5A RID: 44634
		// (get) Token: 0x060276C7 RID: 161479 RVA: 0x0056CC10 File Offset: 0x0056AE10
		public int ZeroValuePerformanceAttribute
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AE5B RID: 44635
		// (get) Token: 0x060276C8 RID: 161480 RVA: 0x0056CC50 File Offset: 0x0056AE50
		public int AscendPerformanceAttribute
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AE5C RID: 44636
		// (get) Token: 0x060276C9 RID: 161481 RVA: 0x0056CC90 File Offset: 0x0056AE90
		public int DescendPerformanceAttribute
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AE5D RID: 44637
		// (get) Token: 0x060276CA RID: 161482 RVA: 0x0056CCD0 File Offset: 0x0056AED0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060276CB RID: 161483 RVA: 0x0056CD10 File Offset: 0x0056AF10
		public static Offset<ITimedStrikeDevice> CreateITimedStrikeDevice(FlatBufferBuilder builder, EProgressBarControlType Type = EProgressBarControlType.CaptureStrategicPoint, int MaxValue = 0, int InitValue = 0, int ProgressPerformanceAttribute = 0, int AddValue = 0, int Timeout = 0, int FallbackValue = 0, int FallbackInterval = 0, int ZeroValuePerformanceAttribute = 0, int AscendPerformanceAttribute = 0, int DescendPerformanceAttribute = 0, byte NullMask = 0)
		{
			builder.StartTable(12);
			ITimedStrikeDevice.AddDescendPerformanceAttribute(builder, DescendPerformanceAttribute);
			ITimedStrikeDevice.AddAscendPerformanceAttribute(builder, AscendPerformanceAttribute);
			ITimedStrikeDevice.AddZeroValuePerformanceAttribute(builder, ZeroValuePerformanceAttribute);
			ITimedStrikeDevice.AddFallbackInterval(builder, FallbackInterval);
			ITimedStrikeDevice.AddFallbackValue(builder, FallbackValue);
			ITimedStrikeDevice.AddTimeout(builder, Timeout);
			ITimedStrikeDevice.AddAddValue(builder, AddValue);
			ITimedStrikeDevice.AddProgressPerformanceAttribute(builder, ProgressPerformanceAttribute);
			ITimedStrikeDevice.AddInitValue(builder, InitValue);
			ITimedStrikeDevice.AddMaxValue(builder, MaxValue);
			ITimedStrikeDevice.AddNullMask(builder, NullMask);
			ITimedStrikeDevice.AddType(builder, Type);
			return ITimedStrikeDevice.EndITimedStrikeDevice(builder);
		}

		// Token: 0x060276CC RID: 161484 RVA: 0x0056CD88 File Offset: 0x0056AF88
		public static void StartITimedStrikeDevice(FlatBufferBuilder builder)
		{
			builder.StartTable(12);
		}

		// Token: 0x060276CD RID: 161485 RVA: 0x0056CD92 File Offset: 0x0056AF92
		public static void AddType(FlatBufferBuilder builder, EProgressBarControlType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060276CE RID: 161486 RVA: 0x0056CD9D File Offset: 0x0056AF9D
		public static void AddMaxValue(FlatBufferBuilder builder, int maxValue)
		{
			builder.AddInt(1, maxValue, 0);
		}

		// Token: 0x060276CF RID: 161487 RVA: 0x0056CDA8 File Offset: 0x0056AFA8
		public static void AddInitValue(FlatBufferBuilder builder, int initValue)
		{
			builder.AddInt(2, initValue, 0);
		}

		// Token: 0x060276D0 RID: 161488 RVA: 0x0056CDB3 File Offset: 0x0056AFB3
		public static void AddProgressPerformanceAttribute(FlatBufferBuilder builder, int progressPerformanceAttribute)
		{
			builder.AddInt(3, progressPerformanceAttribute, 0);
		}

		// Token: 0x060276D1 RID: 161489 RVA: 0x0056CDBE File Offset: 0x0056AFBE
		public static void AddAddValue(FlatBufferBuilder builder, int addValue)
		{
			builder.AddInt(4, addValue, 0);
		}

		// Token: 0x060276D2 RID: 161490 RVA: 0x0056CDC9 File Offset: 0x0056AFC9
		public static void AddTimeout(FlatBufferBuilder builder, int timeout)
		{
			builder.AddInt(5, timeout, 0);
		}

		// Token: 0x060276D3 RID: 161491 RVA: 0x0056CDD4 File Offset: 0x0056AFD4
		public static void AddFallbackValue(FlatBufferBuilder builder, int fallbackValue)
		{
			builder.AddInt(6, fallbackValue, 0);
		}

		// Token: 0x060276D4 RID: 161492 RVA: 0x0056CDDF File Offset: 0x0056AFDF
		public static void AddFallbackInterval(FlatBufferBuilder builder, int fallbackInterval)
		{
			builder.AddInt(7, fallbackInterval, 0);
		}

		// Token: 0x060276D5 RID: 161493 RVA: 0x0056CDEA File Offset: 0x0056AFEA
		public static void AddZeroValuePerformanceAttribute(FlatBufferBuilder builder, int zeroValuePerformanceAttribute)
		{
			builder.AddInt(8, zeroValuePerformanceAttribute, 0);
		}

		// Token: 0x060276D6 RID: 161494 RVA: 0x0056CDF5 File Offset: 0x0056AFF5
		public static void AddAscendPerformanceAttribute(FlatBufferBuilder builder, int ascendPerformanceAttribute)
		{
			builder.AddInt(9, ascendPerformanceAttribute, 0);
		}

		// Token: 0x060276D7 RID: 161495 RVA: 0x0056CE01 File Offset: 0x0056B001
		public static void AddDescendPerformanceAttribute(FlatBufferBuilder builder, int descendPerformanceAttribute)
		{
			builder.AddInt(10, descendPerformanceAttribute, 0);
		}

		// Token: 0x060276D8 RID: 161496 RVA: 0x0056CE0D File Offset: 0x0056B00D
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(11, nullMask, 0);
		}

		// Token: 0x060276D9 RID: 161497 RVA: 0x0056CE19 File Offset: 0x0056B019
		public static Offset<ITimedStrikeDevice> EndITimedStrikeDevice(FlatBufferBuilder builder)
		{
			return new Offset<ITimedStrikeDevice>(builder.EndTable());
		}

		// Token: 0x060276DA RID: 161498 RVA: 0x0056CE28 File Offset: 0x0056B028
		public ITimedStrikeDeviceT UnPack()
		{
			ITimedStrikeDeviceT timedStrikeDeviceT = new ITimedStrikeDeviceT();
			this.UnPackTo(timedStrikeDeviceT);
			return timedStrikeDeviceT;
		}

		// Token: 0x060276DB RID: 161499 RVA: 0x0056CE44 File Offset: 0x0056B044
		public void UnPackTo(ITimedStrikeDeviceT _o)
		{
			_o.Type = this.Type;
			_o.MaxValue = this.MaxValue;
			_o.InitValue = this.InitValue;
			_o.ProgressPerformanceAttribute = this.ProgressPerformanceAttribute;
			_o.AddValue = this.AddValue;
			_o.Timeout = this.Timeout;
			_o.FallbackValue = this.FallbackValue;
			_o.FallbackInterval = this.FallbackInterval;
			_o.ZeroValuePerformanceAttribute = this.ZeroValuePerformanceAttribute;
			_o.AscendPerformanceAttribute = this.AscendPerformanceAttribute;
			_o.DescendPerformanceAttribute = this.DescendPerformanceAttribute;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060276DC RID: 161500 RVA: 0x0056CEE4 File Offset: 0x0056B0E4
		public static Offset<ITimedStrikeDevice> Pack(FlatBufferBuilder builder, ITimedStrikeDeviceT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimedStrikeDevice>);
			}
			return ITimedStrikeDevice.CreateITimedStrikeDevice(builder, _o.Type, _o.MaxValue, _o.InitValue, _o.ProgressPerformanceAttribute, _o.AddValue, _o.Timeout, _o.FallbackValue, _o.FallbackInterval, _o.ZeroValuePerformanceAttribute, _o.AscendPerformanceAttribute, _o.DescendPerformanceAttribute, _o.NullMask);
		}

		// Token: 0x0400F118 RID: 61720
		private Table __p;
	}
}
