using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F26 RID: 20262
	public struct ICheckHonamiStoryPlayerCorruptedLevel : IFlatbufferObject
	{
		// Token: 0x170090B6 RID: 37046
		// (get) Token: 0x0601F7D1 RID: 128977 RVA: 0x00462034 File Offset: 0x00460234
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F7D2 RID: 128978 RVA: 0x00462041 File Offset: 0x00460241
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F7D3 RID: 128979 RVA: 0x00462048 File Offset: 0x00460248
		public static ICheckHonamiStoryPlayerCorruptedLevel GetRootAsICheckHonamiStoryPlayerCorruptedLevel(ByteBuffer _bb)
		{
			return ICheckHonamiStoryPlayerCorruptedLevel.GetRootAsICheckHonamiStoryPlayerCorruptedLevel(_bb, default(ICheckHonamiStoryPlayerCorruptedLevel));
		}

		// Token: 0x0601F7D4 RID: 128980 RVA: 0x00462064 File Offset: 0x00460264
		public static ICheckHonamiStoryPlayerCorruptedLevel GetRootAsICheckHonamiStoryPlayerCorruptedLevel(ByteBuffer _bb, ICheckHonamiStoryPlayerCorruptedLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F7D5 RID: 128981 RVA: 0x00462081 File Offset: 0x00460281
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F7D6 RID: 128982 RVA: 0x00462090 File Offset: 0x00460290
		public ICheckHonamiStoryPlayerCorruptedLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170090B7 RID: 37047
		// (get) Token: 0x0601F7D7 RID: 128983 RVA: 0x004620A0 File Offset: 0x004602A0
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

		// Token: 0x170090B8 RID: 37048
		// (get) Token: 0x0601F7D8 RID: 128984 RVA: 0x004620DC File Offset: 0x004602DC
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

		// Token: 0x170090B9 RID: 37049
		// (get) Token: 0x0601F7D9 RID: 128985 RVA: 0x00462118 File Offset: 0x00460318
		public int Level
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

		// Token: 0x0601F7DA RID: 128986 RVA: 0x00462154 File Offset: 0x00460354
		public static Offset<ICheckHonamiStoryPlayerCorruptedLevel> CreateICheckHonamiStoryPlayerCorruptedLevel(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, ECompare Compare = ECompare.Eq, int Level = 0)
		{
			builder.StartTable(3);
			ICheckHonamiStoryPlayerCorruptedLevel.AddLevel(builder, Level);
			ICheckHonamiStoryPlayerCorruptedLevel.AddCompare(builder, Compare);
			ICheckHonamiStoryPlayerCorruptedLevel.AddType(builder, Type);
			return ICheckHonamiStoryPlayerCorruptedLevel.EndICheckHonamiStoryPlayerCorruptedLevel(builder);
		}

		// Token: 0x0601F7DB RID: 128987 RVA: 0x00462178 File Offset: 0x00460378
		public static void StartICheckHonamiStoryPlayerCorruptedLevel(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601F7DC RID: 128988 RVA: 0x00462181 File Offset: 0x00460381
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F7DD RID: 128989 RVA: 0x0046218C File Offset: 0x0046038C
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x0601F7DE RID: 128990 RVA: 0x00462197 File Offset: 0x00460397
		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
			builder.AddInt(2, level, 0);
		}

		// Token: 0x0601F7DF RID: 128991 RVA: 0x004621A2 File Offset: 0x004603A2
		public static Offset<ICheckHonamiStoryPlayerCorruptedLevel> EndICheckHonamiStoryPlayerCorruptedLevel(FlatBufferBuilder builder)
		{
			return new Offset<ICheckHonamiStoryPlayerCorruptedLevel>(builder.EndTable());
		}

		// Token: 0x0601F7E0 RID: 128992 RVA: 0x004621B0 File Offset: 0x004603B0
		public ICheckHonamiStoryPlayerCorruptedLevelT UnPack()
		{
			ICheckHonamiStoryPlayerCorruptedLevelT checkHonamiStoryPlayerCorruptedLevelT = new ICheckHonamiStoryPlayerCorruptedLevelT();
			this.UnPackTo(checkHonamiStoryPlayerCorruptedLevelT);
			return checkHonamiStoryPlayerCorruptedLevelT;
		}

		// Token: 0x0601F7E1 RID: 128993 RVA: 0x004621CB File Offset: 0x004603CB
		public void UnPackTo(ICheckHonamiStoryPlayerCorruptedLevelT _o)
		{
			_o.Type = this.Type;
			_o.Compare = this.Compare;
			_o.Level = this.Level;
		}

		// Token: 0x0601F7E2 RID: 128994 RVA: 0x004621F4 File Offset: 0x004603F4
		public static Offset<ICheckHonamiStoryPlayerCorruptedLevel> Pack(FlatBufferBuilder builder, ICheckHonamiStoryPlayerCorruptedLevelT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckHonamiStoryPlayerCorruptedLevel>);
			}
			return ICheckHonamiStoryPlayerCorruptedLevel.CreateICheckHonamiStoryPlayerCorruptedLevel(builder, _o.Type, _o.Compare, _o.Level);
		}

		// Token: 0x0400DD9B RID: 56731
		private Table __p;
	}
}
