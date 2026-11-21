using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200707F RID: 28799
	public struct IJigsawItemEntity : IFlatbufferObject
	{
		// Token: 0x1700D2FF RID: 54015
		// (get) Token: 0x06031F4F RID: 204623 RVA: 0x006C2F3B File Offset: 0x006C113B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031F50 RID: 204624 RVA: 0x006C2F48 File Offset: 0x006C1148
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031F51 RID: 204625 RVA: 0x006C2F50 File Offset: 0x006C1150
		public static IJigsawItemEntity GetRootAsIJigsawItemEntity(ByteBuffer _bb)
		{
			return IJigsawItemEntity.GetRootAsIJigsawItemEntity(_bb, default(IJigsawItemEntity));
		}

		// Token: 0x06031F52 RID: 204626 RVA: 0x006C2F6C File Offset: 0x006C116C
		public static IJigsawItemEntity GetRootAsIJigsawItemEntity(ByteBuffer _bb, IJigsawItemEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031F53 RID: 204627 RVA: 0x006C2F89 File Offset: 0x006C1189
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031F54 RID: 204628 RVA: 0x006C2F98 File Offset: 0x006C1198
		public IJigsawItemEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D300 RID: 54016
		// (get) Token: 0x06031F55 RID: 204629 RVA: 0x006C2FA8 File Offset: 0x006C11A8
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

		// Token: 0x06031F56 RID: 204630 RVA: 0x006C2FE4 File Offset: 0x006C11E4
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D301 RID: 54017
		// (get) Token: 0x06031F57 RID: 204631 RVA: 0x006C3024 File Offset: 0x006C1224
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

		// Token: 0x06031F58 RID: 204632 RVA: 0x006C304F File Offset: 0x006C124F
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06031F59 RID: 204633 RVA: 0x006C305E File Offset: 0x006C125E
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x06031F5A RID: 204634 RVA: 0x006C306C File Offset: 0x006C126C
		public static Offset<IJigsawItemEntity> CreateIJigsawItemEntity(FlatBufferBuilder builder, EResetEntityType Type = EResetEntityType.TeleControl, VectorOffset EntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IJigsawItemEntity.AddEntityIds(builder, EntityIdsOffset);
			IJigsawItemEntity.AddType(builder, Type);
			return IJigsawItemEntity.EndIJigsawItemEntity(builder);
		}

		// Token: 0x06031F5B RID: 204635 RVA: 0x006C3089 File Offset: 0x006C1289
		public static void StartIJigsawItemEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031F5C RID: 204636 RVA: 0x006C3092 File Offset: 0x006C1292
		public static void AddType(FlatBufferBuilder builder, EResetEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031F5D RID: 204637 RVA: 0x006C309D File Offset: 0x006C129D
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(1, entityIdsOffset.Value, 0);
		}

		// Token: 0x06031F5E RID: 204638 RVA: 0x006C30B0 File Offset: 0x006C12B0
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06031F5F RID: 204639 RVA: 0x006C30E7 File Offset: 0x006C12E7
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06031F60 RID: 204640 RVA: 0x006C3101 File Offset: 0x006C1301
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06031F61 RID: 204641 RVA: 0x006C311F File Offset: 0x006C131F
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06031F62 RID: 204642 RVA: 0x006C3138 File Offset: 0x006C1338
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06031F63 RID: 204643 RVA: 0x006C3143 File Offset: 0x006C1343
		public static Offset<IJigsawItemEntity> EndIJigsawItemEntity(FlatBufferBuilder builder)
		{
			return new Offset<IJigsawItemEntity>(builder.EndTable());
		}

		// Token: 0x06031F64 RID: 204644 RVA: 0x006C3150 File Offset: 0x006C1350
		public IJigsawItemEntityT UnPack()
		{
			IJigsawItemEntityT jigsawItemEntityT = new IJigsawItemEntityT();
			this.UnPackTo(jigsawItemEntityT);
			return jigsawItemEntityT;
		}

		// Token: 0x06031F65 RID: 204645 RVA: 0x006C316C File Offset: 0x006C136C
		public void UnPackTo(IJigsawItemEntityT _o)
		{
			_o.Type = this.Type;
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
		}

		// Token: 0x06031F66 RID: 204646 RVA: 0x006C31B4 File Offset: 0x006C13B4
		public static Offset<IJigsawItemEntity> Pack(FlatBufferBuilder builder, IJigsawItemEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IJigsawItemEntity>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IJigsawItemEntity.CreateEntityIdsVector(builder, data);
			}
			return IJigsawItemEntity.CreateIJigsawItemEntity(builder, _o.Type, entityIdsOffset);
		}

		// Token: 0x04011FF7 RID: 73719
		private Table __p;
	}
}
