using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047E7 RID: 18407
	public struct ILevelVoxelInfo : IFlatbufferObject
	{
		// Token: 0x1700844A RID: 33866
		// (get) Token: 0x0601C760 RID: 116576 RVA: 0x00406C74 File Offset: 0x00404E74
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C761 RID: 116577 RVA: 0x00406C81 File Offset: 0x00404E81
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C762 RID: 116578 RVA: 0x00406C88 File Offset: 0x00404E88
		public static ILevelVoxelInfo GetRootAsILevelVoxelInfo(ByteBuffer _bb)
		{
			return ILevelVoxelInfo.GetRootAsILevelVoxelInfo(_bb, default(ILevelVoxelInfo));
		}

		// Token: 0x0601C763 RID: 116579 RVA: 0x00406CA4 File Offset: 0x00404EA4
		public static ILevelVoxelInfo GetRootAsILevelVoxelInfo(ByteBuffer _bb, ILevelVoxelInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C764 RID: 116580 RVA: 0x00406CC1 File Offset: 0x00404EC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C765 RID: 116581 RVA: 0x00406CD0 File Offset: 0x00404ED0
		public ILevelVoxelInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700844B RID: 33867
		// (get) Token: 0x0601C766 RID: 116582 RVA: 0x00406CE0 File Offset: 0x00404EE0
		public int LevelId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601C767 RID: 116583 RVA: 0x00406D1C File Offset: 0x00404F1C
		public IEntityVoxelInfo? EntityVoxelInfos(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IEntityVoxelInfo?(default(IEntityVoxelInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700844C RID: 33868
		// (get) Token: 0x0601C768 RID: 116584 RVA: 0x00406D7C File Offset: 0x00404F7C
		public int EntityVoxelInfosLength
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

		// Token: 0x0601C769 RID: 116585 RVA: 0x00406DA7 File Offset: 0x00404FA7
		public static Offset<ILevelVoxelInfo> CreateILevelVoxelInfo(FlatBufferBuilder builder, int LevelId = 0, VectorOffset EntityVoxelInfosOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ILevelVoxelInfo.AddEntityVoxelInfos(builder, EntityVoxelInfosOffset);
			ILevelVoxelInfo.AddLevelId(builder, LevelId);
			return ILevelVoxelInfo.EndILevelVoxelInfo(builder);
		}

		// Token: 0x0601C76A RID: 116586 RVA: 0x00406DC4 File Offset: 0x00404FC4
		public static void StartILevelVoxelInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601C76B RID: 116587 RVA: 0x00406DCD File Offset: 0x00404FCD
		public static void AddLevelId(FlatBufferBuilder builder, int levelId)
		{
			builder.AddInt(0, levelId, 0);
		}

		// Token: 0x0601C76C RID: 116588 RVA: 0x00406DD8 File Offset: 0x00404FD8
		public static void AddEntityVoxelInfos(FlatBufferBuilder builder, VectorOffset entityVoxelInfosOffset)
		{
			builder.AddOffset(1, entityVoxelInfosOffset.Value, 0);
		}

		// Token: 0x0601C76D RID: 116589 RVA: 0x00406DE8 File Offset: 0x00404FE8
		public static VectorOffset CreateEntityVoxelInfosVector(FlatBufferBuilder builder, Offset<IEntityVoxelInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C76E RID: 116590 RVA: 0x00406E28 File Offset: 0x00405028
		public static VectorOffset CreateEntityVoxelInfosVectorBlock(FlatBufferBuilder builder, Offset<IEntityVoxelInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityVoxelInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C76F RID: 116591 RVA: 0x00406E42 File Offset: 0x00405042
		public static VectorOffset CreateEntityVoxelInfosVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityVoxelInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityVoxelInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C770 RID: 116592 RVA: 0x00406E60 File Offset: 0x00405060
		public static VectorOffset CreateEntityVoxelInfosVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityVoxelInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C771 RID: 116593 RVA: 0x00406E79 File Offset: 0x00405079
		public static void StartEntityVoxelInfosVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C772 RID: 116594 RVA: 0x00406E84 File Offset: 0x00405084
		public static Offset<ILevelVoxelInfo> EndILevelVoxelInfo(FlatBufferBuilder builder)
		{
			return new Offset<ILevelVoxelInfo>(builder.EndTable());
		}

		// Token: 0x0601C773 RID: 116595 RVA: 0x00406E94 File Offset: 0x00405094
		public ILevelVoxelInfoT UnPack()
		{
			ILevelVoxelInfoT levelVoxelInfoT = new ILevelVoxelInfoT();
			this.UnPackTo(levelVoxelInfoT);
			return levelVoxelInfoT;
		}

		// Token: 0x0601C774 RID: 116596 RVA: 0x00406EB0 File Offset: 0x004050B0
		public void UnPackTo(ILevelVoxelInfoT _o)
		{
			_o.LevelId = this.LevelId;
			_o.EntityVoxelInfos = new List<IEntityVoxelInfoT>();
			for (int i = 0; i < this.EntityVoxelInfosLength; i++)
			{
				_o.EntityVoxelInfos.Add((this.EntityVoxelInfos(i) != null) ? this.EntityVoxelInfos(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601C775 RID: 116597 RVA: 0x00406F1C File Offset: 0x0040511C
		public static Offset<ILevelVoxelInfo> Pack(FlatBufferBuilder builder, ILevelVoxelInfoT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelVoxelInfo>);
			}
			VectorOffset entityVoxelInfosOffset = default(VectorOffset);
			if (_o.EntityVoxelInfos != null)
			{
				Offset<IEntityVoxelInfo>[] array = new Offset<IEntityVoxelInfo>[_o.EntityVoxelInfos.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IEntityVoxelInfo.Pack(builder, _o.EntityVoxelInfos[i]);
				}
				entityVoxelInfosOffset = ILevelVoxelInfo.CreateEntityVoxelInfosVector(builder, array);
			}
			return ILevelVoxelInfo.CreateILevelVoxelInfo(builder, _o.LevelId, entityVoxelInfosOffset);
		}

		// Token: 0x0400CC7E RID: 52350
		private Table __p;
	}
}
