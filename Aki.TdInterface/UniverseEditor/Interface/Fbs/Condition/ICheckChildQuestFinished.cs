using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200499A RID: 18842
	public struct ICheckChildQuestFinished : IFlatbufferObject
	{
		// Token: 0x17008822 RID: 34850
		// (get) Token: 0x0601D632 RID: 120370 RVA: 0x00424618 File Offset: 0x00422818
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D633 RID: 120371 RVA: 0x00424625 File Offset: 0x00422825
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D634 RID: 120372 RVA: 0x0042462C File Offset: 0x0042282C
		public static ICheckChildQuestFinished GetRootAsICheckChildQuestFinished(ByteBuffer _bb)
		{
			return ICheckChildQuestFinished.GetRootAsICheckChildQuestFinished(_bb, default(ICheckChildQuestFinished));
		}

		// Token: 0x0601D635 RID: 120373 RVA: 0x00424648 File Offset: 0x00422848
		public static ICheckChildQuestFinished GetRootAsICheckChildQuestFinished(ByteBuffer _bb, ICheckChildQuestFinished obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D636 RID: 120374 RVA: 0x00424665 File Offset: 0x00422865
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D637 RID: 120375 RVA: 0x00424674 File Offset: 0x00422874
		public ICheckChildQuestFinished __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008823 RID: 34851
		// (get) Token: 0x0601D638 RID: 120376 RVA: 0x00424684 File Offset: 0x00422884
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

		// Token: 0x17008824 RID: 34852
		// (get) Token: 0x0601D639 RID: 120377 RVA: 0x004246C0 File Offset: 0x004228C0
		public int QuestId
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

		// Token: 0x17008825 RID: 34853
		// (get) Token: 0x0601D63A RID: 120378 RVA: 0x004246FC File Offset: 0x004228FC
		public int ChildQuestId
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

		// Token: 0x17008826 RID: 34854
		// (get) Token: 0x0601D63B RID: 120379 RVA: 0x00424738 File Offset: 0x00422938
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008827 RID: 34855
		// (get) Token: 0x0601D63C RID: 120380 RVA: 0x00424778 File Offset: 0x00422978
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601D63D RID: 120381 RVA: 0x004247B5 File Offset: 0x004229B5
		public static Offset<ICheckChildQuestFinished> CreateICheckChildQuestFinished(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int QuestId = 0, int ChildQuestId = 0, ECompare Compare = ECompare.Eq, byte NullMask = 0)
		{
			builder.StartTable(5);
			ICheckChildQuestFinished.AddChildQuestId(builder, ChildQuestId);
			ICheckChildQuestFinished.AddQuestId(builder, QuestId);
			ICheckChildQuestFinished.AddNullMask(builder, NullMask);
			ICheckChildQuestFinished.AddCompare(builder, Compare);
			ICheckChildQuestFinished.AddType(builder, Type);
			return ICheckChildQuestFinished.EndICheckChildQuestFinished(builder);
		}

		// Token: 0x0601D63E RID: 120382 RVA: 0x004247E9 File Offset: 0x004229E9
		public static void StartICheckChildQuestFinished(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601D63F RID: 120383 RVA: 0x004247F2 File Offset: 0x004229F2
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D640 RID: 120384 RVA: 0x004247FD File Offset: 0x004229FD
		public static void AddQuestId(FlatBufferBuilder builder, int questId)
		{
			builder.AddInt(1, questId, 0);
		}

		// Token: 0x0601D641 RID: 120385 RVA: 0x00424808 File Offset: 0x00422A08
		public static void AddChildQuestId(FlatBufferBuilder builder, int childQuestId)
		{
			builder.AddInt(2, childQuestId, 0);
		}

		// Token: 0x0601D642 RID: 120386 RVA: 0x00424813 File Offset: 0x00422A13
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(3, (byte)compare, 0);
		}

		// Token: 0x0601D643 RID: 120387 RVA: 0x0042481E File Offset: 0x00422A1E
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0601D644 RID: 120388 RVA: 0x00424829 File Offset: 0x00422A29
		public static Offset<ICheckChildQuestFinished> EndICheckChildQuestFinished(FlatBufferBuilder builder)
		{
			return new Offset<ICheckChildQuestFinished>(builder.EndTable());
		}

		// Token: 0x0601D645 RID: 120389 RVA: 0x00424838 File Offset: 0x00422A38
		public ICheckChildQuestFinishedT UnPack()
		{
			ICheckChildQuestFinishedT checkChildQuestFinishedT = new ICheckChildQuestFinishedT();
			this.UnPackTo(checkChildQuestFinishedT);
			return checkChildQuestFinishedT;
		}

		// Token: 0x0601D646 RID: 120390 RVA: 0x00424853 File Offset: 0x00422A53
		public void UnPackTo(ICheckChildQuestFinishedT _o)
		{
			_o.Type = this.Type;
			_o.QuestId = this.QuestId;
			_o.ChildQuestId = this.ChildQuestId;
			_o.Compare = this.Compare;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601D647 RID: 120391 RVA: 0x00424894 File Offset: 0x00422A94
		public static Offset<ICheckChildQuestFinished> Pack(FlatBufferBuilder builder, ICheckChildQuestFinishedT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckChildQuestFinished>);
			}
			return ICheckChildQuestFinished.CreateICheckChildQuestFinished(builder, _o.Type, _o.QuestId, _o.ChildQuestId, _o.Compare, _o.NullMask);
		}

		// Token: 0x0400D1AE RID: 53678
		private Table __p;
	}
}
