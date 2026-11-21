using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005187 RID: 20871
	public struct IPreChildQuest : IFlatbufferObject
	{
		// Token: 0x17009579 RID: 38265
		// (get) Token: 0x06020D71 RID: 134513 RVA: 0x0048B9C9 File Offset: 0x00489BC9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020D72 RID: 134514 RVA: 0x0048B9D6 File Offset: 0x00489BD6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020D73 RID: 134515 RVA: 0x0048B9E0 File Offset: 0x00489BE0
		public static IPreChildQuest GetRootAsIPreChildQuest(ByteBuffer _bb)
		{
			return IPreChildQuest.GetRootAsIPreChildQuest(_bb, default(IPreChildQuest));
		}

		// Token: 0x06020D74 RID: 134516 RVA: 0x0048B9FC File Offset: 0x00489BFC
		public static IPreChildQuest GetRootAsIPreChildQuest(ByteBuffer _bb, IPreChildQuest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020D75 RID: 134517 RVA: 0x0048BA19 File Offset: 0x00489C19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020D76 RID: 134518 RVA: 0x0048BA28 File Offset: 0x00489C28
		public IPreChildQuest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700957A RID: 38266
		// (get) Token: 0x06020D77 RID: 134519 RVA: 0x0048BA38 File Offset: 0x00489C38
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

		// Token: 0x1700957B RID: 38267
		// (get) Token: 0x06020D78 RID: 134520 RVA: 0x0048BA74 File Offset: 0x00489C74
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

		// Token: 0x1700957C RID: 38268
		// (get) Token: 0x06020D79 RID: 134521 RVA: 0x0048BAB0 File Offset: 0x00489CB0
		public IChildQuestCondition? PreChildQuest
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IChildQuestCondition?(default(IChildQuestCondition).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06020D7A RID: 134522 RVA: 0x0048BB0D File Offset: 0x00489D0D
		public static Offset<IPreChildQuest> CreateIPreChildQuest(FlatBufferBuilder builder, EVisibleCondition Type = EVisibleCondition.Weather, ECompare Compare = ECompare.Eq, Offset<IChildQuestCondition> PreChildQuestOffset = default(Offset<IChildQuestCondition>))
		{
			builder.StartTable(3);
			IPreChildQuest.AddPreChildQuest(builder, PreChildQuestOffset);
			IPreChildQuest.AddCompare(builder, Compare);
			IPreChildQuest.AddType(builder, Type);
			return IPreChildQuest.EndIPreChildQuest(builder);
		}

		// Token: 0x06020D7B RID: 134523 RVA: 0x0048BB31 File Offset: 0x00489D31
		public static void StartIPreChildQuest(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06020D7C RID: 134524 RVA: 0x0048BB3A File Offset: 0x00489D3A
		public static void AddType(FlatBufferBuilder builder, EVisibleCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020D7D RID: 134525 RVA: 0x0048BB45 File Offset: 0x00489D45
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x06020D7E RID: 134526 RVA: 0x0048BB50 File Offset: 0x00489D50
		public static void AddPreChildQuest(FlatBufferBuilder builder, Offset<IChildQuestCondition> preChildQuestOffset)
		{
			builder.AddOffset(2, preChildQuestOffset.Value, 0);
		}

		// Token: 0x06020D7F RID: 134527 RVA: 0x0048BB60 File Offset: 0x00489D60
		public static Offset<IPreChildQuest> EndIPreChildQuest(FlatBufferBuilder builder)
		{
			return new Offset<IPreChildQuest>(builder.EndTable());
		}

		// Token: 0x06020D80 RID: 134528 RVA: 0x0048BB70 File Offset: 0x00489D70
		public IPreChildQuestT UnPack()
		{
			IPreChildQuestT preChildQuestT = new IPreChildQuestT();
			this.UnPackTo(preChildQuestT);
			return preChildQuestT;
		}

		// Token: 0x06020D81 RID: 134529 RVA: 0x0048BB8C File Offset: 0x00489D8C
		public void UnPackTo(IPreChildQuestT _o)
		{
			_o.Type = this.Type;
			_o.Compare = this.Compare;
			_o.PreChildQuest = ((this.PreChildQuest != null) ? this.PreChildQuest.Value.UnPack() : null);
		}

		// Token: 0x06020D82 RID: 134530 RVA: 0x0048BBE0 File Offset: 0x00489DE0
		public static Offset<IPreChildQuest> Pack(FlatBufferBuilder builder, IPreChildQuestT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPreChildQuest>);
			}
			Offset<IChildQuestCondition> preChildQuestOffset = (_o.PreChildQuest == null) ? default(Offset<IChildQuestCondition>) : IChildQuestCondition.Pack(builder, _o.PreChildQuest);
			return IPreChildQuest.CreateIPreChildQuest(builder, _o.Type, _o.Compare, preChildQuestOffset);
		}

		// Token: 0x0400E16E RID: 57710
		private Table __p;
	}
}
