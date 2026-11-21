using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FB3 RID: 28595
	public struct IHideSpecifyEntity : IFlatbufferObject
	{
		// Token: 0x1700D169 RID: 53609
		// (get) Token: 0x0603181D RID: 202781 RVA: 0x006B5BFF File Offset: 0x006B3DFF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603181E RID: 202782 RVA: 0x006B5C0C File Offset: 0x006B3E0C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603181F RID: 202783 RVA: 0x006B5C14 File Offset: 0x006B3E14
		public static IHideSpecifyEntity GetRootAsIHideSpecifyEntity(ByteBuffer _bb)
		{
			return IHideSpecifyEntity.GetRootAsIHideSpecifyEntity(_bb, default(IHideSpecifyEntity));
		}

		// Token: 0x06031820 RID: 202784 RVA: 0x006B5C30 File Offset: 0x006B3E30
		public static IHideSpecifyEntity GetRootAsIHideSpecifyEntity(ByteBuffer _bb, IHideSpecifyEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031821 RID: 202785 RVA: 0x006B5C4D File Offset: 0x006B3E4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031822 RID: 202786 RVA: 0x006B5C5C File Offset: 0x006B3E5C
		public IHideSpecifyEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D16A RID: 53610
		// (get) Token: 0x06031823 RID: 202787 RVA: 0x006B5C6C File Offset: 0x006B3E6C
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

		// Token: 0x06031824 RID: 202788 RVA: 0x006B5CA8 File Offset: 0x006B3EA8
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D16B RID: 53611
		// (get) Token: 0x06031825 RID: 202789 RVA: 0x006B5CE8 File Offset: 0x006B3EE8
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

		// Token: 0x06031826 RID: 202790 RVA: 0x006B5D13 File Offset: 0x006B3F13
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06031827 RID: 202791 RVA: 0x006B5D22 File Offset: 0x006B3F22
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x06031828 RID: 202792 RVA: 0x006B5D30 File Offset: 0x006B3F30
		public static Offset<IHideSpecifyEntity> CreateIHideSpecifyEntity(FlatBufferBuilder builder, EHideType Type = EHideType.WorldMonsterAndMonsterTreasure, VectorOffset EntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IHideSpecifyEntity.AddEntityIds(builder, EntityIdsOffset);
			IHideSpecifyEntity.AddType(builder, Type);
			return IHideSpecifyEntity.EndIHideSpecifyEntity(builder);
		}

		// Token: 0x06031829 RID: 202793 RVA: 0x006B5D4D File Offset: 0x006B3F4D
		public static void StartIHideSpecifyEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603182A RID: 202794 RVA: 0x006B5D56 File Offset: 0x006B3F56
		public static void AddType(FlatBufferBuilder builder, EHideType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603182B RID: 202795 RVA: 0x006B5D61 File Offset: 0x006B3F61
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(1, entityIdsOffset.Value, 0);
		}

		// Token: 0x0603182C RID: 202796 RVA: 0x006B5D74 File Offset: 0x006B3F74
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0603182D RID: 202797 RVA: 0x006B5DAB File Offset: 0x006B3FAB
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0603182E RID: 202798 RVA: 0x006B5DC5 File Offset: 0x006B3FC5
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0603182F RID: 202799 RVA: 0x006B5DE3 File Offset: 0x006B3FE3
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06031830 RID: 202800 RVA: 0x006B5DFC File Offset: 0x006B3FFC
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06031831 RID: 202801 RVA: 0x006B5E07 File Offset: 0x006B4007
		public static Offset<IHideSpecifyEntity> EndIHideSpecifyEntity(FlatBufferBuilder builder)
		{
			return new Offset<IHideSpecifyEntity>(builder.EndTable());
		}

		// Token: 0x06031832 RID: 202802 RVA: 0x006B5E14 File Offset: 0x006B4014
		public IHideSpecifyEntityT UnPack()
		{
			IHideSpecifyEntityT hideSpecifyEntityT = new IHideSpecifyEntityT();
			this.UnPackTo(hideSpecifyEntityT);
			return hideSpecifyEntityT;
		}

		// Token: 0x06031833 RID: 202803 RVA: 0x006B5E30 File Offset: 0x006B4030
		public void UnPackTo(IHideSpecifyEntityT _o)
		{
			_o.Type = this.Type;
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
		}

		// Token: 0x06031834 RID: 202804 RVA: 0x006B5E78 File Offset: 0x006B4078
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

		// Token: 0x04011EDF RID: 73439
		private Table __p;
	}
}
