using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F54 RID: 24404
	public struct ISpawnMonsterCompleteCondition : IFlatbufferObject
	{
		// Token: 0x1700B4BC RID: 46268
		// (get) Token: 0x0602902C RID: 167980 RVA: 0x0059A236 File Offset: 0x00598436
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602902D RID: 167981 RVA: 0x0059A243 File Offset: 0x00598443
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602902E RID: 167982 RVA: 0x0059A24C File Offset: 0x0059844C
		public static ISpawnMonsterCompleteCondition GetRootAsISpawnMonsterCompleteCondition(ByteBuffer _bb)
		{
			return ISpawnMonsterCompleteCondition.GetRootAsISpawnMonsterCompleteCondition(_bb, default(ISpawnMonsterCompleteCondition));
		}

		// Token: 0x0602902F RID: 167983 RVA: 0x0059A268 File Offset: 0x00598468
		public static ISpawnMonsterCompleteCondition GetRootAsISpawnMonsterCompleteCondition(ByteBuffer _bb, ISpawnMonsterCompleteCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029030 RID: 167984 RVA: 0x0059A285 File Offset: 0x00598485
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029031 RID: 167985 RVA: 0x0059A294 File Offset: 0x00598494
		public ISpawnMonsterCompleteCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B4BD RID: 46269
		// (get) Token: 0x06029032 RID: 167986 RVA: 0x0059A2A4 File Offset: 0x005984A4
		public ESpawnMonsterCompleteCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESpawnMonsterCompleteCondition.AllKill;
				}
				return (ESpawnMonsterCompleteCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029033 RID: 167987 RVA: 0x0059A2E0 File Offset: 0x005984E0
		public static Offset<ISpawnMonsterCompleteCondition> CreateISpawnMonsterCompleteCondition(FlatBufferBuilder builder, ESpawnMonsterCompleteCondition Type = ESpawnMonsterCompleteCondition.AllKill)
		{
			builder.StartTable(1);
			ISpawnMonsterCompleteCondition.AddType(builder, Type);
			return ISpawnMonsterCompleteCondition.EndISpawnMonsterCompleteCondition(builder);
		}

		// Token: 0x06029034 RID: 167988 RVA: 0x0059A2F6 File Offset: 0x005984F6
		public static void StartISpawnMonsterCompleteCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06029035 RID: 167989 RVA: 0x0059A2FF File Offset: 0x005984FF
		public static void AddType(FlatBufferBuilder builder, ESpawnMonsterCompleteCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029036 RID: 167990 RVA: 0x0059A30A File Offset: 0x0059850A
		public static Offset<ISpawnMonsterCompleteCondition> EndISpawnMonsterCompleteCondition(FlatBufferBuilder builder)
		{
			return new Offset<ISpawnMonsterCompleteCondition>(builder.EndTable());
		}

		// Token: 0x06029037 RID: 167991 RVA: 0x0059A318 File Offset: 0x00598518
		public ISpawnMonsterCompleteConditionT UnPack()
		{
			ISpawnMonsterCompleteConditionT spawnMonsterCompleteConditionT = new ISpawnMonsterCompleteConditionT();
			this.UnPackTo(spawnMonsterCompleteConditionT);
			return spawnMonsterCompleteConditionT;
		}

		// Token: 0x06029038 RID: 167992 RVA: 0x0059A333 File Offset: 0x00598533
		public void UnPackTo(ISpawnMonsterCompleteConditionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06029039 RID: 167993 RVA: 0x0059A344 File Offset: 0x00598544
		public static Offset<ISpawnMonsterCompleteCondition> Pack(FlatBufferBuilder builder, ISpawnMonsterCompleteConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISpawnMonsterCompleteCondition>);
			}
			return ISpawnMonsterCompleteCondition.CreateISpawnMonsterCompleteCondition(builder, _o.Type);
		}

		// Token: 0x0400FC10 RID: 64528
		private Table __p;
	}
}
