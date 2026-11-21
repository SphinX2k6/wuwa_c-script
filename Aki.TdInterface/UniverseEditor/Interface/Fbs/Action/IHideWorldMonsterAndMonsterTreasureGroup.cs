using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FC8 RID: 28616
	public struct IHideWorldMonsterAndMonsterTreasureGroup : IFlatbufferObject
	{
		// Token: 0x1700D1A0 RID: 53664
		// (get) Token: 0x0603192C RID: 203052 RVA: 0x006B7BF9 File Offset: 0x006B5DF9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603192D RID: 203053 RVA: 0x006B7C06 File Offset: 0x006B5E06
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603192E RID: 203054 RVA: 0x006B7C10 File Offset: 0x006B5E10
		public static IHideWorldMonsterAndMonsterTreasureGroup GetRootAsIHideWorldMonsterAndMonsterTreasureGroup(ByteBuffer _bb)
		{
			return IHideWorldMonsterAndMonsterTreasureGroup.GetRootAsIHideWorldMonsterAndMonsterTreasureGroup(_bb, default(IHideWorldMonsterAndMonsterTreasureGroup));
		}

		// Token: 0x0603192F RID: 203055 RVA: 0x006B7C2C File Offset: 0x006B5E2C
		public static IHideWorldMonsterAndMonsterTreasureGroup GetRootAsIHideWorldMonsterAndMonsterTreasureGroup(ByteBuffer _bb, IHideWorldMonsterAndMonsterTreasureGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031930 RID: 203056 RVA: 0x006B7C49 File Offset: 0x006B5E49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031931 RID: 203057 RVA: 0x006B7C58 File Offset: 0x006B5E58
		public IHideWorldMonsterAndMonsterTreasureGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D1A1 RID: 53665
		// (get) Token: 0x06031932 RID: 203058 RVA: 0x006B7C68 File Offset: 0x006B5E68
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

		// Token: 0x06031933 RID: 203059 RVA: 0x006B7CA4 File Offset: 0x006B5EA4
		public int HideRangeEntities(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D1A2 RID: 53666
		// (get) Token: 0x06031934 RID: 203060 RVA: 0x006B7CE4 File Offset: 0x006B5EE4
		public int HideRangeEntitiesLength
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

		// Token: 0x06031935 RID: 203061 RVA: 0x006B7D0F File Offset: 0x006B5F0F
		public Span<int> GetHideRangeEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06031936 RID: 203062 RVA: 0x006B7D1E File Offset: 0x006B5F1E
		public int[] GetHideRangeEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x06031937 RID: 203063 RVA: 0x006B7D2C File Offset: 0x006B5F2C
		public static Offset<IHideWorldMonsterAndMonsterTreasureGroup> CreateIHideWorldMonsterAndMonsterTreasureGroup(FlatBufferBuilder builder, EHideType Type = EHideType.WorldMonsterAndMonsterTreasure, VectorOffset HideRangeEntitiesOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IHideWorldMonsterAndMonsterTreasureGroup.AddHideRangeEntities(builder, HideRangeEntitiesOffset);
			IHideWorldMonsterAndMonsterTreasureGroup.AddType(builder, Type);
			return IHideWorldMonsterAndMonsterTreasureGroup.EndIHideWorldMonsterAndMonsterTreasureGroup(builder);
		}

		// Token: 0x06031938 RID: 203064 RVA: 0x006B7D49 File Offset: 0x006B5F49
		public static void StartIHideWorldMonsterAndMonsterTreasureGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031939 RID: 203065 RVA: 0x006B7D52 File Offset: 0x006B5F52
		public static void AddType(FlatBufferBuilder builder, EHideType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603193A RID: 203066 RVA: 0x006B7D5D File Offset: 0x006B5F5D
		public static void AddHideRangeEntities(FlatBufferBuilder builder, VectorOffset hideRangeEntitiesOffset)
		{
			builder.AddOffset(1, hideRangeEntitiesOffset.Value, 0);
		}

		// Token: 0x0603193B RID: 203067 RVA: 0x006B7D70 File Offset: 0x006B5F70
		public static VectorOffset CreateHideRangeEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0603193C RID: 203068 RVA: 0x006B7DA7 File Offset: 0x006B5FA7
		public static VectorOffset CreateHideRangeEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0603193D RID: 203069 RVA: 0x006B7DC1 File Offset: 0x006B5FC1
		public static VectorOffset CreateHideRangeEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0603193E RID: 203070 RVA: 0x006B7DDF File Offset: 0x006B5FDF
		public static VectorOffset CreateHideRangeEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603193F RID: 203071 RVA: 0x006B7DF8 File Offset: 0x006B5FF8
		public static void StartHideRangeEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06031940 RID: 203072 RVA: 0x006B7E03 File Offset: 0x006B6003
		public static Offset<IHideWorldMonsterAndMonsterTreasureGroup> EndIHideWorldMonsterAndMonsterTreasureGroup(FlatBufferBuilder builder)
		{
			return new Offset<IHideWorldMonsterAndMonsterTreasureGroup>(builder.EndTable());
		}

		// Token: 0x06031941 RID: 203073 RVA: 0x006B7E10 File Offset: 0x006B6010
		public IHideWorldMonsterAndMonsterTreasureGroupT UnPack()
		{
			IHideWorldMonsterAndMonsterTreasureGroupT hideWorldMonsterAndMonsterTreasureGroupT = new IHideWorldMonsterAndMonsterTreasureGroupT();
			this.UnPackTo(hideWorldMonsterAndMonsterTreasureGroupT);
			return hideWorldMonsterAndMonsterTreasureGroupT;
		}

		// Token: 0x06031942 RID: 203074 RVA: 0x006B7E2C File Offset: 0x006B602C
		public void UnPackTo(IHideWorldMonsterAndMonsterTreasureGroupT _o)
		{
			_o.Type = this.Type;
			_o.HideRangeEntities = new List<int>();
			for (int i = 0; i < this.HideRangeEntitiesLength; i++)
			{
				_o.HideRangeEntities.Add(this.HideRangeEntities(i));
			}
		}

		// Token: 0x06031943 RID: 203075 RVA: 0x006B7E74 File Offset: 0x006B6074
		public static Offset<IHideWorldMonsterAndMonsterTreasureGroup> Pack(FlatBufferBuilder builder, IHideWorldMonsterAndMonsterTreasureGroupT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHideWorldMonsterAndMonsterTreasureGroup>);
			}
			VectorOffset hideRangeEntitiesOffset = default(VectorOffset);
			if (_o.HideRangeEntities != null)
			{
				int[] data = _o.HideRangeEntities.ToArray();
				hideRangeEntitiesOffset = IHideWorldMonsterAndMonsterTreasureGroup.CreateHideRangeEntitiesVector(builder, data);
			}
			return IHideWorldMonsterAndMonsterTreasureGroup.CreateIHideWorldMonsterAndMonsterTreasureGroup(builder, _o.Type, hideRangeEntitiesOffset);
		}

		// Token: 0x04011EFE RID: 73470
		private Table __p;
	}
}
