using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B80 RID: 19328
	public struct IClock : IFlatbufferObject
	{
		// Token: 0x17008C3E RID: 35902
		// (get) Token: 0x0601E74F RID: 124751 RVA: 0x00443ABA File Offset: 0x00441CBA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E750 RID: 124752 RVA: 0x00443AC7 File Offset: 0x00441CC7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E751 RID: 124753 RVA: 0x00443AD0 File Offset: 0x00441CD0
		public static IClock GetRootAsIClock(ByteBuffer _bb)
		{
			return IClock.GetRootAsIClock(_bb, default(IClock));
		}

		// Token: 0x0601E752 RID: 124754 RVA: 0x00443AEC File Offset: 0x00441CEC
		public static IClock GetRootAsIClock(ByteBuffer _bb, IClock obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E753 RID: 124755 RVA: 0x00443B09 File Offset: 0x00441D09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E754 RID: 124756 RVA: 0x00443B18 File Offset: 0x00441D18
		public IClock __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008C3F RID: 35903
		// (get) Token: 0x0601E755 RID: 124757 RVA: 0x00443B28 File Offset: 0x00441D28
		public EVisibleCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVisibleCondition.Weather;
				}
				return (EVisibleCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008C40 RID: 35904
		// (get) Token: 0x0601E756 RID: 124758 RVA: 0x00443B64 File Offset: 0x00441D64
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

		// Token: 0x17008C41 RID: 35905
		// (get) Token: 0x0601E757 RID: 124759 RVA: 0x00443BA0 File Offset: 0x00441DA0
		public int Start
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

		// Token: 0x17008C42 RID: 35906
		// (get) Token: 0x0601E758 RID: 124760 RVA: 0x00443BDC File Offset: 0x00441DDC
		public int End
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

		// Token: 0x0601E759 RID: 124761 RVA: 0x00443C19 File Offset: 0x00441E19
		public static Offset<IClock> CreateIClock(FlatBufferBuilder builder, EVisibleCondition Type = EVisibleCondition.Weather, ECompare Compare = ECompare.Eq, int Start = 0, int End = 0)
		{
			builder.StartTable(4);
			IClock.AddEnd(builder, End);
			IClock.AddStart(builder, Start);
			IClock.AddCompare(builder, Compare);
			IClock.AddType(builder, Type);
			return IClock.EndIClock(builder);
		}

		// Token: 0x0601E75A RID: 124762 RVA: 0x00443C45 File Offset: 0x00441E45
		public static void StartIClock(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601E75B RID: 124763 RVA: 0x00443C4E File Offset: 0x00441E4E
		public static void AddType(FlatBufferBuilder builder, EVisibleCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E75C RID: 124764 RVA: 0x00443C59 File Offset: 0x00441E59
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x0601E75D RID: 124765 RVA: 0x00443C64 File Offset: 0x00441E64
		public static void AddStart(FlatBufferBuilder builder, int start)
		{
			builder.AddInt(2, start, 0);
		}

		// Token: 0x0601E75E RID: 124766 RVA: 0x00443C6F File Offset: 0x00441E6F
		public static void AddEnd(FlatBufferBuilder builder, int end)
		{
			builder.AddInt(3, end, 0);
		}

		// Token: 0x0601E75F RID: 124767 RVA: 0x00443C7A File Offset: 0x00441E7A
		public static Offset<IClock> EndIClock(FlatBufferBuilder builder)
		{
			return new Offset<IClock>(builder.EndTable());
		}

		// Token: 0x0601E760 RID: 124768 RVA: 0x00443C88 File Offset: 0x00441E88
		public IClockT UnPack()
		{
			IClockT clockT = new IClockT();
			this.UnPackTo(clockT);
			return clockT;
		}

		// Token: 0x0601E761 RID: 124769 RVA: 0x00443CA3 File Offset: 0x00441EA3
		public void UnPackTo(IClockT _o)
		{
			_o.Type = this.Type;
			_o.Compare = this.Compare;
			_o.Start = this.Start;
			_o.End = this.End;
		}

		// Token: 0x0601E762 RID: 124770 RVA: 0x00443CD8 File Offset: 0x00441ED8
		public static Offset<IClock> Pack(FlatBufferBuilder builder, IClockT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClock>);
			}
			return IClock.CreateIClock(builder, _o.Type, _o.Compare, _o.Start, _o.End);
		}

		// Token: 0x0400D44E RID: 54350
		private Table __p;
	}
}
