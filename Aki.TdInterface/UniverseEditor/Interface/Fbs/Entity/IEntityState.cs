using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C3A RID: 19514
	public struct IEntityState : IFlatbufferObject
	{
		// Token: 0x17008A62 RID: 35426
		// (get) Token: 0x0601DE7E RID: 122494 RVA: 0x0043190F File Offset: 0x0042FB0F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DE7F RID: 122495 RVA: 0x0043191C File Offset: 0x0042FB1C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DE80 RID: 122496 RVA: 0x00431924 File Offset: 0x0042FB24
		public static IEntityState GetRootAsIEntityState(ByteBuffer _bb)
		{
			return IEntityState.GetRootAsIEntityState(_bb, default(IEntityState));
		}

		// Token: 0x0601DE81 RID: 122497 RVA: 0x00431940 File Offset: 0x0042FB40
		public static IEntityState GetRootAsIEntityState(ByteBuffer _bb, IEntityState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DE82 RID: 122498 RVA: 0x0043195D File Offset: 0x0042FB5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DE83 RID: 122499 RVA: 0x0043196C File Offset: 0x0042FB6C
		public IEntityState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008A63 RID: 35427
		// (get) Token: 0x0601DE84 RID: 122500 RVA: 0x0043197C File Offset: 0x0042FB7C
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008A64 RID: 35428
		// (get) Token: 0x0601DE85 RID: 122501 RVA: 0x004319B8 File Offset: 0x0042FBB8
		public IEntityData? Data
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IEntityData?(default(IEntityData).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601DE86 RID: 122502 RVA: 0x00431A15 File Offset: 0x0042FC15
		public static Offset<IEntityState> CreateIEntityState(FlatBufferBuilder builder, int EntityId = 0, Offset<IEntityData> DataOffset = default(Offset<IEntityData>))
		{
			builder.StartTable(2);
			IEntityState.AddData(builder, DataOffset);
			IEntityState.AddEntityId(builder, EntityId);
			return IEntityState.EndIEntityState(builder);
		}

		// Token: 0x0601DE87 RID: 122503 RVA: 0x00431A32 File Offset: 0x0042FC32
		public static void StartIEntityState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601DE88 RID: 122504 RVA: 0x00431A3B File Offset: 0x0042FC3B
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x0601DE89 RID: 122505 RVA: 0x00431A46 File Offset: 0x0042FC46
		public static void AddData(FlatBufferBuilder builder, Offset<IEntityData> dataOffset)
		{
			builder.AddOffset(1, dataOffset.Value, 0);
		}

		// Token: 0x0601DE8A RID: 122506 RVA: 0x00431A56 File Offset: 0x0042FC56
		public static Offset<IEntityState> EndIEntityState(FlatBufferBuilder builder)
		{
			return new Offset<IEntityState>(builder.EndTable());
		}

		// Token: 0x0601DE8B RID: 122507 RVA: 0x00431A64 File Offset: 0x0042FC64
		public IEntityStateT UnPack()
		{
			IEntityStateT entityStateT = new IEntityStateT();
			this.UnPackTo(entityStateT);
			return entityStateT;
		}

		// Token: 0x0601DE8C RID: 122508 RVA: 0x00431A80 File Offset: 0x0042FC80
		public void UnPackTo(IEntityStateT _o)
		{
			_o.EntityId = this.EntityId;
			_o.Data = ((this.Data != null) ? this.Data.Value.UnPack() : null);
		}

		// Token: 0x0601DE8D RID: 122509 RVA: 0x00431AC8 File Offset: 0x0042FCC8
		public static Offset<IEntityState> Pack(FlatBufferBuilder builder, IEntityStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityState>);
			}
			Offset<IEntityData> dataOffset = (_o.Data == null) ? default(Offset<IEntityData>) : IEntityData.Pack(builder, _o.Data);
			return IEntityState.CreateIEntityState(builder, _o.EntityId, dataOffset);
		}

		// Token: 0x0400D69C RID: 54940
		private Table __p;
	}
}
