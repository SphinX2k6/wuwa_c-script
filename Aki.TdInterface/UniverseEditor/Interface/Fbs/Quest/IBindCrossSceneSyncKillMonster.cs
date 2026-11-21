using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004145 RID: 16709
	public struct IBindCrossSceneSyncKillMonster : IFlatbufferObject
	{
		// Token: 0x1700712D RID: 28973
		// (get) Token: 0x06016F47 RID: 94023 RVA: 0x0034680A File Offset: 0x00344A0A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016F48 RID: 94024 RVA: 0x00346817 File Offset: 0x00344A17
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016F49 RID: 94025 RVA: 0x00346820 File Offset: 0x00344A20
		public static IBindCrossSceneSyncKillMonster GetRootAsIBindCrossSceneSyncKillMonster(ByteBuffer _bb)
		{
			return IBindCrossSceneSyncKillMonster.GetRootAsIBindCrossSceneSyncKillMonster(_bb, default(IBindCrossSceneSyncKillMonster));
		}

		// Token: 0x06016F4A RID: 94026 RVA: 0x0034683C File Offset: 0x00344A3C
		public static IBindCrossSceneSyncKillMonster GetRootAsIBindCrossSceneSyncKillMonster(ByteBuffer _bb, IBindCrossSceneSyncKillMonster obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016F4B RID: 94027 RVA: 0x00346859 File Offset: 0x00344A59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016F4C RID: 94028 RVA: 0x00346868 File Offset: 0x00344A68
		public IBindCrossSceneSyncKillMonster __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06016F4D RID: 94029 RVA: 0x00346878 File Offset: 0x00344A78
		public int EntityBundleIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700712E RID: 28974
		// (get) Token: 0x06016F4E RID: 94030 RVA: 0x003468B8 File Offset: 0x00344AB8
		public int EntityBundleIdsLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06016F4F RID: 94031 RVA: 0x003468E3 File Offset: 0x00344AE3
		public Span<int> GetEntityBundleIdsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x06016F50 RID: 94032 RVA: 0x003468F2 File Offset: 0x00344AF2
		public int[] GetEntityBundleIdsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x06016F51 RID: 94033 RVA: 0x00346900 File Offset: 0x00344B00
		public static Offset<IBindCrossSceneSyncKillMonster> CreateIBindCrossSceneSyncKillMonster(FlatBufferBuilder builder, VectorOffset EntityBundleIdsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IBindCrossSceneSyncKillMonster.AddEntityBundleIds(builder, EntityBundleIdsOffset);
			return IBindCrossSceneSyncKillMonster.EndIBindCrossSceneSyncKillMonster(builder);
		}

		// Token: 0x06016F52 RID: 94034 RVA: 0x00346916 File Offset: 0x00344B16
		public static void StartIBindCrossSceneSyncKillMonster(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06016F53 RID: 94035 RVA: 0x0034691F File Offset: 0x00344B1F
		public static void AddEntityBundleIds(FlatBufferBuilder builder, VectorOffset entityBundleIdsOffset)
		{
			builder.AddOffset(0, entityBundleIdsOffset.Value, 0);
		}

		// Token: 0x06016F54 RID: 94036 RVA: 0x00346930 File Offset: 0x00344B30
		public static VectorOffset CreateEntityBundleIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06016F55 RID: 94037 RVA: 0x00346967 File Offset: 0x00344B67
		public static VectorOffset CreateEntityBundleIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06016F56 RID: 94038 RVA: 0x00346981 File Offset: 0x00344B81
		public static VectorOffset CreateEntityBundleIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06016F57 RID: 94039 RVA: 0x0034699F File Offset: 0x00344B9F
		public static VectorOffset CreateEntityBundleIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06016F58 RID: 94040 RVA: 0x003469B8 File Offset: 0x00344BB8
		public static void StartEntityBundleIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06016F59 RID: 94041 RVA: 0x003469C3 File Offset: 0x00344BC3
		public static Offset<IBindCrossSceneSyncKillMonster> EndIBindCrossSceneSyncKillMonster(FlatBufferBuilder builder)
		{
			return new Offset<IBindCrossSceneSyncKillMonster>(builder.EndTable());
		}

		// Token: 0x06016F5A RID: 94042 RVA: 0x003469D0 File Offset: 0x00344BD0
		public IBindCrossSceneSyncKillMonsterT UnPack()
		{
			IBindCrossSceneSyncKillMonsterT bindCrossSceneSyncKillMonsterT = new IBindCrossSceneSyncKillMonsterT();
			this.UnPackTo(bindCrossSceneSyncKillMonsterT);
			return bindCrossSceneSyncKillMonsterT;
		}

		// Token: 0x06016F5B RID: 94043 RVA: 0x003469EC File Offset: 0x00344BEC
		public void UnPackTo(IBindCrossSceneSyncKillMonsterT _o)
		{
			_o.EntityBundleIds = new List<int>();
			for (int i = 0; i < this.EntityBundleIdsLength; i++)
			{
				_o.EntityBundleIds.Add(this.EntityBundleIds(i));
			}
		}

		// Token: 0x06016F5C RID: 94044 RVA: 0x00346A28 File Offset: 0x00344C28
		public static Offset<IBindCrossSceneSyncKillMonster> Pack(FlatBufferBuilder builder, IBindCrossSceneSyncKillMonsterT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBindCrossSceneSyncKillMonster>);
			}
			VectorOffset entityBundleIdsOffset = default(VectorOffset);
			if (_o.EntityBundleIds != null)
			{
				int[] data = _o.EntityBundleIds.ToArray();
				entityBundleIdsOffset = IBindCrossSceneSyncKillMonster.CreateEntityBundleIdsVector(builder, data);
			}
			return IBindCrossSceneSyncKillMonster.CreateIBindCrossSceneSyncKillMonster(builder, entityBundleIdsOffset);
		}

		// Token: 0x0400BF9A RID: 49050
		private Table __p;
	}
}
