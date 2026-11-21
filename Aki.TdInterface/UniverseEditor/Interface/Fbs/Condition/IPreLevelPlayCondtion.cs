using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005190 RID: 20880
	public struct IPreLevelPlayCondtion : IFlatbufferObject
	{
		// Token: 0x1700958A RID: 38282
		// (get) Token: 0x06020DB7 RID: 134583 RVA: 0x0048C16E File Offset: 0x0048A36E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020DB8 RID: 134584 RVA: 0x0048C17B File Offset: 0x0048A37B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020DB9 RID: 134585 RVA: 0x0048C184 File Offset: 0x0048A384
		public static IPreLevelPlayCondtion GetRootAsIPreLevelPlayCondtion(ByteBuffer _bb)
		{
			return IPreLevelPlayCondtion.GetRootAsIPreLevelPlayCondtion(_bb, default(IPreLevelPlayCondtion));
		}

		// Token: 0x06020DBA RID: 134586 RVA: 0x0048C1A0 File Offset: 0x0048A3A0
		public static IPreLevelPlayCondtion GetRootAsIPreLevelPlayCondtion(ByteBuffer _bb, IPreLevelPlayCondtion obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020DBB RID: 134587 RVA: 0x0048C1BD File Offset: 0x0048A3BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020DBC RID: 134588 RVA: 0x0048C1CC File Offset: 0x0048A3CC
		public IPreLevelPlayCondtion __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700958B RID: 38283
		// (get) Token: 0x06020DBD RID: 134589 RVA: 0x0048C1DC File Offset: 0x0048A3DC
		public EAccessQuestCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAccessQuestCondition.ExploreLevel;
				}
				return (EAccessQuestCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700958C RID: 38284
		// (get) Token: 0x06020DBE RID: 134590 RVA: 0x0048C218 File Offset: 0x0048A418
		public int PreLevelPlay
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

		// Token: 0x06020DBF RID: 134591 RVA: 0x0048C254 File Offset: 0x0048A454
		public static Offset<IPreLevelPlayCondtion> CreateIPreLevelPlayCondtion(FlatBufferBuilder builder, EAccessQuestCondition Type = EAccessQuestCondition.ExploreLevel, int PreLevelPlay = 0)
		{
			builder.StartTable(2);
			IPreLevelPlayCondtion.AddPreLevelPlay(builder, PreLevelPlay);
			IPreLevelPlayCondtion.AddType(builder, Type);
			return IPreLevelPlayCondtion.EndIPreLevelPlayCondtion(builder);
		}

		// Token: 0x06020DC0 RID: 134592 RVA: 0x0048C271 File Offset: 0x0048A471
		public static void StartIPreLevelPlayCondtion(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06020DC1 RID: 134593 RVA: 0x0048C27A File Offset: 0x0048A47A
		public static void AddType(FlatBufferBuilder builder, EAccessQuestCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020DC2 RID: 134594 RVA: 0x0048C285 File Offset: 0x0048A485
		public static void AddPreLevelPlay(FlatBufferBuilder builder, int preLevelPlay)
		{
			builder.AddInt(1, preLevelPlay, 0);
		}

		// Token: 0x06020DC3 RID: 134595 RVA: 0x0048C290 File Offset: 0x0048A490
		public static Offset<IPreLevelPlayCondtion> EndIPreLevelPlayCondtion(FlatBufferBuilder builder)
		{
			return new Offset<IPreLevelPlayCondtion>(builder.EndTable());
		}

		// Token: 0x06020DC4 RID: 134596 RVA: 0x0048C2A0 File Offset: 0x0048A4A0
		public IPreLevelPlayCondtionT UnPack()
		{
			IPreLevelPlayCondtionT preLevelPlayCondtionT = new IPreLevelPlayCondtionT();
			this.UnPackTo(preLevelPlayCondtionT);
			return preLevelPlayCondtionT;
		}

		// Token: 0x06020DC5 RID: 134597 RVA: 0x0048C2BB File Offset: 0x0048A4BB
		public void UnPackTo(IPreLevelPlayCondtionT _o)
		{
			_o.Type = this.Type;
			_o.PreLevelPlay = this.PreLevelPlay;
		}

		// Token: 0x06020DC6 RID: 134598 RVA: 0x0048C2D8 File Offset: 0x0048A4D8
		public static Offset<IPreLevelPlayCondtion> Pack(FlatBufferBuilder builder, IPreLevelPlayCondtionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPreLevelPlayCondtion>);
			}
			return IPreLevelPlayCondtion.CreateIPreLevelPlayCondtion(builder, _o.Type, _o.PreLevelPlay);
		}

		// Token: 0x0400E178 RID: 57720
		private Table __p;
	}
}
