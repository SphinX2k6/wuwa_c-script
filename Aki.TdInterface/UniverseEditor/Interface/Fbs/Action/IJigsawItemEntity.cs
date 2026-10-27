using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069CF RID: 27087
	public struct IJigsawItemEntity : IFlatbufferObject
	{
		// Token: 0x1700C8FF RID: 51455
		// (get) Token: 0x0602F58F RID: 193935 RVA: 0x00672BE3 File Offset: 0x00670DE3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F590 RID: 193936 RVA: 0x00672BF0 File Offset: 0x00670DF0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F591 RID: 193937 RVA: 0x00672BF8 File Offset: 0x00670DF8
		public static IJigsawItemEntity GetRootAsIJigsawItemEntity(ByteBuffer _bb)
		{
			return IJigsawItemEntity.GetRootAsIJigsawItemEntity(_bb, default(IJigsawItemEntity));
		}

		// Token: 0x0602F592 RID: 193938 RVA: 0x00672C14 File Offset: 0x00670E14
		public static IJigsawItemEntity GetRootAsIJigsawItemEntity(ByteBuffer _bb, IJigsawItemEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F593 RID: 193939 RVA: 0x00672C31 File Offset: 0x00670E31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F594 RID: 193940 RVA: 0x00672C40 File Offset: 0x00670E40
		public IJigsawItemEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C900 RID: 51456
		// (get) Token: 0x0602F595 RID: 193941 RVA: 0x00672C50 File Offset: 0x00670E50
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

		// Token: 0x0602F596 RID: 193942 RVA: 0x00672C8C File Offset: 0x00670E8C
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C901 RID: 51457
		// (get) Token: 0x0602F597 RID: 193943 RVA: 0x00672CCC File Offset: 0x00670ECC
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

		// Token: 0x0602F598 RID: 193944 RVA: 0x00672CF7 File Offset: 0x00670EF7
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0602F599 RID: 193945 RVA: 0x00672D06 File Offset: 0x00670F06
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x0602F59A RID: 193946 RVA: 0x00672D14 File Offset: 0x00670F14
		public static Offset<IJigsawItemEntity> CreateIJigsawItemEntity(FlatBufferBuilder builder, EResetEntityType Type = EResetEntityType.TeleControl, VectorOffset EntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IJigsawItemEntity.AddEntityIds(builder, EntityIdsOffset);
			IJigsawItemEntity.AddType(builder, Type);
			return IJigsawItemEntity.EndIJigsawItemEntity(builder);
		}

		// Token: 0x0602F59B RID: 193947 RVA: 0x00672D31 File Offset: 0x00670F31
		public static void StartIJigsawItemEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602F59C RID: 193948 RVA: 0x00672D3A File Offset: 0x00670F3A
		public static void AddType(FlatBufferBuilder builder, EResetEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F59D RID: 193949 RVA: 0x00672D45 File Offset: 0x00670F45
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(1, entityIdsOffset.Value, 0);
		}

		// Token: 0x0602F59E RID: 193950 RVA: 0x00672D58 File Offset: 0x00670F58
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602F59F RID: 193951 RVA: 0x00672D8F File Offset: 0x00670F8F
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F5A0 RID: 193952 RVA: 0x00672DA9 File Offset: 0x00670FA9
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F5A1 RID: 193953 RVA: 0x00672DC7 File Offset: 0x00670FC7
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602F5A2 RID: 193954 RVA: 0x00672DE0 File Offset: 0x00670FE0
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602F5A3 RID: 193955 RVA: 0x00672DEB File Offset: 0x00670FEB
		public static Offset<IJigsawItemEntity> EndIJigsawItemEntity(FlatBufferBuilder builder)
		{
			return new Offset<IJigsawItemEntity>(builder.EndTable());
		}

		// Token: 0x0602F5A4 RID: 193956 RVA: 0x00672DF8 File Offset: 0x00670FF8
		public IJigsawItemEntityT UnPack()
		{
			IJigsawItemEntityT jigsawItemEntityT = new IJigsawItemEntityT();
			this.UnPackTo(jigsawItemEntityT);
			return jigsawItemEntityT;
		}

		// Token: 0x0602F5A5 RID: 193957 RVA: 0x00672E14 File Offset: 0x00671014
		public void UnPackTo(IJigsawItemEntityT _o)
		{
			_o.Type = this.Type;
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
		}

		// Token: 0x0602F5A6 RID: 193958 RVA: 0x00672E5C File Offset: 0x0067105C
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

		// Token: 0x0401118D RID: 70029
		private Table __p;
	}
}
