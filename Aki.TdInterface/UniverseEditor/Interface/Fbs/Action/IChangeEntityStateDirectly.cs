using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006961 RID: 26977
	public struct IChangeEntityStateDirectly : IFlatbufferObject
	{
		// Token: 0x1700C690 RID: 50832
		// (get) Token: 0x0602E3EC RID: 189420 RVA: 0x00650BE6 File Offset: 0x0064EDE6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E3ED RID: 189421 RVA: 0x00650BF3 File Offset: 0x0064EDF3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E3EE RID: 189422 RVA: 0x00650BFC File Offset: 0x0064EDFC
		public static IChangeEntityStateDirectly GetRootAsIChangeEntityStateDirectly(ByteBuffer _bb)
		{
			return IChangeEntityStateDirectly.GetRootAsIChangeEntityStateDirectly(_bb, default(IChangeEntityStateDirectly));
		}

		// Token: 0x0602E3EF RID: 189423 RVA: 0x00650C18 File Offset: 0x0064EE18
		public static IChangeEntityStateDirectly GetRootAsIChangeEntityStateDirectly(ByteBuffer _bb, IChangeEntityStateDirectly obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E3F0 RID: 189424 RVA: 0x00650C35 File Offset: 0x0064EE35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E3F1 RID: 189425 RVA: 0x00650C44 File Offset: 0x0064EE44
		public IChangeEntityStateDirectly __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C691 RID: 50833
		// (get) Token: 0x0602E3F2 RID: 189426 RVA: 0x00650C54 File Offset: 0x0064EE54
		public EChangeEntityState Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EChangeEntityState.Directly;
				}
				return (EChangeEntityState)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C692 RID: 50834
		// (get) Token: 0x0602E3F3 RID: 189427 RVA: 0x00650C90 File Offset: 0x0064EE90
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

		// Token: 0x1700C693 RID: 50835
		// (get) Token: 0x0602E3F4 RID: 189428 RVA: 0x00650CCC File Offset: 0x0064EECC
		public string State
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E3F5 RID: 189429 RVA: 0x00650D03 File Offset: 0x0064EF03
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602E3F6 RID: 189430 RVA: 0x00650D12 File Offset: 0x0064EF12
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700C694 RID: 50836
		// (get) Token: 0x0602E3F7 RID: 189431 RVA: 0x00650D20 File Offset: 0x0064EF20
		public bool DelayChange
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C695 RID: 50837
		// (get) Token: 0x0602E3F8 RID: 189432 RVA: 0x00650D60 File Offset: 0x0064EF60
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E3F9 RID: 189433 RVA: 0x00650D9D File Offset: 0x0064EF9D
		public static Offset<IChangeEntityStateDirectly> CreateIChangeEntityStateDirectly(FlatBufferBuilder builder, EChangeEntityState Type = EChangeEntityState.Directly, int EntityId = 0, StringOffset StateOffset = default(StringOffset), bool DelayChange = false, byte NullMask = 0)
		{
			builder.StartTable(5);
			IChangeEntityStateDirectly.AddState(builder, StateOffset);
			IChangeEntityStateDirectly.AddEntityId(builder, EntityId);
			IChangeEntityStateDirectly.AddNullMask(builder, NullMask);
			IChangeEntityStateDirectly.AddDelayChange(builder, DelayChange);
			IChangeEntityStateDirectly.AddType(builder, Type);
			return IChangeEntityStateDirectly.EndIChangeEntityStateDirectly(builder);
		}

		// Token: 0x0602E3FA RID: 189434 RVA: 0x00650DD1 File Offset: 0x0064EFD1
		public static void StartIChangeEntityStateDirectly(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602E3FB RID: 189435 RVA: 0x00650DDA File Offset: 0x0064EFDA
		public static void AddType(FlatBufferBuilder builder, EChangeEntityState type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E3FC RID: 189436 RVA: 0x00650DE5 File Offset: 0x0064EFE5
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0602E3FD RID: 189437 RVA: 0x00650DF0 File Offset: 0x0064EFF0
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(2, stateOffset.Value, 0);
		}

		// Token: 0x0602E3FE RID: 189438 RVA: 0x00650E00 File Offset: 0x0064F000
		public static void AddDelayChange(FlatBufferBuilder builder, bool delayChange)
		{
			builder.AddBool(3, delayChange, false);
		}

		// Token: 0x0602E3FF RID: 189439 RVA: 0x00650E0B File Offset: 0x0064F00B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602E400 RID: 189440 RVA: 0x00650E16 File Offset: 0x0064F016
		public static Offset<IChangeEntityStateDirectly> EndIChangeEntityStateDirectly(FlatBufferBuilder builder)
		{
			return new Offset<IChangeEntityStateDirectly>(builder.EndTable());
		}

		// Token: 0x0602E401 RID: 189441 RVA: 0x00650E24 File Offset: 0x0064F024
		public IChangeEntityStateDirectlyT UnPack()
		{
			IChangeEntityStateDirectlyT changeEntityStateDirectlyT = new IChangeEntityStateDirectlyT();
			this.UnPackTo(changeEntityStateDirectlyT);
			return changeEntityStateDirectlyT;
		}

		// Token: 0x0602E402 RID: 189442 RVA: 0x00650E3F File Offset: 0x0064F03F
		public void UnPackTo(IChangeEntityStateDirectlyT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.State = this.State;
			_o.DelayChange = this.DelayChange;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602E403 RID: 189443 RVA: 0x00650E80 File Offset: 0x0064F080
		public static Offset<IChangeEntityStateDirectly> Pack(FlatBufferBuilder builder, IChangeEntityStateDirectlyT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeEntityStateDirectly>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return IChangeEntityStateDirectly.CreateIChangeEntityStateDirectly(builder, _o.Type, _o.EntityId, stateOffset, _o.DelayChange, _o.NullMask);
		}

		// Token: 0x040116B7 RID: 71351
		private Table __p;
	}
}
