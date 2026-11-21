using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005193 RID: 20883
	public struct IPreQuest : IFlatbufferObject
	{
		// Token: 0x1700958F RID: 38287
		// (get) Token: 0x06020DCD RID: 134605 RVA: 0x0048C36E File Offset: 0x0048A56E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020DCE RID: 134606 RVA: 0x0048C37B File Offset: 0x0048A57B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020DCF RID: 134607 RVA: 0x0048C384 File Offset: 0x0048A584
		public static IPreQuest GetRootAsIPreQuest(ByteBuffer _bb)
		{
			return IPreQuest.GetRootAsIPreQuest(_bb, default(IPreQuest));
		}

		// Token: 0x06020DD0 RID: 134608 RVA: 0x0048C3A0 File Offset: 0x0048A5A0
		public static IPreQuest GetRootAsIPreQuest(ByteBuffer _bb, IPreQuest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020DD1 RID: 134609 RVA: 0x0048C3BD File Offset: 0x0048A5BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020DD2 RID: 134610 RVA: 0x0048C3CC File Offset: 0x0048A5CC
		public IPreQuest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009590 RID: 38288
		// (get) Token: 0x06020DD3 RID: 134611 RVA: 0x0048C3DC File Offset: 0x0048A5DC
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

		// Token: 0x17009591 RID: 38289
		// (get) Token: 0x06020DD4 RID: 134612 RVA: 0x0048C418 File Offset: 0x0048A618
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

		// Token: 0x17009592 RID: 38290
		// (get) Token: 0x06020DD5 RID: 134613 RVA: 0x0048C454 File Offset: 0x0048A654
		public int PreQuestId
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

		// Token: 0x06020DD6 RID: 134614 RVA: 0x0048C490 File Offset: 0x0048A690
		public static Offset<IPreQuest> CreateIPreQuest(FlatBufferBuilder builder, EVisibleCondition Type = EVisibleCondition.Weather, ECompare Compare = ECompare.Eq, int PreQuestId = 0)
		{
			builder.StartTable(3);
			IPreQuest.AddPreQuestId(builder, PreQuestId);
			IPreQuest.AddCompare(builder, Compare);
			IPreQuest.AddType(builder, Type);
			return IPreQuest.EndIPreQuest(builder);
		}

		// Token: 0x06020DD7 RID: 134615 RVA: 0x0048C4B4 File Offset: 0x0048A6B4
		public static void StartIPreQuest(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06020DD8 RID: 134616 RVA: 0x0048C4BD File Offset: 0x0048A6BD
		public static void AddType(FlatBufferBuilder builder, EVisibleCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020DD9 RID: 134617 RVA: 0x0048C4C8 File Offset: 0x0048A6C8
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x06020DDA RID: 134618 RVA: 0x0048C4D3 File Offset: 0x0048A6D3
		public static void AddPreQuestId(FlatBufferBuilder builder, int preQuestId)
		{
			builder.AddInt(2, preQuestId, 0);
		}

		// Token: 0x06020DDB RID: 134619 RVA: 0x0048C4DE File Offset: 0x0048A6DE
		public static Offset<IPreQuest> EndIPreQuest(FlatBufferBuilder builder)
		{
			return new Offset<IPreQuest>(builder.EndTable());
		}

		// Token: 0x06020DDC RID: 134620 RVA: 0x0048C4EC File Offset: 0x0048A6EC
		public IPreQuestT UnPack()
		{
			IPreQuestT preQuestT = new IPreQuestT();
			this.UnPackTo(preQuestT);
			return preQuestT;
		}

		// Token: 0x06020DDD RID: 134621 RVA: 0x0048C507 File Offset: 0x0048A707
		public void UnPackTo(IPreQuestT _o)
		{
			_o.Type = this.Type;
			_o.Compare = this.Compare;
			_o.PreQuestId = this.PreQuestId;
		}

		// Token: 0x06020DDE RID: 134622 RVA: 0x0048C530 File Offset: 0x0048A730
		public static Offset<IPreQuest> Pack(FlatBufferBuilder builder, IPreQuestT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPreQuest>);
			}
			return IPreQuest.CreateIPreQuest(builder, _o.Type, _o.Compare, _o.PreQuestId);
		}

		// Token: 0x0400E17B RID: 57723
		private Table __p;
	}
}
