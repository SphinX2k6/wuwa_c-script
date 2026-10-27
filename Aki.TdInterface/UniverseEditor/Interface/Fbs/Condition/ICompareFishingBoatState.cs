using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BA1 RID: 19361
	public struct ICompareFishingBoatState : IFlatbufferObject
	{
		// Token: 0x17008C84 RID: 35972
		// (get) Token: 0x0601E868 RID: 125032 RVA: 0x00445824 File Offset: 0x00443A24
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E869 RID: 125033 RVA: 0x00445831 File Offset: 0x00443A31
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E86A RID: 125034 RVA: 0x00445838 File Offset: 0x00443A38
		public static ICompareFishingBoatState GetRootAsICompareFishingBoatState(ByteBuffer _bb)
		{
			return ICompareFishingBoatState.GetRootAsICompareFishingBoatState(_bb, default(ICompareFishingBoatState));
		}

		// Token: 0x0601E86B RID: 125035 RVA: 0x00445854 File Offset: 0x00443A54
		public static ICompareFishingBoatState GetRootAsICompareFishingBoatState(ByteBuffer _bb, ICompareFishingBoatState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E86C RID: 125036 RVA: 0x00445871 File Offset: 0x00443A71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E86D RID: 125037 RVA: 0x00445880 File Offset: 0x00443A80
		public ICompareFishingBoatState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008C85 RID: 35973
		// (get) Token: 0x0601E86E RID: 125038 RVA: 0x00445890 File Offset: 0x00443A90
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

		// Token: 0x17008C86 RID: 35974
		// (get) Token: 0x0601E86F RID: 125039 RVA: 0x004458CC File Offset: 0x00443ACC
		public bool IsStop
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008C87 RID: 35975
		// (get) Token: 0x0601E870 RID: 125040 RVA: 0x0044590C File Offset: 0x00443B0C
		public int FishingPort
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

		// Token: 0x17008C88 RID: 35976
		// (get) Token: 0x0601E871 RID: 125041 RVA: 0x00445948 File Offset: 0x00443B48
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E872 RID: 125042 RVA: 0x00445985 File Offset: 0x00443B85
		public static Offset<ICompareFishingBoatState> CreateICompareFishingBoatState(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, bool IsStop = false, int FishingPort = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			ICompareFishingBoatState.AddFishingPort(builder, FishingPort);
			ICompareFishingBoatState.AddNullMask(builder, NullMask);
			ICompareFishingBoatState.AddIsStop(builder, IsStop);
			ICompareFishingBoatState.AddType(builder, Type);
			return ICompareFishingBoatState.EndICompareFishingBoatState(builder);
		}

		// Token: 0x0601E873 RID: 125043 RVA: 0x004459B1 File Offset: 0x00443BB1
		public static void StartICompareFishingBoatState(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601E874 RID: 125044 RVA: 0x004459BA File Offset: 0x00443BBA
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E875 RID: 125045 RVA: 0x004459C5 File Offset: 0x00443BC5
		public static void AddIsStop(FlatBufferBuilder builder, bool isStop)
		{
			builder.AddBool(1, isStop, false);
		}

		// Token: 0x0601E876 RID: 125046 RVA: 0x004459D0 File Offset: 0x00443BD0
		public static void AddFishingPort(FlatBufferBuilder builder, int fishingPort)
		{
			builder.AddInt(2, fishingPort, 0);
		}

		// Token: 0x0601E877 RID: 125047 RVA: 0x004459DB File Offset: 0x00443BDB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0601E878 RID: 125048 RVA: 0x004459E6 File Offset: 0x00443BE6
		public static Offset<ICompareFishingBoatState> EndICompareFishingBoatState(FlatBufferBuilder builder)
		{
			return new Offset<ICompareFishingBoatState>(builder.EndTable());
		}

		// Token: 0x0601E879 RID: 125049 RVA: 0x004459F4 File Offset: 0x00443BF4
		public ICompareFishingBoatStateT UnPack()
		{
			ICompareFishingBoatStateT compareFishingBoatStateT = new ICompareFishingBoatStateT();
			this.UnPackTo(compareFishingBoatStateT);
			return compareFishingBoatStateT;
		}

		// Token: 0x0601E87A RID: 125050 RVA: 0x00445A0F File Offset: 0x00443C0F
		public void UnPackTo(ICompareFishingBoatStateT _o)
		{
			_o.Type = this.Type;
			_o.IsStop = this.IsStop;
			_o.FishingPort = this.FishingPort;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601E87B RID: 125051 RVA: 0x00445A44 File Offset: 0x00443C44
		public static Offset<ICompareFishingBoatState> Pack(FlatBufferBuilder builder, ICompareFishingBoatStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompareFishingBoatState>);
			}
			return ICompareFishingBoatState.CreateICompareFishingBoatState(builder, _o.Type, _o.IsStop, _o.FishingPort, _o.NullMask);
		}

		// Token: 0x0400D47D RID: 54397
		private Table __p;
	}
}
