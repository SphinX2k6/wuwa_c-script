using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005106 RID: 20742
	public struct IEntityStateCondition : IFlatbufferObject
	{
		// Token: 0x170094AA RID: 38058
		// (get) Token: 0x060209AB RID: 133547 RVA: 0x00485683 File Offset: 0x00483883
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060209AC RID: 133548 RVA: 0x00485690 File Offset: 0x00483890
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060209AD RID: 133549 RVA: 0x00485698 File Offset: 0x00483898
		public static IEntityStateCondition GetRootAsIEntityStateCondition(ByteBuffer _bb)
		{
			return IEntityStateCondition.GetRootAsIEntityStateCondition(_bb, default(IEntityStateCondition));
		}

		// Token: 0x060209AE RID: 133550 RVA: 0x004856B4 File Offset: 0x004838B4
		public static IEntityStateCondition GetRootAsIEntityStateCondition(ByteBuffer _bb, IEntityStateCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060209AF RID: 133551 RVA: 0x004856D1 File Offset: 0x004838D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060209B0 RID: 133552 RVA: 0x004856E0 File Offset: 0x004838E0
		public IEntityStateCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170094AB RID: 38059
		// (get) Token: 0x060209B1 RID: 133553 RVA: 0x004856F0 File Offset: 0x004838F0
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

		// Token: 0x170094AC RID: 38060
		// (get) Token: 0x060209B2 RID: 133554 RVA: 0x0048572C File Offset: 0x0048392C
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

		// Token: 0x060209B3 RID: 133555 RVA: 0x00485763 File Offset: 0x00483963
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060209B4 RID: 133556 RVA: 0x00485772 File Offset: 0x00483972
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060209B5 RID: 133557 RVA: 0x00485780 File Offset: 0x00483980
		public static Offset<IEntityStateCondition> CreateIEntityStateCondition(FlatBufferBuilder builder, int EntityId = 0, StringOffset StateOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IEntityStateCondition.AddState(builder, StateOffset);
			IEntityStateCondition.AddEntityId(builder, EntityId);
			return IEntityStateCondition.EndIEntityStateCondition(builder);
		}

		// Token: 0x060209B6 RID: 133558 RVA: 0x0048579D File Offset: 0x0048399D
		public static void StartIEntityStateCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060209B7 RID: 133559 RVA: 0x004857A6 File Offset: 0x004839A6
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x060209B8 RID: 133560 RVA: 0x004857B1 File Offset: 0x004839B1
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(1, stateOffset.Value, 0);
		}

		// Token: 0x060209B9 RID: 133561 RVA: 0x004857C1 File Offset: 0x004839C1
		public static Offset<IEntityStateCondition> EndIEntityStateCondition(FlatBufferBuilder builder)
		{
			return new Offset<IEntityStateCondition>(builder.EndTable());
		}

		// Token: 0x060209BA RID: 133562 RVA: 0x004857D0 File Offset: 0x004839D0
		public IEntityStateConditionT UnPack()
		{
			IEntityStateConditionT entityStateConditionT = new IEntityStateConditionT();
			this.UnPackTo(entityStateConditionT);
			return entityStateConditionT;
		}

		// Token: 0x060209BB RID: 133563 RVA: 0x004857EB File Offset: 0x004839EB
		public void UnPackTo(IEntityStateConditionT _o)
		{
			_o.EntityId = this.EntityId;
			_o.State = this.State;
		}

		// Token: 0x060209BC RID: 133564 RVA: 0x00485808 File Offset: 0x00483A08
		public static Offset<IEntityStateCondition> Pack(FlatBufferBuilder builder, IEntityStateConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityStateCondition>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return IEntityStateCondition.CreateIEntityStateCondition(builder, _o.EntityId, stateOffset);
		}

		// Token: 0x0400E0C9 RID: 57545
		private Table __p;
	}
}
