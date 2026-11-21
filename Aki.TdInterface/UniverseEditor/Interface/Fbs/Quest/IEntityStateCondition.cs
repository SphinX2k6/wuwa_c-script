using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200424A RID: 16970
	public struct IEntityStateCondition : IFlatbufferObject
	{
		// Token: 0x170073B6 RID: 29622
		// (get) Token: 0x060179E7 RID: 96743 RVA: 0x0035E6F0 File Offset: 0x0035C8F0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060179E8 RID: 96744 RVA: 0x0035E6FD File Offset: 0x0035C8FD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060179E9 RID: 96745 RVA: 0x0035E704 File Offset: 0x0035C904
		public static IEntityStateCondition GetRootAsIEntityStateCondition(ByteBuffer _bb)
		{
			return IEntityStateCondition.GetRootAsIEntityStateCondition(_bb, default(IEntityStateCondition));
		}

		// Token: 0x060179EA RID: 96746 RVA: 0x0035E720 File Offset: 0x0035C920
		public static IEntityStateCondition GetRootAsIEntityStateCondition(ByteBuffer _bb, IEntityStateCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060179EB RID: 96747 RVA: 0x0035E73D File Offset: 0x0035C93D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060179EC RID: 96748 RVA: 0x0035E74C File Offset: 0x0035C94C
		public IEntityStateCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170073B7 RID: 29623
		// (get) Token: 0x060179ED RID: 96749 RVA: 0x0035E75C File Offset: 0x0035C95C
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

		// Token: 0x170073B8 RID: 29624
		// (get) Token: 0x060179EE RID: 96750 RVA: 0x0035E798 File Offset: 0x0035C998
		public string State
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060179EF RID: 96751 RVA: 0x0035E7CF File Offset: 0x0035C9CF
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060179F0 RID: 96752 RVA: 0x0035E7DE File Offset: 0x0035C9DE
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060179F1 RID: 96753 RVA: 0x0035E7EC File Offset: 0x0035C9EC
		public static Offset<IEntityStateCondition> CreateIEntityStateCondition(FlatBufferBuilder builder, int EntityId = 0, StringOffset StateOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IEntityStateCondition.AddState(builder, StateOffset);
			IEntityStateCondition.AddEntityId(builder, EntityId);
			return IEntityStateCondition.EndIEntityStateCondition(builder);
		}

		// Token: 0x060179F2 RID: 96754 RVA: 0x0035E809 File Offset: 0x0035CA09
		public static void StartIEntityStateCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060179F3 RID: 96755 RVA: 0x0035E812 File Offset: 0x0035CA12
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x060179F4 RID: 96756 RVA: 0x0035E81D File Offset: 0x0035CA1D
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(1, stateOffset.Value, 0);
		}

		// Token: 0x060179F5 RID: 96757 RVA: 0x0035E82D File Offset: 0x0035CA2D
		public static Offset<IEntityStateCondition> EndIEntityStateCondition(FlatBufferBuilder builder)
		{
			return new Offset<IEntityStateCondition>(builder.EndTable());
		}

		// Token: 0x060179F6 RID: 96758 RVA: 0x0035E83C File Offset: 0x0035CA3C
		public IEntityStateConditionT UnPack()
		{
			IEntityStateConditionT entityStateConditionT = new IEntityStateConditionT();
			this.UnPackTo(entityStateConditionT);
			return entityStateConditionT;
		}

		// Token: 0x060179F7 RID: 96759 RVA: 0x0035E857 File Offset: 0x0035CA57
		public void UnPackTo(IEntityStateConditionT _o)
		{
			_o.EntityId = this.EntityId;
			_o.State = this.State;
		}

		// Token: 0x060179F8 RID: 96760 RVA: 0x0035E874 File Offset: 0x0035CA74
		public static Offset<IEntityStateCondition> Pack(FlatBufferBuilder builder, IEntityStateConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityStateCondition>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return IEntityStateCondition.CreateIEntityStateCondition(builder, _o.EntityId, stateOffset);
		}

		// Token: 0x0400C15B RID: 49499
		private Table __p;
	}
}
