using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BAA RID: 19370
	public struct ICompareGameDifficulty : IFlatbufferObject
	{
		// Token: 0x17008C9D RID: 35997
		// (get) Token: 0x0601E8BE RID: 125118 RVA: 0x004460E8 File Offset: 0x004442E8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E8BF RID: 125119 RVA: 0x004460F5 File Offset: 0x004442F5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E8C0 RID: 125120 RVA: 0x004460FC File Offset: 0x004442FC
		public static ICompareGameDifficulty GetRootAsICompareGameDifficulty(ByteBuffer _bb)
		{
			return ICompareGameDifficulty.GetRootAsICompareGameDifficulty(_bb, default(ICompareGameDifficulty));
		}

		// Token: 0x0601E8C1 RID: 125121 RVA: 0x00446118 File Offset: 0x00444318
		public static ICompareGameDifficulty GetRootAsICompareGameDifficulty(ByteBuffer _bb, ICompareGameDifficulty obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E8C2 RID: 125122 RVA: 0x00446135 File Offset: 0x00444335
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E8C3 RID: 125123 RVA: 0x00446144 File Offset: 0x00444344
		public ICompareGameDifficulty __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008C9E RID: 35998
		// (get) Token: 0x0601E8C4 RID: 125124 RVA: 0x00446154 File Offset: 0x00444354
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

		// Token: 0x17008C9F RID: 35999
		// (get) Token: 0x0601E8C5 RID: 125125 RVA: 0x00446190 File Offset: 0x00444390
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

		// Token: 0x17008CA0 RID: 36000
		// (get) Token: 0x0601E8C6 RID: 125126 RVA: 0x004461CC File Offset: 0x004443CC
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

		// Token: 0x0601E8C7 RID: 125127 RVA: 0x00446208 File Offset: 0x00444408
		public static Offset<ICompareGameDifficulty> CreateICompareGameDifficulty(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, EVarCompare CompareType = EVarCompare.Eq, EGameDifficultyType Difficulty = EGameDifficultyType.None)
		{
			builder.StartTable(3);
			ICompareGameDifficulty.AddDifficulty(builder, Difficulty);
			ICompareGameDifficulty.AddCompareType(builder, CompareType);
			ICompareGameDifficulty.AddType(builder, Type);
			return ICompareGameDifficulty.EndICompareGameDifficulty(builder);
		}

		// Token: 0x0601E8C8 RID: 125128 RVA: 0x0044622C File Offset: 0x0044442C
		public static void StartICompareGameDifficulty(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601E8C9 RID: 125129 RVA: 0x00446235 File Offset: 0x00444435
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E8CA RID: 125130 RVA: 0x00446240 File Offset: 0x00444440
		public static void AddCompareType(FlatBufferBuilder builder, EVarCompare compareType)
		{
			builder.AddByte(1, (byte)compareType, 0);
		}

		// Token: 0x0601E8CB RID: 125131 RVA: 0x0044624B File Offset: 0x0044444B
		public static void AddDifficulty(FlatBufferBuilder builder, EGameDifficultyType difficulty)
		{
			builder.AddByte(2, (byte)difficulty, 0);
		}

		// Token: 0x0601E8CC RID: 125132 RVA: 0x00446256 File Offset: 0x00444456
		public static Offset<ICompareGameDifficulty> EndICompareGameDifficulty(FlatBufferBuilder builder)
		{
			return new Offset<ICompareGameDifficulty>(builder.EndTable());
		}

		// Token: 0x0601E8CD RID: 125133 RVA: 0x00446264 File Offset: 0x00444464
		public ICompareGameDifficultyT UnPack()
		{
			ICompareGameDifficultyT compareGameDifficultyT = new ICompareGameDifficultyT();
			this.UnPackTo(compareGameDifficultyT);
			return compareGameDifficultyT;
		}

		// Token: 0x0601E8CE RID: 125134 RVA: 0x0044627F File Offset: 0x0044447F
		public void UnPackTo(ICompareGameDifficultyT _o)
		{
			_o.Type = this.Type;
			_o.CompareType = this.CompareType;
			_o.Difficulty = this.Difficulty;
		}

		// Token: 0x0601E8CF RID: 125135 RVA: 0x004462A8 File Offset: 0x004444A8
		public static Offset<ICompareGameDifficulty> Pack(FlatBufferBuilder builder, ICompareGameDifficultyT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompareGameDifficulty>);
			}
			return ICompareGameDifficulty.CreateICompareGameDifficulty(builder, _o.Type, _o.CompareType, _o.Difficulty);
		}

		// Token: 0x0400D48B RID: 54411
		private Table __p;
	}
}
