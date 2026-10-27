using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D2E RID: 15662
	public struct IBindCrossSceneSyncKillMonster : IFlatbufferObject
	{
		// Token: 0x17006B73 RID: 27507
		// (get) Token: 0x06015A0F RID: 88591 RVA: 0x0031F592 File Offset: 0x0031D792
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015A10 RID: 88592 RVA: 0x0031F59F File Offset: 0x0031D79F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015A11 RID: 88593 RVA: 0x0031F5A8 File Offset: 0x0031D7A8
		public static IBindCrossSceneSyncKillMonster GetRootAsIBindCrossSceneSyncKillMonster(ByteBuffer _bb)
		{
			return IBindCrossSceneSyncKillMonster.GetRootAsIBindCrossSceneSyncKillMonster(_bb, default(IBindCrossSceneSyncKillMonster));
		}

		// Token: 0x06015A12 RID: 88594 RVA: 0x0031F5C4 File Offset: 0x0031D7C4
		public static IBindCrossSceneSyncKillMonster GetRootAsIBindCrossSceneSyncKillMonster(ByteBuffer _bb, IBindCrossSceneSyncKillMonster obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015A13 RID: 88595 RVA: 0x0031F5E1 File Offset: 0x0031D7E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015A14 RID: 88596 RVA: 0x0031F5F0 File Offset: 0x0031D7F0
		public IBindCrossSceneSyncKillMonster __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06015A15 RID: 88597 RVA: 0x0031F600 File Offset: 0x0031D800
		public int EntityBundleIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17006B74 RID: 27508
		// (get) Token: 0x06015A16 RID: 88598 RVA: 0x0031F640 File Offset: 0x0031D840
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

		// Token: 0x06015A17 RID: 88599 RVA: 0x0031F66B File Offset: 0x0031D86B
		public Span<int> GetEntityBundleIdsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x06015A18 RID: 88600 RVA: 0x0031F67A File Offset: 0x0031D87A
		public int[] GetEntityBundleIdsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x06015A19 RID: 88601 RVA: 0x0031F688 File Offset: 0x0031D888
		public static Offset<IBindCrossSceneSyncKillMonster> CreateIBindCrossSceneSyncKillMonster(FlatBufferBuilder builder, VectorOffset EntityBundleIdsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IBindCrossSceneSyncKillMonster.AddEntityBundleIds(builder, EntityBundleIdsOffset);
			return IBindCrossSceneSyncKillMonster.EndIBindCrossSceneSyncKillMonster(builder);
		}

		// Token: 0x06015A1A RID: 88602 RVA: 0x0031F69E File Offset: 0x0031D89E
		public static void StartIBindCrossSceneSyncKillMonster(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06015A1B RID: 88603 RVA: 0x0031F6A7 File Offset: 0x0031D8A7
		public static void AddEntityBundleIds(FlatBufferBuilder builder, VectorOffset entityBundleIdsOffset)
		{
			builder.AddOffset(0, entityBundleIdsOffset.Value, 0);
		}

		// Token: 0x06015A1C RID: 88604 RVA: 0x0031F6B8 File Offset: 0x0031D8B8
		public static VectorOffset CreateEntityBundleIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06015A1D RID: 88605 RVA: 0x0031F6EF File Offset: 0x0031D8EF
		public static VectorOffset CreateEntityBundleIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06015A1E RID: 88606 RVA: 0x0031F709 File Offset: 0x0031D909
		public static VectorOffset CreateEntityBundleIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06015A1F RID: 88607 RVA: 0x0031F727 File Offset: 0x0031D927
		public static VectorOffset CreateEntityBundleIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06015A20 RID: 88608 RVA: 0x0031F740 File Offset: 0x0031D940
		public static void StartEntityBundleIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06015A21 RID: 88609 RVA: 0x0031F74B File Offset: 0x0031D94B
		public static Offset<IBindCrossSceneSyncKillMonster> EndIBindCrossSceneSyncKillMonster(FlatBufferBuilder builder)
		{
			return new Offset<IBindCrossSceneSyncKillMonster>(builder.EndTable());
		}

		// Token: 0x06015A22 RID: 88610 RVA: 0x0031F758 File Offset: 0x0031D958
		public IBindCrossSceneSyncKillMonsterT UnPack()
		{
			IBindCrossSceneSyncKillMonsterT bindCrossSceneSyncKillMonsterT = new IBindCrossSceneSyncKillMonsterT();
			this.UnPackTo(bindCrossSceneSyncKillMonsterT);
			return bindCrossSceneSyncKillMonsterT;
		}

		// Token: 0x06015A23 RID: 88611 RVA: 0x0031F774 File Offset: 0x0031D974
		public void UnPackTo(IBindCrossSceneSyncKillMonsterT _o)
		{
			_o.EntityBundleIds = new List<int>();
			for (int i = 0; i < this.EntityBundleIdsLength; i++)
			{
				_o.EntityBundleIds.Add(this.EntityBundleIds(i));
			}
		}

		// Token: 0x06015A24 RID: 88612 RVA: 0x0031F7B0 File Offset: 0x0031D9B0
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

		// Token: 0x0400B5ED RID: 46573
		private Table __p;
	}
}
