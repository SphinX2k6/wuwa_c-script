using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200508B RID: 20619
	public struct ICompareFishingBoatState : IFlatbufferObject
	{
		// Token: 0x1700939D RID: 37789
		// (get) Token: 0x06020414 RID: 132116 RVA: 0x00478388 File Offset: 0x00476588
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020415 RID: 132117 RVA: 0x00478395 File Offset: 0x00476595
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020416 RID: 132118 RVA: 0x0047839C File Offset: 0x0047659C
		public static ICompareFishingBoatState GetRootAsICompareFishingBoatState(ByteBuffer _bb)
		{
			return ICompareFishingBoatState.GetRootAsICompareFishingBoatState(_bb, default(ICompareFishingBoatState));
		}

		// Token: 0x06020417 RID: 132119 RVA: 0x004783B8 File Offset: 0x004765B8
		public static ICompareFishingBoatState GetRootAsICompareFishingBoatState(ByteBuffer _bb, ICompareFishingBoatState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020418 RID: 132120 RVA: 0x004783D5 File Offset: 0x004765D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020419 RID: 132121 RVA: 0x004783E4 File Offset: 0x004765E4
		public ICompareFishingBoatState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700939E RID: 37790
		// (get) Token: 0x0602041A RID: 132122 RVA: 0x004783F4 File Offset: 0x004765F4
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

		// Token: 0x1700939F RID: 37791
		// (get) Token: 0x0602041B RID: 132123 RVA: 0x00478430 File Offset: 0x00476630
		public bool IsStop
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170093A0 RID: 37792
		// (get) Token: 0x0602041C RID: 132124 RVA: 0x00478470 File Offset: 0x00476670
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

		// Token: 0x170093A1 RID: 37793
		// (get) Token: 0x0602041D RID: 132125 RVA: 0x004784AC File Offset: 0x004766AC
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

		// Token: 0x0602041E RID: 132126 RVA: 0x004784E9 File Offset: 0x004766E9
		public static Offset<ICompareFishingBoatState> CreateICompareFishingBoatState(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, bool IsStop = false, int FishingPort = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			ICompareFishingBoatState.AddFishingPort(builder, FishingPort);
			ICompareFishingBoatState.AddNullMask(builder, NullMask);
			ICompareFishingBoatState.AddIsStop(builder, IsStop);
			ICompareFishingBoatState.AddType(builder, Type);
			return ICompareFishingBoatState.EndICompareFishingBoatState(builder);
		}

		// Token: 0x0602041F RID: 132127 RVA: 0x00478515 File Offset: 0x00476715
		public static void StartICompareFishingBoatState(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06020420 RID: 132128 RVA: 0x0047851E File Offset: 0x0047671E
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020421 RID: 132129 RVA: 0x00478529 File Offset: 0x00476729
		public static void AddIsStop(FlatBufferBuilder builder, bool isStop)
		{
			builder.AddBool(1, isStop, false);
		}

		// Token: 0x06020422 RID: 132130 RVA: 0x00478534 File Offset: 0x00476734
		public static void AddFishingPort(FlatBufferBuilder builder, int fishingPort)
		{
			builder.AddInt(2, fishingPort, 0);
		}

		// Token: 0x06020423 RID: 132131 RVA: 0x0047853F File Offset: 0x0047673F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06020424 RID: 132132 RVA: 0x0047854A File Offset: 0x0047674A
		public static Offset<ICompareFishingBoatState> EndICompareFishingBoatState(FlatBufferBuilder builder)
		{
			return new Offset<ICompareFishingBoatState>(builder.EndTable());
		}

		// Token: 0x06020425 RID: 132133 RVA: 0x00478558 File Offset: 0x00476758
		public ICompareFishingBoatStateT UnPack()
		{
			ICompareFishingBoatStateT compareFishingBoatStateT = new ICompareFishingBoatStateT();
			this.UnPackTo(compareFishingBoatStateT);
			return compareFishingBoatStateT;
		}

		// Token: 0x06020426 RID: 132134 RVA: 0x00478573 File Offset: 0x00476773
		public void UnPackTo(ICompareFishingBoatStateT _o)
		{
			_o.Type = this.Type;
			_o.IsStop = this.IsStop;
			_o.FishingPort = this.FishingPort;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06020427 RID: 132135 RVA: 0x004785A8 File Offset: 0x004767A8
		public static Offset<ICompareFishingBoatState> Pack(FlatBufferBuilder builder, ICompareFishingBoatStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompareFishingBoatState>);
			}
			return ICompareFishingBoatState.CreateICompareFishingBoatState(builder, _o.Type, _o.IsStop, _o.FishingPort, _o.NullMask);
		}

		// Token: 0x0400DF82 RID: 57218
		private Table __p;
	}
}
