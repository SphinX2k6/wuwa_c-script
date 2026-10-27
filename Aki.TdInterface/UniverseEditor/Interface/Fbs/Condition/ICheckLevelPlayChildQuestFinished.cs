using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004ABD RID: 19133
	public struct ICheckLevelPlayChildQuestFinished : IFlatbufferObject
	{
		// Token: 0x17008AAE RID: 35502
		// (get) Token: 0x0601E08A RID: 123018 RVA: 0x0043707C File Offset: 0x0043527C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E08B RID: 123019 RVA: 0x00437089 File Offset: 0x00435289
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E08C RID: 123020 RVA: 0x00437090 File Offset: 0x00435290
		public static ICheckLevelPlayChildQuestFinished GetRootAsICheckLevelPlayChildQuestFinished(ByteBuffer _bb)
		{
			return ICheckLevelPlayChildQuestFinished.GetRootAsICheckLevelPlayChildQuestFinished(_bb, default(ICheckLevelPlayChildQuestFinished));
		}

		// Token: 0x0601E08D RID: 123021 RVA: 0x004370AC File Offset: 0x004352AC
		public static ICheckLevelPlayChildQuestFinished GetRootAsICheckLevelPlayChildQuestFinished(ByteBuffer _bb, ICheckLevelPlayChildQuestFinished obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E08E RID: 123022 RVA: 0x004370C9 File Offset: 0x004352C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E08F RID: 123023 RVA: 0x004370D8 File Offset: 0x004352D8
		public ICheckLevelPlayChildQuestFinished __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008AAF RID: 35503
		// (get) Token: 0x0601E090 RID: 123024 RVA: 0x004370E8 File Offset: 0x004352E8
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

		// Token: 0x17008AB0 RID: 35504
		// (get) Token: 0x0601E091 RID: 123025 RVA: 0x00437124 File Offset: 0x00435324
		public int ChildQuestId
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

		// Token: 0x17008AB1 RID: 35505
		// (get) Token: 0x0601E092 RID: 123026 RVA: 0x00437160 File Offset: 0x00435360
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

		// Token: 0x0601E093 RID: 123027 RVA: 0x0043719C File Offset: 0x0043539C
		public static Offset<ICheckLevelPlayChildQuestFinished> CreateICheckLevelPlayChildQuestFinished(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int ChildQuestId = 0, ECompare Compare = ECompare.Eq)
		{
			builder.StartTable(3);
			ICheckLevelPlayChildQuestFinished.AddChildQuestId(builder, ChildQuestId);
			ICheckLevelPlayChildQuestFinished.AddCompare(builder, Compare);
			ICheckLevelPlayChildQuestFinished.AddType(builder, Type);
			return ICheckLevelPlayChildQuestFinished.EndICheckLevelPlayChildQuestFinished(builder);
		}

		// Token: 0x0601E094 RID: 123028 RVA: 0x004371C0 File Offset: 0x004353C0
		public static void StartICheckLevelPlayChildQuestFinished(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601E095 RID: 123029 RVA: 0x004371C9 File Offset: 0x004353C9
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E096 RID: 123030 RVA: 0x004371D4 File Offset: 0x004353D4
		public static void AddChildQuestId(FlatBufferBuilder builder, int childQuestId)
		{
			builder.AddInt(1, childQuestId, 0);
		}

		// Token: 0x0601E097 RID: 123031 RVA: 0x004371DF File Offset: 0x004353DF
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x0601E098 RID: 123032 RVA: 0x004371EA File Offset: 0x004353EA
		public static Offset<ICheckLevelPlayChildQuestFinished> EndICheckLevelPlayChildQuestFinished(FlatBufferBuilder builder)
		{
			return new Offset<ICheckLevelPlayChildQuestFinished>(builder.EndTable());
		}

		// Token: 0x0601E099 RID: 123033 RVA: 0x004371F8 File Offset: 0x004353F8
		public ICheckLevelPlayChildQuestFinishedT UnPack()
		{
			ICheckLevelPlayChildQuestFinishedT checkLevelPlayChildQuestFinishedT = new ICheckLevelPlayChildQuestFinishedT();
			this.UnPackTo(checkLevelPlayChildQuestFinishedT);
			return checkLevelPlayChildQuestFinishedT;
		}

		// Token: 0x0601E09A RID: 123034 RVA: 0x00437213 File Offset: 0x00435413
		public void UnPackTo(ICheckLevelPlayChildQuestFinishedT _o)
		{
			_o.Type = this.Type;
			_o.ChildQuestId = this.ChildQuestId;
			_o.Compare = this.Compare;
		}

		// Token: 0x0601E09B RID: 123035 RVA: 0x0043723C File Offset: 0x0043543C
		public static Offset<ICheckLevelPlayChildQuestFinished> Pack(FlatBufferBuilder builder, ICheckLevelPlayChildQuestFinishedT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckLevelPlayChildQuestFinished>);
			}
			return ICheckLevelPlayChildQuestFinished.CreateICheckLevelPlayChildQuestFinished(builder, _o.Type, _o.ChildQuestId, _o.Compare);
		}

		// Token: 0x0400D33F RID: 54079
		private Table __p;
	}
}
