using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E0F RID: 15887
	public struct IEntityStateCondition : IFlatbufferObject
	{
		// Token: 0x17006DD0 RID: 28112
		// (get) Token: 0x060163BA RID: 91066 RVA: 0x00335AF8 File Offset: 0x00333CF8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060163BB RID: 91067 RVA: 0x00335B05 File Offset: 0x00333D05
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060163BC RID: 91068 RVA: 0x00335B0C File Offset: 0x00333D0C
		public static IEntityStateCondition GetRootAsIEntityStateCondition(ByteBuffer _bb)
		{
			return IEntityStateCondition.GetRootAsIEntityStateCondition(_bb, default(IEntityStateCondition));
		}

		// Token: 0x060163BD RID: 91069 RVA: 0x00335B28 File Offset: 0x00333D28
		public static IEntityStateCondition GetRootAsIEntityStateCondition(ByteBuffer _bb, IEntityStateCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060163BE RID: 91070 RVA: 0x00335B45 File Offset: 0x00333D45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060163BF RID: 91071 RVA: 0x00335B54 File Offset: 0x00333D54
		public IEntityStateCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006DD1 RID: 28113
		// (get) Token: 0x060163C0 RID: 91072 RVA: 0x00335B64 File Offset: 0x00333D64
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

		// Token: 0x17006DD2 RID: 28114
		// (get) Token: 0x060163C1 RID: 91073 RVA: 0x00335BA0 File Offset: 0x00333DA0
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

		// Token: 0x060163C2 RID: 91074 RVA: 0x00335BD7 File Offset: 0x00333DD7
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060163C3 RID: 91075 RVA: 0x00335BE6 File Offset: 0x00333DE6
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060163C4 RID: 91076 RVA: 0x00335BF4 File Offset: 0x00333DF4
		public static Offset<IEntityStateCondition> CreateIEntityStateCondition(FlatBufferBuilder builder, int EntityId = 0, StringOffset StateOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IEntityStateCondition.AddState(builder, StateOffset);
			IEntityStateCondition.AddEntityId(builder, EntityId);
			return IEntityStateCondition.EndIEntityStateCondition(builder);
		}

		// Token: 0x060163C5 RID: 91077 RVA: 0x00335C11 File Offset: 0x00333E11
		public static void StartIEntityStateCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060163C6 RID: 91078 RVA: 0x00335C1A File Offset: 0x00333E1A
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x060163C7 RID: 91079 RVA: 0x00335C25 File Offset: 0x00333E25
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(1, stateOffset.Value, 0);
		}

		// Token: 0x060163C8 RID: 91080 RVA: 0x00335C35 File Offset: 0x00333E35
		public static Offset<IEntityStateCondition> EndIEntityStateCondition(FlatBufferBuilder builder)
		{
			return new Offset<IEntityStateCondition>(builder.EndTable());
		}

		// Token: 0x060163C9 RID: 91081 RVA: 0x00335C44 File Offset: 0x00333E44
		public IEntityStateConditionT UnPack()
		{
			IEntityStateConditionT entityStateConditionT = new IEntityStateConditionT();
			this.UnPackTo(entityStateConditionT);
			return entityStateConditionT;
		}

		// Token: 0x060163CA RID: 91082 RVA: 0x00335C5F File Offset: 0x00333E5F
		public void UnPackTo(IEntityStateConditionT _o)
		{
			_o.EntityId = this.EntityId;
			_o.State = this.State;
		}

		// Token: 0x060163CB RID: 91083 RVA: 0x00335C7C File Offset: 0x00333E7C
		public static Offset<IEntityStateCondition> Pack(FlatBufferBuilder builder, IEntityStateConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityStateCondition>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return IEntityStateCondition.CreateIEntityStateCondition(builder, _o.EntityId, stateOffset);
		}

		// Token: 0x0400B783 RID: 46979
		private Table __p;
	}
}
