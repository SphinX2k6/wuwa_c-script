using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200453C RID: 17724
	public struct IRemainScoreCanWinCondition : IFlatbufferObject
	{
		// Token: 0x17007DB7 RID: 32183
		// (get) Token: 0x0601AA8B RID: 109195 RVA: 0x003CDBFE File Offset: 0x003CBDFE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AA8C RID: 109196 RVA: 0x003CDC0B File Offset: 0x003CBE0B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AA8D RID: 109197 RVA: 0x003CDC14 File Offset: 0x003CBE14
		public static IRemainScoreCanWinCondition GetRootAsIRemainScoreCanWinCondition(ByteBuffer _bb)
		{
			return IRemainScoreCanWinCondition.GetRootAsIRemainScoreCanWinCondition(_bb, default(IRemainScoreCanWinCondition));
		}

		// Token: 0x0601AA8E RID: 109198 RVA: 0x003CDC30 File Offset: 0x003CBE30
		public static IRemainScoreCanWinCondition GetRootAsIRemainScoreCanWinCondition(ByteBuffer _bb, IRemainScoreCanWinCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AA8F RID: 109199 RVA: 0x003CDC4D File Offset: 0x003CBE4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AA90 RID: 109200 RVA: 0x003CDC5C File Offset: 0x003CBE5C
		public IRemainScoreCanWinCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007DB8 RID: 32184
		// (get) Token: 0x0601AA91 RID: 109201 RVA: 0x003CDC6C File Offset: 0x003CBE6C
		public EDartSkillConditionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDartSkillConditionType.RemainScoreGe;
				}
				return (EDartSkillConditionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601AA92 RID: 109202 RVA: 0x003CDCA8 File Offset: 0x003CBEA8
		public static Offset<IRemainScoreCanWinCondition> CreateIRemainScoreCanWinCondition(FlatBufferBuilder builder, EDartSkillConditionType Type = EDartSkillConditionType.RemainScoreGe)
		{
			builder.StartTable(1);
			IRemainScoreCanWinCondition.AddType(builder, Type);
			return IRemainScoreCanWinCondition.EndIRemainScoreCanWinCondition(builder);
		}

		// Token: 0x0601AA93 RID: 109203 RVA: 0x003CDCBE File Offset: 0x003CBEBE
		public static void StartIRemainScoreCanWinCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601AA94 RID: 109204 RVA: 0x003CDCC7 File Offset: 0x003CBEC7
		public static void AddType(FlatBufferBuilder builder, EDartSkillConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601AA95 RID: 109205 RVA: 0x003CDCD2 File Offset: 0x003CBED2
		public static Offset<IRemainScoreCanWinCondition> EndIRemainScoreCanWinCondition(FlatBufferBuilder builder)
		{
			return new Offset<IRemainScoreCanWinCondition>(builder.EndTable());
		}

		// Token: 0x0601AA96 RID: 109206 RVA: 0x003CDCE0 File Offset: 0x003CBEE0
		public IRemainScoreCanWinConditionT UnPack()
		{
			IRemainScoreCanWinConditionT remainScoreCanWinConditionT = new IRemainScoreCanWinConditionT();
			this.UnPackTo(remainScoreCanWinConditionT);
			return remainScoreCanWinConditionT;
		}

		// Token: 0x0601AA97 RID: 109207 RVA: 0x003CDCFB File Offset: 0x003CBEFB
		public void UnPackTo(IRemainScoreCanWinConditionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601AA98 RID: 109208 RVA: 0x003CDD0C File Offset: 0x003CBF0C
		public static Offset<IRemainScoreCanWinCondition> Pack(FlatBufferBuilder builder, IRemainScoreCanWinConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRemainScoreCanWinCondition>);
			}
			return IRemainScoreCanWinCondition.CreateIRemainScoreCanWinCondition(builder, _o.Type);
		}

		// Token: 0x0400C5C2 RID: 50626
		private Table __p;
	}
}
