using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050A3 RID: 20643
	public struct ICompareNpcPerformStateCondition : IFlatbufferObject
	{
		// Token: 0x170093D5 RID: 37845
		// (get) Token: 0x060204E4 RID: 132324 RVA: 0x0047980D File Offset: 0x00477A0D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060204E5 RID: 132325 RVA: 0x0047981A File Offset: 0x00477A1A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060204E6 RID: 132326 RVA: 0x00479824 File Offset: 0x00477A24
		public static ICompareNpcPerformStateCondition GetRootAsICompareNpcPerformStateCondition(ByteBuffer _bb)
		{
			return ICompareNpcPerformStateCondition.GetRootAsICompareNpcPerformStateCondition(_bb, default(ICompareNpcPerformStateCondition));
		}

		// Token: 0x060204E7 RID: 132327 RVA: 0x00479840 File Offset: 0x00477A40
		public static ICompareNpcPerformStateCondition GetRootAsICompareNpcPerformStateCondition(ByteBuffer _bb, ICompareNpcPerformStateCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060204E8 RID: 132328 RVA: 0x0047985D File Offset: 0x00477A5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060204E9 RID: 132329 RVA: 0x0047986C File Offset: 0x00477A6C
		public ICompareNpcPerformStateCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170093D6 RID: 37846
		// (get) Token: 0x060204EA RID: 132330 RVA: 0x0047987C File Offset: 0x00477A7C
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170093D7 RID: 37847
		// (get) Token: 0x060204EB RID: 132331 RVA: 0x004798B8 File Offset: 0x00477AB8
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

		// Token: 0x170093D8 RID: 37848
		// (get) Token: 0x060204EC RID: 132332 RVA: 0x004798F4 File Offset: 0x00477AF4
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170093D9 RID: 37849
		// (get) Token: 0x060204ED RID: 132333 RVA: 0x00479930 File Offset: 0x00477B30
		public string State
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060204EE RID: 132334 RVA: 0x00479968 File Offset: 0x00477B68
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060204EF RID: 132335 RVA: 0x00479978 File Offset: 0x00477B78
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x060204F0 RID: 132336 RVA: 0x00479987 File Offset: 0x00477B87
		public static Offset<ICompareNpcPerformStateCondition> CreateICompareNpcPerformStateCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int EntityId = 0, ECompare Compare = ECompare.Eq, StringOffset StateOffset = default(StringOffset))
		{
			builder.StartTable(4);
			ICompareNpcPerformStateCondition.AddState(builder, StateOffset);
			ICompareNpcPerformStateCondition.AddEntityId(builder, EntityId);
			ICompareNpcPerformStateCondition.AddCompare(builder, Compare);
			ICompareNpcPerformStateCondition.AddType(builder, Type);
			return ICompareNpcPerformStateCondition.EndICompareNpcPerformStateCondition(builder);
		}

		// Token: 0x060204F1 RID: 132337 RVA: 0x004799B3 File Offset: 0x00477BB3
		public static void StartICompareNpcPerformStateCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060204F2 RID: 132338 RVA: 0x004799BC File Offset: 0x00477BBC
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060204F3 RID: 132339 RVA: 0x004799C7 File Offset: 0x00477BC7
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x060204F4 RID: 132340 RVA: 0x004799D2 File Offset: 0x00477BD2
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x060204F5 RID: 132341 RVA: 0x004799DD File Offset: 0x00477BDD
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(3, stateOffset.Value, 0);
		}

		// Token: 0x060204F6 RID: 132342 RVA: 0x004799ED File Offset: 0x00477BED
		public static Offset<ICompareNpcPerformStateCondition> EndICompareNpcPerformStateCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICompareNpcPerformStateCondition>(builder.EndTable());
		}

		// Token: 0x060204F7 RID: 132343 RVA: 0x004799FC File Offset: 0x00477BFC
		public ICompareNpcPerformStateConditionT UnPack()
		{
			ICompareNpcPerformStateConditionT compareNpcPerformStateConditionT = new ICompareNpcPerformStateConditionT();
			this.UnPackTo(compareNpcPerformStateConditionT);
			return compareNpcPerformStateConditionT;
		}

		// Token: 0x060204F8 RID: 132344 RVA: 0x00479A17 File Offset: 0x00477C17
		public void UnPackTo(ICompareNpcPerformStateConditionT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.Compare = this.Compare;
			_o.State = this.State;
		}

		// Token: 0x060204F9 RID: 132345 RVA: 0x00479A4C File Offset: 0x00477C4C
		public static Offset<ICompareNpcPerformStateCondition> Pack(FlatBufferBuilder builder, ICompareNpcPerformStateConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompareNpcPerformStateCondition>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return ICompareNpcPerformStateCondition.CreateICompareNpcPerformStateCondition(builder, _o.Type, _o.EntityId, _o.Compare, stateOffset);
		}

		// Token: 0x0400DFA2 RID: 57250
		private Table __p;
	}
}
