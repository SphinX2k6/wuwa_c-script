using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061E8 RID: 25064
	public struct IBaseTime : IFlatbufferObject
	{
		// Token: 0x1700BADB RID: 47835
		// (get) Token: 0x0602B335 RID: 176949 RVA: 0x005F421A File Offset: 0x005F241A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B336 RID: 176950 RVA: 0x005F4227 File Offset: 0x005F2427
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B337 RID: 176951 RVA: 0x005F4230 File Offset: 0x005F2430
		public static IBaseTime GetRootAsIBaseTime(ByteBuffer _bb)
		{
			return IBaseTime.GetRootAsIBaseTime(_bb, default(IBaseTime));
		}

		// Token: 0x0602B338 RID: 176952 RVA: 0x005F424C File Offset: 0x005F244C
		public static IBaseTime GetRootAsIBaseTime(ByteBuffer _bb, IBaseTime obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B339 RID: 176953 RVA: 0x005F4269 File Offset: 0x005F2469
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B33A RID: 176954 RVA: 0x005F4278 File Offset: 0x005F2478
		public IBaseTime __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BADC RID: 47836
		// (get) Token: 0x0602B33B RID: 176955 RVA: 0x005F4288 File Offset: 0x005F2488
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

		// Token: 0x1700BADD RID: 47837
		// (get) Token: 0x0602B33C RID: 176956 RVA: 0x005F42C4 File Offset: 0x005F24C4
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

		// Token: 0x0602B33D RID: 176957 RVA: 0x005F4300 File Offset: 0x005F2500
		public static Offset<IBaseTime> CreateIBaseTime(FlatBufferBuilder builder, int Hour = 0, int Minute = 0)
		{
			builder.StartTable(2);
			IBaseTime.AddMinute(builder, Minute);
			IBaseTime.AddHour(builder, Hour);
			return IBaseTime.EndIBaseTime(builder);
		}

		// Token: 0x0602B33E RID: 176958 RVA: 0x005F431D File Offset: 0x005F251D
		public static void StartIBaseTime(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602B33F RID: 176959 RVA: 0x005F4326 File Offset: 0x005F2526
		public static void AddHour(FlatBufferBuilder builder, int hour)
		{
			builder.AddInt(0, hour, 0);
		}

		// Token: 0x0602B340 RID: 176960 RVA: 0x005F4331 File Offset: 0x005F2531
		public static void AddMinute(FlatBufferBuilder builder, int minute)
		{
			builder.AddInt(1, minute, 0);
		}

		// Token: 0x0602B341 RID: 176961 RVA: 0x005F433C File Offset: 0x005F253C
		public static Offset<IBaseTime> EndIBaseTime(FlatBufferBuilder builder)
		{
			return new Offset<IBaseTime>(builder.EndTable());
		}

		// Token: 0x0602B342 RID: 176962 RVA: 0x005F434C File Offset: 0x005F254C
		public IBaseTimeT UnPack()
		{
			IBaseTimeT baseTimeT = new IBaseTimeT();
			this.UnPackTo(baseTimeT);
			return baseTimeT;
		}

		// Token: 0x0602B343 RID: 176963 RVA: 0x005F4367 File Offset: 0x005F2567
		public void UnPackTo(IBaseTimeT _o)
		{
			_o.Hour = this.Hour;
			_o.Minute = this.Minute;
		}

		// Token: 0x0602B344 RID: 176964 RVA: 0x005F4384 File Offset: 0x005F2584
		public static Offset<IBaseTime> Pack(FlatBufferBuilder builder, IBaseTimeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBaseTime>);
			}
			return IBaseTime.CreateIBaseTime(builder, _o.Hour, _o.Minute);
		}

		// Token: 0x0401071B RID: 67355
		private Table __p;
	}
}
