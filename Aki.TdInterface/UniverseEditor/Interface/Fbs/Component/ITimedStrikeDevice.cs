using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006083 RID: 24707
	public struct ITimedStrikeDevice : IFlatbufferObject
	{
		// Token: 0x1700B789 RID: 46985
		// (get) Token: 0x06029C31 RID: 171057 RVA: 0x005B39BA File Offset: 0x005B1BBA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029C32 RID: 171058 RVA: 0x005B39C7 File Offset: 0x005B1BC7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029C33 RID: 171059 RVA: 0x005B39D0 File Offset: 0x005B1BD0
		public static ITimedStrikeDevice GetRootAsITimedStrikeDevice(ByteBuffer _bb)
		{
			return ITimedStrikeDevice.GetRootAsITimedStrikeDevice(_bb, default(ITimedStrikeDevice));
		}

		// Token: 0x06029C34 RID: 171060 RVA: 0x005B39EC File Offset: 0x005B1BEC
		public static ITimedStrikeDevice GetRootAsITimedStrikeDevice(ByteBuffer _bb, ITimedStrikeDevice obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029C35 RID: 171061 RVA: 0x005B3A09 File Offset: 0x005B1C09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029C36 RID: 171062 RVA: 0x005B3A18 File Offset: 0x005B1C18
		public ITimedStrikeDevice __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B78A RID: 46986
		// (get) Token: 0x06029C37 RID: 171063 RVA: 0x005B3A28 File Offset: 0x005B1C28
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

		// Token: 0x1700B78B RID: 46987
		// (get) Token: 0x06029C38 RID: 171064 RVA: 0x005B3A64 File Offset: 0x005B1C64
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

		// Token: 0x1700B78C RID: 46988
		// (get) Token: 0x06029C39 RID: 171065 RVA: 0x005B3AA0 File Offset: 0x005B1CA0
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

		// Token: 0x1700B78D RID: 46989
		// (get) Token: 0x06029C3A RID: 171066 RVA: 0x005B3ADC File Offset: 0x005B1CDC
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

		// Token: 0x1700B78E RID: 46990
		// (get) Token: 0x06029C3B RID: 171067 RVA: 0x005B3B1C File Offset: 0x005B1D1C
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

		// Token: 0x1700B78F RID: 46991
		// (get) Token: 0x06029C3C RID: 171068 RVA: 0x005B3B5C File Offset: 0x005B1D5C
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

		// Token: 0x1700B790 RID: 46992
		// (get) Token: 0x06029C3D RID: 171069 RVA: 0x005B3B9C File Offset: 0x005B1D9C
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

		// Token: 0x1700B791 RID: 46993
		// (get) Token: 0x06029C3E RID: 171070 RVA: 0x005B3BDC File Offset: 0x005B1DDC
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

		// Token: 0x1700B792 RID: 46994
		// (get) Token: 0x06029C3F RID: 171071 RVA: 0x005B3C1C File Offset: 0x005B1E1C
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

		// Token: 0x1700B793 RID: 46995
		// (get) Token: 0x06029C40 RID: 171072 RVA: 0x005B3C5C File Offset: 0x005B1E5C
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

		// Token: 0x1700B794 RID: 46996
		// (get) Token: 0x06029C41 RID: 171073 RVA: 0x005B3C9C File Offset: 0x005B1E9C
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

		// Token: 0x1700B795 RID: 46997
		// (get) Token: 0x06029C42 RID: 171074 RVA: 0x005B3CDC File Offset: 0x005B1EDC
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

		// Token: 0x06029C43 RID: 171075 RVA: 0x005B3D1C File Offset: 0x005B1F1C
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

		// Token: 0x06029C44 RID: 171076 RVA: 0x005B3D94 File Offset: 0x005B1F94
		public static void StartITimedStrikeDevice(FlatBufferBuilder builder)
		{
			builder.StartTable(12);
		}

		// Token: 0x06029C45 RID: 171077 RVA: 0x005B3D9E File Offset: 0x005B1F9E
		public static void AddType(FlatBufferBuilder builder, EProgressBarControlType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029C46 RID: 171078 RVA: 0x005B3DA9 File Offset: 0x005B1FA9
		public static void AddMaxValue(FlatBufferBuilder builder, int maxValue)
		{
			builder.AddInt(1, maxValue, 0);
		}

		// Token: 0x06029C47 RID: 171079 RVA: 0x005B3DB4 File Offset: 0x005B1FB4
		public static void AddInitValue(FlatBufferBuilder builder, int initValue)
		{
			builder.AddInt(2, initValue, 0);
		}

		// Token: 0x06029C48 RID: 171080 RVA: 0x005B3DBF File Offset: 0x005B1FBF
		public static void AddProgressPerformanceAttribute(FlatBufferBuilder builder, int progressPerformanceAttribute)
		{
			builder.AddInt(3, progressPerformanceAttribute, 0);
		}

		// Token: 0x06029C49 RID: 171081 RVA: 0x005B3DCA File Offset: 0x005B1FCA
		public static void AddAddValue(FlatBufferBuilder builder, int addValue)
		{
			builder.AddInt(4, addValue, 0);
		}

		// Token: 0x06029C4A RID: 171082 RVA: 0x005B3DD5 File Offset: 0x005B1FD5
		public static void AddTimeout(FlatBufferBuilder builder, int timeout)
		{
			builder.AddInt(5, timeout, 0);
		}

		// Token: 0x06029C4B RID: 171083 RVA: 0x005B3DE0 File Offset: 0x005B1FE0
		public static void AddFallbackValue(FlatBufferBuilder builder, int fallbackValue)
		{
			builder.AddInt(6, fallbackValue, 0);
		}

		// Token: 0x06029C4C RID: 171084 RVA: 0x005B3DEB File Offset: 0x005B1FEB
		public static void AddFallbackInterval(FlatBufferBuilder builder, int fallbackInterval)
		{
			builder.AddInt(7, fallbackInterval, 0);
		}

		// Token: 0x06029C4D RID: 171085 RVA: 0x005B3DF6 File Offset: 0x005B1FF6
		public static void AddZeroValuePerformanceAttribute(FlatBufferBuilder builder, int zeroValuePerformanceAttribute)
		{
			builder.AddInt(8, zeroValuePerformanceAttribute, 0);
		}

		// Token: 0x06029C4E RID: 171086 RVA: 0x005B3E01 File Offset: 0x005B2001
		public static void AddAscendPerformanceAttribute(FlatBufferBuilder builder, int ascendPerformanceAttribute)
		{
			builder.AddInt(9, ascendPerformanceAttribute, 0);
		}

		// Token: 0x06029C4F RID: 171087 RVA: 0x005B3E0D File Offset: 0x005B200D
		public static void AddDescendPerformanceAttribute(FlatBufferBuilder builder, int descendPerformanceAttribute)
		{
			builder.AddInt(10, descendPerformanceAttribute, 0);
		}

		// Token: 0x06029C50 RID: 171088 RVA: 0x005B3E19 File Offset: 0x005B2019
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(11, nullMask, 0);
		}

		// Token: 0x06029C51 RID: 171089 RVA: 0x005B3E25 File Offset: 0x005B2025
		public static Offset<ITimedStrikeDevice> EndITimedStrikeDevice(FlatBufferBuilder builder)
		{
			return new Offset<ITimedStrikeDevice>(builder.EndTable());
		}

		// Token: 0x06029C52 RID: 171090 RVA: 0x005B3E34 File Offset: 0x005B2034
		public ITimedStrikeDeviceT UnPack()
		{
			ITimedStrikeDeviceT timedStrikeDeviceT = new ITimedStrikeDeviceT();
			this.UnPackTo(timedStrikeDeviceT);
			return timedStrikeDeviceT;
		}

		// Token: 0x06029C53 RID: 171091 RVA: 0x005B3E50 File Offset: 0x005B2050
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

		// Token: 0x06029C54 RID: 171092 RVA: 0x005B3EF0 File Offset: 0x005B20F0
		public static Offset<ITimedStrikeDevice> Pack(FlatBufferBuilder builder, ITimedStrikeDeviceT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimedStrikeDevice>);
			}
			return ITimedStrikeDevice.CreateITimedStrikeDevice(builder, _o.Type, _o.MaxValue, _o.InitValue, _o.ProgressPerformanceAttribute, _o.AddValue, _o.Timeout, _o.FallbackValue, _o.FallbackInterval, _o.ZeroValuePerformanceAttribute, _o.AscendPerformanceAttribute, _o.DescendPerformanceAttribute, _o.NullMask);
		}

		// Token: 0x0400FE0F RID: 65039
		private Table __p;
	}
}
