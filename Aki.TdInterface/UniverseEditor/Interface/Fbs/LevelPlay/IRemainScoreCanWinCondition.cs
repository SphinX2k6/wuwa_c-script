using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049A4 RID: 18852
	public struct IRemainScoreCanWinCondition : IFlatbufferObject
	{
		// Token: 0x170083F8 RID: 33784
		// (get) Token: 0x0601C260 RID: 115296 RVA: 0x003F9E9A File Offset: 0x003F809A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C261 RID: 115297 RVA: 0x003F9EA7 File Offset: 0x003F80A7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C262 RID: 115298 RVA: 0x003F9EB0 File Offset: 0x003F80B0
		public static IRemainScoreCanWinCondition GetRootAsIRemainScoreCanWinCondition(ByteBuffer _bb)
		{
			return IRemainScoreCanWinCondition.GetRootAsIRemainScoreCanWinCondition(_bb, default(IRemainScoreCanWinCondition));
		}

		// Token: 0x0601C263 RID: 115299 RVA: 0x003F9ECC File Offset: 0x003F80CC
		public static IRemainScoreCanWinCondition GetRootAsIRemainScoreCanWinCondition(ByteBuffer _bb, IRemainScoreCanWinCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C264 RID: 115300 RVA: 0x003F9EE9 File Offset: 0x003F80E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C265 RID: 115301 RVA: 0x003F9EF8 File Offset: 0x003F80F8
		public IRemainScoreCanWinCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170083F9 RID: 33785
		// (get) Token: 0x0601C266 RID: 115302 RVA: 0x003F9F08 File Offset: 0x003F8108
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

		// Token: 0x0601C267 RID: 115303 RVA: 0x003F9F44 File Offset: 0x003F8144
		public static Offset<IRemainScoreCanWinCondition> CreateIRemainScoreCanWinCondition(FlatBufferBuilder builder, EDartSkillConditionType Type = EDartSkillConditionType.RemainScoreGe)
		{
			builder.StartTable(1);
			IRemainScoreCanWinCondition.AddType(builder, Type);
			return IRemainScoreCanWinCondition.EndIRemainScoreCanWinCondition(builder);
		}

		// Token: 0x0601C268 RID: 115304 RVA: 0x003F9F5A File Offset: 0x003F815A
		public static void StartIRemainScoreCanWinCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601C269 RID: 115305 RVA: 0x003F9F63 File Offset: 0x003F8163
		public static void AddType(FlatBufferBuilder builder, EDartSkillConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C26A RID: 115306 RVA: 0x003F9F6E File Offset: 0x003F816E
		public static Offset<IRemainScoreCanWinCondition> EndIRemainScoreCanWinCondition(FlatBufferBuilder builder)
		{
			return new Offset<IRemainScoreCanWinCondition>(builder.EndTable());
		}

		// Token: 0x0601C26B RID: 115307 RVA: 0x003F9F7C File Offset: 0x003F817C
		public IRemainScoreCanWinConditionT UnPack()
		{
			IRemainScoreCanWinConditionT remainScoreCanWinConditionT = new IRemainScoreCanWinConditionT();
			this.UnPackTo(remainScoreCanWinConditionT);
			return remainScoreCanWinConditionT;
		}

		// Token: 0x0601C26C RID: 115308 RVA: 0x003F9F97 File Offset: 0x003F8197
		public void UnPackTo(IRemainScoreCanWinConditionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601C26D RID: 115309 RVA: 0x003F9FA8 File Offset: 0x003F81A8
		public static Offset<IRemainScoreCanWinCondition> Pack(FlatBufferBuilder builder, IRemainScoreCanWinConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRemainScoreCanWinCondition>);
			}
			return IRemainScoreCanWinCondition.CreateIRemainScoreCanWinCondition(builder, _o.Type);
		}

		// Token: 0x0400CFF1 RID: 53233
		private Table __p;
	}
}
