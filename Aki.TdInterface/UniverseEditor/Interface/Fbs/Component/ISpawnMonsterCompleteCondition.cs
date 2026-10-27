using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005947 RID: 22855
	public struct ISpawnMonsterCompleteCondition : IFlatbufferObject
	{
		// Token: 0x1700AB88 RID: 43912
		// (get) Token: 0x06026AC2 RID: 158402 RVA: 0x005535CA File Offset: 0x005517CA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026AC3 RID: 158403 RVA: 0x005535D7 File Offset: 0x005517D7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026AC4 RID: 158404 RVA: 0x005535E0 File Offset: 0x005517E0
		public static ISpawnMonsterCompleteCondition GetRootAsISpawnMonsterCompleteCondition(ByteBuffer _bb)
		{
			return ISpawnMonsterCompleteCondition.GetRootAsISpawnMonsterCompleteCondition(_bb, default(ISpawnMonsterCompleteCondition));
		}

		// Token: 0x06026AC5 RID: 158405 RVA: 0x005535FC File Offset: 0x005517FC
		public static ISpawnMonsterCompleteCondition GetRootAsISpawnMonsterCompleteCondition(ByteBuffer _bb, ISpawnMonsterCompleteCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026AC6 RID: 158406 RVA: 0x00553619 File Offset: 0x00551819
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026AC7 RID: 158407 RVA: 0x00553628 File Offset: 0x00551828
		public ISpawnMonsterCompleteCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AB89 RID: 43913
		// (get) Token: 0x06026AC8 RID: 158408 RVA: 0x00553638 File Offset: 0x00551838
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

		// Token: 0x06026AC9 RID: 158409 RVA: 0x00553674 File Offset: 0x00551874
		public static Offset<ISpawnMonsterCompleteCondition> CreateISpawnMonsterCompleteCondition(FlatBufferBuilder builder, ESpawnMonsterCompleteCondition Type = ESpawnMonsterCompleteCondition.AllKill)
		{
			builder.StartTable(1);
			ISpawnMonsterCompleteCondition.AddType(builder, Type);
			return ISpawnMonsterCompleteCondition.EndISpawnMonsterCompleteCondition(builder);
		}

		// Token: 0x06026ACA RID: 158410 RVA: 0x0055368A File Offset: 0x0055188A
		public static void StartISpawnMonsterCompleteCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06026ACB RID: 158411 RVA: 0x00553693 File Offset: 0x00551893
		public static void AddType(FlatBufferBuilder builder, ESpawnMonsterCompleteCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026ACC RID: 158412 RVA: 0x0055369E File Offset: 0x0055189E
		public static Offset<ISpawnMonsterCompleteCondition> EndISpawnMonsterCompleteCondition(FlatBufferBuilder builder)
		{
			return new Offset<ISpawnMonsterCompleteCondition>(builder.EndTable());
		}

		// Token: 0x06026ACD RID: 158413 RVA: 0x005536AC File Offset: 0x005518AC
		public ISpawnMonsterCompleteConditionT UnPack()
		{
			ISpawnMonsterCompleteConditionT spawnMonsterCompleteConditionT = new ISpawnMonsterCompleteConditionT();
			this.UnPackTo(spawnMonsterCompleteConditionT);
			return spawnMonsterCompleteConditionT;
		}

		// Token: 0x06026ACE RID: 158414 RVA: 0x005536C7 File Offset: 0x005518C7
		public void UnPackTo(ISpawnMonsterCompleteConditionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06026ACF RID: 158415 RVA: 0x005536D8 File Offset: 0x005518D8
		public static Offset<ISpawnMonsterCompleteCondition> Pack(FlatBufferBuilder builder, ISpawnMonsterCompleteConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISpawnMonsterCompleteCondition>);
			}
			return ISpawnMonsterCompleteCondition.CreateISpawnMonsterCompleteCondition(builder, _o.Type);
		}

		// Token: 0x0400EF1B RID: 61211
		private Table __p;
	}
}
