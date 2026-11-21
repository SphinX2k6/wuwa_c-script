using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005094 RID: 20628
	public struct ICompareGameDifficulty : IFlatbufferObject
	{
		// Token: 0x170093B6 RID: 37814
		// (get) Token: 0x0602046A RID: 132202 RVA: 0x00478C4C File Offset: 0x00476E4C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602046B RID: 132203 RVA: 0x00478C59 File Offset: 0x00476E59
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602046C RID: 132204 RVA: 0x00478C60 File Offset: 0x00476E60
		public static ICompareGameDifficulty GetRootAsICompareGameDifficulty(ByteBuffer _bb)
		{
			return ICompareGameDifficulty.GetRootAsICompareGameDifficulty(_bb, default(ICompareGameDifficulty));
		}

		// Token: 0x0602046D RID: 132205 RVA: 0x00478C7C File Offset: 0x00476E7C
		public static ICompareGameDifficulty GetRootAsICompareGameDifficulty(ByteBuffer _bb, ICompareGameDifficulty obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602046E RID: 132206 RVA: 0x00478C99 File Offset: 0x00476E99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602046F RID: 132207 RVA: 0x00478CA8 File Offset: 0x00476EA8
		public ICompareGameDifficulty __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170093B7 RID: 37815
		// (get) Token: 0x06020470 RID: 132208 RVA: 0x00478CB8 File Offset: 0x00476EB8
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

		// Token: 0x170093B8 RID: 37816
		// (get) Token: 0x06020471 RID: 132209 RVA: 0x00478CF4 File Offset: 0x00476EF4
		public EVarCompare CompareType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EVarCompare.Eq;
				}
				return (EVarCompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170093B9 RID: 37817
		// (get) Token: 0x06020472 RID: 132210 RVA: 0x00478D30 File Offset: 0x00476F30
		public EGameDifficultyType Difficulty
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return EGameDifficultyType.None;
				}
				return (EGameDifficultyType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020473 RID: 132211 RVA: 0x00478D6C File Offset: 0x00476F6C
		public static Offset<ICompareGameDifficulty> CreateICompareGameDifficulty(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, EVarCompare CompareType = EVarCompare.Eq, EGameDifficultyType Difficulty = EGameDifficultyType.None)
		{
			builder.StartTable(3);
			ICompareGameDifficulty.AddDifficulty(builder, Difficulty);
			ICompareGameDifficulty.AddCompareType(builder, CompareType);
			ICompareGameDifficulty.AddType(builder, Type);
			return ICompareGameDifficulty.EndICompareGameDifficulty(builder);
		}

		// Token: 0x06020474 RID: 132212 RVA: 0x00478D90 File Offset: 0x00476F90
		public static void StartICompareGameDifficulty(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06020475 RID: 132213 RVA: 0x00478D99 File Offset: 0x00476F99
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020476 RID: 132214 RVA: 0x00478DA4 File Offset: 0x00476FA4
		public static void AddCompareType(FlatBufferBuilder builder, EVarCompare compareType)
		{
			builder.AddByte(1, (byte)compareType, 0);
		}

		// Token: 0x06020477 RID: 132215 RVA: 0x00478DAF File Offset: 0x00476FAF
		public static void AddDifficulty(FlatBufferBuilder builder, EGameDifficultyType difficulty)
		{
			builder.AddByte(2, (byte)difficulty, 0);
		}

		// Token: 0x06020478 RID: 132216 RVA: 0x00478DBA File Offset: 0x00476FBA
		public static Offset<ICompareGameDifficulty> EndICompareGameDifficulty(FlatBufferBuilder builder)
		{
			return new Offset<ICompareGameDifficulty>(builder.EndTable());
		}

		// Token: 0x06020479 RID: 132217 RVA: 0x00478DC8 File Offset: 0x00476FC8
		public ICompareGameDifficultyT UnPack()
		{
			ICompareGameDifficultyT compareGameDifficultyT = new ICompareGameDifficultyT();
			this.UnPackTo(compareGameDifficultyT);
			return compareGameDifficultyT;
		}

		// Token: 0x0602047A RID: 132218 RVA: 0x00478DE3 File Offset: 0x00476FE3
		public void UnPackTo(ICompareGameDifficultyT _o)
		{
			_o.Type = this.Type;
			_o.CompareType = this.CompareType;
			_o.Difficulty = this.Difficulty;
		}

		// Token: 0x0602047B RID: 132219 RVA: 0x00478E0C File Offset: 0x0047700C
		public static Offset<ICompareGameDifficulty> Pack(FlatBufferBuilder builder, ICompareGameDifficultyT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompareGameDifficulty>);
			}
			return ICompareGameDifficulty.CreateICompareGameDifficulty(builder, _o.Type, _o.CompareType, _o.Difficulty);
		}

		// Token: 0x0400DF90 RID: 57232
		private Table __p;
	}
}
