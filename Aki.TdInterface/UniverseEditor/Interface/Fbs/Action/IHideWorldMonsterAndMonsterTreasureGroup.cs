using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006915 RID: 26901
	public struct IHideWorldMonsterAndMonsterTreasureGroup : IFlatbufferObject
	{
		// Token: 0x1700C79D RID: 51101
		// (get) Token: 0x0602EF5C RID: 192348 RVA: 0x00667711 File Offset: 0x00665911
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EF5D RID: 192349 RVA: 0x0066771E File Offset: 0x0066591E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EF5E RID: 192350 RVA: 0x00667728 File Offset: 0x00665928
		public static IHideWorldMonsterAndMonsterTreasureGroup GetRootAsIHideWorldMonsterAndMonsterTreasureGroup(ByteBuffer _bb)
		{
			return IHideWorldMonsterAndMonsterTreasureGroup.GetRootAsIHideWorldMonsterAndMonsterTreasureGroup(_bb, default(IHideWorldMonsterAndMonsterTreasureGroup));
		}

		// Token: 0x0602EF5F RID: 192351 RVA: 0x00667744 File Offset: 0x00665944
		public static IHideWorldMonsterAndMonsterTreasureGroup GetRootAsIHideWorldMonsterAndMonsterTreasureGroup(ByteBuffer _bb, IHideWorldMonsterAndMonsterTreasureGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EF60 RID: 192352 RVA: 0x00667761 File Offset: 0x00665961
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EF61 RID: 192353 RVA: 0x00667770 File Offset: 0x00665970
		public IHideWorldMonsterAndMonsterTreasureGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C79E RID: 51102
		// (get) Token: 0x0602EF62 RID: 192354 RVA: 0x00667780 File Offset: 0x00665980
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

		// Token: 0x0602EF63 RID: 192355 RVA: 0x006677BC File Offset: 0x006659BC
		public int HideRangeEntities(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C79F RID: 51103
		// (get) Token: 0x0602EF64 RID: 192356 RVA: 0x006677FC File Offset: 0x006659FC
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

		// Token: 0x0602EF65 RID: 192357 RVA: 0x00667827 File Offset: 0x00665A27
		public Span<int> GetHideRangeEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0602EF66 RID: 192358 RVA: 0x00667836 File Offset: 0x00665A36
		public int[] GetHideRangeEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x0602EF67 RID: 192359 RVA: 0x00667844 File Offset: 0x00665A44
		public static Offset<IHideWorldMonsterAndMonsterTreasureGroup> CreateIHideWorldMonsterAndMonsterTreasureGroup(FlatBufferBuilder builder, EHideType Type = EHideType.WorldMonsterAndMonsterTreasure, VectorOffset HideRangeEntitiesOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IHideWorldMonsterAndMonsterTreasureGroup.AddHideRangeEntities(builder, HideRangeEntitiesOffset);
			IHideWorldMonsterAndMonsterTreasureGroup.AddType(builder, Type);
			return IHideWorldMonsterAndMonsterTreasureGroup.EndIHideWorldMonsterAndMonsterTreasureGroup(builder);
		}

		// Token: 0x0602EF68 RID: 192360 RVA: 0x00667861 File Offset: 0x00665A61
		public static void StartIHideWorldMonsterAndMonsterTreasureGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602EF69 RID: 192361 RVA: 0x0066786A File Offset: 0x00665A6A
		public static void AddType(FlatBufferBuilder builder, EHideType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602EF6A RID: 192362 RVA: 0x00667875 File Offset: 0x00665A75
		public static void AddHideRangeEntities(FlatBufferBuilder builder, VectorOffset hideRangeEntitiesOffset)
		{
			builder.AddOffset(1, hideRangeEntitiesOffset.Value, 0);
		}

		// Token: 0x0602EF6B RID: 192363 RVA: 0x00667888 File Offset: 0x00665A88
		public static VectorOffset CreateHideRangeEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602EF6C RID: 192364 RVA: 0x006678BF File Offset: 0x00665ABF
		public static VectorOffset CreateHideRangeEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602EF6D RID: 192365 RVA: 0x006678D9 File Offset: 0x00665AD9
		public static VectorOffset CreateHideRangeEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602EF6E RID: 192366 RVA: 0x006678F7 File Offset: 0x00665AF7
		public static VectorOffset CreateHideRangeEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602EF6F RID: 192367 RVA: 0x00667910 File Offset: 0x00665B10
		public static void StartHideRangeEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602EF70 RID: 192368 RVA: 0x0066791B File Offset: 0x00665B1B
		public static Offset<IHideWorldMonsterAndMonsterTreasureGroup> EndIHideWorldMonsterAndMonsterTreasureGroup(FlatBufferBuilder builder)
		{
			return new Offset<IHideWorldMonsterAndMonsterTreasureGroup>(builder.EndTable());
		}

		// Token: 0x0602EF71 RID: 192369 RVA: 0x00667928 File Offset: 0x00665B28
		public IHideWorldMonsterAndMonsterTreasureGroupT UnPack()
		{
			IHideWorldMonsterAndMonsterTreasureGroupT hideWorldMonsterAndMonsterTreasureGroupT = new IHideWorldMonsterAndMonsterTreasureGroupT();
			this.UnPackTo(hideWorldMonsterAndMonsterTreasureGroupT);
			return hideWorldMonsterAndMonsterTreasureGroupT;
		}

		// Token: 0x0602EF72 RID: 192370 RVA: 0x00667944 File Offset: 0x00665B44
		public void UnPackTo(IHideWorldMonsterAndMonsterTreasureGroupT _o)
		{
			_o.Type = this.Type;
			_o.HideRangeEntities = new List<int>();
			for (int i = 0; i < this.HideRangeEntitiesLength; i++)
			{
				_o.HideRangeEntities.Add(this.HideRangeEntities(i));
			}
		}

		// Token: 0x0602EF73 RID: 192371 RVA: 0x0066798C File Offset: 0x00665B8C
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

		// Token: 0x04011092 RID: 69778
		private Table __p;
	}
}
