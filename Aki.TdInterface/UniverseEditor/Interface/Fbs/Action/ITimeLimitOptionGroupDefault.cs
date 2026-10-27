using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073E2 RID: 29666
	public struct ITimeLimitOptionGroupDefault : IFlatbufferObject
	{
		// Token: 0x1700E157 RID: 57687
		// (get) Token: 0x06035E3D RID: 220733 RVA: 0x00755A86 File Offset: 0x00753C86
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035E3E RID: 220734 RVA: 0x00755A93 File Offset: 0x00753C93
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035E3F RID: 220735 RVA: 0x00755A9C File Offset: 0x00753C9C
		public static ITimeLimitOptionGroupDefault GetRootAsITimeLimitOptionGroupDefault(ByteBuffer _bb)
		{
			return ITimeLimitOptionGroupDefault.GetRootAsITimeLimitOptionGroupDefault(_bb, default(ITimeLimitOptionGroupDefault));
		}

		// Token: 0x06035E40 RID: 220736 RVA: 0x00755AB8 File Offset: 0x00753CB8
		public static ITimeLimitOptionGroupDefault GetRootAsITimeLimitOptionGroupDefault(ByteBuffer _bb, ITimeLimitOptionGroupDefault obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035E41 RID: 220737 RVA: 0x00755AD5 File Offset: 0x00753CD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035E42 RID: 220738 RVA: 0x00755AE4 File Offset: 0x00753CE4
		public ITimeLimitOptionGroupDefault __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E158 RID: 57688
		// (get) Token: 0x06035E43 RID: 220739 RVA: 0x00755AF4 File Offset: 0x00753CF4
		public ETimeLimitOptionGroupStyle Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETimeLimitOptionGroupStyle.Default;
				}
				return (ETimeLimitOptionGroupStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E159 RID: 57689
		// (get) Token: 0x06035E44 RID: 220740 RVA: 0x00755B30 File Offset: 0x00753D30
		public int TimeoutOptionIndex
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

		// Token: 0x1700E15A RID: 57690
		// (get) Token: 0x06035E45 RID: 220741 RVA: 0x00755B6C File Offset: 0x00753D6C
		public float TimeLimit
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035E46 RID: 220742 RVA: 0x00755BAC File Offset: 0x00753DAC
		public static Offset<ITimeLimitOptionGroupDefault> CreateITimeLimitOptionGroupDefault(FlatBufferBuilder builder, ETimeLimitOptionGroupStyle Type = ETimeLimitOptionGroupStyle.Default, int TimeoutOptionIndex = 0, float TimeLimit = 0f)
		{
			builder.StartTable(3);
			ITimeLimitOptionGroupDefault.AddTimeLimit(builder, TimeLimit);
			ITimeLimitOptionGroupDefault.AddTimeoutOptionIndex(builder, TimeoutOptionIndex);
			ITimeLimitOptionGroupDefault.AddType(builder, Type);
			return ITimeLimitOptionGroupDefault.EndITimeLimitOptionGroupDefault(builder);
		}

		// Token: 0x06035E47 RID: 220743 RVA: 0x00755BD0 File Offset: 0x00753DD0
		public static void StartITimeLimitOptionGroupDefault(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06035E48 RID: 220744 RVA: 0x00755BD9 File Offset: 0x00753DD9
		public static void AddType(FlatBufferBuilder builder, ETimeLimitOptionGroupStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035E49 RID: 220745 RVA: 0x00755BE4 File Offset: 0x00753DE4
		public static void AddTimeoutOptionIndex(FlatBufferBuilder builder, int timeoutOptionIndex)
		{
			builder.AddInt(1, timeoutOptionIndex, 0);
		}

		// Token: 0x06035E4A RID: 220746 RVA: 0x00755BEF File Offset: 0x00753DEF
		public static void AddTimeLimit(FlatBufferBuilder builder, float timeLimit)
		{
			builder.AddFloat(2, timeLimit, 0.0);
		}

		// Token: 0x06035E4B RID: 220747 RVA: 0x00755C02 File Offset: 0x00753E02
		public static Offset<ITimeLimitOptionGroupDefault> EndITimeLimitOptionGroupDefault(FlatBufferBuilder builder)
		{
			return new Offset<ITimeLimitOptionGroupDefault>(builder.EndTable());
		}

		// Token: 0x06035E4C RID: 220748 RVA: 0x00755C10 File Offset: 0x00753E10
		public ITimeLimitOptionGroupDefaultT UnPack()
		{
			ITimeLimitOptionGroupDefaultT timeLimitOptionGroupDefaultT = new ITimeLimitOptionGroupDefaultT();
			this.UnPackTo(timeLimitOptionGroupDefaultT);
			return timeLimitOptionGroupDefaultT;
		}

		// Token: 0x06035E4D RID: 220749 RVA: 0x00755C2B File Offset: 0x00753E2B
		public void UnPackTo(ITimeLimitOptionGroupDefaultT _o)
		{
			_o.Type = this.Type;
			_o.TimeoutOptionIndex = this.TimeoutOptionIndex;
			_o.TimeLimit = this.TimeLimit;
		}

		// Token: 0x06035E4E RID: 220750 RVA: 0x00755C54 File Offset: 0x00753E54
		public static Offset<ITimeLimitOptionGroupDefault> Pack(FlatBufferBuilder builder, ITimeLimitOptionGroupDefaultT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimeLimitOptionGroupDefault>);
			}
			return ITimeLimitOptionGroupDefault.CreateITimeLimitOptionGroupDefault(builder, _o.Type, _o.TimeoutOptionIndex, _o.TimeLimit);
		}

		// Token: 0x04012239 RID: 74297
		private Table __p;
	}
}
