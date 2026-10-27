using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CFD RID: 19709
	public struct ITrafficMatchTargetByEntityLogic : IFlatbufferObject
	{
		// Token: 0x17008F01 RID: 36609
		// (get) Token: 0x0601F484 RID: 128132 RVA: 0x0045D404 File Offset: 0x0045B604
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F485 RID: 128133 RVA: 0x0045D411 File Offset: 0x0045B611
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F486 RID: 128134 RVA: 0x0045D418 File Offset: 0x0045B618
		public static ITrafficMatchTargetByEntityLogic GetRootAsITrafficMatchTargetByEntityLogic(ByteBuffer _bb)
		{
			return ITrafficMatchTargetByEntityLogic.GetRootAsITrafficMatchTargetByEntityLogic(_bb, default(ITrafficMatchTargetByEntityLogic));
		}

		// Token: 0x0601F487 RID: 128135 RVA: 0x0045D434 File Offset: 0x0045B634
		public static ITrafficMatchTargetByEntityLogic GetRootAsITrafficMatchTargetByEntityLogic(ByteBuffer _bb, ITrafficMatchTargetByEntityLogic obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F488 RID: 128136 RVA: 0x0045D451 File Offset: 0x0045B651
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F489 RID: 128137 RVA: 0x0045D460 File Offset: 0x0045B660
		public ITrafficMatchTargetByEntityLogic __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008F02 RID: 36610
		// (get) Token: 0x0601F48A RID: 128138 RVA: 0x0045D470 File Offset: 0x0045B670
		public ETrafficMatchTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETrafficMatchTargetType.MatchByEntityLogic;
				}
				return (ETrafficMatchTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F48B RID: 128139 RVA: 0x0045D4AC File Offset: 0x0045B6AC
		public EEntityLogic EntityLogicTypes(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return EEntityLogic.Item;
			}
			return (EEntityLogic)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17008F03 RID: 36611
		// (get) Token: 0x0601F48C RID: 128140 RVA: 0x0045D4EC File Offset: 0x0045B6EC
		public int EntityLogicTypesLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601F48D RID: 128141 RVA: 0x0045D517 File Offset: 0x0045B717
		public Span<EEntityLogic> GetEntityLogicTypesBytes()
		{
			return this.__p.__vector_as_span<EEntityLogic>(6, 1);
		}

		// Token: 0x0601F48E RID: 128142 RVA: 0x0045D528 File Offset: 0x0045B728
		public EEntityLogic[] GetEntityLogicTypesArray()
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			EEntityLogic[] array = new EEntityLogic[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (EEntityLogic)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x0601F48F RID: 128143 RVA: 0x0045D591 File Offset: 0x0045B791
		public static Offset<ITrafficMatchTargetByEntityLogic> CreateITrafficMatchTargetByEntityLogic(FlatBufferBuilder builder, ETrafficMatchTargetType Type = ETrafficMatchTargetType.MatchByEntityLogic, VectorOffset EntityLogicTypesOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ITrafficMatchTargetByEntityLogic.AddEntityLogicTypes(builder, EntityLogicTypesOffset);
			ITrafficMatchTargetByEntityLogic.AddType(builder, Type);
			return ITrafficMatchTargetByEntityLogic.EndITrafficMatchTargetByEntityLogic(builder);
		}

		// Token: 0x0601F490 RID: 128144 RVA: 0x0045D5AE File Offset: 0x0045B7AE
		public static void StartITrafficMatchTargetByEntityLogic(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601F491 RID: 128145 RVA: 0x0045D5B7 File Offset: 0x0045B7B7
		public static void AddType(FlatBufferBuilder builder, ETrafficMatchTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F492 RID: 128146 RVA: 0x0045D5C2 File Offset: 0x0045B7C2
		public static void AddEntityLogicTypes(FlatBufferBuilder builder, VectorOffset entityLogicTypesOffset)
		{
			builder.AddOffset(1, entityLogicTypesOffset.Value, 0);
		}

		// Token: 0x0601F493 RID: 128147 RVA: 0x0045D5D4 File Offset: 0x0045B7D4
		public static VectorOffset CreateEntityLogicTypesVector(FlatBufferBuilder builder, EEntityLogic[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601F494 RID: 128148 RVA: 0x0045D60B File Offset: 0x0045B80B
		public static VectorOffset CreateEntityLogicTypesVectorBlock(FlatBufferBuilder builder, EEntityLogic[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<EEntityLogic>(data);
			return builder.EndVector();
		}

		// Token: 0x0601F495 RID: 128149 RVA: 0x0045D625 File Offset: 0x0045B825
		public static VectorOffset CreateEntityLogicTypesVectorBlock(FlatBufferBuilder builder, ArraySegment<EEntityLogic> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<EEntityLogic>(data);
			return builder.EndVector();
		}

		// Token: 0x0601F496 RID: 128150 RVA: 0x0045D643 File Offset: 0x0045B843
		public static VectorOffset CreateEntityLogicTypesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<EEntityLogic>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601F497 RID: 128151 RVA: 0x0045D65C File Offset: 0x0045B85C
		public static void StartEntityLogicTypesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601F498 RID: 128152 RVA: 0x0045D667 File Offset: 0x0045B867
		public static Offset<ITrafficMatchTargetByEntityLogic> EndITrafficMatchTargetByEntityLogic(FlatBufferBuilder builder)
		{
			return new Offset<ITrafficMatchTargetByEntityLogic>(builder.EndTable());
		}

		// Token: 0x0601F499 RID: 128153 RVA: 0x0045D674 File Offset: 0x0045B874
		public ITrafficMatchTargetByEntityLogicT UnPack()
		{
			ITrafficMatchTargetByEntityLogicT trafficMatchTargetByEntityLogicT = new ITrafficMatchTargetByEntityLogicT();
			this.UnPackTo(trafficMatchTargetByEntityLogicT);
			return trafficMatchTargetByEntityLogicT;
		}

		// Token: 0x0601F49A RID: 128154 RVA: 0x0045D690 File Offset: 0x0045B890
		public void UnPackTo(ITrafficMatchTargetByEntityLogicT _o)
		{
			_o.Type = this.Type;
			_o.EntityLogicTypes = new List<EEntityLogic>();
			for (int i = 0; i < this.EntityLogicTypesLength; i++)
			{
				_o.EntityLogicTypes.Add(this.EntityLogicTypes(i));
			}
		}

		// Token: 0x0601F49B RID: 128155 RVA: 0x0045D6D8 File Offset: 0x0045B8D8
		public static Offset<ITrafficMatchTargetByEntityLogic> Pack(FlatBufferBuilder builder, ITrafficMatchTargetByEntityLogicT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrafficMatchTargetByEntityLogic>);
			}
			VectorOffset entityLogicTypesOffset = default(VectorOffset);
			if (_o.EntityLogicTypes != null)
			{
				EEntityLogic[] data = _o.EntityLogicTypes.ToArray();
				entityLogicTypesOffset = ITrafficMatchTargetByEntityLogic.CreateEntityLogicTypesVector(builder, data);
			}
			return ITrafficMatchTargetByEntityLogic.CreateITrafficMatchTargetByEntityLogic(builder, _o.Type, entityLogicTypesOffset);
		}

		// Token: 0x0400D6D9 RID: 55001
		private Table __p;
	}
}
