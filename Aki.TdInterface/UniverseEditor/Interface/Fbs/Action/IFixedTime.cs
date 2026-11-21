using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E51 RID: 28241
	public struct IFixedTime : IFlatbufferObject
	{
		// Token: 0x1700CF04 RID: 52996
		// (get) Token: 0x06030C8D RID: 199821 RVA: 0x0069EEC0 File Offset: 0x0069D0C0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030C8E RID: 199822 RVA: 0x0069EECD File Offset: 0x0069D0CD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030C8F RID: 199823 RVA: 0x0069EED4 File Offset: 0x0069D0D4
		public static IFixedTime GetRootAsIFixedTime(ByteBuffer _bb)
		{
			return IFixedTime.GetRootAsIFixedTime(_bb, default(IFixedTime));
		}

		// Token: 0x06030C90 RID: 199824 RVA: 0x0069EEF0 File Offset: 0x0069D0F0
		public static IFixedTime GetRootAsIFixedTime(ByteBuffer _bb, IFixedTime obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030C91 RID: 199825 RVA: 0x0069EF0D File Offset: 0x0069D10D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030C92 RID: 199826 RVA: 0x0069EF1C File Offset: 0x0069D11C
		public IFixedTime __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CF05 RID: 52997
		// (get) Token: 0x06030C93 RID: 199827 RVA: 0x0069EF2C File Offset: 0x0069D12C
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

		// Token: 0x1700CF06 RID: 52998
		// (get) Token: 0x06030C94 RID: 199828 RVA: 0x0069EF68 File Offset: 0x0069D168
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

		// Token: 0x06030C95 RID: 199829 RVA: 0x0069EFA4 File Offset: 0x0069D1A4
		public static Offset<IFixedTime> CreateIFixedTime(FlatBufferBuilder builder, int Hour = 0, int Minutes = 0)
		{
			builder.StartTable(2);
			IFixedTime.AddMinutes(builder, Minutes);
			IFixedTime.AddHour(builder, Hour);
			return IFixedTime.EndIFixedTime(builder);
		}

		// Token: 0x06030C96 RID: 199830 RVA: 0x0069EFC1 File Offset: 0x0069D1C1
		public static void StartIFixedTime(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06030C97 RID: 199831 RVA: 0x0069EFCA File Offset: 0x0069D1CA
		public static void AddHour(FlatBufferBuilder builder, int hour)
		{
			builder.AddInt(0, hour, 0);
		}

		// Token: 0x06030C98 RID: 199832 RVA: 0x0069EFD5 File Offset: 0x0069D1D5
		public static void AddMinutes(FlatBufferBuilder builder, int minutes)
		{
			builder.AddInt(1, minutes, 0);
		}

		// Token: 0x06030C99 RID: 199833 RVA: 0x0069EFE0 File Offset: 0x0069D1E0
		public static Offset<IFixedTime> EndIFixedTime(FlatBufferBuilder builder)
		{
			return new Offset<IFixedTime>(builder.EndTable());
		}

		// Token: 0x06030C9A RID: 199834 RVA: 0x0069EFF0 File Offset: 0x0069D1F0
		public IFixedTimeT UnPack()
		{
			IFixedTimeT fixedTimeT = new IFixedTimeT();
			this.UnPackTo(fixedTimeT);
			return fixedTimeT;
		}

		// Token: 0x06030C9B RID: 199835 RVA: 0x0069F00B File Offset: 0x0069D20B
		public void UnPackTo(IFixedTimeT _o)
		{
			_o.Hour = this.Hour;
			_o.Minutes = this.Minutes;
		}

		// Token: 0x06030C9C RID: 199836 RVA: 0x0069F028 File Offset: 0x0069D228
		public static Offset<IFixedTime> Pack(FlatBufferBuilder builder, IFixedTimeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFixedTime>);
			}
			return IFixedTime.CreateIFixedTime(builder, _o.Hour, _o.Minutes);
		}

		// Token: 0x04011D21 RID: 72993
		private Table __p;
	}
}
