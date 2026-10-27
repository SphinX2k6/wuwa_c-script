using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067D1 RID: 26577
	public struct IFixedTime : IFlatbufferObject
	{
		// Token: 0x1700C54E RID: 50510
		// (get) Token: 0x0602E447 RID: 189511 RVA: 0x0065177C File Offset: 0x0064F97C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E448 RID: 189512 RVA: 0x00651789 File Offset: 0x0064F989
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E449 RID: 189513 RVA: 0x00651790 File Offset: 0x0064F990
		public static IFixedTime GetRootAsIFixedTime(ByteBuffer _bb)
		{
			return IFixedTime.GetRootAsIFixedTime(_bb, default(IFixedTime));
		}

		// Token: 0x0602E44A RID: 189514 RVA: 0x006517AC File Offset: 0x0064F9AC
		public static IFixedTime GetRootAsIFixedTime(ByteBuffer _bb, IFixedTime obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E44B RID: 189515 RVA: 0x006517C9 File Offset: 0x0064F9C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E44C RID: 189516 RVA: 0x006517D8 File Offset: 0x0064F9D8
		public IFixedTime __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C54F RID: 50511
		// (get) Token: 0x0602E44D RID: 189517 RVA: 0x006517E8 File Offset: 0x0064F9E8
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

		// Token: 0x1700C550 RID: 50512
		// (get) Token: 0x0602E44E RID: 189518 RVA: 0x00651824 File Offset: 0x0064FA24
		public int Minutes
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

		// Token: 0x0602E44F RID: 189519 RVA: 0x00651860 File Offset: 0x0064FA60
		public static Offset<IFixedTime> CreateIFixedTime(FlatBufferBuilder builder, int Hour = 0, int Minutes = 0)
		{
			builder.StartTable(2);
			IFixedTime.AddMinutes(builder, Minutes);
			IFixedTime.AddHour(builder, Hour);
			return IFixedTime.EndIFixedTime(builder);
		}

		// Token: 0x0602E450 RID: 189520 RVA: 0x0065187D File Offset: 0x0064FA7D
		public static void StartIFixedTime(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602E451 RID: 189521 RVA: 0x00651886 File Offset: 0x0064FA86
		public static void AddHour(FlatBufferBuilder builder, int hour)
		{
			builder.AddInt(0, hour, 0);
		}

		// Token: 0x0602E452 RID: 189522 RVA: 0x00651891 File Offset: 0x0064FA91
		public static void AddMinutes(FlatBufferBuilder builder, int minutes)
		{
			builder.AddInt(1, minutes, 0);
		}

		// Token: 0x0602E453 RID: 189523 RVA: 0x0065189C File Offset: 0x0064FA9C
		public static Offset<IFixedTime> EndIFixedTime(FlatBufferBuilder builder)
		{
			return new Offset<IFixedTime>(builder.EndTable());
		}

		// Token: 0x0602E454 RID: 189524 RVA: 0x006518AC File Offset: 0x0064FAAC
		public IFixedTimeT UnPack()
		{
			IFixedTimeT fixedTimeT = new IFixedTimeT();
			this.UnPackTo(fixedTimeT);
			return fixedTimeT;
		}

		// Token: 0x0602E455 RID: 189525 RVA: 0x006518C7 File Offset: 0x0064FAC7
		public void UnPackTo(IFixedTimeT _o)
		{
			_o.Hour = this.Hour;
			_o.Minutes = this.Minutes;
		}

		// Token: 0x0602E456 RID: 189526 RVA: 0x006518E4 File Offset: 0x0064FAE4
		public static Offset<IFixedTime> Pack(FlatBufferBuilder builder, IFixedTimeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFixedTime>);
			}
			return IFixedTime.CreateIFixedTime(builder, _o.Hour, _o.Minutes);
		}

		// Token: 0x04010EEF RID: 69359
		private Table __p;
	}
}
