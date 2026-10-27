using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BC8 RID: 19400
	public struct ICompareTimePeriod : IFlatbufferObject
	{
		// Token: 0x17008CE5 RID: 36069
		// (get) Token: 0x0601E9D7 RID: 125399 RVA: 0x004480D8 File Offset: 0x004462D8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E9D8 RID: 125400 RVA: 0x004480E5 File Offset: 0x004462E5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E9D9 RID: 125401 RVA: 0x004480EC File Offset: 0x004462EC
		public static ICompareTimePeriod GetRootAsICompareTimePeriod(ByteBuffer _bb)
		{
			return ICompareTimePeriod.GetRootAsICompareTimePeriod(_bb, default(ICompareTimePeriod));
		}

		// Token: 0x0601E9DA RID: 125402 RVA: 0x00448108 File Offset: 0x00446308
		public static ICompareTimePeriod GetRootAsICompareTimePeriod(ByteBuffer _bb, ICompareTimePeriod obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E9DB RID: 125403 RVA: 0x00448125 File Offset: 0x00446325
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E9DC RID: 125404 RVA: 0x00448134 File Offset: 0x00446334
		public ICompareTimePeriod __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008CE6 RID: 36070
		// (get) Token: 0x0601E9DD RID: 125405 RVA: 0x00448144 File Offset: 0x00446344
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008CE7 RID: 36071
		// (get) Token: 0x0601E9DE RID: 125406 RVA: 0x00448180 File Offset: 0x00446380
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008CE8 RID: 36072
		// (get) Token: 0x0601E9DF RID: 125407 RVA: 0x004481BC File Offset: 0x004463BC
		public ETimePeriod TimePeriod
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ETimePeriod.DayTime;
				}
				return (ETimePeriod)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E9E0 RID: 125408 RVA: 0x004481F8 File Offset: 0x004463F8
		public static Offset<ICompareTimePeriod> CreateICompareTimePeriod(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, ECompare Compare = ECompare.Eq, ETimePeriod TimePeriod = ETimePeriod.DayTime)
		{
			builder.StartTable(3);
			ICompareTimePeriod.AddTimePeriod(builder, TimePeriod);
			ICompareTimePeriod.AddCompare(builder, Compare);
			ICompareTimePeriod.AddType(builder, Type);
			return ICompareTimePeriod.EndICompareTimePeriod(builder);
		}

		// Token: 0x0601E9E1 RID: 125409 RVA: 0x0044821C File Offset: 0x0044641C
		public static void StartICompareTimePeriod(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601E9E2 RID: 125410 RVA: 0x00448225 File Offset: 0x00446425
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E9E3 RID: 125411 RVA: 0x00448230 File Offset: 0x00446430
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x0601E9E4 RID: 125412 RVA: 0x0044823B File Offset: 0x0044643B
		public static void AddTimePeriod(FlatBufferBuilder builder, ETimePeriod timePeriod)
		{
			builder.AddByte(2, (byte)timePeriod, 0);
		}

		// Token: 0x0601E9E5 RID: 125413 RVA: 0x00448246 File Offset: 0x00446446
		public static Offset<ICompareTimePeriod> EndICompareTimePeriod(FlatBufferBuilder builder)
		{
			return new Offset<ICompareTimePeriod>(builder.EndTable());
		}

		// Token: 0x0601E9E6 RID: 125414 RVA: 0x00448254 File Offset: 0x00446454
		public ICompareTimePeriodT UnPack()
		{
			ICompareTimePeriodT compareTimePeriodT = new ICompareTimePeriodT();
			this.UnPackTo(compareTimePeriodT);
			return compareTimePeriodT;
		}

		// Token: 0x0601E9E7 RID: 125415 RVA: 0x0044826F File Offset: 0x0044646F
		public void UnPackTo(ICompareTimePeriodT _o)
		{
			_o.Type = this.Type;
			_o.Compare = this.Compare;
			_o.TimePeriod = this.TimePeriod;
		}

		// Token: 0x0601E9E8 RID: 125416 RVA: 0x00448298 File Offset: 0x00446498
		public static Offset<ICompareTimePeriod> Pack(FlatBufferBuilder builder, ICompareTimePeriodT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompareTimePeriod>);
			}
			return ICompareTimePeriod.CreateICompareTimePeriod(builder, _o.Type, _o.Compare, _o.TimePeriod);
		}

		// Token: 0x0400D4B4 RID: 54452
		private Table __p;
	}
}
