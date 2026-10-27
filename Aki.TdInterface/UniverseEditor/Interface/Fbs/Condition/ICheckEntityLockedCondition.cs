using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A0C RID: 18956
	public struct ICheckEntityLockedCondition : IFlatbufferObject
	{
		// Token: 0x17008932 RID: 35122
		// (get) Token: 0x0601DA5C RID: 121436 RVA: 0x0042C100 File Offset: 0x0042A300
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DA5D RID: 121437 RVA: 0x0042C10D File Offset: 0x0042A30D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DA5E RID: 121438 RVA: 0x0042C114 File Offset: 0x0042A314
		public static ICheckEntityLockedCondition GetRootAsICheckEntityLockedCondition(ByteBuffer _bb)
		{
			return ICheckEntityLockedCondition.GetRootAsICheckEntityLockedCondition(_bb, default(ICheckEntityLockedCondition));
		}

		// Token: 0x0601DA5F RID: 121439 RVA: 0x0042C130 File Offset: 0x0042A330
		public static ICheckEntityLockedCondition GetRootAsICheckEntityLockedCondition(ByteBuffer _bb, ICheckEntityLockedCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DA60 RID: 121440 RVA: 0x0042C14D File Offset: 0x0042A34D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DA61 RID: 121441 RVA: 0x0042C15C File Offset: 0x0042A35C
		public ICheckEntityLockedCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008933 RID: 35123
		// (get) Token: 0x0601DA62 RID: 121442 RVA: 0x0042C16C File Offset: 0x0042A36C
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

		// Token: 0x0601DA63 RID: 121443 RVA: 0x0042C1A8 File Offset: 0x0042A3A8
		public int Entities(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008934 RID: 35124
		// (get) Token: 0x0601DA64 RID: 121444 RVA: 0x0042C1E8 File Offset: 0x0042A3E8
		public int EntitiesLength
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

		// Token: 0x0601DA65 RID: 121445 RVA: 0x0042C213 File Offset: 0x0042A413
		public Span<int> GetEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0601DA66 RID: 121446 RVA: 0x0042C222 File Offset: 0x0042A422
		public int[] GetEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x17008935 RID: 35125
		// (get) Token: 0x0601DA67 RID: 121447 RVA: 0x0042C230 File Offset: 0x0042A430
		public bool IsLocked
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601DA68 RID: 121448 RVA: 0x0042C26F File Offset: 0x0042A46F
		public static Offset<ICheckEntityLockedCondition> CreateICheckEntityLockedCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, VectorOffset EntitiesOffset = default(VectorOffset), bool IsLocked = false)
		{
			builder.StartTable(3);
			ICheckEntityLockedCondition.AddEntities(builder, EntitiesOffset);
			ICheckEntityLockedCondition.AddIsLocked(builder, IsLocked);
			ICheckEntityLockedCondition.AddType(builder, Type);
			return ICheckEntityLockedCondition.EndICheckEntityLockedCondition(builder);
		}

		// Token: 0x0601DA69 RID: 121449 RVA: 0x0042C293 File Offset: 0x0042A493
		public static void StartICheckEntityLockedCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601DA6A RID: 121450 RVA: 0x0042C29C File Offset: 0x0042A49C
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DA6B RID: 121451 RVA: 0x0042C2A7 File Offset: 0x0042A4A7
		public static void AddEntities(FlatBufferBuilder builder, VectorOffset entitiesOffset)
		{
			builder.AddOffset(1, entitiesOffset.Value, 0);
		}

		// Token: 0x0601DA6C RID: 121452 RVA: 0x0042C2B8 File Offset: 0x0042A4B8
		public static VectorOffset CreateEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601DA6D RID: 121453 RVA: 0x0042C2EF File Offset: 0x0042A4EF
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DA6E RID: 121454 RVA: 0x0042C309 File Offset: 0x0042A509
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DA6F RID: 121455 RVA: 0x0042C327 File Offset: 0x0042A527
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601DA70 RID: 121456 RVA: 0x0042C340 File Offset: 0x0042A540
		public static void StartEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601DA71 RID: 121457 RVA: 0x0042C34B File Offset: 0x0042A54B
		public static void AddIsLocked(FlatBufferBuilder builder, bool isLocked)
		{
			builder.AddBool(2, isLocked, false);
		}

		// Token: 0x0601DA72 RID: 121458 RVA: 0x0042C356 File Offset: 0x0042A556
		public static Offset<ICheckEntityLockedCondition> EndICheckEntityLockedCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckEntityLockedCondition>(builder.EndTable());
		}

		// Token: 0x0601DA73 RID: 121459 RVA: 0x0042C364 File Offset: 0x0042A564
		public ICheckEntityLockedConditionT UnPack()
		{
			ICheckEntityLockedConditionT checkEntityLockedConditionT = new ICheckEntityLockedConditionT();
			this.UnPackTo(checkEntityLockedConditionT);
			return checkEntityLockedConditionT;
		}

		// Token: 0x0601DA74 RID: 121460 RVA: 0x0042C380 File Offset: 0x0042A580
		public void UnPackTo(ICheckEntityLockedConditionT _o)
		{
			_o.Type = this.Type;
			_o.Entities = new List<int>();
			for (int i = 0; i < this.EntitiesLength; i++)
			{
				_o.Entities.Add(this.Entities(i));
			}
			_o.IsLocked = this.IsLocked;
		}

		// Token: 0x0601DA75 RID: 121461 RVA: 0x0042C3D4 File Offset: 0x0042A5D4
		public static Offset<ICheckEntityLockedCondition> Pack(FlatBufferBuilder builder, ICheckEntityLockedConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckEntityLockedCondition>);
			}
			VectorOffset entitiesOffset = default(VectorOffset);
			if (_o.Entities != null)
			{
				int[] data = _o.Entities.ToArray();
				entitiesOffset = ICheckEntityLockedCondition.CreateEntitiesVector(builder, data);
			}
			return ICheckEntityLockedCondition.CreateICheckEntityLockedCondition(builder, _o.Type, entitiesOffset, _o.IsLocked);
		}

		// Token: 0x0400D253 RID: 53843
		private Table __p;
	}
}
