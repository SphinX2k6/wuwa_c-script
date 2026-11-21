using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004ECC RID: 20172
	public struct ICheckEntityLockedCondition : IFlatbufferObject
	{
		// Token: 0x17009002 RID: 36866
		// (get) Token: 0x0601F4CF RID: 128207 RVA: 0x0045CD6C File Offset: 0x0045AF6C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F4D0 RID: 128208 RVA: 0x0045CD79 File Offset: 0x0045AF79
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F4D1 RID: 128209 RVA: 0x0045CD80 File Offset: 0x0045AF80
		public static ICheckEntityLockedCondition GetRootAsICheckEntityLockedCondition(ByteBuffer _bb)
		{
			return ICheckEntityLockedCondition.GetRootAsICheckEntityLockedCondition(_bb, default(ICheckEntityLockedCondition));
		}

		// Token: 0x0601F4D2 RID: 128210 RVA: 0x0045CD9C File Offset: 0x0045AF9C
		public static ICheckEntityLockedCondition GetRootAsICheckEntityLockedCondition(ByteBuffer _bb, ICheckEntityLockedCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F4D3 RID: 128211 RVA: 0x0045CDB9 File Offset: 0x0045AFB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F4D4 RID: 128212 RVA: 0x0045CDC8 File Offset: 0x0045AFC8
		public ICheckEntityLockedCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009003 RID: 36867
		// (get) Token: 0x0601F4D5 RID: 128213 RVA: 0x0045CDD8 File Offset: 0x0045AFD8
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

		// Token: 0x0601F4D6 RID: 128214 RVA: 0x0045CE14 File Offset: 0x0045B014
		public int Entities(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17009004 RID: 36868
		// (get) Token: 0x0601F4D7 RID: 128215 RVA: 0x0045CE54 File Offset: 0x0045B054
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

		// Token: 0x0601F4D8 RID: 128216 RVA: 0x0045CE7F File Offset: 0x0045B07F
		public Span<int> GetEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0601F4D9 RID: 128217 RVA: 0x0045CE8E File Offset: 0x0045B08E
		public int[] GetEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x17009005 RID: 36869
		// (get) Token: 0x0601F4DA RID: 128218 RVA: 0x0045CE9C File Offset: 0x0045B09C
		public bool IsLocked
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601F4DB RID: 128219 RVA: 0x0045CEDB File Offset: 0x0045B0DB
		public static Offset<ICheckEntityLockedCondition> CreateICheckEntityLockedCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, VectorOffset EntitiesOffset = default(VectorOffset), bool IsLocked = false)
		{
			builder.StartTable(3);
			ICheckEntityLockedCondition.AddEntities(builder, EntitiesOffset);
			ICheckEntityLockedCondition.AddIsLocked(builder, IsLocked);
			ICheckEntityLockedCondition.AddType(builder, Type);
			return ICheckEntityLockedCondition.EndICheckEntityLockedCondition(builder);
		}

		// Token: 0x0601F4DC RID: 128220 RVA: 0x0045CEFF File Offset: 0x0045B0FF
		public static void StartICheckEntityLockedCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601F4DD RID: 128221 RVA: 0x0045CF08 File Offset: 0x0045B108
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F4DE RID: 128222 RVA: 0x0045CF13 File Offset: 0x0045B113
		public static void AddEntities(FlatBufferBuilder builder, VectorOffset entitiesOffset)
		{
			builder.AddOffset(1, entitiesOffset.Value, 0);
		}

		// Token: 0x0601F4DF RID: 128223 RVA: 0x0045CF24 File Offset: 0x0045B124
		public static VectorOffset CreateEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601F4E0 RID: 128224 RVA: 0x0045CF5B File Offset: 0x0045B15B
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601F4E1 RID: 128225 RVA: 0x0045CF75 File Offset: 0x0045B175
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601F4E2 RID: 128226 RVA: 0x0045CF93 File Offset: 0x0045B193
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601F4E3 RID: 128227 RVA: 0x0045CFAC File Offset: 0x0045B1AC
		public static void StartEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601F4E4 RID: 128228 RVA: 0x0045CFB7 File Offset: 0x0045B1B7
		public static void AddIsLocked(FlatBufferBuilder builder, bool isLocked)
		{
			builder.AddBool(2, isLocked, false);
		}

		// Token: 0x0601F4E5 RID: 128229 RVA: 0x0045CFC2 File Offset: 0x0045B1C2
		public static Offset<ICheckEntityLockedCondition> EndICheckEntityLockedCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckEntityLockedCondition>(builder.EndTable());
		}

		// Token: 0x0601F4E6 RID: 128230 RVA: 0x0045CFD0 File Offset: 0x0045B1D0
		public ICheckEntityLockedConditionT UnPack()
		{
			ICheckEntityLockedConditionT checkEntityLockedConditionT = new ICheckEntityLockedConditionT();
			this.UnPackTo(checkEntityLockedConditionT);
			return checkEntityLockedConditionT;
		}

		// Token: 0x0601F4E7 RID: 128231 RVA: 0x0045CFEC File Offset: 0x0045B1EC
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

		// Token: 0x0601F4E8 RID: 128232 RVA: 0x0045D040 File Offset: 0x0045B240
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

		// Token: 0x0400DD27 RID: 56615
		private Table __p;
	}
}
