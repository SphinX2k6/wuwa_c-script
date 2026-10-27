using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D28 RID: 15656
	public struct IAwakeAndLoadEntityCondition : IFlatbufferObject
	{
		// Token: 0x17006B5D RID: 27485
		// (get) Token: 0x060159AF RID: 88495 RVA: 0x0031E782 File Offset: 0x0031C982
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060159B0 RID: 88496 RVA: 0x0031E78F File Offset: 0x0031C98F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060159B1 RID: 88497 RVA: 0x0031E798 File Offset: 0x0031C998
		public static IAwakeAndLoadEntityCondition GetRootAsIAwakeAndLoadEntityCondition(ByteBuffer _bb)
		{
			return IAwakeAndLoadEntityCondition.GetRootAsIAwakeAndLoadEntityCondition(_bb, default(IAwakeAndLoadEntityCondition));
		}

		// Token: 0x060159B2 RID: 88498 RVA: 0x0031E7B4 File Offset: 0x0031C9B4
		public static IAwakeAndLoadEntityCondition GetRootAsIAwakeAndLoadEntityCondition(ByteBuffer _bb, IAwakeAndLoadEntityCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060159B3 RID: 88499 RVA: 0x0031E7D1 File Offset: 0x0031C9D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060159B4 RID: 88500 RVA: 0x0031E7E0 File Offset: 0x0031C9E0
		public IAwakeAndLoadEntityCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006B5E RID: 27486
		// (get) Token: 0x060159B5 RID: 88501 RVA: 0x0031E7F0 File Offset: 0x0031C9F0
		public EChildQuest Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EChildQuest.DoInteract;
				}
				return (EChildQuest)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006B5F RID: 27487
		// (get) Token: 0x060159B6 RID: 88502 RVA: 0x0031E82C File Offset: 0x0031CA2C
		public IConditionGroup? PreConditions
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060159B7 RID: 88503 RVA: 0x0031E88C File Offset: 0x0031CA8C
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17006B60 RID: 27488
		// (get) Token: 0x060159B8 RID: 88504 RVA: 0x0031E8CC File Offset: 0x0031CACC
		public int EntityIdsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060159B9 RID: 88505 RVA: 0x0031E8F7 File Offset: 0x0031CAF7
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x060159BA RID: 88506 RVA: 0x0031E906 File Offset: 0x0031CB06
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x17006B61 RID: 27489
		// (get) Token: 0x060159BB RID: 88507 RVA: 0x0031E914 File Offset: 0x0031CB14
		public bool IsWaitForShow
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006B62 RID: 27490
		// (get) Token: 0x060159BC RID: 88508 RVA: 0x0031E954 File Offset: 0x0031CB54
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

		// Token: 0x060159BD RID: 88509 RVA: 0x0031E991 File Offset: 0x0031CB91
		public static Offset<IAwakeAndLoadEntityCondition> CreateIAwakeAndLoadEntityCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), VectorOffset EntityIdsOffset = default(VectorOffset), bool IsWaitForShow = false, byte NullMask = 0)
		{
			builder.StartTable(5);
			IAwakeAndLoadEntityCondition.AddEntityIds(builder, EntityIdsOffset);
			IAwakeAndLoadEntityCondition.AddPreConditions(builder, PreConditionsOffset);
			IAwakeAndLoadEntityCondition.AddNullMask(builder, NullMask);
			IAwakeAndLoadEntityCondition.AddIsWaitForShow(builder, IsWaitForShow);
			IAwakeAndLoadEntityCondition.AddType(builder, Type);
			return IAwakeAndLoadEntityCondition.EndIAwakeAndLoadEntityCondition(builder);
		}

		// Token: 0x060159BE RID: 88510 RVA: 0x0031E9C5 File Offset: 0x0031CBC5
		public static void StartIAwakeAndLoadEntityCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060159BF RID: 88511 RVA: 0x0031E9CE File Offset: 0x0031CBCE
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060159C0 RID: 88512 RVA: 0x0031E9D9 File Offset: 0x0031CBD9
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x060159C1 RID: 88513 RVA: 0x0031E9E9 File Offset: 0x0031CBE9
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(2, entityIdsOffset.Value, 0);
		}

		// Token: 0x060159C2 RID: 88514 RVA: 0x0031E9FC File Offset: 0x0031CBFC
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060159C3 RID: 88515 RVA: 0x0031EA33 File Offset: 0x0031CC33
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060159C4 RID: 88516 RVA: 0x0031EA4D File Offset: 0x0031CC4D
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060159C5 RID: 88517 RVA: 0x0031EA6B File Offset: 0x0031CC6B
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060159C6 RID: 88518 RVA: 0x0031EA84 File Offset: 0x0031CC84
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060159C7 RID: 88519 RVA: 0x0031EA8F File Offset: 0x0031CC8F
		public static void AddIsWaitForShow(FlatBufferBuilder builder, bool isWaitForShow)
		{
			builder.AddBool(3, isWaitForShow, false);
		}

		// Token: 0x060159C8 RID: 88520 RVA: 0x0031EA9A File Offset: 0x0031CC9A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060159C9 RID: 88521 RVA: 0x0031EAA5 File Offset: 0x0031CCA5
		public static Offset<IAwakeAndLoadEntityCondition> EndIAwakeAndLoadEntityCondition(FlatBufferBuilder builder)
		{
			return new Offset<IAwakeAndLoadEntityCondition>(builder.EndTable());
		}

		// Token: 0x060159CA RID: 88522 RVA: 0x0031EAB4 File Offset: 0x0031CCB4
		public IAwakeAndLoadEntityConditionT UnPack()
		{
			IAwakeAndLoadEntityConditionT awakeAndLoadEntityConditionT = new IAwakeAndLoadEntityConditionT();
			this.UnPackTo(awakeAndLoadEntityConditionT);
			return awakeAndLoadEntityConditionT;
		}

		// Token: 0x060159CB RID: 88523 RVA: 0x0031EAD0 File Offset: 0x0031CCD0
		public void UnPackTo(IAwakeAndLoadEntityConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
			_o.IsWaitForShow = this.IsWaitForShow;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060159CC RID: 88524 RVA: 0x0031EB60 File Offset: 0x0031CD60
		public static Offset<IAwakeAndLoadEntityCondition> Pack(FlatBufferBuilder builder, IAwakeAndLoadEntityConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAwakeAndLoadEntityCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IAwakeAndLoadEntityCondition.CreateEntityIdsVector(builder, data);
			}
			return IAwakeAndLoadEntityCondition.CreateIAwakeAndLoadEntityCondition(builder, _o.Type, preConditionsOffset, entityIdsOffset, _o.IsWaitForShow, _o.NullMask);
		}

		// Token: 0x0400B5E1 RID: 46561
		private Table __p;
	}
}
