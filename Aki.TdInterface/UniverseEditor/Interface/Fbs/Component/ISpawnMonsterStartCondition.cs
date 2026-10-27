using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005962 RID: 22882
	public struct ISpawnMonsterStartCondition : IFlatbufferObject
	{
		// Token: 0x1700ABBF RID: 43967
		// (get) Token: 0x06026BB7 RID: 158647 RVA: 0x00555427 File Offset: 0x00553627
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026BB8 RID: 158648 RVA: 0x00555434 File Offset: 0x00553634
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026BB9 RID: 158649 RVA: 0x0055543C File Offset: 0x0055363C
		public static ISpawnMonsterStartCondition GetRootAsISpawnMonsterStartCondition(ByteBuffer _bb)
		{
			return ISpawnMonsterStartCondition.GetRootAsISpawnMonsterStartCondition(_bb, default(ISpawnMonsterStartCondition));
		}

		// Token: 0x06026BBA RID: 158650 RVA: 0x00555458 File Offset: 0x00553658
		public static ISpawnMonsterStartCondition GetRootAsISpawnMonsterStartCondition(ByteBuffer _bb, ISpawnMonsterStartCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026BBB RID: 158651 RVA: 0x00555475 File Offset: 0x00553675
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026BBC RID: 158652 RVA: 0x00555484 File Offset: 0x00553684
		public ISpawnMonsterStartCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ABC0 RID: 43968
		// (get) Token: 0x06026BBD RID: 158653 RVA: 0x00555494 File Offset: 0x00553694
		public ESpawnMonsterStartCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESpawnMonsterStartCondition.Immediate;
				}
				return (ESpawnMonsterStartCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026BBE RID: 158654 RVA: 0x005554D0 File Offset: 0x005536D0
		public static Offset<ISpawnMonsterStartCondition> CreateISpawnMonsterStartCondition(FlatBufferBuilder builder, ESpawnMonsterStartCondition Type = ESpawnMonsterStartCondition.Immediate)
		{
			builder.StartTable(1);
			ISpawnMonsterStartCondition.AddType(builder, Type);
			return ISpawnMonsterStartCondition.EndISpawnMonsterStartCondition(builder);
		}

		// Token: 0x06026BBF RID: 158655 RVA: 0x005554E6 File Offset: 0x005536E6
		public static void StartISpawnMonsterStartCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06026BC0 RID: 158656 RVA: 0x005554EF File Offset: 0x005536EF
		public static void AddType(FlatBufferBuilder builder, ESpawnMonsterStartCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026BC1 RID: 158657 RVA: 0x005554FA File Offset: 0x005536FA
		public static Offset<ISpawnMonsterStartCondition> EndISpawnMonsterStartCondition(FlatBufferBuilder builder)
		{
			return new Offset<ISpawnMonsterStartCondition>(builder.EndTable());
		}

		// Token: 0x06026BC2 RID: 158658 RVA: 0x00555508 File Offset: 0x00553708
		public ISpawnMonsterStartConditionT UnPack()
		{
			ISpawnMonsterStartConditionT spawnMonsterStartConditionT = new ISpawnMonsterStartConditionT();
			this.UnPackTo(spawnMonsterStartConditionT);
			return spawnMonsterStartConditionT;
		}

		// Token: 0x06026BC3 RID: 158659 RVA: 0x00555523 File Offset: 0x00553723
		public void UnPackTo(ISpawnMonsterStartConditionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06026BC4 RID: 158660 RVA: 0x00555534 File Offset: 0x00553734
		public static Offset<ISpawnMonsterStartCondition> Pack(FlatBufferBuilder builder, ISpawnMonsterStartConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISpawnMonsterStartCondition>);
			}
			return ISpawnMonsterStartCondition.CreateISpawnMonsterStartCondition(builder, _o.Type);
		}

		// Token: 0x0400EF46 RID: 61254
		private Table __p;
	}
}
