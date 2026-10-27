using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006900 RID: 26880
	public struct IHideSpecifyEntity : IFlatbufferObject
	{
		// Token: 0x1700C766 RID: 51046
		// (get) Token: 0x0602EE4D RID: 192077 RVA: 0x00665717 File Offset: 0x00663917
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EE4E RID: 192078 RVA: 0x00665724 File Offset: 0x00663924
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EE4F RID: 192079 RVA: 0x0066572C File Offset: 0x0066392C
		public static IHideSpecifyEntity GetRootAsIHideSpecifyEntity(ByteBuffer _bb)
		{
			return IHideSpecifyEntity.GetRootAsIHideSpecifyEntity(_bb, default(IHideSpecifyEntity));
		}

		// Token: 0x0602EE50 RID: 192080 RVA: 0x00665748 File Offset: 0x00663948
		public static IHideSpecifyEntity GetRootAsIHideSpecifyEntity(ByteBuffer _bb, IHideSpecifyEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EE51 RID: 192081 RVA: 0x00665765 File Offset: 0x00663965
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EE52 RID: 192082 RVA: 0x00665774 File Offset: 0x00663974
		public IHideSpecifyEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C767 RID: 51047
		// (get) Token: 0x0602EE53 RID: 192083 RVA: 0x00665784 File Offset: 0x00663984
		public EHideType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHideType.WorldMonsterAndMonsterTreasure;
				}
				return (EHideType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602EE54 RID: 192084 RVA: 0x006657C0 File Offset: 0x006639C0
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C768 RID: 51048
		// (get) Token: 0x0602EE55 RID: 192085 RVA: 0x00665800 File Offset: 0x00663A00
		public int EntityIdsLength
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

		// Token: 0x0602EE56 RID: 192086 RVA: 0x0066582B File Offset: 0x00663A2B
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0602EE57 RID: 192087 RVA: 0x0066583A File Offset: 0x00663A3A
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x0602EE58 RID: 192088 RVA: 0x00665848 File Offset: 0x00663A48
		public static Offset<IHideSpecifyEntity> CreateIHideSpecifyEntity(FlatBufferBuilder builder, EHideType Type = EHideType.WorldMonsterAndMonsterTreasure, VectorOffset EntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IHideSpecifyEntity.AddEntityIds(builder, EntityIdsOffset);
			IHideSpecifyEntity.AddType(builder, Type);
			return IHideSpecifyEntity.EndIHideSpecifyEntity(builder);
		}

		// Token: 0x0602EE59 RID: 192089 RVA: 0x00665865 File Offset: 0x00663A65
		public static void StartIHideSpecifyEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602EE5A RID: 192090 RVA: 0x0066586E File Offset: 0x00663A6E
		public static void AddType(FlatBufferBuilder builder, EHideType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602EE5B RID: 192091 RVA: 0x00665879 File Offset: 0x00663A79
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(1, entityIdsOffset.Value, 0);
		}

		// Token: 0x0602EE5C RID: 192092 RVA: 0x0066588C File Offset: 0x00663A8C
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602EE5D RID: 192093 RVA: 0x006658C3 File Offset: 0x00663AC3
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602EE5E RID: 192094 RVA: 0x006658DD File Offset: 0x00663ADD
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602EE5F RID: 192095 RVA: 0x006658FB File Offset: 0x00663AFB
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602EE60 RID: 192096 RVA: 0x00665914 File Offset: 0x00663B14
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602EE61 RID: 192097 RVA: 0x0066591F File Offset: 0x00663B1F
		public static Offset<IHideSpecifyEntity> EndIHideSpecifyEntity(FlatBufferBuilder builder)
		{
			return new Offset<IHideSpecifyEntity>(builder.EndTable());
		}

		// Token: 0x0602EE62 RID: 192098 RVA: 0x0066592C File Offset: 0x00663B2C
		public IHideSpecifyEntityT UnPack()
		{
			IHideSpecifyEntityT hideSpecifyEntityT = new IHideSpecifyEntityT();
			this.UnPackTo(hideSpecifyEntityT);
			return hideSpecifyEntityT;
		}

		// Token: 0x0602EE63 RID: 192099 RVA: 0x00665948 File Offset: 0x00663B48
		public void UnPackTo(IHideSpecifyEntityT _o)
		{
			_o.Type = this.Type;
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
		}

		// Token: 0x0602EE64 RID: 192100 RVA: 0x00665990 File Offset: 0x00663B90
		public static Offset<IHideSpecifyEntity> Pack(FlatBufferBuilder builder, IHideSpecifyEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHideSpecifyEntity>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IHideSpecifyEntity.CreateEntityIdsVector(builder, data);
			}
			return IHideSpecifyEntity.CreateIHideSpecifyEntity(builder, _o.Type, entityIdsOffset);
		}

		// Token: 0x04011073 RID: 69747
		private Table __p;
	}
}
