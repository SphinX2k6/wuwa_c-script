using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B98 RID: 19352
	public struct ICompareEntitySelfStateCondition : IFlatbufferObject
	{
		// Token: 0x17008C6D RID: 35949
		// (get) Token: 0x0601E812 RID: 124946 RVA: 0x00444F8C File Offset: 0x0044318C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E813 RID: 124947 RVA: 0x00444F99 File Offset: 0x00443199
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E814 RID: 124948 RVA: 0x00444FA0 File Offset: 0x004431A0
		public static ICompareEntitySelfStateCondition GetRootAsICompareEntitySelfStateCondition(ByteBuffer _bb)
		{
			return ICompareEntitySelfStateCondition.GetRootAsICompareEntitySelfStateCondition(_bb, default(ICompareEntitySelfStateCondition));
		}

		// Token: 0x0601E815 RID: 124949 RVA: 0x00444FBC File Offset: 0x004431BC
		public static ICompareEntitySelfStateCondition GetRootAsICompareEntitySelfStateCondition(ByteBuffer _bb, ICompareEntitySelfStateCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E816 RID: 124950 RVA: 0x00444FD9 File Offset: 0x004431D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E817 RID: 124951 RVA: 0x00444FE8 File Offset: 0x004431E8
		public ICompareEntitySelfStateCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008C6E RID: 35950
		// (get) Token: 0x0601E818 RID: 124952 RVA: 0x00444FF8 File Offset: 0x004431F8
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

		// Token: 0x17008C6F RID: 35951
		// (get) Token: 0x0601E819 RID: 124953 RVA: 0x00445034 File Offset: 0x00443234
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

		// Token: 0x0601E81A RID: 124954 RVA: 0x0044506B File Offset: 0x0044326B
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601E81B RID: 124955 RVA: 0x0044507A File Offset: 0x0044327A
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17008C70 RID: 35952
		// (get) Token: 0x0601E81C RID: 124956 RVA: 0x00445088 File Offset: 0x00443288
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

		// Token: 0x0601E81D RID: 124957 RVA: 0x004450C4 File Offset: 0x004432C4
		public static Offset<ICompareEntitySelfStateCondition> CreateICompareEntitySelfStateCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, StringOffset StateOffset = default(StringOffset), ECompare Compare = ECompare.Eq)
		{
			builder.StartTable(3);
			ICompareEntitySelfStateCondition.AddState(builder, StateOffset);
			ICompareEntitySelfStateCondition.AddCompare(builder, Compare);
			ICompareEntitySelfStateCondition.AddType(builder, Type);
			return ICompareEntitySelfStateCondition.EndICompareEntitySelfStateCondition(builder);
		}

		// Token: 0x0601E81E RID: 124958 RVA: 0x004450E8 File Offset: 0x004432E8
		public static void StartICompareEntitySelfStateCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601E81F RID: 124959 RVA: 0x004450F1 File Offset: 0x004432F1
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E820 RID: 124960 RVA: 0x004450FC File Offset: 0x004432FC
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(1, stateOffset.Value, 0);
		}

		// Token: 0x0601E821 RID: 124961 RVA: 0x0044510C File Offset: 0x0044330C
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x0601E822 RID: 124962 RVA: 0x00445117 File Offset: 0x00443317
		public static Offset<ICompareEntitySelfStateCondition> EndICompareEntitySelfStateCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICompareEntitySelfStateCondition>(builder.EndTable());
		}

		// Token: 0x0601E823 RID: 124963 RVA: 0x00445124 File Offset: 0x00443324
		public ICompareEntitySelfStateConditionT UnPack()
		{
			ICompareEntitySelfStateConditionT compareEntitySelfStateConditionT = new ICompareEntitySelfStateConditionT();
			this.UnPackTo(compareEntitySelfStateConditionT);
			return compareEntitySelfStateConditionT;
		}

		// Token: 0x0601E824 RID: 124964 RVA: 0x0044513F File Offset: 0x0044333F
		public void UnPackTo(ICompareEntitySelfStateConditionT _o)
		{
			_o.Type = this.Type;
			_o.State = this.State;
			_o.Compare = this.Compare;
		}

		// Token: 0x0601E825 RID: 124965 RVA: 0x00445168 File Offset: 0x00443368
		public static Offset<ICompareEntitySelfStateCondition> Pack(FlatBufferBuilder builder, ICompareEntitySelfStateConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompareEntitySelfStateCondition>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return ICompareEntitySelfStateCondition.CreateICompareEntitySelfStateCondition(builder, _o.Type, stateOffset, _o.Compare);
		}

		// Token: 0x0400D470 RID: 54384
		private Table __p;
	}
}
