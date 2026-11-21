using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004199 RID: 16793
	public struct ICheckTrapDefenseEventMonsterKilled : IFlatbufferObject
	{
		// Token: 0x170071C7 RID: 29127
		// (get) Token: 0x0601720F RID: 94735 RVA: 0x0034BBE7 File Offset: 0x00349DE7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017210 RID: 94736 RVA: 0x0034BBF4 File Offset: 0x00349DF4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017211 RID: 94737 RVA: 0x0034BBFC File Offset: 0x00349DFC
		public static ICheckTrapDefenseEventMonsterKilled GetRootAsICheckTrapDefenseEventMonsterKilled(ByteBuffer _bb)
		{
			return ICheckTrapDefenseEventMonsterKilled.GetRootAsICheckTrapDefenseEventMonsterKilled(_bb, default(ICheckTrapDefenseEventMonsterKilled));
		}

		// Token: 0x06017212 RID: 94738 RVA: 0x0034BC18 File Offset: 0x00349E18
		public static ICheckTrapDefenseEventMonsterKilled GetRootAsICheckTrapDefenseEventMonsterKilled(ByteBuffer _bb, ICheckTrapDefenseEventMonsterKilled obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017213 RID: 94739 RVA: 0x0034BC35 File Offset: 0x00349E35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017214 RID: 94740 RVA: 0x0034BC44 File Offset: 0x00349E44
		public ICheckTrapDefenseEventMonsterKilled __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170071C8 RID: 29128
		// (get) Token: 0x06017215 RID: 94741 RVA: 0x0034BC54 File Offset: 0x00349E54
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

		// Token: 0x170071C9 RID: 29129
		// (get) Token: 0x06017216 RID: 94742 RVA: 0x0034BC90 File Offset: 0x00349E90
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

		// Token: 0x06017217 RID: 94743 RVA: 0x0034BCCC File Offset: 0x00349ECC
		public static Offset<ICheckTrapDefenseEventMonsterKilled> CreateICheckTrapDefenseEventMonsterKilled(FlatBufferBuilder builder, ECheckTrapDefenseEvent Type = ECheckTrapDefenseEvent.MonsterKilled, int Id = 0)
		{
			builder.StartTable(2);
			ICheckTrapDefenseEventMonsterKilled.AddId(builder, Id);
			ICheckTrapDefenseEventMonsterKilled.AddType(builder, Type);
			return ICheckTrapDefenseEventMonsterKilled.EndICheckTrapDefenseEventMonsterKilled(builder);
		}

		// Token: 0x06017218 RID: 94744 RVA: 0x0034BCE9 File Offset: 0x00349EE9
		public static void StartICheckTrapDefenseEventMonsterKilled(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06017219 RID: 94745 RVA: 0x0034BCF2 File Offset: 0x00349EF2
		public static void AddType(FlatBufferBuilder builder, ECheckTrapDefenseEvent type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601721A RID: 94746 RVA: 0x0034BCFD File Offset: 0x00349EFD
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0601721B RID: 94747 RVA: 0x0034BD08 File Offset: 0x00349F08
		public static Offset<ICheckTrapDefenseEventMonsterKilled> EndICheckTrapDefenseEventMonsterKilled(FlatBufferBuilder builder)
		{
			return new Offset<ICheckTrapDefenseEventMonsterKilled>(builder.EndTable());
		}

		// Token: 0x0601721C RID: 94748 RVA: 0x0034BD18 File Offset: 0x00349F18
		public ICheckTrapDefenseEventMonsterKilledT UnPack()
		{
			ICheckTrapDefenseEventMonsterKilledT checkTrapDefenseEventMonsterKilledT = new ICheckTrapDefenseEventMonsterKilledT();
			this.UnPackTo(checkTrapDefenseEventMonsterKilledT);
			return checkTrapDefenseEventMonsterKilledT;
		}

		// Token: 0x0601721D RID: 94749 RVA: 0x0034BD33 File Offset: 0x00349F33
		public void UnPackTo(ICheckTrapDefenseEventMonsterKilledT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x0601721E RID: 94750 RVA: 0x0034BD50 File Offset: 0x00349F50
		public static Offset<ICheckTrapDefenseEventMonsterKilled> Pack(FlatBufferBuilder builder, ICheckTrapDefenseEventMonsterKilledT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckTrapDefenseEventMonsterKilled>);
			}
			return ICheckTrapDefenseEventMonsterKilled.CreateICheckTrapDefenseEventMonsterKilled(builder, _o.Type, _o.Id);
		}

		// Token: 0x0400C01B RID: 49179
		private Table __p;
	}
}
