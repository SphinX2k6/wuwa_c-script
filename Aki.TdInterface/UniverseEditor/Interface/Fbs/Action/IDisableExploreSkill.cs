using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065E2 RID: 26082
	public struct IDisableExploreSkill : IFlatbufferObject
	{
		// Token: 0x1700C1A2 RID: 49570
		// (get) Token: 0x0602D3EE RID: 185326 RVA: 0x006336F8 File Offset: 0x006318F8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D3EF RID: 185327 RVA: 0x00633705 File Offset: 0x00631905
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D3F0 RID: 185328 RVA: 0x0063370C File Offset: 0x0063190C
		public static IDisableExploreSkill GetRootAsIDisableExploreSkill(ByteBuffer _bb)
		{
			return IDisableExploreSkill.GetRootAsIDisableExploreSkill(_bb, default(IDisableExploreSkill));
		}

		// Token: 0x0602D3F1 RID: 185329 RVA: 0x00633728 File Offset: 0x00631928
		public static IDisableExploreSkill GetRootAsIDisableExploreSkill(ByteBuffer _bb, IDisableExploreSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D3F2 RID: 185330 RVA: 0x00633745 File Offset: 0x00631945
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D3F3 RID: 185331 RVA: 0x00633754 File Offset: 0x00631954
		public IDisableExploreSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C1A3 RID: 49571
		// (get) Token: 0x0602D3F4 RID: 185332 RVA: 0x00633764 File Offset: 0x00631964
		public bool PlaceTemporaryTeleport
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C1A4 RID: 49572
		// (get) Token: 0x0602D3F5 RID: 185333 RVA: 0x006337A4 File Offset: 0x006319A4
		public bool IsComplementary
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602D3F6 RID: 185334 RVA: 0x006337E4 File Offset: 0x006319E4
		public EExploreSkillType ExploreSkillList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return EExploreSkillType.None;
			}
			return (EExploreSkillType)this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C1A5 RID: 49573
		// (get) Token: 0x0602D3F7 RID: 185335 RVA: 0x00633824 File Offset: 0x00631A24
		public int ExploreSkillListLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602D3F8 RID: 185336 RVA: 0x0063384F File Offset: 0x00631A4F
		public Span<EExploreSkillType> GetExploreSkillListBytes()
		{
			return this.__p.__vector_as_span<EExploreSkillType>(8, 4);
		}

		// Token: 0x0602D3F9 RID: 185337 RVA: 0x00633860 File Offset: 0x00631A60
		public EExploreSkillType[] GetExploreSkillListArray()
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			EExploreSkillType[] array = new EExploreSkillType[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (EExploreSkillType)this.__p.bb.GetInt(num2 + i * 4);
			}
			return array;
		}

		// Token: 0x1700C1A6 RID: 49574
		// (get) Token: 0x0602D3FA RID: 185338 RVA: 0x006338CC File Offset: 0x00631ACC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D3FB RID: 185339 RVA: 0x00633909 File Offset: 0x00631B09
		public static Offset<IDisableExploreSkill> CreateIDisableExploreSkill(FlatBufferBuilder builder, bool PlaceTemporaryTeleport = false, bool IsComplementary = false, VectorOffset ExploreSkillListOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IDisableExploreSkill.AddExploreSkillList(builder, ExploreSkillListOffset);
			IDisableExploreSkill.AddNullMask(builder, NullMask);
			IDisableExploreSkill.AddIsComplementary(builder, IsComplementary);
			IDisableExploreSkill.AddPlaceTemporaryTeleport(builder, PlaceTemporaryTeleport);
			return IDisableExploreSkill.EndIDisableExploreSkill(builder);
		}

		// Token: 0x0602D3FC RID: 185340 RVA: 0x00633935 File Offset: 0x00631B35
		public static void StartIDisableExploreSkill(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602D3FD RID: 185341 RVA: 0x0063393E File Offset: 0x00631B3E
		public static void AddPlaceTemporaryTeleport(FlatBufferBuilder builder, bool placeTemporaryTeleport)
		{
			builder.AddBool(0, placeTemporaryTeleport, false);
		}

		// Token: 0x0602D3FE RID: 185342 RVA: 0x00633949 File Offset: 0x00631B49
		public static void AddIsComplementary(FlatBufferBuilder builder, bool isComplementary)
		{
			builder.AddBool(1, isComplementary, false);
		}

		// Token: 0x0602D3FF RID: 185343 RVA: 0x00633954 File Offset: 0x00631B54
		public static void AddExploreSkillList(FlatBufferBuilder builder, VectorOffset exploreSkillListOffset)
		{
			builder.AddOffset(2, exploreSkillListOffset.Value, 0);
		}

		// Token: 0x0602D400 RID: 185344 RVA: 0x00633964 File Offset: 0x00631B64
		public static VectorOffset CreateExploreSkillListVector(FlatBufferBuilder builder, EExploreSkillType[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt((int)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602D401 RID: 185345 RVA: 0x0063399B File Offset: 0x00631B9B
		public static VectorOffset CreateExploreSkillListVectorBlock(FlatBufferBuilder builder, EExploreSkillType[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<EExploreSkillType>(data);
			return builder.EndVector();
		}

		// Token: 0x0602D402 RID: 185346 RVA: 0x006339B5 File Offset: 0x00631BB5
		public static VectorOffset CreateExploreSkillListVectorBlock(FlatBufferBuilder builder, ArraySegment<EExploreSkillType> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<EExploreSkillType>(data);
			return builder.EndVector();
		}

		// Token: 0x0602D403 RID: 185347 RVA: 0x006339D3 File Offset: 0x00631BD3
		public static VectorOffset CreateExploreSkillListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<EExploreSkillType>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602D404 RID: 185348 RVA: 0x006339EC File Offset: 0x00631BEC
		public static void StartExploreSkillListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602D405 RID: 185349 RVA: 0x006339F7 File Offset: 0x00631BF7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602D406 RID: 185350 RVA: 0x00633A02 File Offset: 0x00631C02
		public static Offset<IDisableExploreSkill> EndIDisableExploreSkill(FlatBufferBuilder builder)
		{
			return new Offset<IDisableExploreSkill>(builder.EndTable());
		}

		// Token: 0x0602D407 RID: 185351 RVA: 0x00633A10 File Offset: 0x00631C10
		public IDisableExploreSkillT UnPack()
		{
			IDisableExploreSkillT disableExploreSkillT = new IDisableExploreSkillT();
			this.UnPackTo(disableExploreSkillT);
			return disableExploreSkillT;
		}

		// Token: 0x0602D408 RID: 185352 RVA: 0x00633A2C File Offset: 0x00631C2C
		public void UnPackTo(IDisableExploreSkillT _o)
		{
			_o.PlaceTemporaryTeleport = this.PlaceTemporaryTeleport;
			_o.IsComplementary = this.IsComplementary;
			_o.ExploreSkillList = new List<EExploreSkillType>();
			for (int i = 0; i < this.ExploreSkillListLength; i++)
			{
				_o.ExploreSkillList.Add(this.ExploreSkillList(i));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602D409 RID: 185353 RVA: 0x00633A8C File Offset: 0x00631C8C
		public static Offset<IDisableExploreSkill> Pack(FlatBufferBuilder builder, IDisableExploreSkillT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDisableExploreSkill>);
			}
			VectorOffset exploreSkillListOffset = default(VectorOffset);
			if (_o.ExploreSkillList != null)
			{
				EExploreSkillType[] data = _o.ExploreSkillList.ToArray();
				exploreSkillListOffset = IDisableExploreSkill.CreateExploreSkillListVector(builder, data);
			}
			return IDisableExploreSkill.CreateIDisableExploreSkill(builder, _o.PlaceTemporaryTeleport, _o.IsComplementary, exploreSkillListOffset, _o.NullMask);
		}

		// Token: 0x04010C4F RID: 68687
		private Table __p;
	}
}
