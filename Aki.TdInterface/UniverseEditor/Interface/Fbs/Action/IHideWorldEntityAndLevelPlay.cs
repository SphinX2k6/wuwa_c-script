using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FBF RID: 28607
	public struct IHideWorldEntityAndLevelPlay : IFlatbufferObject
	{
		// Token: 0x1700D187 RID: 53639
		// (get) Token: 0x060318A6 RID: 202918 RVA: 0x006B6C34 File Offset: 0x006B4E34
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060318A7 RID: 202919 RVA: 0x006B6C41 File Offset: 0x006B4E41
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060318A8 RID: 202920 RVA: 0x006B6C48 File Offset: 0x006B4E48
		public static IHideWorldEntityAndLevelPlay GetRootAsIHideWorldEntityAndLevelPlay(ByteBuffer _bb)
		{
			return IHideWorldEntityAndLevelPlay.GetRootAsIHideWorldEntityAndLevelPlay(_bb, default(IHideWorldEntityAndLevelPlay));
		}

		// Token: 0x060318A9 RID: 202921 RVA: 0x006B6C64 File Offset: 0x006B4E64
		public static IHideWorldEntityAndLevelPlay GetRootAsIHideWorldEntityAndLevelPlay(ByteBuffer _bb, IHideWorldEntityAndLevelPlay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060318AA RID: 202922 RVA: 0x006B6C81 File Offset: 0x006B4E81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060318AB RID: 202923 RVA: 0x006B6C90 File Offset: 0x006B4E90
		public IHideWorldEntityAndLevelPlay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D188 RID: 53640
		// (get) Token: 0x060318AC RID: 202924 RVA: 0x006B6CA0 File Offset: 0x006B4EA0
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

		// Token: 0x060318AD RID: 202925 RVA: 0x006B6CDC File Offset: 0x006B4EDC
		public int ExcludeEntities(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D189 RID: 53641
		// (get) Token: 0x060318AE RID: 202926 RVA: 0x006B6D1C File Offset: 0x006B4F1C
		public int ExcludeEntitiesLength
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

		// Token: 0x060318AF RID: 202927 RVA: 0x006B6D47 File Offset: 0x006B4F47
		public Span<int> GetExcludeEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x060318B0 RID: 202928 RVA: 0x006B6D56 File Offset: 0x006B4F56
		public int[] GetExcludeEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700D18A RID: 53642
		// (get) Token: 0x060318B1 RID: 202929 RVA: 0x006B6D64 File Offset: 0x006B4F64
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060318B2 RID: 202930 RVA: 0x006B6DA0 File Offset: 0x006B4FA0
		public static Offset<IHideWorldEntityAndLevelPlay> CreateIHideWorldEntityAndLevelPlay(FlatBufferBuilder builder, EHideType Type = EHideType.WorldMonsterAndMonsterTreasure, VectorOffset ExcludeEntitiesOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IHideWorldEntityAndLevelPlay.AddExcludeEntities(builder, ExcludeEntitiesOffset);
			IHideWorldEntityAndLevelPlay.AddNullMask(builder, NullMask);
			IHideWorldEntityAndLevelPlay.AddType(builder, Type);
			return IHideWorldEntityAndLevelPlay.EndIHideWorldEntityAndLevelPlay(builder);
		}

		// Token: 0x060318B3 RID: 202931 RVA: 0x006B6DC4 File Offset: 0x006B4FC4
		public static void StartIHideWorldEntityAndLevelPlay(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060318B4 RID: 202932 RVA: 0x006B6DCD File Offset: 0x006B4FCD
		public static void AddType(FlatBufferBuilder builder, EHideType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060318B5 RID: 202933 RVA: 0x006B6DD8 File Offset: 0x006B4FD8
		public static void AddExcludeEntities(FlatBufferBuilder builder, VectorOffset excludeEntitiesOffset)
		{
			builder.AddOffset(1, excludeEntitiesOffset.Value, 0);
		}

		// Token: 0x060318B6 RID: 202934 RVA: 0x006B6DE8 File Offset: 0x006B4FE8
		public static VectorOffset CreateExcludeEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060318B7 RID: 202935 RVA: 0x006B6E1F File Offset: 0x006B501F
		public static VectorOffset CreateExcludeEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060318B8 RID: 202936 RVA: 0x006B6E39 File Offset: 0x006B5039
		public static VectorOffset CreateExcludeEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060318B9 RID: 202937 RVA: 0x006B6E57 File Offset: 0x006B5057
		public static VectorOffset CreateExcludeEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060318BA RID: 202938 RVA: 0x006B6E70 File Offset: 0x006B5070
		public static void StartExcludeEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060318BB RID: 202939 RVA: 0x006B6E7B File Offset: 0x006B507B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060318BC RID: 202940 RVA: 0x006B6E86 File Offset: 0x006B5086
		public static Offset<IHideWorldEntityAndLevelPlay> EndIHideWorldEntityAndLevelPlay(FlatBufferBuilder builder)
		{
			return new Offset<IHideWorldEntityAndLevelPlay>(builder.EndTable());
		}

		// Token: 0x060318BD RID: 202941 RVA: 0x006B6E94 File Offset: 0x006B5094
		public IHideWorldEntityAndLevelPlayT UnPack()
		{
			IHideWorldEntityAndLevelPlayT hideWorldEntityAndLevelPlayT = new IHideWorldEntityAndLevelPlayT();
			this.UnPackTo(hideWorldEntityAndLevelPlayT);
			return hideWorldEntityAndLevelPlayT;
		}

		// Token: 0x060318BE RID: 202942 RVA: 0x006B6EB0 File Offset: 0x006B50B0
		public void UnPackTo(IHideWorldEntityAndLevelPlayT _o)
		{
			_o.Type = this.Type;
			_o.ExcludeEntities = new List<int>();
			for (int i = 0; i < this.ExcludeEntitiesLength; i++)
			{
				_o.ExcludeEntities.Add(this.ExcludeEntities(i));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060318BF RID: 202943 RVA: 0x006B6F04 File Offset: 0x006B5104
		public static Offset<IHideWorldEntityAndLevelPlay> Pack(FlatBufferBuilder builder, IHideWorldEntityAndLevelPlayT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHideWorldEntityAndLevelPlay>);
			}
			VectorOffset excludeEntitiesOffset = default(VectorOffset);
			if (_o.ExcludeEntities != null)
			{
				int[] data = _o.ExcludeEntities.ToArray();
				excludeEntitiesOffset = IHideWorldEntityAndLevelPlay.CreateExcludeEntitiesVector(builder, data);
			}
			return IHideWorldEntityAndLevelPlay.CreateIHideWorldEntityAndLevelPlay(builder, _o.Type, excludeEntitiesOffset, _o.NullMask);
		}

		// Token: 0x04011EF0 RID: 73456
		private Table __p;
	}
}
