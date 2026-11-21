using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007100 RID: 28928
	public struct ILiveInteractDanmakuTriggerBattleEvent : IFlatbufferObject
	{
		// Token: 0x1700D3D9 RID: 54233
		// (get) Token: 0x060323DB RID: 205787 RVA: 0x006CB809 File Offset: 0x006C9A09
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060323DC RID: 205788 RVA: 0x006CB816 File Offset: 0x006C9A16
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060323DD RID: 205789 RVA: 0x006CB820 File Offset: 0x006C9A20
		public static ILiveInteractDanmakuTriggerBattleEvent GetRootAsILiveInteractDanmakuTriggerBattleEvent(ByteBuffer _bb)
		{
			return ILiveInteractDanmakuTriggerBattleEvent.GetRootAsILiveInteractDanmakuTriggerBattleEvent(_bb, default(ILiveInteractDanmakuTriggerBattleEvent));
		}

		// Token: 0x060323DE RID: 205790 RVA: 0x006CB83C File Offset: 0x006C9A3C
		public static ILiveInteractDanmakuTriggerBattleEvent GetRootAsILiveInteractDanmakuTriggerBattleEvent(ByteBuffer _bb, ILiveInteractDanmakuTriggerBattleEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060323DF RID: 205791 RVA: 0x006CB859 File Offset: 0x006C9A59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060323E0 RID: 205792 RVA: 0x006CB868 File Offset: 0x006C9A68
		public ILiveInteractDanmakuTriggerBattleEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D3DA RID: 54234
		// (get) Token: 0x060323E1 RID: 205793 RVA: 0x006CB878 File Offset: 0x006C9A78
		public ELiveInteractDanmakuTriggerType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELiveInteractDanmakuTriggerType.SkillGenre;
				}
				return (ELiveInteractDanmakuTriggerType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D3DB RID: 54235
		// (get) Token: 0x060323E2 RID: 205794 RVA: 0x006CB8B4 File Offset: 0x006C9AB4
		public int EntityId
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

		// Token: 0x1700D3DC RID: 54236
		// (get) Token: 0x060323E3 RID: 205795 RVA: 0x006CB8F0 File Offset: 0x006C9AF0
		public int BattleEventId
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

		// Token: 0x060323E4 RID: 205796 RVA: 0x006CB92C File Offset: 0x006C9B2C
		public static Offset<ILiveInteractDanmakuTriggerBattleEvent> CreateILiveInteractDanmakuTriggerBattleEvent(FlatBufferBuilder builder, ELiveInteractDanmakuTriggerType Type = ELiveInteractDanmakuTriggerType.SkillGenre, int EntityId = 0, int BattleEventId = 0)
		{
			builder.StartTable(3);
			ILiveInteractDanmakuTriggerBattleEvent.AddBattleEventId(builder, BattleEventId);
			ILiveInteractDanmakuTriggerBattleEvent.AddEntityId(builder, EntityId);
			ILiveInteractDanmakuTriggerBattleEvent.AddType(builder, Type);
			return ILiveInteractDanmakuTriggerBattleEvent.EndILiveInteractDanmakuTriggerBattleEvent(builder);
		}

		// Token: 0x060323E5 RID: 205797 RVA: 0x006CB950 File Offset: 0x006C9B50
		public static void StartILiveInteractDanmakuTriggerBattleEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060323E6 RID: 205798 RVA: 0x006CB959 File Offset: 0x006C9B59
		public static void AddType(FlatBufferBuilder builder, ELiveInteractDanmakuTriggerType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060323E7 RID: 205799 RVA: 0x006CB964 File Offset: 0x006C9B64
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x060323E8 RID: 205800 RVA: 0x006CB96F File Offset: 0x006C9B6F
		public static void AddBattleEventId(FlatBufferBuilder builder, int battleEventId)
		{
			builder.AddInt(2, battleEventId, 0);
		}

		// Token: 0x060323E9 RID: 205801 RVA: 0x006CB97A File Offset: 0x006C9B7A
		public static Offset<ILiveInteractDanmakuTriggerBattleEvent> EndILiveInteractDanmakuTriggerBattleEvent(FlatBufferBuilder builder)
		{
			return new Offset<ILiveInteractDanmakuTriggerBattleEvent>(builder.EndTable());
		}

		// Token: 0x060323EA RID: 205802 RVA: 0x006CB988 File Offset: 0x006C9B88
		public ILiveInteractDanmakuTriggerBattleEventT UnPack()
		{
			ILiveInteractDanmakuTriggerBattleEventT liveInteractDanmakuTriggerBattleEventT = new ILiveInteractDanmakuTriggerBattleEventT();
			this.UnPackTo(liveInteractDanmakuTriggerBattleEventT);
			return liveInteractDanmakuTriggerBattleEventT;
		}

		// Token: 0x060323EB RID: 205803 RVA: 0x006CB9A3 File Offset: 0x006C9BA3
		public void UnPackTo(ILiveInteractDanmakuTriggerBattleEventT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.BattleEventId = this.BattleEventId;
		}

		// Token: 0x060323EC RID: 205804 RVA: 0x006CB9CC File Offset: 0x006C9BCC
		public static Offset<ILiveInteractDanmakuTriggerBattleEvent> Pack(FlatBufferBuilder builder, ILiveInteractDanmakuTriggerBattleEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILiveInteractDanmakuTriggerBattleEvent>);
			}
			return ILiveInteractDanmakuTriggerBattleEvent.CreateILiveInteractDanmakuTriggerBattleEvent(builder, _o.Type, _o.EntityId, _o.BattleEventId);
		}

		// Token: 0x040120D2 RID: 73938
		private Table __p;
	}
}
