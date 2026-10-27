using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006104 RID: 24836
	public struct IActorTurnToEntityData : IFlatbufferObject
	{
		// Token: 0x1700B70B RID: 46859
		// (get) Token: 0x0602A6EF RID: 173807 RVA: 0x005D8915 File Offset: 0x005D6B15
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A6F0 RID: 173808 RVA: 0x005D8922 File Offset: 0x005D6B22
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A6F1 RID: 173809 RVA: 0x005D892C File Offset: 0x005D6B2C
		public static IActorTurnToEntityData GetRootAsIActorTurnToEntityData(ByteBuffer _bb)
		{
			return IActorTurnToEntityData.GetRootAsIActorTurnToEntityData(_bb, default(IActorTurnToEntityData));
		}

		// Token: 0x0602A6F2 RID: 173810 RVA: 0x005D8948 File Offset: 0x005D6B48
		public static IActorTurnToEntityData GetRootAsIActorTurnToEntityData(ByteBuffer _bb, IActorTurnToEntityData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A6F3 RID: 173811 RVA: 0x005D8965 File Offset: 0x005D6B65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A6F4 RID: 173812 RVA: 0x005D8974 File Offset: 0x005D6B74
		public IActorTurnToEntityData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B70C RID: 46860
		// (get) Token: 0x0602A6F5 RID: 173813 RVA: 0x005D8984 File Offset: 0x005D6B84
		public EActorTurnToMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EActorTurnToMode.Talker;
				}
				return (EActorTurnToMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B70D RID: 46861
		// (get) Token: 0x0602A6F6 RID: 173814 RVA: 0x005D89C0 File Offset: 0x005D6BC0
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

		// Token: 0x0602A6F7 RID: 173815 RVA: 0x005D89FC File Offset: 0x005D6BFC
		public static Offset<IActorTurnToEntityData> CreateIActorTurnToEntityData(FlatBufferBuilder builder, EActorTurnToMode Type = EActorTurnToMode.Talker, int EntityId = 0)
		{
			builder.StartTable(2);
			IActorTurnToEntityData.AddEntityId(builder, EntityId);
			IActorTurnToEntityData.AddType(builder, Type);
			return IActorTurnToEntityData.EndIActorTurnToEntityData(builder);
		}

		// Token: 0x0602A6F8 RID: 173816 RVA: 0x005D8A19 File Offset: 0x005D6C19
		public static void StartIActorTurnToEntityData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602A6F9 RID: 173817 RVA: 0x005D8A22 File Offset: 0x005D6C22
		public static void AddType(FlatBufferBuilder builder, EActorTurnToMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A6FA RID: 173818 RVA: 0x005D8A2D File Offset: 0x005D6C2D
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0602A6FB RID: 173819 RVA: 0x005D8A38 File Offset: 0x005D6C38
		public static Offset<IActorTurnToEntityData> EndIActorTurnToEntityData(FlatBufferBuilder builder)
		{
			return new Offset<IActorTurnToEntityData>(builder.EndTable());
		}

		// Token: 0x0602A6FC RID: 173820 RVA: 0x005D8A48 File Offset: 0x005D6C48
		public IActorTurnToEntityDataT UnPack()
		{
			IActorTurnToEntityDataT actorTurnToEntityDataT = new IActorTurnToEntityDataT();
			this.UnPackTo(actorTurnToEntityDataT);
			return actorTurnToEntityDataT;
		}

		// Token: 0x0602A6FD RID: 173821 RVA: 0x005D8A63 File Offset: 0x005D6C63
		public void UnPackTo(IActorTurnToEntityDataT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x0602A6FE RID: 173822 RVA: 0x005D8A80 File Offset: 0x005D6C80
		public static Offset<IActorTurnToEntityData> Pack(FlatBufferBuilder builder, IActorTurnToEntityDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorTurnToEntityData>);
			}
			return IActorTurnToEntityData.CreateIActorTurnToEntityData(builder, _o.Type, _o.EntityId);
		}

		// Token: 0x040104CF RID: 66767
		private Table __p;
	}
}
