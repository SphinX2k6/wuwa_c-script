using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C19 RID: 19481
	public struct IEntityStateCondition : IFlatbufferObject
	{
		// Token: 0x17008D86 RID: 36230
		// (get) Token: 0x0601EDC5 RID: 126405 RVA: 0x0045201B File Offset: 0x0045021B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EDC6 RID: 126406 RVA: 0x00452028 File Offset: 0x00450228
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EDC7 RID: 126407 RVA: 0x00452030 File Offset: 0x00450230
		public static IEntityStateCondition GetRootAsIEntityStateCondition(ByteBuffer _bb)
		{
			return IEntityStateCondition.GetRootAsIEntityStateCondition(_bb, default(IEntityStateCondition));
		}

		// Token: 0x0601EDC8 RID: 126408 RVA: 0x0045204C File Offset: 0x0045024C
		public static IEntityStateCondition GetRootAsIEntityStateCondition(ByteBuffer _bb, IEntityStateCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EDC9 RID: 126409 RVA: 0x00452069 File Offset: 0x00450269
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EDCA RID: 126410 RVA: 0x00452078 File Offset: 0x00450278
		public IEntityStateCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008D87 RID: 36231
		// (get) Token: 0x0601EDCB RID: 126411 RVA: 0x00452088 File Offset: 0x00450288
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

		// Token: 0x17008D88 RID: 36232
		// (get) Token: 0x0601EDCC RID: 126412 RVA: 0x004520C4 File Offset: 0x004502C4
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

		// Token: 0x0601EDCD RID: 126413 RVA: 0x004520FB File Offset: 0x004502FB
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601EDCE RID: 126414 RVA: 0x0045210A File Offset: 0x0045030A
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601EDCF RID: 126415 RVA: 0x00452118 File Offset: 0x00450318
		public static Offset<IEntityStateCondition> CreateIEntityStateCondition(FlatBufferBuilder builder, int EntityId = 0, StringOffset StateOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IEntityStateCondition.AddState(builder, StateOffset);
			IEntityStateCondition.AddEntityId(builder, EntityId);
			return IEntityStateCondition.EndIEntityStateCondition(builder);
		}

		// Token: 0x0601EDD0 RID: 126416 RVA: 0x00452135 File Offset: 0x00450335
		public static void StartIEntityStateCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601EDD1 RID: 126417 RVA: 0x0045213E File Offset: 0x0045033E
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x0601EDD2 RID: 126418 RVA: 0x00452149 File Offset: 0x00450349
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(1, stateOffset.Value, 0);
		}

		// Token: 0x0601EDD3 RID: 126419 RVA: 0x00452159 File Offset: 0x00450359
		public static Offset<IEntityStateCondition> EndIEntityStateCondition(FlatBufferBuilder builder)
		{
			return new Offset<IEntityStateCondition>(builder.EndTable());
		}

		// Token: 0x0601EDD4 RID: 126420 RVA: 0x00452168 File Offset: 0x00450368
		public IEntityStateConditionT UnPack()
		{
			IEntityStateConditionT entityStateConditionT = new IEntityStateConditionT();
			this.UnPackTo(entityStateConditionT);
			return entityStateConditionT;
		}

		// Token: 0x0601EDD5 RID: 126421 RVA: 0x00452183 File Offset: 0x00450383
		public void UnPackTo(IEntityStateConditionT _o)
		{
			_o.EntityId = this.EntityId;
			_o.State = this.State;
		}

		// Token: 0x0601EDD6 RID: 126422 RVA: 0x004521A0 File Offset: 0x004503A0
		public static Offset<IEntityStateCondition> Pack(FlatBufferBuilder builder, IEntityStateConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityStateCondition>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return IEntityStateCondition.CreateIEntityStateCondition(builder, _o.EntityId, stateOffset);
		}

		// Token: 0x0400D5B2 RID: 54706
		private Table __p;
	}
}
