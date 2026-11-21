using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C4A RID: 27722
	public struct IDisableExploreSkill : IFlatbufferObject
	{
		// Token: 0x1700CB31 RID: 52017
		// (get) Token: 0x0602FB72 RID: 195442 RVA: 0x0067F8BC File Offset: 0x0067DABC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FB73 RID: 195443 RVA: 0x0067F8C9 File Offset: 0x0067DAC9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FB74 RID: 195444 RVA: 0x0067F8D0 File Offset: 0x0067DAD0
		public static IDisableExploreSkill GetRootAsIDisableExploreSkill(ByteBuffer _bb)
		{
			return IDisableExploreSkill.GetRootAsIDisableExploreSkill(_bb, default(IDisableExploreSkill));
		}

		// Token: 0x0602FB75 RID: 195445 RVA: 0x0067F8EC File Offset: 0x0067DAEC
		public static IDisableExploreSkill GetRootAsIDisableExploreSkill(ByteBuffer _bb, IDisableExploreSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FB76 RID: 195446 RVA: 0x0067F909 File Offset: 0x0067DB09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FB77 RID: 195447 RVA: 0x0067F918 File Offset: 0x0067DB18
		public IDisableExploreSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CB32 RID: 52018
		// (get) Token: 0x0602FB78 RID: 195448 RVA: 0x0067F928 File Offset: 0x0067DB28
		public bool PlaceTemporaryTeleport
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CB33 RID: 52019
		// (get) Token: 0x0602FB79 RID: 195449 RVA: 0x0067F968 File Offset: 0x0067DB68
		public bool IsComplementary
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602FB7A RID: 195450 RVA: 0x0067F9A8 File Offset: 0x0067DBA8
		public EExploreSkillType ExploreSkillList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return EExploreSkillType.None;
			}
			return (EExploreSkillType)this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700CB34 RID: 52020
		// (get) Token: 0x0602FB7B RID: 195451 RVA: 0x0067F9E8 File Offset: 0x0067DBE8
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

		// Token: 0x0602FB7C RID: 195452 RVA: 0x0067FA13 File Offset: 0x0067DC13
		public Span<EExploreSkillType> GetExploreSkillListBytes()
		{
			return this.__p.__vector_as_span<EExploreSkillType>(8, 4);
		}

		// Token: 0x0602FB7D RID: 195453 RVA: 0x0067FA24 File Offset: 0x0067DC24
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

		// Token: 0x1700CB35 RID: 52021
		// (get) Token: 0x0602FB7E RID: 195454 RVA: 0x0067FA90 File Offset: 0x0067DC90
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

		// Token: 0x0602FB7F RID: 195455 RVA: 0x0067FACD File Offset: 0x0067DCCD
		public static Offset<IDisableExploreSkill> CreateIDisableExploreSkill(FlatBufferBuilder builder, bool PlaceTemporaryTeleport = false, bool IsComplementary = false, VectorOffset ExploreSkillListOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IDisableExploreSkill.AddExploreSkillList(builder, ExploreSkillListOffset);
			IDisableExploreSkill.AddNullMask(builder, NullMask);
			IDisableExploreSkill.AddIsComplementary(builder, IsComplementary);
			IDisableExploreSkill.AddPlaceTemporaryTeleport(builder, PlaceTemporaryTeleport);
			return IDisableExploreSkill.EndIDisableExploreSkill(builder);
		}

		// Token: 0x0602FB80 RID: 195456 RVA: 0x0067FAF9 File Offset: 0x0067DCF9
		public static void StartIDisableExploreSkill(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602FB81 RID: 195457 RVA: 0x0067FB02 File Offset: 0x0067DD02
		public static void AddPlaceTemporaryTeleport(FlatBufferBuilder builder, bool placeTemporaryTeleport)
		{
			builder.AddBool(0, placeTemporaryTeleport, false);
		}

		// Token: 0x0602FB82 RID: 195458 RVA: 0x0067FB0D File Offset: 0x0067DD0D
		public static void AddIsComplementary(FlatBufferBuilder builder, bool isComplementary)
		{
			builder.AddBool(1, isComplementary, false);
		}

		// Token: 0x0602FB83 RID: 195459 RVA: 0x0067FB18 File Offset: 0x0067DD18
		public static void AddExploreSkillList(FlatBufferBuilder builder, VectorOffset exploreSkillListOffset)
		{
			builder.AddOffset(2, exploreSkillListOffset.Value, 0);
		}

		// Token: 0x0602FB84 RID: 195460 RVA: 0x0067FB28 File Offset: 0x0067DD28
		public static VectorOffset CreateExploreSkillListVector(FlatBufferBuilder builder, EExploreSkillType[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt((int)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602FB85 RID: 195461 RVA: 0x0067FB5F File Offset: 0x0067DD5F
		public static VectorOffset CreateExploreSkillListVectorBlock(FlatBufferBuilder builder, EExploreSkillType[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<EExploreSkillType>(data);
			return builder.EndVector();
		}

		// Token: 0x0602FB86 RID: 195462 RVA: 0x0067FB79 File Offset: 0x0067DD79
		public static VectorOffset CreateExploreSkillListVectorBlock(FlatBufferBuilder builder, ArraySegment<EExploreSkillType> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<EExploreSkillType>(data);
			return builder.EndVector();
		}

		// Token: 0x0602FB87 RID: 195463 RVA: 0x0067FB97 File Offset: 0x0067DD97
		public static VectorOffset CreateExploreSkillListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<EExploreSkillType>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602FB88 RID: 195464 RVA: 0x0067FBB0 File Offset: 0x0067DDB0
		public static void StartExploreSkillListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602FB89 RID: 195465 RVA: 0x0067FBBB File Offset: 0x0067DDBB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602FB8A RID: 195466 RVA: 0x0067FBC6 File Offset: 0x0067DDC6
		public static Offset<IDisableExploreSkill> EndIDisableExploreSkill(FlatBufferBuilder builder)
		{
			return new Offset<IDisableExploreSkill>(builder.EndTable());
		}

		// Token: 0x0602FB8B RID: 195467 RVA: 0x0067FBD4 File Offset: 0x0067DDD4
		public IDisableExploreSkillT UnPack()
		{
			IDisableExploreSkillT disableExploreSkillT = new IDisableExploreSkillT();
			this.UnPackTo(disableExploreSkillT);
			return disableExploreSkillT;
		}

		// Token: 0x0602FB8C RID: 195468 RVA: 0x0067FBF0 File Offset: 0x0067DDF0
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

		// Token: 0x0602FB8D RID: 195469 RVA: 0x0067FC50 File Offset: 0x0067DE50
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

		// Token: 0x04011A61 RID: 72289
		private Table __p;
	}
}
