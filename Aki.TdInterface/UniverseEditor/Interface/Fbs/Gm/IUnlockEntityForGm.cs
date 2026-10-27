using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x020046CF RID: 18127
	public struct IUnlockEntityForGm : IFlatbufferObject
	{
		// Token: 0x170080CA RID: 32970
		// (get) Token: 0x0601B8ED RID: 112877 RVA: 0x003E8D31 File Offset: 0x003E6F31
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B8EE RID: 112878 RVA: 0x003E8D3E File Offset: 0x003E6F3E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B8EF RID: 112879 RVA: 0x003E8D48 File Offset: 0x003E6F48
		public static IUnlockEntityForGm GetRootAsIUnlockEntityForGm(ByteBuffer _bb)
		{
			return IUnlockEntityForGm.GetRootAsIUnlockEntityForGm(_bb, default(IUnlockEntityForGm));
		}

		// Token: 0x0601B8F0 RID: 112880 RVA: 0x003E8D64 File Offset: 0x003E6F64
		public static IUnlockEntityForGm GetRootAsIUnlockEntityForGm(ByteBuffer _bb, IUnlockEntityForGm obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B8F1 RID: 112881 RVA: 0x003E8D81 File Offset: 0x003E6F81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B8F2 RID: 112882 RVA: 0x003E8D90 File Offset: 0x003E6F90
		public IUnlockEntityForGm __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170080CB RID: 32971
		// (get) Token: 0x0601B8F3 RID: 112883 RVA: 0x003E8DA0 File Offset: 0x003E6FA0
		public EGmCommand Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGmCommand.SkipToLevelPlayNode;
				}
				return (EGmCommand)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B8F4 RID: 112884 RVA: 0x003E8DDC File Offset: 0x003E6FDC
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170080CC RID: 32972
		// (get) Token: 0x0601B8F5 RID: 112885 RVA: 0x003E8E1C File Offset: 0x003E701C
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

		// Token: 0x0601B8F6 RID: 112886 RVA: 0x003E8E47 File Offset: 0x003E7047
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0601B8F7 RID: 112887 RVA: 0x003E8E56 File Offset: 0x003E7056
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x0601B8F8 RID: 112888 RVA: 0x003E8E64 File Offset: 0x003E7064
		public static Offset<IUnlockEntityForGm> CreateIUnlockEntityForGm(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, VectorOffset EntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IUnlockEntityForGm.AddEntityIds(builder, EntityIdsOffset);
			IUnlockEntityForGm.AddType(builder, Type);
			return IUnlockEntityForGm.EndIUnlockEntityForGm(builder);
		}

		// Token: 0x0601B8F9 RID: 112889 RVA: 0x003E8E81 File Offset: 0x003E7081
		public static void StartIUnlockEntityForGm(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601B8FA RID: 112890 RVA: 0x003E8E8A File Offset: 0x003E708A
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B8FB RID: 112891 RVA: 0x003E8E95 File Offset: 0x003E7095
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(1, entityIdsOffset.Value, 0);
		}

		// Token: 0x0601B8FC RID: 112892 RVA: 0x003E8EA8 File Offset: 0x003E70A8
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B8FD RID: 112893 RVA: 0x003E8EDF File Offset: 0x003E70DF
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B8FE RID: 112894 RVA: 0x003E8EF9 File Offset: 0x003E70F9
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B8FF RID: 112895 RVA: 0x003E8F17 File Offset: 0x003E7117
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B900 RID: 112896 RVA: 0x003E8F30 File Offset: 0x003E7130
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601B901 RID: 112897 RVA: 0x003E8F3B File Offset: 0x003E713B
		public static Offset<IUnlockEntityForGm> EndIUnlockEntityForGm(FlatBufferBuilder builder)
		{
			return new Offset<IUnlockEntityForGm>(builder.EndTable());
		}

		// Token: 0x0601B902 RID: 112898 RVA: 0x003E8F48 File Offset: 0x003E7148
		public IUnlockEntityForGmT UnPack()
		{
			IUnlockEntityForGmT unlockEntityForGmT = new IUnlockEntityForGmT();
			this.UnPackTo(unlockEntityForGmT);
			return unlockEntityForGmT;
		}

		// Token: 0x0601B903 RID: 112899 RVA: 0x003E8F64 File Offset: 0x003E7164
		public void UnPackTo(IUnlockEntityForGmT _o)
		{
			_o.Type = this.Type;
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
		}

		// Token: 0x0601B904 RID: 112900 RVA: 0x003E8FAC File Offset: 0x003E71AC
		public static Offset<IUnlockEntityForGm> Pack(FlatBufferBuilder builder, IUnlockEntityForGmT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUnlockEntityForGm>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IUnlockEntityForGm.CreateEntityIdsVector(builder, data);
			}
			return IUnlockEntityForGm.CreateIUnlockEntityForGm(builder, _o.Type, entityIdsOffset);
		}

		// Token: 0x0400C8A1 RID: 51361
		private Table __p;
	}
}
