using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FF6 RID: 24566
	public struct ISuccessConditionSameSpecificState : IFlatbufferObject
	{
		// Token: 0x1700B61F RID: 46623
		// (get) Token: 0x0602963A RID: 169530 RVA: 0x005A6391 File Offset: 0x005A4591
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602963B RID: 169531 RVA: 0x005A639E File Offset: 0x005A459E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602963C RID: 169532 RVA: 0x005A63A8 File Offset: 0x005A45A8
		public static ISuccessConditionSameSpecificState GetRootAsISuccessConditionSameSpecificState(ByteBuffer _bb)
		{
			return ISuccessConditionSameSpecificState.GetRootAsISuccessConditionSameSpecificState(_bb, default(ISuccessConditionSameSpecificState));
		}

		// Token: 0x0602963D RID: 169533 RVA: 0x005A63C4 File Offset: 0x005A45C4
		public static ISuccessConditionSameSpecificState GetRootAsISuccessConditionSameSpecificState(ByteBuffer _bb, ISuccessConditionSameSpecificState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602963E RID: 169534 RVA: 0x005A63E1 File Offset: 0x005A45E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602963F RID: 169535 RVA: 0x005A63F0 File Offset: 0x005A45F0
		public ISuccessConditionSameSpecificState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B620 RID: 46624
		// (get) Token: 0x06029640 RID: 169536 RVA: 0x005A6400 File Offset: 0x005A4600
		public ETargetGearGroupSuccessCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETargetGearGroupSuccessCondition.SameSpecificState;
				}
				return (ETargetGearGroupSuccessCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B621 RID: 46625
		// (get) Token: 0x06029641 RID: 169537 RVA: 0x005A643C File Offset: 0x005A463C
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

		// Token: 0x06029642 RID: 169538 RVA: 0x005A6473 File Offset: 0x005A4673
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06029643 RID: 169539 RVA: 0x005A6482 File Offset: 0x005A4682
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06029644 RID: 169540 RVA: 0x005A6490 File Offset: 0x005A4690
		public static Offset<ISuccessConditionSameSpecificState> CreateISuccessConditionSameSpecificState(FlatBufferBuilder builder, ETargetGearGroupSuccessCondition Type = ETargetGearGroupSuccessCondition.SameSpecificState, StringOffset StateOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ISuccessConditionSameSpecificState.AddState(builder, StateOffset);
			ISuccessConditionSameSpecificState.AddType(builder, Type);
			return ISuccessConditionSameSpecificState.EndISuccessConditionSameSpecificState(builder);
		}

		// Token: 0x06029645 RID: 169541 RVA: 0x005A64AD File Offset: 0x005A46AD
		public static void StartISuccessConditionSameSpecificState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06029646 RID: 169542 RVA: 0x005A64B6 File Offset: 0x005A46B6
		public static void AddType(FlatBufferBuilder builder, ETargetGearGroupSuccessCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029647 RID: 169543 RVA: 0x005A64C1 File Offset: 0x005A46C1
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(1, stateOffset.Value, 0);
		}

		// Token: 0x06029648 RID: 169544 RVA: 0x005A64D1 File Offset: 0x005A46D1
		public static Offset<ISuccessConditionSameSpecificState> EndISuccessConditionSameSpecificState(FlatBufferBuilder builder)
		{
			return new Offset<ISuccessConditionSameSpecificState>(builder.EndTable());
		}

		// Token: 0x06029649 RID: 169545 RVA: 0x005A64E0 File Offset: 0x005A46E0
		public ISuccessConditionSameSpecificStateT UnPack()
		{
			ISuccessConditionSameSpecificStateT successConditionSameSpecificStateT = new ISuccessConditionSameSpecificStateT();
			this.UnPackTo(successConditionSameSpecificStateT);
			return successConditionSameSpecificStateT;
		}

		// Token: 0x0602964A RID: 169546 RVA: 0x005A64FB File Offset: 0x005A46FB
		public void UnPackTo(ISuccessConditionSameSpecificStateT _o)
		{
			_o.Type = this.Type;
			_o.State = this.State;
		}

		// Token: 0x0602964B RID: 169547 RVA: 0x005A6518 File Offset: 0x005A4718
		public static Offset<ISuccessConditionSameSpecificState> Pack(FlatBufferBuilder builder, ISuccessConditionSameSpecificStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISuccessConditionSameSpecificState>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return ISuccessConditionSameSpecificState.CreateISuccessConditionSameSpecificState(builder, _o.Type, stateOffset);
		}

		// Token: 0x0400FD17 RID: 64791
		private Table __p;
	}
}
