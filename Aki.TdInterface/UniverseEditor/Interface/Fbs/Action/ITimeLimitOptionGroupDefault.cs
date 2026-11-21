using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BCC RID: 31692
	public struct ITimeLimitOptionGroupDefault : IFlatbufferObject
	{
		// Token: 0x1700ED6C RID: 60780
		// (get) Token: 0x060391F0 RID: 233968 RVA: 0x007B81FA File Offset: 0x007B63FA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060391F1 RID: 233969 RVA: 0x007B8207 File Offset: 0x007B6407
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060391F2 RID: 233970 RVA: 0x007B8210 File Offset: 0x007B6410
		public static ITimeLimitOptionGroupDefault GetRootAsITimeLimitOptionGroupDefault(ByteBuffer _bb)
		{
			return ITimeLimitOptionGroupDefault.GetRootAsITimeLimitOptionGroupDefault(_bb, default(ITimeLimitOptionGroupDefault));
		}

		// Token: 0x060391F3 RID: 233971 RVA: 0x007B822C File Offset: 0x007B642C
		public static ITimeLimitOptionGroupDefault GetRootAsITimeLimitOptionGroupDefault(ByteBuffer _bb, ITimeLimitOptionGroupDefault obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060391F4 RID: 233972 RVA: 0x007B8249 File Offset: 0x007B6449
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060391F5 RID: 233973 RVA: 0x007B8258 File Offset: 0x007B6458
		public ITimeLimitOptionGroupDefault __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ED6D RID: 60781
		// (get) Token: 0x060391F6 RID: 233974 RVA: 0x007B8268 File Offset: 0x007B6468
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

		// Token: 0x1700ED6E RID: 60782
		// (get) Token: 0x060391F7 RID: 233975 RVA: 0x007B82A4 File Offset: 0x007B64A4
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

		// Token: 0x1700ED6F RID: 60783
		// (get) Token: 0x060391F8 RID: 233976 RVA: 0x007B82E0 File Offset: 0x007B64E0
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

		// Token: 0x060391F9 RID: 233977 RVA: 0x007B8320 File Offset: 0x007B6520
		public static Offset<ITimeLimitOptionGroupDefault> CreateITimeLimitOptionGroupDefault(FlatBufferBuilder builder, ETimeLimitOptionGroupStyle Type = ETimeLimitOptionGroupStyle.Default, int TimeoutOptionIndex = 0, float TimeLimit = 0f)
		{
			builder.StartTable(3);
			ITimeLimitOptionGroupDefault.AddTimeLimit(builder, TimeLimit);
			ITimeLimitOptionGroupDefault.AddTimeoutOptionIndex(builder, TimeoutOptionIndex);
			ITimeLimitOptionGroupDefault.AddType(builder, Type);
			return ITimeLimitOptionGroupDefault.EndITimeLimitOptionGroupDefault(builder);
		}

		// Token: 0x060391FA RID: 233978 RVA: 0x007B8344 File Offset: 0x007B6544
		public static void StartITimeLimitOptionGroupDefault(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060391FB RID: 233979 RVA: 0x007B834D File Offset: 0x007B654D
		public static void AddType(FlatBufferBuilder builder, ETimeLimitOptionGroupStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060391FC RID: 233980 RVA: 0x007B8358 File Offset: 0x007B6558
		public static void AddTimeoutOptionIndex(FlatBufferBuilder builder, int timeoutOptionIndex)
		{
			builder.AddInt(1, timeoutOptionIndex, 0);
		}

		// Token: 0x060391FD RID: 233981 RVA: 0x007B8363 File Offset: 0x007B6563
		public static void AddTimeLimit(FlatBufferBuilder builder, float timeLimit)
		{
			builder.AddFloat(2, timeLimit, 0.0);
		}

		// Token: 0x060391FE RID: 233982 RVA: 0x007B8376 File Offset: 0x007B6576
		public static Offset<ITimeLimitOptionGroupDefault> EndITimeLimitOptionGroupDefault(FlatBufferBuilder builder)
		{
			return new Offset<ITimeLimitOptionGroupDefault>(builder.EndTable());
		}

		// Token: 0x060391FF RID: 233983 RVA: 0x007B8384 File Offset: 0x007B6584
		public ITimeLimitOptionGroupDefaultT UnPack()
		{
			ITimeLimitOptionGroupDefaultT timeLimitOptionGroupDefaultT = new ITimeLimitOptionGroupDefaultT();
			this.UnPackTo(timeLimitOptionGroupDefaultT);
			return timeLimitOptionGroupDefaultT;
		}

		// Token: 0x06039200 RID: 233984 RVA: 0x007B839F File Offset: 0x007B659F
		public void UnPackTo(ITimeLimitOptionGroupDefaultT _o)
		{
			_o.Type = this.Type;
			_o.TimeoutOptionIndex = this.TimeoutOptionIndex;
			_o.TimeLimit = this.TimeLimit;
		}

		// Token: 0x06039201 RID: 233985 RVA: 0x007B83C8 File Offset: 0x007B65C8
		public static Offset<ITimeLimitOptionGroupDefault> Pack(FlatBufferBuilder builder, ITimeLimitOptionGroupDefaultT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimeLimitOptionGroupDefault>);
			}
			return ITimeLimitOptionGroupDefault.CreateITimeLimitOptionGroupDefault(builder, _o.Type, _o.TimeoutOptionIndex, _o.TimeLimit);
		}

		// Token: 0x04013255 RID: 78421
		private Table __p;
	}
}
