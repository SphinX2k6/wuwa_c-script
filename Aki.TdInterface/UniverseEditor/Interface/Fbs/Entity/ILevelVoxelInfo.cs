using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C4F RID: 19535
	public struct ILevelVoxelInfo : IFlatbufferObject
	{
		// Token: 0x17008A95 RID: 35477
		// (get) Token: 0x0601DF5D RID: 122717 RVA: 0x004335C4 File Offset: 0x004317C4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DF5E RID: 122718 RVA: 0x004335D1 File Offset: 0x004317D1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DF5F RID: 122719 RVA: 0x004335D8 File Offset: 0x004317D8
		public static ILevelVoxelInfo GetRootAsILevelVoxelInfo(ByteBuffer _bb)
		{
			return ILevelVoxelInfo.GetRootAsILevelVoxelInfo(_bb, default(ILevelVoxelInfo));
		}

		// Token: 0x0601DF60 RID: 122720 RVA: 0x004335F4 File Offset: 0x004317F4
		public static ILevelVoxelInfo GetRootAsILevelVoxelInfo(ByteBuffer _bb, ILevelVoxelInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DF61 RID: 122721 RVA: 0x00433611 File Offset: 0x00431811
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DF62 RID: 122722 RVA: 0x00433620 File Offset: 0x00431820
		public ILevelVoxelInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008A96 RID: 35478
		// (get) Token: 0x0601DF63 RID: 122723 RVA: 0x00433630 File Offset: 0x00431830
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

		// Token: 0x0601DF64 RID: 122724 RVA: 0x0043366C File Offset: 0x0043186C
		public IEntityVoxelInfo? EntityVoxelInfos(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IEntityVoxelInfo?(default(IEntityVoxelInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008A97 RID: 35479
		// (get) Token: 0x0601DF65 RID: 122725 RVA: 0x004336CC File Offset: 0x004318CC
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

		// Token: 0x0601DF66 RID: 122726 RVA: 0x004336F7 File Offset: 0x004318F7
		public static Offset<ILevelVoxelInfo> CreateILevelVoxelInfo(FlatBufferBuilder builder, int LevelId = 0, VectorOffset EntityVoxelInfosOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ILevelVoxelInfo.AddEntityVoxelInfos(builder, EntityVoxelInfosOffset);
			ILevelVoxelInfo.AddLevelId(builder, LevelId);
			return ILevelVoxelInfo.EndILevelVoxelInfo(builder);
		}

		// Token: 0x0601DF67 RID: 122727 RVA: 0x00433714 File Offset: 0x00431914
		public static void StartILevelVoxelInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601DF68 RID: 122728 RVA: 0x0043371D File Offset: 0x0043191D
		public static void AddLevelId(FlatBufferBuilder builder, int levelId)
		{
			builder.AddInt(0, levelId, 0);
		}

		// Token: 0x0601DF69 RID: 122729 RVA: 0x00433728 File Offset: 0x00431928
		public static void AddEntityVoxelInfos(FlatBufferBuilder builder, VectorOffset entityVoxelInfosOffset)
		{
			builder.AddOffset(1, entityVoxelInfosOffset.Value, 0);
		}

		// Token: 0x0601DF6A RID: 122730 RVA: 0x00433738 File Offset: 0x00431938
		public static VectorOffset CreateEntityVoxelInfosVector(FlatBufferBuilder builder, Offset<IEntityVoxelInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601DF6B RID: 122731 RVA: 0x00433778 File Offset: 0x00431978
		public static VectorOffset CreateEntityVoxelInfosVectorBlock(FlatBufferBuilder builder, Offset<IEntityVoxelInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityVoxelInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DF6C RID: 122732 RVA: 0x00433792 File Offset: 0x00431992
		public static VectorOffset CreateEntityVoxelInfosVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityVoxelInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityVoxelInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DF6D RID: 122733 RVA: 0x004337B0 File Offset: 0x004319B0
		public static VectorOffset CreateEntityVoxelInfosVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityVoxelInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601DF6E RID: 122734 RVA: 0x004337C9 File Offset: 0x004319C9
		public static void StartEntityVoxelInfosVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601DF6F RID: 122735 RVA: 0x004337D4 File Offset: 0x004319D4
		public static Offset<ILevelVoxelInfo> EndILevelVoxelInfo(FlatBufferBuilder builder)
		{
			return new Offset<ILevelVoxelInfo>(builder.EndTable());
		}

		// Token: 0x0601DF70 RID: 122736 RVA: 0x004337E4 File Offset: 0x004319E4
		public ILevelVoxelInfoT UnPack()
		{
			ILevelVoxelInfoT levelVoxelInfoT = new ILevelVoxelInfoT();
			this.UnPackTo(levelVoxelInfoT);
			return levelVoxelInfoT;
		}

		// Token: 0x0601DF71 RID: 122737 RVA: 0x00433800 File Offset: 0x00431A00
		public void UnPackTo(ILevelVoxelInfoT _o)
		{
			_o.LevelId = this.LevelId;
			_o.EntityVoxelInfos = new List<IEntityVoxelInfoT>();
			for (int i = 0; i < this.EntityVoxelInfosLength; i++)
			{
				_o.EntityVoxelInfos.Add((this.EntityVoxelInfos(i) != null) ? this.EntityVoxelInfos(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601DF72 RID: 122738 RVA: 0x0043386C File Offset: 0x00431A6C
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

		// Token: 0x0400D6B9 RID: 54969
		private Table __p;
	}
}
