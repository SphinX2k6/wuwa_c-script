using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B38 RID: 19256
	public struct ICheckSyncLevelPlayCompleteNumber : IFlatbufferObject
	{
		// Token: 0x17008BB1 RID: 35761
		// (get) Token: 0x0601E4D4 RID: 124116 RVA: 0x0043EFA2 File Offset: 0x0043D1A2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E4D5 RID: 124117 RVA: 0x0043EFAF File Offset: 0x0043D1AF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E4D6 RID: 124118 RVA: 0x0043EFB8 File Offset: 0x0043D1B8
		public static ICheckSyncLevelPlayCompleteNumber GetRootAsICheckSyncLevelPlayCompleteNumber(ByteBuffer _bb)
		{
			return ICheckSyncLevelPlayCompleteNumber.GetRootAsICheckSyncLevelPlayCompleteNumber(_bb, default(ICheckSyncLevelPlayCompleteNumber));
		}

		// Token: 0x0601E4D7 RID: 124119 RVA: 0x0043EFD4 File Offset: 0x0043D1D4
		public static ICheckSyncLevelPlayCompleteNumber GetRootAsICheckSyncLevelPlayCompleteNumber(ByteBuffer _bb, ICheckSyncLevelPlayCompleteNumber obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E4D8 RID: 124120 RVA: 0x0043EFF1 File Offset: 0x0043D1F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E4D9 RID: 124121 RVA: 0x0043F000 File Offset: 0x0043D200
		public ICheckSyncLevelPlayCompleteNumber __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008BB2 RID: 35762
		// (get) Token: 0x0601E4DA RID: 124122 RVA: 0x0043F010 File Offset: 0x0043D210
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

		// Token: 0x17008BB3 RID: 35763
		// (get) Token: 0x0601E4DB RID: 124123 RVA: 0x0043F04C File Offset: 0x0043D24C
		public int SyncId
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

		// Token: 0x17008BB4 RID: 35764
		// (get) Token: 0x0601E4DC RID: 124124 RVA: 0x0043F088 File Offset: 0x0043D288
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008BB5 RID: 35765
		// (get) Token: 0x0601E4DD RID: 124125 RVA: 0x0043F0C4 File Offset: 0x0043D2C4
		public int Number
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

		// Token: 0x0601E4DE RID: 124126 RVA: 0x0043F101 File Offset: 0x0043D301
		public static Offset<ICheckSyncLevelPlayCompleteNumber> CreateICheckSyncLevelPlayCompleteNumber(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int SyncId = 0, ECompare Compare = ECompare.Eq, int Number = 0)
		{
			builder.StartTable(4);
			ICheckSyncLevelPlayCompleteNumber.AddNumber(builder, Number);
			ICheckSyncLevelPlayCompleteNumber.AddSyncId(builder, SyncId);
			ICheckSyncLevelPlayCompleteNumber.AddCompare(builder, Compare);
			ICheckSyncLevelPlayCompleteNumber.AddType(builder, Type);
			return ICheckSyncLevelPlayCompleteNumber.EndICheckSyncLevelPlayCompleteNumber(builder);
		}

		// Token: 0x0601E4DF RID: 124127 RVA: 0x0043F12D File Offset: 0x0043D32D
		public static void StartICheckSyncLevelPlayCompleteNumber(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601E4E0 RID: 124128 RVA: 0x0043F136 File Offset: 0x0043D336
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E4E1 RID: 124129 RVA: 0x0043F141 File Offset: 0x0043D341
		public static void AddSyncId(FlatBufferBuilder builder, int syncId)
		{
			builder.AddInt(1, syncId, 0);
		}

		// Token: 0x0601E4E2 RID: 124130 RVA: 0x0043F14C File Offset: 0x0043D34C
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x0601E4E3 RID: 124131 RVA: 0x0043F157 File Offset: 0x0043D357
		public static void AddNumber(FlatBufferBuilder builder, int number)
		{
			builder.AddInt(3, number, 0);
		}

		// Token: 0x0601E4E4 RID: 124132 RVA: 0x0043F162 File Offset: 0x0043D362
		public static Offset<ICheckSyncLevelPlayCompleteNumber> EndICheckSyncLevelPlayCompleteNumber(FlatBufferBuilder builder)
		{
			return new Offset<ICheckSyncLevelPlayCompleteNumber>(builder.EndTable());
		}

		// Token: 0x0601E4E5 RID: 124133 RVA: 0x0043F170 File Offset: 0x0043D370
		public ICheckSyncLevelPlayCompleteNumberT UnPack()
		{
			ICheckSyncLevelPlayCompleteNumberT checkSyncLevelPlayCompleteNumberT = new ICheckSyncLevelPlayCompleteNumberT();
			this.UnPackTo(checkSyncLevelPlayCompleteNumberT);
			return checkSyncLevelPlayCompleteNumberT;
		}

		// Token: 0x0601E4E6 RID: 124134 RVA: 0x0043F18B File Offset: 0x0043D38B
		public void UnPackTo(ICheckSyncLevelPlayCompleteNumberT _o)
		{
			_o.Type = this.Type;
			_o.SyncId = this.SyncId;
			_o.Compare = this.Compare;
			_o.Number = this.Number;
		}

		// Token: 0x0601E4E7 RID: 124135 RVA: 0x0043F1C0 File Offset: 0x0043D3C0
		public static Offset<ICheckSyncLevelPlayCompleteNumber> Pack(FlatBufferBuilder builder, ICheckSyncLevelPlayCompleteNumberT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckSyncLevelPlayCompleteNumber>);
			}
			return ICheckSyncLevelPlayCompleteNumber.CreateICheckSyncLevelPlayCompleteNumber(builder, _o.Type, _o.SyncId, _o.Compare, _o.Number);
		}

		// Token: 0x0400D3DE RID: 54238
		private Table __p;
	}
}
