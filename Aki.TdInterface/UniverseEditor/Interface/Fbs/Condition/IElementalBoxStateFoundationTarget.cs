using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050EE RID: 20718
	public struct IElementalBoxStateFoundationTarget : IFlatbufferObject
	{
		// Token: 0x17009479 RID: 38009
		// (get) Token: 0x060208D9 RID: 133337 RVA: 0x004840E1 File Offset: 0x004822E1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060208DA RID: 133338 RVA: 0x004840EE File Offset: 0x004822EE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060208DB RID: 133339 RVA: 0x004840F8 File Offset: 0x004822F8
		public static IElementalBoxStateFoundationTarget GetRootAsIElementalBoxStateFoundationTarget(ByteBuffer _bb)
		{
			return IElementalBoxStateFoundationTarget.GetRootAsIElementalBoxStateFoundationTarget(_bb, default(IElementalBoxStateFoundationTarget));
		}

		// Token: 0x060208DC RID: 133340 RVA: 0x00484114 File Offset: 0x00482314
		public static IElementalBoxStateFoundationTarget GetRootAsIElementalBoxStateFoundationTarget(ByteBuffer _bb, IElementalBoxStateFoundationTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060208DD RID: 133341 RVA: 0x00484131 File Offset: 0x00482331
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060208DE RID: 133342 RVA: 0x00484140 File Offset: 0x00482340
		public IElementalBoxStateFoundationTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700947A RID: 38010
		// (get) Token: 0x060208DF RID: 133343 RVA: 0x00484150 File Offset: 0x00482350
		public EElementalBoxStateTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EElementalBoxStateTargetType.Player;
				}
				return (EElementalBoxStateTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700947B RID: 38011
		// (get) Token: 0x060208E0 RID: 133344 RVA: 0x0048418C File Offset: 0x0048238C
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

		// Token: 0x1700947C RID: 38012
		// (get) Token: 0x060208E1 RID: 133345 RVA: 0x004841C8 File Offset: 0x004823C8
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

		// Token: 0x060208E2 RID: 133346 RVA: 0x004841FF File Offset: 0x004823FF
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060208E3 RID: 133347 RVA: 0x0048420E File Offset: 0x0048240E
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x060208E4 RID: 133348 RVA: 0x0048421C File Offset: 0x0048241C
		public static Offset<IElementalBoxStateFoundationTarget> CreateIElementalBoxStateFoundationTarget(FlatBufferBuilder builder, EElementalBoxStateTargetType Type = EElementalBoxStateTargetType.Player, int EntityId = 0, StringOffset StateOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IElementalBoxStateFoundationTarget.AddState(builder, StateOffset);
			IElementalBoxStateFoundationTarget.AddEntityId(builder, EntityId);
			IElementalBoxStateFoundationTarget.AddType(builder, Type);
			return IElementalBoxStateFoundationTarget.EndIElementalBoxStateFoundationTarget(builder);
		}

		// Token: 0x060208E5 RID: 133349 RVA: 0x00484240 File Offset: 0x00482440
		public static void StartIElementalBoxStateFoundationTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060208E6 RID: 133350 RVA: 0x00484249 File Offset: 0x00482449
		public static void AddType(FlatBufferBuilder builder, EElementalBoxStateTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060208E7 RID: 133351 RVA: 0x00484254 File Offset: 0x00482454
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x060208E8 RID: 133352 RVA: 0x0048425F File Offset: 0x0048245F
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(2, stateOffset.Value, 0);
		}

		// Token: 0x060208E9 RID: 133353 RVA: 0x0048426F File Offset: 0x0048246F
		public static Offset<IElementalBoxStateFoundationTarget> EndIElementalBoxStateFoundationTarget(FlatBufferBuilder builder)
		{
			return new Offset<IElementalBoxStateFoundationTarget>(builder.EndTable());
		}

		// Token: 0x060208EA RID: 133354 RVA: 0x0048427C File Offset: 0x0048247C
		public IElementalBoxStateFoundationTargetT UnPack()
		{
			IElementalBoxStateFoundationTargetT elementalBoxStateFoundationTargetT = new IElementalBoxStateFoundationTargetT();
			this.UnPackTo(elementalBoxStateFoundationTargetT);
			return elementalBoxStateFoundationTargetT;
		}

		// Token: 0x060208EB RID: 133355 RVA: 0x00484297 File Offset: 0x00482497
		public void UnPackTo(IElementalBoxStateFoundationTargetT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.State = this.State;
		}

		// Token: 0x060208EC RID: 133356 RVA: 0x004842C0 File Offset: 0x004824C0
		public static Offset<IElementalBoxStateFoundationTarget> Pack(FlatBufferBuilder builder, IElementalBoxStateFoundationTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IElementalBoxStateFoundationTarget>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return IElementalBoxStateFoundationTarget.CreateIElementalBoxStateFoundationTarget(builder, _o.Type, _o.EntityId, stateOffset);
		}

		// Token: 0x0400E0A5 RID: 57509
		private Table __p;
	}
}
