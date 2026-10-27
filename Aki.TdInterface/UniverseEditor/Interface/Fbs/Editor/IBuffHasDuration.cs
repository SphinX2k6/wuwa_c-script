using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004835 RID: 18485
	public struct IBuffHasDuration : IFlatbufferObject
	{
		// Token: 0x170084A5 RID: 33957
		// (get) Token: 0x0601C927 RID: 117031 RVA: 0x0040A3A9 File Offset: 0x004085A9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C928 RID: 117032 RVA: 0x0040A3B6 File Offset: 0x004085B6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C929 RID: 117033 RVA: 0x0040A3C0 File Offset: 0x004085C0
		public static IBuffHasDuration GetRootAsIBuffHasDuration(ByteBuffer _bb)
		{
			return IBuffHasDuration.GetRootAsIBuffHasDuration(_bb, default(IBuffHasDuration));
		}

		// Token: 0x0601C92A RID: 117034 RVA: 0x0040A3DC File Offset: 0x004085DC
		public static IBuffHasDuration GetRootAsIBuffHasDuration(ByteBuffer _bb, IBuffHasDuration obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C92B RID: 117035 RVA: 0x0040A3F9 File Offset: 0x004085F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C92C RID: 117036 RVA: 0x0040A408 File Offset: 0x00408608
		public IBuffHasDuration __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170084A6 RID: 33958
		// (get) Token: 0x0601C92D RID: 117037 RVA: 0x0040A418 File Offset: 0x00408618
		public EBuffDurationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBuffDurationType.Instant;
				}
				return (EBuffDurationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170084A7 RID: 33959
		// (get) Token: 0x0601C92E RID: 117038 RVA: 0x0040A454 File Offset: 0x00408654
		public int Duration
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

		// Token: 0x0601C92F RID: 117039 RVA: 0x0040A490 File Offset: 0x00408690
		public static Offset<IBuffHasDuration> CreateIBuffHasDuration(FlatBufferBuilder builder, EBuffDurationType Type = EBuffDurationType.Instant, int Duration = 0)
		{
			builder.StartTable(2);
			IBuffHasDuration.AddDuration(builder, Duration);
			IBuffHasDuration.AddType(builder, Type);
			return IBuffHasDuration.EndIBuffHasDuration(builder);
		}

		// Token: 0x0601C930 RID: 117040 RVA: 0x0040A4AD File Offset: 0x004086AD
		public static void StartIBuffHasDuration(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601C931 RID: 117041 RVA: 0x0040A4B6 File Offset: 0x004086B6
		public static void AddType(FlatBufferBuilder builder, EBuffDurationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C932 RID: 117042 RVA: 0x0040A4C1 File Offset: 0x004086C1
		public static void AddDuration(FlatBufferBuilder builder, int duration)
		{
			builder.AddInt(1, duration, 0);
		}

		// Token: 0x0601C933 RID: 117043 RVA: 0x0040A4CC File Offset: 0x004086CC
		public static Offset<IBuffHasDuration> EndIBuffHasDuration(FlatBufferBuilder builder)
		{
			return new Offset<IBuffHasDuration>(builder.EndTable());
		}

		// Token: 0x0601C934 RID: 117044 RVA: 0x0040A4DC File Offset: 0x004086DC
		public IBuffHasDurationT UnPack()
		{
			IBuffHasDurationT buffHasDurationT = new IBuffHasDurationT();
			this.UnPackTo(buffHasDurationT);
			return buffHasDurationT;
		}

		// Token: 0x0601C935 RID: 117045 RVA: 0x0040A4F7 File Offset: 0x004086F7
		public void UnPackTo(IBuffHasDurationT _o)
		{
			_o.Type = this.Type;
			_o.Duration = this.Duration;
		}

		// Token: 0x0601C936 RID: 117046 RVA: 0x0040A514 File Offset: 0x00408714
		public static Offset<IBuffHasDuration> Pack(FlatBufferBuilder builder, IBuffHasDurationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBuffHasDuration>);
			}
			return IBuffHasDuration.CreateIBuffHasDuration(builder, _o.Type, _o.Duration);
		}

		// Token: 0x0400CD60 RID: 52576
		private Table __p;
	}
}
