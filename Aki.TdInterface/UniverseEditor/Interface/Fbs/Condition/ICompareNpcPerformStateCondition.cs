using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BB9 RID: 19385
	public struct ICompareNpcPerformStateCondition : IFlatbufferObject
	{
		// Token: 0x17008CBC RID: 36028
		// (get) Token: 0x0601E938 RID: 125240 RVA: 0x00446CA9 File Offset: 0x00444EA9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E939 RID: 125241 RVA: 0x00446CB6 File Offset: 0x00444EB6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E93A RID: 125242 RVA: 0x00446CC0 File Offset: 0x00444EC0
		public static ICompareNpcPerformStateCondition GetRootAsICompareNpcPerformStateCondition(ByteBuffer _bb)
		{
			return ICompareNpcPerformStateCondition.GetRootAsICompareNpcPerformStateCondition(_bb, default(ICompareNpcPerformStateCondition));
		}

		// Token: 0x0601E93B RID: 125243 RVA: 0x00446CDC File Offset: 0x00444EDC
		public static ICompareNpcPerformStateCondition GetRootAsICompareNpcPerformStateCondition(ByteBuffer _bb, ICompareNpcPerformStateCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E93C RID: 125244 RVA: 0x00446CF9 File Offset: 0x00444EF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E93D RID: 125245 RVA: 0x00446D08 File Offset: 0x00444F08
		public ICompareNpcPerformStateCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008CBD RID: 36029
		// (get) Token: 0x0601E93E RID: 125246 RVA: 0x00446D18 File Offset: 0x00444F18
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

		// Token: 0x17008CBE RID: 36030
		// (get) Token: 0x0601E93F RID: 125247 RVA: 0x00446D54 File Offset: 0x00444F54
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

		// Token: 0x17008CBF RID: 36031
		// (get) Token: 0x0601E940 RID: 125248 RVA: 0x00446D90 File Offset: 0x00444F90
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

		// Token: 0x17008CC0 RID: 36032
		// (get) Token: 0x0601E941 RID: 125249 RVA: 0x00446DCC File Offset: 0x00444FCC
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

		// Token: 0x0601E942 RID: 125250 RVA: 0x00446E04 File Offset: 0x00445004
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0601E943 RID: 125251 RVA: 0x00446E14 File Offset: 0x00445014
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x0601E944 RID: 125252 RVA: 0x00446E23 File Offset: 0x00445023
		public static Offset<ICompareNpcPerformStateCondition> CreateICompareNpcPerformStateCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int EntityId = 0, ECompare Compare = ECompare.Eq, StringOffset StateOffset = default(StringOffset))
		{
			builder.StartTable(4);
			ICompareNpcPerformStateCondition.AddState(builder, StateOffset);
			ICompareNpcPerformStateCondition.AddEntityId(builder, EntityId);
			ICompareNpcPerformStateCondition.AddCompare(builder, Compare);
			ICompareNpcPerformStateCondition.AddType(builder, Type);
			return ICompareNpcPerformStateCondition.EndICompareNpcPerformStateCondition(builder);
		}

		// Token: 0x0601E945 RID: 125253 RVA: 0x00446E4F File Offset: 0x0044504F
		public static void StartICompareNpcPerformStateCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601E946 RID: 125254 RVA: 0x00446E58 File Offset: 0x00445058
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E947 RID: 125255 RVA: 0x00446E63 File Offset: 0x00445063
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0601E948 RID: 125256 RVA: 0x00446E6E File Offset: 0x0044506E
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x0601E949 RID: 125257 RVA: 0x00446E79 File Offset: 0x00445079
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(3, stateOffset.Value, 0);
		}

		// Token: 0x0601E94A RID: 125258 RVA: 0x00446E89 File Offset: 0x00445089
		public static Offset<ICompareNpcPerformStateCondition> EndICompareNpcPerformStateCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICompareNpcPerformStateCondition>(builder.EndTable());
		}

		// Token: 0x0601E94B RID: 125259 RVA: 0x00446E98 File Offset: 0x00445098
		public ICompareNpcPerformStateConditionT UnPack()
		{
			ICompareNpcPerformStateConditionT compareNpcPerformStateConditionT = new ICompareNpcPerformStateConditionT();
			this.UnPackTo(compareNpcPerformStateConditionT);
			return compareNpcPerformStateConditionT;
		}

		// Token: 0x0601E94C RID: 125260 RVA: 0x00446EB3 File Offset: 0x004450B3
		public void UnPackTo(ICompareNpcPerformStateConditionT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.Compare = this.Compare;
			_o.State = this.State;
		}

		// Token: 0x0601E94D RID: 125261 RVA: 0x00446EE8 File Offset: 0x004450E8
		public static Offset<ICompareNpcPerformStateCondition> Pack(FlatBufferBuilder builder, ICompareNpcPerformStateConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompareNpcPerformStateCondition>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return ICompareNpcPerformStateCondition.CreateICompareNpcPerformStateCondition(builder, _o.Type, _o.EntityId, _o.Compare, stateOffset);
		}

		// Token: 0x0400D49D RID: 54429
		private Table __p;
	}
}
