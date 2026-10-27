using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005398 RID: 21400
	public struct IHitLogicChangeNextAndLockTargetState : IFlatbufferObject
	{
		// Token: 0x17009D3E RID: 40254
		// (get) Token: 0x060230BA RID: 143546 RVA: 0x004DA3AD File Offset: 0x004D85AD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060230BB RID: 143547 RVA: 0x004DA3BA File Offset: 0x004D85BA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060230BC RID: 143548 RVA: 0x004DA3C4 File Offset: 0x004D85C4
		public static IHitLogicChangeNextAndLockTargetState GetRootAsIHitLogicChangeNextAndLockTargetState(ByteBuffer _bb)
		{
			return IHitLogicChangeNextAndLockTargetState.GetRootAsIHitLogicChangeNextAndLockTargetState(_bb, default(IHitLogicChangeNextAndLockTargetState));
		}

		// Token: 0x060230BD RID: 143549 RVA: 0x004DA3E0 File Offset: 0x004D85E0
		public static IHitLogicChangeNextAndLockTargetState GetRootAsIHitLogicChangeNextAndLockTargetState(ByteBuffer _bb, IHitLogicChangeNextAndLockTargetState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060230BE RID: 143550 RVA: 0x004DA3FD File Offset: 0x004D85FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060230BF RID: 143551 RVA: 0x004DA40C File Offset: 0x004D860C
		public IHitLogicChangeNextAndLockTargetState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009D3F RID: 40255
		// (get) Token: 0x060230C0 RID: 143552 RVA: 0x004DA41C File Offset: 0x004D861C
		public EHitLogicType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHitLogicType.ChangeNextState;
				}
				return (EHitLogicType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009D40 RID: 40256
		// (get) Token: 0x060230C1 RID: 143553 RVA: 0x004DA458 File Offset: 0x004D8658
		public string TargetState
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

		// Token: 0x060230C2 RID: 143554 RVA: 0x004DA48F File Offset: 0x004D868F
		public Span<byte> GetTargetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060230C3 RID: 143555 RVA: 0x004DA49E File Offset: 0x004D869E
		public byte[] GetTargetStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060230C4 RID: 143556 RVA: 0x004DA4AC File Offset: 0x004D86AC
		public static Offset<IHitLogicChangeNextAndLockTargetState> CreateIHitLogicChangeNextAndLockTargetState(FlatBufferBuilder builder, EHitLogicType Type = EHitLogicType.ChangeNextState, StringOffset TargetStateOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IHitLogicChangeNextAndLockTargetState.AddTargetState(builder, TargetStateOffset);
			IHitLogicChangeNextAndLockTargetState.AddType(builder, Type);
			return IHitLogicChangeNextAndLockTargetState.EndIHitLogicChangeNextAndLockTargetState(builder);
		}

		// Token: 0x060230C5 RID: 143557 RVA: 0x004DA4C9 File Offset: 0x004D86C9
		public static void StartIHitLogicChangeNextAndLockTargetState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060230C6 RID: 143558 RVA: 0x004DA4D2 File Offset: 0x004D86D2
		public static void AddType(FlatBufferBuilder builder, EHitLogicType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060230C7 RID: 143559 RVA: 0x004DA4DD File Offset: 0x004D86DD
		public static void AddTargetState(FlatBufferBuilder builder, StringOffset targetStateOffset)
		{
			builder.AddOffset(1, targetStateOffset.Value, 0);
		}

		// Token: 0x060230C8 RID: 143560 RVA: 0x004DA4ED File Offset: 0x004D86ED
		public static Offset<IHitLogicChangeNextAndLockTargetState> EndIHitLogicChangeNextAndLockTargetState(FlatBufferBuilder builder)
		{
			return new Offset<IHitLogicChangeNextAndLockTargetState>(builder.EndTable());
		}

		// Token: 0x060230C9 RID: 143561 RVA: 0x004DA4FC File Offset: 0x004D86FC
		public IHitLogicChangeNextAndLockTargetStateT UnPack()
		{
			IHitLogicChangeNextAndLockTargetStateT hitLogicChangeNextAndLockTargetStateT = new IHitLogicChangeNextAndLockTargetStateT();
			this.UnPackTo(hitLogicChangeNextAndLockTargetStateT);
			return hitLogicChangeNextAndLockTargetStateT;
		}

		// Token: 0x060230CA RID: 143562 RVA: 0x004DA517 File Offset: 0x004D8717
		public void UnPackTo(IHitLogicChangeNextAndLockTargetStateT _o)
		{
			_o.Type = this.Type;
			_o.TargetState = this.TargetState;
		}

		// Token: 0x060230CB RID: 143563 RVA: 0x004DA534 File Offset: 0x004D8734
		public static Offset<IHitLogicChangeNextAndLockTargetState> Pack(FlatBufferBuilder builder, IHitLogicChangeNextAndLockTargetStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHitLogicChangeNextAndLockTargetState>);
			}
			StringOffset targetStateOffset = (_o.TargetState == null) ? default(StringOffset) : builder.CreateString(_o.TargetState);
			return IHitLogicChangeNextAndLockTargetState.CreateIHitLogicChangeNextAndLockTargetState(builder, _o.Type, targetStateOffset);
		}

		// Token: 0x0400E582 RID: 58754
		private Table __p;
	}
}
