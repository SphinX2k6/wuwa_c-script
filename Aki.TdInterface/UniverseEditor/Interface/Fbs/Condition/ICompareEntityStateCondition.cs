using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B9B RID: 19355
	public struct ICompareEntityStateCondition : IFlatbufferObject
	{
		// Token: 0x17008C74 RID: 35956
		// (get) Token: 0x0601E82E RID: 124974 RVA: 0x00445242 File Offset: 0x00443442
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E82F RID: 124975 RVA: 0x0044524F File Offset: 0x0044344F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E830 RID: 124976 RVA: 0x00445258 File Offset: 0x00443458
		public static ICompareEntityStateCondition GetRootAsICompareEntityStateCondition(ByteBuffer _bb)
		{
			return ICompareEntityStateCondition.GetRootAsICompareEntityStateCondition(_bb, default(ICompareEntityStateCondition));
		}

		// Token: 0x0601E831 RID: 124977 RVA: 0x00445274 File Offset: 0x00443474
		public static ICompareEntityStateCondition GetRootAsICompareEntityStateCondition(ByteBuffer _bb, ICompareEntityStateCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E832 RID: 124978 RVA: 0x00445291 File Offset: 0x00443491
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E833 RID: 124979 RVA: 0x004452A0 File Offset: 0x004434A0
		public ICompareEntityStateCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008C75 RID: 35957
		// (get) Token: 0x0601E834 RID: 124980 RVA: 0x004452B0 File Offset: 0x004434B0
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

		// Token: 0x17008C76 RID: 35958
		// (get) Token: 0x0601E835 RID: 124981 RVA: 0x004452EC File Offset: 0x004434EC
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

		// Token: 0x17008C77 RID: 35959
		// (get) Token: 0x0601E836 RID: 124982 RVA: 0x00445328 File Offset: 0x00443528
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

		// Token: 0x17008C78 RID: 35960
		// (get) Token: 0x0601E837 RID: 124983 RVA: 0x00445364 File Offset: 0x00443564
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

		// Token: 0x0601E838 RID: 124984 RVA: 0x0044539C File Offset: 0x0044359C
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0601E839 RID: 124985 RVA: 0x004453AC File Offset: 0x004435AC
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x0601E83A RID: 124986 RVA: 0x004453BB File Offset: 0x004435BB
		public static Offset<ICompareEntityStateCondition> CreateICompareEntityStateCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int EntityId = 0, ECompare Compare = ECompare.Eq, StringOffset StateOffset = default(StringOffset))
		{
			builder.StartTable(4);
			ICompareEntityStateCondition.AddState(builder, StateOffset);
			ICompareEntityStateCondition.AddEntityId(builder, EntityId);
			ICompareEntityStateCondition.AddCompare(builder, Compare);
			ICompareEntityStateCondition.AddType(builder, Type);
			return ICompareEntityStateCondition.EndICompareEntityStateCondition(builder);
		}

		// Token: 0x0601E83B RID: 124987 RVA: 0x004453E7 File Offset: 0x004435E7
		public static void StartICompareEntityStateCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601E83C RID: 124988 RVA: 0x004453F0 File Offset: 0x004435F0
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E83D RID: 124989 RVA: 0x004453FB File Offset: 0x004435FB
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0601E83E RID: 124990 RVA: 0x00445406 File Offset: 0x00443606
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x0601E83F RID: 124991 RVA: 0x00445411 File Offset: 0x00443611
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(3, stateOffset.Value, 0);
		}

		// Token: 0x0601E840 RID: 124992 RVA: 0x00445421 File Offset: 0x00443621
		public static Offset<ICompareEntityStateCondition> EndICompareEntityStateCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICompareEntityStateCondition>(builder.EndTable());
		}

		// Token: 0x0601E841 RID: 124993 RVA: 0x00445430 File Offset: 0x00443630
		public ICompareEntityStateConditionT UnPack()
		{
			ICompareEntityStateConditionT compareEntityStateConditionT = new ICompareEntityStateConditionT();
			this.UnPackTo(compareEntityStateConditionT);
			return compareEntityStateConditionT;
		}

		// Token: 0x0601E842 RID: 124994 RVA: 0x0044544B File Offset: 0x0044364B
		public void UnPackTo(ICompareEntityStateConditionT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.Compare = this.Compare;
			_o.State = this.State;
		}

		// Token: 0x0601E843 RID: 124995 RVA: 0x00445480 File Offset: 0x00443680
		public static Offset<ICompareEntityStateCondition> Pack(FlatBufferBuilder builder, ICompareEntityStateConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompareEntityStateCondition>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return ICompareEntityStateCondition.CreateICompareEntityStateCondition(builder, _o.Type, _o.EntityId, _o.Compare, stateOffset);
		}

		// Token: 0x0400D474 RID: 54388
		private Table __p;
	}
}
