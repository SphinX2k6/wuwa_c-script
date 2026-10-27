using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EAF RID: 28335
	public struct IResetTeleControlEntity : IFlatbufferObject
	{
		// Token: 0x1700D2F1 RID: 54001
		// (get) Token: 0x06032145 RID: 205125 RVA: 0x006C59DC File Offset: 0x006C3BDC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032146 RID: 205126 RVA: 0x006C59E9 File Offset: 0x006C3BE9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032147 RID: 205127 RVA: 0x006C59F0 File Offset: 0x006C3BF0
		public static IResetTeleControlEntity GetRootAsIResetTeleControlEntity(ByteBuffer _bb)
		{
			return IResetTeleControlEntity.GetRootAsIResetTeleControlEntity(_bb, default(IResetTeleControlEntity));
		}

		// Token: 0x06032148 RID: 205128 RVA: 0x006C5A0C File Offset: 0x006C3C0C
		public static IResetTeleControlEntity GetRootAsIResetTeleControlEntity(ByteBuffer _bb, IResetTeleControlEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032149 RID: 205129 RVA: 0x006C5A29 File Offset: 0x006C3C29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603214A RID: 205130 RVA: 0x006C5A38 File Offset: 0x006C3C38
		public IResetTeleControlEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D2F2 RID: 54002
		// (get) Token: 0x0603214B RID: 205131 RVA: 0x006C5A48 File Offset: 0x006C3C48
		public EResetEntityType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EResetEntityType.TeleControl;
				}
				return (EResetEntityType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603214C RID: 205132 RVA: 0x006C5A84 File Offset: 0x006C3C84
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D2F3 RID: 54003
		// (get) Token: 0x0603214D RID: 205133 RVA: 0x006C5AC4 File Offset: 0x006C3CC4
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

		// Token: 0x0603214E RID: 205134 RVA: 0x006C5AEF File Offset: 0x006C3CEF
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0603214F RID: 205135 RVA: 0x006C5AFE File Offset: 0x006C3CFE
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x06032150 RID: 205136 RVA: 0x006C5B0C File Offset: 0x006C3D0C
		public static Offset<IResetTeleControlEntity> CreateIResetTeleControlEntity(FlatBufferBuilder builder, EResetEntityType Type = EResetEntityType.TeleControl, VectorOffset EntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IResetTeleControlEntity.AddEntityIds(builder, EntityIdsOffset);
			IResetTeleControlEntity.AddType(builder, Type);
			return IResetTeleControlEntity.EndIResetTeleControlEntity(builder);
		}

		// Token: 0x06032151 RID: 205137 RVA: 0x006C5B29 File Offset: 0x006C3D29
		public static void StartIResetTeleControlEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06032152 RID: 205138 RVA: 0x006C5B32 File Offset: 0x006C3D32
		public static void AddType(FlatBufferBuilder builder, EResetEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032153 RID: 205139 RVA: 0x006C5B3D File Offset: 0x006C3D3D
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(1, entityIdsOffset.Value, 0);
		}

		// Token: 0x06032154 RID: 205140 RVA: 0x006C5B50 File Offset: 0x006C3D50
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06032155 RID: 205141 RVA: 0x006C5B87 File Offset: 0x006C3D87
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06032156 RID: 205142 RVA: 0x006C5BA1 File Offset: 0x006C3DA1
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06032157 RID: 205143 RVA: 0x006C5BBF File Offset: 0x006C3DBF
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06032158 RID: 205144 RVA: 0x006C5BD8 File Offset: 0x006C3DD8
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06032159 RID: 205145 RVA: 0x006C5BE3 File Offset: 0x006C3DE3
		public static Offset<IResetTeleControlEntity> EndIResetTeleControlEntity(FlatBufferBuilder builder)
		{
			return new Offset<IResetTeleControlEntity>(builder.EndTable());
		}

		// Token: 0x0603215A RID: 205146 RVA: 0x006C5BF0 File Offset: 0x006C3DF0
		public IResetTeleControlEntityT UnPack()
		{
			IResetTeleControlEntityT resetTeleControlEntityT = new IResetTeleControlEntityT();
			this.UnPackTo(resetTeleControlEntityT);
			return resetTeleControlEntityT;
		}

		// Token: 0x0603215B RID: 205147 RVA: 0x006C5C0C File Offset: 0x006C3E0C
		public void UnPackTo(IResetTeleControlEntityT _o)
		{
			_o.Type = this.Type;
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
		}

		// Token: 0x0603215C RID: 205148 RVA: 0x006C5C54 File Offset: 0x006C3E54
		public static Offset<IResetTeleControlEntity> Pack(FlatBufferBuilder builder, IResetTeleControlEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IResetTeleControlEntity>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IResetTeleControlEntity.CreateEntityIdsVector(builder, data);
			}
			return IResetTeleControlEntity.CreateIResetTeleControlEntity(builder, _o.Type, entityIdsOffset);
		}

		// Token: 0x040118A5 RID: 71845
		private Table __p;
	}
}
