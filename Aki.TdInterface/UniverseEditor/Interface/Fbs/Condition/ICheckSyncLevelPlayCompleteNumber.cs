using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200501F RID: 20511
	public struct ICheckSyncLevelPlayCompleteNumber : IFlatbufferObject
	{
		// Token: 0x170092C1 RID: 37569
		// (get) Token: 0x0602005F RID: 131167 RVA: 0x0047174E File Offset: 0x0046F94E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020060 RID: 131168 RVA: 0x0047175B File Offset: 0x0046F95B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020061 RID: 131169 RVA: 0x00471764 File Offset: 0x0046F964
		public static ICheckSyncLevelPlayCompleteNumber GetRootAsICheckSyncLevelPlayCompleteNumber(ByteBuffer _bb)
		{
			return ICheckSyncLevelPlayCompleteNumber.GetRootAsICheckSyncLevelPlayCompleteNumber(_bb, default(ICheckSyncLevelPlayCompleteNumber));
		}

		// Token: 0x06020062 RID: 131170 RVA: 0x00471780 File Offset: 0x0046F980
		public static ICheckSyncLevelPlayCompleteNumber GetRootAsICheckSyncLevelPlayCompleteNumber(ByteBuffer _bb, ICheckSyncLevelPlayCompleteNumber obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020063 RID: 131171 RVA: 0x0047179D File Offset: 0x0046F99D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020064 RID: 131172 RVA: 0x004717AC File Offset: 0x0046F9AC
		public ICheckSyncLevelPlayCompleteNumber __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170092C2 RID: 37570
		// (get) Token: 0x06020065 RID: 131173 RVA: 0x004717BC File Offset: 0x0046F9BC
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

		// Token: 0x170092C3 RID: 37571
		// (get) Token: 0x06020066 RID: 131174 RVA: 0x004717F8 File Offset: 0x0046F9F8
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

		// Token: 0x170092C4 RID: 37572
		// (get) Token: 0x06020067 RID: 131175 RVA: 0x00471834 File Offset: 0x0046FA34
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

		// Token: 0x170092C5 RID: 37573
		// (get) Token: 0x06020068 RID: 131176 RVA: 0x00471870 File Offset: 0x0046FA70
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

		// Token: 0x06020069 RID: 131177 RVA: 0x004718AD File Offset: 0x0046FAAD
		public static Offset<ICheckSyncLevelPlayCompleteNumber> CreateICheckSyncLevelPlayCompleteNumber(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int SyncId = 0, ECompare Compare = ECompare.Eq, int Number = 0)
		{
			builder.StartTable(4);
			ICheckSyncLevelPlayCompleteNumber.AddNumber(builder, Number);
			ICheckSyncLevelPlayCompleteNumber.AddSyncId(builder, SyncId);
			ICheckSyncLevelPlayCompleteNumber.AddCompare(builder, Compare);
			ICheckSyncLevelPlayCompleteNumber.AddType(builder, Type);
			return ICheckSyncLevelPlayCompleteNumber.EndICheckSyncLevelPlayCompleteNumber(builder);
		}

		// Token: 0x0602006A RID: 131178 RVA: 0x004718D9 File Offset: 0x0046FAD9
		public static void StartICheckSyncLevelPlayCompleteNumber(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602006B RID: 131179 RVA: 0x004718E2 File Offset: 0x0046FAE2
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602006C RID: 131180 RVA: 0x004718ED File Offset: 0x0046FAED
		public static void AddSyncId(FlatBufferBuilder builder, int syncId)
		{
			builder.AddInt(1, syncId, 0);
		}

		// Token: 0x0602006D RID: 131181 RVA: 0x004718F8 File Offset: 0x0046FAF8
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x0602006E RID: 131182 RVA: 0x00471903 File Offset: 0x0046FB03
		public static void AddNumber(FlatBufferBuilder builder, int number)
		{
			builder.AddInt(3, number, 0);
		}

		// Token: 0x0602006F RID: 131183 RVA: 0x0047190E File Offset: 0x0046FB0E
		public static Offset<ICheckSyncLevelPlayCompleteNumber> EndICheckSyncLevelPlayCompleteNumber(FlatBufferBuilder builder)
		{
			return new Offset<ICheckSyncLevelPlayCompleteNumber>(builder.EndTable());
		}

		// Token: 0x06020070 RID: 131184 RVA: 0x0047191C File Offset: 0x0046FB1C
		public ICheckSyncLevelPlayCompleteNumberT UnPack()
		{
			ICheckSyncLevelPlayCompleteNumberT checkSyncLevelPlayCompleteNumberT = new ICheckSyncLevelPlayCompleteNumberT();
			this.UnPackTo(checkSyncLevelPlayCompleteNumberT);
			return checkSyncLevelPlayCompleteNumberT;
		}

		// Token: 0x06020071 RID: 131185 RVA: 0x00471937 File Offset: 0x0046FB37
		public void UnPackTo(ICheckSyncLevelPlayCompleteNumberT _o)
		{
			_o.Type = this.Type;
			_o.SyncId = this.SyncId;
			_o.Compare = this.Compare;
			_o.Number = this.Number;
		}

		// Token: 0x06020072 RID: 131186 RVA: 0x0047196C File Offset: 0x0046FB6C
		public static Offset<ICheckSyncLevelPlayCompleteNumber> Pack(FlatBufferBuilder builder, ICheckSyncLevelPlayCompleteNumberT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckSyncLevelPlayCompleteNumber>);
			}
			return ICheckSyncLevelPlayCompleteNumber.CreateICheckSyncLevelPlayCompleteNumber(builder, _o.Type, _o.SyncId, _o.Compare, _o.Number);
		}

		// Token: 0x0400DEDD RID: 57053
		private Table __p;
	}
}
