using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D82 RID: 15746
	public struct ICheckTrapDefenseEventMonsterKilled : IFlatbufferObject
	{
		// Token: 0x17006C0D RID: 27661
		// (get) Token: 0x06015CD7 RID: 89303 RVA: 0x0032496F File Offset: 0x00322B6F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015CD8 RID: 89304 RVA: 0x0032497C File Offset: 0x00322B7C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015CD9 RID: 89305 RVA: 0x00324984 File Offset: 0x00322B84
		public static ICheckTrapDefenseEventMonsterKilled GetRootAsICheckTrapDefenseEventMonsterKilled(ByteBuffer _bb)
		{
			return ICheckTrapDefenseEventMonsterKilled.GetRootAsICheckTrapDefenseEventMonsterKilled(_bb, default(ICheckTrapDefenseEventMonsterKilled));
		}

		// Token: 0x06015CDA RID: 89306 RVA: 0x003249A0 File Offset: 0x00322BA0
		public static ICheckTrapDefenseEventMonsterKilled GetRootAsICheckTrapDefenseEventMonsterKilled(ByteBuffer _bb, ICheckTrapDefenseEventMonsterKilled obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015CDB RID: 89307 RVA: 0x003249BD File Offset: 0x00322BBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015CDC RID: 89308 RVA: 0x003249CC File Offset: 0x00322BCC
		public ICheckTrapDefenseEventMonsterKilled __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006C0E RID: 27662
		// (get) Token: 0x06015CDD RID: 89309 RVA: 0x003249DC File Offset: 0x00322BDC
		public ECheckTrapDefenseEvent Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckTrapDefenseEvent.MonsterKilled;
				}
				return (ECheckTrapDefenseEvent)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006C0F RID: 27663
		// (get) Token: 0x06015CDE RID: 89310 RVA: 0x00324A18 File Offset: 0x00322C18
		public int Id
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

		// Token: 0x06015CDF RID: 89311 RVA: 0x00324A54 File Offset: 0x00322C54
		public static Offset<ICheckTrapDefenseEventMonsterKilled> CreateICheckTrapDefenseEventMonsterKilled(FlatBufferBuilder builder, ECheckTrapDefenseEvent Type = ECheckTrapDefenseEvent.MonsterKilled, int Id = 0)
		{
			builder.StartTable(2);
			ICheckTrapDefenseEventMonsterKilled.AddId(builder, Id);
			ICheckTrapDefenseEventMonsterKilled.AddType(builder, Type);
			return ICheckTrapDefenseEventMonsterKilled.EndICheckTrapDefenseEventMonsterKilled(builder);
		}

		// Token: 0x06015CE0 RID: 89312 RVA: 0x00324A71 File Offset: 0x00322C71
		public static void StartICheckTrapDefenseEventMonsterKilled(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06015CE1 RID: 89313 RVA: 0x00324A7A File Offset: 0x00322C7A
		public static void AddType(FlatBufferBuilder builder, ECheckTrapDefenseEvent type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015CE2 RID: 89314 RVA: 0x00324A85 File Offset: 0x00322C85
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06015CE3 RID: 89315 RVA: 0x00324A90 File Offset: 0x00322C90
		public static Offset<ICheckTrapDefenseEventMonsterKilled> EndICheckTrapDefenseEventMonsterKilled(FlatBufferBuilder builder)
		{
			return new Offset<ICheckTrapDefenseEventMonsterKilled>(builder.EndTable());
		}

		// Token: 0x06015CE4 RID: 89316 RVA: 0x00324AA0 File Offset: 0x00322CA0
		public ICheckTrapDefenseEventMonsterKilledT UnPack()
		{
			ICheckTrapDefenseEventMonsterKilledT checkTrapDefenseEventMonsterKilledT = new ICheckTrapDefenseEventMonsterKilledT();
			this.UnPackTo(checkTrapDefenseEventMonsterKilledT);
			return checkTrapDefenseEventMonsterKilledT;
		}

		// Token: 0x06015CE5 RID: 89317 RVA: 0x00324ABB File Offset: 0x00322CBB
		public void UnPackTo(ICheckTrapDefenseEventMonsterKilledT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x06015CE6 RID: 89318 RVA: 0x00324AD8 File Offset: 0x00322CD8
		public static Offset<ICheckTrapDefenseEventMonsterKilled> Pack(FlatBufferBuilder builder, ICheckTrapDefenseEventMonsterKilledT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckTrapDefenseEventMonsterKilled>);
			}
			return ICheckTrapDefenseEventMonsterKilled.CreateICheckTrapDefenseEventMonsterKilled(builder, _o.Type, _o.Id);
		}

		// Token: 0x0400B66E RID: 46702
		private Table __p;
	}
}
